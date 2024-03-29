﻿Public Class Mensaje
    Public Sub New()
        idEstatusMensaje_ = New Generico()
        idCliente_ = New Cliente()
        idSucursal_ = New Sucursal()
    End Sub
    Private idMensaje_ As Integer
    Public Property IdMensaje As Integer
        Get
            Return idMensaje_
        End Get
        Set(ByVal value As Integer)
            idMensaje_ = value
        End Set
    End Property
    Private mensaje_ As String
    Public Property Mensaje As String
        Get
            Return mensaje_
        End Get
        Set(ByVal value As String)
            mensaje_ = value
        End Set
    End Property
    Private fechaInicial_ As DateTime
    Public Property FechaInicial As DateTime
        Get
            Return fechaInicial_
        End Get
        Set(ByVal value As DateTime)
            fechaInicial_ = value
        End Set
    End Property
    Private idEstatusMensaje_ As Generico
    Public Property IdEstatusMensaje As Generico
        Get
            Return idEstatusMensaje_
        End Get
        Set(ByVal value As Generico)
            idEstatusMensaje_ = value
        End Set
    End Property
    Private fechaFinal_ As DateTime
    Public Property FechaFinal As DateTime
        Get
            Return fechaFinal_
        End Get
        Set(ByVal value As DateTime)
            fechaFinal_ = value
        End Set
    End Property
    Private idCliente_ As Cliente
    Public Property IdCliente As Cliente
        Get
            Return idCliente_
        End Get
        Set(ByVal value As Cliente)
            idCliente_ = value
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
