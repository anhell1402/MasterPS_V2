Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class AutenticacionBL
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
    Public Function AutenciaUsuario(ByVal user As Usuario) As Usuario
        Dim obj As New AutenticacionDA(cadenaConex)
        user = obj.AutenticaUsuario(user)
        _hayError = obj.HayError
        _error = obj.MensajeError
        Return user
    End Function
    Public Sub RestablecerPasswd(ByVal user As Usuario)
        Dim obj As New AutenticacionDA(cadenaConex)
        obj.RestablecerPasswd(user)
        _hayError = obj.HayError
        _error = obj.MensajeError
    End Sub
    Public Function OlvidaPasswd(ByVal user As Usuario) As Usuario
        Dim obj As New AutenticacionDA(cadenaConex)
        user = obj.OlvidaPasswd(user)
        _hayError = obj.HayError
        _error = obj.MensajeError
        Return user
    End Function
End Class
