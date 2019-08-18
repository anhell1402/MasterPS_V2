Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class SucursalDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal sucursal_ As Sucursal)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaSucursal")
            objDA.AgregarParametro("@nick", sucursal_.Nick)
            objDA.AgregarParametro("@nombre", sucursal_.Nombre)
            objDA.AgregarParametro("@mail", sucursal_.Mail)
            objDA.AgregarParametro("@rfc", sucursal_.Rfc)
            objDA.AgregarParametro("@idDireccion", sucursal_.IdDireccion)
            objDA.AgregarParametro("idTelefono", sucursal_.IdTelefono)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal sucursal_ As Sucursal)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarSucursal")
            objDA.AgregarParametro("@idSucursal", sucursal_.IdSucursal)
            objDA.AgregarParametro("@nick", sucursal_.Nick)
            objDA.AgregarParametro("@nombre", sucursal_.Nombre)
            objDA.AgregarParametro("@mail", sucursal_.Mail)
            objDA.AgregarParametro("@rfc", sucursal_.Rfc)
            objDA.AgregarParametro("@idDireccion", sucursal_.IdDireccion)
            objDA.AgregarParametro("idTelefono", sucursal_.IdTelefono)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal sucursal_ As Sucursal)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarSucursal")
            objDA.AgregarParametro("@idSucursal", sucursal_.IdSucursal)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal sucursal_ As Sucursal) As Sucursal
        Dim suc As Sucursal = Nothing
        Dim lst As List(Of Sucursal)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerSucursal")
            objDA.AgregarParametro("@idSucursal", sucursal_.IdSucursal)
            lst = objDA.ObtenerResultados(Of Sucursal)()
            suc = New Sucursal()
            suc = lst(0)
        End Using
        Return suc
    End Function
    Public Function ObtenerTodos() As Sucursales
        Dim lst As Sucursales = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerSucursales")
            Dim lista As New List(Of Sucursal)
            lista = objDA.ObtenerResultados(Of Sucursal)()
            For Each suc As Sucursal In lista
                lst.Add(suc)
            Next
        End Using
        Return lst
    End Function
End Class
