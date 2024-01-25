Imports Procesos

Public Class frmListaDepositos
    Dim listaDep As List(Of Depositos)
    Dim tareaDep As TareasDepositos
    Dim tareaStk As TareasStock

    Public Property infoDeposito As Depositos

#Region "EVENTO LOAD"
    Private Sub frmListaDepositos_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Enabled = True

        tareaDep = New TareasDepositos
        tareaStk = New TareasStock
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvDepositos)

        ConfigDGV_DEPOSITOS()

        UtilidadesDGV.DescargarDGV(dgvDepositos)

        Notificaciones.arbirFormProceso("CARGANDO DEPOSITOS")

        listaDep = Await tareaDep.ListadoCompleto()

        If Not IsNothing(listaDep) Then
            If txtIdArt.Text <> "" Then
                Dim items As Integer = listaDep.Count - 1
                Dim Est As String = "OK"

                If items >= 0 Then
                    For j As Integer = items To 0 Step -1
                        Dim Stk As Integer = Await tareaStk.verStockFisico(CInt(txtIdArt.Text), listaDep.Item(j).IdDeposito)

                        If Not IsNothing(Stk) Then
                            If Stk - CountStkDep(listaDep.Item(j).IdDeposito, CInt(txtIdArt.Text)) <= 0 Then
                                listaDep.RemoveAt(j)
                            End If
                        Else
                            Est = "Err"

                            Exit For
                        End If
                    Next
                End If

                If Est <> "OK" Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaStk.Err.Descripcion, Botones.OK, Iconos.ERR)

                    Me.Close()
                End If

                lblTitulo.Text = "LISTADO DE DEPOSITOS CON STOCK DISPONIBLE"
            Else
                lblTitulo.Text = "LISTADO DE DEPOSITOS CARGADOS"
            End If

            TareasDepositos.LlenarDGV(dgvDepositos, listaDep)

            UtilidadesDGV.CabeceraDGV(dgvDepositos)

            Notificaciones.cerrarFormProceso()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaDep.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If
    End Sub

#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDGV_DEPOSITOS()
        dgvDepositos.ColumnCount = 8
        dgvDepositos.Columns(0).Name = "idDeposito"
        dgvDepositos.Columns(1).Name = "Nombre"
        dgvDepositos.Columns(2).Name = "Dirección"
        dgvDepositos.Columns(3).Name = "Localidad"
        dgvDepositos.Columns(4).Name = "Provincia"
        dgvDepositos.Columns(5).Name = "CP"
        dgvDepositos.Columns(6).Name = "Eliminado"
        dgvDepositos.Columns(7).Name = "Usuarios_idUsuarios"

        dgvDepositos.Columns("Eliminado").Visible = False
        dgvDepositos.Columns("Usuarios_idUsuarios").Visible = False

        dgvDepositos.Columns("idDeposito").HeaderText = "NRO DE DEPOSITO"
        dgvDepositos.Columns("Nombre").HeaderText = "NOMBRE"
        dgvDepositos.Columns("Dirección").HeaderText = "DIRECCION"
        dgvDepositos.Columns("Localidad").HeaderText = "LOCALIDAD"
        dgvDepositos.Columns("Provincia").HeaderText = "PROVINCIA"
        dgvDepositos.Columns("CP").HeaderText = "COD POSTAL"

        dgvDepositos.Columns("idDeposito").DisplayIndex = 0
        dgvDepositos.Columns("Nombre").DisplayIndex = 1
        dgvDepositos.Columns("Dirección").DisplayIndex = 2
        dgvDepositos.Columns("Localidad").DisplayIndex = 3
        dgvDepositos.Columns("Provincia").DisplayIndex = 4
        dgvDepositos.Columns("CP").DisplayIndex = 5
        dgvDepositos.Columns("Eliminado").DisplayIndex = 6
        dgvDepositos.Columns("Usuarios_idUsuarios").DisplayIndex = 7

        dgvDepositos.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDepositos.Columns("Dirección").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDepositos.Columns("Localidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDepositos.Columns("Provincia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDepositos.Columns("CP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvDepositos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDepositos.ColumnHeadersVisible = False
    End Sub

    Private Function CountStkDep(ByVal idDep As Integer, ByVal idArt As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmRemitoVenta.dgvDetalleRemito.Rows
            If idDep = item.Cells("idDeposito").Value And idArt = item.Cells("idArticulo").Value Then
                If frmArticuloRemitoVentaNuevo.txtOrigen.Text <> "Editar" Or frmArticuloRemitoVentaReserva.txtOrigen.Text <> "Editar" Or item IsNot frmRemitoVenta.dgvDetalleRemito.CurrentRow Then
                    Count = Count + UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
                End If
            End If
        Next

        Return Count
    End Function

#End Region

#Region "EVENTOS CHANGED"
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Dim listFiltrada As New List(Of Depositos)

        UtilidadesDGV.DescargarDGV(dgvDepositos)

        For Each Item In listaDep
            If UCase(Item.Nombre).Contains(UCase(txtNombre.Text)) Then
                listFiltrada.Add(Item)
            End If
        Next

        TareasDepositos.LlenarDGV(dgvDepositos, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvDepositos)
    End Sub

#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub dgvDepositos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepositos.CellDoubleClick
        If e.RowIndex > -1 Then
            infoDeposito = New Depositos With {
                .IdDeposito = dgvDepositos.CurrentRow.Cells("idDeposito").Value,
                .Nombre = dgvDepositos.CurrentRow.Cells("Nombre").Value,
                .Direccion = dgvDepositos.CurrentRow.Cells("Dirección").Value,
                .Localidad = dgvDepositos.CurrentRow.Cells("Localidad").Value,
                .Provincia = dgvDepositos.CurrentRow.Cells("Provincia").Value,
                .CodPostal = dgvDepositos.CurrentRow.Cells("CP").Value
            }

            Me.DialogResult = DialogResult.OK

            Me.Close()
        End If
    End Sub

#End Region

End Class