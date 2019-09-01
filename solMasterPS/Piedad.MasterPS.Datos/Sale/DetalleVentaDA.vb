Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class DetalleVentaDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal detalleVenta_ As DetalleVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaDetalleVenta")
            objDA.AgregarParametro("@idVenta", detalleVenta_.IdVenta)
            objDA.AgregarParametro("@idInventario", detalleVenta_.IdInventario)
            objDA.AgregarParametro("@precioOficial", detalleVenta_.PrecioOficial)
            objDA.AgregarParametro("@descuentoPorcentaje", detalleVenta_.DescuentoPorcentaje)
            objDA.AgregarParametro("@precioFinal", detalleVenta_.PrecioFinal)
            objDA.AgregarParametro("@cantidad", detalleVenta_.Cantidad)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal detalleVenta_ As DetalleVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarDetalleVenta")
            objDA.AgregarParametro("@idDetalleVenta", detalleVenta_.IdDetalleVenta)
            objDA.AgregarParametro("@idVenta", detalleVenta_.IdVenta)
            objDA.AgregarParametro("@idInventario", detalleVenta_.IdInventario)
            objDA.AgregarParametro("@precioOficial", detalleVenta_.PrecioOficial)
            objDA.AgregarParametro("@descuentoPorcentaje", detalleVenta_.DescuentoPorcentaje)
            objDA.AgregarParametro("@precioFinal", detalleVenta_.PrecioFinal)
            objDA.AgregarParametro("@cantidad", detalleVenta_.Cantidad)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal detalleVenta_ As DetalleVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarDetalleVenta")
            objDA.AgregarParametro("@idDetalleVenta", detalleVenta_.IdDetalleVenta)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal detalleVenta_ As DetalleVenta) As DetalleVenta
        Dim detalleVta As DetalleVenta = Nothing
        Dim lst As List(Of DetalleVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleVenta")
            objDA.AgregarParametro("@idDetalleVenta", detalleVenta_.IdDetalleVenta)
            lst = objDA.ObtenerResultados(Of DetalleVenta)()
            detalleVta = New DetalleVenta()
            detalleVta = lst(0)
        End Using
        Return detalleVta
    End Function
    Public Function ObtenerTodos() As DetalleVentas
        Dim lst As DetalleVentas = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleVentas")
            Dim lista As New List(Of DetalleVenta)
            lista = objDA.ObtenerResultados(Of DetalleVenta)
            For Each detalleVta As DetalleVenta In lista
                lst.Add(detalleVta)
            Next
        End Using
        Return lst
    End Function
End Class
