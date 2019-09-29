Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class DocumentoBL
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
    Public Sub Almacenar(ByVal documento_ As Documento)
        Try
            Dim obj As New DocumentoDA(cadenaConex)
            obj.Almacenar(documento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal documento_ As Documento)
        Try
            Dim obj As New DocumentoDA(cadenaConex)
            obj.Actualizar(documento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal documento_ As Documento)
        Try
            Dim obj As New DocumentoDA(cadenaConex)
            obj.Eliminar(documento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal documento_ As Documento) As Documento
        Try
            Dim obj As New DocumentoDA(cadenaConex)
            Return obj.Obtener(documento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal documento_ As Documento) As Documentos
        Try
            Dim obj As New DocumentoDA(cadenaConex)
            Return obj.ObtenerTodos(documento_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
