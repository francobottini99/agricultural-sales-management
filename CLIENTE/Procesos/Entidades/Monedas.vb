Public Class Monedas
    Private _idMonedas As Integer
    Private _Tipo As String
    Private _Moneda As String
    Private _Simbolo As String
    Private _Eliminado As String

#Region "CONSTRUCTORES"
    Public Sub New()
    End Sub

    Public Sub New(idMonedas As Integer, tipo As String, moneda As String, simbolo As String, eliminado As String)
        Me.IdMonedas = idMonedas
        Me.Tipo = tipo
        Me.Moneda = moneda
        Me.Simbolo = simbolo
        Me.Eliminado = eliminado
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdMonedas As Integer
        Get
            Return _idMonedas
        End Get
        Set(value As Integer)
            _idMonedas = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Simbolo As String
        Get
            Return _Simbolo
        End Get
        Set(value As String)
            _Simbolo = value
        End Set
    End Property

    Public Property Eliminado As String
        Get
            Return _Eliminado
        End Get
        Set(value As String)
            _Eliminado = value
        End Set
    End Property
#End Region
End Class
