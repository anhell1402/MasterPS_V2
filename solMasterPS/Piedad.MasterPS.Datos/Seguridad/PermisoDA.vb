Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class PermisoDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal permiso_ As Permiso)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaPermisos")
            objDA.AgregarParametro("@idMenu", permiso_.IdMenu)
            objDA.AgregarParametro("@idRol", permiso_.IdRol)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal permiso_ As Permiso)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarPermisos")
            objDA.AgregarParametro("@idPermiso", permiso_.IdPermiso)
            objDA.AgregarParametro("@idMenu", permiso_.IdMenu)
            objDA.AgregarParametro("@idRol", permiso_.IdRol)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal permiso_ As Permiso)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarPermisos")
            objDA.AgregarParametro("@idPermiso", permiso_.IdPermiso)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal permiso_ As Permiso) As Permiso
        Dim per As Permiso = Nothing
        Dim lst As List(Of Permiso)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerPermiso")
            objDA.AgregarParametro("@idPermiso", permiso_.IdPermiso)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Permiso)()
            per = New Permiso()
            per = lst(0)
        End Using
        Return per
    End Function
    Public Function ObtenerTodos() As Permisos
        Dim lst As Permisos = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerPermisos")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            Dim lista As New List(Of Permiso)
            lista = objDA.ObtenerResultados(Of Permiso)()
            For Each per As Permiso In lista
                lst.Add(per)
            Next
        End Using
        Return lst
    End Function
End Class