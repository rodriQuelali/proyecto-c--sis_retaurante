<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResta
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtmedida = New System.Windows.Forms.ComboBox()
        Me.txtnombreProducto = New System.Windows.Forms.TextBox()
        Me.txtnombreplato = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PixNuevo = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pixcancelar = New System.Windows.Forms.PictureBox()
        Me.pixeliminar = New System.Windows.Forms.PictureBox()
        Me.pixeditar = New System.Windows.Forms.PictureBox()
        Me.pixguardar = New System.Windows.Forms.PictureBox()
        Me.txtidplato = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtnombreRese = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtidreseta = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PixNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixcancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixeliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixeditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixguardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtmedida)
        Me.GroupBox3.Controls.Add(Me.txtnombreProducto)
        Me.GroupBox3.Controls.Add(Me.txtnombreplato)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.PixNuevo)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtidproducto)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.pixcancelar)
        Me.GroupBox3.Controls.Add(Me.pixeliminar)
        Me.GroupBox3.Controls.Add(Me.pixeditar)
        Me.GroupBox3.Controls.Add(Me.pixguardar)
        Me.GroupBox3.Controls.Add(Me.txtidplato)
        Me.GroupBox3.Controls.Add(Me.txtdescripcion)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtcantidad)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtnombreRese)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtidreseta)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox3.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 293)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Receta de plato"
        '
        'txtmedida
        '
        Me.txtmedida.FormattingEnabled = True
        Me.txtmedida.Items.AddRange(New Object() {"gr", "kg", "ltr", "ml"})
        Me.txtmedida.Location = New System.Drawing.Point(145, 89)
        Me.txtmedida.Name = "txtmedida"
        Me.txtmedida.Size = New System.Drawing.Size(221, 21)
        Me.txtmedida.TabIndex = 36
        '
        'txtnombreProducto
        '
        Me.txtnombreProducto.Enabled = False
        Me.txtnombreProducto.Location = New System.Drawing.Point(145, 260)
        Me.txtnombreProducto.MaxLength = 9
        Me.txtnombreProducto.Name = "txtnombreProducto"
        Me.txtnombreProducto.Size = New System.Drawing.Size(221, 20)
        Me.txtnombreProducto.TabIndex = 35
        '
        'txtnombreplato
        '
        Me.txtnombreplato.Enabled = False
        Me.txtnombreplato.Location = New System.Drawing.Point(145, 204)
        Me.txtnombreplato.MaxLength = 9
        Me.txtnombreplato.Name = "txtnombreplato"
        Me.txtnombreplato.Size = New System.Drawing.Size(221, 20)
        Me.txtnombreplato.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "nombre producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "nombre plato"
        '
        'PixNuevo
        '
        Me.PixNuevo.Image = Global.plataforma.My.Resources.Resources.add_item_icon
        Me.PixNuevo.Location = New System.Drawing.Point(384, 34)
        Me.PixNuevo.Name = "PixNuevo"
        Me.PixNuevo.Size = New System.Drawing.Size(57, 35)
        Me.PixNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PixNuevo.TabIndex = 31
        Me.PixNuevo.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(291, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "codigo producto:"
        '
        'txtidproducto
        '
        Me.txtidproducto.Enabled = False
        Me.txtidproducto.Location = New System.Drawing.Point(145, 228)
        Me.txtidproducto.MaxLength = 9
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(140, 20)
        Me.txtidproducto.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(291, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pixcancelar
        '
        Me.pixcancelar.Image = Global.plataforma.My.Resources.Resources.cancelar
        Me.pixcancelar.Location = New System.Drawing.Point(384, 228)
        Me.pixcancelar.Name = "pixcancelar"
        Me.pixcancelar.Size = New System.Drawing.Size(57, 35)
        Me.pixcancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixcancelar.TabIndex = 26
        Me.pixcancelar.TabStop = False
        '
        'pixeliminar
        '
        Me.pixeliminar.Image = Global.plataforma.My.Resources.Resources.Eliminar__1_
        Me.pixeliminar.Location = New System.Drawing.Point(384, 176)
        Me.pixeliminar.Name = "pixeliminar"
        Me.pixeliminar.Size = New System.Drawing.Size(57, 35)
        Me.pixeliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixeliminar.TabIndex = 25
        Me.pixeliminar.TabStop = False
        '
        'pixeditar
        '
        Me.pixeditar.Image = Global.plataforma.My.Resources.Resources.modificar1
        Me.pixeditar.Location = New System.Drawing.Point(384, 125)
        Me.pixeditar.Name = "pixeditar"
        Me.pixeditar.Size = New System.Drawing.Size(57, 35)
        Me.pixeditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixeditar.TabIndex = 24
        Me.pixeditar.TabStop = False
        '
        'pixguardar
        '
        Me.pixguardar.Image = Global.plataforma.My.Resources.Resources.guardar
        Me.pixguardar.Location = New System.Drawing.Point(384, 84)
        Me.pixguardar.Name = "pixguardar"
        Me.pixguardar.Size = New System.Drawing.Size(57, 35)
        Me.pixguardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixguardar.TabIndex = 23
        Me.pixguardar.TabStop = False
        '
        'txtidplato
        '
        Me.txtidplato.Enabled = False
        Me.txtidplato.Location = New System.Drawing.Point(145, 173)
        Me.txtidplato.MaxLength = 9
        Me.txtidplato.Name = "txtidplato"
        Me.txtidplato.Size = New System.Drawing.Size(140, 20)
        Me.txtidplato.TabIndex = 18
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(145, 147)
        Me.txtdescripcion.MaxLength = 100
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(221, 20)
        Me.txtdescripcion.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "codigo plato:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "cantidad:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(145, 116)
        Me.txtcantidad.MaxLength = 9
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(221, 20)
        Me.txtcantidad.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(30, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "descripcion:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 93)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "medida"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(26, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "nombre reseta:"
        '
        'txtnombreRese
        '
        Me.txtnombreRese.Location = New System.Drawing.Point(145, 60)
        Me.txtnombreRese.Name = "txtnombreRese"
        Me.txtnombreRese.Size = New System.Drawing.Size(221, 20)
        Me.txtnombreRese.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(26, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Código:"
        '
        'txtidreseta
        '
        Me.txtidreseta.Location = New System.Drawing.Point(145, 34)
        Me.txtidreseta.Name = "txtidreseta"
        Me.txtidreseta.Size = New System.Drawing.Size(221, 20)
        Me.txtidreseta.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox5.Location = New System.Drawing.Point(518, 77)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(754, 436)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "lista de productos"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 43)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(742, 387)
        Me.DataGridView2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(297, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 36)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "REGISTRO DE RECETAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.plataforma.My.Resources.Resources.sistema_del_men_tailands_de_la_comida_34681895
        Me.PictureBox2.Location = New System.Drawing.Point(151, 375)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(361, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.plataforma.My.Resources.Resources.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(22, 374)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'frmResta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 525)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmResta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmResta"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PixNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixcancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixeliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixeditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixguardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents pixcancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pixeliminar As System.Windows.Forms.PictureBox
    Friend WithEvents pixeditar As System.Windows.Forms.PictureBox
    Friend WithEvents pixguardar As System.Windows.Forms.PictureBox
    Friend WithEvents txtidplato As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtnombreRese As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtidreseta As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PixNuevo As System.Windows.Forms.PictureBox
    Friend WithEvents txtnombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreplato As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmedida As System.Windows.Forms.ComboBox
End Class
