Imports Procesos

Public Class frmListaArticulos
    Public listaRub As List(Of Rubros)
    Public listaSubRub As List(Of SubRubros)
    Dim listaArt As List(Of Articulos)

    Dim tareaRub As TareasRubros
    Dim tareaSub As TareasSubRubro
    Dim tareaArt As TareasArticulos
    Dim tareaStk As TareasStock

    Public Property infoArticulo As Articulos

#Region "LOAD"
    Private Sub FrmArticulos_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Enabled = True

        tareaArt = New TareasArticulos
        tareaRub = New TareasRubros
        tareaSub = New TareasSubRubro
        tareaStk = New TareasStock
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvArticulos)

        ConfigDGV_Articulos()

        UtilidadesDGV.DescargarDGV(dgvArticulos)

        cmbBuscarSubRub.Enabled = False
        cmbBuscarSubRub.Text = ""
        cmbBuscarRub.Text = ""

        Notificaciones.arbirFormProceso()

        listaRub = Await tareaRub.ListadoCompleto()

        If Not IsNothing(listaRub) Then
            cmbBuscarRub.Items.Clear()
            cmbBuscarSubRub.Items.Clear()

            For Each item In listaRub
                cmbBuscarRub.Items.Add(item.Descripcion)
            Next

            If cmbBuscarRub.Items.Count < 1 Then
                cmbBuscarRub.Enabled = False
            End If

            listaSubRub = Await tareaSub.ListadoCompleto()

            If IsNothing(listaSubRub) And tareaSub.Err.Descripcion <> "-" Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(tareaSub.Err.Descripcion, Botones.OK, Iconos.ERR)

                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            End If
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaRub.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If

        listaArt = Await tareaArt.ListadoCompleto()

        If Not IsNothing(listaArt) Then
            If txtStock.Text <> "" Then
                Dim Est As String = "OK"
                Dim items As Integer = listaArt.Count - 1

                If items >= 0 Then
                    For j As Integer = items To 0 Step -1
                        Dim StkFisicoArt As Integer = Await tareaStk.verStockFisico(listaArt.Item(j).IdArticulo)

                        If Not IsNothing(StkFisicoArt) Then
                            If StkFisicoArt - CountStkArt(listaArt.Item(j).IdArticulo) <= 0 Then
                                listaArt.RemoveAt(j)
                            End If
                        Else
                            Est = "Err"

                            Exit For
                        End If
                    Next
                End If

                If Est <> "OK" Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)

                    Me.DialogResult = DialogResult.Cancel
                    Me.Close()
                End If

                If listaArt.Count = 0 Then
                    Notificaciones.MsgBox("No hay Stock de ningun Articulo cargado en el sistema", Botones.OK, Iconos.ERR)

                    Me.DialogResult = DialogResult.Cancel
                    Me.Close()
                End If

                lblTitulo.Text = "LISTADO DE ARTICULOS CON STOCK"
            Else
                lblTitulo.Text = "LISTADO DE ARTICULOS CARGADOS"
            End If

            TareasArticulos.LlenarDGV(dgvArticulos, listaArt)

            UtilidadesDGV.CabeceraDGV(dgvArticulos, DataGridViewAutoSizeColumnsMode.DisplayedCells)

            Notificaciones.cerrarFormProceso()

            txtBusarArt.Select()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Function CountStkArt(ByVal idArt As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmRemitoVenta.dgvDetalleRemito.Rows
            If idArt = item.Cells("idArticulo").Value Then
                If frmArticuloRemitoVentaReserva.txtOrigen.Text <> "Editar" Or frmArticuloRemitoVentaNuevo.txtOrigen.Text <> "Editar" Or item IsNot frmRemitoVenta.dgvDetalleRemito.CurrentRow Then
                    Count = Count + UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
                End If
            End If
        Next

        Return Count
    End Function

    Private Sub ConfigDGV_Articulos()
        dgvArticulos.ColumnCount = 17
        dgvArticulos.Columns(0).Name = "idArticulos"
        dgvArticulos.Columns(1).Name = "CodArt"
        dgvArticulos.Columns(2).Name = "Detalle"
        dgvArticulos.Columns(3).Name = "Unidad"
        dgvArticulos.Columns(4).Name = "Costo"
        dgvArticulos.Columns(5).Name = "FechaActualizacionCosto"
        dgvArticulos.Columns(6).Name = "Precio"
        dgvArticulos.Columns(7).Name = "FechaActualizacionPrecio"
        dgvArticulos.Columns(8).Name = "AlicuotaIVA"
        dgvArticulos.Columns(9).Name = "StockMinimo"
        dgvArticulos.Columns(10).Name = "Observaciones"
        dgvArticulos.Columns(11).Name = "idUsuarios"
        dgvArticulos.Columns(12).Name = "idRubro"
        dgvArticulos.Columns(13).Name = "idSubRubro"
        dgvArticulos.Columns(14).Name = "Usuario"
        dgvArticulos.Columns(15).Name = "Rubro"
        dgvArticulos.Columns(16).Name = "SubRubro"

        dgvArticulos.Columns("idArticulos").Visible = False
        dgvArticulos.Columns("idUsuarios").Visible = False
        dgvArticulos.Columns("idRubro").Visible = False
        dgvArticulos.Columns("idSubRubro").Visible = False

        dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        dgvArticulos.Columns("CodArt").HeaderText = "COD. ART."
        dgvArticulos.Columns("Detalle").HeaderText = "DETALLE"
        dgvArticulos.Columns("Unidad").HeaderText = "UNIDAD"
        dgvArticulos.Columns("Costo").HeaderText = "COSTO"
        dgvArticulos.Columns("FechaActualizacionCosto").HeaderText = "FECHA ACT. COSTO"
        dgvArticulos.Columns("Precio").HeaderText = "PRECIO"
        dgvArticulos.Columns("FechaActualizacionPrecio").HeaderText = "FECHA ACT. PRECIO"
        dgvArticulos.Columns("AlicuotaIVA").HeaderText = "ALICUOTA IVA"
        dgvArticulos.Columns("StockMinimo").HeaderText = "STOCK MINIMO"
        dgvArticulos.Columns("Observaciones").HeaderText = "OBSERVACIONES"
        dgvArticulos.Columns("Usuario").HeaderText = "USUARIO"
        dgvArticulos.Columns("Rubro").HeaderText = "RUBRO"
        dgvArticulos.Columns("SubRubro").HeaderText = "SUB RUBRO"

        dgvArticulos.Columns("idArticulos").DisplayIndex = 0
        dgvArticulos.Columns("idUsuarios").DisplayIndex = 1
        dgvArticulos.Columns("idRubro").DisplayIndex = 2
        dgvArticulos.Columns("idSubRubro").DisplayIndex = 3
        dgvArticulos.Columns("CodArt").DisplayIndex = 4
        dgvArticulos.Columns("Detalle").DisplayIndex = 5
        dgvArticulos.Columns("Rubro").DisplayIndex = 6
        dgvArticulos.Columns("SubRubro").DisplayIndex = 7
        dgvArticulos.Columns("Unidad").DisplayIndex = 8
        dgvArticulos.Columns("Costo").DisplayIndex = 9
        dgvArticulos.Columns("FechaActualizacionCosto").DisplayIndex = 10
        dgvArticulos.Columns("Precio").DisplayIndex = 11
        dgvArticulos.Columns("FechaActualizacionPrecio").DisplayIndex = 12
        dgvArticulos.Columns("AlicuotaIVA").DisplayIndex = 13
        dgvArticulos.Columns("StockMinimo").DisplayIndex = 14
        dgvArticulos.Columns("Observaciones").DisplayIndex = 15
        dgvArticulos.Columns("Usuario").DisplayIndex = 16
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Async Sub dgvProveedores_CellDoubleClickAsync(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellDoubleClick
        If e.RowIndex > -1 Then
            infoArticulo = New Articulos With {
                .IdArticulo = dgvArticulos.CurrentRow.Cells("idArticulos").Value,
                .AscRubro = New Rubros With {.IdRubro = dgvArticulos.CurrentRow.Cells("idRubro").Value},
                .AscSubRubro = New SubRubros With {.IdSubRubro = dgvArticulos.CurrentRow.Cells("idSubRubro").Value},
                .CodArticulo = dgvArticulos.CurrentRow.Cells("CodArt").Value,
                .Detalle = dgvArticulos.CurrentRow.Cells("Detalle").Value,
                .Unidad = dgvArticulos.CurrentRow.Cells("Unidad").Value,
                .Costo = UtilidadesVarias.SoloNumeros(dgvArticulos.CurrentRow.Cells("Costo").Value),
                .FechaActCosto = dgvArticulos.CurrentRow.Cells("FechaActualizacionCosto").Value,
                .Precio = UtilidadesVarias.SoloNumeros(dgvArticulos.CurrentRow.Cells("Precio").Value),
                .FechaActPrec = dgvArticulos.CurrentRow.Cells("FechaActualizacionPrecio").Value,
                .StkMinimo = dgvArticulos.CurrentRow.Cells("StockMinimo").Value,
                .AlicuotaIVA = UtilidadesVarias.SoloNumeros(dgvArticulos.CurrentRow.Cells("AlicuotaIVA").Value),
                .Observaciones = dgvArticulos.CurrentRow.Cells("Observaciones").Value
            }

            Dim Img As String = Await tareaArt.verImgArt(infoArticulo.IdArticulo)

            If Not IsNothing(Img) Then
                infoArticulo.Imagen = Img
            Else
                Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)

                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
#End Region

#Region "EVENTOS CHANGED"
    Private Sub cmbBuscarRub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscarRub.SelectedIndexChanged
        If cmbBuscarRub.Text <> "" Then
            cmbBuscarSubRub.Items.Clear()

            For Each item In listaSubRub
                If listaRub.Item(cmbBuscarRub.SelectedIndex).IdRubro = item.AscRubro.IdRubro And item.Descripcion <> listaRub.Item(cmbBuscarRub.SelectedIndex).Descripcion And item.Abrebiatura <> listaRub.Item(cmbBuscarRub.SelectedIndex).Abrebiatura Then
                    cmbBuscarSubRub.Items.Add(item.Descripcion)
                End If
            Next

            If cmbBuscarSubRub.Items.Count > 0 Then
                cmbBuscarSubRub.Enabled = True
                cmbBuscarSubRub.Text = ""
            Else
                cmbBuscarSubRub.Enabled = False
                cmbBuscarSubRub.Text = ""
            End If
        Else
            cmbBuscarSubRub.Items.Clear()
            cmbBuscarSubRub.Text = ""
            cmbBuscarSubRub.Enabled = False
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBusarArt.TextChanged, cmbBuscarRub.TextChanged, cmbBuscarSubRub.TextChanged
        Dim listFiltrada As New List(Of Articulos)

        UtilidadesDGV.DescargarDGV(dgvArticulos)

        For Each Item In listaArt
            If UCase(Item.Detalle).Contains(UCase(txtBusarArt.Text)) And UCase(Item.AscRubro.Descripcion).Contains(UCase(cmbBuscarRub.Text)) And UCase(Item.AscSubRubro.Descripcion).Contains(UCase(cmbBuscarSubRub.Text)) Then
                listFiltrada.Add(Item)
            End If
        Next

        TareasArticulos.LlenarDGV(dgvArticulos, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvArticulos, DataGridViewAutoSizeColumnsMode.DisplayedCells)
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtBusarArt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusarArt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbBuscarRub.SelectionLength = cmbBuscarRub.Text.Length
            cmbBuscarRub.Select()
        End If
    End Sub

    Private Sub cmbRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBuscarRub.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbBuscarSubRub.SelectionLength = cmbBuscarSubRub.Text.Length
            cmbBuscarSubRub.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            cmbBuscarSubRub.Text = ""
            cmbBuscarSubRub.Enabled = False
        End If
    End Sub

    Private Sub cmbBuscarSubRub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBuscarSubRub.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtBusarArt.SelectionLength = txtBusarArt.Text.Length
            txtBusarArt.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

#End Region
End Class