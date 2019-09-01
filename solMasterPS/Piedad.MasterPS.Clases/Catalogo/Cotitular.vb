Public Class Cotitular
    Public Sub New()
        idCliente_ = New Cliente
        idTipoIdentificacion_ = New Generico

    End Sub
    Private idCotitular_ As Integer
    Public Property IdCotitular As Integer
        Get
            Return idCotitular_
        End Get
        Set(ByVal value As Integer)
            idCotitular_ = value
        End Set
    End Property
    Private nombre_ As String
    Public Property Nombre As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property
    Private apellidoPaterno_ As String
    Public Property ApellidoPaterno As String
        Get
            Return apellidoPaterno_
        End Get
        Set(ByVal value As String)
            apellidoPaterno_ = value
        End Set
    End Property
    Private apellidoMaterno_ As String
    Public Property ApellidoMaterno As String
        Get
            Return apellidoMaterno_
        End Get
        Set(ByVal value As String)
            apellidoMaterno_ = value
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
    Private idTipoIdentificacion_ As Generico
    Public Property IdTipoIdentificacion As Generico
        Get
            Return idTipoIdentificacion_
        End Get
        Set(ByVal value As Generico)
            idTipoIdentificacion_ = value
        End Set
    End Property
    Private numeroIdentificacion_ As String
    Public Property NumeroIdentificacion As String
        Get
            Return numeroIdentificacion_
        End Get
        Set(ByVal value As String)
            numeroIdentificacion_ = value
        End Set
    End Property

End Class
