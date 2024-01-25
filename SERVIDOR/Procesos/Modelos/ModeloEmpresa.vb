Imports AccesoDatos

Public Class ModeloEmpresa
    Inherits EnlaceTransacciones(Of TransaccionesEmpresa)

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
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesEmpresa(), "EMPRESA")

        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idEmpresa As Integer, razonSocial As String, direccion As String, localidad As String, provincia As String, codPostal As String,
                   pais As String, tE As String, mail As String, cUIT As String, iIBB As String, inicioActividad As Date, prefijoFacturacion As String,
                   web As String, condicionIVA As String, logo As String, ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesEmpresa(), "EMPRESA")

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
        Me.Err = err
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

    Public Property AscUsuarios As ModeloUsuario
        Get
            Return _ascUsuarios
        End Get
        Set(value As ModeloUsuario)
            _ascUsuarios = value
        End Set
    End Property

    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As Boolean
        Dim resultado As Integer

        operacion = "INSERTAR"
        idUs = AscUsuarios.IdUsuarios

        EjecutarTransaccion("Insertar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo insertar el nuevo registro en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function Modificar() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        idUs = AscUsuarios.IdUsuarios

        EjecutarTransaccion("Modificar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdEmpresa + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function Eliminar() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"

        EjecutarTransaccion("Eliminar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdEmpresa + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function Consultar() As ModeloEmpresa
        Dim resultado As New TablaEmpresa

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL REGISTRO DE EMPRESA"

        EjecutarTransaccion("Consultar", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloEmpresa With {
                    .IdEmpresa = resultado.idEmpresa,
                    .RazonSocial = resultado.RazonSocial,
                    .Direccion = resultado.Direccion,
                    .Localidad = resultado.Localidad,
                    .Provincia = resultado.Provincia,
                    .CodPostal = resultado.CodPostal,
                    .Pais = resultado.Pais,
                    .TE = resultado.TE,
                    .Mail = resultado.Mail,
                    .CUIT = resultado.CUIT,
                    .IIBB = resultado.IIBB,
                    .InicioActividad = resultado.InicioActividad,
                    .PrefijoFacturacion = resultado.PrefijoFacturacion,
                    .Web = resultado.Web,
                    .CondicionIVA = resultado.CondicionIVA,
                    .Logo = resultado.Logo,
                    .AscUsuarios = New ModeloUsuario With {.IdUsuarios = resultado.ascUsuarios.idUsuario}
                }
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaEmpresa With {
                                                                .RazonSocial = RazonSocial,
                                                                .Direccion = Direccion,
                                                                .Localidad = Localidad,
                                                                .Provincia = Provincia,
                                                                .CodPostal = CodPostal,
                                                                .Pais = Pais,
                                                                .TE = TE,
                                                                .Mail = Mail,
                                                                .CUIT = CUIT,
                                                                .IIBB = IIBB,
                                                                .InicioActividad = InicioActividad,
                                                                .PrefijoFacturacion = PrefijoFacturacion,
                                                                .Web = Web,
                                                                .CondicionIVA = CondicionIVA,
                                                                .Logo = Logo,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaEmpresa With {
                                                                .idEmpresa = IdEmpresa,
                                                                .RazonSocial = RazonSocial,
                                                                .Direccion = Direccion,
                                                                .Localidad = Localidad,
                                                                .Provincia = Provincia,
                                                                .CodPostal = CodPostal,
                                                                .Pais = Pais,
                                                                .TE = TE,
                                                                .Mail = Mail,
                                                                .CUIT = CUIT,
                                                                .IIBB = IIBB,
                                                                .InicioActividad = InicioActividad,
                                                                .PrefijoFacturacion = PrefijoFacturacion,
                                                                .Web = Web,
                                                                .CondicionIVA = CondicionIVA,
                                                                .Logo = Logo,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdEmpresa)
                Case "Consultar"
                    resultado = Me.Transaccion.verRegistro()
                Case Else
                    Err.Identificador = EnumErrores.TRANSACCION_DESCONOCIDA
                    Err.Descripcion = "La transaccion """ + transaccion + """ no se encuentra en el servidor"

                    resultado = Nothing
            End Select
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Err.Identificador = EnumErrores.ERROR_MYSQL
            Err.Descripcion = ex.Message + " | " + ex.StackTrace

            resultado = Nothing
        Catch ex As Exception
            Err.Identificador = EnumErrores.ERROR_GENERAL
            Err.Descripcion = ex.Message + " | " + ex.StackTrace

            resultado = Nothing
        Finally
            detalleResultado = Err.Descripcion

            AñadirOperacion()
        End Try
    End Sub
#End Region
End Class
