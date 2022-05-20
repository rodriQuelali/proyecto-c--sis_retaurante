Imports System.Data.SqlClient
Imports System.IO
Public Class clasProdructo
    Inherits conexion2
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_producto")
            cmd.CommandType = CommandType.StoredProcedure

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
    Public Function insertar_producto(ByVal dts As ClvProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_producto", dts.gidProducto)
            cmd.Parameters.AddWithValue("@nombre_producto", dts.gnombre_p)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@tipo_peso", dts.gtipo_p)
            cmd.Parameters.AddWithValue("@peso", dts.gpeso)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_u)

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

    Public Function editar(ByVal dts As ClvProducto) As Boolean
        Try

            conectado()
            cmd = New SqlCommand("editar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_producto", dts.gidProducto)
            cmd.Parameters.AddWithValue("@nombre_producto", dts.gnombre_p)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@tipo_peso", dts.gtipo_p)
            cmd.Parameters.AddWithValue("@peso", dts.gpeso)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_u)

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

    Public Function eliminar_producto(ByVal dts As ClvProducto) As Boolean
        Try
            Dim cad As String
            Dim n As Integer

            cad = "delete from producto where id_producto = '" & dts.gidProducto & "'"

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

    Public Sub GENERAR_CODIGO()
        Try

            Dim CMD As New SqlCommand("GENERAR_CODIGO_PRODUCTO")
            Dim CODCLI As String
            conectado()
            CMD.CommandType = 4
            CMD.Connection = cnn
            CMD.Parameters.Add("@CODIGO", SqlDbType.VarChar, 4).Direction = 2
            CMD.ExecuteNonQuery()

            CODCLI = CMD.Parameters("@CODIGO").Value

            frmProducto.txtidproducto.Text = CODCLI


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try

    End Sub
End Class