Namespace DevExpress.XtraGauges.Demos
    Partial Public Class StateImageIndicatorWeatherStation
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(StateImageIndicatorWeatherStation))
            Dim imageIndicatorState4 As New DevExpress.XtraGauges.Core.Model.ImageIndicatorState()
            Dim imageIndicatorState5 As New DevExpress.XtraGauges.Core.Model.ImageIndicatorState()
            Dim imageIndicatorState6 As New DevExpress.XtraGauges.Core.Model.ImageIndicatorState()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.gaugeControl3 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.siiLA = New DevExpress.XtraGauges.Win.Base.StateImageIndicatorComponent()
            Me.scHumidityLA = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.lcLA = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.rbLAHumidity = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
            Me.rbLATemp = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
            Me.scTempLA = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.lcSeason = New DevExpress.XtraEditors.LabelControl()
            Me.lcMonth = New DevExpress.XtraEditors.LabelControl()
            Me.lcDay = New DevExpress.XtraEditors.LabelControl()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.gaugeControl4 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.siiLn = New DevExpress.XtraGauges.Win.Base.StateImageIndicatorComponent()
            Me.scHumidityLn = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.lcLn = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.rbLnHumidity = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
            Me.rbLnTemp = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
            Me.scTempLn = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.gaugeControl5 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge3 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.siiMs = New DevExpress.XtraGauges.Win.Base.StateImageIndicatorComponent()
            Me.scHumidityMs = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.lcMs = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.rbMsHumidity = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
            Me.rbMsTemp = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
            Me.scTempMs = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.siiLA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scHumidityLA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcLA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbLAHumidity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbLATemp, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scTempLA, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.panel3.SuspendLayout()
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.siiLn, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scHumidityLn, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcLn, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbLnHumidity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbLnTemp, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scTempLn, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel4.SuspendLayout()
            CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.siiMs, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scHumidityMs, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcMs, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbMsHumidity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbMsTemp, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scTempMs, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = (DirectCast(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "Sunny.png")
            Me.imageList1.Images.SetKeyName(1, "Cloudy.png")
            Me.imageList1.Images.SetKeyName(2, "Rainy.png")
            Me.imageList1.Images.SetKeyName(3, "Snow.png")
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 5
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.panel1, 1, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.panel2, 2, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.panel3, 3, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.panel4, 2, 1)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 3
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(1100, 677)
            Me.tableLayoutPanel1.TabIndex = 27
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.gaugeControl3)
            Me.panel1.Controls.Add(Me.labelControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(118, 83)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(284, 294)
            Me.panel1.TabIndex = 23
            ' 
            ' gaugeControl3
            ' 
            Me.gaugeControl3.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl3.ColorScheme.Color = System.Drawing.Color.FromArgb((CInt((CByte(252)))), (CInt((CByte(30)))), (CInt((CByte(82)))))
            Me.gaugeControl3.ColorScheme.TargetElements = (CType((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar Or DevExpress.XtraGauges.Core.Base.TargetElement.Label), DevExpress.XtraGauges.Core.Base.TargetElement))
            Me.gaugeControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl3.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl3.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(0)
            Me.gaugeControl3.Location = New System.Drawing.Point(0, 32)
            Me.gaugeControl3.Name = "gaugeControl3"
            Me.gaugeControl3.Size = New System.Drawing.Size(284, 262)
            Me.gaugeControl3.TabIndex = 18
            ' 
            ' circularGauge1
            ' 
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(0, 0, 284, 262)
            Me.circularGauge1.ImageIndicators.AddRange(New DevExpress.XtraGauges.Win.Base.StateImageIndicatorComponent() {Me.siiLA})
            Me.circularGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.lcLA})
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.rbLAHumidity, Me.rbLATemp})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.scHumidityLA, Me.scTempLA})
            ' 
            ' siiLA
            ' 
            Me.siiLA.AllowImageSkinning = True
            imageIndicatorState4.Name = "State1"
            Me.siiLA.ImageStateCollection.AddRange(New DevExpress.XtraGauges.Core.Model.ImageIndicatorState() {imageIndicatorState4})
            Me.siiLA.IndicatorScale = Me.scHumidityLA
            Me.siiLA.Name = "circularGauge3_StateImageIndicator1"
            Me.siiLA.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(110.0F, 125.0F)
            Me.siiLA.StateImages = Me.imageList1
            Me.siiLA.StateIndex = 0
            ' 
            ' scHumidityLA
            ' 
            Me.scHumidityLA.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityLA.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityLA.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityLA.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityLA.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5F)
            Me.scHumidityLA.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
            Me.scHumidityLA.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0F, 125.0F)
            Me.scHumidityLA.EndAngle = 90.0F
            Me.scHumidityLA.MajorTickCount = 0
            Me.scHumidityLA.MajorTickmark.FormatString = "{0:F0}"
            Me.scHumidityLA.MajorTickmark.ShapeOffset = -18.0F
            Me.scHumidityLA.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
            Me.scHumidityLA.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.scHumidityLA.MaxValue = 100.0F
            Me.scHumidityLA.MinorTickCount = 0
            Me.scHumidityLA.MinorTickmark.ShapeOffset = -7.0F
            Me.scHumidityLA.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.scHumidityLA.Name = "scale1"
            Me.scHumidityLA.StartAngle = -270.0F
            Me.scHumidityLA.Value = 10.0F
            ' 
            ' lcLA
            ' 
            Me.lcLA.AllowHTMLString = True
            Me.lcLA.AppearanceText.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lcLA.AppearanceText.Format = New DevExpress.XtraGauges.Core.Drawing.StringFormatObject(System.Drawing.StringAlignment.Far, System.Drawing.StringAlignment.Center, System.Drawing.StringTrimming.Character, System.Drawing.StringFormatFlags.NoClip)
            Me.lcLA.Name = "circularGauge3_Label1"
            Me.lcLA.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(155.0F, 125.0F)
            Me.lcLA.Size = New System.Drawing.SizeF(50.0F, 50.0F)
            Me.lcLA.Text = "t: +12C  h: 96%"
            Me.lcLA.ZOrder = -1001
            ' 
            ' rbLAHumidity
            ' 
            Me.rbLAHumidity.ArcScale = Me.scHumidityLA
            Me.rbLAHumidity.Name = "circularGauge3_RangeBar2"
            Me.rbLAHumidity.ShowBackground = True
            Me.rbLAHumidity.StartOffset = 79.0F
            Me.rbLAHumidity.ZOrder = -10
            ' 
            ' rbLATemp
            ' 
            Me.rbLATemp.ArcScale = Me.scTempLA
            Me.rbLATemp.EndOffset = 25.0F
            Me.rbLATemp.Name = "circularGauge3_RangeBar3"
            Me.rbLATemp.ShowBackground = True
            Me.rbLATemp.StartOffset = 64.0F
            Me.rbLATemp.ZOrder = -10
            ' 
            ' scTempLA
            ' 
            Me.scTempLA.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempLA.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempLA.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempLA.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempLA.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.scTempLA.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.scTempLA.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0F, 125.0F)
            Me.scTempLA.EndAngle = -45.0F
            Me.scTempLA.MajorTickCount = 3
            Me.scTempLA.MajorTickmark.FormatString = "{0:F0}"
            Me.scTempLA.MajorTickmark.ShowTick = False
            Me.scTempLA.MajorTickmark.TextOffset = -45.0F
            Me.scTempLA.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.scTempLA.MaxValue = 30.0F
            Me.scTempLA.MinorTickCount = 0
            Me.scTempLA.MinorTickmark.ShapeOffset = -7.0F
            Me.scTempLA.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.scTempLA.MinValue = -30.0F
            Me.scTempLA.Name = "scale1Copy0"
            Me.scTempLA.StartAngle = -270.0F
            Me.scTempLA.Value = 10.0F
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75F)
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl1.Location = New System.Drawing.Point(0, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(284, 32)
            Me.labelControl1.TabIndex = 19
            Me.labelControl1.Text = "Los Angeles"
            ' 
            ' panel2
            ' 
            Me.panel2.Controls.Add(Me.lcSeason)
            Me.panel2.Controls.Add(Me.lcMonth)
            Me.panel2.Controls.Add(Me.lcDay)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(408, 383)
            Me.panel2.Name = "panel2"
            Me.panel2.Padding = New System.Windows.Forms.Padding(0, 50, 0, 0)
            Me.panel2.Size = New System.Drawing.Size(284, 291)
            Me.panel2.TabIndex = 22
            ' 
            ' lcSeason
            ' 
            Me.lcSeason.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.lcSeason.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(173)))), (CInt((CByte(173)))), (CInt((CByte(173)))))
            Me.lcSeason.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lcSeason.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.lcSeason.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lcSeason.Dock = System.Windows.Forms.DockStyle.Top
            Me.lcSeason.Location = New System.Drawing.Point(0, 158)
            Me.lcSeason.Name = "lcSeason"
            Me.lcSeason.Size = New System.Drawing.Size(284, 54)
            Me.lcSeason.TabIndex = 21
            Me.lcSeason.Text = "WINTER"
            ' 
            ' lcMonth
            ' 
            Me.lcMonth.AllowHtmlString = True
            Me.lcMonth.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.lcMonth.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lcMonth.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
            Me.lcMonth.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lcMonth.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lcMonth.Dock = System.Windows.Forms.DockStyle.Top
            Me.lcMonth.Location = New System.Drawing.Point(0, 121)
            Me.lcMonth.Name = "lcMonth"
            Me.lcMonth.Size = New System.Drawing.Size(284, 37)
            Me.lcMonth.TabIndex = 19
            Me.lcMonth.Text = "DECEMBER"
            ' 
            ' lcDay
            ' 
            Me.lcDay.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 48.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.lcDay.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lcDay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lcDay.Dock = System.Windows.Forms.DockStyle.Top
            Me.lcDay.Location = New System.Drawing.Point(0, 50)
            Me.lcDay.Margin = New System.Windows.Forms.Padding(0)
            Me.lcDay.Name = "lcDay"
            Me.lcDay.Size = New System.Drawing.Size(284, 71)
            Me.lcDay.TabIndex = 20
            Me.lcDay.Text = "27"
            ' 
            ' panel3
            ' 
            Me.panel3.Controls.Add(Me.gaugeControl4)
            Me.panel3.Controls.Add(Me.labelControl5)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(698, 83)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(284, 294)
            Me.panel3.TabIndex = 25
            ' 
            ' gaugeControl4
            ' 
            Me.gaugeControl4.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl4.ColorScheme.Color = System.Drawing.Color.FromArgb((CInt((CByte(252)))), (CInt((CByte(30)))), (CInt((CByte(82)))))
            Me.gaugeControl4.ColorScheme.TargetElements = (CType((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar Or DevExpress.XtraGauges.Core.Base.TargetElement.Label), DevExpress.XtraGauges.Core.Base.TargetElement))
            Me.gaugeControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl4.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge2})
            Me.gaugeControl4.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(0)
            Me.gaugeControl4.Location = New System.Drawing.Point(0, 32)
            Me.gaugeControl4.Name = "gaugeControl4"
            Me.gaugeControl4.Size = New System.Drawing.Size(284, 262)
            Me.gaugeControl4.TabIndex = 18
            ' 
            ' circularGauge2
            ' 
            Me.circularGauge2.Bounds = New System.Drawing.Rectangle(0, 0, 284, 262)
            Me.circularGauge2.ImageIndicators.AddRange(New DevExpress.XtraGauges.Win.Base.StateImageIndicatorComponent() {Me.siiLn})
            Me.circularGauge2.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.lcLn})
            Me.circularGauge2.Name = "circularGauge2"
            Me.circularGauge2.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.rbLnHumidity, Me.rbLnTemp})
            Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.scHumidityLn, Me.scTempLn})
            ' 
            ' siiLn
            ' 
            Me.siiLn.AllowImageSkinning = True
            imageIndicatorState5.Name = "State1"
            Me.siiLn.ImageStateCollection.AddRange(New DevExpress.XtraGauges.Core.Model.ImageIndicatorState() {imageIndicatorState5})
            Me.siiLn.IndicatorScale = Me.scHumidityLn
            Me.siiLn.Name = "circularGauge3_StateImageIndicator1"
            Me.siiLn.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(110.0F, 125.0F)
            Me.siiLn.StateImages = Me.imageList1
            Me.siiLn.StateIndex = 0
            ' 
            ' scHumidityLn
            ' 
            Me.scHumidityLn.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityLn.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityLn.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityLn.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityLn.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5F)
            Me.scHumidityLn.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
            Me.scHumidityLn.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0F, 125.0F)
            Me.scHumidityLn.EndAngle = 90.0F
            Me.scHumidityLn.MajorTickCount = 0
            Me.scHumidityLn.MajorTickmark.FormatString = "{0:F0}"
            Me.scHumidityLn.MajorTickmark.ShapeOffset = -14.0F
            Me.scHumidityLn.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
            Me.scHumidityLn.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.scHumidityLn.MaxValue = 100.0F
            Me.scHumidityLn.MinorTickCount = 0
            Me.scHumidityLn.MinorTickmark.ShapeOffset = -7.0F
            Me.scHumidityLn.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.scHumidityLn.Name = "scale1"
            Me.scHumidityLn.StartAngle = -270.0F
            Me.scHumidityLn.Value = 10.0F
            ' 
            ' lcLn
            ' 
            Me.lcLn.AllowHTMLString = True
            Me.lcLn.AppearanceText.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lcLn.Name = "circularGauge3_Label1"
            Me.lcLn.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(155.0F, 125.0F)
            Me.lcLn.Size = New System.Drawing.SizeF(50.0F, 50.0F)
            Me.lcLn.Text = "t: +12C  h: 96%"
            Me.lcLn.ZOrder = -1001
            ' 
            ' rbLnHumidity
            ' 
            Me.rbLnHumidity.ArcScale = Me.scHumidityLn
            Me.rbLnHumidity.Name = "circularGauge3_RangeBar2"
            Me.rbLnHumidity.ShowBackground = True
            Me.rbLnHumidity.StartOffset = 79.0F
            Me.rbLnHumidity.ZOrder = -10
            ' 
            ' rbLnTemp
            ' 
            Me.rbLnTemp.ArcScale = Me.scTempLn
            Me.rbLnTemp.EndOffset = 25.0F
            Me.rbLnTemp.Name = "circularGauge3_RangeBar3"
            Me.rbLnTemp.ShowBackground = True
            Me.rbLnTemp.StartOffset = 64.0F
            Me.rbLnTemp.ZOrder = -10
            ' 
            ' scTempLn
            ' 
            Me.scTempLn.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempLn.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempLn.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempLn.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempLn.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold)
            Me.scTempLn.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
            Me.scTempLn.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0F, 125.0F)
            Me.scTempLn.EndAngle = -45.0F
            Me.scTempLn.MajorTickCount = 3
            Me.scTempLn.MajorTickmark.FormatString = "{0:F0}"
            Me.scTempLn.MajorTickmark.ShowTick = False
            Me.scTempLn.MajorTickmark.TextOffset = -45.0F
            Me.scTempLn.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.scTempLn.MaxValue = 30.0F
            Me.scTempLn.MinorTickCount = 0
            Me.scTempLn.MinorTickmark.ShapeOffset = -7.0F
            Me.scTempLn.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.scTempLn.MinValue = -30.0F
            Me.scTempLn.Name = "scale1Copy0"
            Me.scTempLn.StartAngle = -270.0F
            Me.scTempLn.Value = 10.0F
            ' 
            ' labelControl5
            ' 
            Me.labelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl5.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl5.Location = New System.Drawing.Point(0, 0)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(284, 32)
            Me.labelControl5.TabIndex = 19
            Me.labelControl5.Text = "London"
            ' 
            ' panel4
            ' 
            Me.panel4.Controls.Add(Me.gaugeControl5)
            Me.panel4.Controls.Add(Me.labelControl6)
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel4.Location = New System.Drawing.Point(408, 83)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(284, 294)
            Me.panel4.TabIndex = 24
            ' 
            ' gaugeControl5
            ' 
            Me.gaugeControl5.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl5.ColorScheme.Color = System.Drawing.Color.FromArgb((CInt((CByte(252)))), (CInt((CByte(30)))), (CInt((CByte(82)))))
            Me.gaugeControl5.ColorScheme.TargetElements = (CType((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar Or DevExpress.XtraGauges.Core.Base.TargetElement.Label), DevExpress.XtraGauges.Core.Base.TargetElement))
            Me.gaugeControl5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl5.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge3})
            Me.gaugeControl5.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(0)
            Me.gaugeControl5.Location = New System.Drawing.Point(0, 32)
            Me.gaugeControl5.Name = "gaugeControl5"
            Me.gaugeControl5.Size = New System.Drawing.Size(284, 262)
            Me.gaugeControl5.TabIndex = 18
            ' 
            ' circularGauge3
            ' 
            Me.circularGauge3.Bounds = New System.Drawing.Rectangle(0, 0, 284, 262)
            Me.circularGauge3.ImageIndicators.AddRange(New DevExpress.XtraGauges.Win.Base.StateImageIndicatorComponent() {Me.siiMs})
            Me.circularGauge3.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.lcMs})
            Me.circularGauge3.Name = "circularGauge3"
            Me.circularGauge3.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.rbMsHumidity, Me.rbMsTemp})
            Me.circularGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.scHumidityMs, Me.scTempMs})
            ' 
            ' siiMs
            ' 
            Me.siiMs.AllowImageSkinning = True
            imageIndicatorState6.Name = "State1"
            Me.siiMs.ImageStateCollection.AddRange(New DevExpress.XtraGauges.Core.Model.ImageIndicatorState() {imageIndicatorState6})
            Me.siiMs.IndicatorScale = Me.scHumidityMs
            Me.siiMs.Name = "circularGauge3_StateImageIndicator1"
            Me.siiMs.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(110.0F, 125.0F)
            Me.siiMs.StateImages = Me.imageList1
            Me.siiMs.StateIndex = 0
            ' 
            ' scHumidityMs
            ' 
            Me.scHumidityMs.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityMs.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityMs.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityMs.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scHumidityMs.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5F)
            Me.scHumidityMs.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
            Me.scHumidityMs.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0F, 125.0F)
            Me.scHumidityMs.EndAngle = 90.0F
            Me.scHumidityMs.MajorTickCount = 0
            Me.scHumidityMs.MajorTickmark.FormatString = "{0:F0}"
            Me.scHumidityMs.MajorTickmark.ShapeOffset = -14.0F
            Me.scHumidityMs.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
            Me.scHumidityMs.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.scHumidityMs.MaxValue = 100.0F
            Me.scHumidityMs.MinorTickCount = 0
            Me.scHumidityMs.MinorTickmark.ShapeOffset = -7.0F
            Me.scHumidityMs.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.scHumidityMs.Name = "scale1"
            Me.scHumidityMs.StartAngle = -270.0F
            Me.scHumidityMs.Value = 10.0F
            ' 
            ' lcMs
            ' 
            Me.lcMs.AllowHTMLString = True
            Me.lcMs.AppearanceText.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lcMs.AppearanceText.Format = New DevExpress.XtraGauges.Core.Drawing.StringFormatObject(System.Drawing.StringAlignment.Center, System.Drawing.StringAlignment.Far, System.Drawing.StringTrimming.Character, System.Drawing.StringFormatFlags.NoClip)
            Me.lcMs.Name = "circularGauge3_Label1"
            Me.lcMs.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(155.0F, 125.0F)
            Me.lcMs.Size = New System.Drawing.SizeF(50.0F, 50.0F)
            Me.lcMs.Text = "t: +12C  h: 96%"
            Me.lcMs.ZOrder = -1001
            ' 
            ' rbMsHumidity
            ' 
            Me.rbMsHumidity.ArcScale = Me.scHumidityMs
            Me.rbMsHumidity.Name = "circularGauge3_RangeBar2"
            Me.rbMsHumidity.ShowBackground = True
            Me.rbMsHumidity.StartOffset = 79.0F
            Me.rbMsHumidity.ZOrder = -10
            ' 
            ' rbMsTemp
            ' 
            Me.rbMsTemp.ArcScale = Me.scTempMs
            Me.rbMsTemp.EndOffset = 25.0F
            Me.rbMsTemp.Name = "circularGauge3_RangeBar3"
            Me.rbMsTemp.ShowBackground = True
            Me.rbMsTemp.StartOffset = 64.0F
            Me.rbMsTemp.ZOrder = -10
            ' 
            ' scTempMs
            ' 
            Me.scTempMs.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempMs.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempMs.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempMs.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scTempMs.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold)
            Me.scTempMs.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
            Me.scTempMs.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0F, 125.0F)
            Me.scTempMs.EndAngle = -45.0F
            Me.scTempMs.MajorTickCount = 3
            Me.scTempMs.MajorTickmark.FormatString = "{0:F0}"
            Me.scTempMs.MajorTickmark.ShowTick = False
            Me.scTempMs.MajorTickmark.TextOffset = -45.0F
            Me.scTempMs.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.scTempMs.MaxValue = 30.0F
            Me.scTempMs.MinorTickCount = 0
            Me.scTempMs.MinorTickmark.ShapeOffset = -7.0F
            Me.scTempMs.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.scTempMs.MinValue = -30.0F
            Me.scTempMs.Name = "scale1Copy0"
            Me.scTempMs.StartAngle = -270.0F
            Me.scTempMs.Value = 10.0F
            ' 
            ' labelControl6
            ' 
            Me.labelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75F)
            Me.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl6.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl6.Location = New System.Drawing.Point(0, 0)
            Me.labelControl6.Name = "labelControl6"
            Me.labelControl6.Size = New System.Drawing.Size(284, 32)
            Me.labelControl6.TabIndex = 19
            Me.labelControl6.Text = "Moscow"
            ' 
            ' StateImageIndicators
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Name = "StateImageIndicators"
            Me.Size = New System.Drawing.Size(1100, 677)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.siiLA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scHumidityLA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcLA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbLAHumidity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbLATemp, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scTempLA, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.siiLn, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scHumidityLn, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcLn, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbLnHumidity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbLnTemp, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scTempLn, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel4.ResumeLayout(False)
            CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.siiMs, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scHumidityMs, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcMs, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbMsHumidity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbMsTemp, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scTempMs, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private panel1 As System.Windows.Forms.Panel
        Private gaugeControl3 As Win.GaugeControl
        Private circularGauge1 As Win.Gauges.Circular.CircularGauge
        Private siiLA As Win.Base.StateImageIndicatorComponent
        Private scHumidityLA As Win.Gauges.Circular.ArcScaleComponent
        Private lcLA As Win.Base.LabelComponent
        Private rbLAHumidity As Win.Gauges.Circular.ArcScaleRangeBarComponent
        Private rbLATemp As Win.Gauges.Circular.ArcScaleRangeBarComponent
        Private scTempLA As Win.Gauges.Circular.ArcScaleComponent
        Private labelControl1 As XtraEditors.LabelControl
        Private panel2 As System.Windows.Forms.Panel
        Private lcSeason As XtraEditors.LabelControl
        Private lcMonth As XtraEditors.LabelControl
        Private lcDay As XtraEditors.LabelControl
        Private panel3 As System.Windows.Forms.Panel
        Private gaugeControl4 As Win.GaugeControl
        Private circularGauge2 As Win.Gauges.Circular.CircularGauge
        Private siiLn As Win.Base.StateImageIndicatorComponent
        Private scHumidityLn As Win.Gauges.Circular.ArcScaleComponent
        Private lcLn As Win.Base.LabelComponent
        Private rbLnHumidity As Win.Gauges.Circular.ArcScaleRangeBarComponent
        Private rbLnTemp As Win.Gauges.Circular.ArcScaleRangeBarComponent
        Private scTempLn As Win.Gauges.Circular.ArcScaleComponent
        Private labelControl5 As XtraEditors.LabelControl
        Private panel4 As System.Windows.Forms.Panel
        Private gaugeControl5 As Win.GaugeControl
        Private circularGauge3 As Win.Gauges.Circular.CircularGauge
        Private siiMs As Win.Base.StateImageIndicatorComponent
        Private scHumidityMs As Win.Gauges.Circular.ArcScaleComponent
        Private lcMs As Win.Base.LabelComponent
        Private rbMsHumidity As Win.Gauges.Circular.ArcScaleRangeBarComponent
        Private rbMsTemp As Win.Gauges.Circular.ArcScaleRangeBarComponent
        Private scTempMs As Win.Gauges.Circular.ArcScaleComponent
        Private labelControl6 As XtraEditors.LabelControl
        Private imageList1 As System.Windows.Forms.ImageList
    End Class
End Namespace
