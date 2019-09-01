Public Class Almoneda
    Public Sub New()
        idUsuario_ = New Usuario
    End Sub
    Private idAlmoneda_ As Integer
    Public Property IdAlmoneda As Integer
        Get
            Return idAlmoneda_
        End Get
        Set(ByVal value As Integer)
            idAlmoneda_ = value
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

End Class
