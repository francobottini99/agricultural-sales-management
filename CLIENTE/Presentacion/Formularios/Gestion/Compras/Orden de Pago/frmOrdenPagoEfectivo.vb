Imports Procesos

Public Class frmOrdenPagoEfectivo
    Dim _TareasCaja As TareasCaja
    Dim _TareasValoresEnCartera As TareasValoresEnCartera

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

#Region "LOAD"
    Private Sub frmOrdenPagoEfectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _TareasCaja = New TareasCaja()
        _TareasValoresEnCartera = New TareasValoresEnCartera()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        Dim saldoCajaPesos As Double = Await _TareasCaja.SaldoPesos()

        If Not IsNothing(saldoCajaPesos) Then
            Dim saldoCajaDolares As Double = Await _TareasCaja.SaldoDolares()

            If Not IsNothing(saldoCajaDolares) Then
                Dim saldoValoresDolares As Double = Await _TareasValoresEnCartera.SaldoDolares()

                If Not IsNothing(saldoValoresDolares) Then
                    Dim saldoValoresPesos As Double = Await _TareasValoresEnCartera.SaldoPesos()

                    If Not IsNothing(saldoValoresDolares) Then
                        If txtOrigen.Text = "Editar" Then
                            cmbMoneda.Text = frmOrdenPago.dgvDetalleOrden.CurrentRow.Cells("Moneda").Value
                            txtImporte.Text = frmOrdenPago.dgvDetalleOrden.CurrentRow.Cells("Importe").Value

                            If cmbMoneda.Text = "PESO" Then
                                txtEfectivoDolares.Text = Format(saldoCajaDolares - saldoValoresDolares - UtilidadesVarias.SoloNumeros(frmOrdenPago.txtEfectivoDolares.Text), "U$S #,##0.00")
                                txtEfectivoPesos.Text = Format(saldoCajaPesos - saldoValoresPesos - UtilidadesVarias.SoloNumeros(frmOrdenPago.txtEfectivoPesos.Text) + UtilidadesVarias.SoloNumeros(txtImporte.Text), "$ #,##0.00")
                            ElseIf cmbMoneda.Text = "DOLAR" Then
                                txtEfectivoDolares.Text = Format(saldoCajaDolares - saldoValoresDolares - UtilidadesVarias.SoloNumeros(frmOrdenPago.txtEfectivoDolares.Text) + UtilidadesVarias.SoloNumeros(txtImporte.Text), "U$S #,##0.00")
                                txtEfectivoPesos.Text = Format(saldoCajaPesos - saldoValoresPesos - UtilidadesVarias.SoloNumeros(frmOrdenPago.txtEfectivoPesos.Text), "$ #,##0.00")
                            End If
                        Else
                            txtEfectivoDolares.Text = Format(saldoCajaDolares - saldoValoresDolares - UtilidadesVarias.SoloNumeros(frmOrdenPago.txtEfectivoDolares.Text), "U$S #,##0.00")
                            txtEfectivoPesos.Text = Format(saldoCajaPesos - saldoValoresPesos - UtilidadesVarias.SoloNumeros(frmOrdenPago.txtEfectivoPesos.Text), "$ #,##0.00")
                        End If

                        If UtilidadesVarias.SoloNumeros(txtEfectivoPesos.Text) > 0 Then
                            cmbMoneda.Items.Add("PESO")
                        End If

                        If UtilidadesVarias.SoloNumeros(txtEfectivoDolares.Text) > 0 Then
                            cmbMoneda.Items.Add("DOLAR")
                        End If

                        Notificaciones.cerrarFormProceso()

                        If UtilidadesVarias.SoloNumeros(txtEfectivoPesos.Text) <= 0 And UtilidadesVarias.SoloNumeros(txtEfectivoDolares.Text) <= 0 Then
                            UtilidadesTXT.ResetVariables()
                            Notificaciones.MsgBox("No queda saldo en efectivo disponible en Caja.", Botones.OK, Iconos.ERR)

                            Me.DialogResult = DialogResult.Cancel
                            Me.Close()
                        Else
                            cmbMoneda.SelectionLength = cmbMoneda.Text.Length
                            cmbMoneda.Select()
                        End If
                    Else
                        UtilidadesTXT.ResetVariables()
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(_TareasValoresEnCartera.Err.Descripcion, Botones.OK, Iconos.ERR)

                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    End If
                Else
                    UtilidadesTXT.ResetVariables()
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(_TareasValoresEnCartera.Err.Descripcion, Botones.OK, Iconos.ERR)

                    Me.DialogResult = DialogResult.Cancel
                    Me.Close()
                End If
            Else
                UtilidadesTXT.ResetVariables()
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(_TareasCaja.Err.Descripcion, Botones.OK, Iconos.ERR)

                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            End If
        Else
            UtilidadesTXT.ResetVariables()
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasCaja.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
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

            If txtImporte.Text <> "" Then
                txtImporte.Text = UtilidadesVarias.SoloNumeros(txtImporte.Text)
            End If
        End If
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnAgregar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        UtilidadesTXT.ResetVariables()

        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cmbMoneda.Text = "" Then
            Notificaciones.MsgBox("No especificaste una Moneda.", Botones.OK, Iconos.ERR)
            cmbMoneda.Select()
        Else
            If txtImporte.Text = "" Then
                Notificaciones.MsgBox("No estableciste un Importe.", Botones.OK, Iconos.ERR)
                txtImporte.Select()
            Else
                If UtilidadesVarias.SoloNumeros(txtImporte.Text) <= 0 Then
                    Notificaciones.MsgBox("El Importe debe ser mayor a 0.", Botones.OK, Iconos.ERR)
                    txtImporte.Select()
                Else
                    If UtilidadesVarias.SoloNumeros(txtImporte.Text) > UtilidadesVarias.SoloNumeros(txtEfectivoPesos.Text) And cmbMoneda.Text = "PESO" Then
                        Notificaciones.MsgBox("El Importe no puede ser mayor al saldo de Caja.", Botones.OK, Iconos.ERR)
                        txtImporte.Select()
                    Else
                        If UtilidadesVarias.SoloNumeros(txtImporte.Text) > UtilidadesVarias.SoloNumeros(txtEfectivoDolares.Text) And cmbMoneda.Text = "DOLAR" Then
                            Notificaciones.MsgBox("El Importe no puede ser mayor al saldo de Caja.", Botones.OK, Iconos.ERR)
                            txtImporte.Select()
                        Else
                            If frmOrdenPago.dgvDetalleOrden.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                                frmOrdenPago.dgvDetalleOrden.Rows.Remove(frmOrdenPago.dgvDetalleOrden.CurrentRow)
                            End If

                            Dim aggNuevo As Boolean = True

                            For Each item As DataGridViewRow In frmOrdenPago.dgvDetalleOrden.Rows
                                If cmbMoneda.Text = item.Cells("Moneda").Value And item.Cells("Tipo").Value = "EFECTIVO" Then
                                    Dim importe As String = ""

                                    If cmbMoneda.Text = "PESO" Then
                                        importe = Format(UtilidadesVarias.SoloNumeros(txtImporte.Text) + UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value), "$ #,##0.00")
                                    ElseIf cmbMoneda.Text = "DOLAR" Then
                                        importe = Format(UtilidadesVarias.SoloNumeros(txtImporte.Text) + UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value), "U$S #,##0.00")
                                    End If

                                    item.SetValues(0, 0, 0, "EFECTIVO", "-", "-", "-", "-", "-", "-", cmbMoneda.Text, importe, "-")

                                    aggNuevo = False
                                    Exit For
                                End If
                            Next

                            If aggNuevo Then
                                frmOrdenPago.dgvDetalleOrden.Rows.Add(0, 0, 0, "EFECTIVO", "-", "-", "-", "-", "-", "-", cmbMoneda.Text, txtImporte.Text, "-")
                            End If

                            UtilidadesTXT.ResetVariables()

                            Me.DialogResult = DialogResult.OK

                            Me.Close()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
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

    Private Sub cmbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoneda.SelectedIndexChanged
        If txtImporte.Text <> "" Then
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
#End Region

End Class