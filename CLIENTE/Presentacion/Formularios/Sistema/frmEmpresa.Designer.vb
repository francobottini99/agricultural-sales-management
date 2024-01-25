<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresa))
        Me.pnlContendorDatos = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrefFac = New System.Windows.Forms.TextBox()
        Me.txtInicioAct = New System.Windows.Forms.TextBox()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxProvincia = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIIBB = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbxCatIva = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.bnfCardDatos = New Bunifu.Framework.UI.BunifuCards()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.pnlFrmEmpresa = New System.Windows.Forms.Panel()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.btnBorrarImagen = New System.Windows.Forms.Button()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.txtIdEmpresa = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.bnfCardImg = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxImagen = New System.Windows.Forms.PictureBox()
        Me.bnfElipCarg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipBorr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipCateg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlContendorDatos.SuspendLayout()
        Me.bnfCardDatos.SuspendLayout()
        Me.pnlFrmEmpresa.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardImg.SuspendLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContendorDatos
        '
        Me.pnlContendorDatos.Controls.Add(Me.Label9)
        Me.pnlContendorDatos.Controls.Add(Me.txtPrefFac)
        Me.pnlContendorDatos.Controls.Add(Me.txtInicioAct)
        Me.pnlContendorDatos.Controls.Add(Me.txtWeb)
        Me.pnlContendorDatos.Controls.Add(Me.txtMail)
        Me.pnlContendorDatos.Controls.Add(Me.txtTelefono)
        Me.pnlContendorDatos.Controls.Add(Me.Label7)
        Me.pnlContendorDatos.Controls.Add(Me.txtCuit)
        Me.pnlContendorDatos.Controls.Add(Me.Label5)
        Me.pnlContendorDatos.Controls.Add(Me.cbxProvincia)
        Me.pnlContendorDatos.Controls.Add(Me.Label8)
        Me.pnlContendorDatos.Controls.Add(Me.Label6)
        Me.pnlContendorDatos.Controls.Add(Me.Label4)
        Me.pnlContendorDatos.Controls.Add(Me.Label2)
        Me.pnlContendorDatos.Controls.Add(Me.Label1)
        Me.pnlContendorDatos.Controls.Add(Me.Label11)
        Me.pnlContendorDatos.Controls.Add(Me.txtIIBB)
        Me.pnlContendorDatos.Controls.Add(Me.txtLocalidad)
        Me.pnlContendorDatos.Controls.Add(Me.Label16)
        Me.pnlContendorDatos.Controls.Add(Me.cbxCatIva)
        Me.pnlContendorDatos.Controls.Add(Me.Label3)
        Me.pnlContendorDatos.Controls.Add(Me.txRazonSocial)
        Me.pnlContendorDatos.Controls.Add(Me.Label13)
        Me.pnlContendorDatos.Controls.Add(Me.txtDireccion)
        Me.pnlContendorDatos.Controls.Add(Me.txtPais)
        Me.pnlContendorDatos.Controls.Add(Me.Label10)
        Me.pnlContendorDatos.Controls.Add(Me.Label12)
        Me.pnlContendorDatos.Controls.Add(Me.txtCP)
        Me.pnlContendorDatos.Location = New System.Drawing.Point(5, 2)
        Me.pnlContendorDatos.Name = "pnlContendorDatos"
        Me.pnlContendorDatos.Size = New System.Drawing.Size(760, 387)
        Me.pnlContendorDatos.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(9, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 18)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "PREFIJO DE FACTURACION"
        '
        'txtPrefFac
        '
        Me.txtPrefFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPrefFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrefFac.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefFac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPrefFac.Location = New System.Drawing.Point(183, 353)
        Me.txtPrefFac.MaxLength = 13
        Me.txtPrefFac.Name = "txtPrefFac"
        Me.txtPrefFac.Size = New System.Drawing.Size(189, 25)
        Me.txtPrefFac.TabIndex = 87
        '
        'txtInicioAct
        '
        Me.txtInicioAct.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtInicioAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInicioAct.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioAct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtInicioAct.Location = New System.Drawing.Point(163, 289)
        Me.txtInicioAct.MaxLength = 10
        Me.txtInicioAct.Name = "txtInicioAct"
        Me.txtInicioAct.Size = New System.Drawing.Size(209, 25)
        Me.txtInicioAct.TabIndex = 9
        '
        'txtWeb
        '
        Me.txtWeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeb.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtWeb.Location = New System.Drawing.Point(118, 242)
        Me.txtWeb.MaxLength = 254
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(629, 25)
        Me.txtWeb.TabIndex = 8
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMail.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtMail.Location = New System.Drawing.Point(118, 210)
        Me.txtMail.MaxLength = 254
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(629, 25)
        Me.txtMail.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTelefono.Location = New System.Drawing.Point(118, 176)
        Me.txtTelefono.MaxLength = 254
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(629, 25)
        Me.txtTelefono.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(9, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 18)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "CUIT (Sin Guiones)"
        '
        'txtCuit
        '
        Me.txtCuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuit.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCuit.Location = New System.Drawing.Point(183, 322)
        Me.txtCuit.MaxLength = 13
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(189, 25)
        Me.txtCuit.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(378, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "ING. BRUTOS"
        '
        'cbxProvincia
        '
        Me.cbxProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbxProvincia.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProvincia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cbxProvincia.FormattingEnabled = True
        Me.cbxProvincia.Items.AddRange(New Object() {"Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán"})
        Me.cbxProvincia.Location = New System.Drawing.Point(513, 97)
        Me.cbxProvincia.Name = "cbxProvincia"
        Me.cbxProvincia.Size = New System.Drawing.Size(234, 28)
        Me.cbxProvincia.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(9, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 18)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "INIC. ACTIVIDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 18)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "WEB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(7, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 18)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "MAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(378, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "CATEGORIA IVA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(7, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "TELEFONOS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(7, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 18)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "CODIGO POSTAL"
        '
        'txtIIBB
        '
        Me.txtIIBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtIIBB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIIBB.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIIBB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtIIBB.Location = New System.Drawing.Point(482, 322)
        Me.txtIIBB.MaxLength = 45
        Me.txtIIBB.Name = "txtIIBB"
        Me.txtIIBB.Size = New System.Drawing.Size(265, 25)
        Me.txtIIBB.TabIndex = 12
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtLocalidad.Location = New System.Drawing.Point(118, 98)
        Me.txtLocalidad.MaxLength = 254
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(289, 25)
        Me.txtLocalidad.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(6, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 18)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "LOCALIDAD"
        '
        'cbxCatIva
        '
        Me.cbxCatIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbxCatIva.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCatIva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cbxCatIva.FormattingEnabled = True
        Me.cbxCatIva.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable no Inscripto", "IVA no Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado – Ley Nº 19.640", "IVA Responsable Inscripto – Agente de Percepción"})
        Me.cbxCatIva.Location = New System.Drawing.Point(482, 288)
        Me.cbxCatIva.Name = "cbxCatIva"
        Me.cbxCatIva.Size = New System.Drawing.Size(265, 28)
        Me.cbxCatIva.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "RAZON SOCIAL"
        '
        'txRazonSocial
        '
        Me.txRazonSocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txRazonSocial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txRazonSocial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.txRazonSocial.Location = New System.Drawing.Point(118, 11)
        Me.txRazonSocial.MaxLength = 254
        Me.txRazonSocial.Name = "txRazonSocial"
        Me.txRazonSocial.Size = New System.Drawing.Size(629, 26)
        Me.txRazonSocial.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(433, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 18)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "PAIS"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(118, 66)
        Me.txtDireccion.MaxLength = 254
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(629, 25)
        Me.txtDireccion.TabIndex = 1
        '
        'txtPais
        '
        Me.txtPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPais.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPais.Location = New System.Drawing.Point(514, 131)
        Me.txtPais.MaxLength = 254
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(233, 25)
        Me.txtPais.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(6, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 18)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "DIRECCION"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(433, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "PROVINCIA"
        '
        'txtCP
        '
        Me.txtCP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCP.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCP.Location = New System.Drawing.Point(118, 131)
        Me.txtCP.MaxLength = 45
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(289, 25)
        Me.txtCP.TabIndex = 4
        '
        'bnfCardDatos
        '
        Me.bnfCardDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDatos.BorderRadius = 5
        Me.bnfCardDatos.BottomSahddow = True
        Me.bnfCardDatos.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDatos.Controls.Add(Me.pnlContendorDatos)
        Me.bnfCardDatos.LeftSahddow = False
        Me.bnfCardDatos.Location = New System.Drawing.Point(11, 38)
        Me.bnfCardDatos.Name = "bnfCardDatos"
        Me.bnfCardDatos.RightSahddow = True
        Me.bnfCardDatos.ShadowDepth = 20
        Me.bnfCardDatos.Size = New System.Drawing.Size(766, 395)
        Me.bnfCardDatos.TabIndex = 53
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
        Me.btnEliminar.Location = New System.Drawing.Point(597, 15)
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
        Me.btnNuevo.Location = New System.Drawing.Point(53, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 35)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "     Alta"
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
        Me.btnGuardar.Location = New System.Drawing.Point(324, 15)
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
        Me.btnCancelar.Location = New System.Drawing.Point(460, 15)
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
        Me.btnModificar.Location = New System.Drawing.Point(189, 15)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 35)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "      Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'pnlFrmEmpresa
        '
        Me.pnlFrmEmpresa.AutoScroll = True
        Me.pnlFrmEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmEmpresa.Controls.Add(Me.BunifuCards1)
        Me.pnlFrmEmpresa.Controls.Add(Me.BunifuCards2)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfCardDatos)
        Me.pnlFrmEmpresa.Controls.Add(Me.bnfCardImg)
        Me.pnlFrmEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmEmpresa.Name = "pnlFrmEmpresa"
        Me.pnlFrmEmpresa.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmEmpresa.TabIndex = 59
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.btnEliminar)
        Me.BunifuCards1.Controls.Add(Me.btnNuevo)
        Me.BunifuCards1.Controls.Add(Me.btnModificar)
        Me.BunifuCards1.Controls.Add(Me.btnGuardar)
        Me.BunifuCards1.Controls.Add(Me.btnCancelar)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(11, 439)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(765, 61)
        Me.BunifuCards1.TabIndex = 113
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.btnCargarImagen)
        Me.BunifuCards2.Controls.Add(Me.btnBorrarImagen)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(783, 439)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(390, 61)
        Me.BunifuCards2.TabIndex = 112
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarImagen.FlatAppearance.BorderSize = 0
        Me.btnCargarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarImagen.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagen.ForeColor = System.Drawing.Color.White
        Me.btnCargarImagen.Image = Global.Presentacion.My.Resources.Resources.IconoImagen
        Me.btnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarImagen.Location = New System.Drawing.Point(11, 15)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(180, 35)
        Me.btnCargarImagen.TabIndex = 13
        Me.btnCargarImagen.Text = "      Cargar"
        Me.btnCargarImagen.UseVisualStyleBackColor = False
        '
        'btnBorrarImagen
        '
        Me.btnBorrarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnBorrarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarImagen.FlatAppearance.BorderSize = 0
        Me.btnBorrarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnBorrarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarImagen.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarImagen.ForeColor = System.Drawing.Color.White
        Me.btnBorrarImagen.Image = Global.Presentacion.My.Resources.Resources.IconoBorrarRecortado
        Me.btnBorrarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarImagen.Location = New System.Drawing.Point(201, 15)
        Me.btnBorrarImagen.Name = "btnBorrarImagen"
        Me.btnBorrarImagen.Size = New System.Drawing.Size(180, 35)
        Me.btnBorrarImagen.TabIndex = 14
        Me.btnBorrarImagen.Text = "      Borrar"
        Me.btnBorrarImagen.UseVisualStyleBackColor = False
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.txtIdEmpresa)
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = True
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTitulo.TabIndex = 55
        '
        'txtIdEmpresa
        '
        Me.txtIdEmpresa.BackColor = System.Drawing.Color.Red
        Me.txtIdEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdEmpresa.Enabled = False
        Me.txtIdEmpresa.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEmpresa.ForeColor = System.Drawing.Color.White
        Me.txtIdEmpresa.Location = New System.Drawing.Point(869, 7)
        Me.txtIdEmpresa.Name = "txtIdEmpresa"
        Me.txtIdEmpresa.Size = New System.Drawing.Size(68, 25)
        Me.txtIdEmpresa.TabIndex = 64
        Me.txtIdEmpresa.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(953, 6)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 63
        Me.txtOrigen.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(975, 35)
        Me.lblTitulo.TabIndex = 76
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoEmpresa
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxTitulo.TabIndex = 77
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
        'bnfCardImg
        '
        Me.bnfCardImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardImg.BorderRadius = 5
        Me.bnfCardImg.BottomSahddow = True
        Me.bnfCardImg.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardImg.Controls.Add(Me.pbxImagen)
        Me.bnfCardImg.LeftSahddow = False
        Me.bnfCardImg.Location = New System.Drawing.Point(783, 38)
        Me.bnfCardImg.Name = "bnfCardImg"
        Me.bnfCardImg.RightSahddow = True
        Me.bnfCardImg.ShadowDepth = 20
        Me.bnfCardImg.Size = New System.Drawing.Size(390, 395)
        Me.bnfCardImg.TabIndex = 54
        '
        'pbxImagen
        '
        Me.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImagen.Image = Global.Presentacion.My.Resources.Resources.IconoEmpresa
        Me.pbxImagen.Location = New System.Drawing.Point(10, 14)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(370, 370)
        Me.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxImagen.TabIndex = 42
        Me.pbxImagen.TabStop = False
        '
        'bnfElipCarg
        '
        Me.bnfElipCarg.ElipseRadius = 7
        Me.bnfElipCarg.TargetControl = Me.btnCargarImagen
        '
        'bnfElipBorr
        '
        Me.bnfElipBorr.ElipseRadius = 7
        Me.bnfElipBorr.TargetControl = Me.btnBorrarImagen
        '
        'ofdImagen
        '
        '
        'bnfElpElim
        '
        Me.bnfElpElim.ElipseRadius = 7
        Me.bnfElpElim.TargetControl = Me.btnEliminar
        '
        'bnfElipCateg
        '
        Me.bnfElipCateg.ElipseRadius = 7
        Me.bnfElipCateg.TargetControl = Me
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'bnfElpCanc
        '
        Me.bnfElpCanc.ElipseRadius = 7
        Me.bnfElpCanc.TargetControl = Me.btnCancelar
        '
        'bnfElpGuar
        '
        Me.bnfElpGuar.ElipseRadius = 7
        Me.bnfElpGuar.TargetControl = Me.btnGuardar
        '
        'bnfElpMod
        '
        Me.bnfElpMod.ElipseRadius = 7
        Me.bnfElpMod.TargetControl = Me.btnModificar
        '
        'bnfElpNuevo
        '
        Me.bnfElpNuevo.ElipseRadius = 7
        Me.bnfElpNuevo.TargetControl = Me.btnNuevo
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmEmpresa)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpresa"
        Me.Text = "frmEmpresa"
        Me.pnlContendorDatos.ResumeLayout(False)
        Me.pnlContendorDatos.PerformLayout()
        Me.bnfCardDatos.ResumeLayout(False)
        Me.pnlFrmEmpresa.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardImg.ResumeLayout(False)
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContendorDatos As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIIBB As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbxCatIva As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txRazonSocial As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents btnBorrarImagen As Button
    Friend WithEvents bnfCardDatos As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents pnlFrmEmpresa As Panel
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfCardImg As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxImagen As PictureBox
    Friend WithEvents bnfElipCarg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipBorr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ofdImagen As OpenFileDialog
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipCateg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents cbxProvincia As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtInicioAct As TextBox
    Friend WithEvents txtWeb As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtIdEmpresa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrefFac As TextBox
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
End Class
