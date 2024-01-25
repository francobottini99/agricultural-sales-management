<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReciboVentaDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboVentaDetalle))
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.txtLibrador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipPnl = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.bnfCardImporte = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardValor = New Bunifu.Framework.UI.BunifuCards()
        Me.txtFechaCobro = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnfCardTipo = New Bunifu.Framework.UI.BunifuCards()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfElipFrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCargar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlFrmArticulos.SuspendLayout()
        Me.bnfCardImporte.SuspendLayout()
        Me.bnfCardValor.SuspendLayout()
        Me.bnfCardTipo.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMoneda
        '
        Me.cmbMoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbMoneda.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(78, 16)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(221, 28)
        Me.cmbMoneda.TabIndex = 111
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(13, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "MONEDA"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(305, 21)
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
        Me.txtImporte.Location = New System.Drawing.Point(372, 17)
        Me.txtImporte.MaxLength = 20
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(219, 25)
        Me.txtImporte.TabIndex = 112
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(13, 101)
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
        Me.txtSucursal.Location = New System.Drawing.Point(90, 97)
        Me.txtSucursal.MaxLength = 255
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(501, 25)
        Me.txtSucursal.TabIndex = 125
        '
        'cmbBanco
        '
        Me.cmbBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbBanco.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(90, 55)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(501, 28)
        Me.cmbBanco.TabIndex = 115
        '
        'txtLibrador
        '
        Me.txtLibrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLibrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLibrador.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibrador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtLibrador.Location = New System.Drawing.Point(90, 135)
        Me.txtLibrador.MaxLength = 255
        Me.txtLibrador.Name = "txtLibrador"
        Me.txtLibrador.Size = New System.Drawing.Size(501, 25)
        Me.txtLibrador.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(13, 60)
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
        Me.Label4.Location = New System.Drawing.Point(13, 139)
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
        Me.Label11.Location = New System.Drawing.Point(305, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 18)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "FECHA DE COBRO"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfElpGuar
        '
        Me.bnfElpGuar.ElipseRadius = 7
        Me.bnfElpGuar.TargetControl = Me
        '
        'bnfElpCanc
        '
        Me.bnfElpCanc.ElipseRadius = 7
        Me.bnfElpCanc.TargetControl = Me
        '
        'bnfElipPnl
        '
        Me.bnfElipPnl.ElipseRadius = 20
        Me.bnfElipPnl.TargetControl = Me.pnlFrmArticulos
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardImporte)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardValor)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardTipo)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards4)
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(6, 35)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(625, 390)
        Me.pnlFrmArticulos.TabIndex = 93
        '
        'bnfCardImporte
        '
        Me.bnfCardImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardImporte.BorderRadius = 5
        Me.bnfCardImporte.BottomSahddow = True
        Me.bnfCardImporte.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardImporte.Controls.Add(Me.Label8)
        Me.bnfCardImporte.Controls.Add(Me.cmbMoneda)
        Me.bnfCardImporte.Controls.Add(Me.txtImporte)
        Me.bnfCardImporte.Controls.Add(Me.Label6)
        Me.bnfCardImporte.Enabled = False
        Me.bnfCardImporte.LeftSahddow = False
        Me.bnfCardImporte.Location = New System.Drawing.Point(11, 75)
        Me.bnfCardImporte.Name = "bnfCardImporte"
        Me.bnfCardImporte.RightSahddow = True
        Me.bnfCardImporte.ShadowDepth = 20
        Me.bnfCardImporte.Size = New System.Drawing.Size(606, 58)
        Me.bnfCardImporte.TabIndex = 114
        '
        'bnfCardValor
        '
        Me.bnfCardValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardValor.BorderRadius = 5
        Me.bnfCardValor.BottomSahddow = True
        Me.bnfCardValor.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardValor.Controls.Add(Me.txtFechaCobro)
        Me.bnfCardValor.Controls.Add(Me.Label15)
        Me.bnfCardValor.Controls.Add(Me.Label11)
        Me.bnfCardValor.Controls.Add(Me.txtNumero)
        Me.bnfCardValor.Controls.Add(Me.txtSucursal)
        Me.bnfCardValor.Controls.Add(Me.Label4)
        Me.bnfCardValor.Controls.Add(Me.Label2)
        Me.bnfCardValor.Controls.Add(Me.Label3)
        Me.bnfCardValor.Controls.Add(Me.cmbBanco)
        Me.bnfCardValor.Controls.Add(Me.txtLibrador)
        Me.bnfCardValor.Enabled = False
        Me.bnfCardValor.LeftSahddow = False
        Me.bnfCardValor.Location = New System.Drawing.Point(11, 139)
        Me.bnfCardValor.Name = "bnfCardValor"
        Me.bnfCardValor.RightSahddow = True
        Me.bnfCardValor.ShadowDepth = 20
        Me.bnfCardValor.Size = New System.Drawing.Size(606, 173)
        Me.bnfCardValor.TabIndex = 113
        '
        'txtFechaCobro
        '
        Me.txtFechaCobro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFechaCobro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaCobro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCobro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFechaCobro.Location = New System.Drawing.Point(423, 18)
        Me.txtFechaCobro.MaxLength = 10
        Me.txtFechaCobro.Name = "txtFechaCobro"
        Me.txtFechaCobro.Size = New System.Drawing.Size(168, 25)
        Me.txtFechaCobro.TabIndex = 124
        Me.txtFechaCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(90, 18)
        Me.txtNumero.MaxLength = 45
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(209, 25)
        Me.txtNumero.TabIndex = 117
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(13, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "NUMERO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfCardTipo
        '
        Me.bnfCardTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfCardTipo.BorderRadius = 5
        Me.bnfCardTipo.BottomSahddow = True
        Me.bnfCardTipo.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTipo.Controls.Add(Me.cmbTipo)
        Me.bnfCardTipo.Controls.Add(Me.Label1)
        Me.bnfCardTipo.LeftSahddow = False
        Me.bnfCardTipo.Location = New System.Drawing.Point(11, 11)
        Me.bnfCardTipo.Name = "bnfCardTipo"
        Me.bnfCardTipo.RightSahddow = True
        Me.bnfCardTipo.ShadowDepth = 20
        Me.bnfCardTipo.Size = New System.Drawing.Size(606, 58)
        Me.bnfCardTipo.TabIndex = 110
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbTipo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(78, 15)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(221, 28)
        Me.cmbTipo.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 18)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "TIPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.btnAgregar)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(11, 318)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(606, 63)
        Me.BunifuCards4.TabIndex = 108
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
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.IconoAceptar3
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(473, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 35)
        Me.btnAgregar.TabIndex = 105
        Me.btnAgregar.Text = "      Aceptar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(512, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "RECIBO DE VENTA -> DETALLE"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = False
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(637, 35)
        Me.bnfCardTitulo.TabIndex = 94
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(526, 5)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 68
        Me.txtOrigen.Visible = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(600, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'bnfElipFrm
        '
        Me.bnfElipFrm.ElipseRadius = 20
        Me.bnfElipFrm.TargetControl = Me
        '
        'bnfElpCargar
        '
        Me.bnfElpCargar.ElipseRadius = 7
        Me.bnfElpCargar.TargetControl = Me.btnAgregar
        '
        'frmReciboVentaValores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(637, 431)
        Me.Controls.Add(Me.bnfCardTitulo)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReciboVentaValores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReciboVentaValores"
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.bnfCardImporte.ResumeLayout(False)
        Me.bnfCardImporte.PerformLayout()
        Me.bnfCardValor.ResumeLayout(False)
        Me.bnfCardValor.PerformLayout()
        Me.bnfCardTipo.ResumeLayout(False)
        Me.bnfCardTipo.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbMoneda As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents cmbBanco As ComboBox
    Friend WithEvents txtLibrador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipPnl As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents bnfCardValor As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bnfCardTipo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtFechaCobro As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblTitulo As Label
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfElipFrm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnAgregar As Button
    Friend WithEvents bnfElpCargar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents bnfCardImporte As Bunifu.Framework.UI.BunifuCards
End Class
