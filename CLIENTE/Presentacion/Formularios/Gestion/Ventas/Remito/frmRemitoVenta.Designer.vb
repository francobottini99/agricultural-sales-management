<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRemitoVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemitoVenta))
        Me.txtTE = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumRem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFec = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCtaCli = New System.Windows.Forms.TextBox()
        Me.txtRScli = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDirec = New System.Windows.Forms.Label()
        Me.txtProv = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtIIBB = New System.Windows.Forms.Label()
        Me.bnfCardDetalleRem = New Bunifu.Framework.UI.BunifuCards()
        Me.txtSubTotalP = New System.Windows.Forms.TextBox()
        Me.txtSubTotalC = New System.Windows.Forms.TextBox()
        Me.txtIVAP = New System.Windows.Forms.TextBox()
        Me.txtIVAC = New System.Windows.Forms.TextBox()
        Me.txtTotalP = New System.Windows.Forms.TextBox()
        Me.txtTotalC = New System.Windows.Forms.TextBox()
        Me.dgvDetalleRemito = New System.Windows.Forms.DataGridView()
        Me.bnfElipAgg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipQuitar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBorr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtIdPedido = New System.Windows.Forms.TextBox()
        Me.txtIdFactura = New System.Windows.Forms.TextBox()
        Me.txtIdRemitoVta = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.bnfElipCarg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.bnfCardObs = New Bunifu.Framework.UI.BunifuCards()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.bnfCardInfoClie = New Bunifu.Framework.UI.BunifuCards()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfCardFec = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardBotones = New Bunifu.Framework.UI.BunifuCards()
        Me.pnlFrmRemVta = New System.Windows.Forms.Panel()
        Me.bnfCardClie = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardTc = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardNum = New Bunifu.Framework.UI.BunifuCards()
        Me.cmbPtoVta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bnfElipEditar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.bnfCardDetalleRem.SuspendLayout()
        CType(Me.dgvDetalleRemito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTitulo.SuspendLayout()
        Me.bnfCardObs.SuspendLayout()
        Me.bnfCardInfoClie.SuspendLayout()
        Me.bnfCardFec.SuspendLayout()
        Me.bnfCardBotones.SuspendLayout()
        Me.pnlFrmRemVta.SuspendLayout()
        Me.bnfCardClie.SuspendLayout()
        Me.bnfCardTc.SuspendLayout()
        Me.bnfCardNum.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards3.SuspendLayout()
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
        Me.txtTC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(9, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 18)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "NRO REMITO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumRem
        '
        Me.txtNumRem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumRem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNumRem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumRem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumRem.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRem.ForeColor = System.Drawing.Color.DimGray
        Me.txtNumRem.Location = New System.Drawing.Point(9, 126)
        Me.txtNumRem.MaxLength = 255
        Me.txtNumRem.Name = "txtNumRem"
        Me.txtNumRem.ReadOnly = True
        Me.txtNumRem.Size = New System.Drawing.Size(147, 25)
        Me.txtNumRem.TabIndex = 78
        Me.txtNumRem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtFec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'Label21
        '
        Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LightGray
        Me.Label21.Location = New System.Drawing.Point(10, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 18)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "TIPO DE CAMBIO"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'txtCtaCli
        '
        Me.txtCtaCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCtaCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtaCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaCli.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCtaCli.Location = New System.Drawing.Point(10, 30)
        Me.txtCtaCli.MaxLength = 5
        Me.txtCtaCli.Name = "txtCtaCli"
        Me.txtCtaCli.Size = New System.Drawing.Size(79, 30)
        Me.txtCtaCli.TabIndex = 60
        Me.txtCtaCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRScli
        '
        Me.txtRScli.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtRScli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRScli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRScli.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRScli.ForeColor = System.Drawing.Color.DimGray
        Me.txtRScli.Location = New System.Drawing.Point(95, 30)
        Me.txtRScli.MaxLength = 255
        Me.txtRScli.Name = "txtRScli"
        Me.txtRScli.ReadOnly = True
        Me.txtRScli.Size = New System.Drawing.Size(515, 30)
        Me.txtRScli.TabIndex = 62
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
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LightGray
        Me.Label20.Location = New System.Drawing.Point(9, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(147, 18)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "FECHA"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'bnfCardDetalleRem
        '
        Me.bnfCardDetalleRem.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDetalleRem.BorderRadius = 5
        Me.bnfCardDetalleRem.BottomSahddow = True
        Me.bnfCardDetalleRem.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDetalleRem.Controls.Add(Me.BunifuCards3)
        Me.bnfCardDetalleRem.Controls.Add(Me.btnEditar)
        Me.bnfCardDetalleRem.Controls.Add(Me.btnQuitar)
        Me.bnfCardDetalleRem.Controls.Add(Me.btnAgregar)
        Me.bnfCardDetalleRem.Controls.Add(Me.dgvDetalleRemito)
        Me.bnfCardDetalleRem.Enabled = False
        Me.bnfCardDetalleRem.LeftSahddow = False
        Me.bnfCardDetalleRem.Location = New System.Drawing.Point(11, 303)
        Me.bnfCardDetalleRem.Name = "bnfCardDetalleRem"
        Me.bnfCardDetalleRem.RightSahddow = True
        Me.bnfCardDetalleRem.ShadowDepth = 20
        Me.bnfCardDetalleRem.Size = New System.Drawing.Size(1330, 430)
        Me.bnfCardDetalleRem.TabIndex = 83
        '
        'txtSubTotalP
        '
        Me.txtSubTotalP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSubTotalP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTotalP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtSubTotalP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSubTotalP.Location = New System.Drawing.Point(260, 8)
        Me.txtSubTotalP.MaxLength = 16
        Me.txtSubTotalP.Name = "txtSubTotalP"
        Me.txtSubTotalP.ReadOnly = True
        Me.txtSubTotalP.Size = New System.Drawing.Size(155, 25)
        Me.txtSubTotalP.TabIndex = 77
        Me.txtSubTotalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotalC
        '
        Me.txtSubTotalC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSubTotalC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTotalC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtSubTotalC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtSubTotalC.Location = New System.Drawing.Point(99, 8)
        Me.txtSubTotalC.MaxLength = 16
        Me.txtSubTotalC.Name = "txtSubTotalC"
        Me.txtSubTotalC.ReadOnly = True
        Me.txtSubTotalC.Size = New System.Drawing.Size(155, 25)
        Me.txtSubTotalC.TabIndex = 83
        Me.txtSubTotalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVAP
        '
        Me.txtIVAP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtIVAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVAP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtIVAP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtIVAP.Location = New System.Drawing.Point(625, 8)
        Me.txtIVAP.MaxLength = 16
        Me.txtIVAP.Name = "txtIVAP"
        Me.txtIVAP.ReadOnly = True
        Me.txtIVAP.Size = New System.Drawing.Size(155, 25)
        Me.txtIVAP.TabIndex = 79
        Me.txtIVAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVAC
        '
        Me.txtIVAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtIVAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVAC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtIVAC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtIVAC.Location = New System.Drawing.Point(464, 8)
        Me.txtIVAC.MaxLength = 16
        Me.txtIVAC.Name = "txtIVAC"
        Me.txtIVAC.ReadOnly = True
        Me.txtIVAC.Size = New System.Drawing.Size(155, 25)
        Me.txtIVAC.TabIndex = 85
        Me.txtIVAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalP
        '
        Me.txtTotalP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTotalP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtTotalP.Location = New System.Drawing.Point(1013, 8)
        Me.txtTotalP.MaxLength = 16
        Me.txtTotalP.Name = "txtTotalP"
        Me.txtTotalP.ReadOnly = True
        Me.txtTotalP.Size = New System.Drawing.Size(155, 25)
        Me.txtTotalP.TabIndex = 81
        Me.txtTotalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalC
        '
        Me.txtTotalC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTotalC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtTotalC.Location = New System.Drawing.Point(852, 8)
        Me.txtTotalC.MaxLength = 16
        Me.txtTotalC.Name = "txtTotalC"
        Me.txtTotalC.ReadOnly = True
        Me.txtTotalC.Size = New System.Drawing.Size(155, 25)
        Me.txtTotalC.TabIndex = 87
        Me.txtTotalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalleRemito
        '
        Me.dgvDetalleRemito.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvDetalleRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleRemito.Location = New System.Drawing.Point(10, 16)
        Me.dgvDetalleRemito.Name = "dgvDetalleRemito"
        Me.dgvDetalleRemito.Size = New System.Drawing.Size(1176, 365)
        Me.dgvDetalleRemito.TabIndex = 64
        '
        'bnfElipAgg
        '
        Me.bnfElipAgg.ElipseRadius = 7
        Me.bnfElipAgg.TargetControl = Me.btnAgregar
        '
        'bnfElipQuitar
        '
        Me.bnfElipQuitar.ElipseRadius = 7
        Me.bnfElipQuitar.TargetControl = Me.btnQuitar
        '
        'bnfElipBorr
        '
        Me.bnfElipBorr.ElipseRadius = 7
        Me.bnfElipBorr.TargetControl = Me
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(716, 35)
        Me.lblTitulo.TabIndex = 84
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdPedido
        '
        Me.txtIdPedido.BackColor = System.Drawing.Color.Red
        Me.txtIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdPedido.Enabled = False
        Me.txtIdPedido.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPedido.ForeColor = System.Drawing.Color.White
        Me.txtIdPedido.Location = New System.Drawing.Point(769, 10)
        Me.txtIdPedido.Name = "txtIdPedido"
        Me.txtIdPedido.Size = New System.Drawing.Size(68, 25)
        Me.txtIdPedido.TabIndex = 65
        Me.txtIdPedido.Visible = False
        '
        'txtIdFactura
        '
        Me.txtIdFactura.BackColor = System.Drawing.Color.Red
        Me.txtIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdFactura.Enabled = False
        Me.txtIdFactura.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdFactura.ForeColor = System.Drawing.Color.White
        Me.txtIdFactura.Location = New System.Drawing.Point(843, 10)
        Me.txtIdFactura.Name = "txtIdFactura"
        Me.txtIdFactura.Size = New System.Drawing.Size(68, 25)
        Me.txtIdFactura.TabIndex = 64
        Me.txtIdFactura.Visible = False
        '
        'txtIdRemitoVta
        '
        Me.txtIdRemitoVta.BackColor = System.Drawing.Color.Red
        Me.txtIdRemitoVta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdRemitoVta.Enabled = False
        Me.txtIdRemitoVta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdRemitoVta.ForeColor = System.Drawing.Color.White
        Me.txtIdRemitoVta.Location = New System.Drawing.Point(917, 10)
        Me.txtIdRemitoVta.Name = "txtIdRemitoVta"
        Me.txtIdRemitoVta.Size = New System.Drawing.Size(68, 25)
        Me.txtIdRemitoVta.TabIndex = 63
        Me.txtIdRemitoVta.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(991, 10)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 62
        Me.txtOrigen.Visible = False
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
        'bnfElpMod
        '
        Me.bnfElpMod.ElipseRadius = 7
        Me.bnfElpMod.TargetControl = Me.btnModificar
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdPedido)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdFactura)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdRemitoVta)
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = True
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTitulo.TabIndex = 55
        '
        'bnfElpNuevo
        '
        Me.bnfElpNuevo.ElipseRadius = 7
        Me.bnfElpNuevo.TargetControl = Me.btnNuevo
        '
        'lblBanco
        '
        Me.lblBanco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBanco.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.LightGray
        Me.lblBanco.Location = New System.Drawing.Point(10, 61)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(147, 26)
        Me.lblBanco.TabIndex = 76
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.bnfCardObs.Location = New System.Drawing.Point(11, 741)
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
        Me.txtObservaciones.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtObservaciones.Location = New System.Drawing.Point(8, 26)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(461, 40)
        Me.txtObservaciones.TabIndex = 99
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
        'bnfCardInfoClie
        '
        Me.bnfCardInfoClie.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardInfoClie.BorderRadius = 5
        Me.bnfCardInfoClie.BottomSahddow = True
        Me.bnfCardInfoClie.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardInfoClie.Controls.Add(Me.Label19)
        Me.bnfCardInfoClie.Controls.Add(Me.txtTE)
        Me.bnfCardInfoClie.Controls.Add(Me.Label17)
        Me.bnfCardInfoClie.Controls.Add(Me.txtIIBB)
        Me.bnfCardInfoClie.Controls.Add(Me.Label15)
        Me.bnfCardInfoClie.Controls.Add(Me.Label10)
        Me.bnfCardInfoClie.Controls.Add(Me.txtCuit)
        Me.bnfCardInfoClie.Controls.Add(Me.txtLoc)
        Me.bnfCardInfoClie.Controls.Add(Me.Label13)
        Me.bnfCardInfoClie.Controls.Add(Me.Label11)
        Me.bnfCardInfoClie.Controls.Add(Me.txtDirec)
        Me.bnfCardInfoClie.Controls.Add(Me.txtProv)
        Me.bnfCardInfoClie.Enabled = False
        Me.bnfCardInfoClie.LeftSahddow = False
        Me.bnfCardInfoClie.Location = New System.Drawing.Point(11, 117)
        Me.bnfCardInfoClie.Name = "bnfCardInfoClie"
        Me.bnfCardInfoClie.RightSahddow = True
        Me.bnfCardInfoClie.ShadowDepth = 20
        Me.bnfCardInfoClie.Size = New System.Drawing.Size(622, 180)
        Me.bnfCardInfoClie.TabIndex = 60
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
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'bnfCardFec
        '
        Me.bnfCardFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardFec.BorderRadius = 5
        Me.bnfCardFec.BottomSahddow = True
        Me.bnfCardFec.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardFec.Controls.Add(Me.Label20)
        Me.bnfCardFec.Controls.Add(Me.txtFec)
        Me.bnfCardFec.Enabled = False
        Me.bnfCardFec.LeftSahddow = False
        Me.bnfCardFec.Location = New System.Drawing.Point(639, 41)
        Me.bnfCardFec.Name = "bnfCardFec"
        Me.bnfCardFec.RightSahddow = True
        Me.bnfCardFec.ShadowDepth = 20
        Me.bnfCardFec.Size = New System.Drawing.Size(167, 70)
        Me.bnfCardFec.TabIndex = 60
        '
        'bnfCardBotones
        '
        Me.bnfCardBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardBotones.BorderRadius = 5
        Me.bnfCardBotones.BottomSahddow = True
        Me.bnfCardBotones.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardBotones.Controls.Add(Me.btnEliminar)
        Me.bnfCardBotones.Controls.Add(Me.btnModificar)
        Me.bnfCardBotones.Controls.Add(Me.btnCancelar)
        Me.bnfCardBotones.Controls.Add(Me.btnNuevo)
        Me.bnfCardBotones.Controls.Add(Me.btnGuardar)
        Me.bnfCardBotones.LeftSahddow = False
        Me.bnfCardBotones.Location = New System.Drawing.Point(651, 741)
        Me.bnfCardBotones.Name = "bnfCardBotones"
        Me.bnfCardBotones.RightSahddow = True
        Me.bnfCardBotones.ShadowDepth = 20
        Me.bnfCardBotones.Size = New System.Drawing.Size(690, 74)
        Me.bnfCardBotones.TabIndex = 59
        '
        'pnlFrmRemVta
        '
        Me.pnlFrmRemVta.AutoScroll = True
        Me.pnlFrmRemVta.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmRemVta.Controls.Add(Me.bnfCardClie)
        Me.pnlFrmRemVta.Controls.Add(Me.bnfCardTc)
        Me.pnlFrmRemVta.Controls.Add(Me.bnfCardNum)
        Me.pnlFrmRemVta.Controls.Add(Me.bnfCardObs)
        Me.pnlFrmRemVta.Controls.Add(Me.bnfCardBotones)
        Me.pnlFrmRemVta.Controls.Add(Me.bnfCardFec)
        Me.pnlFrmRemVta.Controls.Add(Me.bnfCardInfoClie)
        Me.pnlFrmRemVta.Controls.Add(Me.bnfCardDetalleRem)
        Me.pnlFrmRemVta.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmRemVta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmRemVta.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmRemVta.Name = "pnlFrmRemVta"
        Me.pnlFrmRemVta.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmRemVta.TabIndex = 62
        '
        'bnfCardClie
        '
        Me.bnfCardClie.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardClie.BorderRadius = 5
        Me.bnfCardClie.BottomSahddow = True
        Me.bnfCardClie.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardClie.Controls.Add(Me.Label2)
        Me.bnfCardClie.Controls.Add(Me.Label1)
        Me.bnfCardClie.Controls.Add(Me.txtRScli)
        Me.bnfCardClie.Controls.Add(Me.txtCtaCli)
        Me.bnfCardClie.Enabled = False
        Me.bnfCardClie.LeftSahddow = False
        Me.bnfCardClie.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardClie.Name = "bnfCardClie"
        Me.bnfCardClie.RightSahddow = True
        Me.bnfCardClie.ShadowDepth = 20
        Me.bnfCardClie.Size = New System.Drawing.Size(622, 70)
        Me.bnfCardClie.TabIndex = 116
        '
        'bnfCardTc
        '
        Me.bnfCardTc.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardTc.BorderRadius = 5
        Me.bnfCardTc.BottomSahddow = True
        Me.bnfCardTc.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTc.Controls.Add(Me.txtTC)
        Me.bnfCardTc.Controls.Add(Me.Label21)
        Me.bnfCardTc.Controls.Add(Me.lblBanco)
        Me.bnfCardTc.Enabled = False
        Me.bnfCardTc.LeftSahddow = False
        Me.bnfCardTc.Location = New System.Drawing.Point(812, 41)
        Me.bnfCardTc.Name = "bnfCardTc"
        Me.bnfCardTc.RightSahddow = True
        Me.bnfCardTc.ShadowDepth = 20
        Me.bnfCardTc.Size = New System.Drawing.Size(167, 97)
        Me.bnfCardTc.TabIndex = 111
        '
        'bnfCardNum
        '
        Me.bnfCardNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardNum.BorderRadius = 5
        Me.bnfCardNum.BottomSahddow = True
        Me.bnfCardNum.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardNum.Controls.Add(Me.cmbPtoVta)
        Me.bnfCardNum.Controls.Add(Me.Label3)
        Me.bnfCardNum.Controls.Add(Me.txtNumRem)
        Me.bnfCardNum.Controls.Add(Me.Label4)
        Me.bnfCardNum.Enabled = False
        Me.bnfCardNum.LeftSahddow = False
        Me.bnfCardNum.Location = New System.Drawing.Point(639, 117)
        Me.bnfCardNum.Name = "bnfCardNum"
        Me.bnfCardNum.RightSahddow = True
        Me.bnfCardNum.ShadowDepth = 20
        Me.bnfCardNum.Size = New System.Drawing.Size(167, 180)
        Me.bnfCardNum.TabIndex = 110
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
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(9, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 18)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "PTO. DE VTA."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnfElipEditar
        '
        Me.bnfElipEditar.ElipseRadius = 7
        Me.bnfElipEditar.TargetControl = Me.btnEditar
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
        Me.btnEliminar.TabIndex = 16
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
        Me.btnModificar.Location = New System.Drawing.Point(151, 20)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 35)
        Me.btnModificar.TabIndex = 15
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
        Me.btnEditar.Location = New System.Drawing.Point(1200, 57)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(118, 35)
        Me.btnEditar.TabIndex = 66
        Me.btnEditar.Text = "    Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnQuitar.Location = New System.Drawing.Point(1200, 98)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(118, 35)
        Me.btnQuitar.TabIndex = 65
        Me.btnQuitar.Text = "    Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
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
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoRemito
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 85
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
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.txtTotalP)
        Me.BunifuCards3.Controls.Add(Me.txtIVAP)
        Me.BunifuCards3.Controls.Add(Me.txtTotalC)
        Me.BunifuCards3.Controls.Add(Me.txtSubTotalP)
        Me.BunifuCards3.Controls.Add(Me.txtIVAC)
        Me.BunifuCards3.Controls.Add(Me.Label7)
        Me.BunifuCards3.Controls.Add(Me.txtSubTotalC)
        Me.BunifuCards3.Controls.Add(Me.Label5)
        Me.BunifuCards3.Controls.Add(Me.Label14)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(6, 381)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(1182, 43)
        Me.BunifuCards3.TabIndex = 122
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(7, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "SUB TOTAL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(427, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 20)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "IVA"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRemitoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmRemVta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRemitoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRemitoVentaNuevo"
        Me.bnfCardDetalleRem.ResumeLayout(False)
        CType(Me.dgvDetalleRemito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        Me.bnfCardObs.ResumeLayout(False)
        Me.bnfCardObs.PerformLayout()
        Me.bnfCardInfoClie.ResumeLayout(False)
        Me.bnfCardInfoClie.PerformLayout()
        Me.bnfCardFec.ResumeLayout(False)
        Me.bnfCardFec.PerformLayout()
        Me.bnfCardBotones.ResumeLayout(False)
        Me.pnlFrmRemVta.ResumeLayout(False)
        Me.bnfCardClie.ResumeLayout(False)
        Me.bnfCardClie.PerformLayout()
        Me.bnfCardTc.ResumeLayout(False)
        Me.bnfCardTc.PerformLayout()
        Me.bnfCardNum.ResumeLayout(False)
        Me.bnfCardNum.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTE As Label
    Friend WithEvents txtTC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumRem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFec As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCtaCli As TextBox
    Friend WithEvents txtRScli As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCuit As Label
    Friend WithEvents txtLoc As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDirec As Label
    Friend WithEvents txtProv As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtIIBB As Label
    Friend WithEvents bnfCardDetalleRem As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvDetalleRemito As DataGridView
    Friend WithEvents bnfElipAgg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipQuitar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipBorr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlFrmRemVta As Panel
    Friend WithEvents bnfCardObs As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label12 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtSubTotalP As TextBox
    Friend WithEvents txtIVAP As TextBox
    Friend WithEvents txtIVAC As TextBox
    Friend WithEvents txtTotalP As TextBox
    Friend WithEvents txtSubTotalC As TextBox
    Friend WithEvents bnfCardBotones As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents bnfCardFec As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblBanco As Label
    Friend WithEvents bnfCardInfoClie As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtIdPedido As TextBox
    Friend WithEvents txtIdFactura As TextBox
    Friend WithEvents txtIdRemitoVta As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfElipCarg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents bnfElipEditar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtTotalC As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents bnfCardNum As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents cmbPtoVta As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bnfCardTc As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardClie As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label14 As Label
End Class
