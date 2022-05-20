Imports System.Data.SqlClient
Imports System.IO
Public Class funAccesoSistema
    Inherits conexion2
    Dim cmd As New SqlCommand
    Public respuesta As SqlDataReader

    Public Function acceso_sistema(ByVal dts As obgRegistroPersonal) As DataTable
        Try
            Dim cad As String


            cad = "select nro_acceso,nombre,apellido_paterno from personal_acceso where (cargo='MOZO' or cargo='CAJERO') and nro_acceso=" & dts.gnroAcceso

            conectado()
            cmd.CommandType = CommandType.Text : cmd.CommandText = cad

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)


                    respuesta = cmd.ExecuteReader

                    While respuesta.Read
                    frmSelecioMesas.CbnombreP.Items.Add(respuesta.Item("nombre") & " " & respuesta.Item("apellido_paterno"))
                    frmPedidos.txtidpersonal.Text = (respuesta.Item("nro_acceso"))
                    frmPedidos.txtnpmbreP.Text = (respuesta.Item("nombre"))
                    frmPedidos.txtapellido.Text = (respuesta.Item("apellido_paterno"))
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
