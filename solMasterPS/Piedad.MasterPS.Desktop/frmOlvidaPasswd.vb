Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Negocio
Imports System.Configuration
Imports System.Net
Imports System.Net.Mail
Imports System.Threading

Public Class frmOlvidaPasswd
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private Sub BtnObtenerPasswd_Click(sender As Object, e As EventArgs) Handles btnObtenerPasswd.Click
        If (txtMail.Text.Trim() <> String.Empty And txtUser.Text.Trim() <> String.Empty) Then
            Dim user As New Usuario()
            user.Nombre = "Prueba"
            user.Apaterno = "usuario"
            user.Password = "MiSuperContraseñaSecreta"
            'user.Username = txtUser.Text.Trim()
            'user.Mail = txtMail.Text.Trim()
            'Dim obj As New AutenticacionBL(cadena)
            'user = obj.OlvidaPasswd(user)
            If (user IsNot Nothing) Then
                'If (user.IdUsuario <> -1) Then
                Dim message As String = String.Empty
                message += "Estimado " + user.Nombre + " " + user.Apaterno + vbNewLine + vbNewLine
                message += "Su clave de acceso es la siguiente: " + user.Password
                    Dim t As Thread = New Thread(New ThreadStart(Sub() hiloMail(message)))
                    t.Start()
                MessageBox.Show("Correo enviado")
                txtMail.Text = String.Empty
                txtUser.Text = String.Empty
                'End If
            End If



        End If

    End Sub
    Private Sub hiloMail(ByVal mess As String)
        Dim fromEmail As String = "test@masterPS.com"
        Dim mailMessage As MailMessage = New MailMessage(fromEmail, "richard_bob2@hotmail.com,anhell1402@gmail.com", "Password de acceso", mess)
        Dim smtpClient As SmtpClient = New SmtpClient("smtp.gmail.com", 587)
        smtpClient.EnableSsl = True
        smtpClient.UseDefaultCredentials = False
        smtpClient.Credentials = New NetworkCredential("anhell1402@gmail.com", "password")

        Try
            smtpClient.Send(mailMessage)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class