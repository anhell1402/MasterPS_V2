﻿Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class AdicionCompraDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal adicionCompra_ As AdicionCompra)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaAdicionCompra")
            objDA.AgregarParametro("@idCliente", adicionCompra_.IdCliente)
            objDA.AgregarParametro("@idTipoIngreso", adicionCompra_.IdTipoIngreso)
            objDA.AgregarParametro("@idMercancia", adicionCompra_.IdMercancia)
            objDA.AgregarParametro("@idTipoEmpenio", adicionCompra_.IdTipoEmpenio)
            objDA.AgregarParametro("@idDetalleMercanciaVenta", adicionCompra_.IdDetalleMercanciaVenta)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal adicionCompra_ As AdicionCompra)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarAdicionCompra")
            objDA.AgregarParametro("@idAdicionCompra", adicionCompra_.IdAdicionCompra)
            objDA.AgregarParametro("@idCliente", adicionCompra_.IdCliente)
            objDA.AgregarParametro("@idTipoIngreso", adicionCompra_.IdTipoIngreso)
            objDA.AgregarParametro("@idMercancia", adicionCompra_.IdMercancia)
            objDA.AgregarParametro("@idTipoEmpenio", adicionCompra_.IdTipoEmpenio)
            objDA.AgregarParametro("@idDetalleMercanciaVenta", adicionCompra_.IdDetalleMercanciaVenta)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal adicionCompra_ As AdicionCompra)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarAdicionCompra")
            objDA.AgregarParametro("@idAdicionCompra", adicionCompra_.IdAdicionCompra)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal adicionCompra_ As AdicionCompra) As AdicionCompra
        Dim adiCom As AdicionCompra = Nothing
        Dim lst As List(Of AdicionCompra)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerAdicionCompra")
            objDA.AgregarParametro("@idAdicionCompra", adicionCompra_.IdAdicionCompra)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of AdicionCompra)()
            adiCom = New AdicionCompra()
            adiCom = lst(0)
        End Using
        Return adiCom
    End Function
    Public Function ObtenerTodos() As AdicionesCompras
        Dim lst As AdicionesCompras = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerAdicionesCompras")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            Dim lista As New List(Of AdicionCompra)
            lista = objDA.ObtenerResultados(Of AdicionCompra)()
            For Each adiCom As AdicionCompra In lista
                lst.Add(adiCom)
            Next
        End Using
        Return lst
    End Function
End Class
