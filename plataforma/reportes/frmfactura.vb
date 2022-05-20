Public Class frmfactura

    Private Sub frmfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'a = InputBox("nro")
        'TODO: esta línea de código carga datos en la tabla 'dbrestauranteDataSet1.venta_factura_uno' Puede moverla o quitarla según sea necesario.
        Me.venta_factura_unoTableAdapter.Fill(Me.dbrestauranteDataSet1.venta_factura_uno, frmPedidos.txtnro_servicio.Text)
        'TODO: esta línea de código carga datos en la tabla 'dbrestauranteDataSet1.venta_factura_dos' Puede moverla o quitarla según sea necesario.
        Me.venta_factura_dosTableAdapter.Fill(Me.dbrestauranteDataSet1.venta_factura_dos, frmPedidos.txtnro_servicio.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class