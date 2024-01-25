<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprobantes))
        Me.txtLeyEnc = New System.Windows.Forms.TextBox()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.bnfElipCarg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBorr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bnfElipCateg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCopias = New System.Windows.Forms.TextBox()
        Me.txtLeyPie = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtLeyenda = New System.Windows.Forms.TextBox()
        Me.txtIdComp = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtCc = New System.Windows.Forms.TextBox()
        Me.txtCe = New System.Windows.Forms.TextBox()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.pnlFrmEmpresa = New System.Windows.Forms.Panel()
        Me.bnfCardLeyenda = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardComp = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.bnfListComp = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvComprobantes = New System.Windows.Forms.DataGridView()
        Me.bnfCardPieEnc = New Bunifu.Framework.UI.BunifuCards()
        Me.lblPieSiNo = New System.Windows.Forms.Label()
        Me.lblEncSiNo = New System.Windows.Forms.Label()
        Me.bnfChkPie = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.bnfChkEnc = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrmEmpresa.SuspendLayout()
        Me.bnfCardLeyenda.SuspendLayout()
        Me.bnfCardComp.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.bnfListComp.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardPieEnc.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLeyEnc
        '
        Me.txtLeyEnc.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLeyEnc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeyEnc.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeyEnc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtLeyEnc.Location = New System.Drawing.Point(408, 19)
        Me.txtLeyEnc.MaxLength = 254
        Me.txtLeyEnc.Name = "txtLeyEnc"
        Me.txtLeyEnc.Size = New System.Drawing.Size(662, 25)
        Me.txtLeyEnc.TabIndex = 5
        '
        'cbxTipo
        '
        Me.cbxTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbxTipo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Reserva", "Remito", "Factura/NC/ND", "Recibo", "Orden de Pago", "Listado", "Informe"})
        Me.cbxTipo.Location = New System.Drawing.Point(836, 16)
        Me.cbxTipo.MaxLength = 254
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(234, 28)
        Me.cbxTipo.TabIndex = 1
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
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "      Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(11, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "IMPRIME PIE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(257, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 18)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "LEYENDA ENCABEZADO"
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(11, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "IMPRIME ENCABEZADO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(257, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 18)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "LEYENDA CUERPO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(697, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 18)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "TIPO COMPROBANTE"
        '
        'bnfElipCateg
        '
        Me.bnfElipCateg.ElipseRadius = 7
        Me.bnfElipCateg.TargetControl = Me
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(11, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "NOMBRE COMPROBANTE"
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
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "        Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(172, 18)
        Me.txtNombre.MaxLength = 254
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(491, 26)
        Me.txtNombre.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(257, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 18)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "LEYENDA PIE"
        '
        'txtCopias
        '
        Me.txtCopias.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCopias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCopias.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCopias.Location = New System.Drawing.Point(172, 17)
        Me.txtCopias.MaxLength = 3
        Me.txtCopias.Name = "txtCopias"
        Me.txtCopias.Size = New System.Drawing.Size(63, 25)
        Me.txtCopias.TabIndex = 2
        Me.txtCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLeyPie
        '
        Me.txtLeyPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLeyPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeyPie.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeyPie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtLeyPie.Location = New System.Drawing.Point(408, 50)
        Me.txtLeyPie.MaxLength = 254
        Me.txtLeyPie.Name = "txtLeyPie"
        Me.txtLeyPie.Size = New System.Drawing.Size(662, 25)
        Me.txtLeyPie.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(11, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 18)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "COPIAS (Orig/Dup/Trip)"
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
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "      Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "     Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtLeyenda
        '
        Me.txtLeyenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLeyenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeyenda.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeyenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtLeyenda.Location = New System.Drawing.Point(378, 17)
        Me.txtLeyenda.MaxLength = 65000
        Me.txtLeyenda.Multiline = True
        Me.txtLeyenda.Name = "txtLeyenda"
        Me.txtLeyenda.Size = New System.Drawing.Size(692, 69)
        Me.txtLeyenda.TabIndex = 3
        '
        'txtIdComp
        '
        Me.txtIdComp.BackColor = System.Drawing.Color.Red
        Me.txtIdComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdComp.Enabled = False
        Me.txtIdComp.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdComp.ForeColor = System.Drawing.Color.White
        Me.txtIdComp.Location = New System.Drawing.Point(875, 6)
        Me.txtIdComp.Name = "txtIdComp"
        Me.txtIdComp.Size = New System.Drawing.Size(68, 25)
        Me.txtIdComp.TabIndex = 64
        Me.txtIdComp.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(959, 5)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 63
        Me.txtOrigen.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(975, 35)
        Me.lblTitulo.TabIndex = 76
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtCc)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdComp)
        Me.bnfCardTitulo.Controls.Add(Me.txtCe)
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
        'txtCc
        '
        Me.txtCc.BackColor = System.Drawing.Color.Red
        Me.txtCc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCc.Enabled = False
        Me.txtCc.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCc.ForeColor = System.Drawing.Color.White
        Me.txtCc.Location = New System.Drawing.Point(1119, 5)
        Me.txtCc.Name = "txtCc"
        Me.txtCc.Size = New System.Drawing.Size(68, 25)
        Me.txtCc.TabIndex = 66
        Me.txtCc.Visible = False
        '
        'txtCe
        '
        Me.txtCe.BackColor = System.Drawing.Color.Red
        Me.txtCe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCe.Enabled = False
        Me.txtCe.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCe.ForeColor = System.Drawing.Color.White
        Me.txtCe.Location = New System.Drawing.Point(1039, 5)
        Me.txtCe.Name = "txtCe"
        Me.txtCe.Size = New System.Drawing.Size(68, 25)
        Me.txtCe.TabIndex = 65
        Me.txtCe.Visible = False
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoComprobante
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 77
        Me.pbxTitulo.TabStop = False
        '
        'pnlFrmEmpresa
        '
        Me.pnlFrmEmpresa.AutoScroll = True
        Me.pnlFrmEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfCardLeyenda)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfCardComp)
        Me.pnlFrmEmpresa.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfListComp)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfCardPieEnc)
        Me.pnlFrmEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmEmpresa.Name = "pnlFrmEmpresa"
        Me.pnlFrmEmpresa.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmEmpresa.TabIndex = 60
        '
        'bnfCardLeyenda
        '
        Me.bnfCardLeyenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardLeyenda.BorderRadius = 5
        Me.bnfCardLeyenda.BottomSahddow = True
        Me.bnfCardLeyenda.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardLeyenda.Controls.Add(Me.Label10)
        Me.bnfCardLeyenda.Controls.Add(Me.txtLeyenda)
        Me.bnfCardLeyenda.Controls.Add(Me.txtCopias)
        Me.bnfCardLeyenda.Controls.Add(Me.Label11)
        Me.bnfCardLeyenda.LeftSahddow = False
        Me.bnfCardLeyenda.Location = New System.Drawing.Point(11, 105)
        Me.bnfCardLeyenda.Name = "bnfCardLeyenda"
        Me.bnfCardLeyenda.RightSahddow = True
        Me.bnfCardLeyenda.ShadowDepth = 20
        Me.bnfCardLeyenda.Size = New System.Drawing.Size(1084, 100)
        Me.bnfCardLeyenda.TabIndex = 112
        '
        'bnfCardComp
        '
        Me.bnfCardComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardComp.BorderRadius = 5
        Me.bnfCardComp.BottomSahddow = True
        Me.bnfCardComp.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardComp.Controls.Add(Me.Label3)
        Me.bnfCardComp.Controls.Add(Me.cbxTipo)
        Me.bnfCardComp.Controls.Add(Me.txtNombre)
        Me.bnfCardComp.Controls.Add(Me.Label16)
        Me.bnfCardComp.LeftSahddow = False
        Me.bnfCardComp.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardComp.Name = "bnfCardComp"
        Me.bnfCardComp.RightSahddow = True
        Me.bnfCardComp.ShadowDepth = 20
        Me.bnfCardComp.Size = New System.Drawing.Size(1084, 58)
        Me.bnfCardComp.TabIndex = 56
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
        Me.BunifuCards1.TabIndex = 111
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
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "      Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'bnfListComp
        '
        Me.bnfListComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfListComp.BorderRadius = 5
        Me.bnfListComp.BottomSahddow = True
        Me.bnfListComp.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfListComp.Controls.Add(Me.BunifuCards6)
        Me.bnfListComp.Controls.Add(Me.dgvComprobantes)
        Me.bnfListComp.LeftSahddow = False
        Me.bnfListComp.Location = New System.Drawing.Point(11, 310)
        Me.bnfListComp.Name = "bnfListComp"
        Me.bnfListComp.RightSahddow = True
        Me.bnfListComp.ShadowDepth = 20
        Me.bnfListComp.Size = New System.Drawing.Size(1330, 436)
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
        Me.BunifuCards6.TabIndex = 110
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
        Me.Label2.Text = "COMPROBANTES CARGADAS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvComprobantes
        '
        Me.dgvComprobantes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComprobantes.Location = New System.Drawing.Point(9, 43)
        Me.dgvComprobantes.Name = "dgvComprobantes"
        Me.dgvComprobantes.Size = New System.Drawing.Size(1310, 381)
        Me.dgvComprobantes.TabIndex = 13
        '
        'bnfCardPieEnc
        '
        Me.bnfCardPieEnc.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardPieEnc.BorderRadius = 5
        Me.bnfCardPieEnc.BottomSahddow = True
        Me.bnfCardPieEnc.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardPieEnc.Controls.Add(Me.lblPieSiNo)
        Me.bnfCardPieEnc.Controls.Add(Me.lblEncSiNo)
        Me.bnfCardPieEnc.Controls.Add(Me.bnfChkPie)
        Me.bnfCardPieEnc.Controls.Add(Me.bnfChkEnc)
        Me.bnfCardPieEnc.Controls.Add(Me.txtLeyEnc)
        Me.bnfCardPieEnc.Controls.Add(Me.Label6)
        Me.bnfCardPieEnc.Controls.Add(Me.Label1)
        Me.bnfCardPieEnc.Controls.Add(Me.Label4)
        Me.bnfCardPieEnc.Controls.Add(Me.txtLeyPie)
        Me.bnfCardPieEnc.Controls.Add(Me.Label13)
        Me.bnfCardPieEnc.LeftSahddow = False
        Me.bnfCardPieEnc.Location = New System.Drawing.Point(11, 211)
        Me.bnfCardPieEnc.Name = "bnfCardPieEnc"
        Me.bnfCardPieEnc.RightSahddow = True
        Me.bnfCardPieEnc.ShadowDepth = 20
        Me.bnfCardPieEnc.Size = New System.Drawing.Size(1084, 93)
        Me.bnfCardPieEnc.TabIndex = 53
        '
        'lblPieSiNo
        '
        Me.lblPieSiNo.AutoSize = True
        Me.lblPieSiNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPieSiNo.ForeColor = System.Drawing.Color.LightGray
        Me.lblPieSiNo.Location = New System.Drawing.Point(185, 55)
        Me.lblPieSiNo.Name = "lblPieSiNo"
        Me.lblPieSiNo.Size = New System.Drawing.Size(19, 18)
        Me.lblPieSiNo.TabIndex = 84
        Me.lblPieSiNo.Text = "SI"
        '
        'lblEncSiNo
        '
        Me.lblEncSiNo.AutoSize = True
        Me.lblEncSiNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncSiNo.ForeColor = System.Drawing.Color.LightGray
        Me.lblEncSiNo.Location = New System.Drawing.Point(185, 24)
        Me.lblEncSiNo.Name = "lblEncSiNo"
        Me.lblEncSiNo.Size = New System.Drawing.Size(19, 18)
        Me.lblEncSiNo.TabIndex = 83
        Me.lblEncSiNo.Text = "SI"
        '
        'bnfChkPie
        '
        Me.bnfChkPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkPie.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfChkPie.Checked = True
        Me.bnfChkPie.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkPie.ForeColor = System.Drawing.Color.White
        Me.bnfChkPie.Location = New System.Drawing.Point(159, 54)
        Me.bnfChkPie.Name = "bnfChkPie"
        Me.bnfChkPie.Size = New System.Drawing.Size(20, 20)
        Me.bnfChkPie.TabIndex = 6
        '
        'bnfChkEnc
        '
        Me.bnfChkEnc.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkEnc.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfChkEnc.Checked = True
        Me.bnfChkEnc.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkEnc.ForeColor = System.Drawing.Color.White
        Me.bnfChkEnc.Location = New System.Drawing.Point(159, 21)
        Me.bnfChkEnc.Name = "bnfChkEnc"
        Me.bnfChkEnc.Size = New System.Drawing.Size(20, 20)
        Me.bnfChkEnc.TabIndex = 4
        '
        'bnfElpMod
        '
        Me.bnfElpMod.ElipseRadius = 7
        Me.bnfElpMod.TargetControl = Me.btnModificar
        '
        'frmComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmEmpresa)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComprobantes"
        Me.Text = "frmComprobantes"
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrmEmpresa.ResumeLayout(False)
        Me.bnfCardLeyenda.ResumeLayout(False)
        Me.bnfCardLeyenda.PerformLayout()
        Me.bnfCardComp.ResumeLayout(False)
        Me.bnfCardComp.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.bnfListComp.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        CType(Me.dgvComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardPieEnc.ResumeLayout(False)
        Me.bnfCardPieEnc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLeyEnc As TextBox
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents bnfElipCarg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipBorr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ofdImagen As OpenFileDialog
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents bnfElipCateg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlFrmEmpresa As Panel
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtIdComp As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfCardPieEnc As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCopias As TextBox
    Friend WithEvents txtLeyPie As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLeyenda As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfChkPie As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents bnfChkEnc As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lblPieSiNo As Label
    Friend WithEvents lblEncSiNo As Label
    Friend WithEvents bnfListComp As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvComprobantes As DataGridView
    Friend WithEvents txtCc As TextBox
    Friend WithEvents txtCe As TextBox
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardComp As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardLeyenda As Bunifu.Framework.UI.BunifuCards
End Class
