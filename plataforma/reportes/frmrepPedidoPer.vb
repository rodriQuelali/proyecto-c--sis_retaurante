Public Class frmrepPedidoPer

    Private Sub frmrepPedidoPer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbrestauranteDataSet1.rep_pedido_personal' Puede moverla o quitarla según sea necesario.
        Me.rep_pedido_personalTableAdapter.Fill(Me.dbrestauranteDataSet1.rep_pedido_personal, frmreportePedido.DateTimePicker1.Value, frmreportePedido.DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class