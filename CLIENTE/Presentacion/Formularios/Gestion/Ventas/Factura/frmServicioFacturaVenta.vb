Imports Procesos

Public Class frmServicioFacturaVenta
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
    Private Sub frmFacturaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        lblSimImpPPal.Text = "IMPORTE " & DatosSesion._MonedaPPal.Simbolo
        lblSimPrecioPPal.Text = "PRECIO " & DatosSesion._MonedaPPal.Simbolo
        lblSimImpContable.Text = "IMPORTE " & DatosSesion._MonedaContable.Simbolo
        lblSimPrecioContable.Text = "PRECIO " & DatosSesion._MonedaContable.Simbolo
        lblImpPPal.Text = Format(0, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        lblImpContable.Text = Format(0, DatosSesion._MonedaContable.Simbolo & " #,##0.00")

        txtAlicIva.Text = "0.0%"

        If txtOrigen.Text = "Editar" Then
            txtDetalleServicio.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("Descripcion").Value
            txtPrecioPPal.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("Precio").Value
            txtAlicIva.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("AlicuotaIVA").Value
            txtUnidad.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("Unidad").Value
            txtCantidad.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("Cantidad").Value

            Importe()
        End If

        txtDetalleServicio.SelectionLength = txtDetalleServicio.Text.Length
        txtDetalleServicio.Select()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub Importe()
        If txtCantidad.Text <> "" And txtPrecioContable.Text <> "" And txtPrecioPPal.Text <> "" Then
            lblImpPPal.Text = Format(txtCantidad.Text * UtilidadesVarias.SoloNumeros(txtPrecioPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            lblImpContable.Text = Format(txtCantidad.Text * UtilidadesVarias.SoloNumeros(txtPrecioContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        Else
            lblImpPPal.Text = Format(0, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            lblImpContable.Text = Format(0, DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtDetalleServicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetalleServicio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtUnidad.SelectionLength = txtUnidad.TextLength
            txtUnidad.Select()
        End If
    End Sub

    Private Sub txtUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtAlicIva.SelectionLength = txtAlicIva.TextLength
            txtAlicIva.Select()
        End If
    End Sub

    Private Sub txtAlicIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlicIva.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtCantidad.SelectionLength = txtCantidad.TextLength
            txtCantidad.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtAlicIva.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtPrecioPPal.SelectionLength = txtPrecioPPal.TextLength
            txtPrecioPPal.Select()
        End If
    End Sub

    Private Sub txtPrecioPPal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioPPal.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtPrecioContable.SelectionLength = txtPrecioContable.TextLength
            txtPrecioContable.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtPrecioPPal.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioContable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioContable.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnAgregar.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtPrecioContable.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtPrecioPPal_Validated(sender As Object, e As EventArgs) Handles txtPrecioPPal.Validated
        If txtPrecioPPal.Text <> "" Then
            txtPrecioPPal.Text = Format(UtilidadesVarias.SoloNumeros(txtPrecioPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            txtPrecioContable.Text = Format(UtilidadesVarias.SoloNumeros(txtPrecioContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If

        AddHandler txtPrecioContable.TextChanged, AddressOf txtPrecioContable_TextChanged
    End Sub

    Private Sub txtPrecioContable_Validated(sender As Object, e As EventArgs) Handles txtPrecioContable.Validated
        If txtPrecioContable.Text <> "" Then
            txtPrecioPPal.Text = Format(UtilidadesVarias.SoloNumeros(txtPrecioPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            txtPrecioContable.Text = Format(UtilidadesVarias.SoloNumeros(txtPrecioContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If

        AddHandler txtPrecioPPal.TextChanged, AddressOf txtPrecioPPal_TextChanged
    End Sub

    Private Sub txtAlicIva_Validated(sender As Object, e As EventArgs) Handles txtAlicIva.Validated
        If txtAlicIva.Text <> "" Then
            txtAlicIva.Text = FormatPercent(UtilidadesVarias.SoloNumeros(txtAlicIva.Text) / 100, 1)
        Else
            txtAlicIva.Text = "0.0%"
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub txtAlicIva_TextChanged(sender As Object, e As EventArgs) Handles txtAlicIva.TextChanged
        If txtAlicIva.Text = "" Then
            txtAlicIva.Text = "0.0%"

            txtAlicIva.SelectionLength = Len(txtAlicIva.Text)
            txtAlicIva.Select()
        End If

        Importe()
    End Sub

    Private Sub txtPrecioPPal_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioPPal.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtPrecioPPal, txtPrecioContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(frmFacturaVenta.txtTipCambio.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

        Importe()
    End Sub

    Private Sub txtPrecioContable_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioContable.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtPrecioContable, txtPrecioPPal, AddressOf txtPrecioContable_TextChanged, AddressOf txtPrecioPPal_TextChanged, UtilidadesVarias.SoloNumeros(frmFacturaVenta.txtTipCambio.Text), UtilidadesTXT.txtTipos.MONEDA_CONTABLE, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)

        Importe()
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Importe()
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        UtilidadesTXT.ResetVariables()

        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtDetalleServicio.Text = "" Then
            Notificaciones.MsgBox("""DETALLE SERVICIO"" es un campo obligatorio", Botones.OK, Iconos.ERR)
            txtDetalleServicio.Select()
        Else
            If txtCantidad.Text = "" Or txtCantidad.Text = "0" Then
                Notificaciones.MsgBox("No estableciste una Cantidad", Botones.OK, Iconos.ERR)
                txtCantidad.Select()
            Else
                If txtPrecioPPal.Text = "" Or txtPrecioPPal.Text = "0" Then
                    Notificaciones.MsgBox("No estableciste un Precio", Botones.OK, Iconos.ERR)
                    txtPrecioPPal.Select()
                Else
                    If txtAlicIva.Text = "" Then
                        txtAlicIva.Text = 0
                    End If

                    If txtUnidad.Text = "" Then
                        txtUnidad.Text = "-"
                    End If

                    Dim impNeto As String = Format(UtilidadesVarias.SoloNumeros(lblImpPPal.Text) + (UtilidadesVarias.SoloNumeros(lblImpPPal.Text) * UtilidadesVarias.SoloNumeros(txtAlicIva.Text)) / 100, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")

                    If frmFacturaVenta.dgvDetalleFactura.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                        frmFacturaVenta.dgvDetalleFactura.Rows.Remove(frmFacturaVenta.dgvDetalleFactura.CurrentRow)
                    End If

                    Dim aggNuevo As Boolean = True

                    For Each item As DataGridViewRow In frmFacturaVenta.dgvDetalleFactura.Rows
                        If txtPrecioPPal.Text = item.Cells("Precio").Value And item.Cells("Descripcion").Value = txtDetalleServicio.Text And item.Cells("Unidad").Value = txtUnidad.Text And item.Cells("AlicuotaIVA").Value = txtAlicIva.Text And item.Cells("Origen").Value = "SERVICIO" Then
                            item.SetValues(2, 0, 0, 0, 0, "-", txtDetalleServicio.Text, txtUnidad.Text, txtPrecioPPal.Text, CDbl(item.Cells("Cantidad").Value) + CDbl(txtCantidad.Text),
                                           lblImpPPal.Text, txtAlicIva.Text, impNeto, "SERVICIO")

                            aggNuevo = False

                            Exit For
                        End If
                    Next

                    If aggNuevo Then
                        frmFacturaVenta.dgvDetalleFactura.Rows.Add(2, 0, 0, 0, 0, "-", txtDetalleServicio.Text, txtUnidad.Text, txtPrecioPPal.Text,
                                                                  txtCantidad.Text, lblImpPPal.Text, txtAlicIva.Text, impNeto, "SERVICIO")
                    End If

                    UtilidadesTXT.ResetVariables()

                    Me.DialogResult = DialogResult.OK

                    Me.Close()
                End If
            End If
        End If
    End Sub
#End Region
End Class