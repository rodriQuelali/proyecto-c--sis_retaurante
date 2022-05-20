Public Class obgKardex
    Dim nro_kardex, saldo_inicial, increso, total, salida, saldo_final As Integer
    Dim id_producto, nombre_producto, tipo_almacen As String

    Public Property gnro_kardex
        Get
            Return nro_kardex
        End Get
        Set(ByVal value)
            nro_kardex = value
        End Set
    End Property

    Public Property gsaldo_inicial
        Get
            Return saldo_inicial
        End Get
        Set(ByVal value)

            saldo_inicial = value
        End Set
    End Property

    Public Property gincreso
        Get
            Return increso
        End Get
        Set(ByVal value)
            increso = value
        End Set

    End Property

    
    Public Property gsalida
        Get
            Return salida
        End Get
        Set(ByVal value)
            salida = value
        End Set

    End Property

    Public Property gsaldo_final
        Get
            Return saldo_final
        End Get
        Set(ByVal value)
            saldo_final = value
        End Set

    End Property

    Public Property gtotal
        Get
            Return total
        End Get
        Set(ByVal value)
            total = value
        End Set

    End Property
    Public Property gidProducto
        Get
            Return id_producto
        End Get
        Set(ByVal value)
            id_producto = value

        End Set
    End Property

    Public Property gnombre_p
        Get
            Return nombre_producto
        End Get
        Set(ByVal value)
            nombre_producto = value
        End Set
    End Property

    Public Property gtipo_almacen
        Get
            Return tipo_almacen
        End Get
        Set(ByVal value)
            tipo_almacen = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal nro_kardex As Integer, ByVal idProducto As Integer, ByVal nombre_p As String, ByVal tipo_U As String, ByVal saldo_inicial As Integer, ByVal increso As Integer, ByVal total As Integer, ByVal salida As Integer, ByVal saldo_final As Integer)
        gnro_kardex = nro_kardex
        gidProducto = idProducto
        gnombre_p = nombre_p
        gtipo_almacen = tipo_almacen
        gsaldo_inicial = saldo_inicial
        gincreso = increso
        gtotal = total
        gsalida = salida
        gsaldo_final = saldo_final
    End Sub

End Class
