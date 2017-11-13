Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class StackedStepAreaDemo
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
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 1, 1, 0, 0, 0, 0), New Object() { (CObj(13R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 2, 1, 0, 0, 0, 0), New Object() { (CObj(16R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 3, 1, 0, 0, 0, 0), New Object() { (CObj(12R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 4, 1, 0, 0, 0, 0), New Object() { (CObj(23R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 5, 1, 0, 0, 0, 0), New Object() { (CObj(19R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 6, 1, 0, 0, 0, 0), New Object() { (CObj(19R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 7, 1, 0, 0, 0, 0), New Object() { (CObj(7R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 8, 1, 0, 0, 0, 0), New Object() { (CObj(34R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 9, 1, 0, 0, 0, 0), New Object() { (CObj(21R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 10, 1, 0, 0, 0, 0), New Object() { (CObj(9R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 1, 0, 0, 0, 0), New Object() { (CObj(5R))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 12, 1, 0, 0, 0, 0), New Object() { (CObj(3R))})
			Dim stackedStepAreaSeriesView1 As New DevExpress.XtraCharts.StackedStepAreaSeriesView()
			Dim xySeriesBlowUpAnimation1 As New DevExpress.XtraCharts.XYSeriesBlowUpAnimation()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 1, 1, 0, 0, 0, 0), New Object() { (CObj(120R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 2, 1, 0, 0, 0, 0), New Object() { (CObj(101R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 3, 1, 0, 0, 0, 0), New Object() { (CObj(91R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 4, 1, 0, 0, 0, 0), New Object() { (CObj(85R))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 5, 1, 0, 0, 0, 0), New Object() { (CObj(101R))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 6, 1, 0, 0, 0, 0), New Object() { (CObj(143R))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 7, 1, 0, 0, 0, 0), New Object() { (CObj(145R))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 8, 1, 0, 0, 0, 0), New Object() { (CObj(150R))})
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 9, 1, 0, 0, 0, 0), New Object() { (CObj(111R))})
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 10, 1, 0, 0, 0, 0), New Object() { (CObj(134R))})
			Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 1, 0, 0, 0, 0), New Object() { (CObj(107R))})
			Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 12, 1, 0, 0, 0, 0), New Object() { (CObj(103R))})
			Dim stackedStepAreaSeriesView2 As New DevExpress.XtraCharts.StackedStepAreaSeriesView()
			Dim xySeriesBlowUpAnimation2 As New DevExpress.XtraCharts.XYSeriesBlowUpAnimation()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint25 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 1, 1, 0, 0, 0, 0), New Object() { (CObj(47R))})
			Dim seriesPoint26 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 2, 1, 0, 0, 0, 0), New Object() { (CObj(77R))})
			Dim seriesPoint27 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 3, 1, 0, 0, 0, 0), New Object() { (CObj(45R))})
			Dim seriesPoint28 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 4, 1, 0, 0, 0, 0), New Object() { (CObj(49R))})
			Dim seriesPoint29 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 5, 1, 0, 0, 0, 0), New Object() { (CObj(63R))})
			Dim seriesPoint30 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 6, 1, 0, 0, 0, 0), New Object() { (CObj(58R))})
			Dim seriesPoint31 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 7, 1, 0, 0, 0, 0), New Object() { (CObj(56R))})
			Dim seriesPoint32 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 8, 1, 0, 0, 0, 0), New Object() { (CObj(77R))})
			Dim seriesPoint33 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 9, 1, 0, 0, 0, 0), New Object() { (CObj(105R))})
			Dim seriesPoint34 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 10, 1, 0, 0, 0, 0), New Object() { (CObj(80R))})
			Dim seriesPoint35 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 1, 0, 0, 0, 0), New Object() { (CObj(91R))})
			Dim seriesPoint36 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 12, 1, 0, 0, 0, 0), New Object() { (CObj(89R))})
			Dim stackedStepAreaSeriesView3 As New DevExpress.XtraCharts.StackedStepAreaSeriesView()
			Dim xySeriesBlowUpAnimation3 As New DevExpress.XtraCharts.XYSeriesBlowUpAnimation()
			Dim stackedStepAreaSeriesView4 As New DevExpress.XtraCharts.StackedStepAreaSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.checkEditInverted = New DevExpress.XtraEditors.CheckEdit()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.checkEditInverted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedStepAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedStepAreaSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedStepAreaSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedStepAreaSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkEditInverted)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditInverted, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
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
			' checkEditInverted
			' 
			Me.checkEditInverted.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditInverted.EditValue = True
			Me.checkEditInverted.Location = New System.Drawing.Point(493, 9)
			Me.checkEditInverted.Name = "checkEditInverted"
			Me.checkEditInverted.Properties.Caption = "Inverted Steps"
			Me.checkEditInverted.Size = New System.Drawing.Size(100, 19)
			Me.checkEditInverted.TabIndex = 2
'			Me.checkEditInverted.CheckedChanged += New System.EventHandler(Me.checkEditInverted_CheckedChanged);
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
			xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
			xyDiagram1.AxisX.Label.Staggered = True
			xyDiagram1.AxisX.Label.TextPattern = "{A:MMMM}"
			xyDiagram1.AxisX.Title.Text = "Month"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0.5R
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Title.Text = "Count"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.Name = "Negative"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
			stackedStepAreaSeriesView1.SeriesAnimation = xySeriesBlowUpAnimation1
			series1.View = stackedStepAreaSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series2.Name = "Neutral"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24})
			xySeriesBlowUpAnimation2.BeginTime = System.TimeSpan.Parse("00:00:00.3000000")
			stackedStepAreaSeriesView2.SeriesAnimation = xySeriesBlowUpAnimation2
			series2.View = stackedStepAreaSeriesView2
			series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series3.Name = "Positive"
			series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32, seriesPoint33, seriesPoint34, seriesPoint35, seriesPoint36})
			xySeriesBlowUpAnimation3.BeginTime = System.TimeSpan.Parse("00:00:00.6000000")
			stackedStepAreaSeriesView3.SeriesAnimation = xySeriesBlowUpAnimation3
			series3.View = stackedStepAreaSeriesView3
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
			Me.chart.SeriesSorting = DevExpress.XtraCharts.SortingMode.Descending
			Me.chart.SeriesTemplate.View = stackedStepAreaSeriesView4
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			Me.chart.TabStop = False
			chartTitle1.Text = "Statistics Comments in the Past Month"
			chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' StackedStepAreaDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "StackedStepAreaDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.checkEditInverted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedStepAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedStepAreaSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedStepAreaSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedStepAreaSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As DevExpress.XtraCharts.ChartControl
		Private WithEvents checkEditInverted As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
	End Class
End Namespace
