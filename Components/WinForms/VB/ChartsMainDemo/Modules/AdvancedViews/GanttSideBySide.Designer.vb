Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AdvancedViews
	Partial Public Class GanttSideBySideDemo
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
			Dim xyDiagramPane1 As New DevExpress.XtraCharts.XYDiagramPane()
			Dim secondaryAxisX1 As New DevExpress.XtraCharts.SecondaryAxisX()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim rangeBarSeriesLabel1 As New DevExpress.XtraCharts.RangeBarSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Project 1", New Object() { (CObj(New System.DateTime(2005, 3, 27, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 30, 0, 0, 0, 0)))}, 0)
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("task 1", New Object() { (CObj(New System.DateTime(2005, 3, 27, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 4, 29, 0, 0, 0, 0)))}, 1)
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("task 2", New Object() { (CObj(New System.DateTime(2005, 4, 19, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 30, 0, 0, 0, 0)))}, 2)
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("task 3", New Object() { (CObj(New System.DateTime(2005, 4, 18, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 7, 0, 0, 0, 0)))}, 3)
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("task 4", New Object() { (CObj(New System.DateTime(2005, 4, 17, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 6, 0, 0, 0, 0)))}, 4)
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("task 5", New Object() { (CObj(New System.DateTime(2005, 4, 23, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 12, 0, 0, 0, 0)))}, 6)
			Dim sideBySideGanttSeriesView1 As New DevExpress.XtraCharts.SideBySideGanttSeriesView()
			Dim barGrowUpAnimation1 As New DevExpress.XtraCharts.BarGrowUpAnimation()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim rangeBarSeriesLabel2 As New DevExpress.XtraCharts.RangeBarSeriesLabel()
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("Project 1", New Object() { (CObj(New System.DateTime(2005, 4, 22, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 6, 17, 0, 0, 0, 0)))}, 0)
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("task 1", New Object() { (CObj(New System.DateTime(2005, 4, 22, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 17, 0, 0, 0, 0)))}, 1)
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("task 2", New Object() { (CObj(New System.DateTime(2005, 5, 1, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 6, 10, 0, 0, 0, 0)))}, 2)
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("task 3", New Object() { (CObj(New System.DateTime(2005, 5, 8, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 28, 0, 0, 0, 0)))}, 3)
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("task 4", New Object() { (CObj(New System.DateTime(2005, 5, 9, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 30, 0, 0, 0, 0)))}, 4)
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("task 5", New Object() { (CObj(New System.DateTime(2005, 5, 28, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 6, 17, 0, 0, 0, 0)))}, 6)
			Dim sideBySideGanttSeriesView2 As New DevExpress.XtraCharts.SideBySideGanttSeriesView()
			Dim barSlideAnimation1 As New DevExpress.XtraCharts.BarSlideAnimation()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim rangeBarSeriesLabel3 As New DevExpress.XtraCharts.RangeBarSeriesLabel()
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("Project 2", New Object() { (CObj(New System.DateTime(2005, 3, 14, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 15, 0, 0, 0, 0)))}, 7)
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("task 1", New Object() { (CObj(New System.DateTime(2005, 3, 14, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 4, 23, 0, 0, 0, 0)))}, 8)
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("task 2", New Object() { (CObj(New System.DateTime(2005, 3, 21, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 4, 9, 0, 0, 0, 0)))}, 9)
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("task 3", New Object() { (CObj(New System.DateTime(2005, 3, 28, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 4, 16, 0, 0, 0, 0)))}, 10)
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint("task 4", New Object() { (CObj(New System.DateTime(2005, 4, 4, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 4, 23, 0, 0, 0, 0)))}, 11)
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint("task 5", New Object() { (CObj(New System.DateTime(2005, 4, 26, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 15, 0, 0, 0, 0)))}, 12)
			Dim sideBySideGanttSeriesView3 As New DevExpress.XtraCharts.SideBySideGanttSeriesView()
			Dim barGrowUpAnimation2 As New DevExpress.XtraCharts.BarGrowUpAnimation()
			Dim series4 As New DevExpress.XtraCharts.Series()
			Dim rangeBarSeriesLabel4 As New DevExpress.XtraCharts.RangeBarSeriesLabel()
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint("Project 2", New Object() { (CObj(New System.DateTime(2005, 4, 11, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 6, 9, 0, 0, 0, 0)))}, 7)
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint("task 1", New Object() { (CObj(New System.DateTime(2005, 4, 11, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 6, 0, 0, 0, 0)))}, 8)
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint("task 2", New Object() { (CObj(New System.DateTime(2005, 4, 17, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 6, 0, 0, 0, 0)))}, 9)
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint("task 3", New Object() { (CObj(New System.DateTime(2005, 4, 29, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 17, 0, 0, 0, 0)))}, 10)
			Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint("task 4", New Object() { (CObj(New System.DateTime(2005, 5, 9, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 5, 25, 0, 0, 0, 0)))}, 11)
			Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint("task 5", New Object() { (CObj(New System.DateTime(2005, 5, 25, 0, 0, 0, 0))), (CObj(New System.DateTime(2005, 6, 9, 0, 0, 0, 0)))}, 12)
			Dim sideBySideGanttSeriesView4 As New DevExpress.XtraCharts.SideBySideGanttSeriesView()
			Dim barSlideAnimation2 As New DevExpress.XtraCharts.BarSlideAnimation()
			Dim sideBySideGanttSeriesView5 As New DevExpress.XtraCharts.SideBySideGanttSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(ganttDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisX1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(rangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideGanttSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(rangeBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideGanttSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(rangeBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideGanttSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(rangeBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideGanttSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideGanttSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
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
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.CrosshairOptions.HighlightPoints = False
			Me.chart.CrosshairOptions.ShowArgumentLine = False
			Me.chart.CrosshairOptions.ShowCrosshairLabels = False
			Me.chart.CrosshairOptions.ShowGroupHeaders = False
			Me.chart.CrosshairOptions.ShowValueLabels = True
			Me.chart.CrosshairOptions.ShowValueLine = True
			Me.chart.CrosshairOptions.SnapMode = DevExpress.XtraCharts.CrosshairSnapMode.NearestValue
			Me.chart.DataBindings = Nothing
			ganttDiagram1.AxisX.Title.Text = "Project 1"
			ganttDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			ganttDiagram1.AxisY.DateTimeScaleOptions.AutoGrid = False
			ganttDiagram1.AxisY.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
			ganttDiagram1.AxisY.DateTimeScaleOptions.GridSpacing = 0.5R
			ganttDiagram1.AxisY.GridLines.MinorVisible = True
			ganttDiagram1.AxisY.Interlaced = True
			ganttDiagram1.AxisY.Label.TextPattern = "{V:m}"
			ganttDiagram1.AxisY.MinorCount = 4
			ganttDiagram1.AxisY.Title.Text = "Date"
			ganttDiagram1.AxisY.VisibleInPanesSerializable = "0"
			ganttDiagram1.PaneDistance = 3
			xyDiagramPane1.Name = "Pane 1"
			xyDiagramPane1.PaneID = 0
			xyDiagramPane1.Weight = 1.25R
			ganttDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1})
			secondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
			secondaryAxisX1.AxisID = 0
			secondaryAxisX1.Name = "secondaryAxisX1"
			secondaryAxisX1.Reverse = True
			secondaryAxisX1.Title.Text = "Project 2"
			secondaryAxisX1.VisibleInPanesSerializable = "0"
			ganttDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() { secondaryAxisX1})
			Me.chart.Diagram = ganttDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			rangeBarSeriesLabel1.Indent = 3
			rangeBarSeriesLabel1.TextPattern = "{V:m}"
			series1.Label = rangeBarSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Project 1 : Orignal Plan"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6})
			series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			barGrowUpAnimation1.Duration = System.TimeSpan.Parse("00:00:00")
			barGrowUpAnimation1.Enabled = False
			sideBySideGanttSeriesView1.Animation = barGrowUpAnimation1
			series1.View = sideBySideGanttSeriesView1
			rangeBarSeriesLabel2.Indent = 3
			rangeBarSeriesLabel2.TextPattern = "{V:m}"
			series2.Label = rangeBarSeriesLabel2
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series2.Name = "Project 1 : Current Plan"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
			series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			barSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			sideBySideGanttSeriesView2.Animation = barSlideAnimation1
			series2.View = sideBySideGanttSeriesView2
			rangeBarSeriesLabel3.Indent = 3
			rangeBarSeriesLabel3.TextPattern = "{V:m}"
			series3.Label = rangeBarSeriesLabel3
			series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series3.Name = "Project 2 : Original Plan"
			series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18})
			series3.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			barGrowUpAnimation2.Duration = System.TimeSpan.Parse("00:00:00")
			barGrowUpAnimation2.Enabled = False
			sideBySideGanttSeriesView3.Animation = barGrowUpAnimation2
			sideBySideGanttSeriesView3.AxisXName = "secondaryAxisX1"
			sideBySideGanttSeriesView3.PaneName = "Pane 1"
			series3.View = sideBySideGanttSeriesView3
			rangeBarSeriesLabel4.Indent = 3
			rangeBarSeriesLabel4.TextPattern = "{V:m}"
			series4.Label = rangeBarSeriesLabel4
			series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series4.Name = "Project 2 : Current Plan"
			series4.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24})
			series4.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			barSlideAnimation2.BeginTime = System.TimeSpan.Parse("00:00:00.8000000")
			barSlideAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			sideBySideGanttSeriesView4.Animation = barSlideAnimation2
			sideBySideGanttSeriesView4.AxisXName = "secondaryAxisX1"
			sideBySideGanttSeriesView4.PaneName = "Pane 1"
			series4.View = sideBySideGanttSeriesView4
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3, series4}
			Me.chart.SeriesTemplate.View = sideBySideGanttSeriesView5
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Project Comparison"
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 12F)
			chartTitle2.Text = "Tasks"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' GanttSideBySideDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "GanttSideBySideDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(secondaryAxisX1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(ganttDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(rangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideGanttSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(rangeBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideGanttSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(rangeBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideGanttSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(rangeBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideGanttSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideGanttSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
