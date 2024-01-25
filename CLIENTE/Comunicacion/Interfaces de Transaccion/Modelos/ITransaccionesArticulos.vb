Public Interface ITransaccionesArticulos
    Inherits ITransaccionesGenericas(Of ModeloArticulos)
    Function verRegistrosSinImagenes() As Task(Of List(Of ModeloArticulos))
    Function verImagenPorId(id As Integer) As Task(Of String)
    Function verRegistroPorId(id As Integer) As Task(Of ModeloArticulos)
    Function verUltimoId() As Task(Of Integer)
    Function modCostoRegistro(id As Integer, cost As Double, fec As Date) As Task
    Function modPrecioRegistro(id As Integer, precio As Double, fec As Date) As Task
    Function Servicio_insRegistro(param As ModeloArticulos) As Task
    Function Servicio_modRegistro(param As ModeloArticulos) As Task
End Interface
