Imports System.Runtime.InteropServices
Imports Piedad.MasterPS.Utilerias
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Negocio
Imports System.Configuration
Imports System.IO

Public Class FrmConfigInicial
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Application.Exit()
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
                        If user.IdRol.IdGenerico = 1 Then
                            'es usuario administrador
                            'guardar la info del archivo de configuracion
                            Dim path As String = "C:\masterps\config\"
                            Dim file As String = "suc.conf"
                            Dim fileExists As Boolean = IO.File.Exists(path + file)
                            Dim folderExists As Boolean = IO.Directory.Exists(path)
                            If Not folderExists Then
                                IO.Directory.CreateDirectory(path)
                            End If
                            Using sw As New StreamWriter(IO.File.Open(path + file, FileMode.OpenOrCreate))
                                sw.WriteLine(Protection.Encrypt(txtUser.Text.Trim() + "|" + cmbSucursal.Text + "|" + cmbSucursal.SelectedValue.ToString()))
                            End Using
                            Me.DialogResult = DialogResult.Ignore
                            Me.Close()
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
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lst As New Sucursales()
        Dim obj As New SucursalBL(cadena)
        lst = obj.Obtener()
        cmbSucursal.DataSource = lst
        cmbSucursal.DisplayMember = "Nombre"
        cmbSucursal.ValueMember = "IdSucursal"
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Autenticar()
        End If
    End Sub
End Class
