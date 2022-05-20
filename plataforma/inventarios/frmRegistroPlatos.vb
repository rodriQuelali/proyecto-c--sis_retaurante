Public Class frmRegistroPlatos
    Private dt As New DataTable
    Private Sub frmRegistroPlatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        ocultar()
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New funRegistroPlato
            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.ValidateChildren = True And txtidplato.Text <> "" And txtnombrePla.Text <> "" And txtpresioU.Text <> "" And txtcantidadStock.Text <> "" And txtcategoria.Text <> "" Then
            Try
                Dim dts As New obgRegistroPlato
                Dim func As New funRegistroPlato

                dts.gidplato = txtidplato.Text
                dts.gnombrePlato = txtnombrePla.Text
                dts.gpresioU = txtpresioU.Text
                dts.gcantidaStock = txtcantidadStock.Text
                dts.gcategoria = txtcategoria.Text


                If func.insertar_plato(dts) Then
                    MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MessageBox.Show("falta ingresar algunos datos", "modificado plato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Dim resultado As DialogResult
        resultado = MessageBox.Show("realmente desea editar los daros de los proveedor", "modificar proveedor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidplato.Text <> "" And txtnombrePla.Text <> "" And txtpresioU.Text <> "" And txtcantidadStock.Text <> "" And txtcategoria.Text <> "" Then

                Try

                    Dim dts As New obgRegistroPlato
                    Dim func As New funRegistroPlato

                    dts.gidplato = txtidplato.Text
                    dts.gnombrePlato = txtnombrePla.Text
                    dts.gpresioU = txtpresioU.Text
                    dts.gcantidaStock = txtcantidadStock.Text
                    dts.gcategoria = txtcategoria.Text


                    If func.editar_plato(dts) Then
                        MessageBox.Show("proveedor medificados correcctamente", "modificado proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("proveedor NO se medifico intenete de nuevo", "mall..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("falta ingresar algunos datos", "modificado proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If

    End Sub
    Sub limpiar()
        txtidplato.Clear()
        txtnombrePla.Clear()
        txtpresioU.Clear()


    End Sub

    Sub ocultar()
        txtidplato.Enabled = False
        txtnombrePla.Enabled = False
        txtpresioU.Enabled = False
        txtcantidadStock.Enabled = False
        txtcategoria.Enabled = False
    End Sub
    Sub mostrartexto()
        txtidplato.Enabled = False
        txtnombrePla.Enabled = True
        txtpresioU.Enabled = True
        txtcantidadStock.Enabled = True
        txtcategoria.Enabled = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox2.Visible = False
        mostrartexto()
        txtidplato.Text = DataGridView1.SelectedCells.Item(0).Value
        txtnombrePla.Text = DataGridView1.SelectedCells.Item(1).Value
        txtpresioU.Text = DataGridView1.SelectedCells.Item(2).Value
        txtcantidadStock.Text = DataGridView1.SelectedCells.Item(3).Value
        txtcategoria.Text = DataGridView1.SelectedCells.Item(4).Value

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        If MessageBox.Show("seguro desea borrar", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim dts As New obgRegistroPlato
            Dim func As New funRegistroPlato

            dts.gidplato = txtidplato.Text

            If func.eliminar_plato(dts) Then

                MessageBox.Show("registro eliminado con exito..", "aviso")
                limpiar()
                mostrar()
            Else
                MessageBox.Show("problemas en la elminacion..", "aviso")
            End If
        Else
            MessageBox.Show("se cancelo la eliminacion..", "aviso")
        End If

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ocultar()
        limpiar()
        PictureBox4.Visible = False
        PictureBox3.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub PixNuevo_Click(sender As Object, e As EventArgs) Handles PixNuevo.Click
        
        PictureBox2.Visible = True
        PictureBox4.Visible = False
        PictureBox3.Visible = False
        mostrartexto()
        limpiar()
        Dim genera_cod As New funRegistroPlato
        genera_cod.generar_codigo()
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = ComboBox1.Text & " like '" & TextBox1.Text & "%'"

            If dv.Count <> 0 Then
                DataGridView1.DataSource = dv
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        buscar()
    End Sub

    Private Sub txtnombrePla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombrePla.KeyPress
        
    End Sub

    Private Sub txtpresioU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpresioU.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
End Class