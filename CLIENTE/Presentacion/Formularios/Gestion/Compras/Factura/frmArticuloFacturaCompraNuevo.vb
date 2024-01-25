Imports System.IO
Imports Procesos

Public Class frmArticuloFacturaCompraNuevo
    Dim listaArt As List(Of Articulos)
    Dim tareaArt As TareasArticulos

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

#Region "METODOS PRIVADOS"
    Private Sub Importe()
        If txtCantidad.Text <> "" And txtCostoContable.Text <> "" And txtCostoPPal.Text <> "" Then
            lblImpPPal.Text = Format(txtCantidad.Text * UtilidadesVarias.SoloNumeros(txtCostoPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            lblImpContable.Text = Format(txtCantidad.Text * UtilidadesVarias.SoloNumeros(txtCostoContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        Else
            lblImpPPal.Text = Format(0, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            lblImpContable.Text = Format(0, DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtCodArt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodArt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtCodArt.Text <> "" Then
                txtCostoPPal.SelectionLength = Len(txtCostoPPal.Text)
                txtCostoPPal.Select()
            Else
                UtilidadesTXT.ResetVariables()

                frmListaArticulos.Dispose()
                UtilidadesVarias.Escalar(frmListaArticulos)
                Dim Result As DialogResult = frmListaArticulos.ShowDialog()

                If Result = DialogResult.OK Then
                    txtCodArt.Text = frmListaArticulos.infoArticulo.CodArticulo
                End If
            End If
        End If
    End Sub

    Private Sub txtPrecioPPal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoPPal.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtCostoContable.SelectionLength = txtCostoContable.TextLength
            txtCostoContable.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtCostoPPal.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioContable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoContable.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtCantidad.SelectionLength = txtCantidad.TextLength
            txtCantidad.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtCostoContable.Text.IndexOf(".") Then
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

            btnAgregar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtPrecioPPal_Validated(sender As Object, e As EventArgs) Handles txtCostoPPal.Validated
        If txtCostoPPal.Text <> "" Then
            txtCostoPPal.Text = Format(UtilidadesVarias.SoloNumeros(txtCostoPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            txtCostoContable.Text = Format(UtilidadesVarias.SoloNumeros(txtCostoContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If

        AddHandler txtCostoContable.TextChanged, AddressOf txtPrecioContable_TextChanged
    End Sub

    Private Sub txtPrecioContable_Validated(sender As Object, e As EventArgs) Handles txtCostoContable.Validated
        If txtCostoContable.Text <> "" Then
            txtCostoPPal.Text = Format(UtilidadesVarias.SoloNumeros(txtCostoPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            txtCostoContable.Text = Format(UtilidadesVarias.SoloNumeros(txtCostoContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If

        AddHandler txtCostoPPal.TextChanged, AddressOf txtPrecioPPal_TextChanged
    End Sub

    Private Sub txtCodArt_Validated(sender As Object, e As EventArgs) Handles txtCodArt.Validated
        If txtCodArt.Text <> "" And txtDetalleArt.Text = "" Then
            Notificaciones.MsgBox("No existe un Articulo con ese codigo.", Botones.OK, Iconos.ERR)

            txtCodArt.SelectionLength = Len(txtCodArt.Text)
            txtCodArt.Select()
        End If
    End Sub
#End Region

#Region "LOAD"
    Private Sub FrmRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tareaArt = New TareasArticulos()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        lblSimImpPPal.Text = "IMPORTE " & DatosSesion._MonedaPPal.Simbolo
        lblSimPrecioPPal.Text = "PRECIO " & DatosSesion._MonedaPPal.Simbolo
        lblSimImpContable.Text = "IMPORTE " & DatosSesion._MonedaContable.Simbolo
        lblSimPrecioContable.Text = "PRECIO " & DatosSesion._MonedaContable.Simbolo

        listaArt = Await tareaArt.ListadoCompleto()

        If IsNothing(listaArt) Then
            UtilidadesTXT.ResetVariables()
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If

        If txtOrigen.Text = "Editar" Then
            txtCodArt.Text = frmFacturaCompra.dgvDetalleFactura.CurrentRow.Cells("CodArt").Value
            txtCostoPPal.Text = frmFacturaCompra.dgvDetalleFactura.CurrentRow.Cells("Precio").Value
            txtCantidad.Text = frmFacturaCompra.dgvDetalleFactura.CurrentRow.Cells("Cantidad").Value

            txtCodArt.ReadOnly = True
            txtCodArt.ForeColor = Color.DimGray

            txtCostoPPal.SelectionLength = txtCostoPPal.Text.Length
            txtCostoPPal.Select()
        Else
            txtCodArt.ReadOnly = False
            txtCodArt.ForeColor = Color.FromArgb(95, 150, 15)

            txtCodArt.SelectionLength = txtCodArt.Text.Length
            txtCodArt.Select()

            Notificaciones.cerrarFormProceso()
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub txtPrecioPPal_TextChanged(sender As Object, e As EventArgs) Handles txtCostoPPal.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtCostoPPal, txtCostoContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(frmFacturaCompra.txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

        Importe()
    End Sub

    Private Sub txtPrecioContable_TextChanged(sender As Object, e As EventArgs) Handles txtCostoContable.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtCostoContable, txtCostoPPal, AddressOf txtPrecioContable_TextChanged, AddressOf txtPrecioPPal_TextChanged, UtilidadesVarias.SoloNumeros(frmFacturaCompra.txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_CONTABLE, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)

        Importe()
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Importe()
    End Sub

    Private Async Sub txtCodArt_TextChangedAsync(sender As Object, e As EventArgs) Handles txtCodArt.TextChanged
        RemoveHandler txtCodArt.Validated, AddressOf txtCodArt_Validated

        UtilidadesTXT.ResetVariables()

        txtDetalleArt.Text = ""
        lblUndSel.Text = ""
        lblAlicIvaSel.Text = ""
        lblFecAct.Text = ""
        pbxImagen.Image = My.Resources.IconoArticulo
        txtCostoPPal.Text = ""
        lblImpPPal.Text = ""
        lblImpContable.Text = ""
        txtCantidad.Text = ""
        txtIdArticulo.Text = ""
        txtCostoAnt.Text = ""
        lblImpContable.Text = ""
        lblImpPPal.Text = ""

        If txtCodArt.Text <> "" Then
            Notificaciones.arbirFormProceso()

            For Each item In listaArt
                If item.CodArticulo = txtCodArt.Text Then
                    Dim Art As String = Await tareaArt.verImgArt(item.IdArticulo)

                    If IsNothing(Art) Then
                        UtilidadesTXT.ResetVariables()
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    Else
                        Importe()

                        pbxImagen.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(Art)))

                        txtDetalleArt.Text = item.Detalle
                        lblUndSel.Text = item.Unidad
                        lblAlicIvaSel.Text = item.AlicuotaIVA
                        lblFecAct.Text = item.FechaActCosto
                        txtCostoAnt.Text = item.Costo
                        txtIdArticulo.Text = item.IdArticulo

                        RemoveHandler txtCostoPPal.TextChanged, AddressOf txtPrecioPPal_TextChanged

                        txtCostoPPal.Text = Format(item.Costo, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")

                        AddHandler txtCostoPPal.TextChanged, AddressOf txtPrecioPPal_TextChanged

                        UtilidadesTXT.FormatoMonedaTXT(txtCostoPPal, txtCostoContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(frmFacturaCompra.txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

                        txtCostoPPal.SelectionLength = txtCostoPPal.Text.Length
                        txtCostoPPal.Select()
                    End If
                End If
            Next

            Notificaciones.cerrarFormProceso()
        End If

        AddHandler txtCodArt.Validated, AddressOf txtCodArt_Validated
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        UtilidadesTXT.ResetVariables()

        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Async Sub BtnCargar_ClickAsync(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCodArt.Text = "" Then
            Notificaciones.MsgBox("No seleccionaste ningun Articulo", Botones.OK, Iconos.ERR)
            txtCodArt.Select()
        Else
            If txtCantidad.Text = "" Or txtCantidad.Text = "0" Then
                Notificaciones.MsgBox("No estableciste una Cantidad", Botones.OK, Iconos.ERR)
                txtCantidad.Select()
            Else
                If txtCostoAnt.Text <> UtilidadesVarias.SoloNumeros(txtCostoPPal.Text) Then
                    Dim resp As DialogResult = Notificaciones.MsgBox("Deseas actualizar el costo del Articulo en la base de datos ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("ACTUALIZANDO COSTO")

                        If Await tareaArt.ActualizarCosto(txtIdArticulo.Text, UtilidadesVarias.SoloNumeros(txtCostoPPal.Text)) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("El costo del Articulo se actualizo correctamente!", Botones.OK, Iconos.OK)
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)
                        End If
                    End If
                End If

                Dim impNeto As String = Format(UtilidadesVarias.SoloNumeros(lblImpPPal.Text) + (UtilidadesVarias.SoloNumeros(lblImpPPal.Text) * UtilidadesVarias.SoloNumeros(lblAlicIvaSel.Text)) / 100, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")

                If frmFacturaCompra.dgvDetalleFactura.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                    frmFacturaCompra.dgvDetalleFactura.Rows.Remove(frmFacturaCompra.dgvDetalleFactura.CurrentRow)
                End If

                Dim aggNuevo As Boolean = True

                For Each item As DataGridViewRow In frmFacturaCompra.dgvDetalleFactura.Rows
                    If txtIdArticulo.Text = item.Cells("idArticulo").Value And txtCostoPPal.Text = item.Cells("Precio").Value And item.Cells("Origen").Value = "NUEVO" Then
                        item.SetValues(txtIdArticulo.Text, 0, 0, txtCodArt.Text, txtDetalleArt.Text, lblUndSel.Text, txtCostoPPal.Text,
                                       CDbl(item.Cells("Cantidad").Value) + CDbl(txtCantidad.Text), 0, lblImpPPal.Text, lblAlicIvaSel.Text, impNeto, "NUEVO")

                        aggNuevo = False
                        Exit For
                    End If
                Next

                If aggNuevo Then
                    frmFacturaCompra.dgvDetalleFactura.Rows.Add(txtIdArticulo.Text, 0, 0, txtCodArt.Text, txtDetalleArt.Text, lblUndSel.Text, txtCostoPPal.Text,
                                                                    txtCantidad.Text, 0, lblImpPPal.Text, lblAlicIvaSel.Text, impNeto, "NUEVO")
                End If

                UtilidadesTXT.ResetVariables()

                Me.DialogResult = DialogResult.OK

                Me.Close()
            End If
        End If
    End Sub
#End Region
End Class