Public Class FrmDatosPlato

    Public cod_producto As Integer
    Private dt As New DataTable
    Private Sub FrmDatosPlato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbrestauranteDataSet1.reseta' Puede moverla o quitarla según sea necesario.
        'Me.ResetaTableAdapter.Fill(Me.DbrestauranteDataSet1.reseta)
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New funDatosPLa
            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub



    Sub pedido()

        If frmPedidos.txtnro_servicio.Text = "" Then

            
            'insertamos el numero de servicio 
            Try
                Dim dts As New bogpedido
                Dim func As New funPedido


                dts.gtotal = frmPedidos.txttotalcomsumo.Text
                dts.gfecha_p = frmPedidos.txtfechapedido.Text
                dts.gmesa = frmPedidos.txtmesa.Text
                dts.gid_personal = frmPedidos.txtidpersonal.Text
                dts.gnombre_p = frmPedidos.txtnpmbreP.Text
                dts.gapellido_p = frmPedidos.txtapellido.Text


                If func.insertar_pedido(dts) Then
                    'MessageBox.Show("se registro correctamente de pedido", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'mostrar numero de pedido para insertar el plato de pedido

            mostra_numero_pedido()

            'insertamos el plato de pedido

            insertar_plato_pedido()


            'actualizamos la caja de total
            frmPedidos.txttotalcomsumo.Text = Convert.ToInt32(txtsubtotal.Text) + Convert.ToInt32(frmPedidos.txttotalcomsumo.Text)


            'actualizamos el registro de pedido todo total

            actualizar_total()

            'mostra los platos pedidos

            mostrar_plato_peido()

            Me.Close()

        Else


            insertar_plato_pedido()
            frmPedidos.txttotalcomsumo.Text = Convert.ToInt32(txtsubtotal.Text) + Convert.ToInt32(frmPedidos.txttotalcomsumo.Text)
            actualizar_total()
            mostrar_plato_peido()
            Me.Close()

        End If

    End Sub



    Public Sub mostrar_plato_peido()
        Try
            Dim func As New funPlatoPedido

            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                frmPedidos.DataGridView1.DataSource = dt
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub insertar_plato_pedido()
        Try
            


            Dim dts As New obgPedido_plato
            Dim func As New funPlatoPedido


            dts.gnro_pedido = frmPedidos.txtnro_servicio.Text
            dts.gid_plato = cod_producto
            dts.gnombre_plato = txtnombreplato.Text
            dts.gpresio_plato = frmPedidos.DataGridView2.SelectedCells.Item(1).Value
            dts.gcantidad_plato = frmPedidos.txtcantidad.Text
            dts.gtotal = txtsubtotal.Text
            dts.gfecha_pedido = frmPedidos.txtfechapedido.Text
            dts.gid_personal_pedido = frmPedidos.txtidpersonal.Text
            dts.gnombre_personal = frmPedidos.txtnpmbreP.Text
            dts.gapellido_personal = frmPedidos.txtapellido.Text


            If func.insertar_pedido_plato(dts) Then
                'MessageBox.Show("se registro correctamente de platos a consumo", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub actualizar_total()
        Try

            Dim dts As New bogpedido
            Dim func As New funPedido

            dts.gnro_pedido = frmPedidos.txtnro_servicio.Text
            dts.gtotal = frmPedidos.txttotalcomsumo.Text
            dts.gmesa = frmPedidos.txtmesa.Text

            If func.editar_pedido(dts) Then
                'MessageBox.Show("cantidad medificados correcctamente", "modificado cantidad", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("cantidad NOooo se medifico intenete de nuevo", "mall..", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pedido()
        frmPedidos.txtcantidad.Text = 1
    End Sub

    Private Sub mostra_numero_pedido()
        Try


            Dim func As New funPedido

            dt = func.mostar_numero

            If dt.Rows.Count > 0 Then

                ' MsgBox("la consulta se genero correctamente")

            Else
                MessageBox.Show("usuario incorrecto", "alerta..", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class