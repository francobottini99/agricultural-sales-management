Public Class TransaccionesParidadCambiaria
    Inherits Transacciones
    Implements ITransaccionesParidadCambiaria

    Public Async Function insRegistro(param As ModeloParidadCambiaria) As Task Implements ITransaccionesGenericas(Of ModeloParidadCambiaria).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PARIDAD_CAMBIARIA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloParidadCambiaria) As Task Implements ITransaccionesGenericas(Of ModeloParidadCambiaria).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloParidadCambiaria).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistrosPorIdMonedas(id As Integer) As Task(Of List(Of ModeloParidadCambiaria)) Implements ITransaccionesParidadCambiaria.verRegistrosPorIdMonedas
        Dim result As List(Of ModeloParidadCambiaria) = Await HttpGET(Of List(Of ModeloParidadCambiaria))(Peticiones.PARIDAD_CAMBIARIA_FILTRAR_POR_ID_MONEDA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloParidadCambiaria)) Implements ITransaccionesGenericas(Of ModeloParidadCambiaria).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
