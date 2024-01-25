<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaja))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfChkEfectivo = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bnfChkValores = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCards13 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCards12 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCards9 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSaldoTotalPeso = New System.Windows.Forms.TextBox()
        Me.BunifuCards8 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSaldoTotalDolar = New System.Windows.Forms.TextBox()
        Me.bnfCardBotones = New Bunifu.Framework.UI.BunifuCards()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSaldoChqDolar = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSaldoEfectivoDolar = New System.Windows.Forms.TextBox()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaldoChqPeso = New System.Windows.Forms.TextBox()
        Me.txtSaldoEfectivoPeso = New System.Windows.Forms.TextBox()
        Me.bnfCardFec = New Bunifu.Framework.UI.BunifuCards()
        Me.btnFiltar = New System.Windows.Forms.Button()
        Me.txtFecHasta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFecDesde = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bnfCardChq = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvValoresCartera = New System.Windows.Forms.DataGridView()
        Me.bnfCardFiltro = New Bunifu.Framework.UI.BunifuCards()
        Me.btnAño = New System.Windows.Forms.Button()
        Me.btnSemana = New System.Windows.Forms.Button()
        Me.btnHoy = New System.Windows.Forms.Button()
        Me.btnMes = New System.Windows.Forms.Button()
        Me.bnfCardMov = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfElipBtnHoy = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBtnSemana = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBtnMes = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBtnAño = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipFiltrar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlContenedor.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards13.SuspendLayout()
        Me.BunifuCards12.SuspendLayout()
        Me.BunifuCards9.SuspendLayout()
        Me.BunifuCards8.SuspendLayout()
        Me.bnfCardBotones.SuspendLayout()
        Me.BunifuCards5.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        Me.bnfCardFec.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.bnfCardChq.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.dgvValoresCartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardFiltro.SuspendLayout()
        Me.bnfCardMov.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1266, 35)
        Me.lblTitulo.TabIndex = 78
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.BunifuCards2)
        Me.pnlContenedor.Controls.Add(Me.BunifuCards13)
        Me.pnlContenedor.Controls.Add(Me.BunifuCards12)
        Me.pnlContenedor.Controls.Add(Me.BunifuCards9)
        Me.pnlContenedor.Controls.Add(Me.BunifuCards8)
        Me.pnlContenedor.Controls.Add(Me.bnfCardBotones)
        Me.pnlContenedor.Controls.Add(Me.BunifuCards5)
        Me.pnlContenedor.Controls.Add(Me.BunifuCards4)
        Me.pnlContenedor.Controls.Add(Me.bnfCardFec)
        Me.pnlContenedor.Controls.Add(Me.BunifuCards1)
        Me.pnlContenedor.Controls.Add(Me.bnfCardChq)
        Me.pnlContenedor.Controls.Add(Me.bnfCardFiltro)
        Me.pnlContenedor.Controls.Add(Me.bnfCardMov)
        Me.pnlContenedor.Controls.Add(Me.bnfCardTitulo)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1352, 827)
        Me.pnlContenedor.TabIndex = 61
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.bnfChkEfectivo)
        Me.BunifuCards2.Controls.Add(Me.Label8)
        Me.BunifuCards2.Controls.Add(Me.Label7)
        Me.BunifuCards2.Controls.Add(Me.bnfChkValores)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(11, 42)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(344, 43)
        Me.BunifuCards2.TabIndex = 123
        '
        'bnfChkEfectivo
        '
        Me.bnfChkEfectivo.AutoSize = True
        Me.bnfChkEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkEfectivo.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfChkEfectivo.Checked = True
        Me.bnfChkEfectivo.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkEfectivo.ForeColor = System.Drawing.Color.White
        Me.bnfChkEfectivo.Location = New System.Drawing.Point(11, 13)
        Me.bnfChkEfectivo.Name = "bnfChkEfectivo"
        Me.bnfChkEfectivo.Size = New System.Drawing.Size(20, 20)
        Me.bnfChkEfectivo.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(206, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 18)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "MOV. DE VALORES"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(33, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "MOV. DE EFECTIVO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfChkValores
        '
        Me.bnfChkValores.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkValores.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfChkValores.Checked = True
        Me.bnfChkValores.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkValores.ForeColor = System.Drawing.Color.White
        Me.bnfChkValores.Location = New System.Drawing.Point(184, 13)
        Me.bnfChkValores.Name = "bnfChkValores"
        Me.bnfChkValores.Size = New System.Drawing.Size(20, 20)
        Me.bnfChkValores.TabIndex = 111
        '
        'BunifuCards13
        '
        Me.BunifuCards13.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards13.BorderRadius = 5
        Me.BunifuCards13.BottomSahddow = True
        Me.BunifuCards13.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards13.Controls.Add(Me.Label4)
        Me.BunifuCards13.LeftSahddow = False
        Me.BunifuCards13.Location = New System.Drawing.Point(187, 530)
        Me.BunifuCards13.Name = "BunifuCards13"
        Me.BunifuCards13.RightSahddow = True
        Me.BunifuCards13.ShadowDepth = 20
        Me.BunifuCards13.Size = New System.Drawing.Size(168, 34)
        Me.BunifuCards13.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(9, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "PESOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards12
        '
        Me.BunifuCards12.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards12.BorderRadius = 5
        Me.BunifuCards12.BottomSahddow = True
        Me.BunifuCards12.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards12.Controls.Add(Me.Label2)
        Me.BunifuCards12.LeftSahddow = False
        Me.BunifuCards12.Location = New System.Drawing.Point(11, 530)
        Me.BunifuCards12.Name = "BunifuCards12"
        Me.BunifuCards12.RightSahddow = True
        Me.BunifuCards12.ShadowDepth = 20
        Me.BunifuCards12.Size = New System.Drawing.Size(168, 34)
        Me.BunifuCards12.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(5, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 18)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "DOLARES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards9
        '
        Me.BunifuCards9.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards9.BorderRadius = 5
        Me.BunifuCards9.BottomSahddow = True
        Me.BunifuCards9.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards9.Controls.Add(Me.Label10)
        Me.BunifuCards9.Controls.Add(Me.txtSaldoTotalPeso)
        Me.BunifuCards9.LeftSahddow = False
        Me.BunifuCards9.Location = New System.Drawing.Point(187, 693)
        Me.BunifuCards9.Name = "BunifuCards9"
        Me.BunifuCards9.RightSahddow = True
        Me.BunifuCards9.ShadowDepth = 20
        Me.BunifuCards9.Size = New System.Drawing.Size(168, 68)
        Me.BunifuCards9.TabIndex = 118
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(8, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 18)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "TOTAL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoTotalPeso
        '
        Me.txtSaldoTotalPeso.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSaldoTotalPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoTotalPeso.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoTotalPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtSaldoTotalPeso.Location = New System.Drawing.Point(8, 30)
        Me.txtSaldoTotalPeso.MaxLength = 16
        Me.txtSaldoTotalPeso.Name = "txtSaldoTotalPeso"
        Me.txtSaldoTotalPeso.ReadOnly = True
        Me.txtSaldoTotalPeso.Size = New System.Drawing.Size(149, 29)
        Me.txtSaldoTotalPeso.TabIndex = 87
        Me.txtSaldoTotalPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BunifuCards8
        '
        Me.BunifuCards8.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards8.BorderRadius = 5
        Me.BunifuCards8.BottomSahddow = True
        Me.BunifuCards8.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards8.Controls.Add(Me.Label24)
        Me.BunifuCards8.Controls.Add(Me.txtSaldoTotalDolar)
        Me.BunifuCards8.LeftSahddow = False
        Me.BunifuCards8.Location = New System.Drawing.Point(11, 693)
        Me.BunifuCards8.Name = "BunifuCards8"
        Me.BunifuCards8.RightSahddow = True
        Me.BunifuCards8.ShadowDepth = 20
        Me.BunifuCards8.Size = New System.Drawing.Size(168, 68)
        Me.BunifuCards8.TabIndex = 117
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LightGray
        Me.Label24.Location = New System.Drawing.Point(8, 10)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(150, 18)
        Me.Label24.TabIndex = 82
        Me.Label24.Text = "TOTAL"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoTotalDolar
        '
        Me.txtSaldoTotalDolar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSaldoTotalDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoTotalDolar.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoTotalDolar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtSaldoTotalDolar.Location = New System.Drawing.Point(8, 30)
        Me.txtSaldoTotalDolar.MaxLength = 16
        Me.txtSaldoTotalDolar.Name = "txtSaldoTotalDolar"
        Me.txtSaldoTotalDolar.ReadOnly = True
        Me.txtSaldoTotalDolar.Size = New System.Drawing.Size(150, 29)
        Me.txtSaldoTotalDolar.TabIndex = 81
        Me.txtSaldoTotalDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bnfCardBotones
        '
        Me.bnfCardBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardBotones.BorderRadius = 5
        Me.bnfCardBotones.BottomSahddow = True
        Me.bnfCardBotones.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardBotones.Controls.Add(Me.btnNuevo)
        Me.bnfCardBotones.Controls.Add(Me.btnEliminar)
        Me.bnfCardBotones.LeftSahddow = False
        Me.bnfCardBotones.Location = New System.Drawing.Point(11, 279)
        Me.bnfCardBotones.Name = "bnfCardBotones"
        Me.bnfCardBotones.RightSahddow = True
        Me.bnfCardBotones.ShadowDepth = 20
        Me.bnfCardBotones.Size = New System.Drawing.Size(344, 60)
        Me.bnfCardBotones.TabIndex = 111
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
        Me.btnNuevo.Location = New System.Drawing.Point(10, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(150, 35)
        Me.btnNuevo.TabIndex = 113
        Me.btnNuevo.Text = "    Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnEliminar.Location = New System.Drawing.Point(184, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(150, 35)
        Me.btnEliminar.TabIndex = 117
        Me.btnEliminar.Text = "      Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'BunifuCards5
        '
        Me.BunifuCards5.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards5.BorderRadius = 5
        Me.BunifuCards5.BottomSahddow = True
        Me.BunifuCards5.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards5.Controls.Add(Me.Label1)
        Me.BunifuCards5.Controls.Add(Me.txtSaldoChqDolar)
        Me.BunifuCards5.Controls.Add(Me.Label22)
        Me.BunifuCards5.Controls.Add(Me.txtSaldoEfectivoDolar)
        Me.BunifuCards5.LeftSahddow = False
        Me.BunifuCards5.Location = New System.Drawing.Point(11, 569)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = True
        Me.BunifuCards5.ShadowDepth = 20
        Me.BunifuCards5.Size = New System.Drawing.Size(168, 118)
        Me.BunifuCards5.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(8, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 18)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "EFECTIVO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoChqDolar
        '
        Me.txtSaldoChqDolar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSaldoChqDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoChqDolar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoChqDolar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSaldoChqDolar.Location = New System.Drawing.Point(8, 35)
        Me.txtSaldoChqDolar.MaxLength = 16
        Me.txtSaldoChqDolar.Name = "txtSaldoChqDolar"
        Me.txtSaldoChqDolar.ReadOnly = True
        Me.txtSaldoChqDolar.Size = New System.Drawing.Size(150, 23)
        Me.txtSaldoChqDolar.TabIndex = 77
        Me.txtSaldoChqDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LightGray
        Me.Label22.Location = New System.Drawing.Point(8, 14)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(150, 18)
        Me.Label22.TabIndex = 78
        Me.Label22.Text = "VALORES"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoEfectivoDolar
        '
        Me.txtSaldoEfectivoDolar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSaldoEfectivoDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoEfectivoDolar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoEfectivoDolar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSaldoEfectivoDolar.Location = New System.Drawing.Point(8, 83)
        Me.txtSaldoEfectivoDolar.MaxLength = 16
        Me.txtSaldoEfectivoDolar.Name = "txtSaldoEfectivoDolar"
        Me.txtSaldoEfectivoDolar.ReadOnly = True
        Me.txtSaldoEfectivoDolar.Size = New System.Drawing.Size(150, 23)
        Me.txtSaldoEfectivoDolar.TabIndex = 79
        Me.txtSaldoEfectivoDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.Label12)
        Me.BunifuCards4.Controls.Add(Me.Label6)
        Me.BunifuCards4.Controls.Add(Me.txtSaldoChqPeso)
        Me.BunifuCards4.Controls.Add(Me.txtSaldoEfectivoPeso)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(187, 569)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(168, 118)
        Me.BunifuCards4.TabIndex = 114
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(8, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 18)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "EFECTIVO"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(8, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 18)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "VALORES"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoChqPeso
        '
        Me.txtSaldoChqPeso.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSaldoChqPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoChqPeso.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoChqPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSaldoChqPeso.Location = New System.Drawing.Point(8, 35)
        Me.txtSaldoChqPeso.MaxLength = 16
        Me.txtSaldoChqPeso.Name = "txtSaldoChqPeso"
        Me.txtSaldoChqPeso.ReadOnly = True
        Me.txtSaldoChqPeso.Size = New System.Drawing.Size(149, 23)
        Me.txtSaldoChqPeso.TabIndex = 83
        Me.txtSaldoChqPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoEfectivoPeso
        '
        Me.txtSaldoEfectivoPeso.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSaldoEfectivoPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoEfectivoPeso.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoEfectivoPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSaldoEfectivoPeso.Location = New System.Drawing.Point(8, 83)
        Me.txtSaldoEfectivoPeso.MaxLength = 16
        Me.txtSaldoEfectivoPeso.Name = "txtSaldoEfectivoPeso"
        Me.txtSaldoEfectivoPeso.ReadOnly = True
        Me.txtSaldoEfectivoPeso.Size = New System.Drawing.Size(149, 23)
        Me.txtSaldoEfectivoPeso.TabIndex = 85
        Me.txtSaldoEfectivoPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bnfCardFec
        '
        Me.bnfCardFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardFec.BorderRadius = 5
        Me.bnfCardFec.BottomSahddow = True
        Me.bnfCardFec.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardFec.Controls.Add(Me.btnFiltar)
        Me.bnfCardFec.Controls.Add(Me.txtFecHasta)
        Me.bnfCardFec.Controls.Add(Me.Label9)
        Me.bnfCardFec.Controls.Add(Me.txtFecDesde)
        Me.bnfCardFec.Controls.Add(Me.Label20)
        Me.bnfCardFec.LeftSahddow = False
        Me.bnfCardFec.Location = New System.Drawing.Point(187, 91)
        Me.bnfCardFec.Name = "bnfCardFec"
        Me.bnfCardFec.RightSahddow = True
        Me.bnfCardFec.ShadowDepth = 20
        Me.bnfCardFec.Size = New System.Drawing.Size(168, 182)
        Me.bnfCardFec.TabIndex = 113
        '
        'btnFiltar
        '
        Me.btnFiltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnFiltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltar.FlatAppearance.BorderSize = 0
        Me.btnFiltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnFiltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltar.ForeColor = System.Drawing.Color.White
        Me.btnFiltar.Image = Global.Presentacion.My.Resources.Resources.IconoCalendario
        Me.btnFiltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltar.Location = New System.Drawing.Point(8, 137)
        Me.btnFiltar.Name = "btnFiltar"
        Me.btnFiltar.Size = New System.Drawing.Size(150, 35)
        Me.btnFiltar.TabIndex = 113
        Me.btnFiltar.Text = "     Filtrar"
        Me.btnFiltar.UseVisualStyleBackColor = False
        '
        'txtFecHasta
        '
        Me.txtFecHasta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecHasta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFecHasta.Location = New System.Drawing.Point(8, 97)
        Me.txtFecHasta.MaxLength = 10
        Me.txtFecHasta.Name = "txtFecHasta"
        Me.txtFecHasta.Size = New System.Drawing.Size(150, 25)
        Me.txtFecHasta.TabIndex = 112
        Me.txtFecHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(8, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 20)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "FECHA HASTA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFecDesde
        '
        Me.txtFecDesde.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecDesde.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFecDesde.Location = New System.Drawing.Point(8, 39)
        Me.txtFecDesde.MaxLength = 10
        Me.txtFecDesde.Name = "txtFecDesde"
        Me.txtFecDesde.Size = New System.Drawing.Size(150, 25)
        Me.txtFecDesde.TabIndex = 110
        Me.txtFecDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LightGray
        Me.Label20.Location = New System.Drawing.Point(8, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(150, 20)
        Me.Label20.TabIndex = 109
        Me.Label20.Text = "FECHA DESDE"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.txtTC)
        Me.BunifuCards1.Controls.Add(Me.lblBanco)
        Me.BunifuCards1.Controls.Add(Me.Label11)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(11, 767)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(344, 51)
        Me.BunifuCards1.TabIndex = 112
        '
        'txtTC
        '
        Me.txtTC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTC.Location = New System.Drawing.Point(50, 15)
        Me.txtTC.MaxLength = 16
        Me.txtTC.Name = "txtTC"
        Me.txtTC.ReadOnly = True
        Me.txtTC.Size = New System.Drawing.Size(146, 25)
        Me.txtTC.TabIndex = 105
        Me.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBanco
        '
        Me.lblBanco.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.LightGray
        Me.lblBanco.Location = New System.Drawing.Point(202, 14)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(131, 30)
        Me.lblBanco.TabIndex = 106
        Me.lblBanco.Text = "BANCO NACION 01/07/2021"
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(7, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 18)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "T. C."
        '
        'bnfCardChq
        '
        Me.bnfCardChq.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardChq.BorderRadius = 5
        Me.bnfCardChq.BottomSahddow = True
        Me.bnfCardChq.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardChq.Controls.Add(Me.BunifuCards3)
        Me.bnfCardChq.Controls.Add(Me.dgvValoresCartera)
        Me.bnfCardChq.LeftSahddow = False
        Me.bnfCardChq.Location = New System.Drawing.Point(361, 433)
        Me.bnfCardChq.Name = "bnfCardChq"
        Me.bnfCardChq.RightSahddow = True
        Me.bnfCardChq.ShadowDepth = 20
        Me.bnfCardChq.Size = New System.Drawing.Size(980, 385)
        Me.bnfCardChq.TabIndex = 109
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
        Me.BunifuCards3.Size = New System.Drawing.Size(967, 33)
        Me.BunifuCards3.TabIndex = 108
        '
        'Label5
        '
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
        Me.dgvValoresCartera.Enabled = False
        Me.dgvValoresCartera.Location = New System.Drawing.Point(9, 43)
        Me.dgvValoresCartera.Name = "dgvValoresCartera"
        Me.dgvValoresCartera.Size = New System.Drawing.Size(961, 330)
        Me.dgvValoresCartera.TabIndex = 64
        '
        'bnfCardFiltro
        '
        Me.bnfCardFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardFiltro.BorderRadius = 5
        Me.bnfCardFiltro.BottomSahddow = True
        Me.bnfCardFiltro.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardFiltro.Controls.Add(Me.btnAño)
        Me.bnfCardFiltro.Controls.Add(Me.btnSemana)
        Me.bnfCardFiltro.Controls.Add(Me.btnHoy)
        Me.bnfCardFiltro.Controls.Add(Me.btnMes)
        Me.bnfCardFiltro.LeftSahddow = False
        Me.bnfCardFiltro.Location = New System.Drawing.Point(11, 91)
        Me.bnfCardFiltro.Name = "bnfCardFiltro"
        Me.bnfCardFiltro.RightSahddow = True
        Me.bnfCardFiltro.ShadowDepth = 20
        Me.bnfCardFiltro.Size = New System.Drawing.Size(168, 182)
        Me.bnfCardFiltro.TabIndex = 107
        '
        'btnAño
        '
        Me.btnAño.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAño.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAño.FlatAppearance.BorderSize = 0
        Me.btnAño.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAño.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAño.ForeColor = System.Drawing.Color.White
        Me.btnAño.Image = Global.Presentacion.My.Resources.Resources.IconoCalendario
        Me.btnAño.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAño.Location = New System.Drawing.Point(8, 137)
        Me.btnAño.Name = "btnAño"
        Me.btnAño.Size = New System.Drawing.Size(150, 35)
        Me.btnAño.TabIndex = 108
        Me.btnAño.Text = "     Este Año"
        Me.btnAño.UseVisualStyleBackColor = False
        '
        'btnSemana
        '
        Me.btnSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnSemana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSemana.FlatAppearance.BorderSize = 0
        Me.btnSemana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSemana.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemana.ForeColor = System.Drawing.Color.White
        Me.btnSemana.Image = Global.Presentacion.My.Resources.Resources.IconoCalendario
        Me.btnSemana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSemana.Location = New System.Drawing.Point(8, 54)
        Me.btnSemana.Name = "btnSemana"
        Me.btnSemana.Size = New System.Drawing.Size(150, 35)
        Me.btnSemana.TabIndex = 106
        Me.btnSemana.Text = "      Esta Semana"
        Me.btnSemana.UseVisualStyleBackColor = False
        '
        'btnHoy
        '
        Me.btnHoy.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnHoy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHoy.FlatAppearance.BorderSize = 0
        Me.btnHoy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHoy.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoy.ForeColor = System.Drawing.Color.White
        Me.btnHoy.Image = Global.Presentacion.My.Resources.Resources.IconoCalendario
        Me.btnHoy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHoy.Location = New System.Drawing.Point(8, 12)
        Me.btnHoy.Name = "btnHoy"
        Me.btnHoy.Size = New System.Drawing.Size(150, 35)
        Me.btnHoy.TabIndex = 104
        Me.btnHoy.Text = "     Hoy"
        Me.btnHoy.UseVisualStyleBackColor = False
        '
        'btnMes
        '
        Me.btnMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnMes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMes.FlatAppearance.BorderSize = 0
        Me.btnMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMes.ForeColor = System.Drawing.Color.White
        Me.btnMes.Image = Global.Presentacion.My.Resources.Resources.IconoCalendario
        Me.btnMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMes.Location = New System.Drawing.Point(8, 95)
        Me.btnMes.Name = "btnMes"
        Me.btnMes.Size = New System.Drawing.Size(150, 35)
        Me.btnMes.TabIndex = 105
        Me.btnMes.Text = "     Este Mes"
        Me.btnMes.UseVisualStyleBackColor = False
        '
        'bnfCardMov
        '
        Me.bnfCardMov.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardMov.BorderRadius = 5
        Me.bnfCardMov.BottomSahddow = True
        Me.bnfCardMov.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardMov.Controls.Add(Me.BunifuCards6)
        Me.bnfCardMov.Controls.Add(Me.dgvMovimientos)
        Me.bnfCardMov.LeftSahddow = False
        Me.bnfCardMov.Location = New System.Drawing.Point(361, 42)
        Me.bnfCardMov.Name = "bnfCardMov"
        Me.bnfCardMov.RightSahddow = True
        Me.bnfCardMov.ShadowDepth = 20
        Me.bnfCardMov.Size = New System.Drawing.Size(980, 385)
        Me.bnfCardMov.TabIndex = 100
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.Label3)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(967, 33)
        Me.BunifuCards6.TabIndex = 107
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(487, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "MOVIMIENTOS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Location = New System.Drawing.Point(9, 43)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.Size = New System.Drawing.Size(961, 330)
        Me.dgvMovimientos.TabIndex = 64
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 5
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.pbxTitulo)
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
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoCaja
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
        'bnfElipBtnHoy
        '
        Me.bnfElipBtnHoy.ElipseRadius = 7
        Me.bnfElipBtnHoy.TargetControl = Me.btnHoy
        '
        'bnfElipBtnSemana
        '
        Me.bnfElipBtnSemana.ElipseRadius = 7
        Me.bnfElipBtnSemana.TargetControl = Me.btnSemana
        '
        'bnfElipBtnMes
        '
        Me.bnfElipBtnMes.ElipseRadius = 7
        Me.bnfElipBtnMes.TargetControl = Me.btnMes
        '
        'bnfElipBtnAño
        '
        Me.bnfElipBtnAño.ElipseRadius = 7
        Me.bnfElipBtnAño.TargetControl = Me.btnAño
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'bnfElpMod
        '
        Me.bnfElpMod.ElipseRadius = 7
        Me.bnfElpMod.TargetControl = Me
        '
        'bnfElpNuevo
        '
        Me.bnfElpNuevo.ElipseRadius = 7
        Me.bnfElpNuevo.TargetControl = Me.btnNuevo
        '
        'bnfElpCanc
        '
        Me.bnfElpCanc.ElipseRadius = 7
        Me.bnfElpCanc.TargetControl = Me
        '
        'bnfElpGuar
        '
        Me.bnfElpGuar.ElipseRadius = 7
        Me.bnfElpGuar.TargetControl = Me
        '
        'bnfElpElim
        '
        Me.bnfElpElim.ElipseRadius = 7
        Me.bnfElpElim.TargetControl = Me.btnEliminar
        '
        'bnfElipFiltrar
        '
        Me.bnfElipFiltrar.ElipseRadius = 7
        Me.bnfElipFiltrar.TargetControl = Me.btnFiltar
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlContenedor)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCaja"
        Me.Text = "frmCajas"
        Me.pnlContenedor.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards13.ResumeLayout(False)
        Me.BunifuCards12.ResumeLayout(False)
        Me.BunifuCards9.ResumeLayout(False)
        Me.BunifuCards9.PerformLayout()
        Me.BunifuCards8.ResumeLayout(False)
        Me.BunifuCards8.PerformLayout()
        Me.bnfCardBotones.ResumeLayout(False)
        Me.BunifuCards5.ResumeLayout(False)
        Me.BunifuCards5.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        Me.bnfCardFec.ResumeLayout(False)
        Me.bnfCardFec.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.bnfCardChq.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        CType(Me.dgvValoresCartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardFiltro.ResumeLayout(False)
        Me.bnfCardMov.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTitulo.ResumeLayout(False)
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardMov As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnMes As Button
    Friend WithEvents btnSemana As Button
    Friend WithEvents btnHoy As Button
    Friend WithEvents dgvMovimientos As DataGridView
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents bnfCardFiltro As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSaldoEfectivoDolar As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtSaldoChqDolar As TextBox
    Friend WithEvents txtSaldoTotalPeso As TextBox
    Friend WithEvents txtSaldoEfectivoPeso As TextBox
    Friend WithEvents txtSaldoTotalDolar As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtSaldoChqPeso As TextBox
    Friend WithEvents btnAño As Button
    Friend WithEvents bnfElipBtnHoy As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipBtnSemana As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipBtnMes As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipBtnAño As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfCardChq As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvValoresCartera As DataGridView
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label5 As Label
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label11 As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents txtTC As TextBox
    Friend WithEvents bnfCardBotones As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label8 As Label
    Friend WithEvents bnfChkValores As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label7 As Label
    Friend WithEvents bnfChkEfectivo As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents bnfCardFec As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtFecHasta As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFecDesde As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BunifuCards9 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards8 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards13 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards12 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnFiltar As Button
    Friend WithEvents bnfElipFiltrar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
End Class
