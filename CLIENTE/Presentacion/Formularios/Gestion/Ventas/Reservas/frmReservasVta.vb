Imports Procesos

Public Class frmReservasVta
    Private listaClientes As List(Of Clientes)
    Private listaNumeracion As List(Of Numeracion)
    Private listaComprobantes As List(Of Comprobantes)

    Private tareaCom As TareasComprobantes
    Private tareaNum As TareasNumeracion
    Private tareaCli As TareasClientes
    Private tareasRes As TareasPedidos
    Private tareaDetRs As TareasPedidosDetalle
    Private tareaStk As TareasStock

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

    Private Sub btnAgregar_GotFocus(sender As Object, e As EventArgs) Handles btnAgregar.GotFocus
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnAgregar_LostFocus(sender As Object, e As EventArgs) Handles btnAgregar.LostFocus
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnAgregar_MouseEnter(sender As Object, e As EventArgs) Handles btnAgregar.MouseEnter
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEditar_GotFocus(sender As Object, e As EventArgs) Handles btnEditar.GotFocus
        If btnEditar.Enabled = True Then
            btnEditar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEditar_LostFocus(sender As Object, e As EventArgs) Handles btnEditar.LostFocus
        If btnEditar.Enabled = True Then
            btnEditar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEditar_MouseEnter(sender As Object, e As EventArgs) Handles btnEditar.MouseEnter
        If btnEditar.Enabled = True Then
            btnEditar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEditar_MouseLeave(sender As Object, e As EventArgs) Handles btnEditar.MouseLeave
        If btnEditar.Enabled = True Then
            btnEditar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnQuitar_GotFocus(sender As Object, e As EventArgs) Handles btnQuitar.GotFocus
        If btnQuitar.Enabled = True Then
            btnQuitar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnQuitar_LostFocus(sender As Object, e As EventArgs) Handles btnQuitar.LostFocus
        If btnQuitar.Enabled = True Then
            btnQuitar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnQuitar_MouseEnter(sender As Object, e As EventArgs) Handles btnQuitar.MouseEnter
        If btnQuitar.Enabled = True Then
            btnQuitar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnQuitar_MouseLeave(sender As Object, e As EventArgs) Handles btnQuitar.MouseLeave
        If btnQuitar.Enabled = True Then
            btnQuitar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub


#End Region

#Region "EVENTO LOAD"
    Private Sub FrmRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a ALTAS DE RESERVAS (ORDEN DE PEDIDO)"

        tareaCli = New TareasClientes
        tareasRes = New TareasPedidos
        tareaDetRs = New TareasPedidosDetalle
        tareaStk = New TareasStock
        tareaNum = New TareasNumeracion
        tareaCom = New TareasComprobantes

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        listaClientes = Await tareaCli.ListadoCompleto()

        If Not IsNothing(listaClientes) Then
            listaComprobantes = Await tareaCom.ListadoCompleto()

            If IsNothing(listaComprobantes) Then
                If tareaCom.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaCom.Err.Descripcion, Botones.OK, Iconos.ERR)

                    
                    frmPpal.AbrirFrm(frmInicio)
                End If
            End If

            UtilidadesDGV.FormatoDGVGeneral(dgvDetallePedido)

            ConfigDGV_DetallePedido()

            Cancelar()

            Notificaciones.cerrarFormProceso()
        ElseIf tareaCli.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaCli.Err.Descripcion, Botones.OK, Iconos.ERR)

            
            frmPpal.AbrirFrm(frmInicio)
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("No hay Clientes cargados en el Sistema.", Botones.OK, Iconos.ERR)

            
            frmPpal.AbrirFrm(frmInicio)
        End If
    End Sub

#End Region

