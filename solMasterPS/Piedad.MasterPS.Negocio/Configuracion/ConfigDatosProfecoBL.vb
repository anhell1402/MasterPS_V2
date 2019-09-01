Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ConfigDatosProfecoBL
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
    Public Sub Almacenar(ByVal configDatosProfeco_ As ConfigDatosProfeco)
        Try
            Dim obj As New ConfigDatosProfecoDA(cadenaConex)
            obj.Almacenar(configDatosProfeco_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal configDatosProfeco_ As ConfigDatosProfeco)
        Try
            Dim obj As New ConfigDatosProfecoDA(cadenaConex)
            obj.Actualizar(configDatosProfeco_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal configDatosProfeco_ As ConfigDatosProfeco)
        Try
            Dim obj As New ConfigDatosProfecoDA(cadenaConex)
            obj.Eliminar(configDatosProfeco_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal configDatosProfeco_ As ConfigDatosProfeco) As ConfigDatosProfeco
        Try
            Dim obj As New ConfigDatosProfecoDA(cadenaConex)
            Return obj.Obtener(configDatosProfeco_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As ConfigDatosProfecos
        Try
            Dim obj As New ConfigDatosProfecoDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
