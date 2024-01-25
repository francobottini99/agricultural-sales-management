Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class FacturaVtaMonedasController
        Inherits Controller

        Private FacturaVentaMonedas As ModeloFacturaVentaMonedas

        <HttpGet>
        <Route("FacturaVtaMonedas/Todos")>
        Public Function Todos() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVentaMonedas = New ModeloFacturaVentaMonedas()

                Dim lista As List(Of ModeloFacturaVentaMonedas) = FacturaVentaMonedas.ListadoCompleto()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVentaMonedas))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVentaMonedas))(Nothing, FacturaVentaMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVentaMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("FacturaVtaMonedas/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVentaMonedas = JsonConvert.DeserializeObject(Of ModeloFacturaVentaMonedas)(ObtenerDatosEntrantes(Request))

                If FacturaVentaMonedas.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaVentaMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVtaMonedas/Eliminar_idFacturaVenta/{Json}")>
        Public Function Eliminar_idFacturaVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVentaMonedas = New ModeloFacturaVentaMonedas With {.AscFacturaVenta = New ModeloFacturaVenta With {.IdFacturaVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                If FacturaVentaMonedas.EliminarPorIdFacturaVenta() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaVentaMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVtaMonedas/Filtrar_idFacturaVenta/{Json}")>
        Public Function Filtrar_idFacturaVenta(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVentaMonedas = New ModeloFacturaVentaMonedas With {.AscFacturaVenta = New ModeloFacturaVenta With {.IdFacturaVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim registro As ModeloFacturaVentaMonedas = FacturaVentaMonedas.ConsultarPorIdFacturaVenta()

                If Not IsNothing(registro) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloFacturaVentaMonedas)(registro, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloFacturaVentaMonedas)(Nothing, FacturaVentaMonedas.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace