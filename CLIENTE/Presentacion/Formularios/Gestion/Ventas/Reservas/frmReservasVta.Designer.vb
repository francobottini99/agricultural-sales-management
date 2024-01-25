<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReservasVta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservasVta))
        Me.bnfCardBotones = New Bunifu.Framework.UI.BunifuCards()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.bnfCardFec = New Bunifu.Framework.UI.BunifuCards()
        Me.txtFec = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumRes = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTE = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCtaCli = New System.Windows.Forms.TextBox()
        Me.txtIIBB = New System.Windows.Forms.Label()
        Me.txtRSCli = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDirec = New System.Windows.Forms.Label()
        Me.txtProv = New System.Windows.Forms.Label()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.bnfCardObs = New Bunifu.Framework.UI.BunifuCards()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.bnfElipQuitar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.bnfElipAgg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.bnfElipBorr = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElipCarg = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpElim = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnfElpGuar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpNuevo = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfElpCanc = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.dgvDetallePedido = New System.Windows.Forms.DataGridView()
        Me.bnfElpMod = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfCardInfoProv = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardTitulo = New Bunifu.Framework.UI.BunifuCards()
        Me.pbxTitulo = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pnlFrmRes = New System.Windows.Forms.Panel()
        Me.bnfCardNum = New Bunifu.Framework.UI.BunifuCards()
        Me.cmbPtoVta = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.bnfCardDet = New Bunifu.Framework.UI.BunifuCards()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.bnfElipEditar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bnfCardProv = New Bunifu.Framework.UI.BunifuCards()
        Me.bnfCardBotones.SuspendLayout()
        Me.bnfCardFec.SuspendLayout()
        Me.bnfCardObs.SuspendLayout()
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnfCardInfoProv.SuspendLayout()
        Me.bnfCardTitulo.SuspendLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrmRes.SuspendLayout()
        Me.bnfCardNum.SuspendLayout()
        Me.bnfCardDet.SuspendLayout()
        Me.bnfCardProv.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnfCardBotones
        '
        Me.bnfCardBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardBotones.BorderRadius = 5
        Me.bnfCardBotones.BottomSahddow = True
        Me.bnfCardBotones.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardBotones.Controls.Add(Me.btnEliminar)
        Me.bnfCardBotones.Controls.Add(Me.btnCancelar)
        Me.bnfCardBotones.Controls.Add(Me.btnNuevo)
        Me.bnfCardBotones.Controls.Add(Me.btnGuardar)
        Me.bnfCardBotones.Controls.Add(Me.btnModificar)
        Me.bnfCardBotones.LeftSahddow = False
        Me.bnfCardBotones.Location = New System.Drawing.Point(651, 741)
        Me.bnfCardBotones.Name = "bnfCardBotones"
        Me.bnfCardBotones.RightSahddow = True
        Me.bnfCardBotones.ShadowDepth = 20
        Me.bnfCardBotones.Size = New System.Drawing.Size(690, 74)
        Me.bnfCardBotones.TabIndex = 59
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
        Me.btnEliminar.Location = New System.Drawing.Point(559, 20)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 35)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "      Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(422, 20)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 35)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "      Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(15, 20)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 35)
        Me.btnNuevo.TabIndex = 10
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
        Me.btnGuardar.Location = New System.Drawing.Point(286, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 35)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "        Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.btnModificar.Location = New System.Drawing.Point(151, 20)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 35)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "      Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'bnfCardFec
        '
        Me.bnfCardFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardFec.BorderRadius = 5
        Me.bnfCardFec.BottomSahddow = True
        Me.bnfCardFec.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardFec.Controls.Add(Me.txtFec)
        Me.bnfCardFec.Controls.Add(Me.Label20)
        Me.bnfCardFec.Enabled = False
        Me.bnfCardFec.LeftSahddow = False
        Me.bnfCardFec.Location = New System.Drawing.Point(639, 41)
        Me.bnfCardFec.Name = "bnfCardFec"
        Me.bnfCardFec.RightSahddow = True
        Me.bnfCardFec.ShadowDepth = 20
        Me.bnfCardFec.Size = New System.Drawing.Size(167, 70)
        Me.bnfCardFec.TabIndex = 60
        '
        'txtFec
        '
        Me.txtFec.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFec.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFec.Location = New System.Drawing.Point(9, 32)
        Me.txtFec.MaxLength = 10
        Me.txtFec.Name = "txtFec"
        Me.txtFec.Size = New System.Drawing.Size(147, 25)
        Me.txtFec.TabIndex = 66
        Me.txtFec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LightGray
        Me.Label20.Location = New System.Drawing.Point(9, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(147, 18)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "FECHA"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(9, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 18)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "NRO RESERVA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumRes
        '
        Me.txtNumRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtNumRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumRes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumRes.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRes.ForeColor = System.Drawing.Color.DimGray
        Me.txtNumRes.Location = New System.Drawing.Point(9, 126)
        Me.txtNumRes.MaxLength = 255
        Me.txtNumRes.Name = "txtNumRes"
        Me.txtNumRes.ReadOnly = True
        Me.txtNumRes.Size = New System.Drawing.Size(147, 25)
        Me.txtNumRes.TabIndex = 78
        Me.txtNumRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(10, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "NRO CTA"
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
        'txtCtaCli
        '
        Me.txtCtaCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCtaCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtaCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaCli.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCtaCli.Location = New System.Drawing.Point(10, 30)
        Me.txtCtaCli.MaxLength = 5
        Me.txtCtaCli.Name = "txtCtaCli"
        Me.txtCtaCli.Size = New System.Drawing.Size(79, 30)
        Me.txtCtaCli.TabIndex = 60
        Me.txtCtaCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'txtRSCli
        '
        Me.txtRSCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtRSCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRSCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRSCli.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRSCli.ForeColor = System.Drawing.Color.DimGray
        Me.txtRSCli.Location = New System.Drawing.Point(95, 30)
        Me.txtRSCli.MaxLength = 255
        Me.txtRSCli.Name = "txtRSCli"
        Me.txtRSCli.ReadOnly = True
        Me.txtRSCli.Size = New System.Drawing.Size(515, 30)
        Me.txtRSCli.TabIndex = 62
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
        Me.Label10.Location = New System.Drawing.Point(7, 19)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(7, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 18)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "LOCALIDAD"
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
        'tmrLoad
        '
        Me.tmrLoad.Interval = 300
        '
        'bnfCardObs
        '
        Me.bnfCardObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardObs.BorderRadius = 5
        Me.bnfCardObs.BottomSahddow = True
        Me.bnfCardObs.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardObs.Controls.Add(Me.Label12)
        Me.bnfCardObs.Controls.Add(Me.txtObservaciones)
        Me.bnfCardObs.Enabled = False
        Me.bnfCardObs.LeftSahddow = False
        Me.bnfCardObs.Location = New System.Drawing.Point(11, 741)
        Me.bnfCardObs.Name = "bnfCardObs"
        Me.bnfCardObs.RightSahddow = True
        Me.bnfCardObs.ShadowDepth = 20
        Me.bnfCardObs.Size = New System.Drawing.Size(478, 74)
        Me.bnfCardObs.TabIndex = 84
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(8, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 16)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "OBSERVACIONES"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtObservaciones.Location = New System.Drawing.Point(8, 26)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(461, 40)
        Me.txtObservaciones.TabIndex = 99
        '
        'bnfElipQuitar
        '
        Me.bnfElipQuitar.ElipseRadius = 7
        Me.bnfElipQuitar.TargetControl = Me.btnQuitar
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitar.FlatAppearance.BorderSize = 0
        Me.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.White
        Me.btnQuitar.Image = Global.Presentacion.My.Resources.Resources.iconoQuitar1
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.Location = New System.Drawing.Point(1200, 98)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(118, 35)
        Me.btnQuitar.TabIndex = 65
        Me.btnQuitar.Text = "    Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'bnfElipAgg
        '
        Me.bnfElipAgg.ElipseRadius = 7
        Me.bnfElipAgg.TargetControl = Me.btnAgregar
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
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.IconoAgregar2
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(1200, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 35)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "     Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'bnfElipBorr
        '
        Me.bnfElipBorr.ElipseRadius = 7
        Me.bnfElipBorr.TargetControl = Me
        '
        'bnfElipCarg
        '
        Me.bnfElipCarg.ElipseRadius = 7
        Me.bnfElipCarg.TargetControl = Me
        '
        'bnfElpElim
        '
        Me.bnfElpElim.ElipseRadius = 7
        Me.bnfElpElim.TargetControl = Me.btnEliminar
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(95, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "RAZON SOCIAL"
        '
        'bnfElpGuar
        '
        Me.bnfElpGuar.ElipseRadius = 7
        Me.bnfElpGuar.TargetControl = Me.btnGuardar
        '
        'bnfElpNuevo
        '
        Me.bnfElpNuevo.ElipseRadius = 7
        Me.bnfElpNuevo.TargetControl = Me.btnNuevo
        '
        'bnfElpCanc
        '
        Me.bnfElpCanc.ElipseRadius = 7
        Me.bnfElpCanc.TargetControl = Me.btnCancelar
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.Red
        Me.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.Color.White
        Me.txtOrigen.Location = New System.Drawing.Point(991, 10)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(68, 25)
        Me.txtOrigen.TabIndex = 62
        Me.txtOrigen.Visible = False
        '
        'dgvDetallePedido
        '
        Me.dgvDetallePedido.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.dgvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePedido.Location = New System.Drawing.Point(10, 16)
        Me.dgvDetallePedido.Name = "dgvDetallePedido"
        Me.dgvDetallePedido.Size = New System.Drawing.Size(1176, 401)
        Me.dgvDetallePedido.TabIndex = 64
        '
        'bnfElpMod
        '
        Me.bnfElpMod.ElipseRadius = 7
        Me.bnfElpMod.TargetControl = Me.btnModificar
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
        Me.bnfCardInfoProv.Controls.Add(Me.Label11)
        Me.bnfCardInfoProv.Controls.Add(Me.txtDirec)
        Me.bnfCardInfoProv.Controls.Add(Me.txtProv)
        Me.bnfCardInfoProv.Enabled = False
        Me.bnfCardInfoProv.LeftSahddow = False
        Me.bnfCardInfoProv.Location = New System.Drawing.Point(11, 117)
        Me.bnfCardInfoProv.Name = "bnfCardInfoProv"
        Me.bnfCardInfoProv.RightSahddow = True
        Me.bnfCardInfoProv.ShadowDepth = 20
        Me.bnfCardInfoProv.Size = New System.Drawing.Size(622, 180)
        Me.bnfCardInfoProv.TabIndex = 60
        '
        'bnfCardTitulo
        '
        Me.bnfCardTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.BorderRadius = 0
        Me.bnfCardTitulo.BottomSahddow = True
        Me.bnfCardTitulo.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bnfCardTitulo.Controls.Add(Me.pbxTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.lblTitulo)
        Me.bnfCardTitulo.Controls.Add(Me.txtOrigen)
        Me.bnfCardTitulo.Controls.Add(Me.pbxSalir)
        Me.bnfCardTitulo.LeftSahddow = False
        Me.bnfCardTitulo.Location = New System.Drawing.Point(0, 0)
        Me.bnfCardTitulo.Name = "bnfCardTitulo"
        Me.bnfCardTitulo.RightSahddow = True
        Me.bnfCardTitulo.ShadowDepth = 20
        Me.bnfCardTitulo.Size = New System.Drawing.Size(1352, 35)
        Me.bnfCardTitulo.TabIndex = 55
        '
        'pbxTitulo
        '
        Me.pbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTitulo.Image = Global.Presentacion.My.Resources.Resources.IconoPedido
        Me.pbxTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbxTitulo.Name = "pbxTitulo"
        Me.pbxTitulo.Size = New System.Drawing.Size(35, 35)
        Me.pbxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxTitulo.TabIndex = 87
        Me.pbxTitulo.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(45, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(975, 35)
        Me.lblTitulo.TabIndex = 86
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'pnlFrmRes
        '
        Me.pnlFrmRes.AutoScroll = True
        Me.pnlFrmRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlFrmRes.Controls.Add(Me.bnfCardProv)
        Me.pnlFrmRes.Controls.Add(Me.bnfCardNum)
        Me.pnlFrmRes.Controls.Add(Me.bnfCardObs)
        Me.pnlFrmRes.Controls.Add(Me.bnfCardBotones)
        Me.pnlFrmRes.Controls.Add(Me.bnfCardFec)
        Me.pnlFrmRes.Controls.Add(Me.bnfCardInfoProv)
        Me.pnlFrmRes.Controls.Add(Me.bnfCardDet)
        Me.pnlFrmRes.Controls.Add(Me.bnfCardTitulo)
        Me.pnlFrmRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrmRes.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrmRes.Name = "pnlFrmRes"
        Me.pnlFrmRes.Size = New System.Drawing.Size(1352, 827)
        Me.pnlFrmRes.TabIndex = 60
        '
        'bnfCardNum
        '
        Me.bnfCardNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardNum.BorderRadius = 5
        Me.bnfCardNum.BottomSahddow = True
        Me.bnfCardNum.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardNum.Controls.Add(Me.cmbPtoVta)
        Me.bnfCardNum.Controls.Add(Me.Label21)
        Me.bnfCardNum.Controls.Add(Me.txtNumRes)
        Me.bnfCardNum.Controls.Add(Me.Label3)
        Me.bnfCardNum.Enabled = False
        Me.bnfCardNum.LeftSahddow = False
        Me.bnfCardNum.Location = New System.Drawing.Point(639, 117)
        Me.bnfCardNum.Name = "bnfCardNum"
        Me.bnfCardNum.RightSahddow = True
        Me.bnfCardNum.ShadowDepth = 20
        Me.bnfCardNum.Size = New System.Drawing.Size(167, 180)
        Me.bnfCardNum.TabIndex = 109
        '
        'cmbPtoVta
        '
        Me.cmbPtoVta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmbPtoVta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPtoVta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmbPtoVta.FormattingEnabled = True
        Me.cmbPtoVta.ItemHeight = 20
        Me.cmbPtoVta.Location = New System.Drawing.Point(9, 55)
        Me.cmbPtoVta.Name = "cmbPtoVta"
        Me.cmbPtoVta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPtoVta.Size = New System.Drawing.Size(147, 28)
        Me.cmbPtoVta.TabIndex = 106
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LightGray
        Me.Label21.Location = New System.Drawing.Point(9, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 18)
        Me.Label21.TabIndex = 91
        Me.Label21.Text = "PTO. DE VTA."
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnfCardDet
        '
        Me.bnfCardDet.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardDet.BorderRadius = 5
        Me.bnfCardDet.BottomSahddow = True
        Me.bnfCardDet.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardDet.Controls.Add(Me.btnEditar)
        Me.bnfCardDet.Controls.Add(Me.btnQuitar)
        Me.bnfCardDet.Controls.Add(Me.btnAgregar)
        Me.bnfCardDet.Controls.Add(Me.dgvDetallePedido)
        Me.bnfCardDet.Enabled = False
        Me.bnfCardDet.LeftSahddow = False
        Me.bnfCardDet.Location = New System.Drawing.Point(11, 303)
        Me.bnfCardDet.Name = "bnfCardDet"
        Me.bnfCardDet.RightSahddow = True
        Me.bnfCardDet.ShadowDepth = 20
        Me.bnfCardDet.Size = New System.Drawing.Size(1330, 430)
        Me.bnfCardDet.TabIndex = 83
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = Global.Presentacion.My.Resources.Resources.IconoEditar3
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(1200, 57)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(118, 35)
        Me.btnEditar.TabIndex = 66
        Me.btnEditar.Text = "    Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'bnfElipEditar
        '
        Me.bnfElipEditar.ElipseRadius = 7
        Me.bnfElipEditar.TargetControl = Me.btnEditar
        '
        'bnfCardProv
        '
        Me.bnfCardProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bnfCardProv.BorderRadius = 5
        Me.bnfCardProv.BottomSahddow = True
        Me.bnfCardProv.color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bnfCardProv.Controls.Add(Me.Label1)
        Me.bnfCardProv.Controls.Add(Me.txtRSCli)
        Me.bnfCardProv.Controls.Add(Me.txtCtaCli)
        Me.bnfCardProv.Controls.Add(Me.Label2)
        Me.bnfCardProv.Enabled = False
        Me.bnfCardProv.LeftSahddow = False
        Me.bnfCardProv.Location = New System.Drawing.Point(11, 41)
        Me.bnfCardProv.Name = "bnfCardProv"
        Me.bnfCardProv.RightSahddow = True
        Me.bnfCardProv.ShadowDepth = 20
        Me.bnfCardProv.Size = New System.Drawing.Size(622, 70)
        Me.bnfCardProv.TabIndex = 110
        '
        'frmReservasVta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 827)
        Me.Controls.Add(Me.pnlFrmRes)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReservasVta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReservasVta"
        Me.bnfCardBotones.ResumeLayout(False)
        Me.bnfCardFec.ResumeLayout(False)
        Me.bnfCardFec.PerformLayout()
        Me.bnfCardObs.ResumeLayout(False)
        Me.bnfCardObs.PerformLayout()
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnfCardInfoProv.ResumeLayout(False)
        Me.bnfCardInfoProv.PerformLayout()
        Me.bnfCardTitulo.ResumeLayout(False)
        Me.bnfCardTitulo.PerformLayout()
        CType(Me.pbxTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrmRes.ResumeLayout(False)
        Me.bnfCardNum.ResumeLayout(False)
        Me.bnfCardNum.PerformLayout()
        Me.bnfCardDet.ResumeLayout(False)
        Me.bnfCardProv.ResumeLayout(False)
        Me.bnfCardProv.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bnfCardBotones As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents bnfCardFec As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumRes As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtFec As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTE As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCtaCli As TextBox
    Friend WithEvents txtIIBB As Label
    Friend WithEvents txtRSCli As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCuit As Label
    Friend WithEvents txtLoc As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDirec As Label
    Friend WithEvents txtProv As Label
    Friend WithEvents btnQuitar As Button
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents bnfCardObs As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label12 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents bnfElipQuitar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipAgg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnAgregar As Button
    Friend WithEvents bnfElipBorr As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlFrmRes As Panel
    Friend WithEvents bnfCardInfoProv As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents bnfCardDet As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvDetallePedido As DataGridView
    Friend WithEvents bnfCardTitulo As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents bnfElipCarg As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpElim As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpGuar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpNuevo As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpCanc As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElpMod As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bnfElipEditar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pbxTitulo As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents bnfCardNum As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents cmbPtoVta As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents bnfCardProv As Bunifu.Framework.UI.BunifuCards
End Class
