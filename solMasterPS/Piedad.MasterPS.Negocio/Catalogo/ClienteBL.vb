Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ClienteBL
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
    Public Sub Almacenar(ByVal cliente_ As Cliente)
        Try
            Dim obj As New ClienteDA(cadenaConex)
            obj.Almacenar(cliente_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal cliente_ As Cliente)
        Try
            Dim obj As New ClienteDA(cadenaConex)
            obj.Actualizar(cliente_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal cliente_ As Cliente)
        Try
            Dim obj As New ClienteDA(cadenaConex)
            obj.Eliminar(cliente_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal cliente_ As Cliente) As Cliente
        Try
            Dim obj As New ClienteDA(cadenaConex)
            Return obj.Obtener(cliente_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal cliente_ As Cliente) As Clientes
        Try
            Dim obj As New ClienteDA(cadenaConex)
            Return obj.ObtenerTodos(cliente_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
