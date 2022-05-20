Imports System.Runtime.InteropServices
Public Class pruevaCamara

    Private Sub pruevaCamara_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebCam1.Start()
        WebCam1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebCam1.Stop()

        WebCam1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Try

        '    Dim data As IDataObject
        '    PictureBox1.Image = WebCam1.Imagen

        '    PictureBox1.Image.Save("Bibliotecas\Imágenes\rooooooo.jpg")


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


        PictureBox1.Image = WebCam1.Imagen
        SaveFileDialog1.FileName = "rorioo"
        SaveFileDialog1.ShowDialog()

        PictureBox1.Image.Save(SaveFileDialog1.FileName)

    End Sub
End Class