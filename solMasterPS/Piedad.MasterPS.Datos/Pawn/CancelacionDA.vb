Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class CancelacionDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal cancelacion_ As Cancelacion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaCancelacion")
            objDA.AgregarParametro("@idVenta", cancelacion_.IdVenta)
            objDA.AgregarParametro("@idUsuario", cancelacion_.IdUsuario)
            objDA.AgregarParametro("@descripcion", cancelacion_.Descripcion)
            objDA.AgregarParametro("@fecha", cancelacion_.Fecha)
            objDA.AgregarParametro("@idEmpenio", cancelacion_.IdEmpenio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal cancelacion_ As Cancelacion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarCancelacion")
            objDA.AgregarParametro("@idCancelacion", cancelacion_.IdCancelacion)
            objDA.AgregarParametro("@idVenta", cancelacion_.IdVenta)
            objDA.AgregarParametro("@idUsuario", cancelacion_.IdUsuario)
            objDA.AgregarParametro("@descripcion", cancelacion_.Descripcion)
            objDA.AgregarParametro("@fecha", cancelacion_.Fecha)
            objDA.AgregarParametro("@idEmpenio", cancelacion_.IdEmpenio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal cancelacion_ As Cancelacion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarCancelacion")
            objDA.AgregarParametro("@idCancelacion", cancelacion_.IdCancelacion)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal cancelacion_ As Cancelacion) As Cancelacion
        Dim cancel As Cancelacion = Nothing
        Dim lst As List(Of Cancelacion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerCancelacion")
            objDA.AgregarParametro("@idCancelacion", cancelacion_.IdCancelacion)
            lst = objDA.ObtenerResultados(Of Cancelacion)()
            cancel = New Cancelacion()
            cancel = lst(0)
        End Using
        Return cancel
    End Function
    Public Function ObtenerTodos() As Cancelaciones
        Dim lst As Cancelaciones = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerCancelaciones")
            Dim lista As New List(Of Cancelacion)
            lista = objDA.ObtenerResultados(Of Cancelacion)()
            For Each cancel As Cancelacion In lista
                lst.Add(cancel)
            Next
        End Using
        Return lst
    End Function
End Class
