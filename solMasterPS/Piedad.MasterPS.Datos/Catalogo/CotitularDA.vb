Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class CotitularDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal cotitular_ As Cotitular)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaCotitular")
            objDA.AgregarParametro("@nombre", cotitular_.Nombre)
            objDA.AgregarParametro("@apellidoPaterno", cotitular_.ApellidoPaterno)
            objDA.AgregarParametro("@apellidoMaterno", cotitular_.ApellidoMaterno)
            objDA.AgregarParametro("@idCliente", cotitular_.IdCliente)
            objDA.AgregarParametro("@idTipoIdentificacion", cotitular_.IdTipoIdentificacion)
            objDA.AgregarParametro("@numeroIdentificacion", cotitular_.NumeroIdentificacion)
            objDA.AgregarParametro("@idSucursal", cotitular_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal cotitular_ As Cotitular)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarCotitular")
            objDA.AgregarParametro("@idCotitular", cotitular_.IdCotitular)
            objDA.AgregarParametro("@nombre", cotitular_.Nombre)
            objDA.AgregarParametro("@apellidoPaterno", cotitular_.ApellidoPaterno)
            objDA.AgregarParametro("@apellidoMaterno", cotitular_.ApellidoMaterno)
            objDA.AgregarParametro("@idCliente", cotitular_.IdCliente)
            objDA.AgregarParametro("@idTipoIdentificacion", cotitular_.IdTipoIdentificacion)
            objDA.AgregarParametro("@numeroIdentificacion", cotitular_.NumeroIdentificacion)
            objDA.AgregarParametro("@idSucursal", cotitular_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal cotitular_ As Cotitular)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarCotitular")
            objDA.AgregarParametro("@idCotitular", cotitular_.IdCotitular)
            objDA.AgregarParametro("@idSucursal", cotitular_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal cotitular_ As Cotitular) As Cotitular
        Dim cot As Cotitular = Nothing
        Dim lst As List(Of Cotitular)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerCotitular")
            objDA.AgregarParametro("@idCotitular", cotitular_.IdCotitular)
            objDA.AgregarParametro("@idSucursal", cotitular_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Cotitular)()
            cot = New Cotitular()
            cot = lst(0)
        End Using
        Return cot
    End Function
    Public Function ObtenerTodos(ByVal cotitular_ As Cotitular) As Cotitulares
        Dim lst As New Cotitulares()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerCotitulares")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", cotitular_.IdSucursal)
            Dim lista As New List(Of Cotitular)
            lista = objDA.ObtenerResultados(Of Cotitular)()
            For Each cot As Cotitular In lista
                lst.Add(cot)
            Next
        End Using
        Return lst
    End Function
End Class
