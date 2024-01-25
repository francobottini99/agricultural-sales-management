Public Class TransaccionesFacturaComMonedas
    Inherits Transacciones
    Implements ITransaccionesFacturaComMonedas

    Public Async Function insRegistro(param As ModeloFacturaComMonedas) As Task Implements ITransaccionesGenericas(Of ModeloFacturaComMonedas).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_MONEDAS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloFacturaComMonedas) As Task Implements ITransaccionesGenericas(Of ModeloFacturaComMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloFacturaComMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function elimRegistroPorIdFacturaCompra(id As Integer) As Task(Of Integer) Implements ITransaccionesFacturaComMonedas.elimRegistroPorIdFacturaCompra
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_MONEDAS_ELIMINAR_POR_ID_FACTURA_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdFacturaCompra(id As Integer) As Task(Of ModeloFacturaComMonedas) Implements ITransaccionesFacturaComMonedas.verRegistrosPorIdFacturaCompra
        Dim result As ModeloFacturaComMonedas = Await HttpGET(Of ModeloFacturaComMonedas)(Peticiones.FACTURA_DE_COMPRA_MONEDAS_FILTRAR_POR_ID_FACTURA_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloFacturaComMonedas)) Implements ITransaccionesGenericas(Of ModeloFacturaComMonedas).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
