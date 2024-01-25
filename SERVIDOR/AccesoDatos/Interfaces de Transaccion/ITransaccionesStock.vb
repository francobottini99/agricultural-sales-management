Public Interface ITransaccionesStock
    Inherits ITransaccionesGenericas(Of TablaStock)
    Function verUltimoId() As TablaStock
    Function verStockFisico(idArt As Integer) As TablaStock
    Function verStockFisico(idArt As Integer, idDep As Integer) As TablaStock
    Function verStockReservado(idArt As Integer) As TablaStock
    Function verStockPorIdArticulo(id As Integer) As List(Of TablaStock)
    Function elimRegistroPorCampos(param As TablaStock) As Integer
End Interface
