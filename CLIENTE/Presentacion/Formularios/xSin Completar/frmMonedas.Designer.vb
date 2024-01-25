<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonedas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonedas))
        Me.bnfElipNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.bnfElipModif = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.bnfElipGuardar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.bnfElipCancelar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.bnfListRubros = New Bunifu.Framework.UI.BunifuCards()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvMonedas = New System.Windows.Forms.DataGridView()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.txtNombreAnt = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtIdUsuario = New System.Windows.Forms.TextBox()
        Me.txtIdPerfil = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bnfCardDatos = New Bunifu.Framework.UI.BunifuCards()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCotizacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSimbolo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.bnfElipElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfListRubros.SuspendLayout()
        CType(Me.dgvMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardDatos.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnfElipNuevo
        '
        Me.bnfElipNuevo.ElipseRadius = 7
        Me.bnfElipNuevo.TargetControl = Me.btnNuevo
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.Presentacion.My.Resources.Resources.IconoNuevoRecortado
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(12, 125)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 35)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "     Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'bnfElipModif
        '
        Me.bnfElipModif.ElipseRadius = 7
        Me.bnfElipModif.TargetControl = Me.btnModificar
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = Global.Presentacion.My.Resources.Resources.IconoModificarRecortado1
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(148, 125)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 35)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "      Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'bnfElipGuardar
        '
        Me.bnfElipGuardar.ElipseRadius = 7
        Me.bnfElipGuardar.TargetControl = Me.btnGuardar
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
        Me.btnGuardar.Location = New System.Drawing.Point(283, 125)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 35)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "        Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'bnfElipCancelar
        '
        Me.bnfElipCancelar.ElipseRadius = 7
        Me.bnfElipCancelar.TargetControl = Me.btnCancelar
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
        Me.btnCancelar.Location = New System.Drawing.Point(419, 125)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 35)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "      Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'bnfListRubros
        '
        Me.bnfListRubros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnfListRubros.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfListRubros.BorderRadius = 5
        Me.bnfListRubros.BottomSahddow = True
        Me.bnfListRubros.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfListRubros.Controls.Add(Me.Label7)
        Me.bnfListRubros.Controls.Add(Me.dgvMonedas)
        Me.bnfListRubros.Controls.Add(Me.ShapeContainer2)
        Me.bnfListRubros.LeftSahddow = False
        Me.bnfListRubros.Location = New System.Drawing.Point(7, 219)
        Me.bnfListRubros.Name = "bnfListRubros"
        Me.bnfListRubros.RightSahddow = True
        Me.bnfListRubros.ShadowDepth = 20
        Me.bnfListRubros.Size = New System.Drawing.Size(835, 242)
        Me.bnfListRubros.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(15, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 23)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "LISTADO DE MONEDAS"
        '
        'dgvMonedas
        '
        Me.dgvMonedas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMonedas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonedas.Location = New System.Drawing.Point(12, 50)
        Me.dgvMonedas.Name = "dgvMonedas"
        Me.dgvMonedas.Size = New System.Drawing.Size(809, 179)
        Me.dgvMonedas.TabIndex = 50
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(835, 242)
        Me.ShapeContainer2.TabIndex = 55
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape3.BorderColor = System.Drawing.Color.DarkGray
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 9
        Me.LineShape3.X2 = 819
        Me.LineShape3.Y1 = 38
        Me.LineShape3.Y2 = 38
        '
        'BunifuCards3
        '
        Me.BunifuCards3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.pbxSalir)
        Me.BunifuCards3.Controls.Add(Me.txtNombreAnt)
        Me.BunifuCards3.Controls.Add(Me.txtOrigen)
        Me.BunifuCards3.Controls.Add(Me.txtIdUsuario)
        Me.BunifuCards3.Controls.Add(Me.txtIdPerfil)
        Me.BunifuCards3.Controls.Add(Me.lblTitulo)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(0, 1)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(848, 35)
        Me.BunifuCards3.TabIndex = 63
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(806, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'txtNombreAnt
        '
        Me.txtNombreAnt.BackColor = System.Drawing.Color.Red
        Me.txtNombreAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreAnt.Enabled = False
        Me.txtNombreAnt.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAnt.ForeColor = System.Drawing.Color.White
        Me.txtNombreAnt.Location = New System.Drawing.Point(442, 11)
        Me.txtNombreAnt.Name = "txtNombreAnt"
        Me.txtNombreAnt.Size = New System.Drawing.Size(68, 25)
        Me.txtNombreAnt.TabIndex = 63
        Me.txtNombreAnt.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(664, 11)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 62
        Me.txtOrigen.Visible = False
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.BackColor = System.Drawing.Color.Red
        Me.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdUsuario.Enabled = False
        Me.txtIdUsuario.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdUsuario.ForeColor = System.Drawing.Color.White
        Me.txtIdUsuario.Location = New System.Drawing.Point(590, 11)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.Size = New System.Drawing.Size(68, 25)
        Me.txtIdUsuario.TabIndex = 61
        Me.txtIdUsuario.Visible = False
        '
        'txtIdPerfil
        '
        Me.txtIdPerfil.BackColor = System.Drawing.Color.Red
        Me.txtIdPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdPerfil.Enabled = False
        Me.txtIdPerfil.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPerfil.ForeColor = System.Drawing.Color.White
        Me.txtIdPerfil.Location = New System.Drawing.Point(516, 11)
        Me.txtIdPerfil.Name = "txtIdPerfil"
        Me.txtIdPerfil.Size = New System.Drawing.Size(68, 25)
        Me.txtIdPerfil.TabIndex = 60
        Me.txtIdPerfil.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(8, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(768, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "ALTAS DE MONEDAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfCardDatos
        '
        Me.bnfCardDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnfCardDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardDatos.BorderRadius = 5
        Me.bnfCardDatos.BottomSahddow = True
        Me.bnfCardDatos.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDatos.Controls.Add(Me.pnlDatos)
        Me.bnfCardDatos.Controls.Add(Me.btnEliminar)
        Me.bnfCardDatos.Controls.Add(Me.btnNuevo)
        Me.bnfCardDatos.Controls.Add(Me.btnGuardar)
        Me.bnfCardDatos.Controls.Add(Me.btnCancelar)
        Me.bnfCardDatos.Controls.Add(Me.btnModificar)
        Me.bnfCardDatos.Controls.Add(Me.ShapeContainer3)
        Me.bnfCardDatos.LeftSahddow = False
        Me.bnfCardDatos.Location = New System.Drawing.Point(7, 44)
        Me.bnfCardDatos.Name = "bnfCardDatos"
        Me.bnfCardDatos.RightSahddow = True
        Me.bnfCardDatos.ShadowDepth = 20
        Me.bnfCardDatos.Size = New System.Drawing.Size(835, 169)
        Me.bnfCardDatos.TabIndex = 64
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.Label2)
        Me.pnlDatos.Controls.Add(Me.txtCotizacion)
        Me.pnlDatos.Controls.Add(Me.Label4)
        Me.pnlDatos.Controls.Add(Me.txtSimbolo)
        Me.pnlDatos.Controls.Add(Me.Label5)
        Me.pnlDatos.Controls.Add(Me.Label3)
        Me.pnlDatos.Controls.Add(Me.txtMoneda)
        Me.pnlDatos.Location = New System.Drawing.Point(8, 10)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(799, 102)
        Me.pnlDatos.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "MONEDA"
        '
        'txtCotizacion
        '
        Me.txtCotizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCotizacion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCotizacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCotizacion.Location = New System.Drawing.Point(168, 68)
        Me.txtCotizacion.MaxLength = 254
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.Size = New System.Drawing.Size(86, 25)
        Me.txtCotizacion.TabIndex = 3
        Me.txtCotizacion.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(2, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "SIMBOLO"
        '
        'txtSimbolo
        '
        Me.txtSimbolo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSimbolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSimbolo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimbolo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSimbolo.Location = New System.Drawing.Point(169, 37)
        Me.txtSimbolo.MaxLength = 254
        Me.txtSimbolo.Name = "txtSimbolo"
        Me.txtSimbolo.Size = New System.Drawing.Size(85, 25)
        Me.txtSimbolo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(3, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "COTIZACION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(268, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Paridad con el Peso Argentino"
        '
        'txtMoneda
        '
        Me.txtMoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtMoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMoneda.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtMoneda.Location = New System.Drawing.Point(169, 6)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(313, 25)
        Me.txtMoneda.TabIndex = 25
        Me.txtMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.IconoBorrarRecortado
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(556, 125)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 35)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "      Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape8})
        Me.ShapeContainer3.Size = New System.Drawing.Size(835, 169)
        Me.ShapeContainer3.TabIndex = 38
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.DarkGray
        Me.LineShape8.BorderWidth = 2
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 4
        Me.LineShape8.X2 = 830
        Me.LineShape8.Y1 = 117
        Me.LineShape8.Y2 = 117
        '
        'bnfElipElim
        '
        Me.bnfElipElim.ElipseRadius = 7
        Me.bnfElipElim.TargetControl = Me.btnEliminar
        '
        'frmMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(850, 473)
        Me.Controls.Add(Me.bnfCardDatos)
        Me.Controls.Add(Me.bnfListRubros)
        Me.Controls.Add(Me.BunifuCards3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMonedas"
        Me.Text = "frmMonedas"
        Me.bnfListRubros.ResumeLayout(False)
        CType(Me.dgvMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardDatos.ResumeLayout(False)
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bnfElipNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipModif As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipGuardar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipCancelar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfListRubros As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvMonedas As DataGridView
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents txtNombreAnt As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtIdUsuario As TextBox
    Friend WithEvents txtIdPerfil As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents bnfCardDatos As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape8 As PowerPacks.LineShape
    Friend WithEvents bnfElipElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCotizacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSimbolo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMoneda As TextBox
End Class
