Public Class obghorarioPersonal


    Private nro_horario, id_personal As Integer
    Private nombre, apellido_p, apellido_m, cargo, horario_i, horario_s, tipo_i, tipo_s As String
    Private fecha_i, fecha_s As Date


    Public Property gnro_hoario
        Get
            Return nro_horario
        End Get
        Set(value)
            nro_horario = value
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

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property gapellido_p
        Get
            Return apellido_p
        End Get
        Set(value)
            apellido_p = value
        End Set
    End Property

    Public Property gapellido_m
        Get
            Return apellido_m
        End Get
        Set(value)
            apellido_m = value
        End Set
    End Property

    Public Property gcargo
        Get
            Return cargo
        End Get
        Set(value)
            cargo = value
        End Set
    End Property

    Public Property gfecha_i
        Get
            Return fecha_i
        End Get
        Set(value)

            fecha_i = value
        End Set
    End Property

    Public Property gfecha_s
        Get
            Return fecha_s
        End Get
        Set(value)
            fecha_s = value
        End Set
    End Property

    Public Property ghorario_i
        Get
            Return horario_i
        End Get
        Set(value)
            horario_i = value
        End Set
    End Property

    Public Property gtipo_i
        Get
            Return tipo_i
        End Get
        Set(value)
            tipo_i = value
        End Set
    End Property

    Public Property ghorario_s
        Get
            Return horario_s
        End Get
        Set(value)
            horario_s = value
        End Set
    End Property

    Public Property gtipo_s
        Get
            Return tipo_s
        End Get
        Set(value)
            tipo_s = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal nro_horario As Integer, ByVal id_personal As Integer, ByVal nombre As String, ByVal apellido_p As String, ByVal apellido_m As String, ByVal cargo As String, ByVal fecha_i As Date, ByVal fecha_s As Date, ByVal hora_i As String, ByVal tipo_i As String, ByVal hora_s As String, ByVal tipo_s As String)
        gnro_hoario = nro_horario
        gid_personal = id_personal
        gnombre = nombre
        gapellido_p = apellido_p
        gapellido_m = apellido_m
        gcargo = cargo
        gfecha_i = fecha_i
        gfecha_s = fecha_s
        ghorario_i = hora_i
        gtipo_i = tipo_i
        ghorario_s = hora_s
        gtipo_s = tipo_s
    End Sub
End Class
