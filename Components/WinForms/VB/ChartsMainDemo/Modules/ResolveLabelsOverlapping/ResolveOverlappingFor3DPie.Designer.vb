Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping
	Partial Public Class ResolveOverlappingFor3dPieDemo
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
			Dim simpleDiagram3D1 As New DevExpress.XtraCharts.SimpleDiagram3D()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pie3DSeriesLabel1 As New DevExpress.XtraCharts.Pie3DSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("China", New Object() { (CObj(1350R))}, 0)
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("India", New Object() { (CObj(1220R))}, 1)
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("USA", New Object() { (CObj(316.67R))}, 2)
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("Indonesia", New Object() { (CObj(251.16R))}, 3)
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (CObj(201.01R))}, 4)
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Pakistan", New Object() { (CObj(193.24R))}, 5)
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("Nigeria", New Object() { (CObj(174.51R))}, 6)
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Bangladesh", New Object() { (CObj(163.65R))}, 7)
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (CObj(142.5R))}, 8)
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("Japan", New Object() { (CObj(127.25R))}, 9)
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("Mexico", New Object() { (CObj(116.22R))}, 10)
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("Phillippines", New Object() { (CObj(105.72R))}, 11)
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("Ethiopia", New Object() { (CObj(93.88R))}, 12)
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("Vietnam", New Object() { (CObj(92.48R))}, 13)
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("Egypt", New Object() { (CObj(85.29R))}, 14)
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("Others", New Object() { (CObj(2466.42R))}, 15)
			Dim pie3DSeriesView1 As New DevExpress.XtraCharts.Pie3DSeriesView()
			Dim pie3DSeriesLabel2 As New DevExpress.XtraCharts.Pie3DSeriesLabel()
			Dim pie3DSeriesView2 As New DevExpress.XtraCharts.Pie3DSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkEditResolveOverlapping = New DevExpress.XtraEditors.CheckEdit()
			Me.labelIndent = New DevExpress.XtraEditors.LabelControl()
			Me.spinIndent = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(simpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pie3DSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pie3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditResolveOverlapping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnDefaultAngles.Location = New System.Drawing.Point(562, 8)
			Me.btnDefaultAngles.TabIndex = 2
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelIndent)
			Me.panel.Controls.Add(Me.spinIndent)
			Me.panel.Controls.Add(Me.checkEditResolveOverlapping)
			Me.panel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditResolveOverlapping, 0)
			Me.panel.Controls.SetChildIndex(Me.spinIndent, 0)
			Me.panel.Controls.SetChildIndex(Me.labelIndent, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(429, 8)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			simpleDiagram3D1.LabelsResolveOverlappingMinIndent = 5
			simpleDiagram3D1.RotationAngleX = -50
			simpleDiagram3D1.RotationAngleY = 170
			simpleDiagram3D1.RotationAngleZ = -25
			simpleDiagram3D1.RotationType = DevExpress.XtraCharts.RotationType.UseAngles
			simpleDiagram3D1.RuntimeRotation = True
			Me.chart.Diagram = simpleDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			pie3DSeriesLabel1.ColumnIndent = 30
			pie3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
			pie3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			pie3DSeriesLabel1.TextPattern = "{A}"
			series1.Label = pie3DSeriesLabel1
			series1.LegendTextPattern = "{VP:P0}  {A}"
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
			series1.View = pie3DSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			pie3DSeriesLabel2.TextPattern = "{VP:G2}"
			Me.chart.SeriesTemplate.Label = pie3DSeriesLabel2
			Me.chart.SeriesTemplate.View = pie3DSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			Me.chart.TabStop = False
			chartTitle1.Indent = 10
			chartTitle1.Text = "Population by Country"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.nationmaster.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' checkEditResolveOverlapping
			' 
			Me.checkEditResolveOverlapping.Location = New System.Drawing.Point(12, 9)
			Me.checkEditResolveOverlapping.Name = "checkEditResolveOverlapping"
			Me.checkEditResolveOverlapping.Properties.Caption = "Resolve Overlapping"
			Me.checkEditResolveOverlapping.Size = New System.Drawing.Size(122, 19)
			Me.checkEditResolveOverlapping.TabIndex = 53
'			Me.checkEditResolveOverlapping.CheckedChanged += New System.EventHandler(Me.checkEditResolveOverlapping_CheckedChanged);
			' 
			' labelIndent
			' 
			Me.labelIndent.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.labelIndent.Location = New System.Drawing.Point(150, 11)
			Me.labelIndent.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
			Me.labelIndent.Name = "labelIndent"
			Me.labelIndent.Size = New System.Drawing.Size(36, 13)
			Me.labelIndent.TabIndex = 54
			Me.labelIndent.Text = "Indent:"
			' 
			' spinIndent
			' 
			Me.spinIndent.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinIndent.Location = New System.Drawing.Point(189, 9)
			Me.spinIndent.Name = "spinIndent"
			Me.spinIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinIndent.Properties.IsFloatValue = False
			Me.spinIndent.Properties.Mask.EditMask = "N00"
			Me.spinIndent.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinIndent.Properties.MinValue = New Decimal(New Integer() { 10, 0, 0, -2147483648})
			Me.spinIndent.Properties.ValidateOnEnterKey = True
			Me.spinIndent.Size = New System.Drawing.Size(58, 20)
			Me.spinIndent.TabIndex = 55
'			Me.spinIndent.EditValueChanged += New System.EventHandler(Me.spinIndent_EditValueChanged);
			' 
			' ResolveOverlappingFor3dPieDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ResolveOverlappingFor3dPieDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(simpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pie3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pie3DSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pie3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
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
