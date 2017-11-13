Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataAggregation
	Partial Public Class CurrencyExchangeRatesDemo
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim rangeControlRange1 As New DevExpress.XtraEditors.RangeControlRange()
			Dim crosshairFreePosition1 As New DevExpress.XtraCharts.CrosshairFreePosition()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Dim lineSeriesView3 As New DevExpress.XtraCharts.LineSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.rangeControl1 = New DevExpress.XtraEditors.RangeControl()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.rangeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Visible = False
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(13946, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' panelRoot
			' 
			Me.panelRoot.Visible = False
			' 
			' rangeControl1
			' 
			Me.rangeControl1.Client = Me.chart
			Me.rangeControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rangeControl1.Location = New System.Drawing.Point(0, 0)
			Me.rangeControl1.Name = "rangeControl1"
			rangeControlRange1.Owner = Me.rangeControl1
			Me.rangeControl1.SelectedRange = rangeControlRange1
			Me.rangeControl1.Size = New System.Drawing.Size(700, 99)
			Me.rangeControl1.TabIndex = 4
			Me.rangeControl1.Text = "rangeControl1"
			' 
			' chart
			' 
			Me.chart.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			crosshairFreePosition1.DockTargetName = "Default Pane"
			Me.chart.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1
			Me.chart.CrosshairOptions.GroupHeaderPattern = "<b>{A:d}</b>"
			Me.chart.CrosshairOptions.ShowArgumentLabels = True
			Me.chart.CrosshairOptions.ShowValueLabels = True
			Me.chart.CrosshairOptions.ShowValueLine = True
			Me.chart.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.VisualRange.Auto = False
			xyDiagram1.AxisY.Label.TextPattern = "{V:F4}"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			xyDiagram1.EnableAxisXScrolling = True
			xyDiagram1.EnableAxisXZooming = True
			xyDiagram1.RangeControlDateTimeGridOptions.SnapAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
			xyDiagram1.RangeControlDateTimeGridOptions.SnapMode = DevExpress.XtraCharts.ChartRangeControlClientSnapMode.Manual
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 0)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.CrosshairLabelPattern = "<b>EUR : {V:F4}</b>"
			series1.Name = "EURUSD"
			series1.View = lineSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series2.CrosshairLabelPattern = "<b>GBP : {V:F4}</b>"
			series2.Name = "GBPUSD"
			series2.View = lineSeriesView2
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chart.SeriesTemplate.View = lineSeriesView3
			Me.chart.Size = New System.Drawing.Size(700, 397)
			Me.chart.TabIndex = 3
			chartTitle1.Text = "Currency Exchange Rates"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
'			Me.chart.CustomDrawCrosshair += New DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(Me.CustomDrawCrosshair);
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.chart)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.rangeControl1)
			Me.splitContainer1.Size = New System.Drawing.Size(700, 500)
			Me.splitContainer1.SplitterDistance = 397
			Me.splitContainer1.TabIndex = 4
			' 
			' CurrencyExchangeRatesDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.splitContainer1)
			Me.Name = "CurrencyExchangeRatesDemo"
			Me.Controls.SetChildIndex(Me.splitContainer1, 0)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.rangeControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private rangeControl1 As XtraEditors.RangeControl
	End Class
End Namespace
