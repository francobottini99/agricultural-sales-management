Public Class RespuestaHTTP(Of Entidad)
    Private _Cuerpo As Entidad
    Private _Err As Errores

    Public Sub New()

    End Sub

    Public Sub New(cuerpo As Entidad, err As Errores)
        Me.Cuerpo = cuerpo
        Me.Err = err
    End Sub

    Public Property Cuerpo As Entidad
        Get
            Return _Cuerpo
        End Get
        Set(value As Entidad)
            _Cuerpo = value
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
