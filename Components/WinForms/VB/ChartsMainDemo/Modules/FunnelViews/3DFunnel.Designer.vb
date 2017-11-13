Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.FunnelViews
	Partial Public Class Funnel3dDemo
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
			Dim funnelDiagram3D1 As New DevExpress.XtraCharts.FunnelDiagram3D()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim funnel3DSeriesLabel1 As New DevExpress.XtraCharts.Funnel3DSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Visited a Website", New Object() { (CObj(9152R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Downloaded a Trial", New Object() { (CObj(6870R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("Contacted to Support", New Object() { (CObj(5121R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("Subscribed", New Object() { (CObj(2224R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Renewed", New Object() { (CObj(1670R))})
			Dim funnel3DSeriesView1 As New DevExpress.XtraCharts.Funnel3DSeriesView()
			Dim funnel3DSeriesView2 As New DevExpress.XtraCharts.Funnel3DSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.spinPointDistance = New DevExpress.XtraEditors.SpinEdit()
			Me.labelPointDistance = New DevExpress.XtraEditors.LabelControl()
			Me.labelHeightToWidthRatio = New DevExpress.XtraEditors.LabelControl()
			Me.cbHeightToWidthRatio = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
			Me.spinHoleRadius = New DevExpress.XtraEditors.SpinEdit()
			Me.labelHoleRadius = New DevExpress.XtraEditors.LabelControl()
			Me.cbLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelPosition = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(funnelDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(funnel3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(funnel3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(funnel3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinPointDistance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbHeightToWidthRatio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinHoleRadius.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Location = New System.Drawing.Point(156, 36)
			Me.btnDefaultAngles.TabIndex = 6
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.cbLabelPosition)
			Me.panel.Controls.Add(Me.labelPosition)
			Me.panel.Controls.Add(Me.spinHoleRadius)
			Me.panel.Controls.Add(Me.labelHoleRadius)
			Me.panel.Controls.Add(Me.checkEditValueAsPercent)
			Me.panel.Controls.Add(Me.spinPointDistance)
			Me.panel.Controls.Add(Me.labelPointDistance)
			Me.panel.Controls.Add(Me.labelHeightToWidthRatio)
			Me.panel.Controls.Add(Me.cbHeightToWidthRatio)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.cbHeightToWidthRatio, 0)
			Me.panel.Controls.SetChildIndex(Me.labelHeightToWidthRatio, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPointDistance, 0)
			Me.panel.Controls.SetChildIndex(Me.spinPointDistance, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditValueAsPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.labelHoleRadius, 0)
			Me.panel.Controls.SetChildIndex(Me.spinHoleRadius, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.cbLabelPosition, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(584, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 10
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			funnelDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.866025403784439;0.5;0;0;-0.5;0.866025403784439;0;0;0;0;1"
			funnelDiagram3D1.RuntimeRotation = True
			funnelDiagram3D1.RuntimeScrolling = True
			funnelDiagram3D1.RuntimeZooming = True
			Me.chart.Diagram = funnelDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			funnel3DSeriesLabel1.LineLength = 40
			funnel3DSeriesLabel1.TextPattern = "{A}: {VP:P0}"
			series1.Label = funnel3DSeriesLabel1
			series1.LegendTextPattern = "{A}: {VP:P0}"
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
			funnel3DSeriesView1.PointDistance = 10
			series1.View = funnel3DSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.View = funnel3DSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "Website Visitor Trend"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' spinPointDistance
			' 
			Me.spinPointDistance.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinPointDistance.Location = New System.Drawing.Point(88, 9)
			Me.spinPointDistance.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
			Me.spinPointDistance.Name = "spinPointDistance"
			Me.spinPointDistance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinPointDistance.Properties.IsFloatValue = False
			Me.spinPointDistance.Properties.Mask.EditMask = "N00"
			Me.spinPointDistance.Properties.MaxValue = New Decimal(New Integer() { 30, 0, 0, 0})
			Me.spinPointDistance.Properties.ValidateOnEnterKey = True
			Me.spinPointDistance.Size = New System.Drawing.Size(46, 20)
			Me.spinPointDistance.TabIndex = 1
'			Me.spinPointDistance.EditValueChanged += New System.EventHandler(Me.spinPointDistance_EditValueChanged);
			' 
			' labelPointDistance
			' 
			Me.labelPointDistance.Location = New System.Drawing.Point(12, 12)
			Me.labelPointDistance.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelPointDistance.Name = "labelPointDistance"
			Me.labelPointDistance.Size = New System.Drawing.Size(72, 13)
			Me.labelPointDistance.TabIndex = 0
			Me.labelPointDistance.Text = "Point Distance:"
			' 
			' labelHeightToWidthRatio
			' 
			Me.labelHeightToWidthRatio.Location = New System.Drawing.Point(12, 40)
			Me.labelHeightToWidthRatio.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelHeightToWidthRatio.Name = "labelHeightToWidthRatio"
			Me.labelHeightToWidthRatio.Size = New System.Drawing.Size(73, 13)
			Me.labelHeightToWidthRatio.TabIndex = 2
			Me.labelHeightToWidthRatio.Text = "Height / Width:"
			' 
			' cbHeightToWidthRatio
			' 
			Me.cbHeightToWidthRatio.Location = New System.Drawing.Point(88, 37)
			Me.cbHeightToWidthRatio.Margin = New System.Windows.Forms.Padding(0, 0, 5, 10)
			Me.cbHeightToWidthRatio.Name = "cbHeightToWidthRatio"
			Me.cbHeightToWidthRatio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbHeightToWidthRatio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbHeightToWidthRatio.Size = New System.Drawing.Size(46, 20)
			Me.cbHeightToWidthRatio.TabIndex = 3
'			Me.cbHeightToWidthRatio.SelectedIndexChanged += New System.EventHandler(Me.cbHeightToWidthRatio_SelectedIndexChanged);
			' 
			' checkEditValueAsPercent
			' 
			Me.checkEditValueAsPercent.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditValueAsPercent.Location = New System.Drawing.Point(584, 9)
			Me.checkEditValueAsPercent.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
			Me.checkEditValueAsPercent.Properties.Caption = "Value as Percent"
			Me.checkEditValueAsPercent.Size = New System.Drawing.Size(105, 19)
			Me.checkEditValueAsPercent.TabIndex = 9
'			Me.checkEditValueAsPercent.CheckedChanged += New System.EventHandler(Me.checkEditValueAsPercent_CheckedChanged);
			' 
			' spinHoleRadius
			' 
			Me.spinHoleRadius.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinHoleRadius.Location = New System.Drawing.Point(238, 9)
			Me.spinHoleRadius.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
			Me.spinHoleRadius.Name = "spinHoleRadius"
			Me.spinHoleRadius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinHoleRadius.Properties.IsFloatValue = False
			Me.spinHoleRadius.Properties.Mask.EditMask = "N00"
			Me.spinHoleRadius.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spinHoleRadius.Properties.ValidateOnEnterKey = True
			Me.spinHoleRadius.Size = New System.Drawing.Size(46, 20)
			Me.spinHoleRadius.TabIndex = 5
'			Me.spinHoleRadius.EditValueChanged += New System.EventHandler(Me.spinHoleRadius_EditValueChanged);
			' 
			' labelHoleRadius
			' 
			Me.labelHoleRadius.Location = New System.Drawing.Point(156, 12)
			Me.labelHoleRadius.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelHoleRadius.Name = "labelHoleRadius"
			Me.labelHoleRadius.Size = New System.Drawing.Size(79, 13)
			Me.labelHoleRadius.TabIndex = 4
			Me.labelHoleRadius.Text = "Hole Radius(%):"
			' 
			' cbLabelPosition
			' 
			Me.cbLabelPosition.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cbLabelPosition.Location = New System.Drawing.Point(481, 9)
			Me.cbLabelPosition.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.cbLabelPosition.Name = "cbLabelPosition"
			Me.cbLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLabelPosition.Properties.Items.AddRange(New Object() { "LeftColumn", "Left", "Center", "Right", "RightColumn"})
			Me.cbLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLabelPosition.Size = New System.Drawing.Size(83, 20)
			Me.cbLabelPosition.TabIndex = 8
'			Me.cbLabelPosition.SelectedIndexChanged += New System.EventHandler(Me.cbLabelPosition_SelectedIndexChanged);
			' 
			' labelPosition
			' 
			Me.labelPosition.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelPosition.Location = New System.Drawing.Point(409, 12)
			Me.labelPosition.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelPosition.Name = "labelPosition"
			Me.labelPosition.Size = New System.Drawing.Size(69, 13)
			Me.labelPosition.TabIndex = 7
			Me.labelPosition.Text = "Label Position:"
			' 
			' Funnel3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "Funnel3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(funnelDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(funnel3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(funnel3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(funnel3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinPointDistance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbHeightToWidthRatio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinHoleRadius.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Protected WithEvents spinPointDistance As DevExpress.XtraEditors.SpinEdit
		Private labelPointDistance As DevExpress.XtraEditors.LabelControl
		Private labelHeightToWidthRatio As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbHeightToWidthRatio As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents checkEditValueAsPercent As DevExpress.XtraEditors.CheckEdit
		Protected WithEvents spinHoleRadius As DevExpress.XtraEditors.SpinEdit
		Private labelHoleRadius As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbLabelPosition As DevExpress.XtraEditors.ComboBoxEdit
		Private labelPosition As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
