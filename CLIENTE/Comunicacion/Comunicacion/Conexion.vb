Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class Conexion
    Private ReadOnly ServerIP As String
    Private Request As HttpWebRequest

    Public Sub New()
        ServerIP = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\SiGeVA\SiGeVA_ServerIP.txt")
    End Sub

    Protected Sub GenerarPeticionGET(Url As String, parametros As Object)
        Request = WebRequest.Create("http://" + ServerIP + "/" + Url + "?Json=" + JsonConvert.SerializeObject(parametros))
        Request.Headers.Add("access-token", Validaciones.Ecy.EncryptData(Validaciones.Token))
    End Sub

    Protected Sub GenerarPeticionGET(Url As String)
        Request = WebRequest.Create("http://" + ServerIP + "/" + Url)
        Request.Headers.Add("access-token", Validaciones.Ecy.EncryptData(Validaciones.Token))
    End Sub

    Protected Async Function GenerarPeticionPOST(Url As String, parametros As Object) As Task
        Dim Encode As UTF8Encoding = New UTF8Encoding()
        Dim JsonArray() As Byte = Encode.GetBytes(Validaciones.Ecy.EncryptData(JsonConvert.SerializeObject(parametros)))

        Request = WebRequest.Create("http://" + ServerIP + "/" + Url)
        Request.Method = "POST"
        Request.ContentType = "text/plain"
        Request.ContentLength = JsonArray.Length
        Request.Headers.Add("access-token", Validaciones.Ecy.EncryptData(Validaciones.Token))

        Using Str As Stream = Await Request.GetRequestStreamAsync()
            Str.Write(JsonArray, 0, JsonArray.Length)
        End Using
    End Function

    Protected Async Function ObtenerRespuesta() As Task(Of HttpWebResponse)
        Return Await Request.GetResponseAsync()
    End Function
End Class
