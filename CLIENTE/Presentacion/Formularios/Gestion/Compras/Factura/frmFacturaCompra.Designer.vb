<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacturaCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaCompra))
        Me.txtTE = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.txtNumFac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFec = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCtaProv = New System.Windows.Forms.TextBox()
        Me.txtRSprov = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDirec = New System.Windows.Forms.Label()
        Me.txtIIBB = New System.Windows.Forms.Label()
        Me.txtProv = New System.Windows.Forms.Label()
        Me.bnfElipEditar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.bnfElipAgg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.bnfElipBorr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipCarg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.bnfCardDetalleRem = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubTotalP = New System.Windows.Forms.TextBox()
        Me.txtTotalC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIVAP = New System.Windows.Forms.TextBox()
        Me.txtSubTotalC = New System.Windows.Forms.TextBox()
        Me.txtTotalP = New System.Windows.Forms.TextBox()
        Me.txtIVAC = New System.Windows.Forms.TextBox()
        Me.btnServicio = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.dgvDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtIdFacturaCompra = New System.Windows.Forms.TextBox()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.pnlFrmFacComp = New System.Windows.Forms.Panel()
        Me.bnfCardClase = New Bunifu.Framework.UI.BunifuCards()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTipoFac = New System.Windows.Forms.Label()
        Me.bnfCardNro = New Bunifu.Framework.UI.BunifuCards()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPrefijo = New System.Windows.Forms.TextBox()
        Me.bnfCardFec = New Bunifu.Framework.UI.BunifuCards()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFecVto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bnfCardTc = New Bunifu.Framework.UI.BunifuCards()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.bnfCardProv = New Bunifu.Framework.UI.BunifuCards()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnfCardObs = New Bunifu.Framework.UI.BunifuCards()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.bnfCardBotones = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardInfoProv = New Bunifu.Framework.UI.BunifuCards()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.bnfElipQuitar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipAggItem = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfServicio = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfCardDetalleRem.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.dgvDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrmFacComp.SuspendLayout()
        Me.bnfCardClase.SuspendLayout()
        Me.bnfCardNro.SuspendLayout()
        Me.bnfCardFec.SuspendLayout()
        Me.bnfCardTc.SuspendLayout()
        Me.bnfCardProv.SuspendLayout()
        Me.bnfCardObs.SuspendLayout()
        Me.bnfCardBotones.SuspendLayout()
        Me.bnfCardInfoProv.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTE
        '
        Me.txtTE.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTE.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTE.ForeColor = System.Drawing.Color.DimGray
        Me.txtTE.Location = New System.Drawing.Point(91, 143)
        Me.txtTE.Name = "txtTE"
        Me.txtTE.Size = New System.Drawing.Size(519, 24)
        Me.txtTE.TabIndex = 81
        '
        'txtTC
        '
        Me.txtTC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTC.Location = New System.Drawing.Point(10, 33)
        Me.txtTC.MaxLength = 16
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(147, 25)
        Me.txtTC.TabIndex = 74
        Me.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumFac
        '
        Me.txtNumFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNumFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumFac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumFac.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumFac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNumFac.Location = New System.Drawing.Point(10, 86)
        Me.txtNumFac.MaxLength = 255
        Me.txtNumFac.Name = "txtNumFac"
        Me.txtNumFac.Size = New System.Drawing.Size(147, 25)
        Me.txtNumFac.TabIndex = 78
        Me.txtNumFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(10, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "NRO CTA"
        '
        'txtFec
        '
        Me.txtFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFec.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFec.Location = New System.Drawing.Point(10, 33)
        Me.txtFec.MaxLength = 10
        Me.txtFec.Name = "txtFec"
        Me.txtFec.Size = New System.Drawing.Size(147, 25)
        Me.txtFec.TabIndex = 66
        Me.txtFec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightGray
        Me.Label17.Location = New System.Drawing.Point(378, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 18)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "II BB"
        '
        'txtCtaProv
        '
        Me.txtCtaProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCtaProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtaProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaProv.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaProv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCtaProv.Location = New System.Drawing.Point(10, 30)
        Me.txtCtaProv.MaxLength = 5
        Me.txtCtaProv.Name = "txtCtaProv"
        Me.txtCtaProv.Size = New System.Drawing.Size(79, 30)
        Me.txtCtaProv.TabIndex = 60
        Me.txtCtaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRSprov
        '
        Me.txtRSprov.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtRSprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRSprov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRSprov.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRSprov.ForeColor = System.Drawing.Color.DimGray
        Me.txtRSprov.Location = New System.Drawing.Point(95, 30)
        Me.txtRSprov.MaxLength = 255
        Me.txtRSprov.Name = "txtRSprov"
        Me.txtRSprov.ReadOnly = True
        Me.txtRSprov.Size = New System.Drawing.Size(515, 30)
        Me.txtRSprov.TabIndex = 62
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(7, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 18)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "CUIT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(7, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 18)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "DIRECCION"
        '
        'txtCuit
        '
        Me.txtCuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCuit.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.ForeColor = System.Drawing.Color.DimGray
        Me.txtCuit.Location = New System.Drawing.Point(91, 111)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(190, 24)
        Me.txtCuit.TabIndex = 77
        '
        'txtLoc
        '
        Me.txtLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLoc.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.ForeColor = System.Drawing.Color.DimGray
        Me.txtLoc.Location = New System.Drawing.Point(91, 48)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(519, 24)
        Me.txtLoc.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(7, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 18)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "PROVINCIA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(7, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 18)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "LOCALIDAD"
        '
        'txtDirec
        '
        Me.txtDirec.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDirec.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirec.ForeColor = System.Drawing.Color.DimGray
        Me.txtDirec.Location = New System.Drawing.Point(91, 16)
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(519, 24)
        Me.txtDirec.TabIndex = 71
        '
        'txtIIBB
        '
        Me.txtIIBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtIIBB.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIIBB.ForeColor = System.Drawing.Color.DimGray
        Me.txtIIBB.Location = New System.Drawing.Point(420, 111)
        Me.txtIIBB.Name = "txtIIBB"
        Me.txtIIBB.Size = New System.Drawing.Size(190, 24)
        Me.txtIIBB.TabIndex = 79
        '
        'txtProv
        '
        Me.txtProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtProv.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProv.ForeColor = System.Drawing.Color.DimGray
        Me.txtProv.Location = New System.Drawing.Point(91, 80)
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(519, 24)
        Me.txtProv.TabIndex = 75
        '
        'bnfElipEditar
        '
        Me.bnfElipEditar.ElipseRadius = 7
        Me.bnfElipEditar.TargetControl = Me.btnEditar
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = Global.Presentacion.My.Resources.Resources.IconoEditar3
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(1200, 98)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(118, 35)
        Me.btnEditar.TabIndex = 66
        Me.btnEditar.Text = "    Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'bnfElipAgg
        '
        Me.bnfElipAgg.ElipseRadius = 7
        Me.bnfElipAgg.TargetControl = Me.btnAgregar
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.IconoAgregar2
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(1200, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 35)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "     Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'bnfElipBorr
        '
        Me.bnfElipBorr.ElipseRadius = 7
        Me.bnfElipBorr.TargetControl = Me
        '
        'bnfElipCarg
        '
        Me.bnfElipCarg.ElipseRadius = 7
        Me.bnfElipCarg.TargetControl = Me
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
        Me.btnEliminar.Location = New System.Drawing.Point(559, 20)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 35)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "      Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(286, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 35)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "        Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.btnModificar.Location = New System.Drawing.Point(151, 20)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 35)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "      Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(15, 20)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 35)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "    Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'bnfCardDetalleRem
        '
        Me.bnfCardDetalleRem.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDetalleRem.BorderRadius = 5
        Me.bnfCardDetalleRem.BottomSahddow = True
        Me.bnfCardDetalleRem.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDetalleRem.Controls.Add(Me.BunifuCards3)
        Me.bnfCardDetalleRem.Controls.Add(Me.btnServicio)
        Me.bnfCardDetalleRem.Controls.Add(Me.btnEditar)
        Me.bnfCardDetalleRem.Controls.Add(Me.btnQuitar)
        Me.bnfCardDetalleRem.Controls.Add(Me.btnAgregar)
        Me.bnfCardDetalleRem.Controls.Add(Me.dgvDetalleFactura)
        Me.bnfCardDetalleRem.Enabled = False
        Me.bnfCardDetalleRem.LeftSahddow = False
        Me.bnfCardDetalleRem.Location = New System.Drawing.Point(11, 303)
        Me.bnfCardDetalleRem.Name = "bnfCardDetalleRem"
        Me.bnfCardDetalleRem.RightSahddow = True
        Me.bnfCardDetalleRem.ShadowDepth = 20
        Me.bnfCardDetalleRem.Size = New System.Drawing.Size(1330, 430)
        Me.bnfCardDetalleRem.TabIndex = 83
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.Label7)
        Me.BunifuCards3.Controls.Add(Me.Label8)
        Me.BunifuCards3.Controls.Add(Me.txtSubTotalP)
        Me.BunifuCards3.Controls.Add(Me.txtTotalC)
        Me.BunifuCards3.Controls.Add(Me.Label9)
        Me.BunifuCards3.Controls.Add(Me.txtIVAP)
        Me.BunifuCards3.Controls.Add(Me.txtSubTotalC)
        Me.BunifuCards3.Controls.Add(Me.txtTotalP)
        Me.BunifuCards3.Controls.Add(Me.txtIVAC)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(6, 381)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(1182, 43)
        Me.BunifuCards3.TabIndex = 120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(792, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "TOTAL"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(7, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "SUB TOTAL"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSubTotalP
        '
        Me.txtSubTotalP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSubTotalP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTotalP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotalP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSubTotalP.Location = New System.Drawing.Point(260, 8)
        Me.txtSubTotalP.MaxLength = 16
        Me.txtSubTotalP.Name = "txtSubTotalP"
        Me.txtSubTotalP.ReadOnly = True
        Me.txtSubTotalP.Size = New System.Drawing.Size(155, 25)
        Me.txtSubTotalP.TabIndex = 77
        Me.txtSubTotalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalC
        '
        Me.txtTotalC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTotalC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtTotalC.Location = New System.Drawing.Point(852, 8)
        Me.txtTotalC.MaxLength = 16
        Me.txtTotalC.Name = "txtTotalC"
        Me.txtTotalC.ReadOnly = True
        Me.txtTotalC.Size = New System.Drawing.Size(155, 25)
        Me.txtTotalC.TabIndex = 87
        Me.txtTotalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(427, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 20)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "IVA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIVAP
        '
        Me.txtIVAP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtIVAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVAP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtIVAP.Location = New System.Drawing.Point(625, 8)
        Me.txtIVAP.MaxLength = 16
        Me.txtIVAP.Name = "txtIVAP"
        Me.txtIVAP.ReadOnly = True
        Me.txtIVAP.Size = New System.Drawing.Size(155, 25)
        Me.txtIVAP.TabIndex = 79
        Me.txtIVAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotalC
        '
        Me.txtSubTotalC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSubTotalC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTotalC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotalC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSubTotalC.Location = New System.Drawing.Point(99, 8)
        Me.txtSubTotalC.MaxLength = 16
        Me.txtSubTotalC.Name = "txtSubTotalC"
        Me.txtSubTotalC.ReadOnly = True
        Me.txtSubTotalC.Size = New System.Drawing.Size(155, 25)
        Me.txtSubTotalC.TabIndex = 83
        Me.txtSubTotalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalP
        '
        Me.txtTotalP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTotalP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtTotalP.Location = New System.Drawing.Point(1013, 8)
        Me.txtTotalP.MaxLength = 16
        Me.txtTotalP.Name = "txtTotalP"
        Me.txtTotalP.ReadOnly = True
        Me.txtTotalP.Size = New System.Drawing.Size(155, 25)
        Me.txtTotalP.TabIndex = 81
        Me.txtTotalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVAC
        '
        Me.txtIVAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtIVAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVAC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtIVAC.Location = New System.Drawing.Point(464, 8)
        Me.txtIVAC.MaxLength = 16
        Me.txtIVAC.Name = "txtIVAC"
        Me.txtIVAC.ReadOnly = True
        Me.txtIVAC.Size = New System.Drawing.Size(155, 25)
        Me.txtIVAC.TabIndex = 85
        Me.txtIVAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnServicio
        '
        Me.btnServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnServicio.FlatAppearance.BorderSize = 0
        Me.btnServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServicio.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServicio.ForeColor = System.Drawing.Color.White
        Me.btnServicio.Image = Global.Presentacion.My.Resources.Resources.IconoServicio1
        Me.btnServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServicio.Location = New System.Drawing.Point(1200, 57)
        Me.btnServicio.Name = "btnServicio"
        Me.btnServicio.Size = New System.Drawing.Size(118, 35)
        Me.btnServicio.TabIndex = 68
        Me.btnServicio.Text = "     Servicio"
        Me.btnServicio.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitar.FlatAppearance.BorderSize = 0
        Me.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.White
        Me.btnQuitar.Image = Global.Presentacion.My.Resources.Resources.iconoQuitar1
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.Location = New System.Drawing.Point(1200, 139)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(118, 35)
        Me.btnQuitar.TabIndex = 65
        Me.btnQuitar.Text = "    Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'dgvDetalleFactura
        '
        Me.dgvDetalleFactura.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleFactura.Location = New System.Drawing.Point(10, 16)
        Me.dgvDetalleFactura.Name = "dgvDetalleFactura"
        Me.dgvDetalleFactura.Size = New System.Drawing.Size(1176, 366)
        Me.dgvDetalleFactura.TabIndex = 64
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
        Me.btnCancelar.Location = New System.Drawing.Point(422, 20)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 35)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "      Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(991, 6)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 62
        Me.txtOrigen.Visible = False
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtIdFacturaCompra)
        Me.bnfCardTitulo.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
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
        'txtIdFacturaCompra
        '
        Me.txtIdFacturaCompra.BackColor = System.Drawing.Color.Red
        Me.txtIdFacturaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdFacturaCompra.Enabled = False
        Me.txtIdFacturaCompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdFacturaCompra.ForeColor = System.Drawing.Color.White
        Me.txtIdFacturaCompra.Location = New System.Drawing.Point(917, 6)
        Me.txtIdFacturaCompra.Name = "txtIdFacturaCompra"
        Me.txtIdFacturaCompra.Size = New System.Drawing.Size(68, 25)
        Me.txtIdFacturaCompra.TabIndex = 80
        Me.txtIdFacturaCompra.Visible = False
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoFactura
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 79
        Me.pbxTitulo.TabStop = False
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
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1015, 35)
        Me.lblTitulo.TabIndex = 78
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBanco
        '
        Me.lblBanco.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.LightGray
        Me.lblBanco.Location = New System.Drawing.Point(10, 62)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(147, 55)
        Me.lblBanco.TabIndex = 76
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlFrmFacComp
        '
        Me.pnlFrmFacComp.AutoScroll = True
        Me.pnlFrmFacComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardClase)
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardNro)
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardFec)
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardTc)
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardProv)
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardObs)
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardBotones)
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardInfoProv)
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardDetalleRem)
        Me.pnlFrmFacComp.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmFacComp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmFacComp.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmFacComp.Name = "pnlFrmFacComp"
        Me.pnlFrmFacComp.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmFacComp.TabIndex = 60
        '
        'bnfCardClase
        '
        Me.bnfCardClase.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardClase.BorderRadius = 5
        Me.bnfCardClase.BottomSahddow = True
        Me.bnfCardClase.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardClase.Controls.Add(Me.Label3)
        Me.bnfCardClase.Controls.Add(Me.lblTipoFac)
        Me.bnfCardClase.Enabled = False
        Me.bnfCardClase.LeftSahddow = False
        Me.bnfCardClase.Location = New System.Drawing.Point(816, 170)
        Me.bnfCardClase.Name = "bnfCardClase"
        Me.bnfCardClase.RightSahddow = True
        Me.bnfCardClase.ShadowDepth = 20
        Me.bnfCardClase.Size = New System.Drawing.Size(171, 127)
        Me.bnfCardClase.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "CLASE COMPROBANTE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTipoFac
        '
        Me.lblTipoFac.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoFac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.lblTipoFac.Location = New System.Drawing.Point(10, 25)
        Me.lblTipoFac.Name = "lblTipoFac"
        Me.lblTipoFac.Size = New System.Drawing.Size(147, 95)
        Me.lblTipoFac.TabIndex = 105
        Me.lblTipoFac.Text = "X"
        Me.lblTipoFac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnfCardNro
        '
        Me.bnfCardNro.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardNro.BorderRadius = 5
        Me.bnfCardNro.BottomSahddow = True
        Me.bnfCardNro.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardNro.Controls.Add(Me.Label21)
        Me.bnfCardNro.Controls.Add(Me.txtNumFac)
        Me.bnfCardNro.Controls.Add(Me.Label18)
        Me.bnfCardNro.Controls.Add(Me.txtPrefijo)
        Me.bnfCardNro.Enabled = False
        Me.bnfCardNro.LeftSahddow = False
        Me.bnfCardNro.Location = New System.Drawing.Point(816, 41)
        Me.bnfCardNro.Name = "bnfCardNro"
        Me.bnfCardNro.RightSahddow = True
        Me.bnfCardNro.ShadowDepth = 20
        Me.bnfCardNro.Size = New System.Drawing.Size(171, 123)
        Me.bnfCardNro.TabIndex = 111
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LightGray
        Me.Label21.Location = New System.Drawing.Point(10, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 20)
        Me.Label21.TabIndex = 102
        Me.Label21.Text = "PREFIJO"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightGray
        Me.Label18.Location = New System.Drawing.Point(10, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 20)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "NRO. COMPROBANTE"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrefijo
        '
        Me.txtPrefijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPrefijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrefijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrefijo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefijo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPrefijo.Location = New System.Drawing.Point(10, 33)
        Me.txtPrefijo.MaxLength = 255
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.Size = New System.Drawing.Size(147, 25)
        Me.txtPrefijo.TabIndex = 79
        Me.txtPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bnfCardFec
        '
        Me.bnfCardFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardFec.BorderRadius = 5
        Me.bnfCardFec.BottomSahddow = True
        Me.bnfCardFec.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardFec.Controls.Add(Me.Label6)
        Me.bnfCardFec.Controls.Add(Me.txtFecVto)
        Me.bnfCardFec.Controls.Add(Me.txtFec)
        Me.bnfCardFec.Controls.Add(Me.Label5)
        Me.bnfCardFec.Enabled = False
        Me.bnfCardFec.LeftSahddow = False
        Me.bnfCardFec.Location = New System.Drawing.Point(639, 41)
        Me.bnfCardFec.Name = "bnfCardFec"
        Me.bnfCardFec.RightSahddow = True
        Me.bnfCardFec.ShadowDepth = 20
        Me.bnfCardFec.Size = New System.Drawing.Size(171, 123)
        Me.bnfCardFec.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(10, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 20)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "FECHA EMISION"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFecVto
        '
        Me.txtFecVto.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecVto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecVto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecVto.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecVto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFecVto.Location = New System.Drawing.Point(10, 86)
        Me.txtFecVto.MaxLength = 10
        Me.txtFecVto.Name = "txtFecVto"
        Me.txtFecVto.Size = New System.Drawing.Size(147, 25)
        Me.txtFecVto.TabIndex = 82
        Me.txtFecVto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(10, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 18)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "FECHA VENCIMIENTO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnfCardTc
        '
        Me.bnfCardTc.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardTc.BorderRadius = 5
        Me.bnfCardTc.BottomSahddow = True
        Me.bnfCardTc.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTc.Controls.Add(Me.Label14)
        Me.bnfCardTc.Controls.Add(Me.txtTC)
        Me.bnfCardTc.Controls.Add(Me.lblBanco)
        Me.bnfCardTc.Enabled = False
        Me.bnfCardTc.LeftSahddow = False
        Me.bnfCardTc.Location = New System.Drawing.Point(639, 170)
        Me.bnfCardTc.Name = "bnfCardTc"
        Me.bnfCardTc.RightSahddow = True
        Me.bnfCardTc.ShadowDepth = 20
        Me.bnfCardTc.Size = New System.Drawing.Size(171, 127)
        Me.bnfCardTc.TabIndex = 109
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(10, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(147, 20)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "TIPO DE CAMBIO"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnfCardProv
        '
        Me.bnfCardProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardProv.BorderRadius = 5
        Me.bnfCardProv.BottomSahddow = True
        Me.bnfCardProv.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardProv.Controls.Add(Me.txtRSprov)
        Me.bnfCardProv.Controls.Add(Me.Label1)
        Me.bnfCardProv.Controls.Add(Me.txtCtaProv)
        Me.bnfCardProv.Controls.Add(Me.Label2)
        Me.bnfCardProv.Enabled = False
        Me.bnfCardProv.LeftSahddow = False
        Me.bnfCardProv.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardProv.Name = "bnfCardProv"
        Me.bnfCardProv.RightSahddow = True
        Me.bnfCardProv.ShadowDepth = 20
        Me.bnfCardProv.Size = New System.Drawing.Size(622, 70)
        Me.bnfCardProv.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(95, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "RAZON SOCIAL"
        '
        'bnfCardObs
        '
        Me.bnfCardObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardObs.BorderRadius = 5
        Me.bnfCardObs.BottomSahddow = True
        Me.bnfCardObs.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardObs.Controls.Add(Me.Label12)
        Me.bnfCardObs.Controls.Add(Me.txtObservaciones)
        Me.bnfCardObs.Enabled = False
        Me.bnfCardObs.LeftSahddow = False
        Me.bnfCardObs.Location = New System.Drawing.Point(11, 740)
        Me.bnfCardObs.Name = "bnfCardObs"
        Me.bnfCardObs.RightSahddow = True
        Me.bnfCardObs.ShadowDepth = 20
        Me.bnfCardObs.Size = New System.Drawing.Size(478, 74)
        Me.bnfCardObs.TabIndex = 84
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(8, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 16)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "OBSERVACIONES"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtObservaciones.Location = New System.Drawing.Point(8, 26)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(461, 40)
        Me.txtObservaciones.TabIndex = 99
        '
        'bnfCardBotones
        '
        Me.bnfCardBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardBotones.BorderRadius = 5
        Me.bnfCardBotones.BottomSahddow = True
        Me.bnfCardBotones.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardBotones.Controls.Add(Me.btnEliminar)
        Me.bnfCardBotones.Controls.Add(Me.btnCancelar)
        Me.bnfCardBotones.Controls.Add(Me.btnNuevo)
        Me.bnfCardBotones.Controls.Add(Me.btnGuardar)
        Me.bnfCardBotones.Controls.Add(Me.btnModificar)
        Me.bnfCardBotones.LeftSahddow = False
        Me.bnfCardBotones.Location = New System.Drawing.Point(651, 741)
        Me.bnfCardBotones.Name = "bnfCardBotones"
        Me.bnfCardBotones.RightSahddow = True
        Me.bnfCardBotones.ShadowDepth = 20
        Me.bnfCardBotones.Size = New System.Drawing.Size(690, 74)
        Me.bnfCardBotones.TabIndex = 59
        '
        'bnfCardInfoProv
        '
        Me.bnfCardInfoProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardInfoProv.BorderRadius = 5
        Me.bnfCardInfoProv.BottomSahddow = True
        Me.bnfCardInfoProv.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardInfoProv.Controls.Add(Me.Label19)
        Me.bnfCardInfoProv.Controls.Add(Me.txtTE)
        Me.bnfCardInfoProv.Controls.Add(Me.Label17)
        Me.bnfCardInfoProv.Controls.Add(Me.txtIIBB)
        Me.bnfCardInfoProv.Controls.Add(Me.Label15)
        Me.bnfCardInfoProv.Controls.Add(Me.Label10)
        Me.bnfCardInfoProv.Controls.Add(Me.txtCuit)
        Me.bnfCardInfoProv.Controls.Add(Me.txtLoc)
        Me.bnfCardInfoProv.Controls.Add(Me.Label13)
        Me.bnfCardInfoProv.Controls.Add(Me.Label11)
        Me.bnfCardInfoProv.Controls.Add(Me.txtDirec)
        Me.bnfCardInfoProv.Controls.Add(Me.txtProv)
        Me.bnfCardInfoProv.Enabled = False
        Me.bnfCardInfoProv.LeftSahddow = False
        Me.bnfCardInfoProv.Location = New System.Drawing.Point(11, 117)
        Me.bnfCardInfoProv.Name = "bnfCardInfoProv"
        Me.bnfCardInfoProv.RightSahddow = True
        Me.bnfCardInfoProv.ShadowDepth = 20
        Me.bnfCardInfoProv.Size = New System.Drawing.Size(622, 180)
        Me.bnfCardInfoProv.TabIndex = 60
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightGray
        Me.Label19.Location = New System.Drawing.Point(7, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "TELEFONO"
        '
        'bnfElipQuitar
        '
        Me.bnfElipQuitar.ElipseRadius = 7
        Me.bnfElipQuitar.TargetControl = Me.btnQuitar
        '
        'bnfElipAggItem
        '
        Me.bnfElipAggItem.ElipseRadius = 7
        Me.bnfElipAggItem.TargetControl = Me
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'bnfServicio
        '
        Me.bnfServicio.ElipseRadius = 7
        Me.bnfServicio.TargetControl = Me.btnServicio
        '
        'frmFacturaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmFacComp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFacturaCompra"
        Me.Text = "frmFacturaCompra"
        Me.bnfCardDetalleRem.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        CType(Me.dgvDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrmFacComp.ResumeLayout(False)
        Me.bnfCardClase.ResumeLayout(False)
        Me.bnfCardNro.ResumeLayout(False)
        Me.bnfCardNro.PerformLayout()
        Me.bnfCardFec.ResumeLayout(False)
        Me.bnfCardFec.PerformLayout()
        Me.bnfCardTc.ResumeLayout(False)
        Me.bnfCardTc.PerformLayout()
        Me.bnfCardProv.ResumeLayout(False)
        Me.bnfCardProv.PerformLayout()
        Me.bnfCardObs.ResumeLayout(False)
        Me.bnfCardObs.PerformLayout()
        Me.bnfCardBotones.ResumeLayout(False)
        Me.bnfCardInfoProv.ResumeLayout(False)
        Me.bnfCardInfoProv.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTE As Label
    Friend WithEvents txtTC As TextBox
    Friend WithEvents txtNumFac As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFec As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCtaProv As TextBox
    Friend WithEvents txtRSprov As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCuit As Label
    Friend WithEvents txtLoc As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDirec As Label
    Friend WithEvents txtIIBB As Label
    Friend WithEvents txtProv As Label
    Friend WithEvents bnfElipEditar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnEditar As Button
    Friend WithEvents bnfElipAgg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnAgregar As Button
    Friend WithEvents bnfElipBorr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlFrmFacComp As Panel
    Friend WithEvents bnfCardBotones As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblBanco As Label
    Friend WithEvents bnfCardInfoProv As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bnfCardDetalleRem As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnQuitar As Button
    Friend WithEvents dgvDetalleFactura As DataGridView
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfElipCarg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipQuitar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtPrefijo As TextBox
    Friend WithEvents txtFecVto As TextBox
    Friend WithEvents bnfElipAggItem As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtIdFacturaCompra As TextBox
    Friend WithEvents btnServicio As Button
    Friend WithEvents bnfServicio As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtSubTotalP As TextBox
    Friend WithEvents txtTotalC As TextBox
    Friend WithEvents txtIVAP As TextBox
    Friend WithEvents txtIVAC As TextBox
    Friend WithEvents txtTotalP As TextBox
    Friend WithEvents txtSubTotalC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTipoFac As Label
    Friend WithEvents bnfCardObs As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label12 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents bnfCardProv As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardTc As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardFec As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardNro As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardClase As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
End Class
