<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucionesrRetiradoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionesrRetiradoCliente))
        Me.bnfElipPnl = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvRemitos = New System.Windows.Forms.DataGridView()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.bnfNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfElipFrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfCardList = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.pnlFrmArticulos.SuspendLayout()
        Me.BunifuCards5.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvRemitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTitulo.SuspendLayout()
        Me.bnfCardList.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnfElipPnl
        '
        Me.bnfElipPnl.ElipseRadius = 20
        Me.bnfElipPnl.TargetControl = Me.pnlFrmArticulos
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardList)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards5)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(6, 35)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(1257, 624)
        Me.pnlFrmArticulos.TabIndex = 66
        '
        'BunifuCards5
        '
        Me.BunifuCards5.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards5.BorderRadius = 5
        Me.BunifuCards5.BottomSahddow = True
        Me.BunifuCards5.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards5.Controls.Add(Me.BunifuCards6)
        Me.BunifuCards5.Controls.Add(Me.dgvRemitos)
        Me.BunifuCards5.LeftSahddow = False
        Me.BunifuCards5.Location = New System.Drawing.Point(11, 11)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = True
        Me.BunifuCards5.ShadowDepth = 20
        Me.BunifuCards5.Size = New System.Drawing.Size(615, 296)
        Me.BunifuCards5.TabIndex = 98
        '
        'BunifuCards6
        '
        Me.BunifuCards6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.Label5)
        Me.BunifuCards6.Controls.Add(Me.Label3)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(601, 33)
        Me.BunifuCards6.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(347, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 18)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "<Click>: Despliega el detalle del Remito"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(487, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "REMITADO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvRemitos
        '
        Me.dgvRemitos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRemitos.Location = New System.Drawing.Point(9, 43)
        Me.dgvRemitos.Name = "dgvRemitos"
        Me.dgvRemitos.Size = New System.Drawing.Size(595, 243)
        Me.dgvRemitos.TabIndex = 50
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.BunifuCards4)
        Me.BunifuCards1.Controls.Add(Me.dgvDetalle)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(632, 11)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(615, 602)
        Me.BunifuCards1.TabIndex = 59
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.Label8)
        Me.BunifuCards4.Controls.Add(Me.Label2)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(601, 33)
        Me.BunifuCards4.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(381, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(217, 18)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "<Doble Click>: Selecciona un Item"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(487, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DETALLE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDetalle
        '
        Me.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(9, 43)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(595, 545)
        Me.dgvDetalle.TabIndex = 50
        '
        'bnfNuevo
        '
        Me.bnfNuevo.ElipseRadius = 7
        Me.bnfNuevo.TargetControl = Me
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 50
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(866, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "DEVOLUCIONES -> REMITOS Y FACTURAS DEL CLIENTE"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(1231, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = False
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = False
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(1269, 35)
        Me.bnfCardTitulo.TabIndex = 65
        '
        'bnfElipFrm
        '
        Me.bnfElipFrm.ElipseRadius = 20
        Me.bnfElipFrm.TargetControl = Me
        '
        'bnfCardList
        '
        Me.bnfCardList.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardList.BorderRadius = 5
        Me.bnfCardList.BottomSahddow = True
        Me.bnfCardList.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardList.Controls.Add(Me.BunifuCards3)
        Me.bnfCardList.Controls.Add(Me.dgvFacturas)
        Me.bnfCardList.LeftSahddow = False
        Me.bnfCardList.Location = New System.Drawing.Point(11, 313)
        Me.bnfCardList.Name = "bnfCardList"
        Me.bnfCardList.RightSahddow = True
        Me.bnfCardList.ShadowDepth = 20
        Me.bnfCardList.Size = New System.Drawing.Size(615, 300)
        Me.bnfCardList.TabIndex = 99
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.Label4)
        Me.BunifuCards3.Controls.Add(Me.Label1)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(601, 33)
        Me.BunifuCards3.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(331, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 18)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "<Click>: Despliega el detalle de la Factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACTURADO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvFacturas
        '
        Me.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Location = New System.Drawing.Point(9, 43)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.Size = New System.Drawing.Size(595, 243)
        Me.dgvFacturas.TabIndex = 50
        '
        'frmDevolucionesRemitoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1269, 665)
        Me.Controls.Add(Me.bnfCardTitulo)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevolucionesRemitoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDevolucionesRemito"
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.BunifuCards5.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        Me.BunifuCards6.PerformLayout()
        CType(Me.dgvRemitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardList.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bnfElipPnl As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvRemitos As DataGridView
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents bnfNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfElipFrm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfCardList As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvFacturas As DataGridView
End Class
