Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class VentaBL
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
    Public Sub Almacenar(ByVal venta_ As Venta)
        Try
            Dim obj As New VentaDA(cadenaConex)
            obj.Almacenar(venta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal venta_ As Venta)
        Try
            Dim obj As New VentaDA(cadenaConex)
            obj.Actualizar(venta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal venta_ As Venta)
        Try
            Dim obj As New VentaDA(cadenaConex)
            obj.Eliminar(venta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal venta_ As Venta) As Venta
        Try
            Dim obj As New VentaDA(cadenaConex)
            Return obj.Obtener(venta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal venta_ As Venta) As Ventas
        Try
            Dim obj As New VentaDA(cadenaConex)
            Return obj.ObtenerTodos(venta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
