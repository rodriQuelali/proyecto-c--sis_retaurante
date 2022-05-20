﻿Public Class FrmBusProducto
    Private dt As New DataTable
    Public auxbusquedaPro As Integer

    Private Sub FrmBusProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New clasProdructo
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre_producto like '" & TextBox10.Text & "%'"

            If dv.Count <> 0 Then
                DataGridView1.DataSource = dv
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        buscar()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If auxbusquedaPro = 0 Then
            frmCompraProducto.txtidproducto.Text = DataGridView1.SelectedCells.Item(0).Value
            frmCompraProducto.txtnombreproducto.Text = DataGridView1.SelectedCells.Item(1).Value
            frmCompraProducto.txtdescripcion.Text = DataGridView1.SelectedCells.Item(2).Value

        ElseIf auxbusquedaPro = 1 Then
            frmSalidaProducto.txtidproducto.Text = DataGridView1.SelectedCells.Item(0).Value
            frmSalidaProducto.txtnomnrePro.Text = DataGridView1.SelectedCells.Item(1).Value
        Else

            frmResta.txtidproducto.Text = DataGridView1.SelectedCells.Item(0).Value
            frmResta.txtnombreProducto.Text = DataGridView1.SelectedCells.Item(1).Value
        End If

        

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmProducto.Show()
    End Sub
End Class