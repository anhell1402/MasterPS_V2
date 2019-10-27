Imports System.Configuration
Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Imports Piedad.MasterPS.Negocio
Imports System.Runtime.InteropServices
Public Class frmSeleccionMciasElectronicas
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
    Private tipo As String
    Public Sub New(ByVal tipo_ As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        tipo = tipo_
        If tipo = 2 Then
            txtTipoEmpenio.Text = "ELECTRÓNICA"
        ElseIf tipo = 3 Then
            txtTipoEmpenio.Text = "HERRAMIENTA"
        End If
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmAltaMcia.Show()
    End Sub
    Private Sub FrmSeleccionMciasElectronicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCategoria()
        'LlenarMarca()
        'LlenarModelo()
    End Sub
    Private Sub LlenarCategoria()
        Dim gen As New Generico()
        gen.IdAuxiliarUno = Convert.ToInt32(tipo)
        Dim lst As New Genericos()
        Dim obj As New GenericoBL(cadena, TipoGenerico.TipoMercancia_Metal)
        lst = obj.ObtenerTodos(gen)
        cmbMercanciaMetal.DataSource = lst
        cmbMercanciaMetal.DisplayMember = "Descripcion"
        cmbMercanciaMetal.ValueMember = "IdGenerico"
    End Sub
    Private Sub LlenarFamilia(ByVal tipo As Generico)
        Dim lst As New Genericos()
        Dim obj As New GenericoBL(cadena, TipoGenerico.Familia_TipoKilataje)
        lst = obj.ObtenerTodos(tipo)
        cmbFamilia.DataSource = lst
        cmbFamilia.DisplayMember = "Descripcion"
        cmbFamilia.ValueMember = "IdGenerico"
    End Sub
    Private Sub LlenarMarca(ByVal tipo As Generico)
        Dim lst As New Genericos()
        Dim obj As New GenericoBL(cadena, TipoGenerico.Marca_EstadoMetal)
        lst = obj.ObtenerTodosBy(tipo)
        cmbMarca.DataSource = lst
        cmbMarca.DisplayMember = "Descripcion"
        cmbMarca.ValueMember = "IdGenerico"
    End Sub
    Private Sub LlenarModelo()
        'Dim lst As New Mercancia()
        'Dim obj As New MercanciaBL(cadena)
        ' lst = obj.ObtenerTodos()
        'cmbModelo.DataSource = lst
        'cmbModelo.DisplayMember = "Descripcion"
        'cmbModelo.ValueMember = "IdGenerico"
    End Sub


    Private Sub CmbMercanciaMetal_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMercanciaMetal.SelectedValueChanged
        Dim gen As New Generico()
        gen = DirectCast(cmbMercanciaMetal.SelectedItem, Generico)

        Dim gen2 As New Generico()
        gen2.IdAuxiliarUno = gen.IdGenerico
        'gen.IdAuxiliarUno = cmbTipoMetal.SelectedValue.ToString()
        LlenarFamilia(gen2)
    End Sub
    Private Sub ObtenerPrecio()
        Dim mcia As New Generico()
        mcia = DirectCast(cmbMercanciaMetal.SelectedItem, Generico)
        Dim familia As New Generico()
        familia = DirectCast(cmbFamilia.SelectedItem, Generico)
        Dim marca As New Generico()
        marca = DirectCast(cmbMarca.SelectedItem, Generico)
        Dim tipoEmpenio As New Generico()
        tipoEmpenio.IdGenerico = Convert.ToInt32(tipo)
        Dim merca As New Mercancia()
        merca.Modelo = cmbModelo.Text
        merca.IdFamilia_TipoKilataje = familia
        merca.IdMarca_EstadoMetal = marca
        merca.IdTipoMercancia_Metal = mcia
        merca.IdTipoEmpenio = tipoEmpenio
        If mcia.IdGenerico > -1 And familia.IdGenerico > -1 And marca.IdGenerico > -1 And cmbModelo.SelectedIndex > 0 Then
            Dim obj As New EmpenioBL(cadena)
            Dim precio As String = obj.ObtenerPrecio(False, merca).ToString("C")
            If obj.HayError Then
                Dim frm As New frmVentanaAviso(TipoVentana.AdvertenciaError, obj.MensajeError, "Error")
                frm.ShowDialog()
            Else
                lblPrestamoCantidadMax.Text = precio
            End If
        Else
            lblPrestamoCantidadMax.Text = "$ 0.00"
        End If
    End Sub

    Private Sub cmbFamilia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFamilia.SelectedValueChanged
        Dim gen As New Generico()
        gen = DirectCast(cmbFamilia.SelectedItem, Generico)
        Dim gen2 As New Generico()
        gen2.IdAuxiliarUno = gen.IdGenerico
        'gen.IdAuxiliarUno = cmbTipoMetal.SelectedValue.ToString()
        LlenarMarca(gen2)

    End Sub

    Private Sub cmbMarca_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMarca.SelectedValueChanged
        Dim marca As New Generico()
        marca = DirectCast(cmbMarca.SelectedItem, Generico)
        Dim familia As New Generico()
        familia = DirectCast(cmbFamilia.SelectedItem, Generico)
        Dim mercanciaMetal As New Generico()
        mercanciaMetal = DirectCast(cmbMercanciaMetal.SelectedItem, Generico)
        Dim tipoEmpenio As New Generico()
        tipoEmpenio.IdGenerico = Convert.ToInt32(tipo)
        Dim merca As New Mercancia()
        merca.IdFamilia_TipoKilataje = familia
        merca.IdMarca_EstadoMetal = marca
        merca.IdTipoEmpenio = tipoEmpenio
        merca.IdTipoMercancia_Metal = mercanciaMetal
        Dim lst As New Mercancias()
        Dim obj As New MercanciaBL(cadena)
        lst = obj.ObtenerModeloss(merca)
        cmbModelo.DataSource = lst
        cmbModelo.DisplayMember = "Modelo"
        cmbModelo.ValueMember = "Modelo"
    End Sub

    Private Sub cmbModelo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbModelo.SelectedValueChanged
        ObtenerPrecio()
    End Sub
End Class