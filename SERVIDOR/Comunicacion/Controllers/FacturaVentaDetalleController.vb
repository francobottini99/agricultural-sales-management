Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class FacturaVentaDetalleController
        Inherits Controller

        Private FacturaVentaDetalle As ModeloFacturaVentaDetalle
        Private Servicio As ServicioFacturaVentaDetalle

        <HttpGet>
        <Route("FacturaVentaDetalle/Filtrar_idCliente/{Json}")>
        Public Function Filtrar_idCliente(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVentaDetalle = New ModeloFacturaVentaDetalle With {.AscFacturaVenta = New ModeloFacturaVenta With {.AscClientes = New ModeloCliente With {.IdCliente = JsonConvert.DeserializeObject(Of Integer)(Json)}}}

                Dim lista As List(Of ModeloFacturaVentaDetalle) = FacturaVentaDetalle.ListadoFiltradoPorIdCliente()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(Nothing, FacturaVentaDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloFacturaVentaDetalle)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("FacturaVentaDetalle/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVentaDetalle = JsonConvert.DeserializeObject(Of ModeloFacturaVentaDetalle)(ObtenerDatosEntrantes(Request))

                If FacturaVentaDetalle.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaVentaDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVentaDetalle/Eliminar_idFacturaVenta/{Json}")>
        Public Function Eliminar_idFacturaVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVentaDetalle = New ModeloFacturaVentaDetalle With {.AscFacturaVenta = New ModeloFacturaVenta With {.IdFacturaVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If FacturaVentaDetalle.EliminarPorIdFacturaVenta() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaVentaDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVentaDetalle/Filtrar_idFacturaVenta/{Json}")>
        Public Function Filtrar_idFacturaVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVentaDetalle = New ModeloFacturaVentaDetalle With {.AscFacturaVenta = New ModeloFacturaVenta With {.IdFacturaVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloFacturaVentaDetalle) = FacturaVentaDetalle.ListadoPorIdFacturaVenta()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(Nothing, FacturaVentaDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVentaDetalle/ListadoSinRemitarCliente")>
        Public Function ListadoSinRemitarCliente(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = New ServicioFacturaVentaDetalle(New ModeloFacturaVentaDetalle With {.AscFacturaVenta = New ModeloFacturaVenta With {.AscClientes = New ModeloCliente With {.IdCliente = JsonConvert.DeserializeObject(Of Integer)(Json)}}})

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.ListadoSinRemitar_Cliente()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVentaDetalle/ListadoRemitadoCliente")>
        Public Function ListadoRemitadoCliente(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = New ServicioFacturaVentaDetalle(New ModeloFacturaVentaDetalle With {.AscFacturaVenta = New ModeloFacturaVenta With {.AscClientes = New ModeloCliente With {.IdCliente = JsonConvert.DeserializeObject(Of Integer)(Json)}}})

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.ListadoRemitado_Cliente()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace