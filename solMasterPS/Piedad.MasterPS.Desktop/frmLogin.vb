Imports System.Runtime.InteropServices
Imports Piedad.MasterPS.Utilerias
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Negocio
Imports System.Configuration

Public Class FrmLogin
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private Sub txtpass_MouseEnter(sender As Object, e As EventArgs) Handles txtPass.MouseEnter
        txtPass.PasswordChar = "*"
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Admin123.2019#
        If txtUser.Text.Trim() <> String.Empty And txtPass.Text.Trim() <> String.Empty Then
            Dim user As New Usuario()
            user.Username = txtUser.Text.Trim()
            user.Password = Protection.Encrypt(txtPass.Text.Trim())
            Dim objDa As New AutenticacionBL(cadena)
            user = objDa.AutenciaUsuario(user)
            If (Not objDa.HayError) Then
                If user IsNot Nothing Then
                    If (user.IdUsuario <> -1) Then
                        'Usuario autenticado
                        Me.Hide()
                        Dim frm As New frmPrincipal()
                        Dim result As DialogResult = frm.ShowDialog()
                        If (result = DialogResult.Cancel) Then
                            Me.Show()
                        End If
                        frm = Nothing
                    End If
                End If
            End If
        Else
        End If

        'frmPrincipal.Show()
    End Sub

    Private Sub Txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pass As String = Protection.Encrypt("Admin123.2019#")
        Dim i As Integer = 0
    End Sub

    Private Sub LkOlvidaste_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkOlvidaste.LinkClicked
        Dim frm As New frmOlvidaPasswd()
        frm.ShowDialog()
    End Sub
End Class
