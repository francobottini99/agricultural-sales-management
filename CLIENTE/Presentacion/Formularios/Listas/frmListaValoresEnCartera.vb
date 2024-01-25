Imports Procesos

Public Class frmListaValoresEnCartera
    Private listaValoresEnCartera As New List(Of ValoresEnCartera)
    Private _TareasValoresEnCartera As TareasValoresEnCartera

    Public Property Valor As New ValoresEnCartera

#Region "EVENTO LOAD"
    Private Sub frmListaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Enabled = True

        _TareasValoresEnCartera = New TareasValoresEnCartera()
    End Sub

    Private Async Sub TmrDgvs_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        UtilidadesDGV.FormatoDGVGeneral(dgvValoresCartera)

        ConfigDgvValoresCartera()

        UtilidadesDGV.DescargarDGV(dgvValoresCartera)

        Notificaciones.arbirFormProceso("CARGADO VALORES EN CARTERA")

        If txtLista.Text = "Completa" Then
            lblTitulo.Text = "LISTA COMPLETA DE VALORES EN CARTERA CARGADOS"

            listaValoresEnCartera = Await _TareasValoresEnCartera.ListadoCompleto()
        ElseIf txtLista.Text = "Disponibles" Then
            lblTitulo.Text = "LISTA DE VALORES DE CARTERA DISPONIBLES"

            listaValoresEnCartera = Await _TareasValoresEnCartera.ListadoDisponible()
        End If

        If Not IsNothing(listaValoresEnCartera) Then
            If txtFormOrigen.Text = "OrdenPago" Then
                Dim auxHash As New Dictionary(Of Integer, ValoresEnCartera)

                For Each item In listaValoresEnCartera
                    auxHash.Add(item.IdValoresEnCartera, item)
                Next

                For Each item As DataGridViewRow In frmOrdenPago.dgvDetalleOrden.Rows
                    Dim remove As New ValoresEnCartera

                    If auxHash.TryGetValue(item.Cells("idValoresEnCartera").Value, remove) Then
                        listaValoresEnCartera.Remove(remove)
                    End If
                Next
            End If

            TareasValoresEnCartera.LlenarDGV(dgvValoresCartera, listaValoresEnCartera)

            UtilidadesDGV.CabeceraDGV(dgvValoresCartera)

            Notificaciones.cerrarFormProceso()

            txtNumero.Select()
        ElseIf _TareasValoresEnCartera.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasValoresEnCartera.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        Else
            Notificaciones.cerrarFormProceso()

            If txtLista.Text = "Disponibles" Then
                Notificaciones.MsgBox("No hay valores en cartera disponibles.", Botones.OK, Iconos.ALERTA)
            Else
                Notificaciones.MsgBox("No hay valores en cartera cargados en el sistema.", Botones.OK, Iconos.ALERTA)
            End If

            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDgvValoresCartera()
        dgvValoresCartera.ColumnCount = 12
        dgvValoresCartera.Columns(0).Name = "idValoresEnCartera"
        dgvValoresCartera.Columns(1).Name = "TipoValor"
        dgvValoresCartera.Columns(2).Name = "Banco"
        dgvValoresCartera.Columns(3).Name = "Sucursal"
        dgvValoresCartera.Columns(4).Name = "Numero"
        dgvValoresCartera.Columns(5).Name = "Librador"
        dgvValoresCartera.Columns(6).Name = "FechaCobro"
        dgvValoresCartera.Columns(7).Name = "Moneda"
        dgvValoresCartera.Columns(8).Name = "Importe"
        dgvValoresCartera.Columns(9).Name = "Disponible"
        dgvValoresCartera.Columns(10).Name = "Eliminado"
        dgvValoresCartera.Columns(11).Name = "Usuarios_idUsuarios"

        dgvValoresCartera.Columns("idValoresEnCartera").Visible = False
        dgvValoresCartera.Columns("Moneda").Visible = False
        dgvValoresCartera.Columns("Disponible").Visible = False
        dgvValoresCartera.Columns("Eliminado").Visible = False
        dgvValoresCartera.Columns("Usuarios_idUsuarios").Visible = False

        dgvValoresCartera.Columns("Banco").HeaderText = "BANCO"
        dgvValoresCartera.Columns("Sucursal").HeaderText = "SUCURSAL"
        dgvValoresCartera.Columns("TipoValor").HeaderText = "TIPO DE VALOR"
        dgvValoresCartera.Columns("Numero").HeaderText = "NUMERO"
        dgvValoresCartera.Columns("Librador").HeaderText = "LIBRADOR"
        dgvValoresCartera.Columns("FechaCobro").HeaderText = "FECHA DE COBRO"
        dgvValoresCartera.Columns("Importe").HeaderText = "IMPORTE"

        dgvValoresCartera.Columns("idValoresEnCartera").DisplayIndex = 0
        dgvValoresCartera.Columns("TipoValor").DisplayIndex = 1
        dgvValoresCartera.Columns("Banco").DisplayIndex = 2
        dgvValoresCartera.Columns("Sucursal").DisplayIndex = 3
        dgvValoresCartera.Columns("Numero").DisplayIndex = 4
        dgvValoresCartera.Columns("Librador").DisplayIndex = 5
        dgvValoresCartera.Columns("FechaCobro").DisplayIndex = 6
        dgvValoresCartera.Columns("Moneda").DisplayIndex = 7
        dgvValoresCartera.Columns("Importe").DisplayIndex = 8
        dgvValoresCartera.Columns("Disponible").DisplayIndex = 9
        dgvValoresCartera.Columns("Eliminado").DisplayIndex = 10
        dgvValoresCartera.Columns("Usuarios_idUsuarios").DisplayIndex = 11

        dgvValoresCartera.Columns("Banco").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("Sucursal").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("TipoValor").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("Numero").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("Librador").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("FechaCobro").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvValoresCartera.Columns("Importe").SortMode = DataGridViewColumnSortMode.NotSortable

        dgvValoresCartera.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvValoresCartera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvValoresCartera.ColumnHeadersVisible = False
    End Sub
