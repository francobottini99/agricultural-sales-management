Public Class TransaccionesArticulos
    Inherits Transacciones
    Implements ITransaccionesArticulos

    Public Async Function modCostoRegistro(id As Integer, cost As Double, fec As Date) As Task Implements ITransaccionesArticulos.modCostoRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ARTICULOS_ACTUALIZAR_COSTO, New ModeloArticulos With {
                                                                .IdArticulo = id,
                                                                .Costo = cost,
                                                                .FechaActCosto = fec
                                                           })

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modPrecioRegistro(id As Integer, precio As Double, fec As Date) As Task Implements ITransaccionesArticulos.modPrecioRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ARTICULOS_ACTUALIZAR_PRECIO, New ModeloArticulos With {
                                                                .IdArticulo = id,
                                                                .Precio = precio,
                                                                .FechaActPrec = fec
                                                           })

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloArticulos) As Task Implements ITransaccionesGenericas(Of ModeloArticulos).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ARTICULOS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloArticulos) As Task Implements ITransaccionesGenericas(Of ModeloArticulos).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ARTICULOS_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloArticulos).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.ARTICULOS_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosSinImagenes() As Task(Of List(Of ModeloArticulos)) Implements ITransaccionesArticulos.verRegistrosSinImagenes
        Dim result As List(Of ModeloArticulos) = Await HttpGET(Of List(Of ModeloArticulos))(Peticiones.ARTICULOS_TODOS_SIN_IMAGENES)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verImagenPorId(id As Integer) As Task(Of String) Implements ITransaccionesArticulos.verImagenPorId
        Dim result As String = Await HttpGET(Of String)(Peticiones.ARTICULOS_CONSULTAR_IMAGEN, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistroPorId(id As Integer) As Task(Of ModeloArticulos) Implements ITransaccionesArticulos.verRegistroPorId
        Dim result As ModeloArticulos = Await HttpGET(Of ModeloArticulos)(Peticiones.ARTICULOS_FILTRAR_ID, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoId() As Task(Of Integer) Implements ITransaccionesArticulos.verUltimoId
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.ARTICULOS_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloArticulos)) Implements ITransaccionesGenericas(Of ModeloArticulos).verRegistros
        Dim result As List(Of ModeloArticulos) = Await HttpGET(Of List(Of ModeloArticulos))(Peticiones.ARTICULOS_TODOS_SIN_IMAGENES)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloArticulos) As Task Implements ITransaccionesArticulos.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ARTICULOS_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloArticulos) As Task Implements ITransaccionesArticulos.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ARTICULOS_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

End Class
