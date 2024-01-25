<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeposito))
        Me.pnlFrmDepositos = New System.Windows.Forms.Panel()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.bnfCardTituloFrm = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.txtIdDeposito = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfCardList = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvDepositos = New System.Windows.Forms.DataGridView()
        Me.bnfCardDatos = New Bunifu.Framework.UI.BunifuCards()
        Me.pnlContendor = New System.Windows.Forms.Panel()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFrmDepositos.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.bnfCardTituloFrm.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardList.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardDatos.SuspendLayout()
        Me.pnlContendor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFrmDepositos
        '
        Me.pnlFrmDepositos.AutoScroll = True
        Me.pnlFrmDepositos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmDepositos.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmDepositos.Controls.Add(Me.bnfCardTituloFrm)
        Me.pnlFrmDepositos.Controls.Add(Me.bnfCardList)
        Me.pnlFrmDepositos.Controls.Add(Me.bnfCardDatos)
        Me.pnlFrmDepositos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmDepositos.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmDepositos.Name = "pnlFrmDepositos"
        Me.pnlFrmDepositos.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmDepositos.TabIndex = 61
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.btnEliminar)
        Me.BunifuCards1.Controls.Add(Me.btnCancelar)
        Me.BunifuCards1.Controls.Add(Me.btnNuevo)
        Me.BunifuCards1.Controls.Add(Me.btnModificar)
        Me.BunifuCards1.Controls.Add(Me.btnGuardar)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(651, 752)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(690, 61)
        Me.BunifuCards1.TabIndex = 110
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
        Me.btnEliminar.Location = New System.Drawing.Point(559, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 35)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "      Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(422, 15)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 35)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "      Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(15, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 35)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "     Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnModificar.Location = New System.Drawing.Point(151, 15)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 35)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "      Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(286, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 35)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "        Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'bnfCardTituloFrm
        '
        Me.bnfCardTituloFrm.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTituloFrm.BorderRadius = 0
        Me.bnfCardTituloFrm.BottomSahddow = True
        Me.bnfCardTituloFrm.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTituloFrm.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTituloFrm.Controls.Add(Me.txtIdDeposito)
        Me.bnfCardTituloFrm.Controls.Add(Me.txtOrigen)
        Me.bnfCardTituloFrm.Controls.Add(Me.lblTitulo)
        Me.bnfCardTituloFrm.Controls.Add(Me.pbxSalir)
        Me.bnfCardTituloFrm.LeftSahddow = False
        Me.bnfCardTituloFrm.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTituloFrm.Name = "bnfCardTituloFrm"
        Me.bnfCardTituloFrm.RightSahddow = True
        Me.bnfCardTituloFrm.ShadowDepth = 20
        Me.bnfCardTituloFrm.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTituloFrm.TabIndex = 56
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoDeposito
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 67
        Me.pbxTitulo.TabStop = False
        '
        'txtIdDeposito
        '
        Me.txtIdDeposito.BackColor = System.Drawing.Color.Red
        Me.txtIdDeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdDeposito.Enabled = False
        Me.txtIdDeposito.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDeposito.ForeColor = System.Drawing.Color.White
        Me.txtIdDeposito.Location = New System.Drawing.Point(895, 10)
        Me.txtIdDeposito.Name = "txtIdDeposito"
        Me.txtIdDeposito.Size = New System.Drawing.Size(68, 25)
        Me.txtIdDeposito.TabIndex = 65
        Me.txtIdDeposito.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(969, 10)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 62
        Me.txtOrigen.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(995, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'bnfCardList
        '
        Me.bnfCardList.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardList.BorderRadius = 5
        Me.bnfCardList.BottomSahddow = True
        Me.bnfCardList.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardList.Controls.Add(Me.BunifuCards6)
        Me.bnfCardList.Controls.Add(Me.dgvDepositos)
        Me.bnfCardList.LeftSahddow = False
        Me.bnfCardList.Location = New System.Drawing.Point(11, 230)
        Me.bnfCardList.Name = "bnfCardList"
        Me.bnfCardList.RightSahddow = True
        Me.bnfCardList.ShadowDepth = 20
        Me.bnfCardList.Size = New System.Drawing.Size(1330, 516)
        Me.bnfCardList.TabIndex = 58
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.Label1)
        Me.BunifuCards6.Controls.Add(Me.txtBuscar)
        Me.BunifuCards6.Controls.Add(Me.Label9)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(1316, 49)
        Me.BunifuCards6.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(801, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "BUSCAR"
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(863, 11)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(440, 25)
        Me.txtBuscar.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(487, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "DEPOSITOS CARGADOS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDepositos
        '
        Me.dgvDepositos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepositos.Location = New System.Drawing.Point(9, 59)
        Me.dgvDepositos.Name = "dgvDepositos"
        Me.dgvDepositos.Size = New System.Drawing.Size(1310, 445)
        Me.dgvDepositos.TabIndex = 50
        '
        'bnfCardDatos
        '
        Me.bnfCardDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDatos.BorderRadius = 5
        Me.bnfCardDatos.BottomSahddow = True
        Me.bnfCardDatos.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDatos.Controls.Add(Me.pnlContendor)
        Me.bnfCardDatos.LeftSahddow = False
        Me.bnfCardDatos.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardDatos.Name = "bnfCardDatos"
        Me.bnfCardDatos.RightSahddow = True
        Me.bnfCardDatos.ShadowDepth = 20
        Me.bnfCardDatos.Size = New System.Drawing.Size(1330, 183)
        Me.bnfCardDatos.TabIndex = 57
        '
        'pnlContendor
        '
        Me.pnlContendor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContendor.Controls.Add(Me.txtProvincia)
        Me.pnlContendor.Controls.Add(Me.txtDireccion)
        Me.pnlContendor.Controls.Add(Me.txtNombre)
        Me.pnlContendor.Controls.Add(Me.Label3)
        Me.pnlContendor.Controls.Add(Me.txtLocalidad)
        Me.pnlContendor.Controls.Add(Me.txtCP)
        Me.pnlContendor.Controls.Add(Me.Label4)
        Me.pnlContendor.Controls.Add(Me.Label8)
        Me.pnlContendor.Controls.Add(Me.Label5)
        Me.pnlContendor.Controls.Add(Me.Label2)
        Me.pnlContendor.Location = New System.Drawing.Point(7, 3)
        Me.pnlContendor.Name = "pnlContendor"
        Me.pnlContendor.Size = New System.Drawing.Size(1271, 175)
        Me.pnlContendor.TabIndex = 55
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtProvincia.Location = New System.Drawing.Point(119, 106)
        Me.txtProvincia.MaxLength = 254
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(471, 25)
        Me.txtProvincia.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(118, 44)
        Me.txtDireccion.MaxLength = 254
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(472, 25)
        Me.txtDireccion.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(118, 13)
        Me.txtNombre.MaxLength = 254
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(472, 25)
        Me.txtNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(7, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "LOCALIDAD"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtLocalidad.Location = New System.Drawing.Point(119, 75)
        Me.txtLocalidad.MaxLength = 254
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(471, 25)
        Me.txtLocalidad.TabIndex = 3
        '
        'txtCP
        '
        Me.txtCP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCP.Location = New System.Drawing.Point(119, 137)
        Me.txtCP.MaxLength = 20
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(109, 25)
        Me.txtCP.TabIndex = 5
        Me.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(7, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "PROVINCIA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(7, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 18)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "DIRECCION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(6, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "COD. POSTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "NOMBRE"
        '
        'bnfElpNuevo
        '
        Me.bnfElpNuevo.ElipseRadius = 7
        Me.bnfElpNuevo.TargetControl = Me.btnNuevo
        '
        'bnfElpMod
        '
        Me.bnfElpMod.ElipseRadius = 7
        Me.bnfElpMod.TargetControl = Me.btnModificar
        '
        'bnfElpGuar
        '
        Me.bnfElpGuar.ElipseRadius = 7
        Me.bnfElpGuar.TargetControl = Me.btnGuardar
        '
        'bnfElpCanc
        '
        Me.bnfElpCanc.ElipseRadius = 7
        Me.bnfElpCanc.TargetControl = Me.btnCancelar
        '
        'bnfElpElim
        '
        Me.bnfElpElim.ElipseRadius = 7
        Me.bnfElpElim.TargetControl = Me.btnEliminar
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'frmDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmDepositos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDeposito"
        Me.Text = "frmDeposito"
        Me.pnlFrmDepositos.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.bnfCardTituloFrm.ResumeLayout(False)
        Me.bnfCardTituloFrm.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardList.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        Me.BunifuCards6.PerformLayout()
        CType(Me.dgvDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardDatos.ResumeLayout(False)
        Me.pnlContendor.ResumeLayout(False)
        Me.pnlContendor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFrmDepositos As Panel
    Friend WithEvents bnfCardTituloFrm As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtIdDeposito As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfCardList As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvDepositos As DataGridView
    Friend WithEvents bnfCardDatos As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pnlContendor As Panel
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
End Class
