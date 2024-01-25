Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class CuentaCorrienteVentaController
        Inherits Controller

        Private CuentaCorrienteVenta As ModeloCuentaCorrienteVenta

        <HttpGet>
        <Route("CuentaCorrienteVenta/Filtrar_idCliente/{Json}")>
        Public Function Filtrar_idCliente(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                CuentaCorrienteVenta = New ModeloCuentaCorrienteVenta With {.AscClientes = New ModeloCliente With {.IdCliente = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloCuentaCorrienteVenta) = CuentaCorrienteVenta.ListasdoPorIdCliente()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloCuentaCorrienteVenta))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloCuentaCorrienteVenta))(Nothing, CuentaCorrienteVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("CuentaCorrienteVenta/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                CuentaCorrienteVenta = JsonConvert.DeserializeObject(Of ModeloCuentaCorrienteVenta)(ObtenerDatosEntrantes(Request))

                If CuentaCorrienteVenta.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, CuentaCorrienteVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("CuentaCorrienteVenta/UltimoID")>
        Public Function UltimoID() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                CuentaCorrienteVenta = New ModeloCuentaCorrienteVenta()

                Dim ultId As Integer = CuentaCorrienteVenta.UltimoId()

                If Not IsNothing(ultId) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(ultId, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, CuentaCorrienteVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("CuentaCorrienteVenta/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                CuentaCorrienteVenta = New ModeloCuentaCorrienteVenta With {.IdCuentaCorrienteVentas = JsonConvert.DeserializeObject(Of Integer)(Json)}

                If CuentaCorrienteVenta.Eliminar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, CuentaCorrienteVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

    End Class
End Namespace