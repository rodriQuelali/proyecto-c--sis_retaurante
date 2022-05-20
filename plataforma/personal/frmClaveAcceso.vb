Public Class frmClaveAcceso
    Private dt As New DataTable

    Private Sub Butguardar_Click(sender As Object, e As EventArgs) Handles Butguardar.Click
        If Me.ValidateChildren = True And txtnombreClave.Text <> "" And txtnroAcceso.Text <> "" And txtcargoClave.Text <> "" And txtpaternoClave.Text <> "" Then
            Try
                Dim dts As New obgRegistroPersonal
                Dim func As New funRegistroPersonal


                dts.gnroAcceso = txtnroAcceso.Text
                dts.gci = txtciClave.Text
                dts.gcargo = txtcargoClave.Text
                dts.gnombre = txtnombreClave.Text
                dts.gapPaterno = txtpaternoClave.Text

                If func.insertar_personal_acceo(dts) Then
                    MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrar_acceso()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Me.Close()
        frmRegistroP.Close()
    End Sub
    Private Sub mostrar_acceso()
        Try
            Dim func As New funRegistroPersonal
            dt = func.mostra_acceso


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub limpiar()
        txtnroAcceso.Clear()
        txtciClave.Clear()
        txtcargoClave.Clear()
        txtnombreClave.Clear()
        txtpaternoClave.Clear()
    End Sub

    Private Sub frmClaveAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_acceso()
        Dim generador As New funRegistroPersonal
        generador.generar_codigo()
    End Sub

    Private Sub Butcancelar_Click(sender As Object, e As EventArgs) Handles Butcancelar.Click
        txtnroAcceso.Clear()
    End Sub

End Class