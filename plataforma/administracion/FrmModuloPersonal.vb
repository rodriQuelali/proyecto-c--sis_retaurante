Public Class FrmModuloPersonal

    Private Sub OperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem.Click
        frmRegistroP.MdiParent = Me
        frmRegistroP.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        frmAdministracion.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        FrmHorarioPersonal.MdiParent = Me
        FrmHorarioPersonal.Show()
    End Sub
End Class