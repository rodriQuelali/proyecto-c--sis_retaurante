Public Class frmPersonal

    Private Sub frmPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebCam1.Start()
        WebCam1.Start()
        lb1.Text = Format(TimeValue(Now), "HHH mmm sss")
        TextBox3.Text = Format(TimeValue(Now), "HHH mmm sss")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        WebCam1.Stop()

        WebCam1.Stop()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PictureBox1.Image = WebCam1.Imagen
        SaveFileDialog1.ShowDialog()
        PictureBox1.Image.Save(SaveFileDialog1.FileName)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lb1.Text = Format(TimeValue(Now), "HHH " & ":" & "mmm" & ":" & " sss")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = Format(TimeValue(Now), "HHH mmm ")
        lb1.Text = Format(TimeValue(Now), "HHH mmm ")
        lb2.Text = Format(TimeValue(Now), "HHH mmm ")

        MsgBox(lb2.Text)

        If lb2.Text > txtcompraacion.Text Then
            lb3.Text = Format(TimeValue(Now), "HHH")
            lb2.Text = Format(TimeValue(Now), " mmm ")
            lb3.Text = lb3.Text - txtcompraacion.Text
            lb3.Text = lb3.Text * 60
            lb4.Text = Convert.ToInt32(lb3.Text) + Convert.ToInt32(lb2.Text)


            MsgBox("tarde... con minnutos de retraso " & lb3.Text & " " & lb2.Text & "total de suma de minutos " & lb4.Text)


        Else
            MsgBox("temprano.....")

        End If
    End Sub
End Class