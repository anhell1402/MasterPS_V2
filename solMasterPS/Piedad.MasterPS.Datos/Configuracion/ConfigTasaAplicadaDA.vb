Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ConfigTasaAplicadaDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal configTasaAplicada_ As ConfigTasaAplicada)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaConfiguracionTasasAplicadas")
            objDA.AgregarParametro("@gastosVentas", configTasaAplicada_.GastosVenta)
            objDA.AgregarParametro("@gastosOperacion", configTasaAplicada_.GastosOperacion)
            objDA.AgregarParametro("@iva", configTasaAplicada_.IVA)
            objDA.AgregarParametro("@porcentajeUtilidad", configTasaAplicada_.PorcentajeUtilidad)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal configTasaAplicada_ As ConfigTasaAplicada)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarConfiguracionTasasAplicadas")
            objDA.AgregarParametro("@idTasaAplicada", configTasaAplicada_.IdTasaAplicada)
            objDA.AgregarParametro("@gastosVentas", configTasaAplicada_.GastosVenta)
            objDA.AgregarParametro("@gastosOperacion", configTasaAplicada_.GastosOperacion)
            objDA.AgregarParametro("@iva", configTasaAplicada_.IVA)
            objDA.AgregarParametro("@porcentajeUtilidad", configTasaAplicada_.PorcentajeUtilidad)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal configTasaAplicada_ As ConfigTasaAplicada)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarConfiguracionTasasAplicadas")
            objDA.AgregarParametro("@idTasaAplicada", configTasaAplicada_.IdTasaAplicada)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal configTasaAplicada_ As ConfigTasaAplicada) As ConfigTasaAplicada
        Dim confTA As ConfigTasaAplicada = Nothing
        Dim lst As List(Of ConfigTasaAplicada)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfiguracionTasaAplicada")
            objDA.AgregarParametro("@idTasaAplicada", configTasaAplicada_.IdTasaAplicada)
            lst = objDA.ObtenerResultados(Of ConfigTasaAplicada)()
            confTA = New ConfigTasaAplicada()
            confTA = lst(0)
        End Using
        Return confTA
    End Function
    Public Function ObtenerTodos() As ConfigTasasAplicadas
        Dim lst As ConfigTasasAplicadas = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfiguracionTasasAplicadas")
            Dim lista As New List(Of ConfigTasaAplicada)
            lista = objDA.ObtenerResultados(Of ConfigTasaAplicada)
            For Each confTA As ConfigTasaAplicada In lista
                lst.Add(confTA)
            Next
        End Using
        Return lst
    End Function
End Class
