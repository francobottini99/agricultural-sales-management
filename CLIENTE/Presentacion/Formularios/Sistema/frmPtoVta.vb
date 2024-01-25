Imports Procesos

Public Class frmPtoVta
    Private listCompleta As List(Of Numeracion)
    Private Tareas As TareasNumeracion

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
        lblTitulo.Text = "SIGEVA -> " & Date.Now & " -> Ingreso a PUNTOS DE VENTA"

        Tareas = New TareasNumeracion()

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvPtoVta)

        ConfigDGV_PTO_VTA()

        Cancelar()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub Activar()
        bnfCardNros.Enabled = True
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

        UtilidadesDGV.DescargarDGV(dgvPtoVta)

        If txtOrigen.Text = "Modificar" And txtPtoVta.Text = "0" Then
            bnfCardDetalle.Enabled = False

            txtNroRes.SelectionLength = Len(txtNroRes.Text)
            txtNroRes.Select()
        Else
            bnfCardDetalle.Enabled = True

            txtPtoVta.SelectionLength = Len(txtPtoVta.Text)
            txtPtoVta.Select()
        End If
    End Sub

    Private Async Sub Cancelar()
        Notificaciones.arbirFormProceso()

        bnfCardNros.Enabled = False
        bnfCardDetalle.Enabled = False
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
            UtilidadesDGV.DescargarDGV(dgvPtoVta)

            TareasNumeracion.LlenarDGV(dgvPtoVta, listCompleta)

            UtilidadesDGV.CabeceraDGV(dgvPtoVta, DataGridViewAutoSizeColumnsMode.DisplayedCells)

            Notificaciones.cerrarFormProceso()

            btnNuevo.Select()
        ElseIf Tareas.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If
    End Sub

    Private Sub ConfigDGV_PTO_VTA()
        dgvPtoVta.ColumnCount = 21
        dgvPtoVta.Columns(0).Name = "idNumeracion"
        dgvPtoVta.Columns(1).Name = "PuntoVenta"
        dgvPtoVta.Columns(2).Name = "Descripcion"
        dgvPtoVta.Columns(3).Name = "NroReserva"
        dgvPtoVta.Columns(4).Name = "NroRemito"
        dgvPtoVta.Columns(5).Name = "NroRecibo"
        dgvPtoVta.Columns(6).Name = "NroOrdenCompra"
        dgvPtoVta.Columns(7).Name = "NroFacturaA"
        dgvPtoVta.Columns(8).Name = "NroFacturaB"
        dgvPtoVta.Columns(9).Name = "NroFacturaC"
        dgvPtoVta.Columns(10).Name = "NroFacturaX"
        dgvPtoVta.Columns(11).Name = "NroNotaCreditoA"
        dgvPtoVta.Columns(12).Name = "NroNotaCreditoB"
        dgvPtoVta.Columns(13).Name = "NroNotaCreditoC"
        dgvPtoVta.Columns(14).Name = "NroNotaCreditoX"
        dgvPtoVta.Columns(15).Name = "NroNotaDebitoA"
        dgvPtoVta.Columns(16).Name = "NroNotaDebitoB"
        dgvPtoVta.Columns(17).Name = "NroNotaDebitoC"
        dgvPtoVta.Columns(18).Name = "NroNotaDebitoX"
        dgvPtoVta.Columns(19).Name = "Eliminado"
        dgvPtoVta.Columns(20).Name = "idUsuario"

        dgvPtoVta.Columns("idNumeracion").Visible = False
        dgvPtoVta.Columns("Eliminado").Visible = False
        dgvPtoVta.Columns("idUsuario").Visible = False

        dgvPtoVta.Columns("PuntoVenta").HeaderText = "PTO. DE VTA."
        dgvPtoVta.Columns("Descripcion").HeaderText = "DESCRIPCION"
        dgvPtoVta.Columns("NroReserva").HeaderText = "NRO RESERVA"
        dgvPtoVta.Columns("NroRemito").HeaderText = "NRO REMITO"
        dgvPtoVta.Columns("NroRecibo").HeaderText = "NRO RECIBO"
        dgvPtoVta.Columns("NroOrdenCompra").HeaderText = "NRO ORD. COM."
        dgvPtoVta.Columns("NroFacturaA").HeaderText = "NRO FAC. ""A"""
        dgvPtoVta.Columns("NroFacturaB").HeaderText = "NRO FAC. ""B"""
        dgvPtoVta.Columns("NroFacturaC").HeaderText = "NRO FAC. ""C"""
        dgvPtoVta.Columns("NroFacturaX").HeaderText = "NRO FAC. ""X"""
        dgvPtoVta.Columns("NroNotaCreditoA").HeaderText = "NRO NC. ""A"""
        dgvPtoVta.Columns("NroNotaCreditoB").HeaderText = "NRO NC. ""B"""
        dgvPtoVta.Columns("NroNotaCreditoC").HeaderText = "NRO NC. ""C"""
        dgvPtoVta.Columns("NroNotaCreditoX").HeaderText = "NRO NC. ""X"""
        dgvPtoVta.Columns("NroNotaDebitoA").HeaderText = "NRO ND. ""A"""
        dgvPtoVta.Columns("NroNotaDebitoB").HeaderText = "NRO ND. ""B"""
        dgvPtoVta.Columns("NroNotaDebitoC").HeaderText = "NRO ND. ""C"""
        dgvPtoVta.Columns("NroNotaDebitoX").HeaderText = "NRO ND. ""X"""

        dgvPtoVta.Columns("idNumeracion").DisplayIndex = 0
        dgvPtoVta.Columns("PuntoVenta").DisplayIndex = 1
        dgvPtoVta.Columns("Descripcion").DisplayIndex = 2
        dgvPtoVta.Columns("NroReserva").DisplayIndex = 3
        dgvPtoVta.Columns("NroRemito").DisplayIndex = 4
        dgvPtoVta.Columns("NroRecibo").DisplayIndex = 5
        dgvPtoVta.Columns("NroOrdenCompra").DisplayIndex = 6
        dgvPtoVta.Columns("NroFacturaA").DisplayIndex = 7
        dgvPtoVta.Columns("NroFacturaB").DisplayIndex = 8
        dgvPtoVta.Columns("NroFacturaC").DisplayIndex = 9
        dgvPtoVta.Columns("NroFacturaX").DisplayIndex = 10
        dgvPtoVta.Columns("NroNotaCreditoA").DisplayIndex = 11
        dgvPtoVta.Columns("NroNotaCreditoB").DisplayIndex = 12
        dgvPtoVta.Columns("NroNotaCreditoC").DisplayIndex = 13
        dgvPtoVta.Columns("NroNotaCreditoX").DisplayIndex = 14
        dgvPtoVta.Columns("NroNotaDebitoA").DisplayIndex = 15
        dgvPtoVta.Columns("NroNotaDebitoB").DisplayIndex = 16
        dgvPtoVta.Columns("NroNotaDebitoC").DisplayIndex = 17
        dgvPtoVta.Columns("NroNotaDebitoX").DisplayIndex = 18
        dgvPtoVta.Columns("Eliminado").DisplayIndex = 19
        dgvPtoVta.Columns("idUsuario").DisplayIndex = 20

        dgvPtoVta.Columns("PuntoVenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvPtoVta.Columns("NroReserva").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroRemito").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroRecibo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroOrdenCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroFacturaA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroFacturaB").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroFacturaC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroFacturaX").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroNotaCreditoA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroNotaCreditoB").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroNotaCreditoC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroNotaCreditoX").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroNotaDebitoA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroNotaDebitoB").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroNotaDebitoC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPtoVta.Columns("NroNotaDebitoX").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvPtoVta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPtoVta.ColumnHeadersVisible = False
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNroRes.Text = 0
        txtNroRem.Text = 0
        txtNroRec.Text = 0
        txtNroOrdCom.Text = 0
        txtNroFacA.Text = 0
        txtNroFacB.Text = 0
        txtNroFacC.Text = 0
        txtNroFacX.Text = 0
        txtNroNCA.Text = 0
        txtNroNCB.Text = 0
        txtNroNCC.Text = 0
        txtNroNCX.Text = 0
        txtNroNDA.Text = 0
        txtNroNDB.Text = 0
        txtNroNDC.Text = 0
        txtNroNDX.Text = 0

        Activar()

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdNumeracion.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Punto de Venta de la lista.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"

            txtPtoVta.Text = dgvPtoVta.CurrentRow.Cells("PuntoVenta").Value
            txtDescripcion.Text = dgvPtoVta.CurrentRow.Cells("Descripcion").Value
            txtNroRes.Text = dgvPtoVta.CurrentRow.Cells("NroReserva").Value
            txtNroRem.Text = dgvPtoVta.CurrentRow.Cells("NroRemito").Value
            txtNroRec.Text = dgvPtoVta.CurrentRow.Cells("NroRecibo").Value
            txtNroOrdCom.Text = dgvPtoVta.CurrentRow.Cells("NroOrdenCompra").Value
            txtNroFacA.Text = dgvPtoVta.CurrentRow.Cells("NroFacturaA").Value
            txtNroFacB.Text = dgvPtoVta.CurrentRow.Cells("NroFacturaB").Value
            txtNroFacC.Text = dgvPtoVta.CurrentRow.Cells("NroFacturaC").Value
            txtNroFacX.Text = dgvPtoVta.CurrentRow.Cells("NroFacturaX").Value
            txtNroNCA.Text = dgvPtoVta.CurrentRow.Cells("NroNotaCreditoA").Value
            txtNroNCB.Text = dgvPtoVta.CurrentRow.Cells("NroNotaCreditoB").Value
            txtNroNCC.Text = dgvPtoVta.CurrentRow.Cells("NroNotaCreditoC").Value
            txtNroNCX.Text = dgvPtoVta.CurrentRow.Cells("NroNotaCreditoX").Value
            txtNroNDA.Text = dgvPtoVta.CurrentRow.Cells("NroNotaDebitoA").Value
            txtNroNDB.Text = dgvPtoVta.CurrentRow.Cells("NroNotaDebitoB").Value
            txtNroNDC.Text = dgvPtoVta.CurrentRow.Cells("NroNotaDebitoC").Value
            txtNroNDX.Text = dgvPtoVta.CurrentRow.Cells("NroNotaDebitoX").Value

            Activar()
        End If
    End Sub

    Private Async Sub BtnEliminar_ClickAsync(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdNumeracion.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un Punto de Venta de la lista.", Botones.OK, Iconos.ALERTA)
        Else
            If txtIdNumeracion.Text = 1 Then
                Notificaciones.MsgBox("El Punto de Venta 0 no puede ser eliminado.", Botones.OK, Iconos.ALERTA)
            Else
                Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Punto de Venta ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                If resp = DialogResult.OK Then
                    Notificaciones.arbirFormProceso("ELIMINANDO PUNTO DE VENTA")

                    If Await Tareas.Eliminar(txtIdNumeracion.Text) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox("Punto de Venta eliminado con exito !", Botones.OK, Iconos.OK)

                        Cancelar()
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                    End If
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtPtoVta.Text = "" Then
            Notificaciones.MsgBox("""PTO. DE VTA."" es un campo obligatorio.", Botones.OK, Iconos.ALERTA)
            txtIdNumeracion.Select()
        Else
            If txtDescripcion.Text = "" Then
                Notificaciones.MsgBox("""DESCRIPCION"" es un campo obligatorio.", Botones.OK, Iconos.ALERTA)
                txtDescripcion.Select()
            Else
                Dim _numeracion As New Numeracion With {
                    .PuntoVenta = txtPtoVta.Text,
                    .Descripcion = txtDescripcion.Text,
                    .NroReserva = txtNroRes.Text,
                    .NroRemito = txtNroRem.Text,
                    .NroRecibo = txtNroRec.Text,
                    .NroOrdenCompra = txtNroOrdCom.Text,
                    .NroFacturaA = txtNroFacA.Text,
                    .NroFacturaB = txtNroFacB.Text,
                    .NroFacturaC = txtNroFacC.Text,
                    .NroFacturaX = txtNroFacX.Text,
                    .NroNotaCreditoA = txtNroNCA.Text,
                    .NroNotaCreditoB = txtNroNCB.Text,
                    .NroNotaCreditoC = txtNroNCC.Text,
                    .NroNotaCreditoX = txtNroNCX.Text,
                    .NroNotaDebitoA = txtNroNDA.Text,
                    .NroNotaDebitoB = txtNroNDB.Text,
                    .NroNotaDebitoC = txtNroNDC.Text,
                    .NroNotaDebitoX = txtNroNDX.Text,
                    .Eliminado = "NO",
                    .AscUsuarios = DatosSesion._Usuario
                }

                If txtOrigen.Text = "Nuevo" Then
                    Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Punto de Venta ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("GUARDANDO PUNTO DE VENTA")

                        If Await Tareas.Insertar(_numeracion) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Punto de Venta guardado con exito !", Botones.OK, Iconos.OK)

                            Cancelar()
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                        End If
                    End If
                ElseIf txtOrigen.Text = "Modificar" Then
                    Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Punto de Venta ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("MODIFICANDO PUNTO DE VENTA")

                        _numeracion.IdNumeracion = CInt(txtIdNumeracion.Text)

                        If Await Tareas.Modificar(_numeracion) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Punto de Venta modificado con exito !", Botones.OK, Iconos.OK)

                            Cancelar()
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(Tareas.Err.Descripcion, Botones.OK, Iconos.ERR)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvPtoVta_CellClickk(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPtoVta.CellClick
        If e.RowIndex > -1 Then
            txtIdNumeracion.Text = dgvPtoVta.CurrentRow.Cells("idNumeracion").Value

            btnModificar.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtPtoVta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPtoVta.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtDescripcion.SelectionLength = Len(txtDescripcion.Text)
            txtDescripcion.Select()
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNroRes.SelectionLength = Len(txtNroRes.Text)
            txtNroRes.Select()
        End If
    End Sub

    Private Sub txtNroRes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroRes.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroRem.SelectionLength = Len(txtNroRem.Text)
            txtNroRem.Select()
        End If
    End Sub

    Private Sub txtNroRem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroRem.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroRec.SelectionLength = Len(txtNroRec.Text)
            txtNroRec.Select()
        End If
    End Sub

    Private Sub txtNroRec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroRec.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroOrdCom.SelectionLength = Len(txtNroOrdCom.Text)
            txtNroOrdCom.Select()
        End If
    End Sub

    Private Sub txtNroOrdCom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroOrdCom.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroFacA.SelectionLength = Len(txtNroFacA.Text)
            txtNroFacA.Select()
        End If
    End Sub

    Private Sub txtNroFacA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroFacA.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroFacB.SelectionLength = Len(txtNroFacB.Text)
            txtNroFacB.Select()
        End If
    End Sub

    Private Sub txtNroFacB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroFacB.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroFacC.SelectionLength = Len(txtNroFacC.Text)
            txtNroFacC.Select()
        End If
    End Sub

    Private Sub txtNroFacC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroFacC.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroFacX.SelectionLength = Len(txtNroFacX.Text)
            txtNroFacX.Select()
        End If
    End Sub

    Private Sub txtNroFacX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroFacX.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroNCA.SelectionLength = Len(txtNroNCA.Text)
            txtNroNCA.Select()
        End If
    End Sub

    Private Sub txtNroNCA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroNCA.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroNCB.SelectionLength = Len(txtNroNCB.Text)
            txtNroNCB.Select()
        End If
    End Sub

    Private Sub txtNroNCB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroNCB.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroNCC.SelectionLength = Len(txtNroNCC.Text)
            txtNroNCC.Select()
        End If
    End Sub

    Private Sub txtNroNCC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroNCC.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroNCX.SelectionLength = Len(txtNroNCX.Text)
            txtNroNCX.Select()
        End If
    End Sub

    Private Sub txtNroNCX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroNCX.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroNDA.SelectionLength = Len(txtNroNDA.Text)
            txtNroNDA.Select()
        End If
    End Sub

    Private Sub txtNroNDA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroNDA.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroNDB.SelectionLength = Len(txtNroNDB.Text)
            txtNroNDB.Select()
        End If
    End Sub

    Private Sub txtNroNDB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroNDB.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroNDC.SelectionLength = Len(txtNroNDC.Text)
            txtNroNDC.Select()
        End If
    End Sub

    Private Sub txtNroNDC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroNDC.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNroNDX.SelectionLength = Len(txtNroNDX.Text)
            txtNroNDX.Select()
        End If
    End Sub

    Private Sub txtNroNDX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroNDX.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnGuardar.Select()
        End If
    End Sub
#End Region

#Region "EVENTO CHANGED"
    Private Sub txtNroRes_TextChanged(sender As Object, e As EventArgs) Handles txtNroRes.TextChanged
        If txtNroRes.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroRes.Text = 0

                txtNroRes.SelectionLength = Len(txtNroRes.Text)
                txtNroRes.Select()
            End If
        End If
    End Sub

    Private Sub txtNroRem_TextChanged(sender As Object, e As EventArgs) Handles txtNroRem.TextChanged
        If txtNroRem.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroRem.Text = 0

                txtNroRem.SelectionLength = Len(txtNroRem.Text)
                txtNroRem.Select()
            End If
        End If
    End Sub

    Private Sub txtNroRec_TextChanged(sender As Object, e As EventArgs) Handles txtNroRec.TextChanged
        If txtNroRec.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroRec.Text = 0

                txtNroRec.SelectionLength = Len(txtNroRec.Text)
                txtNroRec.Select()
            End If
        End If
    End Sub

    Private Sub txtNroOrdCom_TextChanged(sender As Object, e As EventArgs) Handles txtNroOrdCom.TextChanged
        If txtNroOrdCom.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroOrdCom.Text = 0

                txtNroOrdCom.SelectionLength = Len(txtNroOrdCom.Text)
                txtNroOrdCom.Select()
            End If
        End If
    End Sub

    Private Sub txtNroFacA_TextChanged(sender As Object, e As EventArgs) Handles txtNroFacA.TextChanged
        If txtNroFacA.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroFacA.Text = 0

                txtNroFacA.SelectionLength = Len(txtNroFacA.Text)
                txtNroFacA.Select()
            End If
        End If
    End Sub

    Private Sub txtNroFacB_TextChanged(sender As Object, e As EventArgs) Handles txtNroFacB.TextChanged
        If txtNroFacB.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroFacB.Text = 0

                txtNroFacB.SelectionLength = Len(txtNroFacB.Text)
                txtNroFacB.Select()
            End If
        End If
    End Sub

    Private Sub txtNroFacC_TextChanged(sender As Object, e As EventArgs) Handles txtNroFacC.TextChanged
        If txtNroFacC.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroFacC.Text = 0

                txtNroFacC.SelectionLength = Len(txtNroFacC.Text)
                txtNroFacC.Select()
            End If
        End If
    End Sub

    Private Sub txtNroFacX_TextChanged(sender As Object, e As EventArgs) Handles txtNroFacX.TextChanged
        If txtNroFacX.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroFacX.Text = 0

                txtNroFacX.SelectionLength = Len(txtNroFacX.Text)
                txtNroFacX.Select()
            End If
        End If
    End Sub

    Private Sub txtNroNCA_TextChanged(sender As Object, e As EventArgs) Handles txtNroNCA.TextChanged
        If txtNroNCA.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroNCA.Text = 0

                txtNroNCA.SelectionLength = Len(txtNroNCA.Text)
                txtNroNCA.Select()
            End If
        End If
    End Sub

    Private Sub txtNroNCB_TextChanged(sender As Object, e As EventArgs) Handles txtNroNCB.TextChanged
        If txtNroNCB.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroNCB.Text = 0

                txtNroNCB.SelectionLength = Len(txtNroNCB.Text)
                txtNroNCB.Select()
            End If
        End If
    End Sub

    Private Sub txtNroNCC_TextChanged(sender As Object, e As EventArgs) Handles txtNroNCC.TextChanged
        If txtNroNCC.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroNCC.Text = 0

                txtNroNCC.SelectionLength = Len(txtNroNCC.Text)
                txtNroNCC.Select()
            End If
        End If
    End Sub

    Private Sub txtNroNCX_TextChanged(sender As Object, e As EventArgs) Handles txtNroNCX.TextChanged
        If txtNroNCX.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroNCX.Text = 0

                txtNroNCX.SelectionLength = Len(txtNroNCX.Text)
                txtNroNCX.Select()
            End If
        End If
    End Sub

    Private Sub txtNroNDA_TextChanged(sender As Object, e As EventArgs) Handles txtNroNDA.TextChanged
        If txtNroNDA.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroNDA.Text = 0

                txtNroNDA.SelectionLength = Len(txtNroNDA.Text)
                txtNroNDA.Select()
            End If
        End If
    End Sub

    Private Sub txtNroNDB_TextChanged(sender As Object, e As EventArgs) Handles txtNroNDB.TextChanged
        If txtNroNDB.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroNDB.Text = 0

                txtNroNDB.SelectionLength = Len(txtNroNDB.Text)
                txtNroNDB.Select()
            End If
        End If
    End Sub

    Private Sub txtNroNDC_TextChanged(sender As Object, e As EventArgs) Handles txtNroNDC.TextChanged
        If txtNroNDC.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroNDC.Text = 0

                txtNroNDC.SelectionLength = Len(txtNroNDC.Text)
                txtNroNDC.Select()
            End If
        End If
    End Sub

    Private Sub txtNroNDX_TextChanged(sender As Object, e As EventArgs) Handles txtNroNDX.TextChanged
        If txtNroNDX.Text = "" Then
            If bnfCardNros.Enabled = True Then
                txtNroNDX.Text = 0

                txtNroNDX.SelectionLength = Len(txtNroNDX.Text)
                txtNroNDX.Select()
            End If
        End If
    End Sub
#End Region
End Class