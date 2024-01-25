Public Class OrdenDePago
    Private _idOrdenDePago As Integer
    Private _NroComprobante As String
    Private _Fecha As Date
    Private _ImportePesos As Double
    Private _ImporteDolares As Double
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascUsuarios As Usuario
    Private _ascProveedores As Proveedores
    Private _ascCuentaCorrienteCompra As CuentaCorrienteCompra

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario
        AscProveedores = New Proveedores
        AscCuentaCorrienteCompra = New CuentaCorrienteCompra()
    End Sub

    Public Sub New(idOrdenDePago As Integer, nroComprobante As String, fecha As Date, importePesos As Double, importeDolares As Double,
                   observaciones As String, eliminado As String, ascUsuarios As Usuario, ascProveedores As Proveedores, ascCuentaCorrienteCompra As CuentaCorrienteCompra)
        Me.IdOrdenDePago = idOrdenDePago
        Me.NroComprobante = nroComprobante
        Me.Fecha = fecha
        Me.ImportePesos = importePesos
        Me.ImporteDolares = importeDolares
        Me.Observaciones = observaciones
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscProveedores = ascProveedores
        Me.AscCuentaCorrienteCompra = ascCuentaCorrienteCompra
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdOrdenDePago As Integer
        Get
            Return _idOrdenDePago
        End Get
        Set(value As Integer)
            _idOrdenDePago = value
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

    Public Property AscProveedores As Proveedores
        Get
            Return _ascProveedores
        End Get
        Set(value As Proveedores)
            _ascProveedores = value
        End Set
    End Property

    Public Property AscCuentaCorrienteCompra As CuentaCorrienteCompra
        Get
            Return _ascCuentaCorrienteCompra
        End Get
        Set(value As CuentaCorrienteCompra)
            _ascCuentaCorrienteCompra = value
        End Set
    End Property
#End Region
End Class
