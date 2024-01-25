Imports Procesos

Public Class frmClientes
    Private listCompleta As List(Of Clientes)
    Private Tareas As TareasClientes

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

#Region "FORM LOAD"
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Enabled = True
        lblTitulo.Text = "SIGEVA -> " & Date.Now & " -> Ingreso a ALTAS DE CLIENTES"

        Tareas = New TareasClientes()

        UtilidadesDGV.FormatoDGVGeneral(dgvClientes)

        ConfigDGV_Clientes()
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Cancelar()
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

        UtilidadesDGV.DescargarDGV(dgvClientes)

        txtRazonSocial.SelectionLength = Len(txtRazonSocial.Text)
        txtRazonSocial.Select()
    End Sub

    Private Async Sub Cancelar()
        Notificaciones.arbirFormProceso("CARGANDO CLIENTES")

        pnlContendor.Enabled = False
        bnfCardList.Enabled = True

        RemoveHandler txtCredAsignado.TextChanged, AddressOf txtCredAsignado_TextChanged

        UtilidadesTXT.VaciarTxt(Me)

        AddHandler txtCredAsignado.TextChanged, AddressOf txtCredAsignado_TextChanged

        cmbSitIVA.Text = ""
        cmbClasificacion.Text = ""
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
            UtilidadesDGV.DescargarDGV(dgvClientes)

            TareasClientes.LlenarDGV(dgvClientes, listCompleta)

            UtilidadesDGV.CabeceraDGV(dgvClientes, DataGridViewAutoSizeColumnsMode.DisplayedCells)

            Notificaciones.cerrarFormProceso()

            btnNuevo.Select()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If
    End Sub

    Private Sub ConfigDGV_Clientes()
        dgvClientes.ColumnCount = 20
        dgvClientes.Columns(0).Name = "idClientes"
        dgvClientes.Columns(1).Name = "Alta"
        dgvClientes.Columns(2).Name = "RazónSocial"
        dgvClientes.Columns(3).Name = "Dirección"
        dgvClientes.Columns(4).Name = "Localidad"
        dgvClientes.Columns(5).Name = "Provincia"
        dgvClientes.Columns(6).Name = "CP"
        dgvClientes.Columns(7).Name = "País"
        dgvClientes.Columns(8).Name = "Teléfono"
        dgvClientes.Columns(9).Name = "Mail"
        dgvClientes.Columns(10).Name = "Web"
        dgvClientes.Columns(11).Name = "CUIT"
        dgvClientes.Columns(12).Name = "IIBB"
        dgvClientes.Columns(13).Name = "SituacionIVA"
        dgvClientes.Columns(14).Name = "CreditoAsignado"
        dgvClientes.Columns(15).Name = "CreditoConsumido"
        dgvClientes.Columns(16).Name = "Estado"
        dgvClientes.Columns(17).Name = "Clasificación"
        dgvClientes.Columns(18).Name = "Eliminado"
        dgvClientes.Columns(19).Name = "Usuarios_idUsuarios"

        dgvClientes.Columns("IIBB").Visible = False
        dgvClientes.Columns("SituacionIVA").Visible = False
        dgvClientes.Columns("Eliminado").Visible = False
        dgvClientes.Columns("Usuarios_idUsuarios").Visible = False

        dgvClientes.Columns("idClientes").HeaderText = "NRO CTA"
        dgvClientes.Columns("Alta").HeaderText = "FEC. ALTA"
        dgvClientes.Columns("RazónSocial").HeaderText = "RAZON SOCIAL"
        dgvClientes.Columns("Dirección").HeaderText = "DIRECCION"
        dgvClientes.Columns("Localidad").HeaderText = "LOCALIDAD"
        dgvClientes.Columns("Provincia").HeaderText = "PROVINCIA"
        dgvClientes.Columns("CP").HeaderText = "COD POSTAL"
        dgvClientes.Columns("País").HeaderText = "PAIS"
        dgvClientes.Columns("Teléfono").HeaderText = "TELEFONO"
        dgvClientes.Columns("Mail").HeaderText = "MAIL"
        dgvClientes.Columns("Web").HeaderText = "WEB"
        dgvClientes.Columns("CUIT").HeaderText = "CUIT"
        dgvClientes.Columns("CreditoAsignado").HeaderText = "CREDITO ASIG"
        dgvClientes.Columns("CreditoConsumido").HeaderText = "CREDITO CONSUM"
        dgvClientes.Columns("Estado").HeaderText = "ESTADO"
        dgvClientes.Columns("Clasificación").HeaderText = "CLASIFICACION"

        dgvClientes.Columns("idClientes").DisplayIndex = 0
        dgvClientes.Columns("Alta").DisplayIndex = 1
        dgvClientes.Columns("RazónSocial").DisplayIndex = 2
        dgvClientes.Columns("CUIT").DisplayIndex = 3
        dgvClientes.Columns("Dirección").DisplayIndex = 4
        dgvClientes.Columns("Localidad").DisplayIndex = 5
        dgvClientes.Columns("Provincia").DisplayIndex = 6
        dgvClientes.Columns("CP").DisplayIndex = 7
        dgvClientes.Columns("País").DisplayIndex = 8
        dgvClientes.Columns("Teléfono").DisplayIndex = 9
        dgvClientes.Columns("Mail").DisplayIndex = 10
        dgvClientes.Columns("Web").DisplayIndex = 11
        dgvClientes.Columns("CreditoAsignado").DisplayIndex = 12
        dgvClientes.Columns("CreditoConsumido").DisplayIndex = 13
        dgvClientes.Columns("Estado").DisplayIndex = 14
        dgvClientes.Columns("Clasificación").DisplayIndex = 15

        dgvClientes.Columns("idClientes").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvClientes.Columns("Alta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvClientes.Columns("RazónSocial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("CUIT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvClientes.Columns("Dirección").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Localidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Provincia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("CP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvClientes.Columns("País").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Teléfono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Mail").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Web").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("CreditoAsignado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvClientes.Columns("CreditoConsumido").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvClientes.Columns("Estado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvClientes.Columns("Clasificación").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvClientes.ColumnHeadersVisible = False
    End Sub

    Private Sub Guiones(ByRef _cliente As Clientes)
        If txtDireccion.Text = "" Then
            _cliente.Direccion = "-"
        End If

        If txtLocalidad.Text = "" Then
            _cliente.Localidad = "-"
        End If

        If cbxProvincia.Text = "" Then
            _cliente.Provincia = "-"
        End If

        If txtCP.Text = "" Then
            _cliente.CodPostal = "-"
        End If

        If txtPais.Text = "" Then
            _cliente.Pais = "-"
        End If

        If txtTelefono.Text = "" Then
            _cliente.Telefono = "-"
        End If

        If txtWeb.Text = "" Then
            _cliente.Web = "-"
        End If

        If txtCUIT.Text = "" Then
            _cliente.CUIT = "-"
        End If

        If txtIIBB.Text = "" Then
            _cliente.IIBB = "-"
        End If

        If txtMail.Text = "" Then
            _cliente.Mail = "-"
        End If
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()

        txtFecha.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        txtCredAsignado.Text = Format(10000, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdCliente.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Cliente.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            txtFecha.Text = dgvClientes.CurrentRow.Cells("Alta").Value
            txtRazonSocial.Text = dgvClientes.CurrentRow.Cells("RazónSocial").Value
            txtDireccion.Text = dgvClientes.CurrentRow.Cells("Dirección").Value
            txtLocalidad.Text = dgvClientes.CurrentRow.Cells("Localidad").Value
            cbxProvincia.Text = dgvClientes.CurrentRow.Cells("Provincia").Value
            txtCP.Text = dgvClientes.CurrentRow.Cells("CP").Value
            txtPais.Text = dgvClientes.CurrentRow.Cells("País").Value
            txtTelefono.Text = dgvClientes.CurrentRow.Cells("Teléfono").Value
            txtMail.Text = dgvClientes.CurrentRow.Cells("Mail").Value
            txtWeb.Text = dgvClientes.CurrentRow.Cells("Web").Value
            txtCUIT.Text = dgvClientes.CurrentRow.Cells("CUIT").Value
            txtIIBB.Text = dgvClientes.CurrentRow.Cells("IIBB").Value
            cmbSitIVA.Text = dgvClientes.CurrentRow.Cells("SituacionIVA").Value
            txtCredAsignado.Text = dgvClientes.CurrentRow.Cells("CreditoAsignado").Value
            cmbClasificacion.Text = dgvClientes.CurrentRow.Cells("Clasificación").Value
            cmbSitIVA.Text = dgvClientes.CurrentRow.Cells("SituacionIVA").Value

            Activar()
        End If
    End Sub

    Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdCliente.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Cliente.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Cliente ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO CLIENTE")

                If Await Tareas.Eliminar(txtIdCliente.Text) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Cliente eliminado con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnGuardar_ClickAsync(sender As Object, e As EventArgs) Handles btnGuardar.Click
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
                    Dim _cliente As New Clientes(txtFecha.Text, txtRazonSocial.Text, txtDireccion.Text, txtLocalidad.Text, cbxProvincia.Text,
                                                 txtCP.Text, txtPais.Text, txtTelefono.Text, txtMail.Text, txtWeb.Text, txtCUIT.Text, txtIIBB.Text,
                                                 cmbSitIVA.Text, UtilidadesVarias.SoloNumeros(txtCredAsignado.Text), cmbClasificacion.Text)

                    If txtOrigen.Text = "Nuevo" Then
                        Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Cliente ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("GUARDANDO CLIENTE")

                            Guiones(_cliente)

                            If Await Tareas.Servicio_Insertar(_cliente) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Cliente guardado con exito !", Botones.OK, Iconos.OK)

                                Cancelar()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                            End If
                        End If
                    ElseIf txtOrigen.Text = "Modificar" Then
                        Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Cliente ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("MODIFICANDO CLIENTE")

                            _cliente.IdCliente = CInt(txtIdCliente.Text)

                            Guiones(_cliente)

                            If Await Tareas.Servicio_Modificar(_cliente) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Cliente modificado con exito !", Botones.OK, Iconos.OK)

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

    Private Sub DgvClientes_CellClickk(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        If e.RowIndex > -1 Then
            txtIdCliente.Text = dgvClientes.CurrentRow.Cells("idClientes").Value

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
            cmbClasificacion.SelectionLength = Len(cmbClasificacion.Text)
            cmbClasificacion.Select()
        End If
    End Sub

    Private Sub cmbClasificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbClasificacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCredAsignado.SelectionLength = Len(txtCredAsignado.Text)
            txtCredAsignado.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCredAsignado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredAsignado.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        ElseIf Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ChrW(46) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
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

    Private Sub cmbClasificacion_Validated(sender As Object, e As EventArgs) Handles cmbClasificacion.Validated
        If cmbClasificacion.Text = "" Or cmbClasificacion.Text = "-" Then
            cmbClasificacion.Text = "Bueno"
        End If
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
    Private Sub txtCredAsignado_TextChanged(sender As Object, e As EventArgs) Handles txtCredAsignado.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtCredAsignado, AddressOf txtCredAsignado_TextChanged, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)

        If txtCredAsignado.Text = "" Then
            txtCredAsignado.Text = Format(10000, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")

            txtCredAsignado.SelectionLength = Len(txtCredAsignado.Text)
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim listFiltrada As List(Of Clientes)

        UtilidadesDGV.DescargarDGV(dgvClientes)

        If txtBuscar.Text <> "" Then
            listFiltrada = UtilidadesListas.FiltarLista(Of Clientes)(listCompleta, "RazonSocial", txtBuscar.Text)
        Else
            listFiltrada = listCompleta
        End If

        TareasClientes.LlenarDGV(dgvClientes, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvClientes, DataGridViewAutoSizeColumnsMode.DisplayedCells)
    End Sub
#End Region
End Class