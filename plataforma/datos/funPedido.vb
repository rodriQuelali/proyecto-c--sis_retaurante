Imports System.Data.SqlClient
Imports System.IO
Public Class funPedido
    Inherits conexion2
    Dim cmd As New SqlCommand
    Public respuesta As SqlDataReader
    Public Function mostraPedido(ByVal categoria As String) As DataTable
        Try
            Dim cad As String


            cad = "select nombre_plato,presio_unitario,ip_plato_gaseosa from plato_gaserosa where categoria='" & categoria & "'"

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

    Public Function insertar_pedido(ByVal dts As bogpedido) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_pedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@total_consumido", dts.gtotal)
            cmd.Parameters.AddWithValue("@fecha_pedido", dts.gfecha_p)
            cmd.Parameters.AddWithValue("@mesa", dts.gmesa)
            cmd.Parameters.AddWithValue("@id_personal_pedido", dts.gid_personal)
            cmd.Parameters.AddWithValue("@nombre_persona", dts.gnombre_p)
            cmd.Parameters.AddWithValue("@apellido_paterno_pedido", dts.gapellido_p)

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


    Public Function editar_pedido(ByVal dts As bogpedido) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("actualizarTotalPedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nro_pedido", dts.gnro_pedido)
            cmd.Parameters.AddWithValue("@total_consumido", dts.gtotal)

            cmd.Parameters.AddWithValue("@mesa", dts.gmesa)


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
    Public Function mostar_numero() As DataTable
        Try
            Dim cad As String


            cad = "select MAX(nro_pedido)as pedido_n from pedido"

            conectado()
            cmd.CommandType = CommandType.Text : cmd.CommandText = cad

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)


                respuesta = cmd.ExecuteReader

                While respuesta.Read

                    frmPedidos.txtnro_servicio.Text = (respuesta.Item("pedido_n"))

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
End Class
