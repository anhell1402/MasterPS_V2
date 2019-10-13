Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio
Imports System.Runtime.InteropServices
Public Class frmModificarCliente
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private mensajeError As String = String.Empty
#Region "Movimiento del Formulario"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
#End Region
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class