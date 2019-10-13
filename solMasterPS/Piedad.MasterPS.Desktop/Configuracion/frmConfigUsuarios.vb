Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio
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
        Dim obj As New SucursalBL(cadena)
        Dim lst As New Sucursales()
        lst = obj.Obtener()
        cmbSucursal.DataSource = lst
        cmbSucursal.ValueMember = "IdSucursal"
        cmbSucursal.DisplayMember = "Nick"
    End Sub
    Private Sub FrmConfigUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTipoRol()
        LlenarTipoTel()
        LlenarSucursal()
    End Sub
End Class