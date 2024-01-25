Imports Procesos

Public Class frmDeposito
    Private listCompleta As List(Of Depositos)
    Private Tareas As TareasDepositos

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
        lblTitulo.Text = "SIGEVA -> " & Date.Now & " -> Ingreso a ALTAS DE DEPOSITOS"

        Tareas = New TareasDepositos()

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvDepositos)

        ConfigDGV_DEPOSITOS()

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

        UtilidadesDGV.DescargarDGV(dgvDepositos)

        txtNombre.SelectionLength = Len(txtNombre.Text)
        txtNombre.Select()
    End Sub

    Private Async Sub Cancelar()
        Notificaciones.arbirFormProceso("CARGANDO DEPOSITOS")

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
            UtilidadesDGV.DescargarDGV(dgvDepositos)

            TareasDepositos.LlenarDGV(dgvDepositos, listCompleta)

            UtilidadesDGV.CabeceraDGV(dgvDepositos)

            Notificaciones.cerrarFormProceso()

            btnNuevo.Select()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If
    End Sub

    Private Sub ConfigDGV_DEPOSITOS()
        dgvDepositos.ColumnCount = 8
        dgvDepositos.Columns(0).Name = "idDeposito"
        dgvDepositos.Columns(1).Name = "Nombre"
        dgvDepositos.Columns(2).Name = "Dirección"
        dgvDepositos.Columns(3).Name = "Localidad"
        dgvDepositos.Columns(4).Name = "Provincia"
        dgvDepositos.Columns(5).Name = "CP"
        dgvDepositos.Columns(6).Name = "Eliminado"
        dgvDepositos.Columns(7).Name = "Usuarios_idUsuarios"

        dgvDepositos.Columns("idDeposito").Visible = False
        dgvDepositos.Columns("Eliminado").Visible = False
        dgvDepositos.Columns("Usuarios_idUsuarios").Visible = False

        dgvDepositos.Columns("Nombre").HeaderText = "NOMBRE"
        dgvDepositos.Columns("Dirección").HeaderText = "DIRECCION"
        dgvDepositos.Columns("Localidad").HeaderText = "LOCALIDAD"
        dgvDepositos.Columns("Provincia").HeaderText = "PROVINCIA"
        dgvDepositos.Columns("CP").HeaderText = "COD POSTAL"

        dgvDepositos.Columns("idDeposito").DisplayIndex = 0
        dgvDepositos.Columns("Nombre").DisplayIndex = 1
        dgvDepositos.Columns("Dirección").DisplayIndex = 2
        dgvDepositos.Columns("Localidad").DisplayIndex = 3
        dgvDepositos.Columns("Provincia").DisplayIndex = 4
        dgvDepositos.Columns("CP").DisplayIndex = 5
        dgvDepositos.Columns("Eliminado").DisplayIndex = 6
        dgvDepositos.Columns("Usuarios_idUsuarios").DisplayIndex = 7

        dgvDepositos.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDepositos.Columns("Dirección").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDepositos.Columns("Localidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDepositos.Columns("Provincia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDepositos.Columns("CP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvDepositos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDepositos.ColumnHeadersVisible = False
    End Sub

    Private Sub Guiones(ByRef _deposito As Depositos)
        If txtDireccion.Text = "" Then
            _deposito.Direccion = "-"
        End If

        If txtLocalidad.Text = "" Then
            _deposito.Localidad = "-"
        End If

        If txtProvincia.Text = "" Then
            _deposito.Provincia = "-"
        End If

        If txtCP.Text = "" Then
            _deposito.CodPostal = "-"
        End If
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
        If txtIdDeposito.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Deposito.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            txtNombre.Text = dgvDepositos.CurrentRow.Cells("Nombre").Value
            txtDireccion.Text = dgvDepositos.CurrentRow.Cells("Dirección").Value
            txtLocalidad.Text = dgvDepositos.CurrentRow.Cells("Localidad").Value
            txtProvincia.Text = dgvDepositos.CurrentRow.Cells("Provincia").Value
            txtCP.Text = dgvDepositos.CurrentRow.Cells("CP").Value

            Activar()
        End If
    End Sub

    Private Async Sub BtnEliminar_ClickAsync(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdDeposito.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Deposito.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Deposito ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO DEPOSITO")

                If Await Tareas.Eliminar(txtIdDeposito.Text) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Deposito eliminado con exito !", Botones.OK, Iconos.OK)

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
            Dim _deposito As Depositos = New Depositos(txtNombre.Text, txtDireccion.Text, txtLocalidad.Text, txtProvincia.Text, txtCP.Text)

            If txtOrigen.Text = "Nuevo" Then
                Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Deposito ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                If resp = DialogResult.OK Then
                    Notificaciones.arbirFormProceso("GUARDANDO DEPOSITO")

                    Guiones(_deposito)

                    If Await Tareas.Servicio_Insertar(_deposito) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox("Deposito guardado con exito !", Botones.OK, Iconos.OK)

                        Cancelar()
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

                        txtNombre.Select()
                    End If
                End If
            ElseIf txtOrigen.Text = "Modificar" Then
                Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Deposito ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                If resp = DialogResult.OK Then
                    Notificaciones.arbirFormProceso("MODIFICANDO DEPOSITO")

                    Guiones(_deposito)

                    _deposito.IdDeposito = CInt(txtIdDeposito.Text)

                    If Await Tareas.Servicio_Modificar(_deposito) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox("Deposito modificado con exito !", Botones.OK, Iconos.OK)

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

    Private Sub dgvDepositos_CellClickk(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepositos.CellClick
        If e.RowIndex > -1 Then
            txtIdDeposito.Text = dgvDepositos.CurrentRow.Cells("idDeposito").Value

            btnModificar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDireccion.SelectionLength = Len(txtDireccion.Text)
            txtDireccion.Select()
        End If
    End Sub

    Private Sub txtDireccionl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLocalidad.SelectionLength = Len(txtLocalidad.Text)
            txtLocalidad.Select()
        End If
    End Sub

    Private Sub txtLocalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocalidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtProvincia.SelectionLength = Len(txtProvincia.Text)
            txtProvincia.Select()
        End If
    End Sub

    Private Sub cbxProvincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProvincia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCP.SelectionLength = Len(txtCP.Text)
            txtCP.Select()
        End If
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim listFiltrada As List(Of Depositos)

        UtilidadesDGV.DescargarDGV(dgvDepositos)

        If txtBuscar.Text <> "" Then
            listFiltrada = UtilidadesListas.FiltarLista(Of Depositos)(listCompleta, "Nombre", txtBuscar.Text)
        Else
            listFiltrada = listCompleta
        End If

        TareasDepositos.LlenarDGV(dgvDepositos, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvDepositos)
    End Sub
#End Region
End Class