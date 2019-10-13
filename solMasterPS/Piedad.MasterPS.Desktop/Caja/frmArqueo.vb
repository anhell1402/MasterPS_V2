Public Class frmArqueo
    Private mensajeError As String = String.Empty
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub FrmArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt1000.Text = 0
        txt500.Text = 0
        txt200.Text = 0
        txt100.Text = 0
        txt50.Text = 0
        txt20.Text = 0
        txt10.Text = 0
        txt5.Text = 0
        txt2.Text = 0
        txt1.Text = 0
        txt050.Text = 0

        btnGuardar.Enabled = False
    End Sub
    Private Sub Conteo()
        txtR1000.Text = txt1000.Text * 1000
        txtR500.Text = txt500.Text * 500
        txtR200.Text = txt200.Text * 200
        txtR100.Text = txt100.Text * 100
        txtR50.Text = txt50.Text * 50
        txtR20.Text = txt20.Text * 20
        txtR10.Text = txt10.Text * 10
        txtR5.Text = txt5.Text * 5
        txtR2.Text = txt2.Text * 2
        txtR1.Text = txt1.Text * 1
        txtR050.Text = txt050.Text * 0.5
    End Sub
    Private Sub Totales()
        Dim suma As Decimal
        suma = Val(txtR1000.Text) + Val(txtR500.Text) + Val(txtR200.Text) + Val(txtR100.Text) + Val(txtR50.Text) + Val(txtR20.Text) + Val(txtR10.Text) + Val(txtR5.Text) + Val(txtR2.Text) + Val(txtR1.Text) + Val(txtR050.Text)
        txtTotal.Text = suma
    End Sub
    Private Function Valida() As Boolean
        Dim correcto As Boolean = False
        Dim caja As ValueType
        caja = 0
        If (txt1000.Text <> String.Empty) Then
            correcto = True
        Else
            correcto = False
            mensajeError = "Ingrese unicamente numeros."
        End If
        Return correcto
    End Function

    Private Sub Txt1000_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1000.KeyPress
        Conteo()
        Totales()
    End Sub
End Class