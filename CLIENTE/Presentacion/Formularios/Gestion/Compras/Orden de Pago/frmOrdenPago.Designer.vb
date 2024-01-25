<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenPago))
        Me.txtIdOrden = New System.Windows.Forms.TextBox()
        Me.pnlFrmRemComp = New System.Windows.Forms.Panel()
        Me.bnfCardProv = New Bunifu.Framework.UI.BunifuCards()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRSprov = New System.Windows.Forms.TextBox()
        Me.txtCtaProv = New System.Windows.Forms.TextBox()
        Me.bnfCardTc = New Bunifu.Framework.UI.BunifuCards()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.bnfCardNum = New Bunifu.Framework.UI.BunifuCards()
        Me.cmbPtoVta = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNroOrden = New System.Windows.Forms.TextBox()
        Me.bnfCardObs = New Bunifu.Framework.UI.BunifuCards()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.bnfCardFec = New Bunifu.Framework.UI.BunifuCards()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFec = New System.Windows.Forms.TextBox()
        Me.bnfCardInfoProv = New Bunifu.Framework.UI.BunifuCards()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTE = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtIIBB = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDirec = New System.Windows.Forms.Label()
        Me.txtProv = New System.Windows.Forms.Label()
        Me.bncBotones = New Bunifu.Framework.UI.BunifuCards()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfCardDetalleOrden = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtEfectivoDolares = New System.Windows.Forms.TextBox()
        Me.txtEfectivoPesos = New System.Windows.Forms.TextBox()
        Me.txtTotalDolares = New System.Windows.Forms.TextBox()
        Me.txtTotalPesos = New System.Windows.Forms.TextBox()
        Me.txtValoresCarteraDalores = New System.Windows.Forms.TextBox()
        Me.txtValoresPropiosDolares = New System.Windows.Forms.TextBox()
        Me.txtValoresPropiosPesos = New System.Windows.Forms.TextBox()
        Me.txtValoresCarteraPesos = New System.Windows.Forms.TextBox()
        Me.btnChequePropio = New System.Windows.Forms.Button()
        Me.btnValorCartera = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEfectivo = New System.Windows.Forms.Button()
        Me.dgvDetalleOrden = New System.Windows.Forms.DataGridView()
        Me.bnfDesdeRmt = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipCarg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBorr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfElipEditar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipQuitar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipEfectivo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipValorCartera = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipValorPropio = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlFrmRemComp.SuspendLayout()
        Me.bnfCardProv.SuspendLayout()
        Me.bnfCardTc.SuspendLayout()
        Me.bnfCardNum.SuspendLayout()
        Me.bnfCardObs.SuspendLayout()
        Me.bnfCardFec.SuspendLayout()
        Me.bnfCardInfoProv.SuspendLayout()
        Me.bncBotones.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardDetalleOrden.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdOrden
        '
        Me.txtIdOrden.BackColor = System.Drawing.Color.Red
        Me.txtIdOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdOrden.Enabled = False
        Me.txtIdOrden.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOrden.ForeColor = System.Drawing.Color.White
        Me.txtIdOrden.Location = New System.Drawing.Point(971, 5)
        Me.txtIdOrden.Name = "txtIdOrden"
        Me.txtIdOrden.Size = New System.Drawing.Size(68, 25)
        Me.txtIdOrden.TabIndex = 63
        Me.txtIdOrden.Visible = False
        '
        'pnlFrmRemComp
        '
        Me.pnlFrmRemComp.AutoScroll = True
        Me.pnlFrmRemComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmRemComp.Controls.Add(Me.bnfCardProv)
        Me.pnlFrmRemComp.Controls.Add(Me.bnfCardTc)
        Me.pnlFrmRemComp.Controls.Add(Me.bnfCardNum)
        Me.pnlFrmRemComp.Controls.Add(Me.bnfCardObs)
        Me.pnlFrmRemComp.Controls.Add(Me.bnfCardFec)
        Me.pnlFrmRemComp.Controls.Add(Me.bnfCardInfoProv)
        Me.pnlFrmRemComp.Controls.Add(Me.bncBotones)
        Me.pnlFrmRemComp.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmRemComp.Controls.Add(Me.bnfCardDetalleOrden)
        Me.pnlFrmRemComp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmRemComp.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmRemComp.Name = "pnlFrmRemComp"
        Me.pnlFrmRemComp.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmRemComp.TabIndex = 61
        '
        'bnfCardProv
        '
        Me.bnfCardProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardProv.BorderRadius = 5
        Me.bnfCardProv.BottomSahddow = True
        Me.bnfCardProv.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardProv.Controls.Add(Me.Label2)
        Me.bnfCardProv.Controls.Add(Me.Label1)
        Me.bnfCardProv.Controls.Add(Me.txtRSprov)
        Me.bnfCardProv.Controls.Add(Me.txtCtaProv)
        Me.bnfCardProv.Enabled = False
        Me.bnfCardProv.LeftSahddow = False
        Me.bnfCardProv.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardProv.Name = "bnfCardProv"
        Me.bnfCardProv.RightSahddow = True
        Me.bnfCardProv.ShadowDepth = 20
        Me.bnfCardProv.Size = New System.Drawing.Size(622, 70)
        Me.bnfCardProv.TabIndex = 115
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
        'bnfCardTc
        '
        Me.bnfCardTc.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardTc.BorderRadius = 5
        Me.bnfCardTc.BottomSahddow = True
        Me.bnfCardTc.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTc.Controls.Add(Me.Label21)
        Me.bnfCardTc.Controls.Add(Me.txtTC)
        Me.bnfCardTc.Controls.Add(Me.lblBanco)
        Me.bnfCardTc.Enabled = False
        Me.bnfCardTc.LeftSahddow = False
        Me.bnfCardTc.Location = New System.Drawing.Point(812, 41)
        Me.bnfCardTc.Name = "bnfCardTc"
        Me.bnfCardTc.RightSahddow = True
        Me.bnfCardTc.ShadowDepth = 20
        Me.bnfCardTc.Size = New System.Drawing.Size(167, 97)
        Me.bnfCardTc.TabIndex = 114
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LightGray
        Me.Label21.Location = New System.Drawing.Point(10, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 18)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "TIPO DE CAMBIO"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTC
        '
        Me.txtTC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTC.Location = New System.Drawing.Point(10, 33)
        Me.txtTC.MaxLength = 16
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(147, 25)
        Me.txtTC.TabIndex = 74
        Me.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBanco
        '
        Me.lblBanco.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.LightGray
        Me.lblBanco.Location = New System.Drawing.Point(10, 61)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(147, 26)
        Me.lblBanco.TabIndex = 76
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnfCardNum
        '
        Me.bnfCardNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardNum.BorderRadius = 5
        Me.bnfCardNum.BottomSahddow = True
        Me.bnfCardNum.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardNum.Controls.Add(Me.cmbPtoVta)
        Me.bnfCardNum.Controls.Add(Me.Label22)
        Me.bnfCardNum.Controls.Add(Me.Label23)
        Me.bnfCardNum.Controls.Add(Me.txtNroOrden)
        Me.bnfCardNum.Enabled = False
        Me.bnfCardNum.LeftSahddow = False
        Me.bnfCardNum.Location = New System.Drawing.Point(639, 117)
        Me.bnfCardNum.Name = "bnfCardNum"
        Me.bnfCardNum.RightSahddow = True
        Me.bnfCardNum.ShadowDepth = 20
        Me.bnfCardNum.Size = New System.Drawing.Size(167, 180)
        Me.bnfCardNum.TabIndex = 113
        '
        'cmbPtoVta
        '
        Me.cmbPtoVta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbPtoVta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPtoVta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbPtoVta.FormattingEnabled = True
        Me.cmbPtoVta.ItemHeight = 20
        Me.cmbPtoVta.Location = New System.Drawing.Point(9, 50)
        Me.cmbPtoVta.Name = "cmbPtoVta"
        Me.cmbPtoVta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPtoVta.Size = New System.Drawing.Size(147, 28)
        Me.cmbPtoVta.TabIndex = 106
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LightGray
        Me.Label22.Location = New System.Drawing.Point(9, 106)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(147, 18)
        Me.Label22.TabIndex = 77
        Me.Label22.Text = "NRO ORDEN"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.LightGray
        Me.Label23.Location = New System.Drawing.Point(9, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(147, 18)
        Me.Label23.TabIndex = 91
        Me.Label23.Text = "PTO. DE VTA."
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNroOrden
        '
        Me.txtNroOrden.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOrden.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrden.ForeColor = System.Drawing.Color.DimGray
        Me.txtNroOrden.Location = New System.Drawing.Point(9, 126)
        Me.txtNroOrden.MaxLength = 255
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.ReadOnly = True
        Me.txtNroOrden.Size = New System.Drawing.Size(147, 25)
        Me.txtNroOrden.TabIndex = 78
        Me.txtNroOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bnfCardObs
        '
        Me.bnfCardObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardObs.BorderRadius = 5
        Me.bnfCardObs.BottomSahddow = True
        Me.bnfCardObs.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardObs.Controls.Add(Me.Label3)
        Me.bnfCardObs.Controls.Add(Me.txtObservaciones)
        Me.bnfCardObs.Enabled = False
        Me.bnfCardObs.LeftSahddow = False
        Me.bnfCardObs.Location = New System.Drawing.Point(11, 741)
        Me.bnfCardObs.Name = "bnfCardObs"
        Me.bnfCardObs.RightSahddow = True
        Me.bnfCardObs.ShadowDepth = 20
        Me.bnfCardObs.Size = New System.Drawing.Size(478, 74)
        Me.bnfCardObs.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "OBSERVACIONES"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtObservaciones.Location = New System.Drawing.Point(8, 26)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(461, 40)
        Me.txtObservaciones.TabIndex = 99
        '
        'bnfCardFec
        '
        Me.bnfCardFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardFec.BorderRadius = 5
        Me.bnfCardFec.BottomSahddow = True
        Me.bnfCardFec.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardFec.Controls.Add(Me.Label6)
        Me.bnfCardFec.Controls.Add(Me.txtFec)
        Me.bnfCardFec.Enabled = False
        Me.bnfCardFec.LeftSahddow = False
        Me.bnfCardFec.Location = New System.Drawing.Point(639, 41)
        Me.bnfCardFec.Name = "bnfCardFec"
        Me.bnfCardFec.RightSahddow = True
        Me.bnfCardFec.ShadowDepth = 20
        Me.bnfCardFec.Size = New System.Drawing.Size(167, 70)
        Me.bnfCardFec.TabIndex = 96
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 18)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "FECHA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFec
        '
        Me.txtFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFec.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFec.Location = New System.Drawing.Point(9, 33)
        Me.txtFec.MaxLength = 10
        Me.txtFec.Name = "txtFec"
        Me.txtFec.Size = New System.Drawing.Size(147, 25)
        Me.txtFec.TabIndex = 66
        Me.txtFec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.bnfCardInfoProv.Controls.Add(Me.Label8)
        Me.bnfCardInfoProv.Controls.Add(Me.txtDirec)
        Me.bnfCardInfoProv.Controls.Add(Me.txtProv)
        Me.bnfCardInfoProv.Enabled = False
        Me.bnfCardInfoProv.LeftSahddow = False
        Me.bnfCardInfoProv.Location = New System.Drawing.Point(11, 117)
        Me.bnfCardInfoProv.Name = "bnfCardInfoProv"
        Me.bnfCardInfoProv.RightSahddow = True
        Me.bnfCardInfoProv.ShadowDepth = 20
        Me.bnfCardInfoProv.Size = New System.Drawing.Size(622, 180)
        Me.bnfCardInfoProv.TabIndex = 94
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
        Me.Label10.Location = New System.Drawing.Point(7, 18)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(7, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "LOCALIDAD"
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
        'bncBotones
        '
        Me.bncBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bncBotones.BorderRadius = 5
        Me.bncBotones.BottomSahddow = True
        Me.bncBotones.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bncBotones.Controls.Add(Me.btnEliminar)
        Me.bncBotones.Controls.Add(Me.btnCancelar)
        Me.bncBotones.Controls.Add(Me.btnNuevo)
        Me.bncBotones.Controls.Add(Me.btnGuardar)
        Me.bncBotones.Controls.Add(Me.btnModificar)
        Me.bncBotones.LeftSahddow = False
        Me.bncBotones.Location = New System.Drawing.Point(651, 741)
        Me.bncBotones.Name = "bncBotones"
        Me.bncBotones.RightSahddow = True
        Me.bncBotones.ShadowDepth = 20
        Me.bncBotones.Size = New System.Drawing.Size(690, 74)
        Me.bncBotones.TabIndex = 59
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
        Me.btnNuevo.Text = "     Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdOrden)
        Me.bnfCardTitulo.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = True
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTitulo.TabIndex = 55
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(1045, 5)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 82
        Me.txtOrigen.Visible = False
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoOrdenPago
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 81
        Me.pbxTitulo.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1015, 35)
        Me.lblTitulo.TabIndex = 80
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
        'bnfCardDetalleOrden
        '
        Me.bnfCardDetalleOrden.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDetalleOrden.BorderRadius = 5
        Me.bnfCardDetalleOrden.BottomSahddow = True
        Me.bnfCardDetalleOrden.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDetalleOrden.Controls.Add(Me.BunifuCards6)
        Me.bnfCardDetalleOrden.Controls.Add(Me.btnChequePropio)
        Me.bnfCardDetalleOrden.Controls.Add(Me.btnValorCartera)
        Me.bnfCardDetalleOrden.Controls.Add(Me.btnQuitar)
        Me.bnfCardDetalleOrden.Controls.Add(Me.btnEditar)
        Me.bnfCardDetalleOrden.Controls.Add(Me.btnEfectivo)
        Me.bnfCardDetalleOrden.Controls.Add(Me.dgvDetalleOrden)
        Me.bnfCardDetalleOrden.Enabled = False
        Me.bnfCardDetalleOrden.LeftSahddow = False
        Me.bnfCardDetalleOrden.Location = New System.Drawing.Point(11, 303)
        Me.bnfCardDetalleOrden.Name = "bnfCardDetalleOrden"
        Me.bnfCardDetalleOrden.RightSahddow = True
        Me.bnfCardDetalleOrden.ShadowDepth = 20
        Me.bnfCardDetalleOrden.Size = New System.Drawing.Size(1330, 430)
        Me.bnfCardDetalleOrden.TabIndex = 98
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 0
        Me.BunifuCards6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCards6.BottomSahddow = False
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.Label29)
        Me.BunifuCards6.Controls.Add(Me.Label26)
        Me.BunifuCards6.Controls.Add(Me.Label27)
        Me.BunifuCards6.Controls.Add(Me.Label28)
        Me.BunifuCards6.Controls.Add(Me.txtEfectivoDolares)
        Me.BunifuCards6.Controls.Add(Me.txtEfectivoPesos)
        Me.BunifuCards6.Controls.Add(Me.txtTotalDolares)
        Me.BunifuCards6.Controls.Add(Me.txtTotalPesos)
        Me.BunifuCards6.Controls.Add(Me.txtValoresCarteraDalores)
        Me.BunifuCards6.Controls.Add(Me.txtValoresPropiosDolares)
        Me.BunifuCards6.Controls.Add(Me.txtValoresPropiosPesos)
        Me.BunifuCards6.Controls.Add(Me.txtValoresCarteraPesos)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(0, 385)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = False
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(1329, 43)
        Me.BunifuCards6.TabIndex = 111
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.LightGray
        Me.Label29.Location = New System.Drawing.Point(1013, 9)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(36, 18)
        Me.Label29.TabIndex = 97
        Me.Label29.Text = "TOT."
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.LightGray
        Me.Label26.Location = New System.Drawing.Point(668, 9)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 18)
        Me.Label26.TabIndex = 96
        Me.Label26.Text = "VAL. PRO."
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.LightGray
        Me.Label27.Location = New System.Drawing.Point(324, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 18)
        Me.Label27.TabIndex = 95
        Me.Label27.Text = "VAL. CAR."
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.LightGray
        Me.Label28.Location = New System.Drawing.Point(3, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 18)
        Me.Label28.TabIndex = 94
        Me.Label28.Text = "EFVO."
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEfectivoDolares
        '
        Me.txtEfectivoDolares.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtEfectivoDolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEfectivoDolares.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivoDolares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtEfectivoDolares.Location = New System.Drawing.Point(188, 7)
        Me.txtEfectivoDolares.MaxLength = 16
        Me.txtEfectivoDolares.Name = "txtEfectivoDolares"
        Me.txtEfectivoDolares.ReadOnly = True
        Me.txtEfectivoDolares.Size = New System.Drawing.Size(130, 23)
        Me.txtEfectivoDolares.TabIndex = 83
        Me.txtEfectivoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEfectivoPesos
        '
        Me.txtEfectivoPesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtEfectivoPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEfectivoPesos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivoPesos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtEfectivoPesos.Location = New System.Drawing.Point(54, 7)
        Me.txtEfectivoPesos.MaxLength = 16
        Me.txtEfectivoPesos.Name = "txtEfectivoPesos"
        Me.txtEfectivoPesos.ReadOnly = True
        Me.txtEfectivoPesos.Size = New System.Drawing.Size(130, 23)
        Me.txtEfectivoPesos.TabIndex = 77
        Me.txtEfectivoPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDolares
        '
        Me.txtTotalDolares.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTotalDolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDolares.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtTotalDolares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtTotalDolares.Location = New System.Drawing.Point(1189, 7)
        Me.txtTotalDolares.MaxLength = 16
        Me.txtTotalDolares.Name = "txtTotalDolares"
        Me.txtTotalDolares.ReadOnly = True
        Me.txtTotalDolares.Size = New System.Drawing.Size(130, 23)
        Me.txtTotalDolares.TabIndex = 101
        Me.txtTotalDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPesos
        '
        Me.txtTotalPesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTotalPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPesos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtTotalPesos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtTotalPesos.Location = New System.Drawing.Point(1055, 7)
        Me.txtTotalPesos.MaxLength = 16
        Me.txtTotalPesos.Name = "txtTotalPesos"
        Me.txtTotalPesos.ReadOnly = True
        Me.txtTotalPesos.Size = New System.Drawing.Size(130, 23)
        Me.txtTotalPesos.TabIndex = 99
        Me.txtTotalPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValoresCarteraDalores
        '
        Me.txtValoresCarteraDalores.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtValoresCarteraDalores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValoresCarteraDalores.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValoresCarteraDalores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtValoresCarteraDalores.Location = New System.Drawing.Point(532, 7)
        Me.txtValoresCarteraDalores.MaxLength = 16
        Me.txtValoresCarteraDalores.Name = "txtValoresCarteraDalores"
        Me.txtValoresCarteraDalores.ReadOnly = True
        Me.txtValoresCarteraDalores.Size = New System.Drawing.Size(130, 23)
        Me.txtValoresCarteraDalores.TabIndex = 85
        Me.txtValoresCarteraDalores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValoresPropiosDolares
        '
        Me.txtValoresPropiosDolares.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtValoresPropiosDolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValoresPropiosDolares.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValoresPropiosDolares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtValoresPropiosDolares.Location = New System.Drawing.Point(877, 7)
        Me.txtValoresPropiosDolares.MaxLength = 16
        Me.txtValoresPropiosDolares.Name = "txtValoresPropiosDolares"
        Me.txtValoresPropiosDolares.ReadOnly = True
        Me.txtValoresPropiosDolares.Size = New System.Drawing.Size(130, 23)
        Me.txtValoresPropiosDolares.TabIndex = 87
        Me.txtValoresPropiosDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValoresPropiosPesos
        '
        Me.txtValoresPropiosPesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtValoresPropiosPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValoresPropiosPesos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValoresPropiosPesos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtValoresPropiosPesos.Location = New System.Drawing.Point(743, 7)
        Me.txtValoresPropiosPesos.MaxLength = 16
        Me.txtValoresPropiosPesos.Name = "txtValoresPropiosPesos"
        Me.txtValoresPropiosPesos.ReadOnly = True
        Me.txtValoresPropiosPesos.Size = New System.Drawing.Size(130, 23)
        Me.txtValoresPropiosPesos.TabIndex = 81
        Me.txtValoresPropiosPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValoresCarteraPesos
        '
        Me.txtValoresCarteraPesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtValoresCarteraPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValoresCarteraPesos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValoresCarteraPesos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtValoresCarteraPesos.Location = New System.Drawing.Point(398, 7)
        Me.txtValoresCarteraPesos.MaxLength = 16
        Me.txtValoresCarteraPesos.Name = "txtValoresCarteraPesos"
        Me.txtValoresCarteraPesos.ReadOnly = True
        Me.txtValoresCarteraPesos.Size = New System.Drawing.Size(130, 23)
        Me.txtValoresCarteraPesos.TabIndex = 79
        Me.txtValoresCarteraPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnChequePropio
        '
        Me.btnChequePropio.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnChequePropio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChequePropio.FlatAppearance.BorderSize = 0
        Me.btnChequePropio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnChequePropio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChequePropio.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequePropio.ForeColor = System.Drawing.Color.White
        Me.btnChequePropio.Image = Global.Presentacion.My.Resources.Resources.IconoAgregar2
        Me.btnChequePropio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChequePropio.Location = New System.Drawing.Point(1134, 98)
        Me.btnChequePropio.Name = "btnChequePropio"
        Me.btnChequePropio.Size = New System.Drawing.Size(184, 35)
        Me.btnChequePropio.TabIndex = 68
        Me.btnChequePropio.Text = "     Cheque Propio"
        Me.btnChequePropio.UseVisualStyleBackColor = False
        '
        'btnValorCartera
        '
        Me.btnValorCartera.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnValorCartera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValorCartera.FlatAppearance.BorderSize = 0
        Me.btnValorCartera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnValorCartera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValorCartera.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValorCartera.ForeColor = System.Drawing.Color.White
        Me.btnValorCartera.Image = Global.Presentacion.My.Resources.Resources.IconoAgregar2
        Me.btnValorCartera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnValorCartera.Location = New System.Drawing.Point(1134, 57)
        Me.btnValorCartera.Name = "btnValorCartera"
        Me.btnValorCartera.Size = New System.Drawing.Size(184, 35)
        Me.btnValorCartera.TabIndex = 67
        Me.btnValorCartera.Text = "     Valor de Cartera"
        Me.btnValorCartera.UseVisualStyleBackColor = False
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
        Me.btnQuitar.Location = New System.Drawing.Point(1134, 180)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(184, 35)
        Me.btnQuitar.TabIndex = 65
        Me.btnQuitar.Text = "    Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(1134, 139)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(184, 35)
        Me.btnEditar.TabIndex = 66
        Me.btnEditar.Text = "    Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEfectivo
        '
        Me.btnEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnEfectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEfectivo.FlatAppearance.BorderSize = 0
        Me.btnEfectivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEfectivo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEfectivo.ForeColor = System.Drawing.Color.White
        Me.btnEfectivo.Image = Global.Presentacion.My.Resources.Resources.IconoAgregar2
        Me.btnEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEfectivo.Location = New System.Drawing.Point(1134, 16)
        Me.btnEfectivo.Name = "btnEfectivo"
        Me.btnEfectivo.Size = New System.Drawing.Size(184, 35)
        Me.btnEfectivo.TabIndex = 15
        Me.btnEfectivo.Text = "     Efectivo"
        Me.btnEfectivo.UseVisualStyleBackColor = False
        '
        'dgvDetalleOrden
        '
        Me.dgvDetalleOrden.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleOrden.Location = New System.Drawing.Point(10, 16)
        Me.dgvDetalleOrden.Name = "dgvDetalleOrden"
        Me.dgvDetalleOrden.Size = New System.Drawing.Size(1110, 363)
        Me.dgvDetalleOrden.TabIndex = 64
        '
        'bnfDesdeRmt
        '
        Me.bnfDesdeRmt.ElipseRadius = 7
        Me.bnfDesdeRmt.TargetControl = Me
        '
        'bnfElpCanc
        '
        Me.bnfElpCanc.ElipseRadius = 7
        Me.bnfElpCanc.TargetControl = Me.btnCancelar
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
        'bnfElpElim
        '
        Me.bnfElpElim.ElipseRadius = 7
        Me.bnfElpElim.TargetControl = Me.btnEliminar
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
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        Me.tmrLoad.Interval = 300
        '
        'bnfElipEditar
        '
        Me.bnfElipEditar.ElipseRadius = 7
        Me.bnfElipEditar.TargetControl = Me.btnEditar
        '
        'bnfElipQuitar
        '
        Me.bnfElipQuitar.ElipseRadius = 7
        Me.bnfElipQuitar.TargetControl = Me.btnQuitar
        '
        'bnfElipEfectivo
        '
        Me.bnfElipEfectivo.ElipseRadius = 7
        Me.bnfElipEfectivo.TargetControl = Me.btnEfectivo
        '
        'bnfElipValorCartera
        '
        Me.bnfElipValorCartera.ElipseRadius = 7
        Me.bnfElipValorCartera.TargetControl = Me.btnValorCartera
        '
        'bnfElipValorPropio
        '
        Me.bnfElipValorPropio.ElipseRadius = 7
        Me.bnfElipValorPropio.TargetControl = Me.btnChequePropio
        '
        'frmOrdenPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMargin = New System.Drawing.Size(5, 5)
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmRemComp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenPago"
        Me.Text = "frmOrdenCompra"
        Me.pnlFrmRemComp.ResumeLayout(False)
        Me.bnfCardProv.ResumeLayout(False)
        Me.bnfCardProv.PerformLayout()
        Me.bnfCardTc.ResumeLayout(False)
        Me.bnfCardTc.PerformLayout()
        Me.bnfCardNum.ResumeLayout(False)
        Me.bnfCardNum.PerformLayout()
        Me.bnfCardObs.ResumeLayout(False)
        Me.bnfCardObs.PerformLayout()
        Me.bnfCardFec.ResumeLayout(False)
        Me.bnfCardFec.PerformLayout()
        Me.bnfCardInfoProv.ResumeLayout(False)
        Me.bnfCardInfoProv.PerformLayout()
        Me.bncBotones.ResumeLayout(False)
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardDetalleOrden.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        Me.BunifuCards6.PerformLayout()
        CType(Me.dgvDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtIdOrden As TextBox
    Friend WithEvents pnlFrmRemComp As Panel
    Friend WithEvents bncBotones As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfDesdeRmt As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipCarg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipBorr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnEfectivo As Button
    Friend WithEvents bnfElipEditar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipQuitar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfElipEfectivo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipValorCartera As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipValorPropio As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfCardInfoProv As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTE As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCtaProv As TextBox
    Friend WithEvents txtIIBB As Label
    Friend WithEvents txtRSprov As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCuit As Label
    Friend WithEvents txtLoc As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDirec As Label
    Friend WithEvents txtProv As Label
    Friend WithEvents txtEfectivoPesos As TextBox
    Friend WithEvents txtValoresPropiosDolares As TextBox
    Friend WithEvents txtValoresCarteraPesos As TextBox
    Friend WithEvents txtValoresCarteraDalores As TextBox
    Friend WithEvents txtValoresPropiosPesos As TextBox
    Friend WithEvents txtEfectivoDolares As TextBox
    Friend WithEvents bnfCardFec As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblBanco As Label
    Friend WithEvents txtFec As TextBox
    Friend WithEvents txtTC As TextBox
    Friend WithEvents txtNroOrden As TextBox
    Friend WithEvents bnfCardObs As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents bnfCardDetalleOrden As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvDetalleOrden As DataGridView
    Friend WithEvents btnChequePropio As Button
    Friend WithEvents btnValorCartera As Button
    Friend WithEvents txtTotalDolares As TextBox
    Friend WithEvents txtTotalPesos As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents bnfCardTc As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label21 As Label
    Friend WithEvents bnfCardNum As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents cmbPtoVta As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bnfCardProv As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
End Class
