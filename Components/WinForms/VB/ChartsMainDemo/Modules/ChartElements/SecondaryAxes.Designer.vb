Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class SecondaryAxesDemo
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(40R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(30R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(25R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(22.5R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (CObj(21.25R))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(1700R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(900R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(500R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(300R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (CObj(200R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (CObj(150R))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (CObj(125R))})
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.lbChartType = New DevExpress.XtraEditors.LabelControl()
			Me.cbChartType = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbSeriesAxisX = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbSeriesAxisY = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbSeriesTwoAxisX = New DevExpress.XtraEditors.LabelControl()
			Me.lbSeriesTwoAxisY = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbChartType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbSeriesAxisX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbSeriesAxisY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lbSeriesTwoAxisY)
			Me.panel.Controls.Add(Me.lbSeriesTwoAxisX)
			Me.panel.Controls.Add(Me.cbSeriesAxisY)
			Me.panel.Controls.Add(Me.cbSeriesAxisX)
			Me.panel.Controls.Add(Me.lbChartType)
			Me.panel.Controls.Add(Me.cbChartType)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cbChartType, 0)
			Me.panel.Controls.SetChildIndex(Me.lbChartType, 0)
			Me.panel.Controls.SetChildIndex(Me.cbSeriesAxisX, 0)
			Me.panel.Controls.SetChildIndex(Me.cbSeriesAxisY, 0)
			Me.panel.Controls.SetChildIndex(Me.lbSeriesTwoAxisX, 0)
			Me.panel.Controls.SetChildIndex(Me.lbSeriesTwoAxisY, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 5
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.CrosshairOptions.GroupHeaderPattern = "{A}"
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Title.Text = "Axis X"
			xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Title.Text = "Axis Y"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Margins.Bottom = 10
			Me.chart.Legend.Margins.Left = 10
			Me.chart.Legend.Margins.Right = 10
			Me.chart.Legend.Margins.Top = 10
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint
			pointSeriesLabel1.TextPattern = "{A}: {V}"
			series1.Label = pointSeriesLabel1
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
			series1.View = lineSeriesView1
			pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint
			pointSeriesLabel2.TextPattern = "{A}: {V}"
			series2.Label = pointSeriesLabel2
			series2.Name = "Series 2"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
			lineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
			series2.View = lineSeriesView2
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			' 
			' lbChartType
			' 
			Me.lbChartType.Location = New System.Drawing.Point(12, 12)
			Me.lbChartType.Name = "lbChartType"
			Me.lbChartType.Size = New System.Drawing.Size(58, 13)
			Me.lbChartType.TabIndex = 19
			Me.lbChartType.Text = "Chart Type:"
			' 
			' cbChartType
			' 
			Me.cbChartType.EditValue = ""
			Me.cbChartType.Location = New System.Drawing.Point(74, 9)
			Me.cbChartType.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.cbChartType.Name = "cbChartType"
			Me.cbChartType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbChartType.Size = New System.Drawing.Size(50, 20)
			Me.cbChartType.TabIndex = 18
'			Me.cbChartType.SelectedIndexChanged += New System.EventHandler(Me.cbChartType_SelectedIndexChanged);
			' 
			' cbSeriesAxisX
			' 
			Me.cbSeriesAxisX.EditValue = ""
			Me.cbSeriesAxisX.Location = New System.Drawing.Point(214, 9)
			Me.cbSeriesAxisX.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.cbSeriesAxisX.Name = "cbSeriesAxisX"
			Me.cbSeriesAxisX.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbSeriesAxisX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbSeriesAxisX.Size = New System.Drawing.Size(105, 20)
			Me.cbSeriesAxisX.TabIndex = 20
'			Me.cbSeriesAxisX.SelectedIndexChanged += New System.EventHandler(Me.cbSeriesAxisX_SelectedIndexChanged);
			' 
			' cbSeriesAxisY
			' 
			Me.cbSeriesAxisY.EditValue = ""
			Me.cbSeriesAxisY.Location = New System.Drawing.Point(409, 9)
			Me.cbSeriesAxisY.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.cbSeriesAxisY.Name = "cbSeriesAxisY"
			Me.cbSeriesAxisY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbSeriesAxisY.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbSeriesAxisY.Size = New System.Drawing.Size(105, 20)
			Me.cbSeriesAxisY.TabIndex = 21
'			Me.cbSeriesAxisY.SelectedIndexChanged += New System.EventHandler(Me.cbSeriesAxisY_SelectedIndexChanged);
			' 
			' lbSeriesTwoAxisX
			' 
			Me.lbSeriesTwoAxisX.Location = New System.Drawing.Point(137, 12)
			Me.lbSeriesTwoAxisX.Name = "lbSeriesTwoAxisX"
			Me.lbSeriesTwoAxisX.Size = New System.Drawing.Size(74, 13)
			Me.lbSeriesTwoAxisX.TabIndex = 22
			Me.lbSeriesTwoAxisX.Text = "Series 2 Axis X:"
			' 
			' lbSeriesTwoAxisY
			' 
			Me.lbSeriesTwoAxisY.Location = New System.Drawing.Point(332, 12)
			Me.lbSeriesTwoAxisY.Name = "lbSeriesTwoAxisY"
			Me.lbSeriesTwoAxisY.Size = New System.Drawing.Size(74, 13)
			Me.lbSeriesTwoAxisY.TabIndex = 23
			Me.lbSeriesTwoAxisY.Text = "Series 2 Axis Y:"
			' 
			' SecondaryAxesDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "SecondaryAxesDemo"
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
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbChartType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbSeriesAxisX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbSeriesAxisY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private lbChartType As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbChartType As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbSeriesAxisY As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbSeriesAxisX As DevExpress.XtraEditors.ComboBoxEdit
		Private lbSeriesTwoAxisY As DevExpress.XtraEditors.LabelControl
		Private lbSeriesTwoAxisX As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
