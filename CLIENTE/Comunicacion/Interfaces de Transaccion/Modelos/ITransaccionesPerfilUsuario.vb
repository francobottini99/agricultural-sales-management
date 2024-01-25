Public Interface ITransaccionesPerfilUsuario
    Inherits ITransaccionesGenericas(Of ModeloPerfilUsuario)
    Function verExistePerfilPorNombre(nombre As String) As Task(Of Boolean)
    Function verPerfilUsuarioID(id As Integer) As Task(Of ModeloPerfilUsuario)
    Function Servicio_insRegistro(param As ModeloPerfilUsuario) As Task
    Function Servicio_modRegistro(param As ModeloPerfilUsuario) As Task
    Function Servicio_eliminar(id As Integer) As Task

End Interface
