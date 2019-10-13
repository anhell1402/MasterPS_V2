Imports System.Configuration
Imports System.Runtime.InteropServices
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Negocio

Public Class frmPrincipal
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Dim _user As Usuario
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub New(ByVal user As Usuario)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _user = user
        'Me.WindowState = FormWindowState.Maximized
    End Sub
#Region "FUNCIONALIDADES DEL FORMULARIO"
    'ARASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    'LLAMAR METODO EN EVENTO MOUSEMOVE DEL PANEL BARRA TITULO
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim frm As New frmVentanaAviso(TipoVentana.Pregunta, "¿Está seguro que desea salir?", "Aviso")
        frm.ShowDialog()
        If (frm.Respuesta = RespuestaVentana.Si) Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
        'If (MessageBox.Show("¿Está seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
        '    Me.DialogResult = DialogResult.Cancel
        '    Me.Close()
        'End If
        'Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer
    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub BtnSlide_Click(sender As Object, e As EventArgs) Handles btnSlide.Click
        If PanelMenu.Width = 250 Then
            PanelMenu.Width = 52
        Else
            PanelMenu.Width = 250
        End If
    End Sub

    Private Sub LogoSistema_MouseMove(sender As Object, e As MouseEventArgs) Handles logoSistema.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelFormularios_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelFormularios.MouseClick
        OcultarSubMenus()
    End Sub
    Public Sub OcultarSubMenus()
        PanelSubMenuEmpenio.Visible = False
        PanelSubMenuVenta.Visible = False
        PanelSubMenuInventario.Visible = False
        PanelSubMenuCallCenter.Visible = False
        PanelSubMenuHistorial.Visible = False
        PanelSubMenuCaja.Visible = False
        PanelSubMenuConfiguracion.Visible = False
        PanelSubMenuReportes.Visible = False
    End Sub
    Public WriteOnly Property Ocultar As Boolean
        Set(value As Boolean)
            PanelSubMenuEmpenio.Visible = value
            PanelSubMenuVenta.Visible = value
            PanelSubMenuInventario.Visible = value
            PanelSubMenuCallCenter.Visible = value
            PanelSubMenuHistorial.Visible = value
            PanelSubMenuCaja.Visible = value
            PanelSubMenuConfiguracion.Visible = value
            PanelSubMenuReportes.Visible = value
        End Set
    End Property
    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub
