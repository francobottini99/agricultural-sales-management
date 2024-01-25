Imports Procesos

Public Class frmReciboVenta
    Private listadoClientes As List(Of Clientes)
    Private listadoComprobantes As List(Of Comprobantes)
    Private listadoNumeracion As List(Of Numeracion)
    Private infoCliente As Clientes

    Private _TareasClientes As TareasClientes
    Private _TareasRecibosVenta As TareasRecibosVenta
    Private _TareasComprobantes As TareasComprobantes
    Private _TareasNumeracion As TareasNumeracion

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

    Private Sub btnValorCartera_GotFocus(sender As Object, e As EventArgs) Handles btnAgregar.GotFocus
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnValorCartera_LostFocus(sender As Object, e As EventArgs) Handles btnAgregar.LostFocus
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnValorCartera_MouseEnter(sender As Object, e As EventArgs) Handles btnAgregar.MouseEnter
        If btnAgregar.Enabled = True Then
            btnAgregar.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnValorCartera_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
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
    Private Sub FrmFacturaCompra_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a RECIBO DE VENTA"

        _TareasClientes = New TareasClientes()
        _TareasComprobantes = New TareasComprobantes()
        _TareasRecibosVenta = New TareasRecibosVenta()
        _TareasNumeracion = New TareasNumeracion()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        listadoClientes = Await _TareasClientes.ListadoCompleto()

        If Not IsNothing(listadoClientes) Then
            listadoComprobantes = Await _TareasComprobantes.ListadoCompleto()

            If IsNothing(listadoComprobantes) Then
                If _TareasComprobantes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(_TareasComprobantes.Err.Descripcion, Botones.OK, Iconos.ERR)


                    frmPpal.AbrirFrm(frmInicio)
                End If
            End If

            UtilidadesDGV.FormatoDGVGeneral(dgvDetalleRecibo)

            ConfigDGV_DetalleOrden()

            Cancelar()

            Notificaciones.cerrarFormProceso()
        ElseIf _TareasClientes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasClientes.Err.Descripcion, Botones.OK, Iconos.ERR)


            frmPpal.AbrirFrm(frmInicio)
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("No hay Clientes cargados en el Sistema", Botones.OK, Iconos.ALERTA)


            frmPpal.AbrirFrm(frmInicio)
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Async Sub Cancelar()
        bnfCardDetalleOrden.Enabled = False
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

        dgvDetalleRecibo.ColumnHeadersVisible = False

        UtilidadesDGV.DescargarDGV(dgvDetalleRecibo)

        cmbPtoVta.Items.Clear()

        listadoNumeracion = Await _TareasNumeracion.ListadoCompleto()

        If Not IsNothing(listadoNumeracion) Then
            Notificaciones.cerrarFormProceso()

            For Each item In listadoNumeracion
                cmbPtoVta.Items.Add(UtilidadesVarias.GenerarPrefijoComprobante(item.PuntoVenta))
            Next
        ElseIf _TareasNumeracion.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasNumeracion.Err.Descripcion, Botones.OK, Iconos.ERR)


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

        bnfCardDetalleOrden.Enabled = True
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

        txtCtaCli.SelectionLength = Len(txtCtaCli.Text)
        txtCtaCli.Select()
    End Sub

    Private Sub ConfigDGV_DetalleOrden()
        With dgvDetalleRecibo
            .ColumnCount = 10
            .Columns(0).Name = "idValoresEnCartera"
            .Columns(1).Name = "idCaja"
            .Columns(2).Name = "Tipo"
            .Columns(3).Name = "Banco"
            .Columns(4).Name = "Sucursal"
            .Columns(5).Name = "Numero"
            .Columns(6).Name = "Librador"
            .Columns(7).Name = "FechaCobro"
            .Columns(8).Name = "Moneda"
            .Columns(9).Name = "Importe"

            .Columns("idValoresEnCartera").Visible = False
            .Columns("idCaja").Visible = False
            .Columns("Moneda").Visible = False

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .Columns("Tipo").HeaderText = "TIPO"
            .Columns("Banco").HeaderText = "BANCO"
            .Columns("Sucursal").HeaderText = "SUCURSAL"
            .Columns("Numero").HeaderText = "NUMERO"
            .Columns("Librador").HeaderText = "LIBRADOR"
            .Columns("FechaCobro").HeaderText = "FECHA DE COBRO"
            .Columns("Importe").HeaderText = "IMPORTE"

            .Columns("idValoresEnCartera").DisplayIndex = 0
            .Columns("idCaja").DisplayIndex = 1
            .Columns("Tipo").DisplayIndex = 2
            .Columns("Banco").DisplayIndex = 3
            .Columns("Sucursal").DisplayIndex = 4
            .Columns("Numero").DisplayIndex = 5
            .Columns("Librador").DisplayIndex = 6
            .Columns("FechaCobro").DisplayIndex = 7
            .Columns("Moneda").DisplayIndex = 8
            .Columns("Importe").DisplayIndex = 9
        End With
    End Sub

    Private Sub Importe()
        Dim importeEfectivoPesos As Double = 0
        Dim importeEfectivoDolares As Double = 0
        Dim importeValoresCarteraPesos As Double = 0
        Dim importeValoresCarteraDolares As Double = 0

        For Each item As DataGridViewRow In dgvDetalleRecibo.Rows
            If item.Cells("Tipo").Value = "EFECTIVO" Then
                If item.Cells("Moneda").Value = "PESO" Then
                    importeEfectivoPesos += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                Else
                    importeEfectivoDolares += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                End If
            Else
                If item.Cells("Moneda").Value = "PESO" Then
                    importeValoresCarteraPesos += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                Else
                    importeValoresCarteraDolares += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                End If
            End If
        Next

        txtEfectivoPesos.Text = Format(importeEfectivoPesos, "$ #,##0.00")
        txtEfectivoDolares.Text = Format(importeEfectivoDolares, "U$D #,##0.00")
        txtValoresCarteraPesos.Text = Format(importeValoresCarteraPesos, "$ #,##0.00")
        txtValoresCarteraDalores.Text = Format(importeValoresCarteraDolares, "U$D #,##0.00")

        txtTotalPesos.Text = Format(importeEfectivoPesos + importeValoresCarteraPesos, "$ #,##0.00")
        txtTotalDolares.Text = Format(importeEfectivoDolares + importeValoresCarteraDolares, "U$D #,##0.00")
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtRScli.Text = "" Then
            Notificaciones.MsgBox("No has especificado un Cliente.", Botones.OK, Iconos.ERR)
            txtCtaCli.Select()
        Else
            If dgvDetalleRecibo.Rows.Count = 0 Then
                Notificaciones.MsgBox("No has introducido el detalle del Recibo de Venta.", Botones.OK, Iconos.ERR)
                btnAgregar.Select()
            Else
                If txtObservaciones.Text = "" Then
                    txtObservaciones.Text = "-"
                End If

                Dim _RecibosVentaMonedas As New List(Of RecibosVentaMonedas)
                Dim _Caja As New List(Of Caja)
                Dim _MovimientoValores As New List(Of MovimientoValores)
                Dim _RecibosVentaDetalle As New List(Of RecibosVentaDetalle)

                Dim _ReciboVenta As New RecibosVenta With {
                    .NroComprobante = "RDV - " + cmbPtoVta.Text + " - " + txtNroRecibo.Text,
                    .Fecha = txtFec.Text,
                    .ImportePesos = UtilidadesVarias.SoloNumeros(txtTotalPesos.Text),
                    .ImporteDolares = UtilidadesVarias.SoloNumeros(txtTotalDolares.Text),
                    .Observaciones = txtObservaciones.Text,
                    .Eliminado = "NO",
                    .AscUsuarios = DatosSesion._Usuario,
                    .AscClientes = New Clientes With {.IdCliente = txtCtaCli.Text}
                }

                _RecibosVentaMonedas.Add(New RecibosVentaMonedas With {
                    .TipoCambio = UtilidadesVarias.SoloNumeros(txtTC.Text),
                    .ImporteNeto = UtilidadesVarias.SoloNumeros(txtTotalPesos.Text) + UtilidadesVarias.SoloNumeros(txtTotalDolares.Text) * UtilidadesVarias.SoloNumeros(txtTC.Text),
                    .DescuentoGral = 0,
                    .BaseImponible = UtilidadesVarias.SoloNumeros(txtTotalPesos.Text) + UtilidadesVarias.SoloNumeros(txtTotalDolares.Text) * UtilidadesVarias.SoloNumeros(txtTC.Text) - .DescuentoGral,
                    .IVA = 0,
                    .ImporteTotal = UtilidadesVarias.SoloNumeros(txtTotalPesos.Text) + UtilidadesVarias.SoloNumeros(txtTotalDolares.Text) * UtilidadesVarias.SoloNumeros(txtTC.Text),
                    .Eliminado = "NO"
                })

                Dim detalleCuentaCte As String = "{TC: " + txtTC.Text + "} - "

                For Each item As DataGridViewRow In dgvDetalleRecibo.Rows
                    detalleCuentaCte += "[" + item.Cells("Importe").Value + "] " + item.Cells("Tipo").Value

                    If item IsNot dgvDetalleRecibo.Rows(dgvDetalleRecibo.Rows.Count - 1) Then
                        detalleCuentaCte += " - "
                    End If

                    Dim fecCob As Date

                    If item.Cells("FechaCobro").Value = "-" Then
                        fecCob = txtFec.Text
                    Else
                        fecCob = item.Cells("FechaCobro").Value
                    End If

                    _RecibosVentaDetalle.Add(New RecibosVentaDetalle With {
                        .MedioPago = item.Cells("Tipo").Value,
                        .NroComprobante = item.Cells("Numero").Value,
                        .EntidadEmisora = item.Cells("Banco").Value,
                        .SucursalEntidad = item.Cells("Sucursal").Value,
                        .Librador = item.Cells("Librador").Value,
                        .FechaCobro = fecCob,
                        .Moneda = item.Cells("Moneda").Value,
                        .Importe = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                        .Eliminado = "NO"
                    })

                    If item.Cells("Tipo").Value = "EFECTIVO" Then
                        _Caja.Add(New Caja With {
                            .Fecha = txtFec.Text,
                            .Movimiento = "INGRESO",
                            .Comprobante = "RDV - " + cmbPtoVta.Text + " - " + txtNroRecibo.Text,
                            .Descripcion = "EFECTIVO",
                            .Moneda = item.Cells("Moneda").Value,
                            .Ingreso = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                            .Egreso = 0,
                            .Observaciones = "-",
                            .Eliminado = "NO",
                            .AscUsuarios = DatosSesion._Usuario
                        })
                    ElseIf item.Cells("Tipo").Value = "CHEQUE" Then
                        _MovimientoValores.Add(New MovimientoValores With {
                            .Fecha = txtFec.Text,
                            .Movimiento = "INGRESO",
                            .OrigenDestino = txtRScli.Text,
                            .Eliminado = "NO",
                            .AscValoresEnCartera = New ValoresEnCartera With {
                                .TipoValor = item.Cells("Tipo").Value(),
                                .Banco = item.Cells("Banco").Value(),
                                .Sucursal = item.Cells("Sucursal").Value,
                                .Numero = item.Cells("Numero").Value,
                                .Librador = item.Cells("Librador").Value,
                                .FechaCobro = item.Cells("FechaCobro").Value,
                                .Moneda = item.Cells("Moneda").Value,
                                .Importe = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                                .Disponible = "SI",
                                .Eliminado = "NO",
                                .AscUsuarios = DatosSesion._Usuario
                            },
                            .AscCaja = New Caja With {
                                .Fecha = txtFec.Text,
                                .Movimiento = "INGRESO",
                                .Comprobante = "RDV - " + cmbPtoVta.Text + " - " + txtNroRecibo.Text,
                                .Descripcion = item.Cells("Tipo").Value + " - ( " + item.Cells("Numero").Value.ToString() + " ) - " + item.Cells("Librador").Value.ToString(),
                                .Moneda = item.Cells("Moneda").Value,
                                .Ingreso = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                                .Egreso = 0,
                                .Observaciones = "-",
                                .Eliminado = "NO",
                                .AscUsuarios = DatosSesion._Usuario
                            }
                        })
                    End If
                Next

                Dim _CuentaCorrienteVenta As New CuentaCorrienteVenta With {
                    .Fecha = txtFec.Text,
                    .FechaVto = txtFec.Text,
                    .Comprobante = "RECIBO",
                    .Numero = cmbPtoVta.Text + " - " + txtNroRecibo.Text,
                    .Detalle = detalleCuentaCte,
                    .Debito = 0,
                    .Credito = UtilidadesVarias.SoloNumeros(txtTotalDolares.Text) + UtilidadesVarias.SoloNumeros(txtTotalPesos.Text) / UtilidadesVarias.SoloNumeros(txtTC.Text),
                    .Visible = "SI",
                    .AscClientes = New Clientes With {.IdCliente = txtCtaCli.Text},
                    .AscUsuarios = DatosSesion._Usuario,
                    .Eliminado = "NO"
                }

                If txtOrigen.Text = "Nuevo" Then
                    Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Recibo de Venta ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("GUARDANDO RECIBO DE VENTA")

                        Dim _Numeracion As New Numeracion

                        For Each item In listadoNumeracion
                            If item.PuntoVenta = cmbPtoVta.Text Then
                                _Numeracion.IdNumeracion = item.IdNumeracion
                                _Numeracion.NroRecibo = item.NroRecibo + 1
                            End If
                        Next

                        If Await _TareasRecibosVenta.Servicio_Insertar(_ReciboVenta, _Numeracion, _CuentaCorrienteVenta, _RecibosVentaDetalle, _Caja, _MovimientoValores, _RecibosVentaMonedas) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Recibo de Venta guardada con exito !", Botones.OK, Iconos.OK)

                            resp = Notificaciones.MsgBox("Desea imprimir el Recibo de Venta ?", Botones.SI_NO, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                UtilidadesVarias.Escalar(frmReporte)

                                frmReporte.rvReporte.Reset()

                                frmReporte.rvReporte.LocalReport.ReportPath = Reportes.RPT_RECIBO_VENTA

                                frmReporte.rvReporte.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

                                frmReporte.rvReporte.LocalReport.DataSources.Clear()
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEmpresa", New BindingSource() With {.DataSource = DatosSesion._Empresa}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsCliente", New BindingSource() With {.DataSource = infoCliente}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsReciboVenta", New BindingSource() With {.DataSource = _ReciboVenta}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsReciboVentaDetalle", New BindingSource() With {.DataSource = _RecibosVentaDetalle}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsComprobante", New BindingSource() With {.DataSource = New Comprobantes()}))

                                frmReporte.rvReporte.LocalReport.SetParameters(New List(Of Microsoft.Reporting.WinForms.ReportParameter) From {
                                    New Microsoft.Reporting.WinForms.ReportParameter("ImporteLetrasPesos", Numalet.ToCardinal(UtilidadesVarias.SoloNumeros(txtTotalPesos.Text))),
                                    New Microsoft.Reporting.WinForms.ReportParameter("ImporteLetrasDolares", Numalet.ToCardinal(UtilidadesVarias.SoloNumeros(txtTotalDolares.Text)))
                                })

                                frmReporte.rvReporte.RefreshReport()
                                frmReporte.ShowDialog()
                            End If

                            Cancelar()
                        Else
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(_TareasRecibosVenta.Err.Descripcion, Botones.OK, Iconos.ERR)
                        End If
                    End If
                ElseIf txtOrigen.Text = "Modificar" Then

                End If
            End If
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtOrigen.Text = "Nuevo"

        If listadoNumeracion.Count = 1 Then
            cmbPtoVta.Text = UtilidadesVarias.GenerarPrefijoComprobante(listadoNumeracion.First.PuntoVenta)
        Else
            cmbPtoVta.Text = DatosSesion._Empresa.PrefijoFacturacion
        End If

        For Each num In listadoNumeracion
            If num.PuntoVenta = cmbPtoVta.Text Then
                txtNroRecibo.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroRecibo + 1)

                Exit For
            End If
        Next

        txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        Activar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCtaCli.Text <> "" Then
            dgvDetalleRecibo.CurrentCell = Nothing

            frmReciboVentaDetalle.Dispose()
            UtilidadesVarias.Escalar(frmReciboVentaDetalle)
            frmReciboVentaDetalle.txtOrigen.Text = "Agregar"
            frmReciboVentaDetalle.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleRecibo)

            btnAgregar.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el Cliente sobre el cual se va a emitir el Recibo de Venta.", Botones.OK, Iconos.ALERTA)
            txtCtaCli.Select()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvDetalleRecibo.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            frmReciboVentaDetalle.Dispose()
            UtilidadesVarias.Escalar(frmReciboVentaDetalle)
            frmReciboVentaDetalle.txtOrigen.Text = "Editar"

            frmReciboVentaDetalle.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleRecibo)

            btnAgregar.Select()
        End If
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvDetalleRecibo.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item", Botones.OK, Iconos.ALERTA)
        Else
            dgvDetalleRecibo.Rows.Remove(dgvDetalleRecibo.CurrentRow)

            UtilidadesDGV.CabeceraDGV(dgvDetalleRecibo)

            Importe()

            btnAgregar.Select()
        End If
    End Sub

    Private Sub dgvDetalleOrden_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleRecibo.CellClick
        If e.RowIndex > -1 Then
            btnEditar.Select()
        Else
            dgvDetalleRecibo.CurrentCell = Nothing
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

    Private Sub txtCtaProv_Validated(sender As Object, e As EventArgs) Handles txtCtaCli.Validated
        If txtCtaCli.Text <> "" And txtRScli.Text = "" Then
            Notificaciones.MsgBox("No existe un Cliente con ese numero de cuenta.", Botones.OK, Iconos.ALERTA)

            txtCtaCli.SelectionLength = Len(txtCtaCli.Text)
            txtCtaCli.Select()
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
                            txtNroRecibo.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroOrdenCompra + 1)

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

    Private Sub TxtCtaProv_TextChanged(sender As Object, e As EventArgs) Handles txtCtaCli.TextChanged
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
                End If
            Next
        End If
    End Sub

    Private Sub cmbPtoVta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPtoVta.SelectedIndexChanged
        If txtOrigen.Text <> "Modificar" Then
            txtNroRecibo.Text = ""

            For Each num In listadoNumeracion
                If num.PuntoVenta = cmbPtoVta.Text Then
                    txtNroRecibo.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroRecibo + 1)

                    Exit For
                End If
            Next
        End If
    End Sub
#End Region
End Class