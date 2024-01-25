Imports System.ComponentModel
Imports Procesos

Public Class frmReservaFacturaNuevoCliente
    Private _TareasDetalleReserva As TareasPedidosDetalle
    Private _TareasFacturaVentaDetalle As TareasFacturaVentaDetalle

    Private DetallesPedido As List(Of PedidosDetalle)

    Private FacturaVentaDetalle As List(Of FacturaVentaDetalle)

    Public Property infoDetalleReserva As PedidosDetalle
    Public Property infoDetalleFactura As FacturaVentaDetalle
    Public Property fijarCantRet As Dictionary(Of Integer, Double)
    Public Property fijarStockFisico As Dictionary(Of frmRemitoVenta.CKey, Double)
    Public Property fijarDetPed As List(Of PedidosDetalle)
    Public Property fijarDetFac As List(Of FacturaVentaDetalle)

#Region "ANIMACIONES BOTONES"
    Private Sub btnNuevo_GotFocus(sender As Object, e As EventArgs) Handles btnNuevo.GotFocus
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevo_LostFocus(sender As Object, e As EventArgs) Handles btnNuevo.LostFocus
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnNuevo_MouseEnter(sender As Object, e As EventArgs) Handles btnNuevo.MouseEnter
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevo.MouseLeave
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub
#End Region

