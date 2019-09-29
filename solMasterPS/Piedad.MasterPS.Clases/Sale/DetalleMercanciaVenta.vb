Public Class DetalleMercanciaVenta
    Public Sub New()
        idMercancia_ = New Mercancia()
        idSucursal_ = New Sucursal()
    End Sub
    Private idDetalleMercanciaVenta_ As Integer
    Public Property IdDetalleMercanciaVenta As Integer
        Get
            Return idDetalleMercanciaVenta_
        End Get
        Set(ByVal value As Integer)
            idDetalleMercanciaVenta_ = value
        End Set
    End Property
    Private descripcion_ As String
    Public Property Descripcion As String
        Get
            Return descripcion_
        End Get
        Set(ByVal value As String)
            descripcion_ = value
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
    Private precioUnitario_ As Decimal
    Public Property PrecioUnitario As Decimal
        Get
            Return precioUnitario_
        End Get
        Set(ByVal value As Decimal)
            precioUnitario_ = value
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
