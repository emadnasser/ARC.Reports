Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.FunnelViews
	Partial Public Class FunnelDemo
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
			Dim simpleDiagram2 As New DevExpress.XtraCharts.SimpleDiagram()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim funnelSeriesLabel2 As New DevExpress.XtraCharts.FunnelSeriesLabel()
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Visited a Website", New Object() { (CObj(9152R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("Downloaded a Trial", New Object() { (CObj(6870R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Contacted to Support", New Object() { (CObj(5121R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("Subscribed", New Object() { (CObj(2224R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("Renewed", New Object() { (CObj(1670R))})
			Dim funnelSeriesView2 As New DevExpress.XtraCharts.FunnelSeriesView()
			Dim pointSeriesView2 As New DevExpress.XtraCharts.PointSeriesView()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelPosition = New DevExpress.XtraEditors.LabelControl()
			Me.cbLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEditHeightToWidthRatioAuto = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEditAlignToCenter = New DevExpress.XtraEditors.CheckEdit()
			Me.cbHeightToWidthRatio = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelHeightToWidthRatio = New DevExpress.XtraEditors.LabelControl()
			Me.labelPointDistance = New DevExpress.XtraEditors.LabelControl()
			Me.spinPointDistance = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(simpleDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(funnelSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(funnelSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditHeightToWidthRatioAuto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditAlignToCenter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbHeightToWidthRatio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinPointDistance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.spinPointDistance)
			Me.panel.Controls.Add(Me.labelPointDistance)
			Me.panel.Controls.Add(Me.labelHeightToWidthRatio)
			Me.panel.Controls.Add(Me.cbHeightToWidthRatio)
			Me.panel.Controls.Add(Me.checkEditAlignToCenter)
			Me.panel.Controls.Add(Me.checkEditHeightToWidthRatioAuto)
			Me.panel.Controls.Add(Me.checkEditValueAsPercent)
			Me.panel.Controls.Add(Me.cbLabelPosition)
			Me.panel.Controls.Add(Me.labelPosition)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.cbLabelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditValueAsPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditHeightToWidthRatioAuto, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditAlignToCenter, 0)
			Me.panel.Controls.SetChildIndex(Me.cbHeightToWidthRatio, 0)
			Me.panel.Controls.SetChildIndex(Me.labelHeightToWidthRatio, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPointDistance, 0)
			Me.panel.Controls.SetChildIndex(Me.spinPointDistance, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(584, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 9
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			simpleDiagram2.Margins.Bottom = 10
			simpleDiagram2.Margins.Left = 10
			simpleDiagram2.Margins.Right = 10
			simpleDiagram2.Margins.Top = 10
			Me.chart.Diagram = simpleDiagram2
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			funnelSeriesLabel2.TextPattern = "{A}: {VP:P0}"
			series2.Label = funnelSeriesLabel2
			series2.LegendTextPattern = "{A}: {VP:P0}"
			series2.Name = "Series 1"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10})
			series2.View = funnelSeriesView2
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
			Me.chart.SeriesTemplate.View = pointSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			chartTitle2.Text = "Website Visitor Trend"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle2})
			' 
			' labelPosition
			' 
			Me.labelPosition.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelPosition.Location = New System.Drawing.Point(409, 12)
			Me.labelPosition.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelPosition.Name = "labelPosition"
			Me.labelPosition.Size = New System.Drawing.Size(69, 13)
			Me.labelPosition.TabIndex = 6
			Me.labelPosition.Text = "Label Position:"
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
			Me.cbLabelPosition.TabIndex = 7
'			Me.cbLabelPosition.SelectedIndexChanged += New System.EventHandler(Me.cbLabelPosition_SelectedIndexChanged);
			' 
			' checkEditValueAsPercent
			' 
			Me.checkEditValueAsPercent.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditValueAsPercent.Location = New System.Drawing.Point(584, 9)
			Me.checkEditValueAsPercent.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
			Me.checkEditValueAsPercent.Properties.Caption = "Value as Percent"
			Me.checkEditValueAsPercent.Size = New System.Drawing.Size(105, 19)
			Me.checkEditValueAsPercent.TabIndex = 8
'			Me.checkEditValueAsPercent.CheckedChanged += New System.EventHandler(Me.checkEditValueAsPercent_CheckedChanged);
			' 
			' checkEditHeightToWidthRatioAuto
			' 
			Me.checkEditHeightToWidthRatioAuto.Location = New System.Drawing.Point(156, 37)
			Me.checkEditHeightToWidthRatioAuto.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
			Me.checkEditHeightToWidthRatioAuto.Name = "checkEditHeightToWidthRatioAuto"
			Me.checkEditHeightToWidthRatioAuto.Properties.Caption = "Auto"
			Me.checkEditHeightToWidthRatioAuto.Size = New System.Drawing.Size(49, 19)
			Me.checkEditHeightToWidthRatioAuto.TabIndex = 5
'			Me.checkEditHeightToWidthRatioAuto.CheckedChanged += New System.EventHandler(Me.checkEditHeightToWidthRatioAuto_CheckedChanged);
			' 
			' checkEditAlignToCenter
			' 
			Me.checkEditAlignToCenter.Location = New System.Drawing.Point(156, 9)
			Me.checkEditAlignToCenter.Name = "checkEditAlignToCenter"
			Me.checkEditAlignToCenter.Properties.Caption = "Align to Center"
			Me.checkEditAlignToCenter.Size = New System.Drawing.Size(99, 19)
			Me.checkEditAlignToCenter.TabIndex = 4
'			Me.checkEditAlignToCenter.CheckedChanged += New System.EventHandler(Me.checkEditAlignToCenter_CheckedChanged);
			' 
			' cbHeightToWidthRatio
			' 
			Me.cbHeightToWidthRatio.Location = New System.Drawing.Point(88, 37)
			Me.cbHeightToWidthRatio.Margin = New System.Windows.Forms.Padding(0, 0, 5, 10)
			Me.cbHeightToWidthRatio.Name = "cbHeightToWidthRatio"
			Me.cbHeightToWidthRatio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbHeightToWidthRatio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbHeightToWidthRatio.Size = New System.Drawing.Size(50, 20)
			Me.cbHeightToWidthRatio.TabIndex = 3
'			Me.cbHeightToWidthRatio.SelectedIndexChanged += New System.EventHandler(Me.cbHeightToWidthRatio_SelectedIndexChanged);
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
			' labelPointDistance
			' 
			Me.labelPointDistance.Location = New System.Drawing.Point(12, 12)
			Me.labelPointDistance.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelPointDistance.Name = "labelPointDistance"
			Me.labelPointDistance.Size = New System.Drawing.Size(72, 13)
			Me.labelPointDistance.TabIndex = 0
			Me.labelPointDistance.Text = "Point Distance:"
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
			Me.spinPointDistance.Size = New System.Drawing.Size(50, 20)
			Me.spinPointDistance.TabIndex = 1
'			Me.spinPointDistance.EditValueChanged += New System.EventHandler(Me.spinPointDistance_EditValueChanged);
			' 
			' FunnelDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "FunnelDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(simpleDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(funnelSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(funnelSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditHeightToWidthRatioAuto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditAlignToCenter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbHeightToWidthRatio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinPointDistance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private labelPosition As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbLabelPosition As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents checkEditValueAsPercent As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEditHeightToWidthRatioAuto As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEditAlignToCenter As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbHeightToWidthRatio As DevExpress.XtraEditors.ComboBoxEdit
		Private labelHeightToWidthRatio As DevExpress.XtraEditors.LabelControl
		Private labelPointDistance As DevExpress.XtraEditors.LabelControl
		Protected WithEvents spinPointDistance As DevExpress.XtraEditors.SpinEdit

	End Class
End Namespace
