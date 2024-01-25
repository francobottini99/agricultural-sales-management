Public Class TransaccionesPedidosDetalle
    Inherits Transacciones
    Implements ITransaccionesPedidoDetalle

    Public Async Function insRegistro(param As ModeloPedidoDetalle) As Task Implements ITransaccionesGenericas(Of ModeloPedidoDetalle).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PEDIDOS_DETALLE_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloPedidoDetalle) As Task Implements ITransaccionesGenericas(Of ModeloPedidoDetalle).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PEDIDOS_DETALLE_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloPedidoDetalle).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function elimRegistroPorIdPedido(id As Integer) As Task(Of Integer) Implements ITransaccionesPedidoDetalle.elimRegistroPorIdPedido
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.PEDIDOS_DETALLE_ELIMINAR, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistroPorId(id As Integer) As Task(Of ModeloPedidoDetalle) Implements ITransaccionesPedidoDetalle.verRegistroPorId
        Dim result As ModeloPedidoDetalle = Await HttpGET(Of ModeloPedidoDetalle)(Peticiones.PEDIDOS_DETALLE_FILTRAR_POR_ID_PEDIDOS_DETALLE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdCliente(id As Integer) As Task(Of List(Of ModeloPedidoDetalle)) Implements ITransaccionesPedidoDetalle.verRegistrosPorIdCliente
        Dim result As List(Of ModeloPedidoDetalle) = Await HttpGET(Of List(Of ModeloPedidoDetalle))(Peticiones.PEDIDOS_DETALLE_FILTRAR_POR_ID_CLIENTE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdClienteYRemitado(param As ModeloPedidoDetalle) As Task(Of List(Of ModeloPedidoDetalle)) Implements ITransaccionesPedidoDetalle.verRegistrosPorIdClienteYRemitado
        Dim result As List(Of ModeloPedidoDetalle) = Await HttpPOST(Of List(Of ModeloPedidoDetalle))(Peticiones.PEDIDOS_DETALLE_FILTRAR_POR_ID_CLIENTE_REMITADO, param)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosSinRemitar_idCliente(id As Integer) As Task(Of List(Of ModeloPedidoDetalle)) Implements ITransaccionesPedidoDetalle.verRegistrosSinRemitar_Cliente
        Dim result As List(Of ModeloPedidoDetalle) = Await HttpGET(Of List(Of ModeloPedidoDetalle))(Peticiones.PEDIDOS_DETALLE_SIN_REMITAR_CLIENTE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosSinFacturar_idCliente(id As Integer) As Task(Of List(Of ModeloPedidoDetalle)) Implements ITransaccionesPedidoDetalle.verRegistrosSinFacturar_idCliente
        Dim result As List(Of ModeloPedidoDetalle) = Await HttpGET(Of List(Of ModeloPedidoDetalle))(Peticiones.PEDIDOS_DETALLE_SIN_FACTURAR_CLIENTE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdClienteYFacturado(param As ModeloPedidoDetalle) As Task(Of List(Of ModeloPedidoDetalle)) Implements ITransaccionesPedidoDetalle.verRegistrosPorIdClienteYFacturado
        Dim result As List(Of ModeloPedidoDetalle) = Await HttpPOST(Of List(Of ModeloPedidoDetalle))(Peticiones.PEDIDOS_DETALLE_FILTRAR_POR_ID_CLIENTE_FACTURADO, param)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdPedido(id As Integer) As Task(Of List(Of ModeloPedidoDetalle)) Implements ITransaccionesPedidoDetalle.verRegistrosPorIdPedido
        Dim result As List(Of ModeloPedidoDetalle) = Await HttpGET(Of List(Of ModeloPedidoDetalle))(Peticiones.PEDIDOS_DETALLE_FILTRAR_POR_ID_PEDIDOS, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloPedidoDetalle)) Implements ITransaccionesGenericas(Of ModeloPedidoDetalle).verRegistros
        Dim result As List(Of ModeloPedidoDetalle) = Await HttpGET(Of List(Of ModeloPedidoDetalle))(Peticiones.PEDIDOS_DETALLE_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
