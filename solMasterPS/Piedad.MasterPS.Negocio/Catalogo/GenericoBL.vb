Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class GenericoBL
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
    Private tipoGen As TipoGenerico
    Public Sub New(ByVal cadenaConex As String, ByVal tipo As TipoGenerico)
        Me.cadenaConex = cadenaConex
        Me.tipoGen = tipo
        _hayError = False
    End Sub
    Public Sub Almacenar(ByVal generic As Generico)
        Try
            Dim obj As New GenericoDA(cadenaConex, tipoGen)
            obj.Almacenar(generic)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal generic As Generico)
        Try
            Dim obj As New GenericoDA(cadenaConex, tipoGen)
            obj.Actualizar(generic)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal generic As Generico)
        Try
            Dim obj As New GenericoDA(cadenaConex, tipoGen)
            obj.Eliminar(generic)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal generic As Generico) As Generico
        Try
            Dim obj As New GenericoDA(cadenaConex, tipoGen)
            Return obj.Obtener(generic)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As Genericos
        Try
            Dim obj As New GenericoDA(cadenaConex, tipoGen)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal ID As Generico) As Genericos
        Try
            Dim obj As New GenericoDA(cadenaConex, tipoGen)
            Return obj.ObtenerTodos(ID)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ObtenerTodosBy(ByVal ID As Generico) As Genericos
        Try
            Dim obj As New GenericoDA(cadenaConex, tipoGen)
            Return obj.ObtenerTodosBy(ID)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
