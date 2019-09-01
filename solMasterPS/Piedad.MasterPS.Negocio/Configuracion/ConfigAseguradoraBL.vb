Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ConfigAseguradoraBL
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
    Public Sub Almacenar(ByVal configAseguradora_ As ConfigAseguradora)
        Try
            Dim obj As New ConfigAseguradoraDA(cadenaConex)
            obj.Almacenar(configAseguradora_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal configAseguradora_ As ConfigAseguradora)
        Try
            Dim obj As New ConfigAseguradoraDA(cadenaConex)
            obj.Actualizar(configAseguradora_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal configAseguradora_ As ConfigAseguradora)
        Try
            Dim obj As New ConfigAseguradoraDA(cadenaConex)
            obj.Eliminar(configAseguradora_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal configAseguradora_ As ConfigAseguradora) As ConfigAseguradora
        Try
            Dim obj As New ConfigAseguradoraDA(cadenaConex)
            Return obj.Obtener(configAseguradora_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As ConfigAseguradoras
        Try
            Dim obj As New ConfigAseguradoraDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
