Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class OrdenDePagoMonedasController
        Inherits Controller

        Private OrdenDePagoMonedas As ModeloOrdenDePagoMonedas

        <HttpGet>
        <Route("OrdenDePagoMonedas/Todos")>
        Public Function Todos() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                OrdenDePagoMonedas = New ModeloOrdenDePagoMonedas()

                Dim lista As List(Of ModeloOrdenDePagoMonedas) = OrdenDePagoMonedas.ListadoCompleto()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloOrdenDePagoMonedas))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloOrdenDePagoMonedas))(Nothing, OrdenDePagoMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloOrdenDePagoMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("OrdenDePagoMonedas/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                OrdenDePagoMonedas = JsonConvert.DeserializeObject(Of ModeloOrdenDePagoMonedas)(ObtenerDatosEntrantes(Request))

                If OrdenDePagoMonedas.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, OrdenDePagoMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function


        <HttpGet>
        <Route("OrdenDePagoMonedas/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                OrdenDePagoMonedas = New ModeloOrdenDePagoMonedas With {.IdOrdenDePagoMonedas = JsonConvert.DeserializeObject(Of Integer)(Json)}

                If OrdenDePagoMonedas.Eliminar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, OrdenDePagoMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("OrdenDePagoMonedas/Modificar")>
        Public Function Modificar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                OrdenDePagoMonedas = JsonConvert.DeserializeObject(Of ModeloOrdenDePagoMonedas)(ObtenerDatosEntrantes(Request))

                If OrdenDePagoMonedas.Modificar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, OrdenDePagoMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("OrdenDePagoMonedas/Eliminar_idOrdenDePago/{Json}")>
        Public Function Eliminar_idOrdenDePago(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                OrdenDePagoMonedas = New ModeloOrdenDePagoMonedas With {.AscOrdenDePago = New ModeloOrdenDePago With {.IdOrdenDePago = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If OrdenDePagoMonedas.EliminarPorIdOrdenDePago() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, OrdenDePagoMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("OrdenDePagoMonedas/Filtrar_idOrdenDePago/{Json}")>
        Public Function Filtrar_idOrdenDePago(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                OrdenDePagoMonedas = New ModeloOrdenDePagoMonedas With {.AscOrdenDePago = New ModeloOrdenDePago With {.IdOrdenDePago = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloOrdenDePagoMonedas) = OrdenDePagoMonedas.ConsultarPorIdOrdenDePago()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloOrdenDePagoMonedas))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloOrdenDePagoMonedas))(Nothing, OrdenDePagoMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloOrdenDePagoMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace