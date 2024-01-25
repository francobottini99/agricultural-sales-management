Public Interface ITransaccionesRemitosCompra
    Inherits ITransaccionesGenericas(Of ModeloRemitosCompra)
    Function verUltimoId() As Task(Of Integer)
    Function verSinFacturar() As Task(Of List(Of ModeloRemitosCompra))
    Function modEstadoFacturacion(id As Integer, estFac As String) As Task
    Function verRegistroPorId(id As Integer) As Task(Of ModeloRemitosCompra)
    Function Servicio_insRegistro(param As ServicioRemitoCompra) As Task
    Function Servicio_modRegistro(param As ServicioRemitoCompra) As Task
    Function Servicio_elimRegistro(param As ServicioRemitoCompra) As Task
End Interface
