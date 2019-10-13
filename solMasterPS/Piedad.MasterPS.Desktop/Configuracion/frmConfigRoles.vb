Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio
Public Class frmConfigRoles
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private mensajeError As String = String.Empty
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmConfigRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRol.Visible = False
        txtRoles.Visible = False
        btnAgregar.Visible = False
        btnNuevo.Enabled = True
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
        LlenarDgv()
    End Sub
    Private Sub LlenarDgv()
        Dim tipo As TipoGenerico
        tipo = TipoGenerico.Rol

        Dim obj As New GenericoBL(cadena, tipo)
        Dim lst As New Genericos()
        lst = obj.Obtener()
        dgvRol.DataSource = lst
        If lst.Count > 0 Then
            dgvRol.Rows(0).Selected = False
        End If
        dgvRol.Columns(0).Visible = False
        dgvRol.Columns(2).Visible = False
        dgvRol.Columns(3).Visible = False
        dgvRol.Columns(4).Visible = False
    End Sub
    Public Sub LimpiarCampos()
        txtRoles.Clear()
    End Sub

    Private Sub DgvRol_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRol.CellDoubleClick
        Dim fila As DataGridViewRow = dgvRol.Rows(e.RowIndex)
        lblIdRol.Text = Convert.ToInt32(fila.Cells(0).Value)
        txtRoles.Text = Convert.ToString(fila.Cells(1).Value)

        lblRol.Visible = True
        txtRoles.Visible = True
        btnAgregar.Visible = False

        btnNuevo.Enabled = False
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        lblRol.Visible = True
        txtRoles.Visible = True
        btnAgregar.Visible = True
        txtRoles.Focus()
    End Sub
    Private Function Valida() As Boolean
        Dim correcto As Boolean = False
        Dim tipo As TipoGenerico
        tipo = TipoGenerico.Rol
        If (txtRoles.Text.Trim() <> String.Empty) Then
            correcto = True
        Else
            correcto = False
            mensajeError = "Especifique un rol en el campo vacío."
        End If
        Return correcto
    End Function
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim tipo As TipoGenerico
        tipo = TipoGenerico.Rol
        If Not Valida() Then
            Dim msg As New frmVentanaAviso(TipoVentana.AdvertenciaError, mensajeError, "Advertencia")
            msg.ShowDialog()
        Else
            Dim gen As New Generico()
            gen.Descripcion = txtRoles.Text.Trim()
            Dim obj As New GenericoBL(cadena, tipo)
            obj.Almacenar(gen)

            LimpiarCampos()
            LlenarDgv()
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim tipo As TipoGenerico
        tipo = TipoGenerico.Rol
        If Not Valida() Then
            Dim msg As New frmVentanaAviso(TipoVentana.AdvertenciaError, mensajeError, "Advertencia")
            msg.ShowDialog()
        Else
            Dim gen As New Generico()
            gen.IdGenerico = Convert.ToInt32(lblIdRol.Text)
            gen.Descripcion = txtRoles.Text.Trim()

            Dim obj As New GenericoBL(cadena, tipo)
            obj.Actualizar(gen)

            LimpiarCampos()
            LlenarDgv()
            lblRol.Visible = False
            txtRoles.Visible = False
            btnNuevo.Enabled = True
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim tipo As TipoGenerico
        tipo = TipoGenerico.Rol
        Dim gen As New Generico()
        gen.IdGenerico = Convert.ToInt32(lblIdRol.Text)
        Dim obj As New GenericoBL(cadena, tipo)
        Dim frm As New frmVentanaAviso(TipoVentana.Pregunta, "¿Está seguro que desea eliminar?", "Aviso")
        frm.ShowDialog()
        If (frm.Respuesta = RespuestaVentana.Si) Then
            obj.Eliminar(gen)
            Me.DialogResult = DialogResult.Cancel
            LimpiarCampos()
            LlenarDgv()
            lblRol.Visible = False
            txtRoles.Visible = False
            btnNuevo.Enabled = True
        End If
    End Sub
End Class