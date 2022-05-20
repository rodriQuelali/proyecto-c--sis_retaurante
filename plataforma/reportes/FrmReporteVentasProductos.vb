Public Class FrmReporteVentasProductos

    Private Sub FrmReporteVentasProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbrestauranteDataSet1.venta_producto' Puede moverla o quitarla según sea necesario.
        Me.venta_productoTableAdapter.Fill(Me.dbrestauranteDataSet1.venta_producto, frmVentaProductos.DateTimePicker1.Value, frmVentaProductos.DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class