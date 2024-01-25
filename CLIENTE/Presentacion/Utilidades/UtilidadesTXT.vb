Imports Procesos

Public Class UtilidadesTXT
    Public Enum txtTipos
        MONEDA_CONTABLE
        MONEDA_PRINCIPAL
    End Enum

    Private Shared txtContAnt As Integer
    Private Shared txtAnt As String
    Private Shared simPpal As String
    Private Shared simSec As String

    Public Shared Sub VaciarTxt(ByRef frm As Control)
        For Each ctrl As Control In frm.Controls
            If ctrl.HasChildren Then
                VaciarTxt(ctrl)
            End If

            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    Private Shared Sub Simbolos(TipoMonedaPPal As txtTipos, TipoMonedaSec As txtTipos)
        If TipoMonedaSec = txtTipos.MONEDA_CONTABLE Then
            simSec = DatosSesion._MonedaContable.Simbolo
        Else
            simSec = DatosSesion._MonedaPPal.Simbolo
        End If

        If TipoMonedaPPal = txtTipos.MONEDA_CONTABLE Then
            simPpal = DatosSesion._MonedaContable.Simbolo
        Else
            simPpal = DatosSesion._MonedaPPal.Simbolo
        End If
    End Sub

    Private Shared Sub Simbolos(TipoMonedaPPal As txtTipos)
        If TipoMonedaPPal = txtTipos.MONEDA_CONTABLE Then
            simPpal = DatosSesion._MonedaContable.Simbolo
        Else
            simPpal = DatosSesion._MonedaPPal.Simbolo
        End If
    End Sub

    Public Shared Sub FormatoMonedaTXT(ByRef txtPPal As TextBox, ByRef txtSec As TextBox, ByRef evPPal As EventHandler, ByRef evSec As EventHandler, ParidadCambiaria As Double, TipoMonedaPPal As txtTipos, TipoMonedaSec As txtTipos)
        If txtPPal.Text <> "" Then
            Simbolos(TipoMonedaPPal, TipoMonedaSec)

            If txtPPal.TextLength <= simPpal.Length + 1 Or txtAnt <> txtPPal.Name Or txtPPal.Text = "" Then
                txtContAnt = 0
            End If

            RemoveHandler txtSec.TextChanged, evSec

            Dim CursorPos As Integer = txtPPal.SelectionStart

            RemoveHandler txtPPal.TextChanged, evPPal

            If txtPPal.TextLength = 1 Then
                CursorPos = CursorPos + simPpal.Length + 1
            End If

            If (txtPPal.TextLength <= simPpal.Length + 1 And txtPPal.TextLength > 1) Or (simPpal.Length = 1 And txtPPal.TextLength >= 1 And Not IsNumeric(txtPPal.Text)) Or (txtPPal.TextLength = 1 And Not IsNumeric(txtPPal.Text)) Then
                txtPPal.Text = ""
                txtSec.Text = ""
                txtContAnt = 0
            Else
                If txtPPal.Text.IndexOf("."c) <> -1 And txtPPal.Text.Length < 11 Then
                    Dim Str As String() = txtPPal.Text.Split("."c)

                    If Str(0) = simPpal & " " Or Str(0) = simPpal & " 0" Or txtPPal.Text = "." Then
                        txtPPal.Text = simPpal & " 0" & "." & Str(1)
                        CursorPos += 2
                    Else
                        txtPPal.Text = Format(UtilidadesVarias.SoloNumeros(Str(0)), simPpal & " ##,#0") + "." + Str(1)
                    End If
                Else
                    txtPPal.Text = Format(Math.Round(UtilidadesVarias.SoloNumeros(txtPPal.Text)), simPpal & " ##,#")
                End If
            End If

            If txtPPal.TextLength >= simPpal.Length + 1 Then
                If txtPPal.Text.IndexOf("."c) <> -1 Then
                    Dim Str As String() = txtPPal.Text.Split("."c)

                    If Str(0) = "" Then
                        txtPPal.Text = simPpal & " 0" & "." & Str(1)
                        CursorPos = CursorPos + simPpal.Length + 2
                    End If
                End If

                If TipoMonedaPPal = txtTipos.MONEDA_PRINCIPAL Then
                    If txtPPal.Text.Length > 10 Then
                        txtSec.Text = Format(Math.Round(UtilidadesVarias.SoloNumeros(txtPPal.Text) * ParidadCambiaria), simSec & " ##,#")
                    Else
                        txtSec.Text = Format(Math.Round(UtilidadesVarias.SoloNumeros(txtPPal.Text) * ParidadCambiaria, 2), simSec & " ##,#0.00")
                    End If
                Else
                    If txtPPal.Text.Length > 10 Then
                        txtSec.Text = Format(Math.Round(UtilidadesVarias.SoloNumeros(txtPPal.Text) / ParidadCambiaria), simSec & " ##,#")
                    Else
                        txtSec.Text = Format(Math.Round(UtilidadesVarias.SoloNumeros(txtPPal.Text) / ParidadCambiaria, 2), simSec & " ##,#0.00")
                    End If
                End If
            End If

            For Each c As Char In txtPPal.Text
                If c = ","c And txtContAnt < txtPPal.TextLength - 1 And txtPPal.SelectionStart = 0 Then
                    CursorPos += 1
                End If
            Next

            If txtContAnt > txtPPal.TextLength + 1 And txtContAnt <> 0 Then
                CursorPos -= 1
            End If

            AddHandler txtPPal.TextChanged, evPPal

            txtContAnt = txtPPal.TextLength
            txtPPal.SelectionStart = CursorPos
            txtAnt = txtPPal.Name
        Else
            txtSec.Text = ""
        End If
    End Sub

    Public Shared Sub FormatoMonedaTXT(ByRef txtPPal As TextBox, ByRef evPPal As EventHandler, TipoMonedaPPal As txtTipos)
        If txtPPal.Text <> "" Then
            Simbolos(TipoMonedaPPal)

            If txtPPal.TextLength <= simPpal.Length + 1 Or txtAnt <> txtPPal.Name Then
                txtContAnt = 0
            End If

            Dim CursorPos As Integer = txtPPal.SelectionStart

            RemoveHandler txtPPal.TextChanged, evPPal

            If txtPPal.TextLength = 1 Then
                CursorPos = CursorPos + simPpal.Length + 1
            End If

            If (txtPPal.TextLength <= simPpal.Length + 1 And txtPPal.TextLength > 1) Or (simPpal.Length = 1 And txtPPal.TextLength >= 1 And Not IsNumeric(txtPPal.Text)) Or (txtPPal.TextLength = 1 And Not IsNumeric(txtPPal.Text)) Then
                txtPPal.Text = ""
                txtContAnt = 0
            Else
                If txtPPal.Text.IndexOf("."c) <> -1 Then
                    Dim Str As String() = txtPPal.Text.Split("."c)

                    If Str(0) = simPpal & " " Or Str(0) = simPpal & " 0" Or txtPPal.Text = "." Then
                        txtPPal.Text = simPpal & " 0" & "." & Str(1)
                        CursorPos = CursorPos + 2
                    Else
                        txtPPal.Text = Format(UtilidadesVarias.SoloNumeros(Str(0)), simPpal & " ##,#0") + "." + Str(1)
                    End If
                Else
                    txtPPal.Text = Format(Math.Round(UtilidadesVarias.SoloNumeros(txtPPal.Text)), simPpal & " ##,#0")
                End If
            End If

            If txtPPal.TextLength >= simPpal.Length + 1 Then
                If txtPPal.Text.IndexOf("."c) <> -1 Then
                    Dim Str As String() = txtPPal.Text.Split("."c)

                    If Str(0) = "" Then
                        txtPPal.Text = simPpal & " 0" & "." & Str(1)
                        CursorPos = CursorPos + simPpal.Length + 2
                    End If
                End If
            End If

            For Each c As Char In txtPPal.Text
                If c = ","c And txtContAnt < txtPPal.TextLength - 1 And txtPPal.SelectionStart = 0 Then
                    CursorPos = CursorPos + 1
                End If
            Next

            If txtContAnt > txtPPal.TextLength + 1 And txtContAnt <> 0 Then
                CursorPos = CursorPos - 1
            End If

            AddHandler txtPPal.TextChanged, evPPal

            txtContAnt = txtPPal.TextLength
            txtPPal.SelectionStart = CursorPos
            txtAnt = txtPPal.Name
        End If
    End Sub

    Public Shared Sub ResetVariables()
        txtAnt = ""
        txtContAnt = 0
    End Sub

End Class
