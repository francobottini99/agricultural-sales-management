Imports System.ComponentModel
Imports Procesos

Public Class frmFacturaNuevoProveedor
    Private _TareasFacturaCompraDetalle As TareasFacturaCompraDetalle

    Private FacturaCompraDetalle As List(Of FacturaCompraDetalle)

    Public Property infoDetalleFactura As FacturaCompraDetalle
    Public Property fijarDetFac As List(Of FacturaCompraDetalle)

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
        _TareasFacturaCompraDetalle = New TareasFacturaCompraDetalle()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrDgvs_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        UtilidadesDGV.FormatoDGVGeneral(dgvDetalle)
        UtilidadesDGV.FormatoDGVGeneral(dgvFacturas)

        ConfigDGV_DETALLE()
        ConfigDGV_FACTURAS()

        UtilidadesDGV.DescargarDGV(dgvDetalle)
        UtilidadesDGV.DescargarDGV(dgvFacturas)

        FacturaCompraDetalle = Await _TareasFacturaCompraDetalle.verFacturasCompraDetalleSinRemitarIdProveedor(frmRemitoCompra.txtCtaProv.Text)

        If Not IsNothing(fijarDetFac) Then
            If IsNothing(FacturaCompraDetalle) Then
                FacturaCompraDetalle = New List(Of FacturaCompraDetalle)
            End If

            For Each Item In fijarDetFac
                FacturaCompraDetalle.Add(Item)
            Next
        End If

        If Not IsNothing(FacturaCompraDetalle) Then
            For Each Item In FacturaCompraDetalle
                Dim Count As Double = CountCantidadRemitada_Factura(Item.IdFacturaCompraDetalle)
                Dim agg As Boolean = True

                If Item.Cantidad - Count > 0 Then
                    For Each row In dgvFacturas.Rows
                        If Item.AscFacturaCompra.IdFacturaCompra = row.Cells("idFacturaCompra").Value Then
                            agg = False
                        End If
                    Next
                Else
                    agg = False
                End If

                If agg Then
                    dgvFacturas.Rows.Add(Item.AscFacturaCompra.IdFacturaCompra, Item.AscFacturaCompra.AscUsuarios.IdUsuario,
                                        Format(Item.AscFacturaCompra.Fecha, "dd/MM/yyyy"), Item.AscFacturaCompra.Prefijo,
                                        Item.AscFacturaCompra.NroComprobante, Item.AscFacturaCompra.Observaciones)
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvFacturas)
        ElseIf _TareasFacturaCompraDetalle.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasFacturaCompraDetalle.Err.Descripcion, Botones.OK, Iconos.ERR)

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

    Private Sub ConfigDGV_FACTURAS()
        dgvFacturas.ColumnCount = 6
        dgvFacturas.Columns(0).Name = "idFacturaCompra"
        dgvFacturas.Columns(1).Name = "idUsuarios"
        dgvFacturas.Columns(2).Name = "Fecha"
        dgvFacturas.Columns(3).Name = "Prefijo"
        dgvFacturas.Columns(4).Name = "NroComprobante"
        dgvFacturas.Columns(5).Name = "Observaciones"

        dgvFacturas.Columns("idFacturaCompra").Visible = False
        dgvFacturas.Columns("idUsuarios").Visible = False

        dgvFacturas.Columns("Fecha").HeaderText = "FECHA"
        dgvFacturas.Columns("NroComprobante").HeaderText = "NRO COMPROBANTE"
        dgvFacturas.Columns("Observaciones").HeaderText = "OBSERVACIONES"
        dgvFacturas.Columns("Prefijo").HeaderText = "PREFIJO"

        dgvFacturas.Columns("idFacturaCompra").DisplayIndex = 0
        dgvFacturas.Columns("idUsuarios").DisplayIndex = 1
        dgvFacturas.Columns("Fecha").DisplayIndex = 2
        dgvFacturas.Columns("Prefijo").DisplayIndex = 3
        dgvFacturas.Columns("NroComprobante").DisplayIndex = 4
        dgvFacturas.Columns("Observaciones").DisplayIndex = 5

        dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvFacturas.Columns("Fecha").Width = 100

        dgvFacturas.Sort(dgvFacturas.Columns("Fecha"), ListSortDirection.Ascending)
    End Sub

    Private Function CountCantidadRemitada_Factura(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmRemitoCompra.dgvDetalleRemito.Rows
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

            If Not IsNothing(dgvFacturas.CurrentCell) Then
                infoDetalleFactura = New FacturaCompraDetalle With {
                    .IdFacturaCompraDetalle = dgvDetalle.CurrentRow.Cells("id").Value,
                    .Cantidad = dgvDetalle.CurrentRow.Cells("Saldo").Value,
                    .AscArticulos = New Articulos With {
                        .IdArticulo = dgvDetalle.CurrentRow.Cells("idArticulos").Value,
                        .CodArticulo = dgvDetalle.CurrentRow.Cells("CodArticulo").Value,
                        .Detalle = dgvDetalle.CurrentRow.Cells("Articulo").Value
                    },
                    .AscFacturaCompra = New FacturaCompra With {.IdFacturaCompra = dgvFacturas.CurrentRow.Cells("idFacturaCompra").Value}
                }

                frmArticuloRemitoCompraFactura.Dispose()
                UtilidadesVarias.Escalar(frmArticuloRemitoCompraFactura)
                frmArticuloRemitoCompraFactura.txtOrigen.Text = "Agregar"

                Result = frmArticuloRemitoCompraFactura.ShowDialog()
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
        dgvFacturas.CurrentCell = Nothing

        UtilidadesDGV.DescargarDGV(dgvDetalle)

        frmArticuloRemitoCompraNuevo.Dispose()
        UtilidadesVarias.Escalar(frmArticuloRemitoCompraNuevo)
        frmArticuloRemitoCompraNuevo.txtOrigen.Text = "Agregar"

        Dim Result As DialogResult = frmArticuloRemitoCompraNuevo.ShowDialog()

        If Result = DialogResult.OK Then
            Me.DialogResult = DialogResult.OK

            Me.Close()
        End If

        dgvDetalle.CurrentCell = Nothing
    End Sub

    Private Sub dgvFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturas.CellClick
        If e.RowIndex > -1 Then
            UtilidadesDGV.DescargarDGV(dgvDetalle)

            For Each Item In FacturaCompraDetalle
                Dim Count As Double = CountCantidadRemitada_Factura(Item.IdFacturaCompraDetalle)

                If Item.AscFacturaCompra.IdFacturaCompra = dgvFacturas.CurrentRow.Cells("idFacturaCompra").Value And Item.Cantidad - Count > 0 Then
                    dgvDetalle.Rows.Add(Item.IdFacturaCompraDetalle, Item.AscArticulos.IdArticulo, Item.AscArticulos.CodArticulo, Item.AscArticulos.Detalle, Item.Cantidad - Count)

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