Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class PedidosMovimientosController
        Inherits Controller

        Private PedidoMovimiento As ModeloPedidoMovimientos

        <HttpPost>
        <Route("PedidosMovimientos/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoMovimiento = JsonConvert.DeserializeObject(Of ModeloPedidoMovimientos)(ObtenerDatosEntrantes(Request))

                If PedidoMovimiento.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, PedidoMovimiento.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("PedidosMovimientos/Modificar")>
        Public Function Modificar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoMovimiento = JsonConvert.DeserializeObject(Of ModeloPedidoMovimientos)(ObtenerDatosEntrantes(Request))

                If PedidoMovimiento.Modificar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, PedidoMovimiento.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosMovimientos/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoMovimiento = New ModeloPedidoMovimientos With {.IdPedidosMovimientos = JsonConvert.DeserializeObject(Of Integer)(Json)}

                If PedidoMovimiento.Eliminar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, PedidoMovimiento.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosMovimientos/Eliminar_Movimiento_Cantidad_idPedidosDetalle/{Json}")>
        Public Function Eliminar_Movimiento_Cantidad_idPedidosDetalle(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoMovimiento = JsonConvert.DeserializeObject(Of ModeloPedidoMovimientos)(Json)

                If PedidoMovimiento.EliminarPorCampos() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, PedidoMovimiento.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosDetalle/Filtrar_idPedidosDetalle/{Json}")>
        Public Function Filtrar_idPedidosDetalle(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoMovimiento = New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloPedidoMovimientos) = PedidoMovimiento.ListadoPorIdPedidosDetalle()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoMovimientos))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoMovimientos))(Nothing, PedidoMovimiento.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosMovimientos/Eliminar_idPedidosDetalle/{Json}")>
        Public Function Eliminar_idPedidosDetalle(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoMovimiento = New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If PedidoMovimiento.EliminarPorIdPedidosDetalle() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, PedidoMovimiento.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace