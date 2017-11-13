Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class LogarithmicScaleDemo
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
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (CObj(1436R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (CObj(1718R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (CObj(2156R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (CObj(2644R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (CObj(3180R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (CObj(3678R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (CObj(4149R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (CObj(4611R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (CObj(4992R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (CObj(5290R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (CObj(5503R))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim xySeriesUnwrapAnimation1 As New DevExpress.XtraCharts.XYSeriesUnwrapAnimation()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (CObj(227R))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (CObj(285R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (CObj(365R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (CObj(478R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (CObj(633R))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (CObj(810R))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (CObj(1016R))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (CObj(1251R))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (CObj(1507R))})
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (CObj(1783R))})
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (CObj(2073R))})
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Dim xySeriesUnwrapAnimation2 As New DevExpress.XtraCharts.XYSeriesUnwrapAnimation()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (CObj(331R))})
			Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (CObj(416R))})
			Dim seriesPoint25 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (CObj(512R))})
			Dim seriesPoint26 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (CObj(612R))})
			Dim seriesPoint27 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (CObj(720R))})
			Dim seriesPoint28 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (CObj(833R))})
			Dim seriesPoint29 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (CObj(936R))})
			Dim seriesPoint30 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (CObj(1036R))})
			Dim seriesPoint31 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (CObj(1126R))})
			Dim seriesPoint32 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (CObj(1202R))})
			Dim seriesPoint33 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (CObj(1263R))})
			Dim lineSeriesView3 As New DevExpress.XtraCharts.LineSeriesView()
			Dim xySeriesUnwrapAnimation3 As New DevExpress.XtraCharts.XYSeriesUnwrapAnimation()
			Dim series4 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel4 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint34 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (CObj(547R))})
			Dim seriesPoint35 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (CObj(605R))})
			Dim seriesPoint36 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (CObj(657R))})
			Dim seriesPoint37 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (CObj(695R))})
			Dim seriesPoint38 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (CObj(722R))})
			Dim seriesPoint39 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (CObj(731R))})
			Dim seriesPoint40 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (CObj(728R))})
			Dim seriesPoint41 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (CObj(720R))})
			Dim seriesPoint42 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (CObj(702R))})
			Dim seriesPoint43 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (CObj(678R))})
			Dim seriesPoint44 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (CObj(648R))})
			Dim lineSeriesView4 As New DevExpress.XtraCharts.LineSeriesView()
			Dim xySeriesUnwrapAnimation4 As New DevExpress.XtraCharts.XYSeriesUnwrapAnimation()
			Dim series5 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel5 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint45 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (CObj(12R))})
			Dim seriesPoint46 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (CObj(15R))})
			Dim seriesPoint47 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (CObj(19R))})
			Dim seriesPoint48 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (CObj(22R))})
			Dim seriesPoint49 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (CObj(26R))})
			Dim seriesPoint50 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (CObj(30R))})
			Dim seriesPoint51 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (CObj(35R))})
			Dim seriesPoint52 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (CObj(39R))})
			Dim seriesPoint53 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (CObj(43R))})
			Dim seriesPoint54 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (CObj(47R))})
			Dim seriesPoint55 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (CObj(50R))})
			Dim lineSeriesView5 As New DevExpress.XtraCharts.LineSeriesView()
			Dim xySeriesUnwrapAnimation5 As New DevExpress.XtraCharts.XYSeriesUnwrapAnimation()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.chLogarithmic = New DevExpress.XtraEditors.CheckEdit()
			Me.cbLogarithmicBase = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblLogarithmicBase = New DevExpress.XtraEditors.LabelControl()
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
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chLogarithmic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLogarithmicBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.chLogarithmic)
			Me.panel.Controls.Add(Me.cbLogarithmicBase)
			Me.panel.Controls.Add(Me.lblLogarithmicBase)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.lblLogarithmicBase, 0)
			Me.panel.Controls.SetChildIndex(Me.cbLogarithmicBase, 0)
			Me.panel.Controls.SetChildIndex(Me.chLogarithmic, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
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
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.Title.Text = "Years"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Logarithmic = True
			xyDiagram1.AxisY.MinorCount = 4
			xyDiagram1.AxisY.Title.Text = "Population mid-year, millions"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			pointSeriesLabel1.Angle = 90
			pointSeriesLabel1.BackColor = System.Drawing.Color.Transparent
			pointSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel1.LineLength = 6
			pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Label = pointSeriesLabel1
			series1.Name = "Asia"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11})
			xySeriesUnwrapAnimation1.BeginTime = System.TimeSpan.Parse("00:00:01.6000000")
			lineSeriesView1.SeriesAnimation = xySeriesUnwrapAnimation1
			series1.View = lineSeriesView1
			pointSeriesLabel2.Angle = -45
			pointSeriesLabel2.BackColor = System.Drawing.Color.Transparent
			pointSeriesLabel2.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel2.LineLength = 6
			pointSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint
			series2.Label = pointSeriesLabel2
			series2.Name = "Africa"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22})
			lineSeriesView2.LineMarkerOptions.Size = 8
			xySeriesUnwrapAnimation2.BeginTime = System.TimeSpan.Parse("00:00:00.4000000")
			lineSeriesView2.SeriesAnimation = xySeriesUnwrapAnimation2
			series2.View = lineSeriesView2
			pointSeriesLabel3.BackColor = System.Drawing.Color.Transparent
			pointSeriesLabel3.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel3.LineLength = 6
			pointSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint
			series3.Label = pointSeriesLabel3
			series3.Name = "Americas"
			series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32, seriesPoint33})
			lineSeriesView3.LineMarkerOptions.Size = 8
			xySeriesUnwrapAnimation3.BeginTime = System.TimeSpan.Parse("00:00:00.8000000")
			lineSeriesView3.SeriesAnimation = xySeriesUnwrapAnimation3
			series3.View = lineSeriesView3
			pointSeriesLabel4.BackColor = System.Drawing.Color.Transparent
			pointSeriesLabel4.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel4.LineLength = 6
			pointSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel4.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint
			series4.Label = pointSeriesLabel4
			series4.Name = "Europe"
			series4.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint34, seriesPoint35, seriesPoint36, seriesPoint37, seriesPoint38, seriesPoint39, seriesPoint40, seriesPoint41, seriesPoint42, seriesPoint43, seriesPoint44})
			lineSeriesView4.LineMarkerOptions.Size = 8
			xySeriesUnwrapAnimation4.BeginTime = System.TimeSpan.Parse("00:00:01.2000000")
			lineSeriesView4.SeriesAnimation = xySeriesUnwrapAnimation4
			series4.View = lineSeriesView4
			pointSeriesLabel5.Angle = 90
			pointSeriesLabel5.BackColor = System.Drawing.Color.Transparent
			pointSeriesLabel5.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pointSeriesLabel5.LineLength = 6
			pointSeriesLabel5.LineVisibility = DevExpress.Utils.DefaultBoolean.False
			series5.Label = pointSeriesLabel5
			series5.Name = "Oceania"
			series5.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint45, seriesPoint46, seriesPoint47, seriesPoint48, seriesPoint49, seriesPoint50, seriesPoint51, seriesPoint52, seriesPoint53, seriesPoint54, seriesPoint55})
			lineSeriesView5.SeriesAnimation = xySeriesUnwrapAnimation5
			series5.View = lineSeriesView5
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3, series4, series5}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Historic, Current and Future Population "
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.geohive.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' chLogarithmic
			' 
			Me.chLogarithmic.Location = New System.Drawing.Point(12, 9)
			Me.chLogarithmic.Name = "chLogarithmic"
			Me.chLogarithmic.Properties.Caption = "Enabled"
			Me.chLogarithmic.Size = New System.Drawing.Size(63, 19)
			Me.chLogarithmic.TabIndex = 2
