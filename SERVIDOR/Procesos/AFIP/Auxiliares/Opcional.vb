Public Class Opcional
    Private _Id As String
    Private _Valor As String

    Public Sub New()
    End Sub

    Public Sub New(id As String, valor As String)
        Me.Id = id
        Me.Valor = valor
    End Sub

#Region "PROPIEDADES"
    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(value As String)
            _Id = value
        End Set
    End Property

    Public Property Valor As String
        Get
            Return _Valor
        End Get
        Set(value As String)
            _Valor = value
        End Set
    End Property
#End Region

End Class
