Public Class frmSalidaProducto
    Private dt As New DataTable
    Public auxSalida As Integer
    Private Sub frmSalidaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        ocultar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New funSalidaProd
            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    
    Private Sub Pixguardar_Click(sender As Object, e As EventArgs) Handles Pixguardar.Click
        If Me.ValidateChildren = True And txtidsalida.Text <> "" And txtidproducto.Text <> "" And txtnomnrePro.Text <> "" And txtcantidad.Text <> "" Then
            Try
                Dim dts As New obgSalidaPro
                Dim func As New funSalidaProd

                dts.gidsalida = txtidsalida.Text
                dts.gidProducto = txtidproducto.Text
                dts.gfechaSalida = txtdate.Text
                dts.gcantidadSalida = txtcantidad.Text
                dts.gnombrePro = txtnomnrePro.Text


                If func.insertar_salida(dts) Then
                    MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Sub limpiar()
        txtidsalida.Clear()
        txtidproducto.Clear()
        txtcantidad.Clear()
        txtnomnrePro.Clear()

    End Sub
    Sub mostrartexto()
        txtidproducto.Enabled = False
        txtidsalida.Enabled = False
        txtcantidad.Enabled = True
        txtnomnrePro.Enabled = False
    End Sub

    Sub ocultar()

        txtidproducto.Enabled = False
        txtidsalida.Enabled = False
        txtcantidad.Enabled = False
        txtnomnrePro.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        auxSalida = 1
        FrmBusProducto.auxbusquedaPro = auxSalida
        FrmBusProducto.Show()
    End Sub

    Private Sub PixNuevo_Click(sender As Object, e As EventArgs) Handles PixNuevo.Click
        Dim genera_cod As New funSalidaProd
        genera_cod.generar_codigo()
        mostrartexto()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        limpiar()
        ocultar()
    End Sub

  
    
    Private Sub txtnomnrePro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomnrePro.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
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
End Class