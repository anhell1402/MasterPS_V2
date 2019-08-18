Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class MensajeDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal mensaje_ As Mensaje)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaMensaje")
            objDA.AgregarParametro("@mensaje", mensaje_.Mensaje)
            objDA.AgregarParametro("@fechaInicial", mensaje_.FechaInicial)
            objDA.AgregarParametro("@idEstatusMensaje", mensaje_.IdEstatusMensaje)
            objDA.AgregarParametro("@fechaFinal", mensaje_.FechaFinal)
            objDA.AgregarParametro("idCliente", mensaje_.IdCliente)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal mensaje_ As Mensaje)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarMensaje")
            objDA.AgregarParametro("@idMensaje", mensaje_.IdMensaje)
            objDA.AgregarParametro("@mensaje", mensaje_.Mensaje)
            objDA.AgregarParametro("@fechaInicial", mensaje_.FechaInicial)
            objDA.AgregarParametro("@idEstatusMensaje", mensaje_.IdEstatusMensaje)
            objDA.AgregarParametro("@fechaFinal", mensaje_.FechaFinal)
            objDA.AgregarParametro("@idCliente", mensaje_.IdCliente)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal mensaje_ As Mensaje)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarMensaje")
            objDA.AgregarParametro("@idMensaje", mensaje_.IdMensaje)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal mensaje_ As Mensaje) As Mensaje
        Dim msj As Mensaje = Nothing
        Dim lst As List(Of Mensaje)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerMensaje")
            objDA.AgregarParametro("@idMensaje", mensaje_.IdMensaje)
            lst = objDA.ObtenerResultados(Of Mensaje)()
            msj = New Mensaje()
            msj = lst(0)
        End Using
        Return msj
    End Function
    Public Function ObtenerTodos() As Mensajes
        Dim lst As Mensajes = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerMensajes")
            Dim lista As New List(Of Mensaje)
            lista = objDA.ObtenerResultados(Of Mensaje)()
            For Each msj As Mensaje In lista
                lst.Add(msj)
            Next
        End Using
        Return lst
    End Function
End Class
