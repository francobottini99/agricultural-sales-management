Public Class PerfilUsuario
    Private _IdPerfil As Integer
    Private _NombrePerfil As String
    Private _Accesos(100) As Boolean
    Private _Eliminado As String

#Region "CONSTRUCTORES"
    Public Sub New()

    End Sub

    Public Sub New(idPerfil As Integer, nombrePerfil As String, accesos() As Boolean, eliminado As String)
        Me.IdPerfil = idPerfil
        Me.NombrePerfil = nombrePerfil
        Me.Accesos = accesos
        Me.Eliminado = eliminado
    End Sub

    Public Sub New(nombrePerfil As String, accesos() As Boolean, eliminado As String)
        Me.NombrePerfil = nombrePerfil
        Me.Accesos = accesos
        Me.Eliminado = eliminado
    End Sub

#End Region

#Region "PROPIEDADES"
    Public Property IdPerfil As Integer
        Get
            Return _IdPerfil
        End Get
        Set(value As Integer)
            _IdPerfil = value
        End Set
    End Property

    Public Property NombrePerfil As String
        Get
            Return _NombrePerfil
        End Get
        Set(value As String)
            _NombrePerfil = value
        End Set
    End Property

    Public Property Accesos As Boolean()
        Get
            Return _Accesos
        End Get
        Set(value As Boolean())
            _Accesos = value
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
#End Region
End Class
