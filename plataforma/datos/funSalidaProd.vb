Imports System.Data.SqlClient
Imports System.IO
Public Class funSalidaProd
    Inherits conexion2
    Dim cmd As New SqlCommand


    Public Function mostra() As DataTable
        Try
            Dim cad As String


            cad = "select * from salida"

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

    Public Function insertar_salida(ByVal dts As obgSalidaPro) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_salida")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_salida", dts.gidsalida)
            cmd.Parameters.AddWithValue("@id_producto_sallida", dts.gidProducto)
            cmd.Parameters.AddWithValue("@fecha_salida", dts.gfechaSalida)
            cmd.Parameters.AddWithValue("@cantidad_salida", dts.gcantidadSalida)
            cmd.Parameters.AddWithValue("@nombre_salida_producto", dts.gnombrePro)

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


    Public da As New SqlDataAdapter
    Public ds As DataSet
    Dim registro, sw As Integer
    Public Sub generar_codigo()
        RUNsql("select * from salida") : registro = 0
        frmCompraProducto.DataGridView1.DataSource = ds.Tables(0).DefaultView


        Dim num As Integer
        registro = 0
        registro = ds.Tables(0).Rows.Count - 1
        num = Integer.Parse(ds.Tables(0).Rows(registro).Item(0))
        frmSalidaProducto.txtidsalida.Text = (num + 1)
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
