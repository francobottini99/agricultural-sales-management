Public Class MovimientoValores
    Private _idMovimientoValores As Integer
    Private _Fecha As Date
    Private _Movimiento As String
    Private _OrigenDestino As String
    Private _Eliminado As String
    Private _ascValoresEnCartera As ValoresEnCartera
    Private _ascCaja As Caja

#Region "CONSTRUCTORES"
    Public Sub New()
        AscValoresEnCartera = New ValoresEnCartera()
        AscCaja = New Caja()
    End Sub

    Public Sub New(idMovimientoValores As Integer, fecha As Date, movimiento As String, origenDestino As String, eliminado As String,
                   ascValoresEnCartera As ValoresEnCartera, ascCaja As Caja)
        Me.IdMovimientoValores = idMovimientoValores
        Me.Fecha = fecha
        Me.Movimiento = movimiento
        Me.OrigenDestino = origenDestino
        Me.Eliminado = eliminado
        Me.AscValoresEnCartera = ascValoresEnCartera
        Me.AscCaja = ascCaja
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdMovimientoValores As Integer
        Get
            Return _idMovimientoValores
        End Get
        Set(value As Integer)
            _idMovimientoValores = value
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

    Public Property Movimiento As String
        Get
            Return _Movimiento
        End Get
        Set(value As String)
            _Movimiento = value
        End Set
    End Property

    Public Property OrigenDestino As String
        Get
            Return _OrigenDestino
        End Get
        Set(value As String)
            _OrigenDestino = value
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

    Public Property AscValoresEnCartera As ValoresEnCartera
        Get
            Return _ascValoresEnCartera
        End Get
        Set(value As ValoresEnCartera)
            _ascValoresEnCartera = value
        End Set
    End Property

    Public Property AscCaja As Caja
        Get
            Return _ascCaja
        End Get
        Set(value As Caja)
            _ascCaja = value
        End Set
    End Property
#End Region
End Class
