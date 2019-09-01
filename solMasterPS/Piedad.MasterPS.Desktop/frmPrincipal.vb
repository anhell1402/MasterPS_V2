Imports System.Runtime.InteropServices
Public Class frmPrincipal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Me.Close()
        Application.Exit()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If (MessageBox.Show("¿Está seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestarurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BtnRestarurar_Click(sender As Object, e As EventArgs) Handles btnRestarurar.Click
        btnRestarurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PnlHeader_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDoubleClick
        If (Me.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Normal
            btnMaximizar.Visible = True
            btnRestarurar.Visible = False
        Else
            Me.WindowState = FormWindowState.Maximized
            btnMaximizar.Visible = False
            btnRestarurar.Visible = True
        End If
    End Sub
End Class