<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPtoVta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPtoVta))
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.bnfCardList = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvPtoVta = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlFrmClientes = New System.Windows.Forms.Panel()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardNros = New Bunifu.Framework.UI.BunifuCards()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNroNDX = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtNroNDC = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNroNDB = New System.Windows.Forms.TextBox()
        Me.txtNroRes = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNroRem = New System.Windows.Forms.TextBox()
        Me.txtNroNDA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNroRec = New System.Windows.Forms.TextBox()
        Me.txtNroNCX = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNroOrdCom = New System.Windows.Forms.TextBox()
        Me.txtNroNCC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNroFacA = New System.Windows.Forms.TextBox()
        Me.txtNroNCB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtNroFacB = New System.Windows.Forms.TextBox()
        Me.txtNroNCA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNroFacC = New System.Windows.Forms.TextBox()
        Me.txtNroFacX = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bnfCardTituloFrm = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.txtIdNumeracion = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bnfCardDetalle = New Bunifu.Framework.UI.BunifuCards()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPtoVta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfCardList.SuspendLayout()
        Me.BunifuCards6.SuspendLayout()
        CType(Me.dgvPtoVta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrmClientes.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.bnfCardNros.SuspendLayout()
        Me.bnfCardTituloFrm.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardDetalle.SuspendLayout()
        Me.SuspendLayout()
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
        Me.bnfCardList.Controls.Add(Me.BunifuCards6)
        Me.bnfCardList.Controls.Add(Me.dgvPtoVta)
        Me.bnfCardList.LeftSahddow = False
        Me.bnfCardList.Location = New System.Drawing.Point(11, 287)
        Me.bnfCardList.Name = "bnfCardList"
        Me.bnfCardList.RightSahddow = True
        Me.bnfCardList.ShadowDepth = 20
        Me.bnfCardList.Size = New System.Drawing.Size(1330, 459)
        Me.bnfCardList.TabIndex = 58
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCards6.Controls.Add(Me.Label6)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(6, 11)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(1316, 33)
        Me.BunifuCards6.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(487, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "PUNTOS DE VENTA CARGADOS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvPtoVta
        '
        Me.dgvPtoVta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvPtoVta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPtoVta.Location = New System.Drawing.Point(9, 43)
        Me.dgvPtoVta.Name = "dgvPtoVta"
        Me.dgvPtoVta.Size = New System.Drawing.Size(1310, 405)
        Me.dgvPtoVta.TabIndex = 50
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PTO. DE VTA."
        '
        'pnlFrmClientes
        '
        Me.pnlFrmClientes.AutoScroll = True
        Me.pnlFrmClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmClientes.Controls.Add(Me.BunifuCards2)
        Me.pnlFrmClientes.Controls.Add(Me.bnfCardNros)
        Me.pnlFrmClientes.Controls.Add(Me.bnfCardTituloFrm)
        Me.pnlFrmClientes.Controls.Add(Me.bnfCardList)
        Me.pnlFrmClientes.Controls.Add(Me.bnfCardDetalle)
        Me.pnlFrmClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmClientes.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmClientes.Name = "pnlFrmClientes"
        Me.pnlFrmClientes.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmClientes.TabIndex = 60
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.btnNuevo)
        Me.BunifuCards2.Controls.Add(Me.btnModificar)
        Me.BunifuCards2.Controls.Add(Me.btnCancelar)
        Me.BunifuCards2.Controls.Add(Me.btnGuardar)
        Me.BunifuCards2.Controls.Add(Me.btnEliminar)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(651, 752)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(690, 61)
        Me.BunifuCards2.TabIndex = 110
        '
        'bnfCardNros
        '
        Me.bnfCardNros.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardNros.BorderRadius = 5
        Me.bnfCardNros.BottomSahddow = True
        Me.bnfCardNros.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardNros.Controls.Add(Me.Label21)
        Me.bnfCardNros.Controls.Add(Me.txtNroNDX)
        Me.bnfCardNros.Controls.Add(Me.Label22)
        Me.bnfCardNros.Controls.Add(Me.txtNroNDC)
        Me.bnfCardNros.Controls.Add(Me.Label23)
        Me.bnfCardNros.Controls.Add(Me.Label3)
        Me.bnfCardNros.Controls.Add(Me.txtNroNDB)
        Me.bnfCardNros.Controls.Add(Me.txtNroRes)
        Me.bnfCardNros.Controls.Add(Me.Label24)
        Me.bnfCardNros.Controls.Add(Me.txtNroRem)
        Me.bnfCardNros.Controls.Add(Me.txtNroNDA)
        Me.bnfCardNros.Controls.Add(Me.Label4)
        Me.bnfCardNros.Controls.Add(Me.Label17)
        Me.bnfCardNros.Controls.Add(Me.txtNroRec)
        Me.bnfCardNros.Controls.Add(Me.txtNroNCX)
        Me.bnfCardNros.Controls.Add(Me.Label5)
        Me.bnfCardNros.Controls.Add(Me.Label18)
        Me.bnfCardNros.Controls.Add(Me.txtNroOrdCom)
        Me.bnfCardNros.Controls.Add(Me.txtNroNCC)
        Me.bnfCardNros.Controls.Add(Me.Label8)
        Me.bnfCardNros.Controls.Add(Me.Label19)
        Me.bnfCardNros.Controls.Add(Me.txtNroFacA)
        Me.bnfCardNros.Controls.Add(Me.txtNroNCB)
        Me.bnfCardNros.Controls.Add(Me.Label12)
        Me.bnfCardNros.Controls.Add(Me.Label20)
        Me.bnfCardNros.Controls.Add(Me.txtNroFacB)
        Me.bnfCardNros.Controls.Add(Me.txtNroNCA)
        Me.bnfCardNros.Controls.Add(Me.Label11)
        Me.bnfCardNros.Controls.Add(Me.Label9)
        Me.bnfCardNros.Controls.Add(Me.txtNroFacC)
        Me.bnfCardNros.Controls.Add(Me.txtNroFacX)
        Me.bnfCardNros.Controls.Add(Me.Label10)
        Me.bnfCardNros.LeftSahddow = False
        Me.bnfCardNros.Location = New System.Drawing.Point(11, 122)
        Me.bnfCardNros.Name = "bnfCardNros"
        Me.bnfCardNros.RightSahddow = True
        Me.bnfCardNros.ShadowDepth = 20
        Me.bnfCardNros.Size = New System.Drawing.Size(1040, 159)
        Me.bnfCardNros.TabIndex = 58
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LightGray
        Me.Label21.Location = New System.Drawing.Point(765, 124)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 18)
        Me.Label21.TabIndex = 90
        Me.Label21.Text = "NRO ND. ""X"""
        '
        'txtNroNDX
        '
        Me.txtNroNDX.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroNDX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroNDX.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroNDX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroNDX.Location = New System.Drawing.Point(875, 120)
        Me.txtNroNDX.MaxLength = 8
        Me.txtNroNDX.Name = "txtNroNDX"
        Me.txtNroNDX.Size = New System.Drawing.Size(151, 25)
        Me.txtNroNDX.TabIndex = 89
        Me.txtNroNDX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LightGray
        Me.Label22.Location = New System.Drawing.Point(512, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 18)
        Me.Label22.TabIndex = 88
        Me.Label22.Text = "NRO ND. ""C"""
        '
        'txtNroNDC
        '
        Me.txtNroNDC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroNDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroNDC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroNDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroNDC.Location = New System.Drawing.Point(608, 120)
        Me.txtNroNDC.MaxLength = 8
        Me.txtNroNDC.Name = "txtNroNDC"
        Me.txtNroNDC.Size = New System.Drawing.Size(151, 25)
        Me.txtNroNDC.TabIndex = 87
        Me.txtNroNDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.LightGray
        Me.Label23.Location = New System.Drawing.Point(259, 124)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 18)
        Me.Label23.TabIndex = 86
        Me.Label23.Text = "NRO ND. ""B"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "NRO RESERVA"
        '
        'txtNroNDB
        '
        Me.txtNroNDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroNDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroNDB.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroNDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroNDB.Location = New System.Drawing.Point(355, 120)
        Me.txtNroNDB.MaxLength = 8
        Me.txtNroNDB.Name = "txtNroNDB"
        Me.txtNroNDB.Size = New System.Drawing.Size(151, 25)
        Me.txtNroNDB.TabIndex = 85
        Me.txtNroNDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroRes
        '
        Me.txtNroRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroRes.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroRes.Location = New System.Drawing.Point(102, 15)
        Me.txtNroRes.MaxLength = 8
        Me.txtNroRes.Name = "txtNroRes"
        Me.txtNroRes.Size = New System.Drawing.Size(151, 25)
        Me.txtNroRes.TabIndex = 50
        Me.txtNroRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LightGray
        Me.Label24.Location = New System.Drawing.Point(6, 124)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 18)
        Me.Label24.TabIndex = 84
        Me.Label24.Text = "NRO ND. ""A"""
        '
        'txtNroRem
        '
        Me.txtNroRem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroRem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroRem.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroRem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroRem.Location = New System.Drawing.Point(355, 15)
        Me.txtNroRem.MaxLength = 8
        Me.txtNroRem.Name = "txtNroRem"
        Me.txtNroRem.Size = New System.Drawing.Size(151, 25)
        Me.txtNroRem.TabIndex = 52
        Me.txtNroRem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroNDA
        '
        Me.txtNroNDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroNDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroNDA.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroNDA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroNDA.Location = New System.Drawing.Point(102, 120)
        Me.txtNroNDA.MaxLength = 8
        Me.txtNroNDA.Name = "txtNroNDA"
        Me.txtNroNDA.Size = New System.Drawing.Size(151, 25)
        Me.txtNroNDA.TabIndex = 83
        Me.txtNroNDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(259, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "NRO REMITO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightGray
        Me.Label17.Location = New System.Drawing.Point(765, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 18)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "NRO NC. ""X"""
        '
        'txtNroRec
        '
        Me.txtNroRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroRec.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroRec.Location = New System.Drawing.Point(608, 15)
        Me.txtNroRec.MaxLength = 8
        Me.txtNroRec.Name = "txtNroRec"
        Me.txtNroRec.Size = New System.Drawing.Size(151, 25)
        Me.txtNroRec.TabIndex = 55
        Me.txtNroRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroNCX
        '
        Me.txtNroNCX.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroNCX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroNCX.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroNCX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroNCX.Location = New System.Drawing.Point(875, 85)
        Me.txtNroNCX.MaxLength = 8
        Me.txtNroNCX.Name = "txtNroNCX"
        Me.txtNroNCX.Size = New System.Drawing.Size(151, 25)
        Me.txtNroNCX.TabIndex = 81
        Me.txtNroNCX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(512, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "NRO RECIBO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightGray
        Me.Label18.Location = New System.Drawing.Point(512, 89)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 18)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "NRO NC. ""C"""
        '
        'txtNroOrdCom
        '
        Me.txtNroOrdCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroOrdCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroOrdCom.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrdCom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroOrdCom.Location = New System.Drawing.Point(875, 15)
        Me.txtNroOrdCom.MaxLength = 8
        Me.txtNroOrdCom.Name = "txtNroOrdCom"
        Me.txtNroOrdCom.Size = New System.Drawing.Size(151, 25)
        Me.txtNroOrdCom.TabIndex = 57
        Me.txtNroOrdCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroNCC
        '
        Me.txtNroNCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroNCC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroNCC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroNCC.Location = New System.Drawing.Point(608, 85)
        Me.txtNroNCC.MaxLength = 8
        Me.txtNroNCC.Name = "txtNroNCC"
        Me.txtNroNCC.Size = New System.Drawing.Size(151, 25)
        Me.txtNroNCC.TabIndex = 79
        Me.txtNroNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(765, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 18)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "NRO ORD. COM."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightGray
        Me.Label19.Location = New System.Drawing.Point(259, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 18)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "NRO NC. ""B"""
        '
        'txtNroFacA
        '
        Me.txtNroFacA.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroFacA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroFacA.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFacA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroFacA.Location = New System.Drawing.Point(102, 50)
        Me.txtNroFacA.MaxLength = 8
        Me.txtNroFacA.Name = "txtNroFacA"
        Me.txtNroFacA.Size = New System.Drawing.Size(151, 25)
        Me.txtNroFacA.TabIndex = 59
        Me.txtNroFacA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroNCB
        '
        Me.txtNroNCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroNCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroNCB.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroNCB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroNCB.Location = New System.Drawing.Point(355, 85)
        Me.txtNroNCB.MaxLength = 8
        Me.txtNroNCB.Name = "txtNroNCB"
        Me.txtNroNCB.Size = New System.Drawing.Size(151, 25)
        Me.txtNroNCB.TabIndex = 77
        Me.txtNroNCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(6, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 18)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "NRO FAC. ""A"""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LightGray
        Me.Label20.Location = New System.Drawing.Point(6, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 18)
        Me.Label20.TabIndex = 76
        Me.Label20.Text = "NRO NC. ""A"""
        '
        'txtNroFacB
        '
        Me.txtNroFacB.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroFacB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroFacB.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFacB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroFacB.Location = New System.Drawing.Point(355, 50)
        Me.txtNroFacB.MaxLength = 8
        Me.txtNroFacB.Name = "txtNroFacB"
        Me.txtNroFacB.Size = New System.Drawing.Size(151, 25)
        Me.txtNroFacB.TabIndex = 61
        Me.txtNroFacB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroNCA
        '
        Me.txtNroNCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroNCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroNCA.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroNCA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroNCA.Location = New System.Drawing.Point(102, 85)
        Me.txtNroNCA.MaxLength = 8
        Me.txtNroNCA.Name = "txtNroNCA"
        Me.txtNroNCA.Size = New System.Drawing.Size(151, 25)
        Me.txtNroNCA.TabIndex = 75
        Me.txtNroNCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(259, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 18)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "NRO FAC. ""B"""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(765, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 18)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "NRO FAC. ""X"""
        '
        'txtNroFacC
        '
        Me.txtNroFacC.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroFacC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroFacC.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFacC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroFacC.Location = New System.Drawing.Point(608, 50)
        Me.txtNroFacC.MaxLength = 8
        Me.txtNroFacC.Name = "txtNroFacC"
        Me.txtNroFacC.Size = New System.Drawing.Size(151, 25)
        Me.txtNroFacC.TabIndex = 63
        Me.txtNroFacC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroFacX
        '
        Me.txtNroFacX.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNroFacX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroFacX.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFacX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNroFacX.Location = New System.Drawing.Point(875, 50)
        Me.txtNroFacX.MaxLength = 8
        Me.txtNroFacX.Name = "txtNroFacX"
        Me.txtNroFacX.Size = New System.Drawing.Size(151, 25)
        Me.txtNroFacX.TabIndex = 65
        Me.txtNroFacX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(512, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "NRO FAC. ""C"""
        '
        'bnfCardTituloFrm
        '
        Me.bnfCardTituloFrm.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTituloFrm.BorderRadius = 0
        Me.bnfCardTituloFrm.BottomSahddow = True
        Me.bnfCardTituloFrm.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTituloFrm.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTituloFrm.Controls.Add(Me.txtIdNumeracion)
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
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoUbicacion
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 71
        Me.pbxTitulo.TabStop = False
        '
        'txtIdNumeracion
        '
        Me.txtIdNumeracion.BackColor = System.Drawing.Color.Red
        Me.txtIdNumeracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdNumeracion.Enabled = False
        Me.txtIdNumeracion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdNumeracion.ForeColor = System.Drawing.Color.White
        Me.txtIdNumeracion.Location = New System.Drawing.Point(860, 5)
        Me.txtIdNumeracion.Name = "txtIdNumeracion"
        Me.txtIdNumeracion.Size = New System.Drawing.Size(68, 25)
        Me.txtIdNumeracion.TabIndex = 65
        Me.txtIdNumeracion.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(934, 5)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 62
        Me.txtOrigen.Visible = False
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
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(995, 35)
        Me.lblTitulo.TabIndex = 70
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnfCardDetalle
        '
        Me.bnfCardDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDetalle.BorderRadius = 5
        Me.bnfCardDetalle.BottomSahddow = True
        Me.bnfCardDetalle.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDetalle.Controls.Add(Me.txtDescripcion)
        Me.bnfCardDetalle.Controls.Add(Me.Label1)
        Me.bnfCardDetalle.Controls.Add(Me.txtPtoVta)
        Me.bnfCardDetalle.Controls.Add(Me.Label2)
        Me.bnfCardDetalle.LeftSahddow = False
        Me.bnfCardDetalle.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardDetalle.Name = "bnfCardDetalle"
        Me.bnfCardDetalle.RightSahddow = True
        Me.bnfCardDetalle.ShadowDepth = 20
        Me.bnfCardDetalle.Size = New System.Drawing.Size(1040, 75)
        Me.bnfCardDetalle.TabIndex = 57
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(102, 42)
        Me.txtDescripcion.MaxLength = 254
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(924, 25)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtPtoVta
        '
        Me.txtPtoVta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPtoVta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPtoVta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtoVta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPtoVta.Location = New System.Drawing.Point(102, 11)
        Me.txtPtoVta.MaxLength = 8
        Me.txtPtoVta.Name = "txtPtoVta"
        Me.txtPtoVta.Size = New System.Drawing.Size(151, 25)
        Me.txtPtoVta.TabIndex = 0
        Me.txtPtoVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "DESCRIPCION"
        '
        'bnfElpElim
        '
        Me.bnfElpElim.ElipseRadius = 7
        Me.bnfElpElim.TargetControl = Me.btnEliminar
        '
        'frmPtoVta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmClientes)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPtoVta"
        Me.Text = "frmPtoVta"
        Me.bnfCardList.ResumeLayout(False)
        Me.BunifuCards6.ResumeLayout(False)
        CType(Me.dgvPtoVta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrmClientes.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        Me.bnfCardNros.ResumeLayout(False)
        Me.bnfCardNros.PerformLayout()
        Me.bnfCardTituloFrm.ResumeLayout(False)
        Me.bnfCardTituloFrm.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardDetalle.ResumeLayout(False)
        Me.bnfCardDetalle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents bnfCardList As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvPtoVta As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlFrmClientes As Panel
    Friend WithEvents bnfCardTituloFrm As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents txtIdNumeracion As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents bnfCardDetalle As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtPtoVta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNroRem As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNroRes As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNroNDX As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtNroNDC As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtNroNDB As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtNroNDA As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNroNCX As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtNroNCC As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNroNCB As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtNroNCA As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNroFacX As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNroFacC As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNroFacB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNroFacA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNroOrdCom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNroRec As TextBox
    Friend WithEvents bnfCardNros As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label6 As Label
End Class
