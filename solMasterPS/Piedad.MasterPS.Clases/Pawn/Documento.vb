Public Class Documento
    Public Sub New()
        idTipoDocumento_ = New Generico
        idDetalleEmpenio_ = New DetalleEmpenio
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
    Public WriteOnly Property SetIdTipoDocumento As Integer
        Set(value As Integer)
            idTipoDocumento_.IdGenerico = value
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
    Public WriteOnly Property SetIdDetalleEmpenio As Integer
        Set(value As Integer)
            idDetalleEmpenio_.IdDetalleEmpenio = value
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
End Class
