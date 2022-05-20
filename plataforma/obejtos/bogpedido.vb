Public Class bogpedido

    Private nro_pedido, total_consumido, mesa, id_personal As Integer
    Private nombre_personal, apellido_p As String
    Private fecha_p As Date

    Public Property gnro_pedido
        Get
            Return nro_pedido
        End Get
        Set(value)
            nro_pedido = value
        End Set
    End Property

    Public Property gtotal
        Get
            Return total_consumido
        End Get
        Set(value)
            total_consumido = value
        End Set
    End Property

    Public Property gfecha_p
        Get
            Return fecha_p
        End Get
        Set(value)
            fecha_p = value
        End Set
    End Property

    Public Property gmesa
        Get
            Return mesa
        End Get
        Set(value)
            mesa = value

        End Set
    End Property

    Public Property gid_personal
        Get
            Return id_personal
        End Get
        Set(value)
            id_personal = value
        End Set
    End Property

    Public Property gnombre_p
        Get
            Return nombre_personal
        End Get
        Set(value)
            nombre_personal = value
        End Set
    End Property

    Public Property gapellido_p
        Get
            Return apellido_p
        End Get
        Set(value)
            apellido_p = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal nro_pedido As Integer, ByVal total As Integer, ByVal fecha As Date, ByVal mesa As Integer, ByVal id_personal As Integer, ByVal nombre_p As String, ByVal apellido_p As String)

        gnro_pedido = nro_pedido
        gtotal = total
        gfecha_p = fecha
        gmesa = mesa
        gid_personal = id_personal
        gnombre_p = nombre_p
        gapellido_p = apellido_p

    End Sub
End Class
