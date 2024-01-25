Imports Procesos

Public Class frmProveedores
    Private listCompleta As List(Of Proveedores)
    Private Tareas As TareasProveedores

#Region "EVENTO LOAD"
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tareas = New TareasProveedores()

        tmrLoad.Enabled = True
        lblTitulo.Text = "SIGEVA -> " & Date.Now & " -> Ingreso a ALTAS DE PROVEEDORES"

        UtilidadesDGV.FormatoDGVGeneral(dgvProveedores)
        ConfigDGV_PROVEEDORES()
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Cancelar()
    End Sub
#End Region

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

    Private Sub btnModificar_GotFocus(sender As Object, e As EventArgs) Handles btnModificar.GotFocus
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificar_LostFocus(sender As Object, e As EventArgs) Handles btnModificar.LostFocus
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificar_MouseEnter(sender As Object, e As EventArgs) Handles btnModificar.MouseEnter
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificar_MouseLeave(sender As Object, e As EventArgs) Handles btnModificar.MouseLeave
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnGuardar_GotFocus(sender As Object, e As EventArgs) Handles btnGuardar.GotFocus
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnGuardar_LostFocus(sender As Object, e As EventArgs) Handles btnGuardar.LostFocus
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnGuardar_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar.MouseEnter
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCancelar_GotFocus(sender As Object, e As EventArgs) Handles btnCancelar.GotFocus
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCancelar_LostFocus(sender As Object, e As EventArgs) Handles btnCancelar.LostFocus
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCancelar_MouseEnter(sender As Object, e As EventArgs) Handles btnCancelar.MouseEnter
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelar.MouseLeave
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminar_GotFocus(sender As Object, e As EventArgs) Handles btnEliminar.GotFocus
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminar_LostFocus(sender As Object, e As EventArgs) Handles btnEliminar.LostFocus
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminar_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminar.MouseEnter
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

#End Region

