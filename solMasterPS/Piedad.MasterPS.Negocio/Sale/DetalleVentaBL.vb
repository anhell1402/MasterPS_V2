Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class DetalleVentaBL
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
    Public Sub Almacenar(ByVal detalleVenta_ As DetalleVenta)
        Try
            Dim obj As New DetalleVentaDA(cadenaConex)
            obj.Almacenar(detalleVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal detalleVenta_ As DetalleVenta)
        Try
            Dim obj As New DetalleVentaDA(cadenaConex)
            obj.Actualizar(detalleVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal detalleVenta_ As DetalleVenta)
        Try
            Dim obj As New DetalleVentaDA(cadenaConex)
            obj.Eliminar(detalleVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal detalleVenta_ As DetalleVenta) As DetalleVenta
        Try
            Dim obj As New DetalleVentaDA(cadenaConex)
            Return obj.Obtener(detalleVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal detalleVenta_ As DetalleVenta) As DetalleVentas
        Try
            Dim obj As New DetalleVentaDA(cadenaConex)
            Return obj.ObtenerTodos(detalleVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
