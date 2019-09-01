Public Class Cancelacion
    Public Sub New()
        idVenta_ = New Venta
        idUsuario_ = New Usuario
        idEmpenio_ = New Empenio
    End Sub
    Private idCancelacion_ As Integer
    Public Property IdCancelacion As Integer
        Get
            Return idCancelacion_
        End Get
        Set(ByVal value As Integer)
            idCancelacion_ = value
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
    Private idUsuario_ As Usuario
    Public Property IdUsuario As Usuario
        Get
            Return idUsuario_
        End Get
        Set(ByVal value As Usuario)
            idUsuario_ = value
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
    Private fecha_ As DateTime
    Public Property Fecha As DateTime
        Get
            Return fecha_
        End Get
        Set(ByVal value As DateTime)
            fecha_ = value
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

End Class
