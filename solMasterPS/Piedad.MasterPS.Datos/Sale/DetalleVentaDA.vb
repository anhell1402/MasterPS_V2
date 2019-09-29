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
            objDA.AgregarParametro("@idSucursal", detalleVenta_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
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
            objDA.AgregarParametro("@idSucursal", detalleVenta_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal detalleVenta_ As DetalleVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarDetalleVenta")
            objDA.AgregarParametro("@idDetalleVenta", detalleVenta_.IdDetalleVenta)
            objDA.AgregarParametro("@idSucursal", detalleVenta_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal detalleVenta_ As DetalleVenta) As DetalleVenta
        Dim detalleVta As DetalleVenta = Nothing
        Dim lst As List(Of DetalleVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleVenta")
            objDA.AgregarParametro("@idDetalleVenta", detalleVenta_.IdDetalleVenta)
            objDA.AgregarParametro("@idSucursal", detalleVenta_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of DetalleVenta)()
            detalleVta = New DetalleVenta()
            detalleVta = lst(0)
        End Using
        Return detalleVta
    End Function
    Public Function ObtenerTodos(ByVal detalleVenta_ As DetalleVenta) As DetalleVentas
        Dim lst As New DetalleVentas()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleVentas")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", detalleVenta_.IdSucursal)
            Dim lista As New List(Of DetalleVenta)
            lista = objDA.ObtenerResultados(Of DetalleVenta)()
            For Each detalleVta As DetalleVenta In lista
                lst.Add(detalleVta)
            Next
        End Using
        Return lst
    End Function
End Class
