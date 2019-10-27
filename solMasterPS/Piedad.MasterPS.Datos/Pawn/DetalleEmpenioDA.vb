Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class DetalleEmpenioDA
    Private cadenaConex As String
    Public Sub New(ByVal cadenaConexion As String)
        cadenaConex = cadenaConexion
    End Sub
    Public Sub Almacenar(ByVal detalleEmpenio_ As DetalleEmpenio)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_AltaDetalleEmpenio")
            objDA.AgregarParametro("@idEmpenio", detalleEmpenio_.IdEmpenio)
            objDA.AgregarParametro("@descripcionMercancia", detalleEmpenio_.DescripcionMercancia)
            objDA.AgregarParametro("@idMercancia", detalleEmpenio_.IdMercancia)
            objDA.AgregarParametro("@prestamoUnitario", detalleEmpenio_.PrestamoUnitario)
            objDA.AgregarParametro("@avaluo", detalleEmpenio_.Avaluo)
            objDA.AgregarParametro("@anio", detalleEmpenio_.Anio)
            objDA.AgregarParametro("@color", detalleEmpenio_.Color)
            objDA.AgregarParametro("@placas", detalleEmpenio_.Placas)
            objDA.AgregarParametro("@factura", detalleEmpenio_.Factura)
            objDA.AgregarParametro("@kilometraje", detalleEmpenio_.Kilometraje)
            objDA.AgregarParametro("@agencia", detalleEmpenio_.Agencia)
            objDA.AgregarParametro("@numeroMotor", detalleEmpenio_.NumeroMotor)
            objDA.AgregarParametro("@numeroChasis", detalleEmpenio_.NumeroChasis)
            objDA.AgregarParametro("@repuve", detalleEmpenio_.Repuve)
            objDA.AgregarParametro("@idTipoMotor", detalleEmpenio_.IdTipoMotor)
            objDA.AgregarParametro("@idNivelCombustible", detalleEmpenio_.IdNivelCombustible)
            objDA.AgregarParametro("@numeroTarjetaCirculacion", detalleEmpenio_.NumeroTarjetaCirculacion)
            objDA.AgregarParametro("@aseguradora_Artista_TipoDisenio", detalleEmpenio_.Aseguradora_Artista_TipoDisenio)
            objDA.AgregarParametro("@numeroPoliza", detalleEmpenio_.NumeroPoliza)
            objDA.AgregarParametro("@fechaVencimiento", detalleEmpenio_.FechaVencimiento)
            objDA.AgregarParametro("@cantidadPrendas", detalleEmpenio_.CantidadPrendas)
            objDA.AgregarParametro("@peso", detalleEmpenio_.Peso)
            objDA.AgregarParametro("@pesoPiedras", detalleEmpenio_.PesoPiedra)
            objDA.AgregarParametro("@numeroPiedras", detalleEmpenio_.NumeroPiedras)
            objDA.AgregarParametro("@tamanio", detalleEmpenio_.Tamanio)
            objDA.AgregarParametro("@numeroSerie", detalleEmpenio_.NumeroSerie)
            objDA.AgregarParametro("@idTipoFomraDiamante", detalleEmpenio_.IdTipoFormaDiamante)
            objDA.AgregarParametro("@pureza", detalleEmpenio_.Pureza)
            objDA.AgregarParametro("@idTipoArte", detalleEmpenio_.IdTipoArte)
            objDA.AgregarParametro("@idTipoAntiguedades", detalleEmpenio_.IdTipoAntiguedades)
            objDA.AgregarParametro("@idSucursal", detalleEmpenio_.IdSucursal)
            objDA.AgregarParametro("@claveFolio_Documento", detalleEmpenio_.ClaveFolio_Documento)
            'objDA.AgregarParametro("@idDocumento", detalleEmpenio_.IdDocumento)
            objDA.AgregarParametro("@idTipoPrendaOro", detalleEmpenio_.IdTipoPrendaOro)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Actualizar(ByVal detalleEmpenio_ As DetalleEmpenio)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ActualizarDetalleEmpenio")
            objDA.AgregarParametro("@idDetalleEmpenio", detalleEmpenio_.IdDetalleEmpenio)
            objDA.AgregarParametro("@idEmpenio", detalleEmpenio_.IdEmpenio)
            objDA.AgregarParametro("@descripcionMercancia", detalleEmpenio_.DescripcionMercancia)
            objDA.AgregarParametro("@idMercancia", detalleEmpenio_.IdMercancia)
            objDA.AgregarParametro("@prestamoUnitario", detalleEmpenio_.PrestamoUnitario)
            objDA.AgregarParametro("@avaluo", detalleEmpenio_.Avaluo)
            objDA.AgregarParametro("@anio", detalleEmpenio_.Anio)
            objDA.AgregarParametro("@color", detalleEmpenio_.Color)
            objDA.AgregarParametro("@placas", detalleEmpenio_.Placas)
            objDA.AgregarParametro("@factura", detalleEmpenio_.Factura)
            objDA.AgregarParametro("@kilometraje", detalleEmpenio_.Kilometraje)
            objDA.AgregarParametro("@agencia", detalleEmpenio_.Agencia)
            objDA.AgregarParametro("@numeroMotor", detalleEmpenio_.NumeroMotor)
            objDA.AgregarParametro("@numeroChasis", detalleEmpenio_.NumeroChasis)
            objDA.AgregarParametro("@repuve", detalleEmpenio_.Repuve)
            objDA.AgregarParametro("@idTipoMotor", detalleEmpenio_.IdTipoMotor)
            objDA.AgregarParametro("@idNivelCombustible", detalleEmpenio_.IdNivelCombustible)
            objDA.AgregarParametro("@numeroTarjetaCirculacion", detalleEmpenio_.NumeroTarjetaCirculacion)
            objDA.AgregarParametro("@aseguradora_Artista_TipoDisenio", detalleEmpenio_.Aseguradora_Artista_TipoDisenio)
            objDA.AgregarParametro("@numeroPoliza", detalleEmpenio_.NumeroPoliza)
            objDA.AgregarParametro("@fechaVencimiento", detalleEmpenio_.FechaVencimiento)
            objDA.AgregarParametro("@cantidadPrendas", detalleEmpenio_.CantidadPrendas)
            objDA.AgregarParametro("@peso", detalleEmpenio_.Peso)
            objDA.AgregarParametro("@pesoPiedras", detalleEmpenio_.PesoPiedra)
            objDA.AgregarParametro("@numeroPiedras", detalleEmpenio_.NumeroPiedras)
            objDA.AgregarParametro("@tamanio", detalleEmpenio_.Tamanio)
            objDA.AgregarParametro("@numeroSerie", detalleEmpenio_.NumeroSerie)
            objDA.AgregarParametro("@idTipoFomraDiamante", detalleEmpenio_.IdTipoFormaDiamante)
            objDA.AgregarParametro("@pureza", detalleEmpenio_.Pureza)
            objDA.AgregarParametro("@idTipoArte", detalleEmpenio_.IdTipoArte)
            objDA.AgregarParametro("@idTipoAntiguedades", detalleEmpenio_.IdTipoAntiguedades)
            objDA.AgregarParametro("@idSucursal", detalleEmpenio_.IdSucursal)
            objDA.AgregarParametro("@claveFolio_Documento", detalleEmpenio_.ClaveFolio_Documento)
            'objDA.AgregarParametro("@idDocumento", detalleEmpenio_.IdDocumento)
            objDA.AgregarParametro("@idTipoPrendaOro", detalleEmpenio_.IdTipoPrendaOro)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal detalleEmpenio_ As DetalleEmpenio)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_EliminarDetalleEmpenio")
            objDA.AgregarParametro("@idDetalleEmpenio", detalleEmpenio_.IdDetalleEmpenio)
            objDA.AgregarParametro("@idSucursal", detalleEmpenio_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal detalleEmpenio_ As DetalleEmpenio) As DetalleEmpenio
        Dim detalleEmp As DetalleEmpenio = Nothing
        Dim lst As List(Of DetalleEmpenio)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleEmpenio")
            objDA.AgregarParametro("@idDetalleEmpenio", detalleEmpenio_.IdDetalleEmpenio)
            objDA.AgregarParametro("@idSucursal", detalleEmpenio_.IdSucursal)
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            lst = objDA.ObtenerResultados(Of DetalleEmpenio)()
            detalleEmp = New DetalleEmpenio()
            detalleEmp = lst(0)
        End Using
        Return detalleEmp
    End Function
    Public Function ObtenerTodos(ByVal detalleEmpenio_ As DetalleEmpenio) As DetalleEmpenios
        Dim lst As New DetalleEmpenios()
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando("dbo.sp_ObtenerDetalleEmpenios")
            objDA.EstablecerTipoComando = TipoComando.ProcedimientoAlmacenado
            objDA.AgregarParametro("@idSucursal", detalleEmpenio_.IdSucursal)
            Dim lista As New List(Of DetalleEmpenio)
            lista = objDA.ObtenerResultados(Of DetalleEmpenio)()
            For Each detalleEmp As DetalleEmpenio In lista
                lst.Add(detalleEmp)
            Next
        End Using
        Return lst
    End Function
End Class
