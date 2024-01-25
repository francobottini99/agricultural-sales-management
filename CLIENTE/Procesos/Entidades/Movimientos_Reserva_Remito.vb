Public Class Movimientos_Reserva_Remito
    Private _idMovimientos_Reserva_Remito As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascPedidoMovimientos As PedidosMovimientos
    Private _ascRemitosVentaMovimientos As RemitoVentaMovimientos

#Region "CONSTRUCTORES"
    Public Sub New()
        AscPedidoMovimientos = New PedidosMovimientos()
        AscRemitosVentaMovimientos = New RemitoVentaMovimientos()
    End Sub

    Public Sub New(fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   idMovimientos_Reserva_Remito As Integer, ascPedidoMovimientos As PedidosMovimientos, ascRemitosVentaMovimientos As RemitoVentaMovimientos)
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.IdMovimientos_Reserva_Remito = idMovimientos_Reserva_Remito
        Me.AscPedidoMovimientos = ascPedidoMovimientos
        Me.AscRemitosVentaMovimientos = ascRemitosVentaMovimientos
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

    Public Property IdMovimientos_Reserva_Remito As Integer
        Get
            Return _idMovimientos_Reserva_Remito
        End Get
        Set(value As Integer)
            _idMovimientos_Reserva_Remito = value
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

    Public Property AscRemitosVentaMovimientos As RemitoVentaMovimientos
        Get
            Return _ascRemitosVentaMovimientos
        End Get
        Set(value As RemitoVentaMovimientos)
            _ascRemitosVentaMovimientos = value
        End Set
    End Property
#End Region
End Class
