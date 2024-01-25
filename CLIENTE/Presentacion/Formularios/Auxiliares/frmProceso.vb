Public Class frmProceso
    Dim Orientacion As Integer = 1

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
End Class