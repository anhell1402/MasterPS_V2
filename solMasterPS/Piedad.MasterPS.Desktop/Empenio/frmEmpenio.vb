Public Class frmEmpenio
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmConfigContrasenia.Show()
    End Sub
End Class