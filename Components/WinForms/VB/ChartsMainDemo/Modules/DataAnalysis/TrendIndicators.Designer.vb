Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class TrendIndicatorsDemo
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim textAnnotation1 As New DevExpress.XtraCharts.TextAnnotation()
			Dim paneAnchorPoint1 As New DevExpress.XtraCharts.PaneAnchorPoint()
			Dim relativePosition1 As New DevExpress.XtraCharts.RelativePosition()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim xyDiagramPane1 As New DevExpress.XtraCharts.XYDiagramPane()
			Dim xyDiagramPane2 As New DevExpress.XtraCharts.XYDiagramPane()
			Dim secondaryAxisY1 As New DevExpress.XtraCharts.SecondaryAxisY()
			Dim constantLine1 As New DevExpress.XtraCharts.ConstantLine()
			Dim constantLine2 As New DevExpress.XtraCharts.ConstantLine()
			Dim secondaryAxisY2 As New DevExpress.XtraCharts.SecondaryAxisY()
			Dim legend1 As New DevExpress.XtraCharts.Legend()
			Dim legend2 As New DevExpress.XtraCharts.Legend()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim stockSeriesLabel1 As New DevExpress.XtraCharts.StockSeriesLabel()
			Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
			Dim bollingerBands1 As New DevExpress.XtraCharts.BollingerBands()
			Dim massIndex1 As New DevExpress.XtraCharts.MassIndex()
			Dim standardDeviation1 As New DevExpress.XtraCharts.StandardDeviation()
			Dim stockSeriesView2 As New DevExpress.XtraCharts.StockSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(textAnnotation1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagramPane2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisY2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bollingerBands1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(massIndex1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(standardDeviation1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Size = New System.Drawing.Size(703, 66)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(702, 12)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(703, 74)
			Me.panelRoot.Visible = False
			' 
			' chart
			' 
			paneAnchorPoint1.AxisXCoordinate.AxisValueSerializable = ""
			paneAnchorPoint1.AxisYCoordinate.AxisValueSerializable = ""
			paneAnchorPoint1.PaneName = "StDevPane"
			textAnnotation1.AnchorPoint = paneAnchorPoint1
			textAnnotation1.Name = "Text Annotation 1"
			textAnnotation1.ShapePosition = relativePosition1
			Me.chart.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() { textAnnotation1})
			Me.chart.CrosshairOptions.ShowOnlyInFocusedPane = False
			xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOnly = True
			xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOptions.Holidays.AddRange(New DevExpress.XtraCharts.KnownDate() { New DevExpress.XtraCharts.KnownDate("Christmas Day", New System.DateTime(2007, 12, 25, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("New Year's Day", New System.DateTime(2008, 1, 1, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("Martin Luther King Day", New System.DateTime(2008, 1, 21, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("Presidents' Day", New System.DateTime(2008, 2, 18, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("Good Friday", New System.DateTime(2008, 3, 21, 0, 0, 0, 0))})
			xyDiagram1.AxisX.GridLines.MinorVisible = True
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.Label.TextPattern = "{A: d}"
			xyDiagram1.AxisX.Title.Text = ""
			xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "1"
			xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Text = "US Dollars"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0.5R
			xyDiagram1.DefaultPane.Weight = 2R
			xyDiagramPane1.Name = "MassIndexPane"
			xyDiagramPane1.PaneID = 0
			xyDiagramPane2.Name = "StDevPane"
			xyDiagramPane2.PaneID = 1
			xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1, xyDiagramPane2})
			secondaryAxisY1.AxisID = 0
			constantLine1.AxisValueSerializable = "26.5"
			constantLine1.Name = "26.5"
			constantLine1.ShowInLegend = False
			constantLine1.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far
			constantLine1.Title.ShowBelowLine = True
			constantLine2.AxisValueSerializable = "27"
			constantLine2.Name = "27"
			constantLine2.ShowInLegend = False
			constantLine2.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far
			secondaryAxisY1.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() { constantLine1, constantLine2})
			secondaryAxisY1.GridLines.MinorVisible = True
			secondaryAxisY1.GridLines.Visible = True
			secondaryAxisY1.Name = "MassIndexAxisY"
			secondaryAxisY1.Title.Text = "Mass Index"
			secondaryAxisY1.VisibleInPanesSerializable = "0"
			secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = False
			secondaryAxisY2.AxisID = 1
			secondaryAxisY2.GridLines.MinorVisible = True
			secondaryAxisY2.GridLines.Visible = True
			secondaryAxisY2.Name = "StDevAxisY"
			secondaryAxisY2.VisibleInPanesSerializable = "1"
			xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1, secondaryAxisY2})
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
			legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			legend1.DockTargetName = "MassIndexPane"
			legend1.Name = "Legend1"
			legend2.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			legend2.DockTargetName = "StDevPane"
			legend2.Name = "Legend2"
			Me.chart.Legends.AddRange(New DevExpress.XtraCharts.Legend() { legend1, legend2})
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "DateTimeArgument"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			series1.Label = stockSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "USDJPY Daily"
			series1.ValueDataMembersSerializable = "LowValue;HighValue;OpenValue;CloseValue"
			bollingerBands1.Name = "Bollinger Bands"
			bollingerBands1.ShowInLegend = True
			massIndex1.AxisYName = "MassIndexAxisY"
			massIndex1.LegendName = "Legend1"
			massIndex1.LineStyle.Thickness = 2
			massIndex1.Name = "Mass Index"
			massIndex1.PaneName = "MassIndexPane"
			massIndex1.ShowInLegend = True
			standardDeviation1.AxisYName = "StDevAxisY"
			standardDeviation1.LegendName = "Legend2"
			standardDeviation1.LineStyle.Thickness = 2
			standardDeviation1.Name = "Standard Deviation"
			standardDeviation1.PaneName = "StDevPane"
			standardDeviation1.ShowInLegend = True
			stockSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() { bollingerBands1, massIndex1, standardDeviation1})
			stockSeriesView1.LevelLineLength = 0.3R
			series1.View = stockSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.View = stockSeriesView2
			Me.chart.Size = New System.Drawing.Size(703, 426)
			Me.chart.TabIndex = 3
			chartTitle1.Text = "USDJPY Daily"
			chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' TrendIndicatorsDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "TrendIndicatorsDemo"
			Me.Size = New System.Drawing.Size(703, 500)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(textAnnotation1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagramPane2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(secondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(secondaryAxisY2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bollingerBands1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(massIndex1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(standardDeviation1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
	End Class
End Namespace
