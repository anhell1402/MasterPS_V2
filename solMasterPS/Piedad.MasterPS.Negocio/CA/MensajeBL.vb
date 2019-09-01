Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos

Public Class MensajeBL
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
    Public Sub Almacenar(ByVal mensaje_ As Mensaje)
        Try
            Dim obj As New MensajeDA(cadenaConex)
            obj.Almacenar(mensaje_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal mensaje_ As Mensaje)
        Try
            Dim obj As New MensajeDA(cadenaConex)
            obj.Actualizar(mensaje_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal mensaje_ As Mensaje)
        Try
            Dim obj As New MensajeDA(cadenaConex)
            obj.Eliminar(mensaje_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal mensaje_ As Mensaje) As Mensaje
        Try
            Dim obj As New MensajeDA(cadenaConex)
            Return obj.Obtener(mensaje_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As Mensajes
        Try
            Dim obj As New MensajeDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
