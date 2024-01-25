Imports Procesos

Public Class frmcategorias
    Private listRubo As List(Of Rubros)
    Private TareasRub As TareasRubros
    Private listSubRubo As List(Of SubRubros)
    Private TareasSub As TareasSubRubro
    Private _Dt As DataTable


#Region "ANIMACIONES BOTONES"
    Private Sub btnNuevoRub_GotFocus(sender As Object, e As EventArgs) Handles btnNuevoRub.GotFocus
        If btnNuevoRub.Enabled = True Then
            btnNuevoRub.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevoRub_LostFocus(sender As Object, e As EventArgs) Handles btnNuevoRub.LostFocus
        If btnNuevoRub.Enabled = True Then
            btnNuevoRub.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnNuevoRub_MouseEnter(sender As Object, e As EventArgs) Handles btnNuevoRub.MouseEnter
        If btnNuevoRub.Enabled = True Then
            btnNuevoRub.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevoRub_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevoRub.MouseLeave
        If btnNuevoRub.Enabled = True Then
            btnNuevoRub.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnNuevoSubR_GotFocus(sender As Object, e As EventArgs) Handles btnNuevoSubR.GotFocus
        If btnNuevoSubR.Enabled = True Then
            btnNuevoSubR.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevoSubR_LostFocus(sender As Object, e As EventArgs) Handles btnNuevoSubR.LostFocus
        If btnNuevoSubR.Enabled = True Then
            btnNuevoSubR.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnNuevoSubR_MouseEnter(sender As Object, e As EventArgs) Handles btnNuevoSubR.MouseEnter
        If btnNuevoSubR.Enabled = True Then
            btnNuevoSubR.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnNuevoSubR_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevoSubR.MouseLeave
        If btnNuevoSubR.Enabled = True Then
            btnNuevoSubR.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificarRub_GotFocus(sender As Object, e As EventArgs) Handles btnModificarRub.GotFocus
        If btnModificarRub.Enabled = True Then
            btnModificarRub.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificarRub_LostFocus(sender As Object, e As EventArgs) Handles btnModificarRub.LostFocus
        If btnModificarRub.Enabled = True Then
            btnModificarRub.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificarRub_MouseEnter(sender As Object, e As EventArgs) Handles btnModificarRub.MouseEnter
        If btnModificarRub.Enabled = True Then
            btnModificarRub.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificarRub_MouseLeave(sender As Object, e As EventArgs) Handles btnModificarRub.MouseLeave
        If btnModificarRub.Enabled = True Then
            btnModificarRub.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificarSubR_GotFocus(sender As Object, e As EventArgs) Handles btnModificarSubR.GotFocus
        If btnModificarSubR.Enabled = True Then
            btnModificarSubR.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificarSubR_LostFocus(sender As Object, e As EventArgs) Handles btnModificarSubR.LostFocus
        If btnModificarSubR.Enabled = True Then
            btnModificarSubR.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnModificarSubR_MouseEnter(sender As Object, e As EventArgs) Handles btnModificarSubR.MouseEnter
        If btnModificarSubR.Enabled = True Then
            btnModificarSubR.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnModificarSubR_MouseLeave(sender As Object, e As EventArgs) Handles btnModificarSubR.MouseLeave
        If btnModificarSubR.Enabled = True Then
            btnModificarSubR.BackColor = Color.FromArgb(100, 100, 100)
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

    Private Sub btnEliminarRub_GotFocus(sender As Object, e As EventArgs) Handles btnEliminarRub.GotFocus
        If btnEliminarRub.Enabled = True Then
            btnEliminarRub.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminarRub_LostFocus(sender As Object, e As EventArgs) Handles btnEliminarRub.LostFocus
        If btnEliminarRub.Enabled = True Then
            btnEliminarRub.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminarRub_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminarRub.MouseEnter
        If btnEliminarRub.Enabled = True Then
            btnEliminarRub.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminarRub_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminarRub.MouseLeave
        If btnEliminarRub.Enabled = True Then
            btnEliminarRub.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminarSubR_GotFocus(sender As Object, e As EventArgs) Handles btnEliminarSubR.GotFocus
        If btnEliminarSubR.Enabled = True Then
            btnEliminarSubR.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminarSubR_LostFocus(sender As Object, e As EventArgs) Handles btnEliminarSubR.LostFocus
        If btnEliminarSubR.Enabled = True Then
            btnEliminarSubR.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEliminarSubR_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminarSubR.MouseEnter
        If btnEliminarSubR.Enabled = True Then
            btnEliminarSubR.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEliminarSubR_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminarSubR.MouseLeave
        If btnEliminarSubR.Enabled = True Then
            btnEliminarSubR.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

