Public Class UtilidadesVarias
    Private Class Resoluciones
        Public Property Width As Integer
        Public Property Height As Integer

        Public Sub New()
        End Sub
    End Class

    Private Shared CurrentScreen As Resoluciones
    Private Shared CurrentContainer As Resoluciones

    Private Shared ReadOnly ScreenDesing As New Resoluciones With {.Width = 1600, .Height = 900}
    Private Shared ReadOnly ContainerDesing As New Resoluciones With {.Width = 1352, .Height = 827}

    Private Shared Sub ResolucionActual(Frm As Form)
        For Each item As Screen In Screen.AllScreens
            If item.WorkingArea.Contains(Frm.Location) Then
                CurrentScreen = New Resoluciones With {
                                    .Width = item.Bounds.Width,
                                    .Height = item.Bounds.Height
                                }
            End If
        Next

        CurrentContainer = New Resoluciones With {
                            .Width = frmPpal.pnlContenedor.Width,
                            .Height = frmPpal.pnlContenedor.Height
                         }

        'Dim res As String = CurrentScreen.Width.ToString() + "x" + CurrentScreen.Height.ToString()

        'Select Case res
        '    Case "10"
        'End Select
    End Sub

    Public Shared Sub Escalar(Frm As Form, Optional subFrm As Boolean = False)
        Dim RatioX As Single
        Dim RatioY As Single

        ResolucionActual(Frm)

        If subFrm Then
            RatioX = CurrentContainer.Width / ContainerDesing.Width
            RatioY = CurrentContainer.Height / ContainerDesing.Height
        Else
            RatioX = CurrentScreen.Width / ScreenDesing.Width
            RatioY = CurrentScreen.Height / ScreenDesing.Height

            With Frm
                If TypeOf Frm Is frmMsg Then
                    Frm.AutoSize = False
                End If

                .MinimumSize = New Size(.MinimumSize.Width * RatioX, .MinimumSize.Height * RatioY)
                .MaximumSize = New Size(.MaximumSize.Width * RatioX, .MaximumSize.Height * RatioY)
                .Width = CInt(.Width * RatioX)
                .Height = CInt(.Height * RatioY)
                '.Location = New Point(.Location.X * RatioX, .Location.Y * RatioY)
            End With
        End If

        For Each iControl As Control In Frm.Controls
            Escalar(iControl, RatioX, RatioY)
        Next

        If TypeOf Frm Is frmMsg Then
            With DirectCast(Frm, frmMsg)
                .AutoSize = True
                .btnOK.Location = New Point(.btnOK.Location.X, .lblMsg.Height + 15)
                .btnCerrar.Location = New Point(.btnCerrar.Location.X, .lblMsg.Height + 15)
            End With
        End If
    End Sub

    Private Shared Sub Escalar(ctrl As Control, ratioX As Single, ratioY As Single)
        If ctrl.Controls.Count > 0 Then
            For Each iControl As Control In ctrl.Controls
                Escalar(iControl, ratioX, ratioY)
            Next
        End If

        If TypeOf ctrl Is Button Then
            With DirectCast(ctrl, Button)
                If Not IsNothing(.Image) Then
                    Dim newImg As New Bitmap(.Image, New Size(.Image.Width * ratioX, .Image.Height * ratioY))

                    Using g As Graphics = Graphics.FromImage(newImg)
                        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
                        g.DrawImage(.Image, 0, 0, newImg.Width, newImg.Height)
                    End Using

                    .Image = newImg
                End If

                .Font = New Font(.Font.Name, .Font.Size * Convert.ToSingle((CurrentScreen.Height / ScreenDesing.Height) * (CurrentScreen.Width / ScreenDesing.Width)), .Font.Style)
            End With
        ElseIf TypeOf ctrl Is PictureBox Then
            With DirectCast(ctrl, PictureBox)
                .BorderStyle = BorderStyle.None

                If .SizeMode = PictureBoxSizeMode.CenterImage Then
                    .Width *= ratioX
                    .Height *= ratioY
                    'Dim img As Image = .Image
                    'Dim newImg As New Bitmap(img, New Size(.Image.Width * ratioX, .Image.Height * ratioY))
                    'Dim g As Graphics = Graphics.FromImage(newImg)
                    'g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
                    'g.DrawImage(img, 0, 0, newImg.Width, newImg.Height)

                    '.Image = newImg
                End If
            End With
        ElseIf TypeOf ctrl Is Label Or TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
            ctrl.Font = New Font(ctrl.Font.Name, ctrl.Font.Size * Convert.ToSingle((CurrentScreen.Height / ScreenDesing.Height) * (CurrentScreen.Width / ScreenDesing.Width)), ctrl.Font.Style)
        End If

        With ctrl
            .MinimumSize = New Size(.MinimumSize.Width * ratioX, .MinimumSize.Height * ratioY)
            .MaximumSize = New Size(.MaximumSize.Width * ratioX, .MaximumSize.Height * ratioY)
            .Width = CInt(.Width * ratioX)
            .Height = CInt(.Height * ratioY)
            .Location = New Point(.Location.X * ratioX, .Location.Y * ratioY)
        End With
    End Sub

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

    Public Shared Function SoloNumeros(ByVal cadenaTexto As String) As Double
        If cadenaTexto <> "" Then
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
        Else
            Return 0
        End If
    End Function

    Public Shared Function ValidaCUIT(ByVal NroCuit As String) As Boolean
        Dim ValidaResp As Boolean = False

        If Len(NroCuit) = 0 Or Len(NroCuit) > 13 Then
            ValidaResp = False
        Else
            Dim validaSuma As Integer = 0
            Dim caracTer As String = ""
            Dim SoloNro As String = ""
            Dim sumaCaracter As Integer = 0

            For X As Integer = 1 To Len(NroCuit)
                caracTer = Mid(NroCuit, X, 1)
                If IsNumeric(caracTer) Then
                    SoloNro = SoloNro & caracTer
                    sumaCaracter = sumaCaracter + caracTer
                End If
            Next X
            If sumaCaracter > 0 Then
                If Len(SoloNro) = 11 Then
                    validaSuma += CInt(SoloNro.Substring(0, 1)) * 5
                    validaSuma += CInt(SoloNro.Substring(1, 1)) * 4
                    validaSuma += CInt(SoloNro.Substring(2, 1)) * 3
                    validaSuma += CInt(SoloNro.Substring(3, 1)) * 2
                    validaSuma += CInt(SoloNro.Substring(4, 1)) * 7
                    validaSuma += CInt(SoloNro.Substring(5, 1)) * 6
                    validaSuma += CInt(SoloNro.Substring(6, 1)) * 5
                    validaSuma += CInt(SoloNro.Substring(7, 1)) * 4
                    validaSuma += CInt(SoloNro.Substring(8, 1)) * 3
                    validaSuma += CInt(SoloNro.Substring(9, 1)) * 2
                    validaSuma += CInt(SoloNro.Substring(10, 1)) * 1
                    If Math.Round(validaSuma / 11, 0) = (validaSuma / 11) Then
                        ValidaResp = True
                    Else
                        ValidaResp = False
                    End If
                Else
                    ValidaResp = False
                End If
            Else
                ValidaResp = False
            End If
        End If

        Return ValidaResp
    End Function

    Public Shared Function GenerarNumeroComprobante(ByVal Prefijo As String, ByVal Nro As Integer) As String
        Dim NroComprobante As String = ""

        If Prefijo <> "" Then
            NroComprobante = Prefijo & " - "
        End If

        If Nro.ToString().Length = 1 Then
            NroComprobante = NroComprobante & "0000000" & Nro.ToString()
        ElseIf Nro.ToString().Length = 2 Then
            NroComprobante = NroComprobante & "000000" & Nro.ToString()
        ElseIf Nro.ToString().Length = 3 Then
            NroComprobante = NroComprobante & "00000" & Nro.ToString()
        ElseIf Nro.ToString().Length = 4 Then
            NroComprobante = NroComprobante & "0000" & Nro.ToString()
        ElseIf Nro.ToString().Length = 5 Then
            NroComprobante = NroComprobante & "000" & Nro.ToString()
        ElseIf Nro.ToString().Length = 6 Then
            NroComprobante = NroComprobante & "00" & Nro.ToString()
        ElseIf Nro.ToString().Length = 7 Then
            NroComprobante = NroComprobante & "0" & Nro.ToString()
        Else
            NroComprobante &= Nro.ToString()
        End If

        Return NroComprobante
    End Function

    Public Shared Function GenerarPrefijoComprobante(ByVal Nro As Integer) As String
        Dim Prefijo As String = ""

        If Nro.ToString().Length = 1 Then
            Prefijo = Prefijo & "000" & Nro.ToString()
        ElseIf Nro.ToString().Length = 2 Then
            Prefijo = Prefijo & "00" & Nro.ToString()
        ElseIf Nro.ToString().Length = 3 Then
            Prefijo = Prefijo & "0" & Nro.ToString()
        Else
            Prefijo &= Nro.ToString()
        End If

        Return Prefijo
    End Function
End Class
