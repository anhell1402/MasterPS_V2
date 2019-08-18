Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class CACDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal cac_ As CAC)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaCAC")
            objDA.AgregarParametro("@idUsuario", cac_.IdUsuario)
            objDA.AgregarParametro("@fechaRegistro", cac_.FechaRegistro)
            objDA.AgregarParametro("@descripcion", cac_.Descripcion)
            objDA.AgregarParametro("@idEmpenio", cac_.IdEmpenio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal cac_ As CAC)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarCAC")
            objDA.AgregarParametro("idCAC", cac_.IdCAC)
            objDA.AgregarParametro("idUsuario", cac_.IdUsuario)
            objDA.AgregarParametro("fechaRegistro", cac_.FechaRegistro)
            objDA.AgregarParametro("@descripcion", cac_.Descripcion)
            objDA.AgregarParametro("@idEmpenio", cac_.IdEmpenio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal cac_ As CAC)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarCAC")
            objDA.AgregarParametro("@idCAC", cac_.IdCAC)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal cac_ As CAC) As CAC
        Dim cc As CAC = Nothing
        Dim lst As List(Of CAC)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerCAC")
            objDA.AgregarParametro("@idCAC", cac_.IdCAC)
            lst = objDA.ObtenerResultados(Of CAC)()
            cc = New CAC()
            cc = lst(0)
        End Using
        Return cc
    End Function
    Public Function ObtenerTodos() As CACS
        Dim lst As CACS = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerCACs")
            Dim lista As New List(Of CAC)
            lista = objDA.ObtenerResultados(Of CAC)()
            For Each cc As CAC In lista
                lst.Add(cc)
            Next
        End Using
        Return lst
    End Function
End Class
