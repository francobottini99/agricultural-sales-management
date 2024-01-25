Public Interface ITransaccionesClientes
    Inherits ITransaccionesGenericas(Of ModeloCliente)
    Function Recuperar(id As Integer) As Task
    Function verExisteCliente(nombre As String, cuit As String, situacionIva As String) As Task(Of String())
    Function verRegistroPorID(id As Integer) As Task(Of ModeloCliente)
    Function Servicio_insRegistro(param As ModeloCliente) As Task
    Function Servicio_modRegistro(param As ModeloCliente) As Task
End Interface
