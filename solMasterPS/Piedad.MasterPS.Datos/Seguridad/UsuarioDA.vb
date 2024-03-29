﻿Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class UsuarioDA
    Private cadenaConex As String
    Public Property HayError As Boolean
    Public Property MensajeError As String

    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal usuario_ As Usuario)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaUsuario")
            objDA.AgregarParametro("@nombre", usuario_.Nombre)
            objDA.AgregarParametro("@apaterno", usuario_.Apaterno)
            objDA.AgregarParametro("@amaterno", usuario_.Amaterno)
            objDA.AgregarParametro("@idRol", usuario_.IdRol.IdGenerico)
            objDA.AgregarParametro("@mail", usuario_.Mail)
            objDA.AgregarParametro("@username", usuario_.Username)
            objDA.AgregarParametro("@passwd", usuario_.Password)
            objDA.AgregarParametro("@estatus", usuario_.Status)
            objDA.AgregarParametro("@telefono", usuario_.IdTelefono.Descripcion)
            objDA.AgregarParametro("@tipoTel", usuario_.IdTipoTelefono.IdGenerico)
            objDA.AgregarParametro("@idSucursal", usuario_.IdSucursal.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
            If objDA.HayError Then
                HayError = True
                MensajeError = objDA.MensajeError
            End If
        End Using
    End Sub
    Public Sub Actualizar(ByVal usuario_ As Usuario)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarUsuario")
            objDA.AgregarParametro("@idUsuario", usuario_.IdUsuario)
            objDA.AgregarParametro("@nombre", usuario_.Nombre)
            objDA.AgregarParametro("@apaterno", usuario_.Apaterno)
            objDA.AgregarParametro("@amaterno", usuario_.Amaterno)
            objDA.AgregarParametro("@idRol", usuario_.IdRol.IdGenerico)
            objDA.AgregarParametro("@mail", usuario_.Mail)
            'objDA.AgregarParametro("@username", usuario_.Username)
            'objDA.AgregarParametro("@passwd", usuario_.Password)
            objDA.AgregarParametro("@estatus", usuario_.Status)
            'objDA.AgregarParametro("@idDireccion", usuario_.IdDireccion)
            objDA.AgregarParametro("@telefono", usuario_.IdTelefono.Descripcion)
            objDA.AgregarParametro("@tipoTel", usuario_.IdTipoTelefono.IdGenerico)
            'objDA.AgregarParametro("@idSucursal", usuario_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
            If objDA.HayError Then
                HayError = True
                MensajeError = objDA.MensajeError
            End If
        End Using
    End Sub
    Public Sub Eliminar(ByVal usuario_ As Usuario)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarUsuario")
            objDA.AgregarParametro("@idUsuario", usuario_.IdUsuario)
            objDA.AgregarParametro("@idSucursal", usuario_.IdSucursal.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
            If objDA.HayError Then
                HayError = True
                MensajeError = objDA.MensajeError
            End If
        End Using
    End Sub
    Public Function Obtener(ByVal usuario_ As Usuario) As Usuario
        Dim us As Usuario = Nothing
        Dim lst As List(Of Usuario)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerUsuario")
            objDA.AgregarParametro("@idUsuario", usuario_.IdUsuario)
            objDA.AgregarParametro("@idSucursal", usuario_.IdSucursal.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Usuario)()
            If objDA.HayError Then
                HayError = True
                MensajeError = objDA.MensajeError
            End If
            us = New Usuario()
            us = lst(0)
        End Using
        Return us
    End Function
    Public Function ObtenerTodos(ByVal usuario_ As Usuario) As Usuarios
        Dim lst As New Usuarios()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerUsuarios")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", usuario_.IdSucursal.IdSucursal)
            Dim lista As New List(Of Usuario)
            lista = objDA.ObtenerResultados(Of Usuario)()
            If objDA.HayError Then
                HayError = True
                MensajeError = objDA.MensajeError
            End If
            For Each us As Usuario In lista
                lst.Add(us)
            Next

        End Using
        Return lst
    End Function
End Class