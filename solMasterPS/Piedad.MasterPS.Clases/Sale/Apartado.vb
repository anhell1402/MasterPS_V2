Public Class Apartado
    Public Sub New()
        idCliente_ = New Cliente
        idUsuario_ = New Usuario
        idEstatusApartado_ = New Generico
    End Sub
    Private idApartado_ As Integer
    Public Property IdApartado As Integer
        Get
            Return idApartado_
        End Get
        Set(ByVal value As Integer)
            idApartado_ = value
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
    Private idUsuario_ As Usuario
    Public Property IdUsuario As Usuario
        Get
            Return idUsuario_
        End Get
        Set(ByVal value As Usuario)
            idUsuario_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdUsuario As Integer
        Set(value As Integer)
            idUsuario_.IdUsuario = value
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
    Private total_ As Decimal
    Public Property Total As Decimal
        Get
            Return total_
        End Get
        Set(ByVal value As Decimal)
            total_ = value
        End Set
    End Property
    Private fechaFinalApartado_ As DateTime
    Public Property FechaFinalApartado As DateTime
        Get
            Return fechaFinalApartado_
        End Get
        Set(ByVal value As DateTime)
            fechaFinalApartado_ = value
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
    Private idEstatusApartado_ As Generico
    Public Property IdEstatusApartado As Generico
        Get
            Return idEstatusApartado_
        End Get
        Set(ByVal value As Generico)
            idEstatusApartado_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdEstatusApartado As Integer
        Set(value As Integer)
            idEstatusApartado_.IdGenerico = value
        End Set
    End Property
    Private idApartadoRelacionado_ As Integer
    Public Property IdApartadoRelacionado As Integer
        Get
            Return idApartadoRelacionado_
        End Get
        Set(ByVal value As Integer)
            idApartadoRelacionado_ = value
        End Set
    End Property

End Class
