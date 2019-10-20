Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio
Imports System.Runtime.InteropServices
Public Class frmSeleccionJoyeria
#Region "Movimiento del Formulario"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
#End Region
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private mensajeError As String = String.Empty

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub LblTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub LlenarMetal()
        If txtTipoEmpenio.Text = "JOYERIA" Then
            Dim obj As New GenericoBL(cadena, TipoGenerico.TipoEmpenio)
            Dim lst As New Genericos()
            lst = obj.Obtener()
            cmbTipoMetal.DataSource = lst
            cmbTipoMetal.ValueMember = "IdGenerico"
            cmbTipoMetal.DisplayMember = "Descripcion"
        End If
        If cmbTipoMetal.Text = "ORO" Then
            lblKilataje.Visible = True
            lblPureza.Visible = False
        Else
            lblKilataje.Visible = False
            lblPureza.Visible = True
        End If


    End Sub
    Private Sub FrmSeleccionJoyeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAltaJoyeria.Show()
    End Sub
End Class