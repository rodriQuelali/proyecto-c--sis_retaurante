Public Class obgFactura

    Private nro_factura, id_personal, id_pedido_factura, total, vuelto As Integer
    Private nombre_cliente, tipo_efectivo, nombre_mozo, apellido_mozo, nit_cliente As String
    Private fecha As Date

    Public Property gnro_factura
        Get
            Return nro_factura
        End Get
        Set(value)
            nro_factura = value
        End Set
    End Property

    Public Property gfecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property

    Public Property gnit_cliente
        Get
            Return nit_cliente
        End Get
        Set(value)
            nit_cliente = value
        End Set
    End Property

    Public Property gnombre_cliente
        Get
            Return nombre_cliente
        End Get
        Set(value)
            nombre_cliente = value
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

    Public Property gnombre_mozo
        Get
            Return nombre_mozo
        End Get
        Set(value)
            nombre_mozo = value
        End Set
    End Property

    Public Property gapellido_mozo
        Get
            Return apellido_mozo
        End Get
        Set(value)
            apellido_mozo = value
        End Set
    End Property

    Public Property gid_pedido_factura
        Get
            Return id_pedido_factura
        End Get
        Set(value)
            id_pedido_factura = value
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

    Public Property gtipo_efectivo
        Get
            Return tipo_efectivo
        End Get
        Set(value)
            tipo_efectivo = value
        End Set
    End Property

    Public Property gvuelto
        Get
            Return vuelto
        End Get
        Set(value)
            vuelto = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal nro_factura As Integer, ByVal fecha_factura As Date, ByVal nit_cliente As String, ByVal nombre_cliente As String, ByVal id_personal As Integer, ByVal nombre_mozo As String, ByVal apellido_mozo As String, ByVal id_pedido As Integer, ByVal total As Integer, ByVal tipo_efectivo As String, ByVal vuelto As Integer)

        gnro_factura = nro_factura
        gfecha = fecha_factura
        gnit_cliente = nit_cliente
        gnombre_cliente = nombre_cliente
        gid_personal = id_personal
        gnombre_mozo = nombre_mozo
        gapellido_mozo = apellido_mozo
        gid_pedido_factura = id_personal
        gtotal = total
        gtipo_efectivo = tipo_efectivo
        gvuelto = vuelto

    End Sub
End Class
