Public Class FacturaCompraMovimientos
    Private _idFacturaCompraMovimientos As Integer
    Private _Fecha As Date
    Private _Tipo As String
    Private _Cantidad As Double
    Private _Eliminado As String
    Private _ascUsuarios As Usuario
    Private _ascFacturaCompraDetalle As FacturaCompraDetalle

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
        AscFacturaCompraDetalle = New FacturaCompraDetalle()
    End Sub

    Public Sub New(idFacturaCompraMovimientos As Integer, fecha As Date, tipo As String, cantidad As Double,
                   eliminado As String, ascUsuarios As Usuario, ascFacturaCompraDetalle As FacturaCompraDetalle)
        Me.IdFacturaCompraMovimientos = idFacturaCompraMovimientos
        Me.Fecha = fecha
        Me.Tipo = tipo
        Me.Cantidad = cantidad
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.AscFacturaCompraDetalle = ascFacturaCompraDetalle
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaCompraMovimientos As Integer
        Get
            Return _idFacturaCompraMovimientos
        End Get
        Set(value As Integer)
            _idFacturaCompraMovimientos = value
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

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(value As Double)
            _Cantidad = value
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

    Public Property AscFacturaCompraDetalle As FacturaCompraDetalle
        Get
            Return _ascFacturaCompraDetalle
        End Get
        Set(value As FacturaCompraDetalle)
            _ascFacturaCompraDetalle = value
        End Set
    End Property
#End Region
End Class
