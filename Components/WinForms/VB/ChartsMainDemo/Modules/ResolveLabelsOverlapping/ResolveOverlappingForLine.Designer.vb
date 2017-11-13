Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping
	Partial Public Class ResolveOverlappingForLineDemo
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
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(2.466424R, New Object() { (CObj(-28.2R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(2.486035R, New Object() { (CObj(-25.4R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(2.505635R, New Object() { (CObj(-23.4R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(2.525235R, New Object() { (CObj(-22.4R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(2.544851R, New Object() { (CObj(-21R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(2.564458R, New Object() { (CObj(-19.7R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(2.584058R, New Object() { (CObj(-15.9R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(2.603669R, New Object() { (CObj(-15.3R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(2.623269R, New Object() { (CObj(-15.3R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(2.64288R, New Object() { (CObj(-18.9R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(2.66249R, New Object() { (CObj(-21.1R))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(2.682092R, New Object() { (CObj(-23.2R))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(2.701703R, New Object() { (CObj(-26.9R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(2.721314R, New Object() { (CObj(-30.8R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(2.760537R, New Object() { (CObj(-43.8R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(2.780148R, New Object() { (CObj(-45.7R))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(2.79976R, New Object() { (CObj(-49.1R))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(2.819371R, New Object() { (CObj(-51.5R))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(2.838982R, New Object() { (CObj(-55.5R))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(2.858594R, New Object() { (CObj(-57.5R))})
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(2.878205R, New Object() { (CObj(-61R))})
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(2.897816R, New Object() { (CObj(-61.1R))})
			Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint(2.917428R, New Object() { (CObj(-64.5R))})
			Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint(2.937039R, New Object() { (CObj(-64.9R))})
			Dim seriesPoint25 As New DevExpress.XtraCharts.SeriesPoint(2.976262R, New Object() { (CObj(-67.8R))})
			Dim seriesPoint26 As New DevExpress.XtraCharts.SeriesPoint(3.035084R, New Object() { (CObj(-69.3R))})
			Dim seriesPoint27 As New DevExpress.XtraCharts.SeriesPoint(3.074307R, New Object() { (CObj(-70.4R))})
			Dim seriesPoint28 As New DevExpress.XtraCharts.SeriesPoint(3.093918R, New Object() { (CObj(-71.3R))})
			Dim seriesPoint29 As New DevExpress.XtraCharts.SeriesPoint(3.11353R, New Object() { (CObj(-71.9R))})
			Dim seriesPoint30 As New DevExpress.XtraCharts.SeriesPoint(3.191964R, New Object() { (CObj(-75R))})
			Dim seriesPoint31 As New DevExpress.XtraCharts.SeriesPoint(3.211575R, New Object() { (CObj(-76R))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.spinAngle = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControlAngle = New DevExpress.XtraEditors.LabelControl()
			Me.spinLineLength = New DevExpress.XtraEditors.SpinEdit()
			Me.labelLineLength = New DevExpress.XtraEditors.LabelControl()
			Me.labelMode = New DevExpress.XtraEditors.LabelControl()
			Me.cbMode = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelIndent = New DevExpress.XtraEditors.LabelControl()
			Me.spinIndent = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinLineLength.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.spinIndent)
			Me.panel.Controls.Add(Me.cbMode)
			Me.panel.Controls.Add(Me.labelMode)
			Me.panel.Controls.Add(Me.spinLineLength)
			Me.panel.Controls.Add(Me.labelLineLength)
			Me.panel.Controls.Add(Me.spinAngle)
			Me.panel.Controls.Add(Me.labelControlAngle)
			Me.panel.Controls.Add(Me.labelIndent)
			Me.panel.Controls.SetChildIndex(Me.labelIndent, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.labelControlAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.spinAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelLineLength, 0)
			Me.panel.Controls.SetChildIndex(Me.spinLineLength, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMode, 0)
			Me.panel.Controls.SetChildIndex(Me.cbMode, 0)
			Me.panel.Controls.SetChildIndex(Me.spinIndent, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' chartControl
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.AxisX.Title.Text = "Sol"
			xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Title.Text = "Temperature, in degrees Celsius"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.LabelsResolveOverlappingMinIndent = 3
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Margins.Bottom = 10
			Me.chart.Legend.Margins.Left = 10
			Me.chart.Legend.Margins.Right = 10
			Me.chart.Legend.Margins.Top = 10
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chartControl"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel1.LineLength = 15
			pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint
			series1.Label = pointSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			series1.Name = "Mars Ambient Temperature"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31})
			lineSeriesView1.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
			series1.View = lineSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.View = lineSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 2
			Me.chart.TabStop = False
			chartTitle1.Text = "Mars Pathfinder Temperature Data"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www-k12.atmos.washington.edu/k12"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' spinAngle
			' 
			Me.spinAngle.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.spinAngle.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinAngle.Location = New System.Drawing.Point(615, 36)
			Me.spinAngle.Name = "spinAngle"
			Me.spinAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinAngle.Properties.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.spinAngle.Properties.IsFloatValue = False
			Me.spinAngle.Properties.Mask.EditMask = "N00"
			Me.spinAngle.Properties.MaxValue = New Decimal(New Integer() { 360, 0, 0, 0})
			Me.spinAngle.Properties.MinValue = New Decimal(New Integer() { 360, 0, 0, -2147483648})
			Me.spinAngle.Properties.ValidateOnEnterKey = True
			Me.spinAngle.Size = New System.Drawing.Size(74, 20)
			Me.spinAngle.TabIndex = 3
'			Me.spinAngle.EditValueChanged += New System.EventHandler(Me.spinAngle_EditValueChanged);
			' 
			' labelControlAngle
			' 
			Me.labelControlAngle.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControlAngle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
			Me.labelControlAngle.Location = New System.Drawing.Point(553, 39)
			Me.labelControlAngle.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
			Me.labelControlAngle.Name = "labelControlAngle"
			Me.labelControlAngle.Size = New System.Drawing.Size(59, 13)
			Me.labelControlAngle.TabIndex = 10
			Me.labelControlAngle.Text = "Label Angle:"
			' 
			' spinLineLength
			' 
			Me.spinLineLength.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.spinLineLength.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinLineLength.Location = New System.Drawing.Point(615, 9)
			Me.spinLineLength.Name = "spinLineLength"
			Me.spinLineLength.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinLineLength.Properties.IsFloatValue = False
			Me.spinLineLength.Properties.Mask.EditMask = "N00"
			Me.spinLineLength.Properties.MaxValue = New Decimal(New Integer() { 30, 0, 0, 0})
			Me.spinLineLength.Properties.ValidateOnEnterKey = True
			Me.spinLineLength.Size = New System.Drawing.Size(74, 20)
			Me.spinLineLength.TabIndex = 2
'			Me.spinLineLength.EditValueChanged += New System.EventHandler(Me.spinLineLength_EditValueChanged);
			' 
			' labelLineLength
			' 
			Me.labelLineLength.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelLineLength.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
			Me.labelLineLength.Location = New System.Drawing.Point(553, 12)
			Me.labelLineLength.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
			Me.labelLineLength.Name = "labelLineLength"
			Me.labelLineLength.Size = New System.Drawing.Size(59, 13)
			Me.labelLineLength.TabIndex = 8
			Me.labelLineLength.Text = "Line Length:"
			' 
			' labelMode
			' 
			Me.labelMode.Location = New System.Drawing.Point(9, 12)
			Me.labelMode.Name = "labelMode"
			Me.labelMode.Size = New System.Drawing.Size(30, 13)
			Me.labelMode.TabIndex = 11
			Me.labelMode.Text = "Mode:"
			' 
			' cbMode
			' 
			Me.cbMode.Location = New System.Drawing.Point(48, 9)
			Me.cbMode.Name = "cbMode"
			Me.cbMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbMode.Properties.Items.AddRange(New Object() { "None", "Default", "Hide Overlapped", "Justify Around Point", "Justify All Around Point"})
			Me.cbMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbMode.Size = New System.Drawing.Size(135, 20)
			Me.cbMode.TabIndex = 12
'			Me.cbMode.SelectedIndexChanged += New System.EventHandler(Me.cbMode_SelectedIndexChanged);
			' 
			' labelIndent
			' 
			Me.labelIndent.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.labelIndent.Location = New System.Drawing.Point(9, 40)
			Me.labelIndent.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
			Me.labelIndent.Name = "labelIndent"
			Me.labelIndent.Size = New System.Drawing.Size(36, 13)
			Me.labelIndent.TabIndex = 13
			Me.labelIndent.Text = "Indent:"
			' 
			' spinIndent
			' 
			Me.spinIndent.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinIndent.Location = New System.Drawing.Point(48, 36)
			Me.spinIndent.Name = "spinIndent"
			Me.spinIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinIndent.Properties.IsFloatValue = False
			Me.spinIndent.Properties.Mask.EditMask = "N00"
			Me.spinIndent.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinIndent.Properties.MinValue = New Decimal(New Integer() { 10, 0, 0, -2147483648})
			Me.spinIndent.Properties.ValidateOnEnterKey = True
			Me.spinIndent.Size = New System.Drawing.Size(58, 20)
			Me.spinIndent.TabIndex = 14
'			Me.spinIndent.EditValueChanged += New System.EventHandler(Me.spinIndent_EditValueChanged);
			' 
			' ChartDemoResolveOverlappingLine
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ChartDemoResolveOverlappingLine"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinLineLength.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private WithEvents spinAngle As DevExpress.XtraEditors.SpinEdit
		Private labelControlAngle As DevExpress.XtraEditors.LabelControl
		Private WithEvents spinLineLength As DevExpress.XtraEditors.SpinEdit
		Private labelLineLength As DevExpress.XtraEditors.LabelControl
		Protected labelMode As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbMode As DevExpress.XtraEditors.ComboBoxEdit
		Protected labelIndent As DevExpress.XtraEditors.LabelControl
		Protected WithEvents spinIndent As DevExpress.XtraEditors.SpinEdit
	End Class
End Namespace