#End Region

#Region "EVENTOS CLICK"
    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub dgvValoresCartera_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvValoresCartera.CellDoubleClick
        If e.RowIndex > -1 Then
            Valor.IdValoresEnCartera = dgvValoresCartera.CurrentRow.Cells("idValoresEnCartera").Value
            Valor.TipoValor = dgvValoresCartera.CurrentRow.Cells("TipoValor").Value
            Valor.Banco = dgvValoresCartera.CurrentRow.Cells("Banco").Value
            Valor.Sucursal = dgvValoresCartera.CurrentRow.Cells("Sucursal").Value
            Valor.Numero = dgvValoresCartera.CurrentRow.Cells("Numero").Value
            Valor.Librador = dgvValoresCartera.CurrentRow.Cells("Librador").Value
            Valor.FechaCobro = dgvValoresCartera.CurrentRow.Cells("FechaCobro").Value
            Valor.Moneda = dgvValoresCartera.CurrentRow.Cells("Moneda").Value
            Valor.Importe = dgvValoresCartera.CurrentRow.Cells("Importe").Value
            Valor.Disponible = dgvValoresCartera.CurrentRow.Cells("Disponible").Value
            Valor.Eliminado = dgvValoresCartera.CurrentRow.Cells("Eliminado").Value
            Valor.AscUsuarios.IdUsuario = dgvValoresCartera.CurrentRow.Cells("Usuarios_idUsuarios").Value

            Me.DialogResult = DialogResult.OK

            Me.Close()
        Else
            dgvValoresCartera.CurrentCell = Nothing
        End If
    End Sub
#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtLibrador.SelectionLength = Len(txtLibrador.Text)
            txtLibrador.Select()
        End If
    End Sub

    Private Sub txtLibrador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLibrador.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtNumero.SelectionLength = Len(txtNumero.Text)
            txtNumero.Select()
        End If
    End Sub
#End Region

#Region "EVENTOS CHANGED"
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged, txtLibrador.TextChanged
        Dim listFiltrada As New List(Of ValoresEnCartera)

        UtilidadesDGV.DescargarDGV(dgvValoresCartera)

        For Each Item In listaValoresEnCartera
            If UCase(Item.Numero).Contains(UCase(txtNumero.Text)) And UCase(Item.Librador).Contains(UCase(txtLibrador.Text)) Then
                listFiltrada.Add(Item)
            End If
        Next

        TareasValoresEnCartera.LlenarDGV(dgvValoresCartera, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvValoresCartera)
    End Sub
#End Region
End Class