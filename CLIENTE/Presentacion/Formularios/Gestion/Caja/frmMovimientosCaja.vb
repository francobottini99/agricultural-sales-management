Imports Procesos

Public Class frmMovimientosCaja
    Private listCompletaValores As List(Of ValoresEnCartera)
    Private listCompletaBancos As List(Of Bancos)
    Private _TareasCaja As TareasCaja
    Private _TareasValores As TareasValoresEnCartera
    Private _TareasMovimientoValores As TareasMovimientoValores
    Private _TareasBanco As TareasBancos

#Region "ANIMACION BOTONES"
    Private Sub btnGuardar_GotFocus(sender As Object, e As EventArgs) Handles btnGuardar.GotFocus
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnGuardar_LostFocus(sender As Object, e As EventArgs) Handles btnGuardar.LostFocus
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnGuardar_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar.MouseEnter
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCancelar_GotFocus(sender As Object, e As EventArgs) Handles btnCancelar.GotFocus
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCancelar_LostFocus(sender As Object, e As EventArgs) Handles btnCancelar.LostFocus
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCancelar_MouseEnter(sender As Object, e As EventArgs) Handles btnCancelar.MouseEnter
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelar.MouseLeave
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub
#End Region

#Region "LOAD FORM"
    Private Sub frmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _TareasCaja = New TareasCaja()
        _TareasValores = New TareasValoresEnCartera()
        _TareasBanco = New TareasBancos()
        _TareasMovimientoValores = New TareasMovimientoValores()

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        txtFecha.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        cmbMoneda.Items.Add("PESO")
        cmbMoneda.Items.Add("DOLAR")

        cmbTipo.Items.Add("EFECTIVO")
        cmbTipo.Items.Add("VALOR EN CARTERA")

        UtilidadesDGV.FormatoDGVGeneral(dgvValoresCartera)

        ConfigDgvValoresCartera()

        cmbMoneda.Enabled = False
        txtImporte.Enabled = False
        bnfCardDatosValor.Enabled = False
        bnfCardValoresEnCartera.Enabled = False
        bnfCardGral.Enabled = False
        bnfCardOrigenDestino.Enabled = False

        txtFecha.SelectionLength = Len(txtFecha.Text)
        txtFecha.Select()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Async Sub CargarValoresEnCartera()
        Notificaciones.arbirFormProceso("CARGANDO VALORES")
        UtilidadesDGV.DescargarDGV(dgvValoresCartera)

        listCompletaValores = Await _TareasValores.ListadoDisponible()

        If Not IsNothing(listCompletaValores) Then
            TareasValoresEnCartera.LlenarDGV(dgvValoresCartera, listCompletaValores)

            UtilidadesDGV.CabeceraDGV(dgvValoresCartera)

            cmbMov.Items.Add("EGRESO")

            Notificaciones.cerrarFormProceso()
        ElseIf _TareasValores.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasValores.Err.Descripcion, Botones.OK, Iconos.ERR)
        Else
            Notificaciones.cerrarFormProceso()
        End If
    End Sub

    Private Sub ConfigDgvValoresCartera()
        dgvValoresCartera.ColumnCount = 12
        dgvValoresCartera.Columns(0).Name = "idValoresEnCartera"
        dgvValoresCartera.Columns(1).Name = "TipoValor"
        dgvValoresCartera.Columns(2).Name = "Banco"
        dgvValoresCartera.Columns(3).Name = "Sucursal"
        dgvValoresCartera.Columns(4).Name = "Numero"
        dgvValoresCartera.Columns(5).Name = "Librador"
        dgvValoresCartera.Columns(6).Name = "FechaCobro"
        dgvValoresCartera.Columns(7).Name = "Moneda"
        dgvValoresCartera.Columns(8).Name = "Importe"
        dgvValoresCartera.Columns(9).Name = "Disponible"
        dgvValoresCartera.Columns(10).Name = "Eliminado"
        dgvValoresCartera.Columns(11).Name = "Usuarios_idUsuarios"

        dgvValoresCartera.Columns("idValoresEnCartera").Visible = False
        dgvValoresCartera.Columns("Moneda").Visible = False
        dgvValoresCartera.Columns("Disponible").Visible = False
        dgvValoresCartera.Columns("Eliminado").Visible = False
        dgvValoresCartera.Columns("Usuarios_idUsuarios").Visible = False

        dgvValoresCartera.Columns("Banco").HeaderText = "BANCO"
        dgvValoresCartera.Columns("Sucursal").HeaderText = "SUCURSAL"
        dgvValoresCartera.Columns("TipoValor").HeaderText = "TIPO DE VALOR"
        dgvValoresCartera.Columns("Numero").HeaderText = "NUMERO"
        dgvValoresCartera.Columns("Librador").HeaderText = "LIBRADOR"
        dgvValoresCartera.Columns("FechaCobro").HeaderText = "FECHA DE COBRO"
        dgvValoresCartera.Columns("Importe").HeaderText = "IMPORTE"

        dgvValoresCartera.Columns("idValoresEnCartera").DisplayIndex = 0
        dgvValoresCartera.Columns("TipoValor").DisplayIndex = 1
        dgvValoresCartera.Columns("Banco").DisplayIndex = 2
        dgvValoresCartera.Columns("Sucursal").DisplayIndex = 3
        dgvValoresCartera.Columns("Numero").DisplayIndex = 4
        dgvValoresCartera.Columns("Librador").DisplayIndex = 5
        dgvValoresCartera.Columns("FechaCobro").DisplayIndex = 6
        dgvValoresCartera.Columns("Moneda").DisplayIndex = 7
        dgvValoresCartera.Columns("Importe").DisplayIndex = 8
        dgvValoresCartera.Columns("Disponible").DisplayIndex = 9
        dgvValoresCartera.Columns("Eliminado").DisplayIndex = 10
        dgvValoresCartera.Columns("Usuarios_idUsuarios").DisplayIndex = 11

        dgvValoresCartera.Columns("Banco").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("Sucursal").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("TipoValor").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("Numero").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("Librador").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("FechaCobro").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("Importe").SortMode = DataGridViewColumnSortMode.NotSortable

        dgvValoresCartera.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvValoresCartera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvValoresCartera.ColumnHeadersVisible = False
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        UtilidadesTXT.ResetVariables()

        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If IsNothing(dgvValoresCartera.CurrentCell) And cmbTipo.Text = "VALOR EN CARTERA" And cmbMov.Text = "EGRESO" Then
            Notificaciones.MsgBox("No seleccionaste ningun valor de la cartera.", Botones.OK, Iconos.ALERTA)
        Else
            If cmbTipo.Text = "" Then
                Notificaciones.MsgBox("No has especificado el Tipo.", Botones.OK, Iconos.ALERTA)
                txtImporte.Select()
            Else
                If cmbMov.Text = "" Then
                    Notificaciones.MsgBox("No has especificado el tipo de Movimiento.", Botones.OK, Iconos.ALERTA)
                    cmbMov.Select()
                Else
                    If cmbMoneda.Text = "" Then
                        Notificaciones.MsgBox("No has especificado la Moneda.", Botones.OK, Iconos.ALERTA)
                        cmbMoneda.Select()
                    Else
                        If txtImporte.Text = "" Then
                            Notificaciones.MsgBox("No has especificado el Importe.", Botones.OK, Iconos.ALERTA)
                            txtImporte.Select()
                        Else
                            If cmbTipoValor.Text = "" And cmbTipo.Text = "VALOR EN CARTERA" And cmbMov.Text = "INGRESO" Then
                                Notificaciones.MsgBox("No has especificado el Tipo de Valor.", Botones.OK, Iconos.ALERTA)
                                cmbTipoValor.Select()
                            Else
                                If txtLibrador.Text = "" And cmbTipo.Text = "VALOR EN CARTERA" And cmbMov.Text = "INGRESO" Then
                                    Notificaciones.MsgBox("No has especificado el Librador.", Botones.OK, Iconos.ALERTA)
                                    txtLibrador.Select()
                                Else
                                    If txtObservaciones.Text = "" Then
                                        txtObservaciones.Text = "-"
                                    End If

                                    Dim ingreso As Double = 0
                                    Dim egreso As Double = 0

                                    If cmbMov.Text = "INGRESO" Then
                                        ingreso = UtilidadesVarias.SoloNumeros(txtImporte.Text)
                                    Else
                                        egreso = UtilidadesVarias.SoloNumeros(txtImporte.Text)
                                    End If

                                    Dim _Caja As New Caja With {
                                            .Fecha = txtFecha.Text,
                                            .Movimiento = cmbMov.Text,
                                            .Comprobante = "MOVIMIENTO MANUAL",
                                            .Observaciones = txtObservaciones.Text,
                                            .Moneda = cmbMoneda.Text,
                                            .Ingreso = ingreso,
                                            .Egreso = egreso,
                                            .Eliminado = "NO",
                                            .AscUsuarios = DatosSesion._Usuario
                                        }

                                    If cmbTipo.Text = "EFECTIVO" Then
                                        _Caja.Descripcion = "EFECTIVO"

                                        Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Movimiento de Caja ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                        If resp = DialogResult.OK Then
                                            Notificaciones.arbirFormProceso("GUARDANDO MOVIMIENTO DE CAJA")

                                            If Await _TareasCaja.Insertar(_Caja) Then
                                                Notificaciones.cerrarFormProceso()
                                                Notificaciones.MsgBox("Movimiento de caja guardado con exito !", Botones.OK, Iconos.OK)

                                                UtilidadesTXT.ResetVariables()
                                                Me.DialogResult = DialogResult.OK
                                                Me.Close()
                                            Else
                                                Notificaciones.cerrarFormProceso()
                                                Notificaciones.MsgBox(_TareasCaja.Err.Descripcion, Botones.OK, Iconos.ERR)
                                            End If
                                        End If
                                    ElseIf cmbTipo.Text = "VALOR EN CARTERA" Then
                                        If txtOrigenDestino.Text = "" Then
                                            txtOrigenDestino.Text = "-"
                                        End If

                                        If txtNumero.Text = "" Then
                                            txtNumero.Text = "-"
                                        End If

                                        If cmbBanco.Text = "" Then
                                            cmbBanco.Text = "Ninguno"
                                        End If

                                        If txtSucursal.Text = "" Then
                                            txtSucursal.Text = "-"
                                        End If

                                        _Caja.Descripcion = cmbTipoValor.Text + " - ( " + txtNumero.Text + " ) - " + txtLibrador.Text

                                        Dim _MovimientoValor As New MovimientoValores With {
                                                    .Fecha = txtFecha.Text,
                                                    .Movimiento = cmbMov.Text,
                                                    .OrigenDestino = txtOrigenDestino.Text,
                                                    .Eliminado = "NO",
                                                    .AscCaja = _Caja
                                                }

                                        If cmbMov.Text = "EGRESO" Then
                                            _MovimientoValor.AscValoresEnCartera = New ValoresEnCartera With {.IdValoresEnCartera = dgvValoresCartera.CurrentRow.Cells("idValoresEnCartera").Value}
                                        ElseIf cmbMov.Text = "INGRESO" Then
                                            _MovimientoValor.AscValoresEnCartera = New ValoresEnCartera With {
                                                .TipoValor = cmbTipoValor.Text,
                                                .Banco = cmbBanco.Text,
                                                .Sucursal = txtSucursal.Text,
                                                .Numero = txtNumero.Text,
                                                .Librador = txtLibrador.Text,
                                                .FechaCobro = txtFechaCobro.Text,
                                                .Moneda = cmbMoneda.Text,
                                                .Importe = UtilidadesVarias.SoloNumeros(txtImporte.Text),
                                                .Disponible = "SI",
                                                .Eliminado = "NO",
                                                .AscUsuarios = DatosSesion._Usuario
                                            }
                                        End If

                                        Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Movimiento de Caja ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                        If resp = DialogResult.OK Then
                                            Notificaciones.arbirFormProceso("GUARDANDO MOVIMIENTO DE CAJA")

                                            If Await _TareasMovimientoValores.Servicio_Insertar(_MovimientoValor) Then
                                                Notificaciones.cerrarFormProceso()
                                                Notificaciones.MsgBox("Movimiento de caja guardado con exito !", Botones.OK, Iconos.OK)

                                                UtilidadesTXT.ResetVariables()
                                                Me.DialogResult = DialogResult.OK
                                                Me.Close()
                                            Else
                                                Notificaciones.cerrarFormProceso()
                                                Notificaciones.MsgBox(_TareasMovimientoValores.Err.Descripcion, Botones.OK, Iconos.ERR)
                                            End If
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

    Private Sub dgvValoresCartera_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvValoresCartera.CellClick
        If e.RowIndex > -1 Then
            cmbMoneda.Text = dgvValoresCartera.CurrentRow.Cells("Moneda").Value
            txtImporte.Text = dgvValoresCartera.CurrentRow.Cells("Importe").Value
            cmbTipoValor.Text = dgvValoresCartera.CurrentRow.Cells("TipoValor").Value
            cmbBanco.Text = dgvValoresCartera.CurrentRow.Cells("Banco").Value
            txtNumero.Text = dgvValoresCartera.CurrentRow.Cells("Numero").Value
            txtLibrador.Text = dgvValoresCartera.CurrentRow.Cells("Librador").Value
            txtFechaCobro.Text = dgvValoresCartera.CurrentRow.Cells("FechaCobro").Value
        Else
            cmbMoneda.Text = ""
            txtImporte.Text = ""
            cmbTipoValor.Text = ""
            cmbBanco.Text = ""
            txtNumero.Text = ""
            txtLibrador.Text = ""
            txtFechaCobro.Text = ""

            dgvValoresCartera.CurrentCell = Nothing
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbTipo.SelectionLength = Len(cmbTipo.Text)
            cmbTipo.Select()
        End If
    End Sub

    Private Sub cmbTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTipo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbCuentaContable.SelectionLength = Len(cmbCuentaContable.Text)
            cmbCuentaContable.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            cmbMoneda.Enabled = False
            txtImporte.Enabled = False
            bnfCardDatosValor.Enabled = False
            bnfCardValoresEnCartera.Enabled = False
            bnfCardGral.Enabled = False
            bnfCardOrigenDestino.Enabled = False

            cmbTipo.Text = ""
            cmbMov.Text = ""
            txtFechaCobro.Text = ""
            cmbMoneda.Text = ""
            txtImporte.Text = ""
            cmbTipoValor.Text = ""
            cmbBanco.Text = ""
            txtNumero.Text = ""
            txtOrigenDestino.Text = ""
            txtLibrador.Text = ""

            UtilidadesDGV.DescargarDGV(dgvValoresCartera)
            UtilidadesDGV.CabeceraDGV(dgvValoresCartera)
        End If
    End Sub

    Private Sub cmbCuentaContable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCuentaContable.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtObservaciones.SelectionLength = Len(txtObservaciones.Text)
            txtObservaciones.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            cmbCuentaContable.Text = ""
        End If
    End Sub

    Private Sub cmbMov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMov.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If cmbMov.Text = "EGRESO" And cmbTipo.Text = "VALOR EN CARTERA" Then
                txtOrigenDestino.Select()
            Else
                cmbMoneda.SelectionLength = Len(cmbMoneda.Text)
                cmbMoneda.Select()
            End If
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            cmbMoneda.Enabled = False
            txtImporte.Enabled = False
            bnfCardDatosValor.Enabled = False
            bnfCardValoresEnCartera.Enabled = False
            bnfCardOrigenDestino.Enabled = False

            cmbMov.Text = ""
            txtFechaCobro.Text = ""
            cmbMoneda.Text = ""
            txtImporte.Text = ""
            cmbTipoValor.Text = ""
            cmbBanco.Text = ""
            txtNumero.Text = ""
            txtLibrador.Text = ""
            txtOrigenDestino.Text = ""

            UtilidadesDGV.DescargarDGV(dgvValoresCartera)
            UtilidadesDGV.CabeceraDGV(dgvValoresCartera)
        End If
    End Sub

    Private Sub txtDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbMov.SelectionLength = Len(cmbMov.Text)
            cmbMov.Select()
        End If
    End Sub

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

            If cmbTipo.Text = "EFECTIVO" Then
                btnGuardar.Select()
            ElseIf cmbTipo.Text = "VALOR EN CARTERA" Then
                cmbTipoValor.SelectionLength = Len(cmbTipoValor.Text)
                cmbTipoValor.Select()
            End If
        ElseIf e.KeyChar = ChrW(46) And Not txtImporte.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtOrigenDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrigenDestino.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnGuardar.Select()
        End If
    End Sub

    Private Sub cmbTipoValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTipoValor.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNumero.SelectionLength = Len(txtNumero.Text)
            txtNumero.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            cmbTipoValor.Text = ""
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

            txtOrigenDestino.SelectionLength = Len(txtOrigenDestino.Text)
            txtOrigenDestino.Select()
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
    Private Sub txtFecha_Validated(sender As Object, e As EventArgs) Handles txtFecha.Validated
        If Not IsDate(txtFecha.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)
            txtFecha.Text = ""
        Else
            txtFecha.Text = Format(CDate(txtFecha.Text), "dd/MM/yyyy")
        End If
    End Sub

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

    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged
        If txtFecha.Text = "" Then
            If bnfCardCabecera.Enabled = True Then
                txtFecha.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtFecha.SelectionLength = Len(txtFecha.Text)
                txtFecha.Select()
            End If
        End If
    End Sub

    Private Sub txtFechaCobro_TextChanged(sender As Object, e As EventArgs) Handles txtFechaCobro.TextChanged
        If txtFechaCobro.Text = "" Then
            If bnfCardDatosValor.Enabled = True Then
                txtFechaCobro.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtFechaCobro.SelectionLength = Len(txtFechaCobro.Text)
                txtFechaCobro.Select()
            End If
        End If
    End Sub

    Private Async Sub cmbMov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMov.SelectedIndexChanged
        If cmbTipo.Text = "VALOR EN CARTERA" Then
            If cmbMov.Text = "EGRESO" Then
                cmbMoneda.Enabled = False
                txtImporte.Enabled = False
                bnfCardDatosValor.Enabled = False
                bnfCardValoresEnCartera.Enabled = True
                bnfCardOrigenDestino.Enabled = True

                txtFechaCobro.Text = ""
            Else
                Notificaciones.arbirFormProceso()

                cmbMoneda.Enabled = True
                txtImporte.Enabled = True
                bnfCardDatosValor.Enabled = True
                bnfCardOrigenDestino.Enabled = True
                bnfCardValoresEnCartera.Enabled = False

                dgvValoresCartera.CurrentCell = Nothing

                txtFechaCobro.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                cmbBanco.Items.Clear()
                cmbTipoValor.Items.Clear()

                cmbTipoValor.Items.Add("CHEQUE")

                listCompletaBancos = Await _TareasBanco.ListadoCompleto()

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
            End If

            cmbMoneda.Text = ""
            txtImporte.Text = ""
            cmbTipoValor.Text = ""
            cmbBanco.Text = ""
            txtNumero.Text = ""
            txtLibrador.Text = ""
            txtOrigenDestino.Text = ""
        Else
            cmbMoneda.Enabled = True
            txtImporte.Enabled = True
            bnfCardDatosValor.Enabled = False
            bnfCardValoresEnCartera.Enabled = False
            bnfCardOrigenDestino.Enabled = False
        End If
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        cmbMov.Items.Clear()
        cmbMov.Items.Add("INGRESO")

        If cmbTipo.Text = "VALOR EN CARTERA" Then
            cmbMoneda.Enabled = False
            txtImporte.Enabled = False

            CargarValoresEnCartera()
        Else
            cmbMoneda.Enabled = True
            txtImporte.Enabled = True

            UtilidadesDGV.DescargarDGV(dgvValoresCartera)
            UtilidadesDGV.CabeceraDGV(dgvValoresCartera)

            cmbMov.Items.Add("EGRESO")
        End If

        bnfCardGral.Enabled = True
        cmbMoneda.Enabled = False
        txtImporte.Enabled = False
        bnfCardDatosValor.Enabled = False
        bnfCardValoresEnCartera.Enabled = False
        bnfCardOrigenDestino.Enabled = False

        cmbMov.Text = ""
        txtFechaCobro.Text = ""
        cmbMoneda.Text = ""
        txtImporte.Text = ""
        cmbTipoValor.Text = ""
        cmbBanco.Text = ""
        txtNumero.Text = ""
        txtLibrador.Text = ""
        txtOrigenDestino.Text = ""
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
#End Region
End Class