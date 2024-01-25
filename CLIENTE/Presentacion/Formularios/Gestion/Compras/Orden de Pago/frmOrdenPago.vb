Imports Procesos

Public Class frmOrdenPago
    Private listadoProveedores As List(Of Proveedores)
    Private listadoComprobantes As List(Of Comprobantes)
    Private listadoNumeracion As List(Of Numeracion)
    Private infoProveedor As Proveedores

    Private _TareasProveedores As TareasProveedores
    Private _TareasComprobantes As TareasComprobantes
    Private _TareasOrdenDePago As TareasOrdenDePago
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

    Private Sub btnEfectivo_GotFocus(sender As Object, e As EventArgs) Handles btnEfectivo.GotFocus
        If btnEfectivo.Enabled = True Then
            btnEfectivo.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEfectivo_LostFocus(sender As Object, e As EventArgs) Handles btnEfectivo.LostFocus
        If btnEfectivo.Enabled = True Then
            btnEfectivo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnEfectivo_MouseEnter(sender As Object, e As EventArgs) Handles btnEfectivo.MouseEnter
        If btnEfectivo.Enabled = True Then
            btnEfectivo.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnEfectivo_MouseLeave(sender As Object, e As EventArgs) Handles btnEfectivo.MouseLeave
        If btnEfectivo.Enabled = True Then
            btnEfectivo.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnValorCartera_GotFocus(sender As Object, e As EventArgs) Handles btnValorCartera.GotFocus
        If btnValorCartera.Enabled = True Then
            btnValorCartera.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnValorCartera_LostFocus(sender As Object, e As EventArgs) Handles btnValorCartera.LostFocus
        If btnValorCartera.Enabled = True Then
            btnValorCartera.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnValorCartera_MouseEnter(sender As Object, e As EventArgs) Handles btnValorCartera.MouseEnter
        If btnValorCartera.Enabled = True Then
            btnValorCartera.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnValorCartera_MouseLeave(sender As Object, e As EventArgs) Handles btnValorCartera.MouseLeave
        If btnValorCartera.Enabled = True Then
            btnValorCartera.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnValorPropio_GotFocus(sender As Object, e As EventArgs) Handles btnChequePropio.GotFocus
        If btnChequePropio.Enabled = True Then
            btnChequePropio.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnValorPropio_LostFocus(sender As Object, e As EventArgs) Handles btnChequePropio.LostFocus
        If btnChequePropio.Enabled = True Then
            btnChequePropio.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnValorPropio_MouseEnter(sender As Object, e As EventArgs) Handles btnChequePropio.MouseEnter
        If btnChequePropio.Enabled = True Then
            btnChequePropio.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnValorPropio_MouseLeave(sender As Object, e As EventArgs) Handles btnChequePropio.MouseLeave
        If btnChequePropio.Enabled = True Then
            btnChequePropio.BackColor = Color.FromArgb(100, 100, 100)
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
        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a ORDEN DE PAGO"

        _TareasProveedores = New TareasProveedores()
        _TareasComprobantes = New TareasComprobantes()
        _TareasOrdenDePago = New TareasOrdenDePago()
        _TareasNumeracion = New TareasNumeracion()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        listadoProveedores = Await _TareasProveedores.ListadoCompleto()

        If Not IsNothing(listadoProveedores) Then
            listadoComprobantes = Await _TareasComprobantes.ListadoCompleto()

            If IsNothing(listadoComprobantes) Then
                If _TareasComprobantes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(_TareasComprobantes.Err.Descripcion, Botones.OK, Iconos.ERR)

                    
                    frmPpal.AbrirFrm(frmInicio)
                End If
            End If

            UtilidadesDGV.FormatoDGVGeneral(dgvDetalleOrden)

            ConfigDGV_DetalleOrden()

            Cancelar()

            Notificaciones.cerrarFormProceso()
        ElseIf _TareasProveedores.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasProveedores.Err.Descripcion, Botones.OK, Iconos.ERR)

            
            frmPpal.AbrirFrm(frmInicio)
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("No hay Proveedores cargados en el Sistema", Botones.OK, Iconos.ALERTA)

            
            frmPpal.AbrirFrm(frmInicio)
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Async Sub Cancelar()
        bnfCardDetalleOrden.Enabled = False
        bnfCardFec.Enabled = False
        bnfCardProv.Enabled = False
        bnfCardInfoProv.Enabled = False
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

        dgvDetalleOrden.ColumnHeadersVisible = False

        UtilidadesDGV.DescargarDGV(dgvDetalleOrden)

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
        bnfCardProv.Enabled = True
        bnfCardInfoProv.Enabled = True
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

        txtCtaProv.SelectionLength = Len(txtCtaProv.Text)
        txtCtaProv.Select()
    End Sub

    Private Sub ConfigDGV_DetalleOrden()
        dgvDetalleOrden.ColumnCount = 13
        dgvDetalleOrden.Columns(0).Name = "idValoresEnCartera"
        dgvDetalleOrden.Columns(1).Name = "idChequera"
        dgvDetalleOrden.Columns(2).Name = "idDetalleCheque"
        dgvDetalleOrden.Columns(3).Name = "Tipo"
        dgvDetalleOrden.Columns(4).Name = "Banco"
        dgvDetalleOrden.Columns(5).Name = "Sucursal"
        dgvDetalleOrden.Columns(6).Name = "Numero"
        dgvDetalleOrden.Columns(7).Name = "Librador"
        dgvDetalleOrden.Columns(8).Name = "FechaEmision"
        dgvDetalleOrden.Columns(9).Name = "FechaCobro"
        dgvDetalleOrden.Columns(10).Name = "Moneda"
        dgvDetalleOrden.Columns(11).Name = "Importe"
        dgvDetalleOrden.Columns(12).Name = "Observaciones"

        dgvDetalleOrden.Columns("idChequera").Visible = False
        dgvDetalleOrden.Columns("idValoresEnCartera").Visible = False
        dgvDetalleOrden.Columns("idDetalleCheque").Visible = False
        dgvDetalleOrden.Columns("Moneda").Visible = False
        dgvDetalleOrden.Columns("FechaEmision").Visible = False

        dgvDetalleOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvDetalleOrden.Columns("Tipo").HeaderText = "TIPO"
        dgvDetalleOrden.Columns("Banco").HeaderText = "BANCO"
        dgvDetalleOrden.Columns("Sucursal").HeaderText = "SUCURSAL"
        dgvDetalleOrden.Columns("Numero").HeaderText = "NUMERO"
        dgvDetalleOrden.Columns("Librador").HeaderText = "LIBRADOR"
        dgvDetalleOrden.Columns("FechaCobro").HeaderText = "FECHA DE COBRO"
        dgvDetalleOrden.Columns("Importe").HeaderText = "IMPORTE"
        dgvDetalleOrden.Columns("Observaciones").HeaderText = "OBSERVACIONES"

        dgvDetalleOrden.Columns("idValoresEnCartera").DisplayIndex = 0
        dgvDetalleOrden.Columns("idChequera").DisplayIndex = 1
        dgvDetalleOrden.Columns("idDetalleCheque").DisplayIndex = 2
        dgvDetalleOrden.Columns("Tipo").DisplayIndex = 3
        dgvDetalleOrden.Columns("Banco").DisplayIndex = 4
        dgvDetalleOrden.Columns("Sucursal").DisplayIndex = 5
        dgvDetalleOrden.Columns("Numero").DisplayIndex = 6
        dgvDetalleOrden.Columns("Librador").DisplayIndex = 7
        dgvDetalleOrden.Columns("FechaEmision").DisplayIndex = 8
        dgvDetalleOrden.Columns("FechaCobro").DisplayIndex = 9
        dgvDetalleOrden.Columns("Moneda").DisplayIndex = 10
        dgvDetalleOrden.Columns("Importe").DisplayIndex = 11
        dgvDetalleOrden.Columns("Observaciones").DisplayIndex = 12
    End Sub

    Private Sub Importe()
        Dim importeEfectivoPesos As Double = 0
        Dim importeEfectivoDolares As Double = 0
        Dim importeValoresPropiosPesos As Double = 0
        Dim importeValoresCarteraPesos As Double = 0
        Dim importeValoresPropiosDolares As Double = 0
        Dim importeValoresCarteraDolares As Double = 0

        For Each item As DataGridViewRow In dgvDetalleOrden.Rows
            If item.Cells("Tipo").Value = "EFECTIVO" Then
                If item.Cells("Moneda").Value = "PESO" Then
                    importeEfectivoPesos += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                Else
                    importeEfectivoDolares += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                End If
            End If

            If item.Cells("idValoresEnCartera").Value <> 0 Then
                If item.Cells("Moneda").Value = "PESO" Then
                    importeValoresCarteraPesos += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                Else
                    importeValoresCarteraDolares += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                End If
            End If

            If item.Cells("idDetalleCheque").Value <> 0 Then
                If item.Cells("Moneda").Value = "PESO" Then
                    importeValoresPropiosPesos += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                Else
                    importeValoresPropiosDolares += UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value)
                End If
            End If
        Next

        txtEfectivoPesos.Text = Format(importeEfectivoPesos, "$ #,##0.00")
        txtEfectivoDolares.Text = Format(importeEfectivoDolares, "U$D #,##0.00")
        txtValoresCarteraPesos.Text = Format(importeValoresCarteraPesos, "$ #,##0.00")
        txtValoresCarteraDalores.Text = Format(importeValoresCarteraDolares, "U$D #,##0.00")
        txtValoresPropiosPesos.Text = Format(importeValoresPropiosPesos, "$ #,##0.00")
        txtValoresPropiosDolares.Text = Format(importeValoresPropiosDolares, "U$D #,##0.00")

        txtTotalPesos.Text = Format(importeEfectivoPesos + importeValoresCarteraPesos + importeValoresPropiosPesos, "$ #,##0.00")
        txtTotalDolares.Text = Format(importeEfectivoDolares + importeValoresCarteraDolares + importeValoresPropiosDolares, "U$D #,##0.00")
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
        If txtRSprov.Text = "" Then
            Notificaciones.MsgBox("No has especificado un Proveedor.", Botones.OK, Iconos.ERR)
            txtCtaProv.Select()
        Else
            If dgvDetalleOrden.Rows.Count = 0 Then
                Notificaciones.MsgBox("No has introducido el detalle de la Orden de Pago.", Botones.OK, Iconos.ERR)
                btnEfectivo.Select()
            Else
                If txtObservaciones.Text = "" Then
                    txtObservaciones.Text = "-"
                End If

                Dim _OrdenDePagoDetalle As New List(Of OrdenDePagoDetalle)
                Dim _Caja As New List(Of Caja)
                Dim _DetalleCheques As New List(Of DetalleCheque)
                Dim _MovimientoValores As New List(Of MovimientoValores)
                Dim _OrdenDePagoMonedas As New List(Of OrdenDePagoMonedas)

                Dim _OrdenDePago As New OrdenDePago With {
                    .NroComprobante = "ODC - " + cmbPtoVta.Text + " - " + txtNroOrden.Text,
                    .Fecha = txtFec.Text,
                    .ImportePesos = UtilidadesVarias.SoloNumeros(txtTotalPesos.Text),
                    .ImporteDolares = UtilidadesVarias.SoloNumeros(txtTotalDolares.Text),
                    .Observaciones = txtObservaciones.Text,
                    .Eliminado = "NO",
                    .AscUsuarios = DatosSesion._Usuario,
                    .AscProveedores = New Proveedores With {.IdProveedor = txtCtaProv.Text}
                }

                _OrdenDePagoMonedas.Add(New OrdenDePagoMonedas With {
                    .TipoCambio = UtilidadesVarias.SoloNumeros(txtTC.Text),
                    .ImporteNeto = UtilidadesVarias.SoloNumeros(txtTotalPesos.Text) + UtilidadesVarias.SoloNumeros(txtTotalDolares.Text) * UtilidadesVarias.SoloNumeros(txtTC.Text),
                    .DescuentoGral = 0,
                    .BaseImponible = UtilidadesVarias.SoloNumeros(txtTotalPesos.Text) + UtilidadesVarias.SoloNumeros(txtTotalDolares.Text) * UtilidadesVarias.SoloNumeros(txtTC.Text) - .DescuentoGral,
                    .IVA = 0,
                    .ImporteTotal = UtilidadesVarias.SoloNumeros(txtTotalPesos.Text) + UtilidadesVarias.SoloNumeros(txtTotalDolares.Text) * UtilidadesVarias.SoloNumeros(txtTC.Text),
                    .Eliminado = "NO"
                })

                Dim detalleCuentaCte As String = "{TC: " + txtTC.Text + "} - "

                For Each item As DataGridViewRow In dgvDetalleOrden.Rows
                    detalleCuentaCte += "[" + item.Cells("Importe").Value + "] " + item.Cells("Tipo").Value

                    If item IsNot dgvDetalleOrden.Rows(dgvDetalleOrden.Rows.Count - 1) Then
                        detalleCuentaCte += " - "
                    End If

                    Dim fecCob As Date

                    If item.Cells("FechaCobro").Value = "-" Then
                        fecCob = txtFec.Text
                    Else
                        fecCob = item.Cells("FechaCobro").Value
                    End If

                    _OrdenDePagoDetalle.Add(New OrdenDePagoDetalle With {
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
                            .Movimiento = "EGRESO",
                            .Comprobante = "ODC - " + cmbPtoVta.Text + " - " + txtNroOrden.Text,
                            .Descripcion = "EFECTIVO",
                            .Moneda = item.Cells("Moneda").Value,
                            .Ingreso = 0,
                            .Egreso = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                            .Observaciones = item.Cells("Observaciones").Value,
                            .Eliminado = "NO",
                            .AscUsuarios = DatosSesion._Usuario
                        })
                    ElseIf item.Cells("idValoresEnCartera").Value <> 0 Then
                        _MovimientoValores.Add(New MovimientoValores With {
                            .Fecha = txtFec.Text,
                            .Movimiento = "EGRESO",
                            .OrigenDestino = txtRSprov.Text,
                            .Eliminado = "NO",
                            .AscValoresEnCartera = New ValoresEnCartera With {.IdValoresEnCartera = item.Cells("idValoresEnCartera").Value},
                            .AscCaja = New Caja With {
                                .Fecha = txtFec.Text,
                                .Movimiento = "EGRESO",
                                .Comprobante = "ODC - " + cmbPtoVta.Text + " - " + txtNroOrden.Text,
                                .Descripcion = "[ " + item.Cells("idValoresEnCartera").Value.ToString() + " ] - " + " CHEQUE - ( " + item.Cells("Numero").Value.ToString() + " ) - " + item.Cells("Librador").Value.ToString(),
                                .Moneda = item.Cells("Moneda").Value,
                                .Ingreso = 0,
                                .Egreso = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                                .Observaciones = item.Cells("Observaciones").Value,
                                .Eliminado = "NO",
                                .AscUsuarios = DatosSesion._Usuario
                            }
                        })
                    ElseIf item.Cells("idDetalleCheque").Value <> 0 Then
                        _DetalleCheques.Add(New DetalleCheque With {
                            .IdDetalleCheque = item.Cells("idDetalleCheque").Value,
                            .Numero = item.Cells("Numero").Value,
                            .FechaEmision = item.Cells("FechaEmision").Value,
                            .FechaCobro = item.Cells("FechaCobro").Value,
                            .PlazoDias = DateDiff(DateInterval.Day, item.Cells("FechaEmision").Value, item.Cells("FechaCobro").Value),
                            .Importe = UtilidadesVarias.SoloNumeros(item.Cells("Importe").Value),
                            .Destino = txtRSprov.Text,
                            .EnDisponiblidad = "NO",
                            .Cobrado = "NO",
                            .Anulado = "NO",
                            .Modificado = "NO",
                            .Modificacion = "-",
                            .Observaciones = item.Cells("Observaciones").Value,
                            .AscUsuarios = DatosSesion._Usuario,
                            .AscChequera = New Chequeras With {.IdChequera = item.Cells("idChequera").Value},
                            .Eliminado = "NO"
                        })
                    End If
                Next

                Dim _CuentaCorrienteCompra As New CuentaCorrienteCompra With {
                    .Fecha = txtFec.Text,
                    .FechaVto = txtFec.Text,
                    .Comprobante = "ORDEN DE PAGO",
                    .Numero = cmbPtoVta.Text + " - " + txtNroOrden.Text,
                    .Detalle = detalleCuentaCte,
                    .Debito = 0,
                    .Credito = UtilidadesVarias.SoloNumeros(txtTotalDolares.Text) + UtilidadesVarias.SoloNumeros(txtTotalPesos.Text) / UtilidadesVarias.SoloNumeros(txtTC.Text),
                    .Visible = "SI",
                    .AscProveedores = New Proveedores With {.IdProveedor = txtCtaProv.Text},
                    .AscUsuarios = DatosSesion._Usuario,
                    .Eliminado = "NO"
                }

                If txtOrigen.Text = "Nuevo" Then
                    Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Orden de Pago ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                    If resp = DialogResult.OK Then
                        Notificaciones.arbirFormProceso("GUARDANDO ORDEN DE PAGO")

                        Dim _Numeracion As New Numeracion

                        For Each item In listadoNumeracion
                            If item.PuntoVenta = cmbPtoVta.Text Then
                                _Numeracion.IdNumeracion = item.IdNumeracion
                                _Numeracion.NroOrdenCompra = item.NroOrdenCompra + 1
                            End If
                        Next

                        If Await _TareasOrdenDePago.Servicio_Insertar(_OrdenDePago, _Numeracion, _CuentaCorrienteCompra, _OrdenDePagoDetalle, _Caja, _DetalleCheques, _MovimientoValores, _OrdenDePagoMonedas) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox("Orden de Pago guardada con exito !", Botones.OK, Iconos.OK)

                            resp = Notificaciones.MsgBox("Desea imprimir la Orden de Pago ?", Botones.SI_NO, Iconos.INFORMACION)

                            If resp = DialogResult.OK Then
                                UtilidadesVarias.Escalar(frmReporte)

                                frmReporte.rvReporte.Reset()

                                frmReporte.rvReporte.LocalReport.ReportPath = Reportes.RPT_ORDEN_DE_PAGO

                                frmReporte.rvReporte.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

                                frmReporte.rvReporte.LocalReport.DataSources.Clear()
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEmpresa", New BindingSource() With {.DataSource = DatosSesion._Empresa}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsProveedor", New BindingSource() With {.DataSource = infoProveedor}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsOrdenCompra", New BindingSource() With {.DataSource = _OrdenDePago}))
                                frmReporte.rvReporte.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsOrdenPagoDetalle", New BindingSource() With {.DataSource = _OrdenDePagoDetalle}))
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
                            Notificaciones.MsgBox(_TareasOrdenDePago.Err.Descripcion, Botones.OK, Iconos.ERR)
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
                txtNroOrden.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroOrdenCompra + 1)

                Exit For
            End If
        Next

        txtFec.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        Activar()
    End Sub

    Private Sub btnEfectivo_Click(sender As Object, e As EventArgs) Handles btnEfectivo.Click
        If txtProv.Text <> "" Then
            dgvDetalleOrden.CurrentCell = Nothing

            frmOrdenPagoEfectivo.Dispose()
            UtilidadesVarias.Escalar(frmOrdenPagoEfectivo)
            frmOrdenPagoEfectivo.txtOrigen.Text = "Agregar"
            frmOrdenPagoEfectivo.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleOrden)

            btnEfectivo.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el Proveedor sobre el cual se va a emitir la Orden de Pago.", Botones.OK, Iconos.ALERTA)
            txtCtaProv.Select()
        End If
    End Sub

    Private Sub btnValorCartera_Click(sender As Object, e As EventArgs) Handles btnValorCartera.Click
        If txtProv.Text <> "" Then
            dgvDetalleOrden.CurrentCell = Nothing

            frmListaValoresEnCartera.Dispose()
            UtilidadesVarias.Escalar(frmListaValoresEnCartera)
            frmListaValoresEnCartera.txtLista.Text = "Disponibles"
            frmListaValoresEnCartera.txtFormOrigen.Text = "OrdenPago"

            If frmListaValoresEnCartera.ShowDialog() = DialogResult.OK Then
                Dim imp As String = ""

                If frmListaValoresEnCartera.Valor.Moneda = "PESO" Then
                    imp = Format(UtilidadesVarias.SoloNumeros(frmListaValoresEnCartera.Valor.Importe), "$ #,##0.00")
                ElseIf frmListaValoresEnCartera.Valor.Moneda = "DOLAR" Then
                    imp = Format(UtilidadesVarias.SoloNumeros(frmListaValoresEnCartera.Valor.Importe), "U$S #,##0.00")
                End If

                dgvDetalleOrden.Rows.Add(frmListaValoresEnCartera.Valor.IdValoresEnCartera, 0, 0, frmListaValoresEnCartera.Valor.TipoValor, frmListaValoresEnCartera.Valor.Banco,
                                         frmListaValoresEnCartera.Valor.Sucursal, frmListaValoresEnCartera.Valor.Numero, frmListaValoresEnCartera.Valor.Librador, "-",
                                         Format(frmListaValoresEnCartera.Valor.FechaCobro, "dd/MM/yyyy"), frmListaValoresEnCartera.Valor.Moneda, imp, "-")
            End If

            Importe()
            UtilidadesDGV.CabeceraDGV(dgvDetalleOrden)
            btnEfectivo.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el Proveedor sobre el cual se va a emitir la Orden de Pago.", Botones.OK, Iconos.ALERTA)
            txtCtaProv.Select()
        End If
    End Sub

    Private Sub btnValorPropio_Click(sender As Object, e As EventArgs) Handles btnChequePropio.Click
        If txtProv.Text <> "" Then
            dgvDetalleOrden.CurrentCell = Nothing

            frmOrdenPagoChequePropio.Dispose()
            UtilidadesVarias.Escalar(frmOrdenPagoChequePropio)
            frmOrdenPagoChequePropio.txtOrigen.Text = "Agregar"
            frmOrdenPagoChequePropio.ShowDialog()

            Importe()

            UtilidadesDGV.CabeceraDGV(dgvDetalleOrden)

            btnEfectivo.Select()
        Else
            Notificaciones.MsgBox("Primero debes especificar el Proveedor sobre el cual se va a emitir la Orden de Pago.", Botones.OK, Iconos.ALERTA)
            txtCtaProv.Select()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvDetalleOrden.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item.", Botones.OK, Iconos.ALERTA)
        Else
            If dgvDetalleOrden.CurrentRow.Cells("idValoresEnCartera").Value = 0 Then
                If dgvDetalleOrden.CurrentRow.Cells("Tipo").Value = "EFECTIVO" Then
                    frmOrdenPagoEfectivo.Dispose()
                    UtilidadesVarias.Escalar(frmOrdenPagoEfectivo)
                    frmOrdenPagoEfectivo.txtOrigen.Text = "Editar"

                    frmOrdenPagoEfectivo.ShowDialog()
                ElseIf dgvDetalleOrden.CurrentRow.Cells("idDetalleCheque").Value <> 0 Then
                    frmOrdenPagoChequePropio.Dispose()
                    UtilidadesVarias.Escalar(frmOrdenPagoChequePropio)
                    frmOrdenPagoChequePropio.txtOrigen.Text = "Editar"

                    frmOrdenPagoChequePropio.ShowDialog()
                End If

                Importe()

                UtilidadesDGV.CabeceraDGV(dgvDetalleOrden)

                btnEfectivo.Select()
            Else
                Notificaciones.MsgBox("Los valores que fueron agregados desde la cartera solo se pueden quitar de la lista no editar.", Botones.OK, Iconos.ALERTA)
                btnQuitar.Select()
            End If
        End If
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvDetalleOrden.CurrentCell Is Nothing Then
            Notificaciones.MsgBox("No seleccionaste ningun item", Botones.OK, Iconos.ALERTA)
        Else
            dgvDetalleOrden.Rows.Remove(dgvDetalleOrden.CurrentRow)

            UtilidadesDGV.CabeceraDGV(dgvDetalleOrden)

            Importe()

            btnEfectivo.Select()
        End If
    End Sub

    Private Sub dgvDetalleOrden_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleOrden.CellClick
        If e.RowIndex > -1 Then
            If dgvDetalleOrden.CurrentRow.Cells("Tipo").Value = "EFECTIVO" Or dgvDetalleOrden.CurrentRow.Cells("idDetalleCheque").Value <> 0 Then
                btnEditar.Select()
            Else
                btnQuitar.Select()
            End If
        Else
            dgvDetalleOrden.CurrentCell = Nothing
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

            btnEfectivo.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtTC.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
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
                    infoProveedor = frmListaProveedores.infoProveedor

                    txtCtaProv.Text = infoProveedor.IdProveedor
                    txtRSprov.Text = infoProveedor.RazonSocial
                    txtDirec.Text = infoProveedor.Direccion
                    txtLoc.Text = infoProveedor.Localidad
                    txtProv.Text = infoProveedor.Provincia
                    txtCuit.Text = infoProveedor.CUIT
                    txtIIBB.Text = infoProveedor.IIBB
                    txtTE.Text = infoProveedor.Telefono

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
                            txtNroOrden.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroOrdenCompra + 1)

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

    Private Sub TxtCtaProv_TextChanged(sender As Object, e As EventArgs) Handles txtCtaProv.TextChanged
        txtRSprov.Text = ""
        txtDirec.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtCuit.Text = ""
        txtIIBB.Text = ""
        txtTE.Text = ""

        If txtCtaProv.Text <> "" Then
            For Each item In listadoProveedores
                If item.IdProveedor = txtCtaProv.Text Then
                    infoProveedor = item

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

    Private Sub cmbPtoVta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPtoVta.SelectedIndexChanged
        If txtOrigen.Text <> "Modificar" Then
            txtNroOrden.Text = ""

            For Each num In listadoNumeracion
                If num.PuntoVenta = cmbPtoVta.Text Then
                    txtNroOrden.Text = UtilidadesVarias.GenerarNumeroComprobante("", num.NroOrdenCompra + 1)

                    Exit For
                End If
            Next
        End If
    End Sub
#End Region
End Class