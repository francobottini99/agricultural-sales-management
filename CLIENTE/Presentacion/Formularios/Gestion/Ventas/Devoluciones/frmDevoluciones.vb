Imports Procesos

Public Class frmDevoluciones
    Private listadoClientes As List(Of Clientes)
    Private listadoNumeracion As List(Of Numeracion)
    Private listadoComprobantes As List(Of Comprobantes)
    Private infoCliente As Clientes

    Private tareasComprobantes As TareasComprobantes
    Private tareasNumeracion As TareasNumeracion
    Private tareasClientes As TareasClientes
    Private tareasDevoluciones As TareasDevoluciones

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
        tareasComprobantes = New TareasComprobantes()
        tareasDevoluciones = New TareasDevoluciones()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        listadoClientes = Await TareasClientes.ListadoCompleto()

        If Not IsNothing(listadoClientes) Then
            listadoComprobantes = Await TareasComprobantes.ListadoCompleto()

            If IsNothing(listadoComprobantes) Then
                If TareasComprobantes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(TareasComprobantes.Err.Descripcion, Botones.OK, Iconos.ERR)

                    frmPpal.AbrirFrm(frmInicio)
                End If
            End If

            UtilidadesDGV.FormatoDGVGeneral(dgvDetalle)

            ConfigDGV_Detalle()

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

        dgvDetalle.ColumnHeadersVisible = False

        UtilidadesDGV.DescargarDGV(dgvDetalle)

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
        bnfCardDetalleRem.Enabled = True
        bnfCardFec.Enabled = True
        bnfCardClie.Enabled = True
        bnfCardInfoClie.Enabled = True
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

    Private Sub ConfigDGV_Detalle()
        With dgvDetalle
            .ColumnCount = 17
            .Columns(0).Name = "idArticulo"
            .Columns(1).Name = "idDeposito"
            .Columns(2).Name = "idRemito"
            .Columns(3).Name = "idRemitoDetalle"
            .Columns(4).Name = "idFactura"
            .Columns(5).Name = "idFacturaDetalle"
            .Columns(6).Name = "CodArt"
            .Columns(7).Name = "Descripcion"
            .Columns(8).Name = "Unidad"
            .Columns(9).Name = "Precio"
            .Columns(10).Name = "Cantidad"
            .Columns(11).Name = "Importe"
            .Columns(12).Name = "AlicuotaIVA"
            .Columns(13).Name = "ImporteNeto"
            .Columns(14).Name = "TipoCambio"
            .Columns(15).Name = "Deposito"
            .Columns(16).Name = "Origen"

            .Columns("idArticulo").Visible = False
            .Columns("idDeposito").Visible = False
            .Columns("idRemito").Visible = False
            .Columns("idRemitoDetalle").Visible = False
            .Columns("idFactura").Visible = False
            .Columns("idFacturaDetalle").Visible = False
            .Columns("CodArt").Visible = False

            .Columns("Descripcion").HeaderText = "DESCRIPCION"
            .Columns("Unidad").HeaderText = "UNIDAD"
            .Columns("Precio").HeaderText = "PRECIO"
            .Columns("Cantidad").HeaderText = "CANTIDAD"
            .Columns("Importe").HeaderText = "IMPORTE"
            .Columns("AlicuotaIVA").HeaderText = "ALICUOTA IVA"
            .Columns("ImporteNeto").HeaderText = "IMPORTE NETO"
            .Columns("TipoCambio").HeaderText = "T.C."
            .Columns("Deposito").HeaderText = "DEPOSITO"
            .Columns("Origen").HeaderText = "ORIGEN"

            .Columns("idArticulo").DisplayIndex = 0
            .Columns("idDeposito").DisplayIndex = 1
            .Columns("idRemito").DisplayIndex = 2
            .Columns("idRemitoDetalle").DisplayIndex = 3
            .Columns("idFactura").DisplayIndex = 4
            .Columns("idFacturaDetalle").DisplayIndex = 5
            .Columns("CodArt").DisplayIndex = 6
            .Columns("Descripcion").DisplayIndex = 7
            .Columns("Unidad").DisplayIndex = 8
            .Columns("Precio").DisplayIndex = 9
            .Columns("Cantidad").DisplayIndex = 10
            .Columns("Importe").DisplayIndex = 11
            .Columns("AlicuotaIVA").DisplayIndex = 12
            .Columns("ImporteNeto").DisplayIndex = 13
            .Columns("TipoCambio").DisplayIndex = 14
            .Columns("Deposito").DisplayIndex = 15
            .Columns("Origen").DisplayIndex = 16

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            .Columns("Deposito").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With

        UtilidadesDGV.DisableResizeColumns(dgvDetalle)
        UtilidadesDGV.DisableSortColumns(dgvDetalle)
    End Sub

    Private Sub Importe()
        Dim impDolares As Double = 0
        Dim impNetoDolares As Double = 0
        Dim impPesos As Double = 0
        Dim impNetoPesos As Double = 0

        For Each item As DataGridViewRow In dgvDetalle.Rows
            impDolares += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
            impNetoDolares += UtilidadesVarias.SoloNumeros(item.Cells("ImporteNeto").Value)
            impPesos += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value) * UtilidadesVarias.SoloNumeros(item.Cells("TipoCambio").Value)
            impNetoPesos += UtilidadesVarias.SoloNumeros(item.Cells("ImporteNeto").Value) * UtilidadesVarias.SoloNumeros(item.Cells("TipoCambio").Value)
        Next

        txtSubTotalP.Text = Format(impDolares, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtTotalP.Text = Format(impNetoDolares, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtIVAP.Text = Format(impNetoDolares - impDolares, DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
        txtSubTotalC.Text = Format(impPesos, DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        txtTotalC.Text = Format(impNetoPesos, DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        txtIVAC.Text = Format(impNetoPesos - impPesos, DatosSesion._MonedaContable.Simbolo & " #,##0.00")
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
                txtNumComp.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroDevolucion + 1)

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
            If dgvDetalle.Rows.Count = 0 Then
                Notificaciones.MsgBox("No has introducido el detalle del remito.", Botones.OK, Iconos.ERR)
                btnAgregar.Select()
            Else
                Dim _DetalleDevoluciones As New List(Of DetalleDevoluciones)
                Dim _RemitosVentaMovimientos As New List(Of RemitoVentaMovimientos)
                Dim _FacturaVentaMovimientos As New List(Of FacturaVentaMovimientos)
                Dim _Movimientos_Remito_Factura As New List(Of Movimientos_Remito_Factura)
                Dim _Stock As New List(Of Stock)
                Dim detalleCuentaCte As String = "{TC: -} - "

                If txtObservaciones.Text = "" Then
                    txtObservaciones.Text = "-"
                End If

                Dim _Devolucion As New Devoluciones With {
                                .NroComprobante = cmbPtoVta.Text + " - " + txtNumComp.Text,
                                .Fecha = txtFec.Text,
                                .Importe = UtilidadesVarias.SoloNumeros(txtSubTotalP.Text),
                                .Observaciones = txtObservaciones.Text,
                                .ImpOriginal = 0,
                                .ImpCopia = 0,
                                .Eliminado = "NO",
                                .AscClientes = infoCliente,
                                .AscUsuarios = DatosSesion._Usuario
                            }

                For Each item As DataGridViewRow In dgvDetalle.Rows
                    detalleCuentaCte += "[" + item.Cells("Cantidad").Value.ToString() + " " + item.Cells("Unidad").Value + "] " + item.Cells("Descripcion").Value

                    If item IsNot dgvDetalle.Rows(dgvDetalle.Rows.Count - 1) Then
                        detalleCuentaCte += " - "
                    End If

                    _DetalleDevoluciones.Add(New DetalleDevoluciones With {
                                                .Descripcion = item.Cells("Descripcion").Value,
                                                .Cantidad = item.Cells("Cantidad").Value,
                                                .Unidad = item.Cells("Unidad").Value,
                                                .Precio = UtilidadesVarias.SoloNumeros(item.Cells("Precio").Value),
                                                .Importe = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                                                .AlicuotaIVA = UtilidadesVarias.SoloNumeros(item.Cells("AlicuotaIVA").Value),
                                                .Eliminado = "NO",
                                                .AscArticulos = New Articulos With {.IdArticulo = item.Cells("idArticulo").Value},
                                                .AscDetalleRemitoVenta = New DetalleRemitoVenta With {.IdDetalleRemitosVenta = item.Cells("idRemitoDetalle").Value}
                                            })

                    _Stock.Add(New Stock With {
                                .Fecha = Date.Now.Date,
                                .Cantidad = item.Cells("Cantidad").Value,
                                .Eliminado = "NO",
                                .Movimiento = "INGRESO",
                                .AscArticulos = New Articulos With {
                                    .IdArticulo = item.Cells("idArticulo").Value,
                                    .Detalle = item.Cells("Descripcion").Value
                                },
                                .AscDepositos = New Depositos With {.IdDeposito = item.Cells("idDeposito").Value},
                                .AscUsuarios = DatosSesion._Usuario
                              })

                    _RemitosVentaMovimientos.Add(New RemitoVentaMovimientos With {
                                                    .Fecha = Date.Now.Date,
                                                    .Tipo = "DEVOLUCION",
                                                    .Cantidad = item.Cells("Cantidad").Value,
                                                    .Eliminado = "NO",
                                                    .AscUsuarios = DatosSesion._Usuario,
                                                    .AscDetalleRemitoVenta = New DetalleRemitoVenta With {
                                                        .IdDetalleRemitosVenta = item.Cells("idRemitoDetalle").Value,
                                                        .AscRemitosVenta = New RemitoVenta With {.IdRemitosVenta = item.Cells("idRemito").Value}
                                                    }
                                                 })

                    _FacturaVentaMovimientos.Add(New FacturaVentaMovimientos With {
                                                    .Fecha = Date.Now.Date,
                                                    .Tipo = "DEVOLUCION",
                                                    .Cantidad = item.Cells("Cantidad").Value,
                                                    .Eliminado = "NO",
                                                    .AscFacturaVentaDetalle = New FacturaVentaDetalle With {
                                                        .IdFacturaVentaDetalle = item.Cells("idFacturaDetalle").Value,
                                                        .AscFacturaVenta = New FacturaVenta With {.IdFacturaVenta = item.Cells("idFactura").Value}
                                                    },
                                                    .AscUsuarios = DatosSesion._Usuario
                                                })

                    _Movimientos_Remito_Factura.Add(New Movimientos_Remito_Factura With {
                                    .Fecha = Date.Now.Date,
                                    .Tipo = "DEVOLUCION",
                                    .Cantidad = item.Cells("Cantidad").Value,
                                    .Eliminado = "NO"
                                })
                Next

                Dim _CuentaCorrienteVenta As New CuentaCorrienteVenta With {
                        .Fecha = txtFec.Text,
                        .FechaVto = txtFec.Text,
                        .Comprobante = "DEVOLUCION",
                        .Numero = cmbPtoVta.Text & " - " & txtNumComp.Text,
                        .Detalle = detalleCuentaCte,
                        .Debito = 0,
                        .Credito = UtilidadesVarias.SoloNumeros(txtTotalP.Text),
                        .Visible = "SI",
                        .AscClientes = New Clientes With {.IdCliente = txtCtaCli.Text},
                        .AscUsuarios = DatosSesion._Usuario,
                        .Eliminado = "NO"
                    }

                Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Devolucion ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                If resp = DialogResult.OK Then
                    Notificaciones.arbirFormProceso("GUARDANDO DEVOLUCION")

                    Dim _Numeracion As New Numeracion

                    For Each item In listadoNumeracion
                        If item.PuntoVenta = cmbPtoVta.Text Then
                            _Numeracion.IdNumeracion = item.IdNumeracion
                            _Numeracion.NroDevolucion = item.NroDevolucion + 1
                        End If
                    Next

                    If Await tareasDevoluciones.Servicio_Insertar(_Devolucion, _CuentaCorrienteVenta, _Numeracion, _Stock, _DetalleDevoluciones, _RemitosVentaMovimientos, _FacturaVentaMovimientos, _Movimientos_Remito_Factura) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox("Devolucion guardado con exito !", Botones.OK, Iconos.OK)

                        resp = Notificaciones.MsgBox("Desea imprimir el comprobante de Devolucion ?", Botones.SI_NO, Iconos.INFORMACION)

                        If resp = DialogResult.OK Then
                            'UtilidadesVarias.Escalar(frmReporte)

                            'frmReporte.rvReporte.Reset()

                            'frmReporte.rvReporte.LocalReport.ReportPath = Reportes.RPT_REMITO_VENTA

                            'frmReporte.rvReporte.LocalReport.DataSources.Clear()
                            'frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEmpresa", New BindingSource() With {.DataSource = DatosSesion._Empresa}))
                            'frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsCliente", New BindingSource() With {.DataSource = infoCliente}))
                            'frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsRemitoVenta", New BindingSource() With {.DataSource = _RemitoVenta}))
                            'frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsDetalleRemVta", New BindingSource() With {.DataSource = _DetalleRemitoVenta}))
                            'frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsComprobantes", New BindingSource() With {.DataSource = New Comprobantes()}))

                            'frmReporte.rvReporte.LocalReport.Refresh()
                            'frmReporte.rvReporte.RefreshReport()
                        Else
                            Cancelar()
                        End If
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareasDevoluciones.Err.Descripcion & " - " & tareasDevoluciones.Err.Identificador.ToString, Botones.OK, Iconos.ERR)

                        If tareasDevoluciones.Err.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE Then
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
            frmDevolucionesrRetiradoCliente.Dispose()
            UtilidadesVarias.Escalar(frmDevolucionesrRetiradoCliente)

            frmDevolucionesrRetiradoCliente.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalle)

            btnAgregar.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el cliente sobre el cual se va a emitir una Devolucion.", Botones.OK, Iconos.ALERTA)
            txtCtaCli.Select()
        End If
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvDetalle.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow)

            UtilidadesDGV.CabeceraDGV(dgvDetalle)

            Importe()

            btnAgregar.Select()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvDetalle.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            frmArticuloDevoluciones.Dispose()
            UtilidadesVarias.Escalar(frmArticuloDevoluciones)
            frmArticuloDevoluciones.txtOrigen.Text = "Editar"
            frmArticuloDevoluciones.txtComprobante.Text = dgvDetalle.CurrentRow.Cells("Origen").Value

            frmArticuloDevoluciones.ShowDialog()

            Importe()

            dgvDetalle.CurrentCell = Nothing

            btnAgregar.Select()
        End If
    End Sub

    Private Sub dgvDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellClick
        If e.RowIndex > -1 Then
            btnEditar.Select()
        Else
            dgvDetalle.CurrentCell = Nothing
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
                            txtNumComp.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroRemito + 1)

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
            txtNumComp.Text = ""

            For Each num In listadoNumeracion
                If num.PuntoVenta = cmbPtoVta.Text Then
                    txtNumComp.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroRemito + 1)

                    Exit For
                End If
            Next
        End If
    End Sub
#End Region
End Class