Imports System.Runtime.InteropServices
Public Class frmPrincipal
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
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuVenta.Width = 0
        PanelSubMenuInventario.Width = 0
        PanelSubMenuCallCenter.Width = 0
        PanelSubMenuHistorial.Width = 0
        PanelSubMenuCaja.Width = 0
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False

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
            formulario.Anchor = Anchor.Right Or Anchor.Left Or Anchor.Top Or Anchor.Bottom
            formulario.Show()
            formulario.BringToFront()
        Else
            'Si el formulario/instancia existe
            formulario.BringToFront()
        End If
    End Sub
    Private Sub BtnEmpenio_Click(sender As Object, e As EventArgs) Handles btnEmpenio.Click
        PanelSubMenuEmpenio.BringToFront()
        PanelSubMenuVenta.Width = 0
        PanelSubMenuInventario.Width = 0
        PanelSubMenuCallCenter.Width = 0
        PanelSubMenuHistorial.Width = 0
        PanelSubMenuCaja.Width = 0
        PanelSubMenuReportes.Width = 0
        If PanelSubMenuEmpenio.Width = 0 Then
            PanelSubMenuEmpenio.Width = 540
        Else
            PanelSubMenuEmpenio.Width = 0
        End If
    End Sub

    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        PanelSubMenuVenta.BringToFront()
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuInventario.Width = 0
        PanelSubMenuCallCenter.Width = 0
        PanelSubMenuHistorial.Width = 0
        PanelSubMenuCaja.Width = 0
        PanelSubMenuReportes.Width = 0
        If PanelSubMenuVenta.Width = 0 Then
            PanelSubMenuVenta.Width = 540
        Else
            PanelSubMenuVenta.Width = 0
        End If
    End Sub
    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        PanelSubMenuInventario.BringToFront()
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuVenta.Width = 0
        PanelSubMenuCallCenter.Width = 0
        PanelSubMenuHistorial.Width = 0
        PanelSubMenuCaja.Width = 0
        PanelSubMenuReportes.Width = 0
        If PanelSubMenuInventario.Width = 0 Then
            PanelSubMenuInventario.Width = 586
        Else
            PanelSubMenuInventario.Width = 0
        End If
    End Sub
    Private Sub BtnCallCenter_Click(sender As Object, e As EventArgs) Handles btnCallCenter.Click
        PanelSubMenuCallCenter.BringToFront()
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuVenta.Width = 0
        PanelSubMenuInventario.Width = 0
        PanelSubMenuHistorial.Width = 0
        PanelSubMenuCaja.Width = 0
        PanelSubMenuReportes.Width = 0
        If PanelSubMenuCallCenter.Width = 0 Then
            PanelSubMenuCallCenter.Width = 270
        Else
            PanelSubMenuCallCenter.Width = 0
        End If
    End Sub
    Private Sub BtnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        PanelSubMenuHistorial.BringToFront()
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuVenta.Width = 0
        PanelSubMenuInventario.Width = 0
        PanelSubMenuCallCenter.Width = 0
        PanelSubMenuCaja.Width = 0
        PanelSubMenuReportes.Width = 0
        If PanelSubMenuHistorial.Width = 0 Then
            PanelSubMenuHistorial.Width = 540
        Else
            PanelSubMenuHistorial.Width = 0
        End If
    End Sub
    Private Sub BtnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        PanelSubMenuCaja.BringToFront()
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuVenta.Width = 0
        PanelSubMenuInventario.Width = 0
        PanelSubMenuCallCenter.Width = 0
        PanelSubMenuHistorial.Width = 0
        PanelSubMenuReportes.Width = 0
        If PanelSubMenuCaja.Width = 0 Then
            PanelSubMenuCaja.Width = 540
        Else
            PanelSubMenuCaja.Width = 0
        End If
    End Sub
    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        PanelSubMenuReportes.BringToFront()
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuVenta.Width = 0
        PanelSubMenuInventario.Width = 0
        PanelSubMenuCallCenter.Width = 0
        PanelSubMenuHistorial.Width = 0
        PanelSubMenuCaja.Width = 0
        If PanelSubMenuReportes.Width = 0 Then
            PanelSubMenuReportes.Width = 135
        Else
            PanelSubMenuReportes.Width = 0
        End If
    End Sub
    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles horaFecha.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString()
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub
    Private Sub BtnNuevoEmpeño_Click(sender As Object, e As EventArgs) Handles btnNuevoEmpeño.Click
        PanelSubMenuEmpenio.Width = 0
        AbrirFormularioEnPanel(Of frmEmpenio)()
    End Sub

    Private Sub BtnRefrendo_Click(sender As Object, e As EventArgs) Handles btnRefrendo.Click
        PanelSubMenuEmpenio.Width = 0
        AbrirFormularioEnPanel(Of frmRefrendo)()
    End Sub

End Class