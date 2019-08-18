Public Class CancelacionApartado
    Public Sub New()
        idApartado_ = New Apartado
        idTipoCancelacionApartado_ = New Generico
        idConfigApartado_ = New ConfigApartado
        idVenta_ = New Venta
    End Sub
    Private idCancelacionApartado_ As Integer
    Public Property IdCancelacionApartado As Integer
        Get
            Return idCancelacionApartado_
        End Get
        Set(ByVal value As Integer)
            idCancelacionApartado_ = value
        End Set
    End Property
    Private idApartado_ As Apartado
    Public Property IdApartado As Apartado
        Get
            Return idApartado_
        End Get
        Set(ByVal value As Apartado)
            idApartado_ = value
        End Set
    End Property
    Private idTipoCancelacionApartado_ As Generico
    Public Property IdTipoCancelacionApartado As Generico
        Get
            Return idTipoCancelacionApartado_
        End Get
        Set(ByVal value As Generico)
            idTipoCancelacionApartado_ = value
        End Set
    End Property
    Private montoActualAbonado_ As Decimal
    Public Property MontoActualAbonado As Decimal
        Get
            Return montoActualAbonado_
        End Get
        Set(ByVal value As Decimal)
            montoActualAbonado_ = value
        End Set
    End Property
    Private idConfigApartado_ As ConfigApartado
    Public Property IdConfigApartado As ConfigApartado
        Get
            Return idConfigApartado_
        End Get
        Set(ByVal value As ConfigApartado)
            idConfigApartado_ = value
        End Set
    End Property
    Private montoACuenta_ As Decimal
    Public Property MontoACuenta As Decimal
        Get
            Return montoACuenta_
        End Get
        Set(ByVal value As Decimal)
            montoACuenta_ = value
        End Set
    End Property
    Private idVenta_ As Venta
    Public Property IdVenta As Venta
        Get
            Return idVenta_
        End Get
        Set(ByVal value As Venta)
            idVenta_ = value
        End Set
    End Property

End Class
