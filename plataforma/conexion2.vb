Imports System.Data.SqlClient
Imports System.IO
Public Class conexion2

    Protected cnn As New SqlConnection

    Public idusuario As Integer

    Public Function conectado()
        Try
            cnn = New SqlConnection("data source=.; Initial Catalog=dbrestaurante; Integrated Security=true")
            cnn.Open()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
