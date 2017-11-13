Namespace DevExpress.SalesDemo.Win.Modules
	Partial Public Class ucSalesDashboard
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
			Dim arcScaleRange1 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange2 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange3 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim linearScaleRange1 As New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
			Dim linearScaleRange2 As New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
			Dim linearScaleRange3 As New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
			Dim arcScaleRange4 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange5 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange6 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange7 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange8 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange9 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim simpleDiagram1 As New DevExpress.XtraCharts.SimpleDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim doughnutSeriesLabel1 As New DevExpress.XtraCharts.DoughnutSeriesLabel()
            Dim doughnutSeriesView1 As New DevExpress.XtraCharts.DoughnutSeriesView()
			Dim doughnutSeriesLabel2 As New DevExpress.XtraCharts.DoughnutSeriesLabel()
            Dim doughnutSeriesView2 As New DevExpress.XtraCharts.DoughnutSeriesView()
			Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.monthlySalesPerformance = New DevExpress.SalesDemo.Win.Modules.ucSalesPerformance()
			Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.dailySalesPerformance = New DevExpress.SalesDemo.Win.Modules.ucSalesPerformance()
			Me.tableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
			Me.linearScaleRangeBarForecast = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
			Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
			Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScalePrevYear = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.needleFiscalYear = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.gaugeControl3 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge3 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleFiscalToData = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.needleFiscalToData = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.labelFiscalToData = New System.Windows.Forms.Label()
			Me.labelFiscalYear = New System.Windows.Forms.Label()
			Me.fiscalToData = New System.Windows.Forms.Label()
			Me.fiscalYear = New System.Windows.Forms.Label()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
			Me.chartSalesbySecor = New DevExpress.XtraCharts.ChartControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.tableLayoutPanel4.SuspendLayout()
			Me.tableLayoutPanel5.SuspendLayout()
			Me.tableLayoutPanel6.SuspendLayout()
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleRangeBarForecast, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel3.SuspendLayout()
			CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScalePrevYear, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.needleFiscalYear, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleFiscalToData, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.needleFiscalToData, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel2.SuspendLayout()
			CType(Me.chartSalesbySecor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnutSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnutSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' arcScaleBackgroundLayerComponent2
			' 
			Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent2
			Me.arcScaleBackgroundLayerComponent2.Name = "bg"
			Me.arcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.584F)
			Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style27
			Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(200F, 170.7F)
			Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
			' 
			' arcScaleComponent2
			' 
			Me.arcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10F)
			Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
			Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent2.EndAngle = 45F
			Me.arcScaleComponent2.MajorTickCount = 0
			Me.arcScaleComponent2.MajorTickmark.AllowTickOverlap = True
			Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -4F
			Me.arcScaleComponent2.MajorTickmark.ShowFirst = False
			Me.arcScaleComponent2.MajorTickmark.ShowLast = False
			Me.arcScaleComponent2.MajorTickmark.ShowText = False
			Me.arcScaleComponent2.MajorTickmark.ShowTick = False
			Me.arcScaleComponent2.MajorTickmark.TextOffset = 18F
			Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent2.MaxValue = 100F
			Me.arcScaleComponent2.MinorTickCount = 0
			Me.arcScaleComponent2.MinorTickmark.ShapeOffset = 4F
			Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_2
			Me.arcScaleComponent2.MinorTickmark.ShowFirst = False
			Me.arcScaleComponent2.MinorTickmark.ShowLast = False
			Me.arcScaleComponent2.MinorTickmark.ShowTick = False
			Me.arcScaleComponent2.Name = "scale1"
			Me.arcScaleComponent2.RadiusX = 101F
			Me.arcScaleComponent2.RadiusY = 100.5F
			arcScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9BBB59")
			arcScaleRange1.EndThickness = 22F
			arcScaleRange1.EndValue = 33F
			arcScaleRange1.Name = "Range0"
			arcScaleRange1.ShapeOffset = -4F
			arcScaleRange1.StartThickness = 22F
			arcScaleRange1.StartValue = -0.2F
			arcScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F4F56B")
			arcScaleRange2.EndThickness = 22F
			arcScaleRange2.EndValue = 66F
			arcScaleRange2.Name = "Range1"
			arcScaleRange2.ShapeOffset = -4F
			arcScaleRange2.StartThickness = 22F
			arcScaleRange2.StartValue = 33F
			arcScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E73141")
			arcScaleRange3.EndThickness = 22F
			arcScaleRange3.EndValue = 100.2F
			arcScaleRange3.Name = "Range2"
			arcScaleRange3.ShapeOffset = -4F
			arcScaleRange3.StartThickness = 22F
			arcScaleRange3.StartValue = 66F
			Me.arcScaleComponent2.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() { arcScaleRange1, arcScaleRange2, arcScaleRange3})
			Me.arcScaleComponent2.StartAngle = -225F
			Me.arcScaleComponent2.Value = 50F
			' 
			' arcScaleNeedleComponent2
			' 
			Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
			Me.arcScaleNeedleComponent2.EndOffset = 8F
			Me.arcScaleNeedleComponent2.Name = "needle"
			Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style27
			Me.arcScaleNeedleComponent2.StartOffset = -6F
			Me.arcScaleNeedleComponent2.ZOrder = -50
			' 
			' circularGauge1
			' 
			Me.circularGauge1.AutoSize = DevExpress.Utils.DefaultBoolean.False
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 220, 176)
			Me.circularGauge1.Name = "circularGauge1"
			' 
			' labelComponent1
			' 
			Me.labelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.labelComponent1.Name = "circularGauge3_Label1"
			Me.labelComponent1.Text = "circularGauge3_Label1"
			Me.labelComponent1.ZOrder = -1001
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 3
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F))
			Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel4, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel5, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel6, 2, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 2, 0)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI Light", 8.25F)
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 3
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(980, 700)
			Me.tableLayoutPanel1.TabIndex = 0
			' 
			' tableLayoutPanel4
			' 
			Me.tableLayoutPanel4.ColumnCount = 1
			Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel4.Controls.Add(Me.labelControl3, 0, 0)
			Me.tableLayoutPanel4.Controls.Add(Me.monthlySalesPerformance, 0, 1)
			Me.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel4.Location = New System.Drawing.Point(3, 359)
			Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
			Me.tableLayoutPanel4.RowCount = 2
			Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F))
			Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
			Me.tableLayoutPanel4.Size = New System.Drawing.Size(550, 338)
			Me.tableLayoutPanel4.TabIndex = 12
			' 
			' labelControl3
			' 
			Me.labelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 16F)
			Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center
			Me.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl3.LineVisible = True
			Me.labelControl3.Location = New System.Drawing.Point(3, 3)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Padding = New System.Windows.Forms.Padding(34, 0, 20, 0)
			Me.labelControl3.ShowLineShadow = False
			Me.labelControl3.Size = New System.Drawing.Size(544, 19)
			Me.labelControl3.TabIndex = 12
			Me.labelControl3.Text = "MONTHLY SALES PERFORMANCE "
			' 
			' monthlySalesPerformance
			' 
			Me.monthlySalesPerformance.Dock = System.Windows.Forms.DockStyle.Fill
			Me.monthlySalesPerformance.Location = New System.Drawing.Point(3, 28)
			Me.monthlySalesPerformance.Name = "monthlySalesPerformance"
			Me.monthlySalesPerformance.Size = New System.Drawing.Size(544, 307)
			Me.monthlySalesPerformance.TabIndex = 11
			' 
			' tableLayoutPanel5
			' 
			Me.tableLayoutPanel5.ColumnCount = 1
			Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel5.Controls.Add(Me.labelControl2, 0, 0)
			Me.tableLayoutPanel5.Controls.Add(Me.dailySalesPerformance, 0, 1)
			Me.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
			Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
			Me.tableLayoutPanel5.RowCount = 2
			Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F))
			Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
			Me.tableLayoutPanel5.Size = New System.Drawing.Size(550, 338)
			Me.tableLayoutPanel5.TabIndex = 13
			' 
			' labelControl2
			' 
			Me.labelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 16F)
			Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center
			Me.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl2.LineVisible = True
			Me.labelControl2.Location = New System.Drawing.Point(3, 3)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Padding = New System.Windows.Forms.Padding(34, 0, 20, 0)
			Me.labelControl2.ShowLineShadow = False
			Me.labelControl2.Size = New System.Drawing.Size(544, 19)
			Me.labelControl2.TabIndex = 3
			Me.labelControl2.Text = "DAILY SALES PERFORMANCE "
			' 
			' dailySalesPerformance
			' 
			Me.dailySalesPerformance.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dailySalesPerformance.Location = New System.Drawing.Point(3, 28)
			Me.dailySalesPerformance.Name = "dailySalesPerformance"
			Me.dailySalesPerformance.Size = New System.Drawing.Size(544, 307)
			Me.dailySalesPerformance.TabIndex = 0
			' 
			' tableLayoutPanel6
			' 
			Me.tableLayoutPanel6.ColumnCount = 1
			Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel6.Controls.Add(Me.labelControl4, 0, 0)
			Me.tableLayoutPanel6.Controls.Add(Me.gaugeControl2, 0, 4)
			Me.tableLayoutPanel6.Controls.Add(Me.tableLayoutPanel3, 0, 1)
			Me.tableLayoutPanel6.Controls.Add(Me.labelControl5, 0, 3)
			Me.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel6.Location = New System.Drawing.Point(563, 359)
			Me.tableLayoutPanel6.Name = "tableLayoutPanel6"
			Me.tableLayoutPanel6.RowCount = 5
			Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F))
			Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
			Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F))
			Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F))
			Me.tableLayoutPanel6.Size = New System.Drawing.Size(414, 338)
			Me.tableLayoutPanel6.TabIndex = 14
			' 
			' labelControl4
			' 
			Me.labelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 16F)
			Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center
			Me.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl4.LineVisible = True
			Me.labelControl4.Location = New System.Drawing.Point(3, 3)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
			Me.labelControl4.ShowLineShadow = False
			Me.labelControl4.Size = New System.Drawing.Size(408, 19)
			Me.labelControl4.TabIndex = 16
			Me.labelControl4.Text = "ANNUAL SALES PERFORMANCE "
			' 
			' gaugeControl2
			' 
			Me.gaugeControl2.AutoLayout = False
			Me.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gaugeControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.linearGauge1})
			Me.gaugeControl2.Location = New System.Drawing.Point(3, 281)
			Me.gaugeControl2.Name = "gaugeControl2"
			Me.gaugeControl2.Size = New System.Drawing.Size(408, 54)
			Me.gaugeControl2.TabIndex = 9
			' 
			' linearGauge1
			' 
			Me.linearGauge1.AutoSize = DevExpress.Utils.DefaultBoolean.True
			Me.linearGauge1.Bounds = New System.Drawing.Rectangle(-12, -10, 432, 59)
			Me.linearGauge1.Name = "linearGauge1"
			Me.linearGauge1.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal
			Me.linearGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent() { Me.linearScaleRangeBarForecast})
			Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() { Me.linearScaleComponent1})
			' 
			' linearScaleRangeBarForecast
			' 
			Me.linearScaleRangeBarForecast.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#5848A5")
			Me.linearScaleRangeBarForecast.EndOffset = 8F
			Me.linearScaleRangeBarForecast.LinearScale = Me.linearScaleComponent1
			Me.linearScaleRangeBarForecast.Name = "linearGauge2_RangeBar1"
			Me.linearScaleRangeBarForecast.StartOffset = 4F
			Me.linearScaleRangeBarForecast.ZOrder = -100
			' 
			' linearScaleComponent1
			' 
			Me.linearScaleComponent1.AppearanceScale.Brush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
			Me.linearScaleComponent1.AppearanceScale.Width = 4F
			Me.linearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold)
			Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
			Me.linearScaleComponent1.CustomLogarithmicBase = 2F
			Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, -100F)
			Me.linearScaleComponent1.MajorTickCount = 6
			Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -7F
			Me.linearScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.1F, 1F)
			Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
			Me.linearScaleComponent1.MajorTickmark.TextOffset = -16F
			Me.linearScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
			Me.linearScaleComponent1.MaxValue = 600F
			Me.linearScaleComponent1.MinorTickCount = 4
			Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -14F
			Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
			Me.linearScaleComponent1.MinorTickmark.ShowTick = False
			Me.linearScaleComponent1.Name = "scale2"
			linearScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A54671")
			linearScaleRange1.EndThickness = 11F
			linearScaleRange1.EndValue = 300F
			linearScaleRange1.Name = "Range0"
			linearScaleRange1.ShapeOffset = 10F
			linearScaleRange1.StartThickness = 11F
			linearScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FCC653")
			linearScaleRange2.EndThickness = 11F
			linearScaleRange2.EndValue = 480F
			linearScaleRange2.Name = "Range1"
			linearScaleRange2.ShapeOffset = 10F
			linearScaleRange2.StartThickness = 11F
			linearScaleRange2.StartValue = 300F
			linearScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#469EA5")
			linearScaleRange3.EndThickness = 11F
			linearScaleRange3.EndValue = 600F
			linearScaleRange3.Name = "Range2"
			linearScaleRange3.ShapeOffset = 10F
			linearScaleRange3.StartThickness = 11F
			linearScaleRange3.StartValue = 480F
			Me.linearScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() { linearScaleRange1, linearScaleRange2, linearScaleRange3})
			Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 330F)
			Me.linearScaleComponent1.Value = 20F
			' 
			' tableLayoutPanel3
			' 
			Me.tableLayoutPanel3.ColumnCount = 2
			Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel3.Controls.Add(Me.gaugeControl1, 1, 0)
			Me.tableLayoutPanel3.Controls.Add(Me.gaugeControl3, 0, 0)
			Me.tableLayoutPanel3.Controls.Add(Me.labelFiscalToData, 0, 1)
			Me.tableLayoutPanel3.Controls.Add(Me.labelFiscalYear, 1, 1)
			Me.tableLayoutPanel3.Controls.Add(Me.fiscalToData, 0, 2)
			Me.tableLayoutPanel3.Controls.Add(Me.fiscalYear, 1, 2)
			Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel3.Location = New System.Drawing.Point(3, 28)
			Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
			Me.tableLayoutPanel3.RowCount = 3
			Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F))
			Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F))
			Me.tableLayoutPanel3.Size = New System.Drawing.Size(408, 203)
			Me.tableLayoutPanel3.TabIndex = 0
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge2})
			Me.gaugeControl1.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(0, 6, 0, 0)
			Me.gaugeControl1.Location = New System.Drawing.Point(204, 0)
			Me.gaugeControl1.Margin = New System.Windows.Forms.Padding(0)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(204, 159)
			Me.gaugeControl1.TabIndex = 11
			' 
			' circularGauge2
			' 
			Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent4})
			Me.circularGauge2.Bounds = New System.Drawing.Rectangle(0, 6, 204, 153)
			Me.circularGauge2.Name = "circularGauge2"
			Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.needleFiscalYear})
			Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScalePrevYear})
			' 
			' arcScaleBackgroundLayerComponent4
			' 
			Me.arcScaleBackgroundLayerComponent4.ArcScale = Me.arcScalePrevYear
			Me.arcScaleBackgroundLayerComponent4.Name = "bg"
			Me.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style27
			Me.arcScaleBackgroundLayerComponent4.Size = New System.Drawing.SizeF(200F, 200F)
			Me.arcScaleBackgroundLayerComponent4.ZOrder = 1000
			' 
			' arcScalePrevYear
			' 
			Me.arcScalePrevYear.AppearanceTickmarkText.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
			Me.arcScalePrevYear.AppearanceTickmarkText.Spacing = New DevExpress.XtraGauges.Core.Base.TextSpacing(-10, 0, -10, 0)
			Me.arcScalePrevYear.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
			Me.arcScalePrevYear.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScalePrevYear.EndAngle = 60F
			Me.arcScalePrevYear.MajorTickCount = 4
			Me.arcScalePrevYear.MajorTickmark.AllowTickOverlap = True
			Me.arcScalePrevYear.MajorTickmark.FormatString = "${0:0,,}M"
			Me.arcScalePrevYear.MajorTickmark.ShapeOffset = -2F
			Me.arcScalePrevYear.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
			Me.arcScalePrevYear.MajorTickmark.TextOffset = 20F
			Me.arcScalePrevYear.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScalePrevYear.MaxValue = 6E+08F
			Me.arcScalePrevYear.MinorTickCount = 4
			Me.arcScalePrevYear.MinorTickmark.ShapeOffset = 4F
			Me.arcScalePrevYear.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
			Me.arcScalePrevYear.MinorTickmark.ShowTick = False
			Me.arcScalePrevYear.Name = "scale1"
			arcScaleRange4.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A54671")
			arcScaleRange4.EndThickness = 22F
			arcScaleRange4.EndValue = 3E+08F
			arcScaleRange4.Name = "Range0"
			arcScaleRange4.ShapeOffset = -4F
			arcScaleRange4.StartThickness = 22F
			arcScaleRange5.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FCC653")
			arcScaleRange5.EndThickness = 22F
			arcScaleRange5.EndValue = 5E+08F
			arcScaleRange5.Name = "Range1"
			arcScaleRange5.ShapeOffset = -4F
			arcScaleRange5.StartThickness = 22F
			arcScaleRange5.StartValue = 3E+08F
			arcScaleRange6.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#469EA5")
			arcScaleRange6.EndThickness = 22F
			arcScaleRange6.EndValue = 6E+08F
			arcScaleRange6.Name = "Range2"
			arcScaleRange6.ShapeOffset = -4F
			arcScaleRange6.StartThickness = 22F
			arcScaleRange6.StartValue = 5E+08F
			Me.arcScalePrevYear.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() { arcScaleRange4, arcScaleRange5, arcScaleRange6})
			Me.arcScalePrevYear.StartAngle = -240F
			Me.arcScalePrevYear.Value = 50F
			' 
			' needleFiscalYear
			' 
			Me.needleFiscalYear.ArcScale = Me.arcScalePrevYear
			Me.needleFiscalYear.EndOffset = 8F
			Me.needleFiscalYear.Name = "needle"
			Me.needleFiscalYear.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style27
			Me.needleFiscalYear.StartOffset = -6F
			Me.needleFiscalYear.ZOrder = -50
			' 
			' gaugeControl3
			' 
			Me.gaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gaugeControl3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl3.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge3})
			Me.gaugeControl3.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(0, 6, 0, 0)
			Me.gaugeControl3.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl3.Margin = New System.Windows.Forms.Padding(0)
			Me.gaugeControl3.Name = "gaugeControl3"
			Me.gaugeControl3.Size = New System.Drawing.Size(204, 159)
			Me.gaugeControl3.TabIndex = 12
			' 
			' circularGauge3
			' 
			Me.circularGauge3.AutoSize = DevExpress.Utils.DefaultBoolean.True
			Me.circularGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent3})
			Me.circularGauge3.Bounds = New System.Drawing.Rectangle(0, 6, 204, 153)
			Me.circularGauge3.Name = "circularGauge3"
			Me.circularGauge3.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.needleFiscalToData})
			Me.circularGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleFiscalToData})
			' 
			' arcScaleBackgroundLayerComponent3
			' 
			Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleFiscalToData
			Me.arcScaleBackgroundLayerComponent3.Name = "bg"
			Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style27
			Me.arcScaleBackgroundLayerComponent3.Size = New System.Drawing.SizeF(200F, 200F)
			Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
			' 
			' arcScaleFiscalToData
			' 
			Me.arcScaleFiscalToData.AppearanceTickmarkText.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
			Me.arcScaleFiscalToData.AppearanceTickmarkText.Spacing = New DevExpress.XtraGauges.Core.Base.TextSpacing(-10, 0, -10, 0)
			Me.arcScaleFiscalToData.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
			Me.arcScaleFiscalToData.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleFiscalToData.EndAngle = 60F
			Me.arcScaleFiscalToData.MajorTickCount = 4
			Me.arcScaleFiscalToData.MajorTickmark.AllowTickOverlap = True
			Me.arcScaleFiscalToData.MajorTickmark.FormatString = "${0:0,,}M"
			Me.arcScaleFiscalToData.MajorTickmark.ShapeOffset = -2F
			Me.arcScaleFiscalToData.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
			Me.arcScaleFiscalToData.MajorTickmark.TextOffset = 20F
			Me.arcScaleFiscalToData.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleFiscalToData.MaxValue = 6E+08F
			Me.arcScaleFiscalToData.MinorTickCount = 4
			Me.arcScaleFiscalToData.MinorTickmark.ShapeOffset = 4F
			Me.arcScaleFiscalToData.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
			Me.arcScaleFiscalToData.MinorTickmark.ShowTick = False
			Me.arcScaleFiscalToData.Name = "scale1"
			arcScaleRange7.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A54671")
			arcScaleRange7.EndThickness = 22F
			arcScaleRange7.EndValue = 3E+08F
			arcScaleRange7.Name = "Range0"
			arcScaleRange7.ShapeOffset = -4F
			arcScaleRange7.StartThickness = 22F
			arcScaleRange8.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FCC653")
			arcScaleRange8.EndThickness = 22F
			arcScaleRange8.EndValue = 5E+08F
			arcScaleRange8.Name = "Range1"
			arcScaleRange8.ShapeOffset = -4F
			arcScaleRange8.StartThickness = 22F
			arcScaleRange8.StartValue = 3E+08F
			arcScaleRange9.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#469EA5")
			arcScaleRange9.EndThickness = 22F
			arcScaleRange9.EndValue = 6E+08F
			arcScaleRange9.Name = "Range2"
			arcScaleRange9.ShapeOffset = -4F
			arcScaleRange9.StartThickness = 22F
			arcScaleRange9.StartValue = 5E+08F
			Me.arcScaleFiscalToData.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() { arcScaleRange7, arcScaleRange8, arcScaleRange9})
			Me.arcScaleFiscalToData.StartAngle = -240F
			Me.arcScaleFiscalToData.Value = 50F
			' 
			' needleFiscalToData
			' 
			Me.needleFiscalToData.ArcScale = Me.arcScaleFiscalToData
			Me.needleFiscalToData.EndOffset = 8F
			Me.needleFiscalToData.Name = "needle"
			Me.needleFiscalToData.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style27
			Me.needleFiscalToData.StartOffset = -6F
			Me.needleFiscalToData.ZOrder = -50
			' 
			' labelFiscalToData
			' 
			Me.labelFiscalToData.AutoSize = True
			Me.labelFiscalToData.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelFiscalToData.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.labelFiscalToData.ForeColor = System.Drawing.Color.Gray
			Me.labelFiscalToData.Location = New System.Drawing.Point(3, 159)
			Me.labelFiscalToData.Name = "labelFiscalToData"
			Me.labelFiscalToData.Size = New System.Drawing.Size(198, 16)
			Me.labelFiscalToData.TabIndex = 13
			Me.labelFiscalToData.Text = "FISCAL TO DATA"
			Me.labelFiscalToData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' labelFiscalYear
			' 
			Me.labelFiscalYear.AutoSize = True
			Me.labelFiscalYear.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelFiscalYear.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.labelFiscalYear.ForeColor = System.Drawing.Color.Gray
			Me.labelFiscalYear.Location = New System.Drawing.Point(207, 159)
			Me.labelFiscalYear.Name = "labelFiscalYear"
			Me.labelFiscalYear.Size = New System.Drawing.Size(198, 16)
			Me.labelFiscalYear.TabIndex = 14
			Me.labelFiscalYear.Text = "FISCAL YEAR"
			Me.labelFiscalYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' fiscalToData
			' 
			Me.fiscalToData.AutoSize = True
			Me.fiscalToData.Dock = System.Windows.Forms.DockStyle.Fill
			Me.fiscalToData.Font = New System.Drawing.Font("Segoe UI", 15F)
			Me.fiscalToData.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(70)))), (CInt((CByte(104)))), (CInt((CByte(165)))))
			Me.fiscalToData.Location = New System.Drawing.Point(3, 175)
			Me.fiscalToData.Name = "fiscalToData"
			Me.fiscalToData.Size = New System.Drawing.Size(198, 28)
			Me.fiscalToData.TabIndex = 15
			Me.fiscalToData.Text = "$000,000,000"
			Me.fiscalToData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' fiscalYear
			' 
			Me.fiscalYear.AutoSize = True
			Me.fiscalYear.Dock = System.Windows.Forms.DockStyle.Fill
			Me.fiscalYear.Font = New System.Drawing.Font("Segoe UI", 15F)
			Me.fiscalYear.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(165)))), (CInt((CByte(70)))), (CInt((CByte(113)))))
			Me.fiscalYear.Location = New System.Drawing.Point(207, 175)
			Me.fiscalYear.Name = "fiscalYear"
			Me.fiscalYear.Size = New System.Drawing.Size(198, 28)
			Me.fiscalYear.TabIndex = 16
			Me.fiscalYear.Text = "$000,000,000"
			Me.fiscalYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' labelControl5
			' 
			Me.labelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 16F)
			Me.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center
			Me.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl5.LineVisible = True
			Me.labelControl5.Location = New System.Drawing.Point(3, 257)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
			Me.labelControl5.ShowLineShadow = False
			Me.labelControl5.Size = New System.Drawing.Size(408, 18)
			Me.labelControl5.TabIndex = 17
			Me.labelControl5.Text = "SALES FORECAST"
			' 
			' tableLayoutPanel2
			' 
			Me.tableLayoutPanel2.ColumnCount = 1
			Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel2.Controls.Add(Me.chartSalesbySecor, 0, 1)
			Me.tableLayoutPanel2.Controls.Add(Me.labelControl1, 0, 0)
			Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel2.Location = New System.Drawing.Point(563, 3)
			Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
			Me.tableLayoutPanel2.RowCount = 2
			Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F))
			Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel2.Size = New System.Drawing.Size(414, 338)
			Me.tableLayoutPanel2.TabIndex = 15
			' 
			' chartSalesbySecor
			' 
            Me.chartSalesbySecor.BorderOptions.Visibility = Utils.DefaultBoolean.False
			simpleDiagram1.EqualPieSize = False
			Me.chartSalesbySecor.Diagram = simpleDiagram1
			Me.chartSalesbySecor.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartSalesbySecor.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.LeftOutside
			Me.chartSalesbySecor.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center
            Me.chartSalesbySecor.Legend.EnableAntialiasing = Utils.DefaultBoolean.True
            Me.chartSalesbySecor.Legend.Border.Visibility = Utils.DefaultBoolean.False
			Me.chartSalesbySecor.Legend.EquallySpacedItems = False
			Me.chartSalesbySecor.Legend.Margins.Right = 0
			Me.chartSalesbySecor.Legend.MarkerSize = New System.Drawing.Size(18, 18)
			Me.chartSalesbySecor.Legend.TextOffset = 8
			Me.chartSalesbySecor.Legend.VerticalIndent = 12
			Me.chartSalesbySecor.Location = New System.Drawing.Point(3, 28)
			Me.chartSalesbySecor.Name = "chartSalesbySecor"
			Me.chartSalesbySecor.Padding.Right = 0
			series1.ArgumentDataMember = "GroupName"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            doughnutSeriesLabel1.EnableAntialiasing = Utils.DefaultBoolean.True
            doughnutSeriesLabel1.Border.Visibility = Utils.DefaultBoolean.False
            doughnutSeriesLabel1.TextPattern = "{V:F0}"
			series1.Label = doughnutSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.LegendTextPattern = "{A}"
			series1.Name = "Series 1"
            series1.ValueDataMembersSerializable = "TotalCost"
			doughnutSeriesView1.HoleRadiusPercent = 55
			doughnutSeriesView1.RuntimeExploding = False
			series1.View = doughnutSeriesView1
			Me.chartSalesbySecor.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            doughnutSeriesLabel2.TextPattern = "{VP:G0}"
			Me.chartSalesbySecor.SeriesTemplate.Label = doughnutSeriesLabel2
			doughnutSeriesView2.RuntimeExploding = False
			Me.chartSalesbySecor.SeriesTemplate.View = doughnutSeriesView2
			Me.chartSalesbySecor.Size = New System.Drawing.Size(408, 307)
			Me.chartSalesbySecor.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 16F)
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center
			Me.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl1.LineVisible = True
			Me.labelControl1.Location = New System.Drawing.Point(3, 3)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
			Me.labelControl1.ShowLineShadow = False
			Me.labelControl1.Size = New System.Drawing.Size(408, 19)
			Me.labelControl1.TabIndex = 2
			Me.labelControl1.Text = "SALES BY SECTOR "
			' 
			' ucSalesDashboard
			' 
			Me.Appearance.BackColor = System.Drawing.Color.White
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "ucSalesDashboard"
			Me.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
			Me.Size = New System.Drawing.Size(1000, 700)
			CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel4.ResumeLayout(False)
			Me.tableLayoutPanel5.ResumeLayout(False)
			Me.tableLayoutPanel6.ResumeLayout(False)
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleRangeBarForecast, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel3.ResumeLayout(False)
			Me.tableLayoutPanel3.PerformLayout()
			CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScalePrevYear, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.needleFiscalYear, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleFiscalToData, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.needleFiscalToData, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel2.ResumeLayout(False)
			CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnutSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnutSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartSalesbySecor, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private dailySalesPerformance As ucSalesPerformance
		Private chartSalesbySecor As XtraCharts.ChartControl
		Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
		Private arcScaleBackgroundLayerComponent2 As XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent2 As XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent2 As XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private circularGauge1 As XtraGauges.Win.Gauges.Circular.CircularGauge
		Private gaugeControl2 As XtraGauges.Win.GaugeControl
		Private linearScaleRangeBarForecast As XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent
		Private linearScaleComponent1 As XtraGauges.Win.Gauges.Linear.LinearScaleComponent
		Private linearGauge1 As XtraGauges.Win.Gauges.Linear.LinearGauge
		Private gaugeControl1 As XtraGauges.Win.GaugeControl
		Private circularGauge2 As XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent4 As XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScalePrevYear As XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private needleFiscalYear As XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private labelComponent1 As XtraGauges.Win.Base.LabelComponent
		Private gaugeControl3 As XtraGauges.Win.GaugeControl
		Private circularGauge3 As XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent3 As XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleFiscalToData As XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private needleFiscalToData As XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
		Private monthlySalesPerformance As ucSalesPerformance
		Private tableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
		Private tableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
		Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
		Private labelFiscalToData As System.Windows.Forms.Label
		Private labelFiscalYear As System.Windows.Forms.Label
		Private fiscalToData As System.Windows.Forms.Label
		Private fiscalYear As System.Windows.Forms.Label
		Private labelControl1 As XtraEditors.LabelControl
		Private labelControl3 As XtraEditors.LabelControl
		Private labelControl2 As XtraEditors.LabelControl
		Private labelControl4 As XtraEditors.LabelControl
		Private labelControl5 As XtraEditors.LabelControl
	End Class
End Namespace
