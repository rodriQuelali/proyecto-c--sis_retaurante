<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHorarioPersonal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfecha_s = New System.Windows.Forms.DateTimePicker()
        Me.txtfecha_i = New System.Windows.Forms.DateTimePicker()
        Me.txthorasalida = New System.Windows.Forms.DateTimePicker()
        Me.txthoraIngreso = New System.Windows.Forms.DateTimePicker()
        Me.txttiposalida = New System.Windows.Forms.ComboBox()
        Me.txttipoentrada = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Butcancelar = New System.Windows.Forms.Button()
        Me.Buteditar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcargo = New System.Windows.Forms.TextBox()
        Me.txtmaterno = New System.Windows.Forms.TextBox()
        Me.txtpaterno = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtidpersona = New System.Windows.Forms.TextBox()
        Me.txtidhoraio = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfecha_s)
        Me.GroupBox1.Controls.Add(Me.txtfecha_i)
        Me.GroupBox1.Controls.Add(Me.txthorasalida)
        Me.GroupBox1.Controls.Add(Me.txthoraIngreso)
        Me.GroupBox1.Controls.Add(Me.txttiposalida)
        Me.GroupBox1.Controls.Add(Me.txttipoentrada)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Butcancelar)
        Me.GroupBox1.Controls.Add(Me.Buteditar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcargo)
        Me.GroupBox1.Controls.Add(Me.txtmaterno)
        Me.GroupBox1.Controls.Add(Me.txtpaterno)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtidpersona)
        Me.GroupBox1.Controls.Add(Me.txtidhoraio)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 507)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO DE HORARIOS"
        '
        'txtfecha_s
        '
        Me.txtfecha_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha_s.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_s.Location = New System.Drawing.Point(167, 294)
        Me.txtfecha_s.Name = "txtfecha_s"
        Me.txtfecha_s.Size = New System.Drawing.Size(209, 22)
        Me.txtfecha_s.TabIndex = 34
        '
        'txtfecha_i
        '
        Me.txtfecha_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha_i.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_i.Location = New System.Drawing.Point(168, 265)
        Me.txtfecha_i.Name = "txtfecha_i"
        Me.txtfecha_i.Size = New System.Drawing.Size(208, 22)
        Me.txtfecha_i.TabIndex = 33
        '
        'txthorasalida
        '
        Me.txthorasalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthorasalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txthorasalida.Location = New System.Drawing.Point(168, 352)
        Me.txthorasalida.Name = "txthorasalida"
        Me.txthorasalida.Size = New System.Drawing.Size(99, 22)
        Me.txthorasalida.TabIndex = 32
        '
        'txthoraIngreso
        '
        Me.txthoraIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txthoraIngreso.Location = New System.Drawing.Point(167, 322)
        Me.txthoraIngreso.Name = "txthoraIngreso"
        Me.txthoraIngreso.Size = New System.Drawing.Size(100, 22)
        Me.txthoraIngreso.TabIndex = 31
        '
        'txttiposalida
        '
        Me.txttiposalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttiposalida.FormattingEnabled = True
        Me.txttiposalida.Items.AddRange(New Object() {"am", "pm"})
        Me.txttiposalida.Location = New System.Drawing.Point(275, 351)
        Me.txttiposalida.Name = "txttiposalida"
        Me.txttiposalida.Size = New System.Drawing.Size(101, 24)
        Me.txttiposalida.TabIndex = 30
        '
        'txttipoentrada
        '
        Me.txttipoentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipoentrada.FormattingEnabled = True
        Me.txttipoentrada.Items.AddRange(New Object() {"am", "pm"})
        Me.txttipoentrada.Location = New System.Drawing.Point(275, 321)
        Me.txttipoentrada.Name = "txttipoentrada"
        Me.txttipoentrada.Size = New System.Drawing.Size(101, 24)
        Me.txttipoentrada.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 354)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 15)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Horario Salida"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.plataforma.My.Resources.Resources.Group4_Meeting_Light
        Me.PictureBox1.Location = New System.Drawing.Point(21, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Butcancelar
        '
        Me.Butcancelar.BackgroundImage = Global.plataforma.My.Resources.Resources.cancelar
        Me.Butcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Butcancelar.Location = New System.Drawing.Point(330, 420)
        Me.Butcancelar.Name = "Butcancelar"
        Me.Butcancelar.Size = New System.Drawing.Size(75, 44)
        Me.Butcancelar.TabIndex = 21
        Me.Butcancelar.UseVisualStyleBackColor = True
        '
        'Buteditar
        '
        Me.Buteditar.BackgroundImage = Global.plataforma.My.Resources.Resources.modificar1
        Me.Buteditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buteditar.Location = New System.Drawing.Point(168, 420)
        Me.Buteditar.Name = "Buteditar"
        Me.Buteditar.Size = New System.Drawing.Size(75, 44)
        Me.Buteditar.TabIndex = 19
        Me.Buteditar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Horario imgreso"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Id Persona"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha Salida"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Fecha ingreso:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cargo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Apellido Materno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Apellido Paterno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre personal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Id:"
        '
        'txtcargo
        '
        Me.txtcargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcargo.Location = New System.Drawing.Point(167, 236)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.Size = New System.Drawing.Size(198, 21)
        Me.txtcargo.TabIndex = 7
        '
        'txtmaterno
        '
        Me.txtmaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaterno.Location = New System.Drawing.Point(167, 209)
        Me.txtmaterno.Name = "txtmaterno"
        Me.txtmaterno.Size = New System.Drawing.Size(198, 21)
        Me.txtmaterno.TabIndex = 4
        '
        'txtpaterno
        '
        Me.txtpaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaterno.Location = New System.Drawing.Point(167, 182)
        Me.txtpaterno.Name = "txtpaterno"
        Me.txtpaterno.Size = New System.Drawing.Size(198, 21)
        Me.txtpaterno.TabIndex = 3
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(167, 155)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(198, 21)
        Me.txtnombre.TabIndex = 2
        '
        'txtidpersona
        '
        Me.txtidpersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidpersona.Location = New System.Drawing.Point(167, 128)
        Me.txtidpersona.Name = "txtidpersona"
        Me.txtidpersona.Size = New System.Drawing.Size(198, 21)
        Me.txtidpersona.TabIndex = 1
        '
        'txtidhoraio
        '
        Me.txtidhoraio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidhoraio.Location = New System.Drawing.Point(167, 101)
        Me.txtidhoraio.Name = "txtidhoraio"
        Me.txtidhoraio.Size = New System.Drawing.Size(198, 21)
        Me.txtidhoraio.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(428, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(856, 507)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(230, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(568, 20)
        Me.TextBox2.TabIndex = 6
        '
        'txtbuscar
        '
        Me.txtbuscar.Enabled = False
        Me.txtbuscar.Location = New System.Drawing.Point(22, 59)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(190, 20)
        Me.txtbuscar.TabIndex = 5
        Me.txtbuscar.Text = "nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(844, 409)
        Me.DataGridView1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "exportar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmHorarioPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 548)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmHorarioPersonal"
        Me.Text = "FrmHorarioPersonal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Butcancelar As System.Windows.Forms.Button
    Friend WithEvents Buteditar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcargo As System.Windows.Forms.TextBox
    Friend WithEvents txtmaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtpaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtidpersona As System.Windows.Forms.TextBox
    Friend WithEvents txtidhoraio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txttiposalida As System.Windows.Forms.ComboBox
    Friend WithEvents txttipoentrada As System.Windows.Forms.ComboBox
    Friend WithEvents txthoraIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txthorasalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfecha_s As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfecha_i As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
End Class
