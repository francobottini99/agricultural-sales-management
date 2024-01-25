Public Class TablaBancos
    Public Property idBancos As Integer
    Public Property Nombre As String
    Public Property Eliminado As String
    Public Property ascUsuarios As TablaUsuarios

    Public Sub New()
        ascUsuarios = New TablaUsuarios()
    End Sub
End Class
