Public Class DetalleVenta
    Public Sub New()
        idVenta_ = New Venta
        idInventario_ = New Inventario
    End Sub
    Private idDetalleVenta_ As Integer
    Public Property IdDetalleVenta As Integer
        Get
            Return idDetalleVenta_
        End Get
        Set(ByVal value As Integer)
            idDetalleVenta_ = value
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
    Public WriteOnly Property SetIdVenta As Integer
        Set(value As Integer)
            idVenta_.IdVenta = value
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
    Public WriteOnly Property SetIdInventario As Integer
        Set(value As Integer)
            idInventario_.IdInventario = value
        End Set
    End Property
    Private precioOficial_ As Decimal
    Public Property PrecioOficial As Decimal
        Get
            Return precioOficial_
        End Get
        Set(ByVal value As Decimal)
            precioOficial_ = value
        End Set
    End Property
    Private descuentoPorcentaje_ As Decimal
    Public Property DescuentoPorcentaje As Decimal
        Get
            Return descuentoPorcentaje_
        End Get
        Set(ByVal value As Decimal)
            descuentoPorcentaje_ = value
        End Set
    End Property
    Private precioFinal_ As Decimal
    Public Property PrecioFinal As Decimal
        Get
            Return precioFinal_
        End Get
        Set(ByVal value As Decimal)
            precioFinal_ = value
        End Set
    End Property
    Private cantidad_ As Integer
    Public Property Cantidad As Integer
        Get
            Return cantidad_
        End Get
        Set(ByVal value As Integer)
            cantidad_ = value
        End Set
    End Property

End Class
