<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProceso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProceso))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.bnfBar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.bnfPanelLogo = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Animacion = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfPanelLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 20
        Me.BunifuElipse3.TargetControl = Me.BunifuGradientPanel1
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.bnfBar)
        Me.BunifuGradientPanel1.Controls.Add(Me.lblMensaje)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(94, 8)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 50
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(315, 130)
        Me.BunifuGradientPanel1.TabIndex = 29
        '
        'bnfBar
        '
        Me.bnfBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.bnfBar.BorderRadius = 0
        Me.bnfBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnfBar.Location = New System.Drawing.Point(0, 120)
        Me.bnfBar.MaximumValue = 100
        Me.bnfBar.Name = "bnfBar"
        Me.bnfBar.ProgressColor = System.Drawing.Color.White
        Me.bnfBar.Size = New System.Drawing.Size(315, 10)
        Me.bnfBar.TabIndex = 10
        Me.bnfBar.Value = 0
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.White
        Me.lblMensaje.Location = New System.Drawing.Point(3, 1)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(308, 116)
        Me.lblMensaje.TabIndex = 7
        Me.lblMensaje.Text = "CARGANDO"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.Presentacion.My.Resources.Resources.LogoSIGEVA
        Me.pbxLogo.Location = New System.Drawing.Point(14, 39)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(70, 70)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 7
        Me.pbxLogo.TabStop = False
        '
        'bnfPanelLogo
        '
        Me.bnfPanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfPanelLogo.BackgroundImage = CType(resources.GetObject("bnfPanelLogo.BackgroundImage"), System.Drawing.Image)
        Me.bnfPanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bnfPanelLogo.Controls.Add(Me.BunifuGradientPanel1)
        Me.bnfPanelLogo.Controls.Add(Me.pbxLogo)
        Me.bnfPanelLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bnfPanelLogo.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfPanelLogo.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfPanelLogo.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfPanelLogo.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfPanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.bnfPanelLogo.Name = "bnfPanelLogo"
        Me.bnfPanelLogo.Quality = 50
        Me.bnfPanelLogo.Size = New System.Drawing.Size(417, 145)
        Me.bnfPanelLogo.TabIndex = 28
        '
        'Animacion
        '
        Me.Animacion.Enabled = True
        Me.Animacion.Interval = 5
        '
        'frmProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(417, 145)
        Me.Controls.Add(Me.bnfPanelLogo)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProceso"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCarga"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfPanelLogo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfPanelLogo As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lblMensaje As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents bnfBar As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Animacion As Timer
End Class
