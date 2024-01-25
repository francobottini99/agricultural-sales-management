Public Class Usuario
    Private _idUsuario As Integer
    Private _FechaAlta As Date
    Private _Nombre As String
    Private _Tipo As String
    Private _Contraseña As String
    Private _Imagen As String
    Private _Estado As String
    Private _Token As String
    Private _Eliminado As String
    Private _ascPerfilUs As PerfilUsuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscPerfilUs = New PerfilUsuario()
    End Sub

    Public Sub New(idUsuario As Integer, fechaAlta As Date, nombre As String, tipo As String, contraseña As String, imagen As String, estado As String,
                   eliminado As String, ascPerfilUs As PerfilUsuario, token As String)
        Me.IdUsuario = idUsuario
        Me.FechaAlta = fechaAlta
        Me.Nombre = nombre
        Me.Tipo = tipo
        Me.Contraseña = contraseña
        Me.Imagen = imagen
        Me.Estado = estado
        Me.Eliminado = eliminado
        Me.AscPerfilUs = ascPerfilUs
        Me.Token = token
    End Sub

    Public Sub New(nombre As String, tipo As String, contraseña As String, imagen As String, idPerfil As Integer)
        Me.FechaAlta = Date.Now.Date
        Me.Nombre = nombre
        Me.Tipo = tipo
        Me.Contraseña = contraseña
        Me.Imagen = imagen
        Me.Estado = "Habilitado"
        Me.Eliminado = "NO"
        Me.AscPerfilUs = New PerfilUsuario With {.IdPerfil = idPerfil}
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property FechaAlta As Date
        Get
            Return _FechaAlta
        End Get
        Set(value As Date)
            _FechaAlta = value
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

    Public Property Contraseña As String
        Get
            Return _Contraseña
        End Get
        Set(value As String)
            _Contraseña = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(value As String)
            _Imagen = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
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

    Public Property AscPerfilUs As PerfilUsuario
        Get
            Return _ascPerfilUs
        End Get
        Set(value As PerfilUsuario)
            _ascPerfilUs = value
        End Set
    End Property

    Public Property Token As String
        Get
            Return _Token
        End Get
        Set(value As String)
            _Token = value
        End Set
    End Property
#End Region
End Class
