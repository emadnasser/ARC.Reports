Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ViewCombinations
	Partial Public Class BarAndArea3dDemo
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
			Dim xyDiagram3D1 As New DevExpress.XtraCharts.XYDiagram3D()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim area3DSeriesLabel1 As New DevExpress.XtraCharts.Area3DSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2011, 12, 12, 0, 0, 0, 0), New Object() { (CObj(69.943R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2012, 12, 12, 0, 0, 0, 0), New Object() { (CObj(143.666R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2013, 12, 12, 0, 0, 0, 0), New Object() { (CObj(221.515R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2014, 12, 12, 0, 0, 0, 0), New Object() { (CObj(308.348R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2015, 12, 12, 0, 0, 0, 0), New Object() { (CObj(401.928R))})
			Dim area3DSeriesView1 As New DevExpress.XtraCharts.Area3DSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim bar3DSeriesLabel1 As New DevExpress.XtraCharts.Bar3DSeriesLabel()
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2011, 12, 12, 0, 0, 0, 0), New Object() { (CObj(69.943R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2012, 12, 12, 0, 0, 0, 0), New Object() { (CObj(73.723R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2013, 12, 12, 0, 0, 0, 0), New Object() { (CObj(77.849R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2014, 12, 12, 0, 0, 0, 0), New Object() { (CObj(86.833R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2015, 12, 12, 0, 0, 0, 0), New Object() { (CObj(93.58R))})
			Dim manhattanBarSeriesView1 As New DevExpress.XtraCharts.ManhattanBarSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.zoomTrackBarControl = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.lblZoomPercent = New DevExpress.XtraEditors.LabelControl()
			Me.lblHorizontalScrollPercent = New DevExpress.XtraEditors.LabelControl()
			Me.lblVerticalScrollPercent = New DevExpress.XtraEditors.LabelControl()
			Me.tbcHorizontalScrollPercent = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.tbcVerticalScrollPercent = New DevExpress.XtraEditors.ZoomTrackBarControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(area3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(area3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(manhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zoomTrackBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zoomTrackBarControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbcHorizontalScrollPercent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbcHorizontalScrollPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbcVerticalScrollPercent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbcVerticalScrollPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnDefaultAngles.Location = New System.Drawing.Point(581, 8)
			Me.btnDefaultAngles.Size = New System.Drawing.Size(107, 22)
			Me.btnDefaultAngles.TabIndex = 0
			Me.btnDefaultAngles.Text = "Restore Defaults"
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.zoomTrackBarControl)
			Me.panel.Controls.Add(Me.tbcVerticalScrollPercent)
			Me.panel.Controls.Add(Me.lblZoomPercent)
			Me.panel.Controls.Add(Me.tbcHorizontalScrollPercent)
			Me.panel.Controls.Add(Me.lblHorizontalScrollPercent)
			Me.panel.Controls.Add(Me.lblVerticalScrollPercent)
			Me.panel.Controls.SetChildIndex(Me.lblVerticalScrollPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.lblHorizontalScrollPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.tbcHorizontalScrollPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.lblZoomPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.tbcVerticalScrollPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.zoomTrackBarControl, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.TabIndex = 1
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram3D1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
			xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram3D1.AxisX.Label.TextPattern = "{A:yyyy}"
			xyDiagram3D1.AxisY.Label.TextPattern = "${V}M"
			xyDiagram3D1.RotationMatrixSerializable = "0.866025403784439;0.171010071662834;-0.469846310392954;0;0;0.939692620785908;0.34" & "2020143325669;0;0.5;-0.296198132726024;0.813797681349374;0;0;0;0;1"
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.SeriesDistance = 0.1R
			xyDiagram3D1.VerticalScrollPercent = 5R
			xyDiagram3D1.ZoomPercent = 140
			Me.chart.Diagram = xyDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			area3DSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			series1.Label = area3DSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			series1.Name = "Summary"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
			series1.View = area3DSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			bar3DSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			series2.Label = bar3DSeriesLabel1
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			series2.Name = "Annual"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10})
			manhattanBarSeriesView1.BarDepth = 0.9R
			manhattanBarSeriesView1.Transparency = (CByte(100))
			series2.View = manhattanBarSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "Microsoft Corp. Annual Revenue"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.microsoft.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
'			Me.chart.Scroll3D += New DevExpress.XtraCharts.ChartScroll3DEventHandler(Me.chart_Scroll3D);
'			Me.chart.Zoom3D += New DevExpress.XtraCharts.ChartZoom3DEventHandler(Me.chart_Zoom3D);
			' 
			' zoomTrackBarControl
			' 
			Me.zoomTrackBarControl.EditValue = 100
			Me.zoomTrackBarControl.Location = New System.Drawing.Point(12, 32)
			Me.zoomTrackBarControl.Name = "zoomTrackBarControl"
			Me.zoomTrackBarControl.Properties.HighlightSelectedRange = False
			Me.zoomTrackBarControl.Properties.LargeChange = 25
			Me.zoomTrackBarControl.Properties.Maximum = 500
			Me.zoomTrackBarControl.Properties.Middle = 250
			Me.zoomTrackBarControl.Properties.Minimum = 1
			Me.zoomTrackBarControl.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.zoomTrackBarControl.Properties.ShowValueToolTip = True
			Me.zoomTrackBarControl.Properties.SmallChange = 10
			Me.zoomTrackBarControl.Size = New System.Drawing.Size(120, 23)
			Me.zoomTrackBarControl.TabIndex = 0
			Me.zoomTrackBarControl.Value = 100
'			Me.zoomTrackBarControl.EditValueChanged += New System.EventHandler(Me.zoomTrackBarControl_EditValueChanged);
			' 
			' lblZoomPercent
			' 
			Me.lblZoomPercent.Location = New System.Drawing.Point(56, 12)
			Me.lblZoomPercent.Name = "lblZoomPercent"
			Me.lblZoomPercent.Size = New System.Drawing.Size(30, 13)
			Me.lblZoomPercent.TabIndex = 5
			Me.lblZoomPercent.Text = "Zoom:"
			' 
			' lblHorizontalScrollPercent
			' 
			Me.lblHorizontalScrollPercent.Location = New System.Drawing.Point(169, 12)
			Me.lblHorizontalScrollPercent.Name = "lblHorizontalScrollPercent"
			Me.lblHorizontalScrollPercent.Size = New System.Drawing.Size(80, 13)
			Me.lblHorizontalScrollPercent.TabIndex = 6
			Me.lblHorizontalScrollPercent.Text = "Horizontal Scroll:"
			' 
			' lblVerticalScrollPercent
			' 
			Me.lblVerticalScrollPercent.Location = New System.Drawing.Point(314, 12)
			Me.lblVerticalScrollPercent.Name = "lblVerticalScrollPercent"
			Me.lblVerticalScrollPercent.Size = New System.Drawing.Size(67, 13)
			Me.lblVerticalScrollPercent.TabIndex = 7
			Me.lblVerticalScrollPercent.Text = "Vertical Scroll:"
			' 
			' tbcHorizontalScrollPercent
			' 
			Me.tbcHorizontalScrollPercent.EditValue = 0
			Me.tbcHorizontalScrollPercent.Location = New System.Drawing.Point(150, 32)
			Me.tbcHorizontalScrollPercent.Name = "tbcHorizontalScrollPercent"
			Me.tbcHorizontalScrollPercent.Properties.HighlightSelectedRange = False
			Me.tbcHorizontalScrollPercent.Properties.Maximum = 100
			Me.tbcHorizontalScrollPercent.Properties.Middle = 0
			Me.tbcHorizontalScrollPercent.Properties.Minimum = -100
			Me.tbcHorizontalScrollPercent.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.tbcHorizontalScrollPercent.Properties.SmallChange = 10
			Me.tbcHorizontalScrollPercent.Size = New System.Drawing.Size(120, 23)
			Me.tbcHorizontalScrollPercent.TabIndex = 1
			Me.tbcHorizontalScrollPercent.Value = 0
'			Me.tbcHorizontalScrollPercent.EditValueChanged += New System.EventHandler(Me.tbcHorizontalScrollPercent_EditValueChanged);
			' 
			' tbcVerticalScrollPercent
			' 
			Me.tbcVerticalScrollPercent.EditValue = 0
			Me.tbcVerticalScrollPercent.Location = New System.Drawing.Point(288, 32)
			Me.tbcVerticalScrollPercent.Name = "tbcVerticalScrollPercent"
			Me.tbcVerticalScrollPercent.Properties.HighlightSelectedRange = False
			Me.tbcVerticalScrollPercent.Properties.LargeChange = 50
			Me.tbcVerticalScrollPercent.Properties.Maximum = 100
			Me.tbcVerticalScrollPercent.Properties.Middle = 0
			Me.tbcVerticalScrollPercent.Properties.Minimum = -100
			Me.tbcVerticalScrollPercent.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.tbcVerticalScrollPercent.Properties.SmallChange = 10
			Me.tbcVerticalScrollPercent.Size = New System.Drawing.Size(120, 23)
			Me.tbcVerticalScrollPercent.TabIndex = 8
			Me.tbcVerticalScrollPercent.Value = 0
'			Me.tbcVerticalScrollPercent.EditValueChanged += New System.EventHandler(Me.tbcVerticalScrollPercent_EditValueChanged);
			' 
			' BarAndArea3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "BarAndArea3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(area3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(area3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(manhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zoomTrackBarControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zoomTrackBarControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbcHorizontalScrollPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbcHorizontalScrollPercent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbcVerticalScrollPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbcVerticalScrollPercent, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private WithEvents zoomTrackBarControl As DevExpress.XtraEditors.ZoomTrackBarControl
		Private lblVerticalScrollPercent As DevExpress.XtraEditors.LabelControl
		Private lblZoomPercent As DevExpress.XtraEditors.LabelControl
		Private lblHorizontalScrollPercent As DevExpress.XtraEditors.LabelControl
		Private WithEvents tbcHorizontalScrollPercent As DevExpress.XtraEditors.ZoomTrackBarControl
		Private WithEvents tbcVerticalScrollPercent As DevExpress.XtraEditors.ZoomTrackBarControl
	End Class
End Namespace
