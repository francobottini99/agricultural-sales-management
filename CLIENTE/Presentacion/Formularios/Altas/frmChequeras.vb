Imports Procesos

Public Class frmChequeras
    Private listCompleta As List(Of Chequeras)
    Private Bancos As List(Of Bancos)

    Private Tareas As TareasChequera
    Private TareasBco As TareasBancos

#Region "ANIMACION BOTONES"
    Private Sub btnNuevo_GotFocus(sender As Object, e As EventArgs)
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevo_LostFocus(sender As Object, e As EventArgs)
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnNuevo_MouseEnter(sender As Object, e As EventArgs)
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevo_MouseLeave(sender As Object, e As EventArgs)
        If btnNuevo.Enabled = True Then
            btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificar_GotFocus(sender As Object, e As EventArgs)
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificar_LostFocus(sender As Object, e As EventArgs)
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificar_MouseEnter(sender As Object, e As EventArgs)
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificar_MouseLeave(sender As Object, e As EventArgs)
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnGuardar_GotFocus(sender As Object, e As EventArgs)
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnGuardar_LostFocus(sender As Object, e As EventArgs)
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnGuardar_MouseEnter(sender As Object, e As EventArgs)
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs)
        If btnGuardar.Enabled = True Then
            btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCancelar_GotFocus(sender As Object, e As EventArgs)
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCancelar_LostFocus(sender As Object, e As EventArgs)
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCancelar_MouseEnter(sender As Object, e As EventArgs)
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As Object, e As EventArgs)
        If btnCancelar.Enabled = True Then
            btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminar_GotFocus(sender As Object, e As EventArgs)
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminar_LostFocus(sender As Object, e As EventArgs)
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminar_MouseEnter(sender As Object, e As EventArgs)
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs)
        If btnEliminar.Enabled = True Then
            btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

#End Region

