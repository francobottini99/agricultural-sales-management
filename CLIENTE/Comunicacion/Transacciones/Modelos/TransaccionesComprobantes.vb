Public Class TransaccionesComprobantes
    Inherits Transacciones
    Implements ITransaccionesComprobantes

    Public Async Function insRegistro(param As ModeloComprobantes) As Task Implements ITransaccionesGenericas(Of ModeloComprobantes).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.COMPROBANTES_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloComprobantes) As Task Implements ITransaccionesGenericas(Of ModeloComprobantes).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.COMPROBANTES_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloComprobantes).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.COMPROBANTES_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloComprobantes)) Implements ITransaccionesGenericas(Of ModeloComprobantes).verRegistros
        Dim result As List(Of ModeloComprobantes) = Await HttpGET(Of List(Of ModeloComprobantes))(Peticiones.COMPROBANTES_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
