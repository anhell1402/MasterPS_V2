Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ConfigFacturacionBL
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
    Public Sub Almacenar(ByVal configFacturacion_ As ConfigFacturacion)
        Try
            Dim obj As New ConfigFacturacionDA(cadenaConex)
            obj.Almacenar(configFacturacion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal configFacturacion_ As ConfigFacturacion)
        Try
            Dim obj As New ConfigFacturacionDA(cadenaConex)
            obj.Actualizar(configFacturacion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal configFacturacion_ As ConfigFacturacion)
        Try
            Dim obj As New ConfigFacturacionDA(cadenaConex)
            obj.Eliminar(configFacturacion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal configFacturacion_ As ConfigFacturacion) As ConfigFacturacion
        Try
            Dim obj As New ConfigFacturacionDA(cadenaConex)
            Return obj.Obtener(configFacturacion_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As ConfigFacturaciones
        Try
            Dim obj As New ConfigFacturacionDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
