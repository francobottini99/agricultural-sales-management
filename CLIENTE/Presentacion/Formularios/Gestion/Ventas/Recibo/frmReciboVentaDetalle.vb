Imports Procesos

Public Class frmReciboVentaDetalle
    Private listCompletaBancos As List(Of Bancos)
    Private _TareasBanco As TareasBancos

#Region "ANIMACION BOTONES"
    Private Sub btnAgregar_GotFocus(sender As Object, e As EventArgs) Handles btnAgregar.GotFocus
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnAgregar_LostFocus(sender As Object, e As EventArgs) Handles btnAgregar.LostFocus
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnAgregar_MouseEnter(sender As Object, e As EventArgs) Handles btnAgregar.MouseEnter
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub
#End Region

#Region "LOAD FORM"
    Private Sub frmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _TareasBanco = New TareasBancos()

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_TickAsync(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        cmbBanco.Items.Clear()

        cmbMoneda.Items.Add("PESO")
        cmbMoneda.Items.Add("DOLAR")

        cmbTipo.Items.Add("EFECTIVO")
        cmbTipo.Items.Add("CHEQUE")

        If txtOrigen.Text = "Editar" Then
            cmbTipo.Text = frmReciboVenta.dgvDetalleRecibo.CurrentRow.Cells("Tipo").Value
            cmbMoneda.Text = frmReciboVenta.dgvDetalleRecibo.CurrentRow.Cells("Moneda").Value
            txtImporte.Text = frmReciboVenta.dgvDetalleRecibo.CurrentRow.Cells("Importe").Value

            If cmbTipo.Text = "CHEQUE" Then
                txtFechaCobro.Text = frmReciboVenta.dgvDetalleRecibo.CurrentRow.Cells("FechaCobro").Value
                txtNumero.Text = frmReciboVenta.dgvDetalleRecibo.CurrentRow.Cells("Numero").Value
                cmbBanco.Text = frmReciboVenta.dgvDetalleRecibo.CurrentRow.Cells("Banco").Value
                txtSucursal.Text = frmReciboVenta.dgvDetalleRecibo.CurrentRow.Cells("Sucursal").Value
                txtLibrador.Text = frmReciboVenta.dgvDetalleRecibo.CurrentRow.Cells("Librador").Value
            End If
        End If

        cmbTipo.SelectionLength = Len(cmbTipo.Text)
        cmbTipo.Select()
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cmbTipo.Text = "" Then
            Notificaciones.MsgBox("No has especificado el Tipo.", Botones.OK, Iconos.ALERTA)
            cmbTipo.Select()
        Else
            If cmbMoneda.Text = "" Then
                Notificaciones.MsgBox("No has especificado la Moneda.", Botones.OK, Iconos.ALERTA)
                cmbMoneda.Select()
            Else
                If txtImporte.Text = "" Then
                    Notificaciones.MsgBox("No has especificado el Importe.", Botones.OK, Iconos.ALERTA)
                    txtImporte.Select()
                Else
                    If UtilidadesVarias.SoloNumeros(txtImporte.Text) <= 0 Then
                        Notificaciones.MsgBox("El Importe no puede ser menor o igual a 0.", Botones.OK, Iconos.ALERTA)
                        txtImporte.Select()
                    Else
                        If cmbTipo.Text = "EFECTIVO" Then
                            If frmReciboVenta.dgvDetalleRecibo.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                                frmReciboVenta.dgvDetalleRecibo.Rows.Remove(frmReciboVenta.dgvDetalleRecibo.CurrentRow)
                            End If

                            Dim aggNuevo As Boolean = True

                            For Each item As DataGridViewRow In frmReciboVenta.dgvDetalleRecibo.Rows
                                If cmbMoneda.Text = item.Cells("Moneda").Value And item.Cells("Tipo").Value = "EFECTIVO" Then
                                    Dim importe As String = ""

                                    If cmbMoneda.Text = "PESO" Then
                                        importe = Format(UtilidadesVarias.SoloNumeros(txtImporte.Text) + UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value), "$ #,##0.00")
                                    ElseIf cmbMoneda.Text = "DOLAR" Then
                                        importe = Format(UtilidadesVarias.SoloNumeros(txtImporte.Text) + UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value), "U$S #,##0.00")
                                    End If

                                    item.SetValues(0, 0, "EFECTIVO", "-", "-", "-", "-", "-", cmbMoneda.Text, importe)

                                    aggNuevo = False
                                    Exit For
                                End If
                            Next

                            If aggNuevo Then
                                frmReciboVenta.dgvDetalleRecibo.Rows.Add(0, 0, "EFECTIVO", "-", "-", "-", "-", "-", cmbMoneda.Text, txtImporte.Text)
                            End If

                            UtilidadesTXT.ResetVariables()

                            Me.DialogResult = DialogResult.OK

                            Me.Close()
                        ElseIf cmbTipo.Text = "CHEQUE" Then
                            If txtNumero.Text = "" Then
                                Notificaciones.MsgBox("No has especificado el Numero.", Botones.OK, Iconos.ALERTA)
                                txtNumero.Select()
                            Else
                                If cmbBanco.Text = "" Then
                                    Notificaciones.MsgBox("No has especificado el Banco.", Botones.OK, Iconos.ALERTA)
                                    cmbBanco.Select()
                                Else
                                    If txtSucursal.Text = "" Then
                                        Notificaciones.MsgBox("No has especificado la Sucursal.", Botones.OK, Iconos.ALERTA)
                                        txtSucursal.Select()
                                    Else
                                        If txtLibrador.Text = "" Then
                                            Notificaciones.MsgBox("No has especificado el Librador.", Botones.OK, Iconos.ALERTA)
                                            txtLibrador.Select()
                                        Else
                                            If frmReciboVenta.dgvDetalleRecibo.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                                                frmReciboVenta.dgvDetalleRecibo.Rows.Remove(frmReciboVenta.dgvDetalleRecibo.CurrentRow)
                                            End If

                                            frmReciboVenta.dgvDetalleRecibo.Rows.Add(0, 0, "CHEQUE", cmbBanco.Text, txtSucursal.Text, txtNumero.Text, txtLibrador.Text,
                                                                                         Format(CDate(txtFechaCobro.Text), "dd/MM/yyyy"), cmbMoneda.Text, txtImporte.Text)

                                            UtilidadesTXT.ResetVariables()

                                            Me.DialogResult = DialogResult.OK

                                            Me.Close()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        UtilidadesTXT.ResetVariables()

        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub cmbMoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMoneda.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtImporte.SelectionLength = Len(txtImporte.Text)
            txtImporte.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            cmbMoneda.Text = ""

            If cmbMoneda.Enabled And txtImporte.Text <> "" Then
                txtImporte.Text = UtilidadesVarias.SoloNumeros(txtImporte.Text)
            End If
        End If
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If bnfCardValor.Enabled Then
                txtNumero.SelectionLength = Len(txtNumero.Text)
                txtNumero.Select()
            Else
                btnAgregar.Select()
            End If
        ElseIf e.KeyChar = ChrW(46) And Not txtImporte.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbTipoValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTipo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbMoneda.SelectionLength = Len(cmbMoneda.Text)
            cmbMoneda.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            bnfCardValor.Enabled = False
            bnfCardImporte.Enabled = False

            cmbTipo.Text = ""
            cmbMoneda.Text = ""
            txtImporte.Text = ""
            txtFechaCobro.Text = ""
            txtNumero.Text = ""
            cmbBanco.Text = ""
            txtSucursal.Text = ""
            txtLibrador.Text = ""
        End If
    End Sub

    Private Sub cmbBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBanco.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtSucursal.SelectionLength = Len(txtSucursal.Text)
            txtSucursal.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            cmbBanco.Text = ""
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtFechaCobro.SelectionLength = Len(txtFechaCobro.Text)
            txtFechaCobro.Select()
        End If
    End Sub

    Private Sub txtLibrador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLibrador.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnAgregar.Select()
        End If
    End Sub

    Private Sub txtSucursal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSucursal.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtLibrador.SelectionLength = Len(txtLibrador.Text)
            txtLibrador.Select()
        End If
    End Sub

    Private Sub txtFechaCobro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaCobro.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbBanco.SelectionLength = Len(cmbBanco.Text)
            cmbBanco.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtFechaCobro_Validated(sender As Object, e As EventArgs) Handles txtFechaCobro.Validated
        If Not IsDate(txtFechaCobro.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)
            txtFechaCobro.Text = ""
        Else
            txtFechaCobro.Text = Format(CDate(txtFechaCobro.Text), "dd/MM/yyyy")
        End If
    End Sub

    Private Sub txtImporte_Validated(sender As Object, e As EventArgs) Handles txtImporte.Validated
        If txtImporte.Text <> "" Then
            If cmbMoneda.Text = "DOLAR" Then
                txtImporte.Text = Format(UtilidadesVarias.SoloNumeros(txtImporte.Text), "U$S #,##0.00")
            ElseIf cmbMoneda.Text = "PESO" Then
                txtImporte.Text = Format(UtilidadesVarias.SoloNumeros(txtImporte.Text), "$ #,##0.00")
            End If
        End If
    End Sub
