Imports System.Data.SqlClient
Imports System.IO
Public Class funReseta
    Inherits conexion2
    Dim cmd As New SqlCommand
    Public Function mostra() As DataTable
        Try
            Dim cad As String


            cad = "select * from reseta"

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

    Public Function insertar_reseta(ByVal dts As obgReseta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_reseta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_reseta", dts.gidReseta)
            cmd.Parameters.AddWithValue("@nombre_reseta", dts.gnombreReseta)
            cmd.Parameters.AddWithValue("@medida", dts.gmedida)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@id_plato", dts.gidPlato)
            cmd.Parameters.AddWithValue("@nombre_plato", dts.gnombrePLato)
            cmd.Parameters.AddWithValue("@id_producto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@nombre_producto", dts.gnomnbreProducto)

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
        RUNsql("select * from reseta") : registro = 0
        frmResta.DataGridView2.DataSource = ds.Tables(0).DefaultView


        Dim num As Integer
        registro = 0
        registro = ds.Tables(0).Rows.Count - 1
        num = Integer.Parse(ds.Tables(0).Rows(registro).Item(0))
        frmResta.txtidreseta.Text = (num + 1)

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
