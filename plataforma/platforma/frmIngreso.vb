Public Class frmIngreso
    Dim total As String
    Private dt As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uno As Integer
        uno = 1
        total = total & uno

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        frmaperturaCaja.Show()
        'frmcontrol_personal.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click


        frmAccesoInventario.Show()


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim acceso As Integer


        If total <> "" Then
            acceso = total
            Try

                Dim dts As New obgRegistroPersonal
                Dim func As New funAccesoSistema



                dts.gnroAcceso = acceso
                dt = func.acceso_sistema(dts)

                If dt.Rows.Count > 0 Then
                    'frmSelecioMesas.txtnombreP.Text = dt
                    frmSelecioMesas.Show()

                Else
                    MessageBox.Show("usuario incorrecto", "alerta..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("increse ....", "alerta..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        total = ""


    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uno As Integer
        uno = 2
        total = total & uno

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim uno As Integer
        uno = 3
        total = total & uno
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim uno As Integer
        uno = 4
        total = total & uno
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim uno As Integer
        uno = 5
        total = total & uno
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim uno As Integer
        uno = 6
        total = total & uno
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim uno As Integer
        uno = 7
        total = total & uno
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim uno As Integer
        uno = 8
        total = total & uno
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim uno As Integer
        uno = 9
        total = total & uno
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If total = "" Then
            total = ""
        Else
            Dim uno As Integer
            uno = 0
            total = total & uno
        End If
       
    End Sub

    Private Sub frmIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        total = ""
    End Sub


    
End Class