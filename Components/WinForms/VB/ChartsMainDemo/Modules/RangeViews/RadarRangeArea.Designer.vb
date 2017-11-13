Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class RadarRangeAreaDemo
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
			Dim radarRangeAreaSeriesLabel1 As New DevExpress.XtraCharts.RadarRangeAreaSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() { (CObj(6R)), (CObj(2R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() { (CObj(7R)), (CObj(2R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() { (CObj(10R)), (CObj(3R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() { (CObj(14R)), (CObj(5R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() { (CObj(18R)), (CObj(8R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() { (CObj(21R)), (CObj(11R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() { (CObj(22R)), (CObj(13R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() { (CObj(22R)), (CObj(13R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() { (CObj(19R)), (CObj(11R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() { (CObj(15R)), (CObj(8R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() { (CObj(10R)), (CObj(5R))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() { (CObj(7R)), (CObj(3R))})
			Dim radarRangeAreaSeriesView1 As New DevExpress.XtraCharts.RadarRangeAreaSeriesView()
			Dim circularSeriesLinearUnwindAnimation1 As New DevExpress.XtraCharts.CircularSeriesLinearUnwindAnimation()
			Dim circularMarkerSlideAnimation1 As New DevExpress.XtraCharts.CircularMarkerSlideAnimation()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.comboBoxEditMinMarkerKind = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditMinMarkerSize = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelMinMarkerKind = New DevExpress.XtraEditors.LabelControl()
			Me.labelMinMarkerSize = New DevExpress.XtraEditors.LabelControl()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkEditShowMaxMarkers = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEditShowMinMarkers = New DevExpress.XtraEditors.CheckEdit()
			Me.labelMaxMarkerKind = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditMaxMarkerKind = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelMaxMarkerSize = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditMaxMarkerSize = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelLabelKind = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxLabelKind = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditTextDirection = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelTextDirection = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditDiagramStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelDiagramStyle = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.comboBoxEditMinMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMinMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarRangeAreaSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarRangeAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditShowMaxMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditShowMinMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMaxMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMaxMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxLabelKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditTextDirection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.comboBoxEditDiagramStyle)
			Me.panel.Controls.Add(Me.labelDiagramStyle)
			Me.panel.Controls.Add(Me.comboBoxEditTextDirection)
			Me.panel.Controls.Add(Me.labelTextDirection)
			Me.panel.Controls.Add(Me.comboBoxLabelKind)
			Me.panel.Controls.Add(Me.labelLabelKind)
			Me.panel.Controls.Add(Me.comboBoxEditMaxMarkerSize)
			Me.panel.Controls.Add(Me.labelMaxMarkerSize)
			Me.panel.Controls.Add(Me.comboBoxEditMaxMarkerKind)
			Me.panel.Controls.Add(Me.labelMaxMarkerKind)
			Me.panel.Controls.Add(Me.checkEditShowMinMarkers)
			Me.panel.Controls.Add(Me.checkEditShowMaxMarkers)
			Me.panel.Controls.Add(Me.labelMinMarkerSize)
			Me.panel.Controls.Add(Me.labelMinMarkerKind)
			Me.panel.Controls.Add(Me.comboBoxEditMinMarkerKind)
			Me.panel.Controls.Add(Me.comboBoxEditMinMarkerSize)
			Me.panel.Size = New System.Drawing.Size(697, 66)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMinMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMinMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMinMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMinMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowMaxMarkers, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowMinMarkers, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMaxMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMaxMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMaxMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMaxMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.labelLabelKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxLabelKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelTextDirection, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditTextDirection, 0)
			Me.panel.Controls.SetChildIndex(Me.labelDiagramStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditDiagramStyle, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(598, 38)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 57
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(697, 74)
			' 
			' comboBoxEditMinMarkerKind
			' 
			Me.comboBoxEditMinMarkerKind.EditValue = ""
			Me.comboBoxEditMinMarkerKind.Location = New System.Drawing.Point(171, 37)
			Me.comboBoxEditMinMarkerKind.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditMinMarkerKind.Name = "comboBoxEditMinMarkerKind"
			Me.comboBoxEditMinMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMinMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMinMarkerKind.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEditMinMarkerKind.TabIndex = 51
'			Me.comboBoxEditMinMarkerKind.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMinMarkerKind_SelectedIndexChanged);
			' 
			' comboBoxEditMinMarkerSize
			' 
			Me.comboBoxEditMinMarkerSize.EditValue = ""
			Me.comboBoxEditMinMarkerSize.Location = New System.Drawing.Point(311, 37)
			Me.comboBoxEditMinMarkerSize.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.comboBoxEditMinMarkerSize.Name = "comboBoxEditMinMarkerSize"
			Me.comboBoxEditMinMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMinMarkerSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMinMarkerSize.Size = New System.Drawing.Size(50, 20)
			Me.comboBoxEditMinMarkerSize.TabIndex = 55
'			Me.comboBoxEditMinMarkerSize.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMinMarkerSize_SelectedIndexChanged);
			' 
			' labelMinMarkerKind
			' 
			Me.labelMinMarkerKind.Location = New System.Drawing.Point(144, 40)
			Me.labelMinMarkerKind.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelMinMarkerKind.Name = "labelMinMarkerKind"
			Me.labelMinMarkerKind.Size = New System.Drawing.Size(24, 13)
			Me.labelMinMarkerKind.TabIndex = 50
			Me.labelMinMarkerKind.Text = "Kind:"
			' 
			' labelMinMarkerSize
			' 
			Me.labelMinMarkerSize.Location = New System.Drawing.Point(281, 40)
			Me.labelMinMarkerSize.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelMinMarkerSize.Name = "labelMinMarkerSize"
			Me.labelMinMarkerSize.Size = New System.Drawing.Size(23, 13)
			Me.labelMinMarkerSize.TabIndex = 54
			Me.labelMinMarkerSize.Text = "Size:"
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			radarDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			radarDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
			radarDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
			radarDiagram1.AxisX.Label.TextPattern = "{A:MMMM}"
			radarDiagram1.AxisX.WholeRange.AutoSideMargins = False
			radarDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
			radarDiagram1.AxisY.Label.TextPattern = "{V}°C"
			Me.chart.Diagram = radarDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			radarRangeAreaSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			radarRangeAreaSeriesLabel1.TextPattern = "{V:F}"
			series1.Label = radarRangeAreaSeriesLabel1
			series1.Name = "Day-Night"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
			radarRangeAreaSeriesView1.Border1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(174))))), (CInt(Fix((CByte(73))))))
			radarRangeAreaSeriesView1.Border2.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(121))))))
			radarRangeAreaSeriesView1.Marker1Visibility = DevExpress.Utils.DefaultBoolean.True
			radarRangeAreaSeriesView1.Marker2Visibility = DevExpress.Utils.DefaultBoolean.True
			radarRangeAreaSeriesView1.SeriesAnimation = circularSeriesLinearUnwindAnimation1
			circularMarkerSlideAnimation1.BeginTime = System.TimeSpan.Parse("00:00:00.4000000")
			circularMarkerSlideAnimation1.Duration = System.TimeSpan.Parse("00:00:00.8000000")
			radarRangeAreaSeriesView1.SeriesPointAnimation = circularMarkerSlideAnimation1
			series1.View = radarRangeAreaSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(697, 426)
			Me.chart.TabIndex = 2
			Me.chart.TabStop = False
			chartTitle1.Text = "Average Temperature in London"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.weather.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' checkEditShowMaxMarkers
			' 
			Me.checkEditShowMaxMarkers.EditValue = True
			Me.checkEditShowMaxMarkers.Location = New System.Drawing.Point(13, 9)
			Me.checkEditShowMaxMarkers.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
			Me.checkEditShowMaxMarkers.Name = "checkEditShowMaxMarkers"
			Me.checkEditShowMaxMarkers.Properties.Caption = "Show Value2 Markers"
			Me.checkEditShowMaxMarkers.Size = New System.Drawing.Size(125, 19)
			Me.checkEditShowMaxMarkers.TabIndex = 58
'			Me.checkEditShowMaxMarkers.CheckedChanged += New System.EventHandler(Me.checkEditShowMaxMarkers_CheckedChanged);
			' 
			' checkEditShowMinMarkers
			' 
			Me.checkEditShowMinMarkers.EditValue = True
			Me.checkEditShowMinMarkers.Location = New System.Drawing.Point(13, 37)
			Me.checkEditShowMinMarkers.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
			Me.checkEditShowMinMarkers.Name = "checkEditShowMinMarkers"
			Me.checkEditShowMinMarkers.Properties.Caption = "Show Value1 Markers"
			Me.checkEditShowMinMarkers.Size = New System.Drawing.Size(125, 19)
			Me.checkEditShowMinMarkers.TabIndex = 59
'			Me.checkEditShowMinMarkers.CheckedChanged += New System.EventHandler(Me.checkEditShowMinMarkers_CheckedChanged);
			' 
			' labelMaxMarkerKind
			' 
			Me.labelMaxMarkerKind.Location = New System.Drawing.Point(144, 12)
			Me.labelMaxMarkerKind.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelMaxMarkerKind.Name = "labelMaxMarkerKind"
			Me.labelMaxMarkerKind.Size = New System.Drawing.Size(24, 13)
			Me.labelMaxMarkerKind.TabIndex = 60
			Me.labelMaxMarkerKind.Text = "Kind:"
			' 
			' comboBoxEditMaxMarkerKind
			' 
			Me.comboBoxEditMaxMarkerKind.EditValue = ""
			Me.comboBoxEditMaxMarkerKind.Location = New System.Drawing.Point(171, 9)
			Me.comboBoxEditMaxMarkerKind.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditMaxMarkerKind.Name = "comboBoxEditMaxMarkerKind"
			Me.comboBoxEditMaxMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMaxMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMaxMarkerKind.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEditMaxMarkerKind.TabIndex = 61
'			Me.comboBoxEditMaxMarkerKind.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMaxMarkerKind_SelectedIndexChanged);
			' 
			' labelMaxMarkerSize
			' 
			Me.labelMaxMarkerSize.Location = New System.Drawing.Point(281, 12)
			Me.labelMaxMarkerSize.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelMaxMarkerSize.Name = "labelMaxMarkerSize"
			Me.labelMaxMarkerSize.Size = New System.Drawing.Size(23, 13)
			Me.labelMaxMarkerSize.TabIndex = 62
			Me.labelMaxMarkerSize.Text = "Size:"
			' 
			' comboBoxEditMaxMarkerSize
			' 
			Me.comboBoxEditMaxMarkerSize.EditValue = ""
			Me.comboBoxEditMaxMarkerSize.Location = New System.Drawing.Point(311, 8)
			Me.comboBoxEditMaxMarkerSize.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.comboBoxEditMaxMarkerSize.Name = "comboBoxEditMaxMarkerSize"
			Me.comboBoxEditMaxMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMaxMarkerSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMaxMarkerSize.Size = New System.Drawing.Size(50, 20)
			Me.comboBoxEditMaxMarkerSize.TabIndex = 63
'			Me.comboBoxEditMaxMarkerSize.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMaxMarkerSize_SelectedIndexChanged);
			' 
			' labelLabelKind
			' 
			Me.labelLabelKind.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelLabelKind.Location = New System.Drawing.Point(530, 12)
			Me.labelLabelKind.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelLabelKind.Name = "labelLabelKind"
			Me.labelLabelKind.Size = New System.Drawing.Size(52, 13)
			Me.labelLabelKind.TabIndex = 64
			Me.labelLabelKind.Text = "Label Kind:"
			' 
			' comboBoxLabelKind
			' 
			Me.comboBoxLabelKind.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.comboBoxLabelKind.EditValue = "Two Labels"
			Me.comboBoxLabelKind.Location = New System.Drawing.Point(587, 9)
			Me.comboBoxLabelKind.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxLabelKind.Name = "comboBoxLabelKind"
			Me.comboBoxLabelKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxLabelKind.Properties.Items.AddRange(New Object() { "One Label", "Two Labels", "Max Value Label", "Min Value Label", "Value 1 Label", "Value 2 Label"})
			Me.comboBoxLabelKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxLabelKind.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxLabelKind.TabIndex = 65
'			Me.comboBoxLabelKind.SelectedIndexChanged += New System.EventHandler(Me.comboBoxLabelKind_SelectedIndexChanged);
			' 
			' comboBoxEditTextDirection
			' 
			Me.comboBoxEditTextDirection.EditValue = ""
			Me.comboBoxEditTextDirection.Location = New System.Drawing.Point(446, 9)
			Me.comboBoxEditTextDirection.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditTextDirection.Name = "comboBoxEditTextDirection"
			Me.comboBoxEditTextDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditTextDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditTextDirection.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditTextDirection.TabIndex = 66
'			Me.comboBoxEditTextDirection.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditTextDirection_SelectedIndexChanged);
			' 
			' labelTextDirection
			' 
			Me.labelTextDirection.Location = New System.Drawing.Point(374, 12)
			Me.labelTextDirection.Margin = New System.Windows.Forms.Padding(0)
			Me.labelTextDirection.Name = "labelTextDirection"
			Me.labelTextDirection.Size = New System.Drawing.Size(71, 13)
			Me.labelTextDirection.TabIndex = 67
			Me.labelTextDirection.Text = "Text Direction:"
			' 
			' comboBoxEditDiagramStyle
			' 
			Me.comboBoxEditDiagramStyle.EditValue = ""
			Me.comboBoxEditDiagramStyle.Location = New System.Drawing.Point(446, 37)
			Me.comboBoxEditDiagramStyle.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.comboBoxEditDiagramStyle.Name = "comboBoxEditDiagramStyle"
			Me.comboBoxEditDiagramStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditDiagramStyle.Properties.Items.AddRange(New Object() { "Circle", "Polygon"})
			Me.comboBoxEditDiagramStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditDiagramStyle.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditDiagramStyle.TabIndex = 68
'			Me.comboBoxEditDiagramStyle.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditDiagramStyle_SelectedIndexChanged);
			' 
			' labelDiagramStyle
			' 
			Me.labelDiagramStyle.Location = New System.Drawing.Point(374, 40)
			Me.labelDiagramStyle.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelDiagramStyle.Name = "labelDiagramStyle"
			Me.labelDiagramStyle.Size = New System.Drawing.Size(70, 13)
			Me.labelDiagramStyle.TabIndex = 69
			Me.labelDiagramStyle.Text = "Diagram Style:"
			' 
			' RadarRangeAreaDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "RadarRangeAreaDemo"
			Me.Size = New System.Drawing.Size(697, 500)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.comboBoxEditMinMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMinMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(radarDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(radarRangeAreaSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(radarRangeAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditShowMaxMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditShowMinMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMaxMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMaxMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxLabelKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditTextDirection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Protected WithEvents comboBoxEditMinMarkerKind As DevExpress.XtraEditors.ComboBoxEdit
		Protected WithEvents comboBoxEditMinMarkerSize As DevExpress.XtraEditors.ComboBoxEdit
		Protected labelMinMarkerKind As DevExpress.XtraEditors.LabelControl
		Protected labelMinMarkerSize As DevExpress.XtraEditors.LabelControl
		Private chart As ChartControl
		Protected labelMaxMarkerKind As DevExpress.XtraEditors.LabelControl
		Protected WithEvents checkEditShowMinMarkers As DevExpress.XtraEditors.CheckEdit
		Protected WithEvents checkEditShowMaxMarkers As DevExpress.XtraEditors.CheckEdit
		Protected WithEvents comboBoxEditMaxMarkerSize As DevExpress.XtraEditors.ComboBoxEdit
		Protected labelMaxMarkerSize As DevExpress.XtraEditors.LabelControl
		Protected WithEvents comboBoxEditMaxMarkerKind As DevExpress.XtraEditors.ComboBoxEdit
		Protected WithEvents comboBoxLabelKind As DevExpress.XtraEditors.ComboBoxEdit
		Protected labelLabelKind As DevExpress.XtraEditors.LabelControl
		Protected WithEvents comboBoxEditTextDirection As XtraEditors.ComboBoxEdit
		Private labelTextDirection As XtraEditors.LabelControl
		Protected WithEvents comboBoxEditDiagramStyle As XtraEditors.ComboBoxEdit
		Private labelDiagramStyle As XtraEditors.LabelControl
	End Class
End Namespace
