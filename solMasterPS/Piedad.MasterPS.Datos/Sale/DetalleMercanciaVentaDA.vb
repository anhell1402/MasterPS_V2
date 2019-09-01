Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class DetalleMercanciaVentaDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal detalleMercVta_ As DetalleMercanciaVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaDetalleMercanciaVenta")
            objDA.AgregarParametro("@descripcion", detalleMercVta_.Descripcion)
            objDA.AgregarParametro("@idMercancia", detalleMercVta_.IdMercancia)
            objDA.AgregarParametro("@precioUnitario", detalleMercVta_.PrecioUnitario)
            objDA.AgregarParametro("@avaluo", detalleMercVta_.Avaluo)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal detalleMercVta_ As DetalleMercanciaVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarDetalleMercanciaVenta")
            objDA.AgregarParametro("@idDetalleMercanciaVenta", detalleMercVta_.IdDetalleMercanciaVenta)
            objDA.AgregarParametro("@descripcion", detalleMercVta_.Descripcion)
            objDA.AgregarParametro("@idMercancia", detalleMercVta_.IdMercancia)
            objDA.AgregarParametro("@precioUnitario", detalleMercVta_.PrecioUnitario)
            objDA.AgregarParametro("@avaluo", detalleMercVta_.Avaluo)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal detalleMercVta_ As DetalleMercanciaVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarDetalleMercanciaVenta")
            objDA.AgregarParametro("@idDetalleMercanciaVenta", detalleMercVta_.IdDetalleMercanciaVenta)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal detalleMercVenta_ As DetalleMercanciaVenta) As DetalleMercanciaVenta
        Dim detalleMV As DetalleMercanciaVenta = Nothing
        Dim lst As List(Of DetalleMercanciaVenta)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleMercanciaVenta")
            objDA.AgregarParametro("@idDetalleMercanciaVenta", detalleMercVenta_.IdDetalleMercanciaVenta)
            lst = objDA.ObtenerResultados(Of DetalleMercanciaVenta)()
            detalleMV = New DetalleMercanciaVenta()
            detalleMV = lst(0)
        End Using
        Return detalleMV
    End Function
    Public Function ObtenerTodos() As DetalleMercanciaVentas
        Dim lst As DetalleMercanciaVentas = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleMercanciasVentas")
            Dim lista As New List(Of DetalleMercanciaVenta)
            lista = objDA.ObtenerResultados(Of DetalleMercanciaVenta)()
            For Each detalleMV As DetalleMercanciaVenta In lista
                lst.Add(detalleMV)
            Next
        End Using
        Return lst
    End Function
End Class
