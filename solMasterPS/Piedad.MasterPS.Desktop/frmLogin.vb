Public Class frmLogin
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Hide()
        Dim frm As New frmPrincipal()
        frm.ShowDialog()
    End Sub
End Class
