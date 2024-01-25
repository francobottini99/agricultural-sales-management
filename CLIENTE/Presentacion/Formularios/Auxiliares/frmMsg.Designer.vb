<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsg))
        Me.bnfElipMsg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfDragMsg = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.bnfBarraTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.bnfBtnOk = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnOK = New System.Windows.Forms.Button()
        Me.bnfBtnCerr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbxInf = New System.Windows.Forms.PictureBox()
        Me.pbxError = New System.Windows.Forms.PictureBox()
        Me.pbxAlerta = New System.Windows.Forms.PictureBox()
        Me.pbxOk = New System.Windows.Forms.PictureBox()
        Me.bnfPanelElip = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfBarraTitulo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxInf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxOk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnfElipMsg
        '
        Me.bnfElipMsg.ElipseRadius = 20
        Me.bnfElipMsg.TargetControl = Me
        '
        'bnfDragMsg
        '
        Me.bnfDragMsg.Fixed = True
        Me.bnfDragMsg.Horizontal = True
        Me.bnfDragMsg.TargetControl = Me
        Me.bnfDragMsg.Vertical = True
        '
        'bnfBarraTitulo
        '
        Me.bnfBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.bnfBarraTitulo.BorderRadius = 5
        Me.bnfBarraTitulo.BottomSahddow = False
        Me.bnfBarraTitulo.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.bnfBarraTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfBarraTitulo.LeftSahddow = False
        Me.bnfBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfBarraTitulo.Name = "bnfBarraTitulo"
        Me.bnfBarraTitulo.RightSahddow = True
        Me.bnfBarraTitulo.ShadowDepth = 20
        Me.bnfBarraTitulo.Size = New System.Drawing.Size(471, 42)
        Me.bnfBarraTitulo.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(229, 23)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "SIGEVA - Sistema de Alertas"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.White
        Me.lblMsg.Location = New System.Drawing.Point(91, 10)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(3, 3, 3, 50)
        Me.lblMsg.MaximumSize = New System.Drawing.Size(355, 700)
        Me.lblMsg.MinimumSize = New System.Drawing.Size(355, 73)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(355, 73)
        Me.lblMsg.TabIndex = 2
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfBtnOk
        '
        Me.bnfBtnOk.ElipseRadius = 10
        Me.bnfBtnOk.TargetControl = Me.btnOK
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(360, 92)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 40)
        Me.btnOK.TabIndex = 34
        Me.btnOK.Text = "Aceptar"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'bnfBtnCerr
        '
        Me.bnfBtnCerr.ElipseRadius = 10
        Me.bnfBtnCerr.TargetControl = Me.btnCerrar
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(267, 92)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(87, 40)
        Me.btnCerrar.TabIndex = 35
        Me.btnCerrar.Text = "Cancelar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.lblMsg)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.pbxInf)
        Me.Panel1.Controls.Add(Me.pbxError)
        Me.Panel1.Controls.Add(Me.pbxAlerta)
        Me.Panel1.Controls.Add(Me.pbxOk)
        Me.Panel1.Location = New System.Drawing.Point(7, 40)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 139)
        Me.Panel1.TabIndex = 39
        '
        'pbxInf
        '
        Me.pbxInf.Image = Global.Presentacion.My.Resources.Resources.IconoInformacion_Minimalista
        Me.pbxInf.Location = New System.Drawing.Point(6, 10)
        Me.pbxInf.Name = "pbxInf"
        Me.pbxInf.Size = New System.Drawing.Size(79, 73)
        Me.pbxInf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxInf.TabIndex = 36
        Me.pbxInf.TabStop = False
        '
        'pbxError
        '
        Me.pbxError.Image = Global.Presentacion.My.Resources.Resources.IconoError_Minimalista
        Me.pbxError.Location = New System.Drawing.Point(6, 10)
        Me.pbxError.Name = "pbxError"
        Me.pbxError.Size = New System.Drawing.Size(79, 73)
        Me.pbxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxError.TabIndex = 37
        Me.pbxError.TabStop = False
        '
        'pbxAlerta
        '
        Me.pbxAlerta.Image = Global.Presentacion.My.Resources.Resources.IconoAlerta_Minimalista
        Me.pbxAlerta.Location = New System.Drawing.Point(6, 10)
        Me.pbxAlerta.Name = "pbxAlerta"
        Me.pbxAlerta.Size = New System.Drawing.Size(79, 73)
        Me.pbxAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxAlerta.TabIndex = 3
        Me.pbxAlerta.TabStop = False
        '
        'pbxOk
        '
        Me.pbxOk.Image = Global.Presentacion.My.Resources.Resources.IconoOk_Minimalista1
        Me.pbxOk.Location = New System.Drawing.Point(6, 10)
        Me.pbxOk.Name = "pbxOk"
        Me.pbxOk.Size = New System.Drawing.Size(79, 73)
        Me.pbxOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxOk.TabIndex = 38
        Me.pbxOk.TabStop = False
        '
        'bnfPanelElip
        '
        Me.bnfPanelElip.ElipseRadius = 20
        Me.bnfPanelElip.TargetControl = Me.Panel1
        '
        'frmMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 188)
        Me.Controls.Add(Me.bnfBarraTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(468, 188)
        Me.Name = "frmMsg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMsg"
        Me.bnfBarraTitulo.ResumeLayout(False)
        Me.bnfBarraTitulo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxInf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxOk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bnfElipMsg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfDragMsg As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents bnfBarraTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxAlerta As PictureBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents bnfBtnOk As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfBtnCerr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pbxInf As PictureBox
    Friend WithEvents pbxError As PictureBox
    Friend WithEvents pbxOk As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bnfPanelElip As Bunifu.Framework.UI.BunifuElipse
End Class
