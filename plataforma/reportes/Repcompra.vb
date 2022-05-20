Public Class Repcompra

    Private Sub Repcompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbrestauranteDataSet1.rep_compra' Puede moverla o quitarla según sea necesario.
        Me.rep_compraTableAdapter.Fill(Me.dbrestauranteDataSet1.rep_compra, frmcompraPro.DateTimePicker1.Value, frmcompraPro.DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class