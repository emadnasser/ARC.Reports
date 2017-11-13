Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Styles
Imports DevExpress.XtraGauges.Presets.Styles
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win.Gauges.Digital
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraGauges.Demos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class AnimationScale
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim ArcScaleRange7 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange
            Dim ArcScaleRange8 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange
            Dim ArcScaleRange9 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange
            Dim LinearScaleRange7 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange
            Dim LinearScaleRange8 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange
            Dim LinearScaleRange9 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.CircleEase = New System.Windows.Forms.RadioButton
            Me.ExponentialEase = New System.Windows.Forms.RadioButton
            Me.SineEase = New System.Windows.Forms.RadioButton
            Me.CubicEase = New System.Windows.Forms.RadioButton
            Me.QuadraticEase = New System.Windows.Forms.RadioButton
            Me.QuinticEase = New System.Windows.Forms.RadioButton
            Me.PowerEase = New System.Windows.Forms.RadioButton
            Me.EaseFuction = New DevExpress.XtraEditors.ComboBoxEdit
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.CircularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.ArcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.ArcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.ArcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.ArcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
            Me.BounceEase = New System.Windows.Forms.RadioButton
            Me.ElasticEase = New System.Windows.Forms.RadioButton
            Me.BackEase = New System.Windows.Forms.RadioButton
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.LinearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
            Me.LinearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
            Me.LinearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
            Me.LinearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.tabbedControlGroup2 = New DevExpress.XtraLayout.TabbedControlGroup
            Me.Circular = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
            Me.Linear = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
            Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.digitalBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
            Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.EaseFuction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CircularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LinearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabbedControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Circular, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Linear, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.digitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.CircleEase)
            Me.layoutControl1.Controls.Add(Me.ExponentialEase)
            Me.layoutControl1.Controls.Add(Me.SineEase)
            Me.layoutControl1.Controls.Add(Me.CubicEase)
            Me.layoutControl1.Controls.Add(Me.QuadraticEase)
            Me.layoutControl1.Controls.Add(Me.QuinticEase)
            Me.layoutControl1.Controls.Add(Me.PowerEase)
            Me.layoutControl1.Controls.Add(Me.EaseFuction)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Controls.Add(Me.BounceEase)
            Me.layoutControl1.Controls.Add(Me.ElasticEase)
            Me.layoutControl1.Controls.Add(Me.BackEase)
            Me.layoutControl1.Controls.Add(Me.gaugeControl2)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(983, 145, 655, 556)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(664, 446)
            Me.layoutControl1.TabIndex = 17
            Me.layoutControl1.Text = "layoutControl1"
            '
            'CircleEase
            '
            Me.CircleEase.Location = New System.Drawing.Point(500, 362)
            Me.CircleEase.Name = "CircleEase"
            Me.CircleEase.Size = New System.Drawing.Size(162, 25)
            Me.CircleEase.TabIndex = 19
            Me.CircleEase.TabStop = True
            Me.CircleEase.Text = "Circle Ease"
            Me.CircleEase.UseVisualStyleBackColor = True
            '
            'ExponentialEase
            '
            Me.ExponentialEase.Location = New System.Drawing.Point(500, 333)
            Me.ExponentialEase.Name = "ExponentialEase"
            Me.ExponentialEase.Size = New System.Drawing.Size(162, 25)
            Me.ExponentialEase.TabIndex = 18
            Me.ExponentialEase.TabStop = True
            Me.ExponentialEase.Text = "Exponential Ease"
            Me.ExponentialEase.UseVisualStyleBackColor = True
            '
            'SineEase
            '
            Me.SineEase.Location = New System.Drawing.Point(500, 304)
            Me.SineEase.Name = "SineEase"
            Me.SineEase.Size = New System.Drawing.Size(162, 25)
            Me.SineEase.TabIndex = 17
            Me.SineEase.TabStop = True
            Me.SineEase.Text = "Sine Ease"
            Me.SineEase.UseVisualStyleBackColor = True
            '
            'CubicEase
            '
            Me.CubicEase.Location = New System.Drawing.Point(500, 217)
            Me.CubicEase.Name = "CubicEase"
            Me.CubicEase.Size = New System.Drawing.Size(162, 25)
            Me.CubicEase.TabIndex = 16
            Me.CubicEase.TabStop = True
            Me.CubicEase.Text = "Cubic Ease"
            Me.CubicEase.UseVisualStyleBackColor = True
            '
            'QuadraticEase
            '
            Me.QuadraticEase.Location = New System.Drawing.Point(500, 246)
            Me.QuadraticEase.Name = "QuadraticEase"
            Me.QuadraticEase.Size = New System.Drawing.Size(162, 25)
            Me.QuadraticEase.TabIndex = 14
            Me.QuadraticEase.TabStop = True
            Me.QuadraticEase.Text = "Quadratic Ease"
            Me.QuadraticEase.UseVisualStyleBackColor = True
            '
            'QuinticEase
            '
            Me.QuinticEase.Location = New System.Drawing.Point(500, 275)
            Me.QuinticEase.Name = "QuinticEase"
            Me.QuinticEase.Size = New System.Drawing.Size(162, 25)
            Me.QuinticEase.TabIndex = 15
            Me.QuinticEase.TabStop = True
            Me.QuinticEase.Text = "Quintic Ease"
            Me.QuinticEase.UseVisualStyleBackColor = True
            '
            'PowerEase
            '
            Me.PowerEase.Location = New System.Drawing.Point(500, 188)
            Me.PowerEase.Name = "PowerEase"
            Me.PowerEase.Size = New System.Drawing.Size(162, 25)
            Me.PowerEase.TabIndex = 13
            Me.PowerEase.TabStop = True
            Me.PowerEase.Text = "Power Ease"
            Me.PowerEase.UseVisualStyleBackColor = True
            '
            'EaseFuction
            '
            Me.EaseFuction.Location = New System.Drawing.Point(500, 49)
            Me.EaseFuction.Name = "EaseFuction"
            Me.EaseFuction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
            Me.EaseFuction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.EaseFuction.Size = New System.Drawing.Size(162, 20)
            Me.EaseFuction.StyleController = Me.layoutControl1
            Me.EaseFuction.TabIndex = 12
            '
            'gaugeControl1
            '
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.CircularGauge1})
            Me.gaugeControl1.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(25)
            Me.gaugeControl1.Location = New System.Drawing.Point(14, 34)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(452, 398)
            Me.gaugeControl1.TabIndex = 0
            '
            'CircularGauge1
            '
            Me.CircularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent1})
            Me.CircularGauge1.Bounds = New System.Drawing.Rectangle(25, 25, 402, 348)
            Me.CircularGauge1.Name = "CircularGauge1"
            Me.CircularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent1})
            Me.CircularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent1})
            Me.CircularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.ArcScaleSpindleCapComponent1})
            '
            'ArcScaleBackgroundLayerComponent1
            '
            Me.ArcScaleBackgroundLayerComponent1.ArcScale = Me.ArcScaleComponent1
            Me.ArcScaleBackgroundLayerComponent1.Name = "bg"
            Me.ArcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style25
            Me.ArcScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'ArcScaleComponent1
            '
            Me.ArcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 9.0!)
            Me.ArcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.ArcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.ArcScaleComponent1.EndAngle = 60.0!
            Me.ArcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.ArcScaleComponent1.MajorTickmark.ShapeOffset = -6.0!
            Me.ArcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_1
            Me.ArcScaleComponent1.MajorTickmark.TextOffset = -20.0!
            Me.ArcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.ArcScaleComponent1.MaxValue = 100.0!
            Me.ArcScaleComponent1.MinorTickCount = 4
            Me.ArcScaleComponent1.MinorTickmark.ShapeOffset = -2.0!
            Me.ArcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_2
            Me.ArcScaleComponent1.Name = "scale1"
            Me.ArcScaleComponent1.RadiusX = 95.0!
            Me.ArcScaleComponent1.RadiusY = 95.0!
            ArcScaleRange7.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968")
            ArcScaleRange7.EndThickness = 2.0!
            ArcScaleRange7.EndValue = 33.0!
            ArcScaleRange7.Name = "Range0"
            ArcScaleRange7.ShapeOffset = 11.5!
            ArcScaleRange7.StartThickness = 2.0!
            ArcScaleRange8.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFDA80")
            ArcScaleRange8.EndThickness = 2.0!
            ArcScaleRange8.EndValue = 66.0!
            ArcScaleRange8.Name = "Range1"
            ArcScaleRange8.ShapeOffset = 11.5!
            ArcScaleRange8.StartThickness = 2.0!
            ArcScaleRange8.StartValue = 33.0!
            ArcScaleRange9.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E99D9D")
            ArcScaleRange9.EndThickness = 2.0!
            ArcScaleRange9.EndValue = 100.0!
            ArcScaleRange9.Name = "Range2"
            ArcScaleRange9.ShapeOffset = 11.5!
            ArcScaleRange9.StartThickness = 2.0!
            ArcScaleRange9.StartValue = 66.0!
            Me.ArcScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange7, ArcScaleRange8, ArcScaleRange9})
            Me.ArcScaleComponent1.StartAngle = -240.0!
            Me.ArcScaleComponent1.Value = 80.0!
            '
            'ArcScaleNeedleComponent1
            '
            Me.ArcScaleNeedleComponent1.ArcScale = Me.ArcScaleComponent1
            Me.ArcScaleNeedleComponent1.EndOffset = -8.0!
            Me.ArcScaleNeedleComponent1.Name = "needle"
            Me.ArcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style25
            Me.ArcScaleNeedleComponent1.StartOffset = -21.0!
            Me.ArcScaleNeedleComponent1.ZOrder = -50
            '
            'ArcScaleSpindleCapComponent1
            '
            Me.ArcScaleSpindleCapComponent1.ArcScale = Me.ArcScaleComponent1
            Me.ArcScaleSpindleCapComponent1.Name = "circularGauge11_SpindleCap1"
            Me.ArcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style25
            Me.ArcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(15.0!, 15.0!)
            Me.ArcScaleSpindleCapComponent1.ZOrder = -100
            '
            'BounceEase
            '
            Me.BounceEase.Location = New System.Drawing.Point(500, 159)
            Me.BounceEase.Name = "BounceEase"
            Me.BounceEase.Size = New System.Drawing.Size(162, 25)
            Me.BounceEase.TabIndex = 9
            Me.BounceEase.TabStop = True
            Me.BounceEase.Text = "Bounce Ease"
            Me.BounceEase.UseVisualStyleBackColor = True
            '
            'ElasticEase
            '
            Me.ElasticEase.Location = New System.Drawing.Point(500, 130)
            Me.ElasticEase.Name = "ElasticEase"
            Me.ElasticEase.Size = New System.Drawing.Size(162, 25)
            Me.ElasticEase.TabIndex = 11
            Me.ElasticEase.TabStop = True
            Me.ElasticEase.Text = "Elastic Ease"
            Me.ElasticEase.UseVisualStyleBackColor = True
            '
            'BackEase
            '
            Me.BackEase.Checked = True
            Me.BackEase.Location = New System.Drawing.Point(500, 101)
            Me.BackEase.Name = "BackEase"
            Me.BackEase.Size = New System.Drawing.Size(162, 25)
            Me.BackEase.TabIndex = 2
            Me.BackEase.TabStop = True
            Me.BackEase.Text = "Back Ease"
            Me.BackEase.UseVisualStyleBackColor = True
            '
            'gaugeControl2
            '
            Me.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.LinearGauge1})
            Me.gaugeControl2.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(25)
            Me.gaugeControl2.Location = New System.Drawing.Point(14, 34)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.Size = New System.Drawing.Size(452, 398)
            Me.gaugeControl2.TabIndex = 2
            '
            'LinearGauge1
            '
            Me.LinearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.LinearScaleBackgroundLayerComponent1})
            Me.LinearGauge1.Bounds = New System.Drawing.Rectangle(25, 25, 402, 348)
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
            Me.LinearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25
            Me.LinearScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'LinearScaleComponent1
            '
            Me.LinearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            Me.LinearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.LinearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 38.0!)
            Me.LinearScaleComponent1.MajorTickCount = 6
            Me.LinearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.LinearScaleComponent1.MajorTickmark.ShapeOffset = -25.0!
            Me.LinearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1
            Me.LinearScaleComponent1.MajorTickmark.TextOffset = -35.0!
            Me.LinearScaleComponent1.MaxValue = 100.0!
            Me.LinearScaleComponent1.MinorTickCount = 4
            Me.LinearScaleComponent1.MinorTickmark.ShapeOffset = -22.0!
            Me.LinearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2
            Me.LinearScaleComponent1.Name = "scale1"
            LinearScaleRange7.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#7AC463")
            LinearScaleRange7.EndThickness = 3.0!
            LinearScaleRange7.EndValue = 33.0!
            LinearScaleRange7.Name = "Range0"
            LinearScaleRange7.ShapeOffset = -12.0!
            LinearScaleRange7.StartThickness = 3.0!
            LinearScaleRange8.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F1D183")
            LinearScaleRange8.EndThickness = 3.0!
            LinearScaleRange8.EndValue = 66.0!
            LinearScaleRange8.Name = "Range1"
            LinearScaleRange8.ShapeOffset = -12.0!
            LinearScaleRange8.StartThickness = 3.0!
            LinearScaleRange8.StartValue = 33.0!
            LinearScaleRange9.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F1877E")
            LinearScaleRange9.EndThickness = 3.0!
            LinearScaleRange9.EndValue = 100.0!
            LinearScaleRange9.Name = "Range2"
            LinearScaleRange9.ShapeOffset = -12.0!
            LinearScaleRange9.StartThickness = 3.0!
            LinearScaleRange9.StartValue = 66.0!
            Me.LinearScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {LinearScaleRange7, LinearScaleRange8, LinearScaleRange9})
            Me.LinearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 212.0!)
            Me.LinearScaleComponent1.Value = 50.0!
            '
            'LinearScaleLevelComponent1
            '
            Me.LinearScaleLevelComponent1.LinearScale = Me.LinearScaleComponent1
            Me.LinearScaleLevelComponent1.Name = "level1"
            Me.LinearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25
            Me.LinearScaleLevelComponent1.ZOrder = -50
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabbedControlGroup2, Me.layoutControlItem1, Me.layoutControlItem10, Me.layoutControlItem8, Me.emptySpaceItem1, Me.emptySpaceItem3, Me.emptySpaceItem4, Me.splitterItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem11})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(664, 446)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            '
            'tabbedControlGroup2
            '
            Me.tabbedControlGroup2.CustomizationFormText = "tabbedControlGroup2"
            Me.tabbedControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.tabbedControlGroup2.Name = "tabbedControlGroup2"
            Me.tabbedControlGroup2.SelectedTabPage = Me.Circular
            Me.tabbedControlGroup2.SelectedTabPageIndex = 0
            Me.tabbedControlGroup2.Size = New System.Drawing.Size(480, 446)
            Me.tabbedControlGroup2.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Circular, Me.Linear})
            Me.tabbedControlGroup2.Text = "tabbedControlGroup2"
            '
            'Circular
            '
            Me.Circular.CustomizationFormText = "layoutControlGroup2"
            Me.Circular.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem12})
            Me.Circular.Location = New System.Drawing.Point(0, 0)
            Me.Circular.Name = "Circular"
            Me.Circular.Size = New System.Drawing.Size(456, 402)
            Me.Circular.Tag = "Full"
            Me.Circular.Text = "Circular"
            '
            'layoutControlItem12
            '
            Me.layoutControlItem12.Control = Me.gaugeControl1
            Me.layoutControlItem12.CustomizationFormText = "layoutControlItem12"
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(456, 402)
            Me.layoutControlItem12.Text = "layoutControlItem12"
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem12.TextToControlDistance = 0
            Me.layoutControlItem12.TextVisible = False
            '
            'Linear
            '
            Me.Linear.CustomizationFormText = "layoutControlGroup3"
            Me.Linear.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem13})
            Me.Linear.Location = New System.Drawing.Point(0, 0)
            Me.Linear.Name = "Linear"
            Me.Linear.Size = New System.Drawing.Size(456, 402)
            Me.Linear.Tag = "Vertical"
            Me.Linear.Text = "Linear"
            '
            'layoutControlItem13
            '
            Me.layoutControlItem13.Control = Me.gaugeControl2
            Me.layoutControlItem13.CustomizationFormText = "layoutControlItem13"
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(456, 402)
            Me.layoutControlItem13.Text = "layoutControlItem13"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem13.TextToControlDistance = 0
            Me.layoutControlItem13.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.BackEase
            Me.layoutControlItem1.CustomizationFormText = "Ease Function"
            Me.layoutControlItem1.Location = New System.Drawing.Point(498, 71)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 14, 2)
            Me.layoutControlItem1.Size = New System.Drawing.Size(166, 57)
            Me.layoutControlItem1.Text = "Ease Function"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(67, 13)
            '
            'layoutControlItem10
            '
            Me.layoutControlItem10.Control = Me.ElasticEase
            Me.layoutControlItem10.CustomizationFormText = "layoutControlItem10"
            Me.layoutControlItem10.Location = New System.Drawing.Point(498, 128)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(166, 29)
            Me.layoutControlItem10.Text = "layoutControlItem10"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextToControlDistance = 0
            Me.layoutControlItem10.TextVisible = False
            '
            'layoutControlItem8
            '
            Me.layoutControlItem8.Control = Me.BounceEase
            Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
            Me.layoutControlItem8.Location = New System.Drawing.Point(498, 157)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(166, 29)
            Me.layoutControlItem8.Text = "layoutControlItem8"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextToControlDistance = 0
            Me.layoutControlItem8.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(498, 389)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(166, 57)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'emptySpaceItem3
            '
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(498, 0)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(166, 31)
            Me.emptySpaceItem3.Text = "emptySpaceItem3"
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            '
            'emptySpaceItem4
            '
            Me.emptySpaceItem4.AllowHotTrack = False
            Me.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4"
            Me.emptySpaceItem4.Location = New System.Drawing.Point(485, 0)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(13, 446)
            Me.emptySpaceItem4.Text = "emptySpaceItem4"
            Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            '
            'splitterItem1
            '
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(480, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 446)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.EaseFuction
            Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
            Me.LayoutControlItem2.Location = New System.Drawing.Point(498, 31)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(166, 40)
            Me.LayoutControlItem2.Text = "Ease Mode"
            Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(67, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.PowerEase
            Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
            Me.LayoutControlItem3.Location = New System.Drawing.Point(498, 186)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(166, 29)
            Me.LayoutControlItem3.Text = "LayoutControlItem3"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem3.TextToControlDistance = 0
            Me.LayoutControlItem3.TextVisible = False
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.CubicEase
            Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
            Me.LayoutControlItem4.Location = New System.Drawing.Point(498, 215)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(166, 29)
            Me.LayoutControlItem4.Text = "LayoutControlItem4"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem4.TextToControlDistance = 0
            Me.LayoutControlItem4.TextVisible = False
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.QuadraticEase
            Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
            Me.LayoutControlItem5.Location = New System.Drawing.Point(498, 244)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(166, 29)
            Me.LayoutControlItem5.Text = "LayoutControlItem5"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem5.TextToControlDistance = 0
            Me.LayoutControlItem5.TextVisible = False
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.QuinticEase
            Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
            Me.LayoutControlItem6.Location = New System.Drawing.Point(498, 273)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(166, 29)
            Me.LayoutControlItem6.Text = "LayoutControlItem6"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem6.TextToControlDistance = 0
            Me.LayoutControlItem6.TextVisible = False
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.SineEase
            Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
            Me.LayoutControlItem7.Location = New System.Drawing.Point(498, 302)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(166, 29)
            Me.LayoutControlItem7.Text = "LayoutControlItem7"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem7.TextToControlDistance = 0
            Me.LayoutControlItem7.TextVisible = False
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.ExponentialEase
            Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
            Me.LayoutControlItem9.Location = New System.Drawing.Point(498, 331)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(166, 29)
            Me.LayoutControlItem9.Text = "LayoutControlItem9"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem9.TextToControlDistance = 0
            Me.LayoutControlItem9.TextVisible = False
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.CircleEase
            Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
            Me.LayoutControlItem11.Location = New System.Drawing.Point(498, 360)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(166, 29)
            Me.LayoutControlItem11.Text = "LayoutControlItem11"
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem11.TextToControlDistance = 0
            Me.LayoutControlItem11.TextVisible = False
            '
            'emptySpaceItem2
            '
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(482, 0)
            Me.emptySpaceItem2.Name = "emptySpaceItem1"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(182, 127)
            Me.emptySpaceItem2.Text = "emptySpaceItem1"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'digitalBackgroundLayerComponent2
            '
            Me.digitalBackgroundLayerComponent2.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
            Me.digitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent13"
            Me.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style24
            Me.digitalBackgroundLayerComponent2.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
            Me.digitalBackgroundLayerComponent2.ZOrder = 1000
            '
            'digitalBackgroundLayerComponent1
            '
            Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
            Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent13"
            Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style24
            Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
            Me.digitalBackgroundLayerComponent1.ZOrder = 1000
            '
            'AnimationScale
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "AnimationScale"
            Me.Size = New System.Drawing.Size(664, 446)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.EaseFuction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CircularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LinearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabbedControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Circular, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Linear, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.digitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private WithEvents EaseFuction As DevExpress.XtraEditors.ComboBoxEdit
        Private WithEvents gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
        Private WithEvents BounceEase As System.Windows.Forms.RadioButton
        Private WithEvents ElasticEase As System.Windows.Forms.RadioButton
        Private WithEvents BackEase As System.Windows.Forms.RadioButton
        Private WithEvents gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
        Private WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents tabbedControlGroup2 As DevExpress.XtraLayout.TabbedControlGroup
        Private WithEvents Circular As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents Linear As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents splitterItem1 As DevExpress.XtraLayout.SplitterItem
        Private WithEvents emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents digitalBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
        Private WithEvents digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents CubicEase As System.Windows.Forms.RadioButton
        Private WithEvents QuadraticEase As System.Windows.Forms.RadioButton
        Private WithEvents QuinticEase As System.Windows.Forms.RadioButton
        Private WithEvents PowerEase As System.Windows.Forms.RadioButton
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents CircleEase As System.Windows.Forms.RadioButton
        Private WithEvents ExponentialEase As System.Windows.Forms.RadioButton
        Private WithEvents SineEase As System.Windows.Forms.RadioButton
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents CircularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private WithEvents ArcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private WithEvents ArcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private WithEvents ArcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private WithEvents ArcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        Friend WithEvents LinearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Private WithEvents LinearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
        Private WithEvents LinearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Private WithEvents LinearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

    End Class
End Namespace
