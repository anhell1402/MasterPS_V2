Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ConfigFacturacionDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal configFacturacion_ As ConfigFacturacion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaConfigFacturacion")
            objDA.AgregarParametro("@serie", configFacturacion_.Serie)
            objDA.AgregarParametro("@folio", configFacturacion_.Folio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal configFacturacion_ As ConfigFacturacion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarConfigFacturacion")
            objDA.AgregarParametro("@idFacturacion", configFacturacion_.IdFacturacion)
            objDA.AgregarParametro("@serie", configFacturacion_.Serie)
            objDA.AgregarParametro("@folio", configFacturacion_.Folio)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal configFacturacion_ As ConfigFacturacion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarConfigFacturacion")
            objDA.AgregarParametro("@idFacturacion", configFacturacion_.IdFacturacion)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal configFacturacion_ As ConfigFacturacion) As ConfigFacturacion
        Dim conFac As ConfigFacturacion = Nothing
        Dim lst As List(Of ConfigFacturacion)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerConfigFacturacion")
            objDA.AgregarParametro("@idFacturacion", configFacturacion_.IdFacturacion)
            lst = objDA.ObtenerResultados(Of ConfigFacturacion)()
            conFac = New ConfigFacturacion()
            conFac = lst(0)
        End Using
        Return conFac
    End Function
    Public Function ObtenerTodos() As ConfigFacturaciones
        Dim lst As ConfigFacturaciones = Nothing
        Using objDA As New ConexDB(cadenaConex)
            Dim lista As New List(Of ConfigFacturacion)
            lista = objDA.ObtenerResultados(Of ConfigFacturacion)()
            For Each conFac As ConfigFacturacion In lista
                lst.Add(conFac)
            Next
        End Using
        Return lst
    End Function
End Class
