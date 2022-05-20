Public Class frmCobrarPedido
    Private dt As New DataTable
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub frmCobrarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtnit.Focus()
        txtnombre_cliente.Enabled = False
        btnregistarclie.Enabled = False
        txtnombre_cliente.CharacterCasing = CharacterCasing.Upper




    End Sub

    Private Sub txtnombre_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre_cliente.KeyPress
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
            txtnit.Focus()
        End If

    End Sub

    Private Sub txtnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnit.KeyPress
        'numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            txtefectivo.Focus()
            busqueda_cliente()
        End If

    End Sub

    Private Sub txtefectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtefectivo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            txtvuelto.Text = Convert.ToInt32(txtefectivo.Text) - Convert.ToInt32(txttotal.Text)
        End If
    End Sub

    
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub insertar_factura()

        Try
            Dim dts As New obgFactura
            Dim func As New funFacturas

            dts.gfecha = frmPedidos.txtfechapedido.Text
            dts.gnit_cliente = txtnit.Text
            dts.gnombre_cliente = txtnombre_cliente.Text
            dts.gid_personal = frmPedidos.txtidpersonal.Text
            dts.gnombre_mozo = frmPedidos.txtnpmbreP.Text
            dts.gapellido_mozo = frmPedidos.txtapellido.Text
            dts.gid_pedido_factura = frmPedidos.txtnro_servicio.Text
            dts.gtotal = txttotal.Text
            dts.gtipo_efectivo = txtefectivo.Text
            dts.gvuelto = txtvuelto.Text

            If func.insertar_factura(dts) Then
                MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmfactura.Show()
                Me.Close()
                frmPedidos.Close()
                frmSelecioMesas.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub insertar_cliente()
        Try
            Dim dts As New obgClientes
            Dim func As New funFacturas


            dts.gnit = txtnit.Text
            dts.gapellido = txtnombre_cliente.Text
            dts.gtelefono = 0
            
            If func.insertar_cliente(dts) Then
                MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
               

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub busqueda_cliente()
        Try

            Dim dts As New obgClientes
            Dim func As New funFacturas



            dts.gnit = txtnit.Text
            dt = func.busqueda_clie(dts)

            If dt.Rows.Count > 0 Then
                'frmSelecioMesas.txtnombreP.Text = dt


            Else
                If MessageBox.Show("dese agregar el nuevo usuario", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    txtnombre_cliente.Enabled = True
                    btnregistarclie.Enabled = True
                    txtnombre_cliente.Focus()
                Else
                    MessageBox.Show("se cancelo..", "aviso")

                End If
            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        insertar_factura()
    End Sub

    Private Sub btnregistarclie_Click(sender As Object, e As EventArgs) Handles btnregistarclie.Click
        insertar_cliente()
    End Sub
End Class