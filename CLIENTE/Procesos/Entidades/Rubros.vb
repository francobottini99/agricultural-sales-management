Public Class Rubros
    Private _idRubro As Integer
    Private _Abrebiatura As String
    Private _Descripcion As String
    Private _Eliminado As String
    Private _ascUsuarios As New Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idRubro As Integer, abrebiatura As String, descripcion As String, eliminado As String, ascUsuarios As Usuario)
        Me.IdRubro = idRubro
        Me.Abrebiatura = abrebiatura
        Me.Descripcion = descripcion
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
    End Sub

    Public Sub New(abrebiatura As String, descripcion As String)
        Me.Abrebiatura = abrebiatura
        Me.Descripcion = descripcion
        Me.Eliminado = "NO"
        Me.AscUsuarios = DatosSesion._Usuario
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRubro As Integer
        Get
            Return _idRubro
        End Get
        Set(value As Integer)
            _idRubro = value
        End Set
    End Property

    Public Property Abrebiatura As String
        Get
            Return _Abrebiatura
        End Get
        Set(value As String)
            _Abrebiatura = value
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
