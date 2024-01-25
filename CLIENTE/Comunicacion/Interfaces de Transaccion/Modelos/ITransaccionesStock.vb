Public Interface ITransaccionesStock
    Inherits ITransaccionesGenericas(Of ModeloStock)
    Function verUltimoId() As Task(Of Integer)
    Function verStockFisico(idArt As Integer) As Task(Of Integer)
    Function verStockFisico(idArt As Integer, idDep As Integer) As Task(Of Integer)
    Function verStockReservado(idArt As Integer) As Task(Of Integer)
    Function verStockPorIdArticulo(id As Integer) As Task(Of List(Of ModeloStock))
    Function elimRegistroPorCampos(param As ModeloStock) As Task
End Interface
