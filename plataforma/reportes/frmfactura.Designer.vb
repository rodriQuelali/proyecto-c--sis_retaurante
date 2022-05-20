<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfactura
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbrestauranteDataSet1 = New plataforma.dbrestauranteDataSet1()
        Me.venta_factura_unoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venta_factura_unoTableAdapter = New plataforma.dbrestauranteDataSet1TableAdapters.venta_factura_unoTableAdapter()
        Me.venta_factura_dosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venta_factura_dosTableAdapter = New plataforma.dbrestauranteDataSet1TableAdapters.venta_factura_dosTableAdapter()
        CType(Me.dbrestauranteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venta_factura_unoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venta_factura_dosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.venta_factura_unoBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.venta_factura_dosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "plataforma.Repfactura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(713, 416)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbrestauranteDataSet1
        '
        Me.dbrestauranteDataSet1.DataSetName = "dbrestauranteDataSet1"
        Me.dbrestauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'venta_factura_unoBindingSource
        '
        Me.venta_factura_unoBindingSource.DataMember = "venta_factura_uno"
        Me.venta_factura_unoBindingSource.DataSource = Me.dbrestauranteDataSet1
        '
        'venta_factura_unoTableAdapter
        '
        Me.venta_factura_unoTableAdapter.ClearBeforeFill = True
        '
        'venta_factura_dosBindingSource
        '
        Me.venta_factura_dosBindingSource.DataMember = "venta_factura_dos"
        Me.venta_factura_dosBindingSource.DataSource = Me.dbrestauranteDataSet1
        '
        'venta_factura_dosTableAdapter
        '
        Me.venta_factura_dosTableAdapter.ClearBeforeFill = True
        '
        'frmfactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 416)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmfactura"
        Me.Text = "frmfactura"
        CType(Me.dbrestauranteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venta_factura_unoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venta_factura_dosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venta_factura_unoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbrestauranteDataSet1 As plataforma.dbrestauranteDataSet1
    Friend WithEvents venta_factura_dosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents venta_factura_unoTableAdapter As plataforma.dbrestauranteDataSet1TableAdapters.venta_factura_unoTableAdapter
    Friend WithEvents venta_factura_dosTableAdapter As plataforma.dbrestauranteDataSet1TableAdapters.venta_factura_dosTableAdapter
End Class
