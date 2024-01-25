Imports AccesoDatos

Public Class ModeloProveedores
    Inherits EnlaceTransacciones(Of TransaccionesProveedores)

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
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesProveedores(), "PROVEEDORES")

        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
    End Sub

    Public Sub New(idProveedor As Integer, fechaAlta As Date, razonSocial As String, direccion As String, localidad As String,
                   provincia As String, codPostal As String, pais As String, telefono As String, mail As String, web As String,
                   cUIT As String, iIBB As String, situacionIVA As String, estado As String, eliminado As String, ascUsuarios As ModeloUsuario,
                   err As Errores)
        MyBase.New(New TransaccionesProveedores(), "PROVEEDORES")

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
        Me.Err = err
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdProveedor + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdProveedor + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloProveedores)
        Dim resultado As New List(Of TablaProveedores)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE PROVEEDORES"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloProveedores(resultado)
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
        detalleOperacion = "VERIFICAR SI EXISTE UN PROVEEDOR CON UN NOMBRE ESPECIFICO"

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
        detalleOperacion = "VERIFICAR SI EXISTE UN PROVEEDOR CON UN CUIT Y NOMBRE ESPECIFICO"

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
        detalleOperacion = "VERIFICAR SI EXISTE UN PROVEEDOR CON UN CUIT ESPECIFICO"

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
        detalleOperacion = "REINGRESA UN PROVEEDOR ELIMINADO AL SISTEMA"

        EjecutarTransaccion("RecuperarEliminado", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo reingresar el proveedor [ID: " + IdProveedor + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ConsultarPorId() As ModeloProveedores
        Dim resultado As New TablaProveedores

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR UN PROVEEDOR POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloProveedores With {
                                .IdProveedor = resultado.idProveedor,
                                .FechaAlta = resultado.FechaAlta,
                                .RazonSocial = resultado.RazonSocial,
                                .Direccion = resultado.Direccion,
                                .Localidad = resultado.Localidad,
                                .Provincia = resultado.Provincia,
                                .CodPostal = resultado.CodPostal,
                                .Pais = resultado.Pais,
                                .Telefono = resultado.Telefono,
                                .Mail = resultado.Mail,
                                .Web = resultado.Web,
                                .CUIT = resultado.CUIT,
                                .IIBB = resultado.IIBB,
                                .SituacionIVA = resultado.SituacionIVA,
                                .Estado = resultado.Estado,
                                .Eliminado = resultado.Eliminado,
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
    Private Function listModeloProveedores(objeto As List(Of TablaProveedores)) As List(Of ModeloProveedores)
        Dim proveedores As New List(Of ModeloProveedores)

        For Each item In objeto
            proveedores.Add(New ModeloProveedores With {
                                .IdProveedor = item.idProveedor,
                                .FechaAlta = item.FechaAlta,
                                .RazonSocial = item.RazonSocial,
                                .Direccion = item.Direccion,
                                .Localidad = item.Localidad,
                                .Provincia = item.Provincia,
                                .CodPostal = item.CodPostal,
                                .Pais = item.Pais,
                                .Telefono = item.Telefono,
                                .Mail = item.Mail,
                                .Web = item.Web,
                                .CUIT = item.CUIT,
                                .IIBB = item.IIBB,
                                .SituacionIVA = item.SituacionIVA,
                                .Estado = item.Estado,
                                .Eliminado = item.Eliminado,
                                .AscUsuarios = New ModeloUsuario With {.IdUsuarios = item.ascUsuarios.idUsuario}
                            })
        Next

        Return proveedores
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaProveedores With {
                                                                .FechaAlta = FechaAlta,
                                                                .RazonSocial = RazonSocial,
                                                                .Direccion = Direccion,
                                                                .Localidad = Localidad,
                                                                .Provincia = Provincia,
                                                                .CodPostal = CodPostal,
                                                                .Pais = Pais,
                                                                .Telefono = Telefono,
                                                                .Mail = Mail,
                                                                .Web = Web,
                                                                .CUIT = CUIT,
                                                                .IIBB = IIBB,
                                                                .SituacionIVA = SituacionIVA,
                                                                .Estado = Estado,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaProveedores With {
                                                                .idProveedor = IdProveedor,
                                                                .FechaAlta = FechaAlta,
                                                                .RazonSocial = RazonSocial,
                                                                .Direccion = Direccion,
                                                                .Localidad = Localidad,
                                                                .Provincia = Provincia,
                                                                .CodPostal = CodPostal,
                                                                .Pais = Pais,
                                                                .Telefono = Telefono,
                                                                .Mail = Mail,
                                                                .Web = Web,
                                                                .CUIT = CUIT,
                                                                .IIBB = IIBB,
                                                                .SituacionIVA = SituacionIVA,
                                                                .Estado = Estado,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdProveedor)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ExistePorNombreYCuit"
                    resultado = Me.Transaccion.verExisteProveedorNombreCuit(RazonSocial, CUIT)
                Case "ExistePorCuit"
                    resultado = Me.Transaccion.verExisteProveedorCuit(CUIT)
                Case "ExistePorNombre"
                    resultado = Me.Transaccion.verExisteProveedorNombre(RazonSocial)
                Case "RecuperarEliminado"
                    resultado = Me.Transaccion.Recuperar(IdProveedor)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorID(IdProveedor)
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

