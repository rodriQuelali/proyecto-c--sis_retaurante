
Public Class obgRegistroPersonal

    Private ci, edad, telefono, nroAcceso As Integer
    Private nombre, apPaterno, apMaterno, direccion, EstadoCivil, Cargo As String

    Public Property gci
        Get
            Return ci
        End Get
        Set(value)
            ci = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property gapPaterno
        Get
            Return apPaterno
        End Get
        Set(value)
            apPaterno = value
        End Set
    End Property

    Public Property gapMaterno
        Get
            Return apMaterno
        End Get
        Set(value)
            apMaterno = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property gEstadoCivil
        Get
            Return EstadoCivil
        End Get
        Set(value)
            EstadoCivil = value
        End Set
    End Property

    Public Property gedad
        Get
            Return edad
        End Get
        Set(value)
            edad = value
        End Set
    End Property

    Public Property gcargo
        Get
            Return Cargo
        End Get
        Set(value)
            Cargo = value
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

    Public Property gnroAcceso
        Get
            Return nroAcceso
        End Get
        Set(value)
            nroAcceso = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal ci As Integer, ByVal nombre As String, ByVal apPaterno As String, ByVal apMterno As String, ByVal direccion As String, ByVal estdoCivil As String, ByVal edad As Integer, ByVal cargo As String, ByVal telefono As Integer, ByVal nroacceso As Integer)

        gci = ci
        gnombre = nombre
        gapPaterno = apPaterno
        gapMaterno = apMterno
        gdireccion = direccion
        gEstadoCivil = estdoCivil
        gedad = edad
        gcargo = cargo
        gtelefono = telefono
        gnroAcceso = nroacceso

    End Sub
End Class
