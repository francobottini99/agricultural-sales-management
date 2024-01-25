<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaFacturaVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaFacturaVenta))
        Me.txtBuscFec = New System.Windows.Forms.TextBox()
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bnfCardList = New Bunifu.Framework.UI.BunifuCards()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBuscCli = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBuscNroFac = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvFacturasVenta = New System.Windows.Forms.DataGridView()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtLista = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFrmArticulos.SuspendLayout()
        Me.bnfCardList.SuspendLayout()
        CType(Me.dgvFacturasVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscFec
        '
        Me.txtBuscFec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtBuscFec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscFec.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtBuscFec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscFec.Location = New System.Drawing.Point(579, 15)
        Me.txtBuscFec.Name = "txtBuscFec"
        Me.txtBuscFec.Size = New System.Drawing.Size(157, 18)
        Me.txtBuscFec.TabIndex = 58
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlFrmArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFrmArticulos.Controls.Add(Me.Label8)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardList)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(993, 600)
        Me.pnlFrmArticulos.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(723, 571)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 18)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Nota: <Doble Click>: Selecciona Factura"
        '
        'bnfCardList
        '
        Me.bnfCardList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnfCardList.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardList.BorderRadius = 5
        Me.bnfCardList.BottomSahddow = True
        Me.bnfCardList.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardList.Controls.Add(Me.Label12)
        Me.bnfCardList.Controls.Add(Me.txtBuscCli)
        Me.bnfCardList.Controls.Add(Me.Label16)
        Me.bnfCardList.Controls.Add(Me.txtBuscFec)
        Me.bnfCardList.Controls.Add(Me.Label14)
        Me.bnfCardList.Controls.Add(Me.txtBuscNroFac)
        Me.bnfCardList.Controls.Add(Me.Label7)
        Me.bnfCardList.Controls.Add(Me.dgvFacturasVenta)
        Me.bnfCardList.Controls.Add(Me.ShapeContainer3)
        Me.bnfCardList.LeftSahddow = False
        Me.bnfCardList.Location = New System.Drawing.Point(3, 45)
        Me.bnfCardList.Name = "bnfCardList"
        Me.bnfCardList.RightSahddow = True
        Me.bnfCardList.ShadowDepth = 20
        Me.bnfCardList.Size = New System.Drawing.Size(984, 517)
        Me.bnfCardList.TabIndex = 58
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(95, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 18)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Cliente"
        '
        'txtBuscCli
        '
        Me.txtBuscCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtBuscCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscCli.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtBuscCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscCli.Location = New System.Drawing.Point(183, 45)
        Me.txtBuscCli.Name = "txtBuscCli"
        Me.txtBuscCli.Size = New System.Drawing.Size(312, 18)
        Me.txtBuscCli.TabIndex = 60
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(529, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 18)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(95, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 18)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Nro Factura"
        '
        'txtBuscNroFac
        '
        Me.txtBuscNroFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscNroFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtBuscNroFac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscNroFac.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtBuscNroFac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscNroFac.Location = New System.Drawing.Point(183, 16)
        Me.txtBuscNroFac.Name = "txtBuscNroFac"
        Me.txtBuscNroFac.Size = New System.Drawing.Size(312, 18)
        Me.txtBuscNroFac.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(7, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 23)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "BUSCAR"
        '
        'dgvFacturasVenta
        '
        Me.dgvFacturasVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFacturasVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvFacturasVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturasVenta.Location = New System.Drawing.Point(7, 85)
        Me.dgvFacturasVenta.Name = "dgvFacturasVenta"
        Me.dgvFacturasVenta.Size = New System.Drawing.Size(967, 420)
        Me.dgvFacturasVenta.TabIndex = 50
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3})
        Me.ShapeContainer3.Size = New System.Drawing.Size(984, 517)
        Me.ShapeContainer3.TabIndex = 53
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape5.BorderColor = System.Drawing.Color.DarkGray
        Me.LineShape5.BorderWidth = 2
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 7
        Me.LineShape5.X2 = 272
        Me.LineShape5.Y1 = 75
        Me.LineShape5.Y2 = 75
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.DarkGray
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 83
        Me.LineShape4.X2 = 82
        Me.LineShape4.Y1 = 6
        Me.LineShape4.Y2 = 72
        '
        'LineShape3
        '
        Me.LineShape3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape3.BorderColor = System.Drawing.Color.DarkGray
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 271
        Me.LineShape3.X2 = 976
        Me.LineShape3.Y1 = 75
        Me.LineShape3.Y2 = 75
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 5
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtLista)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(1, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = True
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(987, 35)
        Me.bnfCardTitulo.TabIndex = 55
        '
        'txtLista
        '
        Me.txtLista.BackColor = System.Drawing.Color.Red
        Me.txtLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLista.Enabled = False
        Me.txtLista.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLista.ForeColor = System.Drawing.Color.White
        Me.txtLista.Location = New System.Drawing.Point(880, 10)
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(68, 25)
        Me.txtLista.TabIndex = 64
        Me.txtLista.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(8, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(866, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "..."
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(955, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'frmListaFacturaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 600)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaFacturaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListaFacturaVenta"
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.pnlFrmArticulos.PerformLayout()
        Me.bnfCardList.ResumeLayout(False)
        Me.bnfCardList.PerformLayout()
        CType(Me.dgvFacturasVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtBuscFec As TextBox
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents bnfCardList As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBuscNroFac As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvFacturasVenta As DataGridView
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As PowerPacks.LineShape
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtLista As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBuscCli As TextBox
End Class
