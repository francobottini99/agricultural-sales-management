﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticuloRemitoCompraFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticuloRemitoCompraFactura))
        Me.lblAlicIvaSel = New System.Windows.Forms.Label()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbxImagen = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUndSel = New System.Windows.Forms.Label()
        Me.lblSimImpContable = New System.Windows.Forms.Label()
        Me.lblImpContable = New System.Windows.Forms.Label()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblCantPendiente = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFecAct = New System.Windows.Forms.Label()
        Me.lblImpPPal = New System.Windows.Forms.Label()
        Me.lblSimImpPPal = New System.Windows.Forms.Label()
        Me.txtCodArt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDetalleArt = New System.Windows.Forms.TextBox()
        Me.txtIdFacturaDetalle = New System.Windows.Forms.TextBox()
        Me.txtIdFactura = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtCostoAnt = New System.Windows.Forms.TextBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.pnlFrmArticulos = New System.Windows.Forms.Panel()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtCostoContable = New System.Windows.Forms.TextBox()
        Me.txtCostoPPal = New System.Windows.Forms.TextBox()
        Me.lblSimPrecioPPal = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblSimPrecioContable = New System.Windows.Forms.Label()
        Me.bnfArt = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfDeposito = New Bunifu.Framework.UI.BunifuCards()
        Me.txtDeposito = New System.Windows.Forms.TextBox()
        Me.txtCodDeposito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfElpCargar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipPnl = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipFrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCards5.SuspendLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards6.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        Me.pnlFrmArticulos.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.bnfArt.SuspendLayout()
        Me.bnfDeposito.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAlicIvaSel
        '
        Me.lblAlicIvaSel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblAlicIvaSel.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlicIvaSel.ForeColor = System.Drawing.Color.DimGray
        Me.lblAlicIvaSel.Location = New System.Drawing.Point(11, 101)
        Me.lblAlicIvaSel.Name = "lblAlicIvaSel"
        Me.lblAlicIvaSel.Size = New System.Drawing.Size(184, 24)
        Me.lblAlicIvaSel.TabIndex = 84
        Me.lblAlicIvaSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.BunifuCards5.Location = New System.Drawing.Point(226, 164)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = True
        Me.BunifuCards5.ShadowDepth = 20
        Me.BunifuCards5.Size = New System.Drawing.Size(153, 182)
        Me.BunifuCards5.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(16, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "IMAGEN ARTICULO"
        '
        'pbxImagen
        '
        Me.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImagen.Image = Global.Presentacion.My.Resources.Resources.IconoArticulo
        Me.pbxImagen.Location = New System.Drawing.Point(9, 34)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(133, 137)
        Me.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxImagen.TabIndex = 42
        Me.pbxImagen.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(12, 80)
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
        Me.Label3.Location = New System.Drawing.Point(12, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "UNIDAD"
        '
        'lblUndSel
        '
        Me.lblUndSel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblUndSel.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUndSel.ForeColor = System.Drawing.Color.DimGray
        Me.lblUndSel.Location = New System.Drawing.Point(11, 39)
        Me.lblUndSel.Name = "lblUndSel"
        Me.lblUndSel.Size = New System.Drawing.Size(184, 24)
        Me.lblUndSel.TabIndex = 80
        Me.lblUndSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSimImpContable
        '
        Me.lblSimImpContable.AutoSize = True
        Me.lblSimImpContable.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimImpContable.ForeColor = System.Drawing.Color.LightGray
        Me.lblSimImpContable.Location = New System.Drawing.Point(12, 199)
        Me.lblSimImpContable.Name = "lblSimImpContable"
        Me.lblSimImpContable.Size = New System.Drawing.Size(73, 18)
        Me.lblSimImpContable.TabIndex = 105
        Me.lblSimImpContable.Text = "IMPORTE $"
        '
        'lblImpContable
        '
        Me.lblImpContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblImpContable.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpContable.ForeColor = System.Drawing.Color.DimGray
        Me.lblImpContable.Location = New System.Drawing.Point(11, 220)
        Me.lblImpContable.Name = "lblImpContable"
        Me.lblImpContable.Size = New System.Drawing.Size(184, 24)
        Me.lblImpContable.TabIndex = 101
        Me.lblImpContable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.lblCantPendiente)
        Me.BunifuCards6.Controls.Add(Me.Label12)
        Me.BunifuCards6.Controls.Add(Me.Label6)
        Me.BunifuCards6.Controls.Add(Me.lblFecAct)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(385, 164)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(165, 125)
        Me.BunifuCards6.TabIndex = 112
        '
        'lblCantPendiente
        '
        Me.lblCantPendiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblCantPendiente.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantPendiente.ForeColor = System.Drawing.Color.DimGray
        Me.lblCantPendiente.Location = New System.Drawing.Point(7, 90)
        Me.lblCantPendiente.Name = "lblCantPendiente"
        Me.lblCantPendiente.Size = New System.Drawing.Size(150, 24)
        Me.lblCantPendiente.TabIndex = 123
        Me.lblCantPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(7, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 18)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "PENDIENTE DE REMITAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(7, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 18)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "ACTUALIZ. DE COSTO"
        '
        'lblFecAct
        '
        Me.lblFecAct.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblFecAct.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecAct.ForeColor = System.Drawing.Color.DimGray
        Me.lblFecAct.Location = New System.Drawing.Point(7, 34)
        Me.lblFecAct.Name = "lblFecAct"
        Me.lblFecAct.Size = New System.Drawing.Size(150, 24)
        Me.lblFecAct.TabIndex = 111
        Me.lblFecAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImpPPal
        '
        Me.lblImpPPal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblImpPPal.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpPPal.ForeColor = System.Drawing.Color.DimGray
        Me.lblImpPPal.Location = New System.Drawing.Point(11, 161)
        Me.lblImpPPal.Name = "lblImpPPal"
        Me.lblImpPPal.Size = New System.Drawing.Size(184, 24)
        Me.lblImpPPal.TabIndex = 98
        Me.lblImpPPal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSimImpPPal
        '
        Me.lblSimImpPPal.AutoSize = True
        Me.lblSimImpPPal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimImpPPal.ForeColor = System.Drawing.Color.LightGray
        Me.lblSimImpPPal.Location = New System.Drawing.Point(12, 140)
        Me.lblSimImpPPal.Name = "lblSimImpPPal"
        Me.lblSimImpPPal.Size = New System.Drawing.Size(90, 18)
        Me.lblSimImpPPal.TabIndex = 99
        Me.lblSimImpPPal.Text = "IMPORTE U$D"
        '
        'txtCodArt
        '
        Me.txtCodArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCodArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodArt.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodArt.ForeColor = System.Drawing.Color.DimGray
        Me.txtCodArt.Location = New System.Drawing.Point(10, 33)
        Me.txtCodArt.MaxLength = 14
        Me.txtCodArt.Name = "txtCodArt"
        Me.txtCodArt.ReadOnly = True
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
        Me.txtDetalleArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleArt.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleArt.ForeColor = System.Drawing.Color.DimGray
        Me.txtDetalleArt.Location = New System.Drawing.Point(205, 33)
        Me.txtDetalleArt.MaxLength = 255
        Me.txtDetalleArt.Name = "txtDetalleArt"
        Me.txtDetalleArt.ReadOnly = True
        Me.txtDetalleArt.Size = New System.Drawing.Size(547, 30)
        Me.txtDetalleArt.TabIndex = 105
        Me.txtDetalleArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIdFacturaDetalle
        '
        Me.txtIdFacturaDetalle.BackColor = System.Drawing.Color.Red
        Me.txtIdFacturaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdFacturaDetalle.Enabled = False
        Me.txtIdFacturaDetalle.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdFacturaDetalle.ForeColor = System.Drawing.Color.White
        Me.txtIdFacturaDetalle.Location = New System.Drawing.Point(361, 7)
        Me.txtIdFacturaDetalle.Name = "txtIdFacturaDetalle"
        Me.txtIdFacturaDetalle.Size = New System.Drawing.Size(68, 25)
        Me.txtIdFacturaDetalle.TabIndex = 71
        Me.txtIdFacturaDetalle.Visible = False
        '
        'txtIdFactura
        '
        Me.txtIdFactura.BackColor = System.Drawing.Color.Red
        Me.txtIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdFactura.Enabled = False
        Me.txtIdFactura.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdFactura.ForeColor = System.Drawing.Color.White
        Me.txtIdFactura.Location = New System.Drawing.Point(435, 7)
        Me.txtIdFactura.Name = "txtIdFactura"
        Me.txtIdFactura.Size = New System.Drawing.Size(68, 25)
        Me.txtIdFactura.TabIndex = 70
        Me.txtIdFactura.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(509, 7)
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
        Me.txtCostoAnt.Location = New System.Drawing.Point(583, 7)
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
        Me.txtIdArticulo.Location = New System.Drawing.Point(657, 7)
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
        Me.lblTitulo.Size = New System.Drawing.Size(726, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "REMITO DE COMPRA -> DETALLE A REMITAR"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.btnAgregar)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(11, 352)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(760, 63)
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
        Me.btnAgregar.Location = New System.Drawing.Point(634, 16)
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
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.lblAlicIvaSel)
        Me.BunifuCards3.Controls.Add(Me.Label7)
        Me.BunifuCards3.Controls.Add(Me.Label3)
        Me.BunifuCards3.Controls.Add(Me.lblUndSel)
        Me.BunifuCards3.Controls.Add(Me.lblSimImpContable)
        Me.BunifuCards3.Controls.Add(Me.lblImpContable)
        Me.BunifuCards3.Controls.Add(Me.lblImpPPal)
        Me.BunifuCards3.Controls.Add(Me.lblSimImpPPal)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(11, 87)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(209, 259)
        Me.BunifuCards3.TabIndex = 107
        '
        'pnlFrmArticulos
        '
        Me.pnlFrmArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards6)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards5)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards4)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards3)
        Me.pnlFrmArticulos.Controls.Add(Me.BunifuCards2)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfArt)
        Me.pnlFrmArticulos.Controls.Add(Me.bnfDeposito)
        Me.pnlFrmArticulos.Location = New System.Drawing.Point(6, 35)
        Me.pnlFrmArticulos.Name = "pnlFrmArticulos"
        Me.pnlFrmArticulos.Size = New System.Drawing.Size(781, 425)
        Me.pnlFrmArticulos.TabIndex = 65
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.txtCantidad)
        Me.BunifuCards2.Controls.Add(Me.txtCostoContable)
        Me.BunifuCards2.Controls.Add(Me.txtCostoPPal)
        Me.BunifuCards2.Controls.Add(Me.lblSimPrecioPPal)
        Me.BunifuCards2.Controls.Add(Me.Label22)
        Me.BunifuCards2.Controls.Add(Me.lblSimPrecioContable)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(556, 164)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(215, 182)
        Me.BunifuCards2.TabIndex = 107
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(8, 146)
        Me.txtCantidad.MaxLength = 16
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(199, 25)
        Me.txtCantidad.TabIndex = 110
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostoContable
        '
        Me.txtCostoContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCostoContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoContable.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoContable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCostoContable.Location = New System.Drawing.Point(8, 90)
        Me.txtCostoContable.MaxLength = 16
        Me.txtCostoContable.Name = "txtCostoContable"
        Me.txtCostoContable.Size = New System.Drawing.Size(199, 25)
        Me.txtCostoContable.TabIndex = 109
        Me.txtCostoContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostoPPal
        '
        Me.txtCostoPPal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCostoPPal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoPPal.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoPPal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCostoPPal.Location = New System.Drawing.Point(8, 34)
        Me.txtCostoPPal.MaxLength = 16
        Me.txtCostoPPal.Name = "txtCostoPPal"
        Me.txtCostoPPal.Size = New System.Drawing.Size(199, 25)
        Me.txtCostoPPal.TabIndex = 108
        Me.txtCostoPPal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSimPrecioPPal
        '
        Me.lblSimPrecioPPal.AutoSize = True
        Me.lblSimPrecioPPal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimPrecioPPal.ForeColor = System.Drawing.Color.LightGray
        Me.lblSimPrecioPPal.Location = New System.Drawing.Point(10, 13)
        Me.lblSimPrecioPPal.Name = "lblSimPrecioPPal"
        Me.lblSimPrecioPPal.Size = New System.Drawing.Size(77, 18)
        Me.lblSimPrecioPPal.TabIndex = 83
        Me.lblSimPrecioPPal.Text = "COSTO U$D"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LightGray
        Me.Label22.Location = New System.Drawing.Point(10, 125)
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
        Me.lblSimPrecioContable.Location = New System.Drawing.Point(10, 69)
        Me.lblSimPrecioContable.Name = "lblSimPrecioContable"
        Me.lblSimPrecioContable.Size = New System.Drawing.Size(60, 18)
        Me.lblSimPrecioContable.TabIndex = 104
        Me.lblSimPrecioContable.Text = "COSTO $"
        '
        'bnfArt
        '
        Me.bnfArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfArt.BorderRadius = 5
        Me.bnfArt.BottomSahddow = True
        Me.bnfArt.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfArt.Controls.Add(Me.txtCodArt)
        Me.bnfArt.Controls.Add(Me.Label10)
        Me.bnfArt.Controls.Add(Me.Label8)
        Me.bnfArt.Controls.Add(Me.txtDetalleArt)
        Me.bnfArt.LeftSahddow = False
        Me.bnfArt.Location = New System.Drawing.Point(11, 11)
        Me.bnfArt.Name = "bnfArt"
        Me.bnfArt.RightSahddow = True
        Me.bnfArt.ShadowDepth = 20
        Me.bnfArt.Size = New System.Drawing.Size(760, 70)
        Me.bnfArt.TabIndex = 96
        '
        'bnfDeposito
        '
        Me.bnfDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfDeposito.BorderRadius = 5
        Me.bnfDeposito.BottomSahddow = True
        Me.bnfDeposito.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfDeposito.Controls.Add(Me.txtDeposito)
        Me.bnfDeposito.Controls.Add(Me.txtCodDeposito)
        Me.bnfDeposito.Controls.Add(Me.Label1)
        Me.bnfDeposito.Enabled = False
        Me.bnfDeposito.LeftSahddow = False
        Me.bnfDeposito.Location = New System.Drawing.Point(226, 87)
        Me.bnfDeposito.Name = "bnfDeposito"
        Me.bnfDeposito.RightSahddow = True
        Me.bnfDeposito.ShadowDepth = 20
        Me.bnfDeposito.Size = New System.Drawing.Size(545, 71)
        Me.bnfDeposito.TabIndex = 106
        '
        'txtDeposito
        '
        Me.txtDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeposito.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeposito.ForeColor = System.Drawing.Color.DimGray
        Me.txtDeposito.Location = New System.Drawing.Point(100, 35)
        Me.txtDeposito.MaxLength = 14
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.Size = New System.Drawing.Size(437, 26)
        Me.txtDeposito.TabIndex = 113
        '
        'txtCodDeposito
        '
        Me.txtCodDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCodDeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodDeposito.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDeposito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCodDeposito.Location = New System.Drawing.Point(8, 35)
        Me.txtCodDeposito.MaxLength = 14
        Me.txtCodDeposito.Name = "txtCodDeposito"
        Me.txtCodDeposito.Size = New System.Drawing.Size(86, 26)
        Me.txtCodDeposito.TabIndex = 111
        Me.txtCodDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 18)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "DEPOSITO DE INGRESO"
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = False
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtIdFacturaDetalle)
        Me.bnfCardTitulo.Controls.Add(Me.txtIdFactura)
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
        Me.bnfCardTitulo.Size = New System.Drawing.Size(793, 35)
        Me.bnfCardTitulo.TabIndex = 92
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(756, 5)
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
        'bnfElipPnl
        '
        Me.bnfElipPnl.ElipseRadius = 20
        Me.bnfElipPnl.TargetControl = Me.pnlFrmArticulos
        '
        'bnfElipFrm
        '
        Me.bnfElipFrm.ElipseRadius = 20
        Me.bnfElipFrm.TargetControl = Me
        '
        'frmArticuloRemitoCompraFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 466)
        Me.Controls.Add(Me.pnlFrmArticulos)
        Me.Controls.Add(Me.bnfCardTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArticuloRemitoCompraFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmArticuloRemitoCompraFactura"
        Me.BunifuCards5.ResumeLayout(False)
        Me.BunifuCards5.PerformLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards6.ResumeLayout(False)
        Me.BunifuCards6.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.pnlFrmArticulos.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.bnfArt.ResumeLayout(False)
        Me.bnfArt.PerformLayout()
        Me.bnfDeposito.ResumeLayout(False)
        Me.bnfDeposito.PerformLayout()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAlicIvaSel As Label
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label4 As Label
    Friend WithEvents pbxImagen As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUndSel As Label
    Friend WithEvents lblSimImpContable As Label
    Friend WithEvents lblImpContable As Label
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFecAct As Label
    Friend WithEvents lblImpPPal As Label
    Friend WithEvents lblSimImpPPal As Label
    Friend WithEvents txtCodArt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDetalleArt As TextBox
    Friend WithEvents txtIdFacturaDetalle As TextBox
    Friend WithEvents txtIdFactura As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtCostoAnt As TextBox
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pnlFrmArticulos As Panel
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtCostoContable As TextBox
    Friend WithEvents txtCostoPPal As TextBox
    Friend WithEvents lblSimPrecioPPal As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblSimPrecioContable As Label
    Friend WithEvents bnfArt As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfDeposito As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtDeposito As TextBox
    Friend WithEvents txtCodDeposito As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bnfElpCargar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblCantPendiente As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents bnfElipPnl As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipFrm As Bunifu.Framework.UI.BunifuElipse
End Class
