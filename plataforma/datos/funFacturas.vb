Imports System.Data.SqlClient
Imports System.IO
Public Class funFacturas
    Inherits conexion2
    Dim cmd As New SqlCommand
    Public respuesta As SqlDataReader

    Public Function insertar_factura(ByVal dts As obgFactura) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_factura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@fecha_factura", dts.gfecha)
            cmd.Parameters.AddWithValue("@nit_cliente_factura", dts.gnit_cliente)
            cmd.Parameters.AddWithValue("@nombre_cliente_factura", dts.gnombre_cliente)
            cmd.Parameters.AddWithValue("@id_personal_mozo", dts.gid_personal)
            cmd.Parameters.AddWithValue("@nombre_mozo", dts.gnombre_mozo)
            cmd.Parameters.AddWithValue("@apellido_mozo", dts.gapellido_mozo)
            cmd.Parameters.AddWithValue("@id_pedido_factura", dts.gid_pedido_factura)
            cmd.Parameters.AddWithValue("@total", dts.gtotal)
            cmd.Parameters.AddWithValue("@tipo_efectivo", dts.gtipo_efectivo)
            cmd.Parameters.AddWithValue("@vuelto", dts.gvuelto)

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
    'insertando a clientes ala factura o biando la clase funcliente
    Public Function insertar_cliente(ByVal dts As obgClientes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_cliete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@nit", dts.gnit)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@telefono ", dts.gtelefono)


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

    Public Function busqueda_clie(ByVal dts As obgClientes) As DataTable
        Try
            Dim cad As String


            cad = "select nit,apellido,telefono from cliente where nit='" & dts.gnit & "'"

            conectado()
            cmd.CommandType = CommandType.Text : cmd.CommandText = cad

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)


                respuesta = cmd.ExecuteReader

                While respuesta.Read

                    frmCobrarPedido.txtnombre_cliente.Text = (respuesta.Item("apellido"))
                    
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
