Public Class obgPedido_plato

    Private idpedido_plato, id_plato, nro_pedido, presio_plato, cantidad_plato, total, id_personal_plato As Integer
    Private nombre_pla, nombre_personla, apellido_personal As String
    Private fecha As Date

    Public Property gidpedido_plato
        Get
            Return idpedido_plato
        End Get
        Set(value)
            idpedido_plato = value
        End Set
    End Property

    Public Property gid_plato
        Get
            Return id_plato
        End Get
        Set(value)
            id_plato = value
        End Set
    End Property

    Public Property gnro_pedido
        Get
            Return nro_pedido
        End Get
        Set(value)
            nro_pedido = value
        End Set
    End Property

    Public Property gnombre_plato
        Get
            Return nombre_pla
        End Get
        Set(value)
            nombre_pla = value
        End Set
    End Property

    Public Property gpresio_plato
        Get
            Return presio_plato
        End Get
        Set(value)
            presio_plato = value
        End Set
    End Property

    Public Property gcantidad_plato
        Get
            Return cantidad_plato
        End Get
        Set(value)
            cantidad_plato = value
        End Set
    End Property

    Public Property gtotal
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property

    Public Property gfecha_pedido
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property

    Public Property gid_personal_pedido
        Get
            Return id_personal_plato
        End Get
        Set(value)
            id_personal_plato = value
        End Set
    End Property

    Public Property gnombre_personal
        Get
            Return nombre_personla
        End Get
        Set(value)
            nombre_personla = value
        End Set
    End Property

    Public Property gapellido_personal
        Get
            Return apellido_personal
        End Get
        Set(value)
            apellido_personal = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idplato_pedido As Integer, ByVal id_plato As Integer, ByVal nro_pedido As Integer, ByVal nombre_plato As String, ByVal presio_plat As Integer, ByVal cantidad_plato As Integer, ByVal total As Integer, ByVal fecha As Date, ByVal id_personal_pedido As Integer, ByVal nombre_personal As String, ByVal apellido_personal As String)

        gidpedido_plato = idpedido_plato
        gid_plato = id_plato
        gnro_pedido = nro_pedido
        gnombre_plato = nombre_plato
        gpresio_plato = presio_plat
        gcantidad_plato = cantidad_plato
        gtotal = total
        gfecha_pedido = fecha
        gid_personal_pedido = id_personal_pedido
        gnombre_personal = nombre_personal
        gapellido_personal = apellido_personal

    End Sub
End Class
