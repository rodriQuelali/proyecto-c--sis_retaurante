Imports System.Data.SqlClient
Imports System.IO
Public Class FunKardex
    Inherits conexion2
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_kardex")
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

    Public Function insertar_kardex(ByVal dts As obgKardex) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_kardex")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nro_kardex_alamcen", dts.gnro_kardex)
            cmd.Parameters.AddWithValue("@id_prodructo_kardex_almacen", dts.gidProducto)
            cmd.Parameters.AddWithValue("@nombre_prodructo_kardex_alamcen", dts.gnombre_p)
            cmd.Parameters.AddWithValue("@tipo_unidad_almacen", dts.gtipo_almacen)
            cmd.Parameters.AddWithValue("@saldo_inicial", dts.gsaldo_inicial)
            cmd.Parameters.AddWithValue("@increso", dts.gincreso)
            cmd.Parameters.AddWithValue("@total", dts.gtotal)
            cmd.Parameters.AddWithValue("@salida", dts.gsalida)
            cmd.Parameters.AddWithValue("@saldo_final", dts.gsaldo_final)

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

    Public Function editar_kardex(ByVal dts As obgKardex) As Boolean
        Try

            conectado()
            cmd = New SqlCommand("editar_kardex")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@id_prodructo_kardex_almacen", dts.gidProducto)
            cmd.Parameters.AddWithValue("@nombre_prodructo_kardex_alamcen", dts.gnombre_p)
            cmd.Parameters.AddWithValue("@tipo_unidad_almacen", dts.gtipo_almacen)
            

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

    Public Function eliminar_kardex(ByVal dts As obgKardex) As Boolean

        Try
            Dim cad As String
            Dim n As Integer

            cad = "delete from almacen_kardex where id_prodructo_kardex_almacen = '" & dts.gidProducto & "'"

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
