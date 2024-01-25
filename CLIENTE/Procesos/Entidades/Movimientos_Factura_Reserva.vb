Public Class Movimientos_Factura_Reserva
    Private _idMovimientos_Factura_Reseva As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascFacturaVentaMovimientos As FacturaVentaMovimientos
    Private _ascPedidoMovimientos As PedidosMovimientos

#Region "CONSTRUCTORES"
    Public Sub New()
        AscFacturaVentaMovimientos = New FacturaVentaMovimientos()
        AscPedidoMovimientos = New PedidosMovimientos()
    End Sub

    Public Sub New(idMovimientos_Factura_Reseva As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   ascFacturaVentaMovimientos As FacturaVentaMovimientos, ascPedidoMovimientos As PedidosMovimientos)
        Me.IdMovimientos_Factura_Reseva = idMovimientos_Factura_Reseva
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscFacturaVentaMovimientos = ascFacturaVentaMovimientos
        Me.AscPedidoMovimientos = ascPedidoMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdMovimientos_Factura_Reseva As Integer
        Get
            Return _idMovimientos_Factura_Reseva
        End Get
        Set(value As Integer)
            _idMovimientos_Factura_Reseva = value
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

    Public Property AscFacturaVentaMovimientos As FacturaVentaMovimientos
        Get
            Return _ascFacturaVentaMovimientos
        End Get
        Set(value As FacturaVentaMovimientos)
            _ascFacturaVentaMovimientos = value
        End Set
    End Property

    Public Property AscPedidoMovimientos As PedidosMovimientos
        Get
            Return _ascPedidoMovimientos
        End Get
        Set(value As PedidosMovimientos)
            _ascPedidoMovimientos = value
        End Set
    End Property
#End Region
End Class
