Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class EmpenioBL
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
    Public Sub Almacenar(ByVal empenio_ As Empenio)
        Try
            Dim obj As New EmpenioDA(cadenaConex)
            obj.Almacenar(empenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal empenio_ As Empenio)
        Try
            Dim obj As New EmpenioDA(cadenaConex)
            obj.Actualizar(empenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal empenio_ As Empenio)
        Try
            Dim obj As New EmpenioDA(cadenaConex)
            obj.Eliminar(empenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal empenio_ As Empenio) As Empenio
        Try
            Dim obj As New EmpenioDA(cadenaConex)
            Return obj.Obtener(empenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal empenio_ As Empenio) As Empenios
        Try
            Dim obj As New EmpenioDA(cadenaConex)
            Return obj.ObtenerTodos(empenio_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPrecio(ByVal esJoyeria As Boolean, ByVal merca_ As Mercancia) As Decimal
        Dim precio As Decimal = 0
        Try
            Dim obj As New EmpenioDA(cadenaConex)
            precio = obj.ObtenerPrecio(esJoyeria, merca_)
            _hayError = obj.HayError
            _error = obj.MensajeError
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
        Return precio
    End Function
End Class
