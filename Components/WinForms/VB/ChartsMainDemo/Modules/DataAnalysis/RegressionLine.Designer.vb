Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class RegressionLineDemo
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
			Dim pointSeriesView1 As New DevExpress.XtraCharts.PointSeriesView()
			Dim regressionLine1 As New DevExpress.XtraCharts.RegressionLine()
			Dim xyMarkerWidenAnimation1 As New DevExpress.XtraCharts.XYMarkerWidenAnimation()
			Dim pointSeriesView2 As New DevExpress.XtraCharts.PointSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.btnCreateRandomPoints = New DevExpress.XtraEditors.SimpleButton()
			Me.speThickness = New DevExpress.XtraEditors.SpinEdit()
			Me.lbThickness = New DevExpress.XtraEditors.LabelControl()
			Me.lbColor = New DevExpress.XtraEditors.LabelControl()
			Me.clreColor = New DevExpress.XtraEditors.ColorEdit()
			Me.cbDashStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbDashStyle = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(regressionLine1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.speThickness.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.clreColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbDashStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lbDashStyle)
			Me.panel.Controls.Add(Me.cbDashStyle)
			Me.panel.Controls.Add(Me.clreColor)
			Me.panel.Controls.Add(Me.lbColor)
			Me.panel.Controls.Add(Me.lbThickness)
			Me.panel.Controls.Add(Me.speThickness)
			Me.panel.Controls.Add(Me.btnCreateRandomPoints)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.btnCreateRandomPoints, 0)
			Me.panel.Controls.SetChildIndex(Me.speThickness, 0)
			Me.panel.Controls.SetChildIndex(Me.lbThickness, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.lbColor, 0)
			Me.panel.Controls.SetChildIndex(Me.clreColor, 0)
			Me.panel.Controls.SetChildIndex(Me.cbDashStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.lbDashStyle, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 4
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Title.Text = "Arguments"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.VisualRange.Auto = False
			xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "100"
			xyDiagram1.AxisX.VisualRange.MinValueSerializable = "0"
			xyDiagram1.AxisX.WholeRange.Auto = False
			xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "100"
			xyDiagram1.AxisX.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.Title.Text = "Values"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			xyDiagram1.LabelsResolveOverlappingMinIndent = 1
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint
			pointSeriesLabel1.TextPattern = "{V:F2}"
			series1.Label = pointSeriesLabel1
			series1.Name = "Random points"
			regressionLine1.Name = "Regression Line"
			regressionLine1.Visible = False
			pointSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() { regressionLine1})
			xyMarkerWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.0100000")
			pointSeriesView1.SeriesPointAnimation = xyMarkerWidenAnimation1
			series1.View = pointSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.View = pointSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Random Points Generator"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
'			Me.chart.AnimationEnded += New DevExpress.XtraCharts.AnimationEndedEventHandler(Me.chart_AnimationEnded);
			' 
			' btnCreateRandomPoints
			' 
			Me.btnCreateRandomPoints.Location = New System.Drawing.Point(12, 8)
			Me.btnCreateRandomPoints.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.btnCreateRandomPoints.Name = "btnCreateRandomPoints"
			Me.btnCreateRandomPoints.Size = New System.Drawing.Size(85, 22)
			Me.btnCreateRandomPoints.TabIndex = 0
			Me.btnCreateRandomPoints.Text = "Create Points"
'			Me.btnCreateRandomPoints.Click += New System.EventHandler(Me.btnCreateRandomPoints_Click);
			' 
			' speThickness
			' 
			Me.speThickness.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.speThickness.Location = New System.Drawing.Point(328, 9)
			Me.speThickness.Name = "speThickness"
			Me.speThickness.Properties.Appearance.Options.UseTextOptions = True
			Me.speThickness.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.speThickness.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.speThickness.Properties.IsFloatValue = False
			Me.speThickness.Properties.Mask.EditMask = "N00"
			Me.speThickness.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.speThickness.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.speThickness.Properties.ValidateOnEnterKey = True
			Me.speThickness.Size = New System.Drawing.Size(60, 20)
			Me.speThickness.TabIndex = 3
'			Me.speThickness.EditValueChanged += New System.EventHandler(Me.speThickness_EditValueChanged);
			' 
			' lbThickness
			' 
			Me.lbThickness.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbThickness.Location = New System.Drawing.Point(272, 8)
			Me.lbThickness.Name = "lbThickness"
			Me.lbThickness.Size = New System.Drawing.Size(50, 20)
			Me.lbThickness.TabIndex = 15
			Me.lbThickness.Text = "Thickness:"
			' 
			' lbColor
			' 
			Me.lbColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbColor.Location = New System.Drawing.Point(110, 11)
			Me.lbColor.Name = "lbColor"
			Me.lbColor.Size = New System.Drawing.Size(32, 14)
			Me.lbColor.TabIndex = 16
			Me.lbColor.Text = "Color:"
			' 
			' clreColor
			' 
			Me.clreColor.EditValue = System.Drawing.Color.Empty
			Me.clreColor.EnterMoveNextControl = True
			Me.clreColor.Location = New System.Drawing.Point(148, 9)
			Me.clreColor.Name = "clreColor"
			Me.clreColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.clreColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.clreColor.Size = New System.Drawing.Size(108, 20)
			Me.clreColor.TabIndex = 1
'			Me.clreColor.EditValueChanged += New System.EventHandler(Me.clreColor_EditValueChanged);
			' 
			' cbDashStyle
			' 
			Me.cbDashStyle.Location = New System.Drawing.Point(468, 9)
			Me.cbDashStyle.Name = "cbDashStyle"
			Me.cbDashStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbDashStyle.Properties.Items.AddRange(New Object() { "Solid", "Dash", "Dot", "DashDot", "DashDotDot"})
			Me.cbDashStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbDashStyle.Size = New System.Drawing.Size(108, 20)
			Me.cbDashStyle.TabIndex = 2
'			Me.cbDashStyle.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedIndexChanged);
			' 
			' lbDashStyle
			' 
			Me.lbDashStyle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbDashStyle.Location = New System.Drawing.Point(405, 8)
			Me.lbDashStyle.Name = "lbDashStyle"
			Me.lbDashStyle.Size = New System.Drawing.Size(57, 20)
			Me.lbDashStyle.TabIndex = 19
			Me.lbDashStyle.Text = "Dash Style:"
			' 
			' RegressionLineDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "RegressionLineDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(regressionLine1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.speThickness.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.clreColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbDashStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private WithEvents btnCreateRandomPoints As DevExpress.XtraEditors.SimpleButton
		Private WithEvents speThickness As DevExpress.XtraEditors.SpinEdit
		Private lbThickness As DevExpress.XtraEditors.LabelControl
		Private lbColor As DevExpress.XtraEditors.LabelControl
		Private WithEvents clreColor As DevExpress.XtraEditors.ColorEdit
		Private lbDashStyle As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbDashStyle As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
