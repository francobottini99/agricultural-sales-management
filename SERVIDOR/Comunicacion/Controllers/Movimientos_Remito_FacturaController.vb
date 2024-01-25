Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class Movimientos_Remito_FacturaController
        Inherits Controller

        Private MovRemFac As ModeloMovimientos_Remito_Factura

        <HttpGet>
        <Route("Movimientos_Remito_Factura/Filtrar_idRemitosVenta/{Json}")>
        Public Function Filtrar_idRemitosVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                MovRemFac = New ModeloMovimientos_Remito_Factura With {.AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}}}

                Dim lista As List(Of ModeloMovimientos_Remito_Factura) = MovRemFac.ListasdoPorIdRemitosVenta()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMovimientos_Remito_Factura))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMovimientos_Remito_Factura))(Nothing, MovRemFac.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloMovimientos_Remito_Factura)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace