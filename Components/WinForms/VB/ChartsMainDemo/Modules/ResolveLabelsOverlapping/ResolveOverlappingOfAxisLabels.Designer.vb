Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping
	Partial Public Class ResolveOverlappingOfAxisLabelsDemo
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 6, 0, 0, 0), New Object() { (CObj(69R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 3, 0, 0, 0), New Object() { (CObj(76R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 0, 0, 0, 0), New Object() { (CObj(66R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 21, 0, 0, 0), New Object() { (CObj(49R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 18, 0, 0, 0), New Object() { (CObj(45R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 15, 0, 0, 0), New Object() { (CObj(48R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 12, 0, 0, 0), New Object() { (CObj(57R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 9, 0, 0, 0), New Object() { (CObj(66R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 6, 0, 0, 0), New Object() { (CObj(78R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 3, 0, 0, 0), New Object() { (CObj(83R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 0, 0, 0, 0), New Object() { (CObj(72R))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 21, 0, 0, 0), New Object() { (CObj(52R))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 18, 0, 0, 0), New Object() { (CObj(40R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 15, 0, 0, 0), New Object() { (CObj(41R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 12, 0, 0, 0), New Object() { (CObj(37R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 9, 0, 0, 0), New Object() { (CObj(41R))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 6, 0, 0, 0), New Object() { (CObj(68R))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 3, 0, 0, 0), New Object() { (CObj(78R))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 0, 0, 0, 0), New Object() { (CObj(71R))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 21, 0, 0, 0), New Object() { (CObj(63R))})
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 18, 0, 0, 0), New Object() { (CObj(47R))})
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 15, 0, 0, 0), New Object() { (CObj(44R))})
			Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 12, 0, 0, 0), New Object() { (CObj(48R))})
			Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 9, 0, 0, 0), New Object() { (CObj(68R))})
			Dim seriesPoint25 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 6, 0, 0, 0), New Object() { (CObj(81R))})
			Dim seriesPoint26 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 3, 0, 0, 0), New Object() { (CObj(85R))})
			Dim seriesPoint27 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 0, 0, 0, 0), New Object() { (CObj(76R))})
			Dim seriesPoint28 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 21, 0, 0, 0), New Object() { (CObj(65R))})
			Dim seriesPoint29 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 18, 0, 0, 0), New Object() { (CObj(57R))})
			Dim seriesPoint30 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 15, 0, 0, 0), New Object() { (CObj(62R))})
			Dim seriesPoint31 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 12, 0, 0, 0), New Object() { (CObj(53R))})
			Dim seriesPoint32 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 9, 0, 0, 0), New Object() { (CObj(62R))})
			Dim seriesPoint33 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 6, 0, 0, 0), New Object() { (CObj(76R))})
			Dim seriesPoint34 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 3, 0, 0, 0), New Object() { (CObj(80R))})
			Dim seriesPoint35 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 0, 0, 0, 0), New Object() { (CObj(82R))})
			Dim seriesPoint36 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 21, 0, 0, 0), New Object() { (CObj(73R))})
			Dim seriesPoint37 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 18, 0, 0, 0), New Object() { (CObj(57R))})
			Dim seriesPoint38 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 15, 0, 0, 0), New Object() { (CObj(55R))})
			Dim seriesPoint39 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 12, 0, 0, 0), New Object() { (CObj(64R))})
			Dim seriesPoint40 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 9, 0, 0, 0), New Object() { (CObj(74R))})
			Dim seriesPoint41 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 6, 0, 0, 0), New Object() { (CObj(89R))})
			Dim seriesPoint42 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 3, 0, 0, 0), New Object() { (CObj(87R))})
			Dim seriesPoint43 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 0, 0, 0, 0), New Object() { (CObj(80R))})
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkEditResolveOverlapping = New DevExpress.XtraEditors.CheckEdit()
			Me.labelIndent = New DevExpress.XtraEditors.LabelControl()
			Me.spinIndent = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditResolveOverlapping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.spinIndent)
			Me.panel.Controls.Add(Me.labelIndent)
			Me.panel.Controls.Add(Me.checkEditResolveOverlapping)
			Me.panel.Size = New System.Drawing.Size(697, 40)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditResolveOverlapping, 0)
			Me.panel.Controls.SetChildIndex(Me.labelIndent, 0)
			Me.panel.Controls.SetChildIndex(Me.spinIndent, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(599, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(697, 48)
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.AxisLabelsResolveOverlappingMinIndent = 0
			xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour
			xyDiagram1.AxisX.DateTimeScaleOptions.GridSpacing = 6R
			xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.Label.TextPattern = "{A:dd/MM HH:mm}"
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.VisualRange.Auto = False
			xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "06/09/2008 09:00:00.000"
			xyDiagram1.AxisX.VisualRange.MinValueSerializable = "06/06/2008 00:00:00.000"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Text = "Humidity, %"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisualRange.Auto = False
			xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "120"
			xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			xyDiagram1.AxisY.WholeRange.Auto = False
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "120"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			xyDiagram1.DefaultPane.ScrollBarOptions.YAxisScrollBarVisible = False
			xyDiagram1.DefaultPane.Weight = 2R
			xyDiagram1.EnableAxisXScrolling = True
			xyDiagram1.PaneDistance = 4
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Location = New System.Drawing.Point(0, 48)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Center
			series1.Label = sideBySideBarSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Relative humidity (%)"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32, seriesPoint33, seriesPoint34, seriesPoint35, seriesPoint36, seriesPoint37, seriesPoint38, seriesPoint39, seriesPoint40, seriesPoint41, seriesPoint42, seriesPoint43})
			sideBySideBarSeriesView1.BarWidth = 1.5R
			series1.View = sideBySideBarSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(697, 452)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Weather in London"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' checkEditResolveOverlapping
			' 
			Me.checkEditResolveOverlapping.Location = New System.Drawing.Point(10, 10)
			Me.checkEditResolveOverlapping.Name = "checkEditResolveOverlapping"
			Me.checkEditResolveOverlapping.Properties.Caption = "Resolve Overlapping"
			Me.checkEditResolveOverlapping.Size = New System.Drawing.Size(122, 19)
			Me.checkEditResolveOverlapping.TabIndex = 54
'			Me.checkEditResolveOverlapping.CheckedChanged += New System.EventHandler(Me.checkEditResolveOverlapping_CheckedChanged);
			' 
			' labelIndent
			' 
			Me.labelIndent.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.labelIndent.Location = New System.Drawing.Point(138, 13)
			Me.labelIndent.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
			Me.labelIndent.Name = "labelIndent"
			Me.labelIndent.Size = New System.Drawing.Size(36, 13)
			Me.labelIndent.TabIndex = 55
			Me.labelIndent.Text = "Indent:"
			' 
			' spinIndent
			' 
			Me.spinIndent.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinIndent.Location = New System.Drawing.Point(177, 10)
			Me.spinIndent.Name = "spinIndent"
			Me.spinIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinIndent.Properties.IsFloatValue = False
			Me.spinIndent.Properties.Mask.EditMask = "N00"
			Me.spinIndent.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinIndent.Properties.MinValue = New Decimal(New Integer() { 10, 0, 0, -2147483648})
			Me.spinIndent.Properties.ValidateOnEnterKey = True
			Me.spinIndent.Size = New System.Drawing.Size(58, 20)
			Me.spinIndent.TabIndex = 56
'			Me.spinIndent.EditValueChanged += New System.EventHandler(Me.spinIndent_EditValueChanged);
			' 
			' ResolveOverlappingOfAxisLabelsDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ResolveOverlappingOfAxisLabelsDemo"
			Me.Size = New System.Drawing.Size(697, 500)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditResolveOverlapping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private WithEvents checkEditResolveOverlapping As DevExpress.XtraEditors.CheckEdit
		Protected labelIndent As DevExpress.XtraEditors.LabelControl
		Protected WithEvents spinIndent As DevExpress.XtraEditors.SpinEdit
	End Class
End Namespace
