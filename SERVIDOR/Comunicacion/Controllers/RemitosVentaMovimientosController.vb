Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class RemitosVentaMovimientosController
        Inherits Controller

        Private RemMov As ModeloRemitosVentaMovimientos

        <HttpGet>
        <Route("RemitosVentaMovimientos/Filtrar_idRemitosVenta/{Json}")>
        Public Function Filtrar_idRemitosVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                RemMov = New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}}

                Dim lista As List(Of ModeloRemitosVentaMovimientos) = RemMov.ListasdoPorIdRemitosVenta()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloRemitosVentaMovimientos))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloRemitosVentaMovimientos))(Nothing, RemMov.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloRemitosVentaMovimientos)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace