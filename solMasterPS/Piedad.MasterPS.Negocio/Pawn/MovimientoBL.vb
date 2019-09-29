Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class MovimientoBL
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
    Public Sub Almacenar(ByVal movimiento_ As Movimiento)
        Try
            Dim obj As New MovimientoDA(cadenaConex)
            obj.Almacenar(movimiento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal movimiento_ As Movimiento)
        Try
            Dim obj As New MovimientoDA(cadenaConex)
            obj.Actualizar(movimiento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal movimiento_ As Movimiento)
        Try
            Dim obj As New MovimientoDA(cadenaConex)
            obj.Eliminar(movimiento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal movimiento_ As Movimiento) As Movimiento
        Try
            Dim obj As New MovimientoDA(cadenaConex)
            Return obj.Obtener(movimiento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal movimiento_ As Movimiento) As Movimientos
        Try
            Dim obj As New MovimientoDA(cadenaConex)
            Return obj.ObtenerTodos(movimiento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
