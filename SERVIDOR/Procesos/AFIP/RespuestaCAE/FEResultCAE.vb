Public Class FEResultCAE
    Private _Obtenido As Boolean
    Private _DetalleResultado As String
    Private _MsgError As String
    Private _Observaciones As String
    Private _CAE As String
    Private _FchVtoCAE As String

    Public Sub New()
    End Sub

    Public Property Obtenido As Boolean
        Get
            Return _Obtenido
        End Get
        Set(value As Boolean)
            _Obtenido = value
        End Set
    End Property

    Public Property DetalleResultado As String
        Get
            Return _DetalleResultado
        End Get
        Set(value As String)
            _DetalleResultado = value
        End Set
    End Property

    Public Property MsgError As String
        Get
            Return _MsgError
        End Get
        Set(value As String)
            _MsgError = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property

    Public Property CAE As String
        Get
            Return _CAE
        End Get
        Set(value As String)
            _CAE = value
        End Set
    End Property

    Public Property FchVtoCAE As String
        Get
            Return _FchVtoCAE
        End Get
        Set(value As String)
            _FchVtoCAE = value
        End Set
    End Property
End Class
