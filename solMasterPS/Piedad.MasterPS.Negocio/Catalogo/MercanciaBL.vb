Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class MercanciaBL
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
    Public Sub Almacenar(ByVal mercancia_ As Mercancia)
        Try
            Dim obj As New MercanciaDA(cadenaConex)
            obj.Almacenar(mercancia_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal mercancia_ As Mercancia)
        Try
            Dim obj As New MercanciaDA(cadenaConex)
            obj.Actualizar(mercancia_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal mercancia_ As Mercancia)
        Try
            Dim obj As New MercanciaDA(cadenaConex)
            obj.Eliminar(mercancia_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal mercancia_ As Mercancia) As Mercancia
        Try
            Dim obj As New MercanciaDA(cadenaConex)
            Return obj.Obtener(mercancia_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal mercancia_ As Mercancia) As Mercancias
        Try
            Dim obj As New MercanciaDA(cadenaConex)
            Return obj.ObtenerTodos(mercancia_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
