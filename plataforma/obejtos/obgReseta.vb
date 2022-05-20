Public Class obgReseta

    Private idReseta, idPlato As Integer
    Private nombreReseta, medida, descripcion, cantidad, idproducto, nombrePlato, nombreProducto As String

    Public Property gidReseta
        Get
            Return idReseta
        End Get
        Set(value)
            idReseta = value
        End Set
    End Property

    Public Property gnombreReseta
        Get
            Return nombreReseta
        End Get
        Set(value)
            nombreReseta = value
        End Set
    End Property

    Public Property gmedida
        Get
            Return medida
        End Get
        Set(value)
            medida = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property

    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property
    Public Property gidPlato
        Get
            Return idPlato
        End Get
        Set(value)

            idPlato = value
        End Set
    End Property

    Public Property gnombrePLato
        Get
            Return nombrePlato
        End Get
        Set(value)
            nombrePlato = value
        End Set
    End Property

    Public Property gidproducto
        Get
            Return idproducto
        End Get
        Set(value)
            idproducto = value
        End Set
    End Property

    Public Property gnomnbreProducto
        Get
            Return nombreProducto
        End Get
        Set(value)
            nombreProducto = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idReseta As Integer, ByVal nombreReseta As String, ByVal medida As String, ByVal descripcion As String, ByVal cantidad As String, ByVal idPlato As Integer, ByVal nombrePlato As String, ByVal idproducto As String, ByVal nombreProducto As String)

        gidReseta = idReseta
        gnombreReseta = nombreReseta
        gmedida = medida
        gdescripcion = descripcion
        gcantidad = cantidad
        gidPlato = idPlato
        gnombrePLato = nombrePlato
        gidproducto = idproducto
        gnomnbreProducto = nombreProducto
    End Sub
End Class
