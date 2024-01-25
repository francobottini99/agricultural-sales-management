Public Interface ITransaccionesDepositos
    Inherits ITransaccionesGenericas(Of ModeloDepositos)
    Function verExisteDepositoPorNombre(nombre As String) As Task(Of Boolean)
    Function Servicio_insRegistro(param As ModeloDepositos) As Task
    Function Servicio_modRegistro(param As ModeloDepositos) As Task
End Interface
