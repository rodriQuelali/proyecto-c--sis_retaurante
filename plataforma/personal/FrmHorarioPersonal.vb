Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Text
Public Class FrmHorarioPersonal
    Private dt As New DataTable
    Private Sub FrmHorarioPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Buteditar.Visible = False
        txtnombre.CharacterCasing = CharacterCasing.Upper
        txtpaterno.CharacterCasing = CharacterCasing.Upper
        txtmaterno.CharacterCasing = CharacterCasing.Upper
        txtcargo.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New funHorario
            dt = func.mostra


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub insertar_h()
        Try
            Dim dts As New obghorarioPersonal
            Dim func As New funHorario

            dts.gid_personal = frmRegistroP.txtci.Text
            dts.gnombre = frmRegistroP.txtnombre.Text
            dts.gapellido_p = frmRegistroP.txtpaterno.Text
            dts.gapellido_m = frmRegistroP.txtmaterno.Text
            dts.gcargo = frmRegistroP.txtcargo.Text
            dts.gfecha_i = frmRegistroP.txthora_general.Text
            dts.gfecha_s = frmRegistroP.txthora_general.Text
            dts.ghorario_i = "00:00:00"
            dts.gtipo_i = "am"
            dts.ghorario_s = "00:00:00"
            dts.gtipo_s = "pm"

            If func.insertar_horario(dts) Then
                MessageBox.Show("se registro correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'mostrar()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Buteditar.Visible = True
        txtidhoraio.Text = DataGridView1.SelectedCells.Item(0).Value
        txtidpersona.Text = DataGridView1.SelectedCells.Item(1).Value
        txtnombre.Text = DataGridView1.SelectedCells.Item(2).Value
        txtpaterno.Text = DataGridView1.SelectedCells.Item(3).Value
        txtmaterno.Text = DataGridView1.SelectedCells.Item(4).Value
        txtcargo.Text = DataGridView1.SelectedCells.Item(5).Value
        txtfecha_i.Text = DataGridView1.SelectedCells.Item(6).Value
        txtfecha_s.Text = DataGridView1.SelectedCells.Item(7).Value
        txthoraIngreso.Text = DataGridView1.SelectedCells.Item(8).Value
        txttipoentrada.Text = DataGridView1.SelectedCells.Item(9).Value
        txthorasalida.Text = DataGridView1.SelectedCells.Item(10).Value
        txttiposalida.Text = DataGridView1.SelectedCells.Item(11).Value



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Intentar generar el documento.
            'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
            ExportarDatosExcel(DataGridView1, "Reporte de Hoarios: " + Now.Date())
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
            .Range("A1:L1").Value = "LISTA DE HORAIOS DE LA SEMANA."
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

    Public Sub borra()
        txtidhoraio.Clear()
        txtidpersona.Clear()
        txtnombre.Clear()
        txtpaterno.Clear()
        txtmaterno.Clear()
        txtcargo.Clear()

    End Sub

    Private Sub Butcancelar_Click(sender As Object, e As EventArgs) Handles Butcancelar.Click
        borra()
        Buteditar.Visible = False
    End Sub

    Private Sub Buteditar_Click(sender As Object, e As EventArgs) Handles Buteditar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("realmente desea editar los daros de los horario", "modificar horario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidhoraio.Text <> "" And txtidpersona.Text <> "" Then

                Try

                    Dim dts As New obghorarioPersonal
                    Dim func As New funHorario
                    dts.gnro_hoario = txtidhoraio.Text
                    dts.gid_personal = txtidpersona.Text
                    dts.gnombre = txtnombre.Text
                    dts.gapellido_p = txtpaterno.Text
                    dts.gapellido_m = txtmaterno.Text
                    dts.gcargo = txtcargo.Text
                    dts.gfecha_i = txtfecha_i.Text
                    dts.gfecha_s = txtfecha_s.Text
                    dts.ghorario_i = txthoraIngreso.Text
                    dts.gtipo_i = txttipoentrada.Text
                    dts.ghorario_s = txthorasalida.Text
                    dts.gtipo_s = txttiposalida.Text

                    If func.editar_horario(dts) Then
                        MessageBox.Show("proveedor medificados personal", "modificado personal", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        mostrar()
                        borra()
                    Else
                        MessageBox.Show("personal NO se medifico intenete de nuevo", "mall..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        borra()
                    End If
                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("falta ingresar algunos datos", "modificado personal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = txtbuscar.Text & " like '" & TextBox2.Text & "%'"

            If dv.Count <> 0 Then
                DataGridView1.DataSource = dv
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        buscar()
    End Sub
End Class