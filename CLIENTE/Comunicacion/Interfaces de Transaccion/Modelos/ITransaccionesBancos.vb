Public Interface ITransaccionesBancos
    Inherits ITransaccionesGenericas(Of ModeloBancos)
    Function verExisteBancoPorNombre(nombre As String) As Task(Of Boolean)
    Function Servicio_insRegistro(param As ModeloBancos) As Task
    Function Servicio_modRegistro(param As ModeloBancos) As Task
End Interface
