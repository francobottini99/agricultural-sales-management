Public Interface ITransaccionesUsuarios
    Inherits ITransaccionesGenericas(Of ModeloUsuario)
    Function verRegistroPorNombreYContraseña(nombre As String, contraseña As String) As Task(Of ModeloUsuario)
    Function verExisteUsuarioPorIdPerfil(id As Integer) As Task(Of Boolean)
    Function verExisteUsuarioPorNombre(nombre As String) As Task(Of Boolean)
    Function Servicio_insRegistro(param As ModeloUsuario) As Task
    Function Servicio_modRegistro(param As ModeloUsuario) As Task
    Function modFinalizarSesion(param As ModeloUsuario) As Task
End Interface