#Region "METODOS PRIVADOS"
    Private Sub Activar()
        UtilidadesDGV.DescargarDGV(dgvChq)
        pnlContendorDatos.Enabled = True

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False

        btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
        btnModificar.BackColor = Color.FromArgb(35, 35, 35)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminar.BackColor = Color.FromArgb(35, 35, 35)

        txtFecha.SelectionLength = txtFecha.TextLength
        txtFecha.Select()
    End Sub

    Private Async Sub CancelarAsync()
        Notificaciones.arbirFormProceso("CARGANDO CHEQUERAS")

        UtilidadesDGV.DescargarDGV(dgvChq)

        pnlContendorDatos.Enabled = False

        UtilidadesTXT.VaciarTxt(Me)

        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = True

        btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminar.BackColor = Color.FromArgb(100, 100, 100)

        Bancos = Await TareasBco.ListadoCompleto()

        cbxBanco.Text = ""
        cbxBanco.Items.Clear()
        For Each Bc In Bancos
            cbxBanco.Items.Add(Bc.Nombre)
        Next

        listCompleta = Await Tareas.ListadoCompleto()

        If Not IsNothing(listCompleta) Then
            UtilidadesDGV.DescargarDGV(dgvChq)

            TareasChequera.LlenarDGV(dgvChq, listCompleta)

            UtilidadesDGV.CabeceraDGV(dgvChq)

            Notificaciones.cerrarFormProceso()

            btnNuevo.Select()
        ElseIf Tareas.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        Else
            Notificaciones.cerrarFormProceso()
        End If

        btnNuevo.Select()
    End Sub

    Private Sub ConfigDGV_Cheqauera()
        dgvChq.ColumnCount = 12
        dgvChq.Columns(0).Name = "idChequera"
        dgvChq.Columns(1).Name = "NroCuenta"
        dgvChq.Columns(2).Name = "FechaAlta"
        dgvChq.Columns(3).Name = "Banco"
        dgvChq.Columns(4).Name = "NroChqInicial"
        dgvChq.Columns(5).Name = "CantidadChq"
        dgvChq.Columns(6).Name = "ChqEmitidos"
        dgvChq.Columns(7).Name = "ChqAnulados"
        dgvChq.Columns(8).Name = "ChqDisponibles"
        dgvChq.Columns(9).Name = "Observaciones"
        dgvChq.Columns(10).Name = "Eliminada"
        dgvChq.Columns(11).Name = "Usuarios_idUsuarios"


        dgvChq.Columns("idChequera").Visible = False
        dgvChq.Columns("Eliminada").Visible = False
        dgvChq.Columns("Usuarios_idUsuarios").Visible = False

        dgvChq.Columns("FechaAlta").HeaderText = "ALTA"
        dgvChq.Columns("NroCuenta").HeaderText = "CUENTA"
        dgvChq.Columns("Banco").HeaderText = "BCO EMISOR"
        dgvChq.Columns("NroChqInicial").HeaderText = "NUMERO CHQ INIC"
        dgvChq.Columns("CantidadChq").HeaderText = "CANTIDAD CHQ"
        dgvChq.Columns("ChqEmitidos").HeaderText = "CHQ EMITIDOS"
        dgvChq.Columns("ChqAnulados").HeaderText = "CHQ ANULADOS"
        dgvChq.Columns("ChqDisponibles").HeaderText = "CHQ DISPONIBLES"
        dgvChq.Columns("Observaciones").HeaderText = "OBSERVACIONES"

        dgvChq.Columns("idChequera").DisplayIndex = 0
        dgvChq.Columns("NroCuenta").DisplayIndex = 1
        dgvChq.Columns("FechaAlta").DisplayIndex = 2
        dgvChq.Columns("Banco").DisplayIndex = 3
        dgvChq.Columns("NroChqInicial").DisplayIndex = 4
        dgvChq.Columns("CantidadChq").DisplayIndex = 5
        dgvChq.Columns("ChqEmitidos").DisplayIndex = 6
        dgvChq.Columns("ChqAnulados").DisplayIndex = 7
        dgvChq.Columns("ChqDisponibles").DisplayIndex = 8
        dgvChq.Columns("Observaciones").DisplayIndex = 9
        dgvChq.Columns("Eliminada").DisplayIndex = 10
        dgvChq.Columns("Usuarios_idUsuarios").DisplayIndex = 11

        dgvChq.Columns("FechaAlta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvChq.Columns("NroCuenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvChq.Columns("Banco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvChq.Columns("NroChqInicial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvChq.Columns("CantidadChq").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChq.Columns("ChqEmitidos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChq.Columns("ChqAnulados").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChq.Columns("ChqDisponibles").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChq.Columns("Observaciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvChq.ColumnHeadersVisible = False
    End Sub

#End Region

#Region "EVENTO LOAD"
    Private Sub FrmChequera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a Alta de Chequeras"
        Tareas = New TareasChequera()
        TareasBco = New TareasBancos()

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        ConfigDGV_Cheqauera()
        UtilidadesDGV.FormatoDGVGeneral(dgvChq)

        CancelarAsync()
    End Sub

#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNroCta.SelectionLength = Len(txtNroCta.Text)
            txtNroCta.Select()
        End If
        If Asc(e.KeyChar) <> Keys.Enter Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNroCta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroCta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxBanco.SelectionLength = Len(cbxBanco.Text)
            cbxBanco.Select()
        End If
    End Sub

    Private Sub cbxBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxBanco.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNroChq.SelectionLength = txtNroChq.TextLength
            txtNroChq.Select()
        End If
    End Sub

    Private Sub txtNroChq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroChq.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtChqCant.SelectionLength = txtChqCant.TextLength
            txtChqCant.Select()
        End If
    End Sub

    Private Sub txtChqCant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChqCant.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObserv.SelectionLength = txtObserv.TextLength
            txtObserv.Select()
        End If
    End Sub

    Private Sub txtObserv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObserv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CancelarAsync()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click

        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Async Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNroCta.Text = "" Then
            Notificaciones.MsgBox("""NUMERO DE CUENTA"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
            txtNroCta.SelectionLength = Len(txtNroCta.Text)
        Else
            If cbxBanco.Text = "" Then
                Notificaciones.MsgBox("""BANCO"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                cbxBanco.SelectionLength = Len(cbxBanco.Text)
            Else
                If txtNroChq.Text = "" Then
                    Notificaciones.MsgBox("""NUMERO INICIAL DE CHEQUE"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                    txtNroChq.SelectionLength = txtNroChq.TextLength
                    txtNroChq.Select()
                Else
                    If txtChqCant.Text = "" Then
                        Notificaciones.MsgBox("""CANTIDAD DE CHEQUES"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                        txtChqCant.SelectionLength = txtChqCant.TextLength
                        txtChqCant.Select()
                    Else
                        Dim _Chqra As New Chequeras(txtNroCta.Text, txtFecha.Text, cbxBanco.Text, txtNroChq.Text,
                                                     txtChqCant.Text, txtObserv.Text)

                        If txtOrigen.Text = "Nuevo" Then
                            Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Chequera ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                Notificaciones.arbirFormProceso("GUARDANDO CHEQUERA")

                                If Await Tareas.Servicio_Insertar(_Chqra) Then
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox("Chequera guardada con exito !", Botones.OK, Iconos.OK)

                                    CancelarAsync()
                                Else
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

                                End If
                            End If
                        ElseIf txtOrigen.Text = "Modificar" Then
                            Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Chequera ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                Notificaciones.arbirFormProceso("MODIFICANDO CHEQUERA")

                                _Chqra.IdChequera = CInt(txtIdChq.Text)

                                If Await Tareas.Servicio_Modificar(_Chqra) Then
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox("Chequera modificada con exito !", Botones.OK, Iconos.OK)

                                    CancelarAsync()
                                Else
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdChq.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado una Chequera.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Chequera ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                If dgvChq.CurrentRow.Cells("ChqEmitidos").Value > 0 Then
                    Dim resp1 As DialogResult = Notificaciones.MsgBox("Esta chequera tiene cheques emitidos, si la elimina, elimina también los cheques asociados a la misma, seguro eliminar ?", Botones.OK_CANCEL, Iconos.ALERTA)
                    If resp1 = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("ELIMINANDO CHEQUERA")

                        If Await Tareas.Servicio_Eliminar(txtIdChq.Text) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Chequera eliminada con exito !", Botones.OK, Iconos.OK)

                            CancelarAsync()
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                        End If

                    End If
                Else
                    Notificaciones.arbirFormProceso("ELIMINANDO CHEQUERA")

                    If Await Tareas.Servicio_Eliminar(txtIdChq.Text) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox("Chequera eliminada con exito !", Botones.OK, Iconos.OK)

                        CancelarAsync()
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                    End If
                End If

            End If

        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdChq.Text = "" Then
            Notificaciones.MsgBox("No hay Chequera seleccionada para modificar", Botones.OK, Iconos.OK)
        Else
            If dgvChq.CurrentRow.Cells("ChqEmitidos").Value > 0 Then

                Notificaciones.MsgBox("No puede modificar una chequera que tiene cheques emitidos ! ", Botones.OK, Iconos.INFORMACION)

            Else
                txtOrigen.Text = "Modificar"

                txtFecha.Text = dgvChq.CurrentRow.Cells("FechaAlta").Value
                txtNroCta.Text = dgvChq.CurrentRow.Cells("NroCuenta").Value
                cbxBanco.Text = dgvChq.CurrentRow.Cells("Banco").Value
                txtNroChq.Text = dgvChq.CurrentRow.Cells("NroChqInicial").Value
                txtChqCant.Text = dgvChq.CurrentRow.Cells("CantidadChq").Value
                txtCantEm.Text = dgvChq.CurrentRow.Cells("ChqEmitidos").Value
                txtCantAn.Text = dgvChq.CurrentRow.Cells("ChqAnulados").Value
                txtObserv.Text = dgvChq.CurrentRow.Cells("Observaciones").Value

                Activar()
            End If
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtOrigen.Text = "Nuevo"

        Activar()

        txtFecha.Text = Format(Date.Now.Date, "dd/MM/yyyy")
        txtNroCta.Select()
    End Sub

    Private Sub DgvComprobantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChq.CellClick
        If e.RowIndex > -1 Then
            txtIdChq.Text = dgvChq.CurrentRow.Cells("idChequera").Value
            btnModificar.Select()
        Else
            dgvChq.CurrentCell = Nothing
        End If
    End Sub

#End Region

End Class