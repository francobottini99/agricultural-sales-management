Public Class PedidosDetalle
    Private _idPedidosDetalle As Integer
    Private _Cantidad As Double
    Private _Remitado As String
    Private _Facturado As String
    Private _Eliminado As String
    Private _ascArticulos As Articulos
    Private _ascPedidos As Pedidos

#Region "CONSTRUCTORES"
    Public Sub New()
        AscArticulos = New Articulos
        AscPedidos = New Pedidos
    End Sub

    Public Sub New(idPedidosDetalle As Integer, cantidad As Double, remitado As String, facturado As String,
                   eliminado As String, ascArticulos As Articulos, ascPedidos As Pedidos)

        Me.IdPedidosDetalle = idPedidosDetalle
        Me.Cantidad = cantidad
        Me.Remitado = remitado
        Me.Facturado = facturado
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscPedidos = ascPedidos
    End Sub

#End Region

#Region "PROPIEDADES"
    Public Property IdPedidosDetalle As Integer
        Get
            Return _idPedidosDetalle
        End Get
        Set(value As Integer)
            _idPedidosDetalle = value
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

    Public Property AscPedidos As Pedidos
        Get
            Return _ascPedidos
        End Get
        Set(value As Pedidos)
            _ascPedidos = value
        End Set
    End Property

    Public Property Remitado As String
        Get
            Return _Remitado
        End Get
        Set(value As String)
            _Remitado = value
        End Set
    End Property

    Public Property Facturado As String
        Get
            Return _Facturado
        End Get
        Set(value As String)
            _Facturado = value
        End Set
    End Property
#End Region

End Class
