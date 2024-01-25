<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtUsuario = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContraseña = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnCerrar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel1.Location = New System.Drawing.Point(322, 298)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(394, 23)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Olvidaste la contraseña ?"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUsuario.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.txtUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUsuario.BorderThickness = 3
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUsuario.isPassword = False
        Me.txtUsuario.Location = New System.Drawing.Point(325, 78)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(391, 49)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.BackColor = System.Drawing.Color.Transparent
        Me.lblAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccion.ForeColor = System.Drawing.Color.LightGray
        Me.lblAccion.Location = New System.Drawing.Point(321, 52)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(60, 18)
        Me.lblAccion.TabIndex = 11
        Me.lblAccion.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(321, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtContraseña.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.txtContraseña.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtContraseña.BorderThickness = 3
        Me.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtContraseña.isPassword = True
        Me.txtContraseña.Location = New System.Drawing.Point(325, 165)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(391, 52)
        Me.txtContraseña.TabIndex = 2
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.Presentacion.My.Resources.Resources.IconoCerrar
        Me.btnCerrar.ImageActive = Global.Presentacion.My.Resources.Resources.IconoCerrarVerde
        Me.btnCerrar.Location = New System.Drawing.Point(727, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 26)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.pbxLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Panel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Quality = 10
        Me.Panel1.Size = New System.Drawing.Size(250, 355)
        Me.Panel1.TabIndex = 9
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.Presentacion.My.Resources.Resources.IconoEmpresa
        Me.pbxLogo.Location = New System.Drawing.Point(24, 75)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(200, 200)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 1
        Me.pbxLogo.TabStop = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.Gray
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.Black
        Me.btnIngresar.Location = New System.Drawing.Point(325, 255)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(391, 40)
        Me.btnIngresar.TabIndex = 16
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 355)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAccion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtUsuario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Presentacion"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents txtUsuario As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblAccion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContraseña As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnCerrar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnIngresar As Button
End Class
