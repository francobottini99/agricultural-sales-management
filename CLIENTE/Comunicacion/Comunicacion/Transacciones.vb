Imports System.IO
Imports System.Net
Imports System.Threading
Imports Newtonsoft.Json

Public MustInherit Class Transacciones
    Inherits Conexion

    Protected Err As Errores

    Protected Async Function HttpGET(Of T)(Url As String, Optional Datos As Object = Nothing) As Task(Of T)
        Using Ct As New CancellationTokenSource
            Err = New Errores()

            Try
                Dim json As String

                Ct.CancelAfter(15000)

                If IsNothing(Datos) Then
                    GenerarPeticionGET(Url)
                Else
                    GenerarPeticionGET(Url, Datos)
                End If

                Dim Response As HttpWebResponse = Await ObtenerRespuesta()

                If Response.StatusCode = HttpStatusCode.OK Then
                    Using Sr As StreamReader = New StreamReader(Response.GetResponseStream())
                        json = Await Sr.ReadToEndAsync()
                    End Using
                Else
                    Err.Descripcion = "Ocurrio un fallo en la conexion con el servidor"
                    Err.Identificador = EnumErrores.ERROR_CONEXION

                    Return Nothing
                End If

                Response.Dispose()

                Dim result As RespuestaHTTP(Of T) = JsonConvert.DeserializeObject(Of RespuestaHTTP(Of T))(Validaciones.Ecy.DecryptData(json))

                If IsNothing(result.Err) Then
                    Err = Nothing

                    Return result.Cuerpo
                Else
                    Err = result.Err

                    Return Nothing
                End If
            Catch ex As OperationCanceledException
                Err.Descripcion = ex.Message
                Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

                Return Nothing
            Catch ex As Exception
                Err.Descripcion = ex.Message
                Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

                Return Nothing
            End Try
        End Using
    End Function

    Protected Async Function HttpPOST(Of T)(Url As String, Datos As Object) As Task(Of T)
        Using Ct As New CancellationTokenSource
            Err = New Errores()

            Try
                Dim json As String

                Ct.CancelAfter(15000)

                Await GenerarPeticionPOST(Url, Datos)

                Dim Response As HttpWebResponse = Await ObtenerRespuesta()

                If Response.StatusCode = HttpStatusCode.OK Then
                    Using Sr As StreamReader = New StreamReader(Response.GetResponseStream())
                        json = Await Sr.ReadToEndAsync()
                    End Using
                Else
                    Err.Descripcion = "Ocurrio un fallo en la conexion con el servidor"
                    Err.Identificador = EnumErrores.ERROR_CONEXION

                    Return Nothing
                End If

                Response.Dispose()

                Dim result As RespuestaHTTP(Of T) = JsonConvert.DeserializeObject(Of RespuestaHTTP(Of T))(Validaciones.Ecy.DecryptData(json))

                If IsNothing(result.Err) Then
                    Err = Nothing

                    Return result.Cuerpo
                Else
                    Err = result.Err

                    Return Nothing
                End If
            Catch ex As OperationCanceledException
                Err.Descripcion = ex.Message
                Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

                Return Nothing
            Catch ex As Exception
                Err.Descripcion = ex.Message
                Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

                Return Nothing
            End Try
        End Using
    End Function
End Class
