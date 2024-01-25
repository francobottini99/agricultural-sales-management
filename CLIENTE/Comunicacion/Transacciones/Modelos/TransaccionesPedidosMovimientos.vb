Public Class TransaccionesPedidosMovimientos
    Inherits Transacciones
    Implements ITransaccionesPedidoMovimientos

    Public Async Function insRegistro(param As ModeloPedidoMovimientos) As Task Implements ITransaccionesGenericas(Of ModeloPedidoMovimientos).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PEDIDOS_MOVIMIENTOS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloPedidoMovimientos) As Task Implements ITransaccionesGenericas(Of ModeloPedidoMovimientos).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PEDIDOS_MOVIMIENTOS_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloPedidoMovimientos).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.PEDIDOS_MOVIMIENTOS_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistroPorCampos(param As ModeloPedidoMovimientos) As Task(Of Integer) Implements ITransaccionesPedidoMovimientos.elimRegistroPorCampos
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.PEDIDOS_MOVIMIENTOS_ELIMINAR_POR_MOVIMIENTO_CANTIDAD_ID_PEDIDOS_DETALLE, param)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdPedidoDetalle(id As Integer) As Task(Of List(Of ModeloPedidoMovimientos)) Implements ITransaccionesPedidoMovimientos.verRegistrosPorIdPedidoDetalle
        Dim result As List(Of ModeloPedidoMovimientos) = Await HttpGET(Of List(Of ModeloPedidoMovimientos))(Peticiones.PEDIDOS_MOVIMIENTOS_FILTRAR_POR_ID_PEDIDOS_DETALLE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistroPorIdPedidoDetalle(id As Integer) As Task(Of Integer) Implements ITransaccionesPedidoMovimientos.elimRegistroPorIdPedidoDetalle
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.PEDIDOS_MOVIMIENTOS_ELIMINAR_POR_ID_PEDIDOS_DETALLE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloPedidoMovimientos)) Implements ITransaccionesGenericas(Of ModeloPedidoMovimientos).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
