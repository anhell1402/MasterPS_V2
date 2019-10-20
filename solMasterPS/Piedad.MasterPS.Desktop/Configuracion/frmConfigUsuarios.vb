Imports System.Configuration
Imports System.IO
Imports System.Text
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio
Imports Piedad.MasterPS.Utilerias

Public Class frmConfigUsuarios
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private mensajeError As String = String.Empty
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub LlenarTipoRol()
        Dim obj As New GenericoBL(cadena, TipoGenerico.Rol)
        Dim lst As New Genericos()

        lst = obj.Obtener()
        cmbRol.DataSource = lst
        cmbRol.ValueMember = "IdGenerico"
        cmbRol.DisplayMember = "Descripcion"
    End Sub
    Private Sub LlenarTipoTel()
        Dim obj As New GenericoBL(cadena, TipoGenerico.TipoTelefono)
        Dim lst As New Genericos()
        lst = obj.Obtener()
        cmbTipoTelefono.DataSource = lst
        cmbTipoTelefono.ValueMember = "IdGenerico"
        cmbTipoTelefono.DisplayMember = "Descripcion"
    End Sub
    Private Sub LlenarSucursal()
        Dim idSuc As String
        Dim suc As String
        Dim obj As New SucursalBL(cadena)
        Dim lst As New Sucursales()
        lst = obj.Obtener()
        cmbSucursal.DataSource = lst
        cmbSucursal.ValueMember = "IdSucursal"
        cmbSucursal.DisplayMember = "Nick"
        idSuc = ObtenerSucursalLocal(False)
        suc = ObtenerSucursalLocal(True)
        cmbSucursal.Text = suc
        lblSucursalID.Text = idSuc
        cmbSucursal.Enabled = False
    End Sub
    Private Sub FrmConfigUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTipoRol()
        LlenarTipoTel()
        LlenarSucursal()
        LlenarGV()
    End Sub


    Private Function ObtenerSucursalLocal(ByVal id As Boolean) As String
        Dim suc As String = String.Empty
        Dim path As String = "C:\masterps\config\"
        If IO.Directory.Exists(path) Then
            If IO.File.Exists(path + "suc.conf") Then
                Dim reader As New StreamReader(path + "suc.conf", Encoding.Default)
                Dim a As String
                Do
                    a = reader.ReadLine
                    If a IsNot Nothing Then
                        Try
                            Dim uncode As String
                            If id Then
                                uncode = Protection.Decrypt(a).Split("|")(1)
                            Else
                                uncode = Protection.Decrypt(a).Split("|")(2)
                            End If
                            suc = uncode
                        Catch ex As Exception
                            suc = String.Empty
                        End Try
                    End If
                Loop Until a Is Nothing
                reader.Close()
            End If
        End If
        Return suc
    End Function

    Private Sub LlenarGV()
        Dim lst As Usuarios
        Dim suc As New Usuario()
        suc.IdSucursal.IdSucursal = Convert.ToInt32(ObtenerSucursalLocal(False))
        Dim obj As New UsuarioBL(cadena)
        lst = obj.ObtenerTodos(suc)
        dgvUsuarios.DataSource = lst
        dgvUsuarios.Columns(0).Visible = False 'idUsuario
        dgvUsuarios.Columns(4).Visible = False
        dgvUsuarios.Columns(8).Visible = False
        dgvUsuarios.Columns(10).Visible = False
        dgvUsuarios.Columns(11).Visible = False
        dgvUsuarios.Columns(12).Visible = False
        dgvUsuarios.Columns(13).Visible = False
        dgvUsuarios.ClearSelection()
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Function Valida() As Boolean
        Dim correcto As Boolean = False
        Dim mensaje As String = String.Empty
        If txtAmaterno.Text.Trim() <> String.Empty And txtApaterno.Text.Trim() <> String.Empty And txtNombre.Text.Trim() <> String.Empty Then
            If txtCorreo.Text.Trim() <> String.Empty Then
                If txtTelefono.Text.Trim() <> String.Empty Then
                    If txtUsuario.Text.Trim() <> String.Empty Then
                        correcto = True
                    Else
                        mensaje = "El nombre de usuario es obligatorio."
                    End If
                Else
                    mensaje = "El número de teléfono es obligatorio."
                End If
            Else
                mensaje = "El correo electrónico es obligatorio."
            End If
        Else
            mensaje = "El nombre, apellido paterno y apellido materno, son obligatorios."
        End If
        If Not correcto Then
            Dim frm As New frmVentanaAviso(TipoVentana.AdvertenciaError, mensaje, "Error")
            frm.ShowDialog()
        End If
        Return correcto
    End Function

    Private Sub Limpiar()
        txtAmaterno.Text = String.Empty
        txtApaterno.Text = String.Empty
        txtCorreo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtTelefono.Text = String.Empty
        txtUsuario.Text = String.Empty
        cmbRol.SelectedIndex = 0
        cmbTipoTelefono.SelectedIndex = 0
    End Sub
    Private Sub GuardarInfo(ByVal nuevo As Boolean)
        If Valida() Then
            Dim user As New Usuario()
            Dim obj As New UsuarioBL(cadena)
            Dim mensaje As String
            Dim titulo As String = "Aviso"
            Dim tipo As TipoVentana
            user.Nombre = txtNombre.Text.Trim()
            user.Apaterno = txtApaterno.Text.Trim()
            user.Amaterno = txtAmaterno.Text.Trim()
            user.IdTelefono.Descripcion = txtTelefono.Text.Trim()
            user.IdRol.IdGenerico = Convert.ToInt32(cmbRol.SelectedValue)
            user.Mail = txtCorreo.Text.Trim()
            user.SetIdTipoTelefono = Convert.ToInt32(cmbTipoTelefono.SelectedValue)
            user.Username = txtUsuario.Text.Trim()
            user.Password = Protection.Encrypt(user.Username)
            user.Status = Estatus.CambioPassword
            user.SetIdSucursal = Convert.ToInt32(ObtenerSucursalLocal(False))
            If nuevo Then
                obj.Almacenar(user)
            Else
                user.IdUsuario = Convert.ToInt32(lblIdusuario.Text)
                obj.Actualizar(user)
            End If
            If Not obj.HayError Then
                mensaje = "Información almacenada."
                tipo = TipoVentana.Aviso
                Limpiar()
                LlenarGV()
            Else
                mensaje = "Ocurrió un error: " & obj.MensajeError
                tipo = TipoVentana.AdvertenciaError
                titulo = "Error"
            End If
            Dim frm As New frmVentanaAviso(tipo, mensaje, titulo)
            frm.ShowDialog()
        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        GuardarInfo(True)
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        GuardarInfo(False)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim frm As New frmVentanaAviso(TipoVentana.Pregunta, "¿Está seguro que desea eliminar?", "Aviso")
        frm.ShowDialog()
        If (frm.Respuesta = RespuestaVentana.Si) Then
            Dim user As New Usuario()
            Dim obj As New UsuarioBL(cadena)
            user.IdUsuario = Convert.ToInt32(lblIdusuario.Text)
            user.SetIdSucursal = Convert.ToInt32(ObtenerSucursalLocal(False))
            obj.Eliminar(user)
            If obj.HayError Then
                Dim frm_ As New frmVentanaAviso(TipoVentana.AdvertenciaError, "Ocurrió un error: " & obj.MensajeError, "Error")
                frm_.ShowDialog()
            Else
                Limpiar()
                LlenarGV()
            End If
        End If
    End Sub

    Private Sub DgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            lblIdusuario.Text = dgvUsuarios.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim user As New Usuario()
            user.IdUsuario = Convert.ToInt32(lblIdusuario.Text)
            user.SetIdSucursal = Convert.ToInt32(ObtenerSucursalLocal(False))
            Dim obj As New UsuarioBL(cadena)
            user = obj.Obtener(user)
            txtAmaterno.Text = user.Amaterno
            txtApaterno.Text = user.Apaterno
            txtNombre.Text = user.Nombre
            txtCorreo.Text = user.Mail
            txtTelefono.Text = user.IdTelefono.Descripcion
            txtUsuario.Text = user.Username
            txtUsuario.ReadOnly = True
            cmbRol.Text = user.IdRol.Descripcion
            cmbTipoTelefono.Text = user.IdTipoTelefono.Descripcion
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Else
            txtUsuario.ReadOnly = False
        End If
    End Sub


    Private Function UsuarioSugerido() As String
        Dim user As String = String.Empty
        If txtAmaterno.Text.Trim() <> String.Empty And txtApaterno.Text.Trim() <> String.Empty And txtNombre.Text.Trim() <> String.Empty Then
            user = txtNombre.Text.Trim().Substring(0, 1).ToLower() & txtApaterno.Text.Trim().ToLower()
        Else
            Dim frm As New frmVentanaAviso(TipoVentana.AdvertenciaError, "El nombre, apellido paterno y apellido materno, son obligatorios.", "Error")
            frm.ShowDialog()
        End If
        Return user
    End Function

    Private Sub TxtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        txtUsuario.Text = UsuarioSugerido()
    End Sub
End Class