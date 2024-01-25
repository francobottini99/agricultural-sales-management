<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaValoresEnCartera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaValoresEnCartera))
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.bnfCardValoresEnCartera = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvValoresCartera = New System.Windows.Forms.DataGridView()
        Me.bnfCardGral = New Bunifu.Framework.UI.BunifuCards()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLibrador = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtFormOrigen = New System.Windows.Forms.TextBox()
        Me.txtLista = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfElipFrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipPnl = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlFrmArticulos.SuspendLayout()
        Me.bnfCardValoresEnCartera.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.dgvValoresCartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardGral.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardValoresEnCartera)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardGral)
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(6, 35)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(986, 565)
        Me.pnlFrmArticulos.TabIndex = 66
        '
        'bnfCardValoresEnCartera
        '
        Me.bnfCardValoresEnCartera.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardValoresEnCartera.BorderRadius = 5
        Me.bnfCardValoresEnCartera.BottomSahddow = True
        Me.bnfCardValoresEnCartera.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardValoresEnCartera.Controls.Add(Me.BunifuCards3)
        Me.bnfCardValoresEnCartera.Controls.Add(Me.dgvValoresCartera)
        Me.bnfCardValoresEnCartera.LeftSahddow = False
        Me.bnfCardValoresEnCartera.Location = New System.Drawing.Point(11, 70)
        Me.bnfCardValoresEnCartera.Name = "bnfCardValoresEnCartera"
        Me.bnfCardValoresEnCartera.RightSahddow = True
        Me.bnfCardValoresEnCartera.ShadowDepth = 20
        Me.bnfCardValoresEnCartera.Size = New System.Drawing.Size(966, 485)
        Me.bnfCardValoresEnCartera.TabIndex = 111
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.Label8)
        Me.BunifuCards3.Controls.Add(Me.Label5)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(951, 33)
        Me.BunifuCards3.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(699, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 18)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Nota: <Doble Click>: Selecciona el item" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(487, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "VALORES EN CARTERA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvValoresCartera
        '
        Me.dgvValoresCartera.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvValoresCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValoresCartera.Location = New System.Drawing.Point(9, 43)
        Me.dgvValoresCartera.Name = "dgvValoresCartera"
        Me.dgvValoresCartera.Size = New System.Drawing.Size(945, 428)
        Me.dgvValoresCartera.TabIndex = 64
        '
        'bnfCardGral
        '
        Me.bnfCardGral.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardGral.BorderRadius = 5
        Me.bnfCardGral.BottomSahddow = True
        Me.bnfCardGral.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardGral.Controls.Add(Me.Label1)
        Me.bnfCardGral.Controls.Add(Me.txtLibrador)
        Me.bnfCardGral.Controls.Add(Me.Label6)
        Me.bnfCardGral.Controls.Add(Me.txtNumero)
        Me.bnfCardGral.Controls.Add(Me.BunifuCards1)
        Me.bnfCardGral.LeftSahddow = False
        Me.bnfCardGral.Location = New System.Drawing.Point(11, 11)
        Me.bnfCardGral.Name = "bnfCardGral"
        Me.bnfCardGral.RightSahddow = True
        Me.bnfCardGral.ShadowDepth = 20
        Me.bnfCardGral.Size = New System.Drawing.Size(966, 53)
        Me.bnfCardGral.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(356, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "LIBRADOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLibrador
        '
        Me.txtLibrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLibrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLibrador.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibrador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtLibrador.Location = New System.Drawing.Point(430, 15)
        Me.txtLibrador.MaxLength = 255
        Me.txtLibrador.Name = "txtLibrador"
        Me.txtLibrador.Size = New System.Drawing.Size(524, 25)
        Me.txtLibrador.TabIndex = 114
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(102, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "NUMERO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(168, 15)
        Me.txtNumero.MaxLength = 45
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(182, 25)
        Me.txtNumero.TabIndex = 112
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(95, 53)
        Me.BunifuCards1.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 22)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "BUSCAR"
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = False
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtFormOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.txtLista)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = False
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(998, 33)
        Me.bnfCardTitulo.TabIndex = 92
        '
        'txtFormOrigen
        '
        Me.txtFormOrigen.BackColor = System.Drawing.Color.Red
        Me.txtFormOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormOrigen.Enabled = False
        Me.txtFormOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormOrigen.ForeColor = System.Drawing.Color.White
        Me.txtFormOrigen.Location = New System.Drawing.Point(808, 3)
        Me.txtFormOrigen.Name = "txtFormOrigen"
        Me.txtFormOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtFormOrigen.TabIndex = 66
        Me.txtFormOrigen.Visible = False
        '
        'txtLista
        '
        Me.txtLista.BackColor = System.Drawing.Color.Red
        Me.txtLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLista.Enabled = False
        Me.txtLista.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLista.ForeColor = System.Drawing.Color.White
        Me.txtLista.Location = New System.Drawing.Point(882, 3)
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(68, 25)
        Me.txtLista.TabIndex = 65
        Me.txtLista.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(788, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "..."
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(961, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 1
        '
        'bnfElipFrm
        '
        Me.bnfElipFrm.ElipseRadius = 20
        Me.bnfElipFrm.TargetControl = Me
        '
        'bnfElipPnl
        '
        Me.bnfElipPnl.ElipseRadius = 20
        Me.bnfElipPnl.TargetControl = Me.pnlFrmArticulos
        '
        'frmListaValoresEnCartera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 606)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.Controls.Add(Me.bnfCardTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaValoresEnCartera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmValorEnCartera"
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.bnfCardValoresEnCartera.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        CType(Me.dgvValoresCartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardGral.ResumeLayout(False)
        Me.bnfCardGral.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents bnfCardValoresEnCartera As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvValoresCartera As DataGridView
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents bnfCardGral As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLibrador As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLista As TextBox
    Friend WithEvents txtFormOrigen As TextBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label2 As Label
    Friend WithEvents bnfElipFrm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipPnl As Bunifu.Framework.UI.BunifuElipse
End Class
