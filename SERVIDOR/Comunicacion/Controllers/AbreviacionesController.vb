Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class AbreviacionesController
        Inherits Controller

        <HttpGet>
        <Route("Abreviaciones/Existe/{Json}")>
        Public Function Existe(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New ServicioAbrebiaciones(JsonConvert.DeserializeObject(Of String)(Json)).ExisteAbrebiatura()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of String)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace