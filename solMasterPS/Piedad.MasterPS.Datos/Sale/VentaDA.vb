Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class VentaDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal Venta_ As Venta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaVenta")
            objDA.AgregarParametro("@idCliente", Venta_.IdCliente)
            objDA.AgregarParametro("@idUsuario", Venta_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", Venta_.FechaRegistro)
            objDA.AgregarParametro("@precioTotal", Venta_.PrecioTotal)
            objDA.AgregarParametro("@idEstatusVenta", Venta_.IdEstatusVenta)
            objDA.AgregarParametro("@idSucursal", Venta_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal Venta_ As Venta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarVenta")
            objDA.AgregarParametro("@idVenta", Venta_.IdVenta)
            objDA.AgregarParametro("@idCliente", Venta_.IdCliente)
            objDA.AgregarParametro("@idUsuario", Venta_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", Venta_.FechaRegistro)
            objDA.AgregarParametro("@precioTotal", Venta_.PrecioTotal)
            objDA.AgregarParametro("@idEstatusVenta", Venta_.IdEstatusVenta)
            objDA.AgregarParametro("@idSucursal", Venta_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal Venta_ As Venta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarVenta")
            objDA.AgregarParametro("@idVenta", Venta_.IdVenta)
            objDA.AgregarParametro("@idSucursal", Venta_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal Venta_ As Venta) As Venta
        Dim Vta As Venta = Nothing
        Dim lst As List(Of Venta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerVenta")
            objDA.AgregarParametro("@idVenta", Venta_.IdVenta)
            objDA.AgregarParametro("@idSucursal", Venta_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Venta)()
            Vta = New Venta()
            Vta = lst(0)
        End Using
        Return Vta
    End Function
    Public Function ObtenerTodos(ByVal Venta_ As Venta) As Ventas
        Dim lst As New Ventas()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerVentas")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", Venta_.IdSucursal)
            Dim lista As New List(Of Venta)
            lista = objDA.ObtenerResultados(Of Venta)()
            For Each Vta As Venta In lista
                lst.Add(Vta)
            Next
        End Using
        Return lst
    End Function
End Class
