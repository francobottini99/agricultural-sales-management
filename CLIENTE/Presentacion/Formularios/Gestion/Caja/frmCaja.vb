Imports Procesos

Public Class frmCaja
    Private listCompletaValores As List(Of ValoresEnCartera)
    Private listCompletaCaja As List(Of Caja)
    Private _TareasCaja As TareasCaja
    Private _TareasValores As TareasValoresEnCartera
    Private _TareasMovimientoValores As TareasMovimientoValores

#Region "ANIMACION BOTONES"
    Private Sub btnNuevo_GotFocus(sender As Object, e As EventArgs) Handles btnNuevo.GotFocus
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevo_LostFocus(sender As Object, e As EventArgs) Handles btnNuevo.LostFocus
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnNuevo_MouseEnter(sender As Object, e As EventArgs) Handles btnNuevo.MouseEnter
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevo.MouseLeave
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminar_GotFocus(sender As Object, e As EventArgs) Handles btnEliminar.GotFocus
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminar_LostFocus(sender As Object, e As EventArgs) Handles btnEliminar.LostFocus
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminar_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminar.MouseEnter
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
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

#Region "LOAD FORM"
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "SIGEVA -> " & Date.Now & " -> Ingreso a CAJA"

        _TareasCaja = New TareasCaja()
        _TareasValores = New TareasValoresEnCartera()
        _TareasMovimientoValores = New TareasMovimientoValores()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvValoresCartera)
        UtilidadesDGV.FormatoDGVGeneral(dgvMovimientos)

        ConfigDgvMovimientos()
        ConfigDgvValoresCartera()

        setEnabled(True)
        setColor(Color.FromArgb(100, 100, 100))

        btnHoy.Enabled = False
        btnHoy.BackColor = Color.FromArgb(190, 140, 5)

        txtFecDesde.Text = Date.Now.Date
        txtFecHasta.Text = Date.Now.Date

        Await CargarCaja(txtFecDesde.Text, txtFecHasta.Text)
        Await CargarValoresEnCartera()
        Await Importe()

        txtTC.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
        lblBanco.Text = "BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha

        btnNuevo.Select()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Async Sub ActualizarBusqueda()
        If IsDate(txtFecDesde.Text) Then
            If IsDate(txtFecHasta.Text) Then
                If CDate(txtFecHasta.Text) >= CDate(txtFecDesde.Text) Then
                    If txtFecDesde.Text = Date.Now.Date And txtFecHasta.Text = Date.Now.Date Then
                        setEnabled(True)
                        setColor(Color.FromArgb(100, 100, 100))

                        btnHoy.Enabled = False
                        btnHoy.BackColor = Color.FromArgb(190, 140, 5)
                    ElseIf txtFecDesde.Text = New Date(Date.Now.Date.Year, Date.Now.Date.Month, 1) Then
                        setEnabled(True)
                        setColor(Color.FromArgb(100, 100, 100))

                        btnMes.Enabled = False
                        btnMes.BackColor = Color.FromArgb(190, 140, 5)
                    ElseIf txtFecDesde.Text = New Date(Date.Now.Date.Year, 1, 1) Then
                        setEnabled(True)
                        setColor(Color.FromArgb(100, 100, 100))

                        btnAño.Enabled = False
                        btnAño.BackColor = Color.FromArgb(190, 140, 5)
                    ElseIf (txtFecDesde.Text = Date.Now.AddDays(1 - Date.Now.Date.DayOfWeek).Date And Date.Now.Date.DayOfWeek <> DayOfWeek.Sunday) Or (txtFecDesde.Text = Date.Now.AddDays(-6).Date And Date.Now.Date.DayOfWeek = DayOfWeek.Sunday) Then
                        setEnabled(True)
                        setColor(Color.FromArgb(100, 100, 100))

                        btnSemana.Enabled = False
                        btnSemana.BackColor = Color.FromArgb(190, 140, 5)
                    Else
                        setEnabled(True)
                        setColor(Color.FromArgb(100, 100, 100))
                    End If

                    Await CargarCaja(txtFecDesde.Text, txtFecHasta.Text)
                    Await CargarValoresEnCartera()
                    Await Importe()

                    btnNuevo.Select()
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

    Private Async Function Importe() As Task
        Dim saldoCajaPesos As Double = Await _TareasCaja.SaldoPesos()

        If Not IsNothing(saldoCajaPesos) Then
            Dim saldoCajaDolares As Double = Await _TareasCaja.SaldoDolares()

            If Not IsNothing(saldoCajaDolares) Then
                Dim saldoValoresDolares As Double = Await _TareasValores.SaldoDolares()

                If Not IsNothing(saldoValoresDolares) Then
                    Dim saldoValoresPesos As Double = Await _TareasValores.SaldoPesos()

                    If Not IsNothing(saldoValoresDolares) Then
                        txtSaldoEfectivoDolar.Text = Format(saldoCajaDolares - saldoValoresDolares, "U$S #,##0.00")
                        txtSaldoEfectivoPeso.Text = Format(saldoCajaPesos - saldoValoresPesos, "$ #,##0.00")
                        txtSaldoChqDolar.Text = Format(saldoValoresDolares, "U$S #,##0.00")
                        txtSaldoChqPeso.Text = Format(saldoValoresPesos, "$ #,##0.00")
                        txtSaldoTotalDolar.Text = Format(saldoCajaDolares, "U$S #,##0.00")
                        txtSaldoTotalPeso.Text = Format(saldoCajaPesos, "$ #,##0.00")

                        Notificaciones.cerrarFormProceso()
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(_TareasValores.Err.Descripcion, Botones.OK, Iconos.ERR)
                    End If
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(_TareasValores.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            Else
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(_TareasCaja.Err.Descripcion, Botones.OK, Iconos.ERR)
            End If
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasCaja.Err.Descripcion, Botones.OK, Iconos.ERR)
        End If
    End Function

    Private Async Function CargarCaja(fecDesde As Date, fecHasta As Date) As Task
        Notificaciones.arbirFormProceso("CARGANDO DETALLE")
        UtilidadesDGV.DescargarDGV(dgvMovimientos)

        listCompletaCaja = Await _TareasCaja.ListadoPorFechas(fecDesde, fecHasta)

        If Not IsNothing(listCompletaCaja) Then
            If bnfChkEfectivo.Checked And Not bnfChkValores.Checked Then
                For i As Integer = listCompletaCaja.Count - 1 To 0 Step -1
                    If listCompletaCaja.Item(i).Descripcion <> "EFECTIVO" Then
                        listCompletaCaja.Remove(listCompletaCaja.Item(i))
                    End If
                Next
            ElseIf bnfChkValores.Checked And Not bnfChkEfectivo.Checked Then
                For i As Integer = listCompletaCaja.Count - 1 To 0 Step -1
                    If listCompletaCaja.Item(i).Descripcion = "EFECTIVO" Then
                        listCompletaCaja.Remove(listCompletaCaja.Item(i))
                    End If
                Next
            ElseIf Not bnfChkValores.Checked And Not bnfChkEfectivo.Checked Then
                listCompletaCaja.Clear()
            End If

            TareasCaja.LlenarDGV(dgvMovimientos, listCompletaCaja)

            UtilidadesDGV.CabeceraDGV(dgvMovimientos)
        ElseIf _TareasCaja.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasCaja.Err.Descripcion, Botones.OK, Iconos.ERR)
        End If
    End Function

    Private Async Function CargarValoresEnCartera() As Task
        UtilidadesDGV.DescargarDGV(dgvValoresCartera)

        listCompletaValores = Await _TareasValores.ListadoDisponible()

        If Not IsNothing(listCompletaValores) Then
            TareasValoresEnCartera.LlenarDGV(dgvValoresCartera, listCompletaValores)

            UtilidadesDGV.CabeceraDGV(dgvValoresCartera)
        ElseIf _TareasValores.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            MsgBox(_TareasValores.Err.Descripcion)
            Notificaciones.MsgBox(_TareasValores.Err.Descripcion, Botones.OK, Iconos.ERR)
        End If
    End Function

    Private Sub ConfigDgvMovimientos()
        dgvMovimientos.ColumnCount = 11
        dgvMovimientos.Columns(0).Name = "idCaja"
        dgvMovimientos.Columns(1).Name = "Fecha"
        dgvMovimientos.Columns(2).Name = "Movimiento"
        dgvMovimientos.Columns(3).Name = "Comprobante"
        dgvMovimientos.Columns(4).Name = "Detalle"
        dgvMovimientos.Columns(5).Name = "Moneda"
        dgvMovimientos.Columns(6).Name = "Ingreso"
        dgvMovimientos.Columns(7).Name = "Egreso"
        dgvMovimientos.Columns(8).Name = "Observaciones"
        dgvMovimientos.Columns(9).Name = "Eliminado"
        dgvMovimientos.Columns(10).Name = "Usuarios_idUsuarios"

        dgvMovimientos.Columns("idCaja").Visible = False
        dgvMovimientos.Columns("Movimiento").Visible = False
        dgvMovimientos.Columns("Moneda").Visible = False
        dgvMovimientos.Columns("Eliminado").Visible = False
        dgvMovimientos.Columns("Usuarios_idUsuarios").Visible = False

        dgvMovimientos.Columns("Fecha").HeaderText = "FECHA"
        dgvMovimientos.Columns("Movimiento").HeaderText = "MOVIMIENTO"
        dgvMovimientos.Columns("Comprobante").HeaderText = "COMPROBANTE"
        dgvMovimientos.Columns("Detalle").HeaderText = "DETALLE"
        dgvMovimientos.Columns("Moneda").HeaderText = "MONEDA"
        dgvMovimientos.Columns("Ingreso").HeaderText = "INGRESO"
        dgvMovimientos.Columns("Egreso").HeaderText = "EGRESO"
        dgvMovimientos.Columns("Observaciones").HeaderText = "OBSERVACIONES"

        dgvMovimientos.Columns("Fecha").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvMovimientos.Columns("Movimiento").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvMovimientos.Columns("Comprobante").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvMovimientos.Columns("Detalle").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvMovimientos.Columns("Moneda").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvMovimientos.Columns("Ingreso").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvMovimientos.Columns("Egreso").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvMovimientos.Columns("Observaciones").SortMode = DataGridViewColumnSortMode.NotSortable

        dgvMovimientos.Columns("idCaja").DisplayIndex = 0
        dgvMovimientos.Columns("Fecha").DisplayIndex = 1
        dgvMovimientos.Columns("Movimiento").DisplayIndex = 2
        dgvMovimientos.Columns("Comprobante").DisplayIndex = 3
        dgvMovimientos.Columns("Detalle").DisplayIndex = 4
        dgvMovimientos.Columns("Moneda").DisplayIndex = 5
        dgvMovimientos.Columns("Ingreso").DisplayIndex = 6
        dgvMovimientos.Columns("Egreso").DisplayIndex = 7
        dgvMovimientos.Columns("Observaciones").DisplayIndex = 8
        dgvMovimientos.Columns("Eliminado").DisplayIndex = 9
        dgvMovimientos.Columns("Usuarios_idUsuarios").DisplayIndex = 10

        dgvMovimientos.Columns("Ingreso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvMovimientos.Columns("Egreso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvMovimientos.ColumnHeadersVisible = False
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

        btnHoy.BackColor = color
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Async Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmMovimientosCaja.Dispose()
        UtilidadesVarias.Escalar(frmMovimientosCaja)
        dgvMovimientos.CurrentCell = Nothing

        If frmMovimientosCaja.ShowDialog() = DialogResult.OK Then
            Await CargarCaja(txtFecDesde.Text, txtFecHasta.Text)
            Await CargarValoresEnCartera()
            Await Importe()
        End If

        btnNuevo.Select()
    End Sub

    Private Sub btnFiltar_Click(sender As Object, e As EventArgs) Handles btnFiltar.Click
        ActualizarBusqueda()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        frmPpal.AbrirFrm(frmInicio)
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

    Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvMovimientos.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun movimiento de la lista.", Botones.OK, Iconos.ALERTA)
        Else
            If dgvMovimientos.CurrentRow.Cells("Comprobante").Value <> "MOVIMIENTO MANUAL" Then
                Notificaciones.MsgBox("Solo puedes eliminar movimientos que se generaron manualmente.", Botones.OK, Iconos.ALERTA)
            Else
                Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Movimiento de Caja ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                If resp = DialogResult.OK Then
                    Notificaciones.arbirFormProceso("ELIMINANDO MOVIMIENTO DE CAJA")

                    If dgvMovimientos.CurrentRow.Cells("Detalle").Value = "EFECTIVO" Then
                        If Await _TareasCaja.Eliminar(dgvMovimientos.CurrentRow.Cells("idCaja").Value) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Movimiento de caja eliminado con exito !", Botones.OK, Iconos.OK)

                            Await CargarCaja(txtFecDesde.Text, txtFecHasta.Text)
                            Await CargarValoresEnCartera()
                            Await Importe()
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(_TareasCaja.Err.Descripcion, Botones.OK, Iconos.ERR)
                        End If
                    Else
                        Dim respConf As DialogResult = DialogResult.OK

                        If dgvMovimientos.CurrentRow.Cells("Movimiento").Value = "INGRESO" Then
                            For Each item As DataGridViewRow In dgvMovimientos.Rows
                                If item.Cells("Detalle").Value = dgvMovimientos.CurrentRow.Cells("Detalle").Value Then
                                    If item.Cells("Comprobante").Value = "MOVIMIENTO MANUAL" Then
                                        respConf = Notificaciones.MsgBox("El valor que va a eliminar ya se asentó como egresado, por lo tanto los dos movimientos (ingreso / egreso) se eliminaran, desea continuar con la operacion ?", Botones.OK_CANCEL, Iconos.INFORMACION)
                                    Else
                                        Notificaciones.MsgBox("No se puede eliminar el movimiento por que ya fue egresado mediante un comprobante contable.", Botones.OK, Iconos.ERR)
                                        respConf = DialogResult.Cancel
                                    End If

                                    Exit For
                                End If
                            Next
                        End If

                        If respConf = DialogResult.OK Then
                            If Await _TareasMovimientoValores.Servicio_Eliminar(dgvMovimientos.CurrentRow.Cells("idCaja").Value) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Movimiento de caja eliminado con exito !", Botones.OK, Iconos.OK)

                                Await CargarCaja(txtFecDesde.Text, txtFecHasta.Text)
                                Await CargarValoresEnCartera()
                                Await Importe()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(_TareasMovimientoValores.Err.Descripcion, Botones.OK, Iconos.ERR)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvMovimientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovimientos.CellClick
        If e.RowIndex < 0 Then
            dgvMovimientos.CurrentCell = Nothing
        End If
    End Sub

    Private Async Sub bnfChkEfectivo_OnChange(sender As Object, e As EventArgs) Handles bnfChkEfectivo.OnChange
        Await CargarCaja(txtFecDesde.Text, txtFecHasta.Text)
        Await CargarValoresEnCartera()
        Await Importe()
    End Sub

    Private Async Sub bnfChkValores_OnChange(sender As Object, e As EventArgs) Handles bnfChkValores.OnChange
        Await CargarCaja(txtFecDesde.Text, txtFecHasta.Text)
        Await CargarValoresEnCartera()
        Await Importe()
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
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtFecDesde_Validated(sender As Object, e As EventArgs) Handles txtFecDesde.Validated
        If Not IsDate(txtFecDesde.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

            txtFecDesde.Text = ""
        Else
            txtFecDesde.Text = Format(CDate(txtFecDesde.Text), "dd/MM/yyyy")
        End If
    End Sub

    Private Sub txtFecHasta_Validated(sender As Object, e As EventArgs) Handles txtFecHasta.Validated
        If Not IsDate(txtFecHasta.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

            txtFecHasta.Text = ""
        Else
            txtFecHasta.Text = Format(CDate(txtFecHasta.Text), "dd/MM/yyyy")
        End If
    End Sub
#End Region

End Class