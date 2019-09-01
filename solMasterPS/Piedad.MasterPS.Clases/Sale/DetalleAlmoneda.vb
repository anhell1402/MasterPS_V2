﻿Public Class DetalleAlmoneda
    Public Sub New()
        idAlmoneda_ = New Almoneda
        idEmpenio_ = New Empenio
        idTipoEmpenio_ = New Generico
    End Sub
    Private idDetalleAlmoneda_ As Integer
    Public Property IdDetalleAlmoneda As Integer
        Get
            Return idDetalleAlmoneda_
        End Get
        Set(ByVal value As Integer)
            idDetalleAlmoneda_ = value
        End Set
    End Property
    Private idAlmoneda_ As Almoneda
    Public Property IdAlmoneda As Almoneda
        Get
            Return idAlmoneda_
        End Get
        Set(ByVal value As Almoneda)
            idAlmoneda_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdAlmoneda As Integer
        Set(value As Integer)
            idAlmoneda_.IdAlmoneda = value
        End Set
    End Property
    Private idEmpenio_ As Empenio
    Public Property IdEmpenio As Empenio
        Get
            Return idEmpenio_
        End Get
        Set(ByVal value As Empenio)
            idEmpenio_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdEmpenio As Integer
        Set(value As Integer)
            idEmpenio_.IdEmpenio = value
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
    Private liberado_ As Integer
    Public Property Liberado As Integer
        Get
            Return liberado_
        End Get
        Set(ByVal value As Integer)
            liberado_ = value
        End Set
    End Property

End Class
