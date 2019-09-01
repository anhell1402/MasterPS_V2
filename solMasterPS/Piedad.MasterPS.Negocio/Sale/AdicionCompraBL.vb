Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos
Public Class AdicionCompraBL
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
    Public Sub Almacenar(ByVal adicionCompra_ As AdicionCompra)
        Try
            Dim obj As New AdicionCompraDA(cadenaConex)
            obj.Almacenar(adicionCompra_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal adicionCompra_ As AdicionCompra)
        Try
            Dim obj As New AdicionCompraDA(cadenaConex)
            obj.Actualizar(adicionCompra_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal adicionCompra_ As AdicionCompra)
        Try
            Dim obj As New AdicionCompraDA(cadenaConex)
            obj.Eliminar(adicionCompra_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal adicionCompra_ As AdicionCompra) As AdicionCompra
        Try
            Dim obj As New AdicionCompraDA(cadenaConex)
            Return obj.Obtener(adicionCompra_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function Obtener() As AdicionesCompras
        Try
            Dim obj As New AdicionCompraDA(cadenaConex)
            Return obj.ObtenerTodos()
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
