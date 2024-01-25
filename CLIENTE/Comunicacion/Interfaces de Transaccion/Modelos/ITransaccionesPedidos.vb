Public Interface ITransaccionesPedidos
    Inherits ITransaccionesGenericas(Of ModeloPedidos)
    Function modFechaCierrePedido(id As Integer, fec As Date) As Task
    Function verUltimoId() As Task(Of Integer)
    Function Servicio_insRegistro(param As ServicioPedidos) As Task
    Function Servicio_modRegistro(param As ServicioPedidos) As Task
    Function Servicio_elimRegistro(param As ServicioPedidos) As Task
    Function verRegistrosModElim() As Task(Of List(Of ModeloPedidos))
    Function verRegistrosSinCompletar() As Task(Of List(Of ModeloPedidos))
End Interface
