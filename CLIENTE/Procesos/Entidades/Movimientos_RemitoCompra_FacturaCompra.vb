Public Class Movimientos_RemitoCompra_FacturaCompra
    Private _idMovimientos_RemitoCompra_FacturaCompra As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascRemitosCompraMovimientos As RemitoCompraMovimientos
    Private _ascFacturaCompraMovimientos As FacturaCompraMovimientos

#Region "CONSTRUCTORES"
    Public Sub New()
        AscRemitosCompraMovimientos = New RemitoCompraMovimientos()
        AscFacturaCompraMovimientos = New FacturaCompraMovimientos()
    End Sub

    Public Sub New(idMovimientos_RemitoCompra_FacturaCompra As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   ascRemitosCompraMovimientos As RemitoCompraMovimientos, ascFacturaCompraMovimientos As FacturaCompraMovimientos)
        Me.IdMovimientos_RemitoCompra_FacturaCompra = idMovimientos_RemitoCompra_FacturaCompra
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscRemitosCompraMovimientos = ascRemitosCompraMovimientos
        Me.AscFacturaCompraMovimientos = ascFacturaCompraMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdMovimientos_RemitoCompra_FacturaCompra As Integer
        Get
            Return _idMovimientos_RemitoCompra_FacturaCompra
        End Get
        Set(value As Integer)
            _idMovimientos_RemitoCompra_FacturaCompra = value
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

    Public Property AscRemitosCompraMovimientos As RemitoCompraMovimientos
        Get
            Return _ascRemitosCompraMovimientos
        End Get
        Set(value As RemitoCompraMovimientos)
            _ascRemitosCompraMovimientos = value
        End Set
    End Property

    Public Property AscFacturaCompraMovimientos As FacturaCompraMovimientos
        Get
            Return _ascFacturaCompraMovimientos
        End Get
        Set(value As FacturaCompraMovimientos)
            _ascFacturaCompraMovimientos = value
        End Set
    End Property
#End Region
End Class
