Imports Procesos

Public Class frmRemitoCompra
    Private Proveedores As List(Of Proveedores)

    Private tareaProv As TareasProveedores
    Private tareaRemCom As TareasRemitoCompra
    Private tareasRCM As TareasRemitoCompraMoneda
    Private tareasRemComMov As TareasRemitoCompraMovimientos
    Private tareasMovRemFac As TareasMovimientos_RemitoCompra_FacturaCompra

    Private fijarDetFac As List(Of FacturaCompraDetalle)

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

#Region "EVENTOS LOAD"
    Private Sub FrmRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a ALTAS DE REMITOS DE COMPRA"

        tareaProv = New TareasProveedores()
        tareaRemCom = New TareasRemitoCompra()
        tareasRCM = New TareasRemitoCompraMoneda()
        tareasRemComMov = New TareasRemitoCompraMovimientos()
        tareasMovRemFac = New TareasMovimientos_RemitoCompra_FacturaCompra()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        Proveedores = Await tareaProv.ListadoCompleto

        If IsNothing(Proveedores) Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaProv.Err.Descripcion, Botones.OK, Iconos.ERR)
            Me.Close()
        Else
            Notificaciones.cerrarFormProceso()
            UtilidadesDGV.FormatoDGVGeneral(dgvDetalleRemito)

            ConfigDGV_DetalleRemito()

            Cancelar()
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub Cancelar()
        bnfCardDetalleRem.Enabled = False
        bnfCardFecNro.Enabled = False
        bnfCardTc.Enabled = False
        bnfCardProv.Enabled = False
        bnfCardInfoProv.Enabled = False
        bnfCardObs.Enabled = False

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

        dgvDetalleRemito.ColumnHeadersVisible = False

        UtilidadesDGV.DescargarDGV(dgvDetalleRemito)

        btnNuevo.Select()
    End Sub

    Private Sub Activar()
        If txtOrigen.Text = "Nuevo" Then
            txtTC.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
            lblBanco.Text = "BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha
        End If

        bnfCardDetalleRem.Enabled = True
        bnfCardFecNro.Enabled = True
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

        If txtOrigen.Text = "Nuevo" Then
            txtCtaProv.Enabled = True
            txtCtaProv.SelectionLength = Len(txtCtaProv.Text)
            txtCtaProv.Select()
        Else
            txtCtaProv.Enabled = False
            txtFec.SelectionLength = Len(txtFec.Text)
            txtFec.Select()
        End If
    End Sub

    Private Sub Importe()
        Dim imp As Double = 0
        Dim impNeto As Double = 0

        For Each item As DataGridViewRow In dgvDetalleRemito.Rows
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

    Private Sub ConfigDGV_DetalleRemito()
        dgvDetalleRemito.ColumnCount = 15
        dgvDetalleRemito.Columns(0).Name = "idArticulo"
        dgvDetalleRemito.Columns(1).Name = "idDeposito"
        dgvDetalleRemito.Columns(2).Name = "idFactura"
        dgvDetalleRemito.Columns(3).Name = "idFacturaDetalle"
        dgvDetalleRemito.Columns(4).Name = "CodArt"
        dgvDetalleRemito.Columns(5).Name = "Descripcion"
        dgvDetalleRemito.Columns(6).Name = "Unidad"
        dgvDetalleRemito.Columns(7).Name = "Precio"
        dgvDetalleRemito.Columns(8).Name = "Cantidad"
        dgvDetalleRemito.Columns(9).Name = "CantidadPendiente"
        dgvDetalleRemito.Columns(10).Name = "Importe"
        dgvDetalleRemito.Columns(11).Name = "AlicuotaIVA"
        dgvDetalleRemito.Columns(12).Name = "ImporteNeto"
        dgvDetalleRemito.Columns(13).Name = "Deposito"
        dgvDetalleRemito.Columns(14).Name = "Origen"

        dgvDetalleRemito.Columns("idArticulo").Visible = False
        dgvDetalleRemito.Columns("idDeposito").Visible = False
        dgvDetalleRemito.Columns("idFactura").Visible = False
        dgvDetalleRemito.Columns("idFacturaDetalle").Visible = False
        dgvDetalleRemito.Columns("CodArt").Visible = False
        dgvDetalleRemito.Columns("CantidadPendiente").Visible = False

        dgvDetalleRemito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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
        dgvDetalleRemito.Columns("idFactura").DisplayIndex = 2
        dgvDetalleRemito.Columns("idFacturaDetalle").DisplayIndex = 3
        dgvDetalleRemito.Columns("CodArt").DisplayIndex = 4
        dgvDetalleRemito.Columns("Descripcion").DisplayIndex = 5
        dgvDetalleRemito.Columns("Unidad").DisplayIndex = 6
        dgvDetalleRemito.Columns("Precio").DisplayIndex = 7
        dgvDetalleRemito.Columns("Cantidad").DisplayIndex = 8
        dgvDetalleRemito.Columns("CantidadPendiente").DisplayIndex = 9
        dgvDetalleRemito.Columns("Importe").DisplayIndex = 10
        dgvDetalleRemito.Columns("AlicuotaIVA").DisplayIndex = 11
        dgvDetalleRemito.Columns("ImporteNeto").DisplayIndex = 12
        dgvDetalleRemito.Columns("Deposito").DisplayIndex = 13
        dgvDetalleRemito.Columns("Origen").DisplayIndex = 14
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        txtOrigen.Text = "Nuevo"

        Activar()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtProv.Text <> "" Then
            frmFacturaNuevoProveedor.Dispose()
            UtilidadesVarias.Escalar(frmFacturaNuevoProveedor)
            frmFacturaNuevoProveedor.txtRS.Text = txtRSprov.Text

            If txtOrigen.Text = "Modificar" Then
                frmFacturaNuevoProveedor.fijarDetFac = fijarDetFac
            End If

            frmFacturaNuevoProveedor.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleRemito)

            btnAgregar.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el proveedor del cual proviene el Remito.", Botones.OK, Iconos.ALERTA)
            txtCtaProv.Select()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
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

    Private Async Sub BtnGuardar_ClickAsync(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtRSprov.Text = "" Then
            Notificaciones.MsgBox("No has especificado un Proveedor.", Botones.OK, Iconos.ALERTA)
            txtCtaProv.Select()
        Else
            If txtNumRem.Text = "" Then
                Notificaciones.MsgBox("No has introducido el numero de remito.", Botones.OK, Iconos.ALERTA)
                txtNumRem.Select()
            Else
                If dgvDetalleRemito.Rows.Count = 0 Then
                    Notificaciones.MsgBox("No has introducido el detalle del remito.", Botones.OK, Iconos.ALERTA)
                    btnAgregar.Select()
                Else
                    Dim _DetalleRemitoCompra As New List(Of DetalleRemitoCompra)
                    Dim _RemitosCompraMovimientos As New List(Of RemitoCompraMovimientos)
                    Dim _Movimientos_Remito_Factura As New List(Of Movimientos_RemitoCompra_FacturaCompra)
                    Dim _FacturaCompraMovimientos As New List(Of FacturaCompraMovimientos)

                    If txtObservaciones.Text = "" Then
                        txtObservaciones.Text = "-"
                    End If

                    Dim _RemitoCompra As New RemitoCompra With {
                                .NroComprobante = txtNumRem.Text,
                                .Fecha = txtFec.Text,
                                .Importe = UtilidadesVarias.SoloNumeros(txtSubTotalP.Text),
                                .Observaciones = txtObservaciones.Text,
                                .ImpOriginal = 0,
                                .ImpCopia = 0,
                                .Facturado = "NO",
                                .Eliminado = "NO",
                                .AscProveedores = New Proveedores With {.IdProveedor = txtCtaProv.Text},
                                .AscUsuarios = DatosSesion._Usuario
                            }

                    Dim _RemitoCompraMon As New RemitoCompraMonedas With {
                                .TipoCambio = UtilidadesVarias.SoloNumeros(txtTC.Text),
                                .ImporteNeto = UtilidadesVarias.SoloNumeros(txtSubTotalC.Text),
                                .DescuentoGral = 0,
                                .BaseImponible = UtilidadesVarias.SoloNumeros(txtSubTotalC.Text),
                                .IVA = UtilidadesVarias.SoloNumeros(txtIVAC.Text),
                                .ImporteTotal = UtilidadesVarias.SoloNumeros(txtTotalC.Text),
                                .Eliminado = "NO"
                            }

                    For Each item As DataGridViewRow In dgvDetalleRemito.Rows
                        _DetalleRemitoCompra.Add(New DetalleRemitoCompra With {
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

                        _RemitosCompraMovimientos.Add(New RemitoCompraMovimientos With {
                                                    .Fecha = Date.Now.Date,
                                                    .Tipo = "REMITADO",
                                                    .Cantidad = item.Cells("Cantidad").Value,
                                                    .Eliminado = "NO",
                                                    .AscUsuarios = DatosSesion._Usuario,
                                                    .AscStock = New Stock With {
                                                        .Fecha = Date.Now.Date,
                                                        .Cantidad = item.Cells("Cantidad").Value,
                                                        .Movimiento = "INGRESO",
                                                        .Eliminado = "NO",
                                                        .AscArticulos = New Articulos With {
                                                            .IdArticulo = item.Cells("idArticulo").Value,
                                                            .Detalle = item.Cells("Descripcion").Value
                                                        },
                                                        .AscDepositos = New Depositos With {.IdDeposito = item.Cells("idDeposito").Value},
                                                        .AscUsuarios = DatosSesion._Usuario
                                                    }
                                                 })

                        _FacturaCompraMovimientos.Add(New FacturaCompraMovimientos With {
                                                    .Fecha = Date.Now.Date,
                                                    .Tipo = "REMITADO",
                                                    .Cantidad = item.Cells("Cantidad").Value,
                                                    .Eliminado = "NO",
                                                    .AscFacturaCompraDetalle = New FacturaCompraDetalle With {
                                                        .IdFacturaCompraDetalle = item.Cells("idFacturaDetalle").Value,
                                                        .AscFacturaCompra = New FacturaCompra With {.IdFacturaCompra = item.Cells("idFactura").Value}
                                                    },
                                                    .AscUsuarios = DatosSesion._Usuario
                                                })

                        _Movimientos_Remito_Factura.Add(New Movimientos_RemitoCompra_FacturaCompra With {
                                                        .Fecha = Date.Now.Date,
                                                        .Tipo = "REMITADO",
                                                        .Cantidad = item.Cells("Cantidad").Value,
                                                        .Eliminado = "NO"
                                                    })
                    Next

                    If txtOrigen.Text = "Nuevo" Then
                        Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Remito de Compra ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("GUARDANDO REMITO DE COMPRA")

                            If Await tareaRemCom.Servicio_Insertar(_RemitoCompra, _RemitoCompraMon, _DetalleRemitoCompra, _RemitosCompraMovimientos, _FacturaCompraMovimientos, _Movimientos_Remito_Factura) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Remito de compra guardado con exito !", Botones.OK, Iconos.OK)

                                Cancelar()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(tareaRemCom.Err.Descripcion, Botones.OK, Iconos.ERR)

                                If tareaRemCom.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
                                    Cancelar()
                                End If
                            End If
                        End If
                    Else
                        Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Remito de Compra ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            Notificaciones.arbirFormProceso("MODIFICANDO REMITO DE COMPRA")

                            _RemitoCompra.IdRemitosCompra = txtIdRemitoCompra.Text
                            _RemitoCompraMon.AscRemitosCompra.IdRemitosCompra = txtIdRemitoCompra.Text

                            For Each item In _DetalleRemitoCompra
                                item.AscRemitosCompra.IdRemitosCompra = txtIdRemitoCompra.Text
                            Next

                            If Await tareaRemCom.Servicio_Modificar(_RemitoCompra, _RemitoCompraMon, _DetalleRemitoCompra, _RemitosCompraMovimientos, _FacturaCompraMovimientos, _Movimientos_Remito_Factura) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox("Remito de compra modificada con exito !", Botones.OK, Iconos.OK)

                                Cancelar()
                            Else
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(tareaRemCom.Err.Descripcion, Botones.OK, Iconos.ERR)

                                If tareaRemCom.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
                                    Cancelar()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Async Sub BtnModificar_ClickAsync(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmListaRemitosCompra.Dispose()
        UtilidadesVarias.Escalar(frmListaRemitosCompra)
        frmListaRemitosCompra.txtLista.Text = "Para Modificar"
        Dim Result As DialogResult = frmListaRemitosCompra.ShowDialog()

        If Result = DialogResult.OK Then
            Notificaciones.arbirFormProceso()

            Dim RemitoComMoneda As RemitoCompraMonedas = Await tareasRCM.verRemitosComMonPorID(frmListaRemitosCompra.infoRemito.IdRemitosCompra)

            If IsNothing(RemitoComMoneda) Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(tareasRCM.Err.Descripcion, Botones.OK, Iconos.ERR)
            Else
                Dim remComMov As List(Of RemitoCompraMovimientos) = Await tareasRemComMov.ListadoPorIdRemitoCompra(frmListaRemitosCompra.infoRemito.IdRemitosCompra)

                If IsNothing(remComMov) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareasRemComMov.Err.Descripcion, Botones.OK, Iconos.ERR)
                Else
                    Dim idToRemove As New List(Of Integer)

                    fijarDetFac = New List(Of FacturaCompraDetalle)

                    txtTC.Text = Format(RemitoComMoneda.TipoCambio, "$ ##,#0.00")

                    txtIdRemitoCompra.Text = frmListaRemitosCompra.infoRemito.IdRemitosCompra
                    txtCtaProv.Text = frmListaRemitosCompra.infoRemito.AscProveedores.IdProveedor
                    txtFec.Text = Format(frmListaRemitosCompra.infoRemito.Fecha, "dd/MM/yyyy")
                    txtNumRem.Text = frmListaRemitosCompra.infoRemito.NroComprobante
                    txtObservaciones.Text = frmListaRemitosCompra.infoRemito.Observaciones

                    txtCtaProv.Enabled = False

                    txtOrigen.Text = "Modificar"

                    Dim MovimientoRemFac As List(Of Movimientos_RemitoCompra_FacturaCompra) = Await tareasMovRemFac.ListadoPorIdRemitoCompra(frmListaRemitosCompra.infoRemito.IdRemitosCompra)

                    If Not IsNothing(MovimientoRemFac) Then
                        For Each item In MovimientoRemFac
                            dgvDetalleRemito.Rows.Add(item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscArticulos.IdArticulo, item.AscRemitosCompraMovimientos.AscStock.AscDepositos.IdDeposito,
                                                      item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AscFacturaCompra.IdFacturaCompra, item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.IdFacturaCompraDetalle,
                                                      item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscArticulos.CodArticulo, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscArticulos.Detalle,
                                                      item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Unidad, Format(item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Precio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                      item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Cantidad, item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Cantidad, Format(item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                      item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AlicuotaIVA, Format(item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Importe + (item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Importe * item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AlicuotaIVA) / 100, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                      item.AscRemitosCompraMovimientos.AscStock.AscDepositos.Nombre, "FACTURA")

                            idToRemove.Add(item.AscRemitosCompraMovimientos.IdRemitosCompraMovimientos)
                            item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AscArticulos = item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscArticulos
                            fijarDetFac.Add(item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle)
                        Next
                    ElseIf tareasMovRemFac.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareasMovRemFac.Err.Descripcion, Botones.OK, Iconos.ERR)
                    End If

                    For i As Integer = idToRemove.Count - 1 To 0 Step -1
                        Dim remove As New RemitoCompraMovimientos
                        Dim elim As Boolean = False

                        For Each item In remComMov
                            If item.IdRemitosCompraMovimientos = idToRemove(i) Then
                                remove = item
                                elim = True
                            End If
                        Next

                        If elim Then
                            remComMov.Remove(remove)
                        End If
                    Next

                    For Each item In remComMov
                        dgvDetalleRemito.Rows.Add(item.AscDetalleRemtioCompra.AscArticulos.IdArticulo, item.AscStock.AscDepositos.IdDeposito, 0, 0,
                                                  item.AscDetalleRemtioCompra.AscArticulos.CodArticulo, item.AscDetalleRemtioCompra.AscArticulos.Detalle,
                                                  item.AscDetalleRemtioCompra.Unidad, Format(item.AscDetalleRemtioCompra.Precio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                  item.AscDetalleRemtioCompra.Cantidad, 0, Format(item.AscDetalleRemtioCompra.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                  item.AscDetalleRemtioCompra.AlicuotaIVA, Format(item.AscDetalleRemtioCompra.Importe + (item.AscDetalleRemtioCompra.Importe * item.AscDetalleRemtioCompra.AlicuotaIVA) / 100, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                                  item.AscStock.AscDepositos.Nombre, "NUEVO")
                    Next

                    Activar()

                    UtilidadesDGV.CabeceraDGV(dgvDetalleRemito)
                    Notificaciones.cerrarFormProceso()
                End If
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvDetalleRemito.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            If dgvDetalleRemito.CurrentRow.Cells("Origen").Value = "NUEVO" Then
                frmArticuloRemitoCompraNuevo.Dispose()
                UtilidadesVarias.Escalar(frmArticuloRemitoCompraNuevo)
                frmArticuloRemitoCompraNuevo.txtOrigen.Text = "Editar"

                frmArticuloRemitoCompraNuevo.ShowDialog()
            ElseIf dgvDetalleRemito.CurrentRow.Cells("Origen").Value = "FACTURA" Then
                frmArticuloRemitoCompraFactura.Dispose()
                UtilidadesVarias.Escalar(frmArticuloRemitoCompraFactura)
                frmArticuloRemitoCompraFactura.txtOrigen.Text = "Editar"

                frmArticuloRemitoCompraFactura.ShowDialog()
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

    Private Async Sub BtnEliminar_ClickAsync(sender As Object, e As EventArgs) Handles btnEliminar.Click
        frmListaRemitosCompra.Dispose()
        UtilidadesVarias.Escalar(frmListaRemitosCompra)
        frmListaRemitosCompra.txtLista.Text = "Para Eliminar"

        Dim Result As DialogResult = frmListaRemitosCompra.ShowDialog()

        If Result = DialogResult.OK Then
            Dim resp As DialogResult = Notificaciones.MsgBox("Eliminar Remito de Compra ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO REMITO COMPRA")

                Dim _RemitoCompra As New RemitoCompra With {.IdRemitosCompra = frmListaRemitosCompra.infoRemito.IdRemitosCompra}
                Dim _RemiComMoneda As New RemitoCompraMonedas With {.AscRemitosCompra = New RemitoCompra With {.IdRemitosCompra = frmListaRemitosCompra.infoRemito.IdRemitosCompra}}

                If Await tareaRemCom.Servicio_Eliminar(_RemitoCompra, _RemiComMoneda) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Remito de compra eliminado con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaRemCom.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNumRem.SelectionLength = Len(txtNumRem.Text)
            txtNumRem.Select()
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

    Private Sub txtNumRem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumRem.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtTC.SelectionLength = Len(txtTC.Text)
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

#Region "VALIDATED"
    Private Sub txtFec_Validated(sender As Object, e As EventArgs) Handles txtFec.Validated
        If Not IsDate(txtFec.Text) Then
            Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ALERTA)
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

    Private Sub txtCtaProv_Validated(sender As Object, e As EventArgs) Handles txtCtaProv.Validated
        If txtCtaProv.Text <> "" And txtRSprov.Text = "" Then
            Notificaciones.MsgBox("No existe un Proveedor con ese numero de cuenta.", Botones.OK, Iconos.ALERTA)

            txtCtaProv.SelectionLength = Len(txtCtaProv.Text)
            txtCtaProv.Select()
        End If
    End Sub

#End Region

#Region "EVENTOS CHANGED"
    Private Sub txtFec_TextChanged(sender As Object, e As EventArgs) Handles txtFec.TextChanged
        If txtFec.Text = "" Then
            If bnfCardFecNro.Enabled = True Then
                txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")

                txtFec.SelectionLength = Len(txtFec.Text)
                txtFec.Select()
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
            If bnfCardFecNro.Enabled = True Then
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
            For Each item In Proveedores
                If item.idProveedor = txtCtaProv.Text Then
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