Public Class ConfigDatosProfeco
    Private idDatosContratoProfeco_ As Integer
    Public Property IdDatosContratoProfeco As Integer
        Get
            Return idDatosContratoProfeco_
        End Get
        Set(ByVal value As Integer)
            idDatosContratoProfeco_ = value
        End Set
    End Property
    Private numeroContratoAdhesion_ As String
    Public Property NumeroContratoAdhesion As String
        Get
            Return numeroContratoAdhesion_
        End Get
        Set(ByVal value As String)
            numeroContratoAdhesion_ = value
        End Set
    End Property
    Private fechaContratoAdhesion_ As DateTime
    Public Property FechaContratoAdhesion As DateTime
        Get
            Return fechaContratoAdhesion_
        End Get
        Set(ByVal value As DateTime)
            fechaContratoAdhesion_ = value
        End Set
    End Property
    Private paginaWeb_ As String
    Public Property PaginaWeb As String
        Get
            Return paginaWeb_
        End Get
        Set(ByVal value As String)
            paginaWeb_ = value
        End Set
    End Property
    Private autorizacionMercadeo_ As Integer
    Public Property AutorizacionMercadeo As Integer
        Get
            Return autorizacionMercadeo_
        End Get
        Set(ByVal value As Integer)
            autorizacionMercadeo_ = value
        End Set
    End Property
    Private horarioServicioPublico_ As String
    Public Property HorarioServicioPublico As String
        Get
            Return horarioServicioPublico_
        End Get
        Set(ByVal value As String)
            horarioServicioPublico_ = value
        End Set
    End Property
End Class
