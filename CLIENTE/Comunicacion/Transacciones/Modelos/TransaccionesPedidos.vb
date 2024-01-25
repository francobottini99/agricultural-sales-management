Public Class TransaccionesPedidos
    Inherits Transacciones
    Implements ITransaccionesPedidos

    Public Async Function modFechaCierrePedido(id As Integer, fec As Date) As Task Implements ITransaccionesPedidos.modFechaCierrePedido
        Dim result As String() = Await HttpPOST(Of String())(Peticiones.PEDIDOS_MODIFICAR_FECHA_CIERRE_PEDIDO, New ModeloPedidos With {
                                                                .IdPedidos = id,
                                                                .FechaCierrePedido = fec
                                                            })

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloPedidos) As Task Implements ITransaccionesGenericas(Of ModeloPedidos).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PEDIDOS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloPedidos) As Task Implements ITransaccionesGenericas(Of ModeloPedidos).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PEDIDOS_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloPedidos).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.PEDIDOS_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoId() As Task(Of Integer) Implements ITransaccionesPedidos.verUltimoId
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.PEDIDOS_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloPedidos)) Implements ITransaccionesGenericas(Of ModeloPedidos).verRegistros
        Dim result As List(Of ModeloPedidos) = Await HttpGET(Of List(Of ModeloPedidos))(Peticiones.PEDIDOS_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosModElim() As Task(Of List(Of ModeloPedidos)) Implements ITransaccionesPedidos.verRegistrosModElim
        Dim result As List(Of ModeloPedidos) = Await HttpGET(Of List(Of ModeloPedidos))(Peticiones.PEDIDOS_LISTADO_MOD_ELIM)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosSinCompletar() As Task(Of List(Of ModeloPedidos)) Implements ITransaccionesPedidos.verRegistrosSinCompletar
        Dim result As List(Of ModeloPedidos) = Await HttpGET(Of List(Of ModeloPedidos))(Peticiones.PEDIDOS_LISTADO_SIN_COMPLETAR)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ServicioPedidos) As Task Implements ITransaccionesPedidos.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PEDIDOS_SERVICIO_INSERRTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ServicioPedidos) As Task Implements ITransaccionesPedidos.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PEDIDOS_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_elimRegistro(param As ServicioPedidos) As Task Implements ITransaccionesPedidos.Servicio_elimRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PEDIDOS_SERVICIO_ELIMINAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
