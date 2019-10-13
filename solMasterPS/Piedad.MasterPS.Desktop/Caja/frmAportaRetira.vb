Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio
Imports System.Runtime.InteropServices
Public Class frmAportaRetira
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private mensajeError As String = String.Empty
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class