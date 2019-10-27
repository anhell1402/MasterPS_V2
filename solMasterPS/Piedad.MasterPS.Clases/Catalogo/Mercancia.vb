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
    Public WriteOnly Property SetIdTipoEmpenio As Integer
        Set(value As Integer)
            idTipoEmpenio_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionTipoEmpenio As String
        Set(value As String)
            idTipoEmpenio_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionTipoEmpenio As String
        Get
            Return IdTipoEmpenio.Descripcion
        End Get
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
    Public WriteOnly Property SetIdTipoMercancia_Metal As Integer
        Set(value As Integer)
            idTipoMercancia_Metal_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionTipoMercancia_Metal As String
        Set(value As String)
            idTipoMercancia_Metal_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionTipoMercancia_Metal As String
        Get
            Return IdTipoMercancia_Metal.Descripcion
        End Get
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
    Public WriteOnly Property SetIdFamilia_TipoKilataje As Integer
        Set(value As Integer)
            idFamilia_TipoKilataje_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionFamilia_Kilataje As String
        Set(value As String)
            idFamilia_TipoKilataje_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionFamilia_TipoKilataje As String
        Get
            Return IdFamilia_TipoKilataje.Descripcion
        End Get
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
    Public WriteOnly Property SetIdMarca_EstadoMetal As Integer
        Set(value As Integer)
            idMarca_EstadoMetal_.IdGenerico = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionMarca_EstadoMetal As String
        Set(value As String)
            idMarca_EstadoMetal_.Descripcion = value
        End Set
    End Property
    Public ReadOnly Property DescripcionMarca_EstadoMetal As String
        Get
            Return IdMarca_EstadoMetal.Descripcion
        End Get
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
    Public WriteOnly Property SetIdSucursal_ As Integer
        Set(value As Integer)
            idSucursal_.IdSucursal = value
        End Set
    End Property
    Public WriteOnly Property SetDescripcionSucursal As String
        Set(value As String)
            idSucursal_.Nick = value
        End Set
    End Property
    Public ReadOnly Property DescripcionSucursal As String
        Get
            Return IdSucursal.Nick
        End Get
    End Property
End Class
