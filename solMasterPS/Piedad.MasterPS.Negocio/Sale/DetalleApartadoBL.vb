Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class DetalleApartadoBL
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
    Public Sub Almacenar(ByVal detalleApartado_ As DetalleApartado)
        Try
            Dim obj As New DetalleApartadoDA(cadenaConex)
            obj.Almacenar(detalleApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal detalleApartado_ As DetalleApartado)
        Try
            Dim obj As New DetalleApartadoDA(cadenaConex)
            obj.Actualizar(detalleApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal detalleApartado_ As DetalleApartado)
        Try
            Dim obj As New DetalleApartadoDA(cadenaConex)
            obj.Eliminar(detalleApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal detalleApartado_ As DetalleApartado) As DetalleApartado
        Try
            Dim obj As New DetalleApartadoDA(cadenaConex)
            Return obj.Obtener(detalleApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal detalleApartado_ As DetalleApartado) As DetalleApartados
        Try
            Dim obj As New DetalleApartadoDA(cadenaConex)
            Return obj.ObtenerTodos(detalleApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
