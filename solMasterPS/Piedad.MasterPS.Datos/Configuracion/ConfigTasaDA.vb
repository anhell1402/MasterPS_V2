Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ConfigTasaDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal configTasa_ As ConfigTasa)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaTasa")
            objDA.AgregarParametro("@idTipoTasa", configTasa_.IdTipoTasa)
            objDA.AgregarParametro("@idPeriodo", configTasa_.IdPeriodo)
            objDA.AgregarParametro("@plazo", configTasa_.Plazo)
            objDA.AgregarParametro("@tasaTipica", configTasa_.TasaTipica)
            objDA.AgregarParametro("@tasaPromocional", configTasa_.TasaPromocional)
            objDA.AgregarParametro("@tasaPreferencial", configTasa_.TasaPreferencial)
            objDA.AgregarParametro("@porcentajePrestamo", configTasa_.PorcentajePrestamo)
            objDA.AgregarParametro("@CAT", configTasa_.CAT)
            objDA.AgregarParametro("@interesAnual", configTasa_.InteresAnual)
            objDA.AgregarParametro("@almacenaje", configTasa_.Almacenaje)
            objDA.AgregarParametro("@seguro", configTasa_.Seguro)
            objDA.AgregarParametro("@diasMinimos", configTasa_.DiasMinimos)
            objDA.AgregarParametro("@diasGracia", configTasa_.DiasGracia)
            objDA.AgregarParametro("@idSucursal", configTasa_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal configTasa_ As ConfigTasa)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarTasa")
            objDA.AgregarParametro("@idTasa", configTasa_.IdTasa)
            objDA.AgregarParametro("@idTipoTasa", configTasa_.IdTipoTasa)
            objDA.AgregarParametro("@idPeriodo", configTasa_.IdPeriodo)
            objDA.AgregarParametro("@plazo", configTasa_.Plazo)
            objDA.AgregarParametro("@tasaTipica", configTasa_.TasaTipica)
            objDA.AgregarParametro("@tasaPromocional", configTasa_.TasaPromocional)
            objDA.AgregarParametro("@tasaPreferencial", configTasa_.TasaPreferencial)
            objDA.AgregarParametro("@porcentajePrestamo", configTasa_.PorcentajePrestamo)
            objDA.AgregarParametro("@CAT", configTasa_.CAT)
            objDA.AgregarParametro("@interesAnual", configTasa_.InteresAnual)
            objDA.AgregarParametro("@almacenaje", configTasa_.Almacenaje)
            objDA.AgregarParametro("@seguro", configTasa_.Seguro)
            objDA.AgregarParametro("@diasMinimos", configTasa_.DiasMinimos)
            objDA.AgregarParametro("@diasGracia", configTasa_.DiasGracia)
            objDA.AgregarParametro("@idSucursal", configTasa_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal configTasa_ As ConfigTasa)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarTasa")
            objDA.AgregarParametro("@idTasa", configTasa_.IdTasa)
            objDA.AgregarParametro("@idSucursal", configTasa_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal configTasa_ As ConfigTasa)
        Dim confTasa As ConfigTasa = Nothing
        Dim lst As List(Of ConfigTasa)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerTasa")
            objDA.AgregarParametro("@idTasa", configTasa_.IdTasa)
            objDA.AgregarParametro("@idSucursal", configTasa_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of ConfigTasa)()
            confTasa = New ConfigTasa()
            confTasa = lst(0)
        End Using
        Return confTasa
    End Function
    Public Function ObtenerTodos(ByVal configTasa_ As ConfigTasa) As ConfigTasas
        Dim lst As New ConfigTasas()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerTasas")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", configTasa_.IdSucursal)
            Dim lista As New List(Of ConfigTasa)
            lista = objDA.ObtenerResultados(Of ConfigTasa)()
            For Each confTasa As ConfigTasa In lista
                lst.Add(confTasa)
            Next
        End Using
        Return lst
    End Function
End Class