#Region "EVENTOS CLICK"

    Private Async Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtRazonSocial.Text = "" Then
            Notificaciones.MsgBox("""RAZON SOCIAL"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

            txtRazonSocial.Select()
        Else
            If cmbSitIVA.Text = "" Or cmbSitIVA.Text = "-" Then
                Notificaciones.MsgBox("""SITUACION ANTE EL IVA"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                cmbSitIVA.Select()
            Else
                If txtCUIT.Text = "" And cmbSitIVA.Text <> "Consumidor Final" And cmbSitIVA.Text <> "Sujeto no Categorizado" And cmbSitIVA.Text <> "IVA Liberado – Ley Nº 19.640" Then
                    Notificaciones.MsgBox("""CUIT"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                    cmbSitIVA.Select()
                Else
                    Dim _proveedor As New Proveedores(txtFecha.Text, txtRazonSocial.Text, txtDireccion.Text, txtLocalidad.Text, cbxProvincia.Text,
                                                 txtCP.Text, txtPais.Text, txtTelefono.Text, txtMail.Text, txtWeb.Text, txtCUIT.Text, txtIIBB.Text,
                                                 cmbSitIVA.Text)

                    If txtOrigen.Text = "Nuevo" Then
                        Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Proveedor ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("GUARDANDO PROVEEDOR")

                            Guiones(_proveedor)

                            If Await Tareas.Servicio_Insertar(_proveedor) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Proveedor guardado con exito !", Botones.OK, Iconos.OK)

                                Cancelar()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                            End If
                        End If
                    ElseIf txtOrigen.Text = "Modificar" Then
                        Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Proveedor ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("MODIFICANDO PROVEEDOR")

                            _proveedor.IdProveedor = CInt(txtIdProveedores.Text)

                            Guiones(_proveedor)

                            If Await Tareas.Servicio_Modificar(_proveedor) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Proveedor modificado con exito !", Botones.OK, Iconos.OK)

                                Cancelar()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdProveedores.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Proveedor.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            txtFecha.Text = dgvProveedores.CurrentRow.Cells("Alta").Value
            txtRazonSocial.Text = dgvProveedores.CurrentRow.Cells("RazónSocial").Value
            txtDireccion.Text = dgvProveedores.CurrentRow.Cells("Dirección").Value
            txtLocalidad.Text = dgvProveedores.CurrentRow.Cells("Localidad").Value
            cbxProvincia.Text = dgvProveedores.CurrentRow.Cells("Provincia").Value
            txtCP.Text = dgvProveedores.CurrentRow.Cells("CP").Value
            txtPais.Text = dgvProveedores.CurrentRow.Cells("País").Value
            txtTelefono.Text = dgvProveedores.CurrentRow.Cells("Teléfono").Value
            txtMail.Text = dgvProveedores.CurrentRow.Cells("Mail").Value
            txtWeb.Text = dgvProveedores.CurrentRow.Cells("Web").Value
            txtCUIT.Text = dgvProveedores.CurrentRow.Cells("CUIT").Value
            txtIIBB.Text = dgvProveedores.CurrentRow.Cells("IIBB").Value
            cmbSitIVA.Text = dgvProveedores.CurrentRow.Cells("SituacionIVA").Value

            Activar()
        End If
    End Sub

    Private Async Sub BtnEliminar_ClickAsync(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdProveedores.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Proveedor.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Proveedor ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO PROVEEDOR")

                If Await Tareas.Eliminar(txtIdProveedores.Text) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Proveedor eliminado con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()

        txtFecha.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub dgvProveedores_CellClickk(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        If e.RowIndex > -1 Then
            txtIdProveedores.Text = dgvProveedores.CurrentRow.Cells("idProveedores").Value

            btnModificar.Select()
        End If
    End Sub

#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDireccion.SelectionLength = Len(txtDireccion.Text)
            txtDireccion.Select()
        End If
    End Sub

    Private Sub txtDireccionl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLocalidad.SelectionLength = Len(txtLocalidad.Text)
            txtLocalidad.Select()
        End If
    End Sub

    Private Sub txtLocalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocalidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxProvincia.SelectionLength = Len(cbxProvincia.Text)
            cbxProvincia.Select()
        End If
    End Sub

    Private Sub cbxProvincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxProvincia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCP.SelectionLength = Len(txtCP.Text)
            txtCP.Select()
        End If
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPais.SelectionLength = Len(txtPais.Text)
            txtPais.Select()
        End If
    End Sub

    Private Sub txtPais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPais.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtTelefono.SelectionLength = Len(txtTelefono.Text)
            txtTelefono.Select()
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtMail.SelectionLength = Len(txtMail.Text)
            txtMail.Select()
        End If
    End Sub

    Private Sub txtMail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMail.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtWeb.SelectionLength = Len(txtWeb.Text)
            txtWeb.Select()
        End If
    End Sub

    Private Sub txtWeb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeb.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cmbSitIVA.SelectionLength = Len(cmbSitIVA.Text)
            cmbSitIVA.Select()
        End If
    End Sub

    Private Sub cmbSitIVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSitIVA.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCUIT.SelectionLength = Len(txtCUIT.Text)
            txtCUIT.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCUIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCUIT.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtIIBB.SelectionLength = Len(txtIIBB.Text)
            txtIIBB.Select()
        ElseIf e.KeyChar = ChrW(46) Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            If Asc(e.KeyChar) <> Keys.Back Then
                If txtCUIT.Text <> "" And txtCUIT.Text <> "-" And txtCUIT.Text <> "00-00000000-0" Then
                    If Len(txtCUIT.Text) < 13 Then
                        If Len(txtCUIT.Text) = 2 Then
                            txtCUIT.Text = txtCUIT.Text & "-"
                            txtCUIT.Select(txtCUIT.Text.Length, 0)
                        ElseIf Len(txtCUIT.Text) = 11 Then
                            txtCUIT.Text = txtCUIT.Text & "-"
                            txtCUIT.Select(txtCUIT.Text.Length, 0)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtIIBB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIIBB.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

#End Region

#Region "METODOS PRIVADOS"
    Private Sub Activar()
        pnlContendor.Enabled = True
        bnfCardList.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False

        btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
        btnModificar.BackColor = Color.FromArgb(35, 35, 35)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminar.BackColor = Color.FromArgb(35, 35, 35)

        txtBuscar.Text = ""

        UtilidadesDGV.DescargarDGV(dgvProveedores)

        txtRazonSocial.SelectionLength = Len(txtRazonSocial.Text)
        txtRazonSocial.Select()
    End Sub

    Private Async Sub Cancelar()
        pnlContendor.Enabled = False
        bnfCardList.Enabled = True

        UtilidadesTXT.VaciarTxt(Me)

        cmbSitIVA.Text = ""
        cbxProvincia.Text = ""

        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = True

        btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminar.BackColor = Color.FromArgb(100, 100, 100)

        listCompleta = Await Tareas.ListadoCompleto()

        If Not IsNothing(listCompleta) Then
            UtilidadesDGV.DescargarDGV(dgvProveedores)

            TareasProveedores.LlenarDGV(dgvProveedores, listCompleta)

            UtilidadesDGV.CabeceraDGV(dgvProveedores)

            Notificaciones.cerrarFormProceso()
        ElseIf Tareas.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If

        btnNuevo.Select()
    End Sub

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

    Private Sub Guiones(ByRef _Proveedor As Proveedores)
        If txtDireccion.Text = "" Then
            _Proveedor.Direccion = "-"
        End If

        If txtLocalidad.Text = "" Then
            _Proveedor.Localidad = "-"
        End If

        If cbxProvincia.Text = "" Then
            _Proveedor.Localidad = "-"
        End If

        If txtCP.Text = "" Then
            _Proveedor.CodPostal = "-"
        End If

        If txtPais.Text = "" Then
            _Proveedor.Pais = "-"
        End If

        If txtTelefono.Text = "" Then
            _Proveedor.Telefono = "-"
        End If

        If txtWeb.Text = "" Then
            _Proveedor.Web = "-"
        End If

        If cmbSitIVA.Text = "" Then
            _Proveedor.SituacionIVA = "-"
        End If

        If txtCUIT.Text = "" Then
            _Proveedor.CUIT = "-"
        End If

        If txtIIBB.Text = "" Then
            _Proveedor.IIBB = "-"
        End If

        If txtMail.Text = "" Then
            _Proveedor.Mail = "-"
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub cmbSitIVA_Validated(sender As Object, e As EventArgs) Handles cmbSitIVA.Validated
        If cmbSitIVA.Text = "" Or cmbSitIVA.Text = "-" Then
            cmbSitIVA.Text = "Consumidor Final"
            txtCUIT.Text = "00-00000000-0"
        ElseIf cmbSitIVA.Text = "Consumidor Final" Or cmbSitIVA.Text <> "Sujeto no Categorizado" Or cmbSitIVA.Text <> "IVA Liberado – Ley Nº 19.640" Then
            txtCUIT.Text = "00-00000000-0"
        Else
            txtCUIT.Text = ""
        End If

        txtCUIT.SelectionLength = Len(txtCUIT.Text)
        txtCUIT.Select()
    End Sub

    Private Sub txtCUIT_Validated(sender As Object, e As EventArgs) Handles txtCUIT.Validated
        If cmbSitIVA.Text <> "Consumidor Final" And cmbSitIVA.Text <> "Sujeto no Categorizado" And cmbSitIVA.Text <> "IVA Liberado – Ley Nº 19.640" And txtCUIT.Text <> "" Then
            If UtilidadesVarias.ValidaCUIT(txtCUIT.Text) = True Then
                txtIIBB.SelectionLength = Len(txtIIBB.Text)
                txtIIBB.Select()
            Else
                Notificaciones.MsgBox("El CUIT ingresado no es válido.", Botones.OK, Iconos.ERR)
                txtCUIT.Select()
            End If
        Else
            txtCUIT.Text = "00-00000000-0"
            txtIIBB.SelectionLength = Len(txtIIBB.Text)
            txtIIBB.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim listFiltrada As List(Of Proveedores)

        UtilidadesDGV.DescargarDGV(dgvProveedores)

        If txtBuscar.Text <> "" Then
            listFiltrada = UtilidadesListas.FiltarLista(Of Proveedores)(listCompleta, "RazonSocial", txtBuscar.Text)
        Else
            listFiltrada = listCompleta
        End If

        TareasProveedores.LlenarDGV(dgvProveedores, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvProveedores)
    End Sub

#End Region

End Class