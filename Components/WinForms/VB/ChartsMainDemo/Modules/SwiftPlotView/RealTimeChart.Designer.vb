Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.SwiftPlotView
	Partial Public Class RealtimeChartDemo
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
			Me.components = New System.ComponentModel.Container()
			Dim swiftPlotDiagram2 As New DevExpress.XtraCharts.SwiftPlotDiagram()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim swiftPlotSeriesView3 As New DevExpress.XtraCharts.SwiftPlotSeriesView()
			Dim regressionLine3 As New DevExpress.XtraCharts.RegressionLine()
			Dim series4 As New DevExpress.XtraCharts.Series()
			Dim swiftPlotSeriesView4 As New DevExpress.XtraCharts.SwiftPlotSeriesView()
			Dim regressionLine4 As New DevExpress.XtraCharts.RegressionLine()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.timer = New System.Windows.Forms.Timer(Me.components)
			Me.btnPauseResume = New DevExpress.XtraEditors.SimpleButton()
			Me.lblWindowSize = New DevExpress.XtraEditors.LabelControl()
			Me.spnTimeInterval = New DevExpress.XtraEditors.SpinEdit()
			Me.chRegression = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(regressionLine3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(regressionLine4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spnTimeInterval.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chRegression.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.chRegression)
			Me.panel.Controls.Add(Me.spnTimeInterval)
			Me.panel.Controls.Add(Me.btnPauseResume)
			Me.panel.Controls.Add(Me.lblWindowSize)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.lblWindowSize, 0)
			Me.panel.Controls.SetChildIndex(Me.btnPauseResume, 0)
			Me.panel.Controls.SetChildIndex(Me.spnTimeInterval, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.chRegression, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(603, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			swiftPlotDiagram2.AxisX.GridLines.Visible = True
			swiftPlotDiagram2.AxisX.Label.TextPattern = "{A:mm:ss}"
			swiftPlotDiagram2.AxisX.Title.Text = "Time"
			swiftPlotDiagram2.AxisX.VisibleInPanesSerializable = "-1"
			swiftPlotDiagram2.AxisY.Interlaced = True
			swiftPlotDiagram2.AxisY.Title.Text = "Values"
			swiftPlotDiagram2.AxisY.VisibleInPanesSerializable = "-1"
			swiftPlotDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
			swiftPlotDiagram2.Margins.Right = 15
			Me.chart.Diagram = swiftPlotDiagram2
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series3.Name = "Process 1"
			regressionLine3.Name = "Regression Line"
			swiftPlotSeriesView3.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() { regressionLine3})
			series3.View = swiftPlotSeriesView3
			series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series4.Name = "Process 2"
			regressionLine4.Name = "Regression Line"
			swiftPlotSeriesView4.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() { regressionLine4})
			series4.View = swiftPlotSeriesView4
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series3, series4}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			' 
			' timer
			' 
			Me.timer.Enabled = True
'			Me.timer.Tick += New System.EventHandler(Me.timer_Tick);
			' 
			' btnPauseResume
			' 
			Me.btnPauseResume.Location = New System.Drawing.Point(12, 8)
			Me.btnPauseResume.Name = "btnPauseResume"
			Me.btnPauseResume.Size = New System.Drawing.Size(84, 22)
			Me.btnPauseResume.TabIndex = 2
'			Me.btnPauseResume.Click += New System.EventHandler(Me.btnPauseResume_Click);
			' 
			' lblWindowSize
			' 
			Me.lblWindowSize.Cursor = System.Windows.Forms.Cursors.Default
			Me.lblWindowSize.Location = New System.Drawing.Point(110, 12)
			Me.lblWindowSize.Name = "lblWindowSize"
			Me.lblWindowSize.Size = New System.Drawing.Size(115, 13)
			Me.lblWindowSize.TabIndex = 10
			Me.lblWindowSize.Text = "Time interval (seconds):"
			' 
			' spnTimeInterval
			' 
			Me.spnTimeInterval.EditValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spnTimeInterval.Location = New System.Drawing.Point(231, 9)
			Me.spnTimeInterval.Name = "spnTimeInterval"
			Me.spnTimeInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spnTimeInterval.Properties.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.spnTimeInterval.Properties.IsFloatValue = False
			Me.spnTimeInterval.Properties.Mask.EditMask = "N00"
			Me.spnTimeInterval.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spnTimeInterval.Properties.MinValue = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.spnTimeInterval.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.spnTimeInterval.Size = New System.Drawing.Size(56, 20)
			Me.spnTimeInterval.TabIndex = 11
			' 
			' chRegression
			' 
			Me.chRegression.EditValue = True
			Me.chRegression.Location = New System.Drawing.Point(304, 9)
			Me.chRegression.Name = "chRegression"
			Me.chRegression.Properties.Caption = "Show regression lines"
			Me.chRegression.Size = New System.Drawing.Size(125, 19)
			Me.chRegression.TabIndex = 13
'			Me.chRegression.CheckedChanged += New System.EventHandler(Me.chRegression_CheckedChanged);
			' 
			' RealtimeChartDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "RealtimeChartDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(swiftPlotDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(regressionLine3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(swiftPlotSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(regressionLine4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(swiftPlotSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spnTimeInterval.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chRegression.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private WithEvents timer As System.Windows.Forms.Timer
		Private WithEvents btnPauseResume As DevExpress.XtraEditors.SimpleButton
		Private lblWindowSize As DevExpress.XtraEditors.LabelControl
		Private spnTimeInterval As DevExpress.XtraEditors.SpinEdit
		Private WithEvents chRegression As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
