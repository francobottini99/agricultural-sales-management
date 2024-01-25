Public Interface ITransaccioneDevoluciones
    Inherits ITransaccionesGenericas(Of ModeloDevoluciones)
    Function Servicio_insRegistro(param As ServicioDevoluciones) As Task
End Interface
