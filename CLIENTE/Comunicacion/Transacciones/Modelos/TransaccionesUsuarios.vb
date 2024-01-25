Public Class TransaccionesUsuarios
    Inherits Transacciones
    Implements ITransaccionesUsuarios

    Public Async Function insRegistro(param As ModeloUsuario) As Task Implements ITransaccionesGenericas(Of ModeloUsuario).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.USUARIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloUsuario) As Task Implements ITransaccionesGenericas(Of ModeloUsuario).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.USUARIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloUsuario).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.USUARIO_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistroPorNombreYContraseña(nombre As String, contraseña As String) As Task(Of ModeloUsuario) Implements ITransaccionesUsuarios.verRegistroPorNombreYContraseña
        Dim result As ModeloUsuario = Await HttpPOST(Of ModeloUsuario)(Peticiones.USUARIO_LOGIN, New ModeloUsuario With {.Nombre = nombre, .Contraseña = contraseña})

        If Not IsNothing(result) Then
            Validaciones.Token = result.Token
            result.Token = Nothing

            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modFinalizarSesion(param As ModeloUsuario) As Task Implements ITransaccionesUsuarios.modFinalizarSesion
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.USUARIO_FINALIZAR_SESION, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteUsuarioPorIdPerfil(id As Integer) As Task(Of Boolean) Implements ITransaccionesUsuarios.verExisteUsuarioPorIdPerfil
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.USUARIO_FILTRAR_POR_ID_PERFIL_DE_USUARIO, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteUsuarioPorNombre(nombre As String) As Task(Of Boolean) Implements ITransaccionesUsuarios.verExisteUsuarioPorNombre
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.USUARIO_EXISTE, nombre)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloUsuario)) Implements ITransaccionesGenericas(Of ModeloUsuario).verRegistros
        Dim result As List(Of ModeloUsuario) = Await HttpGET(Of List(Of ModeloUsuario))(Peticiones.USUARIO_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloUsuario) As Task Implements ITransaccionesUsuarios.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.USUARIO_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloUsuario) As Task Implements ITransaccionesUsuarios.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.USUARIO_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
