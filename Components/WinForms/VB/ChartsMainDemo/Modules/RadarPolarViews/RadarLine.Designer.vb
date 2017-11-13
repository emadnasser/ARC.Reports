Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class RadarLineDemo
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
			Dim radarLineSeriesView1 As New DevExpress.XtraCharts.RadarLineSeriesView()
			Dim circularMarkerSlideAnimation1 As New DevExpress.XtraCharts.CircularMarkerSlideAnimation()
			Dim quinticEasingFunction1 As New DevExpress.XtraCharts.QuinticEasingFunction()
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
			Dim radarLineSeriesView2 As New DevExpress.XtraCharts.RadarLineSeriesView()
			Dim circularMarkerSlideAnimation2 As New DevExpress.XtraCharts.CircularMarkerSlideAnimation()
			Dim quinticEasingFunction2 As New DevExpress.XtraCharts.QuinticEasingFunction()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkEditShowMarkers = New DevExpress.XtraEditors.CheckEdit()
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
			CType(radarLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarLineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEditTextDirection
			' 
			Me.comboBoxEditTextDirection.TabIndex = 2
			' 
			' comboBoxEditMarkerKind
			' 
			' 
			' comboBoxEditMarkerSize
			' 
			' 
			' comboBoxEditDiagramStyle
			' 
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkEditShowMarkers)
			Me.panel.Size = New System.Drawing.Size(697, 66)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditDiagramStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditTextDirection, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowMarkers, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(595, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 6
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(697, 74)
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
			radarLineSeriesView1.LineMarkerOptions.Size = 8
			circularMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.CircularMarkerAnimationDirection.FromCenter
			quinticEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
			circularMarkerSlideAnimation1.EasingFunction = quinticEasingFunction1
			radarLineSeriesView1.SeriesPointAnimation = circularMarkerSlideAnimation1
			series1.View = radarLineSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series2.Name = "Day (max)"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24})
			radarLineSeriesView2.LineMarkerOptions.Size = 8
			circularMarkerSlideAnimation2.Direction = DevExpress.XtraCharts.CircularMarkerAnimationDirection.FromCenter
			quinticEasingFunction2.EasingMode = DevExpress.XtraCharts.EasingMode.Out
			circularMarkerSlideAnimation2.EasingFunction = quinticEasingFunction2
			radarLineSeriesView2.SeriesPointAnimation = circularMarkerSlideAnimation2
			series2.View = radarLineSeriesView2
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			sideBySideBarSeriesLabel1.TextPattern = "{V:G2}"
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(697, 426)
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
			' checkEditShowMarkers
			' 
			Me.checkEditShowMarkers.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditShowMarkers.Location = New System.Drawing.Point(599, 9)
			Me.checkEditShowMarkers.Margin = New System.Windows.Forms.Padding(0)
			Me.checkEditShowMarkers.Name = "checkEditShowMarkers"
			Me.checkEditShowMarkers.Properties.Caption = "Show markers"
			Me.checkEditShowMarkers.Size = New System.Drawing.Size(88, 19)
			Me.checkEditShowMarkers.TabIndex = 5
'			Me.checkEditShowMarkers.CheckedChanged += New System.EventHandler(Me.checkEditShowMarkers_CheckedChanged);
			' 
			' RadarLineDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "RadarLineDemo"
			Me.Size = New System.Drawing.Size(697, 500)
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
			CType(radarLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(radarLineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents checkEditShowMarkers As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
