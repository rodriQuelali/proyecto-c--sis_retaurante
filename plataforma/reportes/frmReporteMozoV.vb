Public Class frmReporteMozoV

    Private Sub frmReporteMozoV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbrestauranteDataSet1.ventas_mozo' Puede moverla o quitarla según sea necesario.
        Me.ventas_mozoTableAdapter.Fill(Me.dbrestauranteDataSet1.ventas_mozo, frmventaPorMozo.DateTimePicker1.Value, frmventaPorMozo.DateTimePicker2.Value)
        'Me.ventas_mozoTableAdapter.Fill(Me.dbrestauranteDataSet1.ventas_mozos, frmventaPorMozo.DateTimePicker1.Value, frmventaPorMozo.DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class