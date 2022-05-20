Imports System.Data.SqlClient
Imports System.IO
Public Class funRegistroPlato
    Inherits conexion2
    Dim cmd As New SqlCommand

    Public Function mostra() As DataTable
        Try
            Dim cad As String


            cad = "select * from plato_gaserosa"

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

    


    Public Function insertar_plato(ByVal dts As obgRegistroPlato) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_plato")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ip_plato_gaseosa", dts.gidplato)
            cmd.Parameters.AddWithValue("@nombre_plato", dts.gnombrePlato)
            cmd.Parameters.AddWithValue("@presio_unitario", dts.gpresioU)
            cmd.Parameters.AddWithValue("@cantida_stock", dts.gcantidaStock)
            cmd.Parameters.AddWithValue("@categoria", dts.gcategoria)

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


    Public Function editar_plato(ByVal dts As obgRegistroPlato) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("editar_plato")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ip_plato_gaseosa", dts.gidplato)
            cmd.Parameters.AddWithValue("@nombre_plato", dts.gnombrePlato)
            cmd.Parameters.AddWithValue("@presio_unitario", dts.gpresioU)
            cmd.Parameters.AddWithValue("@cantida_stock", dts.gcantidaStock)
            cmd.Parameters.AddWithValue("@categoria", dts.gcategoria)


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

    Public Function eliminar_plato(ByVal dts As obgRegistroPlato) As Boolean
        Try
            Dim cad As String
            Dim n As Integer

            cad = "delete from plato_gaserosa where ip_plato_gaseosa = " & dts.gidplato

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

    Public da As New SqlDataAdapter
    Public ds As DataSet
    Dim registro, sw As Integer
    Public Sub generar_codigo()
        RUNsql("select * from plato_gaserosa") : registro = 0
        frmRegistroPlatos.DataGridView1.DataSource = ds.Tables(0).DefaultView


        Dim num As Integer
        registro = 0
        registro = ds.Tables(0).Rows.Count - 1
        num = Integer.Parse(ds.Tables(0).Rows(registro).Item(0))
        frmRegistroPlatos.txtidplato.Text = (num + 1)

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
