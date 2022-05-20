Public Class frmAdministracion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmModuloAlmacen.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmModuloPersonal.Show()
        Me.Close()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmModuloRegistroMenus.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmModuloVentas.Show()
        Me.Close()
    End Sub

    Private Sub frmAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class