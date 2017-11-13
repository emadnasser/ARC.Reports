Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class FibonacciIndicatorsDemo
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
			Dim crosshairFreePosition1 As New DevExpress.XtraCharts.CrosshairFreePosition()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim stockSeriesLabel1 As New DevExpress.XtraCharts.StockSeriesLabel()
			Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
			Dim financialSlideAnimation1 As New DevExpress.XtraCharts.FinancialSlideAnimation()
			Dim fibonacciIndicator1 As New DevExpress.XtraCharts.FibonacciIndicator()
			Dim stockSeriesView2 As New DevExpress.XtraCharts.StockSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.cheLevel23_6 = New DevExpress.XtraEditors.CheckEdit()
			Me.cheLevel76_4 = New DevExpress.XtraEditors.CheckEdit()
			Me.cheLevel0 = New DevExpress.XtraEditors.CheckEdit()
			Me.cheLevel100 = New DevExpress.XtraEditors.CheckEdit()
			Me.cheAdditionalLevels = New DevExpress.XtraEditors.CheckEdit()
			Me.lblKind = New DevExpress.XtraEditors.LabelControl()
			Me.cbeKind = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(fibonacciIndicator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheLevel23_6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheLevel76_4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheLevel0.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheLevel100.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheAdditionalLevels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.cbeKind)
			Me.panel.Controls.Add(Me.lblKind)
			Me.panel.Controls.Add(Me.cheAdditionalLevels)
			Me.panel.Controls.Add(Me.cheLevel76_4)
			Me.panel.Controls.Add(Me.cheLevel0)
			Me.panel.Controls.Add(Me.cheLevel100)
			Me.panel.Controls.Add(Me.cheLevel23_6)
			Me.panel.Controls.SetChildIndex(Me.cheLevel23_6, 0)
			Me.panel.Controls.SetChildIndex(Me.cheLevel100, 0)
			Me.panel.Controls.SetChildIndex(Me.cheLevel0, 0)
			Me.panel.Controls.SetChildIndex(Me.cheLevel76_4, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cheAdditionalLevels, 0)
			Me.panel.Controls.SetChildIndex(Me.lblKind, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeKind, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			crosshairFreePosition1.DockTargetName = "Default Pane"
			Me.chart.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
			xyDiagram1.AxisX.DateTimeScaleOptions.GridSpacing = 0.5R
			xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOptions.Holidays.AddRange(New DevExpress.XtraCharts.KnownDate() { New DevExpress.XtraCharts.KnownDate("Christmas Day", New System.DateTime(2007, 12, 25, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("New Year's Day", New System.DateTime(2008, 1, 1, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("Martin Luther King Day", New System.DateTime(2008, 1, 21, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("Presidents' Day", New System.DateTime(2008, 2, 18, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("Good Friday", New System.DateTime(2008, 3, 21, 0, 0, 0, 0))})
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 2R
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Text = "US Dollars"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Date"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			series1.Label = stockSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Apple Inc."
			series1.ValueDataMembersSerializable = "Low;High;Open;Close"
			financialSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromRight
			stockSeriesView1.Animation = financialSlideAnimation1
			fibonacciIndicator1.BaseLevelColor = System.Drawing.Color.Green
			fibonacciIndicator1.Name = "Fibonacci Indicator 1"
			fibonacciIndicator1.Point1.ArgumentSerializable = "09/13/2016 00:00:00.000"
			fibonacciIndicator1.Point1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Low
			fibonacciIndicator1.Point2.ArgumentSerializable = "07/10/2016 00:00:00.000"
			fibonacciIndicator1.Point2.ValueLevel = DevExpress.XtraCharts.ValueLevel.High
			fibonacciIndicator1.ShowAdditionalLevels = False
			fibonacciIndicator1.ShowLevel0 = True
			fibonacciIndicator1.ShowLevel100 = True
			fibonacciIndicator1.ShowLevel23_6 = False
			fibonacciIndicator1.ShowLevel76_4 = False
			stockSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() { fibonacciIndicator1})
			series1.View = stockSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.View = stockSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 3
			chartTitle1.Text = "Apple Inc. Stock Prices"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.quandl.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' cheLevel23_6
			' 
			Me.cheLevel23_6.Location = New System.Drawing.Point(190, 37)
			Me.cheLevel23_6.Name = "cheLevel23_6"
			Me.cheLevel23_6.Properties.Caption = "Show Level 23.6%"
			Me.cheLevel23_6.Size = New System.Drawing.Size(112, 19)
			Me.cheLevel23_6.TabIndex = 2
'			Me.cheLevel23_6.CheckedChanged += New System.EventHandler(Me.cheLevel23_6_CheckedChanged);
			' 
			' cheLevel76_4
			' 
			Me.cheLevel76_4.Location = New System.Drawing.Point(319, 37)
			Me.cheLevel76_4.Name = "cheLevel76_4"
			Me.cheLevel76_4.Properties.Caption = "Show Level 76.4%"
			Me.cheLevel76_4.Size = New System.Drawing.Size(112, 19)
			Me.cheLevel76_4.TabIndex = 3
'			Me.cheLevel76_4.CheckedChanged += New System.EventHandler(Me.cheLevel76_4_CheckedChanged);
			' 
			' cheLevel0
			' 
			Me.cheLevel0.Location = New System.Drawing.Point(190, 9)
			Me.cheLevel0.Name = "cheLevel0"
			Me.cheLevel0.Properties.Caption = "Show Level 0%"
			Me.cheLevel0.Size = New System.Drawing.Size(99, 19)
			Me.cheLevel0.TabIndex = 4
'			Me.cheLevel0.CheckedChanged += New System.EventHandler(Me.cheLevel0_CheckedChanged);
			' 
			' cheLevel100
			' 
			Me.cheLevel100.Location = New System.Drawing.Point(319, 9)
			Me.cheLevel100.Name = "cheLevel100"
			Me.cheLevel100.Properties.Caption = "Show Level 100%"
			Me.cheLevel100.Size = New System.Drawing.Size(108, 19)
			Me.cheLevel100.TabIndex = 5
'			Me.cheLevel100.CheckedChanged += New System.EventHandler(Me.cheLevel100_CheckedChanged);
			' 
			' cheAdditionalLevels
			' 
			Me.cheAdditionalLevels.Location = New System.Drawing.Point(12, 37)
			Me.cheAdditionalLevels.Name = "cheAdditionalLevels"
			Me.cheAdditionalLevels.Properties.Caption = "Show Additional Levels"
			Me.cheAdditionalLevels.Size = New System.Drawing.Size(132, 19)
			Me.cheAdditionalLevels.TabIndex = 6
'			Me.cheAdditionalLevels.CheckedChanged += New System.EventHandler(Me.cheAdditionalLevels_CheckedChanged);
			' 
			' lblKind
			' 
			Me.lblKind.Location = New System.Drawing.Point(12, 12)
			Me.lblKind.Name = "lblKind"
			Me.lblKind.Size = New System.Drawing.Size(24, 13)
			Me.lblKind.TabIndex = 7
			Me.lblKind.Text = "Kind:"
			' 
			' cbeKind
			' 
			Me.cbeKind.EditValue = "Fibonacci Arcs"
			Me.cbeKind.Location = New System.Drawing.Point(42, 9)
			Me.cbeKind.Name = "cbeKind"
			Me.cbeKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeKind.Properties.Items.AddRange(New Object() { "Fibonacci Arcs", "Fibonacci Fans", "Fibonacci Retracement"})
			Me.cbeKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeKind.Size = New System.Drawing.Size(130, 20)
			Me.cbeKind.TabIndex = 8
'			Me.cbeKind.SelectedIndexChanged += New System.EventHandler(Me.cbeKind_SelectedIndexChanged);
			' 
			' FibonacciIndicatorsDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "FibonacciIndicatorsDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(fibonacciIndicator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheLevel23_6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheLevel76_4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheLevel0.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheLevel100.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheAdditionalLevels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private WithEvents cheLevel100 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cheLevel0 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cheLevel76_4 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cheLevel23_6 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbeKind As DevExpress.XtraEditors.ComboBoxEdit
		Private lblKind As DevExpress.XtraEditors.LabelControl
		Private WithEvents cheAdditionalLevels As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
