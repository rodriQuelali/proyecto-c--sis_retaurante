Public Class obgCompraProducto

    Private idCompra, precio_U, cantidad_Compra, totalCompra, nit_proveedor As Integer
    Private idCompProducto, nombreProduc, marcaCompra, nombre_provedor, descripProducto As String
    Private fechaCom As Date

    Public Property gidCompra
        Get
            Return idCompra
        End Get
        Set(value)
            idCompra = value
        End Set
    End Property

    Public Property gidCompProducto
        Get
            Return idCompProducto
        End Get
        Set(value)
            idCompProducto = value
        End Set
    End Property

    Public Property gnombreProduc
        Get
            Return nombreProduc
        End Get
        Set(value)
            nombreProduc = value
        End Set
    End Property

    Public Property gdescripProducto
        Get
            Return descripProducto
        End Get
        Set(value)
            descripProducto = value
        End Set
    End Property

    Public Property gmarcaCompra
        Get
            Return marcaCompra
        End Get
        Set(value)
            marcaCompra = value
        End Set
    End Property

    Public Property gprecio_U
        Get
            Return precio_U
        End Get
        Set(value)
            precio_U = value
        End Set
    End Property

    Public Property gcantidad_Compra
        Get
            Return cantidad_Compra
        End Get
        Set(value)
            cantidad_Compra = value
        End Set
    End Property

    Public Property gtotalCompra
        Get
            Return totalCompra
        End Get
        Set(value)
            totalCompra = value
        End Set
    End Property

    Public Property gfechaCom
        Get
            Return fechaCom
        End Get
        Set(value)
            fechaCom = value
        End Set
    End Property

    Public Property gnit_proveedor
        Get
            Return nit_proveedor
        End Get
        Set(value)
            nit_proveedor = value
        End Set
    End Property

    Public Property gnombre_provedor
        Get
            Return nombre_provedor
        End Get
        Set(value)
            nombre_provedor = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idCompra As Integer, ByVal idCompProducto As String, ByVal nombreProduc As String, ByVal descripProducto As String, ByVal marcaCompra As String, ByVal precio_U As Integer, ByVal cantidad_Compra As Integer, ByVal totalCompra As Integer, ByVal fechaCom As Date, ByVal nit_proveedor As Integer, ByVal nombre_provedor As String)

        gidCompra = idCompra
        gidCompProducto = idCompProducto
        gnombreProduc = nombreProduc
        gdescripProducto = descripProducto
        gmarcaCompra = marcaCompra
        gprecio_U = precio_U
        gcantidad_Compra = cantidad_Compra
        gtotalCompra = totalCompra
        gfechaCom = fechaCom
        gnit_proveedor = nit_proveedor
        gnombre_provedor = nombre_provedor

    End Sub
End Class
