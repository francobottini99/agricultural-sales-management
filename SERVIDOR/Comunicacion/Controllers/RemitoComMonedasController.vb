Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class RemitoComMonedasController
        Inherits Controller

        Private RemitoCompraMoneda As ModeloRemitoComMonedas

        <HttpPost>
        <Route("RemitoComMonedas/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                RemitoCompraMoneda = JsonConvert.DeserializeObject(Of ModeloRemitoComMonedas)(ObtenerDatosEntrantes(Request))

                If RemitoCompraMoneda.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, RemitoCompraMoneda.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("RemitoComMonedas/Eliminar_idRemitosCompra/{Json}")>
        Public Function Eliminar_idRemitosCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                RemitoCompraMoneda = New ModeloRemitoComMonedas With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If RemitoCompraMoneda.EliminarPorIdRemitosCompra() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, RemitoCompraMoneda.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("RemitoComMonedas/Filtrar_idRemitosCompra/{Json}")>
        Public Function Filtrar_idRemitosCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                RemitoCompraMoneda = New ModeloRemitoComMonedas With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim registro As ModeloRemitoComMonedas = RemitoCompraMoneda.ConsultarPorIdRemitosCompra()

                If Not IsNothing(registro) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloRemitoComMonedas)(registro, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloRemitoComMonedas)(Nothing, RemitoCompraMoneda.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace