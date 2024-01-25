Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class ParidadCambiariaController
        Inherits Controller

        Private ParidadCambiaria As ModeloParidadCambiaria

        <HttpGet>
        <Route("ParidadCambiaria/Filtrar_idMoneda/{Json}")>
        Public Function Filtrar_idMoneda(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                ParidadCambiaria = New ModeloParidadCambiaria With {.AscMonedas = New ModeloMonedas With {.IdMonedas = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloParidadCambiaria) = ParidadCambiaria.ListadoPorIdMonedas()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloParidadCambiaria))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloParidadCambiaria))(Nothing, ParidadCambiaria.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

    End Class
End Namespace