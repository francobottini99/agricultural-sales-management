Public Class TransaccionesPerfilUsuario
    Inherits Transacciones
    Implements ITransaccionesPerfilUsuario

    Public Async Function insRegistro(param As ModeloPerfilUsuario) As Task Implements ITransaccionesGenericas(Of ModeloPerfilUsuario).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PERFIL_DE_USUARIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloPerfilUsuario) As Task Implements ITransaccionesGenericas(Of ModeloPerfilUsuario).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PERFIL_DE_USUARIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloPerfilUsuario).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.PERFIL_DE_USUARIO_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExistePerfilPorNombre(nombre As String) As Task(Of Boolean) Implements ITransaccionesPerfilUsuario.verExistePerfilPorNombre
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.PERFIL_DE_USUARIO_EXISTE, nombre)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verPerfilUsuarioID(id As Integer) As Task(Of ModeloPerfilUsuario) Implements ITransaccionesPerfilUsuario.verPerfilUsuarioID
        Dim result As ModeloPerfilUsuario = Await HttpGET(Of ModeloPerfilUsuario)(Peticiones.PERFIL_DE_USUARIO_FILTRAR_POR_ID_PERFIL_DE_USUARIO, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloPerfilUsuario)) Implements ITransaccionesGenericas(Of ModeloPerfilUsuario).verRegistros
        Dim result As List(Of ModeloPerfilUsuario) = Await HttpGET(Of List(Of ModeloPerfilUsuario))(Peticiones.PERFIL_DE_USUARIO_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloPerfilUsuario) As Task Implements ITransaccionesPerfilUsuario.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PERFIL_DE_USUARIO_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloPerfilUsuario) As Task Implements ITransaccionesPerfilUsuario.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PERFIL_DE_USUARIO_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_eliminar(id As Integer) As Task Implements ITransaccionesPerfilUsuario.Servicio_eliminar
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PERFIL_DE_USUARIO_SERVICIO_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
