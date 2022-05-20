Public Class frmResta

    Private dt As New DataTable
    Public auxreseta As Integer

    Private Sub frmResta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        ocultar()
        pixeliminar.Visible = False
        pixeditar.Visible = False
        pixguardar.Visible = False
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New funReseta
            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                DataGridView2.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub pixguardar_Click(sender As Object, e As EventArgs) Handles pixguardar.Click
        If Me.ValidateChildren = True And txtidplato.Text <> "" And txtnombreRese.Text <> "" And txtmedida.Text <> "" And txtdescripcion.Text <> "" And txtcantidad.Text <> "" And txtidplato.Text <> "" And txtnombreplato.Text <> "" And txtidproducto.Text <> "" And txtnombreProducto.Text <> "" Then
            Try
                Dim dts As New obgReseta
                Dim func As New funReseta

                dts.gidReseta = txtidreseta.Text
                dts.gnombreReseta = txtnombreRese.Text
                dts.gmedida = txtmedida.Text
                dts.gdescripcion = txtdescripcion.Text
                dts.gcantidad = txtcantidad.Text
                dts.gidPlato = txtidplato.Text
                dts.gnombrePLato = txtnombreplato.Text
                dts.gidproducto = txtidproducto.Text
                dts.gnomnbreProducto = txtnombreProducto.Text


                If func.insertar_reseta(dts) Then
                    MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("falta ingresar algunos datos", "modificado reseta", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Sub limpiar()
        txtidreseta.Clear()
        txtnombreRese.Clear()

        txtdescripcion.Clear()
        txtcantidad.Clear()
        txtidplato.Clear()
        txtidproducto.Clear()
        txtnombreProducto.Clear()
        txtnombreplato.Clear()

    End Sub
    Sub mostrartext()
        txtidreseta.Enabled = False
        txtnombreRese.Enabled = True
        txtmedida.Enabled = True
        txtdescripcion.Enabled = True
        txtcantidad.Enabled = True
    End Sub
    Sub ocultar()
        txtidreseta.Enabled = False
        txtnombreRese.Enabled = False
        txtmedida.Enabled = False
        txtdescripcion.Enabled = False
        txtcantidad.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBusquedaPLato.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        auxreseta = 3
        FrmBusProducto.auxbusquedaPro = auxreseta
        FrmBusProducto.Show()
    End Sub

    Private Sub PixNuevo_Click(sender As Object, e As EventArgs) Handles PixNuevo.Click
        limpiar()
        mostrartext()
        pixguardar.Visible = True
        Dim genera_cod As New funReseta
        genera_cod.generar_codigo()
    End Sub

    Private Sub pixcancelar_Click(sender As Object, e As EventArgs) Handles pixcancelar.Click
        ocultar()
        pixguardar.Visible = False
    End Sub

    Private Sub txtnombreRese_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreRese.KeyPress


    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True

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
    End Sub
End Class