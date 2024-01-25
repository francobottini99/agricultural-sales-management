Imports System.IO
Imports Procesos

Public Class frmArticuloFacturaVentaRemito
    Private listaArt As List(Of Articulos)
    Private tareaArt As TareasArticulos
    Private tareaStk As TareasStock
    Private tareaDetRem As TareasDetalleRemitoVenta

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
    Private Sub FrmRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tareaArt = New TareasArticulos()
        tareaStk = New TareasStock()
        tareaDetRem = New TareasDetalleRemitoVenta()

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

        txtCodArt.ReadOnly = True

        If txtOrigen.Text = "Editar" Then
            Dim detalleRemito As List(Of DetalleRemitoVenta) = Await tareaDetRem.verDetalleRemitosVentaSinFacturarIdCliente(frmFacturaVenta.txtCtaCli.Text)

            If Not IsNothing(detalleRemito) Then
                Dim cantidad As Double = 0
                For Each item In detalleRemito
                    If item.IdDetalleRemitosVenta = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("idRemitoDetalle").Value Then
                        cantidad = item.Cantidad
                        Exit For
                    End If
                Next

                txtCodArt.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("CodArt").Value
                txtPrecioPPal.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("Precio").Value
                txtCantidad.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("Cantidad").Value
                lblCantPendiente.Text = cantidad - CountCantFacturada(frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("idRemitoDetalle").Value) + frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("Cantidad").Value
                txtIdRemito.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("idRemito").Value
                txtIdDetalleRemito.Text = frmFacturaVenta.dgvDetalleFactura.CurrentRow.Cells("idRemitoDetalle").Value
            Else
                UtilidadesTXT.ResetVariables()
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(tareaDetRem.Err.Descripcion, Botones.OK, Iconos.ERR)
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            End If
        ElseIf txtOrigen.Text = "Agregar" Then
            txtCodArt.Text = frmReservaRemitoNuevoCliente.infoDetalleRemito.AscArticulos.CodArticulo
            lblCantPendiente.Text = frmReservaRemitoNuevoCliente.infoDetalleRemito.Cantidad
            txtIdRemito.Text = frmReservaRemitoNuevoCliente.infoDetalleRemito.AscRemitosVenta.IdRemitosVenta
            txtIdDetalleRemito.Text = frmReservaRemitoNuevoCliente.infoDetalleRemito.IdDetalleRemitosVenta
        End If
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

    Private Function CountCantFacturada(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmFacturaVenta.dgvDetalleFactura.Rows
            If id = item.Cells("idRemitoDetalle").Value Then
                Count += UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
            End If
        Next

        Return Count
    End Function
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtCodArt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodArt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtCodArt.Text <> "" Then
                txtPrecioPPal.SelectionLength = Len(txtPrecioPPal.Text)
                txtPrecioPPal.Select()
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

            txtCantidad.SelectionLength = txtCantidad.TextLength
            txtCantidad.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtPrecioContable.Text.IndexOf(".") Then
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

    Private Sub txtCodArt_Validated(sender As Object, e As EventArgs) Handles txtCodArt.Validated
        If txtCodArt.Text <> "" And txtDetalleArt.Text = "" Then
            Notificaciones.MsgBox("No existe un Articulo con ese codigo.", Botones.OK, Iconos.ERR)

            txtCodArt.SelectionLength = Len(txtCodArt.Text)
            txtCodArt.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
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

    Private Async Sub txtCodArt_TextChanged(sender As Object, e As EventArgs) Handles txtCodArt.TextChanged
        RemoveHandler txtCodArt.Validated, AddressOf txtCodArt_Validated

        UtilidadesTXT.ResetVariables()

        txtDetalleArt.Text = ""
        lblUndSel.Text = ""
        lblAlicIvaSel.Text = ""
        lblFecAct.Text = ""
        pbxImagen.Image = My.Resources.IconoArticulo
        txtPrecioPPal.Text = ""
        lblImpPPal.Text = ""
        lblImpContable.Text = ""
        txtCantidad.Text = ""
        txtIdArticulo.Text = ""
        txtPrecioAnt.Text = ""
        lblStkReservado.Text = ""
        lblStkFisico.Text = ""
        lblImpContable.Text = ""
        lblImpPPal.Text = ""
        ' lblCantRes.Text = ""

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
                        Dim StkFisicoArt As Integer = Await tareaStk.verStockFisico(item.IdArticulo)

                        If IsNothing(StkFisicoArt) Then
                            UtilidadesTXT.ResetVariables()
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(tareaStk.Err.Descripcion, Botones.OK, Iconos.ERR)
                            Me.DialogResult = DialogResult.Cancel
                            Me.Close()
                        Else
                            Dim stkReservadoArt As Integer = Await tareaStk.verStockReservado(item.IdArticulo)

                            If IsNothing(stkReservadoArt) Then
                                UtilidadesTXT.ResetVariables()
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(tareaStk.Err.Descripcion, Botones.OK, Iconos.ERR)
                                Me.DialogResult = DialogResult.Cancel
                                Me.Close()
                            Else
                                Importe()

                                pbxImagen.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(Art)))

                                txtDetalleArt.Text = item.Detalle
                                lblUndSel.Text = item.Unidad
                                lblAlicIvaSel.Text = item.AlicuotaIVA
                                lblFecAct.Text = item.FechaActPrec
                                txtPrecioAnt.Text = item.Precio
                                txtIdArticulo.Text = item.IdArticulo
                                lblStkFisico.Text = StkFisicoArt
                                lblStkReservado.Text = stkReservadoArt
                                'lblCantRes.Text -= CountStkArt(item.idArticulo)

                                RemoveHandler txtPrecioPPal.TextChanged, AddressOf txtPrecioPPal_TextChanged

                                txtPrecioPPal.Text = Format(item.Precio, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")

                                AddHandler txtPrecioPPal.TextChanged, AddressOf txtPrecioPPal_TextChanged

                                UtilidadesTXT.FormatoMonedaTXT(txtPrecioPPal, txtPrecioContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(frmFacturaVenta.txtTipCambio.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

                                txtPrecioPPal.SelectionLength = txtPrecioPPal.Text.Length
                                txtPrecioPPal.Select()
                            End If
                        End If
                    End If

                    Exit For
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

    Private Async Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCodArt.Text = "" Then
            Notificaciones.MsgBox("No seleccionaste ningun Articulo", Botones.OK, Iconos.ERR)
            txtCodArt.Select()
        Else
            If txtCantidad.Text = "" Or txtCantidad.Text = "0" Then
                Notificaciones.MsgBox("No estableciste una Cantidad", Botones.OK, Iconos.ERR)
                txtCantidad.Select()
            Else
                If CInt(txtCantidad.Text) > CInt(lblCantPendiente.Text) Then
                    Notificaciones.MsgBox("La cantidad ingresada es mayor a la cantidad que figura en el Remito", Botones.OK, Iconos.ERR)

                    txtCantidad.SelectionLength = Len(txtCantidad.Text)
                    txtCantidad.Select()
                Else
                    If txtPrecioAnt.Text <> UtilidadesVarias.SoloNumeros(txtPrecioPPal.Text) Then
                        Dim resp As DialogResult = Notificaciones.MsgBox("Deseas actualizar el precio del Articulo en la base de datos ?", Botones.SI_NO, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("ACTUALIZANDO PRECIO")

                            If Await tareaArt.ActualizarPrecio(txtIdArticulo.Text, UtilidadesVarias.SoloNumeros(txtPrecioPPal.Text)) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("El Precio del Articulo se actualizo correctamente!", Botones.OK, Iconos.OK)
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)
                            End If
                        End If
                    End If

                    Dim impNeto As String = Format(UtilidadesVarias.SoloNumeros(lblImpPPal.Text) + (UtilidadesVarias.SoloNumeros(lblImpPPal.Text) * UtilidadesVarias.SoloNumeros(lblAlicIvaSel.Text)) / 100, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")

                    If frmFacturaVenta.dgvDetalleFactura.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                        frmFacturaVenta.dgvDetalleFactura.Rows.Remove(frmFacturaVenta.dgvDetalleFactura.CurrentRow)
                    End If

                    Dim aggNuevo As Boolean = True

                    For Each item As DataGridViewRow In frmFacturaVenta.dgvDetalleFactura.Rows
                        If txtIdArticulo.Text = item.Cells("idArticulo").Value And txtPrecioPPal.Text = item.Cells("Precio").Value And txtIdDetalleRemito.Text = item.Cells("idRemitoDetalle").Value And item.Cells("Origen").Value = "REMITO" Then
                            item.SetValues(txtIdArticulo.Text, 0, 0, txtIdRemito.Text, txtIdDetalleRemito.Text, txtCodArt.Text, txtDetalleArt.Text, lblUndSel.Text,
                                           txtPrecioPPal.Text, CDbl(item.Cells("Cantidad").Value) + CDbl(txtCantidad.Text), lblImpPPal.Text, lblAlicIvaSel.Text, impNeto, "REMITO")

                            aggNuevo = False
                            Exit For
                        End If
                    Next

                    If aggNuevo Then
                        frmFacturaVenta.dgvDetalleFactura.Rows.Add(txtIdArticulo.Text, 0, 0, txtIdRemito.Text, txtIdDetalleRemito.Text, txtCodArt.Text, txtDetalleArt.Text, lblUndSel.Text,
                                                                   txtPrecioPPal.Text, txtCantidad.Text, lblImpPPal.Text, lblAlicIvaSel.Text, impNeto, "REMITO")
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