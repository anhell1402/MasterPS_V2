﻿Public Class Checador
    Public Sub New()
        idUsuario_ = New Usuario
        idMotivo_ = New Generico
        idCaja_ = New Generico
    End Sub
    Private idChecador_ As Integer
    Public Property IdChecador As Integer
        Get
            Return idChecador_
        End Get
        Set(ByVal value As Integer)
            idChecador_ = value
        End Set
    End Property
    Private idUsuario_ As Usuario
    Public Property IdUsuario As Usuario
        Get
            Return idUsuario_
        End Get
        Set(ByVal value As Usuario)
            idUsuario_ = value
        End Set
    End Property
    Private idMotivo_ As Generico
    Public Property IdMotivo As Generico
        Get
            Return idMotivo_
        End Get
        Set(ByVal value As Generico)
            idMotivo_ = value
        End Set
    End Property
    Private idCaja_ As Generico
    Public Property IdCaja As Generico
        Get
            Return idCaja_
        End Get
        Set(ByVal value As Generico)
            idCaja_ = value
        End Set
    End Property
    Private fechaHora_ As DateTime
    Public Property FechaHora As DateTime
        Get
            Return fechaHora_
        End Get
        Set(ByVal value As DateTime)
            fechaHora_ = value
        End Set
    End Property
    Private entrada_ As Integer
    Public Property Entrada As Integer
        Get
            Return entrada_
        End Get
        Set(ByVal value As Integer)
            entrada_ = value
        End Set
    End Property
End Class