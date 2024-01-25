Imports AccesoDatos

Public Class ModeloUsuario
    Inherits EnlaceTransacciones(Of TransaccionesUsuarios)

    Private _idUsuarios As Integer
    Private _FechaAlta As Date
    Private _Nombre As String
    Private _Tipo As String
    Private _Contraseña As String
    Private _Imagen As String
    Private _Estado As String
    Private _Token As String
    Private _Eliminado As String
    Private _ascPerfilUs As ModeloPerfilUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesUsuarios(), "USUARIOS")

        AscPerfilUs = New ModeloPerfilUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idUsuario As Integer, fechaAlta As Date, nombre As String, tipo As String, contraseña As String, imagen As String, estado As String,
                   eliminado As String, ascPerfilUs As ModeloPerfilUsuario, err As Errores, token As String)
        MyBase.New(New TransaccionesUsuarios(), "USUARIOS")

        Me.IdUsuarios = idUsuario
        Me.FechaAlta = fechaAlta
        Me.Nombre = nombre
        Me.Tipo = tipo
        Me.Contraseña = contraseña
        Me.Imagen = imagen
        Me.Estado = estado
        Me.Eliminado = eliminado
        Me.AscPerfilUs = ascPerfilUs
        Me.Err = err
        Me.Token = token
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdUsuarios As Integer
        Get
            Return _idUsuarios
        End Get
        Set(value As Integer)
            _idUsuarios = value
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

    Public Property AscPerfilUs As ModeloPerfilUsuario
        Get
            Return _ascPerfilUs
        End Get
        Set(value As ModeloPerfilUsuario)
            _ascPerfilUs = value
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

    Public Property Token As String
        Get
            Return _Token
        End Get
        Set(value As String)
            _Token = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As Boolean
        Dim resultado As Integer

        operacion = "INSERTAR"

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

        EjecutarTransaccion("Modificar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdUsuarios + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ModificarToken() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICAR EL TOKEN DE AUTENTICACION"

        EjecutarTransaccion("ModificarToken", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdUsuarios + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdUsuarios + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloUsuario)
        Dim resultado As New List(Of TablaUsuarios)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE USUARIOS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloUsuario(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de usuarios de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ValidarCredenciales() As ModeloUsuario
        Dim resultado As New TablaUsuarios

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR LAS CREDENCIALES DEL USUARIO DENTRO DE LA BASE DE DATOS Y DEVOLVER REGISTRO CORRESPONDIENTE AL MISMO"

        EjecutarTransaccion("ValidarCredenciales", resultado)

        If Not IsNothing(resultado) Then
            Token = Guid.NewGuid().ToString()
            IdUsuarios = resultado.idUsuario

            If ModificarToken() Then
                Return New ModeloUsuario With {
                    .IdUsuarios = resultado.idUsuario,
                    .FechaAlta = resultado.FechaAlta,
                    .Tipo = resultado.Tipo,
                    .Nombre = resultado.Nombre,
                    .Contraseña = resultado.Contraseña,
                    .Imagen = resultado.Imagen,
                    .Estado = resultado.Estado,
                    .Token = Token,
                    .Eliminado = resultado.Eliminado,
                    .AscPerfilUs = New ModeloPerfilUsuario With {
                        .IdPerfil = resultado.ascPerfilUs.IdPerfil,
                        .NombrePerfil = resultado.ascPerfilUs.NombrePerfil
                    }
                }
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_AUTETICACION
                    Err.Descripcion = "No se pudo guardar el Token de Autentificacion"
                End If

                Return Nothing
            End If
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "Las credenciales dadas no corresponden a un usuario del sistema"
            End If

            Return Nothing
        End If
    End Function

    Public Function ExistePorIdPerfil() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN USUARIO CON UN ID DE PERFIL ESPECIFICO"

        EjecutarTransaccion("ExistePorIdPerfil", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ExistePorNombre() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN USUARIO CON UN NOMBRE ESPECIFICO"

        EjecutarTransaccion("ExistePorNombre", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloUsuario
        Dim resultado As New TablaUsuarios

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTA UN USUARIO POR SU ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloUsuario With {
                            .IdUsuarios = resultado.idUsuario,
                            .FechaAlta = resultado.FechaAlta,
                            .Tipo = resultado.Tipo,
                            .Nombre = resultado.Nombre,
                            .Contraseña = resultado.Contraseña,
                            .Imagen = resultado.Imagen,
                            .Estado = resultado.Estado,
                            .Eliminado = resultado.Eliminado,
                            .AscPerfilUs = New ModeloPerfilUsuario With {.IdPerfil = resultado.ascPerfilUs.IdPerfil}
                         }
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloUsuario(objeto As List(Of TablaUsuarios)) As List(Of ModeloUsuario)
        Dim usuarios As New List(Of ModeloUsuario)

        For Each item In objeto
            usuarios.Add(New ModeloUsuario With {
                            .IdUsuarios = item.idUsuario,
                            .FechaAlta = item.FechaAlta,
                            .Tipo = item.Tipo,
                            .Nombre = item.Nombre,
                            .Contraseña = item.Contraseña,
                            .Imagen = item.Imagen,
                            .Estado = item.Estado,
                            .Eliminado = item.Eliminado,
                            .AscPerfilUs = New ModeloPerfilUsuario With {
                                .IdPerfil = item.ascPerfilUs.IdPerfil,
                                .NombrePerfil = item.ascPerfilUs.NombrePerfil
                            }
                         })
        Next

        Return usuarios
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaUsuarios With {
                                                                .FechaAlta = FechaAlta,
                                                                .Tipo = Tipo,
                                                                .Nombre = Nombre,
                                                                .Contraseña = Contraseña,
                                                                .Imagen = Imagen,
                                                                .Estado = Estado,
                                                                .ascPerfilUs = New TablaPerfilUsuario With {.IdPerfil = AscPerfilUs.IdPerfil}
                                                            })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaUsuarios With {
                                                                .idUsuario = IdUsuarios,
                                                                .FechaAlta = FechaAlta,
                                                                .Tipo = Tipo,
                                                                .Nombre = Nombre,
                                                                .Contraseña = Contraseña,
                                                                .Imagen = Imagen,
                                                                .Estado = Estado,
                                                                .ascPerfilUs = New TablaPerfilUsuario With {.IdPerfil = AscPerfilUs.IdPerfil}
                                                              })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdUsuarios)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ValidarCredenciales"
                    resultado = Me.Transaccion.verRegistroPorNombreYContraseña(Nombre, Contraseña)
                Case "ExistePorIdPerfil"
                    resultado = Me.Transaccion.verExisteUsuarioPorIdPerfil(AscPerfilUs.IdPerfil)
                Case "ExistePorNombre"
                    resultado = Me.Transaccion.verExisteUsuarioPorNombre(Nombre)
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verRegistroPorId(IdUsuarios)
                Case "ModificarToken"
                    resultado = Me.Transaccion.modRegistro_Token(IdUsuarios, Token)
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
