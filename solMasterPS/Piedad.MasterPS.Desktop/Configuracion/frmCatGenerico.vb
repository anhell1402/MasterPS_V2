Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio

Public Class frmCatGenerico
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmCatGenerico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDescripcion.Visible = False
        txtDescripcion.Visible = False
        lblAuxiliar1.Visible = False
        txtAuxiliarUno.Visible = False
        lblAuxiliar2.Visible = False
        cmbTipoEmpenio.Visible = False

        btnActualizar.Enabled = False
        btnNuevo.Enabled = False
        btnEliminar.Enabled = False
        ComboBoxGenericos.Items.Insert(0, "-- Seleccione un Opcion --")
        ComboBoxGenericos.Items.Insert(1, "Categoria / Metal")
        ComboBoxGenericos.Items.Insert(2, "Estado de la Venta")
        ComboBoxGenericos.Items.Insert(3, "Estado del Apartado")
        ComboBoxGenericos.Items.Insert(4, "Estado del Empeño")
        ComboBoxGenericos.Items.Insert(5, "Estado del Inventario")
        ComboBoxGenericos.Items.Insert(6, "Estado del Mensaje")
        ComboBoxGenericos.Items.Insert(7, "Familia / Kilataje")
        ComboBoxGenericos.Items.Insert(8, "Formas del Diamante")
        ComboBoxGenericos.Items.Insert(9, "Marca / Estado del Metal")
        ComboBoxGenericos.Items.Insert(10, "Medios de Enterado del Cliente")
        ComboBoxGenericos.Items.Insert(11, "Motivos del Checador")
        ComboBoxGenericos.Items.Insert(12, "Nivel del Combustible")
        ComboBoxGenericos.Items.Insert(13, "Ocupacion del Cliente")
        ComboBoxGenericos.Items.Insert(14, "Roles de Usuario")
        ComboBoxGenericos.Items.Insert(15, "Tipo de Antiguedades")
        ComboBoxGenericos.Items.Insert(16, "Tipo de Arte")
        ComboBoxGenericos.Items.Insert(17, "Tipo de Cancelacion de Apartado")
        ComboBoxGenericos.Items.Insert(18, "Tipo de Documento")
        ComboBoxGenericos.Items.Insert(19, "Tipo de Empeño")
        ComboBoxGenericos.Items.Insert(20, "Tipo de Identificacion")
        ComboBoxGenericos.Items.Insert(21, "Tipo de Interes")
        ComboBoxGenericos.Items.Insert(22, "Tipo de Motor")
        ComboBoxGenericos.Items.Insert(23, "Tipo de Operacion en Empeño")
        ComboBoxGenericos.Items.Insert(24, "Tipo de Sexo")
        ComboBoxGenericos.Items.Insert(25, "Tipo de Telefono")
        ComboBoxGenericos.Items.Insert(26, "Tipos de Ingreso de Mercancia")
        ComboBoxGenericos.Items.Insert(27, "Tipos de Movimientos de Empeño")
        ComboBoxGenericos.Items.Insert(28, "Tipos de Periodo x Tasas")
    End Sub
    Public Sub LlenarTodo()
        Dim tipo As TipoGenerico
        btnNuevo.Enabled = True
        Dim index As Integer
        index = ComboBoxGenericos.SelectedIndex
        Select Case index
            Case 0
                Exit Select
            Case 1
                tipo = TipoGenerico.TipoMercancia_Metal
                Exit Select
            Case 2
                tipo = TipoGenerico.EstatusVenta
                Exit Select
            Case 3
                tipo = TipoGenerico.EstatusApartado
                Exit Select
            Case 4
                tipo = TipoGenerico.EstatusEmpenio
                Exit Select
            Case 5
                tipo = TipoGenerico.EstatusInventario
                Exit Select
            Case 6
                tipo = TipoGenerico.EstatusMensaje
                Exit Select
            Case 7
                tipo = TipoGenerico.Familia_TipoKilataje
                Exit Select
            Case 8
                tipo = TipoGenerico.TipoFormaDiamante
                Exit Select
            Case 9
                tipo = TipoGenerico.Marca_EstadoMetal
                Exit Select
            Case 10
                tipo = TipoGenerico.MedioEnterado
                Exit Select
            Case 11
                tipo = TipoGenerico.MotivoChecador
                Exit Select
            Case 12
                tipo = TipoGenerico.NivelCombustible
                Exit Select
            Case 13
                tipo = TipoGenerico.Ocupacion
                Exit Select
            Case 14
                tipo = TipoGenerico.Rol
                Exit Select
            Case 15
                tipo = TipoGenerico.Antiguedad
                Exit Select
            Case 16
                tipo = TipoGenerico.Arte
                Exit Select
            Case 17
                tipo = TipoGenerico.TipoCancelacionApartado
                Exit Select
            Case 18
                tipo = TipoGenerico.TipoDocumento
                Exit Select
            Case 19
                tipo = TipoGenerico.TipoEmpenio
                Exit Select
            Case 20
                tipo = TipoGenerico.TipoIdentificacion
                Exit Select
            Case 21
                tipo = TipoGenerico.TipoTasa
                Exit Select
            Case 22
                tipo = TipoGenerico.TipoMotor
                Exit Select
            Case 23
                tipo = TipoGenerico.TipoOperacionEmpenio
                Exit Select
            Case 24
                tipo = TipoGenerico.Sexo
                Exit Select
            Case 25
                tipo = TipoGenerico.TipoTelefono
                Exit Select
            Case 26
                tipo = TipoGenerico.TipoIngreso
                Exit Select
            Case 27
                tipo = TipoGenerico.MovimientoEmpenio
                Exit Select
            Case 28
                tipo = TipoGenerico.Periodo
                Exit Select
        End Select

        Dim obj As New GenericoBL(cadena, tipo)
        Dim lst As New Genericos()
        lst = obj.Obtener()
        DGVGenericos.DataSource = lst
        DGVGenericos.Columns(0).Visible = False

        If tipo = TipoGenerico.TipoFormaDiamante Then
            DGVGenericos.Columns(1).Visible = True
            DGVGenericos.Columns(2).Visible = True
            DGVGenericos.Columns(3).Visible = False
            lblDescripcion.Visible = True
            txtDescripcion.Visible = True
            lblAuxiliar1.Visible = True
            txtAuxiliarUno.Visible = True
            lblAuxiliar2.Visible = False
            cmbTipoEmpenio.Visible = False
        ElseIf tipo = TipoGenerico.TipoMercancia_Metal Then
            DGVGenericos.Columns(1).Visible = True
            DGVGenericos.Columns(2).Visible = False
            DGVGenericos.Columns(3).Visible = True
            lblDescripcion.Visible = True
            txtDescripcion.Visible = True
            lblAuxiliar1.Visible = False
            txtAuxiliarUno.Visible = False
            lblAuxiliar2.Visible = True
            cmbTipoEmpenio.Visible = True
        ElseIf tipo = TipoGenerico.Familia_TipoKilataje Then
            DGVGenericos.Columns(1).Visible = True
            DGVGenericos.Columns(2).Visible = False
            DGVGenericos.Columns(3).Visible = True
        ElseIf tipo = TipoGenerico.Marca_EstadoMetal Then
            DGVGenericos.Columns(1).Visible = True
            DGVGenericos.Columns(2).Visible = False
            DGVGenericos.Columns(3).Visible = True
        Else
            DGVGenericos.Columns(1).Visible = True
            DGVGenericos.Columns(2).Visible = False
            DGVGenericos.Columns(3).Visible = False
        End If
    End Sub
    Public Sub LimpiarCampos()
        txtDescripcion.Clear()
        txtAuxiliarUno.Clear()
        cmbTipoEmpenio.Items.IndexOf(0)
    End Sub
    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        LlenarTodo()
        LimpiarCampos()
        btnNuevo.Enabled = True
        lblDescripcion.Visible = True
        txtDescripcion.Visible = True
        lblAuxiliar1.Visible = True
        txtAuxiliarUno.Visible = True
        lblAuxiliar2.Visible = True
        cmbTipoEmpenio.Visible = True
    End Sub
    Private Sub DGVGenericos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGenericos.CellDoubleClick
        Dim fila As DataGridViewRow = DGVGenericos.Rows(e.RowIndex)
        txtDescripcion.Text = Convert.ToString(fila.Cells(1).Value)
        txtAuxiliarUno.Text = Convert.ToString(fila.Cells(2).Value)
        cmbTipoEmpenio.SelectedIndex = Convert.ToString(fila.Cells(3).Value)

        btnNuevo.Enabled = False
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        LimpiarCampos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        LimpiarCampos()
    End Sub
End Class