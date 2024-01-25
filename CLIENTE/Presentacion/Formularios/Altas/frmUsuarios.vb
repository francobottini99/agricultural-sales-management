Imports System.IO
Imports Procesos

Public Class frmUsuarios
    Private listUsuariosCompleta As List(Of Usuario)
    Private listPerfilesCompleta As List(Of PerfilUsuario)
    Private _TareasUsuario As TareasUsuario
    Private _TareasPerfilUsuario As TareasPerfilUsuario

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

#Region "LOAD FORM"
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "SIGEVA -> " & Date.Now & " -> Ingreso a ALTAS DE USUARIO"

        _TareasUsuario = New TareasUsuario()
        _TareasPerfilUsuario = New TareasPerfilUsuario()

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        cmbTipo.Items.Add("Administrador")
        cmbTipo.Items.Add("Usuario")

        UtilidadesDGV.FormatoDGVGeneral(dgvUsuarios)

        ConfigDGV_Usuarios()

        Cancelar()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Async Sub Cancelar()
        Notificaciones.arbirFormProceso("CARGANDO USUARIOS")

        pnlContendor.Enabled = False
        bnfCardList.Enabled = True

        UtilidadesTXT.VaciarTxt(Me)

        cmbPerfil.Text = ""
        cmbTipo.Text = ""

        cmbPerfil.Items.Clear()

        btnCargarImagen.Enabled = False
        btnBorrarImagen.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = True

        btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
        btnBorrarImagen.BackColor = Color.FromArgb(35, 35, 35)
        btnCargarImagen.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminar.BackColor = Color.FromArgb(100, 100, 100)

        If Not IsNothing(pbxImagen.Image) Then
            pbxImagen.Image.Dispose()
        End If

        pbxImagen.Image = Presentacion.My.Resources.IconoUsuario

        listUsuariosCompleta = Await _TareasUsuario.ListadoCompleto()

        If Not IsNothing(listUsuariosCompleta) Then
            UtilidadesDGV.DescargarDGV(dgvUsuarios)

            TareasUsuario.LlenarDGV(dgvUsuarios, listUsuariosCompleta)

            UtilidadesDGV.CabeceraDGV(dgvUsuarios)

            Notificaciones.cerrarFormProceso()

            btnNuevo.Select()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasUsuario.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If
    End Sub

    Private Async Sub Activar()
        Notificaciones.arbirFormProceso()

        pnlContendor.Enabled = True
        bnfCardList.Enabled = False

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

        txtBuscar.Text = ""

        listPerfilesCompleta = Await _TareasPerfilUsuario.ListadoCompleto()

        If Not IsNothing(listPerfilesCompleta) Then
            For Each item In listPerfilesCompleta
                cmbPerfil.Items.Add(item.NombrePerfil)
            Next

            If txtOrigen.Text = "Modificar" Then
                txtIdPerfil.Text = dgvUsuarios.CurrentRow.Cells("idPerfil").Value
                cmbPerfil.Text = dgvUsuarios.CurrentRow.Cells("NombrePerfi").Value
            End If

            UtilidadesDGV.DescargarDGV(dgvUsuarios)

            Notificaciones.cerrarFormProceso()

            cmbTipo.SelectionLength = Len(cmbTipo.Text)
            cmbTipo.Select()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasPerfilUsuario.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If
    End Sub

    Private Sub ConfigDGV_Usuarios()
        dgvUsuarios.RowTemplate.Height = 60
        dgvUsuarios.ColumnCount = 8
        dgvUsuarios.Columns(0).Name = "idUsuarios"
        dgvUsuarios.Columns(1).Name = "idPerfil"
        dgvUsuarios.Columns(2).Name = "FechaAlta"
        dgvUsuarios.Columns(3).Name = "Tipo"
        dgvUsuarios.Columns(4).Name = "Nombre"
        dgvUsuarios.Columns(5).Name = "Contraseña"
        dgvUsuarios.Columns(6).Name = "Estado"
        dgvUsuarios.Columns(7).Name = "NombrePerfi"

        dgvUsuarios.RowsDefaultCellStyle.Font = New Font("Trebuchet MS", 12)
        dgvUsuarios.AlternatingRowsDefaultCellStyle.Font = New Font("Trebuchet MS", 12)

        dgvUsuarios.Columns("idUsuarios").Visible = False
        dgvUsuarios.Columns("idPerfil").Visible = False
        dgvUsuarios.Columns("Contraseña").Visible = False

        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsuarios.ColumnHeadersVisible = True

        dgvUsuarios.Columns("FechaAlta").HeaderText = "FECHA ALTA"
        dgvUsuarios.Columns("Tipo").HeaderText = "CATEGORIA"
        dgvUsuarios.Columns("Nombre").HeaderText = "NOMBRE"
        dgvUsuarios.Columns("Contraseña").HeaderText = "CONTRASEÑA"
        dgvUsuarios.Columns("Estado").HeaderText = "ESTADO"
        dgvUsuarios.Columns("NombrePerfi").HeaderText = "PERFIL"

        dgvUsuarios.Columns("FechaAlta").Width = 150

        Dim img As New DataGridViewImageColumn()
        dgvUsuarios.Columns.Add(img)
        img.HeaderText = "FOTO"
        img.Name = "Imagen"
        img.Width = 200
        img.ImageLayout = DataGridViewImageCellLayout.Zoom

        dgvUsuarios.Columns("idUsuarios").DisplayIndex = 0
        dgvUsuarios.Columns("idPerfil").DisplayIndex = 1
        dgvUsuarios.Columns("FechaAlta").DisplayIndex = 2
        dgvUsuarios.Columns("Nombre").DisplayIndex = 3
        dgvUsuarios.Columns("Tipo").DisplayIndex = 4
        dgvUsuarios.Columns("Contraseña").DisplayIndex = 5
        dgvUsuarios.Columns("Estado").DisplayIndex = 6
        dgvUsuarios.Columns("NombrePerfi").DisplayIndex = 7
        dgvUsuarios.Columns("Imagen").DisplayIndex = 8

        dgvUsuarios.ColumnHeadersVisible = False
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        ofdImagen.Filter = "Imagenes|*.BMP;*.JPG;*.GIF;*.PNG"
        ofdImagen.ShowDialog()
    End Sub

    Private Sub BtnBorrarImagen_Click(sender As Object, e As EventArgs) Handles btnBorrarImagen.Click
        pbxImagen.Image.Dispose()
        pbxImagen.Image = Presentacion.My.Resources.Resources.IconoUsuario
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdUsuario.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Usuario.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells("idUsuarios").Value
            cmbTipo.Text = dgvUsuarios.CurrentRow.Cells("Tipo").Value
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells("Nombre").Value
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells("Contraseña").Value
            txtReingreso.Text = txtContraseña.Text
            pbxImagen.Image = dgvUsuarios.CurrentRow.Cells("Imagen").Value

            Activar()
        End If
    End Sub

    Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdUsuario.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Usuario.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Usuario ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO USUARIO")

                If Await _TareasUsuario.Eliminar(txtIdUsuario.Text) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Usuario eliminado con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(_TareasUsuario.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cmbTipo.Text = "" Then
            Notificaciones.MsgBox("""TIPO USUARIO"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
            cmbTipo.Select()
        Else
            If txtNombre.Text = "" Then
                Notificaciones.MsgBox("""NOMBRE USUARIO"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                txtNombre.Select()
            Else
                If txtContraseña.Text <> txtReingreso.Text Or txtContraseña.Text = "" Then
                    Notificaciones.MsgBox("Las contraseñas no coinciden.", Botones.OK, Iconos.ERR)
                    txtReingreso.Text = ""
                    txtContraseña.Text = ""
                    txtContraseña.Select()
                Else
                    If txtIdPerfil.Text = "" Then
                        Notificaciones.MsgBox("No seleccionaste un perfil para el usuario.", Botones.OK, Iconos.ALERTA)
                        cmbPerfil.Select()
                    Else
                        Dim ImgMs As New MemoryStream

                        pbxImagen.Image.Save(ImgMs, pbxImagen.Image.RawFormat)

                        Dim _usuario As Usuario = New Usuario(txtNombre.Text, cmbTipo.Text, txtContraseña.Text,
                                                              Convert.ToBase64String(ImgMs.ToArray()), txtIdPerfil.Text)

                        If txtOrigen.Text = "Nuevo" Then
                            Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Usuario ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                Notificaciones.arbirFormProceso("GUARDANDO USUARIO")

                                If Await _TareasUsuario.Servicio_Insertar(_usuario) Then
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox("Usuario guardado con exito !", Botones.OK, Iconos.OK)

                                    Cancelar()
                                Else
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox(_TareasUsuario.Err.Descripcion, Botones.OK, Iconos.ERR)

                                    txtNombre.Select()
                                End If
                            End If
                        ElseIf txtOrigen.Text = "Modificar" Then
                            Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Usuario ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                Notificaciones.arbirFormProceso("MODIFICANDO USUARIO")

                                _usuario.IdUsuario = CInt(txtIdUsuario.Text)

                                If Await _TareasUsuario.Servicio_Modificar(_usuario) Then
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox("Usuario modificado con exito !", Botones.OK, Iconos.OK)

                                    Cancelar()
                                Else
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox(_TareasUsuario.Err.Descripcion, Botones.OK, Iconos.ERR)

                                    txtNombre.Select()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex > -1 Then
            txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells("idUsuarios").Value

            btnModificar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub cmbTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTipo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cmbPerfil.SelectionLength = Len(cmbPerfil.Text)
            cmbPerfil.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbPerfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPerfil.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNombre.SelectionLength = Len(txtNombre.Text)
            txtNombre.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtContraseña.SelectionLength = Len(txtContraseña.Text)
            txtContraseña.Select()
        End If
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtReingreso.SelectionLength = Len(txtReingreso.Text)
            txtReingreso.Select()
        End If
    End Sub

    Private Sub txtReingreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReingreso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim listFiltrada As List(Of Usuario)

        UtilidadesDGV.DescargarDGV(dgvUsuarios)

        If txtBuscar.Text <> "" Then
            listFiltrada = UtilidadesListas.FiltarLista(Of Usuario)(listUsuariosCompleta, "Nombre", txtBuscar.Text)
        Else
            listFiltrada = listUsuariosCompleta
        End If

        TareasUsuario.LlenarDGV(dgvUsuarios, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvUsuarios)
    End Sub
#End Region

#Region "EVENTOS SELECT INDEX CHANGED"
    Private Sub cmbPerfil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPerfil.SelectedIndexChanged
        If cmbPerfil.Text <> "" Then
            txtIdPerfil.Text = listPerfilesCompleta.Item(cmbPerfil.SelectedIndex).IdPerfil
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