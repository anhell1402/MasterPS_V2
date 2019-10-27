Public Class DetalleEmpenio
    Public Sub New()
        idEmpenio_ = New Empenio()
        idMercancia_ = New Mercancia()
        idTipoMotor_ = New Generico()
        idNivelCombustible_ = New Generico()
        idTipoFormaDiamante_ = New Generico()
        idTipoArte_ = New Generico()
        idTipoAntiguedades_ = New Generico()
        idSucursal_ = New Sucursal()
        idDocumento_ = New Documento()
        idTipoPrendaOro_ = New Generico()
    End Sub
    Private idDetalleEmpenio_ As Integer
    Public Property IdDetalleEmpenio As Integer
        Get
            Return idDetalleEmpenio_
        End Get
        Set(ByVal value As Integer)
            idDetalleEmpenio_ = value
        End Set
    End Property
    Private idEmpenio_ As Empenio
    Public Property IdEmpenio As Empenio
        Get
            Return idEmpenio_
        End Get
        Set(ByVal value As Empenio)
            idEmpenio_ = value
        End Set
    End Property
    Private descripcionMercancia_ As String
    Public Property DescripcionMercancia As String
        Get
            Return descripcionMercancia_
        End Get
        Set(ByVal value As String)
            descripcionMercancia_ = value
        End Set
    End Property
    Private idMercancia_ As Mercancia
    Public Property IdMercancia As Mercancia
        Get
            Return idMercancia_
        End Get
        Set(ByVal value As Mercancia)
            idMercancia_ = value
        End Set
    End Property
    Private prestamoUnitario_ As Decimal
    Public Property PrestamoUnitario As Decimal
        Get
            Return prestamoUnitario_
        End Get
        Set(ByVal value As Decimal)
            prestamoUnitario_ = value
        End Set
    End Property
    Private avaluo_ As Decimal
    Public Property Avaluo As Decimal
        Get
            Return avaluo_
        End Get
        Set(ByVal value As Decimal)
            avaluo_ = value
        End Set
    End Property
    Private anio_ As Integer
    Public Property Anio As Integer
        Get
            Return anio_
        End Get
        Set(ByVal value As Integer)
            anio_ = value
        End Set
    End Property
    Private color_ As String
    Public Property Color As String
        Get
            Return color_
        End Get
        Set(ByVal value As String)
            color_ = value
        End Set
    End Property
    Private placas_ As String
    Public Property Placas As String
        Get
            Return placas_
        End Get
        Set(ByVal value As String)
            placas_ = value
        End Set
    End Property
    Private factura_ As String
    Public Property Factura As String
        Get
            Return factura_
        End Get
        Set(ByVal value As String)
            factura_ = value
        End Set
    End Property
    Private kilometraje_ As Decimal
    Public Property Kilometraje As Decimal
        Get
            Return kilometraje_
        End Get
        Set(ByVal value As Decimal)
            kilometraje_ = value
        End Set
    End Property
    Private agencia_ As String
    Public Property Agencia As String
        Get
            Return agencia_
        End Get
        Set(ByVal value As String)
            agencia_ = value
        End Set
    End Property
    Private numeroMotor_ As Decimal
    Public Property NumeroMotor As Decimal
        Get
            Return numeroMotor_
        End Get
        Set(ByVal value As Decimal)
            numeroMotor_ = value
        End Set
    End Property
    Private numeroChasis_ As Decimal
    Public Property NumeroChasis As Decimal
        Get
            Return numeroChasis_
        End Get
        Set(ByVal value As Decimal)
            numeroChasis_ = value
        End Set
    End Property
    Private repuve_ As String
    Public Property Repuve As String
        Get
            Return repuve_
        End Get
        Set(ByVal value As String)
            repuve_ = value
        End Set
    End Property
    Private idTipoMotor_ As Generico
    Public Property IdTipoMotor As Generico
        Get
            Return idTipoMotor_
        End Get
        Set(ByVal value As Generico)
            idTipoMotor_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdTipoMotor As Integer
        Set(value As Integer)
            idTipoMotor_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionTipoMotor As String
        Set(value As String)
            idTipoMotor_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionTipoMotor As String
        Get
            Return IdTipoMotor.Descripcion
        End Get
    End Property
    Private idNivelCombustible_ As Generico
    Public Property IdNivelCombustible As Generico
        Get
            Return idNivelCombustible_
        End Get
        Set(ByVal value As Generico)
            idNivelCombustible_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdNivelCombustible As Integer
        Set(value As Integer)
            idNivelCombustible_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcion As String
        Set(value As String)
            idNivelCombustible_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionNivelCombustible As String
        Get
            Return IdNivelCombustible.Descripcion
        End Get
    End Property
    Private numeroTarjetaCirculacion_ As Decimal
    Public Property NumeroTarjetaCirculacion As Decimal
        Get
            Return numeroTarjetaCirculacion_
        End Get
        Set(ByVal value As Decimal)
            numeroTarjetaCirculacion_ = value
        End Set
    End Property
    Private aseguradora_Artista_TipoDisenio_ As String
    Public Property Aseguradora_Artista_TipoDisenio As String
        Get
            Return aseguradora_Artista_TipoDisenio_
        End Get
        Set(ByVal value As String)
            aseguradora_Artista_TipoDisenio_ = value
        End Set
    End Property
    Private numeroPoliza_ As Decimal
    Public Property NumeroPoliza As Decimal
        Get
            Return numeroPoliza_
        End Get
        Set(ByVal value As Decimal)
            numeroPoliza_ = value
        End Set
    End Property
    Private fechaVencimiento_ As DateTime
    Public Property FechaVencimiento As DateTime
        Get
            Return fechaVencimiento_
        End Get
        Set(ByVal value As DateTime)
            fechaVencimiento_ = value
        End Set
    End Property
    Private cantidadPrendas_ As Integer
    Public Property CantidadPrendas As Integer
        Get
            Return cantidadPrendas_
        End Get
        Set(ByVal value As Integer)
            cantidadPrendas_ = value
        End Set
    End Property
    Private peso_ As Decimal
    Public Property Peso As Decimal
        Get
            Return peso_
        End Get
        Set(ByVal value As Decimal)
            peso_ = value
        End Set
    End Property
    Private pesoPiedra_ As Decimal
    Public Property PesoPiedra As Decimal
        Get
            Return pesoPiedra_
        End Get
        Set(ByVal value As Decimal)
            pesoPiedra_ = value
        End Set
    End Property
    Private numeroPiedras_ As Integer
    Public Property NumeroPiedras As Integer
        Get
            Return numeroPiedras_
        End Get
        Set(ByVal value As Integer)
            numeroPiedras_ = value
        End Set
    End Property
    Private tamanio_ As String
    Public Property Tamanio As String
        Get
            Return tamanio_
        End Get
        Set(ByVal value As String)
            tamanio_ = value
        End Set
    End Property
    Private numeroSerie_ As String
    Public Property NumeroSerie As String
        Get
            Return numeroSerie_
        End Get
        Set(ByVal value As String)
            numeroSerie_ = value
        End Set
    End Property
    Private idTipoFormaDiamante_ As Generico
    Public Property IdTipoFormaDiamante As Generico
        Get
            Return idTipoFormaDiamante_
        End Get
        Set(ByVal value As Generico)
            idTipoFormaDiamante_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdTipoFormaDiamante As Integer
        Set(value As Integer)
            idTipoFormaDiamante_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionTipoFormaDiamante As String
        Set(value As String)
            idTipoFormaDiamante_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionTipoFormaDiamante As String
        Get
            Return IdTipoFormaDiamante.Descripcion
        End Get
    End Property
    Private pureza_ As String
    Public Property Pureza As String
        Get
            Return pureza_
        End Get
        Set(ByVal value As String)
            pureza_ = value
        End Set
    End Property
    Private idTipoArte_ As Generico
    Public Property IdTipoArte As Generico
        Get
            Return idTipoArte_
        End Get
        Set(ByVal value As Generico)
            idTipoArte_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdTipoArte As Integer
        Set(value As Integer)
            idTipoArte_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionTipoArte As String
        Set(value As String)
            idTipoArte_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionTipoArte As String
        Get
            Return IdTipoArte.Descripcion
        End Get
    End Property
    Private idTipoAntiguedades_ As Generico
    Public Property IdTipoAntiguedades As Generico
        Get
            Return idTipoAntiguedades_
        End Get
        Set(ByVal value As Generico)
            idTipoAntiguedades_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdTipoAntiguedades As Integer
        Set(value As Integer)
            idTipoAntiguedades_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionTipoAntiguedades As String
        Set(value As String)
            idTipoAntiguedades_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionTipoAntiguedades As String
        Get
            Return IdTipoAntiguedades.Descripcion
        End Get
    End Property
    Private idSucursal_ As Sucursal
    Public Property IdSucursal As Sucursal
        Get
            Return idSucursal_
        End Get
        Set(ByVal value As Sucursal)
            idSucursal_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdSucursal As Integer
        Set(value As Integer)
            idSucursal_.IdSucursal = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionSucursal As String
        Set(value As String)
            idSucursal_.Nick = value
        End Set
    End Property
    Public ReadOnly Property DescripcionSucursal As String
        Get
            Return IdSucursal.Nick
        End Get
    End Property
    Private claveFolio_Documento_ As String
    Public Property ClaveFolio_Documento As String
        Get
            Return claveFolio_Documento_
        End Get
        Set(ByVal value As String)
            claveFolio_Documento_ = value
        End Set
    End Property
    Private idDocumento_ As Documento
    Public Property IdDocumento As Documento
        Get
            Return idDocumento_
        End Get
        Set(ByVal value As Documento)
            idDocumento_ = value
        End Set
    End Property
    Private idTipoPrendaOro_ As Generico
    Public Property IdTipoPrendaOro As Generico
        Get
            Return idTipoPrendaOro_
        End Get
        Set(ByVal value As Generico)
            idTipoPrendaOro_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdTipoPrendaOro As Integer
        Set(value As Integer)
            idTipoPrendaOro_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionTipoPrendaOro As String
        Set(value As String)
            idTipoPrendaOro_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionTipoPrendaOro As String
        Get
            Return IdTipoPrendaOro.Descripcion
        End Get
    End Property
End Class
