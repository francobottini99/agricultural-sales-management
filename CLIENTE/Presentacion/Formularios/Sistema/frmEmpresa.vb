Imports System.IO
Imports Procesos

Public Class frmEmpresa
    Dim _Empresa As Empresa
    Dim Tareas As TareasEmpresa

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

    Private Sub btnCargarImagen_GotFocus(sender As Object, e As EventArgs) Handles btnCargarImagen.GotFocus
        If btnCargarImagen.Enabled = True Then
            btnCargarImagen.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCargarImagen_LostFocus(sender As Object, e As EventArgs) Handles btnCargarImagen.LostFocus
        If btnCargarImagen.Enabled = True Then
            btnCargarImagen.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCargarImagen_MouseEnter(sender As Object, e As EventArgs) Handles btnCargarImagen.MouseEnter
        If btnCargarImagen.Enabled = True Then
            btnCargarImagen.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCargarImagen_MouseLeave(sender As Object, e As EventArgs) Handles btnCargarImagen.MouseLeave
        If btnCargarImagen.Enabled = True Then
            btnCargarImagen.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnBorrarImagen_GotFocus(sender As Object, e As EventArgs) Handles btnBorrarImagen.GotFocus
        If btnBorrarImagen.Enabled = True Then
            btnBorrarImagen.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnBorrarImagen_LostFocus(sender As Object, e As EventArgs) Handles btnBorrarImagen.LostFocus
        If btnBorrarImagen.Enabled = True Then
            btnBorrarImagen.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnBorrarImagen_MouseEnter(sender As Object, e As EventArgs) Handles btnBorrarImagen.MouseEnter
        If btnBorrarImagen.Enabled = True Then
            btnBorrarImagen.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnBorrarImagen_MouseLeave(sender As Object, e As EventArgs) Handles btnBorrarImagen.MouseLeave
        If btnBorrarImagen.Enabled = True Then
            btnBorrarImagen.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub
#End Region

