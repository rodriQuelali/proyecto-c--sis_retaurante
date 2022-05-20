Public Class obgRegistroPlato

    Private idplato, presioU, cantidaStock As Integer
    Private nombrePlato, categoria As String

    Public Property gidplato
        Get
            Return idplato
        End Get
        Set(value)
            idplato = value
        End Set
    End Property

    Public Property gnombrePlato
        Get
            Return nombrePlato
        End Get
        Set(value)
            nombrePlato = value
        End Set
    End Property

    Public Property gpresioU
        Get
            Return presioU
        End Get
        Set(value)
            presioU = value
        End Set
    End Property

    Public Property gcantidaStock
        Get
            Return cantidaStock
        End Get
        Set(value)
            cantidaStock = value
        End Set
    End Property

    Public Property gcategoria
        Get
            Return categoria
        End Get
        Set(value)
            categoria = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idplato As Integer, ByVal nombrePlato As String, ByVal presioU As Integer, ByVal cantidaStock As Integer, ByVal categoria As String)
        gidplato = idplato
        gnombrePlato = nombrePlato
        gpresioU = presioU
        gcantidaStock = cantidaStock
        gcategoria = categoria

    End Sub
End Class
