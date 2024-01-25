Public Class CodigoBarraAFIP
    Public Property CUIT As String
    Public Property FechaVtoCAE As String
    Public Property CodigoComprobante As String
    Public Property CAE As String
    Public Property PtoVta As String
    Public Property DigitoVerificador As Integer

    Public ReadOnly Property CodBarra As String

    Public Sub New(CUIT As String, CodigoComprobante As String, ptoVta As String, CAE As String, fechaVtoCAE As String)
        Me.CUIT = CUIT
        Me.FechaVtoCAE = fechaVtoCAE
        Me.CodigoComprobante = CodigoComprobante
        Me.CAE = CAE
        Me.PtoVta = ptoVta

        GenerarDigitoVerificador()

        CodBarra = Me.CUIT & Me.CodigoComprobante & Me.PtoVta & Me.CAE & Me.FechaVtoCAE & Me.DigitoVerificador
    End Sub

    Private Sub GenerarDigitoVerificador()
        Dim CodBarra As String = CUIT & CodigoComprobante & PtoVta & CAE & FechaVtoCAE

        Dim SumaParcialImpares As Integer = 0
        For i As Integer = 0 To CodBarra.Length Step 2
            SumaParcialImpares += CInt(CodBarra.Substring(i, 1))
        Next
        SumaParcialImpares *= 3

        Dim SumaParcialPares As Integer = 0
        For i As Integer = 1 To CodBarra.Length - 1 Step 2
            SumaParcialPares += CInt(CodBarra.Substring(i, 1))
        Next

        Dim sumaTotal As Integer = SumaParcialImpares + SumaParcialPares
        For i As Integer = 0 To 9
            If (sumaTotal + i) Mod 10 = 0 Then
                DigitoVerificador = i
                Exit For
            End If
        Next
    End Sub
End Class
