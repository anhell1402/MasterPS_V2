Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Negocio
Imports Piedad.MasterPS.Datos

Public Class frmCatGenerico
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmCatGenerico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnActualizar.Enabled = False
        btnNuevo.Enabled = False
        btnEliminar.Enabled = False
        ComboBoxGenericos.Items.Insert(0, "-- Seleccione --")
        ComboBoxGenericos.Items.Insert(1, "Tipo de Telefono")
    End Sub
    Private Sub LlenarTodo()
        'btnNuevo.Enabled = True
        'Dim index As Integer
        'index = ComboBoxGenericos.SelectedIndex
        'Select Case index
        '    Case 0
        '        Exit Select
        '    Case 1
        '        tipo = TipoGenerico.TipoTelefono
        '        Exit Select
        '    Case 2
        '        Exit Select
        'End Select

        'Dim obj As New GenericoBL(cadena, tipo)
        'Dim lst As New Genericos()
        'lst = obj.Obtener()
        'DGVGenericos.DataSource = lst
    End Sub
    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        LlenarTodo()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim obj As Generico()
        LlenarTodo()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub
End Class