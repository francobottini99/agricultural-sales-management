Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class ValoresEnCarteraController
        Inherits Controller

        Private Valores As ModeloValoresEnCartera

        <HttpGet>
        <Route("ValoresEnCartera/Todos")>
        Public Function Todos() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Valores = New ModeloValoresEnCartera()

                Dim lista As List(Of ModeloValoresEnCartera) = Valores.ListadoCompleto()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloValoresEnCartera))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloValoresEnCartera))(Nothing, Valores.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloValoresEnCartera))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("ValoresEnCartera/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Valores = JsonConvert.DeserializeObject(Of ModeloValoresEnCartera)(ObtenerDatosEntrantes(Request))

                If Valores.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Valores.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("ValoresEnCartera/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Valores = New ModeloValoresEnCartera With {.IdValoresEnCartera = JsonConvert.DeserializeObject(Of Integer)(Json)}

                If Valores.Eliminar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Valores.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpPost>
        <Route("ValoresEnCartera/Modificar")>
        Public Function Modificar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Valores = JsonConvert.DeserializeObject(Of ModeloValoresEnCartera)(ObtenerDatosEntrantes(Request))

                If Valores.Modificar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Valores.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("ValoresEnCartera/ListadoDisponible/{Json}")>
        Public Function ListadoDisponible(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Valores = New ModeloValoresEnCartera With {.Disponible = JsonConvert.DeserializeObject(Of String)(Json)}

                Dim lista As List(Of ModeloValoresEnCartera) = Valores.ListadoDisponible()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloValoresEnCartera))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloValoresEnCartera))(Nothing, Valores.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloValoresEnCartera))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Caja/SaldoPesos")>
        Public Function SaldoPesos() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Valores = New ModeloValoresEnCartera()

                Dim Saldo As Double = Valores.SaldoPesos()

                If Not IsNothing(Saldo) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Double)(Saldo, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Double)(Nothing, Valores.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Double)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Caja/SaldoDolares")>
        Public Function SaldoDolares() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Valores = New ModeloValoresEnCartera()

                Dim Saldo As Double = Valores.SaldoDolares()

                If Not IsNothing(Saldo) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Double)(Saldo, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Double)(Nothing, Valores.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Double)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace