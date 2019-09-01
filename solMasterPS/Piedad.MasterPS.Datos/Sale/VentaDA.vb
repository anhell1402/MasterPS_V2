Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class VentaDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal venta_ As Venta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaVenta")
            objDA.AgregarParametro("@idCliente", venta_.IdCliente)
            objDA.AgregarParametro("@idUsuario", venta_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", venta_.FechaRegistro)
            objDA.AgregarParametro("@precioTotal", venta_.PrecioTotal)
            objDA.AgregarParametro("@idEstatusVenta", venta_.IdEstatusVenta)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal venta_ As Venta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarVenta")
            objDA.AgregarParametro("@idVenta", venta_.IdVenta)
            objDA.AgregarParametro("@idCliente", venta_.IdCliente)
            objDA.AgregarParametro("@idUsuario", venta_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", venta_.FechaRegistro)
            objDA.AgregarParametro("@precioTotal", venta_.PrecioTotal)
            objDA.AgregarParametro("@idEstatusVenta", venta_.IdEstatusVenta)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal venta_ As Venta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarVenta")
            objDA.AgregarParametro("@idVenta", venta_.IdVenta)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal venta_ As Venta) As Venta
        Dim vta As Venta = Nothing
        Dim lst As List(Of Venta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerVenta")
            objDA.AgregarParametro("@idVenta", venta_.IdVenta)
            lst = objDA.ObtenerResultados(Of Venta)()
            vta = New Venta()
            vta = lst(0)
        End Using
        Return vta
    End Function
    Public Function ObtenerTodos() As Ventas
        Dim lst As Ventas = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerVentas")
            Dim lista As New List(Of Venta)
            lista = objDA.ObtenerResultados(Of Venta)()
            For Each vta As Venta In lista
                lst.Add(vta)
            Next
        End Using
        Return lst
    End Function
End Class
