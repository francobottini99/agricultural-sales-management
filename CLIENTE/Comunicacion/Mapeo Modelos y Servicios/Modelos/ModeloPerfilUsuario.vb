Public Class ModeloPerfilUsuario
    Private Acc(100) As Boolean

    Public Property IdPerfil As Integer
    Public Property NombrePerfil As String
    Public Property Accesos As Boolean()
        Get
            Return Acc
        End Get
        Set(value As Boolean())
            Acc = value
        End Set
    End Property
    Public Property Eliminado As String
    Public Property Err As Errores

    Public Sub New()
        Err = New Errores()
    End Sub
End Class
