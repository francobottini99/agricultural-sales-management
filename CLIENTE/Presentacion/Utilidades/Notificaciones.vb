Public Enum Botones
    OK
    OK_CANCEL
    SI_NO
End Enum

Public Enum Iconos
    ALERTA
    INFORMACION
    OK
    ERR
End Enum

Public Class Notificaciones
    Public Shared Function MsgBox(ByVal mensaje As String, ByVal boton As Botones, ByVal icono As Iconos) As DialogResult
        frmMsg.lblMsg.Text = mensaje

        If boton = Botones.OK_CANCEL Then
            frmMsg.btnCerrar.Visible = True

            frmMsg.btnCerrar.Text = "Cancelar"
            frmMsg.btnOK.Text = "Ok"
        ElseIf boton = Botones.OK Then
            frmMsg.btnCerrar.Visible = False

            frmMsg.btnOK.Text = "Ok"
        ElseIf boton = Botones.SI_NO Then
            frmMsg.btnCerrar.Visible = True

            frmMsg.btnCerrar.Text = "No"
            frmMsg.btnOK.Text = "Si"
        End If

        If icono = Iconos.ALERTA Then
            frmMsg.pbxAlerta.BringToFront()
            frmMsg.btnOK.FlatAppearance.MouseOverBackColor = Color.FromArgb(190, 140, 5)
            frmMsg.btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(190, 140, 5)
            frmMsg.BackColor = Color.FromArgb(190, 140, 5)
            frmMsg.bnfBarraTitulo.color = Color.FromArgb(190, 140, 5)
            frmMsg.bnfBarraTitulo.BackColor = Color.FromArgb(190, 140, 5)
            frmMsg.btnColorR = 190
            frmMsg.btnColorG = 140
            frmMsg.btnColorB = 5
        ElseIf icono = Iconos.ERR Then
            frmMsg.pbxError.BringToFront()
            frmMsg.BackColor = Color.FromArgb(150, 50, 50)
            frmMsg.btnOK.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 50, 50)
            frmMsg.btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 50, 50)
            frmMsg.bnfBarraTitulo.color = Color.FromArgb(150, 50, 50)
            frmMsg.bnfBarraTitulo.BackColor = Color.FromArgb(150, 50, 50)
            frmMsg.btnColorR = 150
            frmMsg.btnColorG = 50
            frmMsg.btnColorB = 50
        ElseIf icono = Iconos.INFORMACION Then
            frmMsg.pbxInf.BringToFront()
            frmMsg.BackColor = Color.FromArgb(0, 0, 150)
            frmMsg.btnOK.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 150)
            frmMsg.btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 150)
            frmMsg.bnfBarraTitulo.color = Color.FromArgb(0, 0, 150)
            frmMsg.bnfBarraTitulo.BackColor = Color.FromArgb(0, 0, 150)
            frmMsg.btnColorR = 0
            frmMsg.btnColorG = 0
            frmMsg.btnColorB = 150
        ElseIf icono = Iconos.OK Then
            frmMsg.pbxOk.BringToFront()
            frmMsg.BackColor = Color.FromArgb(95, 150, 15)
            frmMsg.btnOK.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 150, 15)
            frmMsg.btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 150, 15)
            frmMsg.bnfBarraTitulo.color = Color.FromArgb(95, 150, 15)
            frmMsg.bnfBarraTitulo.BackColor = Color.FromArgb(95, 150, 15)
            frmMsg.btnColorR = 95
            frmMsg.btnColorG = 150
            frmMsg.btnColorB = 15
        End If

        frmMsg.btnOK.Select()

        UtilidadesVarias.Escalar(frmMsg)
        Return frmMsg.ShowDialog()
    End Function

    Public Shared Sub arbirFormProceso(Optional mensaje As String = "CARGANDO")
        If frmProceso.Visible = False Then
            frmProceso.lblMensaje.Text = mensaje
            BloquearForms()
            UtilidadesVarias.Escalar(frmProceso)
            frmProceso.Show()
        End If
    End Sub

    Public Shared Sub cerrarFormProceso()
        If frmProceso.Visible = True Then
            HabilitarForms()
            frmProceso.Close()
            frmProceso.Dispose()
        End If
    End Sub

    Private Shared listFrmDisable As List(Of Form)

    Private Shared Sub BloquearForms()
        If IsNothing(listFrmDisable) Then
            listFrmDisable = New List(Of Form)
        End If

        For Each frm As Form In My.Application.OpenForms
            If frm.ContainsFocus Then
                listFrmDisable.Add(frm)
                frm.Enabled = False
            End If
        Next
    End Sub

    Private Shared Sub HabilitarForms()
        For Each frm As Form In listFrmDisable
            frm.Enabled = True
        Next

        listFrmDisable.Clear()
    End Sub
End Class
