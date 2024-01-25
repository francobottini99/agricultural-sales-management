Public Class TransaccionesRegistroOperaciones
    Inherits Transacciones
    Implements ITransaccionesRegistroOperaciones

    Public Async Function insRegistro(param As ModeloRegistroOperaciones) As Task Implements ITransaccionesGenericas(Of ModeloRegistroOperaciones).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REGISTRO_OPERACIONES_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloRegistroOperaciones) As Task Implements ITransaccionesGenericas(Of ModeloRegistroOperaciones).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloRegistroOperaciones).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloRegistroOperaciones)) Implements ITransaccionesGenericas(Of ModeloRegistroOperaciones).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
