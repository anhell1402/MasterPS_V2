''' <summary>
''' Clase Generica Auxiliar para catAntiguedades, catArte, catMovimientoEmpenio, estado, estatusApartado, estatusEmpenio,
''' estatusInventario, estatusMensaje, estatusVenta, familia_tipoKilataje, marca_estadoMetal, medioEnterado, motivoChecador
''' municipio, nivelCombustible, ocupacion, pais, periodo, rol, sexo, telefono, tipoCancelacionApartado, tipoDocumento,
''' tipoEmpenio, tipoFormaDiamante, tipoIdentificacion, tipoIngreso, tipoMercancia_Metal, tipoMotor, tipoOperacionEmpenio
''' tipoTasa, tipoTelefono y caja.
''' </summary>
Public Class Generico
    Private idGenerico_ As Integer
    Public Property IdGenerico As Integer
        Get
            Return idGenerico_
        End Get
        Set(ByVal value As Integer)
            idGenerico_ = value
        End Set
    End Property

    Private descripcion_ As String
    Public Property Descripcion As String
        Get
            Return descripcion_
        End Get
        Set(ByVal value As String)
            descripcion_ = value
        End Set
    End Property

    Private auxiliarUno_ As String
    Public Property AuxiliarUno As String
        Get
            Return auxiliarUno_
        End Get
        Set(ByVal value As String)
            auxiliarUno_ = value
        End Set
    End Property

    Private idAuxiliarUno_ As Integer
    Public Property IdAuxiliarUno As Integer
        Get
            Return idAuxiliarUno_
        End Get
        Set(ByVal value As Integer)
            idAuxiliarUno_ = value
        End Set
    End Property

    Private descripcionAuxiliar_ As String
    Public Property DescripcionAuxiliar As String
        Get
            Return descripcionAuxiliar_
        End Get
        Set(value As String)
            descripcionAuxiliar_ = value
        End Set
    End Property
End Class
