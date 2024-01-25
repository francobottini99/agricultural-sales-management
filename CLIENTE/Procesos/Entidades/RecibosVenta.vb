Public Class RecibosVenta
    Private _idRecibosVenta As Integer
    Private _NroComprobante As String
    Private _Fecha As Date
    Private _ImportePesos As Double
    Private _ImporteDolares As Double
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascUsuarios As Usuario
    Private _ascClientes As Clientes
    Private _ascCuentaCorrienteVenta As CuentaCorrienteVenta

#Region "CONSTRUCTORES"
    Public Sub New()
        AscClientes = New Clientes()
        AscUsuarios = New Usuario()
        AscCuentaCorrienteVenta = New CuentaCorrienteVenta()
    End Sub
    Public Sub New(idRecibosVenta As Integer, nroComprobante As String, fecha As Date, importePesos As Double, importeDolares As Double,
                   observaciones As String, eliminado As String, ascUsuarios As Usuario, ascClientes As Clientes,
                   ascCuentaCorrienteVenta As CuentaCorrienteVenta)
        Me.IdRecibosVenta = idRecibosVenta
        Me.NroComprobante = nroComprobante
        Me.Fecha = fecha
        Me.ImportePesos = importePesos
        Me.ImporteDolares = importeDolares
        Me.Observaciones = observaciones
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscClientes = ascClientes
        Me.AscCuentaCorrienteVenta = ascCuentaCorrienteVenta
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRecibosVenta As Integer
        Get
            Return _idRecibosVenta
        End Get
        Set(value As Integer)
            _idRecibosVenta = value
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

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property ImportePesos As Double
        Get
            Return _ImportePesos
        End Get
        Set(value As Double)
            _ImportePesos = value
        End Set
    End Property

    Public Property ImporteDolares As Double
        Get
            Return _ImporteDolares
        End Get
        Set(value As Double)
            _ImporteDolares = value
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

    Public Property AscClientes As Clientes
        Get
            Return _ascClientes
        End Get
        Set(value As Clientes)
            _ascClientes = value
        End Set
    End Property

    Public Property AscCuentaCorrienteVenta As CuentaCorrienteVenta
        Get
            Return _ascCuentaCorrienteVenta
        End Get
        Set(value As CuentaCorrienteVenta)
            _ascCuentaCorrienteVenta = value
        End Set
    End Property
#End Region

End Class
