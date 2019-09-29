Public Class Mercancia
    Public Sub New()
        idTipoEmpenio_ = New Generico()
        idTipoMercancia_Metal_ = New Generico()
        idFamilia_TipoKilataje_ = New Generico()
        idMarca_EstadoMetal_ = New Generico()
        idSucursal_ = New Sucursal()
    End Sub
    Private idMercancia_ As Integer
    Public Property IdMercancia As Integer
        Get
            Return idMercancia_
        End Get
        Set(ByVal value As Integer)
            idMercancia_ = value
        End Set
    End Property
    Private idTipoEmpenio_ As Generico
    Public Property IdTipoEmpenio As Generico
        Get
            Return idTipoEmpenio_
        End Get
        Set(ByVal value As Generico)
            idTipoEmpenio_ = value
        End Set
    End Property
    Private idTipoMercancia_Metal_ As Generico
    Public Property IdTipoMercancia_Metal As Generico
        Get
            Return idTipoMercancia_Metal_
        End Get
        Set(ByVal value As Generico)
            idTipoMercancia_Metal_ = value
        End Set
    End Property
    Private idFamilia_TipoKilataje_ As Generico
    Public Property IdFamilia_TipoKilataje As Generico
        Get
            Return idFamilia_TipoKilataje_
        End Get
        Set(ByVal value As Generico)
            idFamilia_TipoKilataje_ = value
        End Set
    End Property
    Private idMarca_EstadoMetal_ As Generico
    Public Property IdMarca_EstadoMetal As Generico
        Get
            Return idMarca_EstadoMetal_
        End Get
        Set(ByVal value As Generico)
            idMarca_EstadoMetal_ = value
        End Set
    End Property
    Private precioMaximo_ As Decimal
    Public Property PrecioMaximo As Decimal
        Get
            Return precioMaximo_
        End Get
        Set(ByVal value As Decimal)
            precioMaximo_ = value
        End Set
    End Property
    Private modelo_ As String
    Public Property Modelo As String
        Get
            Return modelo_
        End Get
        Set(ByVal value As String)
            modelo_ = value
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
