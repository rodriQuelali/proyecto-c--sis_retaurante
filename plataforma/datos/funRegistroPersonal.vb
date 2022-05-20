Imports System.Data.SqlClient
Imports System.IO
Public Class funRegistroPersonal
    Inherits conexion2
    Dim cmd As New SqlCommand
    Public respuesta As SqlDataReader

    Public Function mostra() As DataTable
        Try
            Dim cad As String


            'cad = "select * from personal"
            cad = "select personal.*,nro_acceso from personal_acceso,personal where personal.c_i=personal_acceso.ci_personal_acceso"
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

    Public Function insertar_personal(ByVal dts As obgRegistroPersonal) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_personal")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@c_i", dts.gci)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido_paterno", dts.gapPaterno)
            cmd.Parameters.AddWithValue("@apellido_materno", dts.gapMaterno)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@estado_civil", dts.gEstadoCivil)
            cmd.Parameters.AddWithValue("@edad", dts.gedad)
            cmd.Parameters.AddWithValue("@cargo", dts.gcargo)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)

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

    Public Function editar_personal(ByVal dts As obgRegistroPersonal) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("editar_personal")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@c_i", dts.gci)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido_paterno", dts.gapPaterno)
            cmd.Parameters.AddWithValue("@apellido_materno", dts.gapMaterno)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@estado_civil", dts.gEstadoCivil)
            cmd.Parameters.AddWithValue("@edad", dts.gedad)
            cmd.Parameters.AddWithValue("@cargo", dts.gcargo)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)


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

    Public Function eliminar_personal(ByVal dts As obgRegistroPersonal) As Boolean
        Try
            Dim cad As String
            Dim n As Integer

            cad = "delete from personal where c_i = " & dts.gci

            conectado()
            cmd.CommandType = CommandType.Text : cmd.CommandText = cad
            cmd.Connection = cnn

            n = cmd.ExecuteNonQuery

            If n = 1 Then
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
    Public Function mostra_acceso() As DataTable
        Try
            Dim cad As String


            cad = "select * from personal_acceso"


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
    Public Function insertar_personal_acceo(ByVal dts As obgRegistroPersonal) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_acceso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nro_acceso", dts.gnroAcceso)
            cmd.Parameters.AddWithValue("@ci_personal_acceso", dts.gci)
            cmd.Parameters.AddWithValue("@cargo", dts.gcargo)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido_paterno", dts.gapPaterno)



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


    Public Function cargar_combo() As DataTable
        Try
            Dim cad As String


            cad = "select nombre,apellido_paterno from personal"

            conectado()
            cmd.CommandType = CommandType.Text : cmd.CommandText = cad

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)


                respuesta = cmd.ExecuteReader

                While respuesta.Read

                    frmProductoMozo.txtnombre.Items.Add(respuesta.Item("nombre"))
                    frmProductoMozo.txtapellido.Items.Add(respuesta.Item("apellido_paterno"))

                End While
                respuesta.Close()


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

    Public da As New SqlDataAdapter
    Public ds As DataSet
    Dim registro, sw As Integer
    Public Sub generar_codigo()
        RUNsql("select * from personal_acceso") : registro = 0
        frmClaveAcceso.DataGridView1.DataSource = ds.Tables(0).DefaultView


        Dim num As Integer
        registro = 0
        registro = ds.Tables(0).Rows.Count - 1
        num = Integer.Parse(ds.Tables(0).Rows(registro).Item(0))
        frmClaveAcceso.txtnroAcceso.Text = (num + 1)
    End Sub
    Public Sub RUNsql(ByVal comando As String)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = comando
        conectado()
        cmd.Connection = cnn
        da.SelectCommand = cmd
        ds = New DataSet : da.Fill(ds)
    End Sub

End Class
