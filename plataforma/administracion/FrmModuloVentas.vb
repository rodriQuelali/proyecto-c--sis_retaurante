Public Class FrmModuloVentas

    Private Sub OperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem.Click
        frmventaPorMozo.MdiParent = Me
        frmventaPorMozo.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        frmProductoMozo.MdiParent = Me
        frmProductoMozo.Show()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        frmVentaProductos.MdiParent = Me
        frmVentaProductos.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        frmAdministracion.Show()
    End Sub

    Private Sub FACTURASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACTURASToolStripMenuItem.Click
        frmVentasFactura.MdiParent = Me
        frmVentasFactura.Show()
    End Sub
End Class