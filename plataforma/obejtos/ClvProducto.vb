Public Class ClvProducto
    Dim peso, precio_unitario As Integer
    Dim idproducto, nombre_p, descripcion, tipo_p As String

    Public Property gidProducto
        Get
            Return idproducto
        End Get
        Set(ByVal value)
            idproducto = value

        End Set
    End Property

    Public Property gnombre_p
        Get
            Return nombre_p
        End Get
        Set(ByVal value)
            nombre_p = value
        End Set
    End Property


    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property

    Public Property gtipo_p
        Get
            Return tipo_p
        End Get
        Set(ByVal value)
            tipo_p = value
        End Set
    End Property

    Public Property gpeso
        Get
            Return peso
        End Get
        Set(ByVal value)
            peso = value
        End Set
    End Property

    Public Property gprecio_u
        Get
            Return precio_unitario
        End Get
        Set(ByVal value)
            precio_unitario = value

        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idproducto As Integer, ByVal nombre_p As String, ByVal descripcion As String, ByVal tipo_p As String, ByVal peso As Integer, ByVal presio_u As Integer)
        gidProducto = idproducto
        gnombre_p = nombre_p
        gdescripcion = descripcion
        gtipo_p = tipo_p
        gpeso = peso
        gprecio_u = presio_u
    End Sub
End Class
