Imports AccesoDatos

Public Class ModeloPerfilUsuario
    Inherits EnlaceTransacciones(Of TransaccionesPerfilUsuario)

    Private _IdPerfil As Integer
    Private _NombrePerfil As String
    Private _Accesos(100) As Boolean
    Private _Eliminado As String
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesPerfilUsuario(), "PERFIL USUARIO")

        Err = New Errores()
    End Sub

    Public Sub New(idPerfil As Integer, nombrePerfil As String, accesos() As Boolean, eliminado As String, err As Errores)
        MyBase.New(New TransaccionesPerfilUsuario(), "PERFIL USUARIO")

        Me.IdPerfil = idPerfil
        Me.NombrePerfil = nombrePerfil
        Me.Accesos = accesos
        Me.Eliminado = eliminado
        Me.Err = err
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdPerfil + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdPerfil + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloPerfilUsuario)
        Dim resultado As New List(Of TablaPerfilUsuario)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE PERFILES DE USUARIO"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloPerfilUsuario(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de usuarios de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorId() As ModeloPerfilUsuario
        Dim resultado As New TablaPerfilUsuario

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR PERFIL DE USUARIO IDENTIFICADO POR ID"

        EjecutarTransaccion("ConsultarPorId", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloPerfilUsuario With {
                            .IdPerfil = resultado.IdPerfil,
                            .NombrePerfil = resultado.NombrePerfil,
                            .Accesos = resultado.Accesos
                         }
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ExistePorNombre() As Boolean
        Dim resultado As Boolean

        operacion = "CONSULTAR"
        detalleOperacion = "VERIFICAR SI EXISTE UN PERFIL DE USUARIO CON UN NOMBRE ESPECIFICO"

        EjecutarTransaccion("ExistePorNombre", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloPerfilUsuario(objeto As List(Of TablaPerfilUsuario)) As List(Of ModeloPerfilUsuario)
        Dim perfiles As New List(Of ModeloPerfilUsuario)

        For Each item In objeto
            perfiles.Add(New ModeloPerfilUsuario With {
                            .IdPerfil = item.IdPerfil,
                            .NombrePerfil = item.NombrePerfil,
                            .Accesos = item.Accesos
                         })
        Next

        Return perfiles
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaPerfilUsuario With {
                                                                .NombrePerfil = NombrePerfil,
                                                                .Accesos = Accesos
                                                            })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaPerfilUsuario With {
                                                                .IdPerfil = IdPerfil,
                                                                .NombrePerfil = NombrePerfil,
                                                                .Accesos = Accesos
                                                            })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdPerfil)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ConsultarPorId"
                    resultado = Me.Transaccion.verPerfilUsuarioID(IdPerfil)
                Case "ExistePorNombre"
                    resultado = Me.Transaccion.verExistePerfilPorNombre(NombrePerfil)
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
