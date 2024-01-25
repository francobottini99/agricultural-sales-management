<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPpal
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPpal))
        Me.Hora = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.bnfTransicion = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.bnfPanelMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.pnlMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlSeguridad = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.btnRegistroActividad = New System.Windows.Forms.Button()
        Me.btnRegistroRespaldo = New System.Windows.Forms.Button()
        Me.btnPerfilesUs = New System.Windows.Forms.Button()
        Me.btnRespaldo = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel63 = New System.Windows.Forms.Panel()
        Me.btnSeguridad = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.pnlConsultas = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.btnConsBancos = New System.Windows.Forms.Button()
        Me.btnConsStock = New System.Windows.Forms.Button()
        Me.pnlConsCanjes = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.btnConsLiquidaciones = New System.Windows.Forms.Button()
        Me.btnConsCartaPorte = New System.Windows.Forms.Button()
        Me.btnConsFiacionesCtos = New System.Windows.Forms.Button()
        Me.btnConsContratos = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel75 = New System.Windows.Forms.Panel()
        Me.btnConsCanjes = New System.Windows.Forms.Button()
        Me.pnlConsCaja = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.btnConcCartera = New System.Windows.Forms.Button()
        Me.btnConsArqueos = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel78 = New System.Windows.Forms.Panel()
        Me.btnConsCaja = New System.Windows.Forms.Button()
        Me.pnlConsVentas = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.btnConsVtaCuentaCorriente = New System.Windows.Forms.Button()
        Me.btnConsVtaND = New System.Windows.Forms.Button()
        Me.btnConsVtaNC = New System.Windows.Forms.Button()
        Me.btnConsVtaFacturas = New System.Windows.Forms.Button()
        Me.btnConsVtaRemitos = New System.Windows.Forms.Button()
        Me.btnConsVtaPedidos = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel56 = New System.Windows.Forms.Panel()
        Me.btnConsVentas = New System.Windows.Forms.Button()
        Me.pnlConsCompras = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.btnConsComCuentaCorriente = New System.Windows.Forms.Button()
        Me.btnConsComNotasDebito = New System.Windows.Forms.Button()
        Me.btnConsComNotasCredito = New System.Windows.Forms.Button()
        Me.btnConsComFacturas = New System.Windows.Forms.Button()
        Me.btnConsComRemito = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.btnConsCompras = New System.Windows.Forms.Button()
        Me.btnConsArticulos = New System.Windows.Forms.Button()
        Me.btnConsProv = New System.Windows.Forms.Button()
        Me.btnConsClientes = New System.Windows.Forms.Button()
        Me.btnConsUsuarios = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel50 = New System.Windows.Forms.Panel()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.pnlStock = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.btnTransferenciasStock = New System.Windows.Forms.Button()
        Me.btnMantenimientoStock = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel61 = New System.Windows.Forms.Panel()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.pnlGestion = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.pnlBancos = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.btnBcoRetiros = New System.Windows.Forms.Button()
        Me.btnBcoDepositos = New System.Windows.Forms.Button()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel47 = New System.Windows.Forms.Panel()
        Me.btnBanco = New System.Windows.Forms.Button()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.pnlCanjes = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.btnLiquidaciones = New System.Windows.Forms.Button()
        Me.btnCartasPorte = New System.Windows.Forms.Button()
        Me.btnFijacionContratos = New System.Windows.Forms.Button()
        Me.btnEmisionContratos = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.btnCanjes = New System.Windows.Forms.Button()
        Me.pnlVentas = New System.Windows.Forms.Panel()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.btnDevolucionesVta = New System.Windows.Forms.Button()
        Me.btnRecVta = New System.Windows.Forms.Button()
        Me.btnNDVta = New System.Windows.Forms.Button()
        Me.btnNCVta = New System.Windows.Forms.Button()
        Me.btnFacVta = New System.Windows.Forms.Button()
        Me.btnRemVta = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.pnlCompras = New System.Windows.Forms.Panel()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.btnOrdPago = New System.Windows.Forms.Button()
        Me.btnNDCom = New System.Windows.Forms.Button()
        Me.btnNCCom = New System.Windows.Forms.Button()
        Me.btnFacCom = New System.Windows.Forms.Button()
        Me.btnRemCom = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.pnlAltas = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.btnChequera = New System.Windows.Forms.Button()
        Me.btnDepositos = New System.Windows.Forms.Button()
        Me.btnCtasContables = New System.Windows.Forms.Button()
        Me.btnBancos = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnCategorias = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnAltas = New System.Windows.Forms.Button()
        Me.pnlSistema = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.btnPtoVta = New System.Windows.Forms.Button()
        Me.btnAlicuota = New System.Windows.Forms.Button()
        Me.btnComprobantes = New System.Windows.Forms.Button()
        Me.btnMoneda = New System.Windows.Forms.Button()
        Me.btnEmpresa = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSistema = New System.Windows.Forms.Button()
        Me.bnfPanelPie = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblFechaSecundaria = New System.Windows.Forms.Label()
        Me.lblHoraSecundaria = New System.Windows.Forms.Label()
        Me.pbxUsuario = New System.Windows.Forms.PictureBox()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.bnfPanelLogo = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.pbxEmpresa = New System.Windows.Forms.PictureBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlBarraFrm = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxMin = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxRest = New System.Windows.Forms.PictureBox()
        Me.pbxMax = New System.Windows.Forms.PictureBox()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.tmrVolver = New System.Windows.Forms.Timer(Me.components)
        Me.bnfPanelMenu.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlSeguridad.SuspendLayout()
        Me.pnlConsultas.SuspendLayout()
        Me.pnlConsCanjes.SuspendLayout()
        Me.pnlConsCaja.SuspendLayout()
        Me.pnlConsVentas.SuspendLayout()
        Me.pnlConsCompras.SuspendLayout()
        Me.pnlStock.SuspendLayout()
        Me.pnlGestion.SuspendLayout()
        Me.pnlBancos.SuspendLayout()
        Me.pnlCanjes.SuspendLayout()
        Me.pnlVentas.SuspendLayout()
        Me.pnlCompras.SuspendLayout()
        Me.pnlAltas.SuspendLayout()
        Me.pnlSistema.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.bnfPanelPie.SuspendLayout()
        CType(Me.pbxUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfPanelLogo.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.pbxEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBarraFrm.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hora
        '
        Me.Hora.Enabled = True
        Me.Hora.Interval = 1000
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.pnlContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(248, 33)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1352, 827)
        Me.pnlContenedor.TabIndex = 2
        '
        'bnfTransicion
        '
        Me.bnfTransicion.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.bnfTransicion.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.bnfTransicion.DefaultAnimation = Animation1
        Me.bnfTransicion.TimeStep = 0.05!
        '
        'bnfPanelMenu
        '
        Me.bnfPanelMenu.BackgroundImage = CType(resources.GetObject("bnfPanelMenu.BackgroundImage"), System.Drawing.Image)
        Me.bnfPanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bnfPanelMenu.Controls.Add(Me.pnlMenu)
        Me.bnfPanelMenu.Controls.Add(Me.bnfPanelPie)
        Me.bnfPanelMenu.Controls.Add(Me.bnfPanelLogo)
        Me.bnfTransicion.SetDecoration(Me.bnfPanelMenu, BunifuAnimatorNS.DecorationType.None)
        Me.bnfPanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.bnfPanelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfPanelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfPanelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfPanelMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfPanelMenu.Location = New System.Drawing.Point(0, 33)
        Me.bnfPanelMenu.Name = "bnfPanelMenu"
        Me.bnfPanelMenu.Quality = 50
        Me.bnfPanelMenu.Size = New System.Drawing.Size(248, 827)
        Me.bnfPanelMenu.TabIndex = 28
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoScroll = True
        Me.pnlMenu.BackgroundImage = CType(resources.GetObject("pnlMenu.BackgroundImage"), System.Drawing.Image)
        Me.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMenu.Controls.Add(Me.btnSalir)
        Me.pnlMenu.Controls.Add(Me.pnlSeguridad)
        Me.pnlMenu.Controls.Add(Me.btnSeguridad)
        Me.pnlMenu.Controls.Add(Me.btnReportes)
        Me.pnlMenu.Controls.Add(Me.pnlConsultas)
        Me.pnlMenu.Controls.Add(Me.btnConsultas)
        Me.pnlMenu.Controls.Add(Me.pnlStock)
        Me.pnlMenu.Controls.Add(Me.btnStock)
        Me.pnlMenu.Controls.Add(Me.pnlGestion)
        Me.pnlMenu.Controls.Add(Me.btnGestion)
        Me.pnlMenu.Controls.Add(Me.pnlAltas)
        Me.pnlMenu.Controls.Add(Me.btnAltas)
        Me.pnlMenu.Controls.Add(Me.pnlSistema)
        Me.pnlMenu.Controls.Add(Me.btnSistema)
        Me.bnfTransicion.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlMenu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlMenu.Location = New System.Drawing.Point(0, 125)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Quality = 10
        Me.pnlMenu.Size = New System.Drawing.Size(248, 559)
        Me.pnlMenu.TabIndex = 48
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnSalir, BunifuAnimatorNS.DecorationType.None)
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.Presentacion.My.Resources.Resources.IconoSalir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 2751)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(231, 35)
        Me.btnSalir.TabIndex = 44
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'pnlSeguridad
        '
        Me.pnlSeguridad.AutoSize = True
        Me.pnlSeguridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlSeguridad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlSeguridad.Controls.Add(Me.Panel27)
        Me.pnlSeguridad.Controls.Add(Me.btnRegistroActividad)
        Me.pnlSeguridad.Controls.Add(Me.btnRegistroRespaldo)
        Me.pnlSeguridad.Controls.Add(Me.btnPerfilesUs)
        Me.pnlSeguridad.Controls.Add(Me.btnRespaldo)
        Me.pnlSeguridad.Controls.Add(Me.Panel10)
        Me.pnlSeguridad.Controls.Add(Me.Panel63)
        Me.bnfTransicion.SetDecoration(Me.pnlSeguridad, BunifuAnimatorNS.DecorationType.None)
        Me.pnlSeguridad.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSeguridad.Location = New System.Drawing.Point(0, 2607)
        Me.pnlSeguridad.Name = "pnlSeguridad"
        Me.pnlSeguridad.Size = New System.Drawing.Size(231, 144)
        Me.pnlSeguridad.TabIndex = 21
        Me.pnlSeguridad.Visible = False
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel27, BunifuAnimatorNS.DecorationType.None)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(10, 142)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(221, 2)
        Me.Panel27.TabIndex = 24
        '
        'btnRegistroActividad
        '
        Me.btnRegistroActividad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnRegistroActividad, BunifuAnimatorNS.DecorationType.None)
        Me.btnRegistroActividad.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistroActividad.FlatAppearance.BorderSize = 0
        Me.btnRegistroActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnRegistroActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistroActividad.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroActividad.ForeColor = System.Drawing.Color.White
        Me.btnRegistroActividad.Image = Global.Presentacion.My.Resources.Resources.IconoRegistroOperaciones
        Me.btnRegistroActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistroActividad.Location = New System.Drawing.Point(10, 107)
        Me.btnRegistroActividad.Name = "btnRegistroActividad"
        Me.btnRegistroActividad.Size = New System.Drawing.Size(221, 35)
        Me.btnRegistroActividad.TabIndex = 13
        Me.btnRegistroActividad.Text = "Registro Activ."
        Me.btnRegistroActividad.UseVisualStyleBackColor = True
        Me.btnRegistroActividad.Visible = False
        '
        'btnRegistroRespaldo
        '
        Me.btnRegistroRespaldo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnRegistroRespaldo, BunifuAnimatorNS.DecorationType.None)
        Me.btnRegistroRespaldo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistroRespaldo.FlatAppearance.BorderSize = 0
        Me.btnRegistroRespaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnRegistroRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistroRespaldo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroRespaldo.ForeColor = System.Drawing.Color.White
        Me.btnRegistroRespaldo.Image = Global.Presentacion.My.Resources.Resources.IconoRegistroRespaldos1
        Me.btnRegistroRespaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistroRespaldo.Location = New System.Drawing.Point(10, 72)
        Me.btnRegistroRespaldo.Name = "btnRegistroRespaldo"
        Me.btnRegistroRespaldo.Size = New System.Drawing.Size(221, 35)
        Me.btnRegistroRespaldo.TabIndex = 5
        Me.btnRegistroRespaldo.Text = "Registro Resp."
        Me.btnRegistroRespaldo.UseVisualStyleBackColor = True
        Me.btnRegistroRespaldo.Visible = False
        '
        'btnPerfilesUs
        '
        Me.btnPerfilesUs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnPerfilesUs, BunifuAnimatorNS.DecorationType.None)
        Me.btnPerfilesUs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPerfilesUs.FlatAppearance.BorderSize = 0
        Me.btnPerfilesUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnPerfilesUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfilesUs.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfilesUs.ForeColor = System.Drawing.Color.White
        Me.btnPerfilesUs.Image = Global.Presentacion.My.Resources.Resources.IconoPerfilUsuario
        Me.btnPerfilesUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfilesUs.Location = New System.Drawing.Point(10, 37)
        Me.btnPerfilesUs.Name = "btnPerfilesUs"
        Me.btnPerfilesUs.Size = New System.Drawing.Size(221, 35)
        Me.btnPerfilesUs.TabIndex = 4
        Me.btnPerfilesUs.Text = "Perfiles Us."
        Me.btnPerfilesUs.UseVisualStyleBackColor = True
        '
        'btnRespaldo
        '
        Me.btnRespaldo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnRespaldo, BunifuAnimatorNS.DecorationType.None)
        Me.btnRespaldo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRespaldo.FlatAppearance.BorderSize = 0
        Me.btnRespaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRespaldo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRespaldo.ForeColor = System.Drawing.Color.White
        Me.btnRespaldo.Image = Global.Presentacion.My.Resources.Resources.IconoRespaldo
        Me.btnRespaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRespaldo.Location = New System.Drawing.Point(10, 2)
        Me.btnRespaldo.Name = "btnRespaldo"
        Me.btnRespaldo.Size = New System.Drawing.Size(221, 35)
        Me.btnRespaldo.TabIndex = 2
        Me.btnRespaldo.Text = "Respaldos"
        Me.btnRespaldo.UseVisualStyleBackColor = True
        Me.btnRespaldo.Visible = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel10, BunifuAnimatorNS.DecorationType.None)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(10, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(221, 2)
        Me.Panel10.TabIndex = 23
        '
        'Panel63
        '
        Me.Panel63.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel63, BunifuAnimatorNS.DecorationType.None)
        Me.Panel63.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel63.Location = New System.Drawing.Point(0, 0)
        Me.Panel63.Name = "Panel63"
        Me.Panel63.Size = New System.Drawing.Size(10, 144)
        Me.Panel63.TabIndex = 0
        '
        'btnSeguridad
        '
        Me.btnSeguridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSeguridad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnSeguridad, BunifuAnimatorNS.DecorationType.None)
        Me.btnSeguridad.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSeguridad.FlatAppearance.BorderSize = 0
        Me.btnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeguridad.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeguridad.ForeColor = System.Drawing.Color.White
        Me.btnSeguridad.Image = Global.Presentacion.My.Resources.Resources.IconoSeguridad
        Me.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeguridad.Location = New System.Drawing.Point(0, 2572)
        Me.btnSeguridad.Name = "btnSeguridad"
        Me.btnSeguridad.Size = New System.Drawing.Size(231, 35)
        Me.btnSeguridad.TabIndex = 43
        Me.btnSeguridad.Text = "Seguridad"
        Me.btnSeguridad.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnReportes, BunifuAnimatorNS.DecorationType.None)
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Image = Global.Presentacion.My.Resources.Resources.reportes1
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 2537)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(231, 35)
        Me.btnReportes.TabIndex = 41
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = False
        Me.btnReportes.Visible = False
        '
        'pnlConsultas
        '
        Me.pnlConsultas.AutoSize = True
        Me.pnlConsultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlConsultas.Controls.Add(Me.Panel25)
        Me.pnlConsultas.Controls.Add(Me.btnConsBancos)
        Me.pnlConsultas.Controls.Add(Me.btnConsStock)
        Me.pnlConsultas.Controls.Add(Me.pnlConsCanjes)
        Me.pnlConsultas.Controls.Add(Me.btnConsCanjes)
        Me.pnlConsultas.Controls.Add(Me.pnlConsCaja)
        Me.pnlConsultas.Controls.Add(Me.btnConsCaja)
        Me.pnlConsultas.Controls.Add(Me.pnlConsVentas)
        Me.pnlConsultas.Controls.Add(Me.btnConsVentas)
        Me.pnlConsultas.Controls.Add(Me.pnlConsCompras)
        Me.pnlConsultas.Controls.Add(Me.btnConsCompras)
        Me.pnlConsultas.Controls.Add(Me.btnConsArticulos)
        Me.pnlConsultas.Controls.Add(Me.btnConsProv)
        Me.pnlConsultas.Controls.Add(Me.btnConsClientes)
        Me.pnlConsultas.Controls.Add(Me.btnConsUsuarios)
        Me.pnlConsultas.Controls.Add(Me.Panel6)
        Me.pnlConsultas.Controls.Add(Me.Panel50)
        Me.bnfTransicion.SetDecoration(Me.pnlConsultas, BunifuAnimatorNS.DecorationType.None)
        Me.pnlConsultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConsultas.Location = New System.Drawing.Point(0, 1572)
        Me.pnlConsultas.Name = "pnlConsultas"
        Me.pnlConsultas.Size = New System.Drawing.Size(231, 965)
        Me.pnlConsultas.TabIndex = 12
        Me.pnlConsultas.Visible = False
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel25, BunifuAnimatorNS.DecorationType.None)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(10, 963)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(221, 2)
        Me.Panel25.TabIndex = 29
        '
        'btnConsBancos
        '
        Me.btnConsBancos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsBancos, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsBancos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsBancos.FlatAppearance.BorderSize = 0
        Me.btnConsBancos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsBancos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsBancos.ForeColor = System.Drawing.Color.White
        Me.btnConsBancos.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasBancos
        Me.btnConsBancos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsBancos.Location = New System.Drawing.Point(10, 928)
        Me.btnConsBancos.Name = "btnConsBancos"
        Me.btnConsBancos.Size = New System.Drawing.Size(221, 35)
        Me.btnConsBancos.TabIndex = 19
        Me.btnConsBancos.Text = "Bancos"
        Me.btnConsBancos.UseVisualStyleBackColor = True
        Me.btnConsBancos.Visible = False
        '
        'btnConsStock
        '
        Me.btnConsStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsStock, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsStock.FlatAppearance.BorderSize = 0
        Me.btnConsStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsStock.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsStock.ForeColor = System.Drawing.Color.White
        Me.btnConsStock.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasStock
        Me.btnConsStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsStock.Location = New System.Drawing.Point(10, 893)
        Me.btnConsStock.Name = "btnConsStock"
        Me.btnConsStock.Size = New System.Drawing.Size(221, 35)
        Me.btnConsStock.TabIndex = 21
        Me.btnConsStock.Text = "Stock"
        Me.btnConsStock.UseVisualStyleBackColor = True
        Me.btnConsStock.Visible = False
        '
        'pnlConsCanjes
        '
        Me.pnlConsCanjes.AutoSize = True
        Me.pnlConsCanjes.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlConsCanjes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlConsCanjes.Controls.Add(Me.Panel28)
        Me.pnlConsCanjes.Controls.Add(Me.btnConsLiquidaciones)
        Me.pnlConsCanjes.Controls.Add(Me.btnConsCartaPorte)
        Me.pnlConsCanjes.Controls.Add(Me.btnConsFiacionesCtos)
        Me.pnlConsCanjes.Controls.Add(Me.btnConsContratos)
        Me.pnlConsCanjes.Controls.Add(Me.Panel14)
        Me.pnlConsCanjes.Controls.Add(Me.Panel75)
        Me.bnfTransicion.SetDecoration(Me.pnlConsCanjes, BunifuAnimatorNS.DecorationType.None)
        Me.pnlConsCanjes.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConsCanjes.Location = New System.Drawing.Point(10, 749)
        Me.pnlConsCanjes.Name = "pnlConsCanjes"
        Me.pnlConsCanjes.Size = New System.Drawing.Size(221, 144)
        Me.pnlConsCanjes.TabIndex = 27
        Me.pnlConsCanjes.Visible = False
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel28, BunifuAnimatorNS.DecorationType.None)
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel28.Location = New System.Drawing.Point(10, 142)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(211, 2)
        Me.Panel28.TabIndex = 9
        '
        'btnConsLiquidaciones
        '
        Me.btnConsLiquidaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsLiquidaciones, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsLiquidaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsLiquidaciones.FlatAppearance.BorderSize = 0
        Me.btnConsLiquidaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsLiquidaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsLiquidaciones.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsLiquidaciones.ForeColor = System.Drawing.Color.White
        Me.btnConsLiquidaciones.Image = Global.Presentacion.My.Resources.Resources.IconoLiquidaciones
        Me.btnConsLiquidaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsLiquidaciones.Location = New System.Drawing.Point(10, 107)
        Me.btnConsLiquidaciones.Name = "btnConsLiquidaciones"
        Me.btnConsLiquidaciones.Size = New System.Drawing.Size(211, 35)
        Me.btnConsLiquidaciones.TabIndex = 5
        Me.btnConsLiquidaciones.Text = "Liquidaciones"
        Me.btnConsLiquidaciones.UseVisualStyleBackColor = True
        '
        'btnConsCartaPorte
        '
        Me.btnConsCartaPorte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsCartaPorte, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsCartaPorte.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsCartaPorte.FlatAppearance.BorderSize = 0
        Me.btnConsCartaPorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsCartaPorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsCartaPorte.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsCartaPorte.ForeColor = System.Drawing.Color.White
        Me.btnConsCartaPorte.Image = Global.Presentacion.My.Resources.Resources.IconoCartaPorte
        Me.btnConsCartaPorte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsCartaPorte.Location = New System.Drawing.Point(10, 72)
        Me.btnConsCartaPorte.Name = "btnConsCartaPorte"
        Me.btnConsCartaPorte.Size = New System.Drawing.Size(211, 35)
        Me.btnConsCartaPorte.TabIndex = 4
        Me.btnConsCartaPorte.Text = "Carta Porte"
        Me.btnConsCartaPorte.UseVisualStyleBackColor = True
        '
        'btnConsFiacionesCtos
        '
        Me.btnConsFiacionesCtos.AccessibleName = "c"
        Me.btnConsFiacionesCtos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsFiacionesCtos, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsFiacionesCtos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsFiacionesCtos.FlatAppearance.BorderSize = 0
        Me.btnConsFiacionesCtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsFiacionesCtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsFiacionesCtos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsFiacionesCtos.ForeColor = System.Drawing.Color.White
        Me.btnConsFiacionesCtos.Image = Global.Presentacion.My.Resources.Resources.IconoFijarContrato
        Me.btnConsFiacionesCtos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsFiacionesCtos.Location = New System.Drawing.Point(10, 37)
        Me.btnConsFiacionesCtos.Name = "btnConsFiacionesCtos"
        Me.btnConsFiacionesCtos.Size = New System.Drawing.Size(211, 35)
        Me.btnConsFiacionesCtos.TabIndex = 3
        Me.btnConsFiacionesCtos.Text = "Cons Fijaciones"
        Me.btnConsFiacionesCtos.UseVisualStyleBackColor = True
        '
        'btnConsContratos
        '
        Me.btnConsContratos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsContratos, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsContratos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsContratos.FlatAppearance.BorderSize = 0
        Me.btnConsContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsContratos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsContratos.ForeColor = System.Drawing.Color.White
        Me.btnConsContratos.Image = Global.Presentacion.My.Resources.Resources.IconoContrato
        Me.btnConsContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsContratos.Location = New System.Drawing.Point(10, 2)
        Me.btnConsContratos.Name = "btnConsContratos"
        Me.btnConsContratos.Size = New System.Drawing.Size(211, 35)
        Me.btnConsContratos.TabIndex = 2
        Me.btnConsContratos.Text = "Contratos"
        Me.btnConsContratos.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel14, BunifuAnimatorNS.DecorationType.None)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(10, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(211, 2)
        Me.Panel14.TabIndex = 8
        '
        'Panel75
        '
        Me.Panel75.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel75, BunifuAnimatorNS.DecorationType.None)
        Me.Panel75.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel75.Location = New System.Drawing.Point(0, 0)
        Me.Panel75.Name = "Panel75"
        Me.Panel75.Size = New System.Drawing.Size(10, 144)
        Me.Panel75.TabIndex = 0
        '
        'btnConsCanjes
        '
        Me.btnConsCanjes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsCanjes, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsCanjes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsCanjes.FlatAppearance.BorderSize = 0
        Me.btnConsCanjes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsCanjes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsCanjes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsCanjes.ForeColor = System.Drawing.Color.White
        Me.btnConsCanjes.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasCanjes
        Me.btnConsCanjes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsCanjes.Location = New System.Drawing.Point(10, 714)
        Me.btnConsCanjes.Name = "btnConsCanjes"
        Me.btnConsCanjes.Size = New System.Drawing.Size(221, 35)
        Me.btnConsCanjes.TabIndex = 17
        Me.btnConsCanjes.Text = "Canjes"
        Me.btnConsCanjes.UseVisualStyleBackColor = True
        Me.btnConsCanjes.Visible = False
        '
        'pnlConsCaja
        '
        Me.pnlConsCaja.AutoSize = True
        Me.pnlConsCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlConsCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlConsCaja.Controls.Add(Me.Panel29)
        Me.pnlConsCaja.Controls.Add(Me.btnConcCartera)
        Me.pnlConsCaja.Controls.Add(Me.btnConsArqueos)
        Me.pnlConsCaja.Controls.Add(Me.Panel11)
        Me.pnlConsCaja.Controls.Add(Me.Panel78)
        Me.bnfTransicion.SetDecoration(Me.pnlConsCaja, BunifuAnimatorNS.DecorationType.None)
        Me.pnlConsCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConsCaja.Location = New System.Drawing.Point(10, 640)
        Me.pnlConsCaja.Name = "pnlConsCaja"
        Me.pnlConsCaja.Size = New System.Drawing.Size(221, 74)
        Me.pnlConsCaja.TabIndex = 28
        Me.pnlConsCaja.Visible = False
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel29, BunifuAnimatorNS.DecorationType.None)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel29.Location = New System.Drawing.Point(10, 72)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(211, 2)
        Me.Panel29.TabIndex = 9
        '
        'btnConcCartera
        '
        Me.btnConcCartera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConcCartera, BunifuAnimatorNS.DecorationType.None)
        Me.btnConcCartera.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConcCartera.FlatAppearance.BorderSize = 0
        Me.btnConcCartera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConcCartera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConcCartera.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConcCartera.ForeColor = System.Drawing.Color.White
        Me.btnConcCartera.Image = Global.Presentacion.My.Resources.Resources.IconoChequera
        Me.btnConcCartera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConcCartera.Location = New System.Drawing.Point(10, 37)
        Me.btnConcCartera.Name = "btnConcCartera"
        Me.btnConcCartera.Size = New System.Drawing.Size(211, 35)
        Me.btnConcCartera.TabIndex = 4
        Me.btnConcCartera.Text = "Cons. Cartera"
        Me.btnConcCartera.UseVisualStyleBackColor = True
        '
        'btnConsArqueos
        '
        Me.btnConsArqueos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsArqueos, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsArqueos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsArqueos.FlatAppearance.BorderSize = 0
        Me.btnConsArqueos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsArqueos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsArqueos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsArqueos.ForeColor = System.Drawing.Color.White
        Me.btnConsArqueos.Image = Global.Presentacion.My.Resources.Resources.IconoCajaMovimiento
        Me.btnConsArqueos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsArqueos.Location = New System.Drawing.Point(10, 2)
        Me.btnConsArqueos.Name = "btnConsArqueos"
        Me.btnConsArqueos.Size = New System.Drawing.Size(211, 35)
        Me.btnConsArqueos.TabIndex = 2
        Me.btnConsArqueos.Text = "Cons. Arqueos"
        Me.btnConsArqueos.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel11, BunifuAnimatorNS.DecorationType.None)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(10, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(211, 2)
        Me.Panel11.TabIndex = 8
        '
        'Panel78
        '
        Me.Panel78.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel78, BunifuAnimatorNS.DecorationType.None)
        Me.Panel78.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel78.Location = New System.Drawing.Point(0, 0)
        Me.Panel78.Name = "Panel78"
        Me.Panel78.Size = New System.Drawing.Size(10, 74)
        Me.Panel78.TabIndex = 0
        '
        'btnConsCaja
        '
        Me.btnConsCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsCaja, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsCaja.FlatAppearance.BorderSize = 0
        Me.btnConsCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsCaja.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsCaja.ForeColor = System.Drawing.Color.White
        Me.btnConsCaja.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasCaja
        Me.btnConsCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsCaja.Location = New System.Drawing.Point(10, 605)
        Me.btnConsCaja.Name = "btnConsCaja"
        Me.btnConsCaja.Size = New System.Drawing.Size(221, 35)
        Me.btnConsCaja.TabIndex = 19
        Me.btnConsCaja.Text = "Caja"
        Me.btnConsCaja.UseVisualStyleBackColor = True
        Me.btnConsCaja.Visible = False
        '
        'pnlConsVentas
        '
        Me.pnlConsVentas.AutoSize = True
        Me.pnlConsVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlConsVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlConsVentas.Controls.Add(Me.Panel30)
        Me.pnlConsVentas.Controls.Add(Me.btnConsVtaCuentaCorriente)
        Me.pnlConsVentas.Controls.Add(Me.btnConsVtaND)
        Me.pnlConsVentas.Controls.Add(Me.btnConsVtaNC)
        Me.pnlConsVentas.Controls.Add(Me.btnConsVtaFacturas)
        Me.pnlConsVentas.Controls.Add(Me.btnConsVtaRemitos)
        Me.pnlConsVentas.Controls.Add(Me.btnConsVtaPedidos)
        Me.pnlConsVentas.Controls.Add(Me.Panel9)
        Me.pnlConsVentas.Controls.Add(Me.Panel56)
        Me.bnfTransicion.SetDecoration(Me.pnlConsVentas, BunifuAnimatorNS.DecorationType.None)
        Me.pnlConsVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConsVentas.Location = New System.Drawing.Point(10, 391)
        Me.pnlConsVentas.Name = "pnlConsVentas"
        Me.pnlConsVentas.Size = New System.Drawing.Size(221, 214)
        Me.pnlConsVentas.TabIndex = 26
        Me.pnlConsVentas.Visible = False
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel30, BunifuAnimatorNS.DecorationType.None)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel30.Location = New System.Drawing.Point(10, 212)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(211, 2)
        Me.Panel30.TabIndex = 15
        '
        'btnConsVtaCuentaCorriente
        '
        Me.btnConsVtaCuentaCorriente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsVtaCuentaCorriente, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsVtaCuentaCorriente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsVtaCuentaCorriente.FlatAppearance.BorderSize = 0
        Me.btnConsVtaCuentaCorriente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsVtaCuentaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsVtaCuentaCorriente.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsVtaCuentaCorriente.ForeColor = System.Drawing.Color.White
        Me.btnConsVtaCuentaCorriente.Image = Global.Presentacion.My.Resources.Resources.IconoCuentaCorriente2
        Me.btnConsVtaCuentaCorriente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsVtaCuentaCorriente.Location = New System.Drawing.Point(10, 177)
        Me.btnConsVtaCuentaCorriente.Name = "btnConsVtaCuentaCorriente"
        Me.btnConsVtaCuentaCorriente.Size = New System.Drawing.Size(211, 35)
        Me.btnConsVtaCuentaCorriente.TabIndex = 16
        Me.btnConsVtaCuentaCorriente.Text = "   Cuentas Corrientes"
        Me.btnConsVtaCuentaCorriente.UseVisualStyleBackColor = True
        '
        'btnConsVtaND
        '
        Me.btnConsVtaND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsVtaND, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsVtaND.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsVtaND.FlatAppearance.BorderSize = 0
        Me.btnConsVtaND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsVtaND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsVtaND.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsVtaND.ForeColor = System.Drawing.Color.White
        Me.btnConsVtaND.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasNota
        Me.btnConsVtaND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsVtaND.Location = New System.Drawing.Point(10, 142)
        Me.btnConsVtaND.Name = "btnConsVtaND"
        Me.btnConsVtaND.Size = New System.Drawing.Size(211, 35)
        Me.btnConsVtaND.TabIndex = 5
        Me.btnConsVtaND.Text = "Notas Debito"
        Me.btnConsVtaND.UseVisualStyleBackColor = True
        Me.btnConsVtaND.Visible = False
        '
        'btnConsVtaNC
        '
        Me.btnConsVtaNC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsVtaNC, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsVtaNC.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsVtaNC.FlatAppearance.BorderSize = 0
        Me.btnConsVtaNC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsVtaNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsVtaNC.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsVtaNC.ForeColor = System.Drawing.Color.White
        Me.btnConsVtaNC.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasNota
        Me.btnConsVtaNC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsVtaNC.Location = New System.Drawing.Point(10, 107)
        Me.btnConsVtaNC.Name = "btnConsVtaNC"
        Me.btnConsVtaNC.Size = New System.Drawing.Size(211, 35)
        Me.btnConsVtaNC.TabIndex = 4
        Me.btnConsVtaNC.Text = "Notas Credito"
        Me.btnConsVtaNC.UseVisualStyleBackColor = True
        Me.btnConsVtaNC.Visible = False
        '
        'btnConsVtaFacturas
        '
        Me.btnConsVtaFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsVtaFacturas, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsVtaFacturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsVtaFacturas.FlatAppearance.BorderSize = 0
        Me.btnConsVtaFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsVtaFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsVtaFacturas.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsVtaFacturas.ForeColor = System.Drawing.Color.White
        Me.btnConsVtaFacturas.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasFactura
        Me.btnConsVtaFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsVtaFacturas.Location = New System.Drawing.Point(10, 72)
        Me.btnConsVtaFacturas.Name = "btnConsVtaFacturas"
        Me.btnConsVtaFacturas.Size = New System.Drawing.Size(211, 35)
        Me.btnConsVtaFacturas.TabIndex = 3
        Me.btnConsVtaFacturas.Text = "Facturas"
        Me.btnConsVtaFacturas.UseVisualStyleBackColor = True
        Me.btnConsVtaFacturas.Visible = False
        '
        'btnConsVtaRemitos
        '
        Me.btnConsVtaRemitos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsVtaRemitos, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsVtaRemitos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsVtaRemitos.FlatAppearance.BorderSize = 0
        Me.btnConsVtaRemitos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsVtaRemitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsVtaRemitos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsVtaRemitos.ForeColor = System.Drawing.Color.White
        Me.btnConsVtaRemitos.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasRemito
        Me.btnConsVtaRemitos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsVtaRemitos.Location = New System.Drawing.Point(10, 37)
        Me.btnConsVtaRemitos.Name = "btnConsVtaRemitos"
        Me.btnConsVtaRemitos.Size = New System.Drawing.Size(211, 35)
        Me.btnConsVtaRemitos.TabIndex = 2
        Me.btnConsVtaRemitos.Text = "Remitos"
        Me.btnConsVtaRemitos.UseVisualStyleBackColor = True
        Me.btnConsVtaRemitos.Visible = False
        '
        'btnConsVtaPedidos
        '
        Me.btnConsVtaPedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsVtaPedidos, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsVtaPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsVtaPedidos.FlatAppearance.BorderSize = 0
        Me.btnConsVtaPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsVtaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsVtaPedidos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsVtaPedidos.ForeColor = System.Drawing.Color.White
        Me.btnConsVtaPedidos.Image = Global.Presentacion.My.Resources.Resources.IconoPedido
        Me.btnConsVtaPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsVtaPedidos.Location = New System.Drawing.Point(10, 2)
        Me.btnConsVtaPedidos.Name = "btnConsVtaPedidos"
        Me.btnConsVtaPedidos.Size = New System.Drawing.Size(211, 35)
        Me.btnConsVtaPedidos.TabIndex = 13
        Me.btnConsVtaPedidos.Text = "Pedidos"
        Me.btnConsVtaPedidos.UseVisualStyleBackColor = True
        Me.btnConsVtaPedidos.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel9, BunifuAnimatorNS.DecorationType.None)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(10, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(211, 2)
        Me.Panel9.TabIndex = 14
        '
        'Panel56
        '
        Me.Panel56.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel56, BunifuAnimatorNS.DecorationType.None)
        Me.Panel56.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel56.Location = New System.Drawing.Point(0, 0)
        Me.Panel56.Name = "Panel56"
        Me.Panel56.Size = New System.Drawing.Size(10, 214)
        Me.Panel56.TabIndex = 12
        '
        'btnConsVentas
        '
        Me.btnConsVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsVentas, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsVentas.FlatAppearance.BorderSize = 0
        Me.btnConsVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsVentas.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsVentas.ForeColor = System.Drawing.Color.White
        Me.btnConsVentas.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasVentas
        Me.btnConsVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsVentas.Location = New System.Drawing.Point(10, 356)
        Me.btnConsVentas.Name = "btnConsVentas"
        Me.btnConsVentas.Size = New System.Drawing.Size(221, 35)
        Me.btnConsVentas.TabIndex = 15
        Me.btnConsVentas.Text = "Ventas"
        Me.btnConsVentas.UseVisualStyleBackColor = True
        '
        'pnlConsCompras
        '
        Me.pnlConsCompras.AutoSize = True
        Me.pnlConsCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlConsCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlConsCompras.Controls.Add(Me.Panel31)
        Me.pnlConsCompras.Controls.Add(Me.btnConsComCuentaCorriente)
        Me.pnlConsCompras.Controls.Add(Me.btnConsComNotasDebito)
        Me.pnlConsCompras.Controls.Add(Me.btnConsComNotasCredito)
        Me.pnlConsCompras.Controls.Add(Me.btnConsComFacturas)
        Me.pnlConsCompras.Controls.Add(Me.btnConsComRemito)
        Me.pnlConsCompras.Controls.Add(Me.Panel7)
        Me.pnlConsCompras.Controls.Add(Me.Panel67)
        Me.bnfTransicion.SetDecoration(Me.pnlConsCompras, BunifuAnimatorNS.DecorationType.None)
        Me.pnlConsCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConsCompras.Location = New System.Drawing.Point(10, 177)
        Me.pnlConsCompras.Name = "pnlConsCompras"
        Me.pnlConsCompras.Size = New System.Drawing.Size(221, 179)
        Me.pnlConsCompras.TabIndex = 24
        Me.pnlConsCompras.Visible = False
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel31, BunifuAnimatorNS.DecorationType.None)
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(10, 177)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(211, 2)
        Me.Panel31.TabIndex = 9
        '
        'btnConsComCuentaCorriente
        '
        Me.btnConsComCuentaCorriente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsComCuentaCorriente, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsComCuentaCorriente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsComCuentaCorriente.FlatAppearance.BorderSize = 0
        Me.btnConsComCuentaCorriente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsComCuentaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsComCuentaCorriente.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsComCuentaCorriente.ForeColor = System.Drawing.Color.White
        Me.btnConsComCuentaCorriente.Image = Global.Presentacion.My.Resources.Resources.IconoCuentaCorriente2
        Me.btnConsComCuentaCorriente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsComCuentaCorriente.Location = New System.Drawing.Point(10, 142)
        Me.btnConsComCuentaCorriente.Name = "btnConsComCuentaCorriente"
        Me.btnConsComCuentaCorriente.Size = New System.Drawing.Size(211, 35)
        Me.btnConsComCuentaCorriente.TabIndex = 10
        Me.btnConsComCuentaCorriente.Text = "   Cuentas Corrientes"
        Me.btnConsComCuentaCorriente.UseVisualStyleBackColor = True
        '
        'btnConsComNotasDebito
        '
        Me.btnConsComNotasDebito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsComNotasDebito, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsComNotasDebito.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsComNotasDebito.FlatAppearance.BorderSize = 0
        Me.btnConsComNotasDebito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsComNotasDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsComNotasDebito.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsComNotasDebito.ForeColor = System.Drawing.Color.White
        Me.btnConsComNotasDebito.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasNota
        Me.btnConsComNotasDebito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsComNotasDebito.Location = New System.Drawing.Point(10, 107)
        Me.btnConsComNotasDebito.Name = "btnConsComNotasDebito"
        Me.btnConsComNotasDebito.Size = New System.Drawing.Size(211, 35)
        Me.btnConsComNotasDebito.TabIndex = 5
        Me.btnConsComNotasDebito.Text = "Notas Debito"
        Me.btnConsComNotasDebito.UseVisualStyleBackColor = True
        Me.btnConsComNotasDebito.Visible = False
        '
        'btnConsComNotasCredito
        '
        Me.btnConsComNotasCredito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsComNotasCredito, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsComNotasCredito.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsComNotasCredito.FlatAppearance.BorderSize = 0
        Me.btnConsComNotasCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsComNotasCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsComNotasCredito.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsComNotasCredito.ForeColor = System.Drawing.Color.White
        Me.btnConsComNotasCredito.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasNota
        Me.btnConsComNotasCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsComNotasCredito.Location = New System.Drawing.Point(10, 72)
        Me.btnConsComNotasCredito.Name = "btnConsComNotasCredito"
        Me.btnConsComNotasCredito.Size = New System.Drawing.Size(211, 35)
        Me.btnConsComNotasCredito.TabIndex = 4
        Me.btnConsComNotasCredito.Text = "Notas Credito"
        Me.btnConsComNotasCredito.UseVisualStyleBackColor = True
        Me.btnConsComNotasCredito.Visible = False
        '
        'btnConsComFacturas
        '
        Me.btnConsComFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsComFacturas, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsComFacturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsComFacturas.FlatAppearance.BorderSize = 0
        Me.btnConsComFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsComFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsComFacturas.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsComFacturas.ForeColor = System.Drawing.Color.White
        Me.btnConsComFacturas.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasFactura
        Me.btnConsComFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsComFacturas.Location = New System.Drawing.Point(10, 37)
        Me.btnConsComFacturas.Name = "btnConsComFacturas"
        Me.btnConsComFacturas.Size = New System.Drawing.Size(211, 35)
        Me.btnConsComFacturas.TabIndex = 3
        Me.btnConsComFacturas.Text = "Facturas"
        Me.btnConsComFacturas.UseVisualStyleBackColor = True
        Me.btnConsComFacturas.Visible = False
        '
        'btnConsComRemito
        '
        Me.btnConsComRemito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsComRemito, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsComRemito.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsComRemito.FlatAppearance.BorderSize = 0
        Me.btnConsComRemito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConsComRemito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsComRemito.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsComRemito.ForeColor = System.Drawing.Color.White
        Me.btnConsComRemito.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasRemito
        Me.btnConsComRemito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsComRemito.Location = New System.Drawing.Point(10, 2)
        Me.btnConsComRemito.Name = "btnConsComRemito"
        Me.btnConsComRemito.Size = New System.Drawing.Size(211, 35)
        Me.btnConsComRemito.TabIndex = 2
        Me.btnConsComRemito.Text = "Remitos"
        Me.btnConsComRemito.UseVisualStyleBackColor = True
        Me.btnConsComRemito.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(10, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(211, 2)
        Me.Panel7.TabIndex = 6
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel67, BunifuAnimatorNS.DecorationType.None)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(10, 179)
        Me.Panel67.TabIndex = 0
        '
        'btnConsCompras
        '
        Me.btnConsCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsCompras, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsCompras.FlatAppearance.BorderSize = 0
        Me.btnConsCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsCompras.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsCompras.ForeColor = System.Drawing.Color.White
        Me.btnConsCompras.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasCompras
        Me.btnConsCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsCompras.Location = New System.Drawing.Point(10, 142)
        Me.btnConsCompras.Name = "btnConsCompras"
        Me.btnConsCompras.Size = New System.Drawing.Size(221, 35)
        Me.btnConsCompras.TabIndex = 13
        Me.btnConsCompras.Text = "Compras"
        Me.btnConsCompras.UseVisualStyleBackColor = True
        '
        'btnConsArticulos
        '
        Me.btnConsArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsArticulos, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsArticulos.FlatAppearance.BorderSize = 0
        Me.btnConsArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsArticulos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsArticulos.ForeColor = System.Drawing.Color.White
        Me.btnConsArticulos.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasArticulos
        Me.btnConsArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsArticulos.Location = New System.Drawing.Point(10, 107)
        Me.btnConsArticulos.Name = "btnConsArticulos"
        Me.btnConsArticulos.Size = New System.Drawing.Size(221, 35)
        Me.btnConsArticulos.TabIndex = 5
        Me.btnConsArticulos.Text = "Articulos"
        Me.btnConsArticulos.UseVisualStyleBackColor = True
        Me.btnConsArticulos.Visible = False
        '
        'btnConsProv
        '
        Me.btnConsProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsProv, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsProv.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsProv.FlatAppearance.BorderSize = 0
        Me.btnConsProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsProv.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsProv.ForeColor = System.Drawing.Color.White
        Me.btnConsProv.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasProveedores
        Me.btnConsProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsProv.Location = New System.Drawing.Point(10, 72)
        Me.btnConsProv.Name = "btnConsProv"
        Me.btnConsProv.Size = New System.Drawing.Size(221, 35)
        Me.btnConsProv.TabIndex = 4
        Me.btnConsProv.Text = "Proveedores"
        Me.btnConsProv.UseVisualStyleBackColor = True
        Me.btnConsProv.Visible = False
        '
        'btnConsClientes
        '
        Me.btnConsClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsClientes, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsClientes.FlatAppearance.BorderSize = 0
        Me.btnConsClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsClientes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsClientes.ForeColor = System.Drawing.Color.White
        Me.btnConsClientes.Image = Global.Presentacion.My.Resources.Resources.IconoConsultasClientes
        Me.btnConsClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsClientes.Location = New System.Drawing.Point(10, 37)
        Me.btnConsClientes.Name = "btnConsClientes"
        Me.btnConsClientes.Size = New System.Drawing.Size(221, 35)
        Me.btnConsClientes.TabIndex = 3
        Me.btnConsClientes.Text = "Clientes"
        Me.btnConsClientes.UseVisualStyleBackColor = True
        Me.btnConsClientes.Visible = False
        '
        'btnConsUsuarios
        '
        Me.btnConsUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsUsuarios, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsUsuarios.FlatAppearance.BorderSize = 0
        Me.btnConsUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnConsUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsUsuarios.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnConsUsuarios.Image = Global.Presentacion.My.Resources.Resources.IconoConsultaUsuario1
        Me.btnConsUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsUsuarios.Location = New System.Drawing.Point(10, 2)
        Me.btnConsUsuarios.Name = "btnConsUsuarios"
        Me.btnConsUsuarios.Size = New System.Drawing.Size(221, 35)
        Me.btnConsUsuarios.TabIndex = 2
        Me.btnConsUsuarios.Text = "Usuarios"
        Me.btnConsUsuarios.UseVisualStyleBackColor = True
        Me.btnConsUsuarios.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(10, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(221, 2)
        Me.Panel6.TabIndex = 22
        '
        'Panel50
        '
        Me.Panel50.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel50, BunifuAnimatorNS.DecorationType.None)
        Me.Panel50.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel50.Location = New System.Drawing.Point(0, 0)
        Me.Panel50.Name = "Panel50"
        Me.Panel50.Size = New System.Drawing.Size(10, 965)
        Me.Panel50.TabIndex = 0
        '
        'btnConsultas
        '
        Me.btnConsultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnConsultas, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsultas.FlatAppearance.BorderSize = 0
        Me.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultas.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.ForeColor = System.Drawing.Color.White
        Me.btnConsultas.Image = Global.Presentacion.My.Resources.Resources.IconoConsultas
        Me.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultas.Location = New System.Drawing.Point(0, 1537)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(231, 35)
        Me.btnConsultas.TabIndex = 40
        Me.btnConsultas.Text = "Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = False
        '
        'pnlStock
        '
        Me.pnlStock.AutoSize = True
        Me.pnlStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlStock.Controls.Add(Me.Panel24)
        Me.pnlStock.Controls.Add(Me.btnTransferenciasStock)
        Me.pnlStock.Controls.Add(Me.btnMantenimientoStock)
        Me.pnlStock.Controls.Add(Me.Panel12)
        Me.pnlStock.Controls.Add(Me.Panel61)
        Me.bnfTransicion.SetDecoration(Me.pnlStock, BunifuAnimatorNS.DecorationType.None)
        Me.pnlStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStock.Location = New System.Drawing.Point(0, 1463)
        Me.pnlStock.Name = "pnlStock"
        Me.pnlStock.Size = New System.Drawing.Size(231, 74)
        Me.pnlStock.TabIndex = 21
        Me.pnlStock.Visible = False
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel24, BunifuAnimatorNS.DecorationType.None)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(10, 72)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(221, 2)
        Me.Panel24.TabIndex = 16
        '
        'btnTransferenciasStock
        '
        Me.btnTransferenciasStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnTransferenciasStock, BunifuAnimatorNS.DecorationType.None)
        Me.btnTransferenciasStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransferenciasStock.FlatAppearance.BorderSize = 0
        Me.btnTransferenciasStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnTransferenciasStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransferenciasStock.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferenciasStock.ForeColor = System.Drawing.Color.White
        Me.btnTransferenciasStock.Image = Global.Presentacion.My.Resources.Resources.IconoStockTransferencias
        Me.btnTransferenciasStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferenciasStock.Location = New System.Drawing.Point(10, 37)
        Me.btnTransferenciasStock.Name = "btnTransferenciasStock"
        Me.btnTransferenciasStock.Size = New System.Drawing.Size(221, 35)
        Me.btnTransferenciasStock.TabIndex = 3
        Me.btnTransferenciasStock.Text = "Transferencias"
        Me.btnTransferenciasStock.UseVisualStyleBackColor = True
        '
        'btnMantenimientoStock
        '
        Me.btnMantenimientoStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnMantenimientoStock, BunifuAnimatorNS.DecorationType.None)
        Me.btnMantenimientoStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMantenimientoStock.FlatAppearance.BorderSize = 0
        Me.btnMantenimientoStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnMantenimientoStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMantenimientoStock.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimientoStock.ForeColor = System.Drawing.Color.White
        Me.btnMantenimientoStock.Image = Global.Presentacion.My.Resources.Resources.IconoStockMantenimiento
        Me.btnMantenimientoStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMantenimientoStock.Location = New System.Drawing.Point(10, 2)
        Me.btnMantenimientoStock.Name = "btnMantenimientoStock"
        Me.btnMantenimientoStock.Size = New System.Drawing.Size(221, 35)
        Me.btnMantenimientoStock.TabIndex = 2
        Me.btnMantenimientoStock.Text = "Mantenimiento"
        Me.btnMantenimientoStock.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel12, BunifuAnimatorNS.DecorationType.None)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(10, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(221, 2)
        Me.Panel12.TabIndex = 15
        '
        'Panel61
        '
        Me.Panel61.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel61, BunifuAnimatorNS.DecorationType.None)
        Me.Panel61.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel61.Location = New System.Drawing.Point(0, 0)
        Me.Panel61.Name = "Panel61"
        Me.Panel61.Size = New System.Drawing.Size(10, 74)
        Me.Panel61.TabIndex = 0
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnStock, BunifuAnimatorNS.DecorationType.None)
        Me.btnStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.Color.White
        Me.btnStock.Image = Global.Presentacion.My.Resources.Resources.IconoStock
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.Location = New System.Drawing.Point(0, 1428)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(231, 35)
        Me.btnStock.TabIndex = 39
        Me.btnStock.Text = "Stock"
        Me.btnStock.UseVisualStyleBackColor = False
        Me.btnStock.Visible = False
        '
        'pnlGestion
        '
        Me.pnlGestion.AutoSize = True
        Me.pnlGestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlGestion.Controls.Add(Me.Panel23)
        Me.pnlGestion.Controls.Add(Me.pnlBancos)
        Me.pnlGestion.Controls.Add(Me.btnBanco)
        Me.pnlGestion.Controls.Add(Me.btnCaja)
        Me.pnlGestion.Controls.Add(Me.pnlCanjes)
        Me.pnlGestion.Controls.Add(Me.btnCanjes)
        Me.pnlGestion.Controls.Add(Me.pnlVentas)
        Me.pnlGestion.Controls.Add(Me.btnVentas)
        Me.pnlGestion.Controls.Add(Me.pnlCompras)
        Me.pnlGestion.Controls.Add(Me.btnCompras)
        Me.pnlGestion.Controls.Add(Me.Panel3)
        Me.pnlGestion.Controls.Add(Me.Panel26)
        Me.bnfTransicion.SetDecoration(Me.pnlGestion, BunifuAnimatorNS.DecorationType.None)
        Me.pnlGestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGestion.Location = New System.Drawing.Point(0, 603)
        Me.pnlGestion.Name = "pnlGestion"
        Me.pnlGestion.Size = New System.Drawing.Size(231, 825)
        Me.pnlGestion.TabIndex = 20
        Me.pnlGestion.Visible = False
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel23, BunifuAnimatorNS.DecorationType.None)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(10, 823)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(221, 2)
        Me.Panel23.TabIndex = 26
        '
        'pnlBancos
        '
        Me.pnlBancos.AutoSize = True
        Me.pnlBancos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlBancos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlBancos.Controls.Add(Me.Panel32)
        Me.pnlBancos.Controls.Add(Me.btnBcoRetiros)
        Me.pnlBancos.Controls.Add(Me.btnBcoDepositos)
        Me.pnlBancos.Controls.Add(Me.Panel18)
        Me.pnlBancos.Controls.Add(Me.Panel47)
        Me.bnfTransicion.SetDecoration(Me.pnlBancos, BunifuAnimatorNS.DecorationType.None)
        Me.pnlBancos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBancos.Location = New System.Drawing.Point(10, 749)
        Me.pnlBancos.Name = "pnlBancos"
        Me.pnlBancos.Size = New System.Drawing.Size(221, 74)
        Me.pnlBancos.TabIndex = 25
        Me.pnlBancos.Visible = False
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel32, BunifuAnimatorNS.DecorationType.None)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel32.Location = New System.Drawing.Point(10, 72)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(211, 2)
        Me.Panel32.TabIndex = 9
        '
        'btnBcoRetiros
        '
        Me.btnBcoRetiros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnBcoRetiros, BunifuAnimatorNS.DecorationType.None)
        Me.btnBcoRetiros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBcoRetiros.FlatAppearance.BorderSize = 0
        Me.btnBcoRetiros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnBcoRetiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBcoRetiros.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBcoRetiros.ForeColor = System.Drawing.Color.White
        Me.btnBcoRetiros.Image = Global.Presentacion.My.Resources.Resources.IconoRetiro
        Me.btnBcoRetiros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBcoRetiros.Location = New System.Drawing.Point(10, 37)
        Me.btnBcoRetiros.Name = "btnBcoRetiros"
        Me.btnBcoRetiros.Size = New System.Drawing.Size(211, 35)
        Me.btnBcoRetiros.TabIndex = 3
        Me.btnBcoRetiros.Text = "Retiros"
        Me.btnBcoRetiros.UseVisualStyleBackColor = True
        '
        'btnBcoDepositos
        '
        Me.btnBcoDepositos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnBcoDepositos, BunifuAnimatorNS.DecorationType.None)
        Me.btnBcoDepositos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBcoDepositos.FlatAppearance.BorderSize = 0
        Me.btnBcoDepositos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnBcoDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBcoDepositos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBcoDepositos.ForeColor = System.Drawing.Color.White
        Me.btnBcoDepositos.Image = Global.Presentacion.My.Resources.Resources.IconoDepositoBancario
        Me.btnBcoDepositos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBcoDepositos.Location = New System.Drawing.Point(10, 2)
        Me.btnBcoDepositos.Name = "btnBcoDepositos"
        Me.btnBcoDepositos.Size = New System.Drawing.Size(211, 35)
        Me.btnBcoDepositos.TabIndex = 2
        Me.btnBcoDepositos.Text = "Depósitos"
        Me.btnBcoDepositos.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel18, BunifuAnimatorNS.DecorationType.None)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(10, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(211, 2)
        Me.Panel18.TabIndex = 8
        '
        'Panel47
        '
        Me.Panel47.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel47, BunifuAnimatorNS.DecorationType.None)
        Me.Panel47.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel47.Location = New System.Drawing.Point(0, 0)
        Me.Panel47.Name = "Panel47"
        Me.Panel47.Size = New System.Drawing.Size(10, 74)
        Me.Panel47.TabIndex = 0
        '
        'btnBanco
        '
        Me.btnBanco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnBanco, BunifuAnimatorNS.DecorationType.None)
        Me.btnBanco.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBanco.FlatAppearance.BorderSize = 0
        Me.btnBanco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBanco.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBanco.ForeColor = System.Drawing.Color.White
        Me.btnBanco.Image = Global.Presentacion.My.Resources.Resources.IconoBancos
        Me.btnBanco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBanco.Location = New System.Drawing.Point(10, 714)
        Me.btnBanco.Name = "btnBanco"
        Me.btnBanco.Size = New System.Drawing.Size(221, 35)
        Me.btnBanco.TabIndex = 13
        Me.btnBanco.Text = "Bancos"
        Me.btnBanco.UseVisualStyleBackColor = True
        Me.btnBanco.Visible = False
        '
        'btnCaja
        '
        Me.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnCaja, BunifuAnimatorNS.DecorationType.None)
        Me.btnCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCaja.FlatAppearance.BorderSize = 0
        Me.btnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaja.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaja.ForeColor = System.Drawing.Color.White
        Me.btnCaja.Image = Global.Presentacion.My.Resources.Resources.IconoCaja
        Me.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCaja.Location = New System.Drawing.Point(10, 679)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(221, 35)
        Me.btnCaja.TabIndex = 5
        Me.btnCaja.Text = "Caja"
        Me.btnCaja.UseVisualStyleBackColor = True
        '
        'pnlCanjes
        '
        Me.pnlCanjes.AutoSize = True
        Me.pnlCanjes.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlCanjes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlCanjes.Controls.Add(Me.Panel34)
        Me.pnlCanjes.Controls.Add(Me.btnLiquidaciones)
        Me.pnlCanjes.Controls.Add(Me.btnCartasPorte)
        Me.pnlCanjes.Controls.Add(Me.btnFijacionContratos)
        Me.pnlCanjes.Controls.Add(Me.btnEmisionContratos)
        Me.pnlCanjes.Controls.Add(Me.Panel8)
        Me.pnlCanjes.Controls.Add(Me.Panel43)
        Me.bnfTransicion.SetDecoration(Me.pnlCanjes, BunifuAnimatorNS.DecorationType.None)
        Me.pnlCanjes.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCanjes.Location = New System.Drawing.Point(10, 535)
        Me.pnlCanjes.Name = "pnlCanjes"
        Me.pnlCanjes.Size = New System.Drawing.Size(221, 144)
        Me.pnlCanjes.TabIndex = 23
        Me.pnlCanjes.Visible = False
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel34, BunifuAnimatorNS.DecorationType.None)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel34.Location = New System.Drawing.Point(10, 142)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(211, 2)
        Me.Panel34.TabIndex = 9
        '
        'btnLiquidaciones
        '
        Me.btnLiquidaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnLiquidaciones, BunifuAnimatorNS.DecorationType.None)
        Me.btnLiquidaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLiquidaciones.FlatAppearance.BorderSize = 0
        Me.btnLiquidaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLiquidaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiquidaciones.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiquidaciones.ForeColor = System.Drawing.Color.White
        Me.btnLiquidaciones.Image = Global.Presentacion.My.Resources.Resources.IconoLiquidaciones
        Me.btnLiquidaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLiquidaciones.Location = New System.Drawing.Point(10, 107)
        Me.btnLiquidaciones.Name = "btnLiquidaciones"
        Me.btnLiquidaciones.Size = New System.Drawing.Size(211, 35)
        Me.btnLiquidaciones.TabIndex = 5
        Me.btnLiquidaciones.Text = "Liquidaciones"
        Me.btnLiquidaciones.UseVisualStyleBackColor = True
        '
        'btnCartasPorte
        '
        Me.btnCartasPorte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnCartasPorte, BunifuAnimatorNS.DecorationType.None)
        Me.btnCartasPorte.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCartasPorte.FlatAppearance.BorderSize = 0
        Me.btnCartasPorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCartasPorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCartasPorte.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCartasPorte.ForeColor = System.Drawing.Color.White
        Me.btnCartasPorte.Image = Global.Presentacion.My.Resources.Resources.IconoCartaPorte
        Me.btnCartasPorte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCartasPorte.Location = New System.Drawing.Point(10, 72)
        Me.btnCartasPorte.Name = "btnCartasPorte"
        Me.btnCartasPorte.Size = New System.Drawing.Size(211, 35)
        Me.btnCartasPorte.TabIndex = 4
        Me.btnCartasPorte.Text = "Carta Porte"
        Me.btnCartasPorte.UseVisualStyleBackColor = True
        '
        'btnFijacionContratos
        '
        Me.btnFijacionContratos.AccessibleName = "c"
        Me.btnFijacionContratos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnFijacionContratos, BunifuAnimatorNS.DecorationType.None)
        Me.btnFijacionContratos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFijacionContratos.FlatAppearance.BorderSize = 0
        Me.btnFijacionContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnFijacionContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFijacionContratos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFijacionContratos.ForeColor = System.Drawing.Color.White
        Me.btnFijacionContratos.Image = Global.Presentacion.My.Resources.Resources.IconoFijarContrato
        Me.btnFijacionContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFijacionContratos.Location = New System.Drawing.Point(10, 37)
        Me.btnFijacionContratos.Name = "btnFijacionContratos"
        Me.btnFijacionContratos.Size = New System.Drawing.Size(211, 35)
        Me.btnFijacionContratos.TabIndex = 3
        Me.btnFijacionContratos.Text = "Fijar Contratos"
        Me.btnFijacionContratos.UseVisualStyleBackColor = True
        '
        'btnEmisionContratos
        '
        Me.btnEmisionContratos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnEmisionContratos, BunifuAnimatorNS.DecorationType.None)
        Me.btnEmisionContratos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmisionContratos.FlatAppearance.BorderSize = 0
        Me.btnEmisionContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEmisionContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmisionContratos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmisionContratos.ForeColor = System.Drawing.Color.White
        Me.btnEmisionContratos.Image = Global.Presentacion.My.Resources.Resources.IconoContrato
        Me.btnEmisionContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmisionContratos.Location = New System.Drawing.Point(10, 2)
        Me.btnEmisionContratos.Name = "btnEmisionContratos"
        Me.btnEmisionContratos.Size = New System.Drawing.Size(211, 35)
        Me.btnEmisionContratos.TabIndex = 2
        Me.btnEmisionContratos.Text = "Emitir Contratos"
        Me.btnEmisionContratos.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel8, BunifuAnimatorNS.DecorationType.None)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(10, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(211, 2)
        Me.Panel8.TabIndex = 7
        '
        'Panel43
        '
        Me.Panel43.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel43, BunifuAnimatorNS.DecorationType.None)
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel43.Location = New System.Drawing.Point(0, 0)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(10, 144)
        Me.Panel43.TabIndex = 0
        '
        'btnCanjes
        '
        Me.btnCanjes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnCanjes, BunifuAnimatorNS.DecorationType.None)
        Me.btnCanjes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCanjes.FlatAppearance.BorderSize = 0
        Me.btnCanjes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCanjes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanjes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanjes.ForeColor = System.Drawing.Color.White
        Me.btnCanjes.Image = Global.Presentacion.My.Resources.Resources.IconoCanjes
        Me.btnCanjes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCanjes.Location = New System.Drawing.Point(10, 500)
        Me.btnCanjes.Name = "btnCanjes"
        Me.btnCanjes.Size = New System.Drawing.Size(221, 35)
        Me.btnCanjes.TabIndex = 4
        Me.btnCanjes.Text = "Canjes"
        Me.btnCanjes.UseVisualStyleBackColor = True
        Me.btnCanjes.Visible = False
        '
        'pnlVentas
        '
        Me.pnlVentas.AutoSize = True
        Me.pnlVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlVentas.Controls.Add(Me.Panel35)
        Me.pnlVentas.Controls.Add(Me.btnDevolucionesVta)
        Me.pnlVentas.Controls.Add(Me.btnRecVta)
        Me.pnlVentas.Controls.Add(Me.btnNDVta)
        Me.pnlVentas.Controls.Add(Me.btnNCVta)
        Me.pnlVentas.Controls.Add(Me.btnFacVta)
        Me.pnlVentas.Controls.Add(Me.btnRemVta)
        Me.pnlVentas.Controls.Add(Me.btnPedidos)
        Me.pnlVentas.Controls.Add(Me.Panel16)
        Me.pnlVentas.Controls.Add(Me.Panel36)
        Me.bnfTransicion.SetDecoration(Me.pnlVentas, BunifuAnimatorNS.DecorationType.None)
        Me.pnlVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVentas.Location = New System.Drawing.Point(10, 251)
        Me.pnlVentas.Name = "pnlVentas"
        Me.pnlVentas.Size = New System.Drawing.Size(221, 249)
        Me.pnlVentas.TabIndex = 22
        Me.pnlVentas.Visible = False
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel35, BunifuAnimatorNS.DecorationType.None)
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel35.Location = New System.Drawing.Point(10, 247)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(211, 2)
        Me.Panel35.TabIndex = 28
        '
        'btnDevolucionesVta
        '
        Me.btnDevolucionesVta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnDevolucionesVta, BunifuAnimatorNS.DecorationType.None)
        Me.btnDevolucionesVta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDevolucionesVta.FlatAppearance.BorderSize = 0
        Me.btnDevolucionesVta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDevolucionesVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevolucionesVta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevolucionesVta.ForeColor = System.Drawing.Color.White
        Me.btnDevolucionesVta.Image = Global.Presentacion.My.Resources.Resources.IconoDevoluciones
        Me.btnDevolucionesVta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDevolucionesVta.Location = New System.Drawing.Point(10, 212)
        Me.btnDevolucionesVta.Name = "btnDevolucionesVta"
        Me.btnDevolucionesVta.Size = New System.Drawing.Size(211, 35)
        Me.btnDevolucionesVta.TabIndex = 29
        Me.btnDevolucionesVta.Text = "Devoluciones"
        Me.btnDevolucionesVta.UseVisualStyleBackColor = True
        '
        'btnRecVta
        '
        Me.btnRecVta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnRecVta, BunifuAnimatorNS.DecorationType.None)
        Me.btnRecVta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecVta.FlatAppearance.BorderSize = 0
        Me.btnRecVta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRecVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecVta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecVta.ForeColor = System.Drawing.Color.White
        Me.btnRecVta.Image = Global.Presentacion.My.Resources.Resources.IconoOrdenPago
        Me.btnRecVta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecVta.Location = New System.Drawing.Point(10, 177)
        Me.btnRecVta.Name = "btnRecVta"
        Me.btnRecVta.Size = New System.Drawing.Size(211, 35)
        Me.btnRecVta.TabIndex = 15
        Me.btnRecVta.Text = "Recibos"
        Me.btnRecVta.UseVisualStyleBackColor = True
        '
        'btnNDVta
        '
        Me.btnNDVta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnNDVta, BunifuAnimatorNS.DecorationType.None)
        Me.btnNDVta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNDVta.FlatAppearance.BorderSize = 0
        Me.btnNDVta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnNDVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNDVta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNDVta.ForeColor = System.Drawing.Color.White
        Me.btnNDVta.Image = Global.Presentacion.My.Resources.Resources.IconoNota
        Me.btnNDVta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNDVta.Location = New System.Drawing.Point(10, 142)
        Me.btnNDVta.Name = "btnNDVta"
        Me.btnNDVta.Size = New System.Drawing.Size(211, 35)
        Me.btnNDVta.TabIndex = 13
        Me.btnNDVta.Text = "    Notas De Débito"
        Me.btnNDVta.UseVisualStyleBackColor = True
        Me.btnNDVta.Visible = False
        '
        'btnNCVta
        '
        Me.btnNCVta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnNCVta, BunifuAnimatorNS.DecorationType.None)
        Me.btnNCVta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNCVta.FlatAppearance.BorderSize = 0
        Me.btnNCVta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnNCVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNCVta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNCVta.ForeColor = System.Drawing.Color.White
        Me.btnNCVta.Image = Global.Presentacion.My.Resources.Resources.IconoNota
        Me.btnNCVta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNCVta.Location = New System.Drawing.Point(10, 107)
        Me.btnNCVta.Name = "btnNCVta"
        Me.btnNCVta.Size = New System.Drawing.Size(211, 35)
        Me.btnNCVta.TabIndex = 5
        Me.btnNCVta.Text = "    Notas De Crédito"
        Me.btnNCVta.UseVisualStyleBackColor = True
        Me.btnNCVta.Visible = False
        '
        'btnFacVta
        '
        Me.btnFacVta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnFacVta, BunifuAnimatorNS.DecorationType.None)
        Me.btnFacVta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFacVta.FlatAppearance.BorderSize = 0
        Me.btnFacVta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnFacVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacVta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacVta.ForeColor = System.Drawing.Color.White
        Me.btnFacVta.Image = Global.Presentacion.My.Resources.Resources.IconoFactura
        Me.btnFacVta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacVta.Location = New System.Drawing.Point(10, 72)
        Me.btnFacVta.Name = "btnFacVta"
        Me.btnFacVta.Size = New System.Drawing.Size(211, 35)
        Me.btnFacVta.TabIndex = 4
        Me.btnFacVta.Text = "Facturas"
        Me.btnFacVta.UseVisualStyleBackColor = True
        '
        'btnRemVta
        '
        Me.btnRemVta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnRemVta, BunifuAnimatorNS.DecorationType.None)
        Me.btnRemVta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemVta.FlatAppearance.BorderSize = 0
        Me.btnRemVta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRemVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemVta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemVta.ForeColor = System.Drawing.Color.White
        Me.btnRemVta.Image = Global.Presentacion.My.Resources.Resources.IconoRemito
        Me.btnRemVta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemVta.Location = New System.Drawing.Point(10, 37)
        Me.btnRemVta.Name = "btnRemVta"
        Me.btnRemVta.Size = New System.Drawing.Size(211, 35)
        Me.btnRemVta.TabIndex = 3
        Me.btnRemVta.Text = "Remitos"
        Me.btnRemVta.UseVisualStyleBackColor = True
        '
        'btnPedidos
        '
        Me.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnPedidos, BunifuAnimatorNS.DecorationType.None)
        Me.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPedidos.FlatAppearance.BorderSize = 0
        Me.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedidos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedidos.ForeColor = System.Drawing.Color.White
        Me.btnPedidos.Image = Global.Presentacion.My.Resources.Resources.IconoPedido
        Me.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPedidos.Location = New System.Drawing.Point(10, 2)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(211, 35)
        Me.btnPedidos.TabIndex = 2
        Me.btnPedidos.Text = "Reservas"
        Me.btnPedidos.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel16, BunifuAnimatorNS.DecorationType.None)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(10, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(211, 2)
        Me.Panel16.TabIndex = 16
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel36, BunifuAnimatorNS.DecorationType.None)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel36.Location = New System.Drawing.Point(0, 0)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(10, 249)
        Me.Panel36.TabIndex = 0
        '
        'btnVentas
        '
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnVentas, BunifuAnimatorNS.DecorationType.None)
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Image = Global.Presentacion.My.Resources.Resources.IconoVentas
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(10, 216)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(221, 35)
        Me.btnVentas.TabIndex = 3
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'pnlCompras
        '
        Me.pnlCompras.AutoSize = True
        Me.pnlCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlCompras.Controls.Add(Me.Panel37)
        Me.pnlCompras.Controls.Add(Me.btnOrdPago)
        Me.pnlCompras.Controls.Add(Me.btnNDCom)
        Me.pnlCompras.Controls.Add(Me.btnNCCom)
        Me.pnlCompras.Controls.Add(Me.btnFacCom)
        Me.pnlCompras.Controls.Add(Me.btnRemCom)
        Me.pnlCompras.Controls.Add(Me.Panel4)
        Me.pnlCompras.Controls.Add(Me.Panel22)
        Me.bnfTransicion.SetDecoration(Me.pnlCompras, BunifuAnimatorNS.DecorationType.None)
        Me.pnlCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCompras.Location = New System.Drawing.Point(10, 37)
        Me.pnlCompras.Name = "pnlCompras"
        Me.pnlCompras.Size = New System.Drawing.Size(221, 179)
        Me.pnlCompras.TabIndex = 21
        Me.pnlCompras.Visible = False
        '
        'Panel37
        '
        Me.Panel37.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel37, BunifuAnimatorNS.DecorationType.None)
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel37.Location = New System.Drawing.Point(10, 177)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(211, 2)
        Me.Panel37.TabIndex = 15
        '
        'btnOrdPago
        '
        Me.btnOrdPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnOrdPago, BunifuAnimatorNS.DecorationType.None)
        Me.btnOrdPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrdPago.FlatAppearance.BorderSize = 0
        Me.btnOrdPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnOrdPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdPago.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdPago.ForeColor = System.Drawing.Color.White
        Me.btnOrdPago.Image = Global.Presentacion.My.Resources.Resources.IconoOrdenPago
        Me.btnOrdPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdPago.Location = New System.Drawing.Point(10, 142)
        Me.btnOrdPago.Name = "btnOrdPago"
        Me.btnOrdPago.Size = New System.Drawing.Size(211, 35)
        Me.btnOrdPago.TabIndex = 13
        Me.btnOrdPago.Text = "  Orden De Pago"
        Me.btnOrdPago.UseVisualStyleBackColor = True
        '
        'btnNDCom
        '
        Me.btnNDCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnNDCom, BunifuAnimatorNS.DecorationType.None)
        Me.btnNDCom.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNDCom.FlatAppearance.BorderSize = 0
        Me.btnNDCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnNDCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNDCom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNDCom.ForeColor = System.Drawing.Color.White
        Me.btnNDCom.Image = Global.Presentacion.My.Resources.Resources.IconoNota
        Me.btnNDCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNDCom.Location = New System.Drawing.Point(10, 107)
        Me.btnNDCom.Name = "btnNDCom"
        Me.btnNDCom.Size = New System.Drawing.Size(211, 35)
        Me.btnNDCom.TabIndex = 5
        Me.btnNDCom.Text = "     Notas De Débito"
        Me.btnNDCom.UseVisualStyleBackColor = True
        Me.btnNDCom.Visible = False
        '
        'btnNCCom
        '
        Me.btnNCCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnNCCom, BunifuAnimatorNS.DecorationType.None)
        Me.btnNCCom.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNCCom.FlatAppearance.BorderSize = 0
        Me.btnNCCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnNCCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNCCom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNCCom.ForeColor = System.Drawing.Color.White
        Me.btnNCCom.Image = Global.Presentacion.My.Resources.Resources.IconoNota
        Me.btnNCCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNCCom.Location = New System.Drawing.Point(10, 72)
        Me.btnNCCom.Name = "btnNCCom"
        Me.btnNCCom.Size = New System.Drawing.Size(211, 35)
        Me.btnNCCom.TabIndex = 4
        Me.btnNCCom.Text = "     Notas De Crédito"
        Me.btnNCCom.UseVisualStyleBackColor = True
        Me.btnNCCom.Visible = False
        '
        'btnFacCom
        '
        Me.btnFacCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnFacCom, BunifuAnimatorNS.DecorationType.None)
        Me.btnFacCom.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFacCom.FlatAppearance.BorderSize = 0
        Me.btnFacCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnFacCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacCom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacCom.ForeColor = System.Drawing.Color.White
        Me.btnFacCom.Image = Global.Presentacion.My.Resources.Resources.IconoFactura
        Me.btnFacCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacCom.Location = New System.Drawing.Point(10, 37)
        Me.btnFacCom.Name = "btnFacCom"
        Me.btnFacCom.Size = New System.Drawing.Size(211, 35)
        Me.btnFacCom.TabIndex = 3
        Me.btnFacCom.Text = "  Facturas"
        Me.btnFacCom.UseVisualStyleBackColor = True
        '
        'btnRemCom
        '
        Me.btnRemCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnRemCom, BunifuAnimatorNS.DecorationType.None)
        Me.btnRemCom.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemCom.FlatAppearance.BorderSize = 0
        Me.btnRemCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRemCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemCom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemCom.ForeColor = System.Drawing.Color.White
        Me.btnRemCom.Image = Global.Presentacion.My.Resources.Resources.IconoRemito
        Me.btnRemCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemCom.Location = New System.Drawing.Point(10, 2)
        Me.btnRemCom.Name = "btnRemCom"
        Me.btnRemCom.Size = New System.Drawing.Size(211, 35)
        Me.btnRemCom.TabIndex = 2
        Me.btnRemCom.Text = "  Remitos"
        Me.btnRemCom.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(10, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(211, 2)
        Me.Panel4.TabIndex = 14
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel22, BunifuAnimatorNS.DecorationType.None)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(10, 179)
        Me.Panel22.TabIndex = 12
        '
        'btnCompras
        '
        Me.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnCompras, BunifuAnimatorNS.DecorationType.None)
        Me.btnCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.Color.White
        Me.btnCompras.Image = Global.Presentacion.My.Resources.Resources.IconoCompras
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(10, 2)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(221, 35)
        Me.btnCompras.TabIndex = 2
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(10, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(221, 2)
        Me.Panel3.TabIndex = 14
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel26, BunifuAnimatorNS.DecorationType.None)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(10, 825)
        Me.Panel26.TabIndex = 1
        '
        'btnGestion
        '
        Me.btnGestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnGestion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnGestion, BunifuAnimatorNS.DecorationType.None)
        Me.btnGestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGestion.FlatAppearance.BorderSize = 0
        Me.btnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestion.ForeColor = System.Drawing.Color.White
        Me.btnGestion.Image = Global.Presentacion.My.Resources.Resources.IconoGestion
        Me.btnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestion.Location = New System.Drawing.Point(0, 568)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Size = New System.Drawing.Size(231, 35)
        Me.btnGestion.TabIndex = 38
        Me.btnGestion.Text = "Gestión"
        Me.btnGestion.UseVisualStyleBackColor = False
        '
        'pnlAltas
        '
        Me.pnlAltas.AutoSize = True
        Me.pnlAltas.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlAltas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlAltas.Controls.Add(Me.Panel21)
        Me.pnlAltas.Controls.Add(Me.btnChequera)
        Me.pnlAltas.Controls.Add(Me.btnDepositos)
        Me.pnlAltas.Controls.Add(Me.btnCtasContables)
        Me.pnlAltas.Controls.Add(Me.btnBancos)
        Me.pnlAltas.Controls.Add(Me.btnArticulos)
        Me.pnlAltas.Controls.Add(Me.btnCategorias)
        Me.pnlAltas.Controls.Add(Me.btnClientes)
        Me.pnlAltas.Controls.Add(Me.btnProveedores)
        Me.pnlAltas.Controls.Add(Me.btnUsuarios)
        Me.pnlAltas.Controls.Add(Me.Panel5)
        Me.pnlAltas.Controls.Add(Me.Panel13)
        Me.bnfTransicion.SetDecoration(Me.pnlAltas, BunifuAnimatorNS.DecorationType.None)
        Me.pnlAltas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAltas.Location = New System.Drawing.Point(0, 249)
        Me.pnlAltas.Name = "pnlAltas"
        Me.pnlAltas.Size = New System.Drawing.Size(231, 319)
        Me.pnlAltas.TabIndex = 12
        Me.pnlAltas.Visible = False
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel21, BunifuAnimatorNS.DecorationType.None)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(10, 317)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(221, 2)
        Me.Panel21.TabIndex = 21
        '
        'btnChequera
        '
        Me.btnChequera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnChequera, BunifuAnimatorNS.DecorationType.None)
        Me.btnChequera.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChequera.FlatAppearance.BorderSize = 0
        Me.btnChequera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnChequera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChequera.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequera.ForeColor = System.Drawing.Color.White
        Me.btnChequera.Image = Global.Presentacion.My.Resources.Resources.IconoChequera
        Me.btnChequera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChequera.Location = New System.Drawing.Point(10, 282)
        Me.btnChequera.Name = "btnChequera"
        Me.btnChequera.Size = New System.Drawing.Size(221, 35)
        Me.btnChequera.TabIndex = 29
        Me.btnChequera.Text = "Chequeras"
        Me.btnChequera.UseVisualStyleBackColor = True
        '
        'btnDepositos
        '
        Me.btnDepositos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnDepositos, BunifuAnimatorNS.DecorationType.None)
        Me.btnDepositos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDepositos.FlatAppearance.BorderSize = 0
        Me.btnDepositos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepositos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepositos.ForeColor = System.Drawing.Color.White
        Me.btnDepositos.Image = Global.Presentacion.My.Resources.Resources.IconoDeposito
        Me.btnDepositos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepositos.Location = New System.Drawing.Point(10, 247)
        Me.btnDepositos.Name = "btnDepositos"
        Me.btnDepositos.Size = New System.Drawing.Size(221, 35)
        Me.btnDepositos.TabIndex = 19
        Me.btnDepositos.Text = "Depósitos"
        Me.btnDepositos.UseVisualStyleBackColor = True
        '
        'btnCtasContables
        '
        Me.btnCtasContables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnCtasContables, BunifuAnimatorNS.DecorationType.None)
        Me.btnCtasContables.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCtasContables.FlatAppearance.BorderSize = 0
        Me.btnCtasContables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCtasContables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtasContables.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtasContables.ForeColor = System.Drawing.Color.White
        Me.btnCtasContables.Image = Global.Presentacion.My.Resources.Resources.IconoGasto
        Me.btnCtasContables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCtasContables.Location = New System.Drawing.Point(10, 212)
        Me.btnCtasContables.Name = "btnCtasContables"
        Me.btnCtasContables.Size = New System.Drawing.Size(221, 35)
        Me.btnCtasContables.TabIndex = 17
        Me.btnCtasContables.Text = "   Cuentas Contables"
        Me.btnCtasContables.UseVisualStyleBackColor = True
        Me.btnCtasContables.Visible = False
        '
        'btnBancos
        '
        Me.btnBancos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnBancos, BunifuAnimatorNS.DecorationType.None)
        Me.btnBancos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBancos.FlatAppearance.BorderSize = 0
        Me.btnBancos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBancos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBancos.ForeColor = System.Drawing.Color.White
        Me.btnBancos.Image = Global.Presentacion.My.Resources.Resources.IconoBancos
        Me.btnBancos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBancos.Location = New System.Drawing.Point(10, 177)
        Me.btnBancos.Name = "btnBancos"
        Me.btnBancos.Size = New System.Drawing.Size(221, 35)
        Me.btnBancos.TabIndex = 15
        Me.btnBancos.Text = "Bancos"
        Me.btnBancos.UseVisualStyleBackColor = True
        '
        'btnArticulos
        '
        Me.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnArticulos, BunifuAnimatorNS.DecorationType.None)
        Me.btnArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArticulos.FlatAppearance.BorderSize = 0
        Me.btnArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArticulos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulos.ForeColor = System.Drawing.Color.White
        Me.btnArticulos.Image = Global.Presentacion.My.Resources.Resources.IconoArticulos
        Me.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArticulos.Location = New System.Drawing.Point(10, 142)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(221, 35)
        Me.btnArticulos.TabIndex = 5
        Me.btnArticulos.Text = "Artículos"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnCategorias
        '
        Me.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnCategorias, BunifuAnimatorNS.DecorationType.None)
        Me.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCategorias.FlatAppearance.BorderSize = 0
        Me.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategorias.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategorias.ForeColor = System.Drawing.Color.White
        Me.btnCategorias.Image = Global.Presentacion.My.Resources.Resources.IconoCategorias
        Me.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategorias.Location = New System.Drawing.Point(10, 107)
        Me.btnCategorias.Name = "btnCategorias"
        Me.btnCategorias.Size = New System.Drawing.Size(221, 35)
        Me.btnCategorias.TabIndex = 22
        Me.btnCategorias.Text = "Categorias"
        Me.btnCategorias.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnClientes, BunifuAnimatorNS.DecorationType.None)
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = Global.Presentacion.My.Resources.Resources.IconoClientes
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(10, 72)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(221, 35)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnProveedores, BunifuAnimatorNS.DecorationType.None)
        Me.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Image = Global.Presentacion.My.Resources.Resources.IconoProveedor
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(10, 37)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(221, 35)
        Me.btnProveedores.TabIndex = 4
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnUsuarios, BunifuAnimatorNS.DecorationType.None)
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Image = Global.Presentacion.My.Resources.Resources.IconoUser
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(10, 2)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(221, 35)
        Me.btnUsuarios.TabIndex = 2
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(10, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(221, 2)
        Me.Panel5.TabIndex = 20
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel13, BunifuAnimatorNS.DecorationType.None)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(10, 319)
        Me.Panel13.TabIndex = 0
        '
        'btnAltas
        '
        Me.btnAltas.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnAltas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnAltas, BunifuAnimatorNS.DecorationType.None)
        Me.btnAltas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAltas.FlatAppearance.BorderSize = 0
        Me.btnAltas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnAltas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltas.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltas.ForeColor = System.Drawing.Color.White
        Me.btnAltas.Image = Global.Presentacion.My.Resources.Resources.iconoAltas
        Me.btnAltas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAltas.Location = New System.Drawing.Point(0, 214)
        Me.btnAltas.Name = "btnAltas"
        Me.btnAltas.Size = New System.Drawing.Size(231, 35)
        Me.btnAltas.TabIndex = 37
        Me.btnAltas.Text = "Altas"
        Me.btnAltas.UseVisualStyleBackColor = False
        '
        'pnlSistema
        '
        Me.pnlSistema.AutoSize = True
        Me.pnlSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlSistema.Controls.Add(Me.Panel20)
        Me.pnlSistema.Controls.Add(Me.btnPtoVta)
        Me.pnlSistema.Controls.Add(Me.btnAlicuota)
        Me.pnlSistema.Controls.Add(Me.btnComprobantes)
        Me.pnlSistema.Controls.Add(Me.btnMoneda)
        Me.pnlSistema.Controls.Add(Me.btnEmpresa)
        Me.pnlSistema.Controls.Add(Me.Panel2)
        Me.pnlSistema.Controls.Add(Me.Panel17)
        Me.bnfTransicion.SetDecoration(Me.pnlSistema, BunifuAnimatorNS.DecorationType.None)
        Me.pnlSistema.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSistema.Location = New System.Drawing.Point(0, 35)
        Me.pnlSistema.Name = "pnlSistema"
        Me.pnlSistema.Size = New System.Drawing.Size(231, 179)
        Me.pnlSistema.TabIndex = 4
        Me.pnlSistema.Visible = False
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel20, BunifuAnimatorNS.DecorationType.None)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(10, 177)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(221, 2)
        Me.Panel20.TabIndex = 6
        '
        'btnPtoVta
        '
        Me.btnPtoVta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnPtoVta, BunifuAnimatorNS.DecorationType.None)
        Me.btnPtoVta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPtoVta.FlatAppearance.BorderSize = 0
        Me.btnPtoVta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnPtoVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPtoVta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPtoVta.ForeColor = System.Drawing.Color.White
        Me.btnPtoVta.Image = Global.Presentacion.My.Resources.Resources.IconoUbicacion
        Me.btnPtoVta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPtoVta.Location = New System.Drawing.Point(10, 142)
        Me.btnPtoVta.Name = "btnPtoVta"
        Me.btnPtoVta.Size = New System.Drawing.Size(221, 35)
        Me.btnPtoVta.TabIndex = 31
        Me.btnPtoVta.Text = "Puntos de Venta"
        Me.btnPtoVta.UseVisualStyleBackColor = True
        '
        'btnAlicuota
        '
        Me.btnAlicuota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnAlicuota, BunifuAnimatorNS.DecorationType.None)
        Me.btnAlicuota.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAlicuota.FlatAppearance.BorderSize = 0
        Me.btnAlicuota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnAlicuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlicuota.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlicuota.ForeColor = System.Drawing.Color.White
        Me.btnAlicuota.Image = Global.Presentacion.My.Resources.Resources.IconoAlicuota
        Me.btnAlicuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlicuota.Location = New System.Drawing.Point(10, 107)
        Me.btnAlicuota.Name = "btnAlicuota"
        Me.btnAlicuota.Size = New System.Drawing.Size(221, 35)
        Me.btnAlicuota.TabIndex = 5
        Me.btnAlicuota.Text = "Alicuotas"
        Me.btnAlicuota.UseVisualStyleBackColor = True
        Me.btnAlicuota.Visible = False
        '
        'btnComprobantes
        '
        Me.btnComprobantes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnComprobantes, BunifuAnimatorNS.DecorationType.None)
        Me.btnComprobantes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComprobantes.FlatAppearance.BorderSize = 0
        Me.btnComprobantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprobantes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobantes.ForeColor = System.Drawing.Color.White
        Me.btnComprobantes.Image = Global.Presentacion.My.Resources.Resources.IconoComprobante
        Me.btnComprobantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComprobantes.Location = New System.Drawing.Point(10, 72)
        Me.btnComprobantes.Name = "btnComprobantes"
        Me.btnComprobantes.Size = New System.Drawing.Size(221, 35)
        Me.btnComprobantes.TabIndex = 4
        Me.btnComprobantes.Text = "Comprobantes"
        Me.btnComprobantes.UseVisualStyleBackColor = True
        '
        'btnMoneda
        '
        Me.btnMoneda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnMoneda, BunifuAnimatorNS.DecorationType.None)
        Me.btnMoneda.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMoneda.FlatAppearance.BorderSize = 0
        Me.btnMoneda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoneda.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoneda.ForeColor = System.Drawing.Color.White
        Me.btnMoneda.Image = Global.Presentacion.My.Resources.Resources.IconoMoneda
        Me.btnMoneda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMoneda.Location = New System.Drawing.Point(10, 37)
        Me.btnMoneda.Name = "btnMoneda"
        Me.btnMoneda.Size = New System.Drawing.Size(221, 35)
        Me.btnMoneda.TabIndex = 3
        Me.btnMoneda.Text = "Moneda"
        Me.btnMoneda.UseVisualStyleBackColor = True
        Me.btnMoneda.Visible = False
        '
        'btnEmpresa
        '
        Me.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnEmpresa, BunifuAnimatorNS.DecorationType.None)
        Me.btnEmpresa.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpresa.FlatAppearance.BorderSize = 0
        Me.btnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpresa.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpresa.ForeColor = System.Drawing.Color.White
        Me.btnEmpresa.Image = Global.Presentacion.My.Resources.Resources.btnEmpresa
        Me.btnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpresa.Location = New System.Drawing.Point(10, 2)
        Me.btnEmpresa.Name = "btnEmpresa"
        Me.btnEmpresa.Size = New System.Drawing.Size(221, 35)
        Me.btnEmpresa.TabIndex = 2
        Me.btnEmpresa.Text = "Empresa"
        Me.btnEmpresa.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 2)
        Me.Panel2.TabIndex = 1
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Panel17.Controls.Add(Me.Panel1)
        Me.bnfTransicion.SetDecoration(Me.Panel17, BunifuAnimatorNS.DecorationType.None)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(10, 179)
        Me.Panel17.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.bnfTransicion.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 179)
        Me.Panel1.TabIndex = 1
        '
        'btnSistema
        '
        Me.btnSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.btnSistema, BunifuAnimatorNS.DecorationType.None)
        Me.btnSistema.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSistema.FlatAppearance.BorderSize = 0
        Me.btnSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSistema.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSistema.ForeColor = System.Drawing.Color.White
        Me.btnSistema.Image = Global.Presentacion.My.Resources.Resources.IconoSistema
        Me.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSistema.Location = New System.Drawing.Point(0, 0)
        Me.btnSistema.Name = "btnSistema"
        Me.btnSistema.Size = New System.Drawing.Size(231, 35)
        Me.btnSistema.TabIndex = 45
        Me.btnSistema.Text = "Sistema"
        Me.btnSistema.UseVisualStyleBackColor = False
        '
        'bnfPanelPie
        '
        Me.bnfPanelPie.BackgroundImage = CType(resources.GetObject("bnfPanelPie.BackgroundImage"), System.Drawing.Image)
        Me.bnfPanelPie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bnfPanelPie.Controls.Add(Me.lblFechaSecundaria)
        Me.bnfPanelPie.Controls.Add(Me.lblHoraSecundaria)
        Me.bnfPanelPie.Controls.Add(Me.pbxUsuario)
        Me.bnfPanelPie.Controls.Add(Me.lblCat)
        Me.bnfPanelPie.Controls.Add(Me.lblUsuario)
        Me.bnfPanelPie.Controls.Add(Me.lblPerfil)
        Me.bnfTransicion.SetDecoration(Me.bnfPanelPie, BunifuAnimatorNS.DecorationType.None)
        Me.bnfPanelPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnfPanelPie.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfPanelPie.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfPanelPie.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfPanelPie.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfPanelPie.Location = New System.Drawing.Point(0, 684)
        Me.bnfPanelPie.Name = "bnfPanelPie"
        Me.bnfPanelPie.Quality = 50
        Me.bnfPanelPie.Size = New System.Drawing.Size(248, 143)
        Me.bnfPanelPie.TabIndex = 29
        '
        'lblFechaSecundaria
        '
        Me.lblFechaSecundaria.BackColor = System.Drawing.Color.Transparent
        Me.bnfTransicion.SetDecoration(Me.lblFechaSecundaria, BunifuAnimatorNS.DecorationType.None)
        Me.lblFechaSecundaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSecundaria.ForeColor = System.Drawing.Color.Gray
        Me.lblFechaSecundaria.Location = New System.Drawing.Point(2, 34)
        Me.lblFechaSecundaria.Name = "lblFechaSecundaria"
        Me.lblFechaSecundaria.Size = New System.Drawing.Size(242, 35)
        Me.lblFechaSecundaria.TabIndex = 48
        Me.lblFechaSecundaria.Text = "Miercoles, 13 de mayo de 2019"
        Me.lblFechaSecundaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraSecundaria
        '
        Me.lblHoraSecundaria.BackColor = System.Drawing.Color.Transparent
        Me.bnfTransicion.SetDecoration(Me.lblHoraSecundaria, BunifuAnimatorNS.DecorationType.None)
        Me.lblHoraSecundaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraSecundaria.ForeColor = System.Drawing.Color.White
        Me.lblHoraSecundaria.Location = New System.Drawing.Point(2, 1)
        Me.lblHoraSecundaria.Name = "lblHoraSecundaria"
        Me.lblHoraSecundaria.Size = New System.Drawing.Size(242, 43)
        Me.lblHoraSecundaria.TabIndex = 47
        Me.lblHoraSecundaria.Text = "00:00:00"
        Me.lblHoraSecundaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxUsuario
        '
        Me.pbxUsuario.BackColor = System.Drawing.Color.Transparent
        Me.bnfTransicion.SetDecoration(Me.pbxUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.pbxUsuario.Image = Global.Presentacion.My.Resources.Resources.IconoUsuario
        Me.pbxUsuario.Location = New System.Drawing.Point(6, 74)
        Me.pbxUsuario.Name = "pbxUsuario"
        Me.pbxUsuario.Size = New System.Drawing.Size(70, 64)
        Me.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxUsuario.TabIndex = 45
        Me.pbxUsuario.TabStop = False
        '
        'lblCat
        '
        Me.lblCat.BackColor = System.Drawing.Color.Transparent
        Me.bnfTransicion.SetDecoration(Me.lblCat, BunifuAnimatorNS.DecorationType.None)
        Me.lblCat.Font = New System.Drawing.Font("Trebuchet MS", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.ForeColor = System.Drawing.Color.White
        Me.lblCat.Location = New System.Drawing.Point(80, 99)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(160, 20)
        Me.lblCat.TabIndex = 46
        Me.lblCat.Text = "Categoria"
        '
        'lblUsuario
        '
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.bnfTransicion.SetDecoration(Me.lblUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.lblUsuario.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(80, 74)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(160, 25)
        Me.lblUsuario.TabIndex = 42
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPerfil
        '
        Me.lblPerfil.BackColor = System.Drawing.Color.Transparent
        Me.bnfTransicion.SetDecoration(Me.lblPerfil, BunifuAnimatorNS.DecorationType.None)
        Me.lblPerfil.Font = New System.Drawing.Font("Trebuchet MS", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfil.ForeColor = System.Drawing.Color.White
        Me.lblPerfil.Location = New System.Drawing.Point(80, 119)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(160, 19)
        Me.lblPerfil.TabIndex = 50
        Me.lblPerfil.Text = "Perfil"
        '
        'bnfPanelLogo
        '
        Me.bnfPanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfPanelLogo.BackgroundImage = CType(resources.GetObject("bnfPanelLogo.BackgroundImage"), System.Drawing.Image)
        Me.bnfPanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bnfPanelLogo.Controls.Add(Me.BunifuGradientPanel1)
        Me.bnfPanelLogo.Controls.Add(Me.pbxLogo)
        Me.bnfTransicion.SetDecoration(Me.bnfPanelLogo, BunifuAnimatorNS.DecorationType.None)
        Me.bnfPanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.bnfPanelLogo.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfPanelLogo.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfPanelLogo.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.bnfPanelLogo.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bnfPanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.bnfPanelLogo.Name = "bnfPanelLogo"
        Me.bnfPanelLogo.Quality = 50
        Me.bnfPanelLogo.Size = New System.Drawing.Size(248, 125)
        Me.bnfPanelLogo.TabIndex = 26
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.pbxEmpresa)
        Me.bnfTransicion.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(248, 125)
        Me.BunifuGradientPanel1.TabIndex = 28
        '
        'pbxEmpresa
        '
        Me.pbxEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.bnfTransicion.SetDecoration(Me.pbxEmpresa, BunifuAnimatorNS.DecorationType.None)
        Me.pbxEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxEmpresa.Image = Global.Presentacion.My.Resources.Resources.IconoEmpresa
        Me.pbxEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.pbxEmpresa.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.pbxEmpresa.Name = "pbxEmpresa"
        Me.pbxEmpresa.Size = New System.Drawing.Size(248, 125)
        Me.pbxEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxEmpresa.TabIndex = 27
        Me.pbxEmpresa.TabStop = False
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.bnfTransicion.SetDecoration(Me.pbxLogo, BunifuAnimatorNS.DecorationType.None)
        Me.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxLogo.Image = Global.Presentacion.My.Resources.Resources.IconoEmpresa
        Me.pbxLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(248, 125)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 27
        Me.pbxLogo.TabStop = False
        '
        'pnlBarraFrm
        '
        Me.pnlBarraFrm.BackgroundImage = CType(resources.GetObject("pnlBarraFrm.BackgroundImage"), System.Drawing.Image)
        Me.pnlBarraFrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBarraFrm.Controls.Add(Me.pbxSalir)
        Me.pnlBarraFrm.Controls.Add(Me.pbxMin)
        Me.pnlBarraFrm.Controls.Add(Me.lblTitulo)
        Me.pnlBarraFrm.Controls.Add(Me.pbxRest)
        Me.pnlBarraFrm.Controls.Add(Me.pbxMax)
        Me.bnfTransicion.SetDecoration(Me.pnlBarraFrm, BunifuAnimatorNS.DecorationType.None)
        Me.pnlBarraFrm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraFrm.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlBarraFrm.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.pnlBarraFrm.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlBarraFrm.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.pnlBarraFrm.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarraFrm.Name = "pnlBarraFrm"
        Me.pnlBarraFrm.Quality = 10
        Me.pnlBarraFrm.Size = New System.Drawing.Size(1600, 33)
        Me.pnlBarraFrm.TabIndex = 26
        '
        'pbxSalir
        '
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.pbxSalir, BunifuAnimatorNS.DecorationType.None)
        Me.pbxSalir.Image = Global.Presentacion.My.Resources.Resources.cerrar
        Me.pbxSalir.Location = New System.Drawing.Point(1570, 4)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(25, 25)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 18
        Me.pbxSalir.TabStop = False
        '
        'pbxMin
        '
        Me.pbxMin.BackColor = System.Drawing.Color.Transparent
        Me.pbxMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.pbxMin, BunifuAnimatorNS.DecorationType.None)
        Me.pbxMin.Image = Global.Presentacion.My.Resources.Resources.minimazar
        Me.pbxMin.Location = New System.Drawing.Point(1489, 4)
        Me.pbxMin.Name = "pbxMin"
        Me.pbxMin.Size = New System.Drawing.Size(25, 25)
        Me.pbxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMin.TabIndex = 15
        Me.pbxMin.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.bnfTransicion.SetDecoration(Me.lblTitulo, BunifuAnimatorNS.DecorationType.None)
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(6, 2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1177, 29)
        Me.lblTitulo.TabIndex = 19
        Me.lblTitulo.Text = "Sistema de Gestion y Venta de Agroinsumos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxRest
        '
        Me.pbxRest.BackColor = System.Drawing.Color.Transparent
        Me.pbxRest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.pbxRest, BunifuAnimatorNS.DecorationType.None)
        Me.pbxRest.Image = Global.Presentacion.My.Resources.Resources.res
        Me.pbxRest.Location = New System.Drawing.Point(1529, 4)
        Me.pbxRest.Name = "pbxRest"
        Me.pbxRest.Size = New System.Drawing.Size(25, 25)
        Me.pbxRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxRest.TabIndex = 16
        Me.pbxRest.TabStop = False
        '
        'pbxMax
        '
        Me.pbxMax.BackColor = System.Drawing.Color.Transparent
        Me.pbxMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnfTransicion.SetDecoration(Me.pbxMax, BunifuAnimatorNS.DecorationType.None)
        Me.pbxMax.Image = Global.Presentacion.My.Resources.Resources.maxi
        Me.pbxMax.Location = New System.Drawing.Point(1529, 4)
        Me.pbxMax.Name = "pbxMax"
        Me.pbxMax.Size = New System.Drawing.Size(25, 25)
        Me.pbxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMax.TabIndex = 17
        Me.pbxMax.TabStop = False
        Me.pbxMax.Visible = False
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'tmrVolver
        '
        Me.tmrVolver.Interval = 120000
        '
        'frmPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1600, 860)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.bnfPanelMenu)
        Me.Controls.Add(Me.pnlBarraFrm)
        Me.bnfTransicion.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1280, 650)
        Me.Name = "frmPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = " "
        Me.bnfPanelMenu.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlSeguridad.ResumeLayout(False)
        Me.pnlConsultas.ResumeLayout(False)
        Me.pnlConsultas.PerformLayout()
        Me.pnlConsCanjes.ResumeLayout(False)
        Me.pnlConsCaja.ResumeLayout(False)
        Me.pnlConsVentas.ResumeLayout(False)
        Me.pnlConsCompras.ResumeLayout(False)
        Me.pnlStock.ResumeLayout(False)
        Me.pnlGestion.ResumeLayout(False)
        Me.pnlGestion.PerformLayout()
        Me.pnlBancos.ResumeLayout(False)
        Me.pnlCanjes.ResumeLayout(False)
        Me.pnlVentas.ResumeLayout(False)
        Me.pnlCompras.ResumeLayout(False)
        Me.pnlAltas.ResumeLayout(False)
        Me.pnlSistema.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.bnfPanelPie.ResumeLayout(False)
        CType(Me.pbxUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfPanelLogo.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.pbxEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBarraFrm.ResumeLayout(False)
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Hora As Timer
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents bnfPanelLogo As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnSeguridad As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnGestion As Button
    Friend WithEvents btnAltas As Button
    Friend WithEvents btnSistema As Button
    Friend WithEvents bnfPanelMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblCat As Label
    Friend WithEvents pbxUsuario As PictureBox
    Friend WithEvents lblHoraSecundaria As Label
    Friend WithEvents lblFechaSecundaria As Label
    Friend WithEvents bnfPanelPie As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pnlBancos As Panel
    Friend WithEvents Panel47 As Panel
    Friend WithEvents btnBcoRetiros As Button
    Friend WithEvents btnBcoDepositos As Button
    Friend WithEvents pnlCompras As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents btnOrdPago As Button
    Friend WithEvents btnNDCom As Button
    Friend WithEvents btnNCCom As Button
    Friend WithEvents btnFacCom As Button
    Friend WithEvents btnRemCom As Button
    Friend WithEvents pnlVentas As Panel
    Friend WithEvents btnRecVta As Button
    Friend WithEvents btnNDVta As Button
    Friend WithEvents Panel36 As Panel
    Friend WithEvents btnNCVta As Button
    Friend WithEvents btnFacVta As Button
    Friend WithEvents btnRemVta As Button
    Friend WithEvents btnPedidos As Button
    Friend WithEvents pnlCanjes As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents btnLiquidaciones As Button
    Friend WithEvents btnCartasPorte As Button
    Friend WithEvents btnFijacionContratos As Button
    Friend WithEvents btnEmisionContratos As Button
    Friend WithEvents pnlAltas As Panel
    Friend WithEvents btnDepositos As Button
    Friend WithEvents btnCtasContables As Button
    Friend WithEvents btnBancos As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btnArticulos As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents pnlGestion As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents btnCaja As Button
    Friend WithEvents btnCanjes As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents pnlSistema As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents btnAlicuota As Button
    Friend WithEvents btnComprobantes As Button
    Friend WithEvents btnMoneda As Button
    Friend WithEvents btnEmpresa As Button
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbxRest As PictureBox
    Friend WithEvents pbxMax As PictureBox
    Friend WithEvents pbxMin As PictureBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents pnlBarraFrm As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents bnfTransicion As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents pnlConsultas As Panel
    Friend WithEvents Panel50 As Panel
    Friend WithEvents btnConsArticulos As Button
    Friend WithEvents btnConsProv As Button
    Friend WithEvents btnConsClientes As Button
    Friend WithEvents btnConsUsuarios As Button
    Friend WithEvents btnConsVentas As Button
    Friend WithEvents btnConsCompras As Button
    Friend WithEvents btnConsCanjes As Button
    Friend WithEvents btnConsBancos As Button
    Friend WithEvents btnConsCaja As Button
    Friend WithEvents btnConsStock As Button
    Friend WithEvents pnlStock As Panel
    Friend WithEvents Panel61 As Panel
    Friend WithEvents btnTransferenciasStock As Button
    Friend WithEvents btnMantenimientoStock As Button
    Friend WithEvents pnlSeguridad As Panel
    Friend WithEvents btnRegistroActividad As Button
    Friend WithEvents Panel63 As Panel
    Friend WithEvents btnRegistroRespaldo As Button
    Friend WithEvents btnPerfilesUs As Button
    Friend WithEvents btnRespaldo As Button
    Friend WithEvents pnlConsCompras As Panel
    Friend WithEvents Panel67 As Panel
    Friend WithEvents btnConsComNotasDebito As Button
    Friend WithEvents btnConsComNotasCredito As Button
    Friend WithEvents btnConsComFacturas As Button
    Friend WithEvents btnConsComRemito As Button
    Friend WithEvents lblPerfil As Label
    Friend WithEvents pnlConsCanjes As Panel
    Friend WithEvents Panel75 As Panel
    Friend WithEvents btnConsLiquidaciones As Button
    Friend WithEvents btnConsCartaPorte As Button
    Friend WithEvents btnConsFiacionesCtos As Button
    Friend WithEvents btnConsContratos As Button
    Friend WithEvents pnlConsCaja As Panel
    Friend WithEvents Panel78 As Panel
    Friend WithEvents btnConcCartera As Button
    Friend WithEvents btnConsArqueos As Button
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCompras As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBanco As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents pnlConsVentas As Panel
    Friend WithEvents btnConsVtaND As Button
    Friend WithEvents btnConsVtaNC As Button
    Friend WithEvents btnConsVtaFacturas As Button
    Friend WithEvents btnConsVtaRemitos As Button
    Friend WithEvents btnConsVtaPedidos As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel56 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel37 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents btnCategorias As Button
    Friend WithEvents tmrVolver As Timer
    Friend WithEvents btnChequera As Button
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pbxEmpresa As PictureBox
    Friend WithEvents btnPtoVta As Button
    Friend WithEvents btnConsComCuentaCorriente As Button
    Friend WithEvents btnConsVtaCuentaCorriente As Button
    Friend WithEvents btnDevolucionesVta As Button
End Class
