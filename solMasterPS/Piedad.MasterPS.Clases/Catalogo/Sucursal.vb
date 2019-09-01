Public Class Sucursal
    Public Sub New()
        idDireccion_ = New Direccion
        idTelefono_ = New Generico
    End Sub
    Private idSucursal_ As Integer
    Public Property IdSucursal As Integer
        Get
            Return idSucursal_
        End Get
        Set(ByVal value As Integer)
            idSucursal_ = value
        End Set
    End Property
    Private nick_ As String
    Public Property Nick As String
        Get
            Return nick_
        End Get
        Set(ByVal value As String)
            nick_ = value
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
    Private mail_ As String
    Public Property Mail As String
        Get
            Return mail_
        End Get
        Set(ByVal value As String)
            mail_ = value
        End Set
    End Property
    Private rfc_ As String
    Public Property Rfc As String
        Get
            Return rfc_
        End Get
        Set(ByVal value As String)
            rfc_ = value
        End Set
    End Property
    Private idDireccion_ As Direccion
    Public Property IdDireccion As Direccion
        Get
            Return idDireccion_
        End Get
        Set(ByVal value As Direccion)
            idDireccion_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdDireccion As Integer
        Set(value As Integer)
            idDireccion_.IdDireccion = value
        End Set
    End Property
    Private idTelefono_ As Generico
    Public Property IdTelefono As Generico
        Get
            Return idTelefono_
        End Get
        Set(ByVal value As Generico)
            idTelefono_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdTelefono As Integer
        Set(value As Integer)
            idTelefono_.IdGenerico = value
        End Set
    End Property
End Class
