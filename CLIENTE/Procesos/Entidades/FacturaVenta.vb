Public Class FacturaVenta
    Private _idFacturaVenta As Integer
    Private _TipoComprobante As String
    Private _ClaseComprobante As String
    Private _Fecha As Date
    Private _FechaVto As Date
    Private _Prefijo As String
    Private _NroComprobante As String
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _Iva As Double
    Private _ImporteTotal As Double
    Private _Observaciones As String
    Private _Remitado As String
    Private _Eliminado As String
    Private _CAE As String
    Private _FechaVtoCAE As Date
    Private _ascClientes As Clientes
    Private _ascUsuarios As Usuario
    Private _ascCtaCteVenta As CuentaCorrienteVenta

#Region "CONSTRUCTORES"
    Public Sub New()
        AscClientes = New Clientes()
        AscCtaCteVenta = New CuentaCorrienteVenta()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idFacturaVenta As Integer, tipoComprobante As String, claseComprobante As String, fecha As Date, fechaVto As Date, prefijo As String,
                   nroComprobante As String, importeNeto As Double, descuentoGral As Double, baseImponible As Double, iva As Double, importeTotal As Double,
                   observaciones As String, remitado As String, eliminado As String, cAE As String, fechaVtoCAE As Date, ascClientes As Clientes,
                   ascUsuarios As Usuario, ascCtaCteVenta As CuentaCorrienteVenta)
        Me.IdFacturaVenta = idFacturaVenta
        Me.TipoComprobante = tipoComprobante
        Me.ClaseComprobante = claseComprobante
        Me.Fecha = fecha
        Me.FechaVto = fechaVto
        Me.Prefijo = prefijo
        Me.NroComprobante = nroComprobante
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.Iva = iva
        Me.ImporteTotal = importeTotal
        Me.Observaciones = observaciones
        Me.Remitado = remitado
        Me.Eliminado = eliminado
        Me.CAE = cAE
        Me.FechaVtoCAE = fechaVtoCAE
        Me.AscClientes = ascClientes
        Me.AscUsuarios = ascUsuarios
        Me.AscCtaCteVenta = ascCtaCteVenta
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaVenta As Integer
        Get
            Return _idFacturaVenta
        End Get
        Set(value As Integer)
            _idFacturaVenta = value
        End Set
    End Property

    Public Property TipoComprobante As String
        Get
            Return _TipoComprobante
        End Get
        Set(value As String)
            _TipoComprobante = value
        End Set
    End Property

    Public Property ClaseComprobante As String
        Get
            Return _ClaseComprobante
        End Get
        Set(value As String)
            _ClaseComprobante = value
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

    Public Property FechaVto As Date
        Get
            Return _FechaVto
        End Get
        Set(value As Date)
            _FechaVto = value
        End Set
    End Property

    Public Property Prefijo As String
        Get
            Return _Prefijo
        End Get
        Set(value As String)
            _Prefijo = value
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

    Public Property ImporteNeto As Double
        Get
            Return _ImporteNeto
        End Get
        Set(value As Double)
            _ImporteNeto = value
        End Set
    End Property

    Public Property DescuentoGral As Double
        Get
            Return _DescuentoGral
        End Get
        Set(value As Double)
            _DescuentoGral = value
        End Set
    End Property

    Public Property BaseImponible As Double
        Get
            Return _BaseImponible
        End Get
        Set(value As Double)
            _BaseImponible = value
        End Set
    End Property

    Public Property Iva As Double
        Get
            Return _Iva
        End Get
        Set(value As Double)
            _Iva = value
        End Set
    End Property

    Public Property ImporteTotal As Double
        Get
            Return _ImporteTotal
        End Get
        Set(value As Double)
            _ImporteTotal = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
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

    Public Property Eliminado As String
        Get
            Return _Eliminado
        End Get
        Set(value As String)
            _Eliminado = value
        End Set
    End Property

    Public Property CAE As String
        Get
            Return _CAE
        End Get
        Set(value As String)
            _CAE = value
        End Set
    End Property

    Public Property FechaVtoCAE As Date
        Get
            Return _FechaVtoCAE
        End Get
        Set(value As Date)
            _FechaVtoCAE = value
        End Set
    End Property

    Public Property AscClientes As Clientes
        Get
            Return _ascClientes
        End Get
        Set(value As Clientes)
            _ascClientes = value
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

    Public Property AscCtaCteVenta As CuentaCorrienteVenta
        Get
            Return _ascCtaCteVenta
        End Get
        Set(value As CuentaCorrienteVenta)
            _ascCtaCteVenta = value
        End Set
    End Property
#End Region
End Class
