Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ucChartProductItem
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

		#Region "Component Designer generated code   "

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SwiftPlotDiagram1 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
            Dim SwiftPlotSeriesView1 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.monthlySalesItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SwiftPlotDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SwiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.monthlySalesItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BorderOptions.Color = System.Drawing.Color.White
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.DataSource = Me.monthlySalesItemBindingSource
            SwiftPlotDiagram1.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None
            SwiftPlotDiagram1.AxisX.DateTimeScaleOptions.GridOffset = 1.0R
            SwiftPlotDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual
            SwiftPlotDiagram1.AxisX.Label.ResolveOverlappingOptions.MinIndent = 2
            SwiftPlotDiagram1.AxisX.Label.TextPattern = "{A:MMMM}"
            SwiftPlotDiagram1.AxisX.MinorCount = 5
            SwiftPlotDiagram1.AxisX.Tickmarks.MinorLength = 1
            SwiftPlotDiagram1.AxisX.Tickmarks.Thickness = 2
            SwiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            SwiftPlotDiagram1.AxisX.WholeRange.AutoSideMargins = False
            SwiftPlotDiagram1.AxisX.WholeRange.SideMarginsValue = 8.0R
            SwiftPlotDiagram1.AxisY.Title.Text = "Revenue"
            SwiftPlotDiagram1.AxisY.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(206, Byte), Integer))
            SwiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = SwiftPlotDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl1.Legend.EquallySpacedItems = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesDataMember = "Product"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "CurrentDate"
            Me.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Me.chartControl1.SeriesTemplate.SummaryFunction = "SUM([Revenue])"
            SwiftPlotSeriesView1.Antialiasing = True
            SwiftPlotSeriesView1.LineStyle.Thickness = 2
            Me.chartControl1.SeriesTemplate.View = SwiftPlotSeriesView1
            Me.chartControl1.Size = New System.Drawing.Size(688, 368)
            Me.chartControl1.TabIndex = 0
            '
            'monthlySalesItemBindingSource
            '
            Me.monthlySalesItemBindingSource.DataSource = GetType(DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.MonthlySalesItem)
            '
            'ucChartProductItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "ucChartProductItem"
            Me.Size = New System.Drawing.Size(688, 368)
            CType(SwiftPlotDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SwiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.monthlySalesItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private monthlySalesItemBindingSource As System.Windows.Forms.BindingSource


	End Class
End Namespace