#End Region

#Region "METODOS PRIVADOS"
    Private Sub Activar()
        btnNuevoRub.Enabled = False
        btnModificarRub.Enabled = False
        btnEliminarRub.Enabled = False
        btnNuevoSubR.Enabled = False
        btnModificarSubR.Enabled = False
        btnEliminarSubR.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True

        btnNuevoRub.BackColor = Color.FromArgb(35, 35, 35)
        btnModificarRub.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminarRub.BackColor = Color.FromArgb(35, 35, 35)
        btnNuevoSubR.BackColor = Color.FromArgb(35, 35, 35)
        btnModificarSubR.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminarSubR.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)

        bnfListRubros.Enabled = False
        bnfListSubRubros.Enabled = False

        UtilidadesDGV.DescargarDGV(dgvRubros)
        UtilidadesDGV.DescargarDGV(dgvSubRubros)
    End Sub

    Private Async Sub Cancelar()
        Notificaciones.arbirFormProceso("CARGADO RUBROS")

        UtilidadesDGV.DescargarDGV(dgvRubros)
        UtilidadesDGV.DescargarDGV(dgvSubRubros)

        listRubo = Await TareasRub.ListadoCompleto()

        If Not IsNothing(listRubo) Then
            UtilidadesDGV.DescargarDGV(dgvRubros)

            TareasRubros.LlenarDGV(dgvRubros, listRubo)

            UtilidadesDGV.CabeceraDGV(dgvRubros)

            Notificaciones.cerrarFormProceso()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(TareasRub.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If

        btnNuevoRub.Enabled = True
        btnModificarRub.Enabled = True
        btnEliminarRub.Enabled = True
        btnNuevoSubR.Enabled = True
        btnModificarSubR.Enabled = True
        btnEliminarSubR.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False

        btnNuevoRub.BackColor = Color.FromArgb(100, 100, 100)
        btnModificarRub.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminarRub.BackColor = Color.FromArgb(100, 100, 100)
        btnNuevoSubR.BackColor = Color.FromArgb(100, 100, 100)
        btnModificarSubR.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminarSubR.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)

        cmbRubro.Visible = False
        txtRubro.Visible = True
        pnlRubro.Enabled = False
        pnlSubRubro.Enabled = False

        UtilidadesTXT.VaciarTxt(Me)
        cmbRubro.Text = ""

        cmbRubro.Items.Clear()

        bnfListRubros.Enabled = True
        bnfListSubRubros.Enabled = True

        btnNuevoRub.Select()
    End Sub

    Private Sub CargarDGV_Rubros()
        dgvRubros.ColumnCount = 5
        dgvRubros.Columns(0).Name = "idRubro"
        dgvRubros.Columns(1).Name = "idUsuario"
        dgvRubros.Columns(2).Name = "Descripcion"
        dgvRubros.Columns(3).Name = "Abrebiatura"
        dgvRubros.Columns(4).Name = "NombreUsuario"

        dgvRubros.Columns("idRubro").Visible = False
        dgvRubros.Columns("idUsuario").Visible = False
        dgvRubros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvRubros.Columns("Descripcion").HeaderText = "RUBRO"
        dgvRubros.Columns("Abrebiatura").HeaderText = "ABREVIATURA"
        dgvRubros.Columns("NombreUsuario").HeaderText = "USUARIO"

        dgvRubros.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvRubros.Columns("Abrebiatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvRubros.Columns("NombreUsuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub CargarDGV_SubRubros()
        dgvSubRubros.ColumnCount = 6
        dgvSubRubros.Columns(0).Name = "idSubRubro"
        dgvSubRubros.Columns(1).Name = "idRubro"
        dgvSubRubros.Columns(2).Name = "idUsuario"
        dgvSubRubros.Columns(3).Name = "Descripcion"
        dgvSubRubros.Columns(4).Name = "Abrebiatura"
        dgvSubRubros.Columns(5).Name = "NombreUsuario"

        dgvSubRubros.Columns("idRubro").Visible = False
        dgvSubRubros.Columns("idSubRubro").Visible = False
        dgvSubRubros.Columns("idUsuario").Visible = False
        dgvSubRubros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvSubRubros.Columns("Descripcion").HeaderText = "SUB RUBRO"
        dgvSubRubros.Columns("Abrebiatura").HeaderText = "ABREVIATURA"
        dgvSubRubros.Columns("NombreUsuario").HeaderText = "USUARIO"

        dgvSubRubros.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvSubRubros.Columns("Abrebiatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvSubRubros.Columns("NombreUsuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
#End Region

#Region "EVENTO LOAD"
    Private Sub Frmcategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TareasRub = New TareasRubros
        TareasSub = New TareasSubRubro

        lblTitulo.Text = "SIGEVA -> " & Date.Now & " -> Ingreso a ALTAS DE CATEGORIAS"

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvRubros)
        UtilidadesDGV.FormatoDGVGeneral(dgvSubRubros)

        CargarDGV_Rubros()
        CargarDGV_SubRubros()

        Cancelar()

        btnNuevoRub.Select()
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnNuevoRub_Click(sender As Object, e As EventArgs) Handles btnNuevoRub.Click
        txtOrigen.Text = "Nuevo_Rubro"

        Activar()

        cmbRubro.Visible = False
        txtRubro.Visible = True
        pnlRubro.Enabled = True

        txtRubro.Select()
    End Sub

    Private Sub BtnNuevoSubR_Click(sender As Object, e As EventArgs) Handles btnNuevoSubR.Click
        txtOrigen.Text = "Nuevo_SubRubro"

        _Dt = UtilidadesDGV.ConvertirDGV_DT(dgvRubros)

        For Each row As DataRow In _Dt.Rows
            cmbRubro.Items.Add(row.Item("Descripcion"))
        Next

        Activar()

        cmbRubro.Visible = True
        txtRubro.Visible = False
        pnlRubro.Enabled = True
        pnlSubRubro.Enabled = True

        cmbRubro.Select()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Async Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtOrigen.Text = "Nuevo_Rubro" Then
            If txtRubro.Text = "" Then
                Notificaciones.MsgBox("No asignaste un nombre para el Rubro.", Botones.OK, Iconos.ERR)

                txtRubro.Select()
            Else
                If txtAbrevRub.Text = "" Then
                    Notificaciones.MsgBox("No asignaste una abreviatura para el Rubro.", Botones.OK, Iconos.ERR)

                    txtAbrevRub.Select()
                Else
                    Dim _rubro As Rubros = New Rubros(txtAbrevRub.Text, txtRubro.Text)

                    Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Rubro ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("GUARDANDO RUBRO")

                        If Await TareasRub.Servicio_Insertar(_rubro) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Rubro guardado con exito !", Botones.OK, Iconos.OK)

                            Cancelar()
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(TareasRub.Err.Descripcion, Botones.OK, Iconos.ERR)
                        End If
                    End If
                End If
            End If
        ElseIf txtOrigen.Text = "Nuevo_SubRubro" Then
            If cmbRubro.Text = "" Or txtAbrevRub.Text = "" Then
                Notificaciones.MsgBox("No seleccionaste el Rubro al que va a pertenecer este Sub Rubro.", Botones.OK, Iconos.ERR)
                cmbRubro.Select()
            Else
                If txtSubrubro.Text = "" Then
                    Notificaciones.MsgBox("No asignaste un nombre para el Sub Rubro.", Botones.OK, Iconos.ERR)
                    txtSubrubro.Select()
                Else
                    If txtAbrevRub.Text = "" Then
                        Notificaciones.MsgBox("No asignaste una abreviatura para el Sub Rubro.", Botones.OK, Iconos.ERR)
                        txtAbrevRub.Select()
                    Else
                        Dim _subRub As SubRubros = New SubRubros(txtAbrevSub.Text, txtSubrubro.Text, txtIdRubro.Text)

                        Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Sub Rubro ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("GUARDANDO SUB RUBRO")

                            If Await TareasSub.Servicio_Insertar(_subRub) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Sub Rubro guardado con exito !", Botones.OK, Iconos.OK)

                                Cancelar()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(TareasSub.Err.Descripcion, Botones.OK, Iconos.ERR)
                            End If
                        End If
                    End If
                End If
            End If
        ElseIf txtOrigen.Text = "Modificar_Rubro" Then
            If txtRubro.Text = "" Then
                Notificaciones.MsgBox("No asignaste un nombre para el Rubro.", Botones.OK, Iconos.ERR)

                txtRubro.Select()
            Else
                If txtAbrevRub.Text = "" Then
                    Notificaciones.MsgBox("No asignaste una abreviatura para el Rubro.", Botones.OK, Iconos.ERR)

                    txtAbrevRub.Select()
                Else
                    Dim _rubro As Rubros = New Rubros(txtAbrevRub.Text, txtRubro.Text)

                    Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Rubro ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("MODIFICANDO RUBRO")

                        _rubro.IdRubro = txtIdRubro.Text

                        If Await TareasRub.Servicio_Modificar(_rubro) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Rubro modificado con exito !", Botones.OK, Iconos.OK)

                            Cancelar()
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(TareasRub.Err.Descripcion, Botones.OK, Iconos.ERR)
                        End If
                    End If
                End If
            End If
        ElseIf txtOrigen.Text = "Modificar_SubRubro" Then
            If cmbRubro.Text = "" Or txtAbrevRub.Text = "" Then
                Notificaciones.MsgBox("No seleccionaste el Rubro al que va a pertenecer este Sub Rubro.", Botones.OK, Iconos.ERR)
                cmbRubro.Select()
            Else
                If txtSubrubro.Text = "" Then
                    Notificaciones.MsgBox("No asignaste un nombre para el Sub Rubro.", Botones.OK, Iconos.ERR)
                    txtSubrubro.Select()
                Else
                    If txtAbrevRub.Text = "" Then
                        Notificaciones.MsgBox("No asignaste una abreviatura para el Sub Rubro.", Botones.OK, Iconos.ERR)
                        txtAbrevRub.Select()
                    Else
                        Dim _subRub As SubRubros = New SubRubros(txtAbrevSub.Text, txtSubrubro.Text, txtIdRubro.Text)

                        Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Sub Rubro ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("MODIFICANDO SUB RUBRO")

                            _subRub.IdSubRubro = txtIdSubRubro.Text

                            If Await TareasSub.Servicio_Modificar(_subRub) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Sub Rubro modificado con exito !", Botones.OK, Iconos.OK)

                                Cancelar()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(TareasSub.Err.Descripcion, Botones.OK, Iconos.ERR)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnEliminarRub_Click(sender As Object, e As EventArgs) Handles btnEliminarRub.Click
        If txtIdRubro.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado ningun Rubro.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Rubro ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO RUBRO")

                If Await TareasRub.Eliminar(txtIdRubro.Text) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Rubro eliminado con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(TareasRub.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Async Sub dgvRubros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellClick
        If e.RowIndex > -1 Then
            txtIdRubro.Text = dgvRubros.CurrentRow.Cells("idRubro").Value

            listSubRubo = Await TareasSub.ListadoCompleto()

            UtilidadesDGV.DescargarDGV(dgvSubRubros)

            For Each item In listSubRubo
                If item.AscRubro.IdRubro = dgvRubros.CurrentRow.Cells("idRubro").Value And item.Descripcion <> dgvRubros.CurrentRow.Cells("Descripcion").Value And item.Abrebiatura <> dgvRubros.CurrentRow.Cells("Abrebiatura").Value Then
                    dgvSubRubros.Rows.Add(item.IdSubRubro, item.AscRubro.IdRubro, item.AscUsuarios.IdUsuario, item.Descripcion, item.Abrebiatura, item.AscUsuarios.Nombre)
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvSubRubros)

            btnModificarRub.Select()
        End If
    End Sub

    Private Sub dgvSubRubros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubRubros.CellClick
        If e.RowIndex > -1 Then
            txtIdSubRubro.Text = dgvSubRubros.CurrentRow.Cells("idSubRubro").Value

            btnModificarSubR.Select()
        End If
    End Sub

    Private Async Sub dgvRubros_CellDoubleClickAsync(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellDoubleClick
        If frmArticulos.Visible Then
            If e.RowIndex > -1 Then
                frmArticulos.listRubros = Await TareasRub.ListadoCompleto

                If Not IsNothing(frmArticulos.listRubros) Then
                    frmArticulos.cmbRubro.Items.Clear()

                    For Each item In frmArticulos.listRubros
                        frmArticulos.cmbRubro.Items.Add(item.Descripcion)
                    Next

                    For Each item In frmArticulos.cmbRubro.Items
                        If item = dgvRubros.CurrentRow.Cells("Descripcion").Value Then
                            frmArticulos.cmbRubro.SelectedItem = item
                            frmArticulos.txtIdRubro.Text = dgvRubros.CurrentRow.Cells("idRubro").Value

                            Exit For
                        End If
                    Next

                    Me.Close()
                Else
                    Notificaciones.MsgBox(TareasRub.Err.Descripcion, Botones.OK, Iconos.ERR)
                    Me.Close()
                    frmArticulos.Dispose()
                End If
            End If
        End If
    End Sub

    Private Async Sub dgvSubRubros_CellDoubleClickAsync(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubRubros.CellDoubleClick
        If frmArticulos.Visible Then
            If e.RowIndex > -1 Then
                Notificaciones.arbirFormProceso()
                frmArticulos.listRubros = Await TareasRub.ListadoCompleto

                If Not IsNothing(frmArticulos.listRubros) Then
                    frmArticulos.cmbRubro.Items.Clear()

                    For Each item In frmArticulos.listRubros
                        frmArticulos.cmbRubro.Items.Add(item.Descripcion)
                    Next


                    frmArticulos.listSubRub = Await TareasSub.ListadoCompleto

                    If Not IsNothing(frmArticulos.listSubRub) Then
                        For Each item In frmArticulos.cmbRubro.Items
                            If item = dgvRubros.CurrentRow.Cells("Descripcion").Value Then
                                frmArticulos.cmbRubro.SelectedItem = item
                                frmArticulos.txtIdRubro.Text = dgvRubros.CurrentRow.Cells("idRubro").Value

                                Exit For
                            End If
                        Next

                        For Each item In frmArticulos.cmbSubRubro.Items
                            If item = dgvSubRubros.CurrentRow.Cells("Descripcion").Value Then
                                frmArticulos.cmbSubRubro.SelectedItem = item
                                frmArticulos.txtIdSubRubro.Text = dgvSubRubros.CurrentRow.Cells("idSubRubro").Value

                                Exit For
                            End If
                        Next

                        Notificaciones.cerrarFormProceso()

                        Me.Close()

                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(TareasSub.Err.Descripcion, Botones.OK, Iconos.ERR)
                        Me.Close()
                        frmArticulos.Dispose()
                    End If
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(TareasRub.Err.Descripcion, Botones.OK, Iconos.ERR)
                    Me.Close()
                    frmArticulos.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub BtnModificarRub_Click(sender As Object, e As EventArgs) Handles btnModificarRub.Click
        If txtIdRubro.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado ningun Rubro.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar_Rubro"

            txtRubro.Text = dgvRubros.CurrentRow.Cells("Descripcion").Value
            txtAbrevRub.Text = dgvRubros.CurrentRow.Cells("Abrebiatura").Value
            txtAbAnt.Text = txtAbrevRub.Text
            txtRubroAnt.Text = txtRubro.Text

            Activar()

            cmbRubro.Visible = False
            txtRubro.Visible = True
            pnlRubro.Enabled = True

            txtRubro.SelectionLength = Len(txtRubro.Text)
            txtRubro.Select()
        End If
    End Sub

    Private Async Sub BtnEliminarSubR_Click(sender As Object, e As EventArgs) Handles btnEliminarSubR.Click
        If txtIdSubRubro.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado ningun SubRubro.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar SubRubro ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO SUB RUBRO")

                If Await TareasSub.Eliminar(txtIdSubRubro.Text) Then
                    Notificaciones.cerrarFormProceso()

                    Notificaciones.MsgBox("SubRubro Eliminado con exito!", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(TareasRub.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Sub BtnModificarSubR_Click(sender As Object, e As EventArgs) Handles btnModificarSubR.Click
        If txtIdSubRubro.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado ningun Sub Rubro.", Botones.OK, Iconos.OK)
        Else
            txtOrigen.Text = "Modificar_SubRubro"

            _Dt = UtilidadesDGV.ConvertirDGV_DT(dgvRubros)

            For Each row As DataRow In _Dt.Rows
                cmbRubro.Items.Add(row.Item("Descripcion"))
            Next

            cmbRubro.Text = dgvRubros.CurrentRow.Cells("Descripcion").Value
            txtAbrevRub.Text = dgvRubros.CurrentRow.Cells("Abrebiatura").Value
            txtSubrubro.Text = dgvSubRubros.CurrentRow.Cells("Descripcion").Value
            txtAbrevSub.Text = dgvSubRubros.CurrentRow.Cells("Abrebiatura").Value
            txtAbAnt.Text = txtAbrevRub.Text
            txtSubRubAnt.Text = txtSubrubro.Text

            Activar()

            cmbRubro.Visible = True
            txtRubro.Visible = False
            pnlRubro.Enabled = True
            pnlSubRubro.Enabled = True

            cmbRubro.SelectionLength = Len(cmbRubro.Text)
            cmbRubro.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub cmbRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbRubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtAbrevRub.SelectionLength = Len(txtAbrevRub.Text)
            txtAbrevRub.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            txtAbrevRub.Text = ""
        End If
    End Sub

    Private Sub txtRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtAbrevRub.SelectionLength = Len(txtAbrevRub.Text)
            txtAbrevRub.Select()
        End If
    End Sub

    Private Sub txtAbrevRub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbrevRub.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtOrigen.Text = "Nuevo_Rubro" Or txtOrigen.Text = "Modificar_Rubro" Then
                btnGuardar.Select()
            Else
                txtSubrubro.SelectionLength = Len(txtSubrubro.Text)
                txtSubrubro.Select()
            End If
        End If
    End Sub

    Private Sub txtSubrubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubrubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtAbrevSub.SelectionLength = Len(txtAbrevSub.Text)
            txtAbrevSub.Select()
        End If
    End Sub

    Private Sub txtAbrevSub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbrevSub.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS TEXT CHANGED"
    Private Sub CmbRubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRubro.SelectedIndexChanged
        If cmbRubro.Text <> "" Then
            txtAbrevRub.Text = _Dt.Rows(cmbRubro.SelectedIndex).Item("Abrebiatura")
        End If
    End Sub

    Private Sub txtAbrevRub_TextChanged(sender As Object, e As EventArgs) Handles txtAbrevRub.TextChanged
        If txtOrigen.Text = "Nuevo_SubRubro" Or txtOrigen.Text = "Modificar_SubRubro" Then
            If txtAbrevRub.Text <> "" Then
                For Each Row As DataRow In _Dt.Rows
                    If Row.Item("Abrebiatura") = txtAbrevRub.Text Then
                        cmbRubro.SelectedItem = Row.Item("Descripcion")
                        Exit For
                    Else
                        cmbRubro.SelectedItem = Nothing
                    End If
                Next
            Else
                cmbRubro.SelectedItem = Nothing
            End If
        End If
    End Sub

#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtAbrevRub_Validated(sender As Object, e As EventArgs) Handles txtAbrevRub.Validated
        If txtOrigen.Text = "Nuevo_SubRubro" Or txtOrigen.Text = "Modificar_SubRubro" Then
            If txtAbrevRub.Text <> "" Then
                If cmbRubro.SelectedItem = Nothing Then
                    Notificaciones.MsgBox("La abreviatura ingresada no corresponde a ningun Rubro.", Botones.OK, Iconos.ERR)
                    cmbRubro.SelectedItem = Nothing
                    txtAbrevRub.Text = ""
                    txtAbrevRub.Select()
                End If
            Else
                cmbRubro.SelectedItem = Nothing
            End If
        End If
    End Sub
#End Region

End Class