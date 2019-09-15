Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ClienteDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal cliente_ As Cliente)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaCliente")
            objDA.AgregarParametro("@nombre", cliente_.Nombre)
            objDA.AgregarParametro("@apellidoPaterno", cliente_.ApellidoPaterno)
            objDA.AgregarParametro("@apellidoMaterno", cliente_.ApellidoMaterno)
            objDA.AgregarParametro("@idDireccion", cliente_.IdDireccion)
            objDA.AgregarParametro("@idTipoIdentificacion", cliente_.IdTipoIdentificacion)
            objDA.AgregarParametro("@numeroIdentificacion", cliente_.NumeroIdentificacion)
            objDA.AgregarParametro("@idTelefono", cliente_.IdTelefono)
            objDA.AgregarParametro("@fechaNacimiento", cliente_.FechaNacimiento)
            objDA.AgregarParametro("@idSexo", cliente_.IdSexo)
            objDA.AgregarParametro("@email", cliente_.Email)
            objDA.AgregarParametro("@idOcupacion", cliente_.IdOcupacion)
            objDA.AgregarParametro("@alerta", cliente_.Alerta)
            objDA.AgregarParametro("@fechaRegistro", cliente_.FechaRegistro)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal cliente_ As Cliente)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarCliente")
            objDA.AgregarParametro("@idCliente", cliente_.IdCliente)
            objDA.AgregarParametro("@nombre", cliente_.Nombre)
            objDA.AgregarParametro("@apellidoPaterno", cliente_.ApellidoPaterno)
            objDA.AgregarParametro("@apellidoMaterno", cliente_.ApellidoMaterno)
            objDA.AgregarParametro("@idDireccion", cliente_.IdDireccion)
            objDA.AgregarParametro("@idTipoIdentificacion", cliente_.IdTipoIdentificacion)
            objDA.AgregarParametro("@numeroIdentificacion", cliente_.NumeroIdentificacion)
            objDA.AgregarParametro("@idTelefono", cliente_.IdTelefono)
            objDA.AgregarParametro("@fechaNacimiento", cliente_.FechaNacimiento)
            objDA.AgregarParametro("@idSexo", cliente_.IdSexo)
            objDA.AgregarParametro("@email", cliente_.Email)
            objDA.AgregarParametro("@idOcupacion", cliente_.IdOcupacion)
            objDA.AgregarParametro("@alerta", cliente_.Alerta)
            objDA.AgregarParametro("@fechaRegistro", cliente_.FechaRegistro)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal cliente_ As Cliente)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarCliente")
            objDA.AgregarParametro("@idCliente", cliente_.IdCliente)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal cliente_ As Cliente) As Cliente
        Dim cte As Cliente = Nothing
        Dim lst As List(Of Cliente)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerCliente")
            objDA.AgregarParametro("@idCliente", cliente_.IdCliente)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Cliente)()
            cte = New Cliente()
            cte = lst(0)
        End Using
        Return cte
    End Function
    Public Function ObtenerTodos() As Clientes
        Dim lst As Clientes = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerClientes")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            Dim lista As New List(Of Cliente)
            lista = objDA.ObtenerResultados(Of Cliente)()
            For Each cte As Cliente In lista
                lst.Add(cte)
            Next
        End Using
        Return lst
    End Function
End Class
