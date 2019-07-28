Public Class ConfigTasasAplicadas
    Private idTasaAplicada_ As Integer
    Public Property IdTasaAplicada As Integer
        Get
            Return idTasaAplicada_
        End Get
        Set(ByVal value As Integer)
            idTasaAplicada_ = value
        End Set
    End Property
    Private gastosVenta_ As Decimal
    Public Property GastosVenta As Decimal
        Get
            Return gastosVenta_
        End Get
        Set(ByVal value As Decimal)
            gastosVenta_ = value
        End Set
    End Property
    Private gastosOperacion_ As Decimal
    Public Property GastosOperacion As Decimal
        Get
            Return gastosOperacion_
        End Get
        Set(ByVal value As Decimal)
            gastosOperacion_ = value
        End Set
    End Property
    Private iva_ As Decimal
    Public Property IVA As Decimal
        Get
            Return iva_
        End Get
        Set(ByVal value As Decimal)
            iva_ = value
        End Set
    End Property
    Private porcentajeUtilidad_ As Decimal
    Public Property PorcentajeUtilidad As Decimal
        Get
            Return porcentajeUtilidad_
        End Get
        Set(ByVal value As Decimal)
            porcentajeUtilidad_ = value
        End Set
    End Property

End Class