#Region "FORM LOAD"
    Private Sub FrmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a DATOS DE LA EMPRESA"

        Tareas = New TareasEmpresa()

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Cancelar()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub Activar()
        pnlContendorDatos.Enabled = True
        bnfCardImg.Enabled = True

        btnCargarImagen.Enabled = True
        btnBorrarImagen.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False

        btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
        btnModificar.BackColor = Color.FromArgb(35, 35, 35)
        btnBorrarImagen.BackColor = Color.FromArgb(100, 100, 100)
        btnCargarImagen.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminar.BackColor = Color.FromArgb(35, 35, 35)

        txRazonSocial.SelectionLength = txRazonSocial.TextLength
        txRazonSocial.Select()
    End Sub

    Private Async Sub Cancelar()
        Notificaciones.arbirFormProceso("CARGANDO DATOS")

        pnlContendorDatos.Enabled = False
        bnfCardImg.Enabled = False

        UtilidadesTXT.VaciarTxt(Me)

        cbxProvincia.Text = ""
        cbxCatIva.Text = ""

        btnCargarImagen.Enabled = False
        btnBorrarImagen.Enabled = False

        'If Not IsNothing(pbxImagen.Image) Then
        '    pbxImagen.Image.Dispose()
        'End If

        _Empresa = Await Tareas.ConsultarDatosEmpresa()

        If Not IsNothing(_Empresa) Then
            txtIdEmpresa.Text = _Empresa.IdEmpresa
            txRazonSocial.Text = _Empresa.RazonSocial
            txtDireccion.Text = _Empresa.Direccion
            txtLocalidad.Text = _Empresa.Localidad
            cbxProvincia.Text = _Empresa.Provincia
            txtCP.Text = _Empresa.CodPostal
            txtPais.Text = _Empresa.Pais
            txtTelefono.Text = _Empresa.TE
            txtMail.Text = _Empresa.Mail
            txtCuit.Text = _Empresa.CUIT
            txtIIBB.Text = _Empresa.IIBB
            txtInicioAct.Text = _Empresa.InicioActividad
            txtWeb.Text = _Empresa.Web
            txtPrefFac.Text = _Empresa.PrefijoFacturacion
            cbxCatIva.Text = _Empresa.CondicionIVA
            pbxImagen.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(_Empresa.Logo)))

            frmPpal.pbxEmpresa.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(_Empresa.Logo)))
            frmPpal.lblTitulo.Text = "Sistema de Gestion y Venta de Agroinsumos - " + _Empresa.RazonSocial

            DatosSesion._Empresa = _Empresa

            btnNuevo.Enabled = False
            btnModificar.Enabled = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            btnEliminar.Enabled = True

            btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
            btnModificar.BackColor = Color.FromArgb(100, 100, 100)
            btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
            btnBorrarImagen.BackColor = Color.FromArgb(35, 35, 35)
            btnCargarImagen.BackColor = Color.FromArgb(35, 35, 35)
            btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
            btnEliminar.BackColor = Color.FromArgb(100, 100, 100)

            Notificaciones.cerrarFormProceso()

            btnModificar.Select()
        ElseIf Tareas.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
            btnNuevo.Enabled = True
            btnModificar.Enabled = False
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            btnEliminar.Enabled = False

            btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
            btnModificar.BackColor = Color.FromArgb(35, 35, 35)
            btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
            btnBorrarImagen.BackColor = Color.FromArgb(35, 35, 35)
            btnCargarImagen.BackColor = Color.FromArgb(35, 35, 35)
            btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
            btnEliminar.BackColor = Color.FromArgb(35, 35, 35)

            pbxImagen.Image = Presentacion.My.Resources.IconoEmpresa

            Notificaciones.cerrarFormProceso()

            btnNuevo.Select()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        ofdImagen.Filter = "Imagenes|*.BMP;*.JPG;*.GIF;*.PNG"
        ofdImagen.ShowDialog()
    End Sub

    Private Sub BtnBorrarImagen_Click(sender As Object, e As EventArgs) Handles btnBorrarImagen.Click
        pbxImagen.Image.Dispose()
        pbxImagen.Image = Presentacion.My.Resources.IconoEmpresa
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdEmpresa.Text = "" Then
            Notificaciones.MsgBox("No hay datos para eliminar.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar los datos de la Empresa ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO DATOS")

                If Await Tareas.Eliminar(txtIdEmpresa.Text) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Los datos de la Empresa se eliminaron con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdEmpresa.Text = "" Then
            Notificaciones.MsgBox("No hay datos para modificar.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"
            Activar()
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtOrigen.Text = "Nuevo"

        Activar()
    End Sub

    Private Async Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txRazonSocial.Text = "" Then
            Notificaciones.MsgBox("""RAZON SOCIAL"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

            txRazonSocial.SelectionLength = txRazonSocial.TextLength
            txRazonSocial.Select()
        Else
            If txtDireccion.Text = "" Then
                Notificaciones.MsgBox("""DIRECCION"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                txtDireccion.SelectionLength = txtDireccion.TextLength
                txtDireccion.Select()
            Else
                If txtLocalidad.Text = "" Then
                    Notificaciones.MsgBox("""LOCALIDAD"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                    txtLocalidad.SelectionLength = txtLocalidad.TextLength
                    txtLocalidad.Select()
                Else
                    If cbxProvincia.Text = "" Then
                        Notificaciones.MsgBox("""PROVINCIA"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                        cbxProvincia.SelectionLength = Len(cbxProvincia.Text)
                        cbxProvincia.Select()
                    Else
                        If txtCP.Text = "" Then
                            Notificaciones.MsgBox("""CODIGO POSTAL"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                            txtCP.SelectionLength = txtCP.TextLength
                            txtCP.Select()
                        Else
                            If txtPais.Text = "" Then
                                Notificaciones.MsgBox("""PAIS"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                                txtPais.SelectionLength = txtPais.TextLength
                                txtPais.Select()
                            Else
                                If txtInicioAct.Text = "" Then
                                    Notificaciones.MsgBox("""INICIO DE ACTIVIDAD"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                                    txtInicioAct.SelectionLength = txtInicioAct.TextLength
                                    txtInicioAct.Select()
                                Else
                                    If cbxCatIva.Text = "" Then
                                        Notificaciones.MsgBox("""CATEGORIA DE IVA"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                                        cbxCatIva.SelectionLength = Len(cbxCatIva.Text)
                                        cbxCatIva.Select()
                                    Else
                                        If txtCuit.Text = "" Then
                                            Notificaciones.MsgBox("""CUIT"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                                            txtCuit.SelectionLength = txtCuit.TextLength
                                            txtCuit.Select()
                                        Else
                                            If txtIIBB.Text = "" Then
                                                Notificaciones.MsgBox("""INGRESOS BRUTOS"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                                                txtIIBB.SelectionLength = txtIIBB.TextLength
                                                txtIIBB.Select()
                                            Else
                                                If txtPrefFac.Text = "" Then
                                                    Notificaciones.MsgBox("""PREFIJO DE FACTURACION"" es un campo obligatorio.", Botones.OK, Iconos.ERR)

                                                    txtPrefFac.SelectionLength = txtIIBB.TextLength
                                                    txtPrefFac.Select()
                                                Else
                                                    If txtTelefono.Text = "" Then
                                                        txtTelefono.Text = "-"
                                                    End If

                                                    If txtMail.Text = "" Then
                                                        txtMail.Text = "-"
                                                    End If

                                                    If txtWeb.Text = "" Then
                                                        txtWeb.Text = "-"
                                                    End If

                                                    Dim ImgMs As New MemoryStream
                                                    pbxImagen.Image.Save(ImgMs, pbxImagen.Image.RawFormat)

                                                    Dim _empresa As Empresa = New Empresa(txRazonSocial.Text, txtDireccion.Text, txtLocalidad.Text, cbxProvincia.Text, txtCP.Text,
                                                                                          txtPais.Text, txtTelefono.Text, txtMail.Text, txtCuit.Text, txtIIBB.Text, Format(CDate(txtInicioAct.Text), "dd/MM/yyyy"),
                                                                                          txtPrefFac.Text, txtWeb.Text, cbxCatIva.Text, Convert.ToBase64String(ImgMs.ToArray()))

                                                    If txtOrigen.Text = "Nuevo" Then
                                                        Dim resp As DialogResult = Notificaciones.MsgBox("Guardar datos de la Empresa ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                                        If resp = DialogResult.OK Then
                                                            Notificaciones.arbirFormProceso("GUARDANDO DATOS")

                                                            If Await Tareas.Insertar(_empresa) Then
                                                                Notificaciones.cerrarFormProceso()
                                                                Notificaciones.MsgBox("Datos de la Empresa guardados con exito !", Botones.OK, Iconos.OK)

                                                                Cancelar()
                                                            Else
                                                                Notificaciones.cerrarFormProceso()
                                                                Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                                                            End If
                                                        End If
                                                    ElseIf txtOrigen.Text = "Modificar" Then
                                                        Dim resp As DialogResult = Notificaciones.MsgBox("Modificar datos de la Empresa ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                                        If resp = DialogResult.OK Then
                                                            Notificaciones.arbirFormProceso("MODIFICANDO DATOS")

                                                            _empresa.IdEmpresa = CInt(txtIdEmpresa.Text)

                                                            If Await Tareas.Modificar(_empresa) Then
                                                                Notificaciones.cerrarFormProceso()
                                                                Notificaciones.MsgBox("Datos de la Empresa modificados con exito !", Botones.OK, Iconos.OK)

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
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txRazonSocial.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDireccion.SelectionLength = txtDireccion.TextLength
            txtDireccion.Select()
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLocalidad.SelectionLength = txtLocalidad.TextLength
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
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPais.SelectionLength = txtPais.TextLength
            txtPais.Select()
        End If
    End Sub

    Private Sub txtPais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPais.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtTelefono.SelectionLength = txtTelefono.TextLength
            txtTelefono.Select()
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtMail.SelectionLength = txtMail.TextLength
            txtMail.Select()
        End If
    End Sub

    Private Sub txtMail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMail.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtWeb.SelectionLength = txtWeb.TextLength
            txtWeb.Select()
        End If
    End Sub

    Private Sub txtWeb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeb.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtInicioAct.SelectionLength = Len(txtInicioAct.Text)
            txtInicioAct.Select()
        End If
    End Sub

    Private Sub txtInicioAct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInicioAct.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cbxCatIva.SelectionLength = Len(cbxCatIva.Text)
            cbxCatIva.Select()
        End If
    End Sub

    Private Sub cbxCatIvab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCatIva.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCuit.SelectionLength = Len(txtCuit.Text)
            txtCuit.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If cbxCatIva.Text <> "Consumidor Final" And cbxCatIva.Text <> "Sujeto no Categorizado" And cbxCatIva.Text <> "IVA Liberado – Ley Nº 19.640" Then
                If UtilidadesVarias.ValidaCUIT(txtCuit.Text) Then
                    txtIIBB.SelectionLength = Len(txtIIBB.Text)
                    txtIIBB.Select()
                Else
                    Notificaciones.MsgBox("El CUIT ingresado no es válido.", Botones.OK, Iconos.ERR)

                    txtCuit.Select()
                End If
            Else
                txtCuit.Text = "00-00000000-0"
                txtIIBB.SelectionLength = Len(txtIIBB.Text)
                txtIIBB.Select()
            End If
        ElseIf e.KeyChar = ChrW(46) Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            If Asc(e.KeyChar) <> Keys.Back Then
                If txtCuit.Text <> "" And txtCuit.Text <> "-" And txtCuit.Text <> "00-00000000-0" Then
                    If Len(txtCuit.Text) < 13 Then
                        If Len(txtCuit.Text) = 2 Then
                            txtCuit.Text = txtCuit.Text & "-"
                            txtCuit.Select(txtCuit.Text.Length, 0)
                        ElseIf Len(txtCuit.Text) = 11 Then
                            txtCuit.Text = txtCuit.Text & "-"
                            txtCuit.Select(txtCuit.Text.Length, 0)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtIIBB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIIBB.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtPrefFac.SelectionLength = Len(txtPrefFac.Text)
            txtPrefFac.Select()
        End If
    End Sub

    Private Sub txtPrefFac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrefFac.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnGuardar.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtPrefFac.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub txtInicioAct_TextChanged(sender As Object, e As EventArgs) Handles txtInicioAct.TextChanged
        If txtInicioAct.Text = "" Then
            If bnfCardDatos.Enabled = True Then
                txtInicioAct.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtInicioAct.SelectionLength = Len(txtInicioAct.Text)
                txtInicioAct.Select()
            End If
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtInicioAct_Validated(sender As Object, e As EventArgs) Handles txtInicioAct.Validated
        If txtInicioAct.Text <> "" Then
            If Not IsDate(txtInicioAct.Text) Then
                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ERR)

                txtInicioAct.Text = ""
                txtInicioAct.Select()
            Else
                txtInicioAct.Text = Format(CDate(txtInicioAct.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtPrefFac_Validated(sender As Object, e As EventArgs) Handles txtPrefFac.Validated
        If txtPrefFac.Text <> "" Then
            If txtPrefFac.Text.Length <= 4 Then
                If txtPrefFac.Text.Length = 1 Then
                    txtPrefFac.Text = "000" + txtPrefFac.Text
                ElseIf txtPrefFac.Text.Length = 2 Then
                    txtPrefFac.Text = "00" + txtPrefFac.Text
                ElseIf txtPrefFac.Text.Length = 3 Then
                    txtPrefFac.Text = "0" + txtPrefFac.Text
                End If
            Else
                Notificaciones.MsgBox("La longitud maxima del Prefijo de la Factura es de 4 digitos.", Botones.OK, Iconos.ERR)

                txtPrefFac.Text = ""
                txtPrefFac.Select()
            End If
        End If
    End Sub
#End Region

#Region "EVENTOS FILE OK"
    Private Sub OfdImagen_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdImagen.FileOk
        Try
            Dim Foto As Image = Image.FromFile(ofdImagen.FileName)

            If Not IsNothing(pbxImagen.Image) Then
                pbxImagen.Image.Dispose()
            End If

            pbxImagen.Image = Foto
        Catch
            Notificaciones.MsgBox("El formato de la imagen no es compatible con el sistema.", Botones.OK, Iconos.ERR)
        End Try
    End Sub
#End Region
End Class