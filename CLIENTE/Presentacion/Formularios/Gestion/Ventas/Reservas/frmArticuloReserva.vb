Imports System.IO
Imports Procesos

Public Class frmArticuloReserva
    Dim _Articulos As New List(Of Articulos)
    Dim tareaArt As TareasArticulos
    Dim tareaStk As TareasStock


#Region "ANIMACION BOTONES"
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

#End Region

#Region "EVENTO LOAD"
    Private Sub FrmRemitosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoad.Enabled = True

        tareaArt = New TareasArticulos
        tareaStk = New TareasStock
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        _Articulos = Await tareaArt.ListadoCompleto()

        If IsNothing(_Articulos) Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)

            UtilidadesTXT.ResetVariables()
            Me.Close()
        End If

        If txtOrigen.Text = "Editar" Then
            txtCodArt.Text = frmReservasVta.dgvDetallePedido.CurrentRow.Cells("CodArt").Value
            txtCantidadReservar.Text = frmReservasVta.dgvDetallePedido.CurrentRow.Cells("Cantidad").Value

            txtCodArt.ReadOnly = True
            txtCodArt.ForeColor = Color.DimGray

            txtCantidadReservar.SelectionLength = txtCantidadReservar.Text.Length
            txtCantidadReservar.Select()
        Else
            txtCodArt.ReadOnly = False
            txtCodArt.ForeColor = Color.FromArgb(95, 150, 15)

            txtCodArt.SelectionLength = txtCodArt.Text.Length
            txtCodArt.Select()

            Notificaciones.cerrarFormProceso()
        End If
    End Sub

#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtCodArt_KeyPressAsync(sender As Object, e As KeyPressEventArgs) Handles txtCodArt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtCodArt.Text <> "" Then
                txtCantidadReservar.SelectionLength = Len(txtCantidadReservar.Text)
                txtCantidadReservar.Select()
            Else
                UtilidadesTXT.ResetVariables()

                frmListaArticulos.Dispose()
                UtilidadesVarias.Escalar(frmListaArticulos)
                Dim Result As DialogResult = frmListaArticulos.ShowDialog()

                If Result = DialogResult.OK Then
                    txtCodArt.Text = frmListaArticulos.infoArticulo.CodArticulo
                End If
            End If
        End If
    End Sub

    Private Sub txtCantidadReservar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadReservar.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            btnAgregar.Select()
        End If
    End Sub

#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        UtilidadesTXT.ResetVariables()

        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCodArt.Text = "" Or txtDetalleArt.Text = "" Then
            Notificaciones.MsgBox("No seleccionaste ningun Articulo.", Botones.OK, Iconos.INFORMACION)
            txtCodArt.Select()
        Else
            If txtCantidadReservar.Text = "" Then
                Notificaciones.MsgBox("No estableciste una Cantidad.", Botones.OK, Iconos.INFORMACION)
                txtCantidadReservar.Select()
            Else
                If frmReservasVta.dgvDetallePedido.CurrentRow IsNot Nothing And txtOrigen.Text = "Editar" Then
                    frmReservasVta.dgvDetallePedido.Rows.Remove(frmReservasVta.dgvDetallePedido.CurrentRow)
                End If

                Dim aggNuevo As Boolean = True

                For Each item As DataGridViewRow In frmReservasVta.dgvDetallePedido.Rows
                    If txtIdArticulo.Text = item.Cells("idArticulos").Value Then
                        item.SetValues(txtIdArticulo.Text, txtCodArt.Text, txtDetalleArt.Text, txtUnidad.Text, CDbl(txtCantidadReservar.Text) + CDbl(item.Cells("Cantidad").Value))

                        aggNuevo = False
                        Exit For
                    End If
                Next

                If aggNuevo Then
                    frmReservasVta.dgvDetallePedido.Rows.Add(txtIdArticulo.Text, txtCodArt.Text, txtDetalleArt.Text, txtUnidad.Text, txtCantidadReservar.Text)
                End If

                UtilidadesTXT.ResetVariables()

                Me.DialogResult = DialogResult.OK

                Me.Close()
            End If
        End If
    End Sub

#End Region

#Region "EVENTOS CHANGED"
    Private Async Sub txtCodArt_TextChangedAsync(sender As Object, e As EventArgs) Handles txtCodArt.TextChanged
        RemoveHandler txtCodArt.Validated, AddressOf txtCodArt_Validated

        UtilidadesTXT.ResetVariables()

        txtDetalleArt.Text = ""
        txtUnidad.Text = ""
        pbxImagen.Image = My.Resources.IconoArticulo
        txtCantidadReservar.Text = ""
        txtIdArticulo.Text = ""
        txtCostoAnt.Text = ""
        txtStkFisico.Text = ""
        txtStkReservado.Text = ""
        txtAlicIva.Text = ""

        If txtCodArt.Text <> "" Then
            Notificaciones.arbirFormProceso()

            For Each item In _Articulos
                If item.CodArticulo = txtCodArt.Text Then
                    Dim ImgArt As String = Await tareaArt.verImgArt(item.IdArticulo)

                    If IsNothing(ImgArt) Then
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)

                        UtilidadesTXT.ResetVariables()
                        Me.Close()
                    Else
                        Dim StkFisicoArt As Integer = Await tareaStk.verStockFisico(item.IdArticulo)

                        If IsNothing(StkFisicoArt) Then
                            Notificaciones.cerrarFormProceso()
                            Notificaciones.MsgBox(tareaStk.Err.Descripcion, Botones.OK, Iconos.ERR)

                            UtilidadesTXT.ResetVariables()
                            Me.Close()
                        Else
                            Dim stkReservadoArt As Integer = Await tareaStk.verStockReservado(item.IdArticulo)

                            If IsNothing(stkReservadoArt) Then
                                Notificaciones.cerrarFormProceso()
                                Notificaciones.MsgBox(tareaStk.Err.Descripcion, Botones.OK, Iconos.ERR)

                                UtilidadesTXT.ResetVariables()
                                Me.Close()
                            Else
                                txtStkReservado.Text = stkReservadoArt
                                txtStkFisico.Text = StkFisicoArt
                                pbxImagen.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(ImgArt)))
                                txtDetalleArt.Text = item.Detalle
                                txtUnidad.Text = item.Unidad
                                txtCostoAnt.Text = item.Costo
                                txtIdArticulo.Text = item.IdArticulo
                                txtAlicIva.Text = item.AlicuotaIVA
                            End If
                        End If
                    End If
                End If
            Next

            Notificaciones.cerrarFormProceso()
        End If

        AddHandler txtCodArt.Validated, AddressOf txtCodArt_Validated
    End Sub

#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtCodArt_Validated(sender As Object, e As EventArgs) Handles txtCodArt.Validated
        If txtCodArt.Text <> "" And txtDetalleArt.Text = "" Then
            Notificaciones.MsgBox("No existe un Articulo con ese codigo.", Botones.OK, Iconos.INFORMACION)

            txtCodArt.SelectionLength = Len(txtCodArt.Text)
            txtCodArt.Select()
        End If
    End Sub

#End Region

End Class