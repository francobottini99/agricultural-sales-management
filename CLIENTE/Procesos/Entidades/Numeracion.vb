Public Class Numeracion
    Private _idNumeracion As Integer
    Private _PuntoVenta As Integer
    Private _Descripcion As String
    Private _NroReserva As Integer
    Private _NroRemito As Integer
    Private _NroDevolucion As Integer
    Private _NroFacturaA As Integer
    Private _NroFacturaB As Integer
    Private _NroFacturaC As Integer
    Private _NroFacturaX As Integer
    Private _NroNotaCreditoA As Integer
    Private _NroNotaCreditoB As Integer
    Private _NroNotaCreditoC As Integer
    Private _NroNotaCreditoX As Integer
    Private _NroNotaDebitoA As Integer
    Private _NroNotaDebitoB As Integer
    Private _NroNotaDebitoC As Integer
    Private _NroNotaDebitoX As Integer
    Private _NroRecibo As Integer
    Private _NroOrdenCompra As Integer
    Private _Eliminado As String
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario
    End Sub

    Public Sub New(idNumeracion As Integer, puntoVenta As Integer, descripcion As String, nroReserva As Integer, nroRemito As Integer,
                   nroDevolucion As Integer, nroFacturaA As Integer, nroFacturaB As Integer, nroFacturaC As Integer, nroFacturaX As Integer, nroNotaCreditoA As Integer,
                   nroNotaCreditoB As Integer, nroNotaCreditoC As Integer, nroNotaCreditoX As Integer, nroNotaDebitoA As Integer,
                   nroNotaDebitoB As Integer, nroNotaDebitoC As Integer, nroNotaDebitoX As Integer, nroRecibo As Integer, nroOrdenCompra As Integer,
                   eliminado As String, ascUsuarios As Usuario)
        Me.IdNumeracion = idNumeracion
        Me.PuntoVenta = puntoVenta
        Me.Descripcion = descripcion
        Me.NroReserva = nroReserva
        Me.NroRemito = nroRemito
        Me.NroDevolucion = nroDevolucion
        Me.NroFacturaA = nroFacturaA
        Me.NroFacturaB = nroFacturaB
        Me.NroFacturaC = nroFacturaC
        Me.NroFacturaX = nroFacturaX
        Me.NroNotaCreditoA = nroNotaCreditoA
        Me.NroNotaCreditoB = nroNotaCreditoB
        Me.NroNotaCreditoC = nroNotaCreditoC
        Me.NroNotaCreditoX = nroNotaCreditoX
        Me.NroNotaDebitoA = nroNotaDebitoA
        Me.NroNotaDebitoB = nroNotaDebitoB
        Me.NroNotaDebitoC = nroNotaDebitoC
        Me.NroNotaDebitoX = nroNotaDebitoX
        Me.NroRecibo = nroRecibo
        Me.NroOrdenCompra = nroOrdenCompra
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdNumeracion As Integer
        Get
            Return _idNumeracion
        End Get
        Set(value As Integer)
            _idNumeracion = value
        End Set
    End Property

    Public Property PuntoVenta As Integer
        Get
            Return _PuntoVenta
        End Get
        Set(value As Integer)
            _PuntoVenta = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property NroReserva As Integer
        Get
            Return _NroReserva
        End Get
        Set(value As Integer)
            _NroReserva = value
        End Set
    End Property

    Public Property NroRemito As Integer
        Get
            Return _NroRemito
        End Get
        Set(value As Integer)
            _NroRemito = value
        End Set
    End Property

    Public Property NroFacturaA As Integer
        Get
            Return _NroFacturaA
        End Get
        Set(value As Integer)
            _NroFacturaA = value
        End Set
    End Property

    Public Property NroFacturaB As Integer
        Get
            Return _NroFacturaB
        End Get
        Set(value As Integer)
            _NroFacturaB = value
        End Set
    End Property

    Public Property NroFacturaC As Integer
        Get
            Return _NroFacturaC
        End Get
        Set(value As Integer)
            _NroFacturaC = value
        End Set
    End Property

    Public Property NroFacturaX As Integer
        Get
            Return _NroFacturaX
        End Get
        Set(value As Integer)
            _NroFacturaX = value
        End Set
    End Property

    Public Property NroNotaCreditoA As Integer
        Get
            Return _NroNotaCreditoA
        End Get
        Set(value As Integer)
            _NroNotaCreditoA = value
        End Set
    End Property

    Public Property NroNotaCreditoB As Integer
        Get
            Return _NroNotaCreditoB
        End Get
        Set(value As Integer)
            _NroNotaCreditoB = value
        End Set
    End Property

    Public Property NroNotaCreditoC As Integer
        Get
            Return _NroNotaCreditoC
        End Get
        Set(value As Integer)
            _NroNotaCreditoC = value
        End Set
    End Property

    Public Property NroNotaCreditoX As Integer
        Get
            Return _NroNotaCreditoX
        End Get
        Set(value As Integer)
            _NroNotaCreditoX = value
        End Set
    End Property

    Public Property NroNotaDebitoA As Integer
        Get
            Return _NroNotaDebitoA
        End Get
        Set(value As Integer)
            _NroNotaDebitoA = value
        End Set
    End Property

    Public Property NroNotaDebitoB As Integer
        Get
            Return _NroNotaDebitoB
        End Get
        Set(value As Integer)
            _NroNotaDebitoB = value
        End Set
    End Property

    Public Property NroNotaDebitoC As Integer
        Get
            Return _NroNotaDebitoC
        End Get
        Set(value As Integer)
            _NroNotaDebitoC = value
        End Set
    End Property

    Public Property NroNotaDebitoX As Integer
        Get
            Return _NroNotaDebitoX
        End Get
        Set(value As Integer)
            _NroNotaDebitoX = value
        End Set
    End Property

    Public Property NroRecibo As Integer
        Get
            Return _NroRecibo
        End Get
        Set(value As Integer)
            _NroRecibo = value
        End Set
    End Property

    Public Property NroOrdenCompra As Integer
        Get
            Return _NroOrdenCompra
        End Get
        Set(value As Integer)
            _NroOrdenCompra = value
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

    Public Property NroDevolucion As Integer
        Get
            Return _NroDevolucion
        End Get
        Set(value As Integer)
            _NroDevolucion = value
        End Set
    End Property
#End Region
End Class
