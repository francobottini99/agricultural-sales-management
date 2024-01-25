<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioSistema))
        Me.Espera = New System.Windows.Forms.Timer(Me.components)
        Me.Animacion = New System.Windows.Forms.Timer(Me.components)
        Me.Peticiones = New System.ComponentModel.BackgroundWorker()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.bnfBar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Espera
        '
        Me.Espera.Interval = 1000
        '
        'Animacion
        '
        Me.Animacion.Enabled = True
        Me.Animacion.Interval = 5
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 60
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.pbxLogo)
        Me.BunifuGradientPanel1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(192, 227)
        Me.BunifuGradientPanel1.TabIndex = 10
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.BackColor = System.Drawing.Color.Transparent
        Me.lblAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccion.ForeColor = System.Drawing.Color.DimGray
        Me.lblAccion.Location = New System.Drawing.Point(170, 175)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(149, 16)
        Me.lblAccion.TabIndex = 7
        Me.lblAccion.Text = "INICIANDO SISTEMA ..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.SIGEVA_GRIS
        Me.PictureBox1.Location = New System.Drawing.Point(44, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.Presentacion.My.Resources.Resources.Carga
        Me.pbxLogo.Location = New System.Drawing.Point(23, 40)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(143, 151)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 2
        Me.pbxLogo.TabStop = False
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.bnfBar)
        Me.BunifuGradientPanel2.Controls.Add(Me.lblAccion)
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(185, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 50
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(459, 227)
        Me.BunifuGradientPanel2.TabIndex = 30
        '
        'bnfBar
        '
        Me.bnfBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.bnfBar.BorderRadius = 0
        Me.bnfBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnfBar.Location = New System.Drawing.Point(0, 217)
        Me.bnfBar.MaximumValue = 100
        Me.bnfBar.Name = "bnfBar"
        Me.bnfBar.ProgressColor = System.Drawing.Color.White
        Me.bnfBar.Size = New System.Drawing.Size(459, 10)
        Me.bnfBar.TabIndex = 9
        Me.bnfBar.Value = 0
        '
        'frmInicioSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 227)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicioSistema"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentacion"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Espera As Timer
    Friend WithEvents Animacion As Timer
    Friend WithEvents Peticiones As System.ComponentModel.BackgroundWorker
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAccion As Label
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents bnfBar As Bunifu.Framework.UI.BunifuProgressBar
End Class
