Public Class Movimientos_Remito_Factura
    Private _idMovimientos_Remito_Factura As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascRemitosVentaMovimientos As RemitoVentaMovimientos
    Private _ascFacturaVentaMovimientos As FacturaVentaMovimientos

#Region "CONSTRUCTORES"
    Public Sub New()
        AscRemitosVentaMovimientos = New RemitoVentaMovimientos()
        AscFacturaVentaMovimientos = New FacturaVentaMovimientos()
    End Sub

    Public Sub New(fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   idMovimientos_Remito_Factura As Integer, ascRemitosVentaMovimientos As RemitoVentaMovimientos, ascFacturaVentaMovimientos As FacturaVentaMovimientos)
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.IdMovimientos_Remito_Factura = idMovimientos_Remito_Factura
        Me.AscRemitosVentaMovimientos = ascRemitosVentaMovimientos
        Me.AscFacturaVentaMovimientos = ascFacturaVentaMovimientos
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

    Public Property IdMovimientos_Remito_Factura As Integer
        Get
            Return _idMovimientos_Remito_Factura
        End Get
        Set(value As Integer)
            _idMovimientos_Remito_Factura = value
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

    Public Property AscFacturaVentaMovimientos As FacturaVentaMovimientos
        Get
            Return _ascFacturaVentaMovimientos
        End Get
        Set(value As FacturaVentaMovimientos)
            _ascFacturaVentaMovimientos = value
        End Set
    End Property
#End Region
End Class
