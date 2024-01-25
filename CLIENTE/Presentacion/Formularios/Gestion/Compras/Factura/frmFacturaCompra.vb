Imports Procesos

Public Class frmFacturaCompra
    Private listaProveedores As List(Of Proveedores)

    Private tareaProv As TareasProveedores
    Private tareaFacCompra As TareasFacturaCompra
    Private tareaFacCompraMoneda As TareasFacturaCompraMonedas
    Private tareaFacMov As TareasFacturaCompraMovimientos
    Private tareaDetFac As TareasFacturaCompraDetalle
    Private tareasMovRemFac As TareasMovimientos_RemitoCompra_FacturaCompra

    Private fijarDetRem As List(Of DetalleRemitoCompra)

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

#Region "EVENTO LOAD"
    Private Sub FrmFacturaCompra_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a ALTAS DE FACTURAS DE COMPRA"

        tareaProv = New TareasProveedores()
        tareaFacCompra = New TareasFacturaCompra()
        tareaFacCompraMoneda = New TareasFacturaCompraMonedas()
        tareasMovRemFac = New TareasMovimientos_RemitoCompra_FacturaCompra()
        tareaFacMov = New TareasFacturaCompraMovimientos()
        tareaDetFac = New TareasFacturaCompraDetalle()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        listaProveedores = Await tareaProv.ListadoCompleto()

        If Not IsNothing(listaProveedores) Then
            UtilidadesDGV.FormatoDGVGeneral(dgvDetalleFactura)

            Cancelar()

            Notificaciones.cerrarFormProceso()
        ElseIf tareaProv.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaProv.Err.Descripcion, Botones.OK, Iconos.ERR)

            
            frmPpal.AbrirFrm(frmInicio)
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("No hay Proveedores cargados en el Sistema", Botones.OK, Iconos.ALERTA)

            
            frmPpal.AbrirFrm(frmInicio)
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub Cancelar()
        bnfCardDetalleRem.Enabled = False
        bnfCardFec.Enabled = False
        bnfCardNro.Enabled = False
        bnfCardClase.Enabled = False
        bnfCardTc.Enabled = False
        bnfCardProv.Enabled = False
        bnfCardInfoProv.Enabled = False
        bnfCardObs.Enabled = False

        UtilidadesTXT.VaciarTxt(Me)

        lblTipoFac.Text = "X"

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

        dgvDetalleFactura.ColumnHeadersVisible = False

        ConfigDGV_DetalleRemito()

        UtilidadesDGV.DescargarDGV(dgvDetalleFactura)

        btnNuevo.Select()
    End Sub

    Private Sub Activar()
        If txtOrigen.Text = "Nuevo" Then
            txtTC.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
            lblBanco.Text = "BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha
        End If

        bnfCardDetalleRem.Enabled = True
        bnfCardFec.Enabled = True
        bnfCardNro.Enabled = True
        bnfCardClase.Enabled = True
        bnfCardTc.Enabled = True
        bnfCardProv.Enabled = True
        bnfCardInfoProv.Enabled = True
        bnfCardObs.Enabled = True

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

        txtCtaProv.SelectionLength = Len(txtCtaProv.Text)
        txtCtaProv.Select()
    End Sub

    Private Sub ConfigDGV_DetalleRemito()
        dgvDetalleFactura.ColumnCount = 13
        dgvDetalleFactura.Columns(0).Name = "idArticulo"
        dgvDetalleFactura.Columns(1).Name = "idRemito"
        dgvDetalleFactura.Columns(2).Name = "idRemitoDetalle"
        dgvDetalleFactura.Columns(3).Name = "CodArt"
        dgvDetalleFactura.Columns(4).Name = "Descripcion"
        dgvDetalleFactura.Columns(5).Name = "Unidad"
        dgvDetalleFactura.Columns(6).Name = "Precio"
        dgvDetalleFactura.Columns(7).Name = "Cantidad"
        dgvDetalleFactura.Columns(8).Name = "CantidadPendiente"
        dgvDetalleFactura.Columns(9).Name = "Importe"
        dgvDetalleFactura.Columns(10).Name = "AlicuotaIVA"
        dgvDetalleFactura.Columns(11).Name = "ImporteNeto"
        dgvDetalleFactura.Columns(12).Name = "Origen"

        dgvDetalleFactura.Columns("idArticulo").Visible = False
        dgvDetalleFactura.Columns("idRemito").Visible = False
        dgvDetalleFactura.Columns("idRemitoDetalle").Visible = False
        dgvDetalleFactura.Columns("CodArt").Visible = False
        dgvDetalleFactura.Columns("CantidadPendiente").Visible = False

        dgvDetalleFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetalleFactura.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        'dgvDetalleRemito.Columns("CodArt").HeaderText = "COD. ART."
        dgvDetalleFactura.Columns("Descripcion").HeaderText = "DESCRIPCION"
        dgvDetalleFactura.Columns("Unidad").HeaderText = "UNIDAD"
        dgvDetalleFactura.Columns("Precio").HeaderText = "PRECIO"
        dgvDetalleFactura.Columns("Cantidad").HeaderText = "CANTIDAD"
        dgvDetalleFactura.Columns("Importe").HeaderText = "IMPORTE"
        dgvDetalleFactura.Columns("AlicuotaIVA").HeaderText = "ALICUOTA IVA"
        dgvDetalleFactura.Columns("ImporteNeto").HeaderText = "IMPORTE NETO"
        dgvDetalleFactura.Columns("Origen").HeaderText = "ORIGEN"

        dgvDetalleFactura.Columns("idArticulo").DisplayIndex = 0
        dgvDetalleFactura.Columns("idRemito").DisplayIndex = 1
        dgvDetalleFactura.Columns("idRemitoDetalle").DisplayIndex = 2
        dgvDetalleFactura.Columns("CodArt").DisplayIndex = 3
        dgvDetalleFactura.Columns("Descripcion").DisplayIndex = 4
        dgvDetalleFactura.Columns("Unidad").DisplayIndex = 5
        dgvDetalleFactura.Columns("Precio").DisplayIndex = 6
        dgvDetalleFactura.Columns("Cantidad").DisplayIndex = 7
        dgvDetalleFactura.Columns("CantidadPendiente").DisplayIndex = 8
        dgvDetalleFactura.Columns("Importe").DisplayIndex = 9
        dgvDetalleFactura.Columns("AlicuotaIVA").DisplayIndex = 10
        dgvDetalleFactura.Columns("ImporteNeto").DisplayIndex = 11
        dgvDetalleFactura.Columns("Origen").DisplayIndex = 12
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
        txtSubTotalC.Text = Format(imp * UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        txtTotalC.Text = Format(impNeto * UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        txtIVAC.Text = Format((impNeto - imp) * UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
    End Sub

#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtOrigen.Text = "Nuevo"

        txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")
        txtFecVto.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        Activar()
    End Sub

    Private Async Sub BtnEliminar_ClickAsync(sender As Object, e As EventArgs) Handles btnEliminar.Click
        frmListaFacturaCompra.Dispose()
        UtilidadesVarias.Escalar(frmListaFacturaCompra)
        Dim Result As DialogResult = frmListaFacturaCompra.ShowDialog()

        If Result = DialogResult.OK Then
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Factura de Compra ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO FACTURA COMPRA")

                Dim _FacturaCompra As New FacturaCompra With {.IdFacturaCompra = frmListaFacturaCompra.infoFactura.IdFacturaCompra}
                Dim _FacturaCompraMoneda As New FacturaCompraMonedas With {.AscFacturaCompra = New FacturaCompra With {.IdFacturaCompra = frmListaFacturaCompra.infoFactura.IdFacturaCompra}}
                Dim _CuentaCorritenteCompra As New CuentaCorrienteCompra With {.IdCuentaCorrienteCompra = frmListaFacturaCompra.infoFactura.AscCuentaCorrienteCompra.IdCuentaCorrienteCompra}

                If Await tareaFacCompra.Servicio_Eliminar(_FacturaCompra, _FacturaCompraMoneda, _CuentaCorritenteCompra) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Factura de compra eliminada con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaFacCompra.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnGuardar_ClickAsync(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtRSprov.Text = "" Then
            Notificaciones.MsgBox("No has especificado un Proveedor.", Botones.OK, Iconos.ALERTA)
            txtCtaProv.Select()
        Else
            If txtPrefijo.Text = "" Then
                Notificaciones.MsgBox("No has introducido el prefijo de la factura.", Botones.OK, Iconos.ALERTA)
                txtPrefijo.Select()
            Else
                If txtNumFac.Text = "" Then
                    Notificaciones.MsgBox("No has introducido el numero de factura.", Botones.OK, Iconos.ALERTA)
                    txtNumFac.Select()
                Else
                    If dgvDetalleFactura.Rows.Count = 0 Then
                        Notificaciones.MsgBox("No has introducido el detalle de la factura.", Botones.OK, Iconos.ALERTA)
                        btnAgregar.Select()
                    Else
                        If txtObservaciones.Text = "" Then
                            txtObservaciones.Text = "-"
                        End If

                        Dim facturaCompra As New FacturaCompra With {
                            .TipoComprobante = "FACTURA",
                            .ClaseComprobante = lblTipoFac.Text,
                            .Fecha = txtFec.Text,
                            .FechaVto = txtFecVto.Text,
                            .Prefijo = txtPrefijo.Text,
                            .NroComprobante = txtNumFac.Text,
                            .ImporteNeto = UtilidadesVarias.SoloNumeros(txtSubTotalP.Text),
                            .DescuentoGral = 0,
                            .BaseImponible = UtilidadesVarias.SoloNumeros(txtSubTotalP.Text) - .DescuentoGral,
                            .Iva = UtilidadesVarias.SoloNumeros(txtIVAP.Text),
                            .ImporteTotal = UtilidadesVarias.SoloNumeros(txtTotalP.Text),
                            .Observaciones = txtObservaciones.Text,
                            .Remitado = "NO",
                            .Eliminado = "NO",
                            .AscProveedores = New Proveedores With {.IdProveedor = txtCtaProv.Text},
                            .AscUsuarios = DatosSesion._Usuario
                        }

                        Dim facturaCompraMonedas As New FacturaCompraMonedas With {
                            .TipoCambio = UtilidadesVarias.SoloNumeros(txtTC.Text),
                            .ImporteNeto = UtilidadesVarias.SoloNumeros(txtSubTotalC.Text),
                            .DescuentoGral = 0,
                            .BaseImponible = UtilidadesVarias.SoloNumeros(txtSubTotalC.Text) - .DescuentoGral,
                            .IVA = UtilidadesVarias.SoloNumeros(txtIVAC.Text),
                            .ImporteTotal = UtilidadesVarias.SoloNumeros(txtTotalC.Text),
                            .Eliminado = "NO"
                        }

                        Dim _DetalleFactura As New List(Of FacturaCompraDetalle)
                        Dim _RemitosCompraMovimientos As New List(Of RemitoCompraMovimientos)
                        Dim _Movimientos_Remito_Factura As New List(Of Movimientos_RemitoCompra_FacturaCompra)
                        Dim _FacturaCompraMovimientos As New List(Of FacturaCompraMovimientos)
                        Dim detalleCuentaCte As String = "{TC: " + txtTC.Text + "} - "

                        For Each item As DataGridViewRow In dgvDetalleFactura.Rows
                            detalleCuentaCte += "[" + item.Cells("Cantidad").Value.ToString() + " " + item.Cells("Unidad").Value + "] " + item.Cells("Descripcion").Value

                            If item IsNot dgvDetalleFactura.Rows(dgvDetalleFactura.Rows.Count - 1) Then
                                detalleCuentaCte += " - "
                            End If

                            _DetalleFactura.Add(New FacturaCompraDetalle With {
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

                            _RemitosCompraMovimientos.Add(New RemitoCompraMovimientos With {
                                .Fecha = Date.Now.Date,
                                .Tipo = "FACTURADO",
                                .Cantidad = item.Cells("Cantidad").Value,
                                .Eliminado = "NO",
                                .AscUsuarios = DatosSesion._Usuario,
                                .AscDetalleRemtioCompra = New DetalleRemitoCompra With {
                                    .IdDetalleRemitosCompra = item.Cells("idRemitoDetalle").Value,
                                    .AscRemitosCompra = New RemitoCompra With {.IdRemitosCompra = item.Cells("idRemito").Value}
                                }
                            })

                            _FacturaCompraMovimientos.Add(New FacturaCompraMovimientos With {
                                .Fecha = Date.Now.Date,
                                .Tipo = "FACTURADO",
                                .Cantidad = item.Cells("Cantidad").Value,
                                .Eliminado = "NO",
                                .AscUsuarios = DatosSesion._Usuario
                            })

                            _Movimientos_Remito_Factura.Add(New Movimientos_RemitoCompra_FacturaCompra With {
                                .Fecha = Date.Now.Date,
                                .Tipo = "FACTURADO",
                                .Cantidad = item.Cells("Cantidad").Value,
                                .Eliminado = "NO"
                            })
                        Next

                        Dim _CuentaCorritenteCompra As New CuentaCorrienteCompra With {
                            .Fecha = txtFec.Text,
                            .FechaVto = txtFecVto.Text,
                            .Comprobante = "FACTURA",
                            .Numero = txtPrefijo.Text & " - " & txtNumFac.Text,
                            .Detalle = detalleCuentaCte,
                            .Debito = UtilidadesVarias.SoloNumeros(txtTotalP.Text),
                            .Credito = 0,
                            .Visible = "SI",
                            .AscProveedores = New Proveedores With {.IdProveedor = txtCtaProv.Text},
                            .AscUsuarios = DatosSesion._Usuario,
                            .Eliminado = "NO"
                        }

                        If txtOrigen.Text = "Nuevo" Then
                            Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Factura de Compra ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                Notificaciones.arbirFormProceso("GUARDANDO FACTURA DE COMPRA")

                                If Await tareaFacCompra.Servicio_Insertar(facturaCompra, _CuentaCorritenteCompra, facturaCompraMonedas, _DetalleFactura, _RemitosCompraMovimientos, _FacturaCompraMovimientos, _Movimientos_Remito_Factura) Then
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox("Factura de compra guardada con exito !", Botones.OK, Iconos.OK)

                                    Cancelar()
                                Else
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox(tareaFacCompra.Err.Descripcion, Botones.OK, Iconos.ERR)

                                    If tareaFacCompra.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
                                        Cancelar()
                                    End If
                                End If
                            End If
                        Else
                            Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Factura de Compra ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                Notificaciones.arbirFormProceso("MODIFICANDO FACTURA DE COMPRA")

                                facturaCompra.IdFacturaCompra = frmListaFacturaCompra.infoFactura.IdFacturaCompra
                                _CuentaCorritenteCompra.IdCuentaCorrienteCompra = frmListaFacturaCompra.infoFactura.AscCuentaCorrienteCompra.IdCuentaCorrienteCompra
                                facturaCompraMonedas.AscFacturaCompra.IdFacturaCompra = frmListaFacturaCompra.infoFactura.IdFacturaCompra

                                For Each item In _DetalleFactura
                                    item.AscFacturaCompra.IdFacturaCompra = frmListaFacturaCompra.infoFactura.IdFacturaCompra
                                Next

                                If Await tareaFacCompra.Servicio_Modificar(facturaCompra, _CuentaCorritenteCompra, facturaCompraMonedas, _DetalleFactura, _RemitosCompraMovimientos, _FacturaCompraMovimientos, _Movimientos_Remito_Factura) Then
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox("Factura de compra modificada con exito !", Botones.OK, Iconos.OK)

                                    Cancelar()
                                Else
                                    Notificaciones.cerrarFormProceso()
                                    Notificaciones.MsgBox(tareaFacCompra.Err.Descripcion, Botones.OK, Iconos.ERR)

                                    If tareaFacCompra.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
                                        Cancelar()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnModificar_ClickAsync(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmListaFacturaCompra.Dispose()
        UtilidadesVarias.Escalar(frmListaFacturaCompra)
        Dim Result As DialogResult = frmListaFacturaCompra.ShowDialog()

        If Result = DialogResult.OK Then
            Dim FacturaCompraMoneda As FacturaCompraMonedas = Await tareaFacCompraMoneda.verFacturaCompraMonedasPorIDFacturaCompra(frmListaFacturaCompra.infoFactura.IdFacturaCompra)

            If IsNothing(FacturaCompraMoneda) Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(tareaFacCompraMoneda.Err.Descripcion, Botones.OK, Iconos.ERR)
            Else
                Dim facDet As List(Of FacturaCompraDetalle) = Await tareaDetFac.verFacturaCompraPorID(frmListaFacturaCompra.infoFactura.IdFacturaCompra)

                If IsNothing(facDet) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaDetFac.Err.Descripcion, Botones.OK, Iconos.ERR)
                Else
                    Dim idToRemove As New List(Of Integer)

                    fijarDetRem = New List(Of DetalleRemitoCompra)

                    txtTC.Text = Format(FacturaCompraMoneda.TipoCambio, "$ ##,#0.00")

                    txtIdFacturaCompra.Text = frmListaFacturaCompra.infoFactura.IdFacturaCompra
                    txtCtaProv.Text = frmListaFacturaCompra.infoFactura.AscProveedores.IdProveedor
                    txtFec.Text = Format(frmListaFacturaCompra.infoFactura.Fecha, "dd/MM/yyyy")
                    txtFecVto.Text = Format(frmListaFacturaCompra.infoFactura.FechaVto, "dd/MM/yyyy")
                    txtPrefijo.Text = frmListaFacturaCompra.infoFactura.Prefijo
                    txtNumFac.Text = frmListaFacturaCompra.infoFactura.NroComprobante
                    txtObservaciones.Text = frmListaFacturaCompra.infoFactura.Observaciones
                    lblTipoFac.Text = frmListaFacturaCompra.infoFactura.ClaseComprobante

                    txtCtaProv.Enabled = False

                    txtOrigen.Text = "Modificar"

                    Dim facComMov As List(Of FacturaCompraMovimientos) = Await tareaFacMov.ListadoPorIdFacturaCompra(frmListaFacturaCompra.infoFactura.IdFacturaCompra)

                    If Not IsNothing(facComMov) Then
                        Dim MovimientoRemFac As List(Of Movimientos_RemitoCompra_FacturaCompra) = Await tareasMovRemFac.ListadoPorIdFacturaCompra(frmListaFacturaCompra.infoFactura.IdFacturaCompra)

                        If Not IsNothing(MovimientoRemFac) Then
                            For Each item In MovimientoRemFac
                                dgvDetalleFactura.Rows.Add(item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscArticulos.IdArticulo, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscRemitosCompra.IdRemitosCompra,
                                                           item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.IdDetalleRemitosCompra, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscArticulos.CodArticulo, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscArticulos.Detalle,
                                                           item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Unidad, Format(item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Precio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                           item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Cantidad, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Cantidad, Format(item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                           item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AlicuotaIVA, Format(item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Importe + (item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Importe * item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AlicuotaIVA) / 100, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                           "FACTURA")

                                idToRemove.Add(item.AscFacturaCompraMovimientos.IdFacturaCompraMovimientos)
                                fijarDetRem.Add(item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra)
                            Next
                        ElseIf tareasMovRemFac.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(tareasMovRemFac.Err.Descripcion, Botones.OK, Iconos.ERR)
                        End If

                        For i As Integer = idToRemove.Count - 1 To 0 Step -1
                            Dim remove As New FacturaCompraMovimientos
                            Dim elim As Boolean = False

                            For Each item In facComMov
                                If item.IdFacturaCompraMovimientos = idToRemove(i) Then
                                    remove = item
                                    elim = True
                                End If
                            Next

                            If elim Then
                                facComMov.Remove(remove)
                            End If
                        Next

                        For Each item In facComMov
                            dgvDetalleFactura.Rows.Add(item.AscFacturaCompraDetalle.AscArticulos.IdArticulo, 0, 0, item.AscFacturaCompraDetalle.AscArticulos.CodArticulo,
                                                           item.AscFacturaCompraDetalle.AscArticulos.Detalle, item.AscFacturaCompraDetalle.Unidad, Format(item.AscFacturaCompraDetalle.Precio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                           item.AscFacturaCompraDetalle.Cantidad, 0, Format(item.AscFacturaCompraDetalle.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"), item.AscFacturaCompraDetalle.AlicuotaIVA,
                                                           Format(item.AscFacturaCompraDetalle.Importe + (item.AscFacturaCompraDetalle.Importe * item.AscFacturaCompraDetalle.AlicuotaIVA) / 100, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"), "NUEVO")
                        Next
                    ElseIf tareaFacMov.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareaFacMov.Err.Descripcion, Botones.OK, Iconos.ERR)
                    End If

                    For Each item In facDet
                        If item.AscArticulos.IdArticulo = 2 Then
                            dgvDetalleFactura.Rows.Add(item.AscArticulos.IdArticulo, 0, 0, item.AscArticulos.CodArticulo,
                                                           item.AscArticulos.Detalle, item.Unidad, Format(item.Precio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                           item.Cantidad, 0, Format(item.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"), item.AlicuotaIVA,
                                                           Format(item.Importe + (item.Importe * item.AlicuotaIVA) / 100, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"), "SERVICIO")
                        End If
                    Next

                    Activar()

                    UtilidadesDGV.CabeceraDGV(dgvDetalleFactura)
                    Notificaciones.cerrarFormProceso()
                End If
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvDetalleFactura.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            If dgvDetalleFactura.CurrentRow.Cells("Origen").Value = "NUEVO" Then
                frmArticuloFacturaCompraNuevo.Dispose()
                UtilidadesVarias.Escalar(frmArticuloFacturaCompraNuevo)
                frmArticuloFacturaCompraNuevo.txtOrigen.Text = "Editar"

                frmArticuloFacturaCompraNuevo.ShowDialog()
            ElseIf dgvDetalleFactura.CurrentRow.Cells("Origen").Value = "REMITO" Then
                frmArticuloFacturaCompraRemito.Dispose()
                UtilidadesVarias.Escalar(frmArticuloFacturaCompraRemito)
                frmArticuloFacturaCompraRemito.txtOrigen.Text = "Editar"

                frmArticuloFacturaCompraRemito.txtIdRemito.Text = dgvDetalleFactura.CurrentRow.Cells("idRemito").Value

                frmArticuloFacturaCompraRemito.ShowDialog()

            ElseIf dgvDetalleFactura.CurrentRow.Cells("Origen").Value = "SERVICIO" Then
                frmServicioFacturaCompra.Dispose()
                UtilidadesVarias.Escalar(frmServicioFacturaCompra)
                frmServicioFacturaCompra.txtOrigen.Text = "Editar"

                frmServicioFacturaCompra.ShowDialog()
            End If

            Importe()

            dgvDetalleFactura.CurrentCell = Nothing

            btnAgregar.Select()
        End If
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtRSprov.Text <> "" Then
            frmRemitoNuevoProveedor.Dispose()
            UtilidadesVarias.Escalar(frmRemitoNuevoProveedor)
            frmRemitoNuevoProveedor.txtRS.Text = txtRSprov.Text

            If txtOrigen.Text = "Modificar" Then
                frmRemitoNuevoProveedor.fijarDetRem = fijarDetRem
            End If

            frmRemitoNuevoProveedor.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleFactura)

            btnAgregar.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el Proveeder de el cual proviene la Factura.", Botones.OK, Iconos.ALERTA)
            txtCtaProv.Select()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvDetalleFactura.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item", Botones.OK, Iconos.ALERTA)
        Else
            dgvDetalleFactura.Rows.Remove(dgvDetalleFactura.CurrentRow)

            UtilidadesDGV.CabeceraDGV(dgvDetalleFactura)

            Importe()

            btnAgregar.Select()
        End If
    End Sub

    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click
        If txtRSprov.Text <> "" Then
            frmServicioFacturaCompra.Dispose()
            UtilidadesVarias.Escalar(frmServicioFacturaCompra)
            frmServicioFacturaCompra.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleFactura)

            btnAgregar.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el Proveedor de el cual proviene la Factura.", Botones.OK, Iconos.ALERTA)
            txtCtaProv.Select()
        End If
    End Sub

    Private Sub dgvDetalleRemito_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleFactura.CellClick
        If e.RowIndex > -1 Then
            btnEditar.Select()
        Else
            dgvDetalleFactura.CurrentCell = Nothing
        End If
    End Sub

    Private Sub lblTipoFac_Click(sender As Object, e As EventArgs) Handles lblTipoFac.Click
        If bnfCardClase.Enabled Then
            If lblTipoFac.Text = "A" Then
                lblTipoFac.Text = "B"
            ElseIf lblTipoFac.Text = "B" Then
                lblTipoFac.Text = "X"
            ElseIf lblTipoFac.Text = "X" Then
                lblTipoFac.Text = "A"
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

            txtFecVto.SelectionLength = Len(txtFecVto.Text)
            txtFecVto.Select()
        End If
    End Sub

    Private Sub txtFecVto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecVto.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtPrefijo.SelectionLength = Len(txtPrefijo.Text)
            txtPrefijo.Select()
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

    Private Sub txtPrefijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrefijo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNumFac.SelectionLength = txtNumFac.Text.Length
            txtNumFac.Select()
        End If
    End Sub

    Private Sub txtNumRem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumFac.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtTC.SelectionLength = txtTC.Text.Length
            txtTC.Select()
        End If
    End Sub

    Private Sub txtCtaProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCtaProv.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtCtaProv.Text <> "" Then
                txtFec.SelectionLength = Len(txtFec.Text)
                txtFec.Select()
            Else
                frmListaProveedores.Dispose()
                UtilidadesVarias.Escalar(frmListaProveedores)
                Dim Result As DialogResult = frmListaProveedores.ShowDialog()

                If Result = DialogResult.OK Then
                    txtCtaProv.Text = frmListaProveedores.infoProveedor.IdProveedor
                    txtRSprov.Text = frmListaProveedores.infoProveedor.RazonSocial
                    txtDirec.Text = frmListaProveedores.infoProveedor.Direccion
                    txtLoc.Text = frmListaProveedores.infoProveedor.Localidad
                    txtProv.Text = frmListaProveedores.infoProveedor.Provincia
                    txtCuit.Text = frmListaProveedores.infoProveedor.CUIT
                    txtIIBB.Text = frmListaProveedores.infoProveedor.IIBB
                    txtTE.Text = frmListaProveedores.infoProveedor.Telefono

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
        If Not IsDate(txtFec.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)
            txtFecVto.Text = ""
        Else
            txtFecVto.Text = Format(CDate(txtFecVto.Text), "dd/MM/yyyy")
        End If
    End Sub

    Private Sub txtTC_Validated(sender As Object, e As EventArgs) Handles txtTC.Validated
        If txtTC.Text <> "" Then
            txtTC.Text = Format(UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
    End Sub

    Private Sub txtCtaProv_Validated(sender As Object, e As EventArgs) Handles txtCtaProv.Validated
        If txtCtaProv.Text <> "" And txtRSprov.Text = "" Then
            Notificaciones.MsgBox("No existe un Proveedor con ese numero de cuenta.", Botones.OK, Iconos.ALERTA)

            txtCtaProv.SelectionLength = Len(txtCtaProv.Text)
            txtCtaProv.Select()
        End If
    End Sub

#End Region

#Region "EVENTO CHANGED"
    Private Sub txtFec_TextChanged(sender As Object, e As EventArgs) Handles txtFec.TextChanged
        If txtFec.Text = "" Then
            If bnfCardFec.Enabled = True Then
                txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtFec.SelectionLength = Len(txtFec.Text)
                txtFec.Select()
            End If
        End If
    End Sub

    Private Sub txtFecVto_TextChanged(sender As Object, e As EventArgs) Handles txtFecVto.TextChanged
        If txtFecVto.Text = "" Then
            If bnfCardFec.Enabled = True Then
                txtFecVto.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtFecVto.SelectionLength = Len(txtFecVto.Text)
                txtFecVto.Select()
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
            If bnfCardTc.Enabled = True Then
                txtTC.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
            Else
                lblBanco.Text = ""
            End If
        End If
    End Sub

    Private Sub TxtCtaProv_TextChanged(sender As Object, e As EventArgs) Handles txtCtaProv.TextChanged
        txtRSprov.Text = ""
        txtDirec.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtCuit.Text = ""
        txtIIBB.Text = ""
        txtTE.Text = ""

        If txtCtaProv.Text <> "" Then
            For Each item In listaProveedores
                If item.IdProveedor = txtCtaProv.Text Then
                    txtDirec.Text = item.Direccion
                    txtLoc.Text = item.Localidad
                    txtProv.Text = item.Provincia
                    txtCuit.Text = item.CUIT
                    txtIIBB.Text = item.IIBB
                    txtTE.Text = item.Telefono
                    txtRSprov.Text = item.RazonSocial
                End If
            Next
        End If
    End Sub
#End Region

End Class