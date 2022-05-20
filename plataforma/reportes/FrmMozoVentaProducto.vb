Public Class FrmMozoVentaProducto

    Private Sub FrmMozoVentaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbrestauranteDataSet1.venta_mozo_prod' Puede moverla o quitarla según sea necesario.
        Me.venta_mozo_prodTableAdapter.Fill(Me.dbrestauranteDataSet1.venta_mozo_prod, frmProductoMozo.txtnombre.Text, frmProductoMozo.txtapellido.Text, frmProductoMozo.DateTimePicker1.Value, frmProductoMozo.DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class