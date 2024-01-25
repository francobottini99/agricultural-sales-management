Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports Procesos

Public Class frmPpal
    Private FrmAc As Form = Nothing
    Private actParidadCambiaria As Boolean

#Region "CAPTURA Y ARRASTRE PANTALLA CON MOUSE"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub pnlBarraFrm_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBarraFrm.MouseDown, lblTitulo.MouseDown
        ReleaseCapture()
        pbxMax.Visible = True
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Me.Size = New Size(1280, 768)
    End Sub

#End Region

#Region "EVENTO LOAD"
    Private Sub frmPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item As Screen In Screen.AllScreens
            If item.WorkingArea.Contains(Me.Location) Then
                Me.Size = item.WorkingArea.Size
                'MsgBox(item.WorkingArea.Size.ToString)
                Me.Location = item.WorkingArea.Location
                Me.MaximizedBounds = item.WorkingArea
                'bnfPanelMenu.Height = Me.Height - bnfPanelMenu.Top - bnfPanelPie.Height - 1
                pbxMax.Visible = False

                Exit For
            End If
        Next

        lblHoraSecundaria.Text = Date.Now.ToLongTimeString
        lblFechaSecundaria.Text = Date.Now.ToLongDateString

        bnfPanelMenu.AutoScroll = True
        bnfPanelMenu.HorizontalScroll.Visible = False

        CultureInfo.DefaultThreadCurrentCulture = New System.Globalization.CultureInfo("es-AR")
        CultureInfo.DefaultThreadCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        CultureInfo.DefaultThreadCurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        CultureInfo.DefaultThreadCurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        CultureInfo.DefaultThreadCurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        CultureInfo.DefaultThreadCurrentCulture.NumberFormat.NumberGroupSeparator = ","

        tmrLoad.Enabled = True
    End Sub

    Private Async Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Dim _TareasPerfilUs As New TareasPerfilUsuario
        Dim _TareasMonedas As New TareasMonedas

        Notificaciones.arbirFormProceso()

        DatosSesion._PerfilUs = Await _TareasPerfilUs.ConsultarPorId(DatosSesion._Usuario.AscPerfilUs.IdPerfil)
        DatosSesion._Monedas = Await _TareasMonedas.ListadoCompleto()

        If lblCat.Text <> "Super Usuario" Then
            If Not IsNothing(DatosSesion._PerfilUs) Then
                Notificaciones.cerrarFormProceso()
                Notificaciones.MsgBox(_TareasPerfilUs.Err.Descripcion, Botones.OK, Iconos.ERR)

                FinalizarSesion()
            End If
        End If

        If Not IsNothing(DatosSesion._Monedas) Then
            DatosSesion._MonedaPPal = TareasMonedas.FiltrarMonedaPpal(DatosSesion._Monedas)
            DatosSesion._MonedaContable = TareasMonedas.FiltrarMonedaContable(DatosSesion._Monedas)

            If IsNothing(DatosSesion._MonedaPPal) Or IsNothing(DatosSesion._MonedaContable) Then
                Notificaciones.MsgBox("No se cargaron correctamente las monedas, el sistema se cerrara !", Botones.OK, Iconos.ERR)

                FinalizarSesion()
            End If
        Else
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(_TareasMonedas.Err.Descripcion, Botones.OK, Iconos.ERR)

            FinalizarSesion()
        End If

        actualizarParidadCambiaria()

        AbrirFrm(frmInicio)

        Notificaciones.cerrarFormProceso()
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Async Sub FinalizarSesion()
        Notificaciones.arbirFormProceso("CERRANDO EL SISTEMA")

        Dim tareasUsuario As New TareasUsuario

        If Not Await tareasUsuario.FinalizarSesion(DatosSesion._Usuario) Then
            Notificaciones.cerrarFormProceso()
            Notificaciones.MsgBox(tareasUsuario.Err.Descripcion, Botones.OK, Iconos.ERR)
        End If

        Notificaciones.cerrarFormProceso()
        Application.Exit()
    End Sub

    Private Class Controles
        Public Sub New(nombre As String, x As Integer, y As Integer)
            _Nombre = nombre
            _X = x
            _Y = y
        End Sub

        Public Property Nombre As String
        Public Property X As Integer
        Public Property Y As Integer
    End Class

    Private posMouseAnt As Point = Nothing

    Private Sub Hora_Tick(sender As Object, e As EventArgs) Handles Hora.Tick
        Dim posMouseAct As Point = Cursor.Position()

        If posMouseAct <> posMouseAnt Then
            tmrVolver.Enabled = False
            tmrVolver.Enabled = True

            posMouseAnt = posMouseAct
        End If

        lblHoraSecundaria.Text = Date.Now.ToLongTimeString

        If lblHoraSecundaria.Text = "09:05:00" Or lblHoraSecundaria.Text = "10:05:00" Or lblHoraSecundaria.Text = "11:05:00" Or
           lblHoraSecundaria.Text = "12:05:00" Or lblHoraSecundaria.Text = "13:05:00" Or lblHoraSecundaria.Text = "14:05:00" Then
            actParidadCambiaria = True
        End If

        If actParidadCambiaria Then
            actualizarParidadCambiaria()
        End If
    End Sub

    Private Sub tmrVolver_Tick(sender As Object, e As EventArgs) Handles tmrVolver.Tick
        'If FrmAc IsNot frmInicio Then
        '    
        '    AbrirFrm(frmInicio)
        'End If
    End Sub

    Private Async Sub actualizarParidadCambiaria()
        actParidadCambiaria = False

        Dim TareaParidadCambiaria As New TareasParidadCamb

        DatosSesion._ListaParidadCambiaria = Await TareaParidadCambiaria.ListadoPorIdMoneda(DatosSesion._MonedaPPal.IdMonedas)

        If Not IsNothing(DatosSesion._ListaParidadCambiaria) Then
            DatosSesion._UltimaParidadCambiaria = DatosSesion._ListaParidadCambiaria.Last()
        Else
            Notificaciones.MsgBox(TareaParidadCambiaria.Err.Descripcion, Botones.OK, Iconos.ERR)
        End If
    End Sub

    Private Sub OcultarPaneles()
        pnlSistema.Visible = False
        pnlGestion.Visible = False
        pnlAltas.Visible = False
        pnlStock.Visible = False
        pnlConsultas.Visible = False
        pnlSeguridad.Visible = False
    End Sub

    Private Sub OcultarPanelesTerciarios()
        pnlCompras.Visible = False
        pnlVentas.Visible = False
        pnlCanjes.Visible = False
        pnlBancos.Visible = False
        pnlConsCompras.Visible = False
        pnlConsVentas.Visible = False
        pnlConsCanjes.Visible = False
        pnlConsCaja.Visible = False
    End Sub

    Private Sub ColoresBtnPrimarios()
        btnSistema.BackColor = Color.FromArgb(55, 55, 55)
        btnAltas.BackColor = Color.FromArgb(55, 55, 55)
        btnStock.BackColor = Color.FromArgb(55, 55, 55)
        btnConsultas.BackColor = Color.FromArgb(55, 55, 55)
        btnReportes.BackColor = Color.FromArgb(55, 55, 55)
        btnSeguridad.BackColor = Color.FromArgb(55, 55, 55)
        btnGestion.BackColor = Color.FromArgb(55, 55, 55)
    End Sub

    Private Sub ColoresBtnSecundarios()
        btnCompras.BackColor = Color.FromArgb(55, 55, 55)
        btnVentas.BackColor = Color.FromArgb(55, 55, 55)
        btnCanjes.BackColor = Color.FromArgb(55, 55, 55)
        btnCaja.BackColor = Color.FromArgb(55, 55, 55)
        btnBanco.BackColor = Color.FromArgb(55, 55, 55)
        btnConsCompras.BackColor = Color.FromArgb(55, 55, 55)
        btnConsVentas.BackColor = Color.FromArgb(55, 55, 55)
        btnChequera.BackColor = Color.FromArgb(55, 55, 55)
        btnConsCanjes.BackColor = Color.FromArgb(55, 55, 55)
        btnConsCaja.BackColor = Color.FromArgb(55, 55, 55)
    End Sub

    Private Sub ColoresBtnTerciarios()
        btnFacVta.BackColor = Color.FromArgb(55, 55, 55)
        btnRemVta.BackColor = Color.FromArgb(55, 55, 55)
    End Sub

    Private Sub AbrirSubMenu(ByVal Menu As Panel)
        OcultarPaneles()
        ColoresBtnPrimarios()
        OcultarPanelesTerciarios()
        ColoresBtnSecundarios()
        ColoresBtnTerciarios()

        Menu.Visible = True
    End Sub

    Private Sub AbrirTerciario(ByVal Menu As Panel)
        OcultarPanelesTerciarios()
        ColoresBtnSecundarios()
        ColoresBtnTerciarios()

        Menu.Visible = True
    End Sub

    Private Sub AbrirCuartario(ByVal Menu As Panel)
        ColoresBtnTerciarios()

        Menu.Visible = True
    End Sub

    Private Function verPermisos(ByVal mdl As Integer) As Boolean
        If lblCat.Text <> "Super Usuario" Then
            If DatosSesion._PerfilUs.Accesos(mdl) = False Then
                Notificaciones.MsgBox("No tienes acceso a este Modulo.", Botones.OK, Iconos.ERR)
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Function Modulos(ByVal btn As Button) As Integer
        Dim index As New Integer

        Select Case btn.Name
            Case "btnEmpresa"
                index = 0
            Case "btnMoneda"
                index = 1
            Case "btnComprobantes"
                index = 2
            Case "btnAlicuota"
                index = 3
            Case "btnUsuarios"
                index = 4
            Case "btnClientes"
                index = 5
            Case "btnProveedores"
                index = 6
            Case "btnArticulos"
                index = 7
            Case "btnCategorias"
                index = 8
            Case "btnBancos"
                index = 9
            Case "btnGastos"
                index = 10
            Case "btnDepositos"
                index = 11
            Case "btnRemCom"
                index = 12
            Case "btnFacCom"
                index = 13
            Case "btnNCCom"
                index = 14
            Case "btnNDCom"
                index = 15
            Case "btnOrdPago"
                index = 16
            Case "btnPedidos"
                index = 17
            Case "btnRemVta"
                index = 18
            Case "btnFacVta"
                index = 19
            Case "btnNCVta"
                index = 20
            Case "btnNDVta"
                index = 21
            Case "btnRecVta"
                index = 22
            Case "btnEmisionContratos"
                index = 23
            Case "btnFijacionContratos"
                index = 24
            Case "btnCartasPorte"
                index = 25
            Case "btnLiquidaciones"
                index = 26
            Case "btnManual"
                index = 27
            Case "btnAltaGastos"
                index = 28
            Case "btnChequera"
                index = 29
            Case "btnBcoDepositos"
                index = 30
            Case "btnBcoRetiros"
                index = 31
            Case "btnMantenimientoStock"
                index = 32
            Case "btnTransferenciasStock"
                index = 33
            Case "btnConsUsuarios"
                index = 34
            Case "btnConsClientes"
                index = 35
            Case "btnConsProv"
                index = 36
            Case "btnConsArticulos"
                index = 37
            Case "btnConsComRemito"
                index = 38
            Case "btnConsComFacturas"
                index = 39
            Case "btnConsComNotasCredito"
                index = 40
            Case "btnConsComNotasDebito"
                index = 41
            Case "btnConsNotasDebito"
                index = 42
            Case "btnConsVtaPedidos"
                index = 43
            Case "btnConsVtaRemitos"
                index = 44
            Case "btnConsVtaFacturas"
                index = 45
            Case "btnConsVtaNC"
                index = 46
            Case "btnConsVtaND"
                index = 47
            Case "btnConsStock"
                index = 48
            Case "btnConsContratos"
                index = 49
            Case "btnConsFiacionesCtos"
                index = 50
            Case "btnConsCartaPorte"
                index = 51
            Case "btnConsLiquidaciones"
                index = 52
            Case "btnConsArqueos"
                index = 53
            Case "btnConcCartera"
                index = 54
            Case "btnConsBancos"
                index = 55
            Case "btnRespaldo"
                index = 56
            Case "btnPerfilesUs"
                index = 57
            Case "btnRegistroRespaldo"
                index = 58
            Case "btnRegistroActividad"
                index = 59
        End Select

        Return index
    End Function

    Private Sub pbxUsuario_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbxUsuario.Paint
        Dim figura As GraphicsPath = New GraphicsPath
        Dim x, y, ancho, alto As Integer

        ancho = 260
        alto = 260

        x = (pbxUsuario.Width - ancho) / 2
        y = (pbxUsuario.Height - alto) / 2

        figura.AddEllipse(New Rectangle(x, y, ancho, alto))

        pbxUsuario.Region = New Region(figura)
    End Sub


#End Region

#Region "METODOS PUBLICOS"
    Public Sub AbrirFrm(ByVal FRM As Form)
        If Not IsNothing(FrmAc) Then
            FrmAc.Close()
        End If

        OcultarPaneles()
        OcultarPanelesTerciarios()

        ColoresBtnPrimarios()
        ColoresBtnSecundarios()
        ColoresBtnTerciarios()

        If pnlContenedor.Controls.Count > 0 Then
            pnlContenedor.Controls.RemoveAt(0)
        End If

        FrmAc = FRM
        FrmAc.TopLevel = False
        FrmAc.Dock = DockStyle.Fill
        FrmAc.Parent = pnlContenedor
        FrmAc.FormBorderStyle = FormBorderStyle.None
        pnlContenedor.Controls.Add(FrmAc)
        pnlContenedor.Tag = FrmAc

        UtilidadesVarias.Escalar(FrmAc, True)

        FrmAc.Show()
    End Sub


#End Region

#Region "EVENTOS CLICK"
    Private Sub pbxMin_Click(sender As Object, e As EventArgs) Handles pbxMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        FinalizarSesion()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FinalizarSesion()
    End Sub

    Private Sub pbxMax_Click(sender As Object, e As EventArgs) Handles pbxMax.Click
        For Each item As Screen In Screen.AllScreens
            If item.WorkingArea.Contains(Me.Location) Then
                Me.Size = item.WorkingArea.Size
                Me.Location = item.WorkingArea.Location
                Me.MaximizedBounds = item.WorkingArea
                pbxMax.Visible = False

                Exit For
            End If
        Next
    End Sub

    Private Sub pbxRest_Click(sender As Object, e As EventArgs) Handles pbxRest.Click
        Me.Size = New Size(1280, 768)
        Me.CenterToScreen()
        pbxMax.Visible = True
    End Sub

    Private Sub BtnSistema_Click(sender As Object, e As EventArgs) Handles btnSistema.Click
        If pnlSistema.Visible = False Then
            AbrirSubMenu(pnlSistema)
            btnSistema.BackColor = Color.FromArgb(95, 150, 15)
        Else
            pnlSistema.Visible = False

            ColoresBtnPrimarios()
            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnGestion_Click(sender As Object, e As EventArgs) Handles btnGestion.Click
        If pnlGestion.Visible = False Then
            AbrirSubMenu(pnlGestion)
            btnGestion.BackColor = Color.FromArgb(95, 150, 15)
        Else
            pnlGestion.Visible = False

            ColoresBtnPrimarios()
            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnAltas_Click(sender As Object, e As EventArgs) Handles btnAltas.Click
        If pnlAltas.Visible = False Then
            AbrirSubMenu(pnlAltas)
            btnAltas.BackColor = Color.FromArgb(95, 150, 15)
        Else
            pnlAltas.Visible = False

            ColoresBtnPrimarios()
            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        If pnlStock.Visible = False Then
            AbrirSubMenu(pnlStock)
            btnStock.BackColor = Color.FromArgb(95, 150, 15)
        Else
            pnlStock.Visible = False

            ColoresBtnPrimarios()
            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        If pnlConsultas.Visible = False Then
            AbrirSubMenu(pnlConsultas)
            btnConsultas.BackColor = Color.FromArgb(95, 150, 15)
        Else
            pnlConsultas.Visible = False

            ColoresBtnPrimarios()
            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnSeguridad_Click(sender As Object, e As EventArgs) Handles btnSeguridad.Click
        If pnlSeguridad.Visible = False Then
            AbrirSubMenu(pnlSeguridad)
            btnSeguridad.BackColor = Color.FromArgb(95, 150, 15)
        Else
            pnlSeguridad.Visible = False

            ColoresBtnPrimarios()
            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        If pnlCompras.Visible = False Then
            AbrirTerciario(pnlCompras)
            btnCompras.BackColor = Color.FromArgb(190, 140, 5)
        Else
            pnlCompras.Visible = False

            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        If pnlVentas.Visible = False Then
            AbrirTerciario(pnlVentas)
            btnVentas.BackColor = Color.FromArgb(190, 140, 5)
        Else
            pnlVentas.Visible = False

            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnCanjes_Click(sender As Object, e As EventArgs) Handles btnCanjes.Click
        If pnlCanjes.Visible = False Then
            AbrirTerciario(pnlCanjes)
            btnCanjes.BackColor = Color.FromArgb(190, 140, 5)
        Else
            pnlCanjes.Visible = False

            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnBanco_Click(sender As Object, e As EventArgs) Handles btnBanco.Click
        If pnlBancos.Visible = False Then
            AbrirTerciario(pnlBancos)
            btnBanco.BackColor = Color.FromArgb(190, 140, 5)
        Else
            pnlBancos.Visible = False

            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnConsCompras_Click(sender As Object, e As EventArgs) Handles btnConsCompras.Click
        If pnlConsCompras.Visible = False Then
            AbrirTerciario(pnlConsCompras)
            btnConsCompras.BackColor = Color.FromArgb(190, 140, 5)
        Else
            pnlConsCompras.Visible = False

            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnConsVentas_Click(sender As Object, e As EventArgs) Handles btnConsVentas.Click
        If pnlConsVentas.Visible = False Then
            AbrirTerciario(pnlConsVentas)
            btnConsVentas.BackColor = Color.FromArgb(190, 140, 5)
        Else
            pnlConsVentas.Visible = False

            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnConsCaja_Click(sender As Object, e As EventArgs) Handles btnConsCaja.Click
        If pnlConsCaja.Visible = False Then
            AbrirTerciario(pnlConsCaja)
            btnConsCaja.BackColor = Color.FromArgb(190, 140, 5)
        Else
            pnlConsCaja.Visible = False

            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub BtnConsCanjes_Click(sender As Object, e As EventArgs) Handles btnConsCanjes.Click
        If pnlConsCanjes.Visible = False Then
            AbrirTerciario(pnlConsCanjes)
            btnConsCanjes.BackColor = Color.FromArgb(190, 140, 5)
        Else
            pnlConsCanjes.Visible = False

            ColoresBtnSecundarios()
            ColoresBtnTerciarios()
        End If
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        If verPermisos(Modulos(btnUsuarios)) Then
            If FrmAc IsNot frmUsuarios Then
                AbrirFrm(frmUsuarios)
            End If
        End If
    End Sub

    Private Sub BtnPerfilesUs_Click(sender As Object, e As EventArgs) Handles btnPerfilesUs.Click
        If verPermisos(Modulos(btnPerfilesUs)) Then
            If FrmAc IsNot frmPerfilUs Then
                AbrirFrm(frmPerfilUs)
            End If
        End If
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        If verPermisos(Modulos(btnArticulos)) Then
            If FrmAc IsNot frmArticulos Then
                AbrirFrm(frmArticulos)
            End If
        End If
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        If verPermisos(Modulos(btnCaja)) Then
            If FrmAc IsNot frmCaja Then
                AbrirFrm(frmCaja)
            End If
        End If
    End Sub

    'Private Sub BtnMoneda_Click(sender As Object, e As EventArgs) Handles btnMoneda.Click
    '   If FrmAc IsNot frmMonedas Then
    '       AbrirFrm(frmMonedas)
    '   End If
    'End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        If verPermisos(Modulos(btnClientes)) Then
            If FrmAc IsNot frmClientes Then
                AbrirFrm(frmClientes)
            End If
        End If
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        If verPermisos(Modulos(btnProveedores)) Then
            If FrmAc IsNot frmProveedores Then
                AbrirFrm(frmProveedores)
            End If
        End If
    End Sub

    Private Sub BtnDepositos_Click(sender As Object, e As EventArgs) Handles btnDepositos.Click
        If verPermisos(Modulos(btnDepositos)) Then
            If FrmAc IsNot frmDeposito Then
                AbrirFrm(frmDeposito)
            End If
        End If
    End Sub

    Private Sub BtnBancos_Click(sender As Object, e As EventArgs) Handles btnBancos.Click
        If verPermisos(Modulos(btnBanco)) Then
            If FrmAc IsNot frmBancos Then
                AbrirFrm(frmBancos)
            End If
        End If
    End Sub

    Private Sub BtnRemCom_Click(sender As Object, e As EventArgs) Handles btnRemCom.Click
        If verPermisos(Modulos(btnRemCom)) Then
            If FrmAc IsNot frmRemitoCompra Then
                AbrirFrm(frmRemitoCompra)
            End If
        End If
    End Sub

    Private Sub BtnFacCom_Click(sender As Object, e As EventArgs) Handles btnFacCom.Click
        If verPermisos(Modulos(btnFacCom)) Then
            If FrmAc IsNot frmFacturaCompra Then
                AbrirFrm(frmFacturaCompra)
            End If
        End If
    End Sub

    Private Sub BtnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        If verPermisos(Modulos(btnPedidos)) Then
            If FrmAc IsNot frmReservasVta Then
                AbrirFrm(frmReservasVta)
            End If
        End If
    End Sub

    Private Sub BtnRemVta_Click(sender As Object, e As EventArgs) Handles btnRemVta.Click
        If verPermisos(Modulos(btnRemVta)) Then
            If FrmAc IsNot frmRemitoVenta Then
                AbrirFrm(frmRemitoVenta)
            End If
        End If
    End Sub

    Private Sub BtnFacVta_Click(sender As Object, e As EventArgs) Handles btnFacVta.Click
        If verPermisos(Modulos(btnFacVta)) Then
            If FrmAc IsNot frmFacturaVenta Then
                AbrirFrm(frmFacturaVenta)
            End If
        End If
    End Sub

    Private Sub BtnOrdPago_Click(sender As Object, e As EventArgs) Handles btnOrdPago.Click
        If verPermisos(Modulos(btnOrdPago)) Then
            If FrmAc IsNot frmOrdenPago Then
                AbrirFrm(frmOrdenPago)
            End If
        End If
    End Sub

    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
        If verPermisos(Modulos(btnEmpresa)) Then
            If FrmAc IsNot frmEmpresa Then
                AbrirFrm(frmEmpresa)
            End If
        End If
    End Sub

    Private Sub BtnComprobantes_Click(sender As Object, e As EventArgs) Handles btnComprobantes.Click
        If verPermisos(Modulos(btnComprobantes)) Then
            If FrmAc IsNot frmComprobantes Then
                AbrirFrm(frmComprobantes)
            End If
        End If
    End Sub

    Private Sub btnChequera_Click(sender As Object, e As EventArgs) Handles btnChequera.Click
        If verPermisos(Modulos(btnChequera)) Then
            If FrmAc IsNot frmChequeras Then
                AbrirFrm(frmChequeras)
            End If
        End If
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        If verPermisos(Modulos(btnCategorias)) Then
            If FrmAc IsNot frmcategorias Then
                AbrirFrm(frmcategorias)
            End If
        End If
    End Sub

    Private Sub btnCtasContables_Click(sender As Object, e As EventArgs) Handles btnCtasContables.Click

    End Sub

    Private Sub btnPtoVta_Click(sender As Object, e As EventArgs) Handles btnPtoVta.Click
        If verPermisos(Modulos(btnPtoVta)) Then
            If FrmAc IsNot frmPtoVta Then
                AbrirFrm(frmPtoVta)
            End If
        End If
    End Sub

    Private Sub btnRecVta_Click(sender As Object, e As EventArgs) Handles btnRecVta.Click
        If verPermisos(Modulos(btnRecVta)) Then
            If FrmAc IsNot frmReciboVenta Then
                AbrirFrm(frmReciboVenta)
            End If
        End If
    End Sub

    Private Sub btnConsVtaCuentaCorriente_Click(sender As Object, e As EventArgs) Handles btnConsVtaCuentaCorriente.Click
        If verPermisos(Modulos(btnConsVtaCuentaCorriente)) Then
            If FrmAc IsNot frmCtaCteVenta Then
                AbrirFrm(frmCtaCteVenta)
            End If
        End If
    End Sub

    Private Sub btnConsComCuentaCorriente_Click(sender As Object, e As EventArgs) Handles btnConsComCuentaCorriente.Click
        If verPermisos(Modulos(btnConsComCuentaCorriente)) Then
            If FrmAc IsNot frmCtaCteCompra Then
                AbrirFrm(frmCtaCteCompra)
            End If
        End If
    End Sub

    Private Sub btnDevolucionesVta_Click(sender As Object, e As EventArgs) Handles btnDevolucionesVta.Click
        If verPermisos(Modulos(btnDevolucionesVta)) Then
            If FrmAc IsNot frmDevoluciones Then
                AbrirFrm(frmDevoluciones)
            End If
        End If
    End Sub

#End Region

End Class
