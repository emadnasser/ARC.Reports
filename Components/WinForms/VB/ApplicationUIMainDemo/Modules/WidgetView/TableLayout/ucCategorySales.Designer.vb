Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ucCategorySales
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim simpleDiagram1 As New DevExpress.XtraCharts.SimpleDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Dim pieSeriesLabel2 As New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView2 As New DevExpress.XtraCharts.PieSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.totalSalesItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.totalSalesItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
            Me.chartControl1.BorderOptions.Visibility = Utils.DefaultBoolean.False
			Me.chartControl1.DataSource = Me.totalSalesItemBindingSource
			simpleDiagram1.EqualPieSize = False
			Me.chartControl1.Diagram = simpleDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.EquallySpacedItems = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentDataMember = "Category"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			pieSeriesLabel1.ColumnIndent = 6
            pieSeriesLabel1.TextPattern = "{A}"
			pieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			series1.Label = pieSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Series 1"
			series1.SummaryFunction = "SUM([RevenueYTD])"
			pieSeriesView1.RuntimeExploding = False
			series1.View = pieSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Category"
			Me.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            pieSeriesLabel2.TextPattern = "{VP:G}"
			Me.chartControl1.SeriesTemplate.Label = pieSeriesLabel2
			Me.chartControl1.SeriesTemplate.SummaryFunction = "SUM([RevenueYTD])"
			Me.chartControl1.SeriesTemplate.TopNOptions.Enabled = True
			pieSeriesView2.RuntimeExploding = False
			Me.chartControl1.SeriesTemplate.View = pieSeriesView2
			Me.chartControl1.Size = New System.Drawing.Size(690, 341)
			Me.chartControl1.TabIndex = 0
			chartTitle1.Text = "Revenue"
			chartTitle1.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(60))))), (CInt(Fix((CByte(147))))), (CInt(Fix((CByte(211))))))
			Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' totalSalesItemBindingSource
			' 
			Me.totalSalesItemBindingSource.DataSource = GetType(DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem)
			' 
			' ucCategorySales
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "ucCategorySales"
			Me.Size = New System.Drawing.Size(690, 341)
			CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.totalSalesItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private totalSalesItemBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace
