Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class ArticulosController
        Inherits Controller

        Private Articulo As ModeloArticulos
        Private Servicio As ServicioArticulos

        <HttpPost>
        <Route("Articulos/ActualizarPrecio")>
        Public Function ActualizarPrecio() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Articulo = JsonConvert.DeserializeObject(Of ModeloArticulos)(ObtenerDatosEntrantes(Request))

                If Articulo.ModificarPrecio() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Articulo.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("Articulos/ActualizarCosto")>
        Public Function ActualizarCosto() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Articulo = JsonConvert.DeserializeObject(Of ModeloArticulos)(ObtenerDatosEntrantes(Request))

                If Articulo.ModificarCosto() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Articulo.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("Articulos/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Articulo = JsonConvert.DeserializeObject(Of ModeloArticulos)(ObtenerDatosEntrantes(Request))

                If Articulo.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Articulo.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("Articulos/ServicioModificar")>
        Public Function ServicioModificar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Dim datos As ModeloArticulos = JsonConvert.DeserializeObject(Of ModeloArticulos)(ObtenerDatosEntrantes(Request))

                Servicio = New ServicioArticulos(datos, datos.AscRubro, datos.AscSubRubro)

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.Modificar()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("Articulos/ServicioInsertar")>
        Public Function ServicioInsertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Dim datos As ModeloArticulos = JsonConvert.DeserializeObject(Of ModeloArticulos)(ObtenerDatosEntrantes(Request))

                Servicio = New ServicioArticulos(datos, datos.AscRubro, datos.AscSubRubro)

                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(Servicio.Insertar()))
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Articulos/UltimoID")>
        Public Function UltimoID() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Articulo = New ModeloArticulos()

                Dim ultId As Integer = Articulo.UltimoId()

                If Not IsNothing(ultId) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(ultId, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, Articulo.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Articulos/Todos_SinImagenes")>
        Public Function Todos_SinImagenes() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Articulo = New ModeloArticulos()

                Dim lista As List(Of ModeloArticulos) = Articulo.ListadoSinImagenes()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloArticulos))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloArticulos))(Nothing, Articulo.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloArticulos))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Articulos/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Articulo = New ModeloArticulos With {.IdArticulo = JsonConvert.DeserializeObject(Of Integer)(Json)}

                If Articulo.Eliminar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Articulo.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Articulos/ConsultarImagen/{Json}")>
        Public Function ConsultarImagen(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Articulo = New ModeloArticulos With {.IdArticulo = JsonConvert.DeserializeObject(Of Integer)(Json)}

                Dim imagen As String = Articulo.ConsultarImagenPorId()

                If Not IsNothing(imagen) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of String)(imagen, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of String)(Nothing, Articulo.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of String)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Articulos/Filtrar_idArticulo/{Json}")>
        Public Function Filtrar_idArticulo(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Articulo = New ModeloArticulos With {.IdArticulo = JsonConvert.DeserializeObject(Of Integer)(Json)}

                Dim registro As ModeloArticulos = Articulo.ConsultarPorId()

                If Not IsNothing(registro) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloArticulos)(registro, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloArticulos)(Nothing, Articulo.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloArticulos)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("Articulos/Modificar")>
        Public Function Modificar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Articulo = JsonConvert.DeserializeObject(Of ModeloArticulos)(ObtenerDatosEntrantes(Request))

                If Articulo.Modificar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Articulo.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

    End Class
End Namespace