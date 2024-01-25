<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfCardTituloFrm = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bnfCardDatos = New Bunifu.Framework.UI.BunifuCards()
        Me.pnlContendor = New System.Windows.Forms.Panel()
        Me.cbxProvincia = New System.Windows.Forms.ComboBox()
        Me.cmbClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbSitIVA = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCredAsignado = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIIBB = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCUIT = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.bnfCardList = New Bunifu.Framework.UI.BunifuCards()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlFrmClientes = New System.Windows.Forms.Panel()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardTituloFrm.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardDatos.SuspendLayout()
        Me.pnlContendor.SuspendLayout()
        Me.bnfCardList.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards6.SuspendLayout()
        Me.pnlFrmClientes.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
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
        'bnfCardTituloFrm
        '
        Me.bnfCardTituloFrm.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTituloFrm.BorderRadius = 0
        Me.bnfCardTituloFrm.BottomSahddow = True
        Me.bnfCardTituloFrm.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTituloFrm.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTituloFrm.Controls.Add(Me.txtIdCliente)
        Me.bnfCardTituloFrm.Controls.Add(Me.txtOrigen)
        Me.bnfCardTituloFrm.Controls.Add(Me.pbxSalir)
        Me.bnfCardTituloFrm.Controls.Add(Me.lblTitulo)
        Me.bnfCardTituloFrm.LeftSahddow = False
        Me.bnfCardTituloFrm.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTituloFrm.Name = "bnfCardTituloFrm"
        Me.bnfCardTituloFrm.RightSahddow = True
        Me.bnfCardTituloFrm.ShadowDepth = 20
        Me.bnfCardTituloFrm.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTituloFrm.TabIndex = 56
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoClientes
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 71
        Me.pbxTitulo.TabStop = False
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.Color.Red
        Me.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.ForeColor = System.Drawing.Color.White
        Me.txtIdCliente.Location = New System.Drawing.Point(895, 10)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(68, 25)
        Me.txtIdCliente.TabIndex = 65
        Me.txtIdCliente.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(969, 10)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 62
        Me.txtOrigen.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(995, 35)
        Me.lblTitulo.TabIndex = 70
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfCardDatos
        '
        Me.bnfCardDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDatos.BorderRadius = 5
        Me.bnfCardDatos.BottomSahddow = True
        Me.bnfCardDatos.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDatos.Controls.Add(Me.pnlContendor)
        Me.bnfCardDatos.LeftSahddow = False
        Me.bnfCardDatos.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardDatos.Name = "bnfCardDatos"
        Me.bnfCardDatos.RightSahddow = True
        Me.bnfCardDatos.ShadowDepth = 20
        Me.bnfCardDatos.Size = New System.Drawing.Size(1085, 360)
        Me.bnfCardDatos.TabIndex = 57
        '
        'pnlContendor
        '
        Me.pnlContendor.Controls.Add(Me.cbxProvincia)
        Me.pnlContendor.Controls.Add(Me.cmbClasificacion)
        Me.pnlContendor.Controls.Add(Me.Label21)
        Me.pnlContendor.Controls.Add(Me.cmbSitIVA)
        Me.pnlContendor.Controls.Add(Me.Label20)
        Me.pnlContendor.Controls.Add(Me.Label19)
        Me.pnlContendor.Controls.Add(Me.Label18)
        Me.pnlContendor.Controls.Add(Me.txtCredAsignado)
        Me.pnlContendor.Controls.Add(Me.Label11)
        Me.pnlContendor.Controls.Add(Me.Label10)
        Me.pnlContendor.Controls.Add(Me.txtIIBB)
        Me.pnlContendor.Controls.Add(Me.Label17)
        Me.pnlContendor.Controls.Add(Me.txtWeb)
        Me.pnlContendor.Controls.Add(Me.Label16)
        Me.pnlContendor.Controls.Add(Me.txtPais)
        Me.pnlContendor.Controls.Add(Me.Label9)
        Me.pnlContendor.Controls.Add(Me.txtDireccion)
        Me.pnlContendor.Controls.Add(Me.txtRazonSocial)
        Me.pnlContendor.Controls.Add(Me.Label1)
        Me.pnlContendor.Controls.Add(Me.Label3)
        Me.pnlContendor.Controls.Add(Me.txtLocalidad)
        Me.pnlContendor.Controls.Add(Me.txtCP)
        Me.pnlContendor.Controls.Add(Me.Label4)
        Me.pnlContendor.Controls.Add(Me.Label8)
        Me.pnlContendor.Controls.Add(Me.txtFecha)
        Me.pnlContendor.Controls.Add(Me.Label5)
        Me.pnlContendor.Controls.Add(Me.Label2)
        Me.pnlContendor.Controls.Add(Me.Label13)
        Me.pnlContendor.Controls.Add(Me.txtMail)
        Me.pnlContendor.Controls.Add(Me.txtTelefono)
        Me.pnlContendor.Controls.Add(Me.label15)
        Me.pnlContendor.Controls.Add(Me.Label12)
        Me.pnlContendor.Controls.Add(Me.txtCUIT)
        Me.pnlContendor.Location = New System.Drawing.Point(7, 3)
        Me.pnlContendor.Name = "pnlContendor"
        Me.pnlContendor.Size = New System.Drawing.Size(1075, 350)
        Me.pnlContendor.TabIndex = 55
        '
        'cbxProvincia
        '
        Me.cbxProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbxProvincia.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProvincia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cbxProvincia.FormattingEnabled = True
        Me.cbxProvincia.Items.AddRange(New Object() {"Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán"})
        Me.cbxProvincia.Location = New System.Drawing.Point(119, 155)
        Me.cbxProvincia.Name = "cbxProvincia"
        Me.cbxProvincia.Size = New System.Drawing.Size(234, 28)
        Me.cbxProvincia.TabIndex = 83
        '
        'cmbClasificacion
        '
        Me.cmbClasificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbClasificacion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClasificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbClasificacion.FormattingEnabled = True
        Me.cmbClasificacion.Items.AddRange(New Object() {"Excelente", "Muy Bueno", "Bueno", "Regular", "Malo"})
        Me.cmbClasificacion.Location = New System.Drawing.Point(799, 185)
        Me.cmbClasificacion.Name = "cmbClasificacion"
        Me.cmbClasificacion.Size = New System.Drawing.Size(249, 28)
        Me.cmbClasificacion.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(670, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 18)
        Me.Label21.TabIndex = 82
        Me.Label21.Text = "Datos Comerciales"
        '
        'cmbSitIVA
        '
        Me.cmbSitIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbSitIVA.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSitIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbSitIVA.FormattingEnabled = True
        Me.cmbSitIVA.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable no Inscripto", "IVA no Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado – Ley Nº 19.640", "IVA Responsable Inscripto – Agente de Percepción", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
        Me.cmbSitIVA.Location = New System.Drawing.Point(797, 31)
        Me.cmbSitIVA.Name = "cmbSitIVA"
        Me.cmbSitIVA.Size = New System.Drawing.Size(249, 28)
        Me.cmbSitIVA.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(670, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 18)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "Datos Fiscales"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(7, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 18)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "Datos Personales"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightGray
        Me.Label18.Location = New System.Drawing.Point(670, 190)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 18)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "CLASIFICACION"
        '
        'txtCredAsignado
        '
        Me.txtCredAsignado.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCredAsignado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredAsignado.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredAsignado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCredAsignado.Location = New System.Drawing.Point(800, 220)
        Me.txtCredAsignado.MaxLength = 0
        Me.txtCredAsignado.Name = "txtCredAsignado"
        Me.txtCredAsignado.Size = New System.Drawing.Size(200, 25)
        Me.txtCredAsignado.TabIndex = 14
        Me.txtCredAsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(670, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 18)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "CREDITO ASIGNADO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(670, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 18)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "SITUACION IVA"
        '
        'txtIIBB
        '
        Me.txtIIBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtIIBB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIIBB.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIIBB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtIIBB.Location = New System.Drawing.Point(799, 97)
        Me.txtIIBB.MaxLength = 20
        Me.txtIIBB.Name = "txtIIBB"
        Me.txtIIBB.Size = New System.Drawing.Size(247, 25)
        Me.txtIIBB.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightGray
        Me.Label17.Location = New System.Drawing.Point(670, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 18)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "ING. BRUTOS"
        '
        'txtWeb
        '
        Me.txtWeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeb.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtWeb.Location = New System.Drawing.Point(118, 314)
        Me.txtWeb.MaxLength = 16
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(472, 25)
        Me.txtWeb.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(7, 318)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 18)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "WEB"
        '
        'txtPais
        '
        Me.txtPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPais.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPais.Location = New System.Drawing.Point(119, 221)
        Me.txtPais.MaxLength = 254
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(471, 25)
        Me.txtPais.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(6, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 18)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "PAIS"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(118, 93)
        Me.txtDireccion.MaxLength = 254
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(472, 25)
        Me.txtDireccion.TabIndex = 2
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtRazonSocial.Location = New System.Drawing.Point(118, 62)
        Me.txtRazonSocial.MaxLength = 254
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(472, 25)
        Me.txtRazonSocial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(7, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "FECHA DE ALTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(7, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "LOCALIDAD"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtLocalidad.Location = New System.Drawing.Point(119, 124)
        Me.txtLocalidad.MaxLength = 254
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(471, 25)
        Me.txtLocalidad.TabIndex = 3
        '
        'txtCP
        '
        Me.txtCP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCP.Location = New System.Drawing.Point(119, 190)
        Me.txtCP.MaxLength = 20
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(109, 25)
        Me.txtCP.TabIndex = 5
        Me.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(7, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "PROVINCIA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(7, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 18)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "DIRECCION"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(118, 31)
        Me.txtFecha.MaxLength = 10
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(110, 25)
        Me.txtFecha.TabIndex = 0
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(6, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "COD. POSTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "RAZON SOCIAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(7, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 18)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "TE"
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMail.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtMail.Location = New System.Drawing.Point(118, 283)
        Me.txtMail.MaxLength = 254
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(472, 25)
        Me.txtMail.TabIndex = 8
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTelefono.Location = New System.Drawing.Point(118, 252)
        Me.txtTelefono.MaxLength = 254
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(472, 25)
        Me.txtTelefono.TabIndex = 7
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.LightGray
        Me.label15.Location = New System.Drawing.Point(7, 287)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(37, 18)
        Me.label15.TabIndex = 42
        Me.label15.Text = "MAIL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(670, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "CUIT (Sin Guiones)"
        '
        'txtCUIT
        '
        Me.txtCUIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCUIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCUIT.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCUIT.Location = New System.Drawing.Point(799, 65)
        Me.txtCUIT.MaxLength = 13
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.Size = New System.Drawing.Size(247, 25)
        Me.txtCUIT.TabIndex = 11
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
        Me.btnEliminar.Location = New System.Drawing.Point(559, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 35)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "      Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(15, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 35)
        Me.btnNuevo.TabIndex = 15
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
        Me.btnGuardar.Location = New System.Drawing.Point(286, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 35)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "        Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(422, 15)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 35)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "      Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnModificar.Location = New System.Drawing.Point(151, 15)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 35)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "      Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'bnfCardList
        '
        Me.bnfCardList.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardList.BorderRadius = 5
        Me.bnfCardList.BottomSahddow = True
        Me.bnfCardList.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardList.Controls.Add(Me.dgvClientes)
        Me.bnfCardList.Controls.Add(Me.BunifuCards6)
        Me.bnfCardList.LeftSahddow = False
        Me.bnfCardList.Location = New System.Drawing.Point(11, 407)
        Me.bnfCardList.Name = "bnfCardList"
        Me.bnfCardList.RightSahddow = True
        Me.bnfCardList.ShadowDepth = 20
        Me.bnfCardList.Size = New System.Drawing.Size(1330, 339)
        Me.bnfCardList.TabIndex = 58
        '
        'dgvClientes
        '
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(9, 59)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(1310, 268)
        Me.dgvClientes.TabIndex = 50
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.txtBuscar)
        Me.BunifuCards6.Controls.Add(Me.Label7)
        Me.BunifuCards6.Controls.Add(Me.Label6)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(1316, 49)
        Me.BunifuCards6.TabIndex = 111
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(863, 11)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(440, 25)
        Me.txtBuscar.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(801, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "BUSCAR"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(487, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CLIENTES CARGADOS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'bnfElpCanc
        '
        Me.bnfElpCanc.ElipseRadius = 7
        Me.bnfElpCanc.TargetControl = Me.btnCancelar
        '
        'bnfElpElim
        '
        Me.bnfElpElim.ElipseRadius = 7
        Me.bnfElpElim.TargetControl = Me.btnEliminar
        '
        'pnlFrmClientes
        '
        Me.pnlFrmClientes.AutoScroll = True
        Me.pnlFrmClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmClientes.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmClientes.Controls.Add(Me.bnfCardTituloFrm)
        Me.pnlFrmClientes.Controls.Add(Me.bnfCardList)
        Me.pnlFrmClientes.Controls.Add(Me.bnfCardDatos)
        Me.pnlFrmClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmClientes.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmClientes.Name = "pnlFrmClientes"
        Me.pnlFrmClientes.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmClientes.TabIndex = 59
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.btnNuevo)
        Me.BunifuCards1.Controls.Add(Me.btnEliminar)
        Me.BunifuCards1.Controls.Add(Me.btnModificar)
        Me.BunifuCards1.Controls.Add(Me.btnCancelar)
        Me.BunifuCards1.Controls.Add(Me.btnGuardar)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(651, 752)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(690, 61)
        Me.BunifuCards1.TabIndex = 112
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmClientes)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClientes"
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardTituloFrm.ResumeLayout(False)
        Me.bnfCardTituloFrm.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardDatos.ResumeLayout(False)
        Me.pnlContendor.ResumeLayout(False)
        Me.pnlContendor.PerformLayout()
        Me.bnfCardList.ResumeLayout(False)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards6.ResumeLayout(False)
        Me.BunifuCards6.PerformLayout()
        Me.pnlFrmClientes.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfCardTituloFrm As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents bnfCardDatos As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pnlContendor As Panel
    Friend WithEvents txtIIBB As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtWeb As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCUIT As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents bnfCardList As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCredAsignado As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbSitIVA As ComboBox
    Friend WithEvents cmbClasificacion As ComboBox
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlFrmClientes As Panel
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents cbxProvincia As ComboBox
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
End Class
