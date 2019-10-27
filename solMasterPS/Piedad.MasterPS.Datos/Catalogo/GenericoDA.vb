Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class GenericoDA
    Private cadenaConex As String
    Private tipoGen As TipoGenerico
    Private almacena As String
    Private actualiza As String
    Private elimina As String
    Private obtener_ As String
    Private obtenerTodos_ As String

    Public Sub New(ByVal cadenaConexion As String, ByVal tipo As TipoGenerico)
        cadenaConex = cadenaConexion
        tipoGen = tipo
        Select Case tipo
            Case TipoGenerico.Caja
                almacena = "dbo.sp_AltaCaja"
                actualiza = "dbo.sp_ActualizarCaja"
                elimina = "dbo.sp_EliminarCaja"
                obtener_ = "dbo.sp_ObtenerCaja"
                obtenerTodos_ = "dbo.sp_ObtenerCajas"
                Exit Select
            Case TipoGenerico.Antiguedad
                almacena = "dbo.sp_AltaCatalogoAntiguedad"
                actualiza = "dbo.sp_ActualizarCatalogoAntiguedad"
                elimina = "dbo.sp_EliminarCatalogoAntiguedad"
                obtener_ = "dbo.sp_ObtenerCatalogoAntiguedad"
                obtenerTodos_ = "dbo.sp_ObtenerCatalogoAntiguedades"
                Exit Select
            Case TipoGenerico.Arte
                almacena = "dbo.sp_AltaCatalogoArte"
                actualiza = "dbo.sp_ActualizarCatalogoArte"
                elimina = "dbo.sp_EliminarCatalogoArte"
                obtener_ = "dbo.sp_ObtenerCatalogoArte"
                obtenerTodos_ = "dbo.sp_ObtenerCatalogoArtes"
                Exit Select
            Case TipoGenerico.MovimientoEmpenio
                almacena = "dbo.sp_AltaCatMovimientoEmpenio"
                actualiza = "dbo.sp_ActualizarCatMovimientoEmpenio"
                elimina = "dbo.sp_EliminarCatMovimientoEmpenio"
                obtener_ = "dbo.sp_ObtenerCatMovimientoEmpenio"
                obtenerTodos_ = "dbo.sp_ObtenerCatMovimientosEmpenios"
                Exit Select
            Case TipoGenerico.Estado
                almacena = "dbo.sp_AltaEstado"
                actualiza = "dbo.sp_ActualizarEstado"
                elimina = "dbo.sp_EliminarEstado"
                obtener_ = "dbo.sp_ObtenerEstado"
                obtenerTodos_ = "dbo.sp_ObtenerEstados"
                Exit Select
            Case TipoGenerico.EstatusApartado
                almacena = "dbo.sp_AltaEstatusApartado"
                actualiza = "dbo.sp_ActualizarEstatusApartado"
                elimina = "dbo.sp_EliminarEstatusApartado"
                obtener_ = "dbo.sp_ObtenerEstatusApartado"
                obtenerTodos_ = "dbo.sp_ObtenerEstatusApartados"
                Exit Select
            Case TipoGenerico.EstatusEmpenio
                almacena = "dbo.sp_AltaEstatusEmpenio"
                actualiza = "dbo.sp_ActualizarEstatusEmpenio"
                elimina = "dbo.sp_EliminarEstatusEmpenio"
                obtener_ = "dbo.sp_ObtenerEstatusEmpenio"
                obtenerTodos_ = "dbo.sp_ObtenerEstatusEmpenios"
                Exit Select
            Case TipoGenerico.EstatusInventario
                almacena = "dbo.sp_AltaEstatusInventario"
                actualiza = "dbo.sp_ActualizarEstatusInventario"
                elimina = "dbo.sp_EliminarEstatusInventario"
                obtener_ = "dbo.sp_ObtenerEstatusInventario"
                obtenerTodos_ = "dbo.sp_ObtenerEstatusInventarios"
                Exit Select
            Case TipoGenerico.EstatusMensaje
                almacena = "dbo.sp_AltaEstatusMensaje"
                actualiza = "dbo.sp_ActualizarEstatusMensaje"
                elimina = "dbo.sp_EliminarEstatusMensaje"
                obtener_ = "dbo.sp_ObtenerEstatusMensaje"
                obtenerTodos_ = "dbo.sp_ObtenerEstatusMensajes"
                Exit Select
            Case TipoGenerico.EstatusVenta
                almacena = "dbo.sp_AltaEstatusVenta"
                actualiza = "dbo.sp_ActualizarEstatusVenta"
                elimina = "dbo.sp_EliminarEstatusVenta"
                obtener_ = "dbo.sp_ObtenerEstatusVenta"
                obtenerTodos_ = "dbo.sp_ObtenerEstatusVentas"
                Exit Select
            Case TipoGenerico.Familia_TipoKilataje
                almacena = "dbo.sp_AltaFamiliaTipoKilataje"
                actualiza = "dbo.sp_ActualizarFamiliaTipoKilataje"
                elimina = "dbo.sp_EliminarFamiliaTipoKilataje"
                obtener_ = "dbo.sp_ObtenerFamiliaTipoKilataje"
                obtenerTodos_ = "dbo.sp_ObtenerFamiliaTiposKilatajes"
                Exit Select
            Case TipoGenerico.Marca_EstadoMetal
                almacena = "dbo.sp_AltaMarcaEstadoMetal"
                actualiza = "dbo.sp_ActualizarMarcaEstadoMetal"
                elimina = "dbo.sp_EliminarMarcaEstadoMetal"
                obtener_ = "dbo.sp_ObtenerMarcaEstadoMetal"
                obtenerTodos_ = "dbo.sp_ObtenerMarcaEstadosMetales"
                Exit Select
            Case TipoGenerico.MedioEnterado
                almacena = "dbo.sp_AltaMedioEnterado"
                actualiza = "dbo.sp_ActualizarMedioEnterado"
                elimina = "dbo.sp_EliminarMedioEnterado"
                obtener_ = "dbo.sp_ObtenerMedioEnterado"
                obtenerTodos_ = "dbo.sp_ObtenerMediosEnterado"
                Exit Select
            Case TipoGenerico.MotivoChecador
                almacena = "dbo.sp_AltaMotivoChecador"
                actualiza = "dbo.sp_ActualizarMotivoChecador"
                elimina = "dbo.sp_EliminarMotivoChecador"
                obtener_ = "dbo.sp_ObtenerMotivoChecador"
                obtenerTodos_ = "dbo.sp_ObtenerMotivosChecador"
                Exit Select
            Case TipoGenerico.Municipio
                almacena = "dbo.sp_AltaMunicipio"
                actualiza = "dbo.sp_ActualizarMunicipio"
                elimina = "dbo.sp_EliminarMunicipio"
                obtener_ = "dbo.sp_ObtenerMunicipio"
                obtenerTodos_ = "dbo.sp_ObtenerMunicipios"
                Exit Select
            Case TipoGenerico.NivelCombustible
                almacena = "dbo.sp_AltaNivelCombustible"
                actualiza = "dbo.sp_ActualizarNivelCombustible"
                elimina = "dbo.sp_EliminarNivelCombustible"
                obtener_ = "dbo.sp_ObtenerNivelCombustible"
                obtenerTodos_ = "dbo.sp_ObtenerNivelesCombustibles"
                Exit Select
            Case TipoGenerico.Ocupacion
                almacena = "dbo.sp_AltaOcupacion"
                actualiza = "dbo.sp_ActualizarOcupacion"
                elimina = "dbo.sp_EliminarOcupacion"
                obtener_ = "dbo.sp_ObtenerOcupacion"
                obtenerTodos_ = "dbo.sp_ObtenerOcupaciones"
                Exit Select
            Case TipoGenerico.Pais
                almacena = "dbo.sp_AltaPais"
                actualiza = "dbo.sp_ActualizarPais"
                elimina = "dbo.sp_EliminarPais"
                obtener_ = "dbo.sp_ObtenerPais"
                obtenerTodos_ = "dbo.sp_ObtenerPaises"
                Exit Select
            Case TipoGenerico.Periodo
                almacena = "dbo.sp_AltaPeriodo"
                actualiza = "dbo.sp_ActualizarPeriodo"
                elimina = "dbo.sp_EliminarPeriodo"
                obtener_ = "dbo.sp_ObtenerPeriodo"
                obtenerTodos_ = "dbo.sp_ObtenerPeriodos"
                Exit Select
            Case TipoGenerico.Rol
                almacena = "dbo.sp_AltaRol"
                actualiza = "dbo.sp_ActualizarRol"
                elimina = "dbo.sp_EliminarRol"
                obtener_ = "dbo.sp_ObtenerRol"
                obtenerTodos_ = "dbo.sp_ObtenerRoles"
                Exit Select
            Case TipoGenerico.Sexo
                almacena = "dbo.sp_AltaSexo"
                actualiza = "dbo.sp_ActualizarSexo"
                elimina = "dbo.sp_EliminarSexo"
                obtener_ = "dbo.sp_ObtenerSexo"
                obtenerTodos_ = "dbo.sp_ObtenerSexos"
                Exit Select
            Case TipoGenerico.Telefono
                almacena = "dbo.sp_AltaTelefono"
                actualiza = "dbo.sp_ActualizarTelefono"
                elimina = "dbo.sp_EliminarTelefono"
                obtener_ = "dbo.sp_ObtenerTelefono"
                obtenerTodos_ = "dbo.sp_ObtenerTelefonos"
                Exit Select
            Case TipoGenerico.TipoCancelacionApartado
                almacena = "dbo.sp_AltaTipoCancelacionApartado"
                actualiza = "dbo.sp_ActualizarTipoCancelacionApartado"
                elimina = "dbo.sp_EliminarTipoCancelacionApartado"
                obtener_ = "dbo.sp_ObtenerTipoCancelacionApartado"
                obtenerTodos_ = "dbo.sp_ObtenerTipoCancelacionApartados"
                Exit Select
            Case TipoGenerico.TipoDocumento
                almacena = "dbo.sp_AltaTipoDocumento"
                actualiza = "dbo.sp_ActualizarTipoDocumento"
                elimina = "dbo.sp_EliminarTipoDocumento"
                obtener_ = "dbo.sp_ObtenerTipoDocumento"
                obtenerTodos_ = "dbo.sp_ObtenerTipoDocumentos"
                Exit Select
            Case TipoGenerico.TipoEmpenio
                almacena = "dbo.sp_AltaTipoEmpenio"
                actualiza = "dbo.sp_ActualizarTipoEmpenio"
                elimina = "dbo.sp_EliminarTipoEmpenio"
                obtener_ = "dbo.sp_ObtenerTipoEmpenio"
                obtenerTodos_ = "dbo.sp_ObtenerTipoEmpenios"
                Exit Select
            Case TipoGenerico.TipoFormaDiamante
                almacena = "dbo.sp_AltaTipoFormaDiamante"
                actualiza = "dbo.sp_ActualizarTipoFormaDiamante"
                elimina = "dbo.sp_EliminarTipoFormaDiamante"
                obtener_ = "dbo.sp_ObtenerTipoFormaDiamante"
                obtenerTodos_ = "dbo.sp_ObtenerTipoFormaDiamantes"
                Exit Select
            Case TipoGenerico.TipoIdentificacion
                almacena = "dbo.sp_AltaTipoIdentificacion"
                actualiza = "dbo.sp_ActualizarTipoIdentificacion"
                elimina = "dbo.sp_EliminarTipoIdentificacion"
                obtener_ = "dbo.sp_ObtenerTipoIdentificacion"
                obtenerTodos_ = "dbo.sp_ObtenerTipoIdentificaciones"
                Exit Select
            Case TipoGenerico.TipoIngreso
                almacena = "dbo.sp_AltaTipoIngreso"
                actualiza = "dbo.sp_ActualizarTipoIngreso"
                elimina = "dbo.sp_EliminarTipoIngreso"
                obtener_ = "dbo.sp_ObtenerTipoIngreso"
                obtenerTodos_ = "dbo.sp_ObtenerTipoIngresos"
                Exit Select
            Case TipoGenerico.TipoMercancia_Metal
                almacena = "dbo.sp_AltaTipoMercanciaMetal"
                actualiza = "dbo.sp_ActualizarTipoMercanciaMetal"
                elimina = "dbo.sp_EliminarTipoMercanciaMetal"
                obtener_ = "dbo.sp_ObtenerTipoMercanciaMetal"
                obtenerTodos_ = "dbo.sp_ObtenerTipoMercanciasMetales"
                Exit Select
            Case TipoGenerico.TipoMotor
                almacena = "dbo.sp_AltaTipoMotor"
                actualiza = "dbo.sp_ActualizarTipoMotor"
                elimina = "dbo.sp_EliminarTipoMotor"
                obtener_ = "dbo.sp_ObtenerTipoMotor"
                obtenerTodos_ = "dbo.sp_ObtenerTipoMotores"
                Exit Select
            Case TipoGenerico.TipoOperacionEmpenio
                almacena = "dbo.sp_AltaTipoOperacionEmpenio"
                actualiza = "dbo.sp_ActualizarTipoOperacionEmpenio"
                elimina = "dbo.sp_EliminarTipoOperacionEmpenio"
                obtener_ = "dbo.sp_ObtenerTipoOperacionEmpenio"
                obtenerTodos_ = "dbo.sp_ObtenerTipoOperacionEmpenios"
                Exit Select
            Case TipoGenerico.TipoTasa
                almacena = "dbo.sp_AltaTipoTasa"
                actualiza = "dbo.sp_ActualizarTipoTasa"
                elimina = "dbo.sp_EliminarTipoTasa"
                obtener_ = "dbo.sp_ObtenerTipoTasa"
                obtenerTodos_ = "dbo.sp_ObtenerTiposTasas"
                Exit Select
            Case TipoGenerico.TipoTelefono
                almacena = "dbo.sp_AltaTipoTelefono"
                actualiza = "dbo.sp_ActualizarTipoTelefono"
                elimina = "dbo.sp_EliminarTipoTelefono"
                obtener_ = "dbo.sp_ObtenerTipoTelefono"
                obtenerTodos_ = "dbo.sp_ObtenerTipoTelefonos"
                Exit Select
            Case TipoGenerico.EstatusCliente
                almacena = "dbo.sp_AltaEstatusCliente"
                actualiza = "dbo.sp_ActualizarEstatusCliente"
                elimina = "dbo.sp_EliminarEstatusCliente"
                obtener_ = "dbo.sp_ObtenerEstatusCliente"
                obtenerTodos_ = "dbo.sp_ObtenerEstatusClientes"
                Exit Select
            Case TipoGenerico.TipoPrendaOro
                almacena = "dbo.sp_AltaTipoPrendaOro"
                actualiza = "dbo.sp_ActualizarTipoPrendaOro"
                elimina = "dbo.sp_EliminarTipoPrendaOro"
                obtener_ = "dbo.sp_ObtenerTipoPrendaOro"
                obtenerTodos_ = "dbo.sp_ObtenerTiposPrendaOro"
                Exit Select
        End Select
    End Sub
    Public Sub Almacenar(ByVal generic As Generico)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(almacena)
            objDA.AgregarParametro("@valor", generic.Descripcion)
            If tipoGen = TipoGenerico.Caja Or tipoGen = TipoGenerico.TipoMercancia_Metal Or
                tipoGen = TipoGenerico.Telefono Or tipoGen = TipoGenerico.Familia_TipoKilataje Or
                tipoGen = TipoGenerico.Marca_EstadoMetal Or tipoGen = TipoGenerico.Municipio Then
                objDA.AgregarParametro("@idAuxiliarUno", generic.IdAuxiliarUno)
            ElseIf tipoGen = TipoGenerico.TipoFormaDiamante Then
                objDA.AgregarParametro("@auxiliarUno", generic.AuxiliarUno)
            End If
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub

    Public Sub Actualizar(ByVal generic As Generico)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(actualiza)
            objDA.AgregarParametro("@id", generic.IdGenerico)
            objDA.AgregarParametro("@valor", generic.Descripcion)
            If tipoGen = TipoGenerico.Caja Or tipoGen = TipoGenerico.TipoMercancia_Metal Or
                tipoGen = TipoGenerico.Telefono Or tipoGen = TipoGenerico.Familia_TipoKilataje Or
                tipoGen = TipoGenerico.Marca_EstadoMetal Or tipoGen = TipoGenerico.Municipio Then
                objDA.AgregarParametro("@idAuxiliarUno", generic.IdAuxiliarUno)
            ElseIf tipoGen = TipoGenerico.TipoFormaDiamante Then
                objDA.AgregarParametro("@auxiliarUno", generic.AuxiliarUno)
            End If
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal generic As Generico)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(elimina)
            objDA.AgregarParametro("@id", generic.IdGenerico)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal generic As Generico) As Generico
        Dim gen As Generico = Nothing
        Dim lst As List(Of Generico)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(obtener_)
            objDA.AgregarParametro("@id", generic.IdGenerico)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of Generico)()
            gen = New Generico()
            gen = lst(0)
        End Using
        Return gen
    End Function

    Public Function ObtenerTodos() As Genericos
        Dim lst As New Genericos()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(obtenerTodos_)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            Dim lista As New List(Of Generico)
            lista = objDA.ObtenerResultados(Of Generico)()
            For Each gen As Generico In lista
                lst.Add(gen)
            Next
        End Using
        Return lst
    End Function
End Class
