Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.Datos

Public Class DetalleMercanciaVentaBL
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
    Public Sub Almacenar(ByVal detalleMercanciaVenta_ As DetalleMercanciaVenta)
        Try
            Dim obj As New DetalleMercanciaVentaDA(cadenaConex)
            obj.Almacenar(detalleMercanciaVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Actualizar(ByVal detalleMercanciaVenta_ As DetalleMercanciaVenta)
        Try
            Dim obj As New DetalleMercanciaVentaDA(cadenaConex)
            obj.Actualizar(detalleMercanciaVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Sub Eliminar(ByVal detalleMercanciaVenta_ As DetalleMercanciaVenta)
        Try
            Dim obj As New DetalleMercanciaVentaDA(cadenaConex)
            obj.Eliminar(detalleMercanciaVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
        End Try
    End Sub
    Public Function Obtener(ByVal detalleMercanciaVenta_ As DetalleMercanciaVenta) As DetalleMercanciaVenta
        Try
            Dim obj As New DetalleMercanciaVentaDA(cadenaConex)
            Return obj.Obtener(detalleMercanciaVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ObtenerTodos(ByVal detalleMercanciaVenta_ As DetalleMercanciaVenta) As DetalleMercanciaVentas
        Try
            Dim obj As New DetalleMercanciaVentaDA(cadenaConex)
            Return obj.ObtenerTodos(detalleMercanciaVenta_)
            _hayError = False
        Catch ex As Exception
            _hayError = True
            _error = ex.Message
            Return Nothing
        End Try
    End Function
End Class
