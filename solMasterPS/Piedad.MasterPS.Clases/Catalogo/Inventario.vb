Public Class Inventario
    Public Sub New()
        idMercancia_ = New Mercancia
        idAdicionCompra_ = New AdicionCompra
        idEmpenio_ = New Empenio
        idDetalleMercanciaVenta_ = New DetalleMercanciaVenta
        idTipoIngreso_ = New Generico
        idEstatusInventario_ = New Generico
    End Sub
    Private idInventario_ As Integer
    Public Property IdInventario As Integer
        Get
            Return idInventario_
        End Get
        Set(ByVal value As Integer)
            idInventario_ = value
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
    Private idAdicionCompra_ As AdicionCompra
    Public Property IdAdicionCompra As AdicionCompra
        Get
            Return idAdicionCompra_
        End Get
        Set(ByVal value As AdicionCompra)
            idAdicionCompra_ = value
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
    Private idEmpenio_ As Empenio
    Public Property IdEmpenio As Empenio
        Get
            Return idEmpenio_
        End Get
        Set(ByVal value As Empenio)
            idEmpenio_ = value
        End Set
    End Property
    Private idDetalleMercanciaVenta_ As DetalleMercanciaVenta
    Public Property IdDetalleMercanciaVenta As DetalleMercanciaVenta
        Get
            Return idDetalleMercanciaVenta_
        End Get
        Set(ByVal value As DetalleMercanciaVenta)
            idDetalleMercanciaVenta_ = value
        End Set
    End Property
    Private diasVencidos_ As Integer
    Public Property DiasVencidos As Integer
        Get
            Return diasVencidos_
        End Get
        Set(ByVal value As Integer)
            diasVencidos_ = value
        End Set
    End Property
    Private idTipoIngreso_ As Generico
    Public Property IdTipoIngreso As Generico
        Get
            Return idTipoIngreso_
        End Get
        Set(ByVal value As Generico)
            idTipoIngreso_ = value
        End Set
    End Property
    Private idEstatusInventario_ As Generico
    Public Property IdEstatusInventario As Generico
        Get
            Return idEstatusInventario_
        End Get
        Set(ByVal value As Generico)
            idEstatusInventario_ = value
        End Set
    End Property

End Class
