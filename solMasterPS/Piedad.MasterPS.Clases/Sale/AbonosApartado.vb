Public Class AbonosApartado
    Public Sub New()
        idApartado_ = New Apartado()
        idUsuario_ = New Usuario()
        idSucursal_ = New Sucursal()
    End Sub
    Private idAbonosApartado_ As Integer
    Public Property IdAbonosApartados As Integer
        Get
            Return idAbonosApartado_
        End Get
        Set(ByVal value As Integer)
            idAbonosApartado_ = value
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
    Private montoAbonado_ As Decimal
    Public Property MontoAbonado As Decimal
        Get
            Return montoAbonado_
        End Get
        Set(ByVal value As Decimal)
            montoAbonado_ = value
        End Set
    End Property
    Private montoRestante_ As Decimal
    Public Property MontoRestante As Decimal
        Get
            Return montoRestante_
        End Get
        Set(ByVal value As Decimal)
            montoRestante_ = value
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
