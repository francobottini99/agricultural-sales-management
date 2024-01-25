Imports Procesos

Public Class frmListaFacturaCompra
    Private _TareasFactura As TareasFacturaCompra
    Private listCompletaFacturas As List(Of FacturaCompra)

    Public Property infoFactura As FacturaCompra

#Region "LOAD"
    Private Sub frmListaFacturaCompra_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        _TareasFactura = New TareasFacturaCompra()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        UtilidadesDGV.FormatoDGVGeneral(dgvFacturas)

        ConfigDGV_FACTURAS()

        UtilidadesDGV.DescargarDGV(dgvFacturas)

        listCompletaFacturas = Await _TareasFactura.verFacturaCompra()

        If Not IsNothing(listCompletaFacturas) Then
            TareasFacturaCompra.LlenarDGV(dgvFacturas, listCompletaFacturas)

            UtilidadesDGV.CabeceraDGV(dgvFacturas)

            Notificaciones.cerrarFormProceso()
        Else
            Notificaciones.cerrarFormProceso()

            If _TareasFactura.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Notificaciones.MsgBox("No hay Facturas de Compra que se puedan Modificar o Eliminar", Botones.OK, Iconos.ALERTA)
            Else
                Notificaciones.MsgBox(_TareasFactura.Err.Descripcion, Botones.OK, Iconos.ERR)
            End If

            Me.Close()
        End If

        txtBuscProv.Select()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDGV_FACTURAS()
        dgvFacturas.ColumnCount = 13
        dgvFacturas.Columns(0).Name = "idFacturaCompra"
        dgvFacturas.Columns(1).Name = "idProveedores"
        dgvFacturas.Columns(2).Name = "idCuentaCorrienteCompra"
        dgvFacturas.Columns(3).Name = "Fecha"
        dgvFacturas.Columns(4).Name = "FechaVto"
        dgvFacturas.Columns(5).Name = "Tipo"
        dgvFacturas.Columns(6).Name = "Proveedor"
        dgvFacturas.Columns(7).Name = "Prefijo"
        dgvFacturas.Columns(8).Name = "NroComprobante"
        dgvFacturas.Columns(9).Name = "ImporteNeto"
        dgvFacturas.Columns(10).Name = "Iva"
        dgvFacturas.Columns(11).Name = "ImporteTotal"
        dgvFacturas.Columns(12).Name = "Observaciones"

        dgvFacturas.Columns("idFacturaCompra").Visible = False
        dgvFacturas.Columns("idProveedores").Visible = False
        dgvFacturas.Columns("idCuentaCorrienteCompra").Visible = False

        dgvFacturas.Columns("Fecha").HeaderText = "FECHA"
        dgvFacturas.Columns("FechaVto").HeaderText = "FECHA VTO"
        dgvFacturas.Columns("Tipo").HeaderText = "TIPO"
        dgvFacturas.Columns("Proveedor").HeaderText = "PROVEEDOR"
        dgvFacturas.Columns("Prefijo").HeaderText = "PREFIJO"
        dgvFacturas.Columns("NroComprobante").HeaderText = "NRO FACTURA"
        dgvFacturas.Columns("ImporteNeto").HeaderText = "IMP. NETO"
        dgvFacturas.Columns("Iva").HeaderText = "IVA"
        dgvFacturas.Columns("ImporteTotal").HeaderText = "IMP. TOTAL"
        dgvFacturas.Columns("Observaciones").HeaderText = "OBSERVACIONES"

        dgvFacturas.Columns("idFacturaCompra").DisplayIndex = 0
        dgvFacturas.Columns("idProveedores").DisplayIndex = 1
        dgvFacturas.Columns("idCuentaCorrienteCompra").DisplayIndex = 2
        dgvFacturas.Columns("Fecha").DisplayIndex = 3
        dgvFacturas.Columns("FechaVto").DisplayIndex = 4
        dgvFacturas.Columns("Tipo").DisplayIndex = 5
        dgvFacturas.Columns("Proveedor").DisplayIndex = 6
        dgvFacturas.Columns("Prefijo").DisplayIndex = 7
        dgvFacturas.Columns("NroComprobante").DisplayIndex = 8
        dgvFacturas.Columns("ImporteNeto").DisplayIndex = 9
        dgvFacturas.Columns("Iva").DisplayIndex = 10
        dgvFacturas.Columns("ImporteTotal").DisplayIndex = 11
        dgvFacturas.Columns("Observaciones").DisplayIndex = 12

        'dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub dgvFacturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturas.CellDoubleClick
        If e.RowIndex > -1 Then
            infoFactura = New FacturaCompra With {
                .IdFacturaCompra = dgvFacturas.CurrentRow.Cells("idFacturaCompra").Value,
                .AscProveedores = New Proveedores With {
                    .IdProveedor = dgvFacturas.CurrentRow.Cells("idProveedores").Value,
                    .RazonSocial = dgvFacturas.CurrentRow.Cells("Proveedor").Value
                },
                .ClaseComprobante = dgvFacturas.CurrentRow.Cells("Tipo").Value,
                .AscCuentaCorrienteCompra = New CuentaCorrienteCompra With {.IdCuentaCorrienteCompra = dgvFacturas.CurrentRow.Cells("idCuentaCorrienteCompra").Value},
                .Fecha = dgvFacturas.CurrentRow.Cells("Fecha").Value,
                .FechaVto = dgvFacturas.CurrentRow.Cells("FechaVto").Value,
                .Prefijo = dgvFacturas.CurrentRow.Cells("Prefijo").Value,
                .NroComprobante = dgvFacturas.CurrentRow.Cells("NroComprobante").Value,
                .ImporteNeto = UtilidadesVarias.SoloNumeros(dgvFacturas.CurrentRow.Cells("ImporteNeto").Value),
                .Iva = UtilidadesVarias.SoloNumeros(dgvFacturas.CurrentRow.Cells("Iva").Value),
                .ImporteTotal = UtilidadesVarias.SoloNumeros(dgvFacturas.CurrentRow.Cells("ImporteTotal").Value),
                .Observaciones = dgvFacturas.CurrentRow.Cells("Observaciones").Value
            }

            Me.DialogResult = DialogResult.OK

            Me.Close()
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtBuscFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscFec.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtBuscProv.SelectionLength = Len(txtBuscProv.Text)
            txtBuscProv.Select()
        End If
    End Sub

    Private Sub txtBuscNroFac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscNroFac.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtBuscFec.SelectionLength = Len(txtBuscFec.Text)
            txtBuscFec.Select()
        End If
    End Sub

    Private Sub txtBuscProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscProv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtBuscNroFac.SelectionLength = Len(txtBuscNroFac.Text)
            txtBuscNroFac.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscFec.TextChanged, txtBuscNroFac.TextChanged, txtBuscProv.TextChanged
        Dim listFiltrada As New List(Of FacturaCompra)

        UtilidadesDGV.DescargarDGV(dgvFacturas)

        For Each Item In listCompletaFacturas
            If UCase(Item.AscProveedores.RazonSocial).Contains(UCase(txtBuscProv.Text)) And UCase(Item.Fecha).Contains(UCase(txtBuscFec.Text)) And UCase(Item.NroComprobante).Contains(UCase(txtBuscNroFac.Text)) Then
                listFiltrada.Add(Item)
            End If
        Next

        TareasFacturaCompra.LlenarDGV(dgvFacturas, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvFacturas)
    End Sub
#End Region
End Class