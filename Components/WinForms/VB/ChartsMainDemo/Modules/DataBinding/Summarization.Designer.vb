Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataBinding
	Partial Public Class SummarizationDemo
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim barGrowUpAnimation1 As New DevExpress.XtraCharts.BarGrowUpAnimation()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SummarizationDemo))
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.labelFunction = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxFunction = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.dS41 = New DevExpress.XtraCharts.Demos.DS4()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxFunction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dS41, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelFunction)
			Me.panel.Controls.Add(Me.comboBoxFunction)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxFunction, 0)
			Me.panel.Controls.SetChildIndex(Me.labelFunction, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.Cursor = System.Windows.Forms.Cursors.Default
			Me.chart.DataAdapter = Me.oleDbDataAdapter1
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Label.Staggered = True
			xyDiagram1.AxisX.Title.Text = "Categories"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Title.Text = "Volume (USD)"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "CategoryName"
			sideBySideBarSeriesLabel1.LineLength = 20
			sideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
			series1.Label = sideBySideBarSeriesLabel1
			series1.LegendTextPattern = "{A}"
			series1.Name = "Quantity"
			series1.SummaryFunction = "SUM([Sum])"
			barGrowUpAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.3000000")
			sideBySideBarSeriesView1.Animation = barGrowUpAnimation1
			sideBySideBarSeriesView1.ColorEach = True
			series1.View = sideBySideBarSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = ""
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' oleDbDataAdapter1
			' 
			Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
			Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Sum", "Sum")})})
			' 
			' oleDbSelectCommand1
			' 
			Me.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText")
			Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
			' 
			' labelFunction
			' 
			Me.labelFunction.Location = New System.Drawing.Point(12, 12)
			Me.labelFunction.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelFunction.Name = "labelFunction"
			Me.labelFunction.Size = New System.Drawing.Size(90, 13)
			Me.labelFunction.TabIndex = 56
			Me.labelFunction.Text = "Summary function:"
			' 
			' comboBoxFunction
			' 
			Me.comboBoxFunction.Location = New System.Drawing.Point(105, 9)
			Me.comboBoxFunction.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxFunction.Name = "comboBoxFunction"
			Me.comboBoxFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxFunction.Properties.Items.AddRange(New Object() { "SUM", "MIN", "MAX", "AVERAGE", "COUNT", "STDDEV (Custom)"})
			Me.comboBoxFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxFunction.Size = New System.Drawing.Size(120, 20)
			Me.comboBoxFunction.TabIndex = 0
'			Me.comboBoxFunction.SelectedIndexChanged += New System.EventHandler(Me.comboBoxMode_SelectedIndexChanged);
			' 
			' dS41
			' 
			Me.dS41.DataSetName = "DS4"
			Me.dS41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' SummarizationDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "SummarizationDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxFunction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dS41, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private dS41 As DS4
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Friend oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private labelFunction As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxFunction As DevExpress.XtraEditors.ComboBoxEdit

	End Class
End Namespace
