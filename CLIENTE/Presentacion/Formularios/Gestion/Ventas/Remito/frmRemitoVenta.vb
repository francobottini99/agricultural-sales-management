Imports Procesos

Public Class frmRemitoVenta
    Private listadoClientes As List(Of Clientes)
    Private listadoNumeracion As List(Of Numeracion)
    Private listadoComprobantes As List(Of Comprobantes)
    Private infoCliente As Clientes

    Private tareasComprobantes As TareasComprobantes
    Private tareasNumeracion As TareasNumeracion
    Private tareasClientes As TareasClientes
    Private tareasRamitoVenta As TareasRemitoVenta
    Private tareasRemitoVentaMoneda As TareasRemitoVentaMoneda
    Private tareasMovimientosRemitoFactura As TareasMovimientos_Remito_Factura
    Private tareasRemitosVentaMovimientos As TareasRemitoVentaMovimientos
    Private tareasMovimientosReservaRemito As TareasMovimientos_Reserva_Remito

    Private fijarCantRet As Dictionary(Of Integer, Double)
    Private fijarStockFisico As Dictionary(Of CKey, Double)
    Private fijarDetPed As List(Of PedidosDetalle)
    Private fijarDetFac As List(Of FacturaVentaDetalle)

    Public Structure CKey
        Public idArt As Integer
        Public idDep As Integer
    End Structure

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

#Region "LOAD"
    Private Sub FrmRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a REMITOS DE VENTA"

        tareasClientes = New TareasClientes()
        tareasNumeracion = New TareasNumeracion()
        tareasRamitoVenta = New TareasRemitoVenta()
        tareasRemitoVentaMoneda = New TareasRemitoVentaMoneda()
        tareasMovimientosRemitoFactura = New TareasMovimientos_Remito_Factura()
        tareasMovimientosReservaRemito = New TareasMovimientos_Reserva_Remito()
        tareasRemitosVentaMovimientos = New TareasRemitoVentaMovimientos()
        tareasComprobantes = New TareasComprobantes()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        listadoClientes = Await tareasClientes.ListadoCompleto()

        If Not IsNothing(listadoClientes) Then
            listadoComprobantes = Await tareasComprobantes.ListadoCompleto()

            If IsNothing(listadoComprobantes) Then
                If tareasComprobantes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareasComprobantes.Err.Descripcion, Botones.OK, Iconos.ERR)

                    
                    frmPpal.AbrirFrm(frmInicio)
                End If
            End If

            UtilidadesDGV.FormatoDGVGeneral(dgvDetalleRemito)

            ConfigDGV_DetalleRemito()

            Cancelar()

            Notificaciones.cerrarFormProceso()
        ElseIf tareasClientes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareasClientes.Err.Descripcion, Botones.OK, Iconos.ERR)

            frmPpal.AbrirFrm(frmInicio)
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("No hay Clientes cargados en el Sistema.", Botones.OK, Iconos.ERR)

            frmPpal.AbrirFrm(frmInicio)
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Public Async Sub Cancelar()
        bnfCardDetalleRem.Enabled = False
        bnfCardFec.Enabled = False
        bnfCardClie.Enabled = False
        bnfCardInfoClie.Enabled = False
        bnfCardObs.Enabled = False
        bnfCardNum.Enabled = False
        bnfCardTc.Enabled = False

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

        dgvDetalleRemito.ColumnHeadersVisible = False

        UtilidadesDGV.DescargarDGV(dgvDetalleRemito)

        cmbPtoVta.Items.Clear()

        listadoNumeracion = Await tareasNumeracion.ListadoCompleto()

        If Not IsNothing(listadoNumeracion) Then
            Notificaciones.cerrarFormProceso()

            For Each item In listadoNumeracion
                cmbPtoVta.Items.Add(UtilidadesVarias.GenerarPrefijoComprobante(item.PuntoVenta))
            Next
        ElseIf tareasNumeracion.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareasNumeracion.Err.Descripcion, Botones.OK, Iconos.ERR)


            frmPpal.AbrirFrm(frmInicio)
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("No hay Puntos de Venta cargados en el Sistema.", Botones.OK, Iconos.ERR)


            frmPpal.AbrirFrm(frmInicio)
        End If

        btnNuevo.Select()
    End Sub

    Private Sub Activar()
        If txtOrigen.Text = "Nuevo" Then
            txtTC.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
            lblBanco.Text = "BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha
        End If

        bnfCardDetalleRem.Enabled = True
        bnfCardFec.Enabled = True
        bnfCardClie.Enabled = True
        bnfCardInfoClie.Enabled = True
        bnfCardObs.Enabled = True
        bnfCardNum.Enabled = True
        bnfCardTc.Enabled = True

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

        Importe()

        If txtOrigen.Text = "Nuevo" Then
            txtCtaCli.Enabled = True
            txtCtaCli.SelectionLength = Len(txtCtaCli.Text)
            txtCtaCli.Select()
        Else
            txtCtaCli.Enabled = False
            txtFec.SelectionLength = Len(txtFec.Text)
            txtFec.Select()
        End If
    End Sub

    Private Sub ConfigDGV_DetalleRemito()
        dgvDetalleRemito.ColumnCount = 17
        dgvDetalleRemito.Columns(0).Name = "idArticulo"
        dgvDetalleRemito.Columns(1).Name = "idDeposito"
        dgvDetalleRemito.Columns(2).Name = "idPedido"
        dgvDetalleRemito.Columns(3).Name = "idPedidosDetalle"
        dgvDetalleRemito.Columns(4).Name = "idFactura"
        dgvDetalleRemito.Columns(5).Name = "idFacturaDetalle"
        dgvDetalleRemito.Columns(6).Name = "CodArt"
        dgvDetalleRemito.Columns(7).Name = "Descripcion"
        dgvDetalleRemito.Columns(8).Name = "Unidad"
        dgvDetalleRemito.Columns(9).Name = "Precio"
        dgvDetalleRemito.Columns(10).Name = "Cantidad"
        dgvDetalleRemito.Columns(11).Name = "CantidadReservada"
        dgvDetalleRemito.Columns(12).Name = "Importe"
        dgvDetalleRemito.Columns(13).Name = "AlicuotaIVA"
        dgvDetalleRemito.Columns(14).Name = "ImporteNeto"
        dgvDetalleRemito.Columns(15).Name = "Deposito"
        dgvDetalleRemito.Columns(16).Name = "Origen"

        dgvDetalleRemito.Columns("idArticulo").Visible = False
        dgvDetalleRemito.Columns("idDeposito").Visible = False
        dgvDetalleRemito.Columns("idPedido").Visible = False
        dgvDetalleRemito.Columns("idPedidosDetalle").Visible = False
        dgvDetalleRemito.Columns("idFactura").Visible = False
        dgvDetalleRemito.Columns("idFacturaDetalle").Visible = False
        dgvDetalleRemito.Columns("CodArt").Visible = False
        dgvDetalleRemito.Columns("CantidadReservada").Visible = False

        'dgvDetalleRemito.Columns("CodArt").HeaderText = "COD. ART."
        dgvDetalleRemito.Columns("Descripcion").HeaderText = "DESCRIPCION"
        dgvDetalleRemito.Columns("Unidad").HeaderText = "UNIDAD"
        dgvDetalleRemito.Columns("Precio").HeaderText = "PRECIO"
        dgvDetalleRemito.Columns("Cantidad").HeaderText = "CANTIDAD"
        dgvDetalleRemito.Columns("Importe").HeaderText = "IMPORTE"
        dgvDetalleRemito.Columns("AlicuotaIVA").HeaderText = "ALICUOTA IVA"
        dgvDetalleRemito.Columns("ImporteNeto").HeaderText = "IMPORTE NETO"
        dgvDetalleRemito.Columns("Deposito").HeaderText = "DEPOSITO"
        dgvDetalleRemito.Columns("Origen").HeaderText = "ORIGEN"

        dgvDetalleRemito.Columns("idArticulo").DisplayIndex = 0
        dgvDetalleRemito.Columns("idDeposito").DisplayIndex = 1
        dgvDetalleRemito.Columns("idPedido").DisplayIndex = 2
        dgvDetalleRemito.Columns("idPedidosDetalle").DisplayIndex = 3
        dgvDetalleRemito.Columns("idFactura").DisplayIndex = 4
        dgvDetalleRemito.Columns("idFacturaDetalle").DisplayIndex = 5
        dgvDetalleRemito.Columns("CodArt").DisplayIndex = 6
        dgvDetalleRemito.Columns("Descripcion").DisplayIndex = 7
        dgvDetalleRemito.Columns("Unidad").DisplayIndex = 8
        dgvDetalleRemito.Columns("Precio").DisplayIndex = 9
        dgvDetalleRemito.Columns("Cantidad").DisplayIndex = 10
        dgvDetalleRemito.Columns("CantidadReservada").DisplayIndex = 11
        dgvDetalleRemito.Columns("Importe").DisplayIndex = 12
        dgvDetalleRemito.Columns("AlicuotaIVA").DisplayIndex = 13
        dgvDetalleRemito.Columns("ImporteNeto").DisplayIndex = 14
        dgvDetalleRemito.Columns("Deposito").DisplayIndex = 15
        dgvDetalleRemito.Columns("Origen").DisplayIndex = 16

        dgvDetalleRemito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvDetalleRemito.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvDetalleRemito.Columns("Deposito").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub Importe()
        Dim imp As Double = 0
        Dim impNeto As Double = 0

        For Each item As DataGridViewRow In dgvDetalleRemito.Rows
            imp += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
            impNeto = impNeto + UtilidadesVarias.SoloNumeros(item.Cells("ImporteNeto").Value)
        Next

        txtSubTotalP.Text = Format(imp, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtTotalP.Text = Format(impNeto, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtIVAP.Text = Format(impNeto - imp, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtSubTotalC.Text = Format(imp * UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        txtTotalC.Text = Format(impNeto * UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        txtIVAC.Text = Format((impNeto - imp) * UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnNuevo_ClickAsync(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtOrigen.Text = "Nuevo"

        If listadoNumeracion.Count = 1 Then
            cmbPtoVta.Text = UtilidadesVarias.GenerarPrefijoComprobante(listadoNumeracion.First.PuntoVenta)
        Else
            cmbPtoVta.Text = DatosSesion._Empresa.PrefijoFacturacion
        End If

        For Each num In listadoNumeracion
            If num.PuntoVenta = cmbPtoVta.Text Then
                txtNumRem.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroRemito + 1)

                Exit For
            End If
        Next

        txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        Activar()
    End Sub

    Private Async Sub BtnGuardar_ClickAsync(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtRScli.Text = "" Then
            Notificaciones.MsgBox("No has especificado un Cliente.", Botones.OK, Iconos.ERR)
            txtCtaCli.Select()
        Else
            If dgvDetalleRemito.Rows.Count = 0 Then
                Notificaciones.MsgBox("No has introducido el detalle del remito.", Botones.OK, Iconos.ERR)
                btnAgregar.Select()
            Else
                Dim _DetalleRemitoVenta As New List(Of DetalleRemitoVenta)
                Dim _RemitosVentaMovimientos As New List(Of RemitoVentaMovimientos)
                Dim _Movimientos_Remito_Factura As New List(Of Movimientos_Remito_Factura)
                Dim _Movimientos_Reserva_Remito As New List(Of Movimientos_Reserva_Remito)
                Dim _PedidosMovimientos As New List(Of PedidosMovimientos)
                Dim _FacturaVentaMovimientos As New List(Of FacturaVentaMovimientos)

                If txtObservaciones.Text = "" Then
                    txtObservaciones.Text = "-"
                End If

                Dim _RemitoVenta As New RemitoVenta With {
                                .NroComprobante = "REM - " + cmbPtoVta.Text + " - " + txtNumRem.Text,
                                .Fecha = txtFec.Text,
                                .Importe = UtilidadesVarias.SoloNumeros(txtSubTotalP.Text),
                                .Observaciones = txtObservaciones.Text,
                                .ImpOriginal = 0,
                                .ImpCopia = 0,
                                .Facturado = "NO",
                                .Eliminado = "NO",
                                .CAE = "-",
                                .FechaVtoCAE = "0001-01-01",
                                .AscClientes = New Clientes With {.IdCliente = txtCtaCli.Text},
                                .AscUsuarios = DatosSesion._Usuario
                            }

                Dim _RemitoVentaMonedas As New RemitoVentaMonedas With {
                                .TipoCambio = UtilidadesVarias.SoloNumeros(txtTC.Text),
                                .ImporteNeto = UtilidadesVarias.SoloNumeros(txtSubTotalC.Text),
                                .DescuentoGral = 0,
                                .BaseImponible = UtilidadesVarias.SoloNumeros(txtSubTotalC.Text),
                                .IVA = UtilidadesVarias.SoloNumeros(txtIVAC.Text),
                                .ImporteTotal = UtilidadesVarias.SoloNumeros(txtTotalC.Text),
                                .Eliminado = "NO"
                            }

                For Each item As DataGridViewRow In dgvDetalleRemito.Rows
                    _DetalleRemitoVenta.Add(New DetalleRemitoVenta With {
                                                .Descripcion = item.Cells("Descripcion").Value,
                                                .Cantidad = item.Cells("Cantidad").Value,
                                                .Unidad = item.Cells("Unidad").Value,
                                                .Precio = UtilidadesVarias.SoloNumeros(item.Cells("Precio").Value),
                                                .Importe = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                                                .AlicuotaIVA = UtilidadesVarias.SoloNumeros(item.Cells("AlicuotaIVA").Value),
                                                .Facturado = "NO",
                                                .Eliminado = "NO",
                                                .AscArticulos = New Articulos With {.IdArticulo = item.Cells("idArticulo").Value}
                                            })

                    _RemitosVentaMovimientos.Add(New RemitoVentaMovimientos With {
                                                    .Fecha = Date.Now.Date,
                                                    .Tipo = "REMITADO",
                                                    .Cantidad = item.Cells("Cantidad").Value,
                                                    .Eliminado = "NO",
                                                    .AscUsuarios = DatosSesion._Usuario,
                                                    .AscStock = New Stock With {
                                                        .Fecha = Date.Now.Date,
                                                        .Cantidad = -item.Cells("Cantidad").Value,
                                                        .Eliminado = "NO",
                                                        .AscArticulos = New Articulos With {
                                                            .IdArticulo = item.Cells("idArticulo").Value,
                                                            .Detalle = item.Cells("Descripcion").Value
                                                        },
                                                        .AscDepositos = New Depositos With {.IdDeposito = item.Cells("idDeposito").Value},
                                                        .AscUsuarios = DatosSesion._Usuario
                                                    }
                                                 })

                    _PedidosMovimientos.Add(New PedidosMovimientos With {
                                                .Fecha = Date.Now.Date,
                                                .Tipo = "RETIRO",
                                                .Cantidad = item.Cells("Cantidad").Value,
                                                .Eliminado = "NO",
                                                .AscPedidosDetalle = New PedidosDetalle With {
                                                    .IdPedidosDetalle = item.Cells("idPedidosDetalle").Value,
                                                    .AscPedidos = New Pedidos With {.IdPedidos = item.Cells("idPedido").Value}
                                                },
                                                .AscUsuarios = DatosSesion._Usuario
                                            })

                    _FacturaVentaMovimientos.Add(New FacturaVentaMovimientos With {
                                                    .Fecha = Date.Now.Date,
                                                    .Tipo = "REMITADO",
                                                    .Cantidad = item.Cells("Cantidad").Value,
                                                    .Eliminado = "NO",
                                                    .AscFacturaVentaDetalle = New FacturaVentaDetalle With {
                                                        .IdFacturaVentaDetalle = item.Cells("idFacturaDetalle").Value,
                                                        .AscFacturaVenta = New FacturaVenta With {.IdFacturaVenta = item.Cells("idFactura").Value}
                                                    },
                                                    .AscUsuarios = DatosSesion._Usuario
                                                })

                    _Movimientos_Reserva_Remito.Add(New Movimientos_Reserva_Remito With {
                                                        .Fecha = Date.Now.Date,
                                                        .Tipo = "REMITADO",
                                                        .Cantidad = item.Cells("Cantidad").Value,
                                                        .Eliminado = "NO"
                                                    })

                    _Movimientos_Remito_Factura.Add(New Movimientos_Remito_Factura With {
                                                        .Fecha = Date.Now.Date,
                                                        .Tipo = "REMITADO",
                                                        .Cantidad = item.Cells("Cantidad").Value,
                                                        .Eliminado = "NO"
                                                    })
                Next

                If txtOrigen.Text = "Nuevo" Then
                    Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Remito de Venta ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("GUARDANDO REMITO DE VENTA")

                        Dim _Numeracion As New Numeracion

                        For Each item In listadoNumeracion
                            If item.PuntoVenta = cmbPtoVta.Text Then
                                _Numeracion.IdNumeracion = item.IdNumeracion
                                _Numeracion.NroRemito = item.NroRemito + 1
                            End If
                        Next

                        If Await tareasRamitoVenta.Servicio_Insertar(_RemitoVenta, _RemitoVentaMonedas, _Numeracion, _DetalleRemitoVenta, _RemitosVentaMovimientos, _PedidosMovimientos, _FacturaVentaMovimientos, _Movimientos_Reserva_Remito, _Movimientos_Remito_Factura) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Remito de venta guardado con exito !", Botones.OK, Iconos.OK)

                            resp = Notificaciones.MsgBox("Desea imprimir el remito ?", Botones.SI_NO, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                UtilidadesVarias.Escalar(frmReporte)

                                frmReporte.rvReporte.Reset()

                                frmReporte.rvReporte.LocalReport.ReportPath = Reportes.RPT_REMITO_VENTA

                                frmReporte.rvReporte.LocalReport.DataSources.Clear()
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEmpresa", New BindingSource() With {.DataSource = DatosSesion._Empresa}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsCliente", New BindingSource() With {.DataSource = infoCliente}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsRemitoVenta", New BindingSource() With {.DataSource = _RemitoVenta}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsDetalleRemVta", New BindingSource() With {.DataSource = _DetalleRemitoVenta}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsComprobantes", New BindingSource() With {.DataSource = New Comprobantes()}))

                                frmReporte.rvReporte.LocalReport.Refresh()
                                frmReporte.rvReporte.RefreshReport()
                            Else
                                Cancelar()
                            End If
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(tareasRamitoVenta.Err.Descripcion & " - " & tareasRamitoVenta.Err.Identificador.ToString, Botones.OK, Iconos.ERR)

                            If tareasRamitoVenta.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
                                Cancelar()
                            End If
                        End If
                    End If
                ElseIf txtOrigen.Text = "Modificar" Then
                    Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Remito de Venta ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("MODIFICANDO REMITO DE VENTA")

                        _RemitoVenta.IdRemitosVenta = txtIdRemitoVta.Text
                        _RemitoVentaMonedas.AscRemitosventa.IdRemitosVenta = _RemitoVenta.IdRemitosVenta

                        For Each item In _DetalleRemitoVenta
                            item.AscRemitosVenta.IdRemitosVenta = _RemitoVenta.IdRemitosVenta
                        Next

                        If Await tareasRamitoVenta.Servicio_Modificar(_RemitoVenta, _RemitoVentaMonedas, _DetalleRemitoVenta, _RemitosVentaMovimientos, _PedidosMovimientos, _FacturaVentaMovimientos, _Movimientos_Reserva_Remito, _Movimientos_Remito_Factura) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Remito de venta modificado con exito !", Botones.OK, Iconos.OK)

                            resp = Notificaciones.MsgBox("Desea imprimir el remito ?", Botones.SI_NO, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                UtilidadesVarias.Escalar(frmReporte)

                                frmReporte.rvReporte.Reset()

                                frmReporte.rvReporte.LocalReport.ReportPath = Reportes.RPT_REMITO_VENTA

                                frmReporte.rvReporte.LocalReport.DataSources.Clear()
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEmpresa", New BindingSource() With {.DataSource = DatosSesion._Empresa}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsCliente", New BindingSource() With {.DataSource = infoCliente}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsRemitoVenta", New BindingSource() With {.DataSource = _RemitoVenta}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsDetalleRemVta", New BindingSource() With {.DataSource = _DetalleRemitoVenta}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsComprobantes", New BindingSource() With {.DataSource = New Comprobantes()}))

                                frmReporte.rvReporte.LocalReport.Refresh()
                                frmReporte.rvReporte.RefreshReport()
                            Else
                                Cancelar()
                            End If
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(tareasRamitoVenta.Err.Descripcion, Botones.OK, Iconos.ERR)

                            If tareasRamitoVenta.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
                                Cancelar()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnModificar_ClickAsync(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmListaRemitosVenta.Dispose()
        UtilidadesVarias.Escalar(frmListaRemitosVenta)
        frmListaRemitosVenta.txtLista.Text = "Completa"

        Dim Result As DialogResult = frmListaRemitosVenta.ShowDialog()

        If Result = DialogResult.OK Then
            Notificaciones.arbirFormProceso()

            Dim RemitoVentaMoneda As RemitoVentaMonedas = Await tareasRemitoVentaMoneda.verRemitosComMonPorID(frmListaRemitosVenta.infoRemito.IdRemitosVenta)

            If IsNothing(RemitoVentaMoneda) Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(tareasRemitoVentaMoneda.Err.Descripcion, Botones.OK, Iconos.ERR)
            Else
                Dim remVtaMov As List(Of RemitoVentaMovimientos) = Await tareasRemitosVentaMovimientos.ListadoPorIdRemitoVenta(frmListaRemitosVenta.infoRemito.IdRemitosVenta)

                If IsNothing(remVtaMov) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareasRemitosVentaMovimientos.Err.Descripcion, Botones.OK, Iconos.ERR)
                Else
                    Dim vectoraux() As String = frmListaRemitosVenta.infoRemito.NroComprobante.Split("-")
                    Dim idToRemove As New List(Of Integer)

                    fijarCantRet = New Dictionary(Of Integer, Double)
                    fijarStockFisico = New Dictionary(Of CKey, Double)
                    fijarDetPed = New List(Of PedidosDetalle)
                    fijarDetFac = New List(Of FacturaVentaDetalle)

                    txtTC.Text = Format(RemitoVentaMoneda.TipoCambio, "$ ##,#0.00")

                    txtIdRemitoVta.Text = frmListaRemitosVenta.infoRemito.IdRemitosVenta
                    txtCtaCli.Text = frmListaRemitosVenta.infoRemito.AscClientes.IdCliente
                    txtFec.Text = Format(frmListaRemitosVenta.infoRemito.Fecha, "dd/MM/yyyy")
                    cmbPtoVta.Text = vectoraux(1)
                    txtNumRem.Text = vectoraux(2)
                    txtObservaciones.Text = frmListaRemitosVenta.infoRemito.Observaciones

                    txtCtaCli.Enabled = False
                    cmbPtoVta.Enabled = False

                    txtOrigen.Text = "Modificar"

                    Dim MovimientoRemFac As List(Of Movimientos_Remito_Factura) = Await tareasMovimientosRemitoFactura.ListadoMovimientosRemitoFacturaPorIdRemitoVenta(frmListaRemitosVenta.infoRemito.IdRemitosVenta)

                    If Not IsNothing(MovimientoRemFac) Then
                        For Each item In MovimientoRemFac
                            dgvDetalleRemito.Rows.Add(item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos.IdArticulo, item.AscRemitosVentaMovimientos.AscStock.AscDepositos.IdDeposito,
                                                      0, 0, item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.AscFacturaVenta.IdFacturaVenta, item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.IdFacturaVentaDetalle,
                                                      item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos.CodArticulo, item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos.Detalle,
                                                      item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Unidad, Format(item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Precio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                      item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Cantidad, item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.Cantidad, Format(item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                      item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AlicuotaIVA, Format(item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Importe + (item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Importe * item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AlicuotaIVA) / 100, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                      item.AscRemitosVentaMovimientos.AscStock.AscDepositos.Nombre, "FACTURA")

                            idToRemove.Add(item.AscRemitosVentaMovimientos.IdRemitosVentasMovimientos)
                            item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.AscArticulos = item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos
                            fijarDetFac.Add(item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle)

                            Dim key As CKey = New CKey With {.idArt = item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos.IdArticulo, .idDep = item.AscRemitosVentaMovimientos.AscStock.AscDepositos.IdDeposito}
                            If fijarStockFisico.ContainsKey(key) Then
                                fijarStockFisico(key) += item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Cantidad
                            Else
                                fijarStockFisico.Add(key, item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Cantidad)
                            End If
                        Next
                    ElseIf tareasMovimientosRemitoFactura.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareasMovimientosRemitoFactura.Err.Descripcion, Botones.OK, Iconos.ERR)
                    End If

                    Dim MovimientoResRem As List(Of Movimientos_Reserva_Remito) = Await tareasMovimientosReservaRemito.ListadoMovimientosRemitoReservaPorIdRemitoVenta(frmListaRemitosVenta.infoRemito.IdRemitosVenta)

                    If Not IsNothing(MovimientoResRem) Then
                        For i As Integer = idToRemove.Count - 1 To 0 Step -1
                            Dim remove As New Movimientos_Reserva_Remito
                            Dim elim As Boolean = False

                            For Each item In MovimientoResRem
                                If item.AscRemitosVentaMovimientos.IdRemitosVentasMovimientos = idToRemove(i) Then
                                    remove = item
                                    elim = True
                                End If
                            Next

                            If elim Then
                                MovimientoResRem.Remove(remove)
                            End If
                        Next

                        For Each item In MovimientoResRem
                            dgvDetalleRemito.Rows.Add(item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos.IdArticulo, item.AscRemitosVentaMovimientos.AscStock.AscDepositos.IdDeposito,
                                                      item.AscPedidoMovimientos.AscPedidosDetalle.AscPedidos.IdPedidos, item.AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle, 0, 0,
                                                      item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos.CodArticulo, item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos.Detalle,
                                                      item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Unidad, Format(item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Precio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                      item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Cantidad, item.AscPedidoMovimientos.AscPedidosDetalle.Cantidad, Format(item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                      item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AlicuotaIVA, Format(item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Importe + (item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Importe * item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AlicuotaIVA) / 100, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                      item.AscRemitosVentaMovimientos.AscStock.AscDepositos.Nombre, "RESERVA")

                            idToRemove.Add(item.AscRemitosVentaMovimientos.IdRemitosVentasMovimientos)
                            item.AscPedidoMovimientos.AscPedidosDetalle.AscArticulos = item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos
                            fijarDetPed.Add(item.AscPedidoMovimientos.AscPedidosDetalle)

                            If fijarCantRet.ContainsKey(item.AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle) Then
                                fijarCantRet(item.AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle) += item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Cantidad
                            Else
                                fijarCantRet.Add(item.AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle, item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Cantidad)
                            End If

                            Dim key As CKey = New CKey With {.idArt = item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.AscArticulos.IdArticulo, .idDep = item.AscRemitosVentaMovimientos.AscStock.AscDepositos.IdDeposito}
                            If fijarStockFisico.ContainsKey(key) Then
                                fijarStockFisico(key) += item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Cantidad
                            Else
                                fijarStockFisico.Add(key, item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Cantidad)
                            End If
                        Next
                    ElseIf tareasMovimientosReservaRemito.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareasMovimientosReservaRemito.Err.Descripcion, Botones.OK, Iconos.ERR)
                    End If

                    For i As Integer = idToRemove.Count - 1 To 0 Step -1
                        Dim remove As New RemitoVentaMovimientos
                        Dim elim As Boolean = False

                        For Each item In remVtaMov
                            If item.IdRemitosVentasMovimientos = idToRemove(i) Then
                                remove = item
                                elim = True
                            End If
                        Next

                        If elim Then
                            remVtaMov.Remove(remove)
                        End If
                    Next

                    For Each item In remVtaMov
                        dgvDetalleRemito.Rows.Add(item.AscDetalleRemitoVenta.AscArticulos.IdArticulo, item.AscStock.AscDepositos.IdDeposito, 0, 0, 0, 0,
                                                  item.AscDetalleRemitoVenta.AscArticulos.CodArticulo, item.AscDetalleRemitoVenta.AscArticulos.Detalle,
                                                  item.AscDetalleRemitoVenta.Unidad, Format(item.AscDetalleRemitoVenta.Precio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                  item.AscDetalleRemitoVenta.Cantidad, 0, Format(item.AscDetalleRemitoVenta.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                  item.AscDetalleRemitoVenta.AlicuotaIVA, Format(item.AscDetalleRemitoVenta.Importe + (item.AscDetalleRemitoVenta.Importe * item.AscDetalleRemitoVenta.AlicuotaIVA) / 100, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                  item.AscStock.AscDepositos.Nombre, "NUEVO")

                        Dim key As CKey = New CKey With {.idArt = item.AscDetalleRemitoVenta.AscArticulos.IdArticulo, .idDep = item.AscStock.AscDepositos.IdDeposito}
                        If fijarStockFisico.ContainsKey(key) Then
                            fijarStockFisico(key) += item.AscDetalleRemitoVenta.Cantidad
                        Else
                            fijarStockFisico.Add(key, item.AscDetalleRemitoVenta.Cantidad)
                        End If
                    Next

                    Activar()

                    UtilidadesDGV.CabeceraDGV(dgvDetalleRemito)
                    Notificaciones.cerrarFormProceso()
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnEliminar_ClickAsync(sender As Object, e As EventArgs) Handles btnEliminar.Click
        frmListaRemitosVenta.Dispose()
        UtilidadesVarias.Escalar(frmListaRemitosVenta)
        frmListaRemitosVenta.txtLista.Text = "Completa"

        Dim Result As DialogResult = frmListaRemitosVenta.ShowDialog()

        If Result = DialogResult.OK Then
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Remito de Venta ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO REMITO DE VENTA")

                Dim _RemitoVenta As New RemitoVenta With {
                    .IdRemitosVenta = frmListaRemitosVenta.infoRemito.IdRemitosVenta,
                    .Fecha = frmListaRemitosVenta.infoRemito.Fecha,
                    .NroComprobante = frmListaRemitosVenta.infoRemito.NroComprobante
                }

                Dim _RemitoVentaMoneda As New RemitoVentaMonedas With {
                    .AscRemitosventa = New RemitoVenta With {.IdRemitosVenta = frmListaRemitosVenta.infoRemito.IdRemitosVenta}
                }

                If Await tareasRamitoVenta.Servicio_Eliminar(_RemitoVenta, _RemitoVentaMoneda) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Remito de venta eliminado con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareasRamitoVenta.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtRScli.Text <> "" Then
            frmReservaFacturaNuevoCliente.Dispose()
            UtilidadesVarias.Escalar(frmReservaFacturaNuevoCliente)
            frmReservaFacturaNuevoCliente.txtRScli.Text = txtRScli.Text

            If txtOrigen.Text = "Modificar" Then
                frmReservaFacturaNuevoCliente.fijarCantRet = fijarCantRet
                frmReservaFacturaNuevoCliente.fijarStockFisico = fijarStockFisico
                frmReservaFacturaNuevoCliente.fijarDetFac = fijarDetFac
                frmReservaFacturaNuevoCliente.fijarDetPed = fijarDetPed
            End If

            frmReservaFacturaNuevoCliente.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleRemito)

            btnAgregar.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el cliente sobre el cual se va a emitir el Remito.", Botones.OK, Iconos.ALERTA)
            txtCtaCli.Select()
        End If
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvDetalleRemito.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            dgvDetalleRemito.Rows.Remove(dgvDetalleRemito.CurrentRow)

            UtilidadesDGV.CabeceraDGV(dgvDetalleRemito)

            Importe()

            btnAgregar.Select()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvDetalleRemito.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            If dgvDetalleRemito.CurrentRow.Cells("Origen").Value = "RESERVA" Then
                frmArticuloRemitoVentaReserva.Dispose()
                UtilidadesVarias.Escalar(frmArticuloRemitoVentaReserva)
                frmArticuloRemitoVentaReserva.txtOrigen.Text = "Editar"

                frmArticuloRemitoVentaReserva.fijarStockFisico = fijarStockFisico

                frmArticuloRemitoVentaReserva.ShowDialog()
            ElseIf dgvDetalleRemito.CurrentRow.Cells("Origen").Value = "NUEVO" Then
                frmArticuloRemitoVentaNuevo.Dispose()
                UtilidadesVarias.Escalar(frmArticuloRemitoVentaNuevo)
                frmArticuloRemitoVentaNuevo.txtOrigen.Text = "Editar"

                frmArticuloRemitoVentaNuevo.fijarStockFisico = fijarStockFisico

                frmArticuloRemitoVentaNuevo.ShowDialog()
            ElseIf dgvDetalleRemito.CurrentRow.Cells("Origen").Value = "FACTURA" Then
                frmArticuloRemitoVentaFactura.Dispose()
                UtilidadesVarias.Escalar(frmArticuloRemitoVentaFactura)
                frmArticuloRemitoVentaFactura.txtOrigen.Text = "Editar"

                frmArticuloRemitoVentaFactura.fijarStockFisico = fijarStockFisico

                frmArticuloRemitoVentaFactura.ShowDialog()
            End If

            Importe()

            dgvDetalleRemito.CurrentCell = Nothing

            btnAgregar.Select()
        End If
    End Sub

    Private Sub dgvDetalleRemito_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleRemito.CellClick
        If e.RowIndex > -1 Then
            btnEditar.Select()
        Else
            dgvDetalleRemito.CurrentCell = Nothing
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If cmbPtoVta.Enabled Then
                cmbPtoVta.SelectionLength = Len(cmbPtoVta.Text)
                cmbPtoVta.Select()
            Else
                txtTC.SelectionLength = Len(txtTC.Text)
                txtTC.Select()
            End If
        End If
    End Sub

    Private Sub cmbPtoVta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPtoVta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtTC.SelectionLength = Len(txtTC.Text)
            txtTC.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTC.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnAgregar.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtTC.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
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
                    infoCliente = frmListaClientes.infoCliente

                    txtCtaCli.Text = infoCliente.IdCliente
                    txtRScli.Text = infoCliente.RazonSocial
                    txtDirec.Text = infoCliente.Direccion
                    txtLoc.Text = infoCliente.Localidad
                    txtProv.Text = infoCliente.Provincia
                    txtCuit.Text = infoCliente.CUIT
                    txtIIBB.Text = infoCliente.IIBB
                    txtTE.Text = infoCliente.Telefono

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
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ERR)

            txtFec.Text = ""
        Else
            txtFec.Text = Format(CDate(txtFec.Text), "dd/MM/yyyy")
        End If
    End Sub

    Private Sub txtTC_Validated(sender As Object, e As EventArgs) Handles txtTC.Validated
        If txtTC.Text <> "" Then
            txtTC.Text = Format(UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
    End Sub

    Private Sub txtCtaCli_Validated(sender As Object, e As EventArgs) Handles txtCtaCli.Validated
        If txtCtaCli.Text <> "" And txtRScli.Text = "" Then
            Notificaciones.MsgBox("No existe un Cliente con ese numero de cuenta.", Botones.OK, Iconos.ERR)

            txtCtaCli.SelectionLength = Len(txtCtaCli.Text)
            txtCtaCli.Select()
        End If
    End Sub

#End Region

#Region "EVENTOS TEXT CHANGED"
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
                    If listadoNumeracion.Count = 1 Then
                        cmbPtoVta.Text = UtilidadesVarias.GenerarPrefijoComprobante(listadoNumeracion.First.PuntoVenta)
                    Else
                        cmbPtoVta.Text = DatosSesion._Empresa.PrefijoFacturacion
                    End If

                    For Each num In listadoNumeracion
                        If num.PuntoVenta = cmbPtoVta.Text Then
                            txtNumRem.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroRemito + 1)

                            Exit For
                        End If
                    Next

                    cmbPtoVta.SelectionLength = Len(cmbPtoVta.Text)
                    cmbPtoVta.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txtTC_TextChanged(sender As Object, e As EventArgs) Handles txtTC.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtTC, AddressOf txtTC_TextChanged, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

        If txtTC.Text <> "" Then
            If txtSubTotalP.Text <> "" Then
                txtSubTotalC.Text = Format(UtilidadesVarias.SoloNumeros(txtSubTotalP.Text) * UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
            End If

            If txtIVAP.Text <> "" Then
                txtIVAC.Text = Format(UtilidadesVarias.SoloNumeros(txtIVAP.Text) * UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
            End If

            If txtTotalP.Text <> "" Then
                txtTotalC.Text = Format(UtilidadesVarias.SoloNumeros(txtTotalP.Text) * UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
            End If

            If UtilidadesVarias.SoloNumeros(txtTC.Text) = DatosSesion._UltimaParidadCambiaria.CotizacionVenta Then
                lblBanco.Text = "BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha
                txtTC.SelectionLength = txtTC.TextLength
            Else
                lblBanco.Text = ""
            End If
        Else
            If bnfCardFec.Enabled = True Then
                txtTC.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
            Else
                lblBanco.Text = ""
            End If
        End If
    End Sub

    Private Sub txtCtaCli_TextChanged(sender As Object, e As EventArgs) Handles txtCtaCli.TextChanged
        txtRScli.Text = ""
        txtDirec.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtCuit.Text = ""
        txtIIBB.Text = ""
        txtTE.Text = ""

        If txtCtaCli.Text <> "" Then
            For Each item In listadoClientes
                If item.IdCliente = txtCtaCli.Text Then
                    infoCliente = item

                    txtDirec.Text = item.Direccion
                    txtLoc.Text = item.Localidad
                    txtProv.Text = item.Provincia
                    txtCuit.Text = item.CUIT
                    txtIIBB.Text = item.IIBB
                    txtTE.Text = item.Telefono
                    txtRScli.Text = item.RazonSocial

                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cmbPtoVta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPtoVta.SelectedIndexChanged
        If txtOrigen.Text <> "Modificar" Then
            txtNumRem.Text = ""

            For Each num In listadoNumeracion
                If num.PuntoVenta = cmbPtoVta.Text Then
                    txtNumRem.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroRemito + 1)

                    Exit For
                End If
            Next
        End If
    End Sub
#End Region
End Class