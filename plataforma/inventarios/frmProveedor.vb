Public Class frmProveedor
    Private dt As New DataTable
    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        ocultar()
        pixEditar.Visible = False
        Pixeliminar.Visible = False
        PictureBox2.Visible = False
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
    Sub limpiar()

        txtnit.Clear()
        txtnombrepro.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()


    End Sub
    Sub mostrar_texto()
        txtnit.Enabled = True
        txtnombrepro.Enabled = True
        txtdireccion.Enabled = True
        txttelefono.Enabled = True
    End Sub


    Sub ocultar()
        txtnit.Enabled = False
        txtnombrepro.Enabled = False
        txtdireccion.Enabled = False
        txttelefono.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


        If Me.ValidateChildren = True And txtnit.Text <> "" And txtnombrepro.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" Then
            Try
                Dim dts As New objproveedor
                Dim func As New funProveedor

                dts.gnitProveedor = txtnit.Text
                dts.gnombreProve = txtnombrepro.Text
                dts.gdireccion = txtdireccion.Text
                dts.gtelefono = txttelefono.Text


                If func.insertar_proveedor(dts) Then
                    MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("falta ingresar algunos datos", "modificado producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        mostrar_texto()
        PictureBox2.Visible = False
        pixEditar.Visible = True
        Pixeliminar.Visible = True
        txtnit.Text = DataGridView1.SelectedCells.Item(0).Value
        txtnombrepro.Text = DataGridView1.SelectedCells.Item(1).Value
        txtdireccion.Text = DataGridView1.SelectedCells.Item(2).Value
        txttelefono.Text = DataGridView1.SelectedCells.Item(3).Value
       
    End Sub

    Private Sub pixEditar_Click(sender As Object, e As EventArgs) Handles pixEditar.Click

        Dim resultado As DialogResult
        resultado = MessageBox.Show("realmente desea editar los daros de los proveedor", "modificar proveedor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnit.Text <> "" And txtnombrepro.Text <> "" Then

                Try

                    Dim dts As New objproveedor
                    Dim func As New funProveedor

                    dts.gnitProveedor = txtnit.Text
                    dts.gnombreProve = txtnombrepro.Text
                    dts.gdireccion = txtdireccion.Text
                    dts.gtelefono = txttelefono.Text

                    If func.editar_proveedor(dts) Then
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

    Private Sub PixNuevo_Click(sender As Object, e As EventArgs) Handles PixNuevo.Click
        PictureBox2.Visible = True
        pixEditar.Visible = False
        Pixeliminar.Visible = False
        limpiar()
        mostrar_texto()
    End Sub

    Private Sub PixCancelar_Click(sender As Object, e As EventArgs) Handles PixCancelar.Click
        limpiar()
        ocultar()
        pixEditar.Visible = False
        Pixeliminar.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Pixeliminar_Click(sender As Object, e As EventArgs) Handles Pixeliminar.Click
        If MessageBox.Show("seguro desea borrar", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim dts As New objproveedor
            Dim func As New funProveedor

            dts.gnitProveedor = txtnit.Text

            If func.eliminar_proveedor(dts) Then

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

    Private Sub txtnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnit.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            txtnombrepro.Focus()
        End If
    End Sub

    Private Sub txtnombrepro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombrepro.KeyPress
        'letras solo letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If


        If Asc(e.KeyChar) = 13 Then
            txtdireccion.Focus()
        End If

    End Sub

    Private Sub txtdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdireccion.KeyPress
        'letras solo letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If


        If Asc(e.KeyChar) = 13 Then
            txttelefono.Focus()
        End If
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
End Class