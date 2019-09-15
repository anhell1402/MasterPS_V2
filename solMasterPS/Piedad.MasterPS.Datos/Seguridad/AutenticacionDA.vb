Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class AutenticacionDA
    Private _error As String
    Public ReadOnly Property MensajeError As String
        Get
            Return _error
        End Get
    End Property
    Private _hayError As Boolean
    Public ReadOnly Property HayError As Boolean
        Get
            Return _hayError
        End Get
    End Property
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
        _hayError = False
    End Sub
    Public Function AutenticaUsuario(ByVal user As Usuario) As Usuario
        Try
            Using objDA As New ConexDB(cadenaConex)
                Dim lista As New List(Of Usuario)
                objDA.CrearComando("dbo.Autentica_sp_AutenticaUsuario")
                objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
                objDA.AgregarParametro("@username", user.Username)
                objDA.AgregarParametro("@passwd", user.Password)
                lista = objDA.ObtenerResultados(Of Usuario)()
                user = lista(0)
            End Using
            _hayError = False
            _error = String.Empty
        Catch ex As Exception
            user = Nothing
            _hayError = True
            _error = ex.Message
        End Try
        Return user
    End Function

    Public Sub RestablecerPasswd(ByVal user As Usuario)
        Try
            Using objDA As New ConexDB(cadenaConex)
                objDA.CrearComando("dbo.Autentica_sp_RestablecerPass")
                objDA.AgregarParametro("@username", user.Username)
                objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
                objDA.EjecutaComando()
            End Using
            _error = String.Empty
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub

    Public Function OlvidaPasswd(ByVal user As Usuario) As Usuario
        Try
            Using objDA As New ConexDB(cadenaConex)
                Dim lista As New List(Of Usuario)
                objDA.CrearComando("dbo.Autentica_sp_OlvidaPasswd")
                objDA.AgregarParametro("@username", user.Username)
                objDA.AgregarParametro("@mail", user.Mail)
                objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
                lista = objDA.ObtenerResultados(Of Usuario)()
                user = lista(0)
            End Using
            _hayError = False
            _error = String.Empty
        Catch ex As Exception
            user = Nothing
            _hayError = True
            _error = ex.Message
        End Try
        Return user
    End Function
End Class
