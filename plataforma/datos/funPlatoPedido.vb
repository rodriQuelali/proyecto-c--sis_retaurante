Imports System.Data.SqlClient
Imports System.IO
Public Class funPlatoPedido
    Inherits conexion2
    Dim cmd As New SqlCommand
    'muetro los platos de plato
    Public Function mostra() As DataTable
        Try
            Dim cad As String


            cad = "select id_plato_pedido,nombre_plato_peidido,presio_plato_pedido,total from plato_pedido where nro_pedido=" & frmPedidos.txtnro_servicio.Text

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
    Public Function insertar_pedido_plato(ByVal dts As obgPedido_plato) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_plato_pedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@nro_pedido", dts.gnro_pedido)
            cmd.Parameters.AddWithValue("@id_plato", dts.gid_plato)
            cmd.Parameters.AddWithValue("@nombre_plato_peidido", dts.gnombre_plato)
            cmd.Parameters.AddWithValue("@presio_plato_pedido", dts.gpresio_plato)
            cmd.Parameters.AddWithValue("@cantidad_plato", dts.gcantidad_plato)
            cmd.Parameters.AddWithValue("@total", dts.gtotal)
            cmd.Parameters.AddWithValue("@fecha_pedido_plato", dts.gfecha_pedido)
            cmd.Parameters.AddWithValue("@id_personal_plato", dts.gid_personal_pedido)
            cmd.Parameters.AddWithValue("@nombre_personal", dts.gnombre_personal)
            cmd.Parameters.AddWithValue("@apellido_personla", dts.gapellido_personal)

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


    Public Function eliminar_plato(ByVal dts As obgPedido_plato) As Boolean
        Try
            Dim cad As String
            Dim n As Integer

            cad = "delete from plato_pedido where id_plato_pedido = " & dts.gidpedido_plato

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
End Class
