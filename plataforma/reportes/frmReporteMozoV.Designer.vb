<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteMozoV
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
        Me.ventas_mozoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ventas_mozoTableAdapter = New plataforma.dbrestauranteDataSet1TableAdapters.ventas_mozoTableAdapter()
        CType(Me.dbrestauranteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ventas_mozoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ventas_mozoBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ventas_mozoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "plataforma.mozoVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(884, 451)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbrestauranteDataSet1
        '
        Me.dbrestauranteDataSet1.DataSetName = "dbrestauranteDataSet1"
        Me.dbrestauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ventas_mozoBindingSource
        '
        Me.ventas_mozoBindingSource.DataMember = "ventas_mozo"
        Me.ventas_mozoBindingSource.DataSource = Me.dbrestauranteDataSet1
        '
        'ventas_mozoTableAdapter
        '
        Me.ventas_mozoTableAdapter.ClearBeforeFill = True
        '
        'frmReporteMozoV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 451)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteMozoV"
        Me.Text = "frmReporteMozoV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dbrestauranteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ventas_mozoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ventas_mozoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbrestauranteDataSet1 As plataforma.dbrestauranteDataSet1
    Friend WithEvents ventas_mozoTableAdapter As plataforma.dbrestauranteDataSet1TableAdapters.ventas_mozoTableAdapter
End Class
