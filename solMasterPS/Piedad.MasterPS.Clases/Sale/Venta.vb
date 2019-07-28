Public Class Venta
    Public Sub New()
        idCliente_ = New Cliente
        idUsuario_ = New Usuario
        idEstatusVenta_ = New Generico
    End Sub
    Private idVenta_ As Integer
    Public Property IdVenta As Integer
        Get
            Return idVenta_
        End Get
        Set(ByVal value As Integer)
            idVenta_ = value
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
    Private idUsuario_ As Usuario
    Public Property IdUsuario As Usuario
        Get
            Return idUsuario_
        End Get
        Set(ByVal value As Usuario)
            idUsuario_ = value
        End Set
    End Property
    Private fechaRegistro_ As DateTime
    Public Property FechaRegistro As DateTime
        Get
            Return fechaRegistro_
        End Get
        Set(ByVal value As DateTime)
            fechaRegistro_ = value
        End Set
    End Property
    Private precioTotal_ As Decimal
    Public Property PrecioTotal As Decimal
        Get
            Return precioTotal_
        End Get
        Set(ByVal value As Decimal)
            precioTotal_ = value
        End Set
    End Property
    Private idEstatusVenta_ As Generico
    Public Property IdEstatusVenta As Generico
        Get
            Return idEstatusVenta_
        End Get
        Set(ByVal value As Generico)
            idEstatusVenta_ = value
        End Set
    End Property

End Class
