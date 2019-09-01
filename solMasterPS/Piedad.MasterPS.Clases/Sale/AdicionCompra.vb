Public Class AdicionCompra
    Public Sub New()
        idCliente_ = New Cliente
        idTipoIngreso_ = New Generico
        idMercancia_ = New Mercancia
        idTipoEmpenio_ = New Generico
        idDetalleMercanciaVenta_ = New DetalleMercanciaVenta
    End Sub
    Private idAdicionCompra_ As Integer
    Public Property IdAdicionCompra As Integer
        Get
            Return idAdicionCompra_
        End Get
        Set(ByVal value As Integer)
            idAdicionCompra_ = value
        End Set
    End Property
    Private idCliente_ As Cliente
    Public Property IdCliente As Cliente
        Get
            Return idCliente_
        End Get
        Set(ByVal value As Cliente)
            idCliente_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdCliente As Integer
        Set(value As Integer)
            idCliente_.IdCliente = value
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
    Public WriteOnly Property SetIdTipoIngreso As Integer
        Set(value As Integer)
            idTipoIngreso_.IdGenerico = value
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
    Public WriteOnly Property SetIdMercancia As Integer
        Set(value As Integer)
            idMercancia_.IdMercancia = value
        End Set
    End Property
    Private idTipoEmpenio_ As Generico
    Public Property IdTipoEmpenio As Generico
        Get
            Return idTipoEmpenio_
        End Get
        Set(ByVal value As Generico)
            idTipoEmpenio_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdTipoEmpenio As Integer
        Set(value As Integer)
            idTipoEmpenio_.IdGenerico = value
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
    Public WriteOnly Property SetIdDetalleMercanciaVenta As Integer
        Set(value As Integer)
            idDetalleMercanciaVenta_.IdDetalleMercanciaVenta = value
        End Set
    End Property
End Class
