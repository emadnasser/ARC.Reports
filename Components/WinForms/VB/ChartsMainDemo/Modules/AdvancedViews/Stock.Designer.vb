Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AdvancedViews
	Partial Public Class StockDemo
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
			Dim stockSeriesLabel1 As New DevExpress.XtraCharts.StockSeriesLabel()
			Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
			Dim financialSlideAnimation1 As New DevExpress.XtraCharts.FinancialSlideAnimation()
			Dim elasticEasingFunction1 As New DevExpress.XtraCharts.ElasticEasingFunction()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.comboBoxEditStockType = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelStockType = New DevExpress.XtraEditors.LabelControl()
			CType(Me.comboBoxEditReductionLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditLabelLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditWorkdaysOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditStockType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEditReductionLevel
			' 
			Me.comboBoxEditReductionLevel.TabIndex = 1
			' 
			' comboBoxEditLabelLevel
			' 
			Me.comboBoxEditLabelLevel.TabIndex = 0
			' 
			' checkEditWorkdaysOnly
			' 
			Me.checkEditWorkdaysOnly.TabIndex = 3
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelStockType)
			Me.panel.Controls.Add(Me.comboBoxEditStockType)
			Me.panel.Size = New System.Drawing.Size(697, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditWorkdaysOnly, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditReductionLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditLabelLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditStockType, 0)
			Me.panel.Controls.SetChildIndex(Me.labelStockType, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.TabIndex = 4
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(697, 46)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.CrosshairOptions.GroupHeaderPattern = "{A:d}"
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.Label.Staggered = True
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 2R
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Text = "US Dollars"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisualRange.Auto = False
			xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "855"
			xyDiagram1.AxisY.VisualRange.MinValueSerializable = "665"
			xyDiagram1.AxisY.WholeRange.Auto = False
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "855"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "665"
			xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.CrosshairLabelPattern = "High: {HV}" & Constants.vbLf & "Low: {LV}" & Constants.vbLf & "Open: {OV}" & Constants.vbLf & "Close: {CV}"
			stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			stockSeriesLabel1.TextPattern = "{CV:F2}"
			series1.Label = stockSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Google Inc."
			financialSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromBottom
			elasticEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
			financialSlideAnimation1.EasingFunction = elasticEasingFunction1
			stockSeriesView1.Animation = financialSlideAnimation1
			stockSeriesView1.Color = System.Drawing.Color.Black
			series1.View = stockSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(697, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Stock Prices"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.quandl.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' comboBoxEditStockType
			' 
			Me.comboBoxEditStockType.EditValue = ""
			Me.comboBoxEditStockType.Location = New System.Drawing.Point(403, 9)
			Me.comboBoxEditStockType.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
			Me.comboBoxEditStockType.Name = "comboBoxEditStockType"
			Me.comboBoxEditStockType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditStockType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditStockType.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditStockType.TabIndex = 2
'			Me.comboBoxEditStockType.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditStockType_SelectedIndexChanged);
			' 
			' labelStockType
			' 
			Me.labelStockType.Location = New System.Drawing.Point(343, 12)
			Me.labelStockType.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.labelStockType.Name = "labelStockType"
			Me.labelStockType.Size = New System.Drawing.Size(57, 13)
			Me.labelStockType.TabIndex = 15
			Me.labelStockType.Text = "Stock Type:"
			' 
			' StockDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "StockDemo"
			Me.Size = New System.Drawing.Size(697, 500)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.comboBoxEditReductionLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditLabelLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditWorkdaysOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditStockType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelStockType As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
