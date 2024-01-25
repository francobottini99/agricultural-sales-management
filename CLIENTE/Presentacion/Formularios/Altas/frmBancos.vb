Imports Procesos

Public Class frmBancos
    Private listCompleta As List(Of bancos)
    Private Tareas As TareasBancos

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

#Region "LOAD FORM"
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "SIGEVA -> " & Date.Now & " -> Ingreso a ALTAS DE BANCOS"

        Tareas = New TareasBancos()

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvBancos)

        ConfigDGV_BANCOS()

        Cancelar()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub Activar()
        pnlContendor.Enabled = True
        bnfCardList.Enabled = False
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

        txtBuscar.Text = ""

        UtilidadesDGV.DescargarDGV(dgvBancos)

        txtNombre.SelectionLength = Len(txtNombre.Text)
        txtNombre.Select()
    End Sub

    Private Async Sub Cancelar()
        Notificaciones.arbirFormProceso("CARGANDO BANCOS")

        pnlContendor.Enabled = False
        bnfCardList.Enabled = True

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

        listCompleta = Await Tareas.ListadoCompleto()

        If Not IsNothing(listCompleta) Then
            UtilidadesDGV.DescargarDGV(dgvBancos)

            TareasBancos.LlenarDGV(dgvBancos, listCompleta)

            UtilidadesDGV.CabeceraDGV(dgvBancos)

            Notificaciones.cerrarFormProceso()

            btnNuevo.Select()
        ElseIf Tareas.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If
    End Sub

    Private Sub ConfigDGV_BANCOS()
        dgvBancos.ColumnCount = 4
        dgvBancos.Columns(0).Name = "idBanco"
        dgvBancos.Columns(1).Name = "Nombre"
        dgvBancos.Columns(2).Name = "Eliminado"
        dgvBancos.Columns(3).Name = "Usuarios_idUsuarios"

        dgvBancos.Columns("idBanco").Visible = False
        dgvBancos.Columns("Eliminado").Visible = False
        dgvBancos.Columns("Usuarios_idUsuarios").Visible = False

        dgvBancos.Columns("Nombre").HeaderText = "NOMBRE"

        dgvBancos.Columns("idBanco").DisplayIndex = 0
        dgvBancos.Columns("Nombre").DisplayIndex = 1
        dgvBancos.Columns("Eliminado").DisplayIndex = 2
        dgvBancos.Columns("Usuarios_idUsuarios").DisplayIndex = 3

        dgvBancos.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvBancos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBancos.ColumnHeadersVisible = False
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click

        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdBanco.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Banco.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            txtNombre.Text = dgvBancos.CurrentRow.Cells("Nombre").Value

            Activar()
        End If
    End Sub

    Private Async Sub BtnEliminar_ClickAsync(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdBanco.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Banco.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Banco ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO BANCO")

                If Await Tareas.Eliminar(txtIdBanco.Text) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Banco eliminado con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
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
            txtNombre.Select()
        Else
            Dim _banco As New Bancos(txtNombre.Text)

            If txtOrigen.Text = "Nuevo" Then
                Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Banco ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                If resp = DialogResult.OK Then
                    Notificaciones.arbirFormProceso("GUARDANDO BANCO")

                    If Await Tareas.Servicio_Insertar(_banco) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox("Banco guardado con exito !", Botones.OK, Iconos.OK)

                        Cancelar()
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

                        txtNombre.Select()
                    End If
                End If
            ElseIf txtOrigen.Text = "Modificar" Then
                Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Banco ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                If resp = DialogResult.OK Then
                    Notificaciones.arbirFormProceso("MODIFICANDO BANCO")

                    _banco.IdBancos = CInt(txtIdBanco.Text)

                    If Await Tareas.Servicio_Modificar(_banco) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox("Banco modificado con exito !", Botones.OK, Iconos.OK)

                        Cancelar()
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

                        txtNombre.Select()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvBancos_CellClickk(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBancos.CellClick
        If e.RowIndex > -1 Then
            txtIdBanco.Text = dgvBancos.CurrentRow.Cells("idBanco").Value

            btnModificar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim listFiltrada As List(Of Bancos)

        UtilidadesDGV.DescargarDGV(dgvBancos)

        If txtBuscar.Text <> "" Then
            listFiltrada = UtilidadesListas.FiltarLista(Of Bancos)(listCompleta, "Nombre", txtBuscar.Text)
        Else
            listFiltrada = listCompleta
        End If

        TareasBancos.LlenarDGV(dgvBancos, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvBancos)
    End Sub
#End Region
End Class