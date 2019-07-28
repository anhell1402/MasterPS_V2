Public Class ConfigOtrasVariables
    Private idOtrasVariables_ As Integer
    Public Property IdOtrasVariables As Integer
        Get
            Return idOtrasVariables_
        End Get
        Set(ByVal value As Integer)
            idOtrasVariables_ = value
        End Set
    End Property
    Private importeMinimoAbono_ As Decimal
    Public Property ImporteMinimoAbono As Decimal
        Get
            Return importeMinimoAbono_
        End Get
        Set(ByVal value As Decimal)
            importeMinimoAbono_ = value
        End Set
    End Property
    Private diasEnajenacion_ As Integer
    Public Property DiasEnajenacion As Integer
        Get
            Return diasEnajenacion_
        End Get
        Set(ByVal value As Integer)
            diasEnajenacion_ = value
        End Set
    End Property
    Private margenNegociacion_ As Integer
    Public Property MargenNegociacion As Integer
        Get
            Return margenNegociacion_
        End Get
        Set(ByVal value As Integer)
            margenNegociacion_ = value
        End Set
    End Property
    Private importeBoletaExtraviada_ As Decimal
    Public Property ImporteBoletaExtraviada As Decimal
        Get
            Return importeBoletaExtraviada_
        End Get
        Set(ByVal value As Decimal)
            importeBoletaExtraviada_ = value
        End Set
    End Property
    Private importeMinimoCobrar_ As Decimal
    Public Property ImporteMinimoCobrar As Decimal
        Get
            Return importeMinimoCobrar_
        End Get
        Set(ByVal value As Decimal)
            importeMinimoCobrar_ = value
        End Set
    End Property
    Private comisionVentaDemasia_ As Decimal
    Public Property ComisionVentaDemasia As Decimal
        Get
            Return comisionVentaDemasia_
        End Get
        Set(ByVal value As Decimal)
            comisionVentaDemasia_ = value
        End Set
    End Property
    Private gerente_ As String
    Public Property Gerente As String
        Get
            Return gerente_
        End Get
        Set(ByVal value As String)
            gerente_ = value
        End Set
    End Property
    Private nota_ As String
    Public Property Nota As String
        Get
            Return nota_
        End Get
        Set(ByVal value As String)
            nota_ = value
        End Set
    End Property
    Private limiteContratoUsuario_ As Decimal
    Public Property LimiteContratoUsuario As Decimal
        Get
            Return limiteContratoUsuario_
        End Get
        Set(ByVal value As Decimal)
            limiteContratoUsuario_ = value
        End Set
    End Property
    Private limiteContratoSupervisor_ As Decimal
    Public Property LimiteContratoSupervisor As Decimal
        Get
            Return limiteContratoSupervisor_
        End Get
        Set(ByVal value As Decimal)
            limiteContratoSupervisor_ = value
        End Set
    End Property
    Private limitePrestamoAuto_ As Decimal
    Public Property LimitePrestamoAuto As Decimal
        Get
            Return limitePrestamoAuto_
        End Get
        Set(ByVal value As Decimal)
            limitePrestamoAuto_ = value
        End Set
    End Property
    Private restriccionAbonoCapital_ As Integer
    Public Property RestriccionAbonoCapital As Integer
        Get
            Return restriccionAbonoCapital_
        End Get
        Set(ByVal value As Integer)
            restriccionAbonoCapital_ = value
        End Set
    End Property
    Private restriccionInteresMinimo_ As Integer
    Public Property RestriccionInteresMinimo As Integer
        Get
            Return restriccionInteresMinimo_
        End Get
        Set(ByVal value As Integer)
            restriccionInteresMinimo_ = value
        End Set
    End Property
    Private diasInteresMinimo_ As Integer
    Public Property DiasInteresMinimo As Integer
        Get
            Return diasInteresMinimo_
        End Get
        Set(ByVal value As Integer)
            diasInteresMinimo_ = value
        End Set
    End Property
    Private reporteContratoDiasVencidos_ As Integer
    Public Property ReporteContratoDiasVencidos As Integer
        Get
            Return reporteContratoDiasVencidos_
        End Get
        Set(ByVal value As Integer)
            reporteContratoDiasVencidos_ = value
        End Set
    End Property

End Class
