Imports Procesos

Public Class frmArticuloDevoluciones
    Private listaArt As List(Of Articulos)
    Private listaDep As List(Of Depositos)
    Private tareaArt As TareasArticulos
    Private tareaStk As TareasStock
    Private tareaDep As TareasDepositos
    Private tareaDetRem As TareasDetalleRemitoVenta
    Private tareaDetFac As TareasFacturaVentaDetalle

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
        If txtCantDevolver.Text <> "" And txtPrecioContable.Text <> "" And txtPrecioPPal.Text <> "" Then
            lblImpPPal.Text = Format(txtCantDevolver.Text * UtilidadesVarias.SoloNumeros(txtPrecioPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            lblImpContable.Text = Format(txtCantDevolver.Text * UtilidadesVarias.SoloNumeros(txtPrecioContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        Else
            lblImpPPal.Text = Format(0, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            lblImpContable.Text = Format(0, DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
    End Sub

    Private Function CountCant(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmDevoluciones.dgvDetalle.Rows
            If txtComprobante.Text = "REMITO" Then
                If id = item.Cells("idRemitoDetalle").Value Then
                    Count += UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
                End If
            ElseIf txtComprobante.Text = "FACTURA" Then
                If id = item.Cells("idFacturaDetalle").Value Then
                    Count += UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
                End If
            End If
        Next

        Return Count
    End Function
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantDevolver.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnAgregar.Select()
        End If
    End Sub

    Private Sub txtCodDeposito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodDeposito.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtCodDeposito.Text <> "" Then
                txtCantDevolver.SelectionLength = Len(txtCantDevolver.Text)
                txtCantDevolver.Select()
            Else
                UtilidadesTXT.ResetVariables()
                frmListaDepositos.Dispose()
                UtilidadesVarias.Escalar(frmListaDepositos)
                Dim Result As DialogResult = frmListaDepositos.ShowDialog()

                If Result = DialogResult.OK Then
                    txtCodDeposito.Text = frmListaDepositos.infoDeposito.IdDeposito
                End If
            End If
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

    Private Sub txtCodDeposito_Validated(sender As Object, e As EventArgs) Handles txtCodDeposito.Validated
        If txtCodDeposito.Text <> "" And txtDeposito.Text = "" Then
            Notificaciones.MsgBox("No existe un Deposito con ese codigo.", Botones.OK, Iconos.ALERTA)

            txtCodDeposito.SelectionLength = Len(txtCodDeposito.Text)
            txtCodDeposito.Select()
        End If
    End Sub
#End Region

#Region "LOAD"
    Private Sub FrmRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tareaArt = New TareasArticulos()
        tareaDep = New TareasDepositos()
        tareaStk = New TareasStock()
        tareaDetRem = New TareasDetalleRemitoVenta()
        tareaDetFac = New TareasFacturaVentaDetalle()

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

        listaDep = Await tareaDep.ListadoCompleto()

        If IsNothing(listaDep) Then
            UtilidadesTXT.ResetVariables()
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaDep.Err.Descripcion, Botones.OK, Iconos.ERR)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If

        txtCodArt.ReadOnly = True

        If txtOrigen.Text = "Editar" Then
            If txtComprobante.Text = "REMITO" Then
                Dim detalleRemito As List(Of DetalleRemitoVenta) = Await tareaDetRem.verDetalleRemitosVentaIdCliente(frmDevoluciones.txtCtaCli.Text)

                If Not IsNothing(detalleRemito) Then
                    Dim cantidad As Double = 0
                    For Each item In detalleRemito
                        If item.IdDetalleRemitosVenta = frmDevoluciones.dgvDetalle.CurrentRow.Cells("idRemitoDetalle").Value Then
                            cantidad = item.Cantidad
                            Exit For
                        End If
                    Next

                    txtCodArt.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("CodArt").Value
                    txtPrecioPPal.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("Precio").Value
                    txtCantDevolver.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("Cantidad").Value
                    lblCantRetirada.Text = cantidad - CountCant(frmDevoluciones.dgvDetalle.CurrentRow.Cells("idRemitoDetalle").Value) + frmDevoluciones.dgvDetalle.CurrentRow.Cells("Cantidad").Value
                    txtIdRemito.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("idRemito").Value
                    txtIdDetalleRemito.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("idRemitoDetalle").Value
                    txtCodDeposito.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("idDeposito").Value
                Else
                    UtilidadesTXT.ResetVariables()
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaDetRem.Err.Descripcion, Botones.OK, Iconos.ERR)
                    Me.DialogResult = DialogResult.Cancel
                    Me.Close()
                End If
            ElseIf txtComprobante.Text = "FACTURA" Then
                Dim detalleFactura As List(Of FacturaVentaDetalle) = Await tareaDetFac.verFacturasVentaDetalleVentaIdCliente(frmDevoluciones.txtCtaCli.Text)

                If Not IsNothing(detalleFactura) Then
                    Dim cantidad As Double = 0
                    For Each item In detalleFactura
                        If item.IdFacturaVentaDetalle = frmDevoluciones.dgvDetalle.CurrentRow.Cells("idFacturaDetalle").Value Then
                            cantidad = item.Cantidad
                            Exit For
                        End If
                    Next

                    txtCodArt.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("CodArt").Value
                    txtPrecioPPal.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("Precio").Value
                    txtCantDevolver.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("Cantidad").Value
                    lblCantRetirada.Text = cantidad - CountCant(frmDevoluciones.dgvDetalle.CurrentRow.Cells("idFacturaDetalle").Value) + frmDevoluciones.dgvDetalle.CurrentRow.Cells("Cantidad").Value
                    txtIdRemito.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("idFactura").Value
                    txtIdDetalleRemito.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("idFacturaDetalle").Value
                    txtCodDeposito.Text = frmDevoluciones.dgvDetalle.CurrentRow.Cells("idDeposito").Value
                Else
                    UtilidadesTXT.ResetVariables()
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaDetFac.Err.Descripcion, Botones.OK, Iconos.ERR)
                    Me.DialogResult = DialogResult.Cancel
                    Me.Close()
                End If
            End If
        ElseIf txtOrigen.Text = "Agregar" Then
            If txtComprobante.Text = "REMITO" Then
                txtCodArt.Text = frmDevolucionesrRetiradoCliente.infoDetalleRemito.AscArticulos.CodArticulo
                lblCantRetirada.Text = frmDevolucionesrRetiradoCliente.infoDetalleRemito.Cantidad
                txtIdRemito.Text = frmDevolucionesrRetiradoCliente.infoDetalleRemito.AscRemitosVenta.IdRemitosVenta
                txtIdDetalleRemito.Text = frmDevolucionesrRetiradoCliente.infoDetalleRemito.IdDetalleRemitosVenta
                txtPrecioPPal.Text = Format(frmDevolucionesrRetiradoCliente.infoDetalleRemito.Precio, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
                txtIdFactura.Text = "0"
                txtIdFacturaDetalle.Text = "0"
            ElseIf txtComprobante.Text = "FACTURA" Then
                txtCodArt.Text = frmDevolucionesrRetiradoCliente.infoDetalleFactura.AscArticulos.CodArticulo
                lblCantRetirada.Text = frmDevolucionesrRetiradoCliente.infoDetalleFactura.Cantidad
                txtIdFactura.Text = frmDevolucionesrRetiradoCliente.infoDetalleFactura.AscFacturaVenta.IdFacturaVenta
                txtIdFacturaDetalle.Text = frmDevolucionesrRetiradoCliente.infoDetalleFactura.IdFacturaVentaDetalle
                txtPrecioPPal.Text = Format(frmDevolucionesrRetiradoCliente.infoDetalleFactura.Precio, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
                txtIdRemito.Text = "0"
                txtIdDetalleRemito.Text = "0"
            End If
        End If

        txtCodDeposito.SelectionLength = Len(txtCodDeposito.Text)
        txtCodDeposito.Select()
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub txtPrecioPPal_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioPPal.TextChanged
        If txtOrigen.Text = "Editar" Then
            UtilidadesTXT.FormatoMonedaTXT(txtPrecioPPal, txtPrecioContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(frmDevoluciones.dgvDetalle.CurrentRow.Cells("TipoCambio").Value), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)
        Else
            If txtComprobante.Text = "REMITO" Then
                UtilidadesTXT.FormatoMonedaTXT(txtPrecioPPal, txtPrecioContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(frmDevolucionesrRetiradoCliente.dgvRemitos.CurrentRow.Cells("TipoCambio").Value), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)
            ElseIf txtComprobante.Text = "FACTURA" Then
                UtilidadesTXT.FormatoMonedaTXT(txtPrecioPPal, txtPrecioContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(frmDevolucionesrRetiradoCliente.dgvFacturas.CurrentRow.Cells("TipoCambio").Value), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)
            End If
        End If

        Importe()
    End Sub

    Private Sub txtPrecioContable_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioContable.TextChanged
        If txtOrigen.Text = "Editar" Then
            UtilidadesTXT.FormatoMonedaTXT(txtPrecioContable, txtPrecioPPal, AddressOf txtPrecioContable_TextChanged, AddressOf txtPrecioPPal_TextChanged, UtilidadesVarias.SoloNumeros(frmDevoluciones.dgvDetalle.CurrentRow.Cells("TipoCambio").Value), UtilidadesTXT.txtTipos.MONEDA_CONTABLE, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)
        Else
            If txtComprobante.Text = "REMITO" Then
                UtilidadesTXT.FormatoMonedaTXT(txtPrecioContable, txtPrecioPPal, AddressOf txtPrecioContable_TextChanged, AddressOf txtPrecioPPal_TextChanged, UtilidadesVarias.SoloNumeros(frmDevolucionesrRetiradoCliente.dgvRemitos.CurrentRow.Cells("TipoCambio").Value), UtilidadesTXT.txtTipos.MONEDA_CONTABLE, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)
            ElseIf txtComprobante.Text = "FACTURA" Then
                UtilidadesTXT.FormatoMonedaTXT(txtPrecioContable, txtPrecioPPal, AddressOf txtPrecioContable_TextChanged, AddressOf txtPrecioPPal_TextChanged, UtilidadesVarias.SoloNumeros(frmDevolucionesrRetiradoCliente.dgvFacturas.CurrentRow.Cells("TipoCambio").Value), UtilidadesTXT.txtTipos.MONEDA_CONTABLE, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)
            End If
        End If

        Importe()
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantDevolver.TextChanged
        Importe()
    End Sub

    Private Sub txtCodDeposito_TextChanged(sender As Object, e As EventArgs) Handles txtCodDeposito.TextChanged
        txtDeposito.Text = ""

        If txtCodDeposito.Text <> "" Then
            For Each item In listaDep
                If item.IdDeposito = txtCodDeposito.Text Then
                    txtDeposito.Text = item.Nombre
                End If
            Next
        End If
    End Sub

    Private Async Sub txtCodArt_TextChanged(sender As Object, e As EventArgs) Handles txtCodArt.TextChanged
        RemoveHandler txtCodArt.Validated, AddressOf txtCodArt_Validated

        UtilidadesTXT.ResetVariables()

        txtDetalleArt.Text = ""
        lblUndSel.Text = ""
        pbxImagen.Image = My.Resources.IconoArticulo
        txtCantDevolver.Text = ""
        txtIdArticulo.Text = ""
        lblStkFisico.Text = ""
        lblStkReservado.Text = ""
        lblAlicIvaSel.Text = ""

        If txtCodArt.Text <> "" Then
            Notificaciones.arbirFormProceso()

            For Each item In listaArt
                If item.CodArticulo = txtCodArt.Text Then
                    Dim ImgArt As String = Await tareaArt.verImgArt(item.IdArticulo)

                    If IsNothing(ImgArt) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)

                        UtilidadesTXT.ResetVariables()
                        Me.Close()
                    Else
                        Dim StkFisicoArt As Integer = Await tareaStk.verStockFisico(item.IdArticulo)

                        If IsNothing(StkFisicoArt) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(tareaStk.Err.Descripcion, Botones.OK, Iconos.ERR)

                            UtilidadesTXT.ResetVariables()
                            Me.Close()
                        Else
                            Dim stkReservadoArt As Integer = Await tareaStk.verStockReservado(item.IdArticulo)

                            If IsNothing(stkReservadoArt) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(tareaStk.Err.Descripcion, Botones.OK, Iconos.ERR)

                                UtilidadesTXT.ResetVariables()
                                Me.Close()
                            Else
                                lblStkReservado.Text = stkReservadoArt
                                lblStkFisico.Text = StkFisicoArt
                                pbxImagen.Image = Image.FromStream(New IO.MemoryStream(Convert.FromBase64String(ImgArt)))
                                txtDetalleArt.Text = item.Detalle
                                lblUndSel.Text = item.Unidad
                                txtIdArticulo.Text = item.IdArticulo
                                lblAlicIvaSel.Text = item.AlicuotaIVA
                            End If
                        End If
                    End If
                End If
            Next

            Importe()

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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCodArt.Text = "" Then
            Notificaciones.MsgBox("No seleccionaste ningun Articulo", Botones.OK, Iconos.ERR)
            txtCodArt.Select()
        Else
            If txtCantDevolver.Text = "" Or txtCantDevolver.Text = "0" Then
                Notificaciones.MsgBox("No estableciste una Cantidad", Botones.OK, Iconos.ERR)
                txtCantDevolver.Select()
            Else
                If txtDeposito.Text = "" Then
                    Notificaciones.MsgBox("No seleccionaste un Deposito de ingreso", Botones.OK, Iconos.ERR)
                    txtCodDeposito.Select()
                Else
                    If CInt(txtCantDevolver.Text) > CInt(lblCantRetirada.Text) Then
                        Notificaciones.MsgBox("La cantidad ingresada es mayor a la cantidad Retirada.", Botones.OK, Iconos.ERR)

                        txtCantDevolver.SelectionLength = Len(txtCantDevolver.Text)
                        txtCantDevolver.Select()
                    Else
                        Dim impNeto As String = Format(UtilidadesVarias.SoloNumeros(lblImpPPal.Text) + (UtilidadesVarias.SoloNumeros(lblImpPPal.Text) * UtilidadesVarias.SoloNumeros(lblAlicIvaSel.Text)) / 100, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
                        Dim tc As String = ""

                        If txtOrigen.Text = "Editar" Then
                            tc = frmDevoluciones.dgvDetalle.CurrentRow.Cells("TipoCambio").Value
                        Else
                            If txtComprobante.Text = "REMITO" Then
                                tc = frmDevolucionesrRetiradoCliente.dgvRemitos.CurrentRow.Cells("TipoCambio").Value
                            ElseIf txtComprobante.Text = "FACTURA" Then
                                tc = frmDevolucionesrRetiradoCliente.dgvFacturas.CurrentRow.Cells("TipoCambio").Value
                            End If
                        End If

                        If frmDevoluciones.dgvDetalle.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                            frmDevoluciones.dgvDetalle.Rows.Remove(frmDevoluciones.dgvDetalle.CurrentRow)
                        End If

                        Dim aggNuevo As Boolean = True

                        For Each item As DataGridViewRow In frmDevoluciones.dgvDetalle.Rows
                            Dim modificar As Boolean = False

                            If txtComprobante.Text = "REMITO" Then
                                If txtIdArticulo.Text = item.Cells("idArticulo").Value And txtPrecioPPal.Text = item.Cells("Precio").Value And txtCodDeposito.Text = item.Cells("idDeposito").Value And txtIdDetalleRemito.Text = item.Cells("idRemitoDetalle").Value Then
                                    modificar = True
                                End If
                            ElseIf txtComprobante.Text = "FACTURA" Then
                                If txtIdArticulo.Text = item.Cells("idArticulo").Value And txtPrecioPPal.Text = item.Cells("Precio").Value And txtCodDeposito.Text = item.Cells("idDeposito").Value And txtIdDetalleRemito.Text = item.Cells("idFacturaDetalle").Value Then
                                    modificar = True
                                End If
                            End If

                            If modificar Then
                                item.SetValues(txtIdArticulo.Text, txtCodDeposito.Text, txtIdRemito.Text, txtIdDetalleRemito.Text, txtIdFactura.Text, txtIdFacturaDetalle.Text,
                                               txtCodArt.Text, txtDetalleArt.Text, lblUndSel.Text, txtPrecioPPal.Text, CDbl(item.Cells("Cantidad").Value) + CDbl(txtCantDevolver.Text),
                                               lblImpPPal.Text, lblAlicIvaSel.Text, impNeto, tc, txtDeposito.Text, txtComprobante.Text)

                                aggNuevo = False
                                Exit For
                            End If
                        Next

                        If aggNuevo Then
                            frmDevoluciones.dgvDetalle.Rows.Add(txtIdArticulo.Text, txtCodDeposito.Text, txtIdRemito.Text, txtIdDetalleRemito.Text, txtIdFactura.Text, txtIdFacturaDetalle.Text,
                                                                txtCodArt.Text, txtDetalleArt.Text, lblUndSel.Text, txtPrecioPPal.Text, txtCantDevolver.Text, lblImpPPal.Text,
                                                                lblAlicIvaSel.Text, impNeto, tc, txtDeposito.Text, txtComprobante.Text)
                        End If

                        UtilidadesTXT.ResetVariables()

                        Me.DialogResult = DialogResult.OK

                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub
#End Region

End Class