Imports Procesos
Public Class frmListaClientes
    Dim listaClientes As List(Of Clientes)
    Dim listaReservas As List(Of Pedidos)
    Dim listaDetalleReserva As List(Of PedidosDetalle)
    Dim tareaCli As TareasClientes
    Dim tareasRes As TareasPedidos
    Dim tareaDetPedido As TareasPedidosDetalle

    Public Property infoCliente As Clientes

#Region "EVENTO LOAD"
    Private Sub frmListaClientes_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Enabled = True

        tareaCli = New TareasClientes
        tareasRes = New TareasPedidos
        tareaDetPedido = New TareasPedidosDetalle
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        Dim Est As String = "OK"

        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvClientes)

        ConfigDGV_CLIENTES()

        UtilidadesDGV.DescargarDGV(dgvClientes)

        Notificaciones.arbirFormProceso("CARGANDO CLIENTES")

        If txtLista.Text = "Completa" Then

            lblTitulo.Text = "LISTADO DE CLIENTES CARGADOS"

            listaClientes = Await tareaCli.ListadoCompleto()

            If IsNothing(listaClientes) Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(tareaCli.Err.Descripcion, Botones.OK, Iconos.ERR)

                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            End If
        ElseIf txtLista.Text = "Con Reservas" Then
            'lblTitulo.Text = "LISTADO DE CLIENTES CON RESERVAS PENDIENTES DE REMITAR"

            'listaReservas = Await tareasRes.ListadoCompleto()

            'If Not IsNothing(listaReservas) Then
            '    Dim items As Integer = listaReservas.Count - 1

            '    If items > 0 Then
            '        For j As Integer = items To 0 Step -1
            '            listaDetalleReserva = Await tareaDetPedido.verDetalleReservaPorIDreserv(listaReservas.Item(j).IdPedidos)

            '            For Each Det In listaDetalleReserva
            '                If Det.SaldoPedido = 0 Then
            '                    listaReservas.RemoveAt(j)

            '                    Exit For
            '                End If
            '            Next
            '        Next
            '    End If

            '    If listaReservas.Count > 0 Then
            '        For Each item In listaReservas

            '            Dim Cli As Clientes = Await tareaCli.verClientePorID(item.AscClientes.IdCliente)

            '            If Not IsNothing(Cli) Then
            '                Dim agg As Boolean = True

            '                For Each itemCli In listaClientes
            '                    If itemCli.IdCliente = item.AscClientes.IdCliente Then
            '                        agg = False

            '                        Exit For
            '                    End If
            '                Next

            '                If agg Then
            '                    listaClientes.Add(Cli)
            '                End If
            '            Else
            '                Est = "Err"
            '                Exit For
            '            End If
            '        Next
            '    End If
            'Else
            '    Notificaciones.cerrarFormProceso()
            '    Notificaciones.MsgBox(tareasRes.Err.Descripcion, Botones.OK, Iconos.ERR)

            '    Me.DialogResult = DialogResult.Cancel
            '    Me.Close()
            'End If
        End If

        If Est = "OK" Then
            If Not IsNothing(listaClientes) Then
                TareasClientes.LlenarDGV(dgvClientes, listaClientes)

                UtilidadesDGV.CabeceraDGV(dgvClientes, DataGridViewAutoSizeColumnsMode.DisplayedCells)

                Notificaciones.cerrarFormProceso()
            Else
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox("No hay Clientes con reservas pendientes de remitar.", Botones.OK, Iconos.ERR)

                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            End If
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaCli.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDGV_CLIENTES()
        dgvClientes.ColumnCount = 20
        dgvClientes.Columns(0).Name = "idClientes"
        dgvClientes.Columns(1).Name = "FechaAlta"
        dgvClientes.Columns(2).Name = "RazónSocial"
        dgvClientes.Columns(3).Name = "Dirección"
        dgvClientes.Columns(4).Name = "Localidad"
        dgvClientes.Columns(5).Name = "Provincia"
        dgvClientes.Columns(6).Name = "CP"
        dgvClientes.Columns(7).Name = "País"
        dgvClientes.Columns(8).Name = "Teléfono"
        dgvClientes.Columns(9).Name = "Mail"
        dgvClientes.Columns(10).Name = "Web"
        dgvClientes.Columns(11).Name = "CUIT"
        dgvClientes.Columns(12).Name = "IIBB"
        dgvClientes.Columns(13).Name = "SituacionIVA"
        dgvClientes.Columns(14).Name = "CreditoAsignado"
        dgvClientes.Columns(15).Name = "CreditoConsumido"
        dgvClientes.Columns(16).Name = "Estado"
        dgvClientes.Columns(17).Name = "Clasificacion"
        dgvClientes.Columns(18).Name = "Eliminado"
        dgvClientes.Columns(19).Name = "Usuarios_idUsuarios"

        dgvClientes.Columns("IIBB").Visible = False
        dgvClientes.Columns("SituacionIVA").Visible = False
        dgvClientes.Columns("Eliminado").Visible = False
        dgvClientes.Columns("Usuarios_idUsuarios").Visible = False
        dgvClientes.Columns("CreditoAsignado").Visible = False
        dgvClientes.Columns("CreditoConsumido").Visible = False

        dgvClientes.Columns("idClientes").HeaderText = "NRO CTA"
        dgvClientes.Columns("FechaAlta").HeaderText = "FEC. ALTA"
        dgvClientes.Columns("RazónSocial").HeaderText = "RAZON SOCIAL"
        dgvClientes.Columns("Dirección").HeaderText = "DIRECCION"
        dgvClientes.Columns("Localidad").HeaderText = "LOCALIDAD"
        dgvClientes.Columns("Provincia").HeaderText = "PROVINCIA"
        dgvClientes.Columns("CP").HeaderText = "COD POSTAL"
        dgvClientes.Columns("País").HeaderText = "PAIS"
        dgvClientes.Columns("Teléfono").HeaderText = "TELEFONO"
        dgvClientes.Columns("Mail").HeaderText = "MAIL"
        dgvClientes.Columns("Web").HeaderText = "WEB"
        dgvClientes.Columns("CUIT").HeaderText = "CUIT"
        dgvClientes.Columns("Estado").HeaderText = "ESTADO"
        dgvClientes.Columns("Clasificacion").HeaderText = "CLASIFICACION"

        dgvClientes.Columns("idClientes").DisplayIndex = 0
        dgvClientes.Columns("FechaAlta").DisplayIndex = 1
        dgvClientes.Columns("RazónSocial").DisplayIndex = 2
        dgvClientes.Columns("CUIT").DisplayIndex = 3
        dgvClientes.Columns("Dirección").DisplayIndex = 4
        dgvClientes.Columns("Localidad").DisplayIndex = 5
        dgvClientes.Columns("Provincia").DisplayIndex = 6
        dgvClientes.Columns("CP").DisplayIndex = 7
        dgvClientes.Columns("País").DisplayIndex = 8
        dgvClientes.Columns("Teléfono").DisplayIndex = 9
        dgvClientes.Columns("Mail").DisplayIndex = 10
        dgvClientes.Columns("Web").DisplayIndex = 11
        dgvClientes.Columns("Estado").DisplayIndex = 12
        dgvClientes.Columns("Clasificacion").DisplayIndex = 13

        dgvClientes.Columns("idClientes").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvClientes.Columns("FechaAlta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvClientes.Columns("RazónSocial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("CUIT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvClientes.Columns("Dirección").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Localidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Provincia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("CP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvClientes.Columns("País").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Teléfono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Mail").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Web").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvClientes.Columns("Estado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvClientes.Columns("Clasificacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvClientes.ColumnHeadersVisible = False
    End Sub


#End Region

#Region "EVENTOS CHANGED"
    Private Sub TxtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles txtRazonSocial.TextChanged
        Dim listFiltrada As New List(Of Clientes)

        UtilidadesDGV.DescargarDGV(dgvClientes)

        For Each Item In listaClientes
            If UCase(Item.RazonSocial).Contains(UCase(txtRazonSocial.Text)) Then
                listFiltrada.Add(Item)
            End If
        Next

        TareasClientes.LlenarDGV(dgvClientes, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvClientes, DataGridViewAutoSizeColumnsMode.DisplayedCells)
    End Sub


#End Region

#Region "EVENTOS CLICK"
    Private Sub dgvProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        If e.RowIndex > -1 Then
            infoCliente = New Clientes With {
                .IdCliente = dgvClientes.CurrentRow.Cells("idClientes").Value,
                .FechaAlta = dgvClientes.CurrentRow.Cells("FechaAlta").Value,
                .RazonSocial = dgvClientes.CurrentRow.Cells("RazónSocial").Value,
                .Direccion = dgvClientes.CurrentRow.Cells("Dirección").Value,
                .Localidad = dgvClientes.CurrentRow.Cells("Localidad").Value,
                .Provincia = dgvClientes.CurrentRow.Cells("Provincia").Value,
                .CodPostal = dgvClientes.CurrentRow.Cells("CP").Value,
                .Pais = dgvClientes.CurrentRow.Cells("País").Value,
                .Telefono = dgvClientes.CurrentRow.Cells("Teléfono").Value,
                .Mail = dgvClientes.CurrentRow.Cells("Mail").Value,
                .Web = dgvClientes.CurrentRow.Cells("Web").Value,
                .CUIT = dgvClientes.CurrentRow.Cells("CUIT").Value,
                .IIBB = dgvClientes.CurrentRow.Cells("IIBB").Value,
                .SituacionIVA = dgvClientes.CurrentRow.Cells("SituacionIVA").Value,
                .CreditoAsignado = UtilidadesVarias.SoloNumeros(dgvClientes.CurrentRow.Cells("CreditoAsignado").Value),
                .CreditoConsumido = UtilidadesVarias.SoloNumeros(dgvClientes.CurrentRow.Cells("CreditoConsumido").Value),
                .Estado = dgvClientes.CurrentRow.Cells("Estado").Value,
                .Clasificacion = dgvClientes.CurrentRow.Cells("Clasificacion").Value,
                .Eliminado = dgvClientes.CurrentRow.Cells("Eliminado").Value,
                .AscUsuarios = New Usuario With {.IdUsuario = dgvClientes.CurrentRow.Cells("Usuarios_idUsuarios").Value}
            }

            Me.DialogResult = DialogResult.OK

            Me.Close()
        End If
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub
#End Region

End Class