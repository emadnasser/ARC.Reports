Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class MovingAverageDemo
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
			Dim simpleMovingAverage1 As New DevExpress.XtraCharts.SimpleMovingAverage()
			Dim exponentialMovingAverage1 As New DevExpress.XtraCharts.ExponentialMovingAverage()
			Dim weightedMovingAverage1 As New DevExpress.XtraCharts.WeightedMovingAverage()
			Dim triangularMovingAverage1 As New DevExpress.XtraCharts.TriangularMovingAverage()
			Dim tripleExponentialMovingAverageTema1 As New DevExpress.XtraCharts.TripleExponentialMovingAverageTema()
			Dim stockSeriesView2 As New DevExpress.XtraCharts.StockSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.lblType = New DevExpress.XtraEditors.LabelControl()
			Me.cbType = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblPointsCount = New DevExpress.XtraEditors.LabelControl()
			Me.spnPointsCount = New DevExpress.XtraEditors.SpinEdit()
			Me.lblKind = New DevExpress.XtraEditors.LabelControl()
			Me.cbKind = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblEnvelopPercent = New DevExpress.XtraEditors.LabelControl()
			Me.spnEnvelopPercent = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(simpleMovingAverage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(exponentialMovingAverage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(weightedMovingAverage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(triangularMovingAverage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(tripleExponentialMovingAverageTema1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spnPointsCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spnEnvelopPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.spnEnvelopPercent)
			Me.panel.Controls.Add(Me.lblEnvelopPercent)
			Me.panel.Controls.Add(Me.cbKind)
			Me.panel.Controls.Add(Me.lblKind)
			Me.panel.Controls.Add(Me.spnPointsCount)
			Me.panel.Controls.Add(Me.lblPointsCount)
			Me.panel.Controls.Add(Me.cbType)
			Me.panel.Controls.Add(Me.lblType)
			Me.panel.Size = New System.Drawing.Size(697, 66)
			Me.panel.Controls.SetChildIndex(Me.lblType, 0)
			Me.panel.Controls.SetChildIndex(Me.cbType, 0)
			Me.panel.Controls.SetChildIndex(Me.lblPointsCount, 0)
			Me.panel.Controls.SetChildIndex(Me.spnPointsCount, 0)
			Me.panel.Controls.SetChildIndex(Me.lblKind, 0)
			Me.panel.Controls.SetChildIndex(Me.cbKind, 0)
			Me.panel.Controls.SetChildIndex(Me.lblEnvelopPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.spnEnvelopPercent, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(327, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 4
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(697, 74)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
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
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Date"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			stockSeriesLabel1.TextPattern = "{CV:F2}"
			series1.Label = stockSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Google Inc."
			series1.ValueDataMembersSerializable = "Low;High;Open;Close"
			financialSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromBottom
			stockSeriesView1.Animation = financialSlideAnimation1
			stockSeriesView1.Color = System.Drawing.Color.Black
			simpleMovingAverage1.EnvelopeColor = System.Drawing.Color.Green
			simpleMovingAverage1.Name = "Simple Moving Average"
			simpleMovingAverage1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close
			exponentialMovingAverage1.EnvelopeColor = System.Drawing.Color.Green
			exponentialMovingAverage1.Name = "Exponential Moving Average"
			exponentialMovingAverage1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close
			weightedMovingAverage1.EnvelopeColor = System.Drawing.Color.Green
			weightedMovingAverage1.Name = "Weighted Moving Average"
			weightedMovingAverage1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close
			triangularMovingAverage1.EnvelopeColor = System.Drawing.Color.Green
			triangularMovingAverage1.Name = "Triangular Moving Average"
			triangularMovingAverage1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close
			tripleExponentialMovingAverageTema1.EnvelopeColor = System.Drawing.Color.Green
			tripleExponentialMovingAverageTema1.Name = "Triangular Moving Average"
			tripleExponentialMovingAverageTema1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close
			stockSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() { simpleMovingAverage1, exponentialMovingAverage1, weightedMovingAverage1, triangularMovingAverage1, tripleExponentialMovingAverageTema1})
			series1.View = stockSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.View = stockSeriesView2
			Me.chart.Size = New System.Drawing.Size(697, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Stock Prices"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.quandl.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
			' 
			' lblType
			' 
			Me.lblType.Location = New System.Drawing.Point(12, 12)
			Me.lblType.Name = "lblType"
			Me.lblType.Size = New System.Drawing.Size(28, 13)
			Me.lblType.TabIndex = 12
			Me.lblType.Text = "Type:"
			' 
			' cbType
			' 
			Me.cbType.EditValue = "Simple"
			Me.cbType.Location = New System.Drawing.Point(46, 9)
			Me.cbType.Name = "cbType"
			Me.cbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbType.Properties.Items.AddRange(New Object() { "Simple", "Exponential", "Weighted", "Triangular", "Triple Exponential (TEMA)"})
			Me.cbType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbType.Size = New System.Drawing.Size(180, 20)
			Me.cbType.TabIndex = 0
'			Me.cbType.SelectedIndexChanged += New System.EventHandler(Me.cbType_SelectedIndexChanged);
			' 
			' lblPointsCount
			' 
			Me.lblPointsCount.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.lblPointsCount.Location = New System.Drawing.Point(538, 12)
			Me.lblPointsCount.Name = "lblPointsCount"
			Me.lblPointsCount.Size = New System.Drawing.Size(60, 13)
			Me.lblPointsCount.TabIndex = 14
			Me.lblPointsCount.Text = "Days Count:"
			' 
			' spnPointsCount
			' 
			Me.spnPointsCount.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.spnPointsCount.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.spnPointsCount.Location = New System.Drawing.Point(632, 9)
			Me.spnPointsCount.Name = "spnPointsCount"
			Me.spnPointsCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spnPointsCount.Properties.IsFloatValue = False
			Me.spnPointsCount.Properties.Mask.EditMask = "N00"
			Me.spnPointsCount.Properties.MaxValue = New Decimal(New Integer() { 15, 0, 0, 0})
			Me.spnPointsCount.Properties.MinValue = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.spnPointsCount.Properties.ValidateOnEnterKey = True
			Me.spnPointsCount.Size = New System.Drawing.Size(50, 20)
			Me.spnPointsCount.TabIndex = 2
'			Me.spnPointsCount.EditValueChanged += New System.EventHandler(Me.spnPointsCount_EditValueChanged);
			' 
			' lblKind
			' 
			Me.lblKind.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.lblKind.Location = New System.Drawing.Point(12, 40)
			Me.lblKind.Name = "lblKind"
			Me.lblKind.Size = New System.Drawing.Size(24, 13)
			Me.lblKind.TabIndex = 18
			Me.lblKind.Text = "Kind:"
'			Me.lblKind.Click += New System.EventHandler(Me.lblKind_Click);
			' 
			' cbKind
			' 
			Me.cbKind.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.cbKind.EditValue = "Moving Average"
			Me.cbKind.Location = New System.Drawing.Point(46, 37)
			Me.cbKind.Name = "cbKind"
			Me.cbKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbKind.Properties.Items.AddRange(New Object() { "Moving Average", "Envelope", "Moving Average And Envelope"})
			Me.cbKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbKind.Size = New System.Drawing.Size(180, 20)
			Me.cbKind.TabIndex = 1
'			Me.cbKind.SelectedIndexChanged += New System.EventHandler(Me.cbKind_SelectedIndexChanged);
			' 
			' lblEnvelopPercent
			' 
			Me.lblEnvelopPercent.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.lblEnvelopPercent.Location = New System.Drawing.Point(538, 40)
			Me.lblEnvelopPercent.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
			Me.lblEnvelopPercent.Name = "lblEnvelopPercent"
			Me.lblEnvelopPercent.Size = New System.Drawing.Size(88, 13)
			Me.lblEnvelopPercent.TabIndex = 21
			Me.lblEnvelopPercent.Text = "Envelope Percent:"
			' 
			' spnEnvelopPercent
			' 
			Me.spnEnvelopPercent.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.spnEnvelopPercent.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.spnEnvelopPercent.Location = New System.Drawing.Point(632, 37)
			Me.spnEnvelopPercent.Name = "spnEnvelopPercent"
			Me.spnEnvelopPercent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spnEnvelopPercent.Properties.IsFloatValue = False
			Me.spnEnvelopPercent.Properties.Mask.EditMask = "N00"
			Me.spnEnvelopPercent.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spnEnvelopPercent.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spnEnvelopPercent.Properties.ValidateOnEnterKey = True
			Me.spnEnvelopPercent.Size = New System.Drawing.Size(50, 20)
			Me.spnEnvelopPercent.TabIndex = 3
'			Me.spnEnvelopPercent.EditValueChanged += New System.EventHandler(Me.spnEnvelopPercent_EditValueChanged);
			' 
			' MovingAverageDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "MovingAverageDemo"
			Me.Size = New System.Drawing.Size(697, 500)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(simpleMovingAverage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(exponentialMovingAverage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(weightedMovingAverage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(triangularMovingAverage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(tripleExponentialMovingAverageTema1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spnPointsCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spnEnvelopPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private lblType As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbType As DevExpress.XtraEditors.ComboBoxEdit
		Private lblPointsCount As DevExpress.XtraEditors.LabelControl
		Private WithEvents spnPointsCount As DevExpress.XtraEditors.SpinEdit
		Private WithEvents lblKind As DevExpress.XtraEditors.LabelControl
		Private lblEnvelopPercent As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbKind As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents spnEnvelopPercent As DevExpress.XtraEditors.SpinEdit

	End Class
End Namespace
