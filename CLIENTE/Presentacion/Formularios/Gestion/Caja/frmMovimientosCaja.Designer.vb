<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientosCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientosCaja))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.bnfCardOrigenDestino = New Bunifu.Framework.UI.BunifuCards()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOrigenDestino = New System.Windows.Forms.TextBox()
        Me.bnfCardValoresEnCartera = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvValoresCartera = New System.Windows.Forms.DataGridView()
        Me.bnfCardDatosValor = New Bunifu.Framework.UI.BunifuCards()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.txtLibrador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFechaCobro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.cmbTipoValor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnfCardGral = New Bunifu.Framework.UI.BunifuCards()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.cmbMov = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.bnfCardCabecera = New Bunifu.Framework.UI.BunifuCards()
        Me.cmbCuentaContable = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipFrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipPnl = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCards4.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrmArticulos.SuspendLayout()
        Me.bnfCardOrigenDestino.SuspendLayout()
        Me.bnfCardValoresEnCartera.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.dgvValoresCartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardDatosValor.SuspendLayout()
        Me.bnfCardGral.SuspendLayout()
        Me.bnfCardCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(788, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "CAJA -> DETALLE DEL MOVIMIENTO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.btnGuardar)
        Me.BunifuCards4.Controls.Add(Me.btnCancelar)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(11, 675)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(841, 63)
        Me.BunifuCards4.TabIndex = 108
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
        Me.btnGuardar.Location = New System.Drawing.Point(586, 16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 35)
        Me.btnGuardar.TabIndex = 117
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
        Me.btnCancelar.Location = New System.Drawing.Point(710, 16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 35)
        Me.btnCancelar.TabIndex = 118
        Me.btnCancelar.Text = "      Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 1
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = False
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = False
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(873, 35)
        Me.bnfCardTitulo.TabIndex = 92
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(836, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardOrigenDestino)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardValoresEnCartera)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardDatosValor)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardGral)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards4)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardCabecera)
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(6, 35)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(861, 747)
        Me.pnlFrmArticulos.TabIndex = 65
        '
        'bnfCardOrigenDestino
        '
        Me.bnfCardOrigenDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardOrigenDestino.BorderRadius = 5
        Me.bnfCardOrigenDestino.BottomSahddow = True
        Me.bnfCardOrigenDestino.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardOrigenDestino.Controls.Add(Me.Label14)
        Me.bnfCardOrigenDestino.Controls.Add(Me.txtOrigenDestino)
        Me.bnfCardOrigenDestino.Enabled = False
        Me.bnfCardOrigenDestino.LeftSahddow = False
        Me.bnfCardOrigenDestino.Location = New System.Drawing.Point(11, 613)
        Me.bnfCardOrigenDestino.Name = "bnfCardOrigenDestino"
        Me.bnfCardOrigenDestino.RightSahddow = True
        Me.bnfCardOrigenDestino.ShadowDepth = 20
        Me.bnfCardOrigenDestino.Size = New System.Drawing.Size(840, 56)
        Me.bnfCardOrigenDestino.TabIndex = 112
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(13, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 18)
        Me.Label14.TabIndex = 122
        Me.Label14.Text = "ORIGEN / DESTINO"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOrigenDestino
        '
        Me.txtOrigenDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtOrigenDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigenDestino.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigenDestino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtOrigenDestino.Location = New System.Drawing.Point(138, 17)
        Me.txtOrigenDestino.MaxLength = 255
        Me.txtOrigenDestino.Name = "txtOrigenDestino"
        Me.txtOrigenDestino.Size = New System.Drawing.Size(690, 25)
        Me.txtOrigenDestino.TabIndex = 121
        '
        'bnfCardValoresEnCartera
        '
        Me.bnfCardValoresEnCartera.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardValoresEnCartera.BorderRadius = 5
        Me.bnfCardValoresEnCartera.BottomSahddow = True
        Me.bnfCardValoresEnCartera.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardValoresEnCartera.Controls.Add(Me.BunifuCards3)
        Me.bnfCardValoresEnCartera.Controls.Add(Me.dgvValoresCartera)
        Me.bnfCardValoresEnCartera.LeftSahddow = False
        Me.bnfCardValoresEnCartera.Location = New System.Drawing.Point(11, 170)
        Me.bnfCardValoresEnCartera.Name = "bnfCardValoresEnCartera"
        Me.bnfCardValoresEnCartera.RightSahddow = True
        Me.bnfCardValoresEnCartera.ShadowDepth = 20
        Me.bnfCardValoresEnCartera.Size = New System.Drawing.Size(840, 304)
        Me.bnfCardValoresEnCartera.TabIndex = 111
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.Label5)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(826, 33)
        Me.BunifuCards3.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(487, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "VALORES EN CARTERA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvValoresCartera
        '
        Me.dgvValoresCartera.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvValoresCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValoresCartera.Location = New System.Drawing.Point(9, 43)
        Me.dgvValoresCartera.Name = "dgvValoresCartera"
        Me.dgvValoresCartera.Size = New System.Drawing.Size(820, 249)
        Me.dgvValoresCartera.TabIndex = 64
        '
        'bnfCardDatosValor
        '
        Me.bnfCardDatosValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardDatosValor.BorderRadius = 5
        Me.bnfCardDatosValor.BottomSahddow = True
        Me.bnfCardDatosValor.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDatosValor.Controls.Add(Me.Label15)
        Me.bnfCardDatosValor.Controls.Add(Me.txtSucursal)
        Me.bnfCardDatosValor.Controls.Add(Me.cmbBanco)
        Me.bnfCardDatosValor.Controls.Add(Me.txtLibrador)
        Me.bnfCardDatosValor.Controls.Add(Me.Label2)
        Me.bnfCardDatosValor.Controls.Add(Me.Label4)
        Me.bnfCardDatosValor.Controls.Add(Me.Label11)
        Me.bnfCardDatosValor.Controls.Add(Me.txtFechaCobro)
        Me.bnfCardDatosValor.Controls.Add(Me.Label3)
        Me.bnfCardDatosValor.Controls.Add(Me.txtNumero)
        Me.bnfCardDatosValor.Controls.Add(Me.cmbTipoValor)
        Me.bnfCardDatosValor.Controls.Add(Me.Label1)
        Me.bnfCardDatosValor.Enabled = False
        Me.bnfCardDatosValor.LeftSahddow = False
        Me.bnfCardDatosValor.Location = New System.Drawing.Point(11, 480)
        Me.bnfCardDatosValor.Name = "bnfCardDatosValor"
        Me.bnfCardDatosValor.RightSahddow = True
        Me.bnfCardDatosValor.ShadowDepth = 20
        Me.bnfCardDatosValor.Size = New System.Drawing.Size(840, 127)
        Me.bnfCardDatosValor.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(423, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 18)
        Me.Label15.TabIndex = 126
        Me.Label15.Text = "SUCURSAL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSucursal
        '
        Me.txtSucursal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSucursal.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSucursal.Location = New System.Drawing.Point(500, 54)
        Me.txtSucursal.MaxLength = 255
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(328, 25)
        Me.txtSucursal.TabIndex = 125
        '
        'cmbBanco
        '
        Me.cmbBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbBanco.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(87, 53)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(330, 28)
        Me.cmbBanco.TabIndex = 115
        '
        'txtLibrador
        '
        Me.txtLibrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLibrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLibrador.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibrador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtLibrador.Location = New System.Drawing.Point(87, 91)
        Me.txtLibrador.MaxLength = 255
        Me.txtLibrador.Name = "txtLibrador"
        Me.txtLibrador.Size = New System.Drawing.Size(330, 25)
        Me.txtLibrador.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "BANCO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(13, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "LIBRADOR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(583, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 18)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "FECHA DE COBRO"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaCobro
        '
        Me.txtFechaCobro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFechaCobro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaCobro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCobro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFechaCobro.Location = New System.Drawing.Point(701, 17)
        Me.txtFechaCobro.MaxLength = 10
        Me.txtFechaCobro.Name = "txtFechaCobro"
        Me.txtFechaCobro.Size = New System.Drawing.Size(127, 25)
        Me.txtFechaCobro.TabIndex = 124
        Me.txtFechaCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(332, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "NUMERO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(398, 17)
        Me.txtNumero.MaxLength = 45
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(179, 25)
        Me.txtNumero.TabIndex = 117
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbTipoValor
        '
        Me.cmbTipoValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbTipoValor.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbTipoValor.FormattingEnabled = True
        Me.cmbTipoValor.Location = New System.Drawing.Point(87, 16)
        Me.cmbTipoValor.Name = "cmbTipoValor"
        Me.cmbTipoValor.Size = New System.Drawing.Size(239, 28)
        Me.cmbTipoValor.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "VALOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfCardGral
        '
        Me.bnfCardGral.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardGral.BorderRadius = 5
        Me.bnfCardGral.BottomSahddow = True
        Me.bnfCardGral.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardGral.Controls.Add(Me.cmbMoneda)
        Me.bnfCardGral.Controls.Add(Me.cmbMov)
        Me.bnfCardGral.Controls.Add(Me.Label8)
        Me.bnfCardGral.Controls.Add(Me.Label9)
        Me.bnfCardGral.Controls.Add(Me.Label6)
        Me.bnfCardGral.Controls.Add(Me.txtImporte)
        Me.bnfCardGral.LeftSahddow = False
        Me.bnfCardGral.Location = New System.Drawing.Point(11, 106)
        Me.bnfCardGral.Name = "bnfCardGral"
        Me.bnfCardGral.RightSahddow = True
        Me.bnfCardGral.ShadowDepth = 20
        Me.bnfCardGral.Size = New System.Drawing.Size(841, 58)
        Me.bnfCardGral.TabIndex = 109
        '
        'cmbMoneda
        '
        Me.cmbMoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbMoneda.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(377, 15)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(211, 28)
        Me.cmbMoneda.TabIndex = 111
        '
        'cmbMov
        '
        Me.cmbMov.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbMov.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMov.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbMov.FormattingEnabled = True
        Me.cmbMov.Location = New System.Drawing.Point(104, 15)
        Me.cmbMov.Name = "cmbMov"
        Me.cmbMov.Size = New System.Drawing.Size(202, 28)
        Me.cmbMov.TabIndex = 109
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(312, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "MONEDA"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(13, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 18)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "MOVIMIENTO"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(594, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "IMPORTE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporte.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtImporte.Location = New System.Drawing.Point(661, 16)
        Me.txtImporte.MaxLength = 20
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(167, 25)
        Me.txtImporte.TabIndex = 112
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bnfCardCabecera
        '
        Me.bnfCardCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardCabecera.BorderRadius = 5
        Me.bnfCardCabecera.BottomSahddow = True
        Me.bnfCardCabecera.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardCabecera.Controls.Add(Me.cmbCuentaContable)
        Me.bnfCardCabecera.Controls.Add(Me.Label13)
        Me.bnfCardCabecera.Controls.Add(Me.cmbTipo)
        Me.bnfCardCabecera.Controls.Add(Me.Label12)
        Me.bnfCardCabecera.Controls.Add(Me.Label7)
        Me.bnfCardCabecera.Controls.Add(Me.txtObservaciones)
        Me.bnfCardCabecera.Controls.Add(Me.Label10)
        Me.bnfCardCabecera.Controls.Add(Me.txtFecha)
        Me.bnfCardCabecera.LeftSahddow = False
        Me.bnfCardCabecera.Location = New System.Drawing.Point(11, 11)
        Me.bnfCardCabecera.Name = "bnfCardCabecera"
        Me.bnfCardCabecera.RightSahddow = True
        Me.bnfCardCabecera.ShadowDepth = 20
        Me.bnfCardCabecera.Size = New System.Drawing.Size(841, 89)
        Me.bnfCardCabecera.TabIndex = 96
        '
        'cmbCuentaContable
        '
        Me.cmbCuentaContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbCuentaContable.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCuentaContable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbCuentaContable.FormattingEnabled = True
        Me.cmbCuentaContable.Location = New System.Drawing.Point(542, 13)
        Me.cmbCuentaContable.Name = "cmbCuentaContable"
        Me.cmbCuentaContable.Size = New System.Drawing.Size(286, 28)
        Me.cmbCuentaContable.TabIndex = 127
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(414, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 18)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "CUENTA CONTABLE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbTipo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(238, 13)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(170, 28)
        Me.cmbTipo.TabIndex = 125
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(195, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 18)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "TIPO"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(10, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "OBSERVACIONES"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtObservaciones.Location = New System.Drawing.Point(122, 51)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(706, 25)
        Me.txtObservaciones.TabIndex = 123
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(10, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 18)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "FECHA"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecha.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(64, 14)
        Me.txtFecha.MaxLength = 10
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(125, 25)
        Me.txtFecha.TabIndex = 122
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'bnfElipFrm
        '
        Me.bnfElipFrm.ElipseRadius = 20
        Me.bnfElipFrm.TargetControl = Me
        '
        'bnfElipPnl
        '
        Me.bnfElipPnl.ElipseRadius = 20
        Me.bnfElipPnl.TargetControl = Me.pnlFrmArticulos
        '
        'frmMovimientosCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(873, 788)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.Controls.Add(Me.bnfCardTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientosCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMovimientos"
        Me.BunifuCards4.ResumeLayout(False)
        Me.bnfCardTitulo.ResumeLayout(False)
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.bnfCardOrigenDestino.ResumeLayout(False)
        Me.bnfCardOrigenDestino.PerformLayout()
        Me.bnfCardValoresEnCartera.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        CType(Me.dgvValoresCartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardDatosValor.ResumeLayout(False)
        Me.bnfCardDatosValor.PerformLayout()
        Me.bnfCardGral.ResumeLayout(False)
        Me.bnfCardGral.PerformLayout()
        Me.bnfCardCabecera.ResumeLayout(False)
        Me.bnfCardCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents bnfCardCabecera As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents cmbCuentaContable As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents bnfCardGral As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents cmbMov As ComboBox
    Friend WithEvents cmbMoneda As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents bnfCardDatosValor As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfCardValoresEnCartera As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvValoresCartera As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFechaCobro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLibrador As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents cmbBanco As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTipoValor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bnfCardOrigenDestino As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label14 As Label
    Friend WithEvents txtOrigenDestino As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents bnfElipFrm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipPnl As Bunifu.Framework.UI.BunifuElipse
End Class
