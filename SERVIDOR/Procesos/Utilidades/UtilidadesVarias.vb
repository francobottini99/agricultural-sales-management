Imports System.Collections.Specialized
Imports AccesoDatos

Public Class UtilidadesVarias
    Public Shared Property Ecy As New Encrypter("UEv9wUp2M7969DS769GD4DrwV686vfumBzRdYE7jsQ64E2D2de8mrZh944pph3Gn6n9CgSG2aLv843eNMNLrDRjB2v6jfeJ37BL")

    Public Shared Function quitarGuiones(cadena As String) As String
        Dim cadenaSg As String = ""

        For X = 1 To Len(cadena)
            Dim Nn As String = Mid(cadena, X, 1)

            If IsNumeric(Nn) Then
                cadenaSg &= Nn
            End If
        Next

        Return cadenaSg
    End Function

    Public Shared Function VerificarToken(headers As NameValueCollection) As Boolean
        Try
            If Not IsNothing(headers.Get("access-token")) Then
                Dim token As String = Ecy.DecryptData(headers.GetValues("access-token").FirstOrDefault())

                If Not (token = "-") Then
                    Return New TransaccionesUsuarios().verExisteToken(token)
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function CodComprobanteAFIP(tipoComprobante As String) As WSAFIPFE.Factura.TipoComprobante
        Select Case tipoComprobante
            Case "A"
                Return WSAFIPFE.Factura.TipoComprobante.FacturaA
            Case "B"
                Return WSAFIPFE.Factura.TipoComprobante.FacturaB
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function CodIvaAFIP(alicuota As Double) As AlicuotasIVA
        Select Case alicuota
            Case 10.5
                Return AlicuotasIVA.I10_5
            Case 5
                Return AlicuotasIVA.I5
            Case 2.5
                Return AlicuotasIVA.I2_5
            Case 27
                Return AlicuotasIVA.I27
            Case 0
                Return AlicuotasIVA.I0
            Case 21
                Return AlicuotasIVA.I21
            Case Else
                Return Nothing
        End Select
    End Function
End Class
