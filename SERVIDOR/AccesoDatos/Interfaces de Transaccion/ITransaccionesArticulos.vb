Public Interface ITransaccionesArticulos
    Inherits ITransaccionesGenericas(Of TablaArticulos)
    Function verRegistrosSinImagenes() As List(Of TablaArticulos)
    Function verImagenPorId(id As Integer) As TablaArticulos
    Function verRegistroPorId(id As Integer) As TablaArticulos
    Function verUltimoId() As TablaArticulos
    Function modCostoRegistro(id As Integer, cost As Double, fec As Date) As Integer
    Function modPrecioRegistro(id As Integer, precio As Double, fec As Date) As Integer
End Interface
