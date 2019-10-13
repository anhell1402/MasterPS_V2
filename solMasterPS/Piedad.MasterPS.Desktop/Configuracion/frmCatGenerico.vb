Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio

Public Class frmCatGenerico
    Private cadena As String = ConfigurationManager.ConnectionStrings("Piedad.MasterPS.DB").ConnectionString
    Private mensajeError As String = String.Empty
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub LlenarTipoEmpenio()
        Dim obj As New GenericoBL(cadena, TipoGenerico.TipoEmpenio)
        Dim lst As New Genericos()
        lst = obj.Obtener()
        cmbTipoEmpenio.DataSource = lst
        cmbTipoEmpenio.ValueMember = "IdGenerico"
        cmbTipoEmpenio.DisplayMember = "Descripcion"
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
        ComboBoxGenericos.Items.Insert(0, "-- Seleccione una opción --")
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
        ComboBoxGenericos.Items.Insert(14, "Tipo de Antiguedades")
        ComboBoxGenericos.Items.Insert(15, "Tipo de Arte")
        ComboBoxGenericos.Items.Insert(16, "Tipo de Cancelacion de Apartado")
        ComboBoxGenericos.Items.Insert(17, "Tipo de Documento")
        ComboBoxGenericos.Items.Insert(18, "Tipo de Empeño")
        ComboBoxGenericos.Items.Insert(19, "Tipo de Identificacion")
        ComboBoxGenericos.Items.Insert(20, "Tipo de Interes")
        ComboBoxGenericos.Items.Insert(21, "Tipo de Motor")
        ComboBoxGenericos.Items.Insert(22, "Tipo de Operacion en Empeño")
        ComboBoxGenericos.Items.Insert(23, "Tipo de Sexo")
        ComboBoxGenericos.Items.Insert(24, "Tipo de Telefono")
        ComboBoxGenericos.Items.Insert(25, "Tipos de Ingreso de Mercancia")
        ComboBoxGenericos.Items.Insert(26, "Tipos de Movimientos de Empeño")
        ComboBoxGenericos.Items.Insert(27, "Tipos de Periodo x Tasas")
        ComboBoxGenericos.SelectedIndex = 0
    End Sub

    Private Function ObtenerTipo() As TipoGenerico
        Dim tipo As TipoGenerico
        Dim index As Integer
        index = ComboBoxGenericos.SelectedIndex
        Select Case index
            Case 0
                Exit Select
            Case 1
                tipo = TipoGenerico.TipoMercancia_Metal
                LlenarTipoEmpenio()
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
                LlenarTipoEmpenio()
                Exit Select
            Case 8
                tipo = TipoGenerico.TipoFormaDiamante
                Exit Select
            Case 9
                tipo = TipoGenerico.Marca_EstadoMetal
                LlenarTipoEmpenio()
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
                tipo = TipoGenerico.Antiguedad
                Exit Select
            Case 15
                tipo = TipoGenerico.Arte
                Exit Select
            Case 16
                tipo = TipoGenerico.TipoCancelacionApartado
                Exit Select
            Case 17
                tipo = TipoGenerico.TipoDocumento
                Exit Select
            Case 18
                tipo = TipoGenerico.TipoEmpenio
                Exit Select
            Case 19
                tipo = TipoGenerico.TipoIdentificacion
                Exit Select
            Case 20
                tipo = TipoGenerico.TipoTasa
                Exit Select
            Case 21
                tipo = TipoGenerico.TipoMotor
                Exit Select
            Case 22
                tipo = TipoGenerico.TipoOperacionEmpenio
                Exit Select
            Case 23
                tipo = TipoGenerico.Sexo
                Exit Select
            Case 24
                tipo = TipoGenerico.TipoTelefono
                Exit Select
            Case 25
                tipo = TipoGenerico.TipoIngreso
                Exit Select
            Case 26
                tipo = TipoGenerico.MovimientoEmpenio
                Exit Select
            Case 27
                tipo = TipoGenerico.Periodo
                Exit Select
        End Select
        Return tipo
    End Function
    Private Sub LlenarTodo()
        Dim tipo As TipoGenerico
        btnNuevo.Enabled = True
        tipo = ObtenerTipo()

        Dim obj As New GenericoBL(cadena, tipo)
        Dim lst As New Genericos()
        lst = obj.Obtener()
        DGVGenericos.DataSource = lst
        If lst.Count > 0 Then
            DGVGenericos.Rows(0).Selected = False
        End If
        DGVGenericos.Columns(0).Visible = False
        DGVGenericos.Columns(2).Visible = False
        DGVGenericos.Columns(3).Visible = False
        DGVGenericos.Columns(4).Visible = False
        lblDescripcion.Visible = True
        txtDescripcion.Visible = True
        cmbTipoEmpenio.Visible = False
        lblAuxiliar2.Visible = False
        If tipo = TipoGenerico.TipoMercancia_Metal Or tipo = TipoGenerico.Familia_TipoKilataje Or tipo = TipoGenerico.Marca_EstadoMetal Then
            cmbTipoEmpenio.Visible = True
            lblAuxiliar2.Visible = True
            DGVGenericos.Columns(4).Visible = True
            DGVGenericos.Columns(4).HeaderText = "Tipo de Empeño"
        End If
        lblAuxiliar1.Visible = False
        txtAuxiliarUno.Visible = False
        If tipo = TipoGenerico.TipoFormaDiamante Then
            lblAuxiliar1.Visible = True
            txtAuxiliarUno.Visible = True
            DGVGenericos.Columns(2).Visible = True
            DGVGenericos.Columns(2).HeaderText = "URL"
        End If

    End Sub
    Public Sub LimpiarCampos()
        txtDescripcion.Clear()
        txtAuxiliarUno.Clear()
    End Sub
    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If ComboBoxGenericos.SelectedIndex > 0 Then
            LlenarTodo()
            LimpiarCampos()
            btnNuevo.Enabled = True
        Else
            Dim msg As New frmVentanaAviso(TipoVentana.AdvertenciaError, "Debe seleccionar un elemento", "Advertencia")
            msg.ShowDialog()
            lblDescripcion.Visible = False
            txtDescripcion.Visible = False
            lblAuxiliar1.Visible = False
            lblAuxiliar2.Visible = False
            txtAuxiliarUno.Visible = False
            cmbTipoEmpenio.Visible = False
            DGVGenericos.DataSource = Nothing
        End If

    End Sub
    Private Sub DGVGenericos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGenericos.CellDoubleClick
        Dim fila As DataGridViewRow = DGVGenericos.Rows(e.RowIndex)
        lblId.Text = Convert.ToInt32(fila.Cells(0).Value)
        txtDescripcion.Text = Convert.ToString(fila.Cells(1).Value)
        txtAuxiliarUno.Text = Convert.ToString(fila.Cells(2).Value)
        If cmbTipoEmpenio.Items.Count > 0 Then
            cmbTipoEmpenio.SelectedIndex = Convert.ToString(fila.Cells(3).Value)
        End If


        btnNuevo.Enabled = False
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True
    End Sub
    Private Function Valida() As Boolean
        Dim correcto As Boolean = False
        Dim tipo As TipoGenerico
        tipo = ObtenerTipo()
        If (txtDescripcion.Text.Trim() <> String.Empty) Then
            correcto = True
        Else
            correcto = False
            mensajeError = "Debe especificar la descripción del elemento."
        End If
        If (correcto) Then
            If tipo = TipoGenerico.TipoFormaDiamante Then
                If txtAuxiliarUno.Text.Trim() <> String.Empty Then
                    correcto = True
                Else
                    mensajeError = "Debe especificar la URL."
                    correcto = False
                End If
            ElseIf tipo = TipoGenerico.TipoMercancia_Metal Or tipo = TipoGenerico.Familia_TipoKilataje Or tipo = TipoGenerico.Marca_EstadoMetal Then
                If Convert.ToInt32(cmbTipoEmpenio.SelectedValue) > 0 Then
                    correcto = True
                Else
                    mensajeError = "Debe especificar el tipo de empeño."
                    correcto = False
                End If
            Else
                correcto = True
            End If
        End If
        Return correcto
    End Function
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim tipo As TipoGenerico
        tipo = ObtenerTipo()
        If Not Valida() Then
            Dim msg As New frmVentanaAviso(TipoVentana.AdvertenciaError, mensajeError, "Advertencia")
            msg.ShowDialog()
        Else
            Dim gen As New Generico()
            gen.Descripcion = txtDescripcion.Text.Trim()
            If tipo = TipoGenerico.TipoFormaDiamante Then
                gen.AuxiliarUno = txtAuxiliarUno.Text.Trim()
            ElseIf tipo = TipoGenerico.TipoMercancia_Metal And tipo = TipoGenerico.Familia_TipoKilataje And tipo = TipoGenerico.Marca_EstadoMetal Then
                gen.IdAuxiliarUno = Convert.ToInt32(cmbTipoEmpenio.SelectedValue)
            End If
            Dim obj As New GenericoBL(cadena, tipo)
            obj.Almacenar(gen)

            LimpiarCampos()
            LlenarTodo()
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim tipo As TipoGenerico
        tipo = ObtenerTipo()
        If Not Valida() Then
            Dim msg As New frmVentanaAviso(TipoVentana.AdvertenciaError, mensajeError, "Advertencia")
            msg.ShowDialog()
        Else
            Dim gen As New Generico()
            gen.IdGenerico = Convert.ToInt32(lblId.Text)
            gen.Descripcion = txtDescripcion.Text.Trim()
            If tipo = TipoGenerico.TipoFormaDiamante Then
                gen.AuxiliarUno = txtAuxiliarUno.Text.Trim()
            ElseIf tipo = TipoGenerico.TipoMercancia_Metal And tipo = TipoGenerico.Familia_TipoKilataje And tipo = TipoGenerico.Marca_EstadoMetal Then
                gen.IdAuxiliarUno = Convert.ToInt32(cmbTipoEmpenio.SelectedValue)
            End If
            Dim obj As New GenericoBL(cadena, tipo)
            obj.Actualizar(gen)

            LimpiarCampos()
            LlenarTodo()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim tipo As TipoGenerico
        tipo = ObtenerTipo()
        Dim gen As New Generico()
        gen.IdGenerico = Convert.ToInt32(lblId.Text)
        Dim obj As New GenericoBL(cadena, tipo)
        Dim frm As New frmVentanaAviso(TipoVentana.Pregunta, "¿Está seguro que desea eliminar?", "Aviso")
        frm.ShowDialog()
        If (frm.Respuesta = RespuestaVentana.Si) Then
            obj.Eliminar(gen)
            Me.DialogResult = DialogResult.Cancel
            LimpiarCampos()
            LlenarTodo()
        End If
    End Sub
End Class