#Region "LOAD"
    Private Sub frmListaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _TareasDetalleReserva = New TareasPedidosDetalle()
        _TareasFacturaVentaDetalle = New TareasFacturaVentaDetalle()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrDgvs_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        UtilidadesDGV.FormatoDGVGeneral(dgvDetalle)
        UtilidadesDGV.FormatoDGVGeneral(dgvPedidos)
        UtilidadesDGV.FormatoDGVGeneral(dgvFacturas)

        ConfigDGV_DETALLE()
        ConfigDGV_PEDIDOS()
        ConfigDGV_FACTURAS()

        UtilidadesDGV.DescargarDGV(dgvDetalle)
        UtilidadesDGV.DescargarDGV(dgvPedidos)
        UtilidadesDGV.DescargarDGV(dgvFacturas)

        DetallesPedido = Await _TareasDetalleReserva.verDetalleReservaSinRemitarIdCliente(frmRemitoVenta.txtCtaCli.Text)
        FacturaVentaDetalle = Await _TareasFacturaVentaDetalle.verFacturasVentaDetalleSinRemitarIdCliente(frmRemitoVenta.txtCtaCli.Text)

        If Not IsNothing(fijarDetPed) Then
            If IsNothing(DetallesPedido) Then
                DetallesPedido = New List(Of PedidosDetalle)
            End If

            For Each Item In fijarDetPed
                DetallesPedido.Add(Item)
            Next
        End If

        If Not IsNothing(fijarDetFac) Then
            If IsNothing(FacturaVentaDetalle) Then
                FacturaVentaDetalle = New List(Of FacturaVentaDetalle)
            End If

            For Each Item In fijarDetFac
                FacturaVentaDetalle.Add(Item)
            Next
        End If

        If Not IsNothing(DetallesPedido) Then
            For Each Item In DetallesPedido
                Dim Count As Double = CountCantidadRemitada_Reserva(Item.IdPedidosDetalle)
                Dim agg As Boolean = True

                If Item.Cantidad - Count > 0 Then
                    For Each row In dgvPedidos.Rows
                        If Item.AscPedidos.IdPedidos = row.Cells("idPedidos").Value Then
                            agg = False
                        End If
                    Next
                Else
                    agg = False
                End If

                If agg Then
                    dgvPedidos.Rows.Add(Item.AscPedidos.IdPedidos, Item.AscPedidos.AscUsuarios.IdUsuario,
                                        Format(Item.AscPedidos.Fecha, "dd/MM/yyyy"), Item.AscPedidos.NroPedido, Item.AscPedidos.Observaciones)
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvPedidos)
        ElseIf _TareasDetalleReserva.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasDetalleReserva.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If

        If Not IsNothing(FacturaVentaDetalle) Then
            For Each Item In FacturaVentaDetalle
                Dim Count As Double = CountCantidadRemitada_Factura(Item.IdFacturaVentaDetalle)
                Dim agg As Boolean = True

                If Item.Cantidad - Count > 0 Then
                    For Each row In dgvFacturas.Rows
                        If Item.AscFacturaVenta.IdFacturaVenta = row.Cells("idFacturaVenta").Value Then
                            agg = False
                        End If
                    Next
                Else
                    agg = False
                End If

                If agg Then
                    dgvFacturas.Rows.Add(Item.AscFacturaVenta.IdFacturaVenta, Item.AscFacturaVenta.AscUsuarios.IdUsuario,
                                            Format(Item.AscFacturaVenta.Fecha, "dd/MM/yyyy"), Item.AscFacturaVenta.ClaseComprobante,
                                            Item.AscFacturaVenta.Prefijo, Item.AscFacturaVenta.NroComprobante, Item.AscFacturaVenta.Observaciones)
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvFacturas)
        ElseIf _TareasFacturaVentaDetalle.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasFacturaVentaDetalle.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If

        Notificaciones.cerrarFormProceso()
        btnNuevo.Select()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDGV_DETALLE()
        dgvDetalle.ColumnCount = 5
        dgvDetalle.Columns(0).Name = "id"
        dgvDetalle.Columns(1).Name = "idArticulos"
        dgvDetalle.Columns(2).Name = "CodArticulo"
        dgvDetalle.Columns(3).Name = "Articulo"
        dgvDetalle.Columns(4).Name = "Saldo"

        dgvDetalle.Columns("id").Visible = False
        dgvDetalle.Columns("idArticulos").Visible = False

        dgvDetalle.Columns("CodArticulo").HeaderText = "CODIGO"
        dgvDetalle.Columns("Articulo").HeaderText = "ARTICULO"
        dgvDetalle.Columns("Saldo").HeaderText = "SALDO"

        dgvDetalle.Columns("id").DisplayIndex = 0
        dgvDetalle.Columns("idArticulos").DisplayIndex = 1
        dgvDetalle.Columns("CodArticulo").DisplayIndex = 2
        dgvDetalle.Columns("Articulo").DisplayIndex = 3
        dgvDetalle.Columns("Saldo").DisplayIndex = 4

        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvDetalle.Columns("Saldo").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvDetalle.Columns("CodArticulo").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub ConfigDGV_PEDIDOS()
        dgvPedidos.ColumnCount = 5
        dgvPedidos.Columns(0).Name = "idPedidos"
        dgvPedidos.Columns(1).Name = "idUsuarios"
        dgvPedidos.Columns(2).Name = "Fecha"
        dgvPedidos.Columns(3).Name = "NroPedido"
        dgvPedidos.Columns(4).Name = "Observaciones"

        dgvPedidos.Columns("idPedidos").Visible = False
        dgvPedidos.Columns("idUsuarios").Visible = False

        dgvPedidos.Columns("Fecha").HeaderText = "FECHA"
        dgvPedidos.Columns("NroPedido").HeaderText = "NRO RESERVA"
        dgvPedidos.Columns("Observaciones").HeaderText = "OBSERVACIONES"

        dgvPedidos.Columns("idPedidos").DisplayIndex = 0
        dgvPedidos.Columns("idUsuarios").DisplayIndex = 1
        dgvPedidos.Columns("Fecha").DisplayIndex = 2
        dgvPedidos.Columns("NroPedido").DisplayIndex = 3
        dgvPedidos.Columns("Observaciones").DisplayIndex = 4

        dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvPedidos.Columns("Fecha").Width = 100

        dgvPedidos.Sort(dgvPedidos.Columns("Fecha"), ListSortDirection.Ascending)
    End Sub

    Private Sub ConfigDGV_FACTURAS()
        dgvFacturas.ColumnCount = 7
        dgvFacturas.Columns(0).Name = "idFacturaVenta"
        dgvFacturas.Columns(1).Name = "idUsuarios"
        dgvFacturas.Columns(2).Name = "Fecha"
        dgvFacturas.Columns(3).Name = "ClaseComprobante"
        dgvFacturas.Columns(4).Name = "Prefijo"
        dgvFacturas.Columns(5).Name = "NroComprobante"
        dgvFacturas.Columns(6).Name = "Observaciones"

        dgvFacturas.Columns("idFacturaVenta").Visible = False
        dgvFacturas.Columns("idUsuarios").Visible = False

        dgvFacturas.Columns("Fecha").HeaderText = "FECHA"
        dgvFacturas.Columns("NroComprobante").HeaderText = "NRO COMPROBANTE"
        dgvFacturas.Columns("Observaciones").HeaderText = "OBSERVACIONES"
        dgvFacturas.Columns("ClaseComprobante").HeaderText = "TIPO"
        dgvFacturas.Columns("Prefijo").HeaderText = "PREFIJO"

        dgvFacturas.Columns("idFacturaVenta").DisplayIndex = 0
        dgvFacturas.Columns("idUsuarios").DisplayIndex = 1
        dgvFacturas.Columns("Fecha").DisplayIndex = 2
        dgvFacturas.Columns("ClaseComprobante").DisplayIndex = 3
        dgvFacturas.Columns("Prefijo").DisplayIndex = 4
        dgvFacturas.Columns("NroComprobante").DisplayIndex = 5
        dgvFacturas.Columns("Observaciones").DisplayIndex = 6

        dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvFacturas.Columns("Fecha").Width = 100
        dgvFacturas.Columns("ClaseComprobante").Width = 40

        dgvFacturas.Sort(dgvFacturas.Columns("Fecha"), ListSortDirection.Ascending)
    End Sub

    Private Function CountCantidadRemitada_Reserva(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmRemitoVenta.dgvDetalleRemito.Rows
            If id = item.Cells("idPedidosDetalle").Value Then
                Count += UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
            End If
        Next

        Return Count
    End Function

    Private Function CountCantidadRemitada_Factura(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmRemitoVenta.dgvDetalleRemito.Rows
            If id = item.Cells("idFacturaDetalle").Value Then
                Count += UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
            End If
        Next

        Return Count
    End Function
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub dgvDetalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellDoubleClick
        If e.RowIndex > -1 Then
            Dim Result As DialogResult

            If Not IsNothing(dgvPedidos.CurrentCell) Then
                infoDetalleReserva = New PedidosDetalle With {
                    .IdPedidosDetalle = dgvDetalle.CurrentRow.Cells("id").Value,
                    .Cantidad = dgvDetalle.CurrentRow.Cells("Saldo").Value,
                    .AscArticulos = New Articulos With {
                        .IdArticulo = dgvDetalle.CurrentRow.Cells("idArticulos").Value,
                        .CodArticulo = dgvDetalle.CurrentRow.Cells("CodArticulo").Value,
                        .Detalle = dgvDetalle.CurrentRow.Cells("Articulo").Value
                    },
                    .AscPedidos = New Pedidos With {.IdPedidos = dgvPedidos.CurrentRow.Cells("idPedidos").Value}
                }

                frmArticuloRemitoVentaReserva.Dispose()
                UtilidadesVarias.Escalar(frmArticuloRemitoVentaReserva)
                frmArticuloRemitoVentaReserva.fijarStockFisico = fijarStockFisico

                frmArticuloRemitoVentaReserva.txtOrigen.Text = "Agregar"

                Result = frmArticuloRemitoVentaReserva.ShowDialog()
            ElseIf Not IsNothing(dgvFacturas.CurrentCell) Then
                infoDetalleFactura = New FacturaVentaDetalle With {
                    .IdFacturaVentaDetalle = dgvDetalle.CurrentRow.Cells("id").Value,
                    .Cantidad = dgvDetalle.CurrentRow.Cells("Saldo").Value,
                    .AscArticulos = New Articulos With {
                        .IdArticulo = dgvDetalle.CurrentRow.Cells("idArticulos").Value,
                        .CodArticulo = dgvDetalle.CurrentRow.Cells("CodArticulo").Value,
                        .Detalle = dgvDetalle.CurrentRow.Cells("Articulo").Value
                    },
                    .AscFacturaVenta = New FacturaVenta With {.IdFacturaVenta = dgvFacturas.CurrentRow.Cells("idFacturaVenta").Value}
                }

                frmArticuloRemitoVentaFactura.Dispose()
                UtilidadesVarias.Escalar(frmArticuloRemitoVentaFactura)
                frmArticuloRemitoVentaFactura.fijarStockFisico = fijarStockFisico

                frmArticuloRemitoVentaFactura.txtOrigen.Text = "Agregar"

                Result = frmArticuloRemitoVentaFactura.ShowDialog()
            End If

            If Result = DialogResult.OK Then
                Me.DialogResult = DialogResult.OK

                Me.Close()
            End If

            dgvDetalle.CurrentCell = Nothing
        Else
            dgvDetalle.CurrentCell = Nothing
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvPedidos.CurrentCell = Nothing
        dgvFacturas.CurrentCell = Nothing

        UtilidadesDGV.DescargarDGV(dgvDetalle)

        frmArticuloRemitoVentaNuevo.Dispose()
        UtilidadesVarias.Escalar(frmArticuloRemitoVentaNuevo)
        frmArticuloRemitoVentaNuevo.txtOrigen.Text = "Agregar"

        frmArticuloRemitoVentaNuevo.fijarStockFisico = fijarStockFisico

        Dim Result As DialogResult = frmArticuloRemitoVentaNuevo.ShowDialog()

        If Result = DialogResult.OK Then
            Me.DialogResult = DialogResult.OK

            Me.Close()
        End If

        dgvDetalle.CurrentCell = Nothing
    End Sub

    Private Sub dgvPedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        If e.RowIndex > -1 Then
            dgvFacturas.CurrentCell = Nothing
            UtilidadesDGV.DescargarDGV(dgvDetalle)

            For Each Item In DetallesPedido
                Dim Count As Double = CountCantidadRemitada_Reserva(Item.IdPedidosDetalle)

                If Not IsNothing(fijarCantRet) Then
                    If fijarCantRet.ContainsKey(Item.IdPedidosDetalle) Then
                        Count -= fijarCantRet(Item.IdPedidosDetalle)
                    End If
                End If

                If Item.AscPedidos.IdPedidos = dgvPedidos.CurrentRow.Cells("idPedidos").Value And Item.Cantidad - Count > 0 Then
                    dgvDetalle.Rows.Add(Item.IdPedidosDetalle, Item.AscArticulos.IdArticulo, Item.AscArticulos.CodArticulo, Item.AscArticulos.Detalle, Item.Cantidad - Count)

                    If Count <> 0 Then
                        dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells("Saldo").Style.ForeColor = Color.FromArgb(95, 150, 15)
                    End If
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        Else
            dgvPedidos.CurrentCell = Nothing

            UtilidadesDGV.DescargarDGV(dgvDetalle)
            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        End If
    End Sub

    Private Sub dgvFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturas.CellClick
        If e.RowIndex > -1 Then
            dgvPedidos.CurrentCell = Nothing
            UtilidadesDGV.DescargarDGV(dgvDetalle)

            For Each Item In FacturaVentaDetalle
                Dim Count As Double = CountCantidadRemitada_Factura(Item.IdFacturaVentaDetalle)

                If Not IsNothing(fijarCantRet) Then
                    If fijarCantRet.ContainsKey(Item.IdFacturaVentaDetalle) Then
                        Count -= fijarCantRet(Item.IdFacturaVentaDetalle)
                    End If
                End If

                If Item.AscFacturaVenta.IdFacturaVenta = dgvFacturas.CurrentRow.Cells("idFacturaVenta").Value And Item.Cantidad - Count > 0 Then
                    dgvDetalle.Rows.Add(Item.IdFacturaVentaDetalle, Item.AscArticulos.IdArticulo, Item.AscArticulos.CodArticulo, Item.AscArticulos.Detalle, Item.Cantidad - Count)

                    If Count <> 0 Then
                        dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells("Saldo").Style.ForeColor = Color.FromArgb(95, 150, 15)
                    End If
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        Else
            dgvFacturas.CurrentCell = Nothing

            UtilidadesDGV.DescargarDGV(dgvDetalle)
            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        End If
    End Sub
#End Region
End Class