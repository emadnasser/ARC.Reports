Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class LineDemo
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
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (CObj(546R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (CObj(605R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (CObj(656R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (CObj(694R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (CObj(721R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (CObj(730R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (CObj(728R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (CObj(721R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (CObj(704R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (CObj(680R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (CObj(650R))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim xySeriesUnwindAnimation1 As New DevExpress.XtraCharts.XYSeriesUnwindAnimation()
			Dim xyMarkerSlideAnimation1 As New DevExpress.XtraCharts.XYMarkerSlideAnimation()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (CObj(332R))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (CObj(417R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (CObj(513R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (CObj(614R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (CObj(721R))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (CObj(836R))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (CObj(935R))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (CObj(1027R))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (CObj(1110R))})
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (CObj(1178R))})
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (CObj(1231R))})
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Dim xySeriesUnwindAnimation2 As New DevExpress.XtraCharts.XYSeriesUnwindAnimation()
			Dim xyMarkerWidenAnimation1 As New DevExpress.XtraCharts.XYMarkerWidenAnimation()
			Dim linearEasingFunction1 As New DevExpress.XtraCharts.LinearEasingFunction()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (CObj(227R))})
			Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (CObj(283R))})
			Dim seriesPoint25 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (CObj(361R))})
			Dim seriesPoint26 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (CObj(471R))})
			Dim seriesPoint27 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (CObj(623R))})
			Dim seriesPoint28 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (CObj(797R))})
			Dim seriesPoint29 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (CObj(982R))})
			Dim seriesPoint30 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (CObj(1189R))})
			Dim seriesPoint31 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (CObj(1416R))})
			Dim seriesPoint32 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (CObj(1665R))})
			Dim seriesPoint33 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (CObj(1937R))})
			Dim lineSeriesView3 As New DevExpress.XtraCharts.LineSeriesView()
			Dim xySeriesUnwindAnimation3 As New DevExpress.XtraCharts.XYSeriesUnwindAnimation()
			Dim xyMarkerSlideAnimation2 As New DevExpress.XtraCharts.XYMarkerSlideAnimation()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' checkEditShowMarkers
			' 
			' 
			' comboBoxEditMarkerKind
			' 
			Me.comboBoxEditMarkerKind.TabIndex = 0
			' 
			' comboBoxEditLabelAngle
			' 
			Me.comboBoxEditLabelAngle.TabIndex = 2
			Me.comboBoxEditLabelAngle.Visible = False
			' 
			' comboBoxEditMarkerSize
			' 
			Me.comboBoxEditMarkerSize.TabIndex = 1
			' 
			' labelAngle
			' 
			Me.labelAngle.Visible = False
			' 
			' checkEditShowLabels
			' 
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.Title.Text = "Years"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Title.Text = "Population mid-year, millions"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			pointSeriesLabel1.BackColor = System.Drawing.Color.Transparent
			pointSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel1.LineLength = 5
			pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint
			series1.Label = pointSeriesLabel1
			series1.Name = "Europe"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11})
			lineSeriesView1.LineMarkerOptions.Size = 8
			lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
			xySeriesUnwindAnimation1.Duration = System.TimeSpan.Parse("00:00:01.4000000")
			lineSeriesView1.SeriesAnimation = xySeriesUnwindAnimation1
			xyMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromTop
			xyMarkerSlideAnimation1.Duration = System.TimeSpan.Parse("00:00:00.8000000")
			lineSeriesView1.SeriesPointAnimation = xyMarkerSlideAnimation1
			series1.View = lineSeriesView1
			pointSeriesLabel2.BackColor = System.Drawing.Color.Transparent
			pointSeriesLabel2.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel2.LineLength = 5
			pointSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint
			series2.Label = pointSeriesLabel2
			series2.Name = "Americas"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22})
			lineSeriesView2.LineMarkerOptions.Size = 8
			lineSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
			xySeriesUnwindAnimation2.BeginTime = System.TimeSpan.Parse("00:00:00.5000000")
			xySeriesUnwindAnimation2.Duration = System.TimeSpan.Parse("00:00:00.8000000")
			lineSeriesView2.SeriesAnimation = xySeriesUnwindAnimation2
			xyMarkerWidenAnimation1.BeginTime = System.TimeSpan.Parse("00:00:00.5000000")
			xyMarkerWidenAnimation1.Duration = System.TimeSpan.Parse("00:00:00.6000000")
			xyMarkerWidenAnimation1.EasingFunction = linearEasingFunction1
			lineSeriesView2.SeriesPointAnimation = xyMarkerWidenAnimation1
			series2.View = lineSeriesView2
			pointSeriesLabel3.Angle = -45
			pointSeriesLabel3.BackColor = System.Drawing.Color.Transparent
			pointSeriesLabel3.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel3.LineLength = 5
			pointSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint
			series3.Label = pointSeriesLabel3
			series3.Name = "Africa"
			series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32, seriesPoint33})
			lineSeriesView3.LineMarkerOptions.Size = 8
			lineSeriesView3.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
			xySeriesUnwindAnimation3.BeginTime = System.TimeSpan.Parse("00:00:01")
			xySeriesUnwindAnimation3.Duration = System.TimeSpan.Parse("00:00:00.8000000")
			lineSeriesView3.SeriesAnimation = xySeriesUnwindAnimation3
			xyMarkerSlideAnimation2.BeginTime = System.TimeSpan.Parse("00:00:01")
			xyMarkerSlideAnimation2.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromBottom
			xyMarkerSlideAnimation2.Duration = System.TimeSpan.Parse("00:00:00.8000000")
			lineSeriesView3.SeriesPointAnimation = xyMarkerSlideAnimation2
			series3.View = lineSeriesView3
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Historic, Current and Future Population "
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.geohive.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
'			Me.chart.VisibleChanged += New System.EventHandler(Me.chart_VisibleChanged);
			' 
			' LineDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "LineDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
