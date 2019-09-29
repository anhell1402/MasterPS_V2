Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class DetalleEmpenioBL
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
    Public Sub Almacenar(ByVal detalleEmpenio_ As DetalleEmpenio)
        Try
            Dim obj As New DetalleEmpenioDA(cadenaConex)
            obj.Almacenar(detalleEmpenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal detalleEmpenio_ As DetalleEmpenio)
        Try
            Dim obj As New DetalleEmpenioDA(cadenaConex)
            obj.Actualizar(detalleEmpenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal detalleEmpenio_ As DetalleEmpenio)
        Try
            Dim obj As New DetalleEmpenioDA(cadenaConex)
            obj.Eliminar(detalleEmpenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal detalleEmpenio_ As DetalleEmpenio) As DetalleEmpenio
        Try
            Dim obj As New DetalleEmpenioDA(cadenaConex)
            Return obj.Obtener(detalleEmpenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal detalleEmpenio_ As DetalleEmpenio) As DetalleEmpenios
        Try
            Dim obj As New DetalleEmpenioDA(cadenaConex)
            Return obj.ObtenerTodos(detalleEmpenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
