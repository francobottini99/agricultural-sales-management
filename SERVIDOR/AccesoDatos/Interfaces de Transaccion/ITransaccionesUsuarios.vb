Public Interface ITransaccionesUsuarios
    Inherits ITransaccionesGenericas(Of TablaUsuarios)
    Function verRegistroPorNombreYContraseña(nombre As String, contraseña As String) As TablaUsuarios
    Function verExisteUsuarioPorIdPerfil(id As Integer) As Boolean
    Function verExisteUsuarioPorNombre(nombre As String) As Boolean
    Function verRegistroPorId(id As Integer) As TablaUsuarios
    Function modRegistro_Token(id As Integer, token As String) As Integer
    Function verExisteToken(token As String) As Boolean
End Interface
