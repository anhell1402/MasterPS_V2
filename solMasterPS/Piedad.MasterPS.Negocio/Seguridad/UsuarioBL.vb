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
            _hayError = obj.HayError
            _error = obj.MensajeError
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try

    End Sub
    Public Sub Actualizar(ByVal usuario_ As Usuario)
        Try
            Dim obj As New UsuarioDA(cadenaConex)
            obj.Actualizar(usuario_)
            _hayError = obj.HayError
            _error = obj.MensajeError
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal usuario_ As Usuario)
        Try
            Dim obj As New UsuarioDA(cadenaConex)
            obj.Eliminar(usuario_)
            _hayError = obj.HayError
            _error = obj.MensajeError
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal usuario_ As Usuario) As Usuario
        Dim user As Usuario
        Try
            Dim obj As New UsuarioDA(cadenaConex)
            user = obj.Obtener(usuario_)
            _hayError = obj.HayError
            _error = obj.MensajeError
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            user = Nothing
        End Try
        Return user
    End Function
    Public Function ObtenerTodos(ByVal usuario_ As Usuario) As Usuarios
        Dim users As Usuarios
        Try
            Dim obj As New UsuarioDA(cadenaConex)
            users = obj.ObtenerTodos(usuario_)
            _hayError = obj.HayError
            _error = obj.MensajeError
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            users = Nothing
        End Try
        Return users
    End Function


End Class
