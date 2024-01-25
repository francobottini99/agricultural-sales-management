Imports System.ComponentModel
Imports Procesos

Public Class frmRemitoNuevoProveedor
    Private _TareasRemitoCompraDetalle As TareasDetalleRemitoCompra

    Private RemitoCompraDetalle As List(Of DetalleRemitoCompra)

    Public Property infoDetalleRemito As DetalleRemitoCompra
    Public Property fijarDetRem As List(Of DetalleRemitoCompra)

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
        _TareasRemitoCompraDetalle = New TareasDetalleRemitoCompra()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrDgvs_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        UtilidadesDGV.FormatoDGVGeneral(dgvDetalle)
        UtilidadesDGV.FormatoDGVGeneral(dgvRemitos)

        ConfigDGV_DETALLE()
        ConfigDGV_FACTURAS()

        UtilidadesDGV.DescargarDGV(dgvDetalle)
        UtilidadesDGV.DescargarDGV(dgvRemitos)

        RemitoCompraDetalle = Await _TareasRemitoCompraDetalle.verDetalleRemitosCompraSinFacturarIdProveedor(frmFacturaCompra.txtCtaProv.Text)

        If Not IsNothing(fijarDetRem) Then
            If IsNothing(RemitoCompraDetalle) Then
                RemitoCompraDetalle = New List(Of DetalleRemitoCompra)
            End If

            For Each Item In fijarDetRem
                RemitoCompraDetalle.Add(Item)
            Next
        End If

        If Not IsNothing(RemitoCompraDetalle) Then
            For Each Item In RemitoCompraDetalle
                Dim Count As Double = CountCantidadFacturada_Remito(Item.IdDetalleRemitosCompra)
                Dim agg As Boolean = True

                If Item.Cantidad - Count > 0 Then
                    For Each row In dgvRemitos.Rows
                        If Item.AscRemitosCompra.IdRemitosCompra = row.Cells("idRemitoCompra").Value Then
                            agg = False
                        End If
                    Next
                Else
                    agg = False
                End If

                If agg Then
                    dgvRemitos.Rows.Add(Item.AscRemitosCompra.IdRemitosCompra, Item.AscRemitosCompra.AscUsuarios.IdUsuario,
                                        Format(Item.AscRemitosCompra.Fecha, "dd/MM/yyyy"), Item.AscRemitosCompra.NroComprobante,
                                        Item.AscRemitosCompra.Observaciones)
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvRemitos)
        ElseIf _TareasRemitoCompraDetalle.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasRemitoCompraDetalle.Err.Descripcion, Botones.OK, Iconos.ERR)

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
        dgvRemitos.ColumnCount = 5
        dgvRemitos.Columns(0).Name = "idRemitoCompra"
        dgvRemitos.Columns(1).Name = "idUsuarios"
        dgvRemitos.Columns(2).Name = "Fecha"
        dgvRemitos.Columns(3).Name = "NroComprobante"
        dgvRemitos.Columns(4).Name = "Observaciones"

        dgvRemitos.Columns("idRemitoCompra").Visible = False
        dgvRemitos.Columns("idUsuarios").Visible = False

        dgvRemitos.Columns("Fecha").HeaderText = "FECHA"
        dgvRemitos.Columns("NroComprobante").HeaderText = "NRO COMPROBANTE"
        dgvRemitos.Columns("Observaciones").HeaderText = "OBSERVACIONES"

        dgvRemitos.Columns("idRemitoCompra").DisplayIndex = 0
        dgvRemitos.Columns("idUsuarios").DisplayIndex = 1
        dgvRemitos.Columns("Fecha").DisplayIndex = 2
        dgvRemitos.Columns("NroComprobante").DisplayIndex = 3
        dgvRemitos.Columns("Observaciones").DisplayIndex = 4

        dgvRemitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvRemitos.Columns("Fecha").Width = 100

        dgvRemitos.Sort(dgvRemitos.Columns("Fecha"), ListSortDirection.Ascending)
    End Sub

    Private Function CountCantidadFacturada_Remito(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmFacturaCompra.dgvDetalleFactura.Rows
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
                infoDetalleRemito = New DetalleRemitoCompra With {
                    .IdDetalleRemitosCompra = dgvDetalle.CurrentRow.Cells("id").Value,
                    .Cantidad = dgvDetalle.CurrentRow.Cells("Saldo").Value,
                    .AscArticulos = New Articulos With {
                        .IdArticulo = dgvDetalle.CurrentRow.Cells("idArticulos").Value,
                        .CodArticulo = dgvDetalle.CurrentRow.Cells("CodArticulo").Value,
                        .Detalle = dgvDetalle.CurrentRow.Cells("Articulo").Value
                    },
                    .AscRemitosCompra = New RemitoCompra With {.IdRemitosCompra = dgvRemitos.CurrentRow.Cells("idRemitoCompra").Value}
                }

                frmArticuloFacturaCompraRemito.Dispose()
                UtilidadesVarias.Escalar(frmArticuloFacturaCompraRemito)
                frmArticuloFacturaCompraRemito.txtOrigen.Text = "Agregar"

                Result = frmArticuloFacturaCompraRemito.ShowDialog()
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
        dgvRemitos.CurrentCell = Nothing

        UtilidadesDGV.DescargarDGV(dgvDetalle)

        frmArticuloFacturaCompraNuevo.Dispose()
        UtilidadesVarias.Escalar(frmArticuloFacturaCompraNuevo)
        frmArticuloFacturaCompraNuevo.txtOrigen.Text = "Agregar"

        Dim Result As DialogResult = frmArticuloFacturaCompraNuevo.ShowDialog()

        If Result = DialogResult.OK Then
            Me.DialogResult = DialogResult.OK

            Me.Close()
        End If

        dgvDetalle.CurrentCell = Nothing
    End Sub

    Private Sub dgvFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRemitos.CellClick
        If e.RowIndex > -1 Then
            UtilidadesDGV.DescargarDGV(dgvDetalle)

            For Each Item In RemitoCompraDetalle
                Dim Count As Double = CountCantidadFacturada_Remito(Item.IdDetalleRemitosCompra)

                If Item.AscRemitosCompra.IdRemitosCompra = dgvRemitos.CurrentRow.Cells("idRemitoCompra").Value And Item.Cantidad - Count > 0 Then
                    dgvDetalle.Rows.Add(Item.IdDetalleRemitosCompra, Item.AscArticulos.IdArticulo, Item.AscArticulos.CodArticulo, Item.AscArticulos.Detalle, Item.Cantidad - Count)

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