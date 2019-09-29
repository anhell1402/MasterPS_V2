Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ConfigOtrasVariableDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal configOtrasVariable_ As ConfigOtraVariable)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaConfigOtrasVariable")
            objDA.AgregarParametro("@importeMinimoAbono", configOtrasVariable_.ImporteMinimoAbono)
            objDA.AgregarParametro("@diasEnajenacion", configOtrasVariable_.DiasEnajenacion)
            objDA.AgregarParametro("@margenNegociacion", configOtrasVariable_.MargenNegociacion)
            objDA.AgregarParametro("@importeBoletaExtraviada", configOtrasVariable_.ImporteBoletaExtraviada)
            objDA.AgregarParametro("@importeMinimoCobrar", configOtrasVariable_.ImporteMinimoCobrar)
            objDA.AgregarParametro("@comisionVentaDemasia", configOtrasVariable_.ComisionVentaDemasia)
            objDA.AgregarParametro("@gerente", configOtrasVariable_.Gerente)
            objDA.AgregarParametro("@nota", configOtrasVariable_.Nota)
            objDA.AgregarParametro("@limiteContratoUsuario", configOtrasVariable_.LimiteContratoUsuario)
            objDA.AgregarParametro("@limiteContratoSupervisor", configOtrasVariable_.LimiteContratoSupervisor)
            objDA.AgregarParametro("@limitePrestamoAuto", configOtrasVariable_.LimitePrestamoAuto)
            objDA.AgregarParametro("@restriccionAbonoCapital", configOtrasVariable_.RestriccionAbonoCapital)
            objDA.AgregarParametro("@restriccionInteresMinimo", configOtrasVariable_.RestriccionInteresMinimo)
            objDA.AgregarParametro("@diasInteresMinimo", configOtrasVariable_.DiasInteresMinimo)
            objDA.AgregarParametro("@reporteContratosDiasVencidos", configOtrasVariable_.ReporteContratoDiasVencidos)
            objDA.AgregarParametro("@idSucursal", configOtrasVariable_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal configOtrasVariable_ As ConfigOtraVariable)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarConfigOtrasVariable")
            objDA.AgregarParametro("@idOtrasVariables", configOtrasVariable_.IdOtrasVariables)
            objDA.AgregarParametro("@importeMinimoAbono", configOtrasVariable_.ImporteMinimoAbono)
            objDA.AgregarParametro("@diasEnajenacion", configOtrasVariable_.DiasEnajenacion)
            objDA.AgregarParametro("@margenNegociacion", configOtrasVariable_.MargenNegociacion)
            objDA.AgregarParametro("@importeBoletaExtraviada", configOtrasVariable_.ImporteBoletaExtraviada)
            objDA.AgregarParametro("@importeMinimoCobrar", configOtrasVariable_.ImporteMinimoCobrar)
            objDA.AgregarParametro("@comisionVentaDemasia", configOtrasVariable_.ComisionVentaDemasia)
            objDA.AgregarParametro("@gerente", configOtrasVariable_.Gerente)
            objDA.AgregarParametro("@nota", configOtrasVariable_.Nota)
            objDA.AgregarParametro("@limiteContratoUsuario", configOtrasVariable_.LimiteContratoUsuario)
            objDA.AgregarParametro("@limiteContratoSupervisor", configOtrasVariable_.LimiteContratoSupervisor)
            objDA.AgregarParametro("@limitePrestamoAuto", configOtrasVariable_.LimitePrestamoAuto)
            objDA.AgregarParametro("@restriccionAbonoCapital", configOtrasVariable_.RestriccionAbonoCapital)
            objDA.AgregarParametro("@restriccionInteresMinimo", configOtrasVariable_.RestriccionInteresMinimo)
            objDA.AgregarParametro("@diasInteresMinimo", configOtrasVariable_.DiasInteresMinimo)
            objDA.AgregarParametro("@reporteContratosDiasVencidos", configOtrasVariable_.ReporteContratoDiasVencidos)
            objDA.AgregarParametro("@idSucursal", configOtrasVariable_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal configOtrasVariable_ As ConfigOtraVariable)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarConfigOtrasVariable")
            objDA.AgregarParametro("@idOtrasVariables", configOtrasVariable_.IdOtrasVariables)
            objDA.AgregarParametro("@idSucursal", configOtrasVariable_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal configOtrasVariable_ As ConfigOtraVariable) As ConfigOtraVariable
        Dim confOV As ConfigOtraVariable = Nothing
        Dim lst As List(Of ConfigOtraVariable)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfigOtrasVariable")
            objDA.AgregarParametro("@idOtrasVariables", configOtrasVariable_.IdOtrasVariables)
            objDA.AgregarParametro("@idSucursal", configOtrasVariable_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of ConfigOtraVariable)()
            confOV = New ConfigOtraVariable()
            confOV = lst(0)
        End Using
        Return confOV
    End Function
    Public Function ObtenerTodos(ByVal configOtrasVariable_ As ConfigOtraVariable) As ConfigOtrasVariables
        Dim lst As New ConfigOtrasVariables()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfigOtrasVariables")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", configOtrasVariable_.IdSucursal)
            Dim lista As New List(Of ConfigOtraVariable)
            lista = objDA.ObtenerResultados(Of ConfigOtraVariable)()
            For Each confOV As ConfigOtraVariable In lista
                lst.Add(confOV)
            Next
        End Using
        Return lst
    End Function
End Class
