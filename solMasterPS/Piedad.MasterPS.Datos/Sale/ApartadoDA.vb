Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ApartadoDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal apartado_ As Apartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaApartado")
            objDA.AgregarParametro("@idCliente", apartado_.IdCliente)
            objDA.AgregarParametro("@idUsuario", apartado_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", apartado_.FechaRegistro)
            objDA.AgregarParametro("@total", apartado_.Total)
            objDA.AgregarParametro("@fechaFinalApartado", apartado_.FechaFinalApartado)
            objDA.AgregarParametro("@vencimientoApartado", apartado_.VencimientoApartado)
            objDA.AgregarParametro("@idEstatusApartado", apartado_.IdEstatusApartado)
            objDA.AgregarParametro("@idApartadoRelacionado", apartado_.IdApartadoRelacionado)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal apartado_ As Apartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarApartado")
            objDA.AgregarParametro("@idApartado", apartado_.IdApartado)
            objDA.AgregarParametro("@idCliente", apartado_.IdCliente)
            objDA.AgregarParametro("@idUsuario", apartado_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", apartado_.FechaRegistro)
            objDA.AgregarParametro("@total", apartado_.Total)
            objDA.AgregarParametro("@fechaFinalApartado", apartado_.FechaFinalApartado)
            objDA.AgregarParametro("@vencimientoApartado", apartado_.VencimientoApartado)
            objDA.AgregarParametro("@idEstatusApartado", apartado_.IdEstatusApartado)
            objDA.AgregarParametro("@idApartadoRelacionado", apartado_.IdApartadoRelacionado)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal apartado_ As Apartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarApartado")
            objDA.AgregarParametro("@idApartado", apartado_.IdApartado)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal apartado_ As Apartado) As Apartado
        Dim ap As Apartado = Nothing
        Dim lst As List(Of Apartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerApartado")
            objDA.AgregarParametro("@idApartado", apartado_.IdApartado)
            lst = objDA.ObtenerResultados(Of Apartado)()
            ap = New Apartado
            ap = lst(0)
        End Using
        Return ap
    End Function
    Public Function ObtenerTodos() As Apartados
        Dim lst As Apartados = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerApartados")
            Dim lista As New List(Of Apartado)
            lista = objDA.ObtenerResultados(Of Apartado)()
            For Each ap As Apartado In lista
                lst.Add(ap)
            Next
        End Using
        Return lst
    End Function
End Class
