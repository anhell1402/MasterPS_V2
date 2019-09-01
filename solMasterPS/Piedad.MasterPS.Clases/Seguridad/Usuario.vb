Public Class Usuario

    Public Sub New()
        idRol_ = New Generico()
        idTelefono_ = New Generico()
        idDireccion_ = New Direccion()
    End Sub
    Private idUsuario_ As Integer
    Public Property IdUsuario As Integer
        Get
            Return idUsuario_
        End Get
        Set(ByVal value As Integer)
            idUsuario_ = value
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
    Private apaterno_ As String
    Public Property Apaterno As String
        Get
            Return apaterno_
        End Get
        Set(ByVal value As String)
            apaterno_ = value
        End Set
    End Property
    Private amaterno_ As String
    Public Property Amaterno As String
        Get
            Return amaterno_
        End Get
        Set(ByVal value As String)
            amaterno_ = value
        End Set
    End Property
    Private idRol_ As Generico
    Public Property IdRol As Generico
        Get
            Return idRol_
        End Get
        Set(ByVal value As Generico)
            idRol_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdRol As Integer
        Set(value As Integer)
            idRol_.IdGenerico = value
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
    Private username_ As String
    Public Property Username As String
        Get
            Return username_
        End Get
        Set(ByVal value As String)
            username_ = value
        End Set
    End Property
    Private password_ As String
    Public Property Password As String
        Get
            Return password_
        End Get
        Set(ByVal value As String)
            password_ = value
        End Set
    End Property
    Private status_ As Estatus
    Public Property Status As Estatus
        Get
            Return status_
        End Get
        Set(ByVal value As Estatus)
            status_ = value
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