Public Class ConfigTasa
    Public Sub New()
        idTipoTasa_ = New Generico
        idPeriodo_ = New Generico

    End Sub
    Private idTasa_ As Integer
    Public Property IdTasa As Integer
        Get
            Return idTasa_
        End Get
        Set(ByVal value As Integer)
            idTasa_ = value
        End Set
    End Property
    Private idTipoTasa_ As Generico
    Public Property IdTipoTasa As Generico
        Get
            Return idTipoTasa_
        End Get
        Set(ByVal value As Generico)
            idTipoTasa_ = value
        End Set
    End Property
    Private idPeriodo_ As Generico
    Public Property IdPeriodo As Generico
        Get
            Return idPeriodo_
        End Get
        Set(ByVal value As Generico)
            idPeriodo_ = value
        End Set
    End Property
    Private plazo_ As Integer
    Public Property Plazo As Integer
        Get
            Return plazo_
        End Get
        Set(ByVal value As Integer)
            plazo_ = value
        End Set
    End Property
    Private tasaTipica_ As Decimal
    Public Property TasaTipica As Decimal
        Get
            Return tasaTipica_
        End Get
        Set(ByVal value As Decimal)
            tasaTipica_ = value
        End Set
    End Property
    Private tasaPromocional_ As Decimal
    Public Property TasaPromocional As Decimal
        Get
            Return tasaPromocional_
        End Get
        Set(ByVal value As Decimal)
            tasaPromocional_ = value
        End Set
    End Property
    Private tasaPreferencial_ As Decimal
    Public Property TasaPreferencial As Decimal
        Get
            Return tasaPreferencial_
        End Get
        Set(ByVal value As Decimal)
            tasaPreferencial_ = value
        End Set
    End Property
    Private porcentajePrestamo_ As Decimal
    Public Property PorcentajePrestamo As Decimal
        Get
            Return porcentajePrestamo_
        End Get
        Set(ByVal value As Decimal)
            porcentajePrestamo_ = value
        End Set
    End Property
    Private cat_ As Decimal
    Public Property CAT As Decimal
        Get
            Return cat_
        End Get
        Set(ByVal value As Decimal)
            cat_ = value
        End Set
    End Property
    Private interesAnual_ As Decimal
    Public Property InteresAnual As Decimal
        Get
            Return interesAnual_
        End Get
        Set(ByVal value As Decimal)
            interesAnual_ = value
        End Set
    End Property
    Private almacenaje_ As Decimal
    Public Property Almacenaje As Decimal
        Get
            Return almacenaje_
        End Get
        Set(ByVal value As Decimal)
            almacenaje_ = value
        End Set
    End Property
    Private seguro_ As Decimal
    Public Property Seguro As Decimal
        Get
            Return seguro_
        End Get
        Set(ByVal value As Decimal)
            seguro_ = value
        End Set
    End Property
    Private diasMinimos_ As Integer
    Public Property DiasMinimos As Integer
        Get
            Return diasMinimos_
        End Get
        Set(ByVal value As Integer)
            diasMinimos_ = value
        End Set
    End Property
    Private diasGracia_ As Integer
    Public Property DiasGracia As Integer
        Get
            Return diasGracia_
        End Get
        Set(ByVal value As Integer)
            diasGracia_ = value
        End Set
    End Property

End Class

