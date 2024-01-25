Public Class TransaccionesEmpresa
    Inherits Transacciones
    Implements ITransaccionesEmpresa

    Public Async Function insRegistro(param As ModeloEmpresa) As Task Implements ITransaccionesGenericas(Of ModeloEmpresa).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.EMPRESA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloEmpresa) As Task Implements ITransaccionesGenericas(Of ModeloEmpresa).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.EMPRESA_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloEmpresa).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.EMPRESA_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistro() As Task(Of ModeloEmpresa) Implements ITransaccionesEmpresa.verRegistro
        Dim result As ModeloEmpresa = Await HttpGET(Of ModeloEmpresa)(Peticiones.EMPRESA_CONSULTAR)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloEmpresa)) Implements ITransaccionesGenericas(Of ModeloEmpresa).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
