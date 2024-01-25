Public Class Bancos
    Private _idBancos As Integer
    Private _Nombre As String
    Private _Eliminado As String
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idBancos As Integer, nombre As String, eliminado As String, ascUsuarios As Usuario)
        Me.IdBancos = idBancos
        Me.Nombre = nombre
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
        Me.Eliminado = "NO"
        Me.AscUsuarios = DatosSesion._Usuario
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdBancos As Integer
        Get
            Return _idBancos
        End Get
        Set(value As Integer)
            _idBancos = value
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
