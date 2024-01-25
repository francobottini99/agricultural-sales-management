Imports Procesos

Public Class frmDevolucionesrRetiradoCliente
    Private _TareasDetalleRemito As TareasDetalleRemitoVenta
    Private _TareasRemitoVentaMonedas As TareasRemitoVentaMoneda
    Private _TareasFacturaVentaDetalle As TareasFacturaVentaDetalle
    Private _TareasFacturaVentaMonedas As TareasFacturaVentaMonedas

    Private ListadoDetalleRemito As List(Of DetalleRemitoVenta)
    Private ListadoRemitoVentaMonedas As List(Of RemitoVentaMonedas)
    Private ListadoFacturaVentaDetalle As List(Of FacturaVentaDetalle)
    Private ListadoFacturaVentaMonedas As List(Of FacturaVentaMonedas)

    Public Property infoDetalleRemito As DetalleRemitoVenta
    Public Property infoDetalleFactura As FacturaVentaDetalle

#Region "LOAD"
    Private Sub frmListaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _TareasDetalleRemito = New TareasDetalleRemitoVenta()
        _TareasRemitoVentaMonedas = New TareasRemitoVentaMoneda()
        _TareasFacturaVentaDetalle = New TareasFacturaVentaDetalle()
        _TareasFacturaVentaMonedas = New TareasFacturaVentaMonedas()

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrDgvs_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Notificaciones.arbirFormProceso()

        UtilidadesDGV.FormatoDGVGeneral(dgvDetalle)
        UtilidadesDGV.FormatoDGVGeneral(dgvRemitos)
        UtilidadesDGV.FormatoDGVGeneral(dgvFacturas)

        ConfigDGV_REMITOS()
        ConfigDGV_DETALLE()
        ConfigDGV_FACTURAS()

        UtilidadesDGV.DescargarDGV(dgvDetalle)
        UtilidadesDGV.DescargarDGV(dgvRemitos)
        UtilidadesDGV.DescargarDGV(dgvFacturas)

        ListadoDetalleRemito = Await _TareasDetalleRemito.verDetalleRemitosVentaSinFacturarIdCliente(frmDevoluciones.txtCtaCli.Text)
        ListadoFacturaVentaDetalle = Await _TareasFacturaVentaDetalle.verFacturasVentaDetalleRemitadoIdCliente(frmDevoluciones.txtCtaCli.Text)

        If Not IsNothing(ListadoDetalleRemito) Then
            ListadoRemitoVentaMonedas = Await _TareasRemitoVentaMonedas.ListadoCompleto()

            If Not IsNothing(ListadoRemitoVentaMonedas) Then
                For Each Item In ListadoDetalleRemito
                    Dim Count As Double = CountCantidadRemito(Item.IdDetalleRemitosVenta)
                    Dim agg As Boolean = True

                    If Count < Item.Cantidad Then
                        For Each row In dgvRemitos.Rows
                            If Item.AscRemitosVenta.IdRemitosVenta = row.Cells("idRemitosVenta").Value Then
                                agg = False
                            End If
                        Next
                    Else
                        agg = False
                    End If

                    If agg Then
                        Dim tc As Double = 0
                        For Each item2 In ListadoRemitoVentaMonedas
                            If item2.AscRemitosventa.IdRemitosVenta = Item.AscRemitosVenta.IdRemitosVenta Then
                                tc = item2.TipoCambio
                                Exit For
                            End If
                        Next

                        dgvRemitos.Rows.Add(Item.AscRemitosVenta.IdRemitosVenta, Item.AscRemitosVenta.AscUsuarios.IdUsuario,
                                            Format(Item.AscRemitosVenta.Fecha, "dd/MM/yyyy"), Item.AscRemitosVenta.NroComprobante,
                                            Format(tc, DatosSesion._MonedaContable.Simbolo & " #,##0.00"), Item.AscRemitosVenta.Observaciones)
                    End If
                Next

                UtilidadesDGV.CabeceraDGV(dgvRemitos)
            ElseIf _TareasRemitoVentaMonedas.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(_TareasRemitoVentaMonedas.Err.Descripcion, Botones.OK, Iconos.ERR)

                Me.Close()
            End If
        ElseIf _TareasDetalleRemito.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasDetalleRemito.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If

        If Not IsNothing(ListadoFacturaVentaDetalle) Then
            ListadoFacturaVentaMonedas = Await _TareasFacturaVentaMonedas.ListadoCompleto()

            If Not IsNothing(ListadoRemitoVentaMonedas) Then
                For Each Item In ListadoFacturaVentaDetalle
                    Dim Count As Double = CountCantidadFactura(Item.IdFacturaVentaDetalle)
                    Dim agg As Boolean = True

                    If Item.Cantidad - Count > 0 Then
                        For Each row In dgvFacturas.Rows
                            If Item.AscFacturaVenta.IdFacturaVenta = row.Cells("idFacturaVenta").Value Then
                                agg = False
                            End If
                        Next
                    Else
                        agg = False
                    End If

                    If agg Then
                        Dim tc As Double = 0
                        For Each item2 In ListadoFacturaVentaMonedas
                            If item2.AscFacturaVenta.IdFacturaVenta = Item.AscFacturaVenta.IdFacturaVenta Then
                                tc = item2.TipoCambio
                                Exit For
                            End If
                        Next

                        dgvFacturas.Rows.Add(Item.AscFacturaVenta.IdFacturaVenta, Item.AscFacturaVenta.AscUsuarios.IdUsuario,
                                             Format(Item.AscFacturaVenta.Fecha, "dd/MM/yyyy"), Item.AscFacturaVenta.ClaseComprobante,
                                             Item.AscFacturaVenta.Prefijo, Item.AscFacturaVenta.NroComprobante,
                                             Format(tc, DatosSesion._MonedaContable.Simbolo & " #,##0.00"), Item.AscFacturaVenta.Observaciones)
                    End If
                Next

                UtilidadesDGV.CabeceraDGV(dgvFacturas)
            ElseIf _TareasFacturaVentaMonedas.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(_TareasFacturaVentaMonedas.Err.Descripcion, Botones.OK, Iconos.ERR)

                Me.Close()
            End If
        ElseIf _TareasFacturaVentaDetalle.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasFacturaVentaDetalle.Err.Descripcion, Botones.OK, Iconos.ERR)

            Me.Close()
        End If

        If _TareasDetalleRemito.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO And _TareasFacturaVentaDetalle.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox("El Cliente " + frmDevoluciones.txtRScli.Text + " no cuenta con Remitos ni Facturas emitidos.", Botones.OK, Iconos.ALERTA)

            Me.Close()
        Else
            Notificaciones.cerrarFormProceso()
        End If
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub ConfigDGV_DETALLE()
        dgvDetalle.ColumnCount = 6
        dgvDetalle.Columns(0).Name = "id"
        dgvDetalle.Columns(1).Name = "idArticulos"
        dgvDetalle.Columns(2).Name = "CodArticulo"
        dgvDetalle.Columns(3).Name = "Articulo"
        dgvDetalle.Columns(4).Name = "Cantidad"
        dgvDetalle.Columns(5).Name = "Precio"

        dgvDetalle.Columns("id").Visible = False
        dgvDetalle.Columns("idArticulos").Visible = False
        dgvDetalle.Columns("Precio").Visible = False

        dgvDetalle.Columns("CodArticulo").HeaderText = "CODIGO"
        dgvDetalle.Columns("Articulo").HeaderText = "ARTICULO"
        dgvDetalle.Columns("Cantidad").HeaderText = "CANTIDAD"

        dgvDetalle.Columns("id").DisplayIndex = 0
        dgvDetalle.Columns("idArticulos").DisplayIndex = 1
        dgvDetalle.Columns("CodArticulo").DisplayIndex = 2
        dgvDetalle.Columns("Articulo").DisplayIndex = 3
        dgvDetalle.Columns("Cantidad").DisplayIndex = 4
        dgvDetalle.Columns("Precio").DisplayIndex = 5

        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvDetalle.Columns("Cantidad").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvDetalle.Columns("CodArticulo").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        UtilidadesDGV.DisableResizeColumns(dgvDetalle)
        UtilidadesDGV.DisableSortColumns(dgvDetalle)
    End Sub

    Private Sub ConfigDGV_REMITOS()
        dgvRemitos.ColumnCount = 6
        dgvRemitos.Columns(0).Name = "idRemitosVenta"
        dgvRemitos.Columns(1).Name = "idUsuarios"
        dgvRemitos.Columns(2).Name = "Fecha"
        dgvRemitos.Columns(3).Name = "NroComprobante"
        dgvRemitos.Columns(4).Name = "TipoCambio"
        dgvRemitos.Columns(5).Name = "Observaciones"

        dgvRemitos.Columns("idRemitosVenta").Visible = False
        dgvRemitos.Columns("idUsuarios").Visible = False

        dgvRemitos.Columns("Fecha").HeaderText = "FECHA"
        dgvRemitos.Columns("NroComprobante").HeaderText = "NRO REMITO"
        dgvRemitos.Columns("TipoCambio").HeaderText = "T.C."
        dgvRemitos.Columns("Observaciones").HeaderText = "OBS."

        dgvRemitos.Columns("idRemitosVenta").DisplayIndex = 0
        dgvRemitos.Columns("idUsuarios").DisplayIndex = 1
        dgvRemitos.Columns("Fecha").DisplayIndex = 2
        dgvRemitos.Columns("NroComprobante").DisplayIndex = 3
        dgvRemitos.Columns("TipoCambio").DisplayIndex = 4
        dgvRemitos.Columns("Observaciones").DisplayIndex = 5

        dgvRemitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvRemitos.Columns("Fecha").Width = 100
        dgvRemitos.Columns("TipoCambio").Width = 125

        dgvRemitos.Sort(dgvRemitos.Columns("Fecha"), ComponentModel.ListSortDirection.Ascending)

        UtilidadesDGV.DisableResizeColumns(dgvRemitos)
        UtilidadesDGV.DisableSortColumns(dgvRemitos)
    End Sub

    Private Sub ConfigDGV_FACTURAS()
        dgvFacturas.ColumnCount = 8
        dgvFacturas.Columns(0).Name = "idFacturaVenta"
        dgvFacturas.Columns(1).Name = "idUsuarios"
        dgvFacturas.Columns(2).Name = "Fecha"
        dgvFacturas.Columns(3).Name = "ClaseComprobante"
        dgvFacturas.Columns(4).Name = "Prefijo"
        dgvFacturas.Columns(5).Name = "NroComprobante"
        dgvFacturas.Columns(6).Name = "TipoCambio"
        dgvFacturas.Columns(7).Name = "Observaciones"

        dgvFacturas.Columns("idFacturaVenta").Visible = False
        dgvFacturas.Columns("idUsuarios").Visible = False

        dgvFacturas.Columns("Fecha").HeaderText = "FECHA"
        dgvFacturas.Columns("NroComprobante").HeaderText = "NRO COMPROBANTE"
        dgvFacturas.Columns("Observaciones").HeaderText = "OBS."
        dgvFacturas.Columns("ClaseComprobante").HeaderText = "TIPO"
        dgvFacturas.Columns("Prefijo").HeaderText = "PREFIJO"
        dgvFacturas.Columns("TipoCambio").HeaderText = "T.C."

        dgvFacturas.Columns("idFacturaVenta").DisplayIndex = 0
        dgvFacturas.Columns("idUsuarios").DisplayIndex = 1
        dgvFacturas.Columns("Fecha").DisplayIndex = 2
        dgvFacturas.Columns("ClaseComprobante").DisplayIndex = 3
        dgvFacturas.Columns("Prefijo").DisplayIndex = 4
        dgvFacturas.Columns("NroComprobante").DisplayIndex = 5
        dgvFacturas.Columns("TipoCambio").DisplayIndex = 6
        dgvFacturas.Columns("Observaciones").DisplayIndex = 7

        dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvFacturas.Columns("Fecha").Width = 100
        dgvFacturas.Columns("ClaseComprobante").Width = 40

        dgvFacturas.Sort(dgvFacturas.Columns("Fecha"), ComponentModel.ListSortDirection.Ascending)

        UtilidadesDGV.DisableResizeColumns(dgvFacturas)
        UtilidadesDGV.DisableSortColumns(dgvFacturas)
    End Sub

    Private Function CountCantidadRemito(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmDevoluciones.dgvDetalle.Rows
            If id = item.Cells("idRemitoDetalle").Value Then
                Count += UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
            End If
        Next

        Return Count
    End Function

    Private Function CountCantidadFactura(ByVal id As Integer)
        Dim Count As Double = 0

        For Each item As DataGridViewRow In frmDevoluciones.dgvDetalle.Rows
            If id = item.Cells("idFacturaDetalle").Value Then
                Count += UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
            End If
        Next

        Return Count
    End Function
#End Region

#Region "EVENTOS CLICK"
    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub dgvDetalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellDoubleClick
        If e.RowIndex > -1 Then
            Dim Result As DialogResult

            If Not IsNothing(dgvRemitos.CurrentCell) Then
                infoDetalleRemito = New DetalleRemitoVenta With {
                    .IdDetalleRemitosVenta = dgvDetalle.CurrentRow.Cells("id").Value,
                    .Cantidad = dgvDetalle.CurrentRow.Cells("Cantidad").Value,
                    .Precio = dgvDetalle.CurrentRow.Cells("Precio").Value,
                    .AscArticulos = New Articulos With {
                        .IdArticulo = dgvDetalle.CurrentRow.Cells("idArticulos").Value,
                        .CodArticulo = dgvDetalle.CurrentRow.Cells("CodArticulo").Value,
                        .Detalle = dgvDetalle.CurrentRow.Cells("Articulo").Value
                    },
                    .AscRemitosVenta = New RemitoVenta With {.IdRemitosVenta = dgvRemitos.CurrentRow.Cells("idRemitosVenta").Value}
                }

                frmArticuloDevoluciones.Dispose()
                UtilidadesVarias.Escalar(frmArticuloDevoluciones)
                frmArticuloDevoluciones.txtOrigen.Text = "Agregar"
                frmArticuloDevoluciones.txtComprobante.Text = "REMITO"

                Result = frmArticuloDevoluciones.ShowDialog()
            ElseIf Not IsNothing(dgvFacturas.CurrentCell) Then
                infoDetalleFactura = New FacturaVentaDetalle With {
                    .IdFacturaVentaDetalle = dgvDetalle.CurrentRow.Cells("id").Value,
                    .Cantidad = dgvDetalle.CurrentRow.Cells("Cantidad").Value,
                    .Precio = dgvDetalle.CurrentRow.Cells("Precio").Value,
                    .AscArticulos = New Articulos With {
                        .IdArticulo = dgvDetalle.CurrentRow.Cells("idArticulos").Value,
                        .CodArticulo = dgvDetalle.CurrentRow.Cells("CodArticulo").Value,
                        .Detalle = dgvDetalle.CurrentRow.Cells("Articulo").Value
                    },
                    .AscFacturaVenta = New FacturaVenta With {.IdFacturaVenta = dgvFacturas.CurrentRow.Cells("idFacturaVenta").Value}
                }

                frmArticuloDevoluciones.Dispose()
                UtilidadesVarias.Escalar(frmArticuloDevoluciones)
                frmArticuloDevoluciones.txtOrigen.Text = "Agregar"
                frmArticuloDevoluciones.txtComprobante.Text = "FACTURA"

                Result = frmArticuloDevoluciones.ShowDialog()
            End If

            If Result = DialogResult.OK Then
                Me.DialogResult = DialogResult.OK

                Me.Close()
            End If

            dgvDetalle.CurrentCell = Nothing
        Else
            dgvDetalle.CurrentCell = Nothing
        End If
    End Sub

    Private Sub dgvRemitos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRemitos.CellClick
        If e.RowIndex > -1 Then
            dgvFacturas.CurrentCell = Nothing
            UtilidadesDGV.DescargarDGV(dgvDetalle)

            For Each Item In ListadoDetalleRemito
                Dim Count As Double = CountCantidadRemito(Item.IdDetalleRemitosVenta)

                If Item.AscRemitosVenta.IdRemitosVenta = dgvRemitos.CurrentRow.Cells("idRemitosVenta").Value And Count < Item.Cantidad Then
                    dgvDetalle.Rows.Add(Item.IdDetalleRemitosVenta, Item.AscArticulos.IdArticulo, Item.AscArticulos.CodArticulo,
                                        Item.AscArticulos.Detalle, Item.Cantidad - Count, Item.Precio)

                    If Count <> 0 Then
                        dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells("Cantidad").Style.ForeColor = Color.FromArgb(95, 150, 15)
                    End If
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        Else
            dgvRemitos.CurrentCell = Nothing

            UtilidadesDGV.DescargarDGV(dgvDetalle)
            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        End If
    End Sub

    Private Sub dgvFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturas.CellClick
        If e.RowIndex > -1 Then
            dgvRemitos.CurrentCell = Nothing
            UtilidadesDGV.DescargarDGV(dgvDetalle)

            For Each Item In ListadoFacturaVentaDetalle
                Dim Count As Double = CountCantidadFactura(Item.IdFacturaVentaDetalle)

                If Item.AscFacturaVenta.IdFacturaVenta = dgvFacturas.CurrentRow.Cells("idFacturaVenta").Value And Item.Cantidad - Count > 0 Then
                    dgvDetalle.Rows.Add(Item.IdFacturaVentaDetalle, Item.AscArticulos.IdArticulo,
                                        Item.AscArticulos.CodArticulo, Item.AscArticulos.Detalle, Item.Cantidad - Count, Item.Precio)

                    If Count <> 0 Then
                        dgvDetalle.Rows(dgvDetalle.Rows.Count - 1).Cells("Cantidad").Style.ForeColor = Color.FromArgb(95, 150, 15)
                    End If
                End If
            Next

            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        Else
            dgvFacturas.CurrentCell = Nothing

            UtilidadesDGV.DescargarDGV(dgvDetalle)
            UtilidadesDGV.CabeceraDGV(dgvDetalle)
        End If
    End Sub

#End Region
End Class