Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class DetalleAlmonedaBL
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
    Public Sub Almacenar(ByVal detalleAlmoneda_ As DetalleAlmoneda)
        Try
            Dim obj As New DetalleAlmonedaDA(cadenaConex)
            obj.Almacenar(detalleAlmoneda_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal detalleAlmoneda_ As DetalleAlmoneda)
        Try
            Dim obj As New DetalleAlmonedaDA(cadenaConex)
            obj.Actualizar(detalleAlmoneda_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal detalleAlmoneda_ As DetalleAlmoneda)
        Try
            Dim obj As New DetalleAlmonedaDA(cadenaConex)
            obj.Eliminar(detalleAlmoneda_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal detalleAlmoneda_ As DetalleAlmoneda) As DetalleAlmoneda
        Try
            Dim obj As New DetalleAlmonedaDA(cadenaConex)
            Return obj.Obtener(detalleAlmoneda_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal detalleAlmoneda_ As DetalleAlmoneda) As DetalleAlmonedas
        Try
            Dim obj As New DetalleAlmonedaDA(cadenaConex)
            Return obj.ObtenerTodos(detalleAlmoneda_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
