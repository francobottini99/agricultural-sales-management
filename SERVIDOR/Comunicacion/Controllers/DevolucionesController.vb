Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class DevolucionesController
        Inherits Controller

        Private Devoluciones As ModeloDevoluciones
        Private Servicio As ServicioDevoluciones

        <HttpPost>
        <Route("Devoluciones/ServicioInsertar")>
        Public Function ServicioInsertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Try
                    Servicio = JsonConvert.DeserializeObject(Of ServicioDevoluciones)(ObtenerDatosEntrantes(Request))

                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.Insertar()))
                Catch ex As Exception
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message & ex.StackTrace})))
                End Try
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace