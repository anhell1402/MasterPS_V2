Public Class Direccion
    Public Sub New()
        idMunicipio_ = New Generico()
    End Sub
    Private idDireccion_ As Integer
    Public Property IdDireccion As Integer
        Get
            Return idDireccion_
        End Get
        Set(ByVal value As Integer)
            idDireccion_ = value
        End Set
    End Property
    Private calle_ As String
    Public Property Calle As String
        Get
            Return calle_
        End Get
        Set(ByVal value As String)
            calle_ = value
        End Set
    End Property
    Private colonia_ As String
    Public Property Colonia As String
        Get
            Return colonia_
        End Get
        Set(ByVal value As String)
            colonia_ = value
        End Set
    End Property
    Private cp_ As String
    Public Property CP As String
        Get
            Return cp_
        End Get
        Set(ByVal value As String)
            cp_ = value
        End Set
    End Property
    Private idMunicipio_ As Generico
    Public Property IdMunicipio As Generico
        Get
            Return idMunicipio_
        End Get
        Set(ByVal value As Generico)
            idMunicipio_ = value
        End Set
    End Property
    Private numExt_ As String
    Public Property NumExt As String
        Get
            Return numExt_
        End Get
        Set(ByVal value As String)
            numExt_ = value
        End Set
    End Property
    Private numInt_ As String
    Public Property NumInt As String
        Get
            Return numInt_
        End Get
        Set(ByVal value As String)
            numInt_ = value
        End Set
    End Property
End Class
