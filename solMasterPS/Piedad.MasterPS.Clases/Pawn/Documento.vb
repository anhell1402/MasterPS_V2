Public Class Documento
    Public Sub New()
        idTipoDocumento_ = New Generico()
        idDetalleEmpenio_ = New DetalleEmpenio()
        idSucursal_ = New Sucursal()
    End Sub
    Private idDocumento_ As Integer
    Public Property IdDocumento As Integer
        Get
            Return idDocumento_
        End Get
        Set(ByVal value As Integer)
            idDocumento_ = value
        End Set
    End Property
    Private idTipoDocumento_ As Generico
    Public Property IdTipoDocumento As Generico
        Get
            Return idTipoDocumento_
        End Get
        Set(ByVal value As Generico)
            idTipoDocumento_ = value
        End Set
    End Property
    Private idDetalleEmpenio_ As DetalleEmpenio
    Public Property IdDetalleEmpenio As DetalleEmpenio
        Get
            Return idDetalleEmpenio_
        End Get
        Set(ByVal value As DetalleEmpenio)
            idDetalleEmpenio_ = value
        End Set
    End Property
    Private mimeType_ As String
    Public Property MimeType As String
        Get
            Return mimeType_
        End Get
        Set(ByVal value As String)
            mimeType_ = value
        End Set
    End Property
    Private documento_ As Byte()
    Public Property Documento As Byte()
        Get
            Return documento_
        End Get
        Set(ByVal value As Byte())
            documento_ = value
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
