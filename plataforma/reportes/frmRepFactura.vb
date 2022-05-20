Public Class frmRepFactura

    Private Sub frmRepFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbrestauranteDataSet1.mostrar_factura_rep' Puede moverla o quitarla según sea necesario.
        Me.mostrar_factura_repTableAdapter.Fill(Me.dbrestauranteDataSet1.mostrar_factura_rep, frmVentasFactura.DateTimePicker1.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class