Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RangeViews
	Partial Public Class SideBySideRangeBarDemo
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim rangeBarSeriesLabel1 As New DevExpress.XtraCharts.RangeBarSeriesLabel()
			Dim sideBySideRangeBarSeriesView1 As New DevExpress.XtraCharts.SideBySideRangeBarSeriesView()
			Dim barWidenAnimation1 As New DevExpress.XtraCharts.BarWidenAnimation()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim rangeBarSeriesLabel2 As New DevExpress.XtraCharts.RangeBarSeriesLabel()
			Dim sideBySideRangeBarSeriesView2 As New DevExpress.XtraCharts.SideBySideRangeBarSeriesView()
			Dim barWidenAnimation2 As New DevExpress.XtraCharts.BarWidenAnimation()
			Dim sideBySideRangeBarSeriesView3 As New DevExpress.XtraCharts.SideBySideRangeBarSeriesView()
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
			CType(rangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(rangeBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideRangeBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideRangeBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
			xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
			xyDiagram1.AxisX.Label.Staggered = True
			xyDiagram1.AxisX.Label.TextPattern = "{A:MMMM}"
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Label.TextPattern = "{V:N0}"
			xyDiagram1.AxisY.Title.Text = "$ per barrel"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Date"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.CrosshairLabelPattern = "Month: {A:MMMM}" & Constants.vbLf & "Min Price: ${V1:0.00}" & Constants.vbLf & "Max Price: ${V2:0.00}"
			rangeBarSeriesLabel1.Indent = 3
			rangeBarSeriesLabel1.TextPattern = "{V:F2}"
			series1.Label = rangeBarSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Europe Brent"
			series1.ToolTipPointPattern = "{S}" & Constants.vbLf & "Month: {A:MMMM}" & Constants.vbLf & "Min Price: ${V1:0.00}" & Constants.vbLf & "Max Price: ${V2:0.00}" & Constants.vbLf
			series1.ValueDataMembersSerializable = "Min;Max"
			barWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.2000000")
			sideBySideRangeBarSeriesView1.Animation = barWidenAnimation1
			series1.View = sideBySideRangeBarSeriesView1
			series2.ArgumentDataMember = "Date"
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			rangeBarSeriesLabel2.Indent = 3
			rangeBarSeriesLabel2.TextPattern = "{V:F2}"
			series2.Label = rangeBarSeriesLabel2
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series2.Name = "OK WTI"
			series2.ToolTipPointPattern = "{S}" & Constants.vbLf & "Month: {A:MMMM}" & Constants.vbLf & "Min Price: ${V1:0.00}" & Constants.vbLf & "Max Price: ${V2:0.00}" & Constants.vbLf
			series2.ValueDataMembersSerializable = "Min;Max"
			barWidenAnimation2.BeginTime = System.TimeSpan.Parse("00:00:00.1000000")
			barWidenAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.2000000")
			sideBySideRangeBarSeriesView2.Animation = barWidenAnimation2
			series2.View = sideBySideRangeBarSeriesView2
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chart.SeriesTemplate.View = sideBySideRangeBarSeriesView3
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Crude Oil Prices in 2015"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.eia.gov"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True
			' 
			' SideBySideRangeBarDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "SideBySideRangeBarDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(rangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(rangeBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideRangeBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideRangeBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
