Public Class Stock
    Private _idStock As Integer
    Private _Fecha As Date
    Private _Movimiento As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascArticulos As Articulos
    Private _ascDepositos As Depositos
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New(idStock As Integer, fecha As Date, movimiento As String, cantidad As Double, eliminado As String,
                   ascArticulos As Articulos, ascDepositos As Depositos, ascUsuarios As Usuario)
        Me.IdStock = idStock
        Me.Fecha = fecha
        Me.Movimiento = movimiento
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscDepositos = ascDepositos
        Me.AscUsuarios = ascUsuarios
    End Sub

    Public Sub New()
        AscArticulos = New Articulos()
        AscDepositos = New Depositos()
        AscUsuarios = New Usuario()
    End Sub

#End Region

#Region "PROPIEDADES"
    Public Property IdStock As Integer
        Get
            Return _idStock
        End Get
        Set(value As Integer)
            _idStock = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Movimiento As String
        Get
            Return _Movimiento
        End Get
        Set(value As String)
            _Movimiento = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(value As Double)
            _Cantidad = value
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

    Public Property AscArticulos As Articulos
        Get
            Return _ascArticulos
        End Get
        Set(value As Articulos)
            _ascArticulos = value
        End Set
    End Property

    Public Property AscDepositos As Depositos
        Get
            Return _ascDepositos
        End Get
        Set(value As Depositos)
            _ascDepositos = value
        End Set
    End Property

    Public Property AscUsuarios As Usuario
        Get
            Return _ascUsuarios
        End Get
        Set(value As Usuario)
            _ascUsuarios = value
        End Set
    End Property
#End Region
End Class
