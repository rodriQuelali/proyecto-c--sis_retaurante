Public Class frmCantidad
    Public total As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uno As Integer
        uno = 1
        total = total & uno

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uno As Integer
        uno = 2
        total = total & uno

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim uno As Integer
        uno = 3
        total = total & uno
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim uno As Integer
        uno = 4
        total = total & uno
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim uno As Integer
        uno = 5
        total = total & uno
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim uno As Integer
        uno = 6
        total = total & uno
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim uno As Integer
        uno = 7
        total = total & uno
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim uno As Integer
        uno = 8
        total = total & uno
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim uno As Integer
        uno = 9
        total = total & uno
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If total = "" Then
            total = ""
        Else
            Dim uno As Integer
            uno = 0
            total = total & uno
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = ""
        total = ""
    End Sub

    Public total2 As Integer
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If total = "" Then

            MsgBox("dijite una cantidad")
        Else
            total2 = total
            frmPedidos.txtcantidad.Text = total2
            total2 = 0
            total = ""
            Me.Close()
        End If

    End Sub
End Class