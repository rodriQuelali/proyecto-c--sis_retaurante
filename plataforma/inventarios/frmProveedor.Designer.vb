<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnombrepro = New System.Windows.Forms.TextBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.PixNuevo = New System.Windows.Forms.PictureBox()
        Me.PixCancelar = New System.Windows.Forms.PictureBox()
        Me.Pixeliminar = New System.Windows.Forms.PictureBox()
        Me.pixEditar = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PixNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PixCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pixeliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttelefono)
        Me.GroupBox2.Controls.Add(Me.txtdireccion)
        Me.GroupBox2.Controls.Add(Me.txtnombrepro)
        Me.GroupBox2.Controls.Add(Me.txtnit)
        Me.GroupBox2.Controls.Add(Me.PixNuevo)
        Me.GroupBox2.Controls.Add(Me.PixCancelar)
        Me.GroupBox2.Controls.Add(Me.Pixeliminar)
        Me.GroupBox2.Controls.Add(Me.pixEditar)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(261, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 208)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(165, 116)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(201, 20)
        Me.txttelefono.TabIndex = 32
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(165, 90)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(201, 20)
        Me.txtdireccion.TabIndex = 31
        '
        'txtnombrepro
        '
        Me.txtnombrepro.Location = New System.Drawing.Point(165, 62)
        Me.txtnombrepro.Name = "txtnombrepro"
        Me.txtnombrepro.Size = New System.Drawing.Size(201, 20)
        Me.txtnombrepro.TabIndex = 30
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(165, 36)
        Me.txtnit.MaxLength = 10
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(201, 20)
        Me.txtnit.TabIndex = 29
        '
        'PixNuevo
        '
        Me.PixNuevo.Image = Global.plataforma.My.Resources.Resources.add_item_icon
        Me.PixNuevo.Location = New System.Drawing.Point(26, 158)
        Me.PixNuevo.Name = "PixNuevo"
        Me.PixNuevo.Size = New System.Drawing.Size(57, 35)
        Me.PixNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PixNuevo.TabIndex = 28
        Me.PixNuevo.TabStop = False
        '
        'PixCancelar
        '
        Me.PixCancelar.Image = Global.plataforma.My.Resources.Resources.cancelar
        Me.PixCancelar.Location = New System.Drawing.Point(309, 158)
        Me.PixCancelar.Name = "PixCancelar"
        Me.PixCancelar.Size = New System.Drawing.Size(57, 35)
        Me.PixCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PixCancelar.TabIndex = 26
        Me.PixCancelar.TabStop = False
        '
        'Pixeliminar
        '
        Me.Pixeliminar.Image = Global.plataforma.My.Resources.Resources.Eliminar__1_
        Me.Pixeliminar.Location = New System.Drawing.Point(237, 158)
        Me.Pixeliminar.Name = "Pixeliminar"
        Me.Pixeliminar.Size = New System.Drawing.Size(57, 35)
        Me.Pixeliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pixeliminar.TabIndex = 25
        Me.Pixeliminar.TabStop = False
        '
        'pixEditar
        '
        Me.pixEditar.Image = Global.plataforma.My.Resources.Resources.modificar1
        Me.pixEditar.Location = New System.Drawing.Point(165, 158)
        Me.pixEditar.Name = "pixEditar"
        Me.pixEditar.Size = New System.Drawing.Size(57, 35)
        Me.pixEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixEditar.TabIndex = 24
        Me.pixEditar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.plataforma.My.Resources.Resources.guardar
        Me.PictureBox2.Location = New System.Drawing.Point(102, 158)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "nombre proveedor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "nit proveedor:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Location = New System.Drawing.Point(33, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 300)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "lista de productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(640, 229)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(210, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 36)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Registtro de Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.plataforma.My.Resources.Resources.Actions_contact_new_icon
        Me.PictureBox1.Location = New System.Drawing.Point(39, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(708, 582)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProveedor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PixNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PixCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pixeliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PixCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents Pixeliminar As System.Windows.Forms.PictureBox
    Friend WithEvents pixEditar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PixNuevo As System.Windows.Forms.PictureBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtnombrepro As System.Windows.Forms.TextBox
    Friend WithEvents txtnit As System.Windows.Forms.TextBox
End Class
