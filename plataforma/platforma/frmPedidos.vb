Public Class frmPedidos

    Private dt As New DataTable
    Dim categoria As String
    Public aux As Integer = 0

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frmCantidad.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As Integer
        categoria = "pollo"
        mostrar()
        'DataGridView2.RowTemplate.Height = 44
        'DataGridView2.RowHeadersWidth.ToString("nombre_plato")
        'DataGridView2.Columns.Item("nombre_plato").Visible = False
        'DataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        'DataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders = 45)

        'DataGridView2.Columns(0).Width = 100
        'DataGridView2.Columns("nombre_plato").Visible = True



        'a = DataGridView2.CurrentCellAddres.X



    End Sub
    Private Sub mostrar()
        Try
            Dim func As New funPedido
            dt = func.mostraPedido(categoria)


            If dt.Rows.Count <> 0 Then
                DataGridView2.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbrestauranteDataSet.plato_gaserosa' Puede moverla o quitarla según sea necesario.
        'Me.Plato_gaserosaTableAdapter.Fill(Me.DbrestauranteDataSet.plato_gaserosa)


        'If txtnro_servicio.Text = "" Then
        '    aux = 1
        '    MsgBox(aux)
        '    'se inserta todo de nuevo
        'Else
        '    aux = 0
        '    MsgBox(aux)
        '    'se actualiza todo
        'End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        categoria = "carnes"
        'DataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        mostrar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        categoria = "parrilladas"
        'DataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        mostrar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        categoria = "gaseosas"
        'DataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        mostrar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        categoria = "criollos"
        'DataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        mostrar()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        categoria = "almuerzos"
        'DataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        mostrar()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        categoria = "guarniciones"
        'DataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        mostrar()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        categoria = "cervesas"
        'DataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        mostrar()
    End Sub

    
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        FrmDatosPlato.txtnombreplato.Text = DataGridView2.SelectedCells.Item(0).Value
        FrmDatosPlato.txtsubtotal.Text = DataGridView2.SelectedCells.Item(1).Value * txtcantidad.Text
        FrmDatosPlato.cod_producto = DataGridView2.SelectedCells.Item(2).Value
        FrmDatosPlato.Show()
    End Sub

    Sub pedido()

        If aux = 1 Then

        Else

        End If

    End Sub

    Public Sub mostrar_pedido()
        Try
            Dim func As New funPlatoPedido
            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If txttotalcomsumo.Text <> 0 Then
            frmCobrarPedido.Show()
            frmCobrarPedido.txttotal.Text = txttotalcomsumo.Text

        Else
            MessageBox.Show("deve realizar un pedido", "alerta..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnelinimarPlato.Enabled = True
    End Sub

    

    Private Sub eliminar_plato()
        If MessageBox.Show("seguro desea borrar", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            txttotalcomsumo.Text = Convert.ToInt32(txttotalcomsumo.Text) - Convert.ToInt32(DataGridView1.SelectedCells.Item(3).Value)



            Dim dts As New obgPedido_plato
            Dim func As New funPlatoPedido

            dts.gidpedido_plato = DataGridView1.SelectedCells.Item(0).Value

            If func.eliminar_plato(dts) Then

                MessageBox.Show("registro eliminado con exito..", "aviso")

                mostrar()
            Else
                MessageBox.Show("problemas en la elminacion..", "aviso")
            End If
        Else
            MessageBox.Show("se cancelo la eliminacion..", "aviso")
        End If
        FrmDatosPlato.actualizar_total()
        FrmDatosPlato.mostrar_plato_peido()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub btnelinimarPlato_Click(sender As Object, e As EventArgs) Handles btnelinimarPlato.Click
        eliminar_plato()
    End Sub
End Class