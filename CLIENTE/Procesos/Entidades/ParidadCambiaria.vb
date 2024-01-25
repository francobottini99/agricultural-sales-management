Public Class ParidadCambiaria

    Private _idParidadCambiaria As Integer
    Private _Fecha As DateTime
    Private _CotizacionCompra As Double
    Private _CotizacionVenta As Double
    Private _Eliminado As String
    Private _ascMonedas As Monedas

#Region "CONSTRUCTORES"
    Public Sub New()
        AscMonedas = New Monedas
    End Sub

    Public Sub New(idParidadCambiaria As Integer, fecha As Date, cotizacionCompra As Double,
                   cotizacionVenta As Double, eliminado As String, ascMonedas As Monedas)

        Me.IdParidadCambiaria = idParidadCambiaria
        Me.Fecha = fecha
        Me.CotizacionCompra = cotizacionCompra
        Me.CotizacionVenta = cotizacionVenta
        Me.Eliminado = eliminado
        Me.AscMonedas = ascMonedas
    End Sub

#End Region

#Region "PROPIEDADES"
    Public Property IdParidadCambiaria As Integer
        Get
            Return _idParidadCambiaria
        End Get
        Set(value As Integer)
            _idParidadCambiaria = value
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

    Public Property CotizacionCompra As Double
        Get
            Return _CotizacionCompra
        End Get
        Set(value As Double)
            _CotizacionCompra = value
        End Set
    End Property

    Public Property CotizacionVenta As Double
        Get
            Return _CotizacionVenta
        End Get
        Set(value As Double)
            _CotizacionVenta = value
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

    Public Property AscMonedas As Monedas
        Get
            Return _ascMonedas
        End Get
        Set(value As Monedas)
            _ascMonedas = value
        End Set
    End Property

#End Region

End Class
