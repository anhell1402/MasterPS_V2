Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class CancelacionBL
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
    Public Sub Almacenar(ByVal cancelacion_ As Cancelacion)
        Try
            Dim obj As New CancelacionDA(cadenaConex)
            obj.Almacenar(cancelacion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal cancelacion_ As Cancelacion)
        Try
            Dim obj As New CancelacionDA(cadenaConex)
            obj.Actualizar(cancelacion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal cancelacion_ As Cancelacion)
        Try
            Dim obj As New CancelacionDA(cadenaConex)
            obj.Eliminar(cancelacion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal cancelacion_ As Cancelacion) As Cancelacion
        Try
            Dim obj As New CancelacionDA(cadenaConex)
            Return obj.Obtener(cancelacion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As Cancelaciones
        Try
            Dim obj As New CancelacionDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
