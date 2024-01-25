Imports Procesos

Public Class frmListaReservas
    Public listaReservas As New List(Of Pedidos)
    Dim tareaRes As TareasPedidos
    Dim tareaDetRes As TareasPedidosDetalle
    Dim tareaStk As TareasStock

    Public Property Res As New Pedidos

#Region "EVENTO LOAD"
    Private Sub frmListaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Enabled = True

        tareaRes = New TareasPedidos
        tareaDetRes = New TareasPedidosDetalle
        tareaStk = New TareasStock
    End Sub

    Private Async Sub TmrDgvs_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvReservas)

        ConfigDGV_RESERVAS()

        UtilidadesDGV.DescargarDGV(dgvReservas)

        Notificaciones.arbirFormProceso("CARGADO RESERVAS")

        If txtLista.Text = "Completa" Then
            lblTitulo.Text = "LISTA DE RESERVAS CARGADAS"

            listaReservas = Await tareaRes.ListadoCompleto()
        ElseIf txtLista.Text = "Para Modificar" Or txtLista.Text = "Para Eliminar" Then
            If txtLista.Text = "Para Modificar" Then
                lblTitulo.Text = "LISTA DE RESERVAS PARA MODIFICAR"
            Else
                lblTitulo.Text = "LISTA DE RESERVAS PARA ELIMINAR"
            End If

            listaReservas = Await tareaRes.ListadoModElim()
        ElseIf txtLista.Text = "Sin Completar" Then
            lblTitulo.Text = "LISTA DE RESERVAS SIN COMPLETAR"

            listaReservas = Await tareaRes.ListadoSinCompletar()
        End If

        If Not IsNothing(listaReservas) Then
            TareasPedidos.LlenarDGV(dgvReservas, listaReservas)

            UtilidadesDGV.CabeceraDGV(dgvReservas)

            Notificaciones.cerrarFormProceso()

            txtBuscNroRes.Select()
        ElseIf tareaRes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaRes.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("No hay reservas que se puedan Modificar o Eliminar", Botones.OK, Iconos.ALERTA)

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub


#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDGV_RESERVAS()
        dgvReservas.ColumnCount = 7
        dgvReservas.Columns(0).Name = "idPedidos"
        dgvReservas.Columns(1).Name = "idClientes"
        dgvReservas.Columns(2).Name = "idUsuarios"
        dgvReservas.Columns(3).Name = "Fecha"
        dgvReservas.Columns(4).Name = "NroPedido"
        dgvReservas.Columns(5).Name = "Cliente"
        dgvReservas.Columns(6).Name = "Observaciones"

        dgvReservas.Columns("idPedidos").Visible = False
        dgvReservas.Columns("idClientes").Visible = False
        dgvReservas.Columns("idUsuarios").Visible = False

        dgvReservas.Columns("Fecha").HeaderText = "FECHA"
        dgvReservas.Columns("NroPedido").HeaderText = "NRO RESERVA"
        dgvReservas.Columns("Cliente").HeaderText = "CLIENTE"
        dgvReservas.Columns("Observaciones").HeaderText = "OBSERVACIONES"

        dgvReservas.Columns("idPedidos").DisplayIndex = 0
        dgvReservas.Columns("idClientes").DisplayIndex = 1
        dgvReservas.Columns("idUsuarios").DisplayIndex = 2
        dgvReservas.Columns("Fecha").DisplayIndex = 3
        dgvReservas.Columns("NroPedido").DisplayIndex = 4
        dgvReservas.Columns("Cliente").DisplayIndex = 5
        dgvReservas.Columns("Observaciones").DisplayIndex = 6

        dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub dgvRemitos_CellDoubleClickAsync(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservas.CellDoubleClick
        If e.RowIndex > -1 Then
            Res.IdPedidos = dgvReservas.CurrentRow.Cells("idPedidos").Value
            Res.AscClientes.IdCliente = dgvReservas.CurrentRow.Cells("idClientes").Value
            Res.AscUsuarios.IdUsuario = dgvReservas.CurrentRow.Cells("idUsuarios").Value
            Res.Fecha = dgvReservas.CurrentRow.Cells("Fecha").Value
            Res.NroPedido = dgvReservas.CurrentRow.Cells("NroPedido").Value
            Res.Observaciones = dgvReservas.CurrentRow.Cells("Observaciones").Value

            Me.DialogResult = DialogResult.OK

            Me.Close()
        Else
            dgvReservas.CurrentCell = Nothing
        End If
    End Sub

#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtBuscFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscFec.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscNroRem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscNroRes.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtBuscFec.SelectionLength = Len(txtBuscFec.Text)
            txtBuscFec.Select()
        End If
    End Sub

#End Region

#Region "EVENTOS CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscFec.TextChanged, txtBuscNroRes.TextChanged
        Dim listFiltrada As New List(Of Pedidos)

        UtilidadesDGV.DescargarDGV(dgvReservas)

        For Each Item In listaReservas
            If UCase(Item.NroPedido).Contains(UCase(txtBuscNroRes.Text)) And UCase(Item.Fecha).Contains(UCase(txtBuscFec.Text)) Then
                listFiltrada.Add(Item)
            End If
        Next

        TareasPedidos.LlenarDGV(dgvReservas, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvReservas)
    End Sub

#End Region

End Class