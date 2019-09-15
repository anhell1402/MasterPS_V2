Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class AlmonedaDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal almoneda_ As Almoneda)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaAlmoneda")
            objDA.AgregarParametro("@idUsuario", almoneda_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", almoneda_.FechaRegistro)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal almoneda_ As Almoneda)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarAlmoneda")
            objDA.AgregarParametro("@idAlmoneda", almoneda_.IdAlmoneda)
            objDA.AgregarParametro("@idUsuario", almoneda_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", almoneda_.FechaRegistro)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal almoneda_ As Almoneda)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarAlmoneda")
            objDA.AgregarParametro("@idAlmoneda", almoneda_.IdAlmoneda)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal almoneda_ As Almoneda) As Almoneda
        Dim almo As Almoneda = Nothing
        Dim lst As List(Of Almoneda)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerAlmoneda")
            objDA.AgregarParametro("@idAlmoneda", almoneda_.IdAlmoneda)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Almoneda)()
            almo = New Almoneda()
            almo = lst(0)
        End Using
        Return almo
    End Function
    Public Function ObtenerTodos() As Almonedas
        Dim lst As Almonedas = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerAlmonedas")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            Dim lista As New List(Of Almoneda)
            lista = objDA.ObtenerResultados(Of Almoneda)()
            For Each almo As Almoneda In lista
                lst.Add(almo)
            Next
        End Using
        Return lst
    End Function
End Class
