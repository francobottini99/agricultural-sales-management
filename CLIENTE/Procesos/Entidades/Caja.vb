Public Class Caja
    Private _idCaja As Integer
    Private _Fecha As Date
    Private _Movimiento As String
    Private _Comprobante As String
    Private _Descripcion As String
    Private _Moneda As String
    Private _Ingreso As Double
    Private _Egreso As Double
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idCaja As Integer, fecha As Date, movimiento As String, comprobante As String, descripcion As String, moneda As String,
                   ingreso As Double, egreso As Double, eliminado As String, ascUsuarios As Usuario, observaciones As String)
        Me.IdCaja = idCaja
        Me.Fecha = fecha
        Me.Movimiento = movimiento
        Me.Comprobante = comprobante
        Me.Descripcion = descripcion
        Me.Moneda = moneda
        Me.Ingreso = ingreso
        Me.Egreso = egreso
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.Observaciones = observaciones
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdCaja As Integer
        Get
            Return _idCaja
        End Get
        Set(value As Integer)
            _idCaja = value
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

    Public Property Comprobante As String
        Get
            Return _Comprobante
        End Get
        Set(value As String)
            _Comprobante = value
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

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Ingreso As Double
        Get
            Return _Ingreso
        End Get
        Set(value As Double)
            _Ingreso = value
        End Set
    End Property

    Public Property Egreso As Double
        Get
            Return _Egreso
        End Get
        Set(value As Double)
            _Egreso = value
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

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property

#End Region
End Class