#End Region

#Region "EVENTO CHANGED"
    Private Sub txtImporte_TextChanged(sender As Object, e As EventArgs) Handles txtImporte.TextChanged
        If cmbMoneda.Text = "DOLAR" Then
            UtilidadesTXT.FormatoMonedaTXT(txtImporte, AddressOf txtImporte_TextChanged, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)
        ElseIf cmbMoneda.Text = "PESO" Then
            UtilidadesTXT.FormatoMonedaTXT(txtImporte, AddressOf txtImporte_TextChanged, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)
        End If
    End Sub

    Private Sub txtFechaCobro_TextChanged(sender As Object, e As EventArgs) Handles txtFechaCobro.TextChanged
        If txtFechaCobro.Text = "" Then
            If bnfCardValor.Enabled = True Then
                txtFechaCobro.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtFechaCobro.SelectionLength = Len(txtFechaCobro.Text)
                txtFechaCobro.Select()
            End If
        End If
    End Sub

    Private Sub cmbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoneda.SelectedIndexChanged
        If cmbMoneda.Enabled And txtImporte.Text <> "" Then
            RemoveHandler txtImporte.TextChanged, AddressOf txtImporte_TextChanged

            If cmbMoneda.Text = "DOLAR" Then
                txtImporte.Text = Format(UtilidadesVarias.SoloNumeros(txtImporte.Text), "U$S #,##0.00")
            ElseIf cmbMoneda.Text = "PESO" Then
                txtImporte.Text = Format(UtilidadesVarias.SoloNumeros(txtImporte.Text), "$ #,##0.00")
            Else
                txtImporte.Text = UtilidadesVarias.SoloNumeros(txtImporte.Text)
            End If

            AddHandler txtImporte.TextChanged, AddressOf txtImporte_TextChanged
        End If
    End Sub

    Private Async Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.Text = "EFECTIVO" Then
            bnfCardValor.Enabled = False
            bnfCardImporte.Enabled = True

            txtFechaCobro.Text = ""
            txtNumero.Text = ""
            cmbBanco.Text = ""
            txtSucursal.Text = ""
            txtLibrador.Text = ""
        ElseIf cmbTipo.Text = "CHEQUE" Then
            bnfCardValor.Enabled = True
            bnfCardImporte.Enabled = True

            txtFechaCobro.Text = Format(Date.Now.Date, "dd/MM/yyyy")

            listCompletaBancos = Await _TareasBanco.ListadoCompleto()

            cmbBanco.Items.Clear()

            If Not IsNothing(listCompletaBancos) Then
                For Each item In listCompletaBancos
                    cmbBanco.Items.Add(item.Nombre)
                Next

                cmbBanco.Items.Add("Ninguno")

                Notificaciones.cerrarFormProceso()
            ElseIf _TareasBanco.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(_TareasBanco.Err.Descripcion, Botones.OK, Iconos.ERR)
            Else
                Notificaciones.cerrarFormProceso()
            End If
        Else
            bnfCardValor.Enabled = False
            bnfCardImporte.Enabled = False

            cmbMoneda.Text = ""
            txtImporte.Text = ""
            txtFechaCobro.Text = ""
            txtNumero.Text = ""
            cmbBanco.Text = ""
            txtSucursal.Text = ""
            txtLibrador.Text = ""
        End If
    End Sub

#End Region

End Class