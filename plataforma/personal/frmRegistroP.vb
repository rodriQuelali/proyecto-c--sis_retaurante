Public Class frmRegistroP
    Private dt As New DataTable
    Private Sub frmRegistroP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        ocultar()
        Buteditar.Visible = False
        Buteliminar.Visible = False
        Butguardar.Visible = False
        txtnombre.CharacterCasing = CharacterCasing.Upper
        txtpaterno.CharacterCasing = CharacterCasing.Upper
        txtmaterno.CharacterCasing = CharacterCasing.Upper
        txtdireccion.CharacterCasing = CharacterCasing.Upper
        txtestadocivil.CharacterCasing = CharacterCasing.Upper
        txtcargo.CharacterCasing = CharacterCasing.Upper
       
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New funRegistroPersonal
            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Butguardar_Click(sender As Object, e As EventArgs) Handles Butguardar.Click
        If Me.ValidateChildren = True And txtci.Text <> "" And txtnombre.Text <> "" And txtpaterno.Text <> "" And txtmaterno.Text <> "" And txtestadocivil.Text <> "" And txtedad.Text <> "" And txtdireccion.Text <> "" And txtcargo.Text <> "" And txttelefono.Text <> "" Then
            Try
                Dim dts As New obgRegistroPersonal
                Dim func As New funRegistroPersonal

                dts.gci = txtci.Text
                dts.gnombre = txtnombre.Text
                dts.gapPaterno = txtpaterno.Text
                dts.gapMaterno = txtmaterno.Text
                dts.gdireccion = txtdireccion.Text
                dts.gEstadoCivil = txtestadocivil.Text
                dts.gedad = txtedad.Text
                dts.gcargo = txtcargo.Text
                dts.gtelefono = txttelefono.Text

                If func.insertar_personal(dts) Then
                    MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FrmHorarioPersonal.insertar_h()

                    frmClaveAcceso.txtciClave.Text = txtci.Text
                    frmClaveAcceso.txtcargoClave.Text = txtcargo.Text
                    frmClaveAcceso.txtnombreClave.Text = txtnombre.Text
                    frmClaveAcceso.txtpaternoClave.Text = txtpaterno.Text
                    frmClaveAcceso.Show()

                    mostrar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("falta ingresar algunos datos", "modificado personal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        

        Buteditar.Visible = False
        Buteliminar.Visible = False
        Butguardar.Visible = False
        limpiar()

    End Sub
    Sub limpiar()
        txtci.Clear()
        txtnombre.Clear()
        txtpaterno.Clear()
        txtmaterno.Clear()
        txtdireccion.Clear()
        txtestadocivil.Clear()
        txtedad.Clear()
        txtcargo.Clear()
        txttelefono.Clear()


    End Sub
    Sub ocultar()
        txtci.Enabled = False
        txtnombre.Enabled = False
        txtpaterno.Enabled = False
        txtmaterno.Enabled = False
        txtdireccion.Enabled = False
        txtestadocivil.Enabled = False
        txtedad.Enabled = False
        txtcargo.Enabled = False
        txttelefono.Enabled = False
    End Sub
    Sub mostrarText()
        txtci.Enabled = True
        txtnombre.Enabled = True
        txtpaterno.Enabled = True
        txtmaterno.Enabled = True
        txtdireccion.Enabled = True
        txtestadocivil.Enabled = True
        txtedad.Enabled = True
        txtcargo.Enabled = True
        txttelefono.Enabled = True
    End Sub
    Private Sub Buteditar_Click(sender As Object, e As EventArgs) Handles Buteditar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("realmente desea editar los daros de los proveedor", "modificar proveedor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then

            If Me.ValidateChildren = True And txtci.Text <> "" And txtnombre.Text <> "" Then

                Try

                    Dim dts As New obgRegistroPersonal
                    Dim func As New funRegistroPersonal
                    dts.gci = txtci.Text
                    dts.gnombre = txtnombre.Text
                    dts.gapPaterno = txtpaterno.Text
                    dts.gapMaterno = txtmaterno.Text
                    dts.gdireccion = txtdireccion.Text
                    dts.gEstadoCivil = txtestadocivil.Text
                    dts.gedad = txtedad.Text
                    dts.gcargo = txtcargo.Text
                    dts.gtelefono = txttelefono.Text

                    If func.editar_personal(dts) Then
                        MessageBox.Show("proveedor medificados personal", "modificado personal", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("personal NO se medifico intenete de nuevo", "mall..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("falta ingresar algunos datos", "modificado personal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
        Buteditar.Visible = False
        Buteliminar.Visible = False
        Butguardar.Visible = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Buteditar.Visible = True
        Buteliminar.Visible = True
        Butguardar.Visible = False
        mostrarText()
        txtci.Text = DataGridView1.SelectedCells.Item(0).Value
        txtnombre.Text = DataGridView1.SelectedCells.Item(1).Value
        txtpaterno.Text = DataGridView1.SelectedCells.Item(2).Value
        txtmaterno.Text = DataGridView1.SelectedCells.Item(3).Value
        txtdireccion.Text = DataGridView1.SelectedCells.Item(4).Value
        txtestadocivil.Text = DataGridView1.SelectedCells.Item(5).Value
        txtedad.Text = DataGridView1.SelectedCells.Item(6).Value
        txtcargo.Text = DataGridView1.SelectedCells.Item(7).Value
        txttelefono.Text = DataGridView1.SelectedCells.Item(8).Value

    End Sub

    Private Sub Buteliminar_Click(sender As Object, e As EventArgs) Handles Buteliminar.Click
        If MessageBox.Show("seguro desea borrar", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim dts As New obgRegistroPersonal
            Dim func As New funRegistroPersonal

            dts.gci = txtci.Text

            If func.eliminar_personal(dts) Then

                MessageBox.Show("registro eliminado con exito..", "aviso")
                limpiar()
                mostrar()
            Else
                MessageBox.Show("problemas en la elminacion..", "aviso")
            End If
        Else
            MessageBox.Show("se cancelo la eliminacion..", "aviso")
        End If
        Buteditar.Visible = False
        Buteliminar.Visible = False
        Butguardar.Visible = False
    End Sub

    Private Sub Butcancelar_Click(sender As Object, e As EventArgs) Handles Butcancelar.Click
        ocultar()
        Buteditar.Visible = False
        Butguardar.Visible = False
        Buteliminar.Visible = False
    End Sub

    Private Sub Butnuevo_Click(sender As Object, e As EventArgs) Handles Butnuevo.Click
        limpiar()
        mostrarText()
        Butguardar.Visible = True
        Buteditar.Visible = False
        Buteliminar.Visible = False
    End Sub

    Private Sub txtci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtci.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtpaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpaterno.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtmaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmaterno.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtestadocivil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtestadocivil.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcargo.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
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
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = TextBox1.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                DataGridView1.DataSource = dv
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub
End Class