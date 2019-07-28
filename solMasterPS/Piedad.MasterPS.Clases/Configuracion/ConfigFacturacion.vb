Public Class ConfigFacturacion
    Private idFacturacion_ As Integer
    Public Property IdFacturacion As Integer
        Get
            Return idFacturacion_
        End Get
        Set(ByVal value As Integer)
            idFacturacion_ = value
        End Set
    End Property
    Private serie_ As Decimal
    Public Property Serie As Decimal
        Get
            Return serie_
        End Get
        Set(ByVal value As Decimal)
            serie_ = value
        End Set
    End Property
    Private folio_ As Decimal
    Public Property Folio As Decimal
        Get
            Return folio_
        End Get
        Set(ByVal value As Decimal)
            folio_ = value
        End Set
    End Property

End Class
