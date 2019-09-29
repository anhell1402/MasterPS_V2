Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class AbonosApartadoBL
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
    Public Sub Almacenar(ByVal abonosApartado_ As AbonosApartado)
        Try
            Dim obj As New AbonosApartadoDA(cadenaConex)
            obj.Almacenar(abonosApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal abonosApartado_ As AbonosApartado)
        Try
            Dim obj As New AbonosApartadoDA(cadenaConex)
            obj.Actualizar(abonosApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal abonosApartado_ As AbonosApartado)
        Try
            Dim obj As New AbonosApartadoDA(cadenaConex)
            obj.Eliminar(abonosApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal abonosApartado_ As AbonosApartado) As AbonosApartado
        Try
            Dim obj As New AbonosApartadoDA(cadenaConex)
            Return obj.Obtener(abonosApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal abonosApartado_ As AbonosApartado) As AbonosApartados
        Try
            Dim obj As New AbonosApartadoDA(cadenaConex)
            Return obj.ObtenerTodos(abonosApartado_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
