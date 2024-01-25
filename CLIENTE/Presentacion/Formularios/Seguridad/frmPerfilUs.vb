Imports Procesos

Public Class frmPerfilUs

    Dim WithEvents CheckBoxHeaderCell As dgvBoxHeaderCell
    Dim listaPerfil As New List(Of PerfilUsuario)
    Dim tareaPerfilUs As TareasPerfilUsuario

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

#Region "EVENTO LOAD"
    Private Sub FrmPerfilUs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desactivar()
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a ALTAS DE PERFILES DE USUARIO"

        tareaPerfilUs = New TareasPerfilUsuario

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.DescargarDGV(dgvDetallePerfiles)
        UtilidadesDGV.DescargarDGV(dgvListaPerfiles)
        UtilidadesDGV.DescargarDGV(dgvModulos)
        UtilidadesDGV.DescargarDGV(dgvPerfil)

        CargarDGV_Perfiles()

        UtilidadesDGV.FormatoDGVGeneral(dgvListaPerfiles)
        UtilidadesDGV.FormatoDGVGeneral(dgvModulos)
        UtilidadesDGV.FormatoDGVGeneral(dgvPerfil)
        UtilidadesDGV.FormatoDGVGeneral(dgvDetallePerfiles)

        btnNuevo.Select()
    End Sub

#End Region

