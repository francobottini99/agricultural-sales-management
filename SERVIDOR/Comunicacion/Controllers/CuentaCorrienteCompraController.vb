Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class CuentaCorrienteCompraController
        Inherits Controller

        Private CuentaCorrienteCompra As ModeloCuentaCorrienteCompra

        <HttpGet>
        <Route("CuentaCorrienteCompra/Filtrar_idProveedor/{Json}")>
        Public Function Filtrar_idProveedor(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                CuentaCorrienteCompra = New ModeloCuentaCorrienteCompra With {.AscProveedores = New ModeloProveedores With {.IdProveedor = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloCuentaCorrienteCompra) = CuentaCorrienteCompra.ListasdoPorIdProveedor()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloCuentaCorrienteCompra))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloCuentaCorrienteCompra))(Nothing, CuentaCorrienteCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("CuentaCorrienteCompra/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                CuentaCorrienteCompra = JsonConvert.DeserializeObject(Of ModeloCuentaCorrienteCompra)(ObtenerDatosEntrantes(Request))

                If CuentaCorrienteCompra.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, CuentaCorrienteCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("CuentaCorrienteCompra/UltimoID")>
        Public Function UltimoID() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                CuentaCorrienteCompra = New ModeloCuentaCorrienteCompra()

                Dim ultId As Integer = CuentaCorrienteCompra.UltimoId()

                If Not IsNothing(ultId) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(ultId, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, CuentaCorrienteCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("CuentaCorrienteCompra/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                CuentaCorrienteCompra = New ModeloCuentaCorrienteCompra With {.IdCuentaCorrienteCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}

                If CuentaCorrienteCompra.Eliminar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, CuentaCorrienteCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace