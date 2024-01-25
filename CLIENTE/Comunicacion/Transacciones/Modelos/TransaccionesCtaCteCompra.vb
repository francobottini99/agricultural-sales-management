Public Class TransaccionesCtaCteCompra
    Inherits Transacciones
    Implements ITransaccionesCtaCteCompra

    Public Async Function insRegistro(param As ModeloCuentaCorrienteCompra) As Task Implements ITransaccionesGenericas(Of ModeloCuentaCorrienteCompra).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CUENTA_CORRIENTE_DE_COMPRA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloCuentaCorrienteCompra) As Task Implements ITransaccionesGenericas(Of ModeloCuentaCorrienteCompra).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloCuentaCorrienteCompra).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.CUENTA_CORRIENTE_DE_COMPRA_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoID() As Task(Of Integer) Implements ITransaccionesCtaCteCompra.verUltimoID
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.CUENTA_CORRIENTE_DE_COMPRA_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloCuentaCorrienteCompra)) Implements ITransaccionesGenericas(Of ModeloCuentaCorrienteCompra).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Async Function verPorIdProveedores(id As Integer) As Task(Of List(Of ModeloCuentaCorrienteCompra)) Implements ITransaccionesCtaCteCompra.verPorIdProveedores
        Dim result As List(Of ModeloCuentaCorrienteCompra) = Await HttpGET(Of List(Of ModeloCuentaCorrienteCompra))(Peticiones.CUENTA_CORRIENTE_DE_COMPRA_FILTRAR_POR_ID_PROVEEDOR, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
