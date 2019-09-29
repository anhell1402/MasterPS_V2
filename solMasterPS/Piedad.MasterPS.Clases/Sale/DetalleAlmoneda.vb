Public Class DetalleAlmoneda
    Public Sub New()
        idAlmoneda_ = New Almoneda()
        idEmpenio_ = New Empenio()
        idTipoEmpenio_ = New Generico()
        idSucursal_ = New Sucursal()
    End Sub
    Private idDetalleAlmoneda_ As Integer
    Public Property IdDetalleAlmoneda As Integer
        Get
            Return idDetalleAlmoneda_
        End Get
        Set(ByVal value As Integer)
            idDetalleAlmoneda_ = value
        End Set
    End Property
    Private idAlmoneda_ As Almoneda
    Public Property IdAlmoneda As Almoneda
        Get
            Return idAlmoneda_
        End Get
        Set(ByVal value As Almoneda)
            idAlmoneda_ = value
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
    Private idTipoEmpenio_ As Generico
    Public Property IdTipoEmpenio As Generico
        Get
            Return idTipoEmpenio_
        End Get
        Set(ByVal value As Generico)
            idTipoEmpenio_ = value
        End Set
    End Property
    Private liberado_ As Integer
    Public Property Liberado As Integer
        Get
            Return liberado_
        End Get
        Set(ByVal value As Integer)
            liberado_ = value
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
