<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReservaRemitoNuevoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservaRemitoNuevoCliente))
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardList = New Bunifu.Framework.UI.BunifuCards()
        Me.dgvRemitos = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtRScli = New System.Windows.Forms.TextBox()
        Me.BunifuCards7 = New Bunifu.Framework.UI.BunifuCards()
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.bnfElipFrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipPnl = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards4.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards3.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.bnfCardList.SuspendLayout()
        CType(Me.dgvRemitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards6.SuspendLayout()
        Me.BunifuCards5.SuspendLayout()
        Me.BunifuCards7.SuspendLayout()
        Me.pnlFrmArticulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(1232, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'bnfNuevo
        '
        Me.bnfNuevo.ElipseRadius = 7
        Me.bnfNuevo.TargetControl = Me.btnNuevo
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
        Me.btnNuevo.Image = Global.Presentacion.My.Resources.Resources.IconoAgregar2
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(10, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 35)
        Me.btnNuevo.TabIndex = 16
        Me.btnNuevo.Text = "     Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 50
        '
        'dgvDetalle
        '
        Me.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(9, 43)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(595, 476)
        Me.dgvDetalle.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(381, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(217, 18)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "<Doble Click>: Selecciona un Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DETALLE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.Label8)
        Me.BunifuCards4.Controls.Add(Me.Label2)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(601, 33)
        Me.BunifuCards4.TabIndex = 98
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.BunifuCards4)
        Me.BunifuCards1.Controls.Add(Me.dgvDetalle)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(632, 80)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(615, 533)
        Me.BunifuCards1.TabIndex = 59
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(466, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "REMITOS / RESERVAS DEL CLIENTE PENDIENTES DE FACTURAR"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 5
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
        Me.bnfCardTitulo.Size = New System.Drawing.Size(1269, 35)
        Me.bnfCardTitulo.TabIndex = 55
        '
        'dgvPedidos
        '
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Location = New System.Drawing.Point(9, 43)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.Size = New System.Drawing.Size(595, 243)
        Me.dgvPedidos.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(329, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 18)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "<Click>: Despliega el detalle de la Reserva"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESERVAS SIN FACTURAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.Label4)
        Me.BunifuCards3.Controls.Add(Me.Label1)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(601, 33)
        Me.BunifuCards3.TabIndex = 97
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.btnNuevo)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(1109, 11)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(138, 63)
        Me.BunifuCards2.TabIndex = 96
        '
        'bnfCardList
        '
        Me.bnfCardList.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardList.BorderRadius = 5
        Me.bnfCardList.BottomSahddow = True
        Me.bnfCardList.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardList.Controls.Add(Me.BunifuCards3)
        Me.bnfCardList.Controls.Add(Me.dgvPedidos)
        Me.bnfCardList.LeftSahddow = False
        Me.bnfCardList.Location = New System.Drawing.Point(11, 313)
        Me.bnfCardList.Name = "bnfCardList"
        Me.bnfCardList.RightSahddow = True
        Me.bnfCardList.ShadowDepth = 20
        Me.bnfCardList.Size = New System.Drawing.Size(615, 300)
        Me.bnfCardList.TabIndex = 58
        '
        'dgvRemitos
        '
        Me.dgvRemitos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRemitos.Location = New System.Drawing.Point(9, 43)
        Me.dgvRemitos.Name = "dgvRemitos"
        Me.dgvRemitos.Size = New System.Drawing.Size(595, 243)
        Me.dgvRemitos.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(346, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 18)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "<Click>: Despliega el detalle del Remito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "REMITOS SIN FACTURAR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.Label5)
        Me.BunifuCards6.Controls.Add(Me.Label3)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(601, 33)
        Me.BunifuCards6.TabIndex = 97
        '
        'BunifuCards5
        '
        Me.BunifuCards5.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards5.BorderRadius = 5
        Me.BunifuCards5.BottomSahddow = True
        Me.BunifuCards5.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards5.Controls.Add(Me.BunifuCards6)
        Me.BunifuCards5.Controls.Add(Me.dgvRemitos)
        Me.BunifuCards5.LeftSahddow = False
        Me.BunifuCards5.Location = New System.Drawing.Point(11, 11)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = True
        Me.BunifuCards5.ShadowDepth = 20
        Me.BunifuCards5.Size = New System.Drawing.Size(615, 296)
        Me.BunifuCards5.TabIndex = 98
        '
        'txtRScli
        '
        Me.txtRScli.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtRScli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRScli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRScli.Font = New System.Drawing.Font("Trebuchet MS", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRScli.ForeColor = System.Drawing.Color.DimGray
        Me.txtRScli.Location = New System.Drawing.Point(9, 15)
        Me.txtRScli.MaxLength = 255
        Me.txtRScli.Name = "txtRScli"
        Me.txtRScli.ReadOnly = True
        Me.txtRScli.Size = New System.Drawing.Size(450, 35)
        Me.txtRScli.TabIndex = 63
        '
        'BunifuCards7
        '
        Me.BunifuCards7.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards7.BorderRadius = 5
        Me.BunifuCards7.BottomSahddow = True
        Me.BunifuCards7.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards7.Controls.Add(Me.txtRScli)
        Me.BunifuCards7.LeftSahddow = False
        Me.BunifuCards7.Location = New System.Drawing.Point(632, 11)
        Me.BunifuCards7.Name = "BunifuCards7"
        Me.BunifuCards7.RightSahddow = True
        Me.BunifuCards7.ShadowDepth = 20
        Me.BunifuCards7.Size = New System.Drawing.Size(471, 63)
        Me.BunifuCards7.TabIndex = 97
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards7)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards5)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards2)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfCardList)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(6, 35)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(1257, 624)
        Me.pnlFrmArticulos.TabIndex = 63
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
        'frmReservaRemitoNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1269, 665)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.Controls.Add(Me.bnfCardTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReservaRemitoNuevoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReservaRemitoNuevoCliente"
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.bnfCardTitulo.ResumeLayout(False)
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.bnfCardList.ResumeLayout(False)
        CType(Me.dgvRemitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards6.ResumeLayout(False)
        Me.BunifuCards6.PerformLayout()
        Me.BunifuCards5.ResumeLayout(False)
        Me.BunifuCards7.ResumeLayout(False)
        Me.BunifuCards7.PerformLayout()
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnNuevo As Button
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblTitulo As Label
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardList As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvRemitos As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtRScli As TextBox
    Friend WithEvents BunifuCards7 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents bnfElipFrm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipPnl As Bunifu.Framework.UI.BunifuElipse
End Class
