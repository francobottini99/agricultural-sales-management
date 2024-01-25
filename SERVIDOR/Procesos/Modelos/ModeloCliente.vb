Imports AccesoDatos

Public Class ModeloCliente
    Inherits EnlaceTransacciones(Of TransaccionesClientes)

    Private _idCliente As Integer
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
    Private _CreditoAsignado As Double
    Private _CreditoConsumido As Double
    Private _Estado As String
    Private _Clasificacion As String
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesClientes(), "CLIENTES")

        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idCliente As Integer, fechaAlta As Date, razonSocial As String, direccion As String, localidad As String, provincia As String,
                   codPostal As String, pais As String, telefono As String, mail As String, web As String, cUIT As String, iIBB As String,
                   situacionIVA As String, creditoAsignado As Double, creditoConsumido As Double, estado As String, clasificacion As String,
                   eliminado As String, ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesClientes(), "CLIENTES")

        Me.IdCliente = idCliente
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
        Me.CreditoAsignado = creditoAsignado
        Me.CreditoConsumido = creditoConsumido
        Me.Estado = estado
        Me.Clasificacion = clasificacion
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
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

    Public Property CreditoAsignado As Double
        Get
            Return _CreditoAsignado
        End Get
        Set(value As Double)
            _CreditoAsignado = value
        End Set
    End Property

    Public Property CreditoConsumido As Double
        Get
            Return _CreditoConsumido
        End Get
        Set(value As Double)
            _CreditoConsumido = value
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

    Public Property Clasificacion As String
        Get
            Return _Clasificacion
        End Get
        Set(value As String)
            _Clasificacion = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdCliente + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdCliente + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloCliente)
        Dim resultado As New List(Of TablaClientes)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE CLIENTES"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Clientes(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ExistePorNombre() As String()
        Dim resultado(2) As String

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN CLIENTE CON UN NOMBRE ESPECIFICO"

        EjecutarTransaccion("ExistePorNombre", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ExistePorNombreYCuit() As String()
        Dim resultado(2) As String

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN CLIENTE CON UN CUIT Y NOMBRE ESPECIFICO"

        EjecutarTransaccion("ExistePorNombreYCuit", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ExistePorCuit() As String()
        Dim resultado(2) As String

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN CLIENTE CON UN CUIT ESPECIFICO"

        EjecutarTransaccion("ExistePorCuit", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function RecuperarEliminado() As Boolean
        Dim resultado As Integer

        operacion = "RECUPERAR"
        detalleOperacion = "REINGRESA UN CLIENTE ELIMINADO AL SISTEMA"

        EjecutarTransaccion("RecuperarEliminado", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo reingresar el cliente [ID: " + IdCliente + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ConsultarPorId() As ModeloCliente
        Dim resultado As New TablaClientes

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR UN CLIENTE POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.Clientes(resultado)
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
                    resultado = Me.Transaccion.insRegistro(Drivers.Clientes(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.Clientes(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdCliente)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ExistePorNombreYCuit"
                    resultado = Me.Transaccion.verExisteClienteNombreCuit(RazonSocial, CUIT)
                Case "ExistePorCuit"
                    resultado = Me.Transaccion.verExisteClienteCuit(CUIT)
                Case "ExistePorNombre"
                    resultado = Me.Transaccion.verExisteClienteNombre(RazonSocial)
                Case "RecuperarEliminado"
                    resultado = Me.Transaccion.Recuperar(IdCliente)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorID(IdCliente)
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
