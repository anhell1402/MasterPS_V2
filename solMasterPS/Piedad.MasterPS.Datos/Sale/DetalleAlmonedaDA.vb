Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class DetalleAlmonedaDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal detalleAlmoneda_ As DetalleAlmoneda)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaDetalleAlmoneda")
            objDA.AgregarParametro("@idAlmoneda", detalleAlmoneda_.IdAlmoneda)
            objDA.AgregarParametro("@idEmpenio", detalleAlmoneda_.IdEmpenio)
            objDA.AgregarParametro("@idTipoEmpenio", detalleAlmoneda_.IdTipoEmpenio)
            objDA.AgregarParametro("@liberado", detalleAlmoneda_.Liberado)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal detalleAlmoneda_ As DetalleAlmoneda)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarDetalleAlmoneda")
            objDA.AgregarParametro("@idDetalleAlmoneda", detalleAlmoneda_.IdDetalleAlmoneda)
            objDA.AgregarParametro("@idAlmoneda", detalleAlmoneda_.IdAlmoneda)
            objDA.AgregarParametro("@idEmpenio", detalleAlmoneda_.IdEmpenio)
            objDA.AgregarParametro("@idTipoEmpenio", detalleAlmoneda_.IdTipoEmpenio)
            objDA.AgregarParametro("@liberado", detalleAlmoneda_.Liberado)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal detalleAlmoneda_ As DetalleAlmoneda)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarDetalleAlmoneda")
            objDA.AgregarParametro("@idDetalleAlmoneda", detalleAlmoneda_.IdDetalleAlmoneda)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal detalleAlmoneda_ As DetalleAlmoneda) As DetalleAlmoneda
        Dim detalleAl As DetalleAlmoneda = Nothing
        Dim lst As List(Of DetalleAlmoneda)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleAlmoneda")
            objDA.AgregarParametro("@idDetalleAlmoneda", detalleAlmoneda_.IdDetalleAlmoneda)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of DetalleAlmoneda)()
            detalleAl = New DetalleAlmoneda()
            detalleAl = lst(0)
        End Using
        Return detalleAl
    End Function
    Public Function ObtenerTodos() As DetalleAlmonedas
        Dim lst As DetalleAlmonedas = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleAlmonedas")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            Dim lista As New List(Of DetalleAlmoneda)
            lista = objDA.ObtenerResultados(Of DetalleAlmoneda)()
            For Each detalleAl As DetalleAlmoneda In lista
                lst.Add(detalleAl)
            Next
        End Using
        Return lst
    End Function
End Class
