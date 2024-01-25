Public Class UtilidadesVarias
    Public Shared Function SoloNumeros(ByVal cadenaTexto As String) As Double
        Const listaNumeros = "0123456789."
        Dim cadenaTemporal As String
        Dim i As Integer

        cadenaTexto = Trim$(cadenaTexto)

        cadenaTemporal = ""

        For i = 1 To Len(cadenaTexto)
            If InStr(listaNumeros, Mid$(cadenaTexto, i, 1)) Then
                cadenaTemporal = cadenaTemporal + Mid$(cadenaTexto, i, 1)
            End If
        Next

        Return CDbl(cadenaTemporal)
    End Function
End Class
