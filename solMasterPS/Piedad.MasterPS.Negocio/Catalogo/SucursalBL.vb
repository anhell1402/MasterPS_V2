Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class SucursalBL
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
    Public Sub Almacenar(ByVal sucursal_ As Sucursal)
        Try
            Dim obj As New SucursalDA(cadenaConex)
            obj.Almacenar(sucursal_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal sucursal_ As Sucursal)
        Try
            Dim obj As New SucursalDA(cadenaConex)
            obj.Actualizar(sucursal_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal sucursal_ As Sucursal)
        Try
            Dim obj As New SucursalDA(cadenaConex)
            obj.Eliminar(sucursal_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal sucursal_ As Sucursal) As Sucursal
        Try
            Dim obj As New SucursalDA(cadenaConex)
            Return Obtener(sucursal_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As Sucursales
        Try
            Dim obj As New SucursalDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
