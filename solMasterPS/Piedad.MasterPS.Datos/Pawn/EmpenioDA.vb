Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class EmpenioDA
    Private cadenaConex As String

    Public Property HayError As Boolean
    Public Property MensajeError As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal empenio_ As Empenio)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaEmpenio")
            objDA.AgregarParametro("@idCliente", empenio_.IdCliente)
            objDA.AgregarParametro("@prestamo", empenio_.Prestamo)
            objDA.AgregarParametro("@idTasa", empenio_.IdTasa)
            objDA.AgregarParametro("@idUsuario", empenio_.IdUsuario)
            objDA.AgregarParametro("@fechaHora", empenio_.FechaHora)
            objDA.AgregarParametro("@avaluo", empenio_.Avaluo)
            objDA.AgregarParametro("@mensaje", empenio_.Mensaje)
            objDA.AgregarParametro("@folio", empenio_.Folio)
            objDA.AgregarParametro("@idTipoEmpenio", empenio_.IdTipoEmpenio)
            objDA.AgregarParametro("@idEstatusEmpenio", empenio_.IdEstatusEmpenio)
            objDA.AgregarParametro("@idSucursal", empenio_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal empenio_ As Empenio)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarEmpenio")
            objDA.AgregarParametro("@idEmpenio", empenio_.IdEmpenio)
            objDA.AgregarParametro("@idCliente", empenio_.IdCliente)
            objDA.AgregarParametro("@prestamo", empenio_.Prestamo)
            objDA.AgregarParametro("@idTasa", empenio_.IdTasa)
            objDA.AgregarParametro("@idUsuario", empenio_.IdUsuario)
            objDA.AgregarParametro("@fechaHora", empenio_.FechaHora)
            objDA.AgregarParametro("@avaluo", empenio_.Avaluo)
            objDA.AgregarParametro("@mensaje", empenio_.Mensaje)
            objDA.AgregarParametro("@folio", empenio_.Folio)
            objDA.AgregarParametro("@idTipoEmpenio", empenio_.IdTipoEmpenio)
            objDA.AgregarParametro("@idEstatusEmpenio", empenio_.IdEstatusEmpenio)
            objDA.AgregarParametro("@idSucursal", empenio_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal empenio_ As Empenio)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarEmpenio")
            objDA.AgregarParametro("@idEmpenio", empenio_.IdEmpenio)
            objDA.AgregarParametro("@idSucursal", empenio_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal empenio_ As Empenio) As Empenio
        Dim emp As Empenio = Nothing
        Dim lst As List(Of Empenio)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerEmpenio")
            objDA.AgregarParametro("@idEmpenio", empenio_.IdEmpenio)
            objDA.AgregarParametro("@idSucursal", empenio_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Empenio)()
            emp = New Empenio()
            emp = lst(0)
        End Using
        Return emp
    End Function
    Public Function ObtenerTodos(ByVal empenio_ As Empenio) As Empenios
        Dim lst As New Empenios()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerEmpenios")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", empenio_.IdSucursal)
            Dim lista As New List(Of Empenio)
            lista = objDA.ObtenerResultados(Of Empenio)()
            For Each emp As Empenio In lista
                lst.Add(emp)
            Next
        End Using
        Return lst
    End Function
    Public Function ObtenerPrecio(ByVal esJoyeria As Boolean, ByVal merca_ As Mercancia, Optional detEmpenio As DetalleEmpenio = Nothing) As Decimal
        Dim lst As New Empenios()
        Dim precio As Decimal = 0
        Using objDA As New ConexDB(cadenaConex)
            If esJoyeria Then
                objDA.CrearComando("select	[dbo].[fn_ObtenerPrecioJoyeria](@idMercanciaMetal ,	@kilataje ,	@estado , @idSucursal , @pesoPrenda , @numPiedras , @pesoPiedra) as precio")
                objDA.EstablecerTipoComando = TipoComando.ComandoEnTexto
                objDA.AgregarParametro("@idMercanciaMetal", merca_.IdTipoMercancia_Metal.IdGenerico)
                objDA.AgregarParametro("@kilataje", merca_.IdFamilia_TipoKilataje.IdGenerico)
                objDA.AgregarParametro("@estado", merca_.IdMarca_EstadoMetal.IdGenerico)
                objDA.AgregarParametro("@idSucursal", merca_.IdSucursal.IdSucursal)
                objDA.AgregarParametro("@pesoPrenda", detEmpenio.Peso)
                objDA.AgregarParametro("@numPiedras", detEmpenio.NumeroPiedras)
                objDA.AgregarParametro("@pesoPiedra", detEmpenio.PesoPiedra)
            Else
                objDA.CrearComando("select	[dbo].[fn_ObtenerPrecioGeneral](@idTipoMercancia_Metal, @idFamilia_TipoKilataje, @idMarca_EstadoMetal , @modelo, @idTipoEmpenio) as precio")
                objDA.EstablecerTipoComando = TipoComando.ComandoEnTexto
                objDA.AgregarParametro("@idTipoMercancia_Metal", merca_.IdTipoMercancia_Metal.IdGenerico)
                objDA.AgregarParametro("@idFamilia_TipoKilataje", merca_.IdFamilia_TipoKilataje.IdGenerico)
                objDA.AgregarParametro("@idMarca_EstadoMetal", merca_.IdMarca_EstadoMetal.IdGenerico)
                objDA.AgregarParametro("@modelo", merca_.Modelo)
                objDA.AgregarParametro("@idTipoEmpenio", merca_.IdTipoEmpenio.IdGenerico)
            End If


            Dim dt As DataTable = objDA.ObtenerResultados()
            If objDA.HayError Then
                HayError = True
                MensajeError = objDA.MensajeError
            Else
                For Each row As DataRow In dt.Rows
                    precio = Convert.ToDecimal(row("precio"))
                Next row

            End If
        End Using
        Return precio
    End Function
End Class
