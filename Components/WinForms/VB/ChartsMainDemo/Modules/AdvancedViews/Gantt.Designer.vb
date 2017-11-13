Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AdvancedViews
	Partial Public Class GanttDemo
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Dim ganttDiagram1 As New DevExpress.XtraCharts.GanttDiagram()
			Dim constantLine1 As New DevExpress.XtraCharts.ConstantLine()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Market Analysis", New Object() { (CObj(New System.DateTime(2006, 8, 16, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 8, 23, 0, 0, 0, 0)))}, 0)
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Feature Planning", New Object() { (CObj(New System.DateTime(2006, 8, 23, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 8, 25, 0, 0, 0, 0)))}, 1)
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("Feature 1: Implementation", New Object() { (CObj(New System.DateTime(2006, 8, 25, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 10, 18, 0, 0, 0, 0)))}, 2)
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("Feature 1: Demos&Docs", New Object() { (CObj(New System.DateTime(2006, 10, 18, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 10, 26, 0, 0, 0, 0)))}, 7)
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Feature 2: Implementation", New Object() { (CObj(New System.DateTime(2006, 9, 7, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 10, 18, 0, 0, 0, 0)))}, 3)
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Feature 2: Demos&Docs", New Object() { (CObj(New System.DateTime(2006, 10, 18, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 10, 26, 0, 0, 0, 0)))}, 8)
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("Feature 3: Implementation", New Object() { (CObj(New System.DateTime(2006, 9, 21, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 10, 18, 0, 0, 0, 0)))}, 4)
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Feature 3: Demos&Docs", New Object() { (CObj(New System.DateTime(2006, 10, 18, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 10, 26, 0, 0, 0, 0)))}, 9)
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("Testing & Bug Fixing", New Object() { (CObj(New System.DateTime(2006, 10, 26, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 11, 10, 0, 0, 0, 0)))}, 10)
			Dim overlappedGanttSeriesView1 As New DevExpress.XtraCharts.OverlappedGanttSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("Market Analysis", New Object() { (CObj(New System.DateTime(2006, 8, 16, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 8, 23, 0, 0, 0, 0)))}, 0)
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("Feature Planning", New Object() { (CObj(New System.DateTime(2006, 8, 23, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 8, 25, 0, 0, 0, 0)))}, 1)
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("Feature 1: Implementation", New Object() { (CObj(New System.DateTime(2006, 8, 25, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 9, 25, 0, 0, 0, 0)))}, 2)
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("Feature 2: Implementation", New Object() { (CObj(New System.DateTime(2006, 9, 7, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 9, 25, 0, 0, 0, 0)))}, 3)
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("Feature 3: Implementation", New Object() { (CObj(New System.DateTime(2006, 9, 21, 0, 0, 0, 0))), (CObj(New System.DateTime(2006, 9, 25, 0, 0, 0, 0)))}, 4)
			Dim overlappedGanttSeriesView2 As New DevExpress.XtraCharts.OverlappedGanttSeriesView()
			Dim barGrowUpAnimation1 As New DevExpress.XtraCharts.BarGrowUpAnimation()
			Dim overlappedGanttSeriesView3 As New DevExpress.XtraCharts.OverlappedGanttSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(ganttDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(overlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(overlappedGanttSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(overlappedGanttSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Size = New System.Drawing.Size(700, 38)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			Me.panelRoot.Visible = False
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			ganttDiagram1.AxisX.GridLines.Visible = True
			ganttDiagram1.AxisX.Title.Text = "Tasks"
			ganttDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			ganttDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			constantLine1.AxisValueSerializable = "09/25/2006 00:00:00.000"
			constantLine1.Name = "Progress Line"
			constantLine1.ShowInLegend = False
			constantLine1.Visible = False
			ganttDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() { constantLine1})
			ganttDiagram1.AxisY.DateTimeScaleOptions.AutoGrid = False
			ganttDiagram1.AxisY.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
			ganttDiagram1.AxisY.DateTimeScaleOptions.GridSpacing = 0.5R
			ganttDiagram1.AxisY.GridLines.MinorVisible = True
			ganttDiagram1.AxisY.Interlaced = True
			ganttDiagram1.AxisY.Label.TextPattern = "{V:m}"
			ganttDiagram1.AxisY.MinorCount = 4
			ganttDiagram1.AxisY.Title.Text = "Date"
			ganttDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			ganttDiagram1.AxisY.VisualRange.Auto = False
			ganttDiagram1.AxisY.VisualRange.AutoSideMargins = False
			ganttDiagram1.AxisY.VisualRange.MaxValueSerializable = "11/16/2006 00:00:00.000"
			ganttDiagram1.AxisY.VisualRange.MinValueSerializable = "08/16/2006 00:00:00.000"
			ganttDiagram1.AxisY.VisualRange.SideMarginsValue = 0R
			ganttDiagram1.AxisY.WholeRange.Auto = False
			ganttDiagram1.AxisY.WholeRange.AutoSideMargins = False
			ganttDiagram1.AxisY.WholeRange.MaxValueSerializable = "11/16/2006 00:00:00.000"
			ganttDiagram1.AxisY.WholeRange.MinValueSerializable = "08/16/2006 00:00:00.000"
			ganttDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			Me.chart.Diagram = ganttDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.Margins.Bottom = 10
			Me.chart.Legend.Margins.Left = 10
			Me.chart.Legend.Margins.Right = 10
			Me.chart.Legend.Margins.Top = 10
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Planned"
			seriesPoint2.Relations.AddRange(New DevExpress.XtraCharts.Relation() { New DevExpress.XtraCharts.TaskLink(0)})
			seriesPoint3.Relations.AddRange(New DevExpress.XtraCharts.Relation() { New DevExpress.XtraCharts.TaskLink(1)})
			seriesPoint4.Relations.AddRange(New DevExpress.XtraCharts.Relation() { New DevExpress.XtraCharts.TaskLink(2)})
			seriesPoint5.Relations.AddRange(New DevExpress.XtraCharts.Relation() { New DevExpress.XtraCharts.TaskLink(1)})
			seriesPoint6.Relations.AddRange(New DevExpress.XtraCharts.Relation() { New DevExpress.XtraCharts.TaskLink(3)})
			seriesPoint7.Relations.AddRange(New DevExpress.XtraCharts.Relation() { New DevExpress.XtraCharts.TaskLink(1)})
			seriesPoint8.Relations.AddRange(New DevExpress.XtraCharts.Relation() { New DevExpress.XtraCharts.TaskLink(4)})
			seriesPoint9.Relations.AddRange(New DevExpress.XtraCharts.Relation() { New DevExpress.XtraCharts.TaskLink(7), New DevExpress.XtraCharts.TaskLink(8), New DevExpress.XtraCharts.TaskLink(9)})
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9})
			series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.View = overlappedGanttSeriesView1
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series2.Name = "Completed"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14})
			series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			barGrowUpAnimation1.BeginTime = System.TimeSpan.Parse("00:00:00.8000000")
			overlappedGanttSeriesView2.Animation = barGrowUpAnimation1
			overlappedGanttSeriesView2.BarWidth = 0.30000001192092896R
			series2.View = overlappedGanttSeriesView2
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chart.SeriesTemplate.View = overlappedGanttSeriesView3
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "R&D Schedule"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
'			Me.chart.AnimationEnded += New DevExpress.XtraCharts.AnimationEndedEventHandler(Me.chart_AnimationEnded);
'			Me.chart.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseDown);
'			Me.chart.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseMove);
'			Me.chart.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseUp);
			' 
			' GanttDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "GanttDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(ganttDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(overlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(overlappedGanttSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(overlappedGanttSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
