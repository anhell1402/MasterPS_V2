Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class PermisoBL
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
    Public Sub Almacenar(ByVal permiso_ As Permiso)
        Try
            Dim obj As New PermisoDA(cadenaConex)
            obj.Almacenar(permiso_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal permiso_ As Permisos)
        Try
            Dim obj As New PermisoDA(cadenaConex)
            obj.Actualizar(permiso_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal permiso_ As Permiso)
        Try
            Dim obj As New PermisoDA(cadenaConex)
            obj.Eliminar(permiso_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal permiso_ As Permiso) As Permiso
        Try
            Dim obj As New PermisoDA(cadenaConex)
            Return obj.Obtener(permiso_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As Permisos
        Try
            Dim obj As New PermisoDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
