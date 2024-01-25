<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChequeras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeras))
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtIdChq = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.pnlFrmEmpresa = New System.Windows.Forms.Panel()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.bnfListComp = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvChq = New System.Windows.Forms.DataGridView()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtCantAn = New System.Windows.Forms.TextBox()
        Me.txtCantEm = New System.Windows.Forms.TextBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfCardDatos = New Bunifu.Framework.UI.BunifuCards()
        Me.pnlContendorDatos = New System.Windows.Forms.Panel()
        Me.txtNroCta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChqCant = New System.Windows.Forms.TextBox()
        Me.cbxBanco = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNroChq = New System.Windows.Forms.TextBox()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipCarg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBorr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfElipCateg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrmEmpresa.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.bnfListComp.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvChq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardDatos.SuspendLayout()
        Me.pnlContendorDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnfElpNuevo
        '
        Me.bnfElpNuevo.ElipseRadius = 7
        Me.bnfElpNuevo.TargetControl = Me.btnNuevo
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
        'txtIdChq
        '
        Me.txtIdChq.BackColor = System.Drawing.Color.Red
        Me.txtIdChq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdChq.Enabled = False
        Me.txtIdChq.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdChq.ForeColor = System.Drawing.Color.White
        Me.txtIdChq.Location = New System.Drawing.Point(625, 5)
        Me.txtIdChq.Name = "txtIdChq"
        Me.txtIdChq.Size = New System.Drawing.Size(68, 25)
        Me.txtIdChq.TabIndex = 64
        Me.txtIdChq.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(709, 4)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 63
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
        Me.lblTitulo.Size = New System.Drawing.Size(1021, 35)
        Me.lblTitulo.TabIndex = 76
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoChequera
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 77
        Me.pbxTitulo.TabStop = False
        '
        'pnlFrmEmpresa
        '
        Me.pnlFrmEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmEmpresa.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfListComp)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfCardDatos)
        Me.pnlFrmEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmEmpresa.Name = "pnlFrmEmpresa"
        Me.pnlFrmEmpresa.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmEmpresa.TabIndex = 61
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.btnNuevo)
        Me.BunifuCards1.Controls.Add(Me.btnEliminar)
        Me.BunifuCards1.Controls.Add(Me.btnModificar)
        Me.BunifuCards1.Controls.Add(Me.btnCancelar)
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
        'bnfListComp
        '
        Me.bnfListComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfListComp.BorderRadius = 5
        Me.bnfListComp.BottomSahddow = True
        Me.bnfListComp.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfListComp.Controls.Add(Me.BunifuCards6)
        Me.bnfListComp.Controls.Add(Me.dgvChq)
        Me.bnfListComp.LeftSahddow = False
        Me.bnfListComp.Location = New System.Drawing.Point(11, 261)
        Me.bnfListComp.Name = "bnfListComp"
        Me.bnfListComp.RightSahddow = True
        Me.bnfListComp.ShadowDepth = 20
        Me.bnfListComp.Size = New System.Drawing.Size(1330, 485)
        Me.bnfListComp.TabIndex = 61
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.Label2)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(1316, 33)
        Me.BunifuCards6.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(487, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CHEQUERAS CARGADAS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvChq
        '
        Me.dgvChq.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvChq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChq.Location = New System.Drawing.Point(9, 43)
        Me.dgvChq.Name = "dgvChq"
        Me.dgvChq.Size = New System.Drawing.Size(1310, 430)
        Me.dgvChq.TabIndex = 10
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtCantAn)
        Me.bnfCardTitulo.Controls.Add(Me.txtCantEm)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdChq)
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = True
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTitulo.TabIndex = 55
        '
        'txtCantAn
        '
        Me.txtCantAn.BackColor = System.Drawing.Color.Red
        Me.txtCantAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantAn.Enabled = False
        Me.txtCantAn.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantAn.ForeColor = System.Drawing.Color.White
        Me.txtCantAn.Location = New System.Drawing.Point(867, 5)
        Me.txtCantAn.Name = "txtCantAn"
        Me.txtCantAn.Size = New System.Drawing.Size(68, 25)
        Me.txtCantAn.TabIndex = 65
        Me.txtCantAn.Visible = False
        '
        'txtCantEm
        '
        Me.txtCantEm.BackColor = System.Drawing.Color.Red
        Me.txtCantEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantEm.Enabled = False
        Me.txtCantEm.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantEm.ForeColor = System.Drawing.Color.White
        Me.txtCantEm.Location = New System.Drawing.Point(783, 4)
        Me.txtCantEm.Name = "txtCantEm"
        Me.txtCantEm.Size = New System.Drawing.Size(68, 25)
        Me.txtCantEm.TabIndex = 66
        Me.txtCantEm.Visible = False
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
        'bnfCardDatos
        '
        Me.bnfCardDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDatos.BorderRadius = 5
        Me.bnfCardDatos.BottomSahddow = True
        Me.bnfCardDatos.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDatos.Controls.Add(Me.pnlContendorDatos)
        Me.bnfCardDatos.LeftSahddow = False
        Me.bnfCardDatos.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardDatos.Name = "bnfCardDatos"
        Me.bnfCardDatos.RightSahddow = True
        Me.bnfCardDatos.ShadowDepth = 20
        Me.bnfCardDatos.Size = New System.Drawing.Size(1330, 214)
        Me.bnfCardDatos.TabIndex = 53
        '
        'pnlContendorDatos
        '
        Me.pnlContendorDatos.Controls.Add(Me.txtNroCta)
        Me.pnlContendorDatos.Controls.Add(Me.Label1)
        Me.pnlContendorDatos.Controls.Add(Me.txtChqCant)
        Me.pnlContendorDatos.Controls.Add(Me.cbxBanco)
        Me.pnlContendorDatos.Controls.Add(Me.Label11)
        Me.pnlContendorDatos.Controls.Add(Me.Label16)
        Me.pnlContendorDatos.Controls.Add(Me.Label3)
        Me.pnlContendorDatos.Controls.Add(Me.txtFecha)
        Me.pnlContendorDatos.Controls.Add(Me.Label13)
        Me.pnlContendorDatos.Controls.Add(Me.txtNroChq)
        Me.pnlContendorDatos.Controls.Add(Me.txtObserv)
        Me.pnlContendorDatos.Controls.Add(Me.Label10)
        Me.pnlContendorDatos.Location = New System.Drawing.Point(7, 5)
        Me.pnlContendorDatos.Name = "pnlContendorDatos"
        Me.pnlContendorDatos.Size = New System.Drawing.Size(841, 204)
        Me.pnlContendorDatos.TabIndex = 55
        '
        'txtNroCta
        '
        Me.txtNroCta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroCta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroCta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroCta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroCta.Location = New System.Drawing.Point(167, 41)
        Me.txtNroCta.MaxLength = 10
        Me.txtNroCta.Name = "txtNroCta"
        Me.txtNroCta.Size = New System.Drawing.Size(156, 25)
        Me.txtNroCta.TabIndex = 74
        Me.txtNroCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "NUMERO CUENTA"
        '
        'txtChqCant
        '
        Me.txtChqCant.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtChqCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChqCant.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqCant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtChqCant.Location = New System.Drawing.Point(167, 139)
        Me.txtChqCant.MaxLength = 254
        Me.txtChqCant.Name = "txtChqCant"
        Me.txtChqCant.Size = New System.Drawing.Size(156, 25)
        Me.txtChqCant.TabIndex = 3
        Me.txtChqCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxBanco
        '
        Me.cbxBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbxBanco.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cbxBanco.FormattingEnabled = True
        Me.cbxBanco.Location = New System.Drawing.Point(167, 72)
        Me.cbxBanco.MaxLength = 254
        Me.cbxBanco.Name = "cbxBanco"
        Me.cbxBanco.Size = New System.Drawing.Size(249, 28)
        Me.cbxBanco.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(6, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 18)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "CANTIDAD CHEQUES"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(6, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 18)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "BANCO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "FECHA ALTA"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(167, 10)
        Me.txtFecha.MaxLength = 254
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(156, 25)
        Me.txtFecha.TabIndex = 0
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(6, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "OBSERVACIONES"
        '
        'txtNroChq
        '
        Me.txtNroChq.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroChq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroChq.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroChq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroChq.Location = New System.Drawing.Point(167, 108)
        Me.txtNroChq.MaxLength = 10
        Me.txtNroChq.Name = "txtNroChq"
        Me.txtNroChq.Size = New System.Drawing.Size(156, 25)
        Me.txtNroChq.TabIndex = 2
        Me.txtNroChq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObserv
        '
        Me.txtObserv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtObserv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObserv.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObserv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtObserv.Location = New System.Drawing.Point(167, 170)
        Me.txtObserv.MaxLength = 254
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.Size = New System.Drawing.Size(662, 25)
        Me.txtObserv.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(6, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 18)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "NRO INICIAL CHEQUE"
        '
        'bnfElpMod
        '
        Me.bnfElpMod.ElipseRadius = 7
        Me.bnfElpMod.TargetControl = Me.btnModificar
        '
        'bnfElpCanc
        '
        Me.bnfElpCanc.ElipseRadius = 7
        Me.bnfElpCanc.TargetControl = Me.btnCancelar
        '
        'bnfElipCarg
        '
        Me.bnfElipCarg.ElipseRadius = 7
        Me.bnfElipCarg.TargetControl = Me
        '
        'bnfElipBorr
        '
        Me.bnfElipBorr.ElipseRadius = 7
        Me.bnfElipBorr.TargetControl = Me
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
        'bnfElipCateg
        '
        Me.bnfElipCateg.ElipseRadius = 7
        Me.bnfElipCateg.TargetControl = Me
        '
        'bnfElpGuar
        '
        Me.bnfElpGuar.ElipseRadius = 7
        Me.bnfElpGuar.TargetControl = Me.btnGuardar
        '
        'frmChequeras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmEmpresa)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChequeras"
        Me.Text = "chqChequeras"
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrmEmpresa.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.bnfListComp.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        CType(Me.dgvChq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardDatos.ResumeLayout(False)
        Me.pnlContendorDatos.ResumeLayout(False)
        Me.pnlContendorDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtIdChq As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents pnlFrmEmpresa As Panel
    Friend WithEvents bnfListComp As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvChq As DataGridView
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfCardDatos As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pnlContendorDatos As Panel
    Friend WithEvents txtChqCant As TextBox
    Friend WithEvents cbxBanco As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNroChq As TextBox
    Friend WithEvents txtObserv As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipCarg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipBorr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ofdImagen As OpenFileDialog
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents bnfElipCateg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtCantEm As TextBox
    Friend WithEvents txtCantAn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNroCta As TextBox
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
