Public Class Empresa
    Private _idEmpresa As Integer
    Private _RazonSocial As String
    Private _Direccion As String
    Private _Localidad As String
    Private _Provincia As String
    Private _CodPostal As String
    Private _Pais As String
    Private _TE As String
    Private _Mail As String
    Private _CUIT As String
    Private _IIBB As String
    Private _InicioActividad As Date
    Private _PrefijoFacturacion As String
    Private _Web As String
    Private _CondicionIVA As String
    Private _Logo As String
    Private _ascUsuarios As Usuario

#Region "CONSTRUCTORES"
    Public Sub New()
        AscUsuarios = New Usuario()
    End Sub

    Public Sub New(idEmpresa As Integer, razonSocial As String, direccion As String, localidad As String, provincia As String, codPostal As String,
                   pais As String, tE As String, mail As String, cUIT As String, iIBB As String, inicioActividad As Date, prefijoFacturacion As String,
                   web As String, condicionIVA As String, logo As String, ascUsuarios As Usuario)
        Me.IdEmpresa = idEmpresa
        Me.RazonSocial = razonSocial
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.Provincia = provincia
        Me.CodPostal = codPostal
        Me.Pais = pais
        Me.TE = tE
        Me.Mail = mail
        Me.CUIT = cUIT
        Me.IIBB = iIBB
        Me.InicioActividad = inicioActividad
        Me.PrefijoFacturacion = prefijoFacturacion
        Me.Web = web
        Me.CondicionIVA = condicionIVA
        Me.Logo = logo
        Me.AscUsuarios = ascUsuarios
    End Sub

    Public Sub New(razonSocial As String, direccion As String, localidad As String, provincia As String, codPostal As String,
                   pais As String, tE As String, mail As String, cUIT As String, iIBB As String, inicioActividad As Date,
                   prefijoFacturacion As String, web As String, condicionIVA As String, logo As String)
        Me.RazonSocial = razonSocial
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.Provincia = provincia
        Me.CodPostal = codPostal
        Me.Pais = pais
        Me.TE = tE
        Me.Mail = mail
        Me.CUIT = cUIT
        Me.IIBB = iIBB
        Me.InicioActividad = inicioActividad
        Me.PrefijoFacturacion = prefijoFacturacion
        Me.Web = web
        Me.CondicionIVA = condicionIVA
        Me.Logo = logo
        Me.AscUsuarios = DatosSesion._Usuario
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(value As Integer)
            _idEmpresa = value
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

    Public Property TE As String
        Get
            Return _TE
        End Get
        Set(value As String)
            _TE = value
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

    Public Property InicioActividad As Date
        Get
            Return _InicioActividad
        End Get
        Set(value As Date)
            _InicioActividad = value
        End Set
    End Property

    Public Property PrefijoFacturacion As String
        Get
            Return _PrefijoFacturacion
        End Get
        Set(value As String)
            _PrefijoFacturacion = value
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

    Public Property CondicionIVA As String
        Get
            Return _CondicionIVA
        End Get
        Set(value As String)
            _CondicionIVA = value
        End Set
    End Property

    Public Property Logo As String
        Get
            Return _Logo
        End Get
        Set(value As String)
            _Logo = value
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
