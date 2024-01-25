<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicioFacturaVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicioFacturaVenta))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecioContable = New System.Windows.Forms.TextBox()
        Me.txtPrecioPPal = New System.Windows.Forms.TextBox()
        Me.lblSimPrecioPPal = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblSimPrecioContable = New System.Windows.Forms.Label()
        Me.bnfArt = New Bunifu.Framework.UI.BunifuCards()
        Me.txtDetalleServicio = New System.Windows.Forms.TextBox()
        Me.txtAlicIva = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.lblSimImpContable = New System.Windows.Forms.Label()
        Me.lblImpContable = New System.Windows.Forms.Label()
        Me.lblSimImpPPal = New System.Windows.Forms.Label()
        Me.lblImpPPal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bnfElpCargar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfElipFrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipPnl = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfArt.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrmArticulos.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(153, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "ALIC IVA %"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(13, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "UNIDAD"
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(296, 156)
        Me.txtCantidad.MaxLength = 16
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(134, 25)
        Me.txtCantidad.TabIndex = 110
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecioContable
        '
        Me.txtPrecioContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPrecioContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioContable.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioContable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPrecioContable.Location = New System.Drawing.Point(16, 262)
        Me.txtPrecioContable.MaxLength = 16
        Me.txtPrecioContable.Name = "txtPrecioContable"
        Me.txtPrecioContable.Size = New System.Drawing.Size(199, 25)
        Me.txtPrecioContable.TabIndex = 109
        Me.txtPrecioContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecioPPal
        '
        Me.txtPrecioPPal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPrecioPPal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioPPal.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioPPal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPrecioPPal.Location = New System.Drawing.Point(16, 213)
        Me.txtPrecioPPal.MaxLength = 16
        Me.txtPrecioPPal.Name = "txtPrecioPPal"
        Me.txtPrecioPPal.Size = New System.Drawing.Size(199, 25)
        Me.txtPrecioPPal.TabIndex = 108
        Me.txtPrecioPPal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSimPrecioPPal
        '
        Me.lblSimPrecioPPal.AutoSize = True
        Me.lblSimPrecioPPal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimPrecioPPal.ForeColor = System.Drawing.Color.LightGray
        Me.lblSimPrecioPPal.Location = New System.Drawing.Point(13, 192)
        Me.lblSimPrecioPPal.Name = "lblSimPrecioPPal"
        Me.lblSimPrecioPPal.Size = New System.Drawing.Size(81, 18)
        Me.lblSimPrecioPPal.TabIndex = 83
        Me.lblSimPrecioPPal.Text = "PRECIO U$D"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LightGray
        Me.Label22.Location = New System.Drawing.Point(293, 135)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 18)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "CANTIDAD"
        '
        'lblSimPrecioContable
        '
        Me.lblSimPrecioContable.AutoSize = True
        Me.lblSimPrecioContable.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimPrecioContable.ForeColor = System.Drawing.Color.LightGray
        Me.lblSimPrecioContable.Location = New System.Drawing.Point(13, 241)
        Me.lblSimPrecioContable.Name = "lblSimPrecioContable"
        Me.lblSimPrecioContable.Size = New System.Drawing.Size(64, 18)
        Me.lblSimPrecioContable.TabIndex = 104
        Me.lblSimPrecioContable.Text = "PRECIO $"
        '
        'bnfArt
        '
        Me.bnfArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfArt.BorderRadius = 5
        Me.bnfArt.BottomSahddow = True
        Me.bnfArt.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfArt.Controls.Add(Me.txtDetalleServicio)
        Me.bnfArt.Controls.Add(Me.txtAlicIva)
        Me.bnfArt.Controls.Add(Me.txtUnidad)
        Me.bnfArt.Controls.Add(Me.lblSimImpContable)
        Me.bnfArt.Controls.Add(Me.lblImpContable)
        Me.bnfArt.Controls.Add(Me.lblSimPrecioPPal)
        Me.bnfArt.Controls.Add(Me.lblSimImpPPal)
        Me.bnfArt.Controls.Add(Me.Label22)
        Me.bnfArt.Controls.Add(Me.lblImpPPal)
        Me.bnfArt.Controls.Add(Me.txtPrecioPPal)
        Me.bnfArt.Controls.Add(Me.lblSimPrecioContable)
        Me.bnfArt.Controls.Add(Me.txtCantidad)
        Me.bnfArt.Controls.Add(Me.Label3)
        Me.bnfArt.Controls.Add(Me.txtPrecioContable)
        Me.bnfArt.Controls.Add(Me.Label8)
        Me.bnfArt.Controls.Add(Me.Label7)
        Me.bnfArt.LeftSahddow = False
        Me.bnfArt.Location = New System.Drawing.Point(11, 11)
        Me.bnfArt.Name = "bnfArt"
        Me.bnfArt.RightSahddow = True
        Me.bnfArt.ShadowDepth = 20
        Me.bnfArt.Size = New System.Drawing.Size(446, 300)
        Me.bnfArt.TabIndex = 96
        '
        'txtDetalleServicio
        '
        Me.txtDetalleServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDetalleServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalleServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleServicio.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtDetalleServicio.Location = New System.Drawing.Point(16, 36)
        Me.txtDetalleServicio.MaxLength = 255
        Me.txtDetalleServicio.Multiline = True
        Me.txtDetalleServicio.Name = "txtDetalleServicio"
        Me.txtDetalleServicio.Size = New System.Drawing.Size(414, 93)
        Me.txtDetalleServicio.TabIndex = 118
        '
        'txtAlicIva
        '
        Me.txtAlicIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtAlicIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlicIva.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlicIva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtAlicIva.Location = New System.Drawing.Point(156, 156)
        Me.txtAlicIva.MaxLength = 16
        Me.txtAlicIva.Name = "txtAlicIva"
        Me.txtAlicIva.Size = New System.Drawing.Size(134, 25)
        Me.txtAlicIva.TabIndex = 117
        Me.txtAlicIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnidad
        '
        Me.txtUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUnidad.Location = New System.Drawing.Point(16, 156)
        Me.txtUnidad.MaxLength = 16
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(134, 25)
        Me.txtUnidad.TabIndex = 116
        '
        'lblSimImpContable
        '
        Me.lblSimImpContable.AutoSize = True
        Me.lblSimImpContable.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimImpContable.ForeColor = System.Drawing.Color.LightGray
        Me.lblSimImpContable.Location = New System.Drawing.Point(232, 192)
        Me.lblSimImpContable.Name = "lblSimImpContable"
        Me.lblSimImpContable.Size = New System.Drawing.Size(73, 18)
        Me.lblSimImpContable.TabIndex = 114
        Me.lblSimImpContable.Text = "IMPORTE $"
        '
        'lblImpContable
        '
        Me.lblImpContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblImpContable.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpContable.ForeColor = System.Drawing.Color.DimGray
        Me.lblImpContable.Location = New System.Drawing.Point(231, 213)
        Me.lblImpContable.Name = "lblImpContable"
        Me.lblImpContable.Size = New System.Drawing.Size(199, 24)
        Me.lblImpContable.TabIndex = 113
        Me.lblImpContable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSimImpPPal
        '
        Me.lblSimImpPPal.AutoSize = True
        Me.lblSimImpPPal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimImpPPal.ForeColor = System.Drawing.Color.LightGray
        Me.lblSimImpPPal.Location = New System.Drawing.Point(232, 241)
        Me.lblSimImpPPal.Name = "lblSimImpPPal"
        Me.lblSimImpPPal.Size = New System.Drawing.Size(90, 18)
        Me.lblSimImpPPal.TabIndex = 112
        Me.lblSimImpPPal.Text = "IMPORTE U$D"
        '
        'lblImpPPal
        '
        Me.lblImpPPal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblImpPPal.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpPPal.ForeColor = System.Drawing.Color.DimGray
        Me.lblImpPPal.Location = New System.Drawing.Point(231, 262)
        Me.lblImpPPal.Name = "lblImpPPal"
        Me.lblImpPPal.Size = New System.Drawing.Size(199, 24)
        Me.lblImpPPal.TabIndex = 111
        Me.lblImpPPal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(13, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 18)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "DETALLE SERVICIO"
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = False
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = False
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(478, 35)
        Me.bnfCardTitulo.TabIndex = 92
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(441, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(6, 3)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 66
        Me.txtOrigen.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(365, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Presentacion -> INGRESE DETALLE A FACTURAR"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnAgregar.Location = New System.Drawing.Point(312, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 35)
        Me.btnAgregar.TabIndex = 103
        Me.btnAgregar.Text = "      Aceptar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards4)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfArt)
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(6, 35)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(466, 388)
        Me.pnlFrmArticulos.TabIndex = 65
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.btnAgregar)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(11, 317)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(446, 63)
        Me.BunifuCards4.TabIndex = 108
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
        'frmServicioFacturaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(478, 429)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.Controls.Add(Me.bnfCardTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmServicioFacturaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmServicioFacturaVenta"
        Me.bnfArt.ResumeLayout(False)
        Me.bnfArt.PerformLayout()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.BunifuCards4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecioContable As TextBox
    Friend WithEvents txtPrecioPPal As TextBox
    Friend WithEvents lblSimPrecioPPal As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblSimPrecioContable As Label
    Friend WithEvents bnfArt As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label8 As Label
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents bnfElpCargar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnAgregar As Button
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblSimImpContable As Label
    Friend WithEvents lblImpContable As Label
    Friend WithEvents lblImpPPal As Label
    Friend WithEvents lblSimImpPPal As Label
    Friend WithEvents txtAlicIva As TextBox
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents txtDetalleServicio As TextBox
    Friend WithEvents bnfElipFrm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipPnl As Bunifu.Framework.UI.BunifuElipse
End Class
