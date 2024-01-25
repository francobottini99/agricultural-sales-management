Public Interface ITransaccionesClientes
    Inherits ITransaccionesGenericas(Of TablaClientes)
    Function Recuperar(id As Integer) As Integer
    Function verExisteClienteNombre(nombre As String) As String()
    Function verExisteClienteCuit(cuit As String) As String()
    Function verExisteClienteNombreCuit(nombre As String, cuit As String) As String()
    Function verRegistroPorID(id As Integer) As TablaClientes
End Interface
