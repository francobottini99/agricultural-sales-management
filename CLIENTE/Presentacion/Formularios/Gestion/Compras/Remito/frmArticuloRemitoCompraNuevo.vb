Imports System.IO
Imports Procesos

Public Class frmArticuloRemitoCompraNuevo
    Dim listaArt As List(Of Articulos)
    Dim listaDep As List(Of Depositos)
    Dim tareaArt As TareasArticulos
    Dim tareaDep As TareasDepositos

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
                txtCodDeposito.SelectionLength = Len(txtCodDeposito.Text)
                txtCodDeposito.Select()
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

    Private Sub txtCodDeposito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodDeposito.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtCodDeposito.Text <> "" Then
                txtCostoPPal.SelectionLength = Len(txtCostoPPal.Text)
                txtCostoPPal.Select()
            Else
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

    Private Sub txtCodDeposito_Validated(sender As Object, e As EventArgs) Handles txtCodDeposito.Validated
        If txtCodDeposito.Text <> "" And txtDeposito.Text = "" Then
            Notificaciones.MsgBox("El Deposito ingresado no existe, o bien no hay stock disponible del articulo seleccionado dentro del mismo.", Botones.OK, Iconos.ERR)

            txtCodDeposito.SelectionLength = Len(txtCodDeposito.Text)
            txtCodDeposito.Select()
        End If
    End Sub
#End Region

#Region "LOAD"
    Private Sub FrmRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tareaArt = New TareasArticulos()
        tareaDep = New TareasDepositos()

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

        If txtOrigen.Text = "Editar" Then
            txtCodArt.Text = frmRemitoCompra.dgvDetalleRemito.CurrentRow.Cells("CodArt").Value
            txtCostoPPal.Text = frmRemitoCompra.dgvDetalleRemito.CurrentRow.Cells("Precio").Value
            txtCantidad.Text = frmRemitoCompra.dgvDetalleRemito.CurrentRow.Cells("Cantidad").Value

            txtCodArt.ReadOnly = True
            txtCodArt.ForeColor = Color.DimGray

            txtCodDeposito.SelectionLength = txtCodDeposito.Text.Length
            txtCodDeposito.Select()
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
        UtilidadesTXT.FormatoMonedaTXT(txtCostoPPal, txtCostoContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(frmRemitoCompra.txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

        Importe()
    End Sub

    Private Sub txtPrecioContable_TextChanged(sender As Object, e As EventArgs) Handles txtCostoContable.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtCostoContable, txtCostoPPal, AddressOf txtPrecioContable_TextChanged, AddressOf txtPrecioPPal_TextChanged, UtilidadesVarias.SoloNumeros(frmRemitoCompra.txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_CONTABLE, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)

        Importe()
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Importe()
    End Sub

    Private Sub txtCodDeposito_TextChanged(sender As Object, e As EventArgs) Handles txtCodDeposito.TextChanged
        txtDeposito.Text = ""

        If txtCodDeposito.Text <> "" Then
            Notificaciones.arbirFormProceso()

            For Each item In listaDep
                If item.IdDeposito = txtCodDeposito.Text Then
                    txtDeposito.Text = item.Nombre
                End If
            Next

            Notificaciones.cerrarFormProceso()
        End If
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
        txtCodDeposito.Text = ""
        txtDeposito.Text = ""
        lblImpContable.Text = ""
        lblImpPPal.Text = ""

        bnfDeposito.Enabled = False

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

                        bnfDeposito.Enabled = True

                        RemoveHandler txtCostoPPal.TextChanged, AddressOf txtPrecioPPal_TextChanged

                        txtCostoPPal.Text = Format(item.Costo, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")

                        AddHandler txtCostoPPal.TextChanged, AddressOf txtPrecioPPal_TextChanged

                        UtilidadesTXT.FormatoMonedaTXT(txtCostoPPal, txtCostoContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(frmRemitoCompra.txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

                        If txtOrigen.Text = "Editar" Then
                            txtCodDeposito.Text = frmRemitoCompra.dgvDetalleRemito.CurrentRow.Cells("idDeposito").Value

                            txtCodDeposito.SelectionLength = txtCodDeposito.Text.Length
                            txtCodDeposito.Select()
                        ElseIf txtOrigen.Text = "Agregar" Then
                            txtCodDeposito.SelectionLength = txtCodDeposito.Text.Length
                            txtCodDeposito.Select()
                        End If
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
                If txtDeposito.Text = "" Then
                    Notificaciones.MsgBox("No seleccionaste un deposito de salida", Botones.OK, Iconos.ERR)
                    txtCodDeposito.Select()
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

                    If frmRemitoCompra.dgvDetalleRemito.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                        frmRemitoCompra.dgvDetalleRemito.Rows.Remove(frmRemitoCompra.dgvDetalleRemito.CurrentRow)
                    End If

                    Dim aggNuevo As Boolean = True

                    For Each item As DataGridViewRow In frmRemitoCompra.dgvDetalleRemito.Rows
                        If txtIdArticulo.Text = item.Cells("idArticulo").Value And txtCostoPPal.Text = item.Cells("Precio").Value And txtCodDeposito.Text = item.Cells("idDeposito").Value And item.Cells("Origen").Value = "NUEVO" Then
                            item.SetValues(txtIdArticulo.Text, txtCodDeposito.Text, 0, 0, txtCodArt.Text, txtDetalleArt.Text, lblUndSel.Text, txtCostoPPal.Text,
                                           CDbl(item.Cells("Cantidad").Value) + CDbl(txtCantidad.Text), 0, lblImpPPal.Text, lblAlicIvaSel.Text, impNeto, txtDeposito.Text, "NUEVO")

                            aggNuevo = False
                            Exit For
                        End If
                    Next

                    If aggNuevo Then
                        frmRemitoCompra.dgvDetalleRemito.Rows.Add(txtIdArticulo.Text, txtCodDeposito.Text, 0, 0, txtCodArt.Text, txtDetalleArt.Text, lblUndSel.Text, txtCostoPPal.Text,
                                                                  txtCantidad.Text, 0, lblImpPPal.Text, lblAlicIvaSel.Text, impNeto, txtDeposito.Text, "NUEVO")
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