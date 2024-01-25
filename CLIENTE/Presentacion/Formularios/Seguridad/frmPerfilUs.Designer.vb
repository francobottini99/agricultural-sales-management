<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPerfilUs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfilUs))
        Me.dgvDetallePerfiles = New System.Windows.Forms.DataGridView()
        Me.dgvListaPerfiles = New System.Windows.Forms.DataGridView()
        Me.bnfCardTirulo = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.bnfCardBtn = New Bunifu.Framework.UI.BunifuCards()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtNombreAnt = New System.Windows.Forms.TextBox()
        Me.txtIdPerfil = New System.Windows.Forms.TextBox()
        Me.bnfCardMod = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvModulos = New System.Windows.Forms.DataGridView()
        Me.Modulos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPerfil = New System.Windows.Forms.DataGridView()
        Me.bnfCardNombre = New Bunifu.Framework.UI.BunifuCards()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpAsg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpQuit = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpAsgT = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpQuitT = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfCardPerf = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bnfCardPerCar = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardDetCar = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDetallePerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTirulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardBtn.SuspendLayout()
        Me.bnfCardMod.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardNombre.SuspendLayout()
        Me.bnfCardPerf.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.bnfCardPerCar.SuspendLayout()
        Me.bnfCardDetCar.SuspendLayout()
        Me.BunifuCards5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDetallePerfiles
        '
        Me.dgvDetallePerfiles.AllowUserToAddRows = False
        Me.dgvDetallePerfiles.AllowUserToDeleteRows = False
        Me.dgvDetallePerfiles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvDetallePerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePerfiles.Location = New System.Drawing.Point(9, 43)
        Me.dgvDetallePerfiles.MultiSelect = False
        Me.dgvDetallePerfiles.Name = "dgvDetallePerfiles"
        Me.dgvDetallePerfiles.ReadOnly = True
        Me.dgvDetallePerfiles.Size = New System.Drawing.Size(640, 248)
        Me.dgvDetallePerfiles.TabIndex = 55
        '
        'dgvListaPerfiles
        '
        Me.dgvListaPerfiles.AllowUserToAddRows = False
        Me.dgvListaPerfiles.AllowUserToDeleteRows = False
        Me.dgvListaPerfiles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvListaPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPerfiles.Location = New System.Drawing.Point(9, 43)
        Me.dgvListaPerfiles.Name = "dgvListaPerfiles"
        Me.dgvListaPerfiles.ReadOnly = True
        Me.dgvListaPerfiles.Size = New System.Drawing.Size(640, 248)
        Me.dgvListaPerfiles.TabIndex = 50
        '
        'bnfCardTirulo
        '
        Me.bnfCardTirulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTirulo.BorderRadius = 0
        Me.bnfCardTirulo.BottomSahddow = True
        Me.bnfCardTirulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTirulo.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTirulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTirulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTirulo.LeftSahddow = False
        Me.bnfCardTirulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTirulo.Name = "bnfCardTirulo"
        Me.bnfCardTirulo.RightSahddow = True
        Me.bnfCardTirulo.ShadowDepth = 20
        Me.bnfCardTirulo.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTirulo.TabIndex = 57
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoPerfilUsuario
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 85
        Me.pbxTitulo.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(975, 35)
        Me.lblTitulo.TabIndex = 84
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
        'bnfCardBtn
        '
        Me.bnfCardBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardBtn.BorderRadius = 5
        Me.bnfCardBtn.BottomSahddow = True
        Me.bnfCardBtn.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardBtn.Controls.Add(Me.btnEliminar)
        Me.bnfCardBtn.Controls.Add(Me.btnNuevo)
        Me.bnfCardBtn.Controls.Add(Me.btnGuardar)
        Me.bnfCardBtn.Controls.Add(Me.btnCancelar)
        Me.bnfCardBtn.Controls.Add(Me.btnModificar)
        Me.bnfCardBtn.LeftSahddow = False
        Me.bnfCardBtn.Location = New System.Drawing.Point(651, 752)
        Me.bnfCardBtn.Name = "bnfCardBtn"
        Me.bnfCardBtn.RightSahddow = True
        Me.bnfCardBtn.ShadowDepth = 20
        Me.bnfCardBtn.Size = New System.Drawing.Size(690, 61)
        Me.bnfCardBtn.TabIndex = 53
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
        Me.btnEliminar.TabIndex = 41
        Me.btnEliminar.Text = "       Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.TabIndex = 30
        Me.btnNuevo.Text = "      Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
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
        Me.btnGuardar.TabIndex = 31
        Me.btnGuardar.Text = "       Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
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
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "       Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnModificar.TabIndex = 33
        Me.btnModificar.Text = "       Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(743, 13)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 63
        Me.txtOrigen.Visible = False
        '
        'txtNombreAnt
        '
        Me.txtNombreAnt.BackColor = System.Drawing.Color.Red
        Me.txtNombreAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreAnt.Enabled = False
        Me.txtNombreAnt.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAnt.ForeColor = System.Drawing.Color.White
        Me.txtNombreAnt.Location = New System.Drawing.Point(669, 13)
        Me.txtNombreAnt.Name = "txtNombreAnt"
        Me.txtNombreAnt.Size = New System.Drawing.Size(68, 25)
        Me.txtNombreAnt.TabIndex = 60
        Me.txtNombreAnt.Visible = False
        '
        'txtIdPerfil
        '
        Me.txtIdPerfil.BackColor = System.Drawing.Color.Red
        Me.txtIdPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdPerfil.Enabled = False
        Me.txtIdPerfil.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPerfil.ForeColor = System.Drawing.Color.White
        Me.txtIdPerfil.Location = New System.Drawing.Point(595, 13)
        Me.txtIdPerfil.Name = "txtIdPerfil"
        Me.txtIdPerfil.Size = New System.Drawing.Size(68, 25)
        Me.txtIdPerfil.TabIndex = 59
        Me.txtIdPerfil.Visible = False
        '
        'bnfCardMod
        '
        Me.bnfCardMod.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardMod.BorderRadius = 5
        Me.bnfCardMod.BottomSahddow = True
        Me.bnfCardMod.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardMod.Controls.Add(Me.BunifuCards6)
        Me.bnfCardMod.Controls.Add(Me.dgvModulos)
        Me.bnfCardMod.LeftSahddow = False
        Me.bnfCardMod.Location = New System.Drawing.Point(11, 89)
        Me.bnfCardMod.Name = "bnfCardMod"
        Me.bnfCardMod.RightSahddow = True
        Me.bnfCardMod.ShadowDepth = 20
        Me.bnfCardMod.Size = New System.Drawing.Size(660, 348)
        Me.bnfCardMod.TabIndex = 58
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
        Me.BunifuCards6.TabIndex = 111
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
        Me.Label4.Text = "MODULOS DEL SISTEMA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvModulos
        '
        Me.dgvModulos.AllowUserToAddRows = False
        Me.dgvModulos.AllowUserToDeleteRows = False
        Me.dgvModulos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvModulos.ColumnHeadersVisible = False
        Me.dgvModulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Modulos})
        Me.dgvModulos.Location = New System.Drawing.Point(9, 43)
        Me.dgvModulos.Name = "dgvModulos"
        Me.dgvModulos.ReadOnly = True
        Me.dgvModulos.RowHeadersVisible = False
        Me.dgvModulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvModulos.Size = New System.Drawing.Size(640, 294)
        Me.dgvModulos.TabIndex = 55
        '
        'Modulos
        '
        Me.Modulos.Frozen = True
        Me.Modulos.HeaderText = "Modulos"
        Me.Modulos.Name = "Modulos"
        Me.Modulos.ReadOnly = True
        Me.Modulos.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Modulos.Visible = False
        '
        'dgvPerfil
        '
        Me.dgvPerfil.AllowUserToAddRows = False
        Me.dgvPerfil.AllowUserToDeleteRows = False
        Me.dgvPerfil.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerfil.Location = New System.Drawing.Point(9, 43)
        Me.dgvPerfil.MultiSelect = False
        Me.dgvPerfil.Name = "dgvPerfil"
        Me.dgvPerfil.ReadOnly = True
        Me.dgvPerfil.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPerfil.Size = New System.Drawing.Size(640, 294)
        Me.dgvPerfil.TabIndex = 55
        '
        'bnfCardNombre
        '
        Me.bnfCardNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardNombre.BorderRadius = 5
        Me.bnfCardNombre.BottomSahddow = True
        Me.bnfCardNombre.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardNombre.Controls.Add(Me.txtOrigen)
        Me.bnfCardNombre.Controls.Add(Me.txtNombre)
        Me.bnfCardNombre.Controls.Add(Me.Label2)
        Me.bnfCardNombre.Controls.Add(Me.txtNombreAnt)
        Me.bnfCardNombre.Controls.Add(Me.txtIdPerfil)
        Me.bnfCardNombre.Enabled = False
        Me.bnfCardNombre.LeftSahddow = False
        Me.bnfCardNombre.Location = New System.Drawing.Point(11, 38)
        Me.bnfCardNombre.Name = "bnfCardNombre"
        Me.bnfCardNombre.RightSahddow = True
        Me.bnfCardNombre.ShadowDepth = 20
        Me.bnfCardNombre.Size = New System.Drawing.Size(1330, 48)
        Me.bnfCardNombre.TabIndex = 56
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(152, 13)
        Me.txtNombre.MaxLength = 254
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(428, 25)
        Me.txtNombre.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(15, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "NOMBRE DEL PERFIL"
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
        'bnfElpAsg
        '
        Me.bnfElpAsg.ElipseRadius = 7
        Me.bnfElpAsg.TargetControl = Me
        '
        'bnfElpQuit
        '
        Me.bnfElpQuit.ElipseRadius = 7
        Me.bnfElpQuit.TargetControl = Me
        '
        'bnfElpAsgT
        '
        Me.bnfElpAsgT.ElipseRadius = 7
        Me.bnfElpAsgT.TargetControl = Me
        '
        'bnfElpQuitT
        '
        Me.bnfElpQuitT.ElipseRadius = 7
        Me.bnfElpQuitT.TargetControl = Me
        '
        'bnfCardPerf
        '
        Me.bnfCardPerf.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardPerf.BorderRadius = 5
        Me.bnfCardPerf.BottomSahddow = True
        Me.bnfCardPerf.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardPerf.Controls.Add(Me.BunifuCards1)
        Me.bnfCardPerf.Controls.Add(Me.dgvPerfil)
        Me.bnfCardPerf.LeftSahddow = False
        Me.bnfCardPerf.Location = New System.Drawing.Point(681, 89)
        Me.bnfCardPerf.Name = "bnfCardPerf"
        Me.bnfCardPerf.RightSahddow = True
        Me.bnfCardPerf.ShadowDepth = 20
        Me.bnfCardPerf.Size = New System.Drawing.Size(660, 348)
        Me.bnfCardPerf.TabIndex = 59
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(646, 33)
        Me.BunifuCards1.TabIndex = 112
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PERFIL DE USUARIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.Label6)
        Me.BunifuCards2.Controls.Add(Me.Label5)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(646, 33)
        Me.BunifuCards2.TabIndex = 112
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(401, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 18)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "<Click>: Despliega el detalle del Perfil"
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
        Me.Label5.Text = "PERFILES CARGADOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfCardPerCar
        '
        Me.bnfCardPerCar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardPerCar.BorderRadius = 5
        Me.bnfCardPerCar.BottomSahddow = True
        Me.bnfCardPerCar.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardPerCar.Controls.Add(Me.BunifuCards2)
        Me.bnfCardPerCar.Controls.Add(Me.dgvListaPerfiles)
        Me.bnfCardPerCar.LeftSahddow = False
        Me.bnfCardPerCar.Location = New System.Drawing.Point(11, 443)
        Me.bnfCardPerCar.Name = "bnfCardPerCar"
        Me.bnfCardPerCar.RightSahddow = True
        Me.bnfCardPerCar.ShadowDepth = 20
        Me.bnfCardPerCar.Size = New System.Drawing.Size(660, 303)
        Me.bnfCardPerCar.TabIndex = 112
        '
        'bnfCardDetCar
        '
        Me.bnfCardDetCar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDetCar.BorderRadius = 5
        Me.bnfCardDetCar.BottomSahddow = True
        Me.bnfCardDetCar.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDetCar.Controls.Add(Me.dgvDetallePerfiles)
        Me.bnfCardDetCar.Controls.Add(Me.BunifuCards5)
        Me.bnfCardDetCar.LeftSahddow = False
        Me.bnfCardDetCar.Location = New System.Drawing.Point(680, 443)
        Me.bnfCardDetCar.Name = "bnfCardDetCar"
        Me.bnfCardDetCar.RightSahddow = True
        Me.bnfCardDetCar.ShadowDepth = 20
        Me.bnfCardDetCar.Size = New System.Drawing.Size(660, 303)
        Me.bnfCardDetCar.TabIndex = 113
        '
        'BunifuCards5
        '
        Me.BunifuCards5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards5.BorderRadius = 5
        Me.BunifuCards5.BottomSahddow = True
        Me.BunifuCards5.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards5.Controls.Add(Me.Label3)
        Me.BunifuCards5.LeftSahddow = False
        Me.BunifuCards5.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = True
        Me.BunifuCards5.ShadowDepth = 20
        Me.BunifuCards5.Size = New System.Drawing.Size(646, 33)
        Me.BunifuCards5.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(487, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "DETALLE PERFIL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Modulos"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'frmPerfilUs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.bnfCardDetCar)
        Me.Controls.Add(Me.bnfCardPerCar)
        Me.Controls.Add(Me.bnfCardBtn)
        Me.Controls.Add(Me.bnfCardNombre)
        Me.Controls.Add(Me.bnfCardPerf)
        Me.Controls.Add(Me.bnfCardMod)
        Me.Controls.Add(Me.bnfCardTirulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPerfilUs"
        Me.Text = "frmPerfilUs"
        CType(Me.dgvDetallePerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListaPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTirulo.ResumeLayout(False)
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardBtn.ResumeLayout(False)
        Me.bnfCardMod.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        CType(Me.dgvModulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardNombre.ResumeLayout(False)
        Me.bnfCardNombre.PerformLayout()
        Me.bnfCardPerf.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.bnfCardPerCar.ResumeLayout(False)
        Me.bnfCardDetCar.ResumeLayout(False)
        Me.BunifuCards5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvListaPerfiles As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents bnfCardTirulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents ofdImagen As OpenFileDialog
    Friend WithEvents bnfCardBtn As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardMod As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvModulos As DataGridView
    Friend WithEvents dgvPerfil As DataGridView
    Friend WithEvents bnfCardNombre As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label2 As Label
    Friend WithEvents Modulos As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpAsg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpQuit As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpAsgT As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpQuitT As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfCardPerf As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dgvDetallePerfiles As DataGridView
    Friend WithEvents txtIdPerfil As TextBox
    Friend WithEvents txtNombreAnt As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label5 As Label
    Friend WithEvents bnfCardPerCar As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardDetCar As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
