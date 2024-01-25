Imports Procesos

Public Class frmListaOrdenDePago
    '    Private _TareaOrdenDePago As TareasOrdenDePago
    '    Private listCompleta As List(Of OrdenDePago)

    '    Public Property infoOrden As OrdenDePago

    '#Region "EVENTOS LOAD"
    '    Private Sub frmListaRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        _TareaOrdenDePago = New TareasOrdenDePago()

    '        tmrLoad.Enabled = True
    '    End Sub

    '    Private Async Sub TmrDgvs_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
    '        tmrLoad.Enabled = False

    '        UtilidadesDGV.FormatoDGVGeneral(dgvOrdenPago)

    '        ConfigDGV_REMITOS()

    '        UtilidadesDGV.DescargarDGV(dgvOrdenPago)

    '        Notificaciones.arbirFormProceso()

    '        If txtLista.Text = "Completa" Then
    '            lblTitulo.Text = "LISTADO DE REMITOS CARGADOS"

    '            listCompletaRemitosCompra = Await _TareaRemitoCompra.ListadoCompleto()
    '        ElseIf txtLista.Text = "Sin Facturar" Then
    '            lblTitulo.Text = "LISTADO DE REMITOS SIN FACTURAR"

    '            listCompletaRemitosCompra = Await _TareaRemitoCompra.ListadoSinFacturar()
    '        ElseIf txtLista.Text = "Para Modificar" Or txtLista.Text = "Para Eliminar" Then
    '            If txtLista.Text = "Para Modificar" Then
    '                lblTitulo.Text = "LISTADO DE REMITOS PARA MODIFICAR"
    '            Else
    '                lblTitulo.Text = "LISTADO DE REMITOS PARA ELIMINAR"
    '            End If

    '            listCompletaRemitosCompra = Await _TareaRemitoCompra.ListadoSinFacturar()

    '            If Not IsNothing(listCompletaRemitosCompra) Then
    '                Dim items As Integer = listCompletaRemitosCompra.Count - 1

    '                If items >= 0 Then
    '                    For j As Integer = items To 0 Step -1
    '                        Dim DetalleRemito As List(Of DetalleRemitoCompra) = Await _TareaDetalleRemitoCompra.ListadoDetalleRemitoCompra(listCompletaRemitosCompra.Item(j).IdRemitosCompra)

    '                        If Not IsNothing(DetalleRemito) Then
    '                            For Each Det In DetalleRemito
    '                                If Det.Facturado = "SI" Then
    '                                    listCompletaRemitosCompra.RemoveAt(j)

    '                                    Exit For
    '                                End If
    '                            Next
    '                        Else
    '                            Exit For
    '                        End If
    '                    Next
    '                End If
    '            End If
    '        End If

    '        If Not IsNothing(listCompletaRemitosCompra) And _TareaRemitoCompra.Err.Identificador = EnumErrores.OK Then
    '            TareasRemitoCompra.LlenarDGV(dgvRemitos, listCompletaRemitosCompra)

    '            UtilidadesDGV.CabeceraDGV(dgvRemitos)

    '            Notificaciones.cerrarFormProceso()
    '        Else
    '            Notificaciones.cerrarFormProceso()

    '            If _TareaRemitoCompra.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
    '                If txtLista.Text = "Sin Facturar" Then
    '                    Notificaciones.MsgBox("No hay Remitos de Compra pendientes de facturar", Botones.OK, Iconos.INFORMACION)
    '                ElseIf txtLista.Text = "Para Modificar" Or txtLista.Text = "Para Eliminar" Then
    '                    Notificaciones.MsgBox("No hay Remitos de Compra que se puedan Modificar o Eliminar", Botones.OK, Iconos.INFORMACION)
    '                End If
    '            Else
    '                Notificaciones.MsgBox(_TareaRemitoCompra.Err.Descripcion, Botones.OK, Iconos.ERR)
    '            End If

    '            Me.Close()
    '        End If

    '        txtBuscProv.Select()
    '    End Sub
    '#End Region

    '#Region "METODOS PRIVADOS"
    '    Private Sub ConfigDGV_REMITOS()
    '        dgvRemitos.ColumnCount = 9
    '        dgvRemitos.Columns(0).Name = "idRemitosCompra"
    '        dgvRemitos.Columns(1).Name = "idProveedores"
    '        dgvRemitos.Columns(2).Name = "idUsuarios"
    '        dgvRemitos.Columns(3).Name = "Fecha"
    '        dgvRemitos.Columns(4).Name = "NroComprobante"
    '        dgvRemitos.Columns(5).Name = "RazonSocial"
    '        dgvRemitos.Columns(6).Name = "Importe"
    '        dgvRemitos.Columns(7).Name = "Facturado"
    '        dgvRemitos.Columns(8).Name = "Observaciones"

    '        dgvRemitos.Columns("idRemitosCompra").Visible = False
    '        dgvRemitos.Columns("idProveedores").Visible = False
    '        dgvRemitos.Columns("idUsuarios").Visible = False
    '        dgvRemitos.Columns("Facturado").Visible = False


    '        dgvRemitos.Columns("Fecha").HeaderText = "FECHA"
    '        dgvRemitos.Columns("NroComprobante").HeaderText = "NRO COMP."
    '        dgvRemitos.Columns("RazonSocial").HeaderText = "PROVEEDOR"
    '        dgvRemitos.Columns("Importe").HeaderText = "IMPORTE"
    '        dgvRemitos.Columns("Observaciones").HeaderText = "OBSERVACIONES"

    '        dgvRemitos.Columns("idRemitosCompra").DisplayIndex = 0
    '        dgvRemitos.Columns("idProveedores").DisplayIndex = 1
    '        dgvRemitos.Columns("idUsuarios").DisplayIndex = 2
    '        dgvRemitos.Columns("Fecha").DisplayIndex = 3
    '        dgvRemitos.Columns("NroComprobante").DisplayIndex = 4
    '        dgvRemitos.Columns("RazonSocial").DisplayIndex = 5
    '        dgvRemitos.Columns("Importe").DisplayIndex = 6
    '        dgvRemitos.Columns("Facturado").DisplayIndex = 7
    '        dgvRemitos.Columns("Observaciones").DisplayIndex = 8
    '    End Sub
    '#End Region

    '#Region "EVENTOS CLICK"
    '    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
    '        Me.DialogResult = DialogResult.Cancel

    '        Me.Close()
    '    End Sub

    '    Private Sub dgvRemitos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrdenPago.CellDoubleClick
    '        If e.RowIndex > -1 Then
    '            infoOrden = New OrdenDePago With {
    '                .IdOrdenDePago = dgvOrdenPago.CurrentRow.Cells("idRemitosCompra").Value,
    '                .Fecha = dgvOrdenPago.CurrentRow.Cells("Fecha").Value,
    '                .NroComprobante = dgvOrdenPago.CurrentRow.Cells("NroComprobante").Value,
    '                .ImportePesos = UtilidadesVarias.SoloNumeros(dgvOrdenPago.CurrentRow.Cells("Importe").Value),
    '                .ImporteDolares = UtilidadesVarias.SoloNumeros(dgvOrdenPago.CurrentRow.Cells("Importe").Value),
    '                .Observaciones = dgvOrdenPago.CurrentRow.Cells("Observaciones").Value,
    '                .AscProveedores = New Proveedores With {
    '                    .IdProveedor = dgvOrdenPago.CurrentRow.Cells("idProveedores").Value,
    '                    .RazonSocial = dgvOrdenPago.CurrentRow.Cells("RazonSocial").Value
    '                },
    '                .AscUsuarios = New Usuario With {.IdUsuario = dgvOrdenPago.CurrentRow.Cells("idUsuarios").Value},
    '                .AscCuentaCorrienteCompra = New CuentaCorrienteCompra With {.IdCuentaCorrienteCompra = dgvOrdenPago.CurrentRow.Cells("idUsuarios").Value}
    '            }

    '            Me.DialogResult = DialogResult.OK

    '            Me.Close()
    '        End If
    '    End Sub
    '#End Region

    '#Region "EVENTOS KEY PRESS"
    '    Private Sub txtBuscFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscFec.KeyPress
    '        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
    '            e.Handled = True
    '        ElseIf Asc(e.KeyChar) = Keys.Enter Then
    '            e.Handled = True

    '            txtBuscProv.SelectionLength = Len(txtBuscProv.Text)
    '            txtBuscProv.Select()
    '        End If
    '    End Sub

    '    Private Sub txtBuscNroOrd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscNroOrd.KeyPress
    '        If Asc(e.KeyChar) = Keys.Enter Then
    '            e.Handled = True

    '            txtBuscFec.SelectionLength = Len(txtBuscFec.Text)
    '            txtBuscFec.Select()
    '        End If
    '    End Sub

    '    Private Sub txtBuscProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscProv.KeyPress
    '        If Asc(e.KeyChar) = Keys.Enter Then
    '            e.Handled = True

    '            txtBuscNroOrd.SelectionLength = Len(txtBuscNroOrd.Text)
    '            txtBuscNroOrd.Select()
    '        End If
    '    End Sub
    '#End Region

    '#Region "EVENTOS VALIDATED"
    '    Private Sub txtBuscFec_Validated(sender As Object, e As EventArgs) Handles txtBuscFec.Validated
    '        If txtBuscFec.Text <> "" Then
    '            If Not IsDate(txtBuscFec.Text) Then
    '                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ERR)
    '                txtBuscFec.Text = ""
    '            Else
    '                txtBuscFec.Text = Format(CDate(txtBuscFec.Text), "dd/MM/yyyy")
    '            End If
    '        End If
    '    End Sub
    '#End Region

    '#Region "EVENTOS CHANGED"
    '    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscFec.TextChanged, txtBuscNroOrd.TextChanged, txtBuscProv.TextChanged
    '        Dim listFiltrada As New List(Of OrdenDePago)

    '        UtilidadesDGV.DescargarDGV(dgvOrdenPago)

    '        For Each item In listCompleta
    '            If UCase(item.NroComprobante).Contains(UCase(txtBuscNroOrd.Text)) And UCase(item.Fecha).Contains(UCase(txtBuscFec.Text)) And UCase(item.AscProveedores.RazonSocial).Contains(UCase(txtBuscProv.Text)) Then
    '                listFiltrada.Add(item)
    '            End If
    '        Next

    '        TareasOrdenDePago.LlenarDGV(dgvOrdenPago, listFiltrada)

    '        UtilidadesDGV.CabeceraDGV(dgvOrdenPago)
    '    End Sub
    '#End Region

End Class