Public Class Devoluciones
    Private _idDevoluciones As Integer
    Private _NroComprobante As String
    Private _Fecha As Date
    Private _Importe As Double
    Private _Observaciones As String
    Private _ImpOriginal As Integer
    Private _ImpCopia As Integer
    Private _Eliminado As String
    Private _ascClientes As Clientes
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscClientes = New Clientes()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idDevoluciones As Integer, nroComprobante As String, fecha As Date, importe As Double, observaciones As String,
                   impOriginal As Integer, impCopia As Integer, eliminado As String, ascClientes As Clientes,
                   ascUsuarios As Usuario)
        Me.IdDevoluciones = idDevoluciones
        Me.NroComprobante = nroComprobante
        Me.Fecha = fecha
        Me.Importe = importe
        Me.Observaciones = observaciones
        Me.ImpOriginal = impOriginal
        Me.ImpCopia = impCopia
        Me.Eliminado = eliminado
        Me.AscClientes = ascClientes
        Me.AscUsuarios = ascUsuarios
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDevoluciones As Integer
        Get
            Return _idDevoluciones
        End Get
        Set(value As Integer)
            _idDevoluciones = value
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

    Public Property Importe As Double
        Get
            Return _Importe
        End Get
        Set(value As Double)
            _Importe = value
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

    Public Property ImpOriginal As Integer
        Get
            Return _ImpOriginal
        End Get
        Set(value As Integer)
            _ImpOriginal = value
        End Set
    End Property

    Public Property ImpCopia As Integer
        Get
            Return _ImpCopia
        End Get
        Set(value As Integer)
            _ImpCopia = value
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
#End Region
End Class
