Public Class Menu
    Private idMenu_ As Integer
    Public Property IdMenu As Integer
        Get
            Return idMenu_
        End Get
        Set(ByVal value As Integer)
            idMenu_ = value
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
    Private idPadre_ As Integer
    Public Property IdPadre As Integer
        Get
            Return idPadre_
        End Get
        Set(ByVal value As Integer)
            idPadre_ = value
        End Set
    End Property
    Private formulario_ As Integer
    Public Property Formulario As Integer
        Get
            Return formulario_
        End Get
        Set(ByVal value As Integer)
            formulario_ = value
        End Set
    End Property
End Class
