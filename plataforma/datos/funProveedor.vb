Imports System.Data.SqlClient
Imports System.IO
Public Class funProveedor
    Inherits conexion2
    Dim cmd As New SqlCommand

    Public Function mostra() As DataTable
        Try
            Dim cad As String


            cad = "select * from proveedor"

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

    Public Function insertar_proveedor(ByVal dts As objproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nit_proveedor", dts.gnitProveedor)
            cmd.Parameters.AddWithValue("@nombre_proveedor", dts.gnombreProve)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
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

    Public Function editar_proveedor(ByVal dts As objproveedor) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("editar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nit_proveedor", dts.gnitProveedor)
            cmd.Parameters.AddWithValue("@nombre_proveedor", dts.gnombreProve)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
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

    Public Function eliminar_proveedor(ByVal dts As objproveedor) As Boolean
        Try
            Dim cad As String
            Dim n As Integer

            cad = "delete from proveedor where nit_proveedor = " & dts.gnitProveedor

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
