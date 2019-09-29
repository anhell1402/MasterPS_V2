Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class ConfigOtrasVariableBL
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
    Public Sub Almacenar(ByVal configOtraVariable_ As ConfigOtraVariable)
        Try
            Dim obj As New ConfigOtrasVariableDA(cadenaConex)
            obj.Almacenar(configOtraVariable_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal configOtraVariable_ As ConfigOtraVariable)
        Try
            Dim obj As New ConfigOtrasVariableDA(cadenaConex)
            obj.Actualizar(configOtraVariable_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal configOtraVariable_ As ConfigOtraVariable)
        Try
            Dim obj As New ConfigOtrasVariableDA(cadenaConex)
            obj.Eliminar(configOtraVariable_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal configOtraVariable_ As ConfigOtraVariable) As ConfigOtraVariable
        Try
            Dim obj As New ConfigOtrasVariableDA(cadenaConex)
            Return obj.Obtener(configOtraVariable_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal configOtraVariable_ As ConfigOtraVariable) As ConfigOtrasVariables
        Try
            Dim obj As New ConfigOtrasVariableDA(cadenaConex)
            Return obj.ObtenerTodos(configOtraVariable_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
