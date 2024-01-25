Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class DatosSistemaController
        Inherits Controller

        Private DatosSistema As ModeloDatosSistema

        <HttpGet>
        <Route("DatosSistema/Consultar")>
        Public Function Consultar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                DatosSistema = New ModeloDatosSistema()

                Dim registro As ModeloDatosSistema = DatosSistema.Consultar()

                If Not IsNothing(registro) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloDatosSistema)(registro, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloDatosSistema)(Nothing, DatosSistema.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace