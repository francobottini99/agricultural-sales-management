<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
        Me.bnfCardList = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtIdSubRubro = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtIdRubro = New System.Windows.Forms.TextBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.bnfElipCarg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.bnfElipBorr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnBorrarImagen = New System.Windows.Forms.Button()
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.bnfCardDatos = New Bunifu.Framework.UI.BunifuCards()
        Me.pnlContendorDatos = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAlicIVA = New System.Windows.Forms.TextBox()
        Me.lblMonedaContablePrecio = New System.Windows.Forms.Label()
        Me.lblMonedaPPalPrecio = New System.Windows.Forms.Label()
        Me.txtPrecioContable = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblMonedaContableCosto = New System.Windows.Forms.Label()
        Me.lblMonedaPPalCosto = New System.Windows.Forms.Label()
        Me.txtCostoContable = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAbSubRubro = New System.Windows.Forms.TextBox()
        Me.txtAbRubro = New System.Windows.Forms.TextBox()
        Me.cmbSubRubro = New System.Windows.Forms.ComboBox()
        Me.cmbRubro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.btnCategorias = New System.Windows.Forms.Button()
        Me.txtCostoPPal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPrecioPPal = New System.Windows.Forms.TextBox()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtStockMin = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.bnfCardImg = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxImagen = New System.Windows.Forms.PictureBox()
        Me.bnfElipCateg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.bnfCardTc = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfCardList.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardDatos.SuspendLayout()
        Me.pnlContendorDatos.SuspendLayout()
        Me.bnfCardImg.SuspendLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrmArticulos.SuspendLayout()
        Me.bnfCardTc.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnfCardList
        '
        Me.bnfCardList.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardList.BorderRadius = 5
        Me.bnfCardList.BottomSahddow = True
        Me.bnfCardList.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardList.Controls.Add(Me.BunifuCards6)
        Me.bnfCardList.Controls.Add(Me.dgvArticulos)
        Me.bnfCardList.LeftSahddow = False
        Me.bnfCardList.Location = New System.Drawing.Point(11, 393)
        Me.bnfCardList.Name = "bnfCardList"
        Me.bnfCardList.RightSahddow = True
        Me.bnfCardList.ShadowDepth = 20
        Me.bnfCardList.Size = New System.Drawing.Size(1330, 353)
        Me.bnfCardList.TabIndex = 57
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.Label1)
        Me.BunifuCards6.Controls.Add(Me.Label7)
        Me.BunifuCards6.Controls.Add(Me.txtBuscar)
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
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(487, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ARTICULOS CARGADOS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.txtBuscar.TabIndex = 51
        '
        'dgvArticulos
        '
        Me.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Location = New System.Drawing.Point(9, 58)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(1310, 281)
        Me.dgvArticulos.TabIndex = 50
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdArticulo)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdSubRubro)
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdRubro)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = True
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTitulo.TabIndex = 55
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoArticulos
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 77
        Me.pbxTitulo.TabStop = False
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.BackColor = System.Drawing.Color.Red
        Me.txtIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdArticulo.Enabled = False
        Me.txtIdArticulo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdArticulo.ForeColor = System.Drawing.Color.White
        Me.txtIdArticulo.Location = New System.Drawing.Point(895, 10)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(68, 25)
        Me.txtIdArticulo.TabIndex = 64
        Me.txtIdArticulo.Visible = False
        '
        'txtIdSubRubro
        '
        Me.txtIdSubRubro.BackColor = System.Drawing.Color.Red
        Me.txtIdSubRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdSubRubro.Enabled = False
        Me.txtIdSubRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSubRubro.ForeColor = System.Drawing.Color.White
        Me.txtIdSubRubro.Location = New System.Drawing.Point(747, 10)
        Me.txtIdSubRubro.Name = "txtIdSubRubro"
        Me.txtIdSubRubro.Size = New System.Drawing.Size(68, 25)
        Me.txtIdSubRubro.TabIndex = 63
        Me.txtIdSubRubro.Visible = False
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
        'txtIdRubro
        '
        Me.txtIdRubro.BackColor = System.Drawing.Color.Red
        Me.txtIdRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdRubro.Enabled = False
        Me.txtIdRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdRubro.ForeColor = System.Drawing.Color.White
        Me.txtIdRubro.Location = New System.Drawing.Point(821, 10)
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
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(975, 35)
        Me.lblTitulo.TabIndex = 76
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "     Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'bnfElpMod
        '
        Me.bnfElpMod.ElipseRadius = 7
        Me.bnfElpMod.TargetControl = Me.btnModificar
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
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "      Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'bnfElpGuar
        '
        Me.bnfElpGuar.ElipseRadius = 7
        Me.bnfElpGuar.TargetControl = Me.btnGuardar
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
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "        Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'bnfElpCanc
        '
        Me.bnfElpCanc.ElipseRadius = 7
        Me.bnfElpCanc.TargetControl = Me.btnCancelar
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
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "      Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'bnfElpElim
        '
        Me.bnfElpElim.ElipseRadius = 7
        Me.bnfElpElim.TargetControl = Me.btnEliminar
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
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "      Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'bnfElipCarg
        '
        Me.bnfElipCarg.ElipseRadius = 7
        Me.bnfElipCarg.TargetControl = Me.btnCargarImagen
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarImagen.FlatAppearance.BorderSize = 0
        Me.btnCargarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarImagen.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagen.ForeColor = System.Drawing.Color.White
        Me.btnCargarImagen.Image = Global.Presentacion.My.Resources.Resources.IconoImagen
        Me.btnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarImagen.Location = New System.Drawing.Point(21, 15)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(107, 35)
        Me.btnCargarImagen.TabIndex = 10
        Me.btnCargarImagen.Text = "Cargar  "
        Me.btnCargarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargarImagen.UseVisualStyleBackColor = False
        '
        'bnfElipBorr
        '
        Me.bnfElipBorr.ElipseRadius = 7
        Me.bnfElipBorr.TargetControl = Me.btnBorrarImagen
        '
        'btnBorrarImagen
        '
        Me.btnBorrarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnBorrarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarImagen.FlatAppearance.BorderSize = 0
        Me.btnBorrarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnBorrarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarImagen.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarImagen.ForeColor = System.Drawing.Color.White
        Me.btnBorrarImagen.Image = Global.Presentacion.My.Resources.Resources.IconoBorrarRecortado
        Me.btnBorrarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarImagen.Location = New System.Drawing.Point(146, 15)
        Me.btnBorrarImagen.Name = "btnBorrarImagen"
        Me.btnBorrarImagen.Size = New System.Drawing.Size(107, 35)
        Me.btnBorrarImagen.TabIndex = 11
        Me.btnBorrarImagen.Text = "      Borrar"
        Me.btnBorrarImagen.UseVisualStyleBackColor = False
        '
        'ofdImagen
        '
        '
        'bnfCardDatos
        '
        Me.bnfCardDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDatos.BorderRadius = 5
        Me.bnfCardDatos.BottomSahddow = True
        Me.bnfCardDatos.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDatos.Controls.Add(Me.pnlContendorDatos)
        Me.bnfCardDatos.LeftSahddow = False
        Me.bnfCardDatos.Location = New System.Drawing.Point(11, 94)
        Me.bnfCardDatos.Name = "bnfCardDatos"
        Me.bnfCardDatos.RightSahddow = True
        Me.bnfCardDatos.ShadowDepth = 20
        Me.bnfCardDatos.Size = New System.Drawing.Size(766, 293)
        Me.bnfCardDatos.TabIndex = 53
        '
        'pnlContendorDatos
        '
        Me.pnlContendorDatos.Controls.Add(Me.Label14)
        Me.pnlContendorDatos.Controls.Add(Me.Label11)
        Me.pnlContendorDatos.Controls.Add(Me.txtAlicIVA)
        Me.pnlContendorDatos.Controls.Add(Me.lblMonedaContablePrecio)
        Me.pnlContendorDatos.Controls.Add(Me.lblMonedaPPalPrecio)
        Me.pnlContendorDatos.Controls.Add(Me.txtPrecioContable)
        Me.pnlContendorDatos.Controls.Add(Me.Label16)
        Me.pnlContendorDatos.Controls.Add(Me.lblMonedaContableCosto)
        Me.pnlContendorDatos.Controls.Add(Me.lblMonedaPPalCosto)
        Me.pnlContendorDatos.Controls.Add(Me.txtCostoContable)
        Me.pnlContendorDatos.Controls.Add(Me.Label9)
        Me.pnlContendorDatos.Controls.Add(Me.txtAbSubRubro)
        Me.pnlContendorDatos.Controls.Add(Me.txtAbRubro)
        Me.pnlContendorDatos.Controls.Add(Me.cmbSubRubro)
        Me.pnlContendorDatos.Controls.Add(Me.cmbRubro)
        Me.pnlContendorDatos.Controls.Add(Me.Label3)
        Me.pnlContendorDatos.Controls.Add(Me.txtDetalle)
        Me.pnlContendorDatos.Controls.Add(Me.btnCategorias)
        Me.pnlContendorDatos.Controls.Add(Me.txtCostoPPal)
        Me.pnlContendorDatos.Controls.Add(Me.Label4)
        Me.pnlContendorDatos.Controls.Add(Me.Label8)
        Me.pnlContendorDatos.Controls.Add(Me.Label5)
        Me.pnlContendorDatos.Controls.Add(Me.Label2)
        Me.pnlContendorDatos.Controls.Add(Me.Label13)
        Me.pnlContendorDatos.Controls.Add(Me.txtPrecioPPal)
        Me.pnlContendorDatos.Controls.Add(Me.txtObserv)
        Me.pnlContendorDatos.Controls.Add(Me.Label10)
        Me.pnlContendorDatos.Controls.Add(Me.Label12)
        Me.pnlContendorDatos.Controls.Add(Me.txtStockMin)
        Me.pnlContendorDatos.Controls.Add(Me.txtUnidad)
        Me.pnlContendorDatos.Location = New System.Drawing.Point(4, 6)
        Me.pnlContendorDatos.Name = "pnlContendorDatos"
        Me.pnlContendorDatos.Size = New System.Drawing.Size(756, 282)
        Me.pnlContendorDatos.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(717, 219)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 18)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(467, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 18)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "ALICUOTA IVA"
        '
        'txtAlicIVA
        '
        Me.txtAlicIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtAlicIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlicIVA.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlicIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtAlicIVA.Location = New System.Drawing.Point(571, 217)
        Me.txtAlicIVA.MaxLength = 99
        Me.txtAlicIVA.Name = "txtAlicIVA"
        Me.txtAlicIVA.Size = New System.Drawing.Size(140, 25)
        Me.txtAlicIVA.TabIndex = 70
        Me.txtAlicIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMonedaContablePrecio
        '
        Me.lblMonedaContablePrecio.AutoSize = True
        Me.lblMonedaContablePrecio.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonedaContablePrecio.ForeColor = System.Drawing.Color.LightGray
        Me.lblMonedaContablePrecio.Location = New System.Drawing.Point(717, 153)
        Me.lblMonedaContablePrecio.Name = "lblMonedaContablePrecio"
        Me.lblMonedaContablePrecio.Size = New System.Drawing.Size(16, 18)
        Me.lblMonedaContablePrecio.TabIndex = 69
        Me.lblMonedaContablePrecio.Text = "$"
        '
        'lblMonedaPPalPrecio
        '
        Me.lblMonedaPPalPrecio.AutoSize = True
        Me.lblMonedaPPalPrecio.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonedaPPalPrecio.ForeColor = System.Drawing.Color.LightGray
        Me.lblMonedaPPalPrecio.Location = New System.Drawing.Point(717, 118)
        Me.lblMonedaPPalPrecio.Name = "lblMonedaPPalPrecio"
        Me.lblMonedaPPalPrecio.Size = New System.Drawing.Size(32, 18)
        Me.lblMonedaPPalPrecio.TabIndex = 68
        Me.lblMonedaPPalPrecio.Text = "U$S"
        '
        'txtPrecioContable
        '
        Me.txtPrecioContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPrecioContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioContable.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioContable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPrecioContable.Location = New System.Drawing.Point(572, 151)
        Me.txtPrecioContable.MaxLength = 15
        Me.txtPrecioContable.Name = "txtPrecioContable"
        Me.txtPrecioContable.Size = New System.Drawing.Size(139, 25)
        Me.txtPrecioContable.TabIndex = 64
        Me.txtPrecioContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(468, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 18)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "PRECIO VENTA"
        '
        'lblMonedaContableCosto
        '
        Me.lblMonedaContableCosto.AutoSize = True
        Me.lblMonedaContableCosto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonedaContableCosto.ForeColor = System.Drawing.Color.LightGray
        Me.lblMonedaContableCosto.Location = New System.Drawing.Point(281, 189)
        Me.lblMonedaContableCosto.Name = "lblMonedaContableCosto"
        Me.lblMonedaContableCosto.Size = New System.Drawing.Size(16, 18)
        Me.lblMonedaContableCosto.TabIndex = 63
        Me.lblMonedaContableCosto.Text = "$"
        '
        'lblMonedaPPalCosto
        '
        Me.lblMonedaPPalCosto.AutoSize = True
        Me.lblMonedaPPalCosto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonedaPPalCosto.ForeColor = System.Drawing.Color.LightGray
        Me.lblMonedaPPalCosto.Location = New System.Drawing.Point(281, 155)
        Me.lblMonedaPPalCosto.Name = "lblMonedaPPalCosto"
        Me.lblMonedaPPalCosto.Size = New System.Drawing.Size(32, 18)
        Me.lblMonedaPPalCosto.TabIndex = 62
        Me.lblMonedaPPalCosto.Text = "U$S"
        '
        'txtCostoContable
        '
        Me.txtCostoContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCostoContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoContable.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoContable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCostoContable.Location = New System.Drawing.Point(136, 185)
        Me.txtCostoContable.MaxLength = 15
        Me.txtCostoContable.Name = "txtCostoContable"
        Me.txtCostoContable.Size = New System.Drawing.Size(139, 25)
        Me.txtCostoContable.TabIndex = 60
        Me.txtCostoContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(10, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "COSTO ($)"
        '
        'txtAbSubRubro
        '
        Me.txtAbSubRubro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAbSubRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbSubRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbSubRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbSubRubro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtAbSubRubro.Location = New System.Drawing.Point(136, 77)
        Me.txtAbSubRubro.MaxLength = 4
        Me.txtAbSubRubro.Name = "txtAbSubRubro"
        Me.txtAbSubRubro.Size = New System.Drawing.Size(72, 25)
        Me.txtAbSubRubro.TabIndex = 59
        Me.txtAbSubRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAbRubro
        '
        Me.txtAbRubro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtAbRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbRubro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtAbRubro.Location = New System.Drawing.Point(136, 39)
        Me.txtAbRubro.MaxLength = 4
        Me.txtAbRubro.Name = "txtAbRubro"
        Me.txtAbRubro.Size = New System.Drawing.Size(72, 25)
        Me.txtAbRubro.TabIndex = 58
        Me.txtAbRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbSubRubro
        '
        Me.cmbSubRubro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbSubRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubRubro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbSubRubro.FormattingEnabled = True
        Me.cmbSubRubro.Location = New System.Drawing.Point(214, 76)
        Me.cmbSubRubro.Name = "cmbSubRubro"
        Me.cmbSubRubro.Size = New System.Drawing.Size(290, 28)
        Me.cmbSubRubro.TabIndex = 57
        '
        'cmbRubro
        '
        Me.cmbRubro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbRubro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRubro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbRubro.FormattingEnabled = True
        Me.cmbRubro.Location = New System.Drawing.Point(214, 38)
        Me.cmbRubro.Name = "cmbRubro"
        Me.cmbRubro.Size = New System.Drawing.Size(290, 28)
        Me.cmbRubro.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "DETALLE "
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalle.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtDetalle.Location = New System.Drawing.Point(136, 6)
        Me.txtDetalle.MaxLength = 254
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(612, 25)
        Me.txtDetalle.TabIndex = 2
        '
        'btnCategorias
        '
        Me.btnCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategorias.FlatAppearance.BorderSize = 0
        Me.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategorias.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategorias.ForeColor = System.Drawing.Color.White
        Me.btnCategorias.Image = Global.Presentacion.My.Resources.Resources.IconoCategoriasRecortado
        Me.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategorias.Location = New System.Drawing.Point(542, 51)
        Me.btnCategorias.Name = "btnCategorias"
        Me.btnCategorias.Size = New System.Drawing.Size(128, 35)
        Me.btnCategorias.TabIndex = 54
        Me.btnCategorias.Text = "        Categorías"
        Me.btnCategorias.UseVisualStyleBackColor = False
        Me.btnCategorias.Visible = False
        '
        'txtCostoPPal
        '
        Me.txtCostoPPal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCostoPPal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoPPal.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoPPal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCostoPPal.Location = New System.Drawing.Point(136, 151)
        Me.txtCostoPPal.MaxLength = 15
        Me.txtCostoPPal.Name = "txtCostoPPal"
        Me.txtCostoPPal.Size = New System.Drawing.Size(139, 25)
        Me.txtCostoPPal.TabIndex = 4
        Me.txtCostoPPal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(10, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "UNIDAD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(10, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "SUB RUBRO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(10, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "COSTO (U$S)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(10, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "RUBRO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(10, 252)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "OBSERVACIONES"
        '
        'txtPrecioPPal
        '
        Me.txtPrecioPPal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPrecioPPal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioPPal.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioPPal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPrecioPPal.Location = New System.Drawing.Point(572, 116)
        Me.txtPrecioPPal.MaxLength = 15
        Me.txtPrecioPPal.Name = "txtPrecioPPal"
        Me.txtPrecioPPal.Size = New System.Drawing.Size(139, 25)
        Me.txtPrecioPPal.TabIndex = 41
        Me.txtPrecioPPal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObserv
        '
        Me.txtObserv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtObserv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObserv.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObserv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtObserv.Location = New System.Drawing.Point(136, 248)
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.Size = New System.Drawing.Size(612, 25)
        Me.txtObserv.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(468, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 18)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "PRECIO VENTA "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(468, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "STOCK MINIMO"
        '
        'txtStockMin
        '
        Me.txtStockMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtStockMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockMin.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtStockMin.Location = New System.Drawing.Point(572, 185)
        Me.txtStockMin.MaxLength = 99
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Size = New System.Drawing.Size(139, 25)
        Me.txtStockMin.TabIndex = 45
        Me.txtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnidad
        '
        Me.txtUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUnidad.Location = New System.Drawing.Point(136, 118)
        Me.txtUnidad.MaxLength = 99
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(138, 25)
        Me.txtUnidad.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightGray
        Me.Label17.Location = New System.Drawing.Point(14, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 18)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "TIPO CAMBIO"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.LightGray
        Me.lblBanco.Location = New System.Drawing.Point(284, 18)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(0, 16)
        Me.lblBanco.TabIndex = 73
        '
        'txtTC
        '
        Me.txtTC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTC.Location = New System.Drawing.Point(140, 12)
        Me.txtTC.MaxLength = 16
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(138, 25)
        Me.txtTC.TabIndex = 66
        Me.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bnfCardImg
        '
        Me.bnfCardImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardImg.BorderRadius = 5
        Me.bnfCardImg.BottomSahddow = True
        Me.bnfCardImg.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardImg.Controls.Add(Me.pbxImagen)
        Me.bnfCardImg.LeftSahddow = False
        Me.bnfCardImg.Location = New System.Drawing.Point(1070, 41)
        Me.bnfCardImg.Name = "bnfCardImg"
        Me.bnfCardImg.RightSahddow = True
        Me.bnfCardImg.ShadowDepth = 20
        Me.bnfCardImg.Size = New System.Drawing.Size(271, 279)
        Me.bnfCardImg.TabIndex = 54
        '
        'pbxImagen
        '
        Me.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImagen.Image = Global.Presentacion.My.Resources.Resources.IconoArticulo
        Me.pbxImagen.Location = New System.Drawing.Point(6, 11)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(260, 260)
        Me.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxImagen.TabIndex = 42
        Me.pbxImagen.TabStop = False
        '
        'bnfElipCateg
        '
        Me.bnfElipCateg.ElipseRadius = 7
        Me.bnfElipCateg.TargetControl = Me.btnCategorias
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.AutoScroll = True
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardTc)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards2)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardDatos)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardList)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardImg)
        Me.pnlFrmArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmArticulos.TabIndex = 58
        '
        'bnfCardTc
        '
        Me.bnfCardTc.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardTc.BorderRadius = 5
        Me.bnfCardTc.BottomSahddow = True
        Me.bnfCardTc.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTc.Controls.Add(Me.Label17)
        Me.bnfCardTc.Controls.Add(Me.txtTC)
        Me.bnfCardTc.Controls.Add(Me.lblBanco)
        Me.bnfCardTc.LeftSahddow = False
        Me.bnfCardTc.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardTc.Name = "bnfCardTc"
        Me.bnfCardTc.RightSahddow = True
        Me.bnfCardTc.ShadowDepth = 20
        Me.bnfCardTc.Size = New System.Drawing.Size(766, 47)
        Me.bnfCardTc.TabIndex = 112
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.btnCargarImagen)
        Me.BunifuCards2.Controls.Add(Me.btnBorrarImagen)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(1070, 321)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(271, 61)
        Me.BunifuCards2.TabIndex = 111
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.btnModificar)
        Me.BunifuCards1.Controls.Add(Me.btnEliminar)
        Me.BunifuCards1.Controls.Add(Me.btnCancelar)
        Me.BunifuCards1.Controls.Add(Me.btnNuevo)
        Me.BunifuCards1.Controls.Add(Me.btnGuardar)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(651, 752)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(690, 61)
        Me.BunifuCards1.TabIndex = 110
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArticulos"
        Me.Text = "frmArticulos"
        Me.bnfCardList.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        Me.BunifuCards6.PerformLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardDatos.ResumeLayout(False)
        Me.pnlContendorDatos.ResumeLayout(False)
        Me.pnlContendorDatos.PerformLayout()
        Me.bnfCardImg.ResumeLayout(False)
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.bnfCardTc.ResumeLayout(False)
        Me.bnfCardTc.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bnfCardList As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvArticulos As DataGridView
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtIdSubRubro As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtIdRubro As TextBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnNuevo As Button
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnModificar As Button
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnGuardar As Button
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnCancelar As Button
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnEliminar As Button
    Friend WithEvents bnfElipCarg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents bnfElipBorr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnBorrarImagen As Button
    Friend WithEvents ofdImagen As OpenFileDialog
    Friend WithEvents bnfCardDatos As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardImg As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxImagen As PictureBox
    Friend WithEvents txtCostoPPal As TextBox
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtObserv As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtStockMin As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPrecioPPal As TextBox
    Friend WithEvents btnCategorias As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bnfElipCateg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlContendorDatos As Panel
    Friend WithEvents cmbSubRubro As ComboBox
    Friend WithEvents cmbRubro As ComboBox
    Friend WithEvents txtAbSubRubro As TextBox
    Friend WithEvents txtAbRubro As TextBox
    Friend WithEvents lblMonedaPPalCosto As Label
    Friend WithEvents txtCostoContable As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrecioContable As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblMonedaContableCosto As Label
    Friend WithEvents txtTC As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblMonedaContablePrecio As Label
    Friend WithEvents lblMonedaPPalPrecio As Label
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAlicIVA As TextBox
    Friend WithEvents lblBanco As Label
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardTc As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
End Class
