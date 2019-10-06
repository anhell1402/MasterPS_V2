Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Negocio

Public Class frmPermisos
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private Sub FrmPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstRoles As New Genericos()
        Dim obj As New GenericoBL(cadena, Datos.TipoGenerico.Rol)
        lstRoles = obj.Obtener()
        cmbRol.DataSource = lstRoles
        cmbRol.ValueMember = "IdGenerico"
        cmbRol.DisplayMember = "Descripcion"
        btnGuardar.Enabled = False
    End Sub

    Private Sub BtnObtenerPermisos_Click(sender As Object, e As EventArgs) Handles btnObtenerPermisos.Click
        btnGuardar.Enabled = True
        Dim gene As New Generico()
        Dim lst As New Menus()
        Dim obj As New MenuBL(cadena)
        gene.IdGenerico = Convert.ToInt32(cmbRol.SelectedValue)
        lst = obj.ObtenerDisplay(gene)
        For Each mn As Menu In lst
            If mn.IdPadre <> 0 Then
                lblMenuDisplay.Text += "             "
            End If
            lblMenuDisplay.Text += mn.Descripcion + vbNewLine
        Next
        'TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        'TableLayoutPanel1.ColumnCount = 2
        'TableLayoutPanel1.RowCount = lst.Count
        'TableLayoutPanel1.ColumnStyles(1).Width = 20
        'Dim cont As Integer = 0
        'Dim lbl As Label
        'For Each mn As Menu In lst
        '    lbl = New Label()
        '    lbl.Text = mn.Descripcion
        '    TableLayoutPanel1.Controls.Add(lbl, 0, cont)
        '    cont += 1
        'Next
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class
