Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos

Public Class CACBL
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
    Public Sub Almacenar(ByVal cac_ As CAC)
        Try
            Dim obj As New CACDA(cadenaConex)
            obj.Almacenar(cac_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try

    End Sub
    Public Sub Actualizar(ByVal cac_ As CAC)
        Try
            Dim obj As New CACDA(cadenaConex)
            obj.Actualizar(cac_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal cac_ As CAC)
        Try
            Dim obj As New CACDA(cadenaConex)
            obj.Eliminar(cac_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal cac_ As CAC) As CAC
        Try
            Dim obj As New CACDA(cadenaConex)
            Return obj.Obtener(cac_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As CACS
        Try
            Dim obj As New CACDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
