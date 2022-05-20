Public Class frmProductoMozo


    Private Sub frmProductoMozo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmMozoVentaProducto.Show()
    End Sub



    Private Sub cargar_combo()

        Dim aux As New funRegistroPersonal
        aux.cargar_combo()

    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class