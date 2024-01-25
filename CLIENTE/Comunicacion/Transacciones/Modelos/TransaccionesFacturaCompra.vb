Public Class TransaccionesFacturaCompra
    Inherits Transacciones
    Implements ITransaccionesFacturaCompra

    Public Async Function insRegistro(param As ModeloFacturaCompra) As Task Implements ITransaccionesGenericas(Of ModeloFacturaCompra).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloFacturaCompra) As Task Implements ITransaccionesGenericas(Of ModeloFacturaCompra).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloFacturaCompra).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoId() As Task(Of Integer) Implements ITransaccionesFacturaCompra.verUltimoId
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.FACTURA_DE_COMPRA_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloFacturaCompra)) Implements ITransaccionesGenericas(Of ModeloFacturaCompra).verRegistros
        Dim result As List(Of ModeloFacturaCompra) = Await HttpGET(Of List(Of ModeloFacturaCompra))(Peticiones.FACTURA_DE_COMPRA_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_elimRegistro(param As ServicioFacturaCompra) As Task Implements ITransaccionesFacturaCompra.Servicio_elimRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_SERVCIO_ELIMINAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ServicioFacturaCompra) As Task Implements ITransaccionesFacturaCompra.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_SERVCIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ServicioFacturaCompra) As Task Implements ITransaccionesFacturaCompra.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_SERVCIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
