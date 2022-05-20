
Public Class frmProducto
    Private dt As New DataTable
   
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox2.Visible = False
        ocultar()
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

            dv.RowFilter = Cbbusqueda.Text & " like '" & txtbusqueda.Text & "%'"

            If dv.Count <> 0 Then
                DataGridView1.DataSource = dv
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub limpiar()
        txtidproducto.Clear()
        txtnombrep.Clear()
        txtdescripcion.Clear()
        'txttipoP.Clear()
        txtpeso.Clear()
        txtprecioU.Clear()

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtnombrep.Text <> "" And txtdescripcion.Text <> "" And txttipoP.Text <> "" And txtpeso.Text <> "" And txtprecioU.Text <> "" Then
            Try
                Dim dts As New ClvProducto
                Dim func As New clasProdructo

                dts.gidProducto = txtidproducto.Text
                dts.gnombre_p = txtnombrep.Text
                dts.gdescripcion = txtdescripcion.Text
                dts.gtipo_p = txttipoP.Text
                dts.gpeso = txtpeso.Text
                dts.gprecio_u = txtprecioU.Text

                If func.insertar_producto(dts) Then
                    MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmKardex.insertar_kardex2()
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Sub ocultar()
        'txtidproducto.Enabled = True
        txtdescripcion.Enabled = False
        txtnombrep.Enabled = False
        txtpeso.Enabled = False
        txtprecioU.Enabled = False
        txttipoP.Enabled = False
    End Sub
    Sub mostrar_texto()
        'txtidproducto.Enabled = True
        txtdescripcion.Enabled = True
        txtnombrep.Enabled = True
        txtpeso.Enabled = True
        txtprecioU.Enabled = True
        txttipoP.Enabled = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim a As New clasProdructo
        a.GENERAR_CODIGO()


        PictureBox2.Visible = True
        PictureBox4.Visible = False
        'txtidproducto.Enabled = True
        txtdescripcion.Enabled = True
        txtnombrep.Enabled = True
        txtpeso.Enabled = True
        txtprecioU.Enabled = True
        txttipoP.Enabled = True
        txtnombrep.Focus()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        mostrar_texto()
        PictureBox2.Visible = False
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        txtidproducto.Text = DataGridView1.SelectedCells.Item(0).Value
        txtnombrep.Text = DataGridView1.SelectedCells.Item(1).Value
        txtdescripcion.Text = DataGridView1.SelectedCells.Item(2).Value
        txttipoP.Text = DataGridView1.SelectedCells.Item(3).Value
        txtpeso.Text = DataGridView1.SelectedCells.Item(4).Value
        txtprecioU.Text = DataGridView1.SelectedCells.Item(5).Value
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("realmente desea editar los daros de los producttos", "modificar productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtnombrep.Text <> "" And txtdescripcion.Text <> "" And txttipoP.Text <> "" And txtpeso.Text <> "" And txtprecioU.Text <> "" Then

                Try

                    Dim dts As New ClvProducto
                    Dim func As New clasProdructo

                    dts.gidProducto = txtidproducto.Text
                    dts.gnombre_p = txtnombrep.Text
                    dts.gdescripcion = txtdescripcion.Text
                    dts.gtipo_p = txttipoP.Text
                    dts.gpeso = txtpeso.Text
                    dts.gprecio_u = txtprecioU.Text

                    If func.editar(dts) Then
                        MessageBox.Show("productos medificados correcctamente", "modificado producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'frmKardex.editar_kardex2()
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("productos NO se medifico intenete de nuevo", "mall..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("falta ingresar algunos datos", "modificado producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

      
        If MessageBox.Show("seguro desea borrar", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim dts As New ClvProducto
            Dim func As New clasProdructo

            dts.gidProducto = txtidproducto.Text
            
            If func.eliminar_producto(dts) Then

                MessageBox.Show("registro eliminado con exito..", "aviso")
                frmKardex.elminar_kardex2()
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
        limpiar()
        ocultar()
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        buscar()
    End Sub
   
    Private Sub txtidproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidproducto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnombrep.Focus()
        End If
    End Sub

    Private Sub txtnombrep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombrep.KeyPress

       


        If Asc(e.KeyChar) = 13 Then
            txtdescripcion.Focus()
        End If
    End Sub

    Private Sub txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            txttipoP.Focus()
        End If
    End Sub

    


    Private Sub txtpeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso.KeyPress
        'numeros
       

        If Asc(e.KeyChar) = 13 Then
            txtprecioU.Focus()
        End If
    End Sub

    Private Sub txttipoP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipoP.KeyPress
        'numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            txtpeso.Focus()
        End If
    End Sub

    Private Sub txtprecioU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioU.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
End Class
