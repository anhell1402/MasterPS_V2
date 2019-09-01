Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class DetalleApartadoDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal detalleApartado_ As DetalleApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaDetalleApartado")
            objDA.AgregarParametro("@idApartado", detalleApartado_.IdApartado)
            objDA.AgregarParametro("@idInventario", detalleApartado_.IdInventario)
            objDA.AgregarParametro("@precio", detalleApartado_.Precio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal detalleApartado_ As DetalleApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarDetalleApartado")
            objDA.AgregarParametro("@idDetalleApartado", detalleApartado_.IdDetalleApartado)
            objDA.AgregarParametro("@idApartado", detalleApartado_.IdApartado)
            objDA.AgregarParametro("@idInventario", detalleApartado_.IdInventario)
            objDA.AgregarParametro("@precio", detalleApartado_.Precio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal detalleApartado_ As DetalleApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarDetalleApartado")
            objDA.AgregarParametro("@idDetalleApartado", detalleApartado_.IdDetalleApartado)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal detalleApartado_ As DetalleApartado) As DetalleApartado
        Dim detalleAp As DetalleApartado = Nothing
        Dim lst As List(Of DetalleApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleApartado")
            objDA.AgregarParametro("@idDetalleApartado", detalleApartado_.IdDetalleApartado)
            lst = objDA.ObtenerResultados(Of DetalleApartado)()
            detalleAp = New DetalleApartado()
            detalleAp = lst(0)
        End Using
        Return detalleAp
    End Function
    Public Function ObtenerTodos() As DetalleApartados
        Dim lst As DetalleApartados = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleApartados")
            Dim lista As New List(Of DetalleApartado)
            lista = objDA.ObtenerResultados(Of DetalleApartado)()
            For Each detalleAp As DetalleApartado In lista
                lst.Add(detalleAp)
            Next
        End Using
        Return lst
    End Function
End Class
