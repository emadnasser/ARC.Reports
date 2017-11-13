Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class EmptyPointsDemo
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
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 1, 0, 0, 0, 0), New Object() { (CObj(65R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 2, 0, 0, 0, 0), New Object() { (CObj(78R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 3, 0, 0, 0, 0), New Object() { (CObj(95R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 4, 0, 0, 0, 0), New Object() { (CObj(110R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 5, 0, 0, 0, 0), New Object() { (CObj(108R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 6, 0, 0, 0, 0), New Object() { (CObj(52R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 7, 0, 0, 0, 0), New Object() { (CObj(46R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 8, 0, 0, 0, 0), New Object() { (CObj(70R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 9, 0, 0, 0, 0), New Object() { (CObj(86R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 10, 0, 0, 0, 0), New Object() { (CObj(92R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 11, 0, 0, 0, 0), New Object() { (CObj(108R))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 12, 0, 0, 0, 0), New Object() { (CObj(115R))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 13, 0, 0, 0, 0), New Object() { (CObj(75R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 14, 0, 0, 0, 0), New Object() { (CObj(65R))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 1, 0, 0, 0, 0), New Object() { (CObj(56R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 2, 0, 0, 0, 0), New Object() { (CObj(45R))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 3, 0, 0, 0, 0), New Object() { (CObj(70R))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 4, 0, 0, 0, 0), New Object() { (CObj(82R))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 5, 0, 0, 0, 0), New Object() { (CObj(80R))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 6, 0, 0, 0, 0), New Object() { (CObj(20R))})
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 7, 0, 0, 0, 0), New Object() { (CObj(10R))})
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 8, 0, 0, 0, 0))
			Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 9, 0, 0, 0, 0))
			Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 10, 0, 0, 0, 0), New Object() { (CObj(65R))})
			Dim seriesPoint25 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 11, 0, 0, 0, 0), New Object() { (CObj(45R))})
			Dim seriesPoint26 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 12, 0, 0, 0, 0), New Object() { (CObj(56R))})
			Dim seriesPoint27 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 13, 0, 0, 0, 0), New Object() { (CObj(10R))})
			Dim seriesPoint28 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 14, 0, 0, 0, 0), New Object() { (CObj(0R))})
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint29 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 1, 0, 0, 0, 0), New Object() { (CObj(45R))})
			Dim seriesPoint30 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 2, 0, 0, 0, 0), New Object() { (CObj(40R))})
			Dim seriesPoint31 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 3, 0, 0, 0, 0), New Object() { (CObj(56R))})
			Dim seriesPoint32 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 4, 0, 0, 0, 0), New Object() { (CObj(47R))})
			Dim seriesPoint33 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 5, 0, 0, 0, 0), New Object() { (CObj(38R))})
			Dim seriesPoint34 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 6, 0, 0, 0, 0), New Object() { (CObj(31R))})
			Dim seriesPoint35 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 7, 0, 0, 0, 0), New Object() { (CObj(27R))})
			Dim seriesPoint36 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 8, 0, 0, 0, 0), New Object() { (CObj(37R))})
			Dim seriesPoint37 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 9, 0, 0, 0, 0), New Object() { (CObj(42R))})
			Dim seriesPoint38 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 10, 0, 0, 0, 0))
			Dim seriesPoint39 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 11, 0, 0, 0, 0), New Object() { (CObj(37R))})
			Dim seriesPoint40 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 12, 0, 0, 0, 0), New Object() { (CObj(21R))})
			Dim seriesPoint41 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 13, 0, 0, 0, 0), New Object() { (CObj(10R))})
			Dim seriesPoint42 As New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2016, 11, 14, 0, 0, 0, 0), New Object() { (CObj(5R))})
			Dim lineSeriesView3 As New DevExpress.XtraCharts.LineSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelViewType = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditViewType = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditViewType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelViewType)
			Me.panel.Controls.Add(Me.comboBoxEditViewType)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditViewType, 0)
			Me.panel.Controls.SetChildIndex(Me.labelViewType, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.CrosshairOptions.GroupHeaderPattern = "{A:d}"
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Label.Staggered = True
			xyDiagram1.AxisX.Label.TextPattern = "{A:m}"
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Title.Text = "Number of visitors"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.MaxHorizontalPercentage = 50R
			Me.chart.Legend.MaxVerticalPercentage = 50R
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.Name = "Politics"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14})
			series1.View = lineSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series2.Name = "Entertainment"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28})
			series2.View = lineSeriesView2
			series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series3.Name = "Travel"
			series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32, seriesPoint33, seriesPoint34, seriesPoint35, seriesPoint36, seriesPoint37, seriesPoint38, seriesPoint39, seriesPoint40, seriesPoint41, seriesPoint42})
			series3.View = lineSeriesView3
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
			sideBySideBarSeriesLabel1.TextPattern = "{V:G2}"
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "News Website Popularity "
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' labelViewType
			' 
			Me.labelViewType.Location = New System.Drawing.Point(12, 12)
			Me.labelViewType.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelViewType.Name = "labelViewType"
			Me.labelViewType.Size = New System.Drawing.Size(53, 13)
			Me.labelViewType.TabIndex = 58
			Me.labelViewType.Text = "View Type:"
			' 
			' comboBoxEditViewType
			' 
			Me.comboBoxEditViewType.EditValue = "Lines"
			Me.comboBoxEditViewType.Location = New System.Drawing.Point(68, 9)
			Me.comboBoxEditViewType.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.comboBoxEditViewType.Name = "comboBoxEditViewType"
			Me.comboBoxEditViewType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditViewType.Properties.Items.AddRange(New Object() { "Lines", "Stacked Lines", "Full-Stacked Lines", "Step Lines", "Areas", "Step Areas", "Stacked Areas", "Full-Stacked Areas", "3D Lines", "3D Stacked Lines", "3D Full-Stacked Lines", "3D Step Lines", "3D Areas", "3D Stacked Areas", "3D Full-Stacked Areas", "3D Step Areas", "Spline", "Spline Area", "Stacked Spline", "Full-Stacked Spline", "Spline 3D", "Spline Area 3D", "Stacked Spline 3D", "Full-Stacked Spline 3D"})
			Me.comboBoxEditViewType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditViewType.Size = New System.Drawing.Size(141, 20)
			Me.comboBoxEditViewType.TabIndex = 0
'			Me.comboBoxEditViewType.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditViewType_SelectedIndexChanged);
			' 
			' EmptyPointsDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "EmptyPointsDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditViewType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelViewType As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxEditViewType As DevExpress.XtraEditors.ComboBoxEdit

	End Class
End Namespace
