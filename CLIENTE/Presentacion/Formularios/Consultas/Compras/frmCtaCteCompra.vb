Imports Procesos

Public Class frmCtaCteCompra
    Private listadoProveedores As List(Of Proveedores)
    Private listadoCtaCrtCompra As List(Of CuentaCorrienteCompra)
    Private listadoComprobantes As List(Of Comprobantes)
    Private infoProveedor As Proveedores

    Private tareasProveedores As TareasProveedores
    Private tareasCtaCrtCompra As TareasCuentaCorrienteCompra
    Private tareasComprobantes As TareasComprobantes

#Region "ANIMACION BOTONES"
    Private Sub btnImprimir_GotFocus(sender As Object, e As EventArgs) Handles btnImprimir.GotFocus
        If btnImprimir.Enabled = True Then
            btnImprimir.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnImprimir_LostFocus(sender As Object, e As EventArgs) Handles btnImprimir.LostFocus
        If btnImprimir.Enabled = True Then
            btnImprimir.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnImprimir_MouseEnter(sender As Object, e As EventArgs) Handles btnImprimir.MouseEnter
        If btnImprimir.Enabled = True Then
            btnImprimir.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnImprimir_MouseLeave(sender As Object, e As EventArgs) Handles btnImprimir.MouseLeave
        If btnImprimir.Enabled = True Then
            btnImprimir.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnFiltar_GotFocus(sender As Object, e As EventArgs) Handles btnFiltar.GotFocus
        If btnFiltar.Enabled = True Then
            btnFiltar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnFiltar_LostFocus(sender As Object, e As EventArgs) Handles btnFiltar.LostFocus
        If btnFiltar.Enabled = True Then
            btnFiltar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnFiltar_MouseEnter(sender As Object, e As EventArgs) Handles btnFiltar.MouseEnter
        If btnFiltar.Enabled = True Then
            btnFiltar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnFiltar_MouseLeave(sender As Object, e As EventArgs) Handles btnFiltar.MouseLeave
        If btnFiltar.Enabled = True Then
            btnFiltar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

#End Region

#Region "LOAD"
    Private Sub FrmRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a CUENTAS CORRIENTES DE COMPRA"

        tareasProveedores = New TareasProveedores()
        tareasCtaCrtCompra = New TareasCuentaCorrienteCompra()
        tareasComprobantes = New TareasComprobantes()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        listadoProveedores = Await tareasProveedores.ListadoCompleto()

        If Not IsNothing(listadoProveedores) Then
            listadoComprobantes = Await tareasComprobantes.ListadoCompleto()

            If IsNothing(listadoComprobantes) Then
                If tareasComprobantes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareasComprobantes.Err.Descripcion, Botones.OK, Iconos.ERR)

                    frmPpal.AbrirFrm(frmInicio)
                End If
            End If

            UtilidadesDGV.FormatoDGVGeneral(dgvDetalle)

            ConfigDGV()

            dgvDetalle.ColumnHeadersVisible = False

            setEnabled(True)
            setColor(Color.FromArgb(100, 100, 100))

            btnHistorico.Enabled = False
            btnHistorico.BackColor = Color.FromArgb(190, 140, 5)

            txtFecDesde.Text = "**/**/****"
            txtFecHasta.Text = "**/**/****"

            Notificaciones.cerrarFormProceso()

            txtCtaProv.Select()
        ElseIf tareasProveedores.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareasProveedores.Err.Descripcion, Botones.OK, Iconos.ERR)


            frmPpal.AbrirFrm(frmInicio)
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("No hay Proveedores cargados en el Sistema.", Botones.OK, Iconos.ERR)


            frmPpal.AbrirFrm(frmInicio)
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDGV()
        With dgvDetalle
            .ColumnCount = 9
            .Columns(0).Name = "idCuentaCorrienteCompra"
            .Columns(1).Name = "Fecha"
            .Columns(2).Name = "FechaVto"
            .Columns(3).Name = "Comprobante"
            .Columns(4).Name = "Numero"
            .Columns(5).Name = "Detalle"
            .Columns(6).Name = "Debito"
            .Columns(7).Name = "Credito"
            .Columns(8).Name = "Saldo"

            .Columns("idCuentaCorrienteCompra").Visible = False

            .Columns("Fecha").HeaderText = "FECHA"
            .Columns("FechaVto").HeaderText = "FECHA VTO"
            .Columns("Comprobante").HeaderText = "COMPROBANTE"
            .Columns("Numero").HeaderText = "NUMERO"
            .Columns("Debito").HeaderText = "DEBE"
            .Columns("Credito").HeaderText = "HABER"
            .Columns("Saldo").HeaderText = "SALDO"
            .Columns("Detalle").HeaderText = "DETALLE"

            .Columns("idCuentaCorrienteCompra").DisplayIndex = 0
            .Columns("Fecha").DisplayIndex = 1
            .Columns("FechaVto").DisplayIndex = 2
            .Columns("Comprobante").DisplayIndex = 3
            .Columns("Numero").DisplayIndex = 4
            .Columns("Debito").DisplayIndex = 5
            .Columns("Credito").DisplayIndex = 6
            .Columns("Saldo").DisplayIndex = 7
            .Columns("Detalle").DisplayIndex = 8

            .Columns("Fecha").Resizable = DataGridViewTriState.False
            .Columns("FechaVto").Resizable = DataGridViewTriState.False
            .Columns("Comprobante").Resizable = DataGridViewTriState.False
            .Columns("Numero").Resizable = DataGridViewTriState.False
            .Columns("Debito").Resizable = DataGridViewTriState.False
            .Columns("Credito").Resizable = DataGridViewTriState.False
            .Columns("Saldo").Resizable = DataGridViewTriState.False
            .Columns("Detalle").Resizable = DataGridViewTriState.False

            .Columns("Fecha").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("FechaVto").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Comprobante").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Numero").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Debito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Credito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Saldo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Detalle").SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns("Fecha").Width = 125
            .Columns("FechaVto").Width = 125
            .Columns("Comprobante").Width = 150
            .Columns("Numero").Width = 125
            .Columns("Debito").Width = 150
            .Columns("Credito").Width = 150
            .Columns("Saldo").Width = 150
            .Columns("Detalle").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            .Columns("Detalle").MinimumWidth = 289

            .Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("FechaVto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Comprobante").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("Numero").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Debito").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Credito").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Detalle").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
    End Sub

    Private Async Function CargarDetalle(Optional fecDesde As Date = Nothing, Optional fecHasta As Date = Nothing) As Task
        If txtRSprov.Text <> "" Then
            Notificaciones.arbirFormProceso("CARGANDO DETALLE")
            UtilidadesDGV.DescargarDGV(dgvDetalle)

            listadoCtaCrtCompra = Await tareasCtaCrtCompra.ListadoIdProveedor(txtCtaProv.Text)

            If Not IsNothing(listadoCtaCrtCompra) Then
                If bnfChkFactura.Checked And Not bnfChkRecibo.Checked Then
                    For i As Integer = listadoCtaCrtCompra.Count - 1 To 0 Step -1
                        Dim remove As Boolean = False

                        If listadoCtaCrtCompra.Item(i).Comprobante <> "FACTURA" Then
                            remove = True
                        End If

                        If fecDesde <> Nothing And fecHasta <> Nothing Then
                            If listadoCtaCrtCompra.Item(i).Fecha > fecHasta Or listadoCtaCrtCompra.Item(i).Fecha < fecDesde Then
                                remove = True
                            End If
                        End If

                        If remove Then
                            listadoCtaCrtCompra.Remove(listadoCtaCrtCompra.Item(i))
                        End If
                    Next
                ElseIf bnfChkRecibo.Checked And Not bnfChkFactura.Checked Then
                    For i As Integer = listadoCtaCrtCompra.Count - 1 To 0 Step -1
                        Dim remove As Boolean = False

                        If listadoCtaCrtCompra.Item(i).Comprobante <> "ORDEN DE PAGO" Then
                            remove = True
                        End If

                        If fecDesde <> Nothing And fecHasta <> Nothing Then
                            If listadoCtaCrtCompra.Item(i).Fecha > fecHasta Or listadoCtaCrtCompra.Item(i).Fecha < fecDesde Then
                                remove = True
                            End If
                        End If

                        If remove Then
                            listadoCtaCrtCompra.Remove(listadoCtaCrtCompra.Item(i))
                        End If
                    Next
                ElseIf Not bnfChkRecibo.Checked And Not bnfChkFactura.Checked Then
                    listadoCtaCrtCompra.Clear()
                Else
                    If fecDesde <> Nothing And fecHasta <> Nothing Then
                        For i As Integer = listadoCtaCrtCompra.Count - 1 To 0 Step -1
                            If listadoCtaCrtCompra.Item(i).Fecha > fecHasta Or listadoCtaCrtCompra.Item(i).Fecha < fecDesde Then
                                listadoCtaCrtCompra.Remove(listadoCtaCrtCompra.Item(i))
                            End If
                        Next
                    End If
                End If

                txtTipCambio.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
                lblBanco.Text = "BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha

                Dim saldoAcumulado As Double = 0
                For Each item In listadoCtaCrtCompra
                    saldoAcumulado += item.Credito - item.Debito
                    item.Saldo = saldoAcumulado

                    dgvDetalle.Rows.Add(item.IdCuentaCorrienteCompra, Format(CDate(item.Fecha), "dd/MM/yyyy"), Format(CDate(item.FechaVto), "dd/MM/yyyy"),
                                        item.Comprobante, item.Numero, item.Detalle, Format(item.Debito, DatosSesion._MonedaPPal.Simbolo & " ##,#0.00"),
                                        Format(item.Credito, DatosSesion._MonedaPPal.Simbolo & " ##,#0.00"), Format(item.Saldo, DatosSesion._MonedaPPal.Simbolo & " ##,#0.00"))

                    If item.Debito > 0 Then
                        dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells("Debito").Style.ForeColor = Color.FromArgb(255, 20, 20)
                    End If

                    If item.Credito > 0 Then
                        dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells("Credito").Style.ForeColor = Color.FromArgb(95, 150, 15)
                    End If

                    If item.Saldo < 0 Then
                        dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells("Saldo").Style.ForeColor = Color.FromArgb(255, 20, 20)
                    Else
                        dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells("Saldo").Style.ForeColor = Color.FromArgb(95, 150, 15)
                    End If
                Next

                UtilidadesDGV.CabeceraDGV(dgvDetalle, DataGridViewAutoSizeColumnsMode.None)

                txtSaldoP.Text = Format(saldoAcumulado, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
                txtSaldolC.Text = Format(saldoAcumulado * UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")

                If saldoAcumulado < 0 Then
                    txtSaldoP.ForeColor = Color.FromArgb(255, 20, 20)
                    txtSaldolC.ForeColor = Color.FromArgb(255, 20, 20)
                Else
                    txtSaldoP.ForeColor = Color.FromArgb(95, 150, 15)
                    txtSaldolC.ForeColor = Color.FromArgb(95, 150, 15)
                End If

                Notificaciones.cerrarFormProceso()

                bnfCardDetalle.Enabled = True
            ElseIf tareasCtaCrtCompra.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(tareasCtaCrtCompra.Err.Descripcion, Botones.OK, Iconos.ERR)

                bnfCardDetalle.Enabled = False

                txtSaldolC.Text = ""
                txtSaldoP.Text = ""
                txtTipCambio.Text = ""
            Else
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox("La cuenta corriente de " + txtRSprov.Text + " esta vacia.", Botones.OK, Iconos.ALERTA)

                bnfCardDetalle.Enabled = False

                txtSaldolC.Text = ""
                txtSaldoP.Text = ""
                txtTipCambio.Text = ""
            End If
        End If
    End Function


    Private Async Sub ActualizarBusqueda()
        If IsDate(txtFecDesde.Text) Or txtFecDesde.Text = "**/**/****" Then
            If IsDate(txtFecHasta.Text) Or txtFecHasta.Text = "**/**/****" Then
                If txtFecDesde.Text = "**/**/****" And txtFecHasta.Text = "**/**/****" Then
                    setEnabled(True)
                    setColor(Color.FromArgb(100, 100, 100))

                    btnHistorico.Enabled = False
                    btnHistorico.BackColor = Color.FromArgb(190, 140, 5)

                    Await CargarDetalle()
                ElseIf txtFecHasta.Text >= CDate(txtFecDesde.Text) Then
                    setEnabled(True)
                    setColor(Color.FromArgb(100, 100, 100))

                    If txtFecDesde.Text = Date.Now.Date And txtFecHasta.Text = Date.Now.Date Then
                        btnHoy.Enabled = False
                        btnHoy.BackColor = Color.FromArgb(190, 140, 5)
                    ElseIf txtFecDesde.Text = New Date(Date.Now.Date.Year, Date.Now.Date.Month, 1) Then
                        btnMes.Enabled = False
                        btnMes.BackColor = Color.FromArgb(190, 140, 5)
                    ElseIf txtFecDesde.Text = New Date(Date.Now.Date.Year, 1, 1) Then
                        btnAño.Enabled = False
                        btnAño.BackColor = Color.FromArgb(190, 140, 5)
                    ElseIf (txtFecDesde.Text = Date.Now.AddDays(1 - Date.Now.Date.DayOfWeek).Date And Date.Now.Date.DayOfWeek <> DayOfWeek.Sunday) Or (txtFecDesde.Text = Date.Now.AddDays(-6).Date And Date.Now.Date.DayOfWeek = DayOfWeek.Sunday) Then
                        btnSemana.Enabled = False
                        btnSemana.BackColor = Color.FromArgb(190, 140, 5)
                    End If

                    Await CargarDetalle(txtFecDesde.Text, txtFecHasta.Text)
                Else
                    Notificaciones.MsgBox("Fecha Hasta no puede ser menor que Fecha Desde.", Botones.OK, Iconos.ALERTA)

                    txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
                    txtFecHasta.Select()
                End If
            Else
                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

                txtFecDesde.SelectionLength = Len(txtFecDesde.Text)
                txtFecDesde.Select()
            End If
        Else
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

            txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
            txtFecHasta.Select()
        End If
    End Sub

    Private Sub setEnabled(enabled As Boolean)
        If Date.Now.Date.Day = 1 Then
            btnMes.Enabled = False
        Else
            btnMes.Enabled = enabled
        End If

        If Date.Now.Date.DayOfWeek = DayOfWeek.Monday Then
            btnSemana.Enabled = False
        Else
            btnSemana.Enabled = enabled
        End If

        If Date.Now.Date.Day = 1 And Date.Now.Date.Month = 1 Then
            btnAño.Enabled = False
        Else
            btnAño.Enabled = enabled
        End If

        If txtFecDesde.Text = "**/**/****" And txtFecHasta.Text = "**/**/****" Then
            btnHistorico.Enabled = False
        Else
            btnHistorico.Enabled = enabled
        End If

        btnHoy.Enabled = enabled
    End Sub

    Private Sub setColor(color As Color)
        If Date.Now.Date.Day = 1 Then
            btnMes.BackColor = Color.FromArgb(35, 35, 35)
        Else
            btnMes.BackColor = color
        End If

        If Date.Now.Date.DayOfWeek = DayOfWeek.Monday Then
            btnSemana.BackColor = Color.FromArgb(35, 35, 35)
        Else
            btnSemana.BackColor = color
        End If

        If Date.Now.Date.Day = 1 And Date.Now.Date.Month = 1 Then
            btnAño.BackColor = Color.FromArgb(35, 35, 35)
        Else
            btnAño.BackColor = color
        End If

        If txtFecDesde.Text = "**/**/****" And txtFecHasta.Text = "**/**/****" Then
            btnHistorico.BackColor = Color.FromArgb(35, 35, 35)
        Else
            btnHistorico.BackColor = color
        End If

        btnHoy.BackColor = color
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub btnFiltar_Click(sender As Object, e As EventArgs) Handles btnFiltar.Click
        If txtFecDesde.Text <> "**/**/****" Then
            If txtFecHasta.Text <> "**/**/****" Then
                ActualizarBusqueda()
            Else
                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

                txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
                txtFecHasta.Select()
            End If
        Else
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

            txtFecDesde.SelectionLength = Len(txtFecDesde.Text)
            txtFecDesde.Select()
        End If
    End Sub

    Private Sub btnHoy_Click(sender As Object, e As EventArgs) Handles btnHoy.Click
        txtFecDesde.Text = Date.Now.Date
        txtFecHasta.Text = Date.Now.Date

        ActualizarBusqueda()
    End Sub

    Private Sub btnMes_Click(sender As Object, e As EventArgs) Handles btnMes.Click
        txtFecDesde.Text = New Date(Date.Now.Date.Year, Date.Now.Date.Month, 1)
        txtFecHasta.Text = Date.Now.Date

        ActualizarBusqueda()
    End Sub

    Private Sub btnSemana_Click(sender As Object, e As EventArgs) Handles btnSemana.Click
        If Date.Now.Date.DayOfWeek = DayOfWeek.Sunday Then
            txtFecDesde.Text = Date.Now.AddDays(-6).Date
        Else
            txtFecDesde.Text = Date.Now.AddDays(1 - Date.Now.Date.DayOfWeek).Date
        End If

        txtFecHasta.Text = Date.Now.Date

        ActualizarBusqueda()
    End Sub

    Private Sub btnAño_Click(sender As Object, e As EventArgs) Handles btnAño.Click
        txtFecDesde.Text = New Date(Date.Now.Date.Year, 1, 1)
        txtFecHasta.Text = Date.Now.Date

        ActualizarBusqueda()
    End Sub

    Private Sub btnHistorico_Click(sender As Object, e As EventArgs) Handles btnHistorico.Click
        txtFecDesde.Text = "**/**/****"
        txtFecHasta.Text = "**/**/****"

        ActualizarBusqueda()
    End Sub

    Private Sub bnfChkFactura_OnChange(sender As Object, e As EventArgs) Handles bnfChkFactura.OnChange
        ActualizarBusqueda()
    End Sub

    Private Sub bnfChkRecibo_OnChange(sender As Object, e As EventArgs) Handles bnfChkRecibo.OnChange
        ActualizarBusqueda()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvDetalle.Rows.Count > 0 Then
            UtilidadesVarias.Escalar(frmReporte)

            frmReporte.rvReporte.Reset()

            frmReporte.rvReporte.LocalReport.ReportPath = Reportes.RPT_CUENTA_CORRIENTE_COMPRA

            frmReporte.rvReporte.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

            frmReporte.rvReporte.LocalReport.DataSources.Clear()
            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEmpresa", New BindingSource() With {.DataSource = DatosSesion._Empresa}))
            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsProveedor", New BindingSource() With {.DataSource = infoProveedor}))
            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsCtaCteCompra", New BindingSource() With {.DataSource = listadoCtaCrtCompra}))
            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsComprobante", New BindingSource() With {.DataSource = New Comprobantes()}))

            frmReporte.rvReporte.LocalReport.SetParameters(New List(Of Microsoft.Reporting.WinForms.ReportParameter) From {
                New Microsoft.Reporting.WinForms.ReportParameter("fechaDesde", txtFecDesde.Text),
                New Microsoft.Reporting.WinForms.ReportParameter("fechaHasta", txtFecHasta.Text),
                New Microsoft.Reporting.WinForms.ReportParameter("TC", txtTipCambio.Text)
            })

            frmReporte.rvReporte.RefreshReport()
            frmReporte.ShowDialog()
        Else
            Notificaciones.MsgBox("No es posible Imprimir una tabla vacia.", Botones.OK, Iconos.ALERTA)
        End If
    End Sub

    Private Sub dgvDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellClick
        If e.RowIndex < 0 Then
            dgvDetalle.CurrentCell = Nothing
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtFecDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecDesde.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
            txtFecHasta.Select()
        End If
    End Sub

    Private Sub txtFecHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecHasta.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnFiltar.Select()
        End If
    End Sub

    Private Sub txtTC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipCambio.KeyPress
        If e.KeyChar = ChrW(46) And Not txtTipCambio.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCtaProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCtaProv.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtCtaProv.Text = "" Then
                frmListaProveedores.Dispose()
                UtilidadesVarias.Escalar(frmListaProveedores)
                Dim Result As DialogResult = frmListaProveedores.ShowDialog()

                If Result = DialogResult.OK Then
                    txtCtaProv.Text = frmListaProveedores.infoProveedor.IdProveedor
                End If
            End If
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub txtFecDesde_TextChanged(sender As Object, e As EventArgs) Handles txtFecDesde.TextChanged
        If txtFecDesde.Text = "" Then
            If bnfCardFec.Enabled = True Then
                txtFecDesde.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtFecDesde.SelectionLength = Len(txtFecDesde.Text)
                txtFecDesde.Select()
            End If
        End If
    End Sub

    Private Sub txtFecHasta_TextChanged(sender As Object, e As EventArgs) Handles txtFecHasta.TextChanged
        If txtFecHasta.Text = "" Then
            If bnfCardFec.Enabled = True Then
                txtFecHasta.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
                txtFecHasta.Select()
            End If
        End If
    End Sub

    Private Sub txtTC_TextChanged(sender As Object, e As EventArgs) Handles txtTipCambio.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtTipCambio, AddressOf txtTC_TextChanged, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

        If txtTipCambio.Text <> "" Then
            If txtSaldoP.Text <> "" Then
                txtSaldolC.Text = Format(UtilidadesVarias.SoloNumeros(txtSaldoP.Text) * UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
            End If

            If UtilidadesVarias.SoloNumeros(txtTipCambio.Text) = DatosSesion._UltimaParidadCambiaria.CotizacionVenta Then
                lblBanco.Text = "BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha
                txtTipCambio.SelectionLength = txtTipCambio.TextLength
            Else
                lblBanco.Text = ""
            End If
        Else
            If bnfCardDetalle.Enabled = True Then
                txtTipCambio.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
            Else
                lblBanco.Text = ""
            End If
        End If
    End Sub

    Private Sub txtCtaProv_TextChanged(sender As Object, e As EventArgs) Handles txtCtaProv.TextChanged
        txtRSprov.Text = ""
        txtDirec.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtCuit.Text = ""
        txtIIBB.Text = ""
        txtTE.Text = ""

        If txtCtaProv.Text <> "" Then
            For Each item In listadoProveedores
                If item.IdProveedor = txtCtaProv.Text Then
                    infoProveedor = item

                    txtDirec.Text = item.Direccion
                    txtLoc.Text = item.Localidad
                    txtProv.Text = item.Provincia
                    txtCuit.Text = item.CUIT
                    txtIIBB.Text = item.IIBB
                    txtTE.Text = item.Telefono
                    txtRSprov.Text = item.RazonSocial

                    Exit For
                End If
            Next
        End If

        If txtRSprov.Text <> "" Then
            ActualizarBusqueda()

            txtCtaProv.SelectionLength = Len(txtCtaProv.Text)
            txtCtaProv.Select()
        Else
            UtilidadesDGV.DescargarDGV(dgvDetalle)

            bnfCardDetalle.Enabled = False

            txtSaldolC.Text = ""
            txtSaldoP.Text = ""
            txtTipCambio.Text = ""
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtFecDesde_Validated(sender As Object, e As EventArgs) Handles txtFecDesde.Validated
        If txtFecDesde.Text <> "**/**/****" Then
            If Not IsDate(txtFecDesde.Text) Then
                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

                txtFecDesde.Text = ""
                txtFecDesde.Select()
            Else
                txtFecDesde.Text = Format(CDate(txtFecDesde.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtFecHasta_Validated(sender As Object, e As EventArgs) Handles txtFecHasta.Validated
        If txtFecHasta.Text <> "**/**/****" Then
            If Not IsDate(txtFecHasta.Text) Then
                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

                txtFecHasta.Text = ""
                txtFecHasta.Select()
            Else
                txtFecHasta.Text = Format(CDate(txtFecHasta.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub


    Private Sub txtTC_Validated(sender As Object, e As EventArgs) Handles txtTipCambio.Validated
        If txtTipCambio.Text <> "" Then
            txtTipCambio.Text = Format(UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
    End Sub

    Private Sub txtCtaProv_Validated(sender As Object, e As EventArgs) Handles txtCtaProv.Validated
        If txtCtaProv.Text <> "" And txtRSprov.Text = "" Then
            Notificaciones.MsgBox("No existe un Proveedor con ese numero de cuenta.", Botones.OK, Iconos.ALERTA)

            UtilidadesDGV.DescargarDGV(dgvDetalle)

            txtSaldolC.Text = ""
            txtSaldoP.Text = ""
            txtTipCambio.Text = ""

            bnfCardDetalle.Enabled = False

            txtCtaProv.SelectionLength = Len(txtCtaProv.Text)
            txtCtaProv.Select()
        Else
            bnfCardDetalle.Enabled = True
        End If
    End Sub
#End Region
End Class