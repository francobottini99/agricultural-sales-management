<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtaCteCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtaCteCompra))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.bnfElpImprimir = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipFiltrar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBtnSemana = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBtnHoy = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBtnMes = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.bnfElipBtnHistorico = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtSaldolC = New System.Windows.Forms.TextBox()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtFecDesde = New System.Windows.Forms.TextBox()
        Me.txtFecHasta = New System.Windows.Forms.TextBox()
        Me.pnlFrmCtaCrtVta = New System.Windows.Forms.Panel()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDirec = New System.Windows.Forms.Label()
        Me.txtProv = New System.Windows.Forms.Label()
        Me.bnfCardProv = New Bunifu.Framework.UI.BunifuCards()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRSprov = New System.Windows.Forms.TextBox()
        Me.txtCtaProv = New System.Windows.Forms.TextBox()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfChkFactura = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bnfChkRecibo = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.bnfCardFiltro = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardFec = New Bunifu.Framework.UI.BunifuCards()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnfCardDetalle = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtSaldoP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTipCambio = New System.Windows.Forms.TextBox()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfElipBtnAño = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnHistorico = New System.Windows.Forms.Button()
        Me.btnAño = New System.Windows.Forms.Button()
        Me.btnSemana = New System.Windows.Forms.Button()
        Me.btnHoy = New System.Windows.Forms.Button()
        Me.btnMes = New System.Windows.Forms.Button()
        Me.btnFiltar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrmCtaCrtVta.SuspendLayout()
        Me.bnfCardInfoProv.SuspendLayout()
        Me.bnfCardProv.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.bnfCardFiltro.SuspendLayout()
        Me.bnfCardFec.SuspendLayout()
        Me.bnfCardDetalle.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(709, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "SALDO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDetalle
        '
        Me.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(9, 15)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(1307, 433)
        Me.dgvDetalle.TabIndex = 64
        '
        'bnfElpImprimir
        '
        Me.bnfElpImprimir.ElipseRadius = 7
        Me.bnfElpImprimir.TargetControl = Me.btnImprimir
        '
        'bnfElipFiltrar
        '
        Me.bnfElipFiltrar.ElipseRadius = 7
        Me.bnfElipFiltrar.TargetControl = Me.btnFiltar
        '
        'bnfElipBtnSemana
        '
        Me.bnfElipBtnSemana.ElipseRadius = 7
        Me.bnfElipBtnSemana.TargetControl = Me.btnSemana
        '
        'bnfElipBtnHoy
        '
        Me.bnfElipBtnHoy.ElipseRadius = 7
        Me.bnfElipBtnHoy.TargetControl = Me.btnHoy
        '
        'bnfElipBtnMes
        '
        Me.bnfElipBtnMes.ElipseRadius = 7
        Me.bnfElipBtnMes.TargetControl = Me.btnMes
        '
        'lblBanco
        '
        Me.lblBanco.Font = New System.Drawing.Font("Trebuchet MS", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.LightGray
        Me.lblBanco.Location = New System.Drawing.Point(330, 14)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(250, 25)
        Me.lblBanco.TabIndex = 103
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfElipBtnHistorico
        '
        Me.bnfElipBtnHistorico.ElipseRadius = 7
        Me.bnfElipBtnHistorico.TargetControl = Me.btnHistorico
        '
        'txtSaldolC
        '
        Me.txtSaldolC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSaldolC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldolC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldolC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtSaldolC.Location = New System.Drawing.Point(957, 14)
        Me.txtSaldolC.MaxLength = 16
        Me.txtSaldolC.Name = "txtSaldolC"
        Me.txtSaldolC.ReadOnly = True
        Me.txtSaldolC.Size = New System.Drawing.Size(180, 25)
        Me.txtSaldolC.TabIndex = 87
        Me.txtSaldolC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(975, 35)
        Me.lblTitulo.TabIndex = 82
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFecDesde
        '
        Me.txtFecDesde.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecDesde.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFecDesde.Location = New System.Drawing.Point(8, 41)
        Me.txtFecDesde.MaxLength = 10
        Me.txtFecDesde.Name = "txtFecDesde"
        Me.txtFecDesde.Size = New System.Drawing.Size(160, 25)
        Me.txtFecDesde.TabIndex = 99
        Me.txtFecDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFecHasta
        '
        Me.txtFecHasta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecHasta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFecHasta.Location = New System.Drawing.Point(8, 101)
        Me.txtFecHasta.MaxLength = 10
        Me.txtFecHasta.Name = "txtFecHasta"
        Me.txtFecHasta.Size = New System.Drawing.Size(160, 25)
        Me.txtFecHasta.TabIndex = 101
        Me.txtFecHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlFrmCtaCrtVta
        '
        Me.pnlFrmCtaCrtVta.AutoScroll = True
        Me.pnlFrmCtaCrtVta.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmCtaCrtVta.Controls.Add(Me.bnfCardInfoProv)
        Me.pnlFrmCtaCrtVta.Controls.Add(Me.bnfCardProv)
        Me.pnlFrmCtaCrtVta.Controls.Add(Me.BunifuCards2)
        Me.pnlFrmCtaCrtVta.Controls.Add(Me.bnfCardFiltro)
        Me.pnlFrmCtaCrtVta.Controls.Add(Me.bnfCardFec)
        Me.pnlFrmCtaCrtVta.Controls.Add(Me.bnfCardDetalle)
        Me.pnlFrmCtaCrtVta.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmCtaCrtVta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmCtaCrtVta.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmCtaCrtVta.Name = "pnlFrmCtaCrtVta"
        Me.pnlFrmCtaCrtVta.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmCtaCrtVta.TabIndex = 63
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
        Me.bnfCardInfoProv.Controls.Add(Me.Label1)
        Me.bnfCardInfoProv.Controls.Add(Me.txtDirec)
        Me.bnfCardInfoProv.Controls.Add(Me.txtProv)
        Me.bnfCardInfoProv.LeftSahddow = False
        Me.bnfCardInfoProv.Location = New System.Drawing.Point(12, 117)
        Me.bnfCardInfoProv.Name = "bnfCardInfoProv"
        Me.bnfCardInfoProv.RightSahddow = True
        Me.bnfCardInfoProv.ShadowDepth = 20
        Me.bnfCardInfoProv.Size = New System.Drawing.Size(622, 180)
        Me.bnfCardInfoProv.TabIndex = 127
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(7, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "LOCALIDAD"
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
        'bnfCardProv
        '
        Me.bnfCardProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardProv.BorderRadius = 5
        Me.bnfCardProv.BottomSahddow = True
        Me.bnfCardProv.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardProv.Controls.Add(Me.Label5)
        Me.bnfCardProv.Controls.Add(Me.Label6)
        Me.bnfCardProv.Controls.Add(Me.txtRSprov)
        Me.bnfCardProv.Controls.Add(Me.txtCtaProv)
        Me.bnfCardProv.LeftSahddow = False
        Me.bnfCardProv.Location = New System.Drawing.Point(12, 41)
        Me.bnfCardProv.Name = "bnfCardProv"
        Me.bnfCardProv.RightSahddow = True
        Me.bnfCardProv.ShadowDepth = 20
        Me.bnfCardProv.Size = New System.Drawing.Size(622, 70)
        Me.bnfCardProv.TabIndex = 126
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(10, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "NRO CTA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(95, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 18)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "RAZON SOCIAL"
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
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.bnfChkFactura)
        Me.BunifuCards2.Controls.Add(Me.Label8)
        Me.BunifuCards2.Controls.Add(Me.Label7)
        Me.BunifuCards2.Controls.Add(Me.bnfChkRecibo)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(814, 41)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(177, 62)
        Me.BunifuCards2.TabIndex = 124
        '
        'bnfChkFactura
        '
        Me.bnfChkFactura.AutoSize = True
        Me.bnfChkFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkFactura.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfChkFactura.Checked = True
        Me.bnfChkFactura.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkFactura.ForeColor = System.Drawing.Color.White
        Me.bnfChkFactura.Location = New System.Drawing.Point(6, 9)
        Me.bnfChkFactura.Name = "bnfChkFactura"
        Me.bnfChkFactura.Size = New System.Drawing.Size(20, 20)
        Me.bnfChkFactura.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(36, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 18)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "ORDENES DE PAGO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(28, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 18)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "FACTURAS DE COMPRA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfChkRecibo
        '
        Me.bnfChkRecibo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkRecibo.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfChkRecibo.Checked = True
        Me.bnfChkRecibo.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfChkRecibo.ForeColor = System.Drawing.Color.White
        Me.bnfChkRecibo.Location = New System.Drawing.Point(6, 35)
        Me.bnfChkRecibo.Name = "bnfChkRecibo"
        Me.bnfChkRecibo.Size = New System.Drawing.Size(20, 20)
        Me.bnfChkRecibo.TabIndex = 111
        '
        'bnfCardFiltro
        '
        Me.bnfCardFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardFiltro.BorderRadius = 5
        Me.bnfCardFiltro.BottomSahddow = True
        Me.bnfCardFiltro.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardFiltro.Controls.Add(Me.btnHistorico)
        Me.bnfCardFiltro.Controls.Add(Me.btnAño)
        Me.bnfCardFiltro.Controls.Add(Me.btnSemana)
        Me.bnfCardFiltro.Controls.Add(Me.btnHoy)
        Me.bnfCardFiltro.Controls.Add(Me.btnMes)
        Me.bnfCardFiltro.LeftSahddow = False
        Me.bnfCardFiltro.Location = New System.Drawing.Point(640, 41)
        Me.bnfCardFiltro.Name = "bnfCardFiltro"
        Me.bnfCardFiltro.RightSahddow = True
        Me.bnfCardFiltro.ShadowDepth = 20
        Me.bnfCardFiltro.Size = New System.Drawing.Size(168, 256)
        Me.bnfCardFiltro.TabIndex = 115
        '
        'bnfCardFec
        '
        Me.bnfCardFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardFec.BorderRadius = 5
        Me.bnfCardFec.BottomSahddow = True
        Me.bnfCardFec.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardFec.Controls.Add(Me.btnFiltar)
        Me.bnfCardFec.Controls.Add(Me.txtFecDesde)
        Me.bnfCardFec.Controls.Add(Me.Label9)
        Me.bnfCardFec.Controls.Add(Me.txtFecHasta)
        Me.bnfCardFec.Controls.Add(Me.Label3)
        Me.bnfCardFec.LeftSahddow = False
        Me.bnfCardFec.Location = New System.Drawing.Point(814, 109)
        Me.bnfCardFec.Name = "bnfCardFec"
        Me.bnfCardFec.RightSahddow = True
        Me.bnfCardFec.ShadowDepth = 20
        Me.bnfCardFec.Size = New System.Drawing.Size(177, 188)
        Me.bnfCardFec.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(8, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 20)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "FECHA HASTA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(8, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "FECHA DESDE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnfCardDetalle
        '
        Me.bnfCardDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDetalle.BorderRadius = 5
        Me.bnfCardDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bnfCardDetalle.BottomSahddow = True
        Me.bnfCardDetalle.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDetalle.Controls.Add(Me.BunifuCards3)
        Me.bnfCardDetalle.Controls.Add(Me.dgvDetalle)
        Me.bnfCardDetalle.Enabled = False
        Me.bnfCardDetalle.LeftSahddow = False
        Me.bnfCardDetalle.Location = New System.Drawing.Point(12, 303)
        Me.bnfCardDetalle.Name = "bnfCardDetalle"
        Me.bnfCardDetalle.RightSahddow = True
        Me.bnfCardDetalle.ShadowDepth = 20
        Me.bnfCardDetalle.Size = New System.Drawing.Size(1330, 512)
        Me.bnfCardDetalle.TabIndex = 111
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.btnImprimir)
        Me.BunifuCards3.Controls.Add(Me.lblBanco)
        Me.BunifuCards3.Controls.Add(Me.Label4)
        Me.BunifuCards3.Controls.Add(Me.txtSaldolC)
        Me.BunifuCards3.Controls.Add(Me.txtSaldoP)
        Me.BunifuCards3.Controls.Add(Me.Label14)
        Me.BunifuCards3.Controls.Add(Me.txtTipCambio)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(6, 448)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(1313, 55)
        Me.BunifuCards3.TabIndex = 119
        '
        'txtSaldoP
        '
        Me.txtSaldoP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSaldoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txtSaldoP.Location = New System.Drawing.Point(771, 14)
        Me.txtSaldoP.MaxLength = 16
        Me.txtSaldoP.Name = "txtSaldoP"
        Me.txtSaldoP.ReadOnly = True
        Me.txtSaldoP.Size = New System.Drawing.Size(180, 25)
        Me.txtSaldoP.TabIndex = 81
        Me.txtSaldoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(12, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 20)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "TIPO DE CAMBIO"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTipCambio
        '
        Me.txtTipCambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTipCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipCambio.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTipCambio.Location = New System.Drawing.Point(144, 14)
        Me.txtTipCambio.MaxLength = 10
        Me.txtTipCambio.Name = "txtTipCambio"
        Me.txtTipCambio.Size = New System.Drawing.Size(180, 25)
        Me.txtTipCambio.TabIndex = 90
        Me.txtTipCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
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
        'bnfElipBtnAño
        '
        Me.bnfElipBtnAño.ElipseRadius = 7
        Me.bnfElipBtnAño.TargetControl = Me.btnAño
        '
        'btnHistorico
        '
        Me.btnHistorico.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnHistorico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistorico.FlatAppearance.BorderSize = 0
        Me.btnHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorico.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorico.ForeColor = System.Drawing.Color.White
        Me.btnHistorico.Image = Global.Presentacion.My.Resources.Resources.IconoCalendario
        Me.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorico.Location = New System.Drawing.Point(8, 208)
        Me.btnHistorico.Name = "btnHistorico"
        Me.btnHistorico.Size = New System.Drawing.Size(150, 35)
        Me.btnHistorico.TabIndex = 109
        Me.btnHistorico.Text = "     Historico"
        Me.btnHistorico.UseVisualStyleBackColor = False
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
        Me.btnAño.Location = New System.Drawing.Point(8, 160)
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
        Me.btnSemana.Location = New System.Drawing.Point(8, 65)
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
        Me.btnHoy.Location = New System.Drawing.Point(8, 17)
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
        Me.btnMes.Location = New System.Drawing.Point(8, 112)
        Me.btnMes.Name = "btnMes"
        Me.btnMes.Size = New System.Drawing.Size(150, 35)
        Me.btnMes.TabIndex = 105
        Me.btnMes.Text = "     Este Mes"
        Me.btnMes.UseVisualStyleBackColor = False
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
        Me.btnFiltar.Location = New System.Drawing.Point(8, 140)
        Me.btnFiltar.Name = "btnFiltar"
        Me.btnFiltar.Size = New System.Drawing.Size(160, 35)
        Me.btnFiltar.TabIndex = 115
        Me.btnFiltar.Text = "     Filtrar"
        Me.btnFiltar.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.IconoImprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(1153, 10)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(150, 35)
        Me.btnImprimir.TabIndex = 114
        Me.btnImprimir.Text = "        Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoCuentaCorriente2
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 83
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
        'frmCtaCteCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmCtaCrtVta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCtaCteCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCtaCteCompra"
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrmCtaCrtVta.ResumeLayout(False)
        Me.bnfCardInfoProv.ResumeLayout(False)
        Me.bnfCardInfoProv.PerformLayout()
        Me.bnfCardProv.ResumeLayout(False)
        Me.bnfCardProv.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.bnfCardFiltro.ResumeLayout(False)
        Me.bnfCardFec.ResumeLayout(False)
        Me.bnfCardFec.PerformLayout()
        Me.bnfCardDetalle.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.bnfCardTitulo.ResumeLayout(False)
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnImprimir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents bnfElpImprimir As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipFiltrar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnFiltar As Button
    Friend WithEvents bnfElipBtnSemana As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnSemana As Button
    Friend WithEvents bnfElipBtnHoy As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnHoy As Button
    Friend WithEvents bnfElipBtnMes As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnMes As Button
    Friend WithEvents lblBanco As Label
    Friend WithEvents bnfElipBtnHistorico As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnHistorico As Button
    Friend WithEvents txtSaldolC As TextBox
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtFecDesde As TextBox
    Friend WithEvents txtFecHasta As TextBox
    Friend WithEvents pnlFrmCtaCrtVta As Panel
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfChkFactura As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bnfChkRecibo As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents bnfCardFiltro As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnAño As Button
    Friend WithEvents bnfCardFec As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bnfCardDetalle As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtSaldoP As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTipCambio As TextBox
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfElipBtnAño As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfCardProv As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRSprov As TextBox
    Friend WithEvents txtCtaProv As TextBox
    Friend WithEvents bnfCardInfoProv As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTE As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtIIBB As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCuit As Label
    Friend WithEvents txtLoc As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDirec As Label
    Friend WithEvents txtProv As Label
End Class
