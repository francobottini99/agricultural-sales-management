Imports Procesos

Public Class frmListaProveedores
    Dim listaProv As List(Of Proveedores)
    Dim tareaProv As TareasProveedores

    Public Property infoProveedor As Proveedores

#Region "LOAD"
    Private Sub frmListaProveedores_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Enabled = True

        tareaProv = New TareasProveedores
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvProveedores)

        ConfigDGV_PROVEEDORES()

        UtilidadesDGV.DescargarDGV(dgvProveedores)

        Notificaciones.arbirFormProceso("CARGANDO LISTA DE PROVEEDORES")

        listaProv = Await tareaProv.ListadoCompleto

        If Not IsNothing(listaProv) Then
            TareasProveedores.LlenarDGV(dgvProveedores, listaProv)

            UtilidadesDGV.CabeceraDGV(dgvProveedores, DataGridViewAutoSizeColumnsMode.DisplayedCells)

            Notificaciones.cerrarFormProceso()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaProv.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDGV_PROVEEDORES()
        dgvProveedores.ColumnCount = 17
        dgvProveedores.Columns(0).Name = "idProveedores"
        dgvProveedores.Columns(1).Name = "Alta"
        dgvProveedores.Columns(2).Name = "RazónSocial"
        dgvProveedores.Columns(3).Name = "Dirección"
        dgvProveedores.Columns(4).Name = "Localidad"
        dgvProveedores.Columns(5).Name = "Provincia"
        dgvProveedores.Columns(6).Name = "CP"
        dgvProveedores.Columns(7).Name = "País"
        dgvProveedores.Columns(8).Name = "Teléfono"
        dgvProveedores.Columns(9).Name = "Mail"
        dgvProveedores.Columns(10).Name = "Web"
        dgvProveedores.Columns(11).Name = "CUIT"
        dgvProveedores.Columns(12).Name = "IIBB"
        dgvProveedores.Columns(13).Name = "SituacionIVA"
        dgvProveedores.Columns(14).Name = "Estado"
        dgvProveedores.Columns(15).Name = "Eliminado"
        dgvProveedores.Columns(16).Name = "Usuarios_idUsuarios"

        dgvProveedores.Columns("IIBB").Visible = False
        dgvProveedores.Columns("SituacionIVA").Visible = False
        dgvProveedores.Columns("Eliminado").Visible = False
        dgvProveedores.Columns("Usuarios_idUsuarios").Visible = False

        dgvProveedores.Columns("idProveedores").HeaderText = "NRO CTA"
        dgvProveedores.Columns("Alta").HeaderText = "FEC. ALTA"
        dgvProveedores.Columns("RazónSocial").HeaderText = "RAZON SOCIAL"
        dgvProveedores.Columns("Dirección").HeaderText = "DIRECCION"
        dgvProveedores.Columns("Localidad").HeaderText = "LOCALIDAD"
        dgvProveedores.Columns("Provincia").HeaderText = "PROVINCIA"
        dgvProveedores.Columns("CP").HeaderText = "COD POSTAL"
        dgvProveedores.Columns("País").HeaderText = "PAIS"
        dgvProveedores.Columns("Teléfono").HeaderText = "TELEFONO"
        dgvProveedores.Columns("Mail").HeaderText = "MAIL"
        dgvProveedores.Columns("Web").HeaderText = "WEB"
        dgvProveedores.Columns("CUIT").HeaderText = "CUIT"
        dgvProveedores.Columns("Estado").HeaderText = "ESTADO"

        dgvProveedores.Columns("idProveedores").DisplayIndex = 0
        dgvProveedores.Columns("Alta").DisplayIndex = 1
        dgvProveedores.Columns("RazónSocial").DisplayIndex = 2
        dgvProveedores.Columns("CUIT").DisplayIndex = 3
        dgvProveedores.Columns("Dirección").DisplayIndex = 4
        dgvProveedores.Columns("Localidad").DisplayIndex = 5
        dgvProveedores.Columns("Provincia").DisplayIndex = 6
        dgvProveedores.Columns("CP").DisplayIndex = 7
        dgvProveedores.Columns("País").DisplayIndex = 8
        dgvProveedores.Columns("Teléfono").DisplayIndex = 9
        dgvProveedores.Columns("Mail").DisplayIndex = 10
        dgvProveedores.Columns("Web").DisplayIndex = 11
        dgvProveedores.Columns("Estado").DisplayIndex = 14

        dgvProveedores.Columns("idProveedores").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProveedores.Columns("Alta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvProveedores.Columns("RazónSocial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("CUIT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProveedores.Columns("Dirección").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("Localidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("Provincia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("CP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProveedores.Columns("País").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("Teléfono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("Mail").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("Web").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("Estado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProveedores.ColumnHeadersVisible = False
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub TxtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles txtRazonSocial.TextChanged
        Dim listFiltrada As New List(Of Proveedores)

        UtilidadesDGV.DescargarDGV(dgvProveedores)

        For Each Item In listaProv
            If UCase(Item.RazonSocial).Contains(UCase(txtRazonSocial.Text)) Then
                listFiltrada.Add(Item)
            End If
        Next

        TareasProveedores.LlenarDGV(dgvProveedores, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvProveedores, DataGridViewAutoSizeColumnsMode.DisplayedCells)
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub dgvProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellDoubleClick
        If e.RowIndex > -1 Then
            infoProveedor = New Proveedores With {
                .IdProveedor = dgvProveedores.CurrentRow.Cells("idProveedores").Value,
                .FechaAlta = dgvProveedores.CurrentRow.Cells("Alta").Value,
                .Direccion = dgvProveedores.CurrentRow.Cells("Dirección").Value,
                .RazonSocial = dgvProveedores.CurrentRow.Cells("RazónSocial").Value,
                .Localidad = dgvProveedores.CurrentRow.Cells("Localidad").Value,
                .Provincia = dgvProveedores.CurrentRow.Cells("Provincia").Value,
                .CodPostal = dgvProveedores.CurrentRow.Cells("CP").Value,
                .Pais = dgvProveedores.CurrentRow.Cells("País").Value,
                .Telefono = dgvProveedores.CurrentRow.Cells("Teléfono").Value,
                .Mail = dgvProveedores.CurrentRow.Cells("Mail").Value,
                .Web = dgvProveedores.CurrentRow.Cells("Web").Value,
                .CUIT = dgvProveedores.CurrentRow.Cells("CUIT").Value,
                .IIBB = dgvProveedores.CurrentRow.Cells("IIBB").Value,
                .SituacionIVA = dgvProveedores.CurrentRow.Cells("SituacionIVA").Value
            }

            Me.DialogResult = DialogResult.OK

            Me.Close()
        End If
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub
#End Region
End Class