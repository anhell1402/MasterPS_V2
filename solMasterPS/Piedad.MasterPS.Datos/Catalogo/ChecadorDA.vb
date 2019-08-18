Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ChecadorDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub

    Public Sub Almacenar(ByVal checador_ As Checador)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaChecador")
            objDA.AgregarParametro("@idSucursal", checador_.IdSucursal)
            objDA.AgregarParametro("@idUsuario", checador_.IdUsuario)
            objDA.AgregarParametro("@idMotivo", checador_.IdMotivo)
            objDA.AgregarParametro("@idCaja", checador_.IdCaja)
            objDA.AgregarParametro("@fechaHora", checador_.FechaHora)
            objDA.AgregarParametro("@entrada", checador_.Entrada)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal checador_ As Checador)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarChecador")
            objDA.AgregarParametro("@idChecador", checador_.IdChecador)
            objDA.AgregarParametro("@idSucursal", checador_.IdSucursal)
            objDA.AgregarParametro("@idUsuario", checador_.IdUsuario)
            objDA.AgregarParametro("@idMotivo", checador_.IdMotivo)
            objDA.AgregarParametro("@idCaja", checador_.IdCaja)
            objDA.AgregarParametro("@fechaHora", checador_.FechaHora)
            objDA.AgregarParametro("@entrada", checador_.Entrada)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal checador_ As Checador)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarChecador")
            objDA.AgregarParametro("@idChecador", checador_.IdChecador)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal checador_ As Checador) As Checador
        Dim chk As Checador = Nothing
        Dim lst As List(Of Checador)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerChecador")
            objDA.AgregarParametro("@idChecador", checador_.IdChecador)
            lst = objDA.ObtenerResultados(Of Checador)()
            chk = New Checador()
            chk = lst(0)
        End Using
        Return chk
    End Function
    Public Function ObtenerTodos() As Checadores
        Dim lst As Checadores = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerChecadores")
            Dim lista As New List(Of Checador)
            lista = objDA.ObtenerResultados(Of Checador)()
            For Each chk As Checador In lista
                lst.Add(chk)
            Next
        End Using
        Return lst
    End Function
End Class
