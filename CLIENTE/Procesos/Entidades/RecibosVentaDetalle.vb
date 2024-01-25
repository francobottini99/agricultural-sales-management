Public Class RecibosVentaDetalle
    Private _idRecibosVentaDetalle As Integer
    Private _MedioPago As String
    Private _NroComprobante As String
    Private _EntidadEmisora As String
    Private _SucursalEntidad As String
    Private _Librador As String
    Private _FechaCobro As Date
    Private _Moneda As String
    Private _Importe As Double
    Private _Eliminado As String
    Private _ascRecibosVenta As RecibosVenta

#Region "CONSTRUCTORES"
    Public Sub New()
        AscRecibosVenta = New RecibosVenta()
    End Sub

    Public Sub New(idRecibosVentaDetalle As Integer, medioPago As String, nroComprobante As String, entidadEmisora As String,
                   sucursalEntidad As String, librador As String, fechaCobro As Date, moneda As String, importe As Double,
                   eliminado As String, ascRecibosVenta As RecibosVenta)
        Me.IdRecibosVentaDetalle = idRecibosVentaDetalle
        Me.MedioPago = medioPago
        Me.NroComprobante = nroComprobante
        Me.EntidadEmisora = entidadEmisora
        Me.SucursalEntidad = sucursalEntidad
        Me.Librador = librador
        Me.FechaCobro = fechaCobro
        Me.Moneda = moneda
        Me.Importe = importe
        Me.Eliminado = eliminado
        Me.AscRecibosVenta = ascRecibosVenta
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRecibosVentaDetalle As Integer
        Get
            Return _idRecibosVentaDetalle
        End Get
        Set(value As Integer)
            _idRecibosVentaDetalle = value
        End Set
    End Property

    Public Property MedioPago As String
        Get
            Return _MedioPago
        End Get
        Set(value As String)
            _MedioPago = value
        End Set
    End Property

    Public Property NroComprobante As String
        Get
            Return _NroComprobante
        End Get
        Set(value As String)
            _NroComprobante = value
        End Set
    End Property

    Public Property EntidadEmisora As String
        Get
            Return _EntidadEmisora
        End Get
        Set(value As String)
            _EntidadEmisora = value
        End Set
    End Property

    Public Property SucursalEntidad As String
        Get
            Return _SucursalEntidad
        End Get
        Set(value As String)
            _SucursalEntidad = value
        End Set
    End Property

    Public Property Librador As String
        Get
            Return _Librador
        End Get
        Set(value As String)
            _Librador = value
        End Set
    End Property

    Public Property FechaCobro As Date
        Get
            Return _FechaCobro
        End Get
        Set(value As Date)
            _FechaCobro = value
        End Set
    End Property

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Importe As Double
        Get
            Return _Importe
        End Get
        Set(value As Double)
            _Importe = value
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

    Public Property AscRecibosVenta As RecibosVenta
        Get
            Return _ascRecibosVenta
        End Get
        Set(value As RecibosVenta)
            _ascRecibosVenta = value
        End Set
    End Property
#End Region
End Class
