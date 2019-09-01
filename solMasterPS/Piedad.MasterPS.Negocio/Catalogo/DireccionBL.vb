Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class DireccionBL
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
    Public Sub Almacenar(ByVal direccion_ As Direccion)
        Try
            Dim obj As New DireccionDA(cadenaConex)
            obj.Almacenar(direccion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal direccion_ As Direccion)
        Try
            Dim obj As New DireccionDA(cadenaConex)
            obj.Actualizar(direccion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal direccion_ As Direccion)
        Try
            Dim obj As New DireccionDA(cadenaConex)
            obj.Eliminar(direccion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal direccion_ As Direccion) As Direccion
        Try
            Dim obj As New DireccionDA(cadenaConex)
            Return obj.Obtener(direccion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As Direcciones
        Try
            Dim obj As New DireccionDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
