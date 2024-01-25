Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class FacturaComMonedasController
        Inherits Controller

        Private FacturaCompraMonedas As ModeloFacturaComMonedas

        <HttpPost>
        <Route("FacturaComMonedas/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompraMonedas = JsonConvert.DeserializeObject(Of ModeloFacturaComMonedas)(ObtenerDatosEntrantes(Request))

                If FacturaCompraMonedas.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaCompraMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaComMonedas/Eliminar_idFacturaCompra/{Json}")>
        Public Function Eliminar_idFacturaCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompraMonedas = New ModeloFacturaComMonedas With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If FacturaCompraMonedas.EliminarPorIdFacturaCompra() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaCompraMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaComMonedas/Filtrar_idFacturaCompra/{Json}")>
        Public Function Filtrar_idFacturaCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompraMonedas = New ModeloFacturaComMonedas With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim registro As ModeloFacturaComMonedas = FacturaCompraMonedas.ConsultarPorIdFacturaCompra()

                If Not IsNothing(registro) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloFacturaComMonedas)(registro, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloFacturaComMonedas)(Nothing, FacturaCompraMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace