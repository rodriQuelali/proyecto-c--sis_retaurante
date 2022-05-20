Imports System.Data.SqlClient
Imports System.IO
Public Class funHorario

    Inherits conexion2
    Dim cmd As New SqlCommand
    Public Function mostra() As DataTable
        Try
            Dim cad As String


            cad = "select * from horario"

            conectado()
            cmd.CommandType = CommandType.Text : cmd.CommandText = cad

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar_horario(ByVal dts As obghorarioPersonal) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_horario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@id_personal_horario", dts.gid_personal)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido_paterno", dts.gapellido_p)
            cmd.Parameters.AddWithValue("@apellido_materno", dts.gapellido_m)
            cmd.Parameters.AddWithValue("@cargo", dts.gcargo)
            cmd.Parameters.AddWithValue("@fecha_ingreso_horario", dts.gfecha_i)
            cmd.Parameters.AddWithValue("@fecha_salida_horario", dts.gfecha_s)
            cmd.Parameters.AddWithValue("@hora_ingreso_horaio", dts.ghorario_i)
            cmd.Parameters.AddWithValue("@tipo_ingreso", dts.gtipo_i)
            cmd.Parameters.AddWithValue("@hora_salida_horario", dts.ghorario_s)
            cmd.Parameters.AddWithValue("@tipo_salida", dts.gtipo_s)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar_horario(ByVal dts As obghorarioPersonal) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("editar_horario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nro_horari", dts.gnro_hoario)
            cmd.Parameters.AddWithValue("@id_personal_horario", dts.gid_personal)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido_paterno", dts.gapellido_p)
            cmd.Parameters.AddWithValue("@apellido_materno", dts.gapellido_m)
            cmd.Parameters.AddWithValue("@cargo", dts.gcargo)
            cmd.Parameters.AddWithValue("@fecha_ingreso_horario", dts.gfecha_i)
            cmd.Parameters.AddWithValue("@fecha_salida_horario", dts.gfecha_s)
            cmd.Parameters.AddWithValue("@hora_ingreso_horaio", dts.ghorario_i)
            cmd.Parameters.AddWithValue("@tipo_ingreso", dts.gtipo_i)
            cmd.Parameters.AddWithValue("@hora_salida_horario", dts.ghorario_s)
            cmd.Parameters.AddWithValue("@tipo_salida", dts.gtipo_s)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

End Class
