Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class RadarPointDemo
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
			Dim radarDiagram1 As New DevExpress.XtraCharts.RadarDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() { (CObj(2R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() { (CObj(2R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() { (CObj(3R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() { (CObj(5R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() { (CObj(8R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() { (CObj(11R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() { (CObj(13R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() { (CObj(13R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() { (CObj(11R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() { (CObj(8R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() { (CObj(5R))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() { (CObj(3R))})
			Dim radarPointSeriesView1 As New DevExpress.XtraCharts.RadarPointSeriesView()
			Dim circularMarkerWidenAnimation1 As New DevExpress.XtraCharts.CircularMarkerWidenAnimation()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() { (CObj(6R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() { (CObj(7R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() { (CObj(10R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() { (CObj(14R))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() { (CObj(18R))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() { (CObj(21R))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() { (CObj(22R))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() { (CObj(22R))})
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() { (CObj(19R))})
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() { (CObj(15R))})
			Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() { (CObj(10R))})
			Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() { (CObj(7R))})
			Dim radarPointSeriesView2 As New DevExpress.XtraCharts.RadarPointSeriesView()
			Dim circularMarkerWidenAnimation2 As New DevExpress.XtraCharts.CircularMarkerWidenAnimation()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.comboBoxEditTextDirection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarPointSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarPointSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEditTextDirection
			' 
			Me.comboBoxEditTextDirection.TabIndex = 2
			' 
			' comboBoxEditMarkerKind
			' 
			Me.comboBoxEditMarkerKind.TabIndex = 1
			' 
			' comboBoxEditMarkerSize
			' 
			' 
			' comboBoxEditDiagramStyle
			' 
			' 
			' panel
			' 
			Me.panel.Size = New System.Drawing.Size(703, 66)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(617, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 5
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(703, 74)
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			radarDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			radarDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
			radarDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
			radarDiagram1.AxisX.Label.TextPattern = "{A:MMMM}"
			radarDiagram1.AxisY.Label.TextPattern = "{V}°C"
			radarDiagram1.AxisY.VisualRange.Auto = False
			radarDiagram1.AxisY.VisualRange.AutoSideMargins = False
			radarDiagram1.AxisY.VisualRange.MaxValueSerializable = "24.2"
			radarDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
			radarDiagram1.AxisY.VisualRange.SideMarginsValue = 0R
			radarDiagram1.AxisY.WholeRange.Auto = False
			radarDiagram1.AxisY.WholeRange.AutoSideMargins = False
			radarDiagram1.AxisY.WholeRange.MaxValueSerializable = "24.2"
			radarDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			radarDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			Me.chart.Diagram = radarDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Night (min)"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
			circularMarkerWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			radarPointSeriesView1.SeriesPointAnimation = circularMarkerWidenAnimation1
			series1.View = radarPointSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series2.Name = "Day (max)"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24})
			circularMarkerWidenAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			radarPointSeriesView2.SeriesPointAnimation = circularMarkerWidenAnimation2
			series2.View = radarPointSeriesView2
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			sideBySideBarSeriesLabel1.TextPattern = "{V:G2}"
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(703, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Average Temperature in London"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.weather.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
'			Me.chart.VisibleChanged += New System.EventHandler(Me.chart_VisibleChanged);
			' 
			' RadarPointDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "RadarPointDemo"
			Me.Size = New System.Drawing.Size(703, 500)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.comboBoxEditTextDirection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(radarDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(radarPointSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(radarPointSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
