Public Class DetalleEmpenio
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
    Private idNivelCombustible_ As Generico
    Public Property IdNivelCombustible As Generico
        Get
            Return idNivelCombustible_
        End Get
        Set(ByVal value As Generico)
            idNivelCombustible_ = value
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
    Private newPropertyValue As String
    Public Property NewProperty() As String
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As String)
            newPropertyValue = value
        End Set
    End Property
End Class
