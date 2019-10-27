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
    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub LblTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private mensajeError As String = String.Empty

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub FrmSeleccionJoyeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTipoMetal()
        LlenarEstado()
        LlenarPrenda()
    End Sub
    Private Sub LlenarTipoMetal()
        Dim gen As New Generico()
        gen.IdAuxiliarUno = 1 'Tipo de empeño = Joyeria
        Dim lst As New Genericos()
        Dim obj As New GenericoBL(cadena, TipoGenerico.TipoMercancia_Metal)
        lst = obj.ObtenerTodos(gen)
        cmbTipoMetal.DataSource = lst
        cmbTipoMetal.DisplayMember = "Descripcion"
        cmbTipoMetal.ValueMember = "IdGenerico"
    End Sub
    Private Sub LlenarEstado()
        Dim gen As New Generico()
        gen.IdAuxiliarUno = 1 'Tipo de empeño = Joyeria
        Dim lst As New Genericos()
        Dim obj As New GenericoBL(cadena, TipoGenerico.Marca_EstadoMetal)
        lst = obj.ObtenerTodos(gen)
        cmbEstado.DataSource = lst
        cmbEstado.DisplayMember = "Descripcion"
        cmbEstado.ValueMember = "IdGenerico"
    End Sub
    Private Sub LlenarPrenda()
        Dim lst As New Genericos()
        Dim obj As New GenericoBL(cadena, TipoGenerico.TipoPrendaOro)
        lst = obj.Obtener()
        cmbPrenda.DataSource = lst
        cmbPrenda.DisplayMember = "Descripcion"
        cmbPrenda.ValueMember = "IdGenerico"
    End Sub
    Private Sub LlenarKilataje(ByVal tipo As Generico)
        Dim lst As New Genericos()
        Dim obj As New GenericoBL(cadena, TipoGenerico.Familia_TipoKilataje)
        lst = obj.ObtenerTodos(tipo)
        cmbKilataje.DataSource = lst
        cmbKilataje.DisplayMember = "Descripcion"
        cmbKilataje.ValueMember = "IdGenerico"
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Cursor = Cursors.WaitCursor
        frmAltaJoyeria.Show()
    End Sub

    Private Sub CmbTipoMetal_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTipoMetal.SelectedValueChanged
        Dim gen As New Generico()
        gen = DirectCast(cmbTipoMetal.SelectedItem, Generico)
        If gen.IdGenerico = 1 Then
            lblKilataje.Text = "Kilataje"
        Else
            lblKilataje.Text = "Pureza"
        End If
        Dim gen2 As New Generico()
        gen2.IdAuxiliarUno = gen.IdGenerico
        'gen.IdAuxiliarUno = cmbTipoMetal.SelectedValue.ToString()
        LlenarKilataje(gen2)
        ObtenerPrecio()
    End Sub

    Private Sub CmbKilataje_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbKilataje.SelectedValueChanged
        ObtenerPrecio()
    End Sub

    Private Sub CmbEstado_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedValueChanged
        ObtenerPrecio()
    End Sub

    Private Sub CmbPrenda_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPrenda.SelectedValueChanged
        ObtenerPrecio()
    End Sub

    Private Sub ObtenerPrecio()

        Dim tipoMetal As New Generico()
        tipoMetal = DirectCast(cmbTipoMetal.SelectedItem, Generico)
        Dim kilataje As New Generico()
        kilataje = DirectCast(cmbKilataje.SelectedItem, Generico)
        Dim estado As New Generico()
        estado = DirectCast(cmbEstado.SelectedItem, Generico)
        If tipoMetal IsNot Nothing And kilataje IsNot Nothing Then


            If tipoMetal.IdGenerico > -1 And kilataje.IdGenerico > -1 Then
                If estado.IdGenerico > -1 Then


                    Dim detEmpenio As New DetalleEmpenio()
                    detEmpenio.Peso = Convert.ToDecimal(txtPesoPrenda.Text.Trim())
                    detEmpenio.NumeroPiedras = Convert.ToInt32(txtNumPiedras.Text.Trim())
                    detEmpenio.PesoPiedra = Convert.ToDecimal(txtPesoPiedras.Text.Trim())
                    Dim merca As New Mercancia()
                    merca.IdFamilia_TipoKilataje = kilataje
                    merca.IdMarca_EstadoMetal = estado
                    merca.IdTipoMercancia_Metal = tipoMetal
                    merca.IdSucursal.IdSucursal = Convert.ToInt32(General.ObtenerSucursalLocal(False))

                    Dim obj As New EmpenioBL(cadena)
                    Dim precio As String = obj.ObtenerPrecio(True, merca, detEmpenio).ToString("C")
                    If obj.HayError Then
                        Dim frm As New frmVentanaAviso(TipoVentana.AdvertenciaError, obj.MensajeError, "Error")
                        frm.ShowDialog()
                    Else
                        lblPrestamoMaxCantidad.Text = precio
                    End If
                End If
            Else
                lblPrestamoMaxCantidad.Text = "$ 0.00"
            End If
        End If
    End Sub



    Private Sub txtPesoPiedras_Leave(sender As Object, e As EventArgs) Handles txtPesoPiedras.Leave
        ObtenerPrecio()
    End Sub

    Private Sub txtPesoPrenda_Leave(sender As Object, e As EventArgs) Handles txtPesoPrenda.Leave
        ObtenerPrecio()
    End Sub

    Private Sub txtNumPiedras_Leave(sender As Object, e As EventArgs) Handles txtNumPiedras.Leave
        ObtenerPrecio()
    End Sub

    Private Sub txtNumPiedras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumPiedras.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub txtPesoPiedras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesoPiedras.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtPesoPrenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesoPrenda.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
End Class