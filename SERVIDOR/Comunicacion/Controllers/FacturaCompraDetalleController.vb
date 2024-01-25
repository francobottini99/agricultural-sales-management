Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class FacturaCompraDetalleController
        Inherits Controller

        Private FacturaCompraDetalle As ModeloFacturaCompraDetalle
        Private Servicio As ServicioFacturaCompraDetalle

        <HttpGet>
        <Route("FacturaCompraDetalle/ListadoSinRemitarProveedor")>
        Public Function ListadoSinRemitarProveedor(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = New ServicioFacturaCompraDetalle(New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.AscProveedores = New ModeloProveedores With {.IdProveedor = JsonConvert.DeserializeObject(Of Integer)(Json)}}})

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.ListadoSinRemitar_Proveedor()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaCompraDetalle))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("FacturaCompraDetalle/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompraDetalle = JsonConvert.DeserializeObject(Of ModeloFacturaCompraDetalle)(ObtenerDatosEntrantes(Request))

                If FacturaCompraDetalle.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaCompraDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaCompraDetalle/Eliminar_idFacturaCompra/{Json}")>
        Public Function Eliminar_idFacturaCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompraDetalle = New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If FacturaCompraDetalle.EliminarPorIdFacturaCompra() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaCompraDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaCompraDetalle/Filtrar_idFacturaCompra/{Json}")>
        Public Function Filtrar_idFacturaCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompraDetalle = New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloFacturaCompraDetalle) = FacturaCompraDetalle.ListadoPorIdFacturaCompra()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaCompraDetalle))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaCompraDetalle))(Nothing, FacturaCompraDetalle.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace