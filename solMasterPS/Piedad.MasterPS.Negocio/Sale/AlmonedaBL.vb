Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class AlmonedaBL
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
    Public Sub Almacenar(ByVal almoneda_ As Almoneda)
        Try
            Dim obj As New AlmonedaDA(cadenaConex)
            obj.Almacenar(almoneda_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal almoneda_ As Almoneda)
        Try
            Dim obj As New AlmonedaDA(cadenaConex)
            obj.Actualizar(almoneda_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal almoneda_ As Almoneda)
        Try
            Dim obj As New AlmonedaDA(cadenaConex)
            obj.Eliminar(almoneda_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal almoneda_ As Almoneda) As Almoneda
        Try
            Dim obj As New AlmonedaDA(cadenaConex)
            Return obj.Obtener(almoneda_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As Almonedas
        Try
            Dim obj As New AlmonedaDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
