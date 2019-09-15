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
        If (MessageBox.Show("¿Está seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
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

    Private Sub BtnEmpenio_Click(sender As Object, e As EventArgs) Handles btnEmpenio.Click
        PanelSubMenuVenta.Width = 0
        PanelSubMenuCatalogo.Width = 0
        PanelSubMenuCallCenter.Width = 0
        If PanelSubMenuEmpenio.Width = 0 Then
            PanelSubMenuEmpenio.Width = 405
        Else
            PanelSubMenuEmpenio.Width = 0
        End If
    End Sub

    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuCatalogo.Width = 0
        PanelSubMenuCallCenter.Width = 0
        If PanelSubMenuVenta.Width = 0 Then
            PanelSubMenuVenta.Width = 405
        Else
            PanelSubMenuVenta.Width = 0
        End If
    End Sub

    Private Sub BtnCatalogo_Click(sender As Object, e As EventArgs) Handles btnCatalogo.Click
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuVenta.Width = 0
        PanelSubMenuCallCenter.Width = 0
        If PanelSubMenuCatalogo.Width = 0 Then
            PanelSubMenuCatalogo.Width = 270
        Else
            PanelSubMenuCatalogo.Width = 0
        End If
    End Sub

    Private Sub BtnCallCenter_Click(sender As Object, e As EventArgs) Handles btnCallCenter.Click
        PanelSubMenuEmpenio.Width = 0
        PanelSubMenuVenta.Width = 0
        PanelSubMenuCatalogo.Width = 0
        If PanelSubMenuCallCenter.Width = 0 Then
            PanelSubMenuCallCenter.Width = 270
        End If
    End Sub
    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False

    End Sub
#End Region
    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormularioEnPanel(Of MiForm As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of MiForm)().FirstOrDefault() 'Busca el Fomrulario en la coleccion
        'Si form no fue encontrado / no existe
        If Formulario Is Nothing Then
            Formulario = New MiForm()
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            Formulario.Show()
        Else
            Formulario.BringToFront()
        End If
    End Sub
End Class