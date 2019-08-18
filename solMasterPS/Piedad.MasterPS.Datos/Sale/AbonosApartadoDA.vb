Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class AbonosApartadoDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal abonosApartado_ As AbonosApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaAbonosApartado")
            objDA.AgregarParametro("@idApartado", abonosApartado_.IdApartado)
            objDA.AgregarParametro("@idUsuario", abonosApartado_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", abonosApartado_.FechaRegistro)
            objDA.AgregarParametro("@montoAbonado", abonosApartado_.MontoAbonado)
            objDA.AgregarParametro("@montoRestante", abonosApartado_.MontoRestante)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal abonosApartado_ As AbonosApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarAbonosApartado")
            objDA.AgregarParametro("@idAbonosApartado", abonosApartado_.IdAbonosApartados)
            objDA.AgregarParametro("@idApartado", abonosApartado_.IdApartado)
            objDA.AgregarParametro("@idUsuario", abonosApartado_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", abonosApartado_.FechaRegistro)
            objDA.AgregarParametro("@montoAbonado", abonosApartado_.MontoAbonado)
            objDA.AgregarParametro("@montoRestante", abonosApartado_.MontoRestante)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal abonosApartado_ As AbonosApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarAbonosApartado")
            objDA.AgregarParametro("@idAbonosApartado", abonosApartado_.IdAbonosApartados)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal abonosApartado_ As AbonosApartado) As AbonosApartado
        Dim abonosAp As AbonosApartado = Nothing
        Dim lst As List(Of AbonosApartado)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerAbonosApartado")
            objDA.AgregarParametro("@idAbonosApartado", abonosApartado_.IdAbonosApartados)
            lst = objDA.ObtenerResultados(Of AbonosApartado)()
            abonosAp = New AbonosApartado()
            abonosAp = lst(0)
        End Using
        Return abonosAp
    End Function
    Public Function ObtenerTodos() As AbonosApartados
        Dim lst As AbonosApartados = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerAbonosApartados")
            Dim lista As New List(Of AbonosApartado)
            lista = objDA.ObtenerResultados(Of AbonosApartado)()
            For Each abonosAp As AbonosApartado In lista
                lst.Add(abonosAp)
            Next
        End Using
        Return lst
    End Function
End Class