#Region "METODOS PRIVADOS"
    Private Sub CargarDGV_Modulos()
        dgvModulos.ColumnCount = 4
        dgvModulos.Columns(1).Name = "Menu"
        dgvModulos.Columns(2).Name = "Sub Menu"
        dgvModulos.Columns(3).Name = "Modulo"

        dgvModulos.Columns("Menu").HeaderText = "MENU"
        dgvModulos.Columns("Sub Menu").HeaderText = "SUB MENU"
        dgvModulos.Columns("Modulo").HeaderText = "MODULO"

        dgvModulos.ColumnHeadersVisible = True
        dgvModulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvModulos.Rows.Add(False, "SISTEMA", "-", "EMPRESA")
        dgvModulos.Rows.Add(False, "SISTEMA", "-", "MONEDA")
        dgvModulos.Rows.Add(False, "SISTEMA", "-", "COMPROBANTES")
        dgvModulos.Rows.Add(False, "SISTEMA", "-", "ALICUOTAS")
        dgvModulos.Rows.Add(False, "ALTAS", "-", "USUARIOS")
        dgvModulos.Rows.Add(False, "ALTAS", "-", "CLIENTES")
        dgvModulos.Rows.Add(False, "ALTAS", "-", "PROVEEDORES")
        dgvModulos.Rows.Add(False, "ALTAS", "-", "ARTICULOS")
        dgvModulos.Rows.Add(False, "ALTAS", "-", "BANCOS")
        dgvModulos.Rows.Add(False, "ALTAS", "-", "GASTOS")
        dgvModulos.Rows.Add(False, "ALTAS", "-", "DEPOSITOS")
        dgvModulos.Rows.Add(False, "GESTION", "COMPRAS", "REMITOS")
        dgvModulos.Rows.Add(False, "GESTION", "COMPRAS", "FACTURAS")
        dgvModulos.Rows.Add(False, "GESTION", "COMPRAS", "NOTAS CREDITO")
        dgvModulos.Rows.Add(False, "GESTION", "COMPRAS", "NOTAS DEBITO")
        dgvModulos.Rows.Add(False, "GESTION", "COMPRAS", "ORDEN DE PAGO")
        dgvModulos.Rows.Add(False, "GESTION", "VENTAS", "PEDIDOS")
        dgvModulos.Rows.Add(False, "GESTION", "VENTAS", "REMITOS")
        dgvModulos.Rows.Add(False, "GESTION", "VENTAS", "FACTURAS")
        dgvModulos.Rows.Add(False, "GESTION", "VENTAS", "NOTAS CREDITO")
        dgvModulos.Rows.Add(False, "GESTION", "VENTAS", "NOTAS DEBITO")
        dgvModulos.Rows.Add(False, "GESTION", "VENTAS", "RECIBOS")
        dgvModulos.Rows.Add(False, "GESTION", "CANJES", "EMITIR CONTRATOS")
        dgvModulos.Rows.Add(False, "GESTION", "CANJES", "FIJAR CONTRATOS")
        dgvModulos.Rows.Add(False, "GESTION", "CANJES", "CARTA PORTE")
        dgvModulos.Rows.Add(False, "GESTION", "CANJES", "LIQUIDACIONES")
        dgvModulos.Rows.Add(False, "GESTION", "CAJA", "MANUAL (IN-EG)")
        dgvModulos.Rows.Add(False, "GESTION", "CAJA", "CARGAR GASTOS")
        dgvModulos.Rows.Add(False, "GESTION", "CAJA", "CARTAS (CHQS)")
        dgvModulos.Rows.Add(False, "GESTION", "BANCOS", "DEPOSITOS")
        dgvModulos.Rows.Add(False, "GESTION", "BANCOS", "RETIROS")
        dgvModulos.Rows.Add(False, "STOCK", "-", "MANTENIMIENTO")
        dgvModulos.Rows.Add(False, "STOCK", "-", "TRANSFERENCIAS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "-", "USUARIOS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "-", "CLIENTES")
        dgvModulos.Rows.Add(False, "CONSULTAS", "-", "PROVEEDORES")
        dgvModulos.Rows.Add(False, "CONSULTAS", "-", "ARTICULOS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "COMPRAS", "REMITOS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "COMPRAS", "FACTURAS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "COMPRAS", "NOTAS CREDITO")
        dgvModulos.Rows.Add(False, "CONSULTAS", "COMPRAS", "NOTAS DEBITO")
        dgvModulos.Rows.Add(False, "CONSULTAS", "VENTAS", "PEDIDOS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "VENTAS", "REMITOS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "VENTAS", "FACTURAS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "VENTAS", "NOTAS CREDITO")
        dgvModulos.Rows.Add(False, "CONSULTAS", "VENTAS", "NOTAS DEBITO")
        dgvModulos.Rows.Add(False, "CONSULTAS", "VENTAS", "RECIBOS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "-", "STOCK")
        dgvModulos.Rows.Add(False, "CONSULTAS", "CANJES", "CONTRATOS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "CANJES", "CARTA PORTE")
        dgvModulos.Rows.Add(False, "CONSULTAS", "CANJES", "LIQUIDACION")
        dgvModulos.Rows.Add(False, "CONSULTAS", "CAJA", "MOV. HISTORICOS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "CAJA", "ARQUEOS")
        dgvModulos.Rows.Add(False, "CONSULTAS", "CAJA", "CARTERA")
        dgvModulos.Rows.Add(False, "CONSULTAS", "-", "BANCOS")
        dgvModulos.Rows.Add(False, "SEGURIDAD", "-", "RESPALDOS")
        dgvModulos.Rows.Add(False, "SEGURIDAD", "-", "PERFILES")
        dgvModulos.Rows.Add(False, "SEGURIDAD", "-", "REGISTRO RESP.")
        dgvModulos.Rows.Add(False, "SEGURIDAD", "-", "REGISTRO ACTV.")

        Dim cbx As New DataGridViewCheckBoxColumn()
        CheckBoxHeaderCell = New dgvBoxHeaderCell

        dgvModulos.Columns.Add(cbx)
        cbx.HeaderText = ""
        cbx.Name = "Acceso"
        cbx.Width = 40
        cbx.HeaderCell = CheckBoxHeaderCell

        For Each item As DataGridViewRow In dgvModulos.Rows
            item.Cells("Acceso").Value = False
        Next

        dgvModulos.Columns("Acceso").DisplayIndex = 0
        dgvModulos.Columns("Menu").DisplayIndex = 1
        dgvModulos.Columns("Sub Menu").DisplayIndex = 2
        dgvModulos.Columns("Modulo").DisplayIndex = 3
    End Sub

    Private Sub CargarDGV_Perfil()
        dgvPerfil.RowTemplate.Height = 25
        dgvPerfil.ColumnCount = 4
        dgvPerfil.Columns(0).Name = "Menu"
        dgvPerfil.Columns(1).Name = "Sub Menu"
        dgvPerfil.Columns(2).Name = "Modulo"
        dgvPerfil.Columns(3).Name = "Resumen"

        dgvPerfil.ColumnHeadersVisible = False
        dgvPerfil.Columns("Menu").Visible = False
        dgvPerfil.Columns("Sub Menu").Visible = False
        dgvPerfil.Columns("Modulo").Visible = False
        dgvPerfil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvPerfil.Columns("Resumen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvPerfil.RowHeadersVisible = False
    End Sub

    Private Sub CargarDGV_ListaPerfiles()
        dgvListaPerfiles.RowTemplate.Height = 25
        dgvListaPerfiles.ColumnCount = 2
        dgvListaPerfiles.Columns(0).Name = "Id"
        dgvListaPerfiles.Columns(1).Name = "Nombre"

        dgvListaPerfiles.Columns("Id").Visible = False
        dgvListaPerfiles.ColumnHeadersVisible = False
        dgvListaPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvListaPerfiles.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvListaPerfiles.RowHeadersVisible = False
    End Sub

    Private Sub CargarDGV_DetallePerfiles()
        dgvDetallePerfiles.RowTemplate.Height = 25
        dgvDetallePerfiles.ColumnCount = 4
        dgvDetallePerfiles.Columns(0).Name = "Menu"
        dgvDetallePerfiles.Columns(1).Name = "Sub Menu"
        dgvDetallePerfiles.Columns(2).Name = "Modulo"
        dgvDetallePerfiles.Columns(3).Name = "Resumen"

        dgvDetallePerfiles.Columns("Menu").Visible = False
        dgvDetallePerfiles.Columns("Sub Menu").Visible = False
        dgvDetallePerfiles.Columns("Modulo").Visible = False
        dgvDetallePerfiles.ColumnHeadersVisible = False
        dgvDetallePerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvDetallePerfiles.Columns("Resumen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvDetallePerfiles.RowHeadersVisible = False
    End Sub

    Private Sub Activar()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False

        bnfCardNombre.Enabled = True
        bnfCardDetCar.Enabled = False
        bnfCardPerCar.Enabled = False

        btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
        btnModificar.BackColor = Color.FromArgb(35, 35, 35)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminar.BackColor = Color.FromArgb(35, 35, 35)
    End Sub

    Private Sub Desactivar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = True

        bnfCardNombre.Enabled = False
        bnfCardDetCar.Enabled = True
        bnfCardPerCar.Enabled = True

        txtNombre.Text = ""

        btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminar.BackColor = Color.FromArgb(100, 100, 100)
    End Sub

    Private Async Sub CargarDGV_Perfiles()
        Notificaciones.arbirFormProceso("CARGANDO PERFILES DE USUSRAIO")

        listaPerfil = Await tareaPerfilUs.ListadoCompleto()

        If Not IsNothing(listaPerfil) Then
            CargarDGV_ListaPerfiles()
            CargarDGV_DetallePerfiles()

            For Each item In listaPerfil
                dgvListaPerfiles.Rows.Add(item.IdPerfil, item.NombrePerfil)
            Next

            dgvListaPerfiles.CurrentCell = Nothing
            Notificaciones.cerrarFormProceso()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaPerfilUs.Err.Descripcion, Botones.OK, Iconos.ERR)
        End If
    End Sub

    Private Function Modulo(ByVal Num As Integer) As String()
        Dim _Dt As New DataTable
        Dim mdl(3) As String

        _Dt.Columns.Add("Menu")
        _Dt.Columns.Add("Sub Menu")
        _Dt.Columns.Add("Modulo")

        _Dt.Rows.Add("SISTEMA", "-", "EMPRESA")
        _Dt.Rows.Add("SISTEMA", "-", "MONEDA")
        _Dt.Rows.Add("SISTEMA", "-", "COMPROBANTES")
        _Dt.Rows.Add("SISTEMA", "-", "ALICUOTAS")
        _Dt.Rows.Add("ALTAS", "-", "USUARIOS")
        _Dt.Rows.Add("ALTAS", "-", "CLIENTES")
        _Dt.Rows.Add("ALTAS", "-", "PROVEEDORES")
        _Dt.Rows.Add("ALTAS", "-", "ARTICULOS")
        _Dt.Rows.Add("ALTAS", "-", "CATEGORIAS")
        _Dt.Rows.Add("ALTAS", "-", "BANCOS")
        _Dt.Rows.Add("ALTAS", "-", "GASTOS")
        _Dt.Rows.Add("ALTAS", "-", "DEPOSITOS")
        _Dt.Rows.Add("GESTION", "COMPRAS", "REMITOS")
        _Dt.Rows.Add("GESTION", "COMPRAS", "FACTURAS")
        _Dt.Rows.Add("GESTION", "COMPRAS", "NOTAS CREDITO")
        _Dt.Rows.Add("GESTION", "COMPRAS", "NOTAS DEBITO")
        _Dt.Rows.Add("GESTION", "COMPRAS", "ORDEN DE PAGO")
        _Dt.Rows.Add("GESTION", "VENTAS", "PEDIDOS")
        _Dt.Rows.Add("GESTION", "VENTAS", "REMITOS")
        _Dt.Rows.Add("GESTION", "VENTAS", "FACTURAS")
        _Dt.Rows.Add("GESTION", "VENTAS", "NOTAS CREDITO")
        _Dt.Rows.Add("GESTION", "VENTAS", "NOTAS DEBITO")
        _Dt.Rows.Add("GESTION", "VENTAS", "RECIBOS")
        _Dt.Rows.Add("GESTION", "CANJES", "EMITIR CONTRATOS")
        _Dt.Rows.Add("GESTION", "CANJES", "FIJAR CONTRATOS")
        _Dt.Rows.Add("GESTION", "CANJES", "CARTA PORTE")
        _Dt.Rows.Add("GESTION", "CANJES", "LIQUIDACIONES")
        _Dt.Rows.Add("GESTION", "CAJA", "MANUAL (IN-EG)")
        _Dt.Rows.Add("GESTION", "CAJA", "CARGAR GASTOS")
        _Dt.Rows.Add("GESTION", "CAJA", "CARTAS (CHQS)")
        _Dt.Rows.Add("GESTION", "BANCOS", "DEPOSITOS")
        _Dt.Rows.Add("GESTION", "BANCOS", "RETIROS")
        _Dt.Rows.Add("STOCK", "-", "MANTENIMIENTO")
        _Dt.Rows.Add("STOCK", "-", "TRANSFERENCIAS")
        _Dt.Rows.Add("CONSULTAS", "-", "USUARIOS")
        _Dt.Rows.Add("CONSULTAS", "-", "CLIENTES")
        _Dt.Rows.Add("CONSULTAS", "-", "PROVEEDORES")
        _Dt.Rows.Add("CONSULTAS", "-", "ARTICULOS")
        _Dt.Rows.Add("CONSULTAS", "COMPRAS", "REMITOS")
        _Dt.Rows.Add("CONSULTAS", "COMPRAS", "FACTURAS")
        _Dt.Rows.Add("CONSULTAS", "COMPRAS", "NOTAS CREDITO")
        _Dt.Rows.Add("CONSULTAS", "COMPRAS", "NOTAS DEBITO")
        _Dt.Rows.Add("CONSULTAS", "VENTAS", "PEDIDOS")
        _Dt.Rows.Add("CONSULTAS", "VENTAS", "REMITOS")
        _Dt.Rows.Add("CONSULTAS", "VENTAS", "FACTURAS")
        _Dt.Rows.Add("CONSULTAS", "VENTAS", "NOTAS CREDITO")
        _Dt.Rows.Add("CONSULTAS", "VENTAS", "NOTAS DEBITO")
        _Dt.Rows.Add("CONSULTAS", "VENTAS", "RECIBOS")
        _Dt.Rows.Add("CONSULTAS", "-", "STOCK")
        _Dt.Rows.Add("CONSULTAS", "CANJES", "CONTRATOS")
        _Dt.Rows.Add("CONSULTAS", "CANJES", "CARTA PORTE")
        _Dt.Rows.Add("CONSULTAS", "CANJES", "LIQUIDACION")
        _Dt.Rows.Add("CONSULTAS", "CAJA", "MOV. HISTORICOS")
        _Dt.Rows.Add("CONSULTAS", "CAJA", "ARQUEOS")
        _Dt.Rows.Add("CONSULTAS", "CAJA", "CARTERA")
        _Dt.Rows.Add("CONSULTAS", "-", "BANCOS")
        _Dt.Rows.Add("SEGURIDAD", "-", "RESPALDOS")
        _Dt.Rows.Add("SEGURIDAD", "-", "PERFILES")
        _Dt.Rows.Add("SEGURIDAD", "-", "REGISTRO RESP.")
        _Dt.Rows.Add("SEGURIDAD", "-", "REGISTRO ACTV.")

        For i As Integer = 0 To 2
            mdl(i) = _Dt.Rows(Num).Item(i)
        Next

        Return mdl
    End Function

#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub CheckBoxHeaderCell_CheckBoxClicked(sender As Object, e As DataGridViewCheckBoxHeaderCellEventArgs) Handles CheckBoxHeaderCell.CheckBoxClicked
        For Each item As DataGridViewRow In dgvModulos.Rows
            item.Cells("Acceso").Value = False
        Next

        dgvModulos.CurrentCell = Nothing
        CheckBoxHeaderCell.CheckUncheckEntireColumn(e.Checked)
        UtilidadesDGV.DescargarDGV(dgvPerfil)

        If CheckBoxHeaderCell.Checked = False Then
            For Each item As DataGridViewRow In dgvModulos.Rows
                Dim Resumen As String = ""

                If item.Cells("Sub Menu").Value = "-" Then
                    Resumen = item.Cells("Menu").Value + " - " + item.Cells("Modulo").Value
                Else
                    Resumen = item.Cells("Menu").Value + " - " + item.Cells("Sub Menu").Value + " - " + item.Cells("Modulo").Value
                End If

                dgvPerfil.Rows.Add(item.Cells("Menu").Value, item.Cells("Sub Menu").Value, item.Cells("Modulo").Value, Resumen)
            Next
        End If

        dgvPerfil.CurrentCell = Nothing
    End Sub

    Private Sub dgvModulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvModulos.CellContentClick
        If e.ColumnIndex = CheckBoxHeaderCell.ColumnIndex Then
            If e.RowIndex > -1 Then
                If dgvModulos.CurrentCell.Value = False Then
                    Dim Resumen As String = ""

                    If dgvModulos.CurrentRow.Cells("Sub Menu").Value = "-" Then
                        Resumen = dgvModulos.CurrentRow.Cells("Menu").Value + " - " + dgvModulos.CurrentRow.Cells("Modulo").Value
                    Else
                        Resumen = dgvModulos.CurrentRow.Cells("Menu").Value + " - " + dgvModulos.CurrentRow.Cells("Sub Menu").Value + " - " + dgvModulos.CurrentRow.Cells("Modulo").Value
                    End If

                    dgvModulos.CurrentCell.Value = True

                    dgvPerfil.Rows.Add(dgvModulos.CurrentRow.Cells("Menu").Value, dgvModulos.CurrentRow.Cells("Sub Menu").Value, dgvModulos.CurrentRow.Cells("Modulo").Value, Resumen)
                    dgvPerfil.CurrentCell = Nothing
                Else
                    dgvModulos.CurrentCell.Value = False

                    Dim rows As Integer = dgvPerfil.Rows.Count - 1

                    If dgvPerfil.Rows.Count > 0 Then
                        For j As Integer = rows To 0 Step -1
                            If dgvPerfil.Rows(j).Cells("Menu").Value = dgvModulos.CurrentRow.Cells("Menu").Value And dgvPerfil.Rows(j).Cells("Sub Menu").Value = dgvModulos.CurrentRow.Cells("Sub Menu").Value And dgvPerfil.Rows(j).Cells("Modulo").Value = dgvModulos.CurrentRow.Cells("Modulo").Value Then
                                dgvPerfil.Rows.Remove(dgvPerfil.Rows(j))
                            End If
                        Next
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        CargarDGV_Modulos()
        CargarDGV_Perfil()
        UtilidadesDGV.DescargarDGV(dgvDetallePerfiles)
        UtilidadesDGV.DescargarDGV(dgvListaPerfiles)
        Activar()

        txtOrigen.Text = "Nuevo"

        txtNombre.Select()

        dgvModulos.CurrentCell = Nothing
        dgvPerfil.CurrentCell = Nothing
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        UtilidadesDGV.DescargarDGV(dgvModulos)
        UtilidadesDGV.DescargarDGV(dgvPerfil)
        Desactivar()
        CargarDGV_Perfiles()

        btnNuevo.Select()

        dgvListaPerfiles.CurrentCell = Nothing
    End Sub

    Private Async Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Then
            Notificaciones.MsgBox("""NOMBRE DEL PERFIL"" es un campo obligatorio.", Botones.OK, Iconos.INFORMACION)
            txtNombre.Select()
        Else
            If dgvPerfil.Rows.Count = 0 Then
                Notificaciones.MsgBox("El perfil no puede estar vacio.", Botones.OK, Iconos.INFORMACION)
            Else
                Dim resp As DialogResult
                Dim Ex As Boolean = False
                Dim Result As Boolean
                Dim Acc(100) As Boolean

                If txtOrigen.Text = "Nuevo" Then
                    resp = Notificaciones.MsgBox("Guardar Perfil ?", Botones.OK_CANCEL, Iconos.INFORMACION)
                Else
                    resp = Notificaciones.MsgBox("Modificar Perfil ?", Botones.OK_CANCEL, Iconos.INFORMACION)
                End If

                If resp = DialogResult.OK Then
                    If txtOrigen.Text = "Nuevo" Then
                        Notificaciones.arbirFormProceso("GUARDANDO PERFIL DE USUARIO")
                    Else
                        Notificaciones.arbirFormProceso("MODIFICANDO PERFIL DE USUARIO")
                    End If

                    For i As Integer = 0 To dgvModulos.Rows.Count - 1
                        For j As Integer = 0 To dgvPerfil.Rows.Count - 1
                            If dgvPerfil.Rows(j).Cells("Menu").Value = dgvModulos.Rows(i).Cells("Menu").Value And dgvPerfil.Rows(j).Cells("Sub Menu").Value = dgvModulos.Rows(i).Cells("Sub Menu").Value And dgvPerfil.Rows(j).Cells("Modulo").Value = dgvModulos.Rows(i).Cells("Modulo").Value Then
                                Ex = True
                            End If
                        Next

                        Acc(i) = Ex

                        Ex = False
                    Next

                    Dim _Perfil As New PerfilUsuario(txtNombre.Text, Acc, "NO")

                    If txtOrigen.Text = "Nuevo" Then
                        Result = Await tareaPerfilUs.ServicioInsertar(_Perfil)
                    Else
                        _Perfil.IdPerfil = txtIdPerfil.Text
                        Result = Await tareaPerfilUs.ServicioModificar(_Perfil)
                    End If

                    If Result = True Then
                        Desactivar()
                        UtilidadesDGV.DescargarDGV(dgvDetallePerfiles)
                        UtilidadesDGV.DescargarDGV(dgvListaPerfiles)
                        UtilidadesDGV.DescargarDGV(dgvModulos)
                        UtilidadesDGV.DescargarDGV(dgvPerfil)
                        CargarDGV_Perfiles()

                        If txtOrigen.Text = "Nuevo" Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Perfil guardado con exito !", Botones.OK, Iconos.OK)
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Perfil modificado con exito !", Botones.OK, Iconos.OK)

                            txtIdPerfil.Text = ""
                            txtNombreAnt.Text = ""
                        End If

                        btnNuevo.Select()
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareaPerfilUs.Err.Descripcion, Botones.OK, Iconos.ERR)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DgvListaPerfiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaPerfiles.CellClick
        If e.RowIndex > -1 Then
            UtilidadesDGV.DescargarDGV(dgvDetallePerfiles)

            For Each item In listaPerfil
                If item.IdPerfil = dgvListaPerfiles.CurrentRow.Cells("Id").Value Then
                    For i As Integer = 0 To 100
                        If item.Accesos(i) = True Then
                            Dim mdl() As String = Modulo(i)
                            Dim Resumen As String

                            If mdl(1) = "-" Then
                                Resumen = mdl(0) + " - " + mdl(2)
                            Else
                                Resumen = mdl(0) + " - " + mdl(1) + " - " + mdl(2)
                            End If

                            dgvDetallePerfiles.Rows.Add(mdl(0), mdl(1), mdl(2), Resumen)
                        End If
                    Next
                End If
            Next

            dgvDetallePerfiles.CurrentCell = Nothing
            btnModificar.Select()
            txtIdPerfil.Text = dgvListaPerfiles.CurrentRow.Cells("Id").Value
        End If
    End Sub

    Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdPerfil.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un perfil.", Botones.OK, Iconos.INFORMACION)
        Else

            Dim resp = Notificaciones.MsgBox("Eliminar Perfil ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO PERFIL DE USUARIO")

                If Await tareaPerfilUs.ServicioEliminar(txtIdPerfil.Text) Then
                    Desactivar()
                    UtilidadesDGV.DescargarDGV(dgvDetallePerfiles)
                    UtilidadesDGV.DescargarDGV(dgvListaPerfiles)
                    CargarDGV_Perfiles()

                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Perfil eliminado con exito !", Botones.OK, Iconos.OK)
                    txtIdPerfil.Text = ""
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaPerfilUs.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If

        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvListaPerfiles.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No has seleccionado un perfil.", Botones.OK, Iconos.INFORMACION)
        Else
            CargarDGV_Perfil()
            CargarDGV_Modulos()

            txtIdPerfil.Text = dgvListaPerfiles.CurrentRow.Cells("Id").Value
            txtNombre.Text = dgvListaPerfiles.CurrentRow.Cells("Nombre").Value
            txtNombreAnt.Text = dgvListaPerfiles.CurrentRow.Cells("Nombre").Value

            For Each row As DataGridViewRow In dgvDetallePerfiles.Rows
                dgvPerfil.Rows.Add(row.Cells("Menu").Value, row.Cells("Sub Menu").Value, row.Cells("Modulo").Value, row.Cells("Resumen").Value)
            Next

            For i As Integer = 0 To dgvModulos.Rows.Count - 1
                For j As Integer = 0 To dgvPerfil.Rows.Count - 1
                    If dgvPerfil.Rows(j).Cells("Menu").Value = dgvModulos.Rows(i).Cells("Menu").Value And dgvPerfil.Rows(j).Cells("Sub Menu").Value = dgvModulos.Rows(i).Cells("Sub Menu").Value And dgvPerfil.Rows(j).Cells("Modulo").Value = dgvModulos.Rows(i).Cells("Modulo").Value Then
                        dgvModulos.Rows(i).Cells("Acceso").Value = True
                    End If
                Next
            Next

            UtilidadesDGV.DescargarDGV(dgvDetallePerfiles)
            UtilidadesDGV.DescargarDGV(dgvListaPerfiles)
            Activar()

            txtOrigen.Text = "Modificar"

            txtNombre.Select()

            dgvModulos.CurrentCell = Nothing
            dgvPerfil.CurrentCell = Nothing
        End If
    End Sub

#End Region

#Region "EVENTOS CAHNGED"
    Private Sub dgvPerfil_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPerfil.SelectionChanged
        dgvPerfil.ClearSelection()
    End Sub

    Private Sub dgvDetallePerfiles_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDetallePerfiles.SelectionChanged
        dgvDetallePerfiles.ClearSelection()
    End Sub
#End Region

End Class