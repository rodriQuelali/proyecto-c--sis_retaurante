<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepFactura
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
        Me.mostrar_factura_repBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_factura_repTableAdapter = New plataforma.dbrestauranteDataSet1TableAdapters.mostrar_factura_repTableAdapter()
        CType(Me.dbrestauranteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_factura_repBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_factura_repBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "plataforma.RepVentasFactura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(771, 479)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbrestauranteDataSet1
        '
        Me.dbrestauranteDataSet1.DataSetName = "dbrestauranteDataSet1"
        Me.dbrestauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_factura_repBindingSource
        '
        Me.mostrar_factura_repBindingSource.DataMember = "mostrar_factura_rep"
        Me.mostrar_factura_repBindingSource.DataSource = Me.dbrestauranteDataSet1
        '
        'mostrar_factura_repTableAdapter
        '
        Me.mostrar_factura_repTableAdapter.ClearBeforeFill = True
        '
        'frmRepFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 479)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRepFactura"
        Me.Text = "frmRepFactura"
        CType(Me.dbrestauranteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_factura_repBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_factura_repBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbrestauranteDataSet1 As plataforma.dbrestauranteDataSet1
    Friend WithEvents mostrar_factura_repTableAdapter As plataforma.dbrestauranteDataSet1TableAdapters.mostrar_factura_repTableAdapter
End Class
