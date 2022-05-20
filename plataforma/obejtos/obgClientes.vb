Public Class obgClientes

    Private telefono As Integer
    Private apellido, nit As String

    Public Property gnit
        Get
            Return nit
        End Get
        Set(value)
            nit = value
        End Set
    End Property

    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(value)
            apellido = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal nit As String, ByVal apellido As String, ByVal telefono As Integer)

        gnit = nit
        gapellido = apellido
        gtelefono = telefono
    End Sub
End Class
