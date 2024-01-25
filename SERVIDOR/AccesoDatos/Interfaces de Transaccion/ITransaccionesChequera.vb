Public Interface ITransaccionesChequera
    Inherits ITransaccionesGenericas(Of TablaChequera)
    Function verExisteChequeEnChequera(nro As Integer) As Boolean
    Function verExisteChequera(cta As String, nro As Integer) As Boolean
    Function elimChequesdeChequera(nro As Integer) As Integer
    Function verUltimoID() As TablaChequera
    Function verListadoSinCompletar() As List(Of TablaChequera)
    Function modChqEmitidos(id As Integer, Cant As Integer) As Integer
End Interface
