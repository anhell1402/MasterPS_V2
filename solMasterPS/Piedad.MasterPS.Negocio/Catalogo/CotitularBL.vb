Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class CotitularBL
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
    Public Sub Almacenar(ByVal cotitular_ As Cotitular)
        Try
            Dim obj As New CotitularDA(cadenaConex)
            obj.Almacenar(cotitular_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal cotitular_ As Cotitular)
        Try
            Dim obj As New CotitularDA(cadenaConex)
            obj.Actualizar(cotitular_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal cotitular_ As Cotitular)
        Try
            Dim obj As New CotitularDA(cadenaConex)
            obj.Eliminar(cotitular_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal cotitular_ As Cotitular) As Cotitular
        Try
            Dim obj As New CotitularDA(cadenaConex)
            Return obj.Obtener(cotitular_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal cotitular_ As Cotitular) As Cotitulares
        Try
            Dim obj As New CotitularDA(cadenaConex)
            Return obj.ObtenerTodos(cotitular_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class