#Region "METODOS PRIVADOS"
    Private Async Sub Cancelar()
        Notificaciones.arbirFormProceso()

        bnfCardDet.Enabled = False
        bnfCardFec.Enabled = False
        bnfCardProv.Enabled = False
        bnfCardInfoProv.Enabled = False
        bnfCardObs.Enabled = False
        bnfCardNum.Enabled = False

        UtilidadesTXT.VaciarTxt(Me)

        cmbPtoVta.Text = ""

        cmbPtoVta.Enabled = True

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

        dgvDetallePedido.ColumnHeadersVisible = False

        UtilidadesDGV.DescargarDGV(dgvDetallePedido)

        cmbPtoVta.Items.Clear()

        listaNumeracion = Await tareaNum.ListadoCompleto()

        If Not IsNothing(listaNumeracion) Then
            Notificaciones.cerrarFormProceso()

            For Each item In listaNumeracion
                cmbPtoVta.Items.Add(UtilidadesVarias.GenerarPrefijoComprobante(item.PuntoVenta))
            Next
        ElseIf tareaNum.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaNum.Err.Descripcion, Botones.OK, Iconos.ERR)


            frmPpal.AbrirFrm(frmInicio)
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("No hay Puntos de Venta cargados en el Sistema.", Botones.OK, Iconos.ERR)


            frmPpal.AbrirFrm(frmInicio)
        End If

        btnNuevo.Select()
    End Sub

    Private Sub Activar()
        bnfCardDet.Enabled = True
        bnfCardFec.Enabled = True
        bnfCardProv.Enabled = True
        bnfCardInfoProv.Enabled = True
        bnfCardObs.Enabled = True
        bnfCardNum.Enabled = True

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

        txtCtaCli.SelectionLength = Len(txtCtaCli.Text)
        txtCtaCli.Select()
    End Sub

    Private Sub ConfigDGV_DetallePedido()
        dgvDetallePedido.ColumnCount = 5
        dgvDetallePedido.Columns(0).Name = "idArticulos"
        dgvDetallePedido.Columns(1).Name = "CodArt"
        dgvDetallePedido.Columns(2).Name = "Descripcion"
        dgvDetallePedido.Columns(3).Name = "Unidad"
        dgvDetallePedido.Columns(4).Name = "Cantidad"

        dgvDetallePedido.Columns("idArticulos").Visible = False
        dgvDetallePedido.Columns("CodArt").Visible = False

        dgvDetallePedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvDetallePedido.Columns("Descripcion").HeaderText = "DESCRIPCION"
        dgvDetallePedido.Columns("Unidad").HeaderText = "UNIDAD"
        dgvDetallePedido.Columns("Cantidad").HeaderText = "CANTIDAD"

        dgvDetallePedido.Columns("idArticulos").DisplayIndex = 0
        dgvDetallePedido.Columns("CodArt").DisplayIndex = 1
        dgvDetallePedido.Columns("Descripcion").DisplayIndex = 2
        dgvDetallePedido.Columns("Unidad").DisplayIndex = 3
        dgvDetallePedido.Columns("Cantidad").DisplayIndex = 4
    End Sub