#End Region
    'METODO DE ABRIR FORMULARIO DENTRO DEL PANEL FORMULARIOS
    Private Sub AbrirFormularioEnPanel(Of MiForm As {Form, New})()
        Dim formulario As Form
        formulario = PanelFormularios.Controls.OfType(Of MiForm)().FirstOrDefault() 'Busca el Formulario en la coleccion
        'Si el formulario/instancia no existe
        If formulario Is Nothing Then
            formulario = New MiForm()
            formulario.TopLevel = False
            PanelFormularios.Controls.Add(formulario)
            PanelFormularios.Tag = formulario
            formulario.Size = New Size(PanelFormularios.Width, PanelFormularios.Height)
            formulario.Anchor = Anchor.Right Or Anchor.Left Or Anchor.Top Or Anchor.Bottom
            formulario.Show()
            formulario.BringToFront()
        Else
            'Si el formulario/instancia existe
            formulario.BringToFront()
        End If
    End Sub

    Private Sub OcultarSubMenus(ByVal idBtn As Integer)
        If idBtn <> 1 Then
            PanelSubMenuEmpenio.Visible = False
        End If
        If idBtn <> 2 Then
            PanelSubMenuVenta.Visible = False
        End If
        If idBtn <> 3 Then
            PanelSubMenuInventario.Visible = False
        End If
        If idBtn <> 4 Then
            PanelSubMenuCallCenter.Visible = False
        End If
        If idBtn <> 5 Then
            PanelSubMenuHistorial.Visible = False
        End If
        If idBtn <> 6 Then
            PanelSubMenuCaja.Visible = False
        End If
        If idBtn <> 7 Then
            PanelSubMenuReportes.Visible = False
        End If
        If idBtn <> 8 Then
            PanelSubMenuConfiguracion.Visible = False
        End If
    End Sub
    Private Sub BtnEmpenio_Click(sender As Object, e As EventArgs) Handles btnEmpenio.Click
        PanelSubMenuEmpenio.BringToFront()
        OcultarSubMenus(1)
        If Not PanelSubMenuEmpenio.Visible Then
            PanelSubMenuEmpenio.Visible = True
        Else
            PanelSubMenuEmpenio.Visible = False
        End If
    End Sub

    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        PanelSubMenuVenta.BringToFront()
        OcultarSubMenus(2)
        If Not PanelSubMenuVenta.Visible Then
            PanelSubMenuVenta.Visible = True
        Else
            PanelSubMenuVenta.Visible = False
        End If
    End Sub
    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        PanelSubMenuInventario.BringToFront()
        OcultarSubMenus(3)
        If Not PanelSubMenuInventario.Visible Then
            PanelSubMenuInventario.Visible = True
        Else
            PanelSubMenuInventario.Visible = False
        End If
    End Sub
    Private Sub BtnCallCenter_Click(sender As Object, e As EventArgs) Handles btnCallCenter.Click
        PanelSubMenuCallCenter.BringToFront()
        OcultarSubMenus(4)
        If Not PanelSubMenuCallCenter.Visible Then
            PanelSubMenuCallCenter.Visible = True
        Else
            PanelSubMenuCallCenter.Visible = False
        End If
    End Sub
    Private Sub BtnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        PanelSubMenuHistorial.BringToFront()
        OcultarSubMenus(5)
        If Not PanelSubMenuHistorial.Visible Then
            PanelSubMenuHistorial.Visible = True
        Else
            PanelSubMenuHistorial.Visible = False
        End If
    End Sub
    Private Sub BtnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        PanelSubMenuCaja.BringToFront()
        OcultarSubMenus(6)
        If Not PanelSubMenuCaja.Visible Then
            PanelSubMenuCaja.Visible = True
        Else
            PanelSubMenuCaja.Visible = False
        End If
    End Sub
    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        PanelSubMenuReportes.BringToFront()
        OcultarSubMenus(7)
        If Not PanelSubMenuReportes.Visible Then
            PanelSubMenuReportes.Visible = True
        Else
            PanelSubMenuReportes.Visible = False
        End If
    End Sub
    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles horaFecha.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString()
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub
    Private Sub BtnNuevoEmpeño_Click(sender As Object, e As EventArgs) Handles btnNuevoEmpenio.Click
        PanelSubMenuEmpenio.Visible = False
        AbrirFormularioEnPanel(Of frmEmpenio)()
    End Sub

    Private Sub BtnRefrendo_Click(sender As Object, e As EventArgs) Handles btnRefrendo.Click
        PanelSubMenuEmpenio.Visible = False
        AbrirFormularioEnPanel(Of frmRefrendo)()
    End Sub
    Private Sub OcultarPadres()
        btnEmpenio.Visible = False
        btnVenta.Visible = False
        btnInventario.Visible = False
        btnCallCenter.Visible = False
        btnHistorial.Visible = False
        btnCaja.Visible = False
        btnReportes.Visible = False
        btnConfiguracion.Visible = False
        btnSummary.Visible = False
    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaMenu()
    End Sub

    Private Sub BtnCatalogo_Click(sender As Object, e As EventArgs) Handles btnCatalogo.Click
        PanelSubMenuConfiguracion.Visible = False
        AbrirFormularioEnPanel(Of frmCatGenerico)()
    End Sub

    Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        PanelSubMenuConfiguracion.BringToFront()
        OcultarSubMenus(8)
        If Not PanelSubMenuConfiguracion.Visible Then
            PanelSubMenuConfiguracion.Visible = True
        Else
            PanelSubMenuConfiguracion.Visible = False
        End If
    End Sub

    Private Sub BtnPermisos_Click(sender As Object, e As EventArgs) Handles btnPermisos.Click
        PanelSubMenuConfiguracion.Visible = False
        AbrirFormularioEnPanel(Of frmConfigPermisos)()
    End Sub

    Private Sub PanelBarraTitulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseDoubleClick
        If WindowState = FormWindowState.Maximized Then
            'Me.WindowState = FormWindowState.Normal
            BtnRestaurar_Click(sender, e)
        Else
            'Me.WindowState = FormWindowState.Maximized
            BtnMaximizar_Click(sender, e)
        End If
    End Sub

    Private Sub BtnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        PanelSubMenuConfiguracion.Visible = False
        AbrirFormularioEnPanel(Of frmConfigRoles)()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        PanelSubMenuConfiguracion.Visible = False
        AbrirFormularioEnPanel(Of frmConfigUsuarios)()
    End Sub

    Private Sub CargaMenu()
        OcultarPadres()
        OcultarSubMenus()
        Dim lstMenu As New Menus()
        Dim obj As New MenuBL(cadena)
        lstMenu = obj.Obtener(_user.IdRol)
        Dim posY As Integer = 34
        For Each mn As Menu In lstMenu
            If mn.IdPadre = 0 Then
                For Each ct As Control In PanelMenu.Controls
                    If TypeOf ct Is Button Then
                        Dim btn As Button = CType(ct, Button)
                        If mn.Control.ToLower() = btn.Name.ToLower() Then
                            btn.Visible = True
                            btn.Location = New Point(0, posY)
                            Dim pnl As Panel = Me.Controls.Find(mn.PanelControl, True).FirstOrDefault()
                            pnl.Location = New Point(0, posY)
                            posY = posY + 35
                            CargaSubMenu(lstMenu, mn.PanelControl)
                            Exit For
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub CargaSubMenu(ByVal lstMenu As Menus, ByVal panelName As String)
        Dim lstBotones As New List(Of Button)
        Dim pnl As Panel = Me.Controls.Find(panelName, True).FirstOrDefault()
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.Visible = False
                If lstMenu.Find(Function(p) p.Control = btn.Name) IsNot Nothing Then
                    btn.Visible = True
                    lstBotones.Add(btn)
                End If
            End If
        Next
        Dim posY As Integer = 0
        Dim posX As Integer = 0
        Dim alto As Integer = 97
        Dim largo As Integer = 0
        Dim filas As Integer = 1
        Dim cantBtn As Integer = 0
        For Each mn As Menu In lstMenu
            Dim btn As Button = lstBotones.Find(Function(p) p.Name = mn.Control)
            If (btn IsNot Nothing) Then
                cantBtn += 1
                If (cantBtn > 4) Then
                    posX = 0
                    posY = posY + 97
                    cantBtn = 0
                    filas = filas + 1
                End If
                btn.Location = New Point(posX, posY)
                posX = posX + 135
                If filas > 1 Then
                    largo = 135 * 4
                Else
                    largo = posX
                End If

            End If
        Next
        pnl.Width = largo
        pnl.Height = alto * filas
        pnl.Visible = False
    End Sub
End Class

