Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class InventarioDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal inventario_ As Inventario)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaInventario")
            objDA.AgregarParametro("@idMercancia", inventario_.IdMercancia)
            objDA.AgregarParametro("@idAdicionCompra", inventario_.IdAdicionCompra)
            objDA.AgregarParametro("@cantidad", inventario_.Cantidad)
            objDA.AgregarParametro("@idEmpenio", inventario_.IdEmpenio)
            objDA.AgregarParametro("@idDetalleMercanciaVenta", inventario_.IdDetalleMercanciaVenta)
            objDA.AgregarParametro("@diasVencidos", inventario_.DiasVencidos)
            objDA.AgregarParametro("@idTipoIngreso", inventario_.IdTipoIngreso)
            objDA.AgregarParametro("@idEstatusInventario", inventario_.IdEstatusInventario)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal inventario_ As Inventario)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarInventario")
            objDA.AgregarParametro("@idInventario", inventario_.IdInventario)
            objDA.AgregarParametro("@idMercancia", inventario_.IdMercancia)
            objDA.AgregarParametro("@idAdicionCompra", inventario_.IdAdicionCompra)
            objDA.AgregarParametro("@cantidad", inventario_.Cantidad)
            objDA.AgregarParametro("@idEmpenio", inventario_.IdEmpenio)
            objDA.AgregarParametro("@idDetalleMercanciaVenta", inventario_.IdDetalleMercanciaVenta)
            objDA.AgregarParametro("@diasVencidos", inventario_.DiasVencidos)
            objDA.AgregarParametro("@idTipoIngreso", inventario_.IdTipoIngreso)
            objDA.AgregarParametro("@idEstatusInventario", inventario_.IdEstatusInventario)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal inventario_ As Inventario)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarInventario")
            objDA.AgregarParametro("@idInventario", inventario_.IdInventario)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal inventario_ As Inventario) As Inventario
        Dim inv As Inventario = Nothing
        Dim lst As List(Of Inventario)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerInventario")
            objDA.AgregarParametro("@idInventario", inventario_.IdInventario)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Inventario)()
            inv = New Inventario()
            inv = lst(0)
        End Using
        Return inv
    End Function
    Public Function ObtenerTodos() As Inventarios
        Dim lst As Inventarios = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerInventarios")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            Dim lista As New List(Of Inventario)
            lista = objDA.ObtenerResultados(Of Inventario)()
            For Each inv As Inventario In lista
                lst.Add(inv)
            Next
        End Using
        Return lst
    End Function
End Class
