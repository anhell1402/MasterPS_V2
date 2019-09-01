Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ChecadorBL
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
    End Sub

    Public Sub Almacenar(ByVal checador_ As Checador)
        Try
            Dim obj As New ChecadorDA(cadenaConex)
            obj.Almacenar(checador_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal checador_ As Checador)
        Try
            Dim obj As New ChecadorDA(cadenaConex)
            obj.Actualizar(checador_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal checador_ As Checador)
        Try
            Dim obj As New ChecadorDA(cadenaConex)
            obj.Eliminar(checador_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal checador_ As Checador) As Checador
        Try
            Dim obj As New ChecadorDA(cadenaConex)
            Return obj.Obtener(checador_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos() As Checadores
        Try
            Dim obj As New ChecadorDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
