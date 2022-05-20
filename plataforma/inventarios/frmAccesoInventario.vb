Public Class frmAccesoInventario

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusuario.Text = "rodrigo q" Then
            If txtpassword.Text = "rodrigo92rock" Then
                frmAdministracion.Show()

                txtpassword.Clear()
                txtusuario.Clear()
                Me.Close()
            Else
                txtpassword.Clear()
                txtusuario.Clear()
            End If
        Else
            txtpassword.Clear()
            txtusuario.Clear()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtusuario.Focus()
        End If
    End Sub

    Private Sub frmAccesoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusuario.Focus()
    End Sub

    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtpassword.Focus()
        End If
    End Sub
End Class