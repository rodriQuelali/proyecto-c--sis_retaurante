Public Class frmSelecioMesas
    Dim a As Integer 'para cargar el numero de mesas
    Dim total As String
   
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim acceso As Integer



        If total <> "" Then

            acceso = total
            For i = 1 To 100

                If i = acceso Then

                Else
                    Button16.Text = acceso
                    Button16.BackColor = Color.BlueViolet
                    frmPedidos.Show()
                    frmPedidos.txtmesa.Text = acceso
                End If
            Next

        Else
            MsgBox("DIGITE UNA MESA")
        End If

        total = ""
    End Sub

   
    Private Sub frmSelecioMesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbnombreP.SelectedIndex = 0
        ComboBox1.Text = "A"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim a1 As Integer
        a1 = 1
        a = a + a1


    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        frmTotalMesa.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Format(TimeValue(Now), "HHH " & ":" & "mmm" & ":" & " sss")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Me.Close()
    End Sub
End Class