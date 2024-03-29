﻿Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio
Imports Piedad.MasterPS.Utilerias
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text
Public Class frmAltaJoyeria
#Region "Movimiento del Fomrulario"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
#End Region
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private mensajeError As String = String.Empty
    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub LblTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Function ObtenerSucursalLocal(ByVal id As Boolean) As String
        Dim suc As String = String.Empty
        Dim path As String = "c:\masterps\config\"
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
    Private Sub LlenarTipoEmpenio()
        Dim tipo As TipoGenerico
        tipo = TipoGenerico.TipoEmpenio
        Dim obj As New GenericoBL(cadena, tipo)
        Dim lst As New Genericos()
        lst = obj.Obtener()
        lst.RemoveRange(2, 9)
        cmbTipoEmpenio.DataSource = lst
        cmbTipoEmpenio.ValueMember = "IdGenerico"
        cmbTipoEmpenio.DisplayMember = "Descripcion"

    End Sub
    Private Sub LlenarTipoMetal()
        cmbMetal.Enabled = True
        Dim tipo As TipoGenerico
        tipo = TipoGenerico.TipoMercancia_Metal
        Dim obj As New GenericoBL(cadena, tipo)
        Dim lst As New Genericos()
        lst = obj.Obtener()
        cmbMetal.DataSource = lst
        cmbMetal.ValueMember = "IdGenerico"
        cmbMetal.DisplayMember = "Descripcion"
        cmbMetal.Focus()
    End Sub
    Private Sub LlenarDGV()
        Dim idSuc As String
        idSuc = ObtenerSucursalLocal(False)

        Dim obj As New MercanciaBL(cadena)

        Dim lst As New List(Of Mercancias())
        dgvPrendas.DataSource = lst
        If lst.Count > 0 Then
            dgvPrendas.Rows(0).Selected = False
            dgvPrendas.Columns(6).Visible = False
        Else
            dgvPrendas.Enabled = False
        End If

    End Sub
    Private Function Valida() As Boolean
        Dim correcto As Boolean = False
        If (cmbMetal.Text.Trim() <> String.Empty) Or (txtTipoPrenda.Text.Trim() <> String.Empty) Or (txtKilatajePureza.Text.Trim() <> String.Empty) Or (txtEstadoPrenda.Text.Trim() <> String.Empty) Or (txtPrestamoMaximo.Text.Trim() <> String.Empty) Then
            correcto = True
        Else
            correcto = False
            mensajeError = "Complete los campos faltantes."
        End If
        Return correcto
    End Function
    Private Sub FrmAltaJoyeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEditar.Visible = False
        LlenarTipoEmpenio()
        LlenarTipoMetal()
        LlenarDGV()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class