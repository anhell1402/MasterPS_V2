Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class MovimientoDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal movimiento_ As Movimiento)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaRegistroMovimientoEmpenio")
            objDA.AgregarParametro("@fechaOperacion", movimiento_.FechaOperacion)
            objDA.AgregarParametro("@diasDiferencia", movimiento_.DiasDiferencia)
            objDA.AgregarParametro("@diasReal", movimiento_.DiasReal)
            objDA.AgregarParametro("@importeDiasDiferencia", movimiento_.ImporteDiasDiferencia)
            objDA.AgregarParametro("@interesDiario", movimiento_.InteresDiario)
            objDA.AgregarParametro("@montoLiquidacion", movimiento_.MontoLiquidacion)
            objDA.AgregarParametro("@idEmpenio", movimiento_.IdEmpenio)
            objDA.AgregarParametro("@prestamo", movimiento_.Prestamo)
            objDA.AgregarParametro("@importePagado", movimiento_.ImportePagado)
            objDA.AgregarParametro("@abonoCapital", movimiento_.AbonoCapital)
            objDA.AgregarParametro("@interes", movimiento_.Interes)
            objDA.AgregarParametro("@diasPorPagar", movimiento_.DiasPorPagar)
            objDA.AgregarParametro("@interesMesUno", movimiento_.InteresMesUno)
            objDA.AgregarParametro("@liquidacionMesUno", movimiento_.LiquidacionMesUno)
            objDA.AgregarParametro("@interesMesDos", movimiento_.InteresMesDos)
            objDA.AgregarParametro("@liquidacionMesDos", movimiento_.LiquidacionMesDos)
            objDA.AgregarParametro("@fechaMesUno", movimiento_.FechaMesUno)
            objDA.AgregarParametro("@fechaMesDos", movimiento_.FechaMesDos)
            objDA.AgregarParametro("@idTipoOperacionEmpenio", movimiento_.IdTipoOperacionEmpenio)
            objDA.AgregarParametro("@idEstatusEmpenio", movimiento_.IdEstatusEmpenio)
            objDA.AgregarParametro("@idUsuario", movimiento_.IdUsuario)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal movimiento_ As Movimiento)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarRegistroMovimientoEmpenio")
            objDA.AgregarParametro("@idFolio", movimiento_.IdFolio)
            objDA.AgregarParametro("@fechaOperacion", movimiento_.FechaOperacion)
            objDA.AgregarParametro("@diasDiferencia", movimiento_.DiasDiferencia)
            objDA.AgregarParametro("@diasReal", movimiento_.DiasReal)
            objDA.AgregarParametro("@importeDiasDiferencia", movimiento_.ImporteDiasDiferencia)
            objDA.AgregarParametro("@interesDiario", movimiento_.InteresDiario)
            objDA.AgregarParametro("@montoLiquidacion", movimiento_.MontoLiquidacion)
            objDA.AgregarParametro("@idEmpenio", movimiento_.IdEmpenio)
            objDA.AgregarParametro("@prestamo", movimiento_.Prestamo)
            objDA.AgregarParametro("@importePagado", movimiento_.ImportePagado)
            objDA.AgregarParametro("@abonoCapital", movimiento_.AbonoCapital)
            objDA.AgregarParametro("@interes", movimiento_.Interes)
            objDA.AgregarParametro("@diasPorPagar", movimiento_.DiasPorPagar)
            objDA.AgregarParametro("@interesMesUno", movimiento_.InteresMesUno)
            objDA.AgregarParametro("@liquidacionMesUno", movimiento_.LiquidacionMesUno)
            objDA.AgregarParametro("@interesMesDos", movimiento_.InteresMesDos)
            objDA.AgregarParametro("@liquidacionMesDos", movimiento_.LiquidacionMesDos)
            objDA.AgregarParametro("@fechaMesUno", movimiento_.FechaMesUno)
            objDA.AgregarParametro("@fechaMesDos", movimiento_.FechaMesDos)
            objDA.AgregarParametro("@idTipoOperacionEmpenio", movimiento_.IdTipoOperacionEmpenio)
            objDA.AgregarParametro("@idEstatusEmpenio", movimiento_.IdEstatusEmpenio)
            objDA.AgregarParametro("@idUsuario", movimiento_.IdUsuario)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal movimiento_ As Movimiento)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarRegistroMovimientoEmpenio")
            objDA.AgregarParametro("@idFolio", movimiento_.IdFolio)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal movimiento_ As Movimiento) As Movimiento
        Dim regEmp As Movimiento = Nothing
        Dim lst As List(Of Movimiento)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerRegistroMovimientoEmpenio")
            objDA.AgregarParametro("@idFolio", movimiento_.IdFolio)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Movimiento)()
            regEmp = New Movimiento()
            regEmp = lst(0)
        End Using
        Return regEmp
    End Function
    Public Function ObtenerTodos() As Movimientos
        Dim lst As Movimientos = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerRegistroMovimientoEmpenios")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            Dim lista As New List(Of Movimiento)
            lista = objDA.ObtenerResultados(Of Movimiento)()
            For Each regEmp As Movimiento In lista
                lst.Add(regEmp)
            Next
        End Using
        Return lst
    End Function
End Class
