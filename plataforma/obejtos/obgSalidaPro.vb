Public Class obgSalidaPro

    Private idSalida, cantidadSalida As Integer
    Private idProducto, nombrePro As String
    Private fechaSalida As Date

    Public Property gidsalida
        Get
            Return idSalida
        End Get
        Set(value)
            idSalida = value
        End Set
    End Property

    Public Property gidProducto
        Get
            Return idProducto
        End Get
        Set(value)
            idProducto = value
        End Set
    End Property

    Public Property gfechaSalida
        Get
            Return fechaSalida
        End Get
        Set(value)
            fechaSalida = value
        End Set
    End Property

    Public Property gcantidadSalida
        Get
            Return cantidadSalida
        End Get
        Set(value)
            cantidadSalida = value
        End Set
    End Property

    Public Property gnombrePro
        Get
            Return nombrePro
        End Get
        Set(value)
            nombrePro = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idSalida As Integer, ByVal idProducto As String, ByVal fechaSalida As Date, ByVal cantidadSalida As Integer, ByVal nombrePro As String)

        gidsalida = idSalida
        gidProducto = idProducto
        gfechaSalida = fechaSalida
        gcantidadSalida = cantidadSalida
        gnombrePro = nombrePro


    End Sub


End Class
