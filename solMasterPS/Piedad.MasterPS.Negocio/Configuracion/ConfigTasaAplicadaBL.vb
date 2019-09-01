Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ConfigTasaAplicadaBL
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
    Public Sub Almacenar(ByVal configTasaAplicada_ As ConfigTasaAplicada)
        Try
            Dim obj As New ConfigTasaAplicadaDA(cadenaConex)
            obj.Almacenar(configTasaAplicada_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal configTasaAplicada_ As ConfigTasaAplicada)
        Try
            Dim obj As New ConfigTasaAplicadaDA(cadenaConex)
            obj.Actualizar(configTasaAplicada_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal configTasaAplicada_ As ConfigTasaAplicada)
        Try
            Dim obj As New ConfigTasaAplicadaDA(cadenaConex)
            obj.Eliminar(configTasaAplicada_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal configTasaAplicada_ As ConfigTasaAplicada) As ConfigTasaAplicada
        Try
            Dim obj As New ConfigTasaAplicadaDA(cadenaConex)
            Return obj.Obtener(configTasaAplicada_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As ConfigTasasAplicadas
        Try
            Dim obj As New ConfigTasaAplicadaDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
