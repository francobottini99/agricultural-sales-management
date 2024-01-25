Public Interface ITransaccionesPerfilUsuario
    Inherits ITransaccionesGenericas(Of TablaPerfilUsuario)
    Function verExistePerfilPorNombre(nombre As String) As Boolean
    Function verPerfilUsuarioID(id As Integer) As TablaPerfilUsuario
    Function verUsuarioPorIDperfil(id As Integer) As Boolean
End Interface
