Public Class frmListaFacturaVenta
    'Public Facturas As New List(Of mdlFacturaVenta)

    'Public Property Fac As New mdlFacturaVenta

    'Private Sub frmListaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    tmrLoad.Enabled = True
    'End Sub

    'Private Sub ConfigDGV_FACTURAS()
    '    dgvFacturasVenta.ColumnCount = 15
    '    dgvFacturasVenta.Columns(0).Name = "idFacturaVenta"
    '    dgvFacturasVenta.Columns(1).Name = "idClientes"
    '    dgvFacturasVenta.Columns(2).Name = "idCuentaCorrienteVentas"
    '    dgvFacturasVenta.Columns(3).Name = "idUsuarios"
    '    dgvFacturasVenta.Columns(4).Name = "Fecha"
    '    dgvFacturasVenta.Columns(5).Name = "FechaVto"
    '    dgvFacturasVenta.Columns(6).Name = "TipoComprobante"
    '    dgvFacturasVenta.Columns(7).Name = "ClaseComprobante"
    '    dgvFacturasVenta.Columns(8).Name = "Prefijo"
    '    dgvFacturasVenta.Columns(9).Name = "NroComprobante"
    '    dgvFacturasVenta.Columns(10).Name = "Cliente"
    '    dgvFacturasVenta.Columns(11).Name = "ImporteNeto"
    '    dgvFacturasVenta.Columns(12).Name = "Iva"
    '    dgvFacturasVenta.Columns(13).Name = "ImporteTotal"
    '    dgvFacturasVenta.Columns(14).Name = "Observaciones"

    '    dgvFacturasVenta.Columns("idFacturaVenta").Visible = False
    '    dgvFacturasVenta.Columns("idClientes").Visible = False
    '    dgvFacturasVenta.Columns("idCuentaCorrienteVentas").Visible = False
    '    dgvFacturasVenta.Columns("idUsuarios").Visible = False

    '    dgvFacturasVenta.Columns("Fecha").HeaderText = "FECHA"
    '    dgvFacturasVenta.Columns("FechaVto").HeaderText = "VTO"
    '    dgvFacturasVenta.Columns("TipoComprobante").HeaderText = "TIPO"
    '    dgvFacturasVenta.Columns("ClaseComprobante").HeaderText = "CLASE"
    '    dgvFacturasVenta.Columns("Prefijo").HeaderText = "PREFIJO"
    '    dgvFacturasVenta.Columns("NroComprobante").HeaderText = "NRO FACTURA"
    '    dgvFacturasVenta.Columns("Cliente").HeaderText = "CLIENTE"
    '    dgvFacturasVenta.Columns("ImporteNeto").HeaderText = "IMP NETO"
    '    dgvFacturasVenta.Columns("Iva").HeaderText = "IVA"
    '    dgvFacturasVenta.Columns("ImporteTotal").HeaderText = "IMP TOTAL"
    '    dgvFacturasVenta.Columns("Observaciones").HeaderText = "OBSERVACIONES"

    '    dgvFacturasVenta.Columns("idFacturaVenta").DisplayIndex = 0
    '    dgvFacturasVenta.Columns("idClientes").DisplayIndex = 1
    '    dgvFacturasVenta.Columns("idCuentaCorrienteVentas").DisplayIndex = 2
    '    dgvFacturasVenta.Columns("idUsuarios").DisplayIndex = 3
    '    dgvFacturasVenta.Columns("Fecha").DisplayIndex = 4
    '    dgvFacturasVenta.Columns("FechaVto").DisplayIndex = 5
    '    dgvFacturasVenta.Columns("TipoComprobante").DisplayIndex = 6
    '    dgvFacturasVenta.Columns("ClaseComprobante").DisplayIndex = 7
    '    dgvFacturasVenta.Columns("Prefijo").DisplayIndex = 8
    '    dgvFacturasVenta.Columns("NroComprobante").DisplayIndex = 9
    '    dgvFacturasVenta.Columns("Cliente").DisplayIndex = 10
    '    dgvFacturasVenta.Columns("ImporteNeto").DisplayIndex = 11
    '    dgvFacturasVenta.Columns("Iva").DisplayIndex = 12
    '    dgvFacturasVenta.Columns("ImporteTotal").DisplayIndex = 13
    '    dgvFacturasVenta.Columns("Observaciones").DisplayIndex = 14

    '    dgvFacturasVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    'End Sub

    'Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
    '    Me.DialogResult = DialogResult.Cancel

    '    Me.Close()
    'End Sub

    'Private Sub txtBuscFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscFec.KeyPress
    '    If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
    '        e.Handled = True
    '    ElseIf Asc(e.KeyChar) = Keys.Enter Then
    '        e.Handled = True

    '        txtBuscCli.SelectionLength = Len(txtBuscCli.Text)
    '        txtBuscCli.Select()
    '    End If
    'End Sub

    'Private Sub txtBuscFec_Validated(sender As Object, e As EventArgs) Handles txtBuscFec.Validated
    '    If txtBuscFec.Text <> "" Then
    '        If Not IsDate(txtBuscFec.Text) Then
    '            MsgBoxSIGEVA("Formato de Fecha incorrecto.", "Ok", "Error", Me)
    '            txtBuscFec.Text = ""
    '        Else
    '            txtBuscFec.Text = Format(CDate(txtBuscFec.Text), "dd/MM/yyyy")
    '        End If
    '    End If
    'End Sub

    'Private Sub txtBuscNroFac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscNroFac.KeyPress
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        e.Handled = True

    '        txtBuscFec.SelectionLength = Len(txtBuscFec.Text)
    '        txtBuscFec.Select()
    '    End If
    'End Sub

    'Private Sub TxtBuscarRes_TextChanged(sender As Object, e As EventArgs) Handles txtBuscFec.TextChanged, txtBuscNroFac.TextChanged, txtBuscCli.TextChanged
    '    Dim Filtro As String = ""
    '    Dim Campos() As Boolean = {False, False, False}

    '    DescargarDGV(dgvFacturasVenta)

    '    If txtBuscNroFac.Text <> "" Then
    '        Filtro += UCase(txtBuscNroFac.Text)
    '        Campos(0) = True
    '    End If

    '    If txtBuscFec.Text <> "" Then
    '        Filtro += UCase(txtBuscFec.Text)
    '        Campos(1) = True
    '    End If

    '    If txtBuscCli.Text <> "" Then
    '        Filtro += UCase(txtBuscCli.Text)
    '        Campos(2) = True
    '    End If

    '    For Each Item In Facturas
    '        Dim Pedido As String = ""

    '        If Campos(0) Then
    '            Pedido += UCase(Item.NroComprobante)
    '        End If

    '        If Campos(1) Then
    '            Pedido += UCase(Item.Fecha)
    '        End If

    '        If Campos(2) Then
    '            Pedido += UCase(Item.ascClientes.RazonSocial)
    '        End If

    '        If Pedido = Filtro Then
    '            dgvFacturasVenta.Rows.Add(Item.idFacturaVenta, Item.ascClientes.idCliente, Item.ascCtaCteVenta.idCuentaCorrienteVentas, Item.ascUsuarios.idUsuario, Item.Fecha,
    '                                      Item.FechaVto, Item.TipoComprobante, Item.ClaseComprobante, Item.Prefijo, Item.NroComprobante, Item.ascClientes.RazonSocial, Item.ImporteNeto,
    '                                      Item.Iva, Item.ImporteTotal, Item.Observaciones)
    '        End If
    '    Next

    '    If dgvFacturasVenta.Rows.Count < 1 Then
    '        dgvFacturasVenta.ColumnHeadersVisible = False
    '    Else
    '        dgvFacturasVenta.ColumnHeadersVisible = True
    '    End If

    '    dgvFacturasVenta.CurrentCell = Nothing
    'End Sub

    'Private Async Sub dgvFacturasVenta_CellDoubleClickAsync(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturasVenta.CellDoubleClick
    '    If e.RowIndex > -1 Then
    '        Dim Detalle As List(Of mdlFacturaVentaDetalle) = Await New mdlFacturaVentaDetalle().Filtrar(dgvFacturasVenta.CurrentRow.Cells("idFacturaVenta").Value,, False, True)
    '        Dim Sum As Double = 0

    '        For Each item In Detalle
    '            Dim Stk As mdlStock = Await New mdlStock().stkFisico(item.ascArticulos.idArticulo)
    '            Sum += Stk.Cantidad
    '        Next

    '        If Sum <> 0 Then
    '            Fac.idFacturaVenta = dgvFacturasVenta.CurrentRow.Cells("idFacturaVenta").Value
    '            Fac.ascClientes.idCliente = dgvFacturasVenta.CurrentRow.Cells("idClientes").Value
    '            Fac.ascCtaCteVenta.idCuentaCorrienteVentas = dgvFacturasVenta.CurrentRow.Cells("idCuentaCorrienteVentas").Value
    '            Fac.ascUsuarios.idUsuario = dgvFacturasVenta.CurrentRow.Cells("idUsuarios").Value
    '            Fac.Fecha = dgvFacturasVenta.CurrentRow.Cells("Fecha").Value
    '            Fac.FechaVto = dgvFacturasVenta.CurrentRow.Cells("FechaVto").Value
    '            Fac.TipoComprobante = dgvFacturasVenta.CurrentRow.Cells("TipoComprobante").Value
    '            Fac.ClaseComprobante = dgvFacturasVenta.CurrentRow.Cells("ClaseComprobante").Value
    '            Fac.Prefijo = dgvFacturasVenta.CurrentRow.Cells("Prefijo").Value
    '            Fac.NroComprobante = dgvFacturasVenta.CurrentRow.Cells("NroComprobante").Value
    '            Fac.ascClientes.RazonSocial = dgvFacturasVenta.CurrentRow.Cells("Cliente").Value
    '            Fac.ImporteNeto = dgvFacturasVenta.CurrentRow.Cells("ImporteNeto").Value
    '            Fac.Iva = dgvFacturasVenta.CurrentRow.Cells("Iva").Value
    '            Fac.ImporteTotal = dgvFacturasVenta.CurrentRow.Cells("ImporteTotal").Value
    '            Fac.Observaciones = dgvFacturasVenta.CurrentRow.Cells("Observaciones").Value
    '            Fac.Err = "OK"

    '            Me.DialogResult = DialogResult.OK

    '            Me.Close()
    '        Else
    '            MsgBoxSIGEVA("No se puede emitir un Remito sobre esta Factura debido a que no hay Stock Fisico disponible de los articulos Facturados", "Ok", "Informacion", Me)
    '        End If
    '    End If
    'End Sub

    'Private Async Sub TmrDgvs_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
    '    tmrLoad.Enabled = False

    '    dgvFacturasVenta = FormatoDGVGeneral(dgvFacturasVenta)

    '    ConfigDGV_FACTURAS()

    '    DescargarDGV(dgvFacturasVenta)

    '    If txtLista.Text = "Completa" Then
    '        lblTitulo.Text = "LISTA DE FACTURAS CARGADAS"

    '        Facturas = Await New mdlFacturaVenta().Todos(, False, True)
    '    ElseIf txtLista.Text = "Sin Remitar" Then
    '        lblTitulo.Text = "LISTADO DE FACTURAS SIN REMITAR"

    '        Facturas = Await New mdlFacturaVenta().SinRemitar(, False, True)
    '    ElseIf txtLista.Text = "Para Modificar" Or txtLista.Text = "Para Eliminar" Then
    '        If txtLista.Text = "Para Modificar" Then
    '            lblTitulo.Text = "LISTA DE FACTURAS PARA MODIFICAR"
    '        Else
    '            lblTitulo.Text = "LISTA DE FACTURAS PARA ELIMINAR"
    '        End If

    '        Facturas = Await New mdlFacturaVenta().SinRemitar(, False, False)

    '        If Facturas.First.Err = "OK" Then
    '            Dim items As Integer = Facturas.Count - 1

    '            If items > 0 Then
    '                For j As Integer = items To 0 Step -1
    '                    Dim Detalle As List(Of mdlFacturaVentaDetalle) = Await New mdlFacturaVentaDetalle().Filtrar(Facturas.Item(j).idFacturaVenta,, False, False)

    '                    For Each Det In Detalle
    '                        If Det.Remitado = "SI" Then
    '                            Facturas.RemoveAt(j)

    '                            Exit For
    '                        End If
    '                    Next
    '                Next
    '            End If

    '            If Facturas.Count = 0 Then
    '                Facturas.Add(New mdlFacturaVenta)
    '                Facturas.First.Err = "1"
    '            End If
    '        End If
    '    End If

    '    HabilitarForms()
    '    frmProceso.Dispose()

    '    If Facturas.First.Err = "OK" Then
    '        For Each Item In Facturas
    '            dgvFacturasVenta.Rows.Add(Item.idFacturaVenta, Item.ascClientes.idCliente, Item.ascCtaCteVenta.idCuentaCorrienteVentas, Item.ascUsuarios.idUsuario, Item.Fecha,
    '                                      Item.FechaVto, Item.TipoComprobante, Item.ClaseComprobante, Item.Prefijo, Item.NroComprobante, Item.ascClientes.RazonSocial, Item.ImporteNeto,
    '                                      Item.Iva, Item.ImporteTotal, Item.Observaciones)
    '        Next
    '    ElseIf Facturas.First.Err = "1" Then
    '        If txtLista.Text = "Para Modificar" Or txtLista.Text = "Para Eliminar" Then
    '            MsgBoxSIGEVA("No hay Facturas que se puedan Modificar o Eliminar", "Ok", "Informacion", Me)
    '        ElseIf txtLista.Text = "Sin Remitar" Then
    '            MsgBoxSIGEVA("No hay Facturas pendientes de Remitar", "Ok", "Informacion", Me)
    '        Else
    '            MsgBoxSIGEVA("No hay Facturas cargadas en el sistema", "Ok", "Informacion", Me)
    '        End If

    '        Me.Close()
    '    Else
    '        MsgBoxSIGEVA(Facturas.First.Err, "Ok", "Error", Me)
    '        Me.Close()
    '    End If

    '    If dgvFacturasVenta.Rows.Count < 1 Then
    '        dgvFacturasVenta.ColumnHeadersVisible = False
    '        dgvFacturasVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '    Else
    '        dgvFacturasVenta.ColumnHeadersVisible = True
    '    End If

    '    dgvFacturasVenta.CurrentCell = Nothing
    '    txtBuscNroFac.Select()
    'End Sub
End Class