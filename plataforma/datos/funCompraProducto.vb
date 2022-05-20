Imports System.Data.SqlClient
Imports System.IO
Public Class funCompraProducto
    Inherits conexion2
    Dim cmd As New SqlCommand


    Public Function mostra() As DataTable

        Try
            Dim cad As String


            cad = "select * from compra_producto"

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
    Public Function mostracargarExcel() As DataTable

        Try
            Dim cad As String


            cad = "select nombre_producto_compra,descripcion_compra,marca_compra,presio_unitario,cantida_comprada,total_compra,fecha_compra,nit_proveedor_compra,nombre_producto_compra from compra_producto"

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

    Public Function insertar_compra(ByVal dts As obgCompraProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_compra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_compra", dts.gidCompra)
            cmd.Parameters.AddWithValue("@id_producto_compra", dts.gidCompProducto)
            cmd.Parameters.AddWithValue("@nombre_producto_compra", dts.gnombreProduc)
            cmd.Parameters.AddWithValue("@descripcion_compra", dts.gdescripProducto)
            cmd.Parameters.AddWithValue("@marca_compra", dts.gmarcaCompra)
            cmd.Parameters.AddWithValue("@presio_unitario", dts.gprecio_U)
            cmd.Parameters.AddWithValue("@cantida_comprada", dts.gcantidad_Compra)
            cmd.Parameters.AddWithValue("@total_compra", dts.gtotalCompra)
            cmd.Parameters.AddWithValue("@fecha_compra", dts.gfechaCom)
            cmd.Parameters.AddWithValue("@nit_proveedor_compra", dts.gnit_proveedor)
            cmd.Parameters.AddWithValue("@nombre_proveedor_compra", dts.gnombre_provedor)

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
        RUNsql("select * from compra_producto") : registro = 0
        frmCompraProducto.DataGridView1.DataSource = ds.Tables(0).DefaultView


        Dim num As Integer
        registro = 0
        registro = ds.Tables(0).Rows.Count - 1
        num = Integer.Parse(ds.Tables(0).Rows(registro).Item(0))
        frmCompraProducto.txtidcompra.Text = (num + 1)
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
