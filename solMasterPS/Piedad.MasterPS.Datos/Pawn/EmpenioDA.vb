Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class EmpenioDA
    Private cadenaConex As String
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
End Class
