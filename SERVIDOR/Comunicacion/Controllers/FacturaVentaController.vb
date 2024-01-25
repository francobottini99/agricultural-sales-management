Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class FacturaVentaController
        Inherits Controller

        Private FacturaVenta As ModeloFacturaVenta
        Private Servicio As ServicioFacturaVenta

        <HttpPost>
        <Route("FacturaVenta/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVenta = JsonConvert.DeserializeObject(Of ModeloFacturaVenta)(ObtenerDatosEntrantes(Request))

                If FacturaVenta.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("FacturaVenta/Modificar")>
        Public Function Modificar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVenta = JsonConvert.DeserializeObject(Of ModeloFacturaVenta)(ObtenerDatosEntrantes(Request))

                If FacturaVenta.Modificar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVenta/UltimoID")>
        Public Function UltimoID() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVenta = New ModeloFacturaVenta()

                Dim ultId As Integer = FacturaVenta.UltimoId()

                If Not IsNothing(ultId) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(ultId, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, FacturaVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVenta/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVenta = New ModeloFacturaVenta With {.IdFacturaVenta = JsonConvert.DeserializeObject(Of Integer)(Json)}

                If FacturaVenta.Eliminar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVenta/Todos")>
        Public Function Todos() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVenta = New ModeloFacturaVenta()

                Dim lista As List(Of ModeloFacturaVenta) = FacturaVenta.ListadoCompleto()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVenta))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVenta))(Nothing, FacturaVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaVenta/Filtrar_Sin_Remitar")>
        Public Function Filtrar_Sin_Remitar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaVenta = New ModeloFacturaVenta()

                Dim lista As List(Of ModeloFacturaVenta) = FacturaVenta.ListadoSinRemitar()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVenta))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaVenta))(Nothing, FacturaVenta.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("FacturaVenta/ServicioInsertar")>
        Public Function ServicioInsertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = JsonConvert.DeserializeObject(Of ServicioFacturaVenta)(ObtenerDatosEntrantes(Request))

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.Insertar()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of FEResultCAE)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace