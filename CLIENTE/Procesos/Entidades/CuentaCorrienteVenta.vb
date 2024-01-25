Public Class CuentaCorrienteVenta
    Private _idCuentaCorrienteVentas As Integer
    Private _Fecha As Date
    Private _FechaVto As Date
    Private _Comprobante As String
    Private _Numero As String
    Private _Detalle As String
    Private _Debito As Double
    Private _Credito As Double
    Private _Eliminado As String
    Private _Visible As String
    Private _ascClientes As Clientes
    Private _ascUsuarios As Usuario

    Private _Saldo As Double

#Region "CONSTRUCTORES"
    Public Sub New()
        AscClientes = New Clientes()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idCuentaCorrienteVentas As Integer, fecha As Date, fechaVto As Date, comprobante As String, numero As String, detalle As String,
                   debito As Double, credito As Double, eliminado As String, visible As String, ascClientes As Clientes, ascUsuarios As Usuario, saldo As Double)
        Me.IdCuentaCorrienteVentas = idCuentaCorrienteVentas
        Me.Fecha = fecha
        Me.FechaVto = fechaVto
        Me.Comprobante = comprobante
        Me.Numero = numero
        Me.Detalle = detalle
        Me.Debito = debito
        Me.Credito = credito
        Me.Eliminado = eliminado
        Me.Visible = visible
        Me.AscClientes = ascClientes
        Me.AscUsuarios = ascUsuarios
        Me.Saldo = saldo
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdCuentaCorrienteVentas As Integer
        Get
            Return _idCuentaCorrienteVentas
        End Get
        Set(value As Integer)
            _idCuentaCorrienteVentas = value
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

    Public Property Comprobante As String
        Get
            Return _Comprobante
        End Get
        Set(value As String)
            _Comprobante = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return _Numero
        End Get
        Set(value As String)
            _Numero = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _Detalle
        End Get
        Set(value As String)
            _Detalle = value
        End Set
    End Property

    Public Property Debito As Double
        Get
            Return _Debito
        End Get
        Set(value As Double)
            _Debito = value
        End Set
    End Property

    Public Property Credito As Double
        Get
            Return _Credito
        End Get
        Set(value As Double)
            _Credito = value
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

    Public Property Visible As String
        Get
            Return _Visible
        End Get
        Set(value As String)
            _Visible = value
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

    Public Property Saldo As Double
        Get
            Return _Saldo
        End Get
        Set(value As Double)
            _Saldo = value
        End Set
    End Property
#End Region
End Class
