﻿Imports System.Runtime.InteropServices
Imports Piedad.MasterPS.Utilerias
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Negocio
Imports System.Configuration
Imports System.IO
Imports System.Text

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

    Private Sub Autenticar()
        If txtUser.Text.Trim() <> String.Empty And txtPass.Text.Trim() <> String.Empty Then
            Dim user As New Usuario()
            user.Username = txtUser.Text.Trim()
            user.Password = Protection.Encrypt(txtPass.Text.Trim())
            txtPass.Text = String.Empty
            Dim objDa As New AutenticacionBL(cadena)
            user = objDa.AutenciaUsuario(user)
            If (Not objDa.HayError) Then
                If user IsNot Nothing Then
                    If (user.IdUsuario <> -1) Then
                        ''Usuario autenticado                        
                        txtUser.Text = String.Empty
                        Me.Hide()
                        Dim frm As New frmPrincipal(user)
                        Dim result As DialogResult = frm.ShowDialog()
                        If (result = DialogResult.Cancel) Then
                            Me.Show()
                        End If
                        frm = Nothing
                    Else
                        Dim frmAviso As New frmVentanaAviso(TipoVentana.AdvertenciaError, "Usuario y/o contraseña incorrectos", "Error")
                        frmAviso.ShowDialog()

                    End If
                Else
                    Dim frmAviso As New frmVentanaAviso(TipoVentana.AdvertenciaError, "Usuario y/o contraseña incorrectos", "Error")
                    frmAviso.ShowDialog()
                End If
            Else
                Dim frmAviso As New frmVentanaAviso(TipoVentana.AdvertenciaError, "Usuario y/o contraseña incorrectos", "Error")
                frmAviso.ShowDialog()
            End If
        Else
            Dim frmAviso As New frmVentanaAviso(TipoVentana.AdvertenciaError, "Usuario y/o contraseña incorrectos", "Error")
            frmAviso.ShowDialog()
            Dim resp As RespuestaVentana = frmAviso.Respuesta
        End If
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'user: sa | pass: go
        Autenticar()
        'frmPrincipal.Show()
    End Sub

    Private Sub Txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ConfigOK() Then
            Me.Visible = False
            Dim frm As New FrmConfigInicial()
            Dim result As DialogResult = frm.ShowDialog()
            If result = DialogResult.Ignore Then
                ConfigOK()
                Me.Show()
            End If
        End If
    End Sub

    Private Sub LkOlvidaste_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkOlvidaste.LinkClicked
        Dim frm As New frmOlvidaPasswd()
        frm.ShowDialog()
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Autenticar()
        End If
    End Sub

    Private Function ConfigOK() As Boolean
        Dim ok As Boolean = False
        Dim path As String = "C:\masterps\config\"
        If IO.Directory.Exists(path) Then
            If IO.File.Exists(path + "suc.conf") Then
                Dim reader As New StreamReader(path + "suc.conf", Encoding.Default)
                Dim a As String
                Do
                    a = reader.ReadLine
                    If a IsNot Nothing Then
                        Try
                            Dim uncode As String = Protection.Decrypt(a).Split("|")(1)
                            lblSucursal.Text = uncode
                            ok = True
                        Catch ex As Exception
                            ok = False
                        End Try
                    End If
                Loop Until a Is Nothing
                reader.Close()
            End If
        End If
        Return ok
    End Function
End Class
