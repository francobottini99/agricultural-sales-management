Imports Procesos

Public Class frmFacturaVenta
    Private listadoClientes As List(Of Clientes)
    Private infoCliente As Clientes
    Private listadoComprobantes As List(Of Comprobantes)
    Private listadoNumeracion As List(Of Numeracion)

    Private tareasNumeracion As TareasNumeracion
    Private tareasComprobantes As TareasComprobantes
    Private tareasClientes As TareasClientes
    Private tareasFacturaVenta As TareasFacturaVenta

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

    Private Sub btnServicio_GotFocus(sender As Object, e As EventArgs) Handles btnServicio.GotFocus
        If btnServicio.Enabled = True Then
            btnServicio.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnServicio_LostFocus(sender As Object, e As EventArgs) Handles btnServicio.LostFocus
        If btnServicio.Enabled = True Then
            btnServicio.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnServicio_MouseEnter(sender As Object, e As EventArgs) Handles btnServicio.MouseEnter
        If btnServicio.Enabled = True Then
            btnServicio.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnServicio_MouseLeave(sender As Object, e As EventArgs) Handles btnServicio.MouseLeave
        If btnServicio.Enabled = True Then
            btnServicio.BackColor = Color.FromArgb(100, 100, 100)
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
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a FACTURAS DE VENTA"

        tareasClientes = New TareasClientes()
        tareasNumeracion = New TareasNumeracion()
        tareasFacturaVenta = New TareasFacturaVenta()
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

            UtilidadesDGV.FormatoDGVGeneral(dgvDetalleFactura)

            ConfigDGV()

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
        Notificaciones.arbirFormProceso()

        bnfCardDetalleFac.Enabled = False
        bnfCardFec.Enabled = False
        bnfCardClase.Enabled = False
        bnfCardNro.Enabled = False
        bnfCardTc.Enabled = False
        bnfCardClie.Enabled = False
        bnfCardInfoClie.Enabled = False
        bnfCardObs.Enabled = False

        UtilidadesTXT.VaciarTxt(Me)

        lblTipoFac.Text = "X"

        'dgvDetalleFactura.Columns("ImporteNeto").Visible = True
        'dgvDetalleFactura.Columns("AlicuotaIVA").Visible = True

        'dgvDetalleFactura.Columns("Importe").HeaderText = "IMPORTE"

        cmbPtoVta.Text = ""

        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)

        cmbPtoVta.Items.Clear()

        dgvDetalleFactura.ColumnHeadersVisible = False

        UtilidadesDGV.DescargarDGV(dgvDetalleFactura)

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
        txtTipCambio.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
        lblBanco.Text = "BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha

        bnfCardDetalleFac.Enabled = True
        bnfCardFec.Enabled = True
        bnfCardClase.Enabled = True
        bnfCardNro.Enabled = True
        bnfCardTc.Enabled = True
        bnfCardClie.Enabled = True
        bnfCardInfoClie.Enabled = True
        bnfCardObs.Enabled = True

        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)

        Importe()

        txtCtaCli.SelectionLength = Len(txtCtaCli.Text)
        txtCtaCli.Select()
    End Sub

    Private Sub ConfigDGV()
        dgvDetalleFactura.ColumnCount = 14
        dgvDetalleFactura.Columns(0).Name = "idArticulo"
        dgvDetalleFactura.Columns(1).Name = "idPedido"
        dgvDetalleFactura.Columns(2).Name = "idPedidosDetalle"
        dgvDetalleFactura.Columns(3).Name = "idRemito"
        dgvDetalleFactura.Columns(4).Name = "idRemitoDetalle"
        dgvDetalleFactura.Columns(5).Name = "CodArt"
        dgvDetalleFactura.Columns(6).Name = "Descripcion"
        dgvDetalleFactura.Columns(7).Name = "Unidad"
        dgvDetalleFactura.Columns(8).Name = "Precio"
        dgvDetalleFactura.Columns(9).Name = "Cantidad"
        dgvDetalleFactura.Columns(10).Name = "Importe"
        dgvDetalleFactura.Columns(11).Name = "AlicuotaIVA"
        dgvDetalleFactura.Columns(12).Name = "ImporteNeto"
        dgvDetalleFactura.Columns(13).Name = "Origen"

        dgvDetalleFactura.Columns("idArticulo").Visible = False
        dgvDetalleFactura.Columns("idPedido").Visible = False
        dgvDetalleFactura.Columns("idPedidosDetalle").Visible = False
        dgvDetalleFactura.Columns("idRemito").Visible = False
        dgvDetalleFactura.Columns("idRemitoDetalle").Visible = False
        dgvDetalleFactura.Columns("CodArt").Visible = False

        'dgvDetalleFactura.Columns("CodArt").HeaderText = "COD. ART."
        dgvDetalleFactura.Columns("Descripcion").HeaderText = "DESCRIPCION"
        dgvDetalleFactura.Columns("Unidad").HeaderText = "UNIDAD"
        dgvDetalleFactura.Columns("Precio").HeaderText = "PRECIO"
        dgvDetalleFactura.Columns("Cantidad").HeaderText = "CANTIDAD"
        dgvDetalleFactura.Columns("Importe").HeaderText = "IMPORTE"
        dgvDetalleFactura.Columns("AlicuotaIVA").HeaderText = "ALICUOTA IVA"
        dgvDetalleFactura.Columns("ImporteNeto").HeaderText = "IMPORTE NETO"
        dgvDetalleFactura.Columns("Origen").HeaderText = "ORIGEN"

        dgvDetalleFactura.Columns("idArticulo").DisplayIndex = 0
        dgvDetalleFactura.Columns("idPedido").DisplayIndex = 1
        dgvDetalleFactura.Columns("idPedidosDetalle").DisplayIndex = 2
        dgvDetalleFactura.Columns("idRemito").DisplayIndex = 3
        dgvDetalleFactura.Columns("idRemitoDetalle").DisplayIndex = 5
        dgvDetalleFactura.Columns("CodArt").DisplayIndex = 5
        dgvDetalleFactura.Columns("Descripcion").DisplayIndex = 6
        dgvDetalleFactura.Columns("Unidad").DisplayIndex = 7
        dgvDetalleFactura.Columns("Precio").DisplayIndex = 8
        dgvDetalleFactura.Columns("Cantidad").DisplayIndex = 9
        dgvDetalleFactura.Columns("Importe").DisplayIndex = 10
        dgvDetalleFactura.Columns("AlicuotaIVA").DisplayIndex = 11
        dgvDetalleFactura.Columns("ImporteNeto").DisplayIndex = 12
        dgvDetalleFactura.Columns("Origen").DisplayIndex = 13

        dgvDetalleFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvDetalleFactura.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub Importe()
        Dim imp As Double = 0
        Dim impNeto As Double = 0

        For Each item As DataGridViewRow In dgvDetalleFactura.Rows
            imp += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
            impNeto += UtilidadesVarias.SoloNumeros(item.Cells("ImporteNeto").Value)
        Next

        txtSubTotalP.Text = Format(imp, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtTotalP.Text = Format(impNeto, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtIVAP.Text = Format(impNeto - imp, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtSubTotalC.Text = Format(imp * UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        txtTotalC.Text = Format(impNeto * UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        txtIVAC.Text = Format((impNeto - imp) * UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnNuevo_ClickAsync(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If listadoNumeracion.Count = 1 Then
            cmbPtoVta.Text = listadoNumeracion.First.PuntoVenta
        Else
            cmbPtoVta.Text = DatosSesion._Empresa.PrefijoFacturacion
        End If

        txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")
        txtFecVto.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        Notificaciones.cerrarFormProceso()
        Activar()
    End Sub

    Private Async Sub BtnGuardar_ClickAsync(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtRScli.Text = "" Then
            Notificaciones.MsgBox("No has especificado un Cliente.", Botones.OK, Iconos.ERR)
            txtCtaCli.Select()
        Else
            If dgvDetalleFactura.Rows.Count = 0 Then
                Notificaciones.MsgBox("No has introducido el Detalle de la Factura.", Botones.OK, Iconos.ERR)
                btnAgregar.Select()
            Else
                If txtObservaciones.Text = "" Then
                    txtObservaciones.Text = "-"
                End If

                Dim numeracion As New Numeracion

                For Each item In listadoNumeracion
                    If item.PuntoVenta = cmbPtoVta.Text Then
                        numeracion.IdNumeracion = item.IdNumeracion

                        If lblTipoFac.Text = "A" Then
                            numeracion.NroFacturaA = item.NroFacturaA + 1
                        Else
                            numeracion.NroFacturaB = item.NroFacturaB + 1
                        End If
                    End If
                Next

                Dim facturaVenta As New FacturaVenta With {
                        .TipoComprobante = "FACTURA",
                        .ClaseComprobante = lblTipoFac.Text,
                        .Fecha = txtFec.Text,
                        .FechaVto = txtFecVto.Text,
                        .Prefijo = cmbPtoVta.Text,
                        .NroComprobante = txtNroFactura.Text,
                        .ImporteNeto = UtilidadesVarias.SoloNumeros(txtSubTotalP.Text),
                        .DescuentoGral = 0,
                        .BaseImponible = UtilidadesVarias.SoloNumeros(txtSubTotalP.Text) - .DescuentoGral,
                        .Iva = UtilidadesVarias.SoloNumeros(txtIVAP.Text),
                        .ImporteTotal = UtilidadesVarias.SoloNumeros(txtTotalP.Text),
                        .Observaciones = txtObservaciones.Text,
                        .Remitado = "NO",
                        .Eliminado = "NO",
                        .AscClientes = New Clientes With {
                            .IdCliente = txtCtaCli.Text,
                            .CUIT = txtCuit.Text
                        },
                        .AscUsuarios = DatosSesion._Usuario
                    }

                Dim facturaVentaMonedas As New FacturaVentaMonedas With {
                        .TipoCambio = UtilidadesVarias.SoloNumeros(txtTipCambio.Text),
                        .ImporteNeto = UtilidadesVarias.SoloNumeros(txtSubTotalC.Text),
                        .DescuentoGral = 0,
                        .BaseImponible = UtilidadesVarias.SoloNumeros(txtSubTotalC.Text) - .DescuentoGral,
                        .IVA = UtilidadesVarias.SoloNumeros(txtIVAC.Text),
                        .ImporteTotal = UtilidadesVarias.SoloNumeros(txtTotalC.Text),
                        .Eliminado = "NO"
                    }

                Dim _DetalleFactura As New List(Of FacturaVentaDetalle)
                Dim _RemitosVentaMovimientos As New List(Of RemitoVentaMovimientos)
                Dim _Movimientos_Remito_Factura As New List(Of Movimientos_Remito_Factura)
                Dim _Movimientos_Factura_Reserva As New List(Of Movimientos_Factura_Reserva)
                Dim _PedidosMovimientos As New List(Of PedidosMovimientos)
                Dim _FacturaVentaMovimientos As New List(Of FacturaVentaMovimientos)
                Dim detalleCuentaCte As String = "{TC: " + txtTipCambio.Text + "} - "

                For Each item As DataGridViewRow In dgvDetalleFactura.Rows
                    detalleCuentaCte += "[" + item.Cells("Cantidad").Value.ToString() + " " + item.Cells("Unidad").Value + "] " + item.Cells("Descripcion").Value

                    If item IsNot dgvDetalleFactura.Rows(dgvDetalleFactura.Rows.Count - 1) Then
                        detalleCuentaCte += " - "
                    End If

                    _DetalleFactura.Add(New FacturaVentaDetalle With {
                                            .Descripcion = item.Cells("Descripcion").Value,
                                            .Unidad = item.Cells("Unidad").Value,
                                            .Cantidad = item.Cells("Cantidad").Value,
                                            .Precio = UtilidadesVarias.SoloNumeros(item.Cells("Precio").Value),
                                            .Importe = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                                            .AlicuotaIVA = UtilidadesVarias.SoloNumeros(item.Cells("AlicuotaIVA").Value),
                                            .Remitado = "NO",
                                            .AscArticulos = New Articulos With {.IdArticulo = item.Cells("idArticulo").Value},
                                            .Eliminado = "NO"
                                        })

                    _RemitosVentaMovimientos.Add(New RemitoVentaMovimientos With {
                                .Fecha = Date.Now.Date,
                                .Tipo = "FACTURADO",
                                .Cantidad = item.Cells("Cantidad").Value,
                                .Eliminado = "NO",
                                .AscUsuarios = DatosSesion._Usuario,
                                .AscDetalleRemitoVenta = New DetalleRemitoVenta With {
                                    .IdDetalleRemitosVenta = item.Cells("idRemitoDetalle").Value,
                                    .AscRemitosVenta = New RemitoVenta With {.IdRemitosVenta = item.Cells("idRemito").Value}
                                }
                             })

                    _PedidosMovimientos.Add(New PedidosMovimientos With {
                                                .Fecha = Date.Now.Date,
                                                .Tipo = "FACTURADO",
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
                                                    .Tipo = "FACTURADO",
                                                    .Cantidad = item.Cells("Cantidad").Value,
                                                    .Eliminado = "NO",
                                                    .AscUsuarios = DatosSesion._Usuario
                                                })

                    _Movimientos_Factura_Reserva.Add(New Movimientos_Factura_Reserva With {
                                                        .Fecha = Date.Now.Date,
                                                        .Tipo = "FACTURADO",
                                                        .Cantidad = item.Cells("Cantidad").Value,
                                                        .Eliminado = "NO"
                                                    })

                    _Movimientos_Remito_Factura.Add(New Movimientos_Remito_Factura With {
                                                        .Fecha = Date.Now.Date,
                                                        .Tipo = "FACTURADO",
                                                        .Cantidad = item.Cells("Cantidad").Value,
                                                        .Eliminado = "NO"
                                                    })
                Next

                Dim cuentaCorrienteVenta As New CuentaCorrienteVenta With {
                        .Fecha = txtFec.Text,
                        .FechaVto = txtFecVto.Text,
                        .Comprobante = "FACTURA",
                        .Numero = cmbPtoVta.Text & " - " & txtNroFactura.Text,
                        .Detalle = detalleCuentaCte,
                        .Debito = UtilidadesVarias.SoloNumeros(txtTotalP.Text),
                        .Credito = 0,
                        .Visible = "SI",
                        .AscClientes = New Clientes With {.IdCliente = txtCtaCli.Text},
                        .AscUsuarios = DatosSesion._Usuario,
                        .Eliminado = "NO"
                    }


                Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Factura de Venta ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                If resp = DialogResult.OK Then
                    Notificaciones.arbirFormProceso("GUARDANDO FACTURA DE VENTA")

                    If Await tareasFacturaVenta.Servicio_Insertar(facturaVenta, facturaVentaMonedas, cuentaCorrienteVenta, numeracion, _DetalleFactura, _RemitosVentaMovimientos, _PedidosMovimientos, _FacturaVentaMovimientos, _Movimientos_Factura_Reserva, _Movimientos_Remito_Factura) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox("Factura de venta guardado con exito !", Botones.OK, Iconos.OK)

                        resp = Notificaciones.MsgBox("Desea imprimir la Factura ?", Botones.SI_NO, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            UtilidadesVarias.Escalar(frmReporte)

                            frmReporte.rvReporte.Reset()

                            frmReporte.rvReporte.LocalReport.ReportPath = Reportes.RPT_FACTURA_VENTA

                            frmReporte.rvReporte.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

                            facturaVenta.CAE = tareasFacturaVenta.CAE
                            facturaVenta.FechaVtoCAE = tareasFacturaVenta.FechaVtoCAE

                            Dim codBarra As New CodigoBarraAFIP(UtilidadesVarias.quitarGuiones(DatosSesion._Empresa.CUIT), "01", facturaVenta.Prefijo, facturaVenta.CAE, UtilidadesVarias.quitarGuiones(Format(facturaVenta.FechaVtoCAE, "yyyy-MM-dd")))
                            Dim copias As Integer = 0

                            frmReporte.rvReporte.LocalReport.DataSources.Clear()

                            For Each item In listadoComprobantes
                                If item.Tipo = "Factura/NC/ND" Then
                                    frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsComprobantes", New BindingSource() With {.DataSource = item}))
                                    copias = item.Copias
                                    Exit For
                                End If
                            Next

                            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEmpresa", New BindingSource() With {.DataSource = DatosSesion._Empresa}))
                            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsCliente", New BindingSource() With {.DataSource = infoCliente}))
                            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsFacturaVta", New BindingSource() With {.DataSource = facturaVenta}))
                            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsDetalleFacturaVta", New BindingSource() With {.DataSource = _DetalleFactura}))
                            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsFacturaVtaMonedas", New BindingSource() With {.DataSource = facturaVentaMonedas}))
                            frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsCodigoBarraAFIP", New BindingSource() With {.DataSource = codBarra}))

                            'If copias = 1 Then
                            '    frmRptFacturaVenta.rvReporte.LocalReport.ReportPath = "D:\005) PROGRAMACION\001) SISTEMA SIGEVA\001) PROGRAMA SIGEVA\Presentacion\Reportes\rptFacturaVenta.rdlc"
                            'ElseIf copias = 2 Then
                            '    frmRptFacturaVenta.rvReporte.LocalReport.ReportPath = "D:\005) PROGRAMACION\001) SISTEMA SIGEVA\001) PROGRAMA SIGEVA\Presentacion\Reportes\rptFacturaVenta_1.rdlc"
                            'Else
                            '    frmRptFacturaVenta.rvReporte.LocalReport.ReportPath = "D:\005) PROGRAMACION\001) SISTEMA SIGEVA\001) PROGRAMA SIGEVA\Presentacion\Reportes\rptFacturaVenta_2.rdlc"
                            'End If

                            frmReporte.rvReporte.RefreshReport()
                            frmReporte.ShowDialog()
                        End If

                        Cancelar()
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareasFacturaVenta.Err.Descripcion, Botones.OK, Iconos.ERR)

                        If tareasFacturaVenta.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
                            Cancelar()
                        End If
                    End If
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
            frmReservaRemitoNuevoCliente.Dispose()

            UtilidadesVarias.Escalar(frmReservaRemitoNuevoCliente)

            frmReservaRemitoNuevoCliente.txtRScli.Text = txtRScli.Text

            frmReservaRemitoNuevoCliente.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleFactura)

            btnAgregar.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el Cliente sobre el cual se va a emitir la Factura.", Botones.OK, Iconos.ALERTA)
            txtCtaCli.Select()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvDetalleFactura.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            If dgvDetalleFactura.CurrentRow.Cells("Origen").Value = "RESERVA" Then
                frmArticuloFacturaVentaReserva.Dispose()

                UtilidadesVarias.Escalar(frmArticuloFacturaVentaReserva)

                frmArticuloFacturaVentaReserva.txtOrigen.Text = "Editar"

                frmArticuloFacturaVentaReserva.txtIdRes.Text = dgvDetalleFactura.CurrentRow.Cells("idPedidosDetalle").Value

                frmArticuloFacturaVentaReserva.ShowDialog()
            ElseIf dgvDetalleFactura.CurrentRow.Cells("Origen").Value = "NUEVO" Then
                frmArticuloFacturaVentaNuevo.Dispose()

                UtilidadesVarias.Escalar(frmArticuloFacturaVentaNuevo)

                frmArticuloFacturaVentaNuevo.txtOrigen.Text = "Editar"

                frmArticuloFacturaVentaNuevo.ShowDialog()
            ElseIf dgvDetalleFactura.CurrentRow.Cells("Origen").Value = "REMITO" Then
                frmArticuloFacturaVentaRemito.Dispose()

                UtilidadesVarias.Escalar(frmArticuloFacturaVentaRemito)

                frmArticuloFacturaVentaRemito.txtOrigen.Text = "Editar"

                frmArticuloFacturaVentaRemito.txtIdRemito.Text = dgvDetalleFactura.CurrentRow.Cells("idRemito").Value

                frmArticuloFacturaVentaRemito.ShowDialog()

            ElseIf dgvDetalleFactura.CurrentRow.Cells("Origen").Value = "SERVICIO" Then
                frmServicioFacturaVenta.Dispose()

                UtilidadesVarias.Escalar(frmServicioFacturaVenta)

                frmServicioFacturaVenta.txtOrigen.Text = "Editar"

                frmServicioFacturaVenta.ShowDialog()
            End If

            Importe()

            dgvDetalleFactura.CurrentCell = Nothing

            btnAgregar.Select()
        End If
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvDetalleFactura.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            dgvDetalleFactura.Rows.Remove(dgvDetalleFactura.CurrentRow)

            UtilidadesDGV.CabeceraDGV(dgvDetalleFactura)

            Importe()

            btnAgregar.Select()
        End If
    End Sub

    Private Sub dgvDetalleFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleFactura.CellClick
        If e.RowIndex > -1 Then
            btnEditar.Select()
        Else
            dgvDetalleFactura.CurrentCell = Nothing
        End If
    End Sub

    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click
        If txtRScli.Text <> "" Then
            frmServicioFacturaVenta.Dispose()

            UtilidadesVarias.Escalar(frmServicioFacturaVenta)

            frmServicioFacturaVenta.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleFactura)

            btnAgregar.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el Cliente sobre el cual se va a emitir la Factura.", Botones.OK, Iconos.ALERTA)
            txtCtaCli.Select()
        End If
    End Sub

    'Private Sub lblTipoFac_Click(sender As Object, e As EventArgs) Handles lblTipoFac.Click
    '    If bnfCardInfo.Enabled Then
    '        If lblTipoFac.Text = "A" Then
    '            lblTipoFac.Text = "B"
    '        ElseIf lblTipoFac.Text = "B" Then
    '            lblTipoFac.Text = "X"
    '        ElseIf lblTipoFac.Text = "X" Then
    '            lblTipoFac.Text = "A"
    '        End If
    '    End If
    'End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtFecVto.SelectionLength = Len(txtFecVto.Text)
            txtFecVto.Select()
        End If
    End Sub

    Private Sub txtFecVto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecVto.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbPtoVta.SelectionLength = Len(cmbPtoVta.Text)
            cmbPtoVta.Select()
        End If
    End Sub

    Private Sub cmbPtoVta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPtoVta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtTipCambio.SelectionLength = Len(txtTipCambio.Text)
            txtTipCambio.Select()
        ElseIf e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipCambio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnAgregar.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtTipCambio.Text.IndexOf(".") Then
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
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

            txtFec.Text = ""
        Else
            txtFec.Text = Format(CDate(txtFec.Text), "dd/MM/yyyy")
        End If
    End Sub

    Private Sub txtFecVto_Validated(sender As Object, e As EventArgs) Handles txtFecVto.Validated
        If Not IsDate(txtFecVto.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)

            txtFecVto.Text = ""
        Else
            txtFecVto.Text = Format(CDate(txtFecVto.Text), "dd/MM/yyyy")
        End If
    End Sub

    Private Sub txtTC_Validated(sender As Object, e As EventArgs) Handles txtTipCambio.Validated
        If txtTipCambio.Text <> "" Then
            txtTipCambio.Text = Format(UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
    End Sub

    Private Sub txtCtaCli_Validated(sender As Object, e As EventArgs) Handles txtCtaCli.Validated
        If txtCtaCli.Text <> "" And txtRScli.Text = "" Then
            Notificaciones.MsgBox("No existe un Cliente con ese numero de cuenta.", Botones.OK, Iconos.ALERTA)

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

    Private Sub txtTC_TextChanged(sender As Object, e As EventArgs) Handles txtTipCambio.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtTipCambio, AddressOf txtTC_TextChanged, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

        If txtTipCambio.Text <> "" Then
            If txtSubTotalP.Text <> "" Then
                txtSubTotalC.Text = Format(UtilidadesVarias.SoloNumeros(txtSubTotalP.Text) * UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
            End If

            If txtIVAP.Text <> "" Then
                txtIVAC.Text = Format(UtilidadesVarias.SoloNumeros(txtIVAP.Text) * UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
            End If

            If txtTotalP.Text <> "" Then
                txtTotalC.Text = Format(UtilidadesVarias.SoloNumeros(txtTotalP.Text) * UtilidadesVarias.SoloNumeros(txtTipCambio.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
            End If

            If UtilidadesVarias.SoloNumeros(txtTipCambio.Text) = DatosSesion._UltimaParidadCambiaria.CotizacionVenta Then
                lblBanco.Text = "BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha
                txtTipCambio.SelectionLength = txtTipCambio.TextLength
            Else
                lblBanco.Text = ""
            End If
        Else
            If bnfCardFec.Enabled = True Then
                txtTipCambio.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
            Else
                lblBanco.Text = ""
            End If
        End If
    End Sub

    Private Sub cmbPtoVta_TextChanged(sender As Object, e As EventArgs) Handles cmbPtoVta.TextChanged
        If cmbPtoVta.Text = "" Then
            If bnfCardNro.Enabled = True Then
                If listadoNumeracion.Count = 1 Then
                    cmbPtoVta.Text = UtilidadesVarias.GenerarPrefijoComprobante(listadoNumeracion.First.PuntoVenta)
                Else
                    cmbPtoVta.Text = DatosSesion._Empresa.PrefijoFacturacion
                End If

                If lblTipoFac.Text = "A" Then
                    For Each num In listadoNumeracion
                        If num.PuntoVenta = cmbPtoVta.Text Then
                            txtNroFactura.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroFacturaA + 1)

                            Exit For
                        End If
                    Next
                ElseIf lblTipoFac.Text = "B" Then
                    For Each num In listadoNumeracion
                        If num.PuntoVenta = cmbPtoVta.Text Then
                            txtNroFactura.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroFacturaB + 1)

                            Exit For
                        End If
                    Next
                End If

                cmbPtoVta.SelectionLength = Len(cmbPtoVta.Text)
                cmbPtoVta.Select()
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
        lblTipoFac.Text = "X"
        txtNroFactura.Text = ""

        UtilidadesDGV.DescargarDGV(dgvDetalleFactura)

        Importe()

        'dgvDetalleFactura.Columns("ImporteNeto").Visible = True
        'dgvDetalleFactura.Columns("AlicuotaIVA").Visible = True

        'dgvDetalleFactura.Columns("Importe").HeaderText = "IMPORTE"

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

                    If item.SituacionIVA = "IVA Responsable Inscripto" Then
                        lblTipoFac.Text = "A"

                        For Each num In listadoNumeracion
                            If num.PuntoVenta = cmbPtoVta.Text Then
                                txtNroFactura.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroFacturaA + 1)

                                Exit For
                            End If
                        Next

                        'dgvDetalleFactura.Columns("ImporteNeto").Visible = True
                        'dgvDetalleFactura.Columns("AlicuotaIVA").Visible = True

                        'dgvDetalleFactura.Columns("Importe").HeaderText = "IMPORTE"
                    Else
                        lblTipoFac.Text = "B"

                        For Each num In listadoNumeracion
                            If num.PuntoVenta = cmbPtoVta.Text Then
                                txtNroFactura.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroFacturaB + 1)

                                Exit For
                            End If
                        Next

                        'dgvDetalleFactura.Columns("ImporteNeto").Visible = False
                        'dgvDetalleFactura.Columns("AlicuotaIVA").Visible = False

                        'dgvDetalleFactura.Columns("Importe").HeaderText = "IMPORTE NETO"
                    End If

                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cmbPtoVta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPtoVta.SelectedIndexChanged
        txtNroFactura.Text = ""

        If lblTipoFac.Text = "A" Then
            For Each num In listadoNumeracion
                If num.PuntoVenta = cmbPtoVta.Text Then
                    txtNroFactura.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroFacturaA + 1)

                    Exit For
                End If
            Next
        ElseIf lblTipoFac.Text = "B" Then
            For Each num In listadoNumeracion
                If num.PuntoVenta = cmbPtoVta.Text Then
                    txtNroFactura.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroFacturaB + 1)

                    Exit For
                End If
            Next
        End If
    End Sub
#End Region
End Class