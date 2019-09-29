Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class CancelacionApartadoBL
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
    Public Sub Almacenar(ByVal cancelacionApartado_ As CancelacionApartado)
        Try
            Dim obj As New CancelacionApartadoDA(cadenaConex)
            obj.Almacenar(cancelacionApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal cancelacionApartado_ As CancelacionApartado)
        Try
            Dim obj As New CancelacionApartadoDA(cadenaConex)
            obj.Actualizar(cancelacionApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal cancelacionApartado_ As CancelacionApartado)
        Try
            Dim obj As New CancelacionApartadoDA(cadenaConex)
            obj.Eliminar(cancelacionApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal cancelacionApartado_ As CancelacionApartado) As CancelacionApartado
        Try
            Dim obj As New CancelacionApartadoDA(cadenaConex)
            Return obj.Obtener(cancelacionApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal cancelacionApartado_ As CancelacionApartado) As CancelacionApartados
        Try
            Dim obj As New CancelacionApartadoDA(cadenaConex)
            Return obj.ObtenerTodos(cancelacionApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
