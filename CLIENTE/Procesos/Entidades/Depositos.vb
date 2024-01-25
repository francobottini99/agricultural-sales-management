Public Class Depositos
    Private _idDeposito As Integer
    Private _Nombre As String
    Private _Direccion As String
    Private _Localidad As String
    Private _Provincia As String
    Private _CodPostal As String
    Private _Eliminado As String
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idDeposito As Integer, nombre As String, direccion As String, localidad As String, provincia As String,
                   codPostal As String, eliminado As String, ascUsuarios As Usuario)
        Me.IdDeposito = idDeposito
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.Provincia = provincia
        Me.CodPostal = codPostal
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
    End Sub

    Public Sub New(nombre As String, direccion As String, localidad As String, provincia As String, codPostal As String)
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.Provincia = provincia
        Me.CodPostal = codPostal
        Me.Eliminado = "NO"
        Me.AscUsuarios = DatosSesion._Usuario
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDeposito As Integer
        Get
            Return _idDeposito
        End Get
        Set(value As Integer)
            _idDeposito = value
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

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(value As String)
            _Provincia = value
        End Set
    End Property

    Public Property CodPostal As String
        Get
            Return _CodPostal
        End Get
        Set(value As String)
            _CodPostal = value
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
