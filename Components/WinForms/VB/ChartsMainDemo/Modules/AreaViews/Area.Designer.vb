Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class AreaDemo
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
			Dim crosshairFreePosition1 As New DevExpress.XtraCharts.CrosshairFreePosition()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim areaSeriesView1 As New DevExpress.XtraCharts.AreaSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.comboTransparencies = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditLabelAngle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditMarkerKind = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditMarkerSize = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.checkEditShowMarkers = New DevExpress.XtraEditors.CheckEdit()
			Me.labelMarkerKind = New DevExpress.XtraEditors.LabelControl()
			Me.labelMarkerSize = New DevExpress.XtraEditors.LabelControl()
			Me.labelAngle = New DevExpress.XtraEditors.LabelControl()
			Me.labelTransparency = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboTransparencies.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelTransparency)
			Me.panel.Controls.Add(Me.labelAngle)
			Me.panel.Controls.Add(Me.labelMarkerSize)
			Me.panel.Controls.Add(Me.labelMarkerKind)
			Me.panel.Controls.Add(Me.checkEditShowMarkers)
			Me.panel.Controls.Add(Me.comboBoxEditLabelAngle)
			Me.panel.Controls.Add(Me.comboBoxEditMarkerKind)
			Me.panel.Controls.Add(Me.comboBoxEditMarkerSize)
			Me.panel.Controls.Add(Me.comboTransparencies)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboTransparencies, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditLabelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowMarkers, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.labelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelTransparency, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 6
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			crosshairFreePosition1.DockCorner = DevExpress.XtraCharts.DockCorner.RightTop
			crosshairFreePosition1.DockTargetName = "Default Pane"
			Me.chart.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1
			Me.chart.CrosshairOptions.GroupHeaderPattern = "Year: {A:yyyy}"
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Label.MaxWidth = 70
			xyDiagram1.AxisX.Title.Text = "Corporation"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = False
			xyDiagram1.AxisY.NumericScaleOptions.GridSpacing = 75R
			xyDiagram1.AxisY.Title.Text = "Thousands US$"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Company"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Year"
			Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: ${V:0.0}K"
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Costs"
			Me.chart.SeriesTemplate.View = areaSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 12
			Me.chart.TabStop = False
			chartTitle1.Text = "Outside Vendor Costs"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' comboTransparencies
			' 
			Me.comboTransparencies.Location = New System.Drawing.Point(266, 37)
			Me.comboTransparencies.Margin = New System.Windows.Forms.Padding(3, 10, 10, 0)
			Me.comboTransparencies.Name = "comboTransparencies"
			Me.comboTransparencies.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboTransparencies.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboTransparencies.Size = New System.Drawing.Size(60, 20)
			Me.comboTransparencies.TabIndex = 3
'			Me.comboTransparencies.SelectedIndexChanged += New System.EventHandler(Me.comboTransparencies_SelectedIndexChanged);
			' 
			' comboBoxEditLabelAngle
			' 
			Me.comboBoxEditLabelAngle.EditValue = ""
			Me.comboBoxEditLabelAngle.Location = New System.Drawing.Point(266, 9)
			Me.comboBoxEditLabelAngle.Margin = New System.Windows.Forms.Padding(3, 0, 10, 10)
			Me.comboBoxEditLabelAngle.Name = "comboBoxEditLabelAngle"
			Me.comboBoxEditLabelAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditLabelAngle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditLabelAngle.Size = New System.Drawing.Size(60, 20)
			Me.comboBoxEditLabelAngle.TabIndex = 2
'			Me.comboBoxEditLabelAngle.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditLabelAngle_SelectedIndexChanged);
			' 
			' comboBoxEditMarkerKind
			' 
			Me.comboBoxEditMarkerKind.EditValue = ""
			Me.comboBoxEditMarkerKind.Location = New System.Drawing.Point(75, 9)
			Me.comboBoxEditMarkerKind.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind"
			Me.comboBoxEditMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMarkerKind.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEditMarkerKind.TabIndex = 0
'			Me.comboBoxEditMarkerKind.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMarkerKind_SelectedIndexChanged);
			' 
			' comboBoxEditMarkerSize
			' 
			Me.comboBoxEditMarkerSize.EditValue = ""
			Me.comboBoxEditMarkerSize.Location = New System.Drawing.Point(75, 37)
			Me.comboBoxEditMarkerSize.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
			Me.comboBoxEditMarkerSize.Name = "comboBoxEditMarkerSize"
			Me.comboBoxEditMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMarkerSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMarkerSize.Size = New System.Drawing.Size(60, 20)
			Me.comboBoxEditMarkerSize.TabIndex = 1
'			Me.comboBoxEditMarkerSize.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMarkerSize_SelectedIndexChanged);
			' 
			' checkEditShowMarkers
			' 
			Me.checkEditShowMarkers.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditShowMarkers.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowMarkers.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.checkEditShowMarkers.Name = "checkEditShowMarkers"
			Me.checkEditShowMarkers.Properties.Caption = "Show Markers"
			Me.checkEditShowMarkers.Size = New System.Drawing.Size(90, 19)
			Me.checkEditShowMarkers.TabIndex = 5
'			Me.checkEditShowMarkers.CheckedChanged += New System.EventHandler(Me.checkEditShowMarkers_CheckedChanged);
			' 
			' labelMarkerKind
			' 
			Me.labelMarkerKind.Location = New System.Drawing.Point(12, 12)
			Me.labelMarkerKind.Margin = New System.Windows.Forms.Padding(10, 0, 3, 10)
			Me.labelMarkerKind.Name = "labelMarkerKind"
			Me.labelMarkerKind.Size = New System.Drawing.Size(60, 13)
			Me.labelMarkerKind.TabIndex = 1
			Me.labelMarkerKind.Text = "Marker Kind:"
			' 
			' labelMarkerSize
			' 
			Me.labelMarkerSize.Location = New System.Drawing.Point(12, 40)
			Me.labelMarkerSize.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.labelMarkerSize.Name = "labelMarkerSize"
			Me.labelMarkerSize.Size = New System.Drawing.Size(59, 13)
			Me.labelMarkerSize.TabIndex = 3
			Me.labelMarkerSize.Text = "Marker Size:"
			' 
			' labelAngle
			' 
			Me.labelAngle.Location = New System.Drawing.Point(193, 12)
			Me.labelAngle.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.labelAngle.Name = "labelAngle"
			Me.labelAngle.Size = New System.Drawing.Size(59, 13)
			Me.labelAngle.TabIndex = 5
			Me.labelAngle.Text = "Label Angle:"
			' 
			' labelTransparency
			' 
			Me.labelTransparency.Location = New System.Drawing.Point(193, 40)
			Me.labelTransparency.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
			Me.labelTransparency.Name = "labelTransparency"
			Me.labelTransparency.Size = New System.Drawing.Size(70, 13)
			Me.labelTransparency.TabIndex = 7
			Me.labelTransparency.Text = "Transparency:"
			' 
			' AreaDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "AreaDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboTransparencies.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing
		Private itemCollection As MarkerKindItemCollection
		Private labelAngle As DevExpress.XtraEditors.LabelControl
		Private labelMarkerSize As DevExpress.XtraEditors.LabelControl
		Private labelMarkerKind As DevExpress.XtraEditors.LabelControl
		Private labelTransparency As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboTransparencies As DevExpress.XtraEditors.ComboBoxEdit

	End Class
End Namespace
