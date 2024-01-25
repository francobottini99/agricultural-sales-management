Public Class Proveedores

    Private _idProveedor As Integer
    Private _FechaAlta As Date
    Private _RazonSocial As String
    Private _Direccion As String
    Private _Localidad As String
    Private _Provincia As String
    Private _CodPostal As String
    Private _Pais As String
    Private _Telefono As String
    Private _Mail As String
    Private _Web As String
    Private _CUIT As String
    Private _IIBB As String
    Private _SituacionIVA As String
    Private _Estado As String
    Private _Eliminado As String
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario
    End Sub

    Public Sub New(idProveedor As Integer, fechaAlta As Date, razonSocial As String, direccion As String, localidad As String,
                   provincia As String, codPostal As String, pais As String, telefono As String, mail As String, web As String,
                   cUIT As String, iIBB As String, situacionIVA As String, estado As String, eliminado As String, ascUsuarios As Usuario)

        Me.IdProveedor = idProveedor
        Me.FechaAlta = fechaAlta
        Me.RazonSocial = razonSocial
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.Provincia = provincia
        Me.CodPostal = codPostal
        Me.Pais = pais
        Me.Telefono = telefono
        Me.Mail = mail
        Me.Web = web
        Me.CUIT = cUIT
        Me.IIBB = iIBB
        Me.SituacionIVA = situacionIVA
        Me.Estado = estado
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
    End Sub

    Public Sub New(fechaAlta As Date, razonSocial As String, direccion As String, localidad As String,
                   provincia As String, codPostal As String, pais As String, telefono As String, mail As String, web As String,
                   cUIT As String, iIBB As String, situacionIVA As String)

        Me.FechaAlta = fechaAlta
        Me.RazonSocial = razonSocial
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.Provincia = provincia
        Me.CodPostal = codPostal
        Me.Pais = pais
        Me.Telefono = telefono
        Me.Mail = mail
        Me.Web = web
        Me.CUIT = cUIT
        Me.IIBB = iIBB
        Me.SituacionIVA = situacionIVA
        Me.Estado = "Habilitado"
        Me.Eliminado = "NO"
        Me.AscUsuarios = DatosSesion._Usuario
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdProveedor As Integer
        Get
            Return _idProveedor
        End Get
        Set(value As Integer)
            _idProveedor = value
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

    Public Property RazonSocial As String
        Get
            Return _RazonSocial
        End Get
        Set(value As String)
            _RazonSocial = value
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

    Public Property Pais As String
        Get
            Return _Pais
        End Get
        Set(value As String)
            _Pais = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Mail As String
        Get
            Return _Mail
        End Get
        Set(value As String)
            _Mail = value
        End Set
    End Property

    Public Property Web As String
        Get
            Return _Web
        End Get
        Set(value As String)
            _Web = value
        End Set
    End Property

    Public Property CUIT As String
        Get
            Return _CUIT
        End Get
        Set(value As String)
            _CUIT = value
        End Set
    End Property

    Public Property IIBB As String
        Get
            Return _IIBB
        End Get
        Set(value As String)
            _IIBB = value
        End Set
    End Property

    Public Property SituacionIVA As String
        Get
            Return _SituacionIVA
        End Get
        Set(value As String)
            _SituacionIVA = value
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
