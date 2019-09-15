Public Class frmVentanaAviso
    Private _tipoVentana As TipoVentana
    Private _mensaje As String
    Private _titulo As String
    Private _respuesta As RespuestaVentana
    Public ReadOnly Property Respuesta As RespuestaVentana
        Get
            Return _respuesta
        End Get
    End Property
    Public Sub New(ByVal _typeVentana As TipoVentana, ByVal mensaje As String, ByVal titulo As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _tipoVentana = _typeVentana
        _mensaje = mensaje
        _titulo = titulo
        lblEncabezadoAviso.Text = titulo
        lblMensajeAviso.Text = mensaje
        Select Case _typeVentana
            Case TipoVentana.AdvertenciaError
                ImagenAviso.Image = My.Resources.warningRed
                btnSi.Visible = False
                btnNo.Visible = False
                Exit Select
            Case TipoVentana.Aviso
                ImagenAviso.Image = My.Resources.Aviso1
                btnSi.Visible = False
                btnNo.Visible = False
                Exit Select
            Case TipoVentana.Pregunta
                ImagenAviso.Image = My.Resources.Pregunta
                btnOK.Visible = False
                Exit Select
        End Select
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        _respuesta = RespuestaVentana.OK
        Me.Close()
    End Sub

    Private Sub BtnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        _respuesta = RespuestaVentana.Si
        Me.Close()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        _respuesta = RespuestaVentana.No
        Me.Close()
    End Sub
End Class