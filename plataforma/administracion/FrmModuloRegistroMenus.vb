Public Class FrmModuloRegistroMenus

    Private Sub OperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem.Click
        frmSalidaProducto.MdiParent = Me
        frmSalidaProducto.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        frmRegistroPlatos.MdiParent = Me
        frmRegistroPlatos.Show()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        frmRegistroPlatos.MdiParent = Me
        frmRegistroPlatos.Show()
    End Sub

    Private Sub RegistroDeResetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeResetasToolStripMenuItem.Click
        frmResta.MdiParent = Me
        frmResta.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        frmAdministracion.Show()

    End Sub

    Private Sub ControlDePersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDePersonalToolStripMenuItem.Click
        frmreportePedido.MdiParent = Me
        frmreportePedido.Show()
    End Sub
End Class