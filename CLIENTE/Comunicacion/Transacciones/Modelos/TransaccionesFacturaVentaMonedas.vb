Public Class TransaccionesFacturaVentaMonedas
    Inherits Transacciones
    Implements ITransaccionesFacturaVentaMoneda

    Public Async Function insRegistro(param As ModeloFacturaVentaMonedas) As Task Implements ITransaccionesGenericas(Of ModeloFacturaVentaMonedas).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_VENTA_MONEDAS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloFacturaVentaMonedas) As Task Implements ITransaccionesGenericas(Of ModeloFacturaVentaMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloFacturaVentaMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistroPorIdFacturaVenta(id As Integer) As Task(Of ModeloFacturaVentaMonedas) Implements ITransaccionesFacturaVentaMoneda.verRegistroPorIdFacturaVenta
        Dim result As ModeloFacturaVentaMonedas = Await HttpGET(Of ModeloFacturaVentaMonedas)(Peticiones.FACTURA_DE_VENTA_MONEDAS_FILTRAR_POR_ID_FACTURA_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistroPorIdFacturaVenta(id As Integer) As Task(Of Integer) Implements ITransaccionesFacturaVentaMoneda.elimRegistroPorIdFacturaVenta
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.FACTURA_DE_VENTA_MONEDAS_ELIMINAR_POR_ID_FACTURA_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloFacturaVentaMonedas)) Implements ITransaccionesGenericas(Of ModeloFacturaVentaMonedas).verRegistros
        Dim result As List(Of ModeloFacturaVentaMonedas) = Await HttpGET(Of List(Of ModeloFacturaVentaMonedas))(Peticiones.FACTURA_DE_VENTA_MONEDAS_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
