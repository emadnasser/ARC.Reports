Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.RealtorWorld.Win
	Partial Public Class ucSysInfo
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
			Dim scaleLabel1 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim scaleLabel2 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim scaleLabel3 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim scaleLabel4 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim scaleLabel5 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim scaleLabel6 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim scaleLabel7 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim scaleLabel8 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim scaleLabel9 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
			Me.labelComponent2 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
			Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleRangeBarComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
			Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleRangeBarComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
			Me.arcScaleRangeBarComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
			Me.arcScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleRangeBarComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleRangeBarComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleRangeBarComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(1105, 618)
			Me.gaugeControl1.TabIndex = 1
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1, Me.arcScaleBackgroundLayerComponent2, Me.arcScaleBackgroundLayerComponent3, Me.arcScaleBackgroundLayerComponent4})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 1093, 606)
			Me.circularGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() { Me.labelComponent1, Me.labelComponent2})
			Me.circularGauge1.Name = "circularGauge1"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1, Me.arcScaleNeedleComponent2, Me.arcScaleNeedleComponent3})
			Me.circularGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() { Me.arcScaleRangeBarComponent1, Me.arcScaleRangeBarComponent2, Me.arcScaleRangeBarComponent3, Me.arcScaleRangeBarComponent4})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1, Me.arcScaleComponent2, Me.arcScaleComponent3, Me.arcScaleComponent4, Me.arcScaleComponent5, Me.arcScaleComponent6, Me.arcScaleComponent7})
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "bgCPU"
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
			Me.arcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(122F, 122F)
			Me.arcScaleBackgroundLayerComponent1.ZOrder = -5
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 5F)
			Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 75F)
			Me.arcScaleComponent1.EndAngle = 60F
			scaleLabel1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 5F)
			scaleLabel1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			scaleLabel1.FormatString = "{0} {1:F0}%"
			scaleLabel1.Name = "Label0"
			scaleLabel1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 122F)
			scaleLabel1.Size = New System.Drawing.SizeF(100F, 12F)
			scaleLabel1.Text = "Total:"
			scaleLabel2.AppearanceText.Font = New System.Drawing.Font("Tahoma", 5F)
			scaleLabel2.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DimGray")
			scaleLabel2.FormatString = "{0}"
			scaleLabel2.Name = "Label1"
			scaleLabel2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 95F)
			scaleLabel2.Size = New System.Drawing.SizeF(50F, 12F)
			scaleLabel2.Text = "Kernel"
			scaleLabel3.AppearanceText.Font = New System.Drawing.Font("Tahoma", 5F)
			scaleLabel3.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DarkGray")
			scaleLabel3.FormatString = "{0}"
			scaleLabel3.Name = "Label2"
			scaleLabel3.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 88F)
			scaleLabel3.Size = New System.Drawing.SizeF(50F, 12F)
			scaleLabel3.Text = "User"
			Me.arcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() { scaleLabel1, scaleLabel2, scaleLabel3})
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -2F
			Me.arcScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.4F, 0.6F)
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
			Me.arcScaleComponent1.MajorTickmark.TextOffset = -7F
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 100F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3F, 0.5F)
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
			Me.arcScaleComponent1.Name = "cpuTotal"
			Me.arcScaleComponent1.RadiusX = 50F
			Me.arcScaleComponent1.RadiusY = 50F
			Me.arcScaleComponent1.StartAngle = -240F
			Me.arcScaleComponent1.Value = 15F
			Me.arcScaleComponent1.ZOrder = -50
			' 
			' arcScaleBackgroundLayerComponent2
			' 
			Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent4
			Me.arcScaleBackgroundLayerComponent2.Name = "bgOS"
			Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
			Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(100F, 100F)
			Me.arcScaleBackgroundLayerComponent2.ZOrder = 1050
			' 
			' arcScaleComponent4
			' 
			Me.arcScaleComponent4.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 4F)
			Me.arcScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScaleComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 175F)
			Me.arcScaleComponent4.EndAngle = 10F
			scaleLabel4.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4F)
			scaleLabel4.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			scaleLabel4.FormatString = "{0}{1:F0}"
			scaleLabel4.Name = "Label1"
			scaleLabel4.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 160F)
			scaleLabel4.Size = New System.Drawing.SizeF(50F, 12F)
			scaleLabel4.Text = "Threads:"
			Me.arcScaleComponent4.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() { scaleLabel4})
			Me.arcScaleComponent4.MajorTickCount = 7
			Me.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent4.MajorTickmark.ShapeOffset = -1F
			Me.arcScaleComponent4.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.25F, 0.4F)
			Me.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
			Me.arcScaleComponent4.MajorTickmark.TextOffset = -7F
			Me.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent4.MaxValue = 1300F
			Me.arcScaleComponent4.MinorTickCount = 4
			Me.arcScaleComponent4.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3F, 0.5F)
			Me.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
			Me.arcScaleComponent4.MinValue = 100F
			Me.arcScaleComponent4.Name = "osThreads"
			Me.arcScaleComponent4.RadiusX = 40F
			Me.arcScaleComponent4.RadiusY = 40F
			Me.arcScaleComponent4.StartAngle = -190F
			Me.arcScaleComponent4.Value = 500F
			' 
			' arcScaleBackgroundLayerComponent3
			' 
			Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleComponent6
			Me.arcScaleBackgroundLayerComponent3.Name = "bgMemory"
			Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
			Me.arcScaleBackgroundLayerComponent3.Size = New System.Drawing.SizeF(92F, 92F)
			Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
			' 
			' arcScaleComponent6
			' 
			Me.arcScaleComponent6.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 3F)
			Me.arcScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScaleComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(45F, 135F)
			Me.arcScaleComponent6.EndAngle = 60F
			scaleLabel5.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4F)
			scaleLabel5.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			scaleLabel5.FormatString = "{0} {2:P1}"
			scaleLabel5.Name = "Label0"
			scaleLabel5.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(50F, 150F)
			scaleLabel5.Size = New System.Drawing.SizeF(100F, 12F)
			scaleLabel5.Text = "Free:"
			scaleLabel6.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4F)
			scaleLabel6.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
			scaleLabel6.FormatString = "{0}"
			scaleLabel6.Name = "Label1"
			scaleLabel6.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(50F, 125F)
			scaleLabel6.Text = "Memory, MB"
			Me.arcScaleComponent6.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() { scaleLabel5, scaleLabel6})
			Me.arcScaleComponent6.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent6.MajorTickmark.ShapeOffset = -2F
			Me.arcScaleComponent6.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.2F, 0.3F)
			Me.arcScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
			Me.arcScaleComponent6.MajorTickmark.TextOffset = -7F
			Me.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent6.MaxValue = 100F
			Me.arcScaleComponent6.MinorTickCount = 4
			Me.arcScaleComponent6.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.15F, 0.25F)
			Me.arcScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
			Me.arcScaleComponent6.Name = "memoryTotal"
			Me.arcScaleComponent6.RadiusX = 40F
			Me.arcScaleComponent6.RadiusY = 40F
			Me.arcScaleComponent6.StartAngle = -240F
			Me.arcScaleComponent6.Value = 15F
			' 
			' arcScaleBackgroundLayerComponent4
			' 
			Me.arcScaleBackgroundLayerComponent4.ArcScale = Me.arcScaleComponent7
			Me.arcScaleBackgroundLayerComponent4.Name = "bgHDD"
			Me.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
			Me.arcScaleBackgroundLayerComponent4.Size = New System.Drawing.SizeF(92F, 92F)
			Me.arcScaleBackgroundLayerComponent4.ZOrder = 1000
			' 
			' arcScaleComponent7
			' 
			Me.arcScaleComponent7.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 3F)
			Me.arcScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScaleComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 135F)
			Me.arcScaleComponent7.EndAngle = 60F
			scaleLabel7.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4F)
			scaleLabel7.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			scaleLabel7.FormatString = "{0} {2:P1}"
			scaleLabel7.Name = "Label0"
			scaleLabel7.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 150F)
			scaleLabel7.Size = New System.Drawing.SizeF(100F, 12F)
			scaleLabel7.Text = "Free:"
			scaleLabel8.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4F)
			scaleLabel8.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
			scaleLabel8.FormatString = "{0}"
			scaleLabel8.Name = "Label1"
			scaleLabel8.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 125F)
			scaleLabel8.Text = "HDD, GB"
			Me.arcScaleComponent7.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() { scaleLabel7, scaleLabel8})
			Me.arcScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent7.MajorTickmark.ShapeOffset = -2F
			Me.arcScaleComponent7.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.2F, 0.3F)
			Me.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
			Me.arcScaleComponent7.MajorTickmark.TextOffset = -7F
			Me.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent7.MaxValue = 100F
			Me.arcScaleComponent7.MinorTickCount = 4
			Me.arcScaleComponent7.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.15F, 0.25F)
			Me.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
			Me.arcScaleComponent7.Name = "hddTotal"
			Me.arcScaleComponent7.RadiusX = 40F
			Me.arcScaleComponent7.RadiusY = 40F
			Me.arcScaleComponent7.StartAngle = -240F
			Me.arcScaleComponent7.Value = 15F
			' 
			' labelComponent1
			' 
			Me.labelComponent1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4F)
			Me.labelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
			Me.labelComponent1.Name = "processorName"
			Me.labelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 62F)
			Me.labelComponent1.Size = New System.Drawing.SizeF(75F, 25F)
			Me.labelComponent1.Text = "CPU Info"
			Me.labelComponent1.ZOrder = -45
			' 
			' labelComponent2
			' 
			Me.labelComponent2.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4F)
			Me.labelComponent2.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
			Me.labelComponent2.Name = "osName"
			Me.labelComponent2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 175F)
			Me.labelComponent2.Size = New System.Drawing.SizeF(55F, 25F)
			Me.labelComponent2.Text = "OS Info"
			Me.labelComponent2.ZOrder = -2
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.Name = "needleCpu"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
			Me.arcScaleNeedleComponent1.StartOffset = -2.75F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' arcScaleNeedleComponent2
			' 
			Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent6
			Me.arcScaleNeedleComponent2.Name = "needleRAM"
			Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
			Me.arcScaleNeedleComponent2.StartOffset = -2.75F
			Me.arcScaleNeedleComponent2.ZOrder = -50
			' 
			' arcScaleNeedleComponent3
			' 
			Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent7
			Me.arcScaleNeedleComponent3.Name = "needleHDD"
			Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
			Me.arcScaleNeedleComponent3.StartOffset = -2.75F
			Me.arcScaleNeedleComponent3.ZOrder = -50
			' 
			' arcScaleRangeBarComponent1
			' 
			Me.arcScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
			Me.arcScaleRangeBarComponent1.ArcScale = Me.arcScaleComponent2
			Me.arcScaleRangeBarComponent1.EndOffset = 15F
			Me.arcScaleRangeBarComponent1.Name = "rangeUser"
			Me.arcScaleRangeBarComponent1.StartOffset = 40F
			Me.arcScaleRangeBarComponent1.ZOrder = -10
			' 
			' arcScaleComponent2
			' 
			Me.arcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 6F)
			Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
			Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 75F)
			Me.arcScaleComponent2.EndAngle = 60F
			Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -2F
			Me.arcScaleComponent2.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
			Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
			Me.arcScaleComponent2.MajorTickmark.ShowText = False
			Me.arcScaleComponent2.MajorTickmark.ShowTick = False
			Me.arcScaleComponent2.MajorTickmark.TextOffset = -10F
			Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent2.MaxValue = 100F
			Me.arcScaleComponent2.MinorTickCount = 4
			Me.arcScaleComponent2.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
			Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
			Me.arcScaleComponent2.MinorTickmark.ShowTick = False
			Me.arcScaleComponent2.Name = "cpuUser"
			Me.arcScaleComponent2.RadiusX = 50F
			Me.arcScaleComponent2.RadiusY = 50F
			Me.arcScaleComponent2.StartAngle = -240F
			Me.arcScaleComponent2.Value = 15F
			Me.arcScaleComponent2.ZOrder = 1001
			' 
			' arcScaleRangeBarComponent2
			' 
			Me.arcScaleRangeBarComponent2.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
			Me.arcScaleRangeBarComponent2.ArcScale = Me.arcScaleComponent3
			Me.arcScaleRangeBarComponent2.EndOffset = 15F
			Me.arcScaleRangeBarComponent2.Name = "rangeKernel"
			Me.arcScaleRangeBarComponent2.StartOffset = 40F
			Me.arcScaleRangeBarComponent2.ZOrder = -11
			' 
			' arcScaleComponent3
			' 
			Me.arcScaleComponent3.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 6F)
			Me.arcScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
			Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 75F)
			Me.arcScaleComponent3.EndAngle = 60F
			Me.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent3.MajorTickmark.ShapeOffset = -2F
			Me.arcScaleComponent3.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
			Me.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
			Me.arcScaleComponent3.MajorTickmark.ShowText = False
			Me.arcScaleComponent3.MajorTickmark.ShowTick = False
			Me.arcScaleComponent3.MajorTickmark.TextOffset = -10F
			Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent3.MaxValue = 100F
			Me.arcScaleComponent3.MinorTickCount = 4
			Me.arcScaleComponent3.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
			Me.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
			Me.arcScaleComponent3.MinorTickmark.ShowTick = False
			Me.arcScaleComponent3.Name = "cpuKernel"
			Me.arcScaleComponent3.RadiusX = 50F
			Me.arcScaleComponent3.RadiusY = 50F
			Me.arcScaleComponent3.StartAngle = -240F
			Me.arcScaleComponent3.Value = 3F
			Me.arcScaleComponent3.ZOrder = 1002
			' 
			' arcScaleRangeBarComponent3
			' 
			Me.arcScaleRangeBarComponent3.AnchorValue = 100F
			Me.arcScaleRangeBarComponent3.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
			Me.arcScaleRangeBarComponent3.ArcScale = Me.arcScaleComponent4
			Me.arcScaleRangeBarComponent3.EndOffset = -3F
			Me.arcScaleRangeBarComponent3.Name = "rangeThreads"
			Me.arcScaleRangeBarComponent3.StartOffset = 35F
			Me.arcScaleRangeBarComponent3.ZOrder = 1
			' 
			' arcScaleRangeBarComponent4
			' 
			Me.arcScaleRangeBarComponent4.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
			Me.arcScaleRangeBarComponent4.ArcScale = Me.arcScaleComponent5
			Me.arcScaleRangeBarComponent4.EndOffset = -2F
			Me.arcScaleRangeBarComponent4.Name = "rangeProcesses"
			Me.arcScaleRangeBarComponent4.StartOffset = 35F
			Me.arcScaleRangeBarComponent4.ZOrder = 1
			' 
			' arcScaleComponent5
			' 
			Me.arcScaleComponent5.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 3F)
			Me.arcScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScaleComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 175F)
			Me.arcScaleComponent5.EndAngle = 150F
			scaleLabel9.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4F)
			scaleLabel9.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			scaleLabel9.FormatString = "{0}{1:F0}"
			scaleLabel9.Name = "Label1"
			scaleLabel9.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 195F)
			scaleLabel9.Size = New System.Drawing.SizeF(50F, 12F)
			scaleLabel9.Text = "Processes:"
			Me.arcScaleComponent5.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() { scaleLabel9})
			Me.arcScaleComponent5.MajorTickCount = 6
			Me.arcScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent5.MajorTickmark.ShapeOffset = -1F
			Me.arcScaleComponent5.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3F, 0.4F)
			Me.arcScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_2
			Me.arcScaleComponent5.MajorTickmark.TextOffset = -7F
			Me.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent5.MaxValue = 150F
			Me.arcScaleComponent5.MinorTickCount = 4
			Me.arcScaleComponent5.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3F, 0.5F)
			Me.arcScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_1
			Me.arcScaleComponent5.Name = "osProcesses"
			Me.arcScaleComponent5.RadiusX = 40F
			Me.arcScaleComponent5.RadiusY = 40F
			Me.arcScaleComponent5.StartAngle = 30F
			Me.arcScaleComponent5.Value = 50F
			' 
			' ucSysInfo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gaugeControl1)
			Me.Name = "ucSysInfo"
			Me.Size = New System.Drawing.Size(1105, 618)
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleRangeBarComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleRangeBarComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleRangeBarComponent4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private labelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
		Private labelComponent2 As DevExpress.XtraGauges.Win.Base.LabelComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
		Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleRangeBarComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
		Private arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleRangeBarComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
		Private arcScaleRangeBarComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
		Private arcScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

	End Class
End Namespace
