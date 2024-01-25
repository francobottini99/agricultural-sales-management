Imports Procesos

Public Class frmListaRemitosVenta
    Private tareasRemitoVenta As TareasRemitoVenta
    Private tareasDetalleRemitoVenta As TareasDetalleRemitoVenta

    Public listadoRemitos As List(Of RemitoVenta)

    Public Property infoRemito As RemitoVenta

#Region "LOAD"
    Private Sub frmListaRemitosVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tareasDetalleRemitoVenta = New TareasDetalleRemitoVenta()
        tareasRemitoVenta = New TareasRemitoVenta()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvRemitos)

        ConfigDGV_REMITOS()

        UtilidadesDGV.DescargarDGV(dgvRemitos)

        Notificaciones.arbirFormProceso()

        If txtLista.Text = "Completa" Then
            lblTitulo.Text = "LISTADO DE REMITOS CARGADOS"

            listadoRemitos = Await tareasRemitoVenta.ListadoCompleto()
        ElseIf txtLista.Text = "Sin Facturar" Then
            lblTitulo.Text = "LISTADO DE REMITOS SIN FACTURAR"

            listadoRemitos = Await tareasRemitoVenta.ListadoSinFacturar()
        ElseIf txtLista.Text = "Para Modificar" Or txtLista.Text = "Para Eliminar" Then
            If txtLista.Text = "Para Modificar" Then
                lblTitulo.Text = "LISTADO DE REMITOS PARA MODIFICAR"
            Else
                lblTitulo.Text = "LISTADO DE REMITOS PARA ELIMINAR"
            End If

            listadoRemitos = Await tareasRemitoVenta.ListadoSinFacturar()

            If Not IsNothing(listadoRemitos) Then
                Dim items As Integer = listadoRemitos.Count - 1

                If items >= 0 Then
                    For j As Integer = items To 0 Step -1
                        Dim DetalleRemito As List(Of DetalleRemitoVenta) = Await tareasDetalleRemitoVenta.ListadoDetalleRemitoVenta(listadoRemitos.Item(j).IdRemitosVenta)

                        If Not IsNothing(DetalleRemito) Then
                            For Each Det In DetalleRemito
                                If Det.Facturado = "SI" Then
                                    listadoRemitos.RemoveAt(j)

                                    Exit For
                                End If
                            Next
                        Else
                            Exit For
                        End If
                    Next
                End If
            End If
        End If

        If Not IsNothing(listadoRemitos) And tareasRemitoVenta.Err.Identificador = EnumErrores.OK Then
            For Each Item In listadoRemitos
                dgvRemitos.Rows.Add(Item.IdRemitosVenta, Item.AscClientes.IdCliente, Item.AscUsuarios.IdUsuario, Format(Item.Fecha, "dd/MM/yyyy"),
                                    Item.NroComprobante, Item.AscClientes.RazonSocial, Format(Item.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                    Item.Facturado, Item.Observaciones)
            Next

            UtilidadesDGV.CabeceraDGV(dgvRemitos)

            Notificaciones.cerrarFormProceso()
        Else
            Notificaciones.cerrarFormProceso()

            If tareasRemitoVenta.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                If txtLista.Text = "Sin Facturar" Then
                    Notificaciones.MsgBox("No hay Remitos de Venta pendientes de facturar", Botones.OK, Iconos.ALERTA)
                ElseIf txtLista.Text = "Para Modificar" Or txtLista.Text = "Para Eliminar" Then
                    Notificaciones.MsgBox("No hay Remitos de Venta que se puedan Modificar o Eliminar", Botones.OK, Iconos.ALERTA)
                End If
            Else
                Notificaciones.MsgBox(tareasRemitoVenta.Err.Descripcion, Botones.OK, Iconos.ERR)
            End If

            Me.Close()
        End If

        txtBuscCli.Select()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDGV_REMITOS()
        dgvRemitos.ColumnCount = 9
        dgvRemitos.Columns(0).Name = "idRemitosVenta"
        dgvRemitos.Columns(1).Name = "idClientes"
        dgvRemitos.Columns(2).Name = "idUsuarios"
        dgvRemitos.Columns(3).Name = "Fecha"
        dgvRemitos.Columns(4).Name = "NroComprobante"
        dgvRemitos.Columns(5).Name = "RazonSocial"
        dgvRemitos.Columns(6).Name = "Importe"
        dgvRemitos.Columns(7).Name = "Facturado"
        dgvRemitos.Columns(8).Name = "Observaciones"

        dgvRemitos.Columns("idRemitosVenta").Visible = False
        dgvRemitos.Columns("idClientes").Visible = False
        dgvRemitos.Columns("idUsuarios").Visible = False
        dgvRemitos.Columns("Facturado").Visible = False

        dgvRemitos.Columns("Fecha").HeaderText = "FECHA"
        dgvRemitos.Columns("NroComprobante").HeaderText = "NRO COMP."
        dgvRemitos.Columns("RazonSocial").HeaderText = "CLIENTE"
        dgvRemitos.Columns("Importe").HeaderText = "IMPORTE"
        dgvRemitos.Columns("Observaciones").HeaderText = "OBSERVACIONES"

        dgvRemitos.Columns("idRemitosVenta").DisplayIndex = 0
        dgvRemitos.Columns("idClientes").DisplayIndex = 1
        dgvRemitos.Columns("idUsuarios").DisplayIndex = 2
        dgvRemitos.Columns("Fecha").DisplayIndex = 3
        dgvRemitos.Columns("NroComprobante").DisplayIndex = 4
        dgvRemitos.Columns("RazonSocial").DisplayIndex = 5
        dgvRemitos.Columns("Importe").DisplayIndex = 6
        dgvRemitos.Columns("Facturado").DisplayIndex = 7
        dgvRemitos.Columns("Observaciones").DisplayIndex = 8

        dgvRemitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub dgvRemitos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRemitos.CellDoubleClick
        If e.RowIndex > -1 Then
            infoRemito = New RemitoVenta With {
                .IdRemitosVenta = dgvRemitos.CurrentRow.Cells("idRemitosVenta").Value,
                .Fecha = dgvRemitos.CurrentRow.Cells("Fecha").Value,
                .NroComprobante = dgvRemitos.CurrentRow.Cells("NroComprobante").Value,
                .Importe = UtilidadesVarias.SoloNumeros(dgvRemitos.CurrentRow.Cells("Importe").Value),
                .Observaciones = dgvRemitos.CurrentRow.Cells("Observaciones").Value,
                .Facturado = dgvRemitos.CurrentRow.Cells("Facturado").Value,
                .AscClientes = New Clientes With {
                    .IdCliente = dgvRemitos.CurrentRow.Cells("idClientes").Value,
                    .RazonSocial = dgvRemitos.CurrentRow.Cells("RazonSocial").Value
                },
                .AscUsuarios = New Usuario With {.IdUsuario = dgvRemitos.CurrentRow.Cells("idUsuarios").Value}
            }

            Me.DialogResult = DialogResult.OK

            Me.Close()
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtBuscCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscCli.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtBuscNroRem.SelectionLength = Len(txtBuscNroRem.Text)
            txtBuscNroRem.Select()
        End If
    End Sub

    Private Sub txtBuscNroRem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscNroRem.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtBuscFec.SelectionLength = Len(txtBuscFec.Text)
            txtBuscFec.Select()
        End If
    End Sub

    Private Sub txtBuscFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscFec.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(47) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtBuscCli.SelectionLength = Len(txtBuscCli.Text)
            txtBuscCli.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtBuscFec_Validated(sender As Object, e As EventArgs) Handles txtBuscFec.Validated
        If txtBuscFec.Text <> "" Then
            If Not IsDate(txtBuscFec.Text) Then
                Notificaciones.MsgBox("Formato de Fecha incorrecto.", Botones.OK, Iconos.ERR)
                txtBuscFec.Text = ""
            Else
                txtBuscFec.Text = Format(CDate(txtBuscFec.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub
#End Region

#Region "EVENTOS CHANGED"
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscFec.TextChanged, txtBuscNroRem.TextChanged, txtBuscCli.TextChanged
        Dim listFiltrada As New List(Of RemitoVenta)

        UtilidadesDGV.DescargarDGV(dgvRemitos)

        For Each item In listadoRemitos
            If UCase(item.NroComprobante).Contains(UCase(txtBuscNroRem.Text)) And UCase(item.Fecha).Contains(UCase(txtBuscFec.Text)) And UCase(item.AscClientes.RazonSocial).Contains(UCase(txtBuscCli.Text)) Then
                listFiltrada.Add(item)
            End If
        Next

        For Each Item In listFiltrada
            dgvRemitos.Rows.Add(Item.IdRemitosVenta, Item.AscClientes.IdCliente, Item.AscUsuarios.IdUsuario, Format(Item.Fecha, "dd/MM/yyyy"),
                                    Item.NroComprobante, Item.AscClientes.RazonSocial, Format(Item.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                                    Item.Facturado, Item.Observaciones)
        Next

        UtilidadesDGV.CabeceraDGV(dgvRemitos)
    End Sub
#End Region
End Class
