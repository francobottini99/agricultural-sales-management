<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcategorias))
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtSubRubAnt = New System.Windows.Forms.TextBox()
        Me.txtAbAnt = New System.Windows.Forms.TextBox()
        Me.txtRubroAnt = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtIdSubRubro = New System.Windows.Forms.TextBox()
        Me.txtIdRubro = New System.Windows.Forms.TextBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubrubro = New System.Windows.Forms.TextBox()
        Me.V = New System.Windows.Forms.Label()
        Me.bnfCardDatos = New Bunifu.Framework.UI.BunifuCards()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlRubro = New System.Windows.Forms.Panel()
        Me.cmbRubro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAbrevRub = New System.Windows.Forms.TextBox()
        Me.txtRubro = New System.Windows.Forms.TextBox()
        Me.pnlSubRubro = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAbrevSub = New System.Windows.Forms.TextBox()
        Me.btnEliminarSubR = New System.Windows.Forms.Button()
        Me.btnNuevoSubR = New System.Windows.Forms.Button()
        Me.btnModificarSubR = New System.Windows.Forms.Button()
        Me.btnEliminarRub = New System.Windows.Forms.Button()
        Me.btnNuevoRub = New System.Windows.Forms.Button()
        Me.btnModificarRub = New System.Windows.Forms.Button()
        Me.btnElipNuevoR = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnElipModR = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnElipGuardar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipElimR = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipNuevoSubR = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipModSubR = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipElimSubR = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlFrmCategorias = New System.Windows.Forms.Panel()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfListRubros = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvRubros = New System.Windows.Forms.DataGridView()
        Me.bnfListSubRubros = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvSubRubros = New System.Windows.Forms.DataGridView()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardDatos.SuspendLayout()
        Me.pnlRubro.SuspendLayout()
        Me.pnlSubRubro.SuspendLayout()
        Me.pnlFrmCategorias.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        Me.bnfListRubros.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvRubros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfListSubRubros.SuspendLayout()
        Me.BunifuCards5.SuspendLayout()
        CType(Me.dgvSubRubros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.txtSubRubAnt)
        Me.bnfCardTitulo.Controls.Add(Me.txtAbAnt)
        Me.bnfCardTitulo.Controls.Add(Me.txtRubroAnt)
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdSubRubro)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdRubro)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = True
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTitulo.TabIndex = 59
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoCategorias
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 73
        Me.pbxTitulo.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(754, 35)
        Me.lblTitulo.TabIndex = 72
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubRubAnt
        '
        Me.txtSubRubAnt.BackColor = System.Drawing.Color.Red
        Me.txtSubRubAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubRubAnt.Enabled = False
        Me.txtSubRubAnt.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubRubAnt.ForeColor = System.Drawing.Color.White
        Me.txtSubRubAnt.Location = New System.Drawing.Point(340, 9)
        Me.txtSubRubAnt.Name = "txtSubRubAnt"
        Me.txtSubRubAnt.Size = New System.Drawing.Size(68, 25)
        Me.txtSubRubAnt.TabIndex = 65
        Me.txtSubRubAnt.Visible = False
        '
        'txtAbAnt
        '
        Me.txtAbAnt.BackColor = System.Drawing.Color.Red
        Me.txtAbAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbAnt.Enabled = False
        Me.txtAbAnt.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbAnt.ForeColor = System.Drawing.Color.White
        Me.txtAbAnt.Location = New System.Drawing.Point(414, 9)
        Me.txtAbAnt.Name = "txtAbAnt"
        Me.txtAbAnt.Size = New System.Drawing.Size(68, 25)
        Me.txtAbAnt.TabIndex = 64
        Me.txtAbAnt.Visible = False
        '
        'txtRubroAnt
        '
        Me.txtRubroAnt.BackColor = System.Drawing.Color.Red
        Me.txtRubroAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRubroAnt.Enabled = False
        Me.txtRubroAnt.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRubroAnt.ForeColor = System.Drawing.Color.White
        Me.txtRubroAnt.Location = New System.Drawing.Point(488, 9)
        Me.txtRubroAnt.Name = "txtRubroAnt"
        Me.txtRubroAnt.Size = New System.Drawing.Size(68, 25)
        Me.txtRubroAnt.TabIndex = 63
        Me.txtRubroAnt.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(710, 9)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 62
        Me.txtOrigen.Visible = False
        '
        'txtIdSubRubro
        '
        Me.txtIdSubRubro.BackColor = System.Drawing.Color.Red
        Me.txtIdSubRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdSubRubro.Enabled = False
        Me.txtIdSubRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSubRubro.ForeColor = System.Drawing.Color.White
        Me.txtIdSubRubro.Location = New System.Drawing.Point(636, 9)
        Me.txtIdSubRubro.Name = "txtIdSubRubro"
        Me.txtIdSubRubro.Size = New System.Drawing.Size(68, 25)
        Me.txtIdSubRubro.TabIndex = 61
        Me.txtIdSubRubro.Visible = False
        '
        'txtIdRubro
        '
        Me.txtIdRubro.BackColor = System.Drawing.Color.Red
        Me.txtIdRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdRubro.Enabled = False
        Me.txtIdRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdRubro.ForeColor = System.Drawing.Color.White
        Me.txtIdRubro.Location = New System.Drawing.Point(562, 9)
        Me.txtIdRubro.Name = "txtIdRubro"
        Me.txtIdRubro.Size = New System.Drawing.Size(68, 25)
        Me.txtIdRubro.TabIndex = 60
        Me.txtIdRubro.Visible = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(1320, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(12, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "SUB RUBRO"
        '
        'txtSubrubro
        '
        Me.txtSubrubro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSubrubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubrubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubrubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubrubro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSubrubro.Location = New System.Drawing.Point(109, 11)
        Me.txtSubrubro.MaxLength = 254
        Me.txtSubrubro.Name = "txtSubrubro"
        Me.txtSubrubro.Size = New System.Drawing.Size(306, 25)
        Me.txtSubrubro.TabIndex = 63
        '
        'V
        '
        Me.V.AutoSize = True
        Me.V.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V.ForeColor = System.Drawing.Color.LightGray
        Me.V.Location = New System.Drawing.Point(15, 16)
        Me.V.Name = "V"
        Me.V.Size = New System.Drawing.Size(50, 18)
        Me.V.TabIndex = 60
        Me.V.Text = "RUBRO"
        '
        'bnfCardDatos
        '
        Me.bnfCardDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDatos.BorderRadius = 5
        Me.bnfCardDatos.BottomSahddow = True
        Me.bnfCardDatos.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDatos.Controls.Add(Me.btnGuardar)
        Me.bnfCardDatos.Controls.Add(Me.btnCancelar)
        Me.bnfCardDatos.LeftSahddow = False
        Me.bnfCardDatos.Location = New System.Drawing.Point(1065, 754)
        Me.bnfCardDatos.Name = "bnfCardDatos"
        Me.bnfCardDatos.RightSahddow = True
        Me.bnfCardDatos.ShadowDepth = 20
        Me.bnfCardDatos.Size = New System.Drawing.Size(276, 61)
        Me.bnfCardDatos.TabIndex = 59
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.IconoGuardarRecortado
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(14, 14)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 35)
        Me.btnGuardar.TabIndex = 68
        Me.btnGuardar.Text = "        Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.Presentacion.My.Resources.Resources.IconoCancelarRecortado
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(144, 14)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 35)
        Me.btnCancelar.TabIndex = 69
        Me.btnCancelar.Text = "      Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'pnlRubro
        '
        Me.pnlRubro.Controls.Add(Me.V)
        Me.pnlRubro.Controls.Add(Me.cmbRubro)
        Me.pnlRubro.Controls.Add(Me.Label2)
        Me.pnlRubro.Controls.Add(Me.txtAbrevRub)
        Me.pnlRubro.Controls.Add(Me.txtRubro)
        Me.pnlRubro.Location = New System.Drawing.Point(3, 7)
        Me.pnlRubro.Name = "pnlRubro"
        Me.pnlRubro.Size = New System.Drawing.Size(425, 82)
        Me.pnlRubro.TabIndex = 81
        '
        'cmbRubro
        '
        Me.cmbRubro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRubro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbRubro.FormattingEnabled = True
        Me.cmbRubro.Location = New System.Drawing.Point(111, 11)
        Me.cmbRubro.Name = "cmbRubro"
        Me.cmbRubro.Size = New System.Drawing.Size(306, 28)
        Me.cmbRubro.TabIndex = 72
        Me.cmbRubro.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "ABREVIATURA"
        '
        'txtAbrevRub
        '
        Me.txtAbrevRub.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtAbrevRub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbrevRub.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbrevRub.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbrevRub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtAbrevRub.Location = New System.Drawing.Point(111, 48)
        Me.txtAbrevRub.MaxLength = 4
        Me.txtAbrevRub.Name = "txtAbrevRub"
        Me.txtAbrevRub.Size = New System.Drawing.Size(84, 25)
        Me.txtAbrevRub.TabIndex = 77
        '
        'txtRubro
        '
        Me.txtRubro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRubro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtRubro.Location = New System.Drawing.Point(111, 12)
        Me.txtRubro.MaxLength = 254
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.Size = New System.Drawing.Size(306, 25)
        Me.txtRubro.TabIndex = 61
        '
        'pnlSubRubro
        '
        Me.pnlSubRubro.Controls.Add(Me.Label8)
        Me.pnlSubRubro.Controls.Add(Me.txtSubrubro)
        Me.pnlSubRubro.Controls.Add(Me.Label3)
        Me.pnlSubRubro.Controls.Add(Me.txtAbrevSub)
        Me.pnlSubRubro.Location = New System.Drawing.Point(3, 7)
        Me.pnlSubRubro.Name = "pnlSubRubro"
        Me.pnlSubRubro.Size = New System.Drawing.Size(424, 82)
        Me.pnlSubRubro.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "ABREVIATURA"
        '
        'txtAbrevSub
        '
        Me.txtAbrevSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtAbrevSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbrevSub.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbrevSub.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbrevSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtAbrevSub.Location = New System.Drawing.Point(109, 45)
        Me.txtAbrevSub.MaxLength = 4
        Me.txtAbrevSub.Name = "txtAbrevSub"
        Me.txtAbrevSub.Size = New System.Drawing.Size(84, 25)
        Me.txtAbrevSub.TabIndex = 79
        '
        'btnEliminarSubR
        '
        Me.btnEliminarSubR.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnEliminarSubR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarSubR.FlatAppearance.BorderSize = 0
        Me.btnEliminarSubR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnEliminarSubR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarSubR.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarSubR.ForeColor = System.Drawing.Color.White
        Me.btnEliminarSubR.Image = Global.Presentacion.My.Resources.Resources.IconoBorrarRecortado
        Me.btnEliminarSubR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarSubR.Location = New System.Drawing.Point(528, 14)
        Me.btnEliminarSubR.Name = "btnEliminarSubR"
        Me.btnEliminarSubR.Size = New System.Drawing.Size(118, 35)
        Me.btnEliminarSubR.TabIndex = 75
        Me.btnEliminarSubR.Text = "      Eliminar"
        Me.btnEliminarSubR.UseVisualStyleBackColor = False
        '
        'btnNuevoSubR
        '
        Me.btnNuevoSubR.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNuevoSubR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoSubR.FlatAppearance.BorderSize = 0
        Me.btnNuevoSubR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnNuevoSubR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoSubR.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoSubR.ForeColor = System.Drawing.Color.White
        Me.btnNuevoSubR.Image = Global.Presentacion.My.Resources.Resources.IconoNuevoRecortado
        Me.btnNuevoSubR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoSubR.Location = New System.Drawing.Point(268, 14)
        Me.btnNuevoSubR.Name = "btnNuevoSubR"
        Me.btnNuevoSubR.Size = New System.Drawing.Size(118, 35)
        Me.btnNuevoSubR.TabIndex = 2
        Me.btnNuevoSubR.Text = "     Nuevo"
        Me.btnNuevoSubR.UseVisualStyleBackColor = False
        '
        'btnModificarSubR
        '
        Me.btnModificarSubR.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnModificarSubR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarSubR.FlatAppearance.BorderSize = 0
        Me.btnModificarSubR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnModificarSubR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarSubR.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarSubR.ForeColor = System.Drawing.Color.White
        Me.btnModificarSubR.Image = Global.Presentacion.My.Resources.Resources.IconoModificarRecortado1
        Me.btnModificarSubR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarSubR.Location = New System.Drawing.Point(398, 14)
        Me.btnModificarSubR.Name = "btnModificarSubR"
        Me.btnModificarSubR.Size = New System.Drawing.Size(118, 35)
        Me.btnModificarSubR.TabIndex = 74
        Me.btnModificarSubR.Text = "      Modificar"
        Me.btnModificarSubR.UseVisualStyleBackColor = False
        '
        'btnEliminarRub
        '
        Me.btnEliminarRub.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnEliminarRub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarRub.FlatAppearance.BorderSize = 0
        Me.btnEliminarRub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnEliminarRub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarRub.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRub.ForeColor = System.Drawing.Color.White
        Me.btnEliminarRub.Image = Global.Presentacion.My.Resources.Resources.IconoBorrarRecortado
        Me.btnEliminarRub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarRub.Location = New System.Drawing.Point(528, 14)
        Me.btnEliminarRub.Name = "btnEliminarRub"
        Me.btnEliminarRub.Size = New System.Drawing.Size(118, 35)
        Me.btnEliminarRub.TabIndex = 70
        Me.btnEliminarRub.Text = "      Eliminar"
        Me.btnEliminarRub.UseVisualStyleBackColor = False
        '
        'btnNuevoRub
        '
        Me.btnNuevoRub.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNuevoRub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoRub.FlatAppearance.BorderSize = 0
        Me.btnNuevoRub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnNuevoRub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoRub.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoRub.ForeColor = System.Drawing.Color.White
        Me.btnNuevoRub.Image = Global.Presentacion.My.Resources.Resources.IconoNuevoRecortado
        Me.btnNuevoRub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoRub.Location = New System.Drawing.Point(268, 14)
        Me.btnNuevoRub.Name = "btnNuevoRub"
        Me.btnNuevoRub.Size = New System.Drawing.Size(118, 35)
        Me.btnNuevoRub.TabIndex = 1
        Me.btnNuevoRub.Text = "     Nuevo"
        Me.btnNuevoRub.UseVisualStyleBackColor = False
        '
        'btnModificarRub
        '
        Me.btnModificarRub.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnModificarRub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarRub.FlatAppearance.BorderSize = 0
        Me.btnModificarRub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnModificarRub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarRub.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarRub.ForeColor = System.Drawing.Color.White
        Me.btnModificarRub.Image = Global.Presentacion.My.Resources.Resources.IconoModificarRecortado1
        Me.btnModificarRub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarRub.Location = New System.Drawing.Point(398, 14)
        Me.btnModificarRub.Name = "btnModificarRub"
        Me.btnModificarRub.Size = New System.Drawing.Size(118, 35)
        Me.btnModificarRub.TabIndex = 67
        Me.btnModificarRub.Text = "      Modificar"
        Me.btnModificarRub.UseVisualStyleBackColor = False
        '
        'btnElipNuevoR
        '
        Me.btnElipNuevoR.ElipseRadius = 7
        Me.btnElipNuevoR.TargetControl = Me.btnNuevoRub
        '
        'btnElipModR
        '
        Me.btnElipModR.ElipseRadius = 7
        Me.btnElipModR.TargetControl = Me.btnModificarRub
        '
        'btnElipGuardar
        '
        Me.btnElipGuardar.ElipseRadius = 7
        Me.btnElipGuardar.TargetControl = Me.btnGuardar
        '
        'bnfElipCanc
        '
        Me.bnfElipCanc.ElipseRadius = 7
        Me.bnfElipCanc.TargetControl = Me.btnCancelar
        '
        'bnfElipElimR
        '
        Me.bnfElipElimR.ElipseRadius = 7
        Me.bnfElipElimR.TargetControl = Me.btnEliminarSubR
        '
        'bnfElipNuevoSubR
        '
        Me.bnfElipNuevoSubR.ElipseRadius = 7
        Me.bnfElipNuevoSubR.TargetControl = Me.btnNuevoSubR
        '
        'bnfElipModSubR
        '
        Me.bnfElipModSubR.ElipseRadius = 7
        Me.bnfElipModSubR.TargetControl = Me.btnModificarSubR
        '
        'bnfElipElimSubR
        '
        Me.bnfElipElimSubR.ElipseRadius = 7
        Me.bnfElipElimSubR.TargetControl = Me.btnEliminarRub
        '
        'pnlFrmCategorias
        '
        Me.pnlFrmCategorias.AutoScroll = True
        Me.pnlFrmCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmCategorias.Controls.Add(Me.bnfCardDatos)
        Me.pnlFrmCategorias.Controls.Add(Me.BunifuCards4)
        Me.pnlFrmCategorias.Controls.Add(Me.BunifuCards3)
        Me.pnlFrmCategorias.Controls.Add(Me.bnfListRubros)
        Me.pnlFrmCategorias.Controls.Add(Me.bnfListSubRubros)
        Me.pnlFrmCategorias.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmCategorias.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmCategorias.Controls.Add(Me.BunifuCards2)
        Me.pnlFrmCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmCategorias.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmCategorias.Name = "pnlFrmCategorias"
        Me.pnlFrmCategorias.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmCategorias.TabIndex = 60
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.btnNuevoSubR)
        Me.BunifuCards4.Controls.Add(Me.btnModificarSubR)
        Me.BunifuCards4.Controls.Add(Me.btnEliminarSubR)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(681, 143)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(660, 61)
        Me.BunifuCards4.TabIndex = 85
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.btnNuevoRub)
        Me.BunifuCards3.Controls.Add(Me.btnModificarRub)
        Me.BunifuCards3.Controls.Add(Me.btnEliminarRub)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(11, 143)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(660, 61)
        Me.BunifuCards3.TabIndex = 84
        '
        'bnfListRubros
        '
        Me.bnfListRubros.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfListRubros.BorderRadius = 5
        Me.bnfListRubros.BottomSahddow = True
        Me.bnfListRubros.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfListRubros.Controls.Add(Me.BunifuCards6)
        Me.bnfListRubros.Controls.Add(Me.dgvRubros)
        Me.bnfListRubros.LeftSahddow = False
        Me.bnfListRubros.Location = New System.Drawing.Point(11, 210)
        Me.bnfListRubros.Name = "bnfListRubros"
        Me.bnfListRubros.RightSahddow = True
        Me.bnfListRubros.ShadowDepth = 20
        Me.bnfListRubros.Size = New System.Drawing.Size(660, 538)
        Me.bnfListRubros.TabIndex = 62
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.Label4)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(646, 33)
        Me.BunifuCards6.TabIndex = 110
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(487, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RUBROS CARGADOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvRubros
        '
        Me.dgvRubros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRubros.Location = New System.Drawing.Point(9, 43)
        Me.dgvRubros.Name = "dgvRubros"
        Me.dgvRubros.Size = New System.Drawing.Size(640, 484)
        Me.dgvRubros.TabIndex = 50
        '
        'bnfListSubRubros
        '
        Me.bnfListSubRubros.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfListSubRubros.BorderRadius = 5
        Me.bnfListSubRubros.BottomSahddow = True
        Me.bnfListSubRubros.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfListSubRubros.Controls.Add(Me.BunifuCards5)
        Me.bnfListSubRubros.Controls.Add(Me.dgvSubRubros)
        Me.bnfListSubRubros.LeftSahddow = False
        Me.bnfListSubRubros.Location = New System.Drawing.Point(681, 210)
        Me.bnfListSubRubros.Name = "bnfListSubRubros"
        Me.bnfListSubRubros.RightSahddow = True
        Me.bnfListSubRubros.ShadowDepth = 20
        Me.bnfListSubRubros.Size = New System.Drawing.Size(660, 538)
        Me.bnfListSubRubros.TabIndex = 63
        '
        'BunifuCards5
        '
        Me.BunifuCards5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards5.BorderRadius = 5
        Me.BunifuCards5.BottomSahddow = True
        Me.BunifuCards5.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards5.Controls.Add(Me.Label5)
        Me.BunifuCards5.LeftSahddow = False
        Me.BunifuCards5.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = True
        Me.BunifuCards5.ShadowDepth = 20
        Me.BunifuCards5.Size = New System.Drawing.Size(646, 33)
        Me.BunifuCards5.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(487, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SUB RUBROS CARGADOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvSubRubros
        '
        Me.dgvSubRubros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvSubRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubRubros.Location = New System.Drawing.Point(9, 43)
        Me.dgvSubRubros.Name = "dgvSubRubros"
        Me.dgvSubRubros.Size = New System.Drawing.Size(640, 484)
        Me.dgvSubRubros.TabIndex = 50
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.pnlRubro)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(11, 41)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(660, 96)
        Me.BunifuCards1.TabIndex = 82
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.pnlSubRubro)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(681, 41)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(660, 96)
        Me.BunifuCards2.TabIndex = 83
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'frmcategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmCategorias)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentacion"
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardDatos.ResumeLayout(False)
        Me.pnlRubro.ResumeLayout(False)
        Me.pnlRubro.PerformLayout()
        Me.pnlSubRubro.ResumeLayout(False)
        Me.pnlSubRubro.PerformLayout()
        Me.pnlFrmCategorias.ResumeLayout(False)
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        Me.bnfListRubros.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        CType(Me.dgvRubros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfListSubRubros.ResumeLayout(False)
        Me.BunifuCards5.ResumeLayout(False)
        CType(Me.dgvSubRubros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents txtRubroAnt As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtIdSubRubro As TextBox
    Friend WithEvents txtIdRubro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSubrubro As TextBox
    Friend WithEvents V As Label
    Friend WithEvents bnfCardDatos As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnEliminarRub As Button
    Friend WithEvents btnNuevoRub As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificarRub As Button
    Friend WithEvents btnElipNuevoR As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnElipModR As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnElipGuardar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipElimR As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnEliminarSubR As Button
    Friend WithEvents btnNuevoSubR As Button
    Friend WithEvents btnModificarSubR As Button
    Friend WithEvents cmbRubro As ComboBox
    Friend WithEvents bnfElipNuevoSubR As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipModSubR As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipElimSubR As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtAbrevSub As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAbrevRub As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAbAnt As TextBox
    Friend WithEvents pnlRubro As Panel
    Friend WithEvents pnlSubRubro As Panel
    Friend WithEvents txtRubro As TextBox
    Friend WithEvents txtSubRubAnt As TextBox
    Friend WithEvents pnlFrmCategorias As Panel
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents bnfListRubros As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvRubros As DataGridView
    Friend WithEvents bnfListSubRubros As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvSubRubros As DataGridView
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label5 As Label
End Class
