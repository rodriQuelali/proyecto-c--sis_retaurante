Public Class Form1

    
    
   

    Private Sub MnuCopia_Click(sender As Object, e As EventArgs) Handles MnuCopia.Click
        frmKardex.MdiParent = Me
        frmKardex.Show()
    End Sub

    
    
    Private Sub RegistroDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeProductosToolStripMenuItem.Click
        frmProducto.MdiParent = Me
        frmProducto.Show()
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        frmCompraProducto.MdiParent = Me
        frmCompraProducto.Show()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        frmProveedor.MdiParent = Me
        frmProveedor.Show()

    End Sub

    Private Sub MnuConProductos_Click(sender As Object, e As EventArgs) Handles MnuConProductos.Click
        frmRegistroPlatos.MdiParent = Me
        frmRegistroPlatos.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegistroDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasToolStripMenuItem.Click
        frmSalidaProducto.MdiParent = Me
        frmSalidaProducto.Show()
    End Sub

    Private Sub RegistroDeGaseosaParVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeGaseosaParVentaToolStripMenuItem.Click
        frmRegistroPlatos.MdiParent = Me
        frmRegistroPlatos.Show()
    End Sub

    Private Sub RegistroDePèrsonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDePèrsonalToolStripMenuItem.Click
        frmRegistroP.MdiParent = Me
        frmRegistroP.Show()
    End Sub

    Private Sub OperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem.Click

    End Sub
End Class
