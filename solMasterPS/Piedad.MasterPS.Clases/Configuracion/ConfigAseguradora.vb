Public Class ConfigAseguradora
    Public Sub New()
        idSucursal_ = New Sucursal()
    End Sub
    Private idAseguradora_ As Integer
    Public Property IdAseguradora As Integer
        Get
            Return idAseguradora_
        End Get
        Set(ByVal value As Integer)
            idAseguradora_ = value
        End Set
    End Property
    Private numeroPoliza_ As String
    Public Property NumeroPoliza As String
        Get
            Return numeroPoliza_
        End Get
        Set(ByVal value As String)
            numeroPoliza_ = value
        End Set
    End Property
    Private fechaExpedicion_ As DateTime
    Public Property FechaExpedicion As DateTime
        Get
            Return fechaExpedicion_
        End Get
        Set(ByVal value As DateTime)
            fechaExpedicion_ = value
        End Set
    End Property
    Private aseguradora_ As String
    Public Property Aseguradora As String
        Get
            Return aseguradora_
        End Get
        Set(ByVal value As String)
            aseguradora_ = value
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
