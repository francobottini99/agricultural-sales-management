Public Class TransaccionesValoresEnCartera
    Inherits Transacciones
    Implements ITransaccionesValoresEnCartera

    Public Async Function verListadoDisponible(disponible As String) As Task(Of List(Of ModeloValoresEnCartera)) Implements ITransaccionesValoresEnCartera.verListadoDisponible
        Dim result As List(Of ModeloValoresEnCartera) = Await HttpGET(Of List(Of ModeloValoresEnCartera))(Peticiones.VALORES_EN_CARTERA_LISTADO_DISPONIBLE, disponible)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloValoresEnCartera)) Implements ITransaccionesGenericas(Of ModeloValoresEnCartera).verRegistros
        Dim result As List(Of ModeloValoresEnCartera) = Await HttpGET(Of List(Of ModeloValoresEnCartera))(Peticiones.VALORES_EN_CARTERA_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloValoresEnCartera) As Task Implements ITransaccionesGenericas(Of ModeloValoresEnCartera).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.VALORES_EN_CARTERA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloValoresEnCartera) As Task Implements ITransaccionesGenericas(Of ModeloValoresEnCartera).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.VALORES_EN_CARTERA_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloValoresEnCartera).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.VALORES_EN_CARTERA_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verSaldoPesos() As Task(Of Double) Implements ITransaccionesValoresEnCartera.verSaldoPesos
        Dim result As Double = Await HttpGET(Of Double)(Peticiones.VALORES_EN_CARTERA_SALDO_PESOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verSaldoDolares() As Task(Of Double) Implements ITransaccionesValoresEnCartera.verSaldoDolares
        Dim result As Double = Await HttpGET(Of Double)(Peticiones.VALORES_EN_CARTERA_SALDO_DOLARES)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