'			Me.chLogarithmic.CheckedChanged += New System.EventHandler(Me.chLogarithmic_CheckedChanged);
			' 
			' cbLogarithmicBase
			' 
			Me.cbLogarithmicBase.Location = New System.Drawing.Point(174, 9)
			Me.cbLogarithmicBase.Name = "cbLogarithmicBase"
			Me.cbLogarithmicBase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLogarithmicBase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLogarithmicBase.Size = New System.Drawing.Size(46, 20)
			Me.cbLogarithmicBase.TabIndex = 3
'			Me.cbLogarithmicBase.SelectedIndexChanged += New System.EventHandler(Me.cbLogarithmicBase_SelectedIndexChanged);
			' 
			' lblLogarithmicBase
			' 
			Me.lblLogarithmicBase.Location = New System.Drawing.Point(84, 12)
			Me.lblLogarithmicBase.Name = "lblLogarithmicBase"
			Me.lblLogarithmicBase.Size = New System.Drawing.Size(84, 13)
			Me.lblLogarithmicBase.TabIndex = 4
			Me.lblLogarithmicBase.Text = "Logarithmic base:"
			' 
			' LogarithmicScaleDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "LogarithmicScaleDemo"
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
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chLogarithmic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLogarithmicBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private WithEvents chLogarithmic As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbLogarithmicBase As DevExpress.XtraEditors.ComboBoxEdit
		Private lblLogarithmicBase As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
