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
    Private control_ As String
    Public Property Control As String
        Get
            Return control_
        End Get
        Set(ByVal value As String)
            control_ = value
        End Set
    End Property
    Private panelControl_ As String
    Public Property PanelControl As String
        Get
            Return panelControl_
        End Get
        Set(value As String)
            panelControl_ = value
        End Set
    End Property
End Class
