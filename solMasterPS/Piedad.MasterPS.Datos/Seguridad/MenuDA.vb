Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class MenuDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal menu_ As Menu)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaMenu")
            objDA.AgregarParametro("@descripcion", menu_.Descripcion)
            objDA.AgregarParametro("@idPadre", menu_.IdPadre)
            objDA.AgregarParametro("@formulario", menu_.Formulario)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal menu_ As Menu)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarMenu")
            objDA.AgregarParametro("@idMenu", menu_.IdMenu)
            objDA.AgregarParametro("@descripcion", menu_.Descripcion)
            objDA.AgregarParametro("@idPadre", menu_.IdPadre)
            objDA.AgregarParametro("@formulario", menu_.Formulario)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal menu_ As Menu)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarMenu")
            objDA.AgregarParametro("@idMenu", menu_.IdMenu)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal menu_ As Menu) As Menu
        Dim main As Menu = Nothing
        Dim lst As List(Of Menu)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerMenu")
            objDA.AgregarParametro("@idMenu", menu_.IdMenu)
            lst = objDA.ObtenerResultados(Of Menu)()
            main = New Menu()
            main = lst(0)
        End Using
        Return main
    End Function
    Public Function ObtenerTodos() As Menus
        Dim lst As Menus = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerMenus")
            Dim lista As New List(Of Menu)
            lista = objDA.ObtenerResultados(Of Menu)()
            For Each main As Menu In lista
                lst.Add(main)
            Next
        End Using
        Return lst
    End Function
End Class