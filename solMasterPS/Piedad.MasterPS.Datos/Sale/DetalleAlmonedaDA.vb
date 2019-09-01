Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class DetalleAlmonedaDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal detalleAlmoneda_ As DetalleAlmoneda)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaDetalleAlmoneda")
            objDA.AgregarParametro("@idÁlmoneda", detalleAlmoneda_.IdAlmoneda)

        End Using
    End Sub
End Class
