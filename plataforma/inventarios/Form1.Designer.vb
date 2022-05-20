<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.StStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCopia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeGaseosaParVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuConProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDePèrsonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraiosDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeMaterialesPorFechaRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuListaVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StStatus.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StStatus
        '
        Me.StStatus.BackColor = System.Drawing.Color.Silver
        Me.StStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.StStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StStatus.Location = New System.Drawing.Point(0, 0)
        Me.StStatus.Name = "StStatus"
        Me.StStatus.Size = New System.Drawing.Size(1231, 22)
        Me.StStatus.TabIndex = 20
        Me.StStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(554, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "usuario"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel5.Text = "cargo"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel2.Text = "Fecha"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusLabel3.Text = "Hora"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.Silver
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(554, 17)
        Me.ToolStripStatusLabel4.Spring = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.BackgroundImage = Global.plataforma.My.Resources.Resources.barravertical
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ControlDePersonalToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 22)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(245, 522)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeProductosToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.MnuCopia, Me.ProveedorToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperacionesToolStripMenuItem.Image = Global.plataforma.My.Resources.Resources.Pedidos
        Me.OperacionesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(232, 52)
        Me.OperacionesToolStripMenuItem.Text = "control almacen"
        '
        'RegistroDeProductosToolStripMenuItem
        '
        Me.RegistroDeProductosToolStripMenuItem.Name = "RegistroDeProductosToolStripMenuItem"
        Me.RegistroDeProductosToolStripMenuItem.Size = New System.Drawing.Size(315, 26)
        Me.RegistroDeProductosToolStripMenuItem.Text = "registro de productos"
        '
        'MarcaToolStripMenuItem
        '
        Me.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem"
        Me.MarcaToolStripMenuItem.Size = New System.Drawing.Size(315, 26)
        Me.MarcaToolStripMenuItem.Text = "registro de compras de insumo"
        '
        'MnuCopia
        '
        Me.MnuCopia.Name = "MnuCopia"
        Me.MnuCopia.Size = New System.Drawing.Size(315, 26)
        Me.MnuCopia.Text = "kardex"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(315, 26)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeVentasToolStripMenuItem, Me.RegistroDeGaseosaParVentaToolStripMenuItem})
        Me.VentasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasToolStripMenuItem.Image = Global.plataforma.My.Resources.Resources.producto
        Me.VentasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(232, 52)
        Me.VentasToolStripMenuItem.Text = "control de produccion"
        '
        'RegistroDeVentasToolStripMenuItem
        '
        Me.RegistroDeVentasToolStripMenuItem.Name = "RegistroDeVentasToolStripMenuItem"
        Me.RegistroDeVentasToolStripMenuItem.Size = New System.Drawing.Size(379, 26)
        Me.RegistroDeVentasToolStripMenuItem.Text = "insumos parea la preparacion de paltos"
        '
        'RegistroDeGaseosaParVentaToolStripMenuItem
        '
        Me.RegistroDeGaseosaParVentaToolStripMenuItem.Name = "RegistroDeGaseosaParVentaToolStripMenuItem"
        Me.RegistroDeGaseosaParVentaToolStripMenuItem.Size = New System.Drawing.Size(379, 26)
        Me.RegistroDeGaseosaParVentaToolStripMenuItem.Text = "registro de gaseosa par venta"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuConProductos, Me.ActualizarToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventarioToolStripMenuItem.Image = Global.plataforma.My.Resources.Resources.Clientes
        Me.InventarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(232, 52)
        Me.InventarioToolStripMenuItem.Text = "registro de menus"
        '
        'MnuConProductos
        '
        Me.MnuConProductos.Name = "MnuConProductos"
        Me.MnuConProductos.Size = New System.Drawing.Size(213, 26)
        Me.MnuConProductos.Text = "registro de platos"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.ActualizarToolStripMenuItem.Text = "actualizar"
        '
        'ControlDePersonalToolStripMenuItem
        '
        Me.ControlDePersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDePèrsonalToolStripMenuItem, Me.HoraiosDePersonalToolStripMenuItem})
        Me.ControlDePersonalToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlDePersonalToolStripMenuItem.Image = Global.plataforma.My.Resources.Resources.Representates
        Me.ControlDePersonalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ControlDePersonalToolStripMenuItem.Name = "ControlDePersonalToolStripMenuItem"
        Me.ControlDePersonalToolStripMenuItem.Size = New System.Drawing.Size(232, 52)
        Me.ControlDePersonalToolStripMenuItem.Text = "control de personal"
        '
        'RegistroDePèrsonalToolStripMenuItem
        '
        Me.RegistroDePèrsonalToolStripMenuItem.Name = "RegistroDePèrsonalToolStripMenuItem"
        Me.RegistroDePèrsonalToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.RegistroDePèrsonalToolStripMenuItem.Text = "registro de pèrsonal"
        '
        'HoraiosDePersonalToolStripMenuItem
        '
        Me.HoraiosDePersonalToolStripMenuItem.Name = "HoraiosDePersonalToolStripMenuItem"
        Me.HoraiosDePersonalToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.HoraiosDePersonalToolStripMenuItem.Text = "horaios de personal"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeMaterialesPorFechaRegistroToolStripMenuItem, Me.MnuLClientes, Me.MnuListaVentas})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Image = Global.plataforma.My.Resources.Resources.modificar
        Me.ReportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(232, 52)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ListaDeMaterialesPorFechaRegistroToolStripMenuItem
        '
        Me.ListaDeMaterialesPorFechaRegistroToolStripMenuItem.Name = "ListaDeMaterialesPorFechaRegistroToolStripMenuItem"
        Me.ListaDeMaterialesPorFechaRegistroToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ListaDeMaterialesPorFechaRegistroToolStripMenuItem.Text = "control de personal"
        '
        'MnuLClientes
        '
        Me.MnuLClientes.Name = "MnuLClientes"
        Me.MnuLClientes.Size = New System.Drawing.Size(229, 26)
        Me.MnuLClientes.Text = "control de ventas"
        '
        'MnuListaVentas
        '
        Me.MnuListaVentas.Name = "MnuListaVentas"
        Me.MnuListaVentas.Size = New System.Drawing.Size(229, 26)
        Me.MnuListaVentas.Text = "control de prudctos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Image = Global.plataforma.My.Resources.Resources.salir
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(232, 52)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.plataforma.My.Resources.Resources.menu_14_back2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1231, 544)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StStatus)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StStatus.ResumeLayout(False)
        Me.StStatus.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCopia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuConProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeMaterialesPorFechaRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuListaVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDePersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDePèrsonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeGaseosaParVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoraiosDePersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
