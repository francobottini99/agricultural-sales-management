Public Class TablaPerfilUsuario
    Private Acc(100) As Boolean

    Public Property IdPerfil As Integer
    Public Property NombrePerfil As String
    Public Property Accesos As Boolean()
        Get
            Return Acc
        End Get
        Set(ByVal Valor As Boolean())
            Acc = Valor
        End Set
    End Property
    Public Property Eliminado As String

    Public Sub New()
    End Sub
End Class