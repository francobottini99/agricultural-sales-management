Imports System.ComponentModel
Imports Procesos

Public Class frmReservaRemitoNuevoCliente
    Private _TareasDetalleReserva As TareasPedidosDetalle
    Private _TareasDetalleRemito As TareasDetalleRemitoVenta
    Private DetallePedido As List(Of PedidosDetalle)
    Private DetalleRemito As List(Of DetalleRemitoVenta)

    Public Property infoDetalleReserva As PedidosDetalle
    Public Property infoDetalleRemito As DetalleRemitoVenta

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
        _TareasDetalleRemito = New TareasDetalleRemitoVenta()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrDgvs_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        UtilidadesDGV.FormatoDGVGeneral(dgvDetalle)
        UtilidadesDGV.FormatoDGVGeneral(dgvPedidos)
        UtilidadesDGV.FormatoDGVGeneral(dgvRemitos)

        ConfigDGV_PEDIDOS()
        ConfigDGV_REMITOS()
        ConfigDGV_DETALLE()

        UtilidadesDGV.DescargarDGV(dgvDetalle)
        UtilidadesDGV.DescargarDGV(dgvPedidos)
        UtilidadesDGV.DescargarDGV(dgvRemitos)

        DetallePedido = Await _TareasDetalleReserva.verDetalleReservaSinFacturarIdCliente(frmFacturaVenta.txtCtaCli.Text)
        DetalleRemito = Await _TareasDetalleRemito.verDetalleRemitosVentaSinFacturarIdCliente(frmFacturaVenta.txtCtaCli.Text)

        If Not IsNothing(DetallePedido) Then
            For Each Item In DetallePedido
                Dim Count As Double = CountCantidadFacturada_Reserva(Item.IdPedidosDetalle)
                Dim agg As Boolean = True

                If Count < Item.Cantidad Then
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

        If Not IsNothing(DetalleRemito) Then
            For Each Item In DetalleRemito
                Dim Count As Double = CountCantidadFacturada_Remito(Item.IdDetalleRemitosVenta)
                Dim agg As Boolean = True

                If Count < Item.Cantidad Then
                    For Each row In dgvRemitos.Rows
                        If Item.AscRemitosVenta.IdRemitosVenta = row.Cells("idRemitosVenta").Value Then
                            agg = False
                        End If
                    Next
                Else
                    agg = False
                End If

                If agg Then
                    dgvRemitos.Rows.Add(Item.AscRemitosVenta.IdRemitosVenta, Item.AscRemitosVenta.AscUsuarios.IdUsuario,
                                        Format(Item.AscRemitosVenta.Fecha, "dd/MM/yyyy"), Item.AscRemitosVenta.NroComprobante, Item.AscRemitosVenta.Observaciones)
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvRemitos)
        ElseIf _TareasDetalleRemito.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasDetalleRemito.Err.Descripcion, Botones.OK, Iconos.ERR)

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

    Private Sub ConfigDGV_REMITOS()
        dgvRemitos.ColumnCount = 5
        dgvRemitos.Columns(0).Name = "idRemitosVenta"
        dgvRemitos.Columns(1).Name = "idUsuarios"
        dgvRemitos.Columns(2).Name = "Fecha"
        dgvRemitos.Columns(3).Name = "NroComprobante"
        dgvRemitos.Columns(4).Name = "Observaciones"

        dgvRemitos.Columns("idRemitosVenta").Visible = False
        dgvRemitos.Columns("idUsuarios").Visible = False

        dgvRemitos.Columns("Fecha").HeaderText = "FECHA"
        dgvRemitos.Columns("NroComprobante").HeaderText = "NRO REMITO"
        dgvRemitos.Columns("Observaciones").HeaderText = "OBSERVACIONES"

        dgvRemitos.Columns("idRemitosVenta").DisplayIndex = 0
        dgvRemitos.Columns("idUsuarios").DisplayIndex = 1
        dgvRemitos.Columns("Fecha").DisplayIndex = 2
        dgvRemitos.Columns("NroComprobante").DisplayIndex = 3
        dgvRemitos.Columns("Observaciones").DisplayIndex = 4

        dgvRemitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvRemitos.Columns("Fecha").Width = 100

        dgvRemitos.Sort(dgvRemitos.Columns("Fecha"), ListSortDirection.Ascending)
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

    Private Function CountCantidadFacturada_Reserva(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmFacturaVenta.dgvDetalleFactura.Rows
            If id = item.Cells("idPedidosDetalle").Value Then
                Count += UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
            End If
        Next

        Return Count
    End Function

    Private Function CountCantidadFacturada_Remito(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmFacturaVenta.dgvDetalleFactura.Rows
            If id = item.Cells("idRemitoDetalle").Value Then
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

            If Not IsNothing(dgvRemitos.CurrentCell) Then
                infoDetalleRemito = New DetalleRemitoVenta With {
                    .IdDetalleRemitosVenta = dgvDetalle.CurrentRow.Cells("id").Value,
                    .Cantidad = dgvDetalle.CurrentRow.Cells("Saldo").Value,
                    .AscArticulos = New Articulos With {
                        .IdArticulo = dgvDetalle.CurrentRow.Cells("idArticulos").Value,
                        .CodArticulo = dgvDetalle.CurrentRow.Cells("CodArticulo").Value,
                        .Detalle = dgvDetalle.CurrentRow.Cells("Articulo").Value
                    },
                    .AscRemitosVenta = New RemitoVenta With {.IdRemitosVenta = dgvRemitos.CurrentRow.Cells("idRemitosVenta").Value}
                }

                frmArticuloFacturaVentaRemito.Dispose()

                UtilidadesVarias.Escalar(frmArticuloFacturaVentaRemito)

                frmArticuloFacturaVentaRemito.txtOrigen.Text = "Agregar"

                Result = frmArticuloFacturaVentaRemito.ShowDialog()
            ElseIf Not IsNothing(dgvPedidos.CurrentCell) Then
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

                frmArticuloFacturaVentaReserva.Dispose()

                UtilidadesVarias.Escalar(frmArticuloFacturaVentaReserva)

                frmArticuloFacturaVentaReserva.txtOrigen.Text = "Agregar"

                Result = frmArticuloFacturaVentaReserva.ShowDialog()
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
        dgvRemitos.CurrentCell = Nothing

        UtilidadesDGV.DescargarDGV(dgvDetalle)

        frmArticuloFacturaVentaNuevo.Dispose()

        UtilidadesVarias.Escalar(frmArticuloFacturaVentaNuevo)

        frmArticuloFacturaVentaNuevo.txtOrigen.Text = "Agregar"

        Dim Result As DialogResult = frmArticuloFacturaVentaNuevo.ShowDialog()

        If Result = DialogResult.OK Then
            Me.DialogResult = DialogResult.OK

            Me.Close()
        End If

        dgvDetalle.CurrentCell = Nothing
    End Sub

    Private Sub dgvPedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        If e.RowIndex > -1 Then
            dgvRemitos.CurrentCell = Nothing

            UtilidadesDGV.DescargarDGV(dgvDetalle)

            For Each Item In DetallePedido
                Dim Count As Double = CountCantidadFacturada_Reserva(Item.IdPedidosDetalle)

                If Item.AscPedidos.IdPedidos = dgvPedidos.CurrentRow.Cells("idPedidos").Value And Count < Item.Cantidad Then
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

    Private Sub dgvRemitos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRemitos.CellClick
        If e.RowIndex > -1 Then
            dgvPedidos.CurrentCell = Nothing

            UtilidadesDGV.DescargarDGV(dgvDetalle)

            For Each Item In DetalleRemito
                Dim Count As Double = CountCantidadFacturada_Remito(Item.IdDetalleRemitosVenta)

                If Item.AscRemitosVenta.IdRemitosVenta = dgvRemitos.CurrentRow.Cells("idRemitosVenta").Value And Count < Item.Cantidad Then
                    dgvDetalle.Rows.Add(Item.IdDetalleRemitosVenta, Item.AscArticulos.IdArticulo, Item.AscArticulos.CodArticulo, Item.AscArticulos.Detalle, Item.Cantidad - Count)

                    If Count <> 0 Then
                        dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells("Saldo").Style.ForeColor = Color.FromArgb(95, 150, 15)
                    End If
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        Else
            dgvRemitos.CurrentCell = Nothing

            UtilidadesDGV.DescargarDGV(dgvDetalle)
            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        End If
    End Sub
#End Region
End Class