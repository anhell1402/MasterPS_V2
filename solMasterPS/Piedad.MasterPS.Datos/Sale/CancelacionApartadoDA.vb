Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class CancelacionApartadoDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal cancelacionApartado_ As CancelacionApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaCancelacionApartado")
            objDA.AgregarParametro("@idApartado", cancelacionApartado_.IdApartado)
            objDA.AgregarParametro("@idTipoCancelacionApartado", cancelacionApartado_.IdTipoCancelacionApartado)
            objDA.AgregarParametro("@montoActualAbonado", cancelacionApartado_.MontoActualAbonado)
            objDA.AgregarParametro("@idConfigApartado", cancelacionApartado_.IdConfigApartado)
            objDA.AgregarParametro("@montoACuenta", cancelacionApartado_.MontoACuenta)
            objDA.AgregarParametro("@idVenta", cancelacionApartado_.IdVenta)
            objDA.AgregarParametro("@idSucursal", cancelacionApartado_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal cancelacionApartado_ As CancelacionApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarCancelacionApartado")
            objDA.AgregarParametro("@idCancelacionApartado", cancelacionApartado_.IdCancelacionApartado)
            objDA.AgregarParametro("@idApartado", cancelacionApartado_.IdApartado)
            objDA.AgregarParametro("@idTipoCancelacionApartado", cancelacionApartado_.IdTipoCancelacionApartado)
            objDA.AgregarParametro("@montoActualAbonado", cancelacionApartado_.MontoActualAbonado)
            objDA.AgregarParametro("@idConfigApartado", cancelacionApartado_.IdConfigApartado)
            objDA.AgregarParametro("@montoACuenta", cancelacionApartado_.MontoACuenta)
            objDA.AgregarParametro("@idVenta", cancelacionApartado_.IdVenta)
            objDA.AgregarParametro("@idSucursal", cancelacionApartado_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal cancelacionApartado_ As CancelacionApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarCancelacionApartado")
            objDA.AgregarParametro("@idCancelacionApartado", cancelacionApartado_.IdCancelacionApartado)
            objDA.AgregarParametro("@idSucursal", cancelacionApartado_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal cancelacionApartado_ As CancelacionApartado) As CancelacionApartado
        Dim cancelAp As CancelacionApartado = Nothing
        Dim lst As List(Of CancelacionApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerCancelacionApartado")
            objDA.AgregarParametro("@idCancelacionApartado", cancelacionApartado_.IdCancelacionApartado)
            objDA.AgregarParametro("@idSucursal", cancelacionApartado_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of CancelacionApartado)()
            cancelAp = New CancelacionApartado()
            cancelAp = lst(0)
        End Using
        Return cancelAp
    End Function
    Public Function ObtenerTodos(ByVal cancelacionApartado_ As CancelacionApartado) As CancelacionApartados
        Dim lst As New CancelacionApartados()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerCancelacionApartados")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", cancelacionApartado_.IdSucursal)
            Dim lista As New List(Of CancelacionApartado)
            lista = objDA.ObtenerResultados(Of CancelacionApartado)()
            For Each cancelAp As CancelacionApartado In lista
                lst.Add(cancelAp)
            Next
        End Using
        Return lst
    End Function
End Class
