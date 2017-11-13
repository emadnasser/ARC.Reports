Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class PriceIndicatorsDemo
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim stockSeriesLabel1 As New DevExpress.XtraCharts.StockSeriesLabel()
			Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
			Dim medianPrice1 As New DevExpress.XtraCharts.MedianPrice()
			Dim typicalPrice1 As New DevExpress.XtraCharts.TypicalPrice()
			Dim weightedClose1 As New DevExpress.XtraCharts.WeightedClose()
			Dim stockSeriesView2 As New DevExpress.XtraCharts.StockSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.lblIndicator = New DevExpress.XtraEditors.LabelControl()
			Me.cbePriceIndicator = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbDashStyle = New DevExpress.XtraEditors.LabelControl()
			Me.cbDashStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.clreColor = New DevExpress.XtraEditors.ColorEdit()
			Me.lbColor = New DevExpress.XtraEditors.LabelControl()
			Me.lbThickness = New DevExpress.XtraEditors.LabelControl()
			Me.speThickness = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(medianPrice1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(typicalPrice1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(weightedClose1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbePriceIndicator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbDashStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.clreColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.speThickness.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.panel.Controls.Add(Me.cbePriceIndicator)
			Me.panel.Controls.Add(Me.lblIndicator)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.lblIndicator, 0)
			Me.panel.Controls.SetChildIndex(Me.cbePriceIndicator, 0)
			Me.panel.Controls.SetChildIndex(Me.speThickness, 0)
			Me.panel.Controls.SetChildIndex(Me.lbThickness, 0)
			Me.panel.Controls.SetChildIndex(Me.lbColor, 0)
			Me.panel.Controls.SetChildIndex(Me.clreColor, 0)
			Me.panel.Controls.SetChildIndex(Me.cbDashStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.lbDashStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(-55, -20)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOptions.Holidays.AddRange(New DevExpress.XtraCharts.KnownDate() { New DevExpress.XtraCharts.KnownDate("Christmas Day", New System.DateTime(2007, 12, 25, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("New Year's Day", New System.DateTime(2008, 1, 1, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("Martin Luther King Day", New System.DateTime(2008, 1, 21, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("Presidents' Day", New System.DateTime(2008, 2, 18, 0, 0, 0, 0)), New DevExpress.XtraCharts.KnownDate("Good Friday", New System.DateTime(2008, 3, 21, 0, 0, 0, 0))})
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Text = "US Dollars"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Date"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			series1.Label = stockSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Apple Inc."
			series1.ValueDataMembersSerializable = "Low;High;Open;Close"
			medianPrice1.LineStyle.Thickness = 2
			medianPrice1.Name = "Median Price"
			medianPrice1.ShowInLegend = True
			typicalPrice1.LineStyle.Thickness = 2
			typicalPrice1.Name = "Typical Price"
			typicalPrice1.ShowInLegend = True
			weightedClose1.LineStyle.Thickness = 2
			weightedClose1.Name = "Weighted Close"
			weightedClose1.ShowInLegend = True
			stockSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() { medianPrice1, typicalPrice1, weightedClose1})
			series1.View = stockSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.View = stockSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 3
			chartTitle1.Text = "Stock Prices"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.quandl.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' lblIndicator
			' 
			Me.lblIndicator.Location = New System.Drawing.Point(12, 12)
			Me.lblIndicator.Name = "lblIndicator"
			Me.lblIndicator.Size = New System.Drawing.Size(73, 13)
			Me.lblIndicator.TabIndex = 7
			Me.lblIndicator.Text = "Price Indicator:"
			' 
			' cbePriceIndicator
			' 
			Me.cbePriceIndicator.EditValue = ""
			Me.cbePriceIndicator.Location = New System.Drawing.Point(91, 9)
			Me.cbePriceIndicator.Name = "cbePriceIndicator"
			Me.cbePriceIndicator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbePriceIndicator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbePriceIndicator.Size = New System.Drawing.Size(110, 20)
			Me.cbePriceIndicator.TabIndex = 8
'			Me.cbePriceIndicator.SelectedIndexChanged += New System.EventHandler(Me.cbePriceIndicator_SelectedIndexChanged);
			' 
			' lbDashStyle
			' 
			Me.lbDashStyle.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.lbDashStyle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbDashStyle.Location = New System.Drawing.Point(533, 8)
			Me.lbDashStyle.Name = "lbDashStyle"
			Me.lbDashStyle.Size = New System.Drawing.Size(56, 20)
			Me.lbDashStyle.TabIndex = 25
			Me.lbDashStyle.Text = "Dash Style:"
			' 
			' cbDashStyle
			' 
			Me.cbDashStyle.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cbDashStyle.Location = New System.Drawing.Point(595, 9)
			Me.cbDashStyle.Name = "cbDashStyle"
			Me.cbDashStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbDashStyle.Properties.Items.AddRange(New Object() { "Solid", "Dash", "Dot", "DashDot", "DashDotDot"})
			Me.cbDashStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbDashStyle.Size = New System.Drawing.Size(90, 20)
			Me.cbDashStyle.TabIndex = 21
'			Me.cbDashStyle.SelectedIndexChanged += New System.EventHandler(Me.cbDashStyle_SelectedIndexChanged);
			' 
			' clreColor
			' 
			Me.clreColor.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.clreColor.EditValue = System.Drawing.Color.Empty
			Me.clreColor.EnterMoveNextControl = True
			Me.clreColor.Location = New System.Drawing.Point(399, 9)
			Me.clreColor.Name = "clreColor"
			Me.clreColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.clreColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.clreColor.Size = New System.Drawing.Size(110, 20)
			Me.clreColor.TabIndex = 20
'			Me.clreColor.EditValueChanged += New System.EventHandler(Me.clreColor_EditValueChanged);
			' 
			' lbColor
			' 
			Me.lbColor.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.lbColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbColor.Location = New System.Drawing.Point(361, 8)
			Me.lbColor.Name = "lbColor"
			Me.lbColor.Size = New System.Drawing.Size(32, 20)
			Me.lbColor.TabIndex = 24
			Me.lbColor.Text = "Color:"
			' 
			' lbThickness
			' 
			Me.lbThickness.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.lbThickness.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbThickness.Location = New System.Drawing.Point(221, 8)
			Me.lbThickness.Name = "lbThickness"
			Me.lbThickness.Size = New System.Drawing.Size(50, 20)
			Me.lbThickness.TabIndex = 23
			Me.lbThickness.Text = "Thickness:"
			' 
			' speThickness
			' 
			Me.speThickness.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.speThickness.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.speThickness.Location = New System.Drawing.Point(277, 9)
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
			Me.speThickness.TabIndex = 22
'			Me.speThickness.EditValueChanged += New System.EventHandler(Me.speThickness_EditValueChanged);
			' 
			' PriceIndicatorsDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "PriceIndicatorsDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(medianPrice1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(typicalPrice1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(weightedClose1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbePriceIndicator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbDashStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.clreColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.speThickness.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private WithEvents cbePriceIndicator As DevExpress.XtraEditors.ComboBoxEdit
		Private lblIndicator As DevExpress.XtraEditors.LabelControl
		Private lbDashStyle As XtraEditors.LabelControl
		Private WithEvents cbDashStyle As XtraEditors.ComboBoxEdit
		Private WithEvents clreColor As XtraEditors.ColorEdit
		Private lbColor As XtraEditors.LabelControl
		Private lbThickness As XtraEditors.LabelControl
		Private WithEvents speThickness As XtraEditors.SpinEdit
	End Class
End Namespace
