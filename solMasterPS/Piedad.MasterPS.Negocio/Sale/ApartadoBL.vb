Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ApartadoBL
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
    Public Sub Almacenar(ByVal apartado_ As Apartado)
        Try
            Dim obj As New ApartadoDA(cadenaConex)
            obj.Almacenar(apartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal apartado_ As Apartado)
        Try
            Dim obj As New ApartadoDA(cadenaConex)
            obj.Actualizar(apartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal apartado_ As Apartado)
        Try
            Dim obj As New ApartadoDA(cadenaConex)
            obj.Eliminar(apartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal apartado_ As Apartado) As Apartado
        Try
            Dim obj As New ApartadoDA(cadenaConex)
            Return obj.Obtener(apartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal apartado_ As Apartado) As Apartados
        Try
            Dim obj As New ApartadoDA(cadenaConex)
            Return obj.ObtenerTodos(apartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
