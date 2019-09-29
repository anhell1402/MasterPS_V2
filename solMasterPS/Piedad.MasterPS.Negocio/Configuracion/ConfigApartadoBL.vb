Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ConfigApartadoBL
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
    Public Sub Almacenar(ByVal configApartado_ As ConfigApartado)
        Try
            Dim obj As New ConfigApartadoDA(cadenaConex)
            obj.Almacenar(configApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal configApartado_ As ConfigApartado)
        Try
            Dim obj As New ConfigApartadoDA(cadenaConex)
            obj.Actualizar(configApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal configApartado_ As ConfigApartado)
        Try
            Dim obj As New ConfigApartadoDA(cadenaConex)
            obj.Eliminar(configApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal configApartado_ As ConfigApartado) As ConfigApartado
        Try
            Dim obj As New ConfigApartadoDA(cadenaConex)
            Return obj.Obtener(configApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal configApartado_ As ConfigApartado) As ConfigApartados
        Try
            Dim obj As New ConfigApartadoDA(cadenaConex)
            Return obj.ObtenerTodos(configApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
