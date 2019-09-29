Public Class ConfigApartado
    Public Sub New()
        idSucursal_ = New Sucursal()
    End Sub
    Private idConfigApartado_ As Integer
    Public Property IdConfigApartado As Integer
        Get
            Return idConfigApartado_
        End Get
        Set(ByVal value As Integer)
            idConfigApartado_ = value
        End Set
    End Property
    Private vencimientoApartado_ As Integer
    Public Property VencimientoApartado As Integer
        Get
            Return vencimientoApartado_
        End Get
        Set(ByVal value As Integer)
            vencimientoApartado_ = value
        End Set
    End Property
    Private engancheApartado_ As Decimal
    Public Property EngancheApartado As Decimal
        Get
            Return engancheApartado_
        End Get
        Set(ByVal value As Decimal)
            engancheApartado_ = value
        End Set
    End Property
    Private ivaVenta_ As Decimal
    Public Property IvaVenta As Decimal
        Get
            Return ivaVenta_
        End Get
        Set(ByVal value As Decimal)
            ivaVenta_ = value
        End Set
    End Property
    Private descuentoAutorizado_ As Decimal
    Public Property DescuentoAutorizado As Decimal
        Get
            Return descuentoAutorizado_
        End Get
        Set(ByVal value As Decimal)
            descuentoAutorizado_ = value
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
    Private penalizacionCancelacion_ As Integer
    Public Property PenalizacionCancelacion As Integer
        Get
            Return penalizacionCancelacion_
        End Get
        Set(ByVal value As Integer)
            penalizacionCancelacion_ = value
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
