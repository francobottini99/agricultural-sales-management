Public Class ModeloBancos
    Public Property IdBancos As Integer
    Public Property Nombre As String
    Public Property Eliminado As String
    Public Property AscUsuarios As ModeloUsuario
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
    End Sub
End Class
