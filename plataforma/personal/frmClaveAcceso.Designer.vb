<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClaveAcceso
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcargoClave = New System.Windows.Forms.TextBox()
        Me.txtpaternoClave = New System.Windows.Forms.TextBox()
        Me.txtnombreClave = New System.Windows.Forms.TextBox()
        Me.txtciClave = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Butcancelar = New System.Windows.Forms.Button()
        Me.Butguardar = New System.Windows.Forms.Button()
        Me.txtnroAcceso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "NOMBRE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "CARGO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "APELLIDO PATERNO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "C.I. :"
        '
        'txtcargoClave
        '
        Me.txtcargoClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcargoClave.Location = New System.Drawing.Point(155, 100)
        Me.txtcargoClave.Name = "txtcargoClave"
        Me.txtcargoClave.Size = New System.Drawing.Size(198, 21)
        Me.txtcargoClave.TabIndex = 19
        '
        'txtpaternoClave
        '
        Me.txtpaternoClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaternoClave.Location = New System.Drawing.Point(155, 170)
        Me.txtpaternoClave.Name = "txtpaternoClave"
        Me.txtpaternoClave.Size = New System.Drawing.Size(198, 21)
        Me.txtpaternoClave.TabIndex = 18
        '
        'txtnombreClave
        '
        Me.txtnombreClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreClave.Location = New System.Drawing.Point(155, 133)
        Me.txtnombreClave.Name = "txtnombreClave"
        Me.txtnombreClave.Size = New System.Drawing.Size(198, 21)
        Me.txtnombreClave.TabIndex = 17
        '
        'txtciClave
        '
        Me.txtciClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtciClave.Location = New System.Drawing.Point(155, 64)
        Me.txtciClave.Name = "txtciClave"
        Me.txtciClave.Size = New System.Drawing.Size(198, 21)
        Me.txtciClave.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Butcancelar)
        Me.GroupBox1.Controls.Add(Me.Butguardar)
        Me.GroupBox1.Controls.Add(Me.txtnroAcceso)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtciClave)
        Me.GroupBox1.Controls.Add(Me.txtnombreClave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtpaternoClave)
        Me.GroupBox1.Controls.Add(Me.txtcargoClave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 265)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Butcancelar
        '
        Me.Butcancelar.BackgroundImage = Global.plataforma.My.Resources.Resources.cancelar
        Me.Butcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Butcancelar.Location = New System.Drawing.Point(266, 215)
        Me.Butcancelar.Name = "Butcancelar"
        Me.Butcancelar.Size = New System.Drawing.Size(75, 44)
        Me.Butcancelar.TabIndex = 27
        Me.Butcancelar.UseVisualStyleBackColor = True
        '
        'Butguardar
        '
        Me.Butguardar.BackgroundImage = Global.plataforma.My.Resources.Resources.guardar
        Me.Butguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Butguardar.Location = New System.Drawing.Point(24, 215)
        Me.Butguardar.Name = "Butguardar"
        Me.Butguardar.Size = New System.Drawing.Size(75, 44)
        Me.Butguardar.TabIndex = 26
        Me.Butguardar.UseVisualStyleBackColor = True
        '
        'txtnroAcceso
        '
        Me.txtnroAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnroAcceso.Location = New System.Drawing.Point(155, 24)
        Me.txtnroAcceso.Name = "txtnroAcceso"
        Me.txtnroAcceso.Size = New System.Drawing.Size(198, 21)
        Me.txtnroAcceso.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "nro acceso:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(386, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 265)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE PERSONAL"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(560, 241)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(948, 48)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "acceso del personal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmClaveAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(968, 335)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClaveAcceso"
        Me.Text = "frmClaveAcceso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcargoClave As System.Windows.Forms.TextBox
    Friend WithEvents txtpaternoClave As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreClave As System.Windows.Forms.TextBox
    Friend WithEvents txtciClave As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnroAcceso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Butcancelar As System.Windows.Forms.Button
    Friend WithEvents Butguardar As System.Windows.Forms.Button
End Class
