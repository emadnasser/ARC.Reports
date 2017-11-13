Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class ScaleBreaksDemo
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
			Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("Mercury", New Object() { (CObj(0.06R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("Venus", New Object() { (CObj(0.82R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("Earth", New Object() { (CObj(1R))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("Mars", New Object() { (CObj(0.11R))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("Jupiter", New Object() { (CObj(318R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("Saturn", New Object() { (CObj(95R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("Uranus", New Object() { (CObj(14.6R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("Neptune", New Object() { (CObj(17.2R))})
			Dim sideBySideBarSeriesView2 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim barSlideAnimation2 As New DevExpress.XtraCharts.BarSlideAnimation()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.chEnableScaleBreaks = New DevExpress.XtraEditors.CheckEdit()
			Me.lblStyle = New DevExpress.XtraEditors.LabelControl()
			Me.cbStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblSize = New DevExpress.XtraEditors.LabelControl()
			Me.spnSize = New DevExpress.XtraEditors.SpinEdit()
			Me.lblColor = New DevExpress.XtraEditors.LabelControl()
			Me.ceColor = New DevExpress.XtraEditors.ColorEdit()
			Me.btnResetColor = New DevExpress.XtraEditors.SimpleButton()
			Me.spnMaxCount = New DevExpress.XtraEditors.SpinEdit()
			Me.lblMaxCount = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chEnableScaleBreaks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spnSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spnMaxCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.chEnableScaleBreaks)
			Me.panel.Controls.Add(Me.lblStyle)
			Me.panel.Controls.Add(Me.lblSize)
			Me.panel.Controls.Add(Me.lblMaxCount)
			Me.panel.Controls.Add(Me.spnMaxCount)
			Me.panel.Controls.Add(Me.spnSize)
			Me.panel.Controls.Add(Me.ceColor)
			Me.panel.Controls.Add(Me.lblColor)
			Me.panel.Controls.Add(Me.btnResetColor)
			Me.panel.Controls.Add(Me.cbStyle)
			Me.panel.Controls.SetChildIndex(Me.cbStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.btnResetColor, 0)
			Me.panel.Controls.SetChildIndex(Me.lblColor, 0)
			Me.panel.Controls.SetChildIndex(Me.ceColor, 0)
			Me.panel.Controls.SetChildIndex(Me.spnSize, 0)
			Me.panel.Controls.SetChildIndex(Me.spnMaxCount, 0)
			Me.panel.Controls.SetChildIndex(Me.lblMaxCount, 0)
			Me.panel.Controls.SetChildIndex(Me.lblSize, 0)
			Me.panel.Controls.SetChildIndex(Me.lblStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.chEnableScaleBreaks, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 6
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram2.AxisX.Title.Text = "Planets"
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.AutoScaleBreaks.Enabled = True
			xyDiagram2.AxisY.AutoScaleBreaks.MaxCount = 4
			xyDiagram2.AxisY.Interlaced = True
			xyDiagram2.AxisY.Title.Text = "Mass (Earth's)"
			xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram2
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series2.LegendTextPattern = "{A}: {V}"
			series2.Name = "Series 1"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
			barSlideAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			barSlideAnimation2.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Inverted
			sideBySideBarSeriesView2.Animation = barSlideAnimation2
			sideBySideBarSeriesView2.ColorEach = True
			series2.View = sideBySideBarSeriesView2
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 2
			chartTitle2.Text = "Mass of Planets in the Solar System"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle2})
			' 
			' chEnableScaleBreaks
			' 
			Me.chEnableScaleBreaks.EditValue = True
			Me.chEnableScaleBreaks.Location = New System.Drawing.Point(12, 9)
			Me.chEnableScaleBreaks.Name = "chEnableScaleBreaks"
			Me.chEnableScaleBreaks.Properties.Caption = "Show Scale Breaks"
			Me.chEnableScaleBreaks.Size = New System.Drawing.Size(112, 19)
			Me.chEnableScaleBreaks.TabIndex = 0
'			Me.chEnableScaleBreaks.CheckedChanged += New System.EventHandler(Me.chEnableScaleBreaks_CheckedChanged);
			' 
			' lblStyle
			' 
			Me.lblStyle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lblStyle.Location = New System.Drawing.Point(151, 8)
			Me.lblStyle.Name = "lblStyle"
			Me.lblStyle.Size = New System.Drawing.Size(28, 20)
			Me.lblStyle.TabIndex = 3
			Me.lblStyle.Text = "Style:"
			' 
			' cbStyle
			' 
			Me.cbStyle.Location = New System.Drawing.Point(185, 9)
			Me.cbStyle.Name = "cbStyle"
			Me.cbStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbStyle.Properties.Items.AddRange(New Object() { "Straight", "Ragged", "Waved"})
			Me.cbStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbStyle.Size = New System.Drawing.Size(78, 20)
			Me.cbStyle.TabIndex = 2
'			Me.cbStyle.SelectedIndexChanged += New System.EventHandler(Me.cbStyle_SelectedIndexChanged);
			' 
			' lblSize
			' 
			Me.lblSize.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lblSize.Location = New System.Drawing.Point(151, 36)
			Me.lblSize.Name = "lblSize"
			Me.lblSize.Size = New System.Drawing.Size(23, 20)
			Me.lblSize.TabIndex = 3
			Me.lblSize.Text = "Size:"
			' 
			' spnSize
			' 
			Me.spnSize.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spnSize.Location = New System.Drawing.Point(185, 37)
			Me.spnSize.Name = "spnSize"
			Me.spnSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spnSize.Properties.IsFloatValue = False
			Me.spnSize.Properties.Mask.EditMask = "N00"
			Me.spnSize.Properties.MaxValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.spnSize.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.spnSize.Properties.ValidateOnEnterKey = True
			Me.spnSize.Size = New System.Drawing.Size(78, 20)
			Me.spnSize.TabIndex = 3
'			Me.spnSize.EditValueChanged += New System.EventHandler(Me.spnSize_EditValueChanged);
			' 
			' lblColor
			' 
			Me.lblColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lblColor.Location = New System.Drawing.Point(287, 8)
			Me.lblColor.Name = "lblColor"
			Me.lblColor.Size = New System.Drawing.Size(29, 20)
			Me.lblColor.TabIndex = 3
			Me.lblColor.Text = "Color:"
			' 
			' ceColor
			' 
			Me.ceColor.EditValue = System.Drawing.Color.Empty
			Me.ceColor.Location = New System.Drawing.Point(322, 9)
			Me.ceColor.Name = "ceColor"
			Me.ceColor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
			Me.ceColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ceColor.Size = New System.Drawing.Size(115, 20)
			Me.ceColor.TabIndex = 4
'			Me.ceColor.EditValueChanged += New System.EventHandler(Me.ceColor_EditValueChanged);
			' 
			' btnResetColor
			' 
			Me.btnResetColor.Location = New System.Drawing.Point(287, 37)
			Me.btnResetColor.Name = "btnResetColor"
			Me.btnResetColor.Size = New System.Drawing.Size(150, 20)
			Me.btnResetColor.TabIndex = 5
			Me.btnResetColor.Text = "Restore Default Color"
'			Me.btnResetColor.Click += New System.EventHandler(Me.btnResetColor_Click);
			' 
			' spnMaxCount
			' 
			Me.spnMaxCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spnMaxCount.Location = New System.Drawing.Point(77, 37)
			Me.spnMaxCount.Name = "spnMaxCount"
			Me.spnMaxCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spnMaxCount.Properties.IsFloatValue = False
			Me.spnMaxCount.Properties.Mask.EditMask = "N00"
			Me.spnMaxCount.Properties.MaxValue = New Decimal(New Integer() { 4, 0, 0, 0})
			Me.spnMaxCount.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spnMaxCount.Properties.ValidateOnEnterKey = True
			Me.spnMaxCount.Size = New System.Drawing.Size(47, 20)
			Me.spnMaxCount.TabIndex = 1
'			Me.spnMaxCount.EditValueChanged += New System.EventHandler(Me.spnMaxCount_EditValueChanged);
			' 
			' lblMaxCount
			' 
			Me.lblMaxCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lblMaxCount.Location = New System.Drawing.Point(15, 39)
			Me.lblMaxCount.Name = "lblMaxCount"
			Me.lblMaxCount.Size = New System.Drawing.Size(56, 14)
			Me.lblMaxCount.TabIndex = 3
			Me.lblMaxCount.Text = "Max Count:"
			' 
			' ScaleBreaksDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ScaleBreaksDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chEnableScaleBreaks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spnSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spnMaxCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private WithEvents chEnableScaleBreaks As DevExpress.XtraEditors.CheckEdit
		Private lblStyle As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbStyle As DevExpress.XtraEditors.ComboBoxEdit
		Private lblSize As DevExpress.XtraEditors.LabelControl
		Private WithEvents spnSize As DevExpress.XtraEditors.SpinEdit
		Private WithEvents ceColor As DevExpress.XtraEditors.ColorEdit
		Private lblColor As DevExpress.XtraEditors.LabelControl
		Private WithEvents btnResetColor As DevExpress.XtraEditors.SimpleButton
		Private lblMaxCount As DevExpress.XtraEditors.LabelControl
		Private WithEvents spnMaxCount As DevExpress.XtraEditors.SpinEdit
	End Class
End Namespace
