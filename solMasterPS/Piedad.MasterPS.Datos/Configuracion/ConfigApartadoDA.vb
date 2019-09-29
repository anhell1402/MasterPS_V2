Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ConfigApartadoDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal configApartado_ As ConfigApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaConfiguracionApartado")
            objDA.AgregarParametro("@vencimientoApartado", configApartado_.VencimientoApartado)
            objDA.AgregarParametro("@engancheApartado", configApartado_.EngancheApartado)
            objDA.AgregarParametro("@ivaVenta", configApartado_.IvaVenta)
            objDA.AgregarParametro("@descuentoAutorizado", configApartado_.DescuentoAutorizado)
            objDA.AgregarParametro("@diasGracia", configApartado_.DiasGracia)
            objDA.AgregarParametro("@penalizacionCancelacion", configApartado_.PenalizacionCancelacion)
            objDA.AgregarParametro("@idSucursal", configApartado_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal configApartado_ As ConfigApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarConfiguracionApartado")
            objDA.AgregarParametro("@idConfigApartado", configApartado_.IdConfigApartado)
            objDA.AgregarParametro("@vencimientoApartado", configApartado_.VencimientoApartado)
            objDA.AgregarParametro("@engancheApartado", configApartado_.EngancheApartado)
            objDA.AgregarParametro("@ivaVenta", configApartado_.IvaVenta)
            objDA.AgregarParametro("@descuentoAutorizado", configApartado_.DescuentoAutorizado)
            objDA.AgregarParametro("@diasGracia", configApartado_.DiasGracia)
            objDA.AgregarParametro("@penalizacionCancelacion", configApartado_.PenalizacionCancelacion)
            objDA.AgregarParametro("@idSucursal", configApartado_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal configApartado_ As ConfigApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarConfiguracionApartado")
            objDA.AgregarParametro("@idConfigApartado", configApartado_.IdConfigApartado)
            objDA.AgregarParametro("@idSucursal", configApartado_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal configApartado_ As ConfigApartado) As ConfigApartado
        Dim confAp As ConfigApartado = Nothing
        Dim lst As List(Of ConfigApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfiguracionApartado")
            objDA.AgregarParametro("@idConfigApartado", configApartado_.IdConfigApartado)
            objDA.AgregarParametro("@idSucursal", configApartado_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of ConfigApartado)()
            confAp = New ConfigApartado()
            confAp = lst(0)
        End Using
        Return confAp
    End Function
    Public Function ObtenerTodos(ByVal configApartado_ As ConfigApartado) As ConfigApartados
        Dim lst As New ConfigApartados()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfiguracionApartados")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", configApartado_.IdSucursal)
            Dim lista As New List(Of ConfigApartado)
            lista = objDA.ObtenerResultados(Of ConfigApartado)()
            For Each confAp As ConfigApartado In lista
                lst.Add(confAp)
            Next
        End Using
        Return lst
    End Function
End Class
