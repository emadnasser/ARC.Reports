Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGauges.Demos
	Partial Public Class StyleManagerFeature
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
            Dim ArcScaleRange1 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange
            Dim ArcScaleRange2 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange
            Dim ArcScaleRange3 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange
            Dim LinearScaleRange1 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange
            Dim LinearScaleRange2 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange
            Dim LinearScaleRange3 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange
            Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.gControl4 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.linearGauge2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
            Me.linearScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
            Me.linearScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
            Me.linearScaleLevelComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
            Me.digitalGauge2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
            Me.digitalBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
            Me.btnStyleChooser = New DevExpress.XtraEditors.SimpleButton
            Me.btnStyleManager = New DevExpress.XtraEditors.SimpleButton
            Me.gControl1 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.CircularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.ArcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.ArcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.ArcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
            Me.ArcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.ArcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
            Me.gControl3 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.digitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
            Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
            Me.gControl2 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.LinearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
            Me.LinearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
            Me.LinearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
            Me.LinearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.tabGroup = New DevExpress.XtraLayout.TabbedControlGroup
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtraScrollableControl1.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleLevelComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.digitalGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.digitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CircularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.digitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LinearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraScrollableControl1
            '
            Me.xtraScrollableControl1.Controls.Add(Me.layoutControl1)
            Me.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
            Me.xtraScrollableControl1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 12)
            Me.xtraScrollableControl1.Size = New System.Drawing.Size(601, 480)
            Me.xtraScrollableControl1.TabIndex = 0
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.gControl4)
            Me.layoutControl1.Controls.Add(Me.btnStyleChooser)
            Me.layoutControl1.Controls.Add(Me.btnStyleManager)
            Me.layoutControl1.Controls.Add(Me.gControl1)
            Me.layoutControl1.Controls.Add(Me.gControl3)
            Me.layoutControl1.Controls.Add(Me.gControl2)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 8)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(601, 460)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            '
            'gControl4
            '
            Me.gControl4.AutoLayout = False
            Me.gControl4.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge2, Me.linearGauge2, Me.digitalGauge2})
            Me.gControl4.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(25)
            Me.gControl4.Location = New System.Drawing.Point(14, 66)
            Me.gControl4.Name = "gControl4"
            Me.gControl4.Size = New System.Drawing.Size(573, 380)
            Me.gControl4.TabIndex = 6
            '
            'circularGauge2
            '
            Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent2})
            Me.circularGauge2.Bounds = New System.Drawing.Rectangle(11, 2, 378, 366)
            Me.circularGauge2.Name = "circularGauge2"
            Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent2})
            Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent2})
            '
            'arcScaleBackgroundLayerComponent2
            '
            Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleBackgroundLayerComponent2.Name = "Gauge0_BackgroundLayer1"
            Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style7
            Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
            '
            'arcScaleComponent2
            '
            Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent2.EndAngle = 60.0!
            Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_2
            Me.arcScaleComponent2.MajorTickmark.TextOffset = 22.0!
            Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent2.MaxValue = 100.0!
            Me.arcScaleComponent2.MinorTickCount = 4
            Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_1
            Me.arcScaleComponent2.Name = "Gauge0_Scale1"
            Me.arcScaleComponent2.RadiusX = 83.0!
            Me.arcScaleComponent2.RadiusY = 83.0!
            Me.arcScaleComponent2.StartAngle = -240.0!
            Me.arcScaleComponent2.Value = 50.0!
            '
            'arcScaleNeedleComponent2
            '
            Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleNeedleComponent2.EndOffset = -25.0!
            Me.arcScaleNeedleComponent2.Name = "Gauge0_Needle1"
            Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style7
            Me.arcScaleNeedleComponent2.StartOffset = -21.0!
            Me.arcScaleNeedleComponent2.ZOrder = -50
            '
            'linearGauge2
            '
            Me.linearGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent2})
            Me.linearGauge2.Bounds = New System.Drawing.Rectangle(300, 29, 255, 332)
            Me.linearGauge2.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent2})
            Me.linearGauge2.Name = "linearGauge2"
            Me.linearGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent2})
            '
            'linearScaleBackgroundLayerComponent2
            '
            Me.linearScaleBackgroundLayerComponent2.LinearScale = Me.linearScaleComponent2
            Me.linearScaleBackgroundLayerComponent2.Name = "Gauge1_BackgroundLayer1"
            Me.linearScaleBackgroundLayerComponent2.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497!, 0.14!)
            Me.linearScaleBackgroundLayerComponent2.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497!, 0.86!)
            Me.linearScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style5
            Me.linearScaleBackgroundLayerComponent2.ZOrder = 1000
            '
            'linearScaleComponent2
            '
            Me.linearScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            Me.linearScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent2.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 35.0!)
            Me.linearScaleComponent2.MajorTickCount = 6
            Me.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent2.MajorTickmark.ShapeOffset = 5.0!
            Me.linearScaleComponent2.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.8!, 0.8!)
            Me.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style5_3
            Me.linearScaleComponent2.MajorTickmark.TextOffset = 37.0!
            Me.linearScaleComponent2.MaxValue = 100.0!
            Me.linearScaleComponent2.MinorTickCount = 4
            Me.linearScaleComponent2.MinorTickmark.ShapeOffset = 5.0!
            Me.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style5_1
            Me.linearScaleComponent2.Name = "Gauge1_Scale1"
            Me.linearScaleComponent2.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 215.0!)
            '
            'linearScaleLevelComponent2
            '
            Me.linearScaleLevelComponent2.LinearScale = Me.linearScaleComponent2
            Me.linearScaleLevelComponent2.Name = "Gauge1_Level1"
            Me.linearScaleLevelComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style5
            Me.linearScaleLevelComponent2.ZOrder = -50
            '
            'digitalGauge2
            '
            Me.digitalGauge2.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge2.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.digitalGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent2})
            Me.digitalGauge2.Bounds = New System.Drawing.Rectangle(90, 237, 309, 100)
            Me.digitalGauge2.Name = "digitalGauge2"
            Me.digitalGauge2.Text = "00.000"
            '
            'digitalBackgroundLayerComponent2
            '
            Me.digitalBackgroundLayerComponent2.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
            Me.digitalBackgroundLayerComponent2.Name = "Gauge2_BackgroundLayer1"
            Me.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style15
            Me.digitalBackgroundLayerComponent2.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
            Me.digitalBackgroundLayerComponent2.ZOrder = 1000
            '
            'btnStyleChooser
            '
            Me.btnStyleChooser.AutoWidthInLayoutControl = True
            Me.btnStyleChooser.Location = New System.Drawing.Point(285, 2)
            Me.btnStyleChooser.MaximumSize = New System.Drawing.Size(150, 0)
            Me.btnStyleChooser.MinimumSize = New System.Drawing.Size(150, 0)
            Me.btnStyleChooser.Name = "btnStyleChooser"
            Me.btnStyleChooser.Size = New System.Drawing.Size(150, 22)
            Me.btnStyleChooser.StyleController = Me.layoutControl1
            Me.btnStyleChooser.TabIndex = 8
            Me.btnStyleChooser.Text = "Show StyleChooser..."
            '
            'btnStyleManager
            '
            Me.btnStyleManager.AutoWidthInLayoutControl = True
            Me.btnStyleManager.Location = New System.Drawing.Point(449, 2)
            Me.btnStyleManager.MaximumSize = New System.Drawing.Size(150, 0)
            Me.btnStyleManager.MinimumSize = New System.Drawing.Size(150, 0)
            Me.btnStyleManager.Name = "btnStyleManager"
            Me.btnStyleManager.Size = New System.Drawing.Size(150, 22)
            Me.btnStyleManager.StyleController = Me.layoutControl1
            Me.btnStyleManager.TabIndex = 7
            Me.btnStyleManager.Text = "Show StyleManager..."
            '
            'gControl1
            '
            Me.gControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.CircularGauge1})
            Me.gControl1.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(50)
            Me.gControl1.Location = New System.Drawing.Point(14, 66)
            Me.gControl1.Name = "gControl1"
            Me.gControl1.Size = New System.Drawing.Size(573, 380)
            Me.gControl1.TabIndex = 4
            '
            'CircularGauge1
            '
            Me.CircularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent1})
            Me.CircularGauge1.Bounds = New System.Drawing.Rectangle(50, 50, 473, 280)
            Me.CircularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.ArcScaleEffectLayerComponent1})
            Me.CircularGauge1.Name = "CircularGauge1"
            Me.CircularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent1})
            Me.CircularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent1})
            Me.CircularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.ArcScaleSpindleCapComponent1})
            '
            'ArcScaleBackgroundLayerComponent1
            '
            Me.ArcScaleBackgroundLayerComponent1.ArcScale = Me.ArcScaleComponent1
            Me.ArcScaleBackgroundLayerComponent1.Name = "bg"
            Me.ArcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style16
            Me.ArcScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'ArcScaleComponent1
            '
            Me.ArcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5!)
            Me.ArcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
            Me.ArcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.ArcScaleComponent1.EndAngle = 60.0!
            Me.ArcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.ArcScaleComponent1.MajorTickmark.ShapeOffset = -14.0!
            Me.ArcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
            Me.ArcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.ArcScaleComponent1.MaxValue = 100.0!
            Me.ArcScaleComponent1.MinorTickCount = 4
            Me.ArcScaleComponent1.MinorTickmark.ShapeOffset = -7.0!
            Me.ArcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.ArcScaleComponent1.Name = "scale1"
            ArcScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968")
            ArcScaleRange1.EndThickness = 14.0!
            ArcScaleRange1.EndValue = 33.0!
            ArcScaleRange1.Name = "Range0"
            ArcScaleRange1.ShapeOffset = 0.0!
            ArcScaleRange1.StartThickness = 14.0!
            ArcScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FED96D")
            ArcScaleRange2.EndThickness = 14.0!
            ArcScaleRange2.EndValue = 66.0!
            ArcScaleRange2.Name = "Range1"
            ArcScaleRange2.ShapeOffset = 0.0!
            ArcScaleRange2.StartThickness = 14.0!
            ArcScaleRange2.StartValue = 33.0!
            ArcScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EF8C75")
            ArcScaleRange3.EndThickness = 14.0!
            ArcScaleRange3.EndValue = 100.0!
            ArcScaleRange3.Name = "Range2"
            ArcScaleRange3.ShapeOffset = 0.0!
            ArcScaleRange3.StartThickness = 14.0!
            ArcScaleRange3.StartValue = 66.0!
            Me.ArcScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange1, ArcScaleRange2, ArcScaleRange3})
            Me.ArcScaleComponent1.StartAngle = -240.0!
            Me.ArcScaleComponent1.Value = 80.0!
            '
            'ArcScaleEffectLayerComponent1
            '
            Me.ArcScaleEffectLayerComponent1.ArcScale = Me.ArcScaleComponent1
            Me.ArcScaleEffectLayerComponent1.Name = "circularGauge1_EffectLayer1"
            Me.ArcScaleEffectLayerComponent1.ZOrder = -1000
            '
            'ArcScaleNeedleComponent1
            '
            Me.ArcScaleNeedleComponent1.ArcScale = Me.ArcScaleComponent1
            Me.ArcScaleNeedleComponent1.EndOffset = 5.0!
            Me.ArcScaleNeedleComponent1.Name = "needle"
            Me.ArcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16
            Me.ArcScaleNeedleComponent1.ZOrder = -50
            '
            'ArcScaleSpindleCapComponent1
            '
            Me.ArcScaleSpindleCapComponent1.ArcScale = Me.ArcScaleComponent1
            Me.ArcScaleSpindleCapComponent1.Name = "cGauge1_SpindleCap1"
            Me.ArcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16
            Me.ArcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(25.0!, 25.0!)
            Me.ArcScaleSpindleCapComponent1.ZOrder = -100
            '
            'gControl3
            '
            Me.gControl3.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge1})
            Me.gControl3.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(25)
            Me.gControl3.Location = New System.Drawing.Point(14, 66)
            Me.gControl3.Name = "gControl3"
            Me.gControl3.Size = New System.Drawing.Size(573, 380)
            Me.gControl3.TabIndex = 5
            '
            'digitalGauge1
            '
            Me.digitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent1})
            Me.digitalGauge1.Bounds = New System.Drawing.Rectangle(25, 25, 523, 330)
            Me.digitalGauge1.DigitCount = 5
            Me.digitalGauge1.Name = "digitalGauge1"
            Me.digitalGauge1.Text = "00,000"
            '
            'digitalBackgroundLayerComponent1
            '
            Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
            Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent7"
            Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
            Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
            Me.digitalBackgroundLayerComponent1.ZOrder = 1000
            '
            'gControl2
            '
            Me.gControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.LinearGauge1})
            Me.gControl2.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(50)
            Me.gControl2.Location = New System.Drawing.Point(14, 66)
            Me.gControl2.Name = "gControl2"
            Me.gControl2.Size = New System.Drawing.Size(573, 380)
            Me.gControl2.TabIndex = 6
            '
            'LinearGauge1
            '
            Me.LinearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.LinearScaleBackgroundLayerComponent1})
            Me.LinearGauge1.Bounds = New System.Drawing.Rectangle(50, 50, 473, 280)
            Me.LinearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.LinearScaleLevelComponent1})
            Me.LinearGauge1.Name = "LinearGauge1"
            Me.LinearGauge1.OptionsToolTip.TooltipTitleFormat = "{0}"
            Me.LinearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.LinearScaleComponent1})
            '
            'LinearScaleBackgroundLayerComponent1
            '
            Me.LinearScaleBackgroundLayerComponent1.LinearScale = Me.LinearScaleComponent1
            Me.LinearScaleBackgroundLayerComponent1.Name = "bg1"
            Me.LinearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 0.85!)
            Me.LinearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style23
            Me.LinearScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'LinearScaleComponent1
            '
            Me.LinearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            Me.LinearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#ADA6C8")
            Me.LinearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(64.0!, 38.0!)
            Me.LinearScaleComponent1.MajorTickCount = 6
            Me.LinearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.LinearScaleComponent1.MajorTickmark.ShapeOffset = -24.0!
            Me.LinearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style23_1
            Me.LinearScaleComponent1.MajorTickmark.TextOffset = -34.0!
            Me.LinearScaleComponent1.MaxValue = 100.0!
            Me.LinearScaleComponent1.MinorTickCount = 4
            Me.LinearScaleComponent1.MinorTickmark.ShapeOffset = -24.0!
            Me.LinearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style23_2
            Me.LinearScaleComponent1.Name = "scale1"
            LinearScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#048778")
            LinearScaleRange1.EndThickness = 5.0!
            LinearScaleRange1.EndValue = 33.0!
            LinearScaleRange1.Name = "Range0"
            LinearScaleRange1.ShapeOffset = -15.0!
            LinearScaleRange1.StartThickness = 5.0!
            LinearScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C8B47C")
            LinearScaleRange2.EndThickness = 5.0!
            LinearScaleRange2.EndValue = 66.0!
            LinearScaleRange2.Name = "Range1"
            LinearScaleRange2.ShapeOffset = -15.0!
            LinearScaleRange2.StartThickness = 5.0!
            LinearScaleRange2.StartValue = 33.0!
            LinearScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#985277")
            LinearScaleRange3.EndThickness = 5.0!
            LinearScaleRange3.EndValue = 100.0!
            LinearScaleRange3.Name = "Range2"
            LinearScaleRange3.ShapeOffset = -15.0!
            LinearScaleRange3.StartThickness = 5.0!
            LinearScaleRange3.StartValue = 66.0!
            Me.LinearScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {LinearScaleRange1, LinearScaleRange2, LinearScaleRange3})
            Me.LinearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(64.0!, 212.0!)
            Me.LinearScaleComponent1.Value = 25.0!
            '
            'LinearScaleLevelComponent1
            '
            Me.LinearScaleLevelComponent1.LinearScale = Me.LinearScaleComponent1
            Me.LinearScaleLevelComponent1.Name = "level1"
            Me.LinearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style23
            Me.LinearScaleLevelComponent1.ZOrder = -50
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabGroup, Me.emptySpaceItem1, Me.layoutControlItem4, Me.layoutControlItem5})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(601, 460)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'tabGroup
            '
            Me.tabGroup.CustomizationFormText = "tabbedControlGroup1"
            Me.tabGroup.Location = New System.Drawing.Point(0, 32)
            Me.tabGroup.Name = "tabbedControlGroup1"
            Me.tabGroup.SelectedTabPage = Me.layoutControlGroup2
            Me.tabGroup.SelectedTabPageIndex = 0
            Me.tabGroup.Size = New System.Drawing.Size(601, 428)
            Me.tabGroup.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.layoutControlGroup5})
            Me.tabGroup.Text = "tabbedControlGroup1"
            '
            'layoutControlGroup2
            '
            Me.layoutControlGroup2.CustomizationFormText = "Circular Gauge"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(577, 384)
            Me.layoutControlGroup2.Text = "Circular Gauge"
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.gControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(577, 384)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlGroup3
            '
            Me.layoutControlGroup3.CustomizationFormText = "Linear Gauge"
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(577, 384)
            Me.layoutControlGroup3.Text = "Linear Gauge"
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.gControl2
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(577, 384)
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            '
            'layoutControlGroup4
            '
            Me.layoutControlGroup4.CustomizationFormText = "Digital Gauge"
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(577, 384)
            Me.layoutControlGroup4.Text = "Digital Gauge"
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.gControl3
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(577, 384)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlGroup5
            '
            Me.layoutControlGroup5.CustomizationFormText = "Multiple Gauges"
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(577, 384)
            Me.layoutControlGroup5.Text = "Multiple Gauges"
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.Control = Me.gControl4
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(577, 384)
            Me.layoutControlItem7.Text = "layoutControlItem7"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextToControlDistance = 0
            Me.layoutControlItem7.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(283, 32)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.btnStyleManager
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(437, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 2, 2, 8)
            Me.layoutControlItem4.Size = New System.Drawing.Size(164, 32)
            Me.layoutControlItem4.Text = "layoutControlItem4"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextToControlDistance = 0
            Me.layoutControlItem4.TextVisible = False
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.btnStyleChooser
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(283, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 8)
            Me.layoutControlItem5.Size = New System.Drawing.Size(154, 32)
            Me.layoutControlItem5.Text = "layoutControlItem5"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.gControl3
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem2"
            Me.layoutControlItem6.Size = New System.Drawing.Size(577, 379)
            Me.layoutControlItem6.Text = "layoutControlItem2"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextToControlDistance = 0
            Me.layoutControlItem6.TextVisible = False
            '
            'StyleManagerFeature
            '
            Me.Controls.Add(Me.xtraScrollableControl1)
            Me.Name = "StyleManagerFeature"
            Me.Size = New System.Drawing.Size(601, 480)
            Me.xtraScrollableControl1.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleLevelComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.digitalGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.digitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CircularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.digitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LinearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
		Private gControl2 As DevExpress.XtraGauges.Win.GaugeControl
		Private gControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private tabGroup As DevExpress.XtraLayout.TabbedControlGroup
		Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private WithEvents btnStyleManager As DevExpress.XtraEditors.SimpleButton
		Private gControl3 As DevExpress.XtraGauges.Win.GaugeControl
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private digitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
		Private digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
        Private WithEvents btnStyleChooser As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private gControl4 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private linearGauge2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
		Private linearScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
		Private linearScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
		Private linearScaleLevelComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
		Private digitalGauge2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
		Private digitalBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents CircularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private WithEvents ArcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private WithEvents ArcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private WithEvents ArcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
        Private WithEvents ArcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private WithEvents ArcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        Friend WithEvents LinearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Private WithEvents LinearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
        Private WithEvents LinearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Private WithEvents LinearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

	End Class
End Namespace
