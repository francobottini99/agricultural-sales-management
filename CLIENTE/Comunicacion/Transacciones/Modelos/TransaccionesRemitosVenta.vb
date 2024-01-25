Public Class TransaccionesRemitosVenta
    Inherits Transacciones
    Implements ITransaccionesRemtiosVenta

    Public Async Function verUltimoId() As Task(Of Integer) Implements ITransaccionesRemtiosVenta.verUltimoId
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.REMITO_DE_VENTA_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verSinFacturar() As Task(Of List(Of ModeloRemitosVenta)) Implements ITransaccionesRemtiosVenta.verSinFacturar
        Dim result As List(Of ModeloRemitosVenta) = Await HttpGET(Of List(Of ModeloRemitosVenta))(Peticiones.REMITO_DE_VENTA_SIN_FACTURAR)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modEstadoFacturacion(id As Integer, estFact As String) As Task Implements ITransaccionesRemtiosVenta.modEstadoFacturacion
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_VENTA_FACTURACION, New ModeloRemitosVenta With {.IdRemitosVenta = id, .Facturado = estFact})

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloRemitosVenta)) Implements ITransaccionesGenericas(Of ModeloRemitosVenta).verRegistros
        Dim result As List(Of ModeloRemitosVenta) = Await HttpGET(Of List(Of ModeloRemitosVenta))(Peticiones.REMITO_DE_VENTA_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloRemitosVenta) As Task Implements ITransaccionesGenericas(Of ModeloRemitosVenta).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_VENTA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloRemitosVenta) As Task Implements ITransaccionesGenericas(Of ModeloRemitosVenta).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_VENTA_MODIFCIAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloRemitosVenta).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.REMITO_DE_VENTA_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ServicioRemitoVenta) As Task Implements ITransaccionesRemtiosVenta.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_VENTA_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ServicioRemitoVenta) As Task Implements ITransaccionesRemtiosVenta.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_VENTA_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_elimRegistro(param As ServicioRemitoVenta) As Task Implements ITransaccionesRemtiosVenta.Servicio_elimRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_VENTA_SERVICIO_ELIMINAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
