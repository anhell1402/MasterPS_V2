﻿Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class DocumentoDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal documento_ As Documento)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaDocumento")
            objDA.AgregarParametro("@idTipoDocumento", documento_.IdTipoDocumento)
            objDA.AgregarParametro("@idDetalleEmpenio", documento_.IdDetalleEmpenio)
            objDA.AgregarParametro("@mimeType", documento_.MimeType)
            objDA.AgregarParametro("@documento", documento_.Documento)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal documento_ As Documento)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarDocumento")
            objDA.AgregarParametro("@idDocumento", documento_.IdDocumento)
            objDA.AgregarParametro("@idTipoDocumento", documento_.IdTipoDocumento)
            objDA.AgregarParametro("@idDetalleEmpenio", documento_.IdDetalleEmpenio)
            objDA.AgregarParametro("@mimeType", documento_.MimeType)
            objDA.AgregarParametro("@documento", documento_.Documento)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal documento_ As Documento)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarDocumento")
            objDA.AgregarParametro("@idDocumento", documento_.IdDocumento)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal documento_ As Documento) As Documento
        Dim doc As Documento = Nothing
        Dim lst As List(Of Documento)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDocumento")
            objDA.AgregarParametro("@idDocumento", documento_.IdDocumento)
            lst = objDA.ObtenerResultados(Of Documento)()
            doc = New Documento()
            doc = lst(0)
        End Using
        Return doc
    End Function
    Public Function ObtenerTodos() As Documentos
        Dim lst As Documentos = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDocumentos")
            Dim lista As New List(Of Documento)
            lista = objDA.ObtenerResultados(Of Documento)()
            For Each doc As Documento In lista
                lst.Add(doc)
            Next
        End Using
        Return lst
    End Function
End Class
