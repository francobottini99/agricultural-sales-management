Public Class Comprobantes
    Private _idComprobantes As Integer
    Private _Nombre As String
    Private _Tipo As String
    Private _Copias As Integer
    Private _Leyenda As String
    Private _Encabezado As String
    Private _LeyendaEnc As String
    Private _Pie As String
    Private _LeyendaPie As String
    Private _CantidadCompEmitidos As Integer
    Private _CantidadCopiasComp As Integer
    Private _Eliminado As String
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idComprobantes As Integer, nombre As String, tipo As String, copias As Integer, leyenda As String, encabezado As String,
                   leyendaEnc As String, pie As String, leyendaPie As String, cantidadCompEmitidos As Integer, cantidadCopiasComp As Integer,
                   eliminado As String, ascUsuarios As Usuario)

        Me.IdComprobantes = idComprobantes
        Me.Nombre = nombre
        Me.Tipo = tipo
        Me.Copias = copias
        Me.Leyenda = leyenda
        Me.Encabezado = encabezado
        Me.LeyendaEnc = leyendaEnc
        Me.Pie = pie
        Me.LeyendaPie = leyendaPie
        Me.CantidadCompEmitidos = cantidadCompEmitidos
        Me.CantidadCopiasComp = cantidadCopiasComp
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
    End Sub

    Public Sub New(nombre As String, tipo As String, copias As Integer, leyenda As String, encabezado As String, leyendaEnc As String, pie As String, leyendaPie As String)
        Me.Nombre = nombre
        Me.Tipo = tipo
        Me.Copias = copias
        Me.Leyenda = leyenda
        Me.Encabezado = encabezado
        Me.LeyendaEnc = leyendaEnc
        Me.Pie = pie
        Me.LeyendaPie = leyendaPie
        Me.CantidadCompEmitidos = 0
        Me.CantidadCopiasComp = 0
        Me.Eliminado = "NO"
        Me.AscUsuarios = DatosSesion._Usuario
    End Sub

#End Region

#Region "PROPIEDADES"
    Public Property IdComprobantes As Integer
        Get
            Return _idComprobantes
        End Get
        Set(value As Integer)
            _idComprobantes = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
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

    Public Property Copias As Integer
        Get
            Return _Copias
        End Get
        Set(value As Integer)
            _Copias = value
        End Set
    End Property

    Public Property Leyenda As String
        Get
            Return _Leyenda
        End Get
        Set(value As String)
            _Leyenda = value
        End Set
    End Property

    Public Property Encabezado As String
        Get
            Return _Encabezado
        End Get
        Set(value As String)
            _Encabezado = value
        End Set
    End Property

    Public Property LeyendaEnc As String
        Get
            Return _LeyendaEnc
        End Get
        Set(value As String)
            _LeyendaEnc = value
        End Set
    End Property

    Public Property Pie As String
        Get
            Return _Pie
        End Get
        Set(value As String)
            _Pie = value
        End Set
    End Property

    Public Property LeyendaPie As String
        Get
            Return _LeyendaPie
        End Get
        Set(value As String)
            _LeyendaPie = value
        End Set
    End Property

    Public Property CantidadCompEmitidos As Integer
        Get
            Return _CantidadCompEmitidos
        End Get
        Set(value As Integer)
            _CantidadCompEmitidos = value
        End Set
    End Property

    Public Property CantidadCopiasComp As Integer
        Get
            Return _CantidadCopiasComp
        End Get
        Set(value As Integer)
            _CantidadCopiasComp = value
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
#End Region

End Class
