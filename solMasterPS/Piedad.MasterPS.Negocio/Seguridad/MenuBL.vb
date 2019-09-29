Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos

Public Class MenuBL
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
    Public Sub Almacenar(ByVal menu_ As Menu)
        Try
            Dim obj As New MenuDA(cadenaConex)
            obj.Almacenar(menu_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal menu_ As Menu)
        Try
            Dim obj As New MenuDA(cadenaConex)
            obj.Actualizar(menu_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal menu_ As Menu)
        Try
            Dim obj As New MenuDA(cadenaConex)
            obj.Eliminar(menu_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal menu_ As Menu) As Menu
        Try
            Dim obj As New MenuDA(cadenaConex)
            Return obj.Obtener(menu_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener(ByVal _rol As Generico) As Menus
        Try
            Dim obj As New MenuDA(cadenaConex)
            Return obj.ObtenerTodos(_rol)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
