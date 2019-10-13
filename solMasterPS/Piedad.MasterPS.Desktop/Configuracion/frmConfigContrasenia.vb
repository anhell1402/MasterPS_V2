Public Class frmConfigContrasenia
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmConfigContrasenia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
    End Sub
End Class