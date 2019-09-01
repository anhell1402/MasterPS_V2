Public Class DetalleEmpenio
    Public Sub New()
        idEmpenio_ = New Empenio
        idMercancia_ = New Mercancia
        idTipoMotor_ = New Generico
        idNivelCombustible_ = New Generico
        idTipoFormaDiamante_ = New Generico
        idTipoArte_ = New Generico
        idTipoAntiguedades_ = New Generico
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
    Public WriteOnly Property SetIdEmpenio As Integer
        Set(value As Integer)
            idEmpenio_.IdEmpenio = value
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
    Public WriteOnly Property SetIdMercancia As Integer
        Set(value As Integer)
            idMercancia_.IdMercancia = value
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
End Class
