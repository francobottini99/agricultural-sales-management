Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class RemitosCompraMovimientosController
        Inherits Controller

        Private RemMov As ModeloRemitosCompraMovimientos

        <HttpGet>
        <Route("RemitosCompraMovimientos/Filtrar_idRemitosCompra/{Json}")>
        Public Function Filtrar_idRemitosCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                RemMov = New ModeloRemitosCompraMovimientos With {.AscDetalleRemtioCompra = New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}}

                Dim lista As List(Of ModeloRemitosCompraMovimientos) = RemMov.ListasdoPorIdRemitosCompra()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloRemitosCompraMovimientos))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloRemitosCompraMovimientos))(Nothing, RemMov.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloRemitosCompraMovimientos)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace