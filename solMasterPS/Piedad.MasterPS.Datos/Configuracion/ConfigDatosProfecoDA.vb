Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ConfigDatosProfecoDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal configDatosProfeco_ As ConfigDatosProfeco)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaConfigDatosContratoProfeco")
            objDA.AgregarParametro("@numeroContratoAdhesion", configDatosProfeco_.NumeroContratoAdhesion)
            objDA.AgregarParametro("@fechaContratoAdhesion", configDatosProfeco_.FechaContratoAdhesion)
            objDA.AgregarParametro("@paginaWeb", configDatosProfeco_.PaginaWeb)
            objDA.AgregarParametro("@autorizacionMercadeo", configDatosProfeco_.AutorizacionMercadeo)
            objDA.AgregarParametro("@horarioServicioPublico", configDatosProfeco_.HorarioServicioPublico)
            objDA.AgregarParametro("@idSucursal", configDatosProfeco_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal configDatosProfeco_ As ConfigDatosProfeco)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarConfigDatosContratoProfeco")
            objDA.AgregarParametro("@idDatosContratoProfeco", configDatosProfeco_.IdDatosContratoProfeco)
            objDA.AgregarParametro("@numeroContratoAdhesion", configDatosProfeco_.NumeroContratoAdhesion)
            objDA.AgregarParametro("@fechaContratoAdhesion", configDatosProfeco_.FechaContratoAdhesion)
            objDA.AgregarParametro("@paginaWeb", configDatosProfeco_.PaginaWeb)
            objDA.AgregarParametro("@autorizacionMercadeo", configDatosProfeco_.AutorizacionMercadeo)
            objDA.AgregarParametro("@horarioServicioPublico", configDatosProfeco_.HorarioServicioPublico)
            objDA.AgregarParametro("@idSucursal", configDatosProfeco_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal configDatosProfeco_ As ConfigDatosProfeco)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarConfigDatosContratoProfeco")
            objDA.AgregarParametro("@idDatosContratoProfeco", configDatosProfeco_.IdDatosContratoProfeco)
            objDA.AgregarParametro("@idSucursal", configDatosProfeco_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal configDatosProfeco_ As ConfigDatosProfeco) As ConfigDatosProfeco
        Dim confProf As ConfigDatosProfeco = Nothing
        Dim lst As List(Of ConfigDatosProfeco)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfigDatosContratoProfeco")
            objDA.AgregarParametro("@idDatosContratoProfeco", configDatosProfeco_.IdDatosContratoProfeco)
            objDA.AgregarParametro("@idSucursal", configDatosProfeco_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of ConfigDatosProfeco)()
            confProf = New ConfigDatosProfeco()
            confProf = lst(0)
        End Using
        Return confProf
    End Function
    Public Function ObtenerTodos(ByVal configDatosProfeco_ As ConfigDatosProfeco) As ConfigDatosProfecos
        Dim lst As New ConfigDatosProfecos()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("ObtenerConfigDatosContratoProfecos")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", configDatosProfeco_.IdSucursal)
            Dim lista As New List(Of ConfigDatosProfeco)
            lista = objDA.ObtenerResultados(Of ConfigDatosProfeco)()
            For Each confProf As ConfigDatosProfeco In lista
                lst.Add(confProf)
            Next
        End Using
        Return lst
    End Function
End Class
