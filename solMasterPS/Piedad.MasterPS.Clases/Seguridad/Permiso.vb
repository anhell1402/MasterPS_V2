Public Class Permiso
    Public Sub New()
        idMenu_ = New Menu()
        idRol_ = New Generico()
    End Sub
    Private idPermiso_ As Integer
    Public Property IdPermiso As Integer
        Get
            Return idPermiso_
        End Get
        Set(ByVal value As Integer)
            idPermiso_ = value
        End Set
    End Property
    Private idMenu_ As Menu
    Public Property IdMenu As Menu
        Get
            Return idMenu_
        End Get
        Set(ByVal value As Menu)
            idMenu_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdMenu As Integer
        Set(value As Integer)
            idMenu_.IdMenu = value
        End Set
    End Property
    Private idRol_ As Generico
    Public Property IdRol As Generico
        Get
            Return idRol_
        End Get
        Set(ByVal value As Generico)
            idRol_ = value
        End Set
    End Property
    Public WriteOnly Property SetIdRol As Integer
        Set(value As Integer)
            idRol_.IdGenerico = value
        End Set
    End Property
End Class
