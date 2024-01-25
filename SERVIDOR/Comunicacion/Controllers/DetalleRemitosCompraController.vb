Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class DetalleRemitosCompraController
        Inherits Controller

        Private DetalleRemitoCompra As ModeloDetalleRemitoCompra
        Private Servicio As ServicioDetalleRemitoCompra

        <HttpPost>
        <Route("DetalleRemitosCompra/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoCompra = JsonConvert.DeserializeObject(Of ModeloDetalleRemitoCompra)(ObtenerDatosEntrantes(Request))

                If DetalleRemitoCompra.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, DetalleRemitoCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitosCompra/Filtrar_idRemitosCompra/{Json}")>
        Public Function Filtrar_idRemitosCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoCompra = New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloDetalleRemitoCompra) = DetalleRemitoCompra.ListasdoPorIdRemitosCompra()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoCompra))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoCompra))(Nothing, DetalleRemitoCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitosCompra/Eliminar_idRemitosCompra/{Json}")>
        Public Function Eliminar_idRemitosCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoCompra = New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If DetalleRemitoCompra.EliminarPorIdRemitosCompra() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, DetalleRemitoCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitosCompra/Eliminar_idArticulo_idRemitosCompra/{Json}")>
        Public Function Eliminar_idArticulo_idRemitosCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Dim ID() As Integer = JsonConvert.DeserializeObject(Of Integer())(Json)

                DetalleRemitoCompra = New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = ID(0)},
                                                                          .AscArticulos = New ModeloArticulos With {.IdArticulo = ID(1)}}

                If DetalleRemitoCompra.EliminarPorIdRemitoCompraYIdArticulo() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, DetalleRemitoCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitosCompra/UltimoID")>
        Public Function UltimoID() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoCompra = New ModeloDetalleRemitoCompra()

                Dim ultId As Integer = DetalleRemitoCompra.UltimoId()

                If Not IsNothing(ultId) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(ultId, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, DetalleRemitoCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("DetalleRemitosCompra/Facturacion")>
        Public Function Facturacion() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoCompra = JsonConvert.DeserializeObject(Of ModeloDetalleRemitoCompra)(ObtenerDatosEntrantes(Request))

                If DetalleRemitoCompra.ModificarEstadoFacturacion() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, DetalleRemitoCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitosCompra/Cantidad")>
        Public Function Cantidad(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DetalleRemitoCompra = New ModeloDetalleRemitoCompra With {.IdDetalleRemitosCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}

                Dim cant As Double = DetalleRemitoCompra.ConsultarCantidad()

                If Not IsNothing(cant) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Double)(cant, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Double)(Nothing, DetalleRemitoCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("DetalleRemitosCompra/ListadoSinFacturarProveedor")>
        Public Function ListadoSinFacturarProveedor(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = New ServicioDetalleRemitoCompra(New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.AscProveedores = New ModeloProveedores With {.IdProveedor = JsonConvert.DeserializeObject(Of Integer)(Json)}}})

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.ListadoSinFacturar_Proveedor()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloDetalleRemitoCompra))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace