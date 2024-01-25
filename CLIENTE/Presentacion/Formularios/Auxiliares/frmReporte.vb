Public Class frmReporte
    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub frmRptCtaCrtVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = Date.Now & " -> IMPRESION DE REPORTES"
    End Sub
End Class