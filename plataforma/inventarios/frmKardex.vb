Imports System.Data.SqlClient
Imports System.IO
Public Class frmKardex

    Private dt As New DataTable


    Private Sub frmKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub mostrar()
        Try
            Dim func As New FunKardex
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

            dv.RowFilter = cbmbusqueda.Text & " like '" & txtbusqueda.Text & "%'"

            If dv.Count <> 0 Then
                DataGridView1.DataSource = dv
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        buscar()

    End Sub
    Public Sub insertar_kardex2()
        Try
            Dim dts As New obgKardex
            Dim func As New FunKardex
            dts.gnro_kardex = 2
            dts.gidProducto = frmProducto.txtidproducto.Text
            dts.gnombre_p = frmProducto.txtnombrep.Text
            dts.gtipo_almacen = frmProducto.txttipoP.Text
            dts.gsaldo_inicial = 0
            dts.gincreso = 0
            dts.gtotal = 0
            dts.gsalida = 0
            dts.gsaldo_final = 0

            If func.insertar_kardex(dts) Then
                MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub editar_kardex2()

        'resultado = MessageBox.Show("realmente desea editar los daros de los producttos", "modificar productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        Try

            Dim dts As New obgKardex
            Dim func As New FunKardex

            dts.gidProducto = frmProducto.txtidproducto.Text
            dts.gnombre_p = frmProducto.txtnombrep.Text
            dts.gtipo_almacen = frmProducto.txttipoP.Text


            If func.editar_kardex(dts) Then
                MessageBox.Show("productos medificados correcctamente", "modificado producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()

            Else
                MessageBox.Show("productos NO se medifico intenete de nuevo", "mall..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mostrar()

            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try




    End Sub

    Public Sub elminar_kardex2()
        

        If MessageBox.Show("seguro desea borrar de kardex", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim dts As New obgKardex
            Dim func As New FunKardex

            dts.gidProducto = frmProducto.txtidproducto.Text

            If func.eliminar_kardex(dts) Then

                MessageBox.Show("registro eliminado con exito..", "aviso")
                mostrar()
            Else
                MessageBox.Show("problemas en la elminacion..", "aviso")
            End If
        Else
            MessageBox.Show("se cancelo la eliminacion..", "aviso")
        End If
      
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class