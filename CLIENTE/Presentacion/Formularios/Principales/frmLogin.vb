Imports System.IO
Imports System.Runtime.InteropServices
Imports Procesos

Public Class frmLogin

#Region "ANIMACION DE BOTONES"
    Private Sub btnIngresar_GotFocus(sender As Object, e As EventArgs) Handles btnIngresar.GotFocus
        btnIngresar.BackColor = Color.FromArgb(95, 150, 15)
        btnIngresar.ForeColor = Color.White
    End Sub

    Private Sub btnIngresar_LostFocus(sender As Object, e As EventArgs) Handles btnIngresar.LostFocus
        btnIngresar.BackColor = Color.Gray
        btnIngresar.ForeColor = Color.Black
    End Sub

    Private Sub btnIngresar_MouseEnter(sender As Object, e As EventArgs) Handles btnIngresar.MouseEnter
        btnIngresar.BackColor = Color.FromArgb(95, 150, 15)
        btnIngresar.ForeColor = Color.White
    End Sub

    Private Sub btnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles btnIngresar.MouseLeave
        btnIngresar.BackColor = Color.Gray
        btnIngresar.ForeColor = Color.Black
    End Sub

#End Region

#Region "CAPTURA Y ARRASTRE PANTALLA CON MOUSE"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, 274, 61458, 0)
    End Sub
    Private Sub lblLogin_MouseDown(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, 274, 61458, 0)
    End Sub

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, 274, 61458, 0)
    End Sub

#End Region

#Region "EVENTOS CLIC"
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Async Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim Tareas As New TareasUsuario

        Notificaciones.arbirFormProceso("INICIANDO SESION")

        DatosSesion._Usuario = Await Tareas.ObtenerCredenciales(txtUsuario.Text, txtContraseña.Text)

        If Not IsNothing(DatosSesion._Usuario) Then
            frmPpal.pbxUsuario.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(DatosSesion._Usuario.Imagen)))
            frmPpal.lblUsuario.Text = DatosSesion._Usuario.Nombre
            frmPpal.lblCat.Text = DatosSesion._Usuario.Tipo
            frmPpal.lblPerfil.Text = DatosSesion._Usuario.AscPerfilUs.NombrePerfil
            DatosSesion._PerfilUs.IdPerfil = DatosSesion._Usuario.AscPerfilUs.IdPerfil

            If Not IsNothing(DatosSesion._Empresa) Then
                frmPpal.pbxEmpresa.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(DatosSesion._Empresa.Logo)))
                frmPpal.lblTitulo.Text += " - " + DatosSesion._Empresa.RazonSocial
            Else
                frmPpal.pbxEmpresa.Image = My.Resources.IconoEmpresa
            End If

            Notificaciones.cerrarFormProceso()

            Me.Hide()
            UtilidadesVarias.Escalar(frmPpal)
            frmPpal.ShowDialog()
            Me.Close()
        Else
            Notificaciones.cerrarFormProceso()

            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

            If Tareas.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then

                btnIngresar.BackColor = Color.Gray
                btnIngresar.ForeColor = Color.Black

                txtContraseña.Text = ""
                SelectNextControl(txtContraseña, False, False, False, False)
            End If
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            SelectNextControl(txtUsuario, True, False, False, True)
        End If
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnIngresar.Select()
        End If
    End Sub

#End Region

#Region "EVENTO LOAD"
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsNothing(DatosSesion._Empresa) Then
            pbxLogo.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(DatosSesion._Empresa.Logo)))
        Else
            pbxLogo.Image = Presentacion.My.Resources.IconoEmpresa
        End If

        txtUsuario.Select()
    End Sub
#End Region

End Class