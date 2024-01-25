Public Class FacturaVentaMovimientos
    Private _idFacturaVentaMovimientos As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascUsuarios As Usuario
    Private _ascFacturaVentaDetalle As FacturaVentaDetalle

#Region "CONSTRUCTORES"
    Public Sub New()
        AscFacturaVentaDetalle = New FacturaVentaDetalle()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idFacturaVentaMovimientos As Integer, fecha As Date, tipo As String, cantidad As Double, eliminado As String,
                   ascUsuarios As Usuario, ascFacturaVentaDetalle As FacturaVentaDetalle)
        Me.IdFacturaVentaMovimientos = idFacturaVentaMovimientos
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscFacturaVentaDetalle = ascFacturaVentaDetalle
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaVentaMovimientos As Integer
        Get
            Return _idFacturaVentaMovimientos
        End Get
        Set(value As Integer)
            _idFacturaVentaMovimientos = value
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
            Return _ascUsuarios
        End Get
        Set(value As Usuario)
            _ascUsuarios = value
        End Set
    End Property

    Public Property AscFacturaVentaDetalle As FacturaVentaDetalle
        Get
            Return _ascFacturaVentaDetalle
        End Get
        Set(value As FacturaVentaDetalle)
            _ascFacturaVentaDetalle = value
        End Set
    End Property
#End Region
End Class
