Public Class Empenio
    Public Sub New()
        idCliente_ = New Cliente
        idTasa_ = New ConfigTasa
        idUsuario_ = New Usuario
        idTipoEmpenio_ = New Generico
        idEstatusEmpenio_ = New Generico

    End Sub
    Private idEmpenio_ As Integer
    Public Property IdEmpenio As Integer
        Get
            Return idEmpenio_
        End Get
        Set(ByVal value As Integer)
            idEmpenio_ = value
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
    Private prestamo_ As Decimal
    Public Property Prestamo As Decimal
        Get
            Return prestamo_
        End Get
        Set(ByVal value As Decimal)
            prestamo_ = value
        End Set
    End Property
    Private idTasa_ As ConfigTasa
    Public Property IdTasa As ConfigTasa
        Get
            Return idTasa_
        End Get
        Set(ByVal value As ConfigTasa)
            idTasa_ = value
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
    Private fechaHora_ As DateTime
    Public Property FechaHora As DateTime
        Get
            Return fechaHora_
        End Get
        Set(ByVal value As DateTime)
            fechaHora_ = value
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
    Private mensaje_ As String
    Public Property Mensaje As String
        Get
            Return mensaje_
        End Get
        Set(ByVal value As String)
            mensaje_ = value
        End Set
    End Property
    Private folio_ As Int64
    Public Property Folio As Int64
        Get
            Return folio_
        End Get
        Set(ByVal value As Int64)
            folio_ = value
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
    Private idEstatusEmpenio_ As Generico
    Public Property IdEstatusEmpenio As Generico
        Get
            Return idEstatusEmpenio_
        End Get
        Set(ByVal value As Generico)
            idEstatusEmpenio_ = value
        End Set
    End Property
End Class
