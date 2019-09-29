Public Class DetalleApartado
    Public Sub New()
        idApartado_ = New Apartado()
        idInventario_ = New Inventario()
        idSucursal_ = New Sucursal()
    End Sub
    Private idDetalleApartado_ As Integer
    Public Property IdDetalleApartado As Integer
        Get
            Return idDetalleApartado_
        End Get
        Set(ByVal value As Integer)
            idDetalleApartado_ = value
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
    Private idInventario_ As Inventario
    Public Property IdInventario As Inventario
        Get
            Return idInventario_
        End Get
        Set(ByVal value As Inventario)
            idInventario_ = value
        End Set
    End Property
    Private precio_ As Decimal
    Public Property Precio As Decimal
        Get
            Return precio_
        End Get
        Set(ByVal value As Decimal)
            precio_ = value
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
