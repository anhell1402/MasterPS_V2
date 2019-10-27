Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class MercanciaDA
    Private _error As String
    Public ReadOnly Property MensajeError As String
        Get
            Return _error
        End Get
    End Property
    Private _hayError As Boolean
    Public ReadOnly Property HayError As Boolean
        Get
            Return _hayError
        End Get
    End Property

    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal mercancia_ As Mercancia)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaMercancia")
            objDA.AgregarParametro("@idTipoEmpenio", mercancia_.IdTipoEmpenio)
            objDA.AgregarParametro("@idTipoMercancia_Metal", mercancia_.IdTipoMercancia_Metal)
            objDA.AgregarParametro("@idFamilia_TipoKilataje", mercancia_.IdFamilia_TipoKilataje)
            objDA.AgregarParametro("@idMarca_EstadoMetal", mercancia_.IdMarca_EstadoMetal)
            objDA.AgregarParametro("@precioMaximo", mercancia_.PrecioMaximo)
            objDA.AgregarParametro("@modelo", mercancia_.Modelo)
            objDA.AgregarParametro("@idSucursal", mercancia_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal mercancia_ As Mercancia)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarMercancia")
            objDA.AgregarParametro("@idMercancia", mercancia_.IdMercancia)
            objDA.AgregarParametro("@idTipoEmpenio", mercancia_.IdTipoEmpenio)
            objDA.AgregarParametro("@idTipoMercancia_Metal", mercancia_.IdTipoMercancia_Metal)
            objDA.AgregarParametro("@idFamilia_TipoKilataje", mercancia_.IdFamilia_TipoKilataje)
            objDA.AgregarParametro("@idMarca_EstadoMetal", mercancia_.IdMarca_EstadoMetal)
            objDA.AgregarParametro("@precioMaximo", mercancia_.PrecioMaximo)
            objDA.AgregarParametro("@modelo", mercancia_.Modelo)
            objDA.AgregarParametro("@idSucursal", mercancia_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal mercancia_ As Mercancia)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarMercancia")
            objDA.AgregarParametro("@idMercancia", mercancia_.IdMercancia)
            objDA.AgregarParametro("@idSucursal", mercancia_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal mercancia_ As Mercancia) As Mercancia
        Dim merc As Mercancia = Nothing
        Dim lst As List(Of Mercancia)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerMercancia")
            objDA.AgregarParametro("@idMercancia", mercancia_.IdMercancia)
            objDA.AgregarParametro("@idSucursal", mercancia_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Mercancia)()
            merc = New Mercancia()
            merc = lst(0)
        End Using
        Return merc
    End Function
    Public Function ObtenerTodos(ByVal mercancia_ As Mercancia) As Mercancias
        Dim lst As New Mercancias()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerMercancias")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", mercancia_.IdSucursal.IdSucursal)
            Dim lista As New List(Of Mercancia)
            lista = objDA.ObtenerResultados(Of Mercancia)()
            For Each merc As Mercancia In lista
                lst.Add(merc)
            Next
        End Using
        Return lst
    End Function

    Public Function ObtenerModelos(ByVal mercancia_ As Mercancia) As Mercancias
        Dim lst As New Mercancias()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerModelosMercancia")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idMercanciaMetal", mercancia_.IdTipoMercancia_Metal.IdGenerico)
            objDA.AgregarParametro("@idFamilia", mercancia_.IdFamilia_TipoKilataje.IdGenerico)
            objDA.AgregarParametro("@idEstado", mercancia_.IdMarca_EstadoMetal.IdGenerico)
            objDA.AgregarParametro("@idTipoEmpenio", mercancia_.IdTipoEmpenio.IdGenerico)
            Dim lista As New List(Of Mercancia)
            lista = objDA.ObtenerResultados(Of Mercancia)()
            If objDA.HayError Then
                _hayError = objDA.HayError
                _error = objDA.MensajeError
            End If
            For Each merc As Mercancia In lista
                lst.Add(merc)
            Next
        End Using
        Return lst
    End Function
End Class
