Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class InventarioBL
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
    End Sub
    Public Sub Almacenar(ByVal inventario_ As Inventario)
        Try
            Dim obj As New InventarioDA(cadenaConex)
            obj.Almacenar(inventario_|)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal inventario_ As Inventario)
        Try
            Dim obj As New InventarioDA(cadenaConex)
            obj.Actualizar(inventario_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal inventario_ As Inventario)
        Try
            Dim obj As New InventarioDA(cadenaConex)
            obj.Eliminar(inventario_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal inventario_ As Inventario) As Inventario
        Try
            Dim obj As New InventarioDA(cadenaConex)
            Return obj.Obtener(inventario_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos() As Inventarios
        Try
            Dim obj As New InventarioDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
