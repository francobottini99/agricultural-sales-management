Public Class RemitoVentaMovimientos
    Private _idRemitosVentasMovimientos As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascUsuarios As Usuario
    Private _ascDetalleRemitoVenta As DetalleRemitoVenta
    Private _ascStock As Stock

#Region "CONSTRUCTORES"
    Public Sub New()
        ascUsuarios = New Usuario()
        ascDetalleRemitoVenta = New DetalleRemitoVenta()
        ascStock = New Stock()
    End Sub

    Public Sub New(idRemitosVentasMovimientos As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   ascUsuarios As Usuario, ascDetalleRemitoVenta As DetalleRemitoVenta, ascStock As Stock)
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscDetalleRemitoVenta = ascDetalleRemitoVenta
        Me.AscStock = ascStock
        Me.IdRemitosVentasMovimientos = idRemitosVentasMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"
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
            Return _ascUsuarios
        End Get
        Set(value As Usuario)
            _ascUsuarios = value
        End Set
    End Property

    Public Property AscDetalleRemitoVenta As DetalleRemitoVenta
        Get
            Return _ascDetalleRemitoVenta
        End Get
        Set(value As DetalleRemitoVenta)
            _ascDetalleRemitoVenta = value
        End Set
    End Property

    Public Property AscStock As Stock
        Get
            Return _ascStock
        End Get
        Set(value As Stock)
            _ascStock = value
        End Set
    End Property

    Public Property IdRemitosVentasMovimientos As Integer
        Get
            Return _idRemitosVentasMovimientos
        End Get
        Set(value As Integer)
            _idRemitosVentasMovimientos = value
        End Set
    End Property
#End Region
End Class
