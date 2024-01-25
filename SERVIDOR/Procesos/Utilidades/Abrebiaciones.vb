Public Class Abrebiaciones
    Private _Rubro As String
    Private _SubRubro As String
    Private _Err As Errores

    Public Sub New()
        Err = New Errores()
    End Sub

    Public Sub New(rubro As String, subRubro As String, err As Errores)
        Me.Rubro = rubro
        Me.SubRubro = subRubro
        Me.Err = err
    End Sub

    Public Property Rubro As String
        Get
            Return _Rubro
        End Get
        Set(value As String)
            _Rubro = value
        End Set
    End Property

    Public Property SubRubro As String
        Get
            Return _SubRubro
        End Get
        Set(value As String)
            _SubRubro = value
        End Set
    End Property

    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property
End Class
