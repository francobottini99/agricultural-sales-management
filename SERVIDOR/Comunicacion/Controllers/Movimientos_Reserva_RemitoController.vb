Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class Movimientos_Reserva_RemitoController
        Inherits Controller

        Private MovResRem As ModeloMovimientos_Reserva_Remito

        <HttpGet>
        <Route("Movimientos_Reserva_Remito/Filtrar_idRemitosVenta/{Json}")>
        Public Function Filtrar_idRemitosVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                MovResRem = New ModeloMovimientos_Reserva_Remito With {.AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}}}

                Dim lista As List(Of ModeloMovimientos_Reserva_Remito) = MovResRem.ListasdoPorIdRemitosVenta()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMovimientos_Reserva_Remito))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMovimientos_Reserva_Remito))(Nothing, MovResRem.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloMovimientos_Reserva_Remito)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace