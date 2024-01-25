Public Class TransaccionesRemitoVentaMonedas
    Inherits Transacciones
    Implements ITransaccionesRemitosVentaMonedas

    Public Async Function insRegistro(param As ModeloRemitosVentaMonedas) As Task Implements ITransaccionesGenericas(Of ModeloRemitosVentaMonedas).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_VENTA_MONEDAS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloRemitosVentaMonedas) As Task Implements ITransaccionesGenericas(Of ModeloRemitosVentaMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloRemitosVentaMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistroPorIdRemitosVenta(id As Integer) As Task(Of ModeloRemitosVentaMonedas) Implements ITransaccionesRemitosVentaMonedas.verRegistroPorIdRemitosVenta
        Dim result As ModeloRemitosVentaMonedas = Await HttpGET(Of ModeloRemitosVentaMonedas)(Peticiones.REMITO_DE_VENTA_MONEDAS_FILTRAR_POR_ID_REMITO_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistroPorIdRemitosVenta(id As Integer) As Task Implements ITransaccionesRemitosVentaMonedas.elimRegistroPorIdRemitosVenta
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.REMITO_DE_VENTA_MONEDAS_ELIMINAR_POR_ID_REMITO_DE_VENTA, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloRemitosVentaMonedas)) Implements ITransaccionesGenericas(Of ModeloRemitosVentaMonedas).verRegistros
        Dim result As List(Of ModeloRemitosVentaMonedas) = Await HttpGET(Of List(Of ModeloRemitosVentaMonedas))(Peticiones.REMITO_DE_VENTA_MONEDAS_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
