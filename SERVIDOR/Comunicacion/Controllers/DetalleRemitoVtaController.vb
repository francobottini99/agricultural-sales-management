Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class DetalleRemitoVtaController
        Inherits Controller

        Private DetalleRemitoVenta As ModeloDetalleRemitoVenta
        Private Servicio As ServicioDetalleRemitoVenta

        <HttpPost>
        <Route("DetalleRemitoVta/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoVenta = JsonConvert.DeserializeObject(Of ModeloDetalleRemitoVenta)(ObtenerDatosEntrantes(Request))

                If DetalleRemitoVenta.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, DetalleRemitoVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitoVta/Filtrar_idRemitosVenta/{Json}")>
        Public Function Filtrar_idRemitosVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloDetalleRemitoVenta) = DetalleRemitoVenta.ListasdoPorIdRemitosVenta()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(Nothing, DetalleRemitoVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitoVta/Eliminar_idRemitosVenta/{Json}")>
        Public Function Eliminar_idRemitosVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If DetalleRemitoVenta.EliminarPorIdRemitosVenta() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, DetalleRemitoVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitoVta/Eliminar_idArticulo_idRemitosVenta/{Json}")>
        Public Function Eliminar_idArticulo_idRemitosVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Dim ID() As Integer = JsonConvert.DeserializeObject(Of Integer())(Json)

                DetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = ID(0)},
                                                                    .AscArticulos = New ModeloArticulos With {.IdArticulo = ID(1)}}

                If DetalleRemitoVenta.EliminarPorIdRemitosVentaYIdArticulo() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, DetalleRemitoVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitoVta/UltimoID")>
        Public Function UltimoID() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoVenta = New ModeloDetalleRemitoVenta()

                Dim ultId As Integer = DetalleRemitoVenta.UltimoId()

                If Not IsNothing(ultId) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(ultId, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, DetalleRemitoVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("DetalleRemitoVta/Facturacion")>
        Public Function Facturacion() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoVenta = JsonConvert.DeserializeObject(Of ModeloDetalleRemitoVenta)(ObtenerDatosEntrantes(Request))

                If DetalleRemitoVenta.ModificarFacturacion() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, DetalleRemitoVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitoVta/Filtrar_idDetalleRemitosVenta/{Json}")>
        Public Function Filtrar_idDetalleRemitosVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.IdDetalleRemitosVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}

                Dim registro As ModeloDetalleRemitoVenta = DetalleRemitoVenta.ConsultarPorId()

                If Not IsNothing(registro) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloDetalleRemitoVenta)(registro, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloDetalleRemitoVenta)(Nothing, DetalleRemitoVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitoVta/Filtrar_idCliente/{Json}")>
        Public Function Filtrar_idCliente(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.AscClientes = New ModeloCliente With {.IdCliente = JsonConvert.DeserializeObject(Of Integer)(Json)}}}

                Dim lista As List(Of ModeloDetalleRemitoVenta) = DetalleRemitoVenta.ListadoFiltradoPorIdCliente()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(Nothing, DetalleRemitoVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloDetalleRemitoVenta)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("DetalleRemitoVta/Filtrar_idCliente_Facturado")>
        Public Function Filtrar_idCliente_Facturado() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoVenta = JsonConvert.DeserializeObject(Of ModeloDetalleRemitoVenta)(ObtenerDatosEntrantes(Request))

                Dim lista As List(Of ModeloDetalleRemitoVenta) = DetalleRemitoVenta.ListadoFiltradoPorIdClienteYFacturado()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(Nothing, DetalleRemitoVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitoVta/ListadoSinFacturarCliente")>
        Public Function ListadoSinFacturarCliente(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = New ServicioDetalleRemitoVenta(New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.AscClientes = New ModeloCliente With {.IdCliente = JsonConvert.DeserializeObject(Of Integer)(Json)}}})

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.ListadoSinFacturar_Cliente()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace