Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class FacturaCompraController
        Inherits Controller

        Private FacturaCompra As ModeloFacturaCompra
        Private Servicio As ServicioFacturaCompra

        <HttpPost>
        <Route("FacturaCompra/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompra = JsonConvert.DeserializeObject(Of ModeloFacturaCompra)(ObtenerDatosEntrantes(Request))

                If FacturaCompra.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("FacturaCompra/ServicioInsertar")>
        Public Function ServicioInsertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = JsonConvert.DeserializeObject(Of ServicioFacturaCompra)(ObtenerDatosEntrantes(Request))

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.Insertar()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("FacturaCompra/ServicioModificar")>
        Public Function ServicioModificar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = JsonConvert.DeserializeObject(Of ServicioFacturaCompra)(ObtenerDatosEntrantes(Request))

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.Modificar()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaCompra/UltimoID")>
        Public Function UltimoID() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompra = New ModeloFacturaCompra()

                Dim ultId As Integer = FacturaCompra.UltimoId()

                If Not IsNothing(ultId) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(ultId, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, FacturaCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaCompra/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}

                If FacturaCompra.Eliminar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("FacturaCompra/ServicioEliminar")>
        Public Function ServicioEliminar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Servicio = JsonConvert.DeserializeObject(Of ServicioFacturaCompra)(ObtenerDatosEntrantes(Request))

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.Eliminar()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("FacturaCompra/Modificar")>
        Public Function Modificar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompra = JsonConvert.DeserializeObject(Of ModeloFacturaCompra)(ObtenerDatosEntrantes(Request))

                If FacturaCompra.Modificar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, FacturaCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("FacturaCompra/Todos")>
        Public Function Todos() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                FacturaCompra = New ModeloFacturaCompra()

                Dim lista As List(Of ModeloFacturaCompra) = FacturaCompra.ListadoCompleto()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaCompra))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloFacturaCompra))(Nothing, FacturaCompra.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace