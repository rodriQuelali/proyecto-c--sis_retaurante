Public Class FrmBusProveedor
    Private dt As New DataTable
    Private Sub FrmBusProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New funProveedor
            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        buscar()

    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre_proveedor like '" & TextBox10.Text & "%'"

            If dv.Count <> 0 Then
                DataGridView1.DataSource = dv
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        frmCompraProducto.txtnirproveedor.Text = DataGridView1.SelectedCells.Item(0).Value
        frmCompraProducto.txtnombreprovee.Text = DataGridView1.SelectedCells.Item(1).Value

        Me.Close()
    End Sub
End Class