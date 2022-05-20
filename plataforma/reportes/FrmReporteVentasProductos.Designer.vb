<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteVentasProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbrestauranteDataSet1 = New plataforma.dbrestauranteDataSet1()
        Me.venta_productoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venta_productoTableAdapter = New plataforma.dbrestauranteDataSet1TableAdapters.venta_productoTableAdapter()
        CType(Me.dbrestauranteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venta_productoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.venta_productoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "plataforma.RepVentaProductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(598, 362)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbrestauranteDataSet1
        '
        Me.dbrestauranteDataSet1.DataSetName = "dbrestauranteDataSet1"
        Me.dbrestauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'venta_productoBindingSource
        '
        Me.venta_productoBindingSource.DataMember = "venta_producto"
        Me.venta_productoBindingSource.DataSource = Me.dbrestauranteDataSet1
        '
        'venta_productoTableAdapter
        '
        Me.venta_productoTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteVentasProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 362)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteVentasProductos"
        Me.Text = "FrmReporteVentasProductos"
        CType(Me.dbrestauranteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venta_productoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venta_productoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbrestauranteDataSet1 As plataforma.dbrestauranteDataSet1
    Friend WithEvents venta_productoTableAdapter As plataforma.dbrestauranteDataSet1TableAdapters.venta_productoTableAdapter
End Class