#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtOrigen.Text = "Nuevo"

        If listaNumeracion.Count = 1 Then
            cmbPtoVta.Text = UtilidadesVarias.GenerarPrefijoComprobante(listaNumeracion.First.PuntoVenta)
        Else
            cmbPtoVta.Text = DatosSesion._Empresa.PrefijoFacturacion
        End If

        For Each num In listaNumeracion
            If num.PuntoVenta = cmbPtoVta.Text Then
                txtNumRes.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroReserva + 1)

                Exit For
            End If
        Next

        txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        Activar()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmArticuloReserva.Dispose()
        UtilidadesVarias.Escalar(frmArticuloReserva)
        frmArticuloReserva.txtOrigen.Text = "Agregar"

        frmArticuloReserva.ShowDialog()

        If dgvDetallePedido.Rows.Count < 1 Then
            dgvDetallePedido.ColumnHeadersVisible = False
        Else
            dgvDetallePedido.ColumnHeadersVisible = True
        End If

        dgvDetallePedido.CurrentCell = Nothing

        btnAgregar.Select()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvDetallePedido.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            dgvDetallePedido.Rows.Remove(dgvDetallePedido.CurrentRow)

            If dgvDetallePedido.Rows.Count < 1 Then
                dgvDetallePedido.ColumnHeadersVisible = False
            Else
                dgvDetallePedido.ColumnHeadersVisible = True
            End If

            dgvDetallePedido.CurrentCell = Nothing

            btnAgregar.Select()
        End If
    End Sub

    Private Async Sub BtnGuardar_ClickAsync(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtRSCli.Text = "" Then
            Notificaciones.MsgBox("No has especificado un Cliente.", Botones.OK, Iconos.ALERTA)
            txtCtaCli.Select()
        Else
            If dgvDetallePedido.Rows.Count = 0 Then
                Notificaciones.MsgBox("No has introducido ningun articulo a Reservar.", Botones.OK, Iconos.ALERTA)
                btnAgregar.Select()
            Else
                Dim _Numeracion As New Numeracion

                For Each item In listaNumeracion
                    If item.PuntoVenta = cmbPtoVta.Text Then
                        _Numeracion.IdNumeracion = item.IdNumeracion
                        _Numeracion.NroReserva = item.NroReserva + 1
                    End If
                Next

                Dim Pedido As New Pedidos With {
                        .NroPedido = "RES - " + cmbPtoVta.Text + " - " + txtNumRes.Text,
                        .Fecha = txtFec.Text,
                        .FechaCierrePedido = "0001/01/01",
                        .Remitado = "NO",
                        .Facturado = "NO",
                        .Observaciones = txtObservaciones.Text,
                        .Eliminado = "NO",
                        .AscClientes = New Clientes With {.IdCliente = txtCtaCli.Text},
                        .AscUsuarios = DatosSesion._Usuario
                }

                Dim _ListaStock As New List(Of Stock)
                Dim Detalle As New List(Of PedidosDetalle)
                Dim pedidosMovimientos As New List(Of PedidosMovimientos)

                For Each item As DataGridViewRow In dgvDetallePedido.Rows
                    _ListaStock.Add(New Stock With {
                                        .Fecha = txtFec.Text,
                                        .Movimiento = "RESERVA",
                                        .Cantidad = item.Cells("Cantidad").Value,
                                        .Eliminado = "NO",
                                        .AscArticulos = New Articulos With {.IdArticulo = item.Cells("idArticulos").Value},
                                        .AscDepositos = New Depositos With {.IdDeposito = 1},
                                        .AscUsuarios = DatosSesion._Usuario
                            })

                    Detalle.Add(New PedidosDetalle With {
                                                .Cantidad = item.Cells("Cantidad").Value,
                                                .Remitado = "NO",
                                                .Facturado = "NO",
                                                .Eliminado = "NO",
                                                .AscArticulos = New Articulos With {.IdArticulo = item.Cells("idArticulos").Value}
                            })

                    pedidosMovimientos.Add(New PedidosMovimientos With {
                                                .Fecha = Date.Now.Date,
                                                .Tipo = "RESERVA",
                                                .Cantidad = item.Cells("Cantidad").Value,
                                                .Eliminado = "NO",
                                                .AscUsuarios = DatosSesion._Usuario
                                           })
                Next

                If txtObservaciones.Text = "" Then
                    Pedido.Observaciones = "-"
                End If

                If txtOrigen.Text = "Nuevo" Then
                    Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Reserva ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("GUARDANDO RESERVA")

                        If txtObservaciones.Text = "" Then
                            txtObservaciones.Text = "-"
                        End If

                        If Await tareasRes.Servicio_Insertar(Pedido, _Numeracion, _ListaStock, Detalle, pedidosMovimientos) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Reserva guardada con exito !", Botones.OK, Iconos.OK)

                            Cancelar()
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(tareasRes.Err.Descripcion, Botones.OK, Iconos.ERR)

                            If tareasRes.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
                                Cancelar()
                            End If
                        End If
                    End If
                Else
                    Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Reserva ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("MODIFICANDO RESERVA")

                        Pedido.IdPedidos = frmListaReservas.Res.IdPedidos

                        For Each item In Detalle
                            item.AscPedidos.IdPedidos = frmListaReservas.Res.IdPedidos
                        Next

                        If Await tareasRes.Servicio_Modificar(Pedido, _ListaStock, Detalle, pedidosMovimientos) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Reserva modificada con exito !", Botones.OK, Iconos.OK)

                            Cancelar()
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(tareasRes.Err.Descripcion, Botones.OK, Iconos.ERR)

                            If tareasRes.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
                                Cancelar()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnModificar_ClickAsync(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmListaReservas.Dispose()
        UtilidadesVarias.Escalar(frmListaReservas)
        frmListaReservas.txtLista.Text = "Para Modificar"
        Dim Result As DialogResult = frmListaReservas.ShowDialog()

        If Result = DialogResult.OK Then
            Notificaciones.arbirFormProceso()
            Dim DetallePedido As List(Of PedidosDetalle) = Await tareaDetRs.verDetalleReservaPorIDreserv(frmListaReservas.Res.IdPedidos)

            If IsNothing(DetallePedido) Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(tareasRes.Err.Descripcion, Botones.OK, Iconos.ERR)
            Else
                Dim vectoraux() As String = frmListaReservas.Res.NroPedido.Split("-")

                txtOrigen.Text = "Modificar"

                txtCtaCli.Text = frmListaReservas.Res.AscClientes.IdCliente
                txtFec.Text = Format(frmListaReservas.Res.Fecha, "dd/MM/yyyy")
                cmbPtoVta.Text = vectoraux(1)
                txtNumRes.Text = vectoraux(2)
                txtObservaciones.Text = frmListaReservas.Res.Observaciones

                For Each item In DetallePedido
                    dgvDetallePedido.Rows.Add(item.AscArticulos.IdArticulo, item.AscArticulos.CodArticulo, item.AscArticulos.Detalle,
                                              item.AscArticulos.Unidad, item.Cantidad)
                Next

                cmbPtoVta.Enabled = False

                Activar()

                Notificaciones.cerrarFormProceso()

                dgvDetallePedido.ColumnHeadersVisible = True

                dgvDetallePedido.CurrentCell = Nothing
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvDetallePedido.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            frmArticuloReserva.Dispose()
            UtilidadesVarias.Escalar(frmArticuloReserva)
            frmArticuloReserva.txtOrigen.Text = "Editar"

            Dim Result As DialogResult = frmArticuloReserva.ShowDialog()

            If Result = DialogResult.OK Then
                dgvDetallePedido.CurrentCell = Nothing

                btnAgregar.Select()
            End If
        End If
    End Sub

    Private Sub dgvDetalleRemito_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetallePedido.CellClick
        If e.RowIndex > -1 Then
            btnEditar.Select()
        End If
    End Sub

    Private Async Sub BtnEliminar_ClickAsync(sender As Object, e As EventArgs) Handles btnEliminar.Click
        frmListaReservas.Dispose()
        UtilidadesVarias.Escalar(frmListaReservas)
        frmListaReservas.txtLista.Text = "Para Eliminar"
        Dim Result As DialogResult = frmListaReservas.ShowDialog()

        If Result = DialogResult.OK Then
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Reserva ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO PEDIDO")

                Dim _Pedido As New Pedidos With {.IdPedidos = frmListaReservas.Res.IdPedidos}
                Dim _Detalle As New PedidosDetalle With {.AscPedidos = New Pedidos With {.IdPedidos = frmListaReservas.Res.IdPedidos}}

                If Await tareasRes.Servicio_Eliminar(_Pedido, _Detalle) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Pedido eliminado con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareasRes.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If

            End If
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If cmbPtoVta.Enabled Then
                cmbPtoVta.SelectionLength = Len(cmbPtoVta.Text)
                cmbPtoVta.Select()
            Else
                btnAgregar.Select()
            End If
        End If
    End Sub

    Private Sub cmbPtoVta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPtoVta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnAgregar.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCtaCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCtaCli.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtCtaCli.Text <> "" Then
                txtFec.SelectionLength = Len(txtFec.Text)
                txtFec.Select()
            Else
                frmListaClientes.Dispose()
                UtilidadesVarias.Escalar(frmListaClientes)
                frmListaClientes.txtLista.Text = "Completa"

                Dim Result As DialogResult = frmListaClientes.ShowDialog()

                If Result = DialogResult.OK Then
                    txtCtaCli.Text = frmListaClientes.infoCliente.IdCliente
                    txtRSCli.Text = frmListaClientes.infoCliente.RazonSocial
                    txtDirec.Text = frmListaClientes.infoCliente.Direccion
                    txtLoc.Text = frmListaClientes.infoCliente.Localidad
                    txtProv.Text = frmListaClientes.infoCliente.Provincia
                    txtCuit.Text = frmListaClientes.infoCliente.CUIT
                    txtIIBB.Text = frmListaClientes.infoCliente.IIBB
                    txtTE.Text = frmListaClientes.infoCliente.Telefono

                    txtFec.SelectionLength = Len(txtFec.Text)
                    txtFec.Select()
                End If
            End If
        End If
    End Sub

#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtFec_Validated(sender As Object, e As EventArgs) Handles txtFec.Validated
        If Not IsDate(txtFec.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)
            txtFec.Text = ""
        Else
            txtFec.Text = Format(CDate(txtFec.Text), "dd/MM/yyyy")
        End If
    End Sub

    Private Sub txtCtaCli_Validated(sender As Object, e As EventArgs) Handles txtCtaCli.Validated
        If txtCtaCli.Text <> "" And txtRSCli.Text = "" Then
            Notificaciones.MsgBox("No existe un Cliente con ese numero de cuenta..", Botones.OK, Iconos.ALERTA)

            txtCtaCli.SelectionLength = Len(txtCtaCli.Text)
            txtCtaCli.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS CHANGED"
    Private Sub txtFec_TextChanged(sender As Object, e As EventArgs) Handles txtFec.TextChanged
        If txtFec.Text = "" Then
            If bnfCardFec.Enabled = True Then
                txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtFec.SelectionLength = Len(txtFec.Text)
                txtFec.Select()
            End If
        End If
    End Sub

    Private Sub cmbPtoVta_TextChanged(sender As Object, e As EventArgs) Handles cmbPtoVta.TextChanged
        If txtOrigen.Text <> "Modificar" Then
            If cmbPtoVta.Text = "" Then
                If bnfCardNum.Enabled = True Then
                    If listaNumeracion.Count = 1 Then
                        cmbPtoVta.Text = UtilidadesVarias.GenerarPrefijoComprobante(listaNumeracion.First.PuntoVenta)
                    Else
                        cmbPtoVta.Text = DatosSesion._Empresa.PrefijoFacturacion
                    End If

                    For Each num In listaNumeracion
                        If num.PuntoVenta = cmbPtoVta.Text Then
                            txtNumRes.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroReserva + 1)

                            Exit For
                        End If
                    Next

                    cmbPtoVta.SelectionLength = Len(cmbPtoVta.Text)
                    cmbPtoVta.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txtCtaCli_TextChanged(sender As Object, e As EventArgs) Handles txtCtaCli.TextChanged
        txtRSCli.Text = ""
        txtDirec.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtCuit.Text = ""
        txtIIBB.Text = ""
        txtTE.Text = ""

        If txtCtaCli.Text <> "" Then
            For Each item In listaClientes
                If item.IdCliente = txtCtaCli.Text Then
                    txtDirec.Text = item.Direccion
                    txtLoc.Text = item.Localidad
                    txtProv.Text = item.Provincia
                    txtCuit.Text = item.CUIT
                    txtIIBB.Text = item.IIBB
                    txtTE.Text = item.Telefono
                    txtRSCli.Text = item.RazonSocial
                End If
            Next
        End If
    End Sub

    Private Sub cmbPtoVta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPtoVta.SelectedIndexChanged
        If txtOrigen.Text <> "Modificar" Then
            txtNumRes.Text = ""

            For Each num In listaNumeracion
                If num.PuntoVenta = cmbPtoVta.Text Then
                    txtNumRes.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroReserva + 1)

                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

End Class