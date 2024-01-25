Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class RemitoVtaMonedasController
        Inherits Controller

        Private RemitoVentaMonedas As ModeloRemitosVentaMonedas

        <HttpGet>
        <Route("RemitoVtaMonedas/Todos")>
        Public Function Todos() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                RemitoVentaMonedas = New ModeloRemitosVentaMonedas()

                Dim lista As List(Of ModeloRemitosVentaMonedas) = RemitoVentaMonedas.ListadoCompleto()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloRemitosVentaMonedas))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloRemitosVentaMonedas))(Nothing, RemitoVentaMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloRemitosVentaMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <Route("RemitoVtaMonedas/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                RemitoVentaMonedas = JsonConvert.DeserializeObject(Of ModeloRemitosVentaMonedas)(ObtenerDatosEntrantes(Request))

                If RemitoVentaMonedas.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, RemitoVentaMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("RemitoVtaMonedas/Eliminar_idRemitosVenta/{Json}")>
        Public Function Eliminar_idRemitosVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                RemitoVentaMonedas = New ModeloRemitosVentaMonedas With {.AscRemitosventa = New ModeloRemitosVenta With {.IdRemitosVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If RemitoVentaMonedas.EliminarPorIdRemitosVenta() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, RemitoVentaMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("RemitoVtaMonedas/Filtrar_idRemitosVenta/{Json}")>
        Public Function Filtrar_idRemitosVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                RemitoVentaMonedas = New ModeloRemitosVentaMonedas With {.AscRemitosventa = New ModeloRemitosVenta With {.IdRemitosVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim registro As ModeloRemitosVentaMonedas = RemitoVentaMonedas.ConsultarPorIdRemitosVenta()

                If Not IsNothing(registro) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloRemitosVentaMonedas)(registro, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloRemitosVentaMonedas)(Nothing, RemitoVentaMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloRemitosVentaMonedas)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace