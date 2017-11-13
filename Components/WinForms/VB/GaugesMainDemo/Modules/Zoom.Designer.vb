Namespace DevExpress.XtraGauges.Demos
    Partial Class ZoomFeature
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
            Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.zoomTrack = New DevExpress.XtraEditors.ZoomTrackBarControl
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtraScrollableControl1.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.zoomTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.zoomTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraScrollableControl1
            '
            Me.xtraScrollableControl1.Controls.Add(Me.layoutControl1)
            Me.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
            Me.xtraScrollableControl1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 12)
            Me.xtraScrollableControl1.Size = New System.Drawing.Size(601, 479)
            Me.xtraScrollableControl1.TabIndex = 0
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.zoomTrack)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 8)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(601, 459)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            '
            'zoomTrack
            '
            Me.zoomTrack.EditValue = 3
            Me.zoomTrack.Location = New System.Drawing.Point(350, 436)
            Me.zoomTrack.MaximumSize = New System.Drawing.Size(250, 0)
            Me.zoomTrack.MinimumSize = New System.Drawing.Size(250, 0)
            Me.zoomTrack.Name = "zoomTrack"
            Me.zoomTrack.Properties.Maximum = 18
            Me.zoomTrack.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.zoomTrack.Size = New System.Drawing.Size(250, 23)
            Me.zoomTrack.StyleController = Me.layoutControl1
            Me.zoomTrack.TabIndex = 1
            Me.zoomTrack.Value = 3
            '
            'gaugeControl1
            '
            Me.gaugeControl1.AutoLayout = False
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(1, 1)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(599, 427)
            Me.gaugeControl1.TabIndex = 0
            '
            'circularGauge1
            '
            Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1, Me.arcScaleBackgroundLayerComponent2})
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 586, 412)
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1, Me.arcScaleComponent2})
            '
            'arcScaleBackgroundLayerComponent1
            '
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1"
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style5
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'arcScaleComponent1
            '
            Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightGrey")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent1.EndAngle = 60.0!
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -21.5!
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_1
            Me.arcScaleComponent1.MajorTickmark.TextOffset = -35.0!
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 100.0!
            Me.arcScaleComponent1.MinorTickCount = 4
            Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -10.0!
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent1.Name = "arcScaleComponent1"
            Me.arcScaleComponent1.RadiusX = 122.0!
            Me.arcScaleComponent1.RadiusY = 122.0!
            Me.arcScaleComponent1.StartAngle = -240.0!
            '
            'arcScaleBackgroundLayerComponent2
            '
            Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent2.Name = "arcScaleBackgroundLayerComponent2"
            Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style5_1
            Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(216.0!, 216.0!)
            Me.arcScaleBackgroundLayerComponent2.ZOrder = 999
            '
            'arcScaleNeedleComponent1
            '
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style5
            Me.arcScaleNeedleComponent1.StartOffset = -23.5!
            Me.arcScaleNeedleComponent1.ZOrder = -50
            '
            'arcScaleComponent2
            '
            Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent2.EndAngle = -30.0!
            Me.arcScaleComponent2.MajorTickCount = 8
            Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -4.0!
            Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_4
            Me.arcScaleComponent2.MajorTickmark.TextOffset = -15.0!
            Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent2.MaxValue = 700.0!
            Me.arcScaleComponent2.MinorTickCount = 4
            Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent2.Name = "arcScaleComponent2"
            Me.arcScaleComponent2.RadiusX = 65.0!
            Me.arcScaleComponent2.RadiusY = 65.0!
            Me.arcScaleComponent2.StartAngle = -240.0!
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.emptySpaceItem1, Me.layoutControlItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(601, 459)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutControlItem1.Size = New System.Drawing.Size(601, 429)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 429)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(349, 30)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.zoomTrack
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(349, 429)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 7, 5)
            Me.layoutControlItem2.Size = New System.Drawing.Size(252, 30)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'ZoomFeature
            '
            Me.Controls.Add(Me.xtraScrollableControl1)
            Me.Name = "ZoomFeature"
            Me.Size = New System.Drawing.Size(601, 479)
            Me.xtraScrollableControl1.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.zoomTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.zoomTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private WithEvents zoomTrack As DevExpress.XtraEditors.ZoomTrackBarControl
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    End Class
End Namespace
