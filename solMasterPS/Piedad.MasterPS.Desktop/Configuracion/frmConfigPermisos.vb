Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Negocio
Public Class frmConfigPermisos
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private Sub frmConfigPermisos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Inicio()
    End Sub
    Private Sub Inicio()
        Dim lstRoles As New Genericos()
        Dim obj As New GenericoBL(cadena, Datos.TipoGenerico.Rol)
        lstRoles = obj.Obtener()
        cmbRol.DataSource = lstRoles
        cmbRol.ValueMember = "IdGenerico"
        cmbRol.DisplayMember = "Descripcion"
        btnGuardar.Enabled = False
        dgvMenuDisplay.DataSource = Nothing
    End Sub
    Private Sub BtnObtenerPermisos_Click(sender As Object, e As EventArgs) Handles btnObtenerPermisos.Click
        btnGuardar.Enabled = True
        Dim gene As New Generico()
        Dim lst As New Menus()
        Dim obj As New MenuBL(cadena)
        gene.IdGenerico = Convert.ToInt32(cmbRol.SelectedValue)
        lst = obj.ObtenerDisplay(gene)

        Dim dt As New DataTable()
        dt.Columns.Add("IdMenu", GetType(Integer))
        dt.Columns.Add("IdPadre", GetType(Integer))
        dt.Columns.Add("Menu", GetType(String))
        dt.Columns.Add("Permiso", GetType(String))
        For Each mn As Menu In lst
            If mn.IdPadre <> 0 Then
                If mn.Permiso > 0 Then
                    dt.Rows.Add(mn.IdMenu, mn.IdPadre, "                  " + mn.Descripcion, True)
                Else
                    dt.Rows.Add(mn.IdMenu, mn.IdPadre, "                  " + mn.Descripcion, False)
                End If
            Else
                dt.Rows.Add(mn.IdMenu, mn.IdPadre, mn.Descripcion, False)
            End If
        Next
        dgvMenuDisplay.DataSource = dt
        For Each row As DataGridViewRow In dgvMenuDisplay.Rows
            If Convert.ToInt32(dgvMenuDisplay.Rows(row.Index).Cells(1).Value) <> 0 Then
                dgvMenuDisplay.Rows(row.Index).Cells(3) = New DataGridViewCheckBoxCell()
            Else
                dgvMenuDisplay.Rows(row.Index).Cells(3).Value = ""
            End If
        Next

        dgvMenuDisplay.RowHeadersVisible = False
        dgvMenuDisplay.Columns(1).ReadOnly = True
        dgvMenuDisplay.Columns(0).Visible = False
        dgvMenuDisplay.Columns(1).Visible = False
        dgvMenuDisplay.Columns(2).Width = 300
        dgvMenuDisplay.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim lst As New Permisos()
        Dim obj As New PermisoBL(cadena)
        Dim idRol As Integer = Convert.ToInt32(cmbRol.SelectedValue)
        Dim rol As New Generico()
        Dim menu As Menu
        rol.IdGenerico = idRol
        Dim per As Permiso
        For Each row As DataGridViewRow In dgvMenuDisplay.Rows
            If Convert.ToInt32(dgvMenuDisplay.Rows(row.Index).Cells(1).Value) <> 0 Then
                Dim val As Boolean = Convert.ToBoolean(dgvMenuDisplay.Rows(row.Index).Cells(3).Value)
                Dim id As Integer = Convert.ToInt32(dgvMenuDisplay.Rows(row.Index).Cells(0).Value)
                If val Then
                    'MsgBox(dgvMenuDisplay.Rows(row.Index).Cells(2).Value)
                    per = New Permiso()
                    menu = New Menu()
                    menu.IdMenu = id
                    per.IdRol = rol
                    per.IdMenu = menu
                    lst.Add(per)
                End If
            End If
        Next
        obj.Actualizar(lst)
        Dim frm As New frmVentanaAviso(TipoVentana.Aviso, "Información almacenada", "Aviso")
        frm.ShowDialog()
        Inicio()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmConfigPermisos_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        'frmPrincipal.OcultarSubMenus()

    End Sub

    Private Sub frmConfigPermisos_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        'frmPrincipal.Ocultar = False

        'Me.BringToFront()
    End Sub
End Class