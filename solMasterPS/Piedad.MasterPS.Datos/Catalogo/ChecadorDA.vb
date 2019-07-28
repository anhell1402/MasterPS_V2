Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class ChecadorDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub

    Public Sub Almacenar(ByVal checador_ As Checador)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_almacenarChecador")
            objDA.AgregarParametro("@nombre", checador_.IdChecador)
            objDA.AgregarParametro("@nombre", checador_.IdChecador)
            objDA.AgregarParametro("@nombre", checador_.IdChecador)
            objDA.EjecutaComando()
        End Using

    End Sub
End Class
