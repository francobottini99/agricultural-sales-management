Imports System.IO
Imports Procesos

Public Class frmInicioSistema
    Dim Orientacion As Integer = 1

#Region "EVENTO LOAD"
    Private Sub FrmInicioSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UtilidadesVarias.Escalar(Me)
        Me.CenterToScreen()
        Espera.Enabled = True
    End Sub

#End Region

#Region "METODOS PRIVADOS"
    Private Async Sub Espera_TickAsync(sender As Object, e As EventArgs) Handles Espera.Tick
        Dim Tareas As New TareasEmpresa

        Espera.Enabled = False

        For Each item As Screen In Screen.AllScreens
            If item.WorkingArea.Contains(Me.Location) Then
                If item.Bounds.Width < 1176 Or item.Bounds.Height < 664 Then
                    Notificaciones.MsgBox("El sistema no soporta la resolucion de tu pantalla, la minima es 1176x664", Botones.OK, Iconos.ERR)
                    Me.Close()
                End If
            End If
        Next

        DatosSesion._Empresa = Await Tareas.ConsultarDatosEmpresa()

        If Not IsNothing(DatosSesion._Empresa) Then
            Me.Hide()
            UtilidadesVarias.Escalar(frmLogin)
            frmLogin.ShowDialog()
            Me.Close()
        Else
            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
            End
        End If
    End Sub

    Private Sub Animacion_Tick(sender As Object, e As EventArgs) Handles Animacion.Tick
        If Orientacion = 1 Then
            bnfBar.Value += 1
        Else
            bnfBar.Value -= 1
        End If

        If bnfBar.Value = 100 Then
            Orientacion = -1
        ElseIf bnfBar.Value = 0 Then
            Orientacion = 1
        End If
    End Sub
#End Region

End Class