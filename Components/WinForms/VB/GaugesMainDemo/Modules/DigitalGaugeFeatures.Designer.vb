Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGauges.Demos
	Partial Public Class DigitalGaugeFeatures
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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl
            Me.useCustomCharacterMap = New DevExpress.XtraEditors.CheckEdit
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup
            Me.gaugeMode = New DevExpress.XtraEditors.ComboBoxEdit
            Me.gaugeText = New DevExpress.XtraEditors.TextEdit
            Me.gaugeTime = New DevExpress.XtraEditors.TextEdit
            Me.gaugeNumber = New DevExpress.XtraEditors.TextEdit
            Me.letterSpacing = New DevExpress.XtraEditors.TrackBarControl
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.dGauge = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
            Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType(Me.useCustomCharacterMap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gaugeMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gaugeText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gaugeTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gaugeNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.letterSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.letterSpacing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dGauge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.panelControl1)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 8)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(601, 464)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.layoutControl2)
            Me.panelControl1.Location = New System.Drawing.Point(0, 322)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(601, 134)
            Me.panelControl1.TabIndex = 10
            '
            'layoutControl2
            '
            Me.layoutControl2.Controls.Add(Me.useCustomCharacterMap)
            Me.layoutControl2.Controls.Add(Me.radioGroup1)
            Me.layoutControl2.Controls.Add(Me.gaugeMode)
            Me.layoutControl2.Controls.Add(Me.gaugeText)
            Me.layoutControl2.Controls.Add(Me.gaugeTime)
            Me.layoutControl2.Controls.Add(Me.gaugeNumber)
            Me.layoutControl2.Controls.Add(Me.letterSpacing)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6})
            Me.layoutControl2.Location = New System.Drawing.Point(2, 2)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.Root = Me.layoutControlGroup3
            Me.layoutControl2.Size = New System.Drawing.Size(597, 130)
            Me.layoutControl2.TabIndex = 0
            '
            'useCustomCharacterMap
            '
            Me.useCustomCharacterMap.Location = New System.Drawing.Point(309, 12)
            Me.useCustomCharacterMap.Name = "useCustomCharacterMap"
            Me.useCustomCharacterMap.Properties.Caption = "Use custom character map 8x14"
            Me.useCustomCharacterMap.Size = New System.Drawing.Size(272, 21)
            Me.useCustomCharacterMap.StyleController = Me.layoutControl2
            Me.useCustomCharacterMap.TabIndex = 10
            '
            'radioGroup1
            '
            Me.radioGroup1.Location = New System.Drawing.Point(114, 41)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroup1.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroup1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Text"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Time"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Number")})
            Me.radioGroup1.Size = New System.Drawing.Size(63, 89)
            Me.radioGroup1.StyleController = Me.layoutControl2
            Me.radioGroup1.TabIndex = 4
            '
            'gaugeMode
            '
            Me.gaugeMode.EditValue = "Matrix8x14"
            Me.gaugeMode.Location = New System.Drawing.Point(109, 12)
            Me.gaugeMode.Name = "gaugeMode"
            Me.gaugeMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.gaugeMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.gaugeMode.Size = New System.Drawing.Size(190, 22)
            Me.gaugeMode.StyleController = Me.layoutControl2
            Me.gaugeMode.TabIndex = 9
            '
            'gaugeText
            '
            Me.gaugeText.EditValue = "Gauges"
            Me.gaugeText.Location = New System.Drawing.Point(182, 44)
            Me.gaugeText.Name = "gaugeText"
            Me.gaugeText.Properties.Mask.EditMask = ".{0,6}"
            Me.gaugeText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            Me.gaugeText.Size = New System.Drawing.Size(117, 22)
            Me.gaugeText.StyleController = Me.layoutControl2
            Me.gaugeText.TabIndex = 5
            '
            'gaugeTime
            '
            Me.gaugeTime.EditValue = "17:59"
            Me.gaugeTime.Location = New System.Drawing.Point(182, 72)
            Me.gaugeTime.Name = "gaugeTime"
            Me.gaugeTime.Properties.DisplayFormat.FormatString = "HH:mm"
            Me.gaugeTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.gaugeTime.Properties.Mask.BeepOnError = True
            Me.gaugeTime.Properties.Mask.EditMask = "HH:mm"
            Me.gaugeTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
            Me.gaugeTime.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.gaugeTime.Size = New System.Drawing.Size(117, 22)
            Me.gaugeTime.StyleController = Me.layoutControl2
            Me.gaugeTime.TabIndex = 7
            '
            'gaugeNumber
            '
            Me.gaugeNumber.EditValue = New Decimal(New Integer() {12345, 0, 0, 131072})
            Me.gaugeNumber.Location = New System.Drawing.Point(182, 100)
            Me.gaugeNumber.Name = "gaugeNumber"
            Me.gaugeNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.gaugeNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.gaugeNumber.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.gaugeNumber.Size = New System.Drawing.Size(117, 22)
            Me.gaugeNumber.StyleController = Me.layoutControl2
            Me.gaugeNumber.TabIndex = 6
            '
            'letterSpacing
            '
            Me.letterSpacing.EditValue = Nothing
            Me.letterSpacing.Location = New System.Drawing.Point(87, 127)
            Me.letterSpacing.MaximumSize = New System.Drawing.Size(0, 35)
            Me.letterSpacing.MinimumSize = New System.Drawing.Size(0, 35)
            Me.letterSpacing.Name = "letterSpacing"
            Me.letterSpacing.Size = New System.Drawing.Size(354, 35)
            Me.letterSpacing.StyleController = Me.layoutControl2
            Me.letterSpacing.TabIndex = 8
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 121)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(446, 46)
            Me.layoutControlItem6.Text = "Letter Spacing:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(76, 20)
            Me.layoutControlItem6.TextToControlDistance = 5
            '
            'layoutControlGroup3
            '
            Me.layoutControlGroup3.AllowDrawBackground = False
            Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.emptySpaceItem1, Me.layoutControlItem7, Me.layoutControlItem5, Me.layoutControlItem3, Me.layoutControlItem4, Me.simpleLabelItem1, Me.emptySpaceItem2, Me.layoutControlItem9})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "Root"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(597, 130)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Root"
            Me.layoutControlGroup3.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.radioGroup1
            Me.layoutControlItem2.CustomizationFormText = "Data to display:"
            Me.layoutControlItem2.Location = New System.Drawing.Point(114, 41)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(63, 89)
            Me.layoutControlItem2.Text = "Data to display:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(304, 40)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(293, 90)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.Control = Me.gaugeMode
            Me.layoutControlItem7.CustomizationFormText = "Display Mode:"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 5, 12, 7)
            Me.layoutControlItem7.Size = New System.Drawing.Size(304, 41)
            Me.layoutControlItem7.Text = "Display Mode:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(89, 16)
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.gaugeTime
            Me.layoutControlItem5.CustomizationFormText = "Time:"
            Me.layoutControlItem5.Location = New System.Drawing.Point(177, 69)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 3)
            Me.layoutControlItem5.Size = New System.Drawing.Size(127, 28)
            Me.layoutControlItem5.Text = "Time:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.gaugeText
            Me.layoutControlItem3.CustomizationFormText = "Text:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(177, 41)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 3)
            Me.layoutControlItem3.Size = New System.Drawing.Size(127, 28)
            Me.layoutControlItem3.Text = "Text:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.gaugeNumber
            Me.layoutControlItem4.CustomizationFormText = "Number:"
            Me.layoutControlItem4.Location = New System.Drawing.Point(177, 97)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 8)
            Me.layoutControlItem4.Size = New System.Drawing.Size(127, 33)
            Me.layoutControlItem4.Text = "Number:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextToControlDistance = 0
            Me.layoutControlItem4.TextVisible = False
            '
            'simpleLabelItem1
            '
            Me.simpleLabelItem1.CustomizationFormText = "Data to display:"
            Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 41)
            Me.simpleLabelItem1.Name = "simpleLabelItem1"
            Me.simpleLabelItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 5, 5, 5)
            Me.simpleLabelItem1.Size = New System.Drawing.Size(114, 26)
            Me.simpleLabelItem1.Text = "Data to display:"
            Me.simpleLabelItem1.TextSize = New System.Drawing.Size(89, 16)
            '
            'emptySpaceItem2
            '
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 67)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(114, 63)
            Me.emptySpaceItem2.Text = "emptySpaceItem2"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem9
            '
            Me.layoutControlItem9.Control = Me.useCustomCharacterMap
            Me.layoutControlItem9.CustomizationFormText = "layoutControlItem9"
            Me.layoutControlItem9.Location = New System.Drawing.Point(304, 0)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 16, 12, 7)
            Me.layoutControlItem9.Size = New System.Drawing.Size(293, 40)
            Me.layoutControlItem9.Text = "layoutControlItem9"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextToControlDistance = 0
            Me.layoutControlItem9.TextVisible = False
            '
            'gaugeControl1
            '
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.dGauge})
            Me.gaugeControl1.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(25)
            Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(601, 314)
            Me.gaugeControl1.TabIndex = 0
            '
            'dGauge
            '
            Me.dGauge.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FD4F2FF")
            Me.dGauge.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D4F2FF")
            Me.dGauge.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent1})
            Me.dGauge.Bounds = New System.Drawing.Rectangle(25, 25, 551, 264)
            Me.dGauge.DigitCount = 6
            Me.dGauge.Name = "dGauge"
            Me.dGauge.Text = "0`0,000"
            '
            'digitalBackgroundLayerComponent1
            '
            Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(307.775!, 99.9625!)
            Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
            Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style2
            Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
            Me.digitalBackgroundLayerComponent1.ZOrder = 1000
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem8})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(601, 464)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 8)
            Me.layoutControlItem1.Size = New System.Drawing.Size(601, 322)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem8
            '
            Me.layoutControlItem8.Control = Me.panelControl1
            Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 322)
            Me.layoutControlItem8.MaxSize = New System.Drawing.Size(0, 142)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(101, 142)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 8)
            Me.layoutControlItem8.Size = New System.Drawing.Size(601, 142)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.Text = "layoutControlItem8"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextToControlDistance = 0
            Me.layoutControlItem8.TextVisible = False
            '
            'DigitalGaugeFeatures
            '
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "DigitalGaugeFeatures"
            Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
            Me.Size = New System.Drawing.Size(601, 480)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType(Me.useCustomCharacterMap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gaugeMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gaugeText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gaugeTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gaugeNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.letterSpacing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.letterSpacing, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dGauge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private dGauge As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
		Private digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents layoutControl2 As DevExpress.XtraLayout.LayoutControl
        Private WithEvents useCustomCharacterMap As DevExpress.XtraEditors.CheckEdit
        Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
        Private WithEvents gaugeMode As DevExpress.XtraEditors.ComboBoxEdit
        Private WithEvents gaugeText As DevExpress.XtraEditors.TextEdit
        Private WithEvents gaugeTime As DevExpress.XtraEditors.TextEdit
        Private WithEvents gaugeNumber As DevExpress.XtraEditors.TextEdit
        Private WithEvents letterSpacing As DevExpress.XtraEditors.TrackBarControl
        Private WithEvents layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
        Private WithEvents emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

	End Class
End Namespace
