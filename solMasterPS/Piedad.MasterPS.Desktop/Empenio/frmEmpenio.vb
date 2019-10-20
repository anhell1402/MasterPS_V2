Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio
Public Class frmEmpenio
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private mensajeError As String = String.Empty
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub LlenarTipoEmpenio()
        Dim obj As New GenericoBL(cadena, TipoGenerico.TipoEmpenio)
        Dim lst As New Genericos()
        lst = obj.Obtener()
        cmbTipoEmpenio.DataSource = lst
        cmbTipoEmpenio.ValueMember = "IdGenerico"
        cmbTipoEmpenio.DisplayMember = "Descripcion"
    End Sub
    Private Sub FrmEmpenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTipoEmpenio()
    End Sub

    Private Sub CmbTipoEmpenio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoEmpenio.SelectedIndexChanged
        If cmbTipoEmpenio.SelectedIndex = 1 Then
            Dim frm As New frmSeleccionJoyeria()
            frm.Show()
            frm.BringToFront()
            frm.txtTipoEmpenio.Text = Convert.ToString(Me.cmbTipoEmpenio.Text)
        ElseIf cmbTipoEmpenio.SelectedIndex = 2 Then
            Dim frm As New frmSeleccionMciasElectronicas
            frm.Show()
            frm.BringToFront()
            frm.txtTipoEmpenio.Text = Convert.ToString(Me.cmbTipoEmpenio.Text)
        ElseIf cmbTipoEmpenio.SelectedIndex = 4 Then
            Dim frm As New frmSeleccionVehiculo()
            frm.Show()
            frm.BringToFront()
            frm.txtTipoEmpenio.Text = Convert.ToString(Me.cmbTipoEmpenio.Text)
        End If
        LlenarTipoEmpenio()
    End Sub
End Class