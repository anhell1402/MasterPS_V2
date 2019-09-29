Public Class Movimiento
    Public Sub New()
        idEmpenio_ = New Empenio()
        idTipoOperacionEmpenio_ = New Generico()
        idEstatusEmpenio_ = New Generico()
        idUsuario_ = New Usuario()
        idSucursal_ = New Sucursal()
    End Sub
    Private idFolio_ As Integer
    Public Property IdFolio As Integer
        Get
            Return idFolio_
        End Get
        Set(ByVal value As Integer)
            idFolio_ = value
        End Set
    End Property
    Private fechaOperacion_ As DateTime
    Public Property FechaOperacion As DateTime
        Get
            Return fechaOperacion_
        End Get
        Set(ByVal value As DateTime)
            fechaOperacion_ = value
        End Set
    End Property
    Private diasDiferencia_ As Integer
    Public Property DiasDiferencia As Integer
        Get
            Return diasDiferencia_
        End Get
        Set(ByVal value As Integer)
            diasDiferencia_ = value
        End Set
    End Property
    Private diasReal_ As Integer
    Public Property DiasReal As Integer
        Get
            Return diasReal_
        End Get
        Set(ByVal value As Integer)
            diasReal_ = value
        End Set
    End Property
    Private importeDiasDiferencia_ As Decimal
    Public Property ImporteDiasDiferencia As Decimal
        Get
            Return importeDiasDiferencia_
        End Get
        Set(ByVal value As Decimal)
            importeDiasDiferencia_ = value
        End Set
    End Property
    Private interesDiario_ As Decimal
    Public Property InteresDiario As Decimal
        Get
            Return interesDiario_
        End Get
        Set(ByVal value As Decimal)
            interesDiario_ = value
        End Set
    End Property
    Private montoLiquidacion_ As Decimal
    Public Property MontoLiquidacion As Decimal
        Get
            Return montoLiquidacion_
        End Get
        Set(ByVal value As Decimal)
            montoLiquidacion_ = value
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
    Private prestamo_ As Decimal
    Public Property Prestamo As Decimal
        Get
            Return prestamo_
        End Get
        Set(ByVal value As Decimal)
            prestamo_ = value
        End Set
    End Property
    Private importePagado_ As Decimal
    Public Property ImportePagado As Decimal
        Get
            Return importePagado_
        End Get
        Set(ByVal value As Decimal)
            importePagado_ = value
        End Set
    End Property
    Private abonoCapital_ As Decimal
    Public Property AbonoCapital As Decimal
        Get
            Return abonoCapital_
        End Get
        Set(ByVal value As Decimal)
            abonoCapital_ = value
        End Set
    End Property
    Private interes_ As Decimal
    Public Property Interes As Decimal
        Get
            Return interes_
        End Get
        Set(ByVal value As Decimal)
            interes_ = value
        End Set
    End Property
    Private diasPorPagar_ As Integer
    Public Property DiasPorPagar As Integer
        Get
            Return diasPorPagar_
        End Get
        Set(ByVal value As Integer)
            diasPorPagar_ = value
        End Set
    End Property
    Private interesMesUno_ As Decimal
    Public Property InteresMesUno As Decimal
        Get
            Return interesMesUno_
        End Get
        Set(ByVal value As Decimal)
            interesMesUno_ = value
        End Set
    End Property
    Private liquidacionMesUno_ As Decimal
    Public Property LiquidacionMesUno As Decimal
        Get
            Return liquidacionMesUno_
        End Get
        Set(ByVal value As Decimal)
            liquidacionMesUno_ = value
        End Set
    End Property
    Private interesMesDos_ As Decimal
    Public Property InteresMesDos As Decimal
        Get
            Return interesMesDos_
        End Get
        Set(ByVal value As Decimal)
            interesMesDos_ = value
        End Set
    End Property
    Private liquidacionMesDos_ As Decimal
    Public Property LiquidacionMesDos As Decimal
        Get
            Return liquidacionMesDos_
        End Get
        Set(ByVal value As Decimal)
            liquidacionMesDos_ = value
        End Set
    End Property
    Private fechaMesUno_ As DateTime
    Public Property FechaMesUno As DateTime
        Get
            Return fechaMesUno_
        End Get
        Set(ByVal value As DateTime)
            fechaMesUno_ = value
        End Set
    End Property
    Private fechaMesDos_ As DateTime
    Public Property FechaMesDos As DateTime
        Get
            Return fechaMesDos_
        End Get
        Set(ByVal value As DateTime)
            fechaMesDos_ = value
        End Set
    End Property
    Private idTipoOperacionEmpenio_ As Generico
    Public Property IdTipoOperacionEmpenio As Generico
        Get
            Return idTipoOperacionEmpenio_
        End Get
        Set(ByVal value As Generico)
            idTipoOperacionEmpenio_ = value
        End Set
    End Property
    Private idEstatusEmpenio_ As Generico
    Public Property IdEstatusEmpenio As Generico
        Get
            Return idEstatusEmpenio_
        End Get
        Set(ByVal value As Generico)
            idEstatusEmpenio_ = value
        End Set
    End Property
    Private idUsuario_ As Usuario
    Public Property IdUsuario As Usuario
        Get
            Return idUsuario_
        End Get
        Set(ByVal value As Usuario)
            idUsuario_ = value
        End Set
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
End Class
