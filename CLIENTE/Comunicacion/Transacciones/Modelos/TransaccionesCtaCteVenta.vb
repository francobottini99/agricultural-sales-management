Public Class TransaccionesCtaCteVenta
    Inherits Transacciones
    Implements ITransaccionesCtaCteVenta

    Public Async Function insRegistro(param As ModeloCuentaCorrienteVenta) As Task Implements ITransaccionesGenericas(Of ModeloCuentaCorrienteVenta).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CUENTA_CORRIENTE_DE_VENTA_INSERTAR, param)
        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloCuentaCorrienteVenta) As Task  Implements ITransaccionesGenericas(Of ModeloCuentaCorrienteVenta).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloCuentaCorrienteVenta).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.CUENTA_CORRIENTE_DE_VENTA_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoID() As Task(Of Integer) Implements ITransaccionesCtaCteVenta.verUltimoID
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.CUENTA_CORRIENTE_DE_VENTA_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloCuentaCorrienteVenta)) Implements ITransaccionesGenericas(Of ModeloCuentaCorrienteVenta).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Async Function verPorIdCliente(id As Integer) As Task(Of List(Of ModeloCuentaCorrienteVenta)) Implements ITransaccionesCtaCteVenta.verPorIdCliente
        Dim result As List(Of ModeloCuentaCorrienteVenta) = Await HttpGET(Of List(Of ModeloCuentaCorrienteVenta))(Peticiones.CUENTA_CORRIENTE_DE_VENTA_FILTRAR_POR_ID_CLIENTE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
