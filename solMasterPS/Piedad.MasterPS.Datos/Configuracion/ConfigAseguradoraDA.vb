Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ConfigAseguradoraDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal configAseguradora_ As ConfigAseguradora)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaConfigAseguradora")
            objDA.AgregarParametro("@numeroPoliza", configAseguradora_.NumeroPoliza)
            objDA.AgregarParametro("@fechaExpedicion", configAseguradora_.FechaExpedicion)
            objDA.AgregarParametro("@aseguradora", configAseguradora_.Aseguradora)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal configAseguradora_ As ConfigAseguradora)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarConfigAseguradora")
            objDA.AgregarParametro("@idAseguradora", configAseguradora_.IdAseguradora)
            objDA.AgregarParametro("@numeroPoliza", configAseguradora_.NumeroPoliza)
            objDA.AgregarParametro("@fechaExpedicion", configAseguradora_.FechaExpedicion)
            objDA.AgregarParametro("@aseguradora", configAseguradora_.Aseguradora)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal configAseguradora_ As ConfigAseguradora)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarConfigAseguradora")
            objDA.AgregarParametro("@idAseguradora", configAseguradora_.IdAseguradora)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal configAseguradora_ As ConfigAseguradora) As ConfigAseguradora
        Dim confAseg As ConfigAseguradora = Nothing
        Dim lst = New List(Of ConfigAseguradora)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfigAseguradora")
            objDA.AgregarParametro("@idAseguradora", configAseguradora_.IdAseguradora)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of ConfigAseguradora)()
            confAseg = New ConfigAseguradora()
            confAseg = lst(0)
        End Using
        Return confAseg
    End Function
    Public Function ObtenerTodos() As ConfigAseguradoras
        Dim lst As ConfigAseguradoras = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfigAseguradoras")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            Dim lista As New List(Of ConfigAseguradora)
            lista = objDA.ObtenerResultados(Of ConfigAseguradora)()
            For Each confAseg As ConfigAseguradora In lista
                lst.Add(confAseg)
            Next
        End Using
        Return lst
    End Function
End Class
