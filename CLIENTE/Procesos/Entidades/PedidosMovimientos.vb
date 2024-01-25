Public Class PedidosMovimientos
    Private _IdPedidosMovimientos As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _AscUsuarios As Usuario
    Private _AscPedidosDetalle As PedidosDetalle
    Private _AscStock As Stock

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
        AscPedidosDetalle = New PedidosDetalle()
        AscStock = New Stock()
    End Sub

    Public Sub New(idPedidosMovimientos As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   ascUsuarios As Usuario, ascPedidosDetalle As PedidosDetalle, ascStock As Stock)
        Me.IdPedidosMovimientos = idPedidosMovimientos
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscPedidosDetalle = ascPedidosDetalle
        Me.AscStock = ascStock
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdPedidosMovimientos As Integer
        Get
            Return _IdPedidosMovimientos
        End Get
        Set(value As Integer)
            _IdPedidosMovimientos = value
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

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
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

    Public Property AscUsuarios As Usuario
        Get
            Return _AscUsuarios
        End Get
        Set(value As Usuario)
            _AscUsuarios = value
        End Set
    End Property

    Public Property AscPedidosDetalle As PedidosDetalle
        Get
            Return _AscPedidosDetalle
        End Get
        Set(value As PedidosDetalle)
            _AscPedidosDetalle = value
        End Set
    End Property

    Public Property AscStock As Stock
        Get
            Return _AscStock
        End Get
        Set(value As Stock)
            _AscStock = value
        End Set
    End Property
#End Region
End Class
