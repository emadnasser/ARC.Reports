Namespace DevExpress.XtraGauges.Demos
    Partial Class WeatherStation
        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Private Sub InitializeComponent()
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim SplineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView
            Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim SplineSeriesView2 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView
            Dim PointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel
            Dim SplineSeriesView3 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView
            Dim PointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
            Me.comboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
            Me.linearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
            Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
            Me.linearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SplineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SplineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
            Me.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
            Me.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = True
            Me.layoutControl1.Controls.Add(Me.panelControl1)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Controls.Add(Me.chartControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 8)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(652, 479)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.layoutControl2)
            Me.panelControl1.Location = New System.Drawing.Point(1, 1)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
            Me.panelControl1.Size = New System.Drawing.Size(651, 44)
            Me.panelControl1.TabIndex = 12
            '
            'layoutControl2
            '
            Me.layoutControl2.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
            Me.layoutControl2.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
            Me.layoutControl2.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
            Me.layoutControl2.Appearance.DisabledLayoutItem.Options.UseForeColor = True
            Me.layoutControl2.Controls.Add(Me.labelControl1)
            Me.layoutControl2.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl2.Controls.Add(Me.comboBoxEdit2)
            Me.layoutControl2.Controls.Add(Me.simpleButton1)
            Me.layoutControl2.Controls.Add(Me.labelControl2)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(2, 8)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.Root = Me.layoutControlGroup2
            Me.layoutControl2.Size = New System.Drawing.Size(647, 34)
            Me.layoutControl2.TabIndex = 0
            Me.layoutControl2.Text = "layoutControl2"
            Me.layoutControl2.AutoScroll = False
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.labelControl1.Location = New System.Drawing.Point(17, 6)
            Me.labelControl1.MaximumSize = New System.Drawing.Size(0, 20)
            Me.labelControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(82, 20)
            Me.labelControl1.StyleController = Me.layoutControl2
            Me.labelControl1.TabIndex = 8
            Me.labelControl1.Text = "Get Weather at"
            '
            'comboBoxEdit1
            '
            Me.comboBoxEdit1.EditValue = "London(Offline data)"
            Me.comboBoxEdit1.Location = New System.Drawing.Point(110, 6)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.Items.AddRange(New Object() {"Delhi", "London", "London(Offline data)", "Los Angeles", "Moscow", "Oslo", "Rome", "Washington"})
            Me.comboBoxEdit1.Properties.Sorted = True
            Me.comboBoxEdit1.Size = New System.Drawing.Size(146, 20)
            Me.comboBoxEdit1.StyleController = Me.layoutControl2
            Me.comboBoxEdit1.TabIndex = 9
            '
            'comboBoxEdit2
            '
            Me.comboBoxEdit2.EditValue = "Celsius"
            Me.comboBoxEdit2.Location = New System.Drawing.Point(298, 6)
            Me.comboBoxEdit2.Name = "comboBoxEdit2"
            Me.comboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit2.Properties.Items.AddRange(New Object() {"Fahrenheit", "Celsius"})
            Me.comboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit2.Size = New System.Drawing.Size(105, 20)
            Me.comboBoxEdit2.StyleController = Me.layoutControl2
            Me.comboBoxEdit2.TabIndex = 10
            '
            'simpleButton1
            '
            Me.simpleButton1.Location = New System.Drawing.Point(465, 6)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(166, 22)
            Me.simpleButton1.StyleController = Me.layoutControl2
            Me.simpleButton1.TabIndex = 6
            Me.simpleButton1.Text = "Get Weather"
            '
            'labelControl2
            '
            Me.labelControl2.Appearance.Options.UseTextOptions = True
            Me.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.labelControl2.Location = New System.Drawing.Point(267, 6)
            Me.labelControl2.MaximumSize = New System.Drawing.Size(0, 20)
            Me.labelControl2.MinimumSize = New System.Drawing.Size(0, 20)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(20, 20)
            Me.labelControl2.StyleController = Me.layoutControl2
            Me.labelControl2.TabIndex = 11
            Me.labelControl2.Text = "in"
            '
            'layoutControlGroup2
            '
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem7, Me.emptySpaceItem1, Me.layoutControlItem5})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(647, 34)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "layoutControlGroup2"
            Me.layoutControlGroup2.TextVisible = False
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.labelControl1
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.MaxSize = New System.Drawing.Size(104, 34)
            Me.layoutControlItem6.MinSize = New System.Drawing.Size(104, 34)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 5, 5, 5)
            Me.layoutControlItem6.Size = New System.Drawing.Size(104, 34)
            Me.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem6.Text = "layoutControlItem6"
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextToControlDistance = 0
            Me.layoutControlItem6.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.comboBoxEdit1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(104, 0)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(157, 31)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(157, 31)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(157, 34)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.simpleButton1
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(459, 0)
            Me.layoutControlItem3.MaxSize = New System.Drawing.Size(188, 33)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(188, 33)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 16, 5, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(188, 34)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.Control = Me.labelControl2
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem7.Location = New System.Drawing.Point(261, 0)
            Me.layoutControlItem7.MaxSize = New System.Drawing.Size(31, 31)
            Me.layoutControlItem7.MinSize = New System.Drawing.Size(31, 31)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(31, 34)
            Me.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem7.Text = "layoutControlItem7"
            Me.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextToControlDistance = 0
            Me.layoutControlItem7.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(408, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(51, 34)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.comboBoxEdit2
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(292, 0)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(116, 31)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(116, 31)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(116, 34)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.Text = "layoutControlItem5"
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            '
            'gaugeControl1
            '
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(417, 79)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(235, 400)
            Me.gaugeControl1.TabIndex = 2
            '
            'linearGauge1
            '
            Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent1})
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 223, 388)
            Me.linearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent1})
            Me.linearGauge1.Name = ""
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent1})
            '
            'linearScaleBackgroundLayerComponent1
            '
            Me.linearScaleBackgroundLayerComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleBackgroundLayerComponent1.Name = "linearScaleBackgroundLayerComponent1"
            Me.linearScaleBackgroundLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.153!)
            Me.linearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.847!)
            Me.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style9
            Me.linearScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'linearScaleComponent1
            '
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 50.0!)
            Me.linearScaleComponent1.MajorTickCount = 6
            Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}°"
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -8.0!
            Me.linearScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(4.0!, 0.5!)
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_1
            Me.linearScaleComponent1.MaxValue = 100.0!
            Me.linearScaleComponent1.MinorTickCount = 4
            Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -5.5!
            Me.linearScaleComponent1.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(2.5!, 0.2!)
            Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style9_1
            Me.linearScaleComponent1.Name = "linearScaleComponent1"
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 200.0!)
            '
            'linearScaleLevelComponent1
            '
            Me.linearScaleLevelComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleLevelComponent1.Name = "linearScaleLevelComponent1"
            Me.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style2
            Me.linearScaleLevelComponent1.ZOrder = -50
            '
            'chartControl1
            '
            Me.chartControl1.AppearanceName = "Light"
            Me.chartControl1.CacheToMemory = True
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisX.Range.SideMarginsEnabled = True
            XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Range.SideMarginsEnabled = True
            XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            Me.chartControl1.Diagram = XyDiagram1
            Me.chartControl1.Location = New System.Drawing.Point(1, 79)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PaletteName = "Aspect"
            Series1.Name = "Series 2"
            Series1.View = SplineSeriesView1
            Series1.LegendText = "MinTemperature"
            PointSeriesLabel1.LineVisibility = Utils.DefaultBoolean.True
            Series1.Label = PointSeriesLabel1
            Series2.Name = "Series 1"
            Series2.View = SplineSeriesView2
            Series2.LegendText = "MaxTemperature"
            PointSeriesLabel2.LineVisibility = Utils.DefaultBoolean.True
            Series2.Label = PointSeriesLabel2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
            Me.chartControl1.SeriesTemplate.View = SplineSeriesView3
            PointSeriesLabel3.LineVisibility = Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = PointSeriesLabel3
            Me.chartControl1.Size = New System.Drawing.Size(403, 400)
            Me.chartControl1.TabIndex = 1
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem1, Me.layoutControlItem8})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(652, 479)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11.0!)
            Me.layoutControlItem4.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem4.Control = Me.gaugeControl1
            Me.layoutControlItem4.CustomizationFormText = "Current Temperature"
            Me.layoutControlItem4.Location = New System.Drawing.Point(410, 49)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 0, 4, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(242, 430)
            Me.layoutControlItem4.Text = "Current Temperature"
            Me.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(139, 20)
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11.0!)
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem1.Control = Me.chartControl1
            Me.layoutControlItem1.CustomizationFormText = "Min and Max temperature for next seven days"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 49)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 6, 4, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(410, 430)
            Me.layoutControlItem1.Text = "Min and Max temperature for next several days"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(314, 20)
            '
            'layoutControlItem8
            '
            Me.layoutControlItem8.Control = Me.panelControl1
            Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem8.MaxSize = New System.Drawing.Size(0, 49)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(101, 49)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 4)
            Me.layoutControlItem8.Size = New System.Drawing.Size(652, 49)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.Text = "layoutControlItem8"
            Me.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextToControlDistance = 0
            Me.layoutControlItem8.TextVisible = False
            '
            'WeatherStation
            '
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "WeatherStation"
            Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
            Me.Size = New System.Drawing.Size(652, 495)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SplineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SplineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Private linearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
        Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Private linearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private comboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
