<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticuloReserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticuloReserva))
        Me.bnfProv = New Bunifu.Framework.UI.BunifuCards()
        Me.txtCodArt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDetalleArt = New System.Windows.Forms.TextBox()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtCostoAnt = New System.Windows.Forms.TextBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtCantidadReservar = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnfElpCargar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbxImagen = New System.Windows.Forms.PictureBox()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtAlicIva = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStkFisico = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStkReservado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfElipFrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipPnl = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfProv.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.pnlFrmArticulos.SuspendLayout()
        Me.BunifuCards5.SuspendLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnfProv
        '
        Me.bnfProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfProv.BorderRadius = 5
        Me.bnfProv.BottomSahddow = True
        Me.bnfProv.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfProv.Controls.Add(Me.txtCodArt)
        Me.bnfProv.Controls.Add(Me.Label10)
        Me.bnfProv.Controls.Add(Me.Label8)
        Me.bnfProv.Controls.Add(Me.txtDetalleArt)
        Me.bnfProv.LeftSahddow = False
        Me.bnfProv.Location = New System.Drawing.Point(11, 11)
        Me.bnfProv.Name = "bnfProv"
        Me.bnfProv.RightSahddow = True
        Me.bnfProv.ShadowDepth = 20
        Me.bnfProv.Size = New System.Drawing.Size(735, 70)
        Me.bnfProv.TabIndex = 96
        '
        'txtCodArt
        '
        Me.txtCodArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCodArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodArt.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodArt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCodArt.Location = New System.Drawing.Point(10, 33)
        Me.txtCodArt.MaxLength = 14
        Me.txtCodArt.Name = "txtCodArt"
        Me.txtCodArt.Size = New System.Drawing.Size(185, 30)
        Me.txtCodArt.TabIndex = 104
        Me.txtCodArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(13, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 18)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "INGRESE COD. ARTICULO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(208, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 18)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "DETALLE ARTICULO"
        '
        'txtDetalleArt
        '
        Me.txtDetalleArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDetalleArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalleArt.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleArt.ForeColor = System.Drawing.Color.DimGray
        Me.txtDetalleArt.Location = New System.Drawing.Point(205, 33)
        Me.txtDetalleArt.MaxLength = 255
        Me.txtDetalleArt.Name = "txtDetalleArt"
        Me.txtDetalleArt.ReadOnly = True
        Me.txtDetalleArt.Size = New System.Drawing.Size(520, 30)
        Me.txtDetalleArt.TabIndex = 105
        Me.txtDetalleArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = False
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.txtCostoAnt)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdArticulo)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = False
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(768, 35)
        Me.bnfCardTitulo.TabIndex = 92
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(486, 9)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 66
        Me.txtOrigen.Visible = False
        '
        'txtCostoAnt
        '
        Me.txtCostoAnt.BackColor = System.Drawing.Color.Red
        Me.txtCostoAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoAnt.Enabled = False
        Me.txtCostoAnt.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoAnt.ForeColor = System.Drawing.Color.White
        Me.txtCostoAnt.Location = New System.Drawing.Point(560, 9)
        Me.txtCostoAnt.Name = "txtCostoAnt"
        Me.txtCostoAnt.Size = New System.Drawing.Size(68, 25)
        Me.txtCostoAnt.TabIndex = 65
        Me.txtCostoAnt.Visible = False
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.BackColor = System.Drawing.Color.Red
        Me.txtIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdArticulo.Enabled = False
        Me.txtIdArticulo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdArticulo.ForeColor = System.Drawing.Color.White
        Me.txtIdArticulo.Location = New System.Drawing.Point(634, 9)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(68, 25)
        Me.txtIdArticulo.TabIndex = 64
        Me.txtIdArticulo.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(451, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "RESERVAS -> INGRESE DETALLE A RESERVAR"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(731, 5)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.txtCantidadReservar)
        Me.BunifuCards1.Controls.Add(Me.Label22)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(579, 87)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(167, 75)
        Me.BunifuCards1.TabIndex = 106
        '
        'txtCantidadReservar
        '
        Me.txtCantidadReservar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCantidadReservar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadReservar.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadReservar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCantidadReservar.Location = New System.Drawing.Point(10, 35)
        Me.txtCantidadReservar.MaxLength = 16
        Me.txtCantidadReservar.Name = "txtCantidadReservar"
        Me.txtCantidadReservar.Size = New System.Drawing.Size(147, 25)
        Me.txtCantidadReservar.TabIndex = 110
        Me.txtCantidadReservar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LightGray
        Me.Label22.Location = New System.Drawing.Point(15, 14)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(136, 18)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "CANTIDAD"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(10, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "UNIDAD"
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
        Me.btnAgregar.Location = New System.Drawing.Point(607, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 35)
        Me.btnAgregar.TabIndex = 103
        Me.btnAgregar.Text = "      Aceptar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 1
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards5)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards2)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards4)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfProv)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(6, 35)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(756, 348)
        Me.pnlFrmArticulos.TabIndex = 62
        '
        'BunifuCards5
        '
        Me.BunifuCards5.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards5.BorderRadius = 5
        Me.BunifuCards5.BottomSahddow = True
        Me.BunifuCards5.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards5.Controls.Add(Me.Label4)
        Me.BunifuCards5.Controls.Add(Me.pbxImagen)
        Me.BunifuCards5.LeftSahddow = False
        Me.BunifuCards5.Location = New System.Drawing.Point(306, 87)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = True
        Me.BunifuCards5.ShadowDepth = 20
        Me.BunifuCards5.Size = New System.Drawing.Size(267, 183)
        Me.BunifuCards5.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 18)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "IMAGEN ARTICULO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxImagen
        '
        Me.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImagen.Image = Global.Presentacion.My.Resources.Resources.IconoArticulo
        Me.pbxImagen.Location = New System.Drawing.Point(12, 35)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(243, 137)
        Me.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxImagen.TabIndex = 42
        Me.pbxImagen.TabStop = False
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.txtAlicIva)
        Me.BunifuCards2.Controls.Add(Me.Label5)
        Me.BunifuCards2.Controls.Add(Me.txtStkFisico)
        Me.BunifuCards2.Controls.Add(Me.txtUnidad)
        Me.BunifuCards2.Controls.Add(Me.Label1)
        Me.BunifuCards2.Controls.Add(Me.Label3)
        Me.BunifuCards2.Controls.Add(Me.txtStkReservado)
        Me.BunifuCards2.Controls.Add(Me.Label2)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(11, 87)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(289, 183)
        Me.BunifuCards2.TabIndex = 116
        '
        'txtAlicIva
        '
        Me.txtAlicIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtAlicIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlicIva.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlicIva.ForeColor = System.Drawing.Color.DimGray
        Me.txtAlicIva.Location = New System.Drawing.Point(136, 138)
        Me.txtAlicIva.MaxLength = 16
        Me.txtAlicIva.Name = "txtAlicIva"
        Me.txtAlicIva.ReadOnly = True
        Me.txtAlicIva.Size = New System.Drawing.Size(136, 25)
        Me.txtAlicIva.TabIndex = 117
        Me.txtAlicIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(10, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "ALIC IVA %"
        '
        'txtStkFisico
        '
        Me.txtStkFisico.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtStkFisico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStkFisico.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkFisico.ForeColor = System.Drawing.Color.DimGray
        Me.txtStkFisico.Location = New System.Drawing.Point(136, 61)
        Me.txtStkFisico.MaxLength = 16
        Me.txtStkFisico.Name = "txtStkFisico"
        Me.txtStkFisico.ReadOnly = True
        Me.txtStkFisico.Size = New System.Drawing.Size(136, 25)
        Me.txtStkFisico.TabIndex = 112
        Me.txtStkFisico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnidad
        '
        Me.txtUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.ForeColor = System.Drawing.Color.DimGray
        Me.txtUnidad.Location = New System.Drawing.Point(136, 99)
        Me.txtUnidad.MaxLength = 16
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.ReadOnly = True
        Me.txtUnidad.Size = New System.Drawing.Size(136, 25)
        Me.txtUnidad.TabIndex = 115
        Me.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(10, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "STOCK FISICO"
        '
        'txtStkReservado
        '
        Me.txtStkReservado.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtStkReservado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStkReservado.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkReservado.ForeColor = System.Drawing.Color.DimGray
        Me.txtStkReservado.Location = New System.Drawing.Point(136, 23)
        Me.txtStkReservado.MaxLength = 16
        Me.txtStkReservado.Name = "txtStkReservado"
        Me.txtStkReservado.ReadOnly = True
        Me.txtStkReservado.Size = New System.Drawing.Size(136, 25)
        Me.txtStkReservado.TabIndex = 114
        Me.txtStkReservado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(10, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 18)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "STOCK RESERVADO"
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.btnAgregar)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(11, 276)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(735, 63)
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
        'frmArticuloReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(768, 389)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.Controls.Add(Me.bnfCardTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArticuloReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmArticuloReserva"
        Me.bnfProv.ResumeLayout(False)
        Me.bnfProv.PerformLayout()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.BunifuCards5.ResumeLayout(False)
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents bnfProv As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtCodArt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDetalleArt As TextBox
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtCostoAnt As TextBox
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents bnfElpCargar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnAgregar As Button
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtCantidadReservar As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtStkReservado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStkFisico As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label4 As Label
    Friend WithEvents pbxImagen As PictureBox
    Friend WithEvents txtAlicIva As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents bnfElipFrm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipPnl As Bunifu.Framework.UI.BunifuElipse
End Class
