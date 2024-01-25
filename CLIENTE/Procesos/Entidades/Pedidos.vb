Public Class Pedidos
    Private _idPedidos As Integer
    Private _NroPedido As String
    Private _Fecha As Date
    Private _FechaCierrePedido As Date
    Private _Remitado As String
    Private _Facturado As String
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascUsuarios As Usuario
    Private _ascClientes As Clientes

    Public Sub New()
        AscUsuarios = New Usuario()
        AscClientes = New Clientes()
    End Sub

    Public Sub New(idPedidos As Integer, nroPedido As String, fecha As Date, fechaCierrePedido As Date, remitado As String, facturado As String,
                   Observaciones As String, Eliminado As String, AscUsuarios As Usuario, AscClientes As Clientes)

        Me.IdPedidos = idPedidos
        Me.NroPedido = nroPedido
        Me.Fecha = fecha
        Me.FechaCierrePedido = fechaCierrePedido
        Me.Remitado = remitado
        Me.Facturado = facturado
        Me.Observaciones = Observaciones
        Me.Eliminado = Eliminado
        Me.AscUsuarios = AscUsuarios
        Me.AscClientes = AscClientes
    End Sub

    Public Property IdPedidos As Integer
        Get
            Return _idPedidos
        End Get
        Set(value As Integer)
            _idPedidos = value
        End Set
    End Property

    Public Property NroPedido As String
        Get
            Return _NroPedido
        End Get
        Set(value As String)
            _NroPedido = value
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

    Public Property FechaCierrePedido As Date
        Get
            Return _FechaCierrePedido
        End Get
        Set(value As Date)
            _FechaCierrePedido = value
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

    Public Property Remitado As String
        Get
            Return _Remitado
        End Get
        Set(value As String)
            _Remitado = value
        End Set
    End Property

    Public Property Facturado As String
        Get
            Return _Facturado
        End Get
        Set(value As String)
            _Facturado = value
        End Set
    End Property
End Class
