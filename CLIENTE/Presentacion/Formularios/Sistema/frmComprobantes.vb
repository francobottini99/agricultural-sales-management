Imports Procesos

Public Class frmComprobantes
    Private listCompleta As List(Of Comprobantes)
    Private Tareas As TareasComprobantes

#Region "ANIMACIONES BOTONES"
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

    Private Sub btnModificar_GotFocus(sender As Object, e As EventArgs) Handles btnModificar.GotFocus
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificar_LostFocus(sender As Object, e As EventArgs) Handles btnModificar.LostFocus
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificar_MouseEnter(sender As Object, e As EventArgs) Handles btnModificar.MouseEnter
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificar_MouseLeave(sender As Object, e As EventArgs) Handles btnModificar.MouseLeave
        If btnModificar.Enabled = True Then
            btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

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

#End Region

#Region "FORM LOAD"
    Private Sub FrmCoprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "SIGEVA -> " & Date.Now & " -> Ingreso a Manejo de Comprobantes del Sistema"

        Tareas = New TareasComprobantes()

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        ConfigDGV_Comprobante()

        UtilidadesDGV.FormatoDGVGeneral(dgvComprobantes)

        CancelarAsync()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub Activar()
        UtilidadesDGV.DescargarDGV(dgvComprobantes)

        bnfCardComp.Enabled = True
        bnfCardLeyenda.Enabled = True
        bnfCardPieEnc.Enabled = True

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

        txtNombre.SelectionLength = txtNombre.TextLength
        txtNombre.Select()
    End Sub

    Private Async Sub CancelarAsync()
        Notificaciones.arbirFormProceso("CARGANDO COMPROBANTES")

        bnfCardComp.Enabled = False
        bnfCardLeyenda.Enabled = False
        bnfCardPieEnc.Enabled = False

        UtilidadesTXT.VaciarTxt(Me)

        cbxTipo.Text = ""

        bnfChkEnc.Checked = True
        bnfChkPie.Checked = True

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

        listCompleta = Await Tareas.ListadoCompleto()

        If IsNothing(listCompleta) Then
            If Tareas.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

                Me.Close()
            End If
        Else
            UtilidadesDGV.DescargarDGV(dgvComprobantes)

            TareasComprobantes.LlenarDGV(dgvComprobantes, listCompleta)

            UtilidadesDGV.CabeceraDGV(dgvComprobantes)
        End If

        Notificaciones.cerrarFormProceso()

        btnNuevo.Select()
    End Sub

    Private Sub ConfigDGV_Comprobante()
        dgvComprobantes.ColumnCount = 13
        dgvComprobantes.Columns(0).Name = "idComprobantes"
        dgvComprobantes.Columns(1).Name = "Nombre"
        dgvComprobantes.Columns(2).Name = "Copias"
        dgvComprobantes.Columns(3).Name = "Tipo"
        dgvComprobantes.Columns(4).Name = "Leyenda"
        dgvComprobantes.Columns(5).Name = "Encabezado"
        dgvComprobantes.Columns(6).Name = "LeyendaEnc"
        dgvComprobantes.Columns(7).Name = "Pie"
        dgvComprobantes.Columns(8).Name = "LeyendaPie"
        dgvComprobantes.Columns(9).Name = "CantidadCompEmitidos"
        dgvComprobantes.Columns(10).Name = "CantidadCopiasComp"
        dgvComprobantes.Columns(11).Name = "Eliminado"
        dgvComprobantes.Columns(12).Name = "Usuarios_idUsuarios"

        dgvComprobantes.Columns("idComprobantes").Visible = False
        dgvComprobantes.Columns("CantidadCompEmitidos").Visible = False
        dgvComprobantes.Columns("CantidadCopiasComp").Visible = False
        dgvComprobantes.Columns("Eliminado").Visible = False
        dgvComprobantes.Columns("Usuarios_idUsuarios").Visible = False

        dgvComprobantes.Columns("Nombre").HeaderText = "NOMBRE"
        dgvComprobantes.Columns("Copias").HeaderText = "COPIAS"
        dgvComprobantes.Columns("Tipo").HeaderText = "TIPO"
        dgvComprobantes.Columns("Leyenda").HeaderText = "LEYENDA"
        dgvComprobantes.Columns("Encabezado").HeaderText = "IMP. ENC."
        dgvComprobantes.Columns("LeyendaEnc").HeaderText = "LEYENDA ENC"
        dgvComprobantes.Columns("Pie").HeaderText = "IMP. PIE"
        dgvComprobantes.Columns("LeyendaPie").HeaderText = "LEYENDA PIE"

        dgvComprobantes.Columns("idComprobantes").DisplayIndex = 0
        dgvComprobantes.Columns("Nombre").DisplayIndex = 1
        dgvComprobantes.Columns("Copias").DisplayIndex = 2
        dgvComprobantes.Columns("Tipo").DisplayIndex = 3
        dgvComprobantes.Columns("Leyenda").DisplayIndex = 4
        dgvComprobantes.Columns("Encabezado").DisplayIndex = 5
        dgvComprobantes.Columns("LeyendaEnc").DisplayIndex = 6
        dgvComprobantes.Columns("Pie").DisplayIndex = 7
        dgvComprobantes.Columns("LeyendaPie").DisplayIndex = 8
        dgvComprobantes.Columns("CantidadCompEmitidos").DisplayIndex = 9
        dgvComprobantes.Columns("CantidadCopiasComp").DisplayIndex = 10
        dgvComprobantes.Columns("Eliminado").DisplayIndex = 11
        dgvComprobantes.Columns("Usuarios_idUsuarios").DisplayIndex = 12

        dgvComprobantes.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvComprobantes.Columns("Copias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvComprobantes.Columns("Tipo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvComprobantes.Columns("Leyenda").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvComprobantes.Columns("Encabezado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvComprobantes.Columns("LeyendaEnc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvComprobantes.Columns("Pie").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvComprobantes.Columns("LeyendaPie").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvComprobantes.ColumnHeadersVisible = False
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxTipo.SelectionLength = Len(cbxTipo.Text)
            cbxTipo.Select()
        End If
    End Sub

    Private Sub cbxTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTipo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCopias.SelectionLength = txtCopias.TextLength
            txtCopias.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCopias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCopias.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLeyenda.SelectionLength = txtLeyenda.TextLength
            txtLeyenda.Select()
        ElseIf e.KeyChar = ChrW(46) Then
            e.Handled = True
        ElseIf Not Char.IsNumber(e.KeyChar) And e.KeyChar <> ChrW(8) And Asc(e.KeyChar) <> Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLeyenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLeyenda.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            bnfChkEnc.Select()
        End If
    End Sub

    Private Sub bnfChkEnc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bnfChkEnc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLeyEnc.SelectionLength = txtLeyEnc.TextLength
            txtLeyEnc.Select()
        End If
    End Sub

    Private Sub txtLeyEnc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLeyEnc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            bnfChkPie.Select()
        End If
    End Sub

    Private Sub bnfChkPie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bnfChkPie.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLeyPie.SelectionLength = txtLeyPie.TextLength
            txtLeyPie.Select()
        End If
    End Sub

    Private Sub txtLeyPie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLeyPie.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtCopias_Validated(sender As Object, e As EventArgs) Handles txtCopias.Validated
        If Not IsNumeric(txtCopias.Text) And txtCopias.Text <> "" Then
            Notificaciones.MsgBox("Valor ingresado incorrecto.", Botones.OK, Iconos.ERR)
            txtCopias.Text = ""
        Else
            txtCopias.Text = Format(Math.Round(CDbl(txtCopias.Text), 0), "#,##0")
        End If
    End Sub

#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtOrigen.Text = "Nuevo"

        Activar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CancelarAsync()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdComp.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Comprobante.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Comprobante ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO COMPROBANTE")

                If Await Tareas.Eliminar(txtIdComp.Text) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Comprobante eliminado con exito !", Botones.OK, Iconos.OK)

                    CancelarAsync()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Then
            Notificaciones.MsgBox("""NOMBRE"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
            txtNombre.SelectionLength = txtNombre.TextLength
            txtNombre.Select()
        Else
            If cbxTipo.Text = "" Then
                Notificaciones.MsgBox("""TIPO DE COMPROBANTE"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                txtCopias.SelectionLength = txtCopias.TextLength
                txtCopias.Select()
            Else
                If txtCopias.Text = "" Then
                    Notificaciones.MsgBox("""COPIAS"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                    txtCopias.SelectionLength = txtCopias.TextLength
                    txtCopias.Select()
                Else
                    If txtLeyenda.Text = "" Then
                        txtLeyenda.Text = "-"
                    End If

                    If txtLeyEnc.Text = "" Then
                        txtLeyEnc.Text = "-"
                    End If

                    If txtLeyPie.Text = "" Then
                        txtLeyPie.Text = "-"
                    End If

                    Dim Enc, Pie As String

                    If bnfChkEnc.Checked = True Then
                        Enc = "Si"
                    Else
                        Enc = "No"
                    End If
                    If bnfChkPie.Checked = True Then
                        Pie = "Si"
                    Else
                        Pie = "No"
                    End If

                    Dim _comprobante As New Comprobantes(txtNombre.Text, cbxTipo.Text, txtCopias.Text, txtLeyenda.Text, Enc, txtLeyEnc.Text, Pie, txtLeyPie.Text)

                    If txtOrigen.Text = "Nuevo" Then
                        Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Comprobante ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("GUARDANDO COMPROBANTE")

                            If Await Tareas.Insertar(_comprobante) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Comprobante guardado con exito !", Botones.OK, Iconos.OK)

                                CancelarAsync()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

                                txtNombre.Select()
                            End If
                        End If
                    ElseIf txtOrigen.Text = "Modificar" Then
                        Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Comprobante ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("MODIFICANDO COMPROBANTE")

                            _comprobante.IdComprobantes = CInt(txtIdComp.Text)

                            If Await Tareas.Modificar(_comprobante) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Comprobante modificado con exito !", Botones.OK, Iconos.OK)

                                CancelarAsync()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

                                txtNombre.Select()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdComp.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Comprobante.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            txtNombre.Text = dgvComprobantes.CurrentRow.Cells("Nombre").Value
            txtCopias.Text = dgvComprobantes.CurrentRow.Cells("Copias").Value
            cbxTipo.Text = dgvComprobantes.CurrentRow.Cells("Tipo").Value
            txtLeyenda.Text = dgvComprobantes.CurrentRow.Cells("Leyenda").Value
            If dgvComprobantes.CurrentRow.Cells("Encabezado").Value = "Si" Then
                bnfChkEnc.Checked = True
            Else
                bnfChkEnc.Checked = False
            End If
            txtLeyEnc.Text = dgvComprobantes.CurrentRow.Cells("LeyendaEnc").Value
            If dgvComprobantes.CurrentRow.Cells("Pie").Value = "Si" Then
                bnfChkPie.Checked = True
            Else
                bnfChkPie.Checked = False
            End If
            txtLeyPie.Text = dgvComprobantes.CurrentRow.Cells("LeyendaPie").Value
            txtCe.Text = dgvComprobantes.CurrentRow.Cells("CantidadCompEmitidos").Value
            txtCc.Text = dgvComprobantes.CurrentRow.Cells("CantidadCopiasComp").Value

            Activar()
        End If
    End Sub

    Private Sub DgvComprobantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComprobantes.CellClick
        If e.RowIndex > -1 Then
            txtIdComp.Text = dgvComprobantes.CurrentRow.Cells("idComprobantes").Value
            btnModificar.Select()
        Else
            dgvComprobantes.CurrentCell = Nothing
        End If
    End Sub

#End Region

End Class