<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenPagoChequePropio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenPagoChequePropio))
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfElpCargar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtIdChequera = New System.Windows.Forms.TextBox()
        Me.txtIdDetalleCheque = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFecAlta = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCantChq = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblChqDisp = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.bnfCardObs = New Bunifu.Framework.UI.BunifuCards()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.bnfCardImp = New Bunifu.Framework.UI.BunifuCards()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bnfCardFec = New Bunifu.Framework.UI.BunifuCards()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFecCobro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFecEmsion = New System.Windows.Forms.TextBox()
        Me.bnfCardNroChq = New Bunifu.Framework.UI.BunifuCards()
        Me.cmbNroChq = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnfCardChequera = New Bunifu.Framework.UI.BunifuCards()
        Me.cmbChequera = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnfElipFrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipPnl = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTitulo.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        Me.pnlFrmArticulos.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.bnfCardObs.SuspendLayout()
        Me.bnfCardImp.SuspendLayout()
        Me.bnfCardFec.SuspendLayout()
        Me.bnfCardNroChq.SuspendLayout()
        Me.bnfCardChequera.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(605, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "ORDEN DE PAGO -> CHEQUES PROPIOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(635, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'bnfElpCargar
        '
        Me.bnfElpCargar.ElipseRadius = 7
        Me.bnfElpCargar.TargetControl = Me.btnAgregar
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
        Me.btnAgregar.Location = New System.Drawing.Point(504, 15)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 35)
        Me.btnAgregar.TabIndex = 103
        Me.btnAgregar.Text = "      Aceptar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = False
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtIdChequera)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdDetalleCheque)
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = False
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(672, 35)
        Me.bnfCardTitulo.TabIndex = 92
        '
        'txtIdChequera
        '
        Me.txtIdChequera.BackColor = System.Drawing.Color.Red
        Me.txtIdChequera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdChequera.Enabled = False
        Me.txtIdChequera.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdChequera.ForeColor = System.Drawing.Color.White
        Me.txtIdChequera.Location = New System.Drawing.Point(397, 3)
        Me.txtIdChequera.Name = "txtIdChequera"
        Me.txtIdChequera.Size = New System.Drawing.Size(68, 25)
        Me.txtIdChequera.TabIndex = 70
        Me.txtIdChequera.Visible = False
        '
        'txtIdDetalleCheque
        '
        Me.txtIdDetalleCheque.BackColor = System.Drawing.Color.Red
        Me.txtIdDetalleCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdDetalleCheque.Enabled = False
        Me.txtIdDetalleCheque.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDetalleCheque.ForeColor = System.Drawing.Color.White
        Me.txtIdDetalleCheque.Location = New System.Drawing.Point(471, 3)
        Me.txtIdDetalleCheque.Name = "txtIdDetalleCheque"
        Me.txtIdDetalleCheque.Size = New System.Drawing.Size(68, 25)
        Me.txtIdDetalleCheque.TabIndex = 69
        Me.txtIdDetalleCheque.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(545, 3)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 68
        Me.txtOrigen.Visible = False
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.btnAgregar)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(11, 475)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(639, 63)
        Me.BunifuCards4.TabIndex = 108
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardObs)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardImp)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardFec)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardNroChq)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardChequera)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards4)
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(6, 35)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(660, 546)
        Me.pnlFrmArticulos.TabIndex = 69
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.Label5)
        Me.BunifuCards1.Controls.Add(Me.Label10)
        Me.BunifuCards1.Controls.Add(Me.lblFecAlta)
        Me.BunifuCards1.Controls.Add(Me.lblBanco)
        Me.BunifuCards1.Controls.Add(Me.lblObs)
        Me.BunifuCards1.Controls.Add(Me.Label13)
        Me.BunifuCards1.Controls.Add(Me.lblCantChq)
        Me.BunifuCards1.Controls.Add(Me.Label15)
        Me.BunifuCards1.Controls.Add(Me.lblChqDisp)
        Me.BunifuCards1.Controls.Add(Me.Label17)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(11, 91)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(639, 135)
        Me.BunifuCards1.TabIndex = 131
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(423, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "FEC. ALTA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(13, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 18)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "BANCO"
        '
        'lblFecAlta
        '
        Me.lblFecAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblFecAlta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecAlta.ForeColor = System.Drawing.Color.DimGray
        Me.lblFecAlta.Location = New System.Drawing.Point(497, 42)
        Me.lblFecAlta.Name = "lblFecAlta"
        Me.lblFecAlta.Size = New System.Drawing.Size(125, 24)
        Me.lblFecAlta.TabIndex = 130
        '
        'lblBanco
        '
        Me.lblBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblBanco.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.DimGray
        Me.lblBanco.Location = New System.Drawing.Point(125, 14)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(497, 24)
        Me.lblBanco.TabIndex = 71
        '
        'lblObs
        '
        Me.lblObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblObs.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.ForeColor = System.Drawing.Color.DimGray
        Me.lblObs.Location = New System.Drawing.Point(125, 72)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(497, 54)
        Me.lblObs.TabIndex = 129
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(13, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "OBSERVACIONES"
        '
        'lblCantChq
        '
        Me.lblCantChq.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblCantChq.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantChq.ForeColor = System.Drawing.Color.DimGray
        Me.lblCantChq.Location = New System.Drawing.Point(125, 43)
        Me.lblCantChq.Name = "lblCantChq"
        Me.lblCantChq.Size = New System.Drawing.Size(94, 24)
        Me.lblCantChq.TabIndex = 128
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(13, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 18)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "CANT. CHEQUES"
        '
        'lblChqDisp
        '
        Me.lblChqDisp.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblChqDisp.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChqDisp.ForeColor = System.Drawing.Color.DimGray
        Me.lblChqDisp.Location = New System.Drawing.Point(317, 43)
        Me.lblChqDisp.Name = "lblChqDisp"
        Me.lblChqDisp.Size = New System.Drawing.Size(100, 24)
        Me.lblChqDisp.TabIndex = 79
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightGray
        Me.Label17.Location = New System.Drawing.Point(225, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 18)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "DISPONIBLES"
        '
        'bnfCardObs
        '
        Me.bnfCardObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardObs.BorderRadius = 5
        Me.bnfCardObs.BottomSahddow = True
        Me.bnfCardObs.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardObs.Controls.Add(Me.Label9)
        Me.bnfCardObs.Controls.Add(Me.txtObservaciones)
        Me.bnfCardObs.Enabled = False
        Me.bnfCardObs.LeftSahddow = False
        Me.bnfCardObs.Location = New System.Drawing.Point(11, 392)
        Me.bnfCardObs.Name = "bnfCardObs"
        Me.bnfCardObs.RightSahddow = True
        Me.bnfCardObs.ShadowDepth = 20
        Me.bnfCardObs.Size = New System.Drawing.Size(639, 77)
        Me.bnfCardObs.TabIndex = 138
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(13, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 18)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "OBSERVACIONES"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtObservaciones.Location = New System.Drawing.Point(16, 36)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(606, 25)
        Me.txtObservaciones.TabIndex = 133
        '
        'bnfCardImp
        '
        Me.bnfCardImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardImp.BorderRadius = 5
        Me.bnfCardImp.BottomSahddow = True
        Me.bnfCardImp.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardImp.Controls.Add(Me.txtImporte)
        Me.bnfCardImp.Controls.Add(Me.Label11)
        Me.bnfCardImp.Enabled = False
        Me.bnfCardImp.LeftSahddow = False
        Me.bnfCardImp.Location = New System.Drawing.Point(455, 312)
        Me.bnfCardImp.Name = "bnfCardImp"
        Me.bnfCardImp.RightSahddow = True
        Me.bnfCardImp.ShadowDepth = 20
        Me.bnfCardImp.Size = New System.Drawing.Size(195, 74)
        Me.bnfCardImp.TabIndex = 137
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporte.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtImporte.Location = New System.Drawing.Point(17, 34)
        Me.txtImporte.MaxLength = 10
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(161, 25)
        Me.txtImporte.TabIndex = 135
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(14, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 18)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "IMPORTE"
        '
        'bnfCardFec
        '
        Me.bnfCardFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardFec.BorderRadius = 5
        Me.bnfCardFec.BottomSahddow = True
        Me.bnfCardFec.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardFec.Controls.Add(Me.Label12)
        Me.bnfCardFec.Controls.Add(Me.txtPlazo)
        Me.bnfCardFec.Controls.Add(Me.Label8)
        Me.bnfCardFec.Controls.Add(Me.txtFecCobro)
        Me.bnfCardFec.Controls.Add(Me.Label7)
        Me.bnfCardFec.Controls.Add(Me.txtFecEmsion)
        Me.bnfCardFec.Enabled = False
        Me.bnfCardFec.LeftSahddow = False
        Me.bnfCardFec.Location = New System.Drawing.Point(11, 312)
        Me.bnfCardFec.Name = "bnfCardFec"
        Me.bnfCardFec.RightSahddow = True
        Me.bnfCardFec.ShadowDepth = 20
        Me.bnfCardFec.Size = New System.Drawing.Size(438, 74)
        Me.bnfCardFec.TabIndex = 132
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(313, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 18)
        Me.Label12.TabIndex = 134
        Me.Label12.Text = "PLAZO EN DIAS"
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlazo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlazo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPlazo.Location = New System.Drawing.Point(316, 34)
        Me.txtPlazo.MaxLength = 10
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.Size = New System.Drawing.Size(106, 25)
        Me.txtPlazo.TabIndex = 133
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(163, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 18)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "FEC. COBRO"
        '
        'txtFecCobro
        '
        Me.txtFecCobro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecCobro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecCobro.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecCobro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFecCobro.Location = New System.Drawing.Point(166, 34)
        Me.txtFecCobro.MaxLength = 10
        Me.txtFecCobro.Name = "txtFecCobro"
        Me.txtFecCobro.Size = New System.Drawing.Size(144, 25)
        Me.txtFecCobro.TabIndex = 131
        Me.txtFecCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(13, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 130
        Me.Label7.Text = "FEC. EMISION"
        '
        'txtFecEmsion
        '
        Me.txtFecEmsion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecEmsion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecEmsion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecEmsion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecEmsion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFecEmsion.Location = New System.Drawing.Point(16, 34)
        Me.txtFecEmsion.MaxLength = 10
        Me.txtFecEmsion.Name = "txtFecEmsion"
        Me.txtFecEmsion.Size = New System.Drawing.Size(144, 25)
        Me.txtFecEmsion.TabIndex = 129
        Me.txtFecEmsion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bnfCardNroChq
        '
        Me.bnfCardNroChq.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardNroChq.BorderRadius = 5
        Me.bnfCardNroChq.BottomSahddow = True
        Me.bnfCardNroChq.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardNroChq.Controls.Add(Me.cmbNroChq)
        Me.bnfCardNroChq.Controls.Add(Me.Label1)
        Me.bnfCardNroChq.Enabled = False
        Me.bnfCardNroChq.LeftSahddow = False
        Me.bnfCardNroChq.Location = New System.Drawing.Point(11, 232)
        Me.bnfCardNroChq.Name = "bnfCardNroChq"
        Me.bnfCardNroChq.RightSahddow = True
        Me.bnfCardNroChq.ShadowDepth = 20
        Me.bnfCardNroChq.Size = New System.Drawing.Size(438, 74)
        Me.bnfCardNroChq.TabIndex = 131
        '
        'cmbNroChq
        '
        Me.cmbNroChq.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbNroChq.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNroChq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbNroChq.FormattingEnabled = True
        Me.cmbNroChq.IntegralHeight = False
        Me.cmbNroChq.Location = New System.Drawing.Point(16, 34)
        Me.cmbNroChq.Name = "cmbNroChq"
        Me.cmbNroChq.Size = New System.Drawing.Size(406, 28)
        Me.cmbNroChq.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "NRO DE CHEQUE"
        '
        'bnfCardChequera
        '
        Me.bnfCardChequera.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardChequera.BorderRadius = 5
        Me.bnfCardChequera.BottomSahddow = True
        Me.bnfCardChequera.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardChequera.Controls.Add(Me.cmbChequera)
        Me.bnfCardChequera.Controls.Add(Me.Label3)
        Me.bnfCardChequera.LeftSahddow = False
        Me.bnfCardChequera.Location = New System.Drawing.Point(11, 11)
        Me.bnfCardChequera.Name = "bnfCardChequera"
        Me.bnfCardChequera.RightSahddow = True
        Me.bnfCardChequera.ShadowDepth = 20
        Me.bnfCardChequera.Size = New System.Drawing.Size(639, 74)
        Me.bnfCardChequera.TabIndex = 130
        '
        'cmbChequera
        '
        Me.cmbChequera.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbChequera.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChequera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbChequera.FormattingEnabled = True
        Me.cmbChequera.Location = New System.Drawing.Point(16, 31)
        Me.cmbChequera.Name = "cmbChequera"
        Me.cmbChequera.Size = New System.Drawing.Size(606, 30)
        Me.cmbChequera.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(13, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "CHEQUERA"
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
        'frmOrdenPagoChequePropio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(672, 587)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.Controls.Add(Me.bnfCardTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenPagoChequePropio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOrdenPagoValorPropio"
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.bnfCardObs.ResumeLayout(False)
        Me.bnfCardObs.PerformLayout()
        Me.bnfCardImp.ResumeLayout(False)
        Me.bnfCardImp.PerformLayout()
        Me.bnfCardFec.ResumeLayout(False)
        Me.bnfCardFec.PerformLayout()
        Me.bnfCardNroChq.ResumeLayout(False)
        Me.bnfCardNroChq.PerformLayout()
        Me.bnfCardChequera.ResumeLayout(False)
        Me.bnfCardChequera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfElpCargar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnAgregar As Button
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents cmbChequera As ComboBox
    Friend WithEvents bnfCardChequera As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFecAlta As Label
    Friend WithEvents lblObs As Label
    Friend WithEvents lblCantChq As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblChqDisp As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents bnfCardNroChq As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents cmbNroChq As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFecCobro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFecEmsion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents bnfCardObs As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardImp As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardFec As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPlazo As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtIdDetalleCheque As TextBox
    Friend WithEvents txtIdChequera As TextBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfElipFrm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipPnl As Bunifu.Framework.UI.BunifuElipse
End Class
