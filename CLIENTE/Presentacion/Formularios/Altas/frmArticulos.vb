Imports System.IO
Imports Procesos

Public Class frmArticulos
    Public listRubros As List(Of Rubros)
    Public listSubRub As List(Of SubRubros)

    Private listArticulos As List(Of Articulos)
    Private tareasRub As TareasRubros
    Private tareasSubRub As TareasSubRubro
    Private tareaArt As TareasArticulos

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

    Private Sub btnCargarImagen_GotFocus(sender As Object, e As EventArgs) Handles btnCargarImagen.GotFocus
        If btnCargarImagen.Enabled = True Then
            btnCargarImagen.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCargarImagen_LostFocus(sender As Object, e As EventArgs) Handles btnCargarImagen.LostFocus
        If btnCargarImagen.Enabled = True Then
            btnCargarImagen.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCargarImagen_MouseEnter(sender As Object, e As EventArgs) Handles btnCargarImagen.MouseEnter
        If btnCargarImagen.Enabled = True Then
            btnCargarImagen.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCargarImagen_MouseLeave(sender As Object, e As EventArgs) Handles btnCargarImagen.MouseLeave
        If btnCargarImagen.Enabled = True Then
            btnCargarImagen.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnBorrarImagen_GotFocus(sender As Object, e As EventArgs) Handles btnBorrarImagen.GotFocus
        If btnBorrarImagen.Enabled = True Then
            btnBorrarImagen.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnBorrarImagen_LostFocus(sender As Object, e As EventArgs) Handles btnBorrarImagen.LostFocus
        If btnBorrarImagen.Enabled = True Then
            btnBorrarImagen.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnBorrarImagen_MouseEnter(sender As Object, e As EventArgs) Handles btnBorrarImagen.MouseEnter
        If btnBorrarImagen.Enabled = True Then
            btnBorrarImagen.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnBorrarImagen_MouseLeave(sender As Object, e As EventArgs) Handles btnBorrarImagen.MouseLeave
        If btnBorrarImagen.Enabled = True Then
            btnBorrarImagen.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCategorias_GotFocus(sender As Object, e As EventArgs) Handles btnCategorias.GotFocus
        If btnCategorias.Enabled = True Then
            btnCategorias.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCategorias_LostFocus(sender As Object, e As EventArgs) Handles btnCategorias.LostFocus
        If btnCategorias.Enabled = True Then
            btnCategorias.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub btnCategorias_MouseEnter(sender As Object, e As EventArgs) Handles btnCategorias.MouseEnter
        If btnCategorias.Enabled = True Then
            btnCategorias.BackColor = Color.FromArgb(190, 140, 5)
        End If
    End Sub

    Private Sub btnCategorias_MouseLeave(sender As Object, e As EventArgs) Handles btnCategorias.MouseLeave
        If btnCategorias.Enabled = True Then
            btnCategorias.BackColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub
#End Region

#Region "EVENTO LOAD"
    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TareasRub = New TareasRubros
        tareasSubRub = New TareasSubRubro
        tareaArt = New TareasArticulos

        lblTitulo.Text = "Presentacion -> " & Date.Now & " -> Ingreso a ALTAS DE ARTICULOS"

        tmrLoad.Enabled = True
    End Sub

    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        lblMonedaPPalCosto.Text = DatosSesion._MonedaPPal.Simbolo
        lblMonedaPPalPrecio.Text = DatosSesion._MonedaPPal.Simbolo

        lblMonedaContableCosto.Text = DatosSesion._MonedaContable.Simbolo
        lblMonedaContablePrecio.Text = DatosSesion._MonedaContable.Simbolo

        UtilidadesDGV.FormatoDGVGeneral(dgvArticulos)

        ConfigDGV_Articulos()

        UtilidadesDGV.DescargarDGV(dgvArticulos)

        Cancelar()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Async Sub Activar()
        Notificaciones.arbirFormProceso()

        listRubros = Await TareasRub.ListadoCompleto()

        If Not IsNothing(listRubros) Then
            cmbRubro.Items.Clear()

            For Each item In listRubros
                cmbRubro.Items.Add(item.Descripcion)
            Next

            listSubRub = Await TareasSubRub.ListadoCompleto()

            If Not IsNothing(listSubRub) Then
                cmbSubRubro.Items.Clear()

                For Each item In listSubRub
                    cmbSubRubro.Items.Add(item.Descripcion)
                Next

                txtTC.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
                lblBanco.Text = "--> BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha

                If cmbRubro.Items.Count > 0 Then
                    cmbRubro.Enabled = True
                    txtAbRubro.Enabled = True

                    If txtOrigen.Text = "Modificar" Then
                        cmbRubro.SelectedItem = dgvArticulos.CurrentRow.Cells("Rubro").Value

                        If dgvArticulos.CurrentRow.Cells("SubRubro").Value <> "-" Then
                            cmbSubRubro.SelectedItem = dgvArticulos.CurrentRow.Cells("SubRubro").Value

                            cmbSubRubro.Enabled = True
                            txtAbSubRubro.Enabled = True
                        Else
                            cmbSubRubro.Text = ""
                            txtAbSubRubro.Text = ""
                            cmbSubRubro.Enabled = False
                            txtAbSubRubro.Enabled = False
                        End If
                    Else
                        cmbSubRubro.Text = ""
                        txtAbSubRubro.Text = ""
                        cmbSubRubro.Enabled = False
                        txtAbSubRubro.Enabled = False
                    End If
                Else
                    cmbRubro.Text = ""
                    txtAbRubro.Text = ""
                    cmbRubro.Enabled = False
                    txtAbRubro.Enabled = False
                End If

                If txtOrigen.Text = "Modificar" Then
                    txtIdArticulo.Text = dgvArticulos.CurrentRow.Cells("idArticulos").Value
                    txtIdRubro.Text = dgvArticulos.CurrentRow.Cells("idRubro").Value
                    txtIdSubRubro.Text = dgvArticulos.CurrentRow.Cells("idSubRubro").Value

                    Dim imgArt As String = Await tareaArt.verImgArt(txtIdArticulo.Text)

                    If Not IsNothing(imgArt) Then
                        pbxImagen.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(imgArt)))
                    Else
                        Notificaciones.cerrarFormProceso()
                        Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)
                        Me.Close()
                    End If

                    Dim AuxCosto As Double = UtilidadesVarias.SoloNumeros(dgvArticulos.CurrentRow.Cells("Costo").Value)
                    Dim AuxPrecio As Double = UtilidadesVarias.SoloNumeros(dgvArticulos.CurrentRow.Cells("Precio").Value)
                    Dim AuxIVA As Double = UtilidadesVarias.SoloNumeros(dgvArticulos.CurrentRow.Cells("AlicuotaIVA").Value)

                    txtDetalle.Text = dgvArticulos.CurrentRow.Cells("Detalle").Value
                    txtUnidad.Text = dgvArticulos.CurrentRow.Cells("Unidad").Value
                    txtCostoPPal.Text = Format(AuxCosto, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00")
                    txtPrecioPPal.Text = Format(AuxPrecio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00")
                    txtStockMin.Text = dgvArticulos.CurrentRow.Cells("StockMinimo").Value
                    txtAlicIVA.Text = AuxIVA
                    txtObserv.Text = dgvArticulos.CurrentRow.Cells("Observaciones").Value
                End If
            Else
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(TareasSubRub.Err.Descripcion, Botones.OK, Iconos.ERR)
                Me.Close()
            End If
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(TareasRub.Err.Descripcion, Botones.OK, Iconos.ERR)
            Me.Close()
        End If

        pnlContendorDatos.Enabled = True
        bnfCardTc.Enabled = True
        bnfCardImg.Enabled = True
        bnfCardList.Enabled = False

        btnCargarImagen.Enabled = True
        btnCategorias.Enabled = True
        btnBorrarImagen.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False

        btnNuevo.BackColor = Color.FromArgb(35, 35, 35)
        btnModificar.BackColor = Color.FromArgb(35, 35, 35)
        btnBorrarImagen.BackColor = Color.FromArgb(100, 100, 100)
        btnCargarImagen.BackColor = Color.FromArgb(100, 100, 100)
        btnCategorias.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(100, 100, 100)
        btnCancelar.BackColor = Color.FromArgb(100, 100, 100)
        btnEliminar.BackColor = Color.FromArgb(35, 35, 35)

        txtBuscar.Text = ""

        UtilidadesDGV.DescargarDGV(dgvArticulos)

        Notificaciones.cerrarFormProceso()

        txtTC.SelectionLength = txtTC.TextLength
        txtTC.Select()
    End Sub

    Private Async Sub Cancelar()
        Notificaciones.arbirFormProceso()

        pnlContendorDatos.Enabled = False
        bnfCardTc.Enabled = False
        bnfCardImg.Enabled = False
        bnfCardList.Enabled = True

        UtilidadesTXT.VaciarTxt(Me)

        btnCargarImagen.Enabled = False
        btnCategorias.Enabled = False
        btnBorrarImagen.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = True

        btnNuevo.BackColor = Color.FromArgb(100, 100, 100)
        btnModificar.BackColor = Color.FromArgb(100, 100, 100)
        btnGuardar.BackColor = Color.FromArgb(35, 35, 35)
        btnBorrarImagen.BackColor = Color.FromArgb(35, 35, 35)
        btnCargarImagen.BackColor = Color.FromArgb(35, 35, 35)
        btnCategorias.BackColor = Color.FromArgb(35, 35, 35)
        btnCancelar.BackColor = Color.FromArgb(35, 35, 35)
        btnEliminar.BackColor = Color.FromArgb(100, 100, 100)

        If Not IsNothing(pbxImagen.Image) Then
            pbxImagen.Image.Dispose()
        End If

        pbxImagen.Image = My.Resources.IconoArticulo

        listArticulos = Await tareaArt.ListadoCompleto()

        If Not IsNothing(listArticulos) Then
            UtilidadesDGV.DescargarDGV(dgvArticulos)

            TareasArticulos.LlenarDGV(dgvArticulos, listArticulos)

            UtilidadesDGV.CabeceraDGV(dgvArticulos, DataGridViewAutoSizeColumnsMode.DisplayedCells)

            Notificaciones.cerrarFormProceso()

            btnNuevo.Select()
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If

        btnNuevo.Select()
    End Sub

    Private Sub ConfigDGV_Articulos()
        'CARGO LAS COLUMNAS DE LA TABLA
        dgvArticulos.ColumnCount = 17
        dgvArticulos.Columns(0).Name = "idArticulos"
        dgvArticulos.Columns(1).Name = "CodArt"
        dgvArticulos.Columns(2).Name = "Detalle"
        dgvArticulos.Columns(3).Name = "Unidad"
        dgvArticulos.Columns(4).Name = "Costo"
        dgvArticulos.Columns(5).Name = "FechaActualizacionCosto"
        dgvArticulos.Columns(6).Name = "Precio"
        dgvArticulos.Columns(7).Name = "FechaActualizacionPrecio"
        dgvArticulos.Columns(8).Name = "AlicuotaIVA"
        dgvArticulos.Columns(9).Name = "StockMinimo"
        dgvArticulos.Columns(10).Name = "Observaciones"
        dgvArticulos.Columns(11).Name = "idUsuarios"
        dgvArticulos.Columns(12).Name = "idRubro"
        dgvArticulos.Columns(13).Name = "idSubRubro"
        dgvArticulos.Columns(14).Name = "Usuario"
        dgvArticulos.Columns(15).Name = "Rubro"
        dgvArticulos.Columns(16).Name = "SubRubro"

        'OCULTO LAS QUE NO VOY A USAR
        dgvArticulos.Columns("idArticulos").Visible = False
        dgvArticulos.Columns("idUsuarios").Visible = False
        dgvArticulos.Columns("Usuario").Visible = False
        dgvArticulos.Columns("idRubro").Visible = False
        dgvArticulos.Columns("idSubRubro").Visible = False

        'MODO EN QUE SE DISTRIBUYEN LAS COLUMNAS DE LA TABLA
        'dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'DETALLO TEXTO DEL ENCABEZADO
        dgvArticulos.Columns("CodArt").HeaderText = "COD ART"
        dgvArticulos.Columns("Detalle").HeaderText = "DETALLE"
        dgvArticulos.Columns("Unidad").HeaderText = "UNIDAD"
        dgvArticulos.Columns("Costo").HeaderText = "COSTO"
        dgvArticulos.Columns("FechaActualizacionCosto").HeaderText = "ACT COSTO"
        dgvArticulos.Columns("Precio").HeaderText = "PRECIO"
        dgvArticulos.Columns("FechaActualizacionPrecio").HeaderText = "ACT PRECIO"
        dgvArticulos.Columns("AlicuotaIVA").HeaderText = "ALICUOTA IVA"
        dgvArticulos.Columns("StockMinimo").HeaderText = "STOCK MINIMO"
        dgvArticulos.Columns("Observaciones").HeaderText = "OBSERVACIONES"
        dgvArticulos.Columns("Usuario").HeaderText = "USUARIO"
        dgvArticulos.Columns("Rubro").HeaderText = "RUBRO"
        dgvArticulos.Columns("SubRubro").HeaderText = "SUB RUBRO"

        'DETERMINO EL ORDEN EN EL QUE APARECEN LAS COLUMNAS
        dgvArticulos.Columns("idArticulos").DisplayIndex = 0
        dgvArticulos.Columns("idUsuarios").DisplayIndex = 1
        dgvArticulos.Columns("idRubro").DisplayIndex = 2
        dgvArticulos.Columns("idSubRubro").DisplayIndex = 3
        dgvArticulos.Columns("CodArt").DisplayIndex = 4
        dgvArticulos.Columns("Detalle").DisplayIndex = 5
        dgvArticulos.Columns("Rubro").DisplayIndex = 6
        dgvArticulos.Columns("SubRubro").DisplayIndex = 7
        dgvArticulos.Columns("Unidad").DisplayIndex = 8
        dgvArticulos.Columns("Costo").DisplayIndex = 9
        dgvArticulos.Columns("FechaActualizacionCosto").DisplayIndex = 10
        dgvArticulos.Columns("Precio").DisplayIndex = 11
        dgvArticulos.Columns("FechaActualizacionPrecio").DisplayIndex = 12
        dgvArticulos.Columns("AlicuotaIVA").DisplayIndex = 13
        dgvArticulos.Columns("StockMinimo").DisplayIndex = 14
        dgvArticulos.Columns("Observaciones").DisplayIndex = 15
        dgvArticulos.Columns("Usuario").DisplayIndex = 16

        'DETERMINO EL ANCHO DE CADA COLUMNA
        dgvArticulos.Columns("CodArt").Width = 100
        dgvArticulos.Columns("Detalle").Width = 250
        dgvArticulos.Columns("Rubro").Width = 90
        dgvArticulos.Columns("SubRubro").Width = 90
        dgvArticulos.Columns("Unidad").Width = 70
        dgvArticulos.Columns("Costo").Width = 100
        dgvArticulos.Columns("FechaActualizacionCosto").Width = 90
        dgvArticulos.Columns("Precio").Width = 100
        dgvArticulos.Columns("FechaActualizacionPrecio").Width = 90
        dgvArticulos.Columns("AlicuotaIVA").Width = 80
        dgvArticulos.Columns("StockMinimo").Width = 80
        dgvArticulos.Columns("Observaciones").Width = 200

        'ALINEO EL TEXTO DE LAS COLUMNAS
        dgvArticulos.Columns("idArticulos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvArticulos.Columns("idUsuarios").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvArticulos.Columns("idRubro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvArticulos.Columns("idSubRubro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvArticulos.Columns("CodArt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvArticulos.Columns("Detalle").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvArticulos.Columns("Rubro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvArticulos.Columns("SubRubro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvArticulos.Columns("Unidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvArticulos.Columns("Costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvArticulos.Columns("FechaActualizacionCosto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvArticulos.Columns("Precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvArticulos.Columns("FechaActualizacionPrecio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvArticulos.Columns("AlicuotaIVA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvArticulos.Columns("StockMinimo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvArticulos.Columns("Observaciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvArticulos.Columns("Usuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub OfdImagen_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdImagen.FileOk
        Try
            Dim Foto As Image = Image.FromFile(ofdImagen.FileName)

            If Not IsNothing(pbxImagen.Image) Then
                pbxImagen.Image.Dispose()
            End If

            pbxImagen.Image = Foto
        Catch
            Notificaciones.MsgBox("El formato de la imagen no es compatible con el sistema.", Botones.OK, Iconos.ERR)
        End Try
    End Sub

#End Region

#Region "EVENTOS CLICK"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        frmPpal.AbrirFrm(frmInicio)
    End Sub

    Private Sub BtnBorrarImagen_Click(sender As Object, e As EventArgs) Handles btnBorrarImagen.Click
        pbxImagen.Image.Dispose()
        pbxImagen.Image = Presentacion.My.Resources.Resources.IconoArticulo
    End Sub

    Private Async Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdRubro.Text = "" Then
            Notificaciones.MsgBox("""RUBRO"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
            cmbRubro.SelectionLength = cmbRubro.Text.Length
            cmbRubro.Select()
        Else
            If cmbSubRubro.Enabled And txtIdSubRubro.Text = "" Then
                Notificaciones.MsgBox("""SUB RUBRO"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                cmbSubRubro.SelectionLength = cmbSubRubro.Text.Length
                cmbSubRubro.Select()
            Else
                If txtDetalle.Text = "" Then
                    Notificaciones.MsgBox("""DETALLE / DESCRIPCION"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                    txtDetalle.SelectionLength = txtDetalle.TextLength
                    txtDetalle.Select()
                Else
                    If txtUnidad.Text = "" Then
                        Notificaciones.MsgBox("""UNIDAD"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                        txtUnidad.SelectionLength = txtUnidad.TextLength
                        txtUnidad.Select()
                    Else
                        If txtCostoPPal.Text = "" Then
                            Notificaciones.MsgBox("""COSTOS"" son campos obligatorio.", Botones.OK, Iconos.ERR)
                            txtCostoPPal.SelectionLength = txtCostoPPal.TextLength
                            txtCostoPPal.Select()
                        Else
                            If txtPrecioPPal.Text = "" Then
                                Notificaciones.MsgBox("""PRECIOS"" son campos obligatorio.", Botones.OK, Iconos.ERR)
                                txtPrecioPPal.SelectionLength = txtPrecioPPal.TextLength
                                txtPrecioPPal.Select()
                            Else
                                If txtAlicIVA.Text = "" Then
                                    Notificaciones.MsgBox("""ALICUOTA IVA"" es un campo obligatorio.", Botones.OK, Iconos.ERR)
                                    txtAlicIVA.SelectionLength = txtAlicIVA.TextLength
                                    txtAlicIVA.Select()
                                Else

                                    Dim ImgMs As New MemoryStream

                                    If txtObserv.Text = "" Then
                                        txtObserv.Text = "-"
                                    End If

                                    If txtStockMin.Text = "" Then
                                        txtStockMin.Text = "0"
                                    End If

                                    If Not cmbSubRubro.Enabled Then
                                        For Each item In listSubRub
                                            If listRubros.Item(cmbRubro.SelectedIndex).IdRubro = item.AscRubro.IdRubro And item.Descripcion = listRubros.Item(cmbRubro.SelectedIndex).Descripcion And item.Abrebiatura = listRubros.Item(cmbRubro.SelectedIndex).Abrebiatura Then
                                                txtIdSubRubro.Text = item.IdSubRubro
                                                txtAbSubRubro.Text = item.Abrebiatura
                                            End If
                                        Next

                                        If txtIdRubro.Text = "" Then
                                            txtIdSubRubro.Text = 0
                                            txtAbSubRubro.Text = ""
                                        End If
                                    End If

                                    pbxImagen.Image.Save(ImgMs, pbxImagen.Image.RawFormat)

                                    Dim _Art As Articulos = New Articulos(txtDetalle.Text, txtUnidad.Text, UtilidadesVarias.SoloNumeros(txtCostoPPal.Text),
                                                                          UtilidadesVarias.SoloNumeros(txtPrecioPPal.Text), UtilidadesVarias.SoloNumeros(txtAlicIVA.Text),
                                                                          UtilidadesVarias.SoloNumeros(txtStockMin.Text), txtObserv.Text, Convert.ToBase64String(ImgMs.ToArray()),
                                                                          txtIdRubro.Text, txtIdSubRubro.Text, cmbRubro.Text, txtAbRubro.Text, txtAbSubRubro.Text)

                                    If txtOrigen.Text = "Nuevo" Then
                                        Dim resp As DialogResult = Notificaciones.MsgBox("Guardar Articulo ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                        If resp = DialogResult.OK Then
                                            Notificaciones.arbirFormProceso("GUARDANDO ARTICULO")

                                            If Await tareaArt.Servicio_Insertar(_Art) Then
                                                Notificaciones.cerrarFormProceso()
                                                Notificaciones.MsgBox("Articulo guardado con exito !", Botones.OK, Iconos.OK)

                                                Cancelar()
                                            Else
                                                Notificaciones.cerrarFormProceso()
                                                Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)
                                            End If
                                        End If
                                    ElseIf txtOrigen.Text = "Modificar" Then
                                        Dim resp As DialogResult = Notificaciones.MsgBox("Modificar Articulo ?", Botones.OK_CANCEL, Iconos.INFORMACION)

                                        If resp = DialogResult.OK Then
                                            Notificaciones.arbirFormProceso("MODIFICANDO ARTICULO")

                                            _Art.IdArticulo = CInt(txtIdArticulo.Text)

                                            If Await tareaArt.Servicio_Modificar(_Art) Then
                                                Notificaciones.cerrarFormProceso()
                                                Notificaciones.MsgBox("Articulo modificado con exito !", Botones.OK, Iconos.OK)

                                                Cancelar()
                                            Else
                                                Notificaciones.cerrarFormProceso()
                                                Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        frmcategorias.ShowDialog(Me)

        txtDetalle.SelectionLength = txtDetalle.Text.Length
        txtDetalle.Select()
    End Sub

    Private Sub dgvArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellClick
        If e.RowIndex > -1 Then
            txtIdArticulo.Text = dgvArticulos.CurrentRow.Cells("idArticulos").Value

            btnModificar.Select()
        End If
    End Sub

    Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdArticulo.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un articulo.", Botones.OK, Iconos.ALERTA)
        Else
            Dim resp As DialogResult = Notificaciones.MsgBox("El stock asociado al articulo se perdera. Seguro que quieres eliminar el articulo ?", Botones.OK_CANCEL, Iconos.INFORMACION)

            If resp = DialogResult.OK Then
                Notificaciones.arbirFormProceso("ELIMINANDO ARTICULO")

                If Await tareaArt.Eliminar(txtIdArticulo.Text) Then
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox("Articulo eliminado con exito !", Botones.OK, Iconos.OK)

                    Cancelar()
                Else
                    Notificaciones.cerrarFormProceso()
                    Notificaciones.MsgBox(tareaArt.Err.Descripcion, Botones.OK, Iconos.ERR)
                End If
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdArticulo.Text = "" Then
            Notificaciones.MsgBox("No has seleccionado un articulo.", Botones.OK, Iconos.ALERTA)
        Else
            txtOrigen.Text = "Modificar"
            Activar()
        End If
    End Sub

    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        ofdImagen.Filter = "Imagenes|*.BMP;*.JPG;*.GIF;*.PNG"
        ofdImagen.ShowDialog()
    End Sub

#End Region

#Region "EVENTOS KEY PRESS"
    Private Sub txtTC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTC.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDetalle.SelectionLength = txtDetalle.Text.Length
            txtDetalle.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtTC.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbRubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If cmbSubRubro.Enabled = True Then
                txtAbSubRubro.SelectionLength = txtAbSubRubro.TextLength
                txtAbSubRubro.Select()
            Else
                txtUnidad.SelectionLength = txtUnidad.TextLength
                txtUnidad.Select()
            End If
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            txtAbRubro.Text = ""
            cmbSubRubro.Text = ""
            txtAbSubRubro.Text = ""
            cmbSubRubro.Enabled = False
            txtAbSubRubro.Enabled = False
        End If
    End Sub

    Private Sub txtAbRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbRubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cmbRubro.SelectionLength = cmbRubro.Text.Length
            cmbRubro.Select()
        End If
    End Sub

    Private Sub cmbSubRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSubRubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDetalle.SelectionLength = txtDetalle.TextLength
            txtDetalle.Select()
        ElseIf Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        Else
            txtAbSubRubro.Text = ""
        End If
    End Sub

    Private Sub txtAbSubRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbSubRubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cmbSubRubro.SelectionLength = cmbSubRubro.Text.Length
            cmbSubRubro.Select()
        End If
    End Sub

    Private Sub txtDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetalle.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtAbRubro.SelectionLength = txtAbRubro.TextLength
            txtAbRubro.Select()
        End If
    End Sub

    Private Sub txtUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostoPPal.SelectionLength = txtCostoPPal.TextLength
            txtCostoPPal.Select()
        End If
    End Sub

    Private Sub txtCostoPPal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoPPal.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostoContable.SelectionLength = txtCostoContable.TextLength
            txtCostoContable.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtCostoPPal.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCostoContable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoContable.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPrecioPPal.SelectionLength = txtPrecioPPal.TextLength
            txtPrecioPPal.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtCostoContable.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioPPal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioPPal.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPrecioContable.SelectionLength = txtPrecioContable.TextLength
            txtPrecioContable.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtPrecioPPal.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioContable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioContable.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtStockMin.SelectionLength = txtStockMin.TextLength
            txtStockMin.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtPrecioContable.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStockMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockMin.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtAlicIVA.SelectionLength = txtAlicIVA.TextLength
            txtAlicIVA.Select()
        End If
    End Sub

    Private Sub txtAlicIVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlicIVA.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObserv.SelectionLength = txtObserv.TextLength
            txtObserv.Select()
        ElseIf e.KeyChar = ChrW(46) And Not txtAlicIVA.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtObserv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObserv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

#End Region

#Region "EVENTOS CHANGED"
    Private Sub txtAbSubRubro_EnabledChanged(sender As Object, e As EventArgs) Handles txtAbSubRubro.EnabledChanged
        If txtAbSubRubro.Enabled = True Then
            txtAbSubRubro.BackColor = Color.FromArgb(30, 30, 30)
        Else
            txtAbSubRubro.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub txtAbRubro_EnabledChanged(sender As Object, e As EventArgs) Handles txtAbRubro.EnabledChanged
        If txtAbRubro.Enabled = True Then
            txtAbRubro.BackColor = Color.FromArgb(30, 30, 30)
        Else
            txtAbRubro.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub CmbRubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRubro.SelectedIndexChanged
        If cmbRubro.Text <> "" Then
            txtAbRubro.Text = listRubros.Item(cmbRubro.SelectedIndex).Abrebiatura
            txtIdRubro.Text = listRubros.Item(cmbRubro.SelectedIndex).IdRubro

            cmbSubRubro.Items.Clear()
            For Each item In listSubRub
                If listRubros.Item(cmbRubro.SelectedIndex).IdRubro = item.AscRubro.IdRubro And item.Descripcion <> listRubros.Item(cmbRubro.SelectedIndex).Descripcion And item.Abrebiatura <> listRubros.Item(cmbRubro.SelectedIndex).Abrebiatura Then
                    cmbSubRubro.Items.Add(item.Descripcion)
                End If
            Next

            If cmbSubRubro.Items.Count > 0 Then
                cmbSubRubro.Enabled = True
                txtAbSubRubro.Enabled = True
            Else
                cmbSubRubro.Text = ""
                txtAbSubRubro.Text = ""
                txtIdSubRubro.Text = ""
                cmbSubRubro.Enabled = False
                txtAbSubRubro.Enabled = False
            End If
        Else
            cmbSubRubro.Items.Clear()
            cmbSubRubro.Text = ""
            txtAbSubRubro.Text = ""
            txtIdSubRubro.Text = ""
            cmbSubRubro.Enabled = False
            txtAbSubRubro.Enabled = False
        End If
    End Sub

    Private Sub txtAbRubro_TextChanged(sender As Object, e As EventArgs) Handles txtAbRubro.TextChanged
        If txtAbRubro.Text <> "" Then
            For Each item In listRubros
                If item.Abrebiatura = txtAbRubro.Text Then
                    cmbRubro.SelectedItem = item.Descripcion
                    Exit For
                Else
                    cmbRubro.SelectedItem = Nothing
                End If
            Next
        Else
            cmbRubro.SelectedItem = Nothing
        End If
    End Sub

    Private Sub cmbSubRubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubRubro.SelectedIndexChanged
        txtIdSubRubro.Text = ""

        If cmbSubRubro.Text <> "" Then
            For Each item In listSubRub
                If item.Descripcion = cmbSubRubro.Text Then
                    txtAbSubRubro.Text = item.Abrebiatura
                    txtIdSubRubro.Text = item.IdSubRubro
                End If
            Next
        End If
    End Sub

    Private Sub txtAbSubRubro_TextChanged(sender As Object, e As EventArgs) Handles txtAbSubRubro.TextChanged
        If txtAbSubRubro.Text <> "" Then
            For Each item In listSubRub
                If item.Abrebiatura = txtAbSubRubro.Text Then
                    cmbSubRubro.SelectedItem = item.Descripcion
                    Exit For
                Else
                    cmbSubRubro.SelectedItem = Nothing
                End If
            Next
        Else
            cmbSubRubro.SelectedItem = Nothing
        End If
    End Sub

    Private Sub TxtCostoPPal_TextChanged(sender As Object, e As EventArgs) Handles txtCostoPPal.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtCostoPPal, txtCostoContable, AddressOf TxtCostoPPal_TextChanged, AddressOf TxtCostoContable_TextChanged, UtilidadesVarias.SoloNumeros(txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)
    End Sub

    Private Sub TxtCostoContable_TextChanged(sender As Object, e As EventArgs) Handles txtCostoContable.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtCostoContable, txtCostoPPal, AddressOf TxtCostoContable_TextChanged, AddressOf TxtCostoPPal_TextChanged, UtilidadesVarias.SoloNumeros(txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_CONTABLE, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)
    End Sub

    Private Sub txtPrecioPPal_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioPPal.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtPrecioPPal, txtPrecioContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)
    End Sub

    Private Sub txtPrecioContable_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioContable.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtPrecioContable, txtPrecioPPal, AddressOf txtPrecioContable_TextChanged, AddressOf txtPrecioPPal_TextChanged, UtilidadesVarias.SoloNumeros(txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_CONTABLE, UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL)
    End Sub

    Private Sub txtTC_TextChanged(sender As Object, e As EventArgs) Handles txtTC.TextChanged
        UtilidadesTXT.FormatoMonedaTXT(txtTC, AddressOf txtTC_TextChanged, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

        If txtTC.Text <> "" Then
            UtilidadesTXT.FormatoMonedaTXT(txtPrecioPPal, txtPrecioContable, AddressOf txtPrecioPPal_TextChanged, AddressOf txtPrecioContable_TextChanged, UtilidadesVarias.SoloNumeros(txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)
            UtilidadesTXT.FormatoMonedaTXT(txtCostoPPal, txtCostoContable, AddressOf TxtCostoPPal_TextChanged, AddressOf TxtCostoContable_TextChanged, UtilidadesVarias.SoloNumeros(txtTC.Text), UtilidadesTXT.txtTipos.MONEDA_PRINCIPAL, UtilidadesTXT.txtTipos.MONEDA_CONTABLE)

            If UtilidadesVarias.SoloNumeros(txtTC.Text) = DatosSesion._UltimaParidadCambiaria.CotizacionVenta Then
                lblBanco.Text = "--> BANCO NACION " & DatosSesion._UltimaParidadCambiaria.Fecha
                txtTC.SelectionLength = txtTC.TextLength
            Else
                lblBanco.Text = ""
            End If
        Else
            If pnlContendorDatos.Enabled = True Then
                txtTC.Text = Format(DatosSesion._UltimaParidadCambiaria.CotizacionVenta, "$ ##,#0.00")
            Else
                lblBanco.Text = ""
            End If
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim listFiltrada As List(Of Articulos)

        UtilidadesDGV.DescargarDGV(dgvArticulos)

        If txtBuscar.Text <> "" Then
            listFiltrada = UtilidadesListas.FiltarLista(Of Articulos)(listArticulos, "Detalle", txtBuscar.Text)
        Else
            listFiltrada = listArticulos
        End If

        TareasArticulos.LlenarDGV(dgvArticulos, listFiltrada)

        UtilidadesDGV.CabeceraDGV(dgvArticulos, DataGridViewAutoSizeColumnsMode.DisplayedCells)
    End Sub

#End Region

#Region "EVENTOS VALIDATED"
    Private Sub txtCostoPPal_Validated(sender As Object, e As EventArgs) Handles txtCostoPPal.Validated
        If txtCostoPPal.Text <> "" Then
            txtCostoPPal.Text = Format(UtilidadesVarias.SoloNumeros(txtCostoPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            txtCostoContable.Text = Format(UtilidadesVarias.SoloNumeros(txtCostoContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
        AddHandler txtCostoContable.TextChanged, AddressOf TxtCostoContable_TextChanged
    End Sub

    Private Sub txtCostoContable_Validated(sender As Object, e As EventArgs) Handles txtCostoContable.Validated
        If txtCostoContable.Text <> "" Then
            txtCostoPPal.Text = Format(UtilidadesVarias.SoloNumeros(txtCostoPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            txtCostoContable.Text = Format(UtilidadesVarias.SoloNumeros(txtCostoContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
        AddHandler txtCostoPPal.TextChanged, AddressOf TxtCostoPPal_TextChanged
    End Sub

    Private Sub txtPrecioD_Validated(sender As Object, e As EventArgs) Handles txtPrecioPPal.Validated
        If txtPrecioPPal.Text <> "" Then
            txtPrecioPPal.Text = Format(UtilidadesVarias.SoloNumeros(txtPrecioPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            txtPrecioContable.Text = Format(UtilidadesVarias.SoloNumeros(txtPrecioContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
        AddHandler txtPrecioContable.TextChanged, AddressOf txtPrecioContable_TextChanged
    End Sub

    Private Sub txtPrecioContable_Validated(sender As Object, e As EventArgs) Handles txtPrecioContable.Validated
        If txtPrecioContable.Text <> "" Then
            txtPrecioPPal.Text = Format(UtilidadesVarias.SoloNumeros(txtPrecioPPal.Text), DatosSesion._MonedaPPal.Simbolo & " #,##0.00")
            txtPrecioContable.Text = Format(UtilidadesVarias.SoloNumeros(txtPrecioContable.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
        AddHandler txtPrecioPPal.TextChanged, AddressOf txtPrecioPPal_TextChanged
    End Sub

    Private Sub txtTC_Validated(sender As Object, e As EventArgs) Handles txtTC.Validated
        If txtTC.Text <> "" Then
            txtTC.Text = Format(UtilidadesVarias.SoloNumeros(txtTC.Text), DatosSesion._MonedaContable.Simbolo & " #,##0.00")
        End If
    End Sub

    Private Sub txtAbRubro_Validated(sender As Object, e As EventArgs) Handles txtAbRubro.Validated
        If txtAbRubro.Text <> "" Then
            If cmbRubro.SelectedItem = Nothing Then
                Notificaciones.MsgBox("La abreviatura ingresada no corresponde a ningun Rubro.", Botones.OK, Iconos.ERR)
                cmbRubro.SelectedItem = Nothing
                txtAbRubro.Text = ""
                txtAbRubro.Select()
            End If
        Else
            cmbRubro.SelectedItem = Nothing
        End If
    End Sub

    Private Sub txtAbSubRubro_Validated(sender As Object, e As EventArgs) Handles txtAbSubRubro.Validated
        If txtAbSubRubro.Text <> "" Then
            If cmbSubRubro.Text = "" Then
                Notificaciones.MsgBox("La abreviatura ingresada no corresponde a ningun Sub Rubro.", Botones.OK, Iconos.ERR)
                cmbSubRubro.SelectedItem = Nothing
                txtAbSubRubro.Text = ""
                txtAbSubRubro.Select()
            End If
        Else
            cmbSubRubro.SelectedItem = Nothing
        End If
    End Sub
#End Region

End Class