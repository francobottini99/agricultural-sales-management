Public Interface ITransaccionesMovimientoValores
    Inherits ITransaccionesGenericas(Of ModeloMovimientoValores)
    Function Servicio_insRegistro(param As ModeloMovimientoValores) As Task
    Function Servicio_elimRegistro(param As ModeloMovimientoValores) As Task
End Interface
