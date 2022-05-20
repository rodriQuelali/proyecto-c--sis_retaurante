Public Class FrmModuloAlmacen

    Private Sub OperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem.Click
        frmProducto.MdiParent = Me
        frmProducto.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        frmCompraProducto.MdiParent = Me
        frmCompraProducto.Show()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        frmKardex.MdiParent = Me
        frmKardex.Show()
    End Sub

    Private Sub ControlDePersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDePersonalToolStripMenuItem.Click
        frmProveedor.MdiParent = Me
        frmProveedor.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        frmAdministracion.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        frmcompraPro.MdiParent = Me
        frmcompraPro.Show()
    End Sub
End Class