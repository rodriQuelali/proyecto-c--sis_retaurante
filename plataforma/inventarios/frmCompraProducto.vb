Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Text
Public Class frmCompraProducto
    Private dt As New DataTable
    Public auxcompra As Integer
    Private Sub frmCompraProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        ocultar()
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New funCompraProducto
            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        auxcompra = 0
        FrmBusProducto.auxbusquedaPro = auxcompra
        FrmBusProducto.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmBusProveedor.Show()
    End Sub


    Private Sub PixGuardar_Click(sender As Object, e As EventArgs) Handles PixGuardar.Click


        If Me.ValidateChildren = True And txtidcompra.Text <> "" And txtidproducto.Text <> "" And txtnombreproducto.Text <> "" And txtdescripcion.Text <> "" Then
            Try
                Dim dts As New obgCompraProducto
                Dim func As New funCompraProducto

                dts.gidCompra = txtidcompra.Text
                dts.gidCompProducto = txtidproducto.Text
                dts.gnombreProduc = txtnombreproducto.Text
                dts.gdescripProducto = txtdescripcion.Text
                dts.gmarcaCompra = txtmarca.Text
                dts.gprecio_U = txtprecioUni.Text
                dts.gcantidad_Compra = txtcantidadCom.Text
                dts.gtotalCompra = txttotalCom.Text
                dts.gfechaCom = txtdate.Text
                dts.gnit_proveedor = txtnirproveedor.Text
                dts.gnombre_provedor = txtnombreprovee.Text



                If func.insertar_compra(dts) Then
                    MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


    End Sub
    Private Sub buscar()
        Try
            Dim func As New funCompraProducto
            dt = func.mostracargarExcel


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " = '" & txtfecha.Text & "'"

            If dv.Count <> 0 Then
                'inexistente.Visible = False
                DataGridView1.DataSource = dv
                'ocultar_columnas()

            Else
                'inexistente.Visible = True
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub limpiar()
        txtidcompra.Clear()
        txtidproducto.Clear()
        txtnombreproducto.Clear()
        txtdescripcion.Clear()
        txtmarca.Clear()
        txtprecioUni.Clear()
        txtcantidadCom.Clear()
        txttotalCom.Clear()
        txtnirproveedor.Clear()
        txtnombreprovee.Clear()

    End Sub
    Sub ocultar()
        txtidcompra.Enabled = False
        txtmarca.Enabled = False
        txtprecioUni.Enabled = False
        txtcantidadCom.Enabled = False
        txttotalCom.Enabled = False
    End Sub
    Sub mostrar_texto()

        txtmarca.Enabled = True
        txtprecioUni.Enabled = True
        txtcantidadCom.Enabled = True
        txttotalCom.Enabled = True
    End Sub

    Private Sub PixNuevo_Click(sender As Object, e As EventArgs) Handles PixNuevo.Click
        Dim genera_cod As New funCompraProducto
        genera_cod.generar_codigo()
        mostrar_texto()


    End Sub

    Private Sub txtidcompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidcompra.KeyPress

    End Sub

    Private Sub txtmarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmarca.KeyPress

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
            txtprecioUni.Focus()
        End If
    End Sub


    Private Sub txtcantidadCom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidadCom.KeyPress

        'numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            txttotalCom.Text = Val(txtprecioUni.Text) * (txtcantidadCom.Text)
        End If
    End Sub

    Private Sub txtprecioUni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioUni.KeyPress
        'numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            txtcantidadCom.Focus()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        limpiar()
        ocultar()
    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs)
        buscar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        buscar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            'Intentar generar el documento.
            'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
            ExportarDatosExcel(DataGridView1, "Reporte de Socios: " + Now.Date())
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ExportarDatosExcel(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            'Encabezado.  
            .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("A1:L1").Merge()
            .Range("A1:L1").Value = "LISTA DE COMPRAS"
            .Range("A1:L1").Font.Bold = True
            .Range("A1:L1").Font.Size = 16
            'Texto despues del encabezado.   
            .Range("A2:L2").Merge()
            .Range("A2:L2").Value = titulo
            .Range("A2:L2").Font.Bold = True
            .Range("A2:L2").Font.Size = 10
            'Espacio.
            .Range("A3:L3").Merge()
            .Range("A3:L3").Value = ""
            .Range("A3:L3").Font.Bold = True
            .Range("A3:L3").Font.Size = 10
            'Estilo a titulos de la tabla.
            .Range("A4:P4").Font.Bold = True
            'Establecer tipo de letra al rango determinado.
            .Range("A1:P100").Font.Name = "Tahoma"
            'Los datos se registran a partir de la columna A, fila 4.
            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 4
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    : If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 10
                    'Establece un formato a los numeros por Default.
                    'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format
                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If
                End If
            Next
            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq
            'Cargar Datos del DataGridView.   
            Dim i As Integer = Numero + 1
            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        'Aqui se realiza la carga de datos.  
                        .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                        'Establece las propiedades de los datos del DataGridView por Default.
                        '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))   
                        '.Range(strColumna + i, strColumna + i).In()   
                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i
            'Dibujar las líneas de las columnas.  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next
            'Dibujar el border exterior grueso de la tabla.   
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With
        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub

End Class