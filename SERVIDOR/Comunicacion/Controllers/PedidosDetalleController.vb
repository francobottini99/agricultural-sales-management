Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class PedidosDetalleController
        Inherits Controller

        Private PedidoDetalle As ModeloPedidoDetalle
        Private Servicio As ServicioPedidosDetalle

        <HttpPost>
        <Route("PedidosDetalle/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoDetalle = JsonConvert.DeserializeObject(Of ModeloPedidoDetalle)(ObtenerDatosEntrantes(Request))

                If PedidoDetalle.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, PedidoDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("PedidosDetalle/Modificar")>
        Public Function Modificar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoDetalle = JsonConvert.DeserializeObject(Of ModeloPedidoDetalle)(ObtenerDatosEntrantes(Request))

                If PedidoDetalle.Modificar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, PedidoDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosDetalle/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoDetalle = New ModeloPedidoDetalle With {.AscPedidos = New ModeloPedidos With {.IdPedidos = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If PedidoDetalle.EliminarPorIdPedido() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, PedidoDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosDetalle/Todos")>
        Public Function Todos() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoDetalle = New ModeloPedidoDetalle()

                Dim lista As List(Of ModeloPedidoDetalle) = PedidoDetalle.ListadoCompleto()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, PedidoDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosDetalle/Filtrar_idPedidos/{Json}")>
        Public Function Filtrar_idPedidos(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoDetalle = New ModeloPedidoDetalle With {.AscPedidos = New ModeloPedidos With {.IdPedidos = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloPedidoDetalle) = PedidoDetalle.ListadoPorIdPedidos()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, PedidoDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosDetalle/Filtrar_idPedidosDetalle/{Json}")>
        Public Function Filtrar_idPedidosDetalle(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = JsonConvert.DeserializeObject(Of Integer)(Json)}

                Dim registro As ModeloPedidoDetalle = PedidoDetalle.ConsultarPorId()

                If Not IsNothing(registro) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloPedidoDetalle)(registro, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloPedidoDetalle)(Nothing, PedidoDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosDetalle/ListadoSinRemitarCliente")>
        Public Function ListadoSinRemitarCliente(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = New ServicioPedidosDetalle(New ModeloPedidoDetalle With {.AscPedidos = New ModeloPedidos With {.AscClientes = New ModeloCliente With {.IdCliente = JsonConvert.DeserializeObject(Of Integer)(Json)}}})

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.ListadoSinRemitar_Cliente()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosDetalle/ListadoSinFacturarCliente")>
        Public Function ListadoSinFacturarCliente(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = New ServicioPedidosDetalle(New ModeloPedidoDetalle With {.AscPedidos = New ModeloPedidos With {.AscClientes = New ModeloCliente With {.IdCliente = JsonConvert.DeserializeObject(Of Integer)(Json)}}})

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.ListadoSinFacturar_Cliente()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("PedidosDetalle/Filtrar_idCliente/{Json}")>
        Public Function Filtrar_idCliente(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoDetalle = New ModeloPedidoDetalle With {.AscPedidos = New ModeloPedidos With {.AscClientes = New ModeloCliente With {.IdCliente = JsonConvert.DeserializeObject(Of Integer)(Json)}}}

                Dim lista As List(Of ModeloPedidoDetalle) = PedidoDetalle.ListadoPorIdCliente()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, PedidoDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("PedidosDetalle/Filtrar_idCliente_Remitado")>
        Public Function Filtrar_idCliente_Remitado() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoDetalle = JsonConvert.DeserializeObject(Of ModeloPedidoDetalle)(ObtenerDatosEntrantes(Request))

                Dim lista As List(Of ModeloPedidoDetalle) = PedidoDetalle.ListadoFiltradoPorIdClienteYRemitado()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, PedidoDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("PedidosDetalle/Filtrar_idCliente_Facturado")>
        Public Function Filtrar_idCliente_Facturado() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                PedidoDetalle = JsonConvert.DeserializeObject(Of ModeloPedidoDetalle)(ObtenerDatosEntrantes(Request))

                Dim lista As List(Of ModeloPedidoDetalle) = PedidoDetalle.ListadoFiltradoPorIdClienteYFacturado()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, PedidoDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace