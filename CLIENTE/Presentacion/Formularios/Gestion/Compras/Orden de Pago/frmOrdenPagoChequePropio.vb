Imports Procesos

Public Class frmOrdenPagoChequePropio
    Private listCompletaChequeras As List(Of Chequeras)
    Private listCompletaDetalleCheques As List(Of DetalleCheque)
    Private _TareasChequera As TareasChequera
    Private _TareasDetalleCheque As TareasDetalleCheque

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
        _TareasChequera = New TareasChequera()
        _TareasDetalleCheque = New TareasDetalleCheque()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso("CARGANDO CHEQUERAS")

        listCompletaChequeras = Await _TareasChequera.ListadoSinCompletar()

        If txtOrigen.Text = "Editar" Then
            If Not IsNothing(listCompletaChequeras) Then
                bnfCardNroChq.Enabled = True
                bnfCardFec.Enabled = True
                bnfCardImp.Enabled = True
                bnfCardObs.Enabled = True

                cmbChequera.Enabled = False
                cmbNroChq.Enabled = False

                txtIdChequera.Text = frmOrdenPago.dgvDetalleOrden.CurrentRow.Cells("idChequera").Value
                txtIdDetalleCheque.Text = frmOrdenPago.dgvDetalleOrden.CurrentRow.Cells("idDetalleCheque").Value

                For Each item In listCompletaChequeras
                    If item.IdChequera = txtIdChequera.Text Then
                        lblBanco.Text = item.Banco
                        lblCantChq.Text = item.CantidadChq
                        lblChqDisp.Text = item.ChqDisponibles
                        lblFecAlta.Text = item.FechaAlta
                        lblObs.Text = item.Observaciones
                        cmbChequera.Text = item.Banco + " --> [ " + item.NroChqInicial.ToString + " - " + (item.NroChqInicial + item.CantidadChq - 1).ToString() + " ]"

                        Exit For
                    End If
                Next

                For Each item As DataGridViewRow In frmOrdenPago.dgvDetalleOrden.Rows
                    If txtIdChequera.Text = item.Cells("idChequera").Value Then
                        lblChqDisp.Text -= 1
                    End If
                Next

                cmbNroChq.Text = frmOrdenPago.dgvDetalleOrden.CurrentRow.Cells("Numero").Value
                txtFecEmsion.Text = frmOrdenPago.dgvDetalleOrden.CurrentRow.Cells("FechaEmision").Value
                txtFecCobro.Text = frmOrdenPago.dgvDetalleOrden.CurrentRow.Cells("FechaCobro").Value
                txtImporte.Text = frmOrdenPago.dgvDetalleOrden.CurrentRow.Cells("Importe").Value
                txtObservaciones.Text = frmOrdenPago.dgvDetalleOrden.CurrentRow.Cells("Observaciones").Value

                RemoveHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged

                txtPlazo.Text = DateDiff(DateInterval.Day, CDate(txtFecEmsion.Text), CDate(txtFecCobro.Text))

                AddHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged

                txtFecEmsion.SelectionLength = Len(txtFecEmsion.Text)
                txtFecEmsion.Select()

                Notificaciones.cerrarFormProceso()
            Else
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(_TareasChequera.Err.Descripcion, Botones.OK, Iconos.ERR)

                UtilidadesTXT.ResetVariables()
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            End If
        Else
            If Not IsNothing(listCompletaChequeras) Then
                Dim listIdChequeras As New List(Of Integer)

                For Each item As DataGridViewRow In frmOrdenPago.dgvDetalleOrden.Rows
                    Dim existe As Boolean = False

                    For Each item_2 In listIdChequeras
                        If item_2 = item.Cells("idChequera").Value Then
                            existe = True
                            Exit For
                        End If
                    Next

                    If Not existe Then
                        listIdChequeras.Add(item.Cells("idChequera").Value)

                        listCompletaDetalleCheques = Await _TareasDetalleCheque.ListadoIdChequeraEnDisponibilidad(item.Cells("idChequera").Value)

                        If Not IsNothing(listCompletaDetalleCheques) Then
                            For i As Integer = listCompletaDetalleCheques.Count - 1 To 0 Step -1
                                For Each item_2 As DataGridViewRow In frmOrdenPago.dgvDetalleOrden.Rows
                                    If listCompletaDetalleCheques.Item(i).IdDetalleCheque = item_2.Cells("idDetalleCheque").Value Then
                                        listCompletaDetalleCheques.Remove(listCompletaDetalleCheques.Item(i))
                                        Exit For
                                    End If
                                Next
                            Next

                            If listCompletaDetalleCheques.Count = 0 Then
                                For i As Integer = listCompletaChequeras.Count - 1 To 0 Step -1
                                    If listCompletaChequeras.Item(i).IdChequera = item.Cells("idChequera").Value Then
                                        listCompletaChequeras.Remove(listCompletaChequeras.Item(i))
                                        Exit For
                                    End If
                                Next
                            End If
                        ElseIf _TareasDetalleCheque.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(_TareasDetalleCheque.Err.Descripcion, Botones.OK, Iconos.ERR)

                            UtilidadesTXT.ResetVariables()
                            Me.DialogResult = DialogResult.Cancel
                            Me.Close()
                        End If
                    End If
                Next

                If listCompletaChequeras.Count > 0 Then
                    For Each item In listCompletaChequeras
                        cmbChequera.Items.Add(item.Banco + " --> [ " + item.NroChqInicial.ToString + " - " + (item.NroChqInicial + item.CantidadChq - 1).ToString() + " ]")
                    Next

                    cmbChequera.SelectionLength = Len(cmbChequera.Text)
                    cmbChequera.Select()

                    Notificaciones.cerrarFormProceso()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("No quedan cheques disponibles cargados en el sistema.", Botones.OK, Iconos.ALERTA)
                End If
            ElseIf _TareasChequera.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(_TareasChequera.Err.Descripcion, Botones.OK, Iconos.ERR)

                UtilidadesTXT.ResetVariables()
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            Else
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox("No quedan cheques disponibles cargados en el sistema.", Botones.OK, Iconos.ALERTA)
            End If
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
        If cmbChequera.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado una Chequera.", Botones.OK, Iconos.ALERTA)
            cmbChequera.Select()
        Else
            If cmbNroChq.Text = "" Then
                Notificaciones.MsgBox("No has seleccionado un Cheque.", Botones.OK, Iconos.ALERTA)
                cmbNroChq.Select()
            Else
                If txtPlazo.Text < 0 Then
                    Notificaciones.MsgBox("La fecha de emision del Cheque no puede ser posterior a la fecha de cobro.", Botones.OK, Iconos.ALERTA)
                    txtFecEmsion.Select()
                Else
                    If txtImporte.Text = "" Then
                        Notificaciones.MsgBox("No especificaste el importe del Cheque.", Botones.OK, Iconos.ALERTA)
                        txtImporte.Select()
                    Else
                        If UtilidadesVarias.SoloNumeros(txtImporte.Text) = 0 Then
                            Notificaciones.MsgBox("El importe del Cheque no puede ser de $ 0.00.", Botones.OK, Iconos.ALERTA)
                            txtImporte.Select()
                        Else
                            If txtObservaciones.Text = "" Then
                                txtObservaciones.Text = "-"
                            End If

                            If frmOrdenPago.dgvDetalleOrden.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                                frmOrdenPago.dgvDetalleOrden.Rows.Remove(frmOrdenPago.dgvDetalleOrden.CurrentRow)
                            End If

                            frmOrdenPago.dgvDetalleOrden.Rows.Add(0, txtIdChequera.Text, txtIdDetalleCheque.Text, "CHEQUE PROPIO", lblBanco.Text, "-", cmbNroChq.Text,
                                                                  "Propio", Format(CDate(txtFecEmsion.Text), "dd/MM/yyyy"), Format(CDate(txtFecCobro.Text), "dd/MM/yyyy"), "PESO", txtImporte.Text, txtObservaciones.Text)

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

#Region "EVENTOS KEY PRESS"
    Private Sub txtFecEmsion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecEmsion.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtFecCobro.SelectionLength = Len(txtFecCobro.Text)
            txtFecCobro.Select()
        End If
    End Sub

    Private Sub txtFecCobro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecCobro.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtPlazo.SelectionLength = Len(txtPlazo.Text)
            txtPlazo.Select()
        End If
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtObservaciones.SelectionLength = Len(txtObservaciones.Text)
            txtObservaciones.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtImporte.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPlazo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlazo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtImporte.SelectionLength = Len(txtImporte.Text)
            txtImporte.Select()
        ElseIf Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbChequera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbChequera.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbNroChq.SelectionLength = Len(cmbNroChq.Text)
            cmbNroChq.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            bnfCardNroChq.Enabled = False
            bnfCardFec.Enabled = False
            bnfCardImp.Enabled = False
            bnfCardObs.Enabled = False

            lblBanco.Text = ""
            lblCantChq.Text = ""
            lblChqDisp.Text = ""
            lblFecAlta.Text = ""
            lblObs.Text = ""

            cmbNroChq.Text = ""
            txtFecEmsion.Text = ""
            txtFecCobro.Text = ""
            txtPlazo.Text = ""
            txtImporte.Text = ""
            txtObservaciones.Text = ""
            txtIdDetalleCheque.Text = ""
            txtIdChequera.Text = ""
        End If
    End Sub

    Private Sub cmbNroChq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbNroChq.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtFecEmsion.SelectionLength = Len(txtFecEmsion.Text)
            txtFecEmsion.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            bnfCardFec.Enabled = False
            bnfCardImp.Enabled = False
            bnfCardObs.Enabled = False

            txtFecEmsion.Text = ""
            txtFecCobro.Text = ""
            txtPlazo.Text = ""
            txtImporte.Text = ""
            txtObservaciones.Text = ""
            txtIdDetalleCheque.Text = ""
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnAgregar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtFecEmsion_Validated(sender As Object, e As EventArgs) Handles txtFecEmsion.Validated
        If Not IsDate(txtFecEmsion.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)
            txtFecEmsion.Text = ""
        Else
            txtFecEmsion.Text = Format(CDate(txtFecEmsion.Text), "dd/MM/yyyy")

            RemoveHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged

            txtPlazo.Text = DateDiff(DateInterval.Day, CDate(txtFecEmsion.Text), CDate(txtFecCobro.Text))

            AddHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged
        End If
    End Sub

    Private Sub txtFecCobro_Validated(sender As Object, e As EventArgs) Handles txtFecCobro.Validated
        If Not IsDate(txtFecCobro.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)
            txtFecCobro.Text = ""
        Else
            txtFecCobro.Text = Format(CDate(txtFecCobro.Text), "dd/MM/yyyy")

            RemoveHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged

            txtPlazo.Text = DateDiff(DateInterval.Day, CDate(txtFecEmsion.Text), CDate(txtFecCobro.Text))

            AddHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged
        End If
    End Sub

    Private Sub txtImporte_Validated(sender As Object, e As EventArgs) Handles txtImporte.Validated
        If txtImporte.Text <> "" Then
            txtImporte.Text = Format(UtilidadesVarias.SoloNumeros(txtImporte.Text), "$ #,##0.00")
        End If
    End Sub
