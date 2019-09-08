Imports System.Runtime.InteropServices
Public Class FrmLogin
    Private Sub txtpass_MouseEnter(sender As Object, e As EventArgs) Handles txtpass.MouseEnter
        txtpass.PasswordChar = "*"
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmPrincipal.Show()
    End Sub

    Private Sub Txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        txtpass.PasswordChar = "*"
    End Sub
End Class
