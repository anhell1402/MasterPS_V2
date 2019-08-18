Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class DireccionDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal direccion_ As Direccion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaDireccion")
            objDA.AgregarParametro("@calle", direccion_.Calle)
            objDA.AgregarParametro("@colonia", direccion_.Colonia)
            objDA.AgregarParametro("@cp", direccion_.CP)
            objDA.AgregarParametro("@idMunicipio", direccion_.IdMunicipio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal direccion_ As Direccion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarDireccion")
            objDA.AgregarParametro("@idDireccion", direccion_.IdDireccion)
            objDA.AgregarParametro("@calle", direccion_.Calle)
            objDA.AgregarParametro("@colonia", direccion_.Colonia)
            objDA.AgregarParametro("@cp", direccion_.CP)
            objDA.AgregarParametro("@idMunicipio", direccion_.IdMunicipio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal direccion_ As Direccion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarDireccion")
            objDA.AgregarParametro("@idDireccion", direccion_.IdDireccion)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal direccion_ As Direccion) As Direccion
        Dim dire As Direccion = Nothing
        Dim lst As List(Of Direccion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDireccion")
            objDA.AgregarParametro("@idDireccion", direccion_.IdDireccion)
            lst = objDA.ObtenerResultados(Of Direccion)()
            dire = New Direccion()
            dire = lst(0)
        End Using
        Return dire
    End Function
    Public Function ObtenerTodos() As Direcciones
        Dim lst As Direcciones = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDirecciones")
            Dim lista As New List(Of Direccion)
            lista = objDA.ObtenerResultados(Of Direccion)()
            For Each dire As Direccion In lista
                lst.Add(dire)
            Next
        End Using
        Return lst
    End Function
End Class
