Imports System.IO
Imports Procesos

Module Funciones
    Public Function ObtenerDatosEntrantes(Request As HttpRequestBase) As String
        Using Reader = New StreamReader(Request.GetBufferlessInputStream(True), Encoding.UTF8)
            Return UtilidadesVarias.Ecy.DecryptData(Reader.ReadToEnd)
        End Using
    End Function
End Module
