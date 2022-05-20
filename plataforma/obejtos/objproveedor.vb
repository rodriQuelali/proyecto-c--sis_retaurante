Public Class objproveedor

    Private nitProveedor, telefono As Integer
    Private nombrePro, direccion As String

    Public Property gnitProveedor
        Get
            Return nitProveedor
        End Get
        Set(ByVal value)
            nitProveedor = value
        End Set
    End Property

    Public Property gnombreProve
        Get
            Return nombrePro
        End Get
        Set(ByVal value)
            nombrePro = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal nitproveedor As Integer, ByVal nombrePro As String, ByVal direccion As String, ByVal telefono As Integer)
        gnitProveedor = nitproveedor
        gnombreProve = nombrePro
        gdireccion = direccion
        gtelefono = telefono
    End Sub

End Class
