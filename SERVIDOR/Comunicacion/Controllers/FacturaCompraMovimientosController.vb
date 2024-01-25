Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class FacturaCompraMovimientosController
        Inherits Controller

        Private FacMov As ModeloFacturaCompraMovimientos

        <HttpGet>
        <Route("FacturaCompraMovimientos/Filtrar_idFacturaCompra/{Json}")>
        Public Function Filtrar_idFacturaCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacMov = New ModeloFacturaCompraMovimientos With {.AscFacturaCompraDetalle = New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}}

                Dim lista As List(Of ModeloFacturaCompraMovimientos) = FacMov.ListasdoPorIdFacturaCompra()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaCompraMovimientos))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaCompraMovimientos))(Nothing, FacMov.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloFacturaCompraMovimientos)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace