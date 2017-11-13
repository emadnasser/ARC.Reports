Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ViewCombinations
	Partial Public Class BarAndLine2dDemo
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
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2011, 12, 12, 0, 0, 0, 0), New Object() { (CObj(69.943R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2012, 12, 12, 0, 0, 0, 0), New Object() { (CObj(73.723R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2013, 12, 12, 0, 0, 0, 0), New Object() { (CObj(77.849R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2014, 12, 12, 0, 0, 0, 0), New Object() { (CObj(86.833R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2015, 12, 12, 0, 0, 0, 0), New Object() { (CObj(93.58R))})
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim barGrowUpAnimation1 As New DevExpress.XtraCharts.BarGrowUpAnimation()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2011, 12, 12, 0, 0, 0, 0), New Object() { (CObj(69.943R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2012, 12, 12, 0, 0, 0, 0), New Object() { (CObj(143.666R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2013, 12, 12, 0, 0, 0, 0), New Object() { (CObj(221.515R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2014, 12, 12, 0, 0, 0, 0), New Object() { (CObj(308.348R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2015, 12, 12, 0, 0, 0, 0), New Object() { (CObj(401.928R))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim xySeriesUnwindAnimation1 As New DevExpress.XtraCharts.XYSeriesUnwindAnimation()
			Dim xyMarkerWidenAnimation1 As New DevExpress.XtraCharts.XYMarkerWidenAnimation()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.chart.CrosshairOptions.GroupHeaderPattern = "{A:yyyy}"
			Me.chart.CrosshairOptions.GroupHeaderTextOptions.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
			xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Label.TextPattern = "{A:yyyy}"
			xyDiagram1.AxisX.Title.Text = "Years"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Text = "Millions of Dollars"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			sideBySideBarSeriesLabel1.TextPattern = "{V:F2}"
			series1.Label = sideBySideBarSeriesLabel1
			series1.Name = "Annual"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
			barGrowUpAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			sideBySideBarSeriesView1.Animation = barGrowUpAnimation1
			series1.View = sideBySideBarSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			pointSeriesLabel1.Angle = 70
			pointSeriesLabel1.LineLength = 30
			pointSeriesLabel1.TextPattern = "{V:F2}"
			series2.Label = pointSeriesLabel1
			series2.Name = "Summary"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10})
			lineSeriesView1.LineMarkerOptions.Size = 20
			xySeriesUnwindAnimation1.BeginTime = System.TimeSpan.Parse("00:00:00.8000000")
			lineSeriesView1.SeriesAnimation = xySeriesUnwindAnimation1
			xyMarkerWidenAnimation1.BeginTime = System.TimeSpan.Parse("00:00:01")
			lineSeriesView1.SeriesPointAnimation = xyMarkerWidenAnimation1
			series2.View = lineSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			sideBySideBarSeriesLabel2.TextPattern = "{V:YYYY}"
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Microsoft Corp. Annual Revenue"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.microsoft.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' BarAndLine2dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "BarAndLine2dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
