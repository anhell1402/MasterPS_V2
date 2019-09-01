Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class UsuarioBL
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
    Public Sub Almacenar(ByVal usuario_ As Usuario)
        Try
            Dim obj As New UsuarioDA(cadenaConex)
            obj.Almacenar(usuario_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal usuario_ As Usuario)
        Try
            Dim obj As New UsuarioDA(cadenaConex)
            obj.Actualizar(usuario_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal usuario_ As Usuario)
        Try
            Dim obj As New UsuarioDA(cadenaConex)
            obj.Eliminar(usuario_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal usuario_ As Usuario) As Usuario
        Try
            Dim obj As New UsuarioDA(cadenaConex)
            Return obj.Obtener(usuario_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As Usuarios
        Try
            Dim obj As New UsuarioDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
