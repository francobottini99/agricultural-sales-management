Public Class UtilidadesDGV
    Public Shared Sub DisableSortColumns(ByRef DGV As DataGridView)
        For Each column As DataGridViewColumn In DGV.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Public Shared Sub DisableResizeColumns(ByRef DGV As DataGridView)
        For Each column As DataGridViewColumn In DGV.Columns
            column.Resizable = DataGridViewTriState.False
        Next
    End Sub

    Public Shared Function ConvertirDGV_DT(ByVal miDataGrid As DataGridView) As DataTable
        Dim Tabla As New DataTable

        Try
            Dim filaNueva As DataRow
            Dim numCols As Integer

            numCols = miDataGrid.ColumnCount

            For Each Columna As DataGridViewColumn In miDataGrid.Columns
                Tabla.Columns.Add(Columna.Name)
            Next

            For Each filaDatos As DataGridViewRow In miDataGrid.Rows
                filaNueva = Tabla.NewRow()
                For i As Integer = 0 To numCols - 1
                    filaNueva(i) = filaDatos.Cells(i).Value
                Next
                Tabla.Rows.Add(filaNueva)
            Next

            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message.ToArray)
            Tabla = New DataTable
            Return Tabla
        End Try
    End Function

    Public Shared Sub CabeceraDGV(ByRef DGV As DataGridView, Optional disposicon As DataGridViewAutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill)
        If DGV.Rows.Count < 1 Then
            DGV.ColumnHeadersVisible = False
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            DGV.ColumnHeadersVisible = True
            DGV.AutoSizeColumnsMode = disposicon
        End If

        DGV.CurrentCell = Nothing
    End Sub

    Public Shared Sub DescargarDGV(ByRef DGV As DataGridView)
        DGV.DataSource = Nothing

        Dim rows As Integer = DGV.Rows.Count - 1

        If DGV.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                DGV.Rows.Remove(DGV.Rows(j))
            Next
        End If

        DGV.ColumnHeadersVisible = False
    End Sub

    Public Shared Sub FormatoDGVGeneral(ByRef DGV As DataGridView)
        Dim CurrentScreenWidth As Integer
        Dim CurrentScreenHeight As Integer
        Dim DesignScreenHeight As Integer = 860
        Dim DesignScreenWidth As Integer = 1600
        Dim RatioX As Single
        Dim RatioY As Single

        For Each item As Screen In Screen.AllScreens
            If item.WorkingArea.Contains(DGV.Location) Then
                CurrentScreenWidth = item.WorkingArea.Width
                CurrentScreenHeight = item.WorkingArea.Height

                Exit For
            End If
        Next

        RatioX = CurrentScreenWidth / DesignScreenWidth
        RatioY = CurrentScreenHeight / DesignScreenHeight

        'ANULO POSIBILIDAD DE EDICION DEL USUARIO
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DGV.ReadOnly = True

        'COLOR DE FONDO DE LA TABLA
        DGV.BackgroundColor = Color.FromArgb(30, 30, 30)

        'CELDAS COLOR FONDO, TIPO Y COLOR LETRAS
        DGV.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)
        DGV.RowsDefaultCellStyle.Font = New Font("Trebuchet MS", 10 * RatioY * RatioX) 'New Font("Trebuchet MS", 10)
        DGV.RowsDefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200)

        'CELDAS COLOR FONDO, TIPO Y COLOR LETRAS
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)
        DGV.AlternatingRowsDefaultCellStyle.Font = New Font("Trebuchet MS", 10 * RatioY * RatioX) 'New Font("Trebuchet MS", 10)
        DGV.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200)

        'CELDAS SELECCION
        DGV.MultiSelect = False
        DGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(175, 175, 175)
        DGV.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'COLOR Y TIPO DE LA GRILLA
        DGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DGV.GridColor = Color.LightGray

        'EDICION DE LA CABECERA DE COLUMNAS
        DGV.EnableHeadersVisualStyles = False
        DGV.ColumnHeadersHeight = 25 * RatioY
        DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(175, 175, 175)
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0)
        DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(175, 175, 175)
        DGV.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS", 10 * RatioY * RatioX, FontStyle.Bold) 'New Font("Trebuchet MS", 10, FontStyle.Bold)

        'EDICION DE LA CABECERA DE FILAS
        DGV.AllowUserToResizeRows = False
        DGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGV.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(175, 175, 175)
        DGV.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(175, 175, 175)
        DGV.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)
        DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        'TIPO DE SELECCION DE CELDAS
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'ALTO DE FILAS
        DGV.RowTemplate.Height = 25 * RatioY
    End Sub
End Class
