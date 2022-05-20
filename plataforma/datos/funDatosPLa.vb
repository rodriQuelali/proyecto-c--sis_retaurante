Imports System.Data.SqlClient
Imports System.IO
Public Class funDatosPLa
    Inherits conexion2
    Dim cmd As New SqlCommand

    Public Function mostra() As DataTable
        Try
            Dim cad As String


            cad = "select nombre_reseta,medida,cantidad from reseta where nombre_plato='" & FrmDatosPlato.txtnombreplato.Text & "'"

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
End Class
