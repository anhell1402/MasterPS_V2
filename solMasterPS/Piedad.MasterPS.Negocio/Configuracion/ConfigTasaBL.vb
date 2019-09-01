Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ConfigTasaBL
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
    Public Sub Almacenar(ByVal configTasa_ As ConfigTasa)
        Try
            Dim obj As New ConfigTasaDA(cadenaConex)
            obj.Almacenar(configTasa_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal configTasa_ As ConfigTasa)
        Try
            Dim obj As New ConfigTasaDA(cadenaConex)
            obj.Actualizar(configTasa_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal configTasa_ As ConfigTasa)
        Try
            Dim obj As New ConfigTasaDA(cadenaConex)
            obj.Eliminar(configTasa_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal configTasa_ As ConfigTasa) As ConfigTasa
        Try
            Dim obj As New ConfigTasaDA(cadenaConex)
            Return obj.Obtener(configTasa_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As ConfigTasas
        Try
            Dim obj As New ConfigTasaDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
