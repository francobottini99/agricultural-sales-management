Public Class TransaccionesRemitoComMonedas
    Inherits Transacciones
    Implements ITransaccionesRemitoComMonedas

    Public Async Function insRegistro(param As ModeloRemitoComMonedas) As Task Implements ITransaccionesGenericas(Of ModeloRemitoComMonedas).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_COMPRA_MONEDAS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloRemitoComMonedas) As Task Implements ITransaccionesGenericas(Of ModeloRemitoComMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloRemitoComMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function elimRegistroPorIdRemitosCompra(id As Integer) As Task Implements ITransaccionesRemitoComMonedas.elimRegistroPorIdRemitosCompra
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.REMITO_DE_COMPRA_MONEDAS_ELIMINAR_POR_ID_REMITO_DE_COMPRA, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistroPorIdRemitosCompra(id As Integer) As Task(Of ModeloRemitoComMonedas) Implements ITransaccionesRemitoComMonedas.verRegistroPorIdRemitosCompra
        Dim result As ModeloRemitoComMonedas = Await HttpGET(Of ModeloRemitoComMonedas)(Peticiones.REMITO_DE_COMPRA_MONEDAS_FILTRAR_POR_ID_REMITO_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloRemitoComMonedas)) Implements ITransaccionesGenericas(Of ModeloRemitoComMonedas).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