#End Region

#Region "EVENTO CHANGED"
    Private Sub txtImporte_TextChanged(sender As Object, e As EventArgs) Handles txtImporte.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtImporte, AddressOf txtImporte_TextChanged, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)
    End Sub

    Private Sub txtFecEmsion_TextChanged(sender As Object, e As EventArgs) Handles txtFecEmsion.TextChanged
        If txtFecEmsion.Text = "" Then
            If bnfCardFec.Enabled = True Then
                txtFecEmsion.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                RemoveHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged

                txtPlazo.Text = DateDiff(DateInterval.Day, CDate(txtFecEmsion.Text), CDate(txtFecCobro.Text))

                AddHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged

                txtFecEmsion.SelectionLength = Len(txtFecEmsion.Text)
                txtFecEmsion.Select()
            End If
        End If
    End Sub

    Private Sub txtFecCobro_TextChanged(sender As Object, e As EventArgs) Handles txtFecCobro.TextChanged
        If txtFecCobro.Text = "" Then
            If bnfCardFec.Enabled = True Then
                txtFecCobro.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                RemoveHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged

                txtPlazo.Text = DateDiff(DateInterval.Day, CDate(txtFecEmsion.Text), CDate(txtFecCobro.Text))

                AddHandler txtPlazo.TextChanged, AddressOf txtPlazo_TextChanged

                txtFecCobro.SelectionLength = Len(txtFecCobro.Text)
                txtFecCobro.Select()
            End If
        End If
    End Sub

    Private Sub txtPlazo_TextChanged(sender As Object, e As EventArgs) Handles txtPlazo.TextChanged
        If bnfCardFec.Enabled = True Then
            If txtPlazo.Text <> "" Then
                txtFecCobro.Text = CDate(txtFecEmsion.Text).AddDays(CInt(txtPlazo.Text))
            Else
                txtPlazo.Text = 0

                txtFecCobro.Text = CDate(txtFecEmsion.Text).AddDays(CInt(txtPlazo.Text))

                txtPlazo.SelectionLength = Len(txtPlazo.Text)
                txtPlazo.Select()
            End If
        End If
    End Sub

    Private Async Sub cmbChequera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChequera.SelectedIndexChanged
        Notificaciones.arbirFormProceso("CARGANDO CHEQUES")

        For Each item In listCompletaChequeras
            If item.Banco + " --> [ " + item.NroChqInicial.ToString + " - " + (item.NroChqInicial + item.CantidadChq - 1).ToString() + " ]" = cmbChequera.Text Then
                lblBanco.Text = item.Banco
                lblCantChq.Text = item.CantidadChq
                lblChqDisp.Text = item.ChqDisponibles
                lblFecAlta.Text = item.FechaAlta
                lblObs.Text = item.Observaciones
                txtIdChequera.Text = item.IdChequera

                listCompletaDetalleCheques = Await _TareasDetalleCheque.ListadoIdChequeraEnDisponibilidad(item.IdChequera)

                Exit For
            End If
        Next

        bnfCardNroChq.Enabled = True
        bnfCardFec.Enabled = False
        bnfCardImp.Enabled = False
        bnfCardObs.Enabled = False

        cmbNroChq.Text = ""
        txtFecEmsion.Text = ""
        txtFecCobro.Text = ""
        txtPlazo.Text = ""
        txtImporte.Text = ""
        txtObservaciones.Text = ""

        cmbNroChq.Items.Clear()

        If Not IsNothing(listCompletaDetalleCheques) Then
            Dim count As Integer = 0

            For Each item In listCompletaDetalleCheques
                Dim agg As Boolean = True

                For Each item_2 As DataGridViewRow In frmOrdenPago.dgvDetalleOrden.Rows
                    If item.IdDetalleCheque = item_2.Cells("idDetalleCheque").Value Then
                        agg = False
                        count += 1
                        Exit For
                    End If
                Next

                If agg Then
                    cmbNroChq.Items.Add(item.Numero)
                End If
            Next

            lblChqDisp.Text -= count

            Notificaciones.cerrarFormProceso()
        ElseIf _TareasDetalleCheque.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasDetalleCheque.Err.Descripcion, Botones.OK, Iconos.ERR)

            UtilidadesTXT.ResetVariables()

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        Else
            Notificaciones.cerrarFormProceso()
        End If
    End Sub

    Private Sub cmbNroChq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNroChq.SelectedIndexChanged
        For Each item In listCompletaDetalleCheques
            If item.Numero = cmbNroChq.Text Then
                txtIdDetalleCheque.Text = item.IdDetalleCheque
                Exit For
            End If
        Next

        bnfCardFec.Enabled = True
        bnfCardImp.Enabled = True
        bnfCardObs.Enabled = True

        txtFecEmsion.Text = Format(Date.Now.Date, "dd/MM/yyyy")
        txtFecCobro.Text = Format(Date.Now.Date, "dd/MM/yyyy")
        txtPlazo.Text = 0
        txtImporte.Text = ""
        txtObservaciones.Text = ""
    End Sub
#End Region
End Class