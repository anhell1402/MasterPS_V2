Public Class Cliente
    Public Sub New()
        idDireccion_ = New Direccion()
        idTipoIdentificacion_ = New Generico()
        idTelefono_ = New Generico()
        idSexo_ = New Generico()
        idOcupacion_ = New Generico()
        idMedioEnterado_ = New Generico()
        idSucursal_ = New Sucursal()
    End Sub
    Private idCliente_ As Integer
    Public Property IdCliente As Integer
        Get
            Return idCliente_
        End Get
        Set(ByVal value As Integer)
            idCliente_ = value
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
    Private idDireccion_ As Direccion
    Public Property IdDireccion As Direccion
        Get
            Return idDireccion_
        End Get
        Set(ByVal value As Direccion)
            idDireccion_ = value
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
    Private idTelefono_ As Generico
    Public Property IdTelefono As Generico
        Get
            Return idTelefono_
        End Get
        Set(ByVal value As Generico)
            idTelefono_ = value
        End Set
    End Property
    Private fechaNacimiento_ As DateTime
    Public Property FechaNacimiento As DateTime
        Get
            Return fechaNacimiento_
        End Get
        Set(ByVal value As DateTime)
            fechaNacimiento_ = value
        End Set
    End Property
    Private idSexo_ As Generico
    Public Property IdSexo As Generico
        Get
            Return idSexo_
        End Get
        Set(ByVal value As Generico)
            idSexo_ = value
        End Set
    End Property
    Private email_ As String
    Public Property Email As String
        Get
            Return email_
        End Get
        Set(ByVal value As String)
            email_ = value
        End Set
    End Property
    Private idOcupacion_ As Generico
    Public Property IdOcupacion As Generico
        Get
            Return idOcupacion_
        End Get
        Set(ByVal value As Generico)
            idOcupacion_ = value
        End Set
    End Property
    Private alerta_ As String
    Public Property Alerta As String
        Get
            Return alerta_
        End Get
        Set(ByVal value As String)
            alerta_ = value
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
    Private idMedioEnterado_ As Generico
    Public Property IdMedioEnterado As Generico
        Get
            Return idMedioEnterado_
        End Get
        Set(ByVal value As Generico)
            idMedioEnterado_ = value
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
