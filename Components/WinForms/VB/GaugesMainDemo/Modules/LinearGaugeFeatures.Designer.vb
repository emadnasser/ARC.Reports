Namespace DevExpress.XtraGauges.Demos
    Partial Class LinearGaugeFeatures
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
            Dim ScaleIndicatorState1 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState2 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState3 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState4 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState5 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState6 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState7 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState8 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleLabel1 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.rangeTrackLinear = New DevExpress.XtraEditors.RangeTrackBarControl
            Me.lblTickOffset = New DevExpress.XtraEditors.TrackBarControl
            Me.tickOffset = New DevExpress.XtraEditors.TrackBarControl
            Me.labelsOrientation = New DevExpress.XtraEditors.ComboBoxEdit
            Me.textExtentTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.labelsCountTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.tickmarksCountTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.valueTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
            Me.linearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
            Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
            Me.linearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl4 = New DevExpress.XtraLayout.LayoutControl
            Me.markerShape = New DevExpress.XtraEditors.ComboBoxEdit
            Me.markerOffset = New DevExpress.XtraEditors.TrackBarControl
            Me.gaugeControl4 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.linearGauge4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
            Me.linearScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
            Me.linearScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
            Me.linearScaleMarkerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent
            Me.linearScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent
            Me.rbValue = New DevExpress.XtraEditors.TrackBarControl
            Me.rbStartValue = New DevExpress.XtraEditors.TrackBarControl
            Me.rbEndExtent = New DevExpress.XtraEditors.TrackBarControl
            Me.rbStartExtent = New DevExpress.XtraEditors.TrackBarControl
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl5 = New DevExpress.XtraLayout.LayoutControl
            Me.stateValTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.gaugeControl5 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.linearGauge5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
            Me.linearScaleBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
            Me.linearScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
            Me.linearScaleStateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
            Me.linearScaleStateIndicatorComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
            Me.linearScaleLevelComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl6 = New DevExpress.XtraLayout.LayoutControl
            Me.gaugeControl6 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.linearGauge6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
            Me.linearScaleBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
            Me.linearScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
            Me.linearScaleLevelComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
            Me.lblOrientation = New DevExpress.XtraEditors.ComboBoxEdit
            Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl
            Me.vertLblPos = New DevExpress.XtraEditors.TrackBarControl
            Me.horzLblPos = New DevExpress.XtraEditors.TrackBarControl
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
            Me.layoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem
            Me.linearScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.rangeTrackLinear, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rangeTrackLinear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblTickOffset, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblTickOffset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tickOffset, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tickOffset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.labelsOrientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textExtentTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textExtentTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.labelsCountTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.labelsCountTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tickmarksCountTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tickmarksCountTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.valueTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.valueTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage4.SuspendLayout()
            CType(Me.layoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl4.SuspendLayout()
            CType(Me.markerShape.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.markerOffset, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.markerOffset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearGauge4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbValue, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbStartValue, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbStartValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbEndExtent, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbEndExtent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbStartExtent, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rbStartExtent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage5.SuspendLayout()
            CType(Me.layoutControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl5.SuspendLayout()
            CType(Me.stateValTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.stateValTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearGauge5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleLevelComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage6.SuspendLayout()
            CType(Me.layoutControl6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl6.SuspendLayout()
            CType(Me.linearGauge6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleLevelComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblOrientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vertLblPos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vertLblPos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.horzLblPos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.horzLblPos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.Padding = New System.Windows.Forms.Padding(8)
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(699, 453)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage4, Me.xtraTabPage5, Me.xtraTabPage6})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.layoutControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Padding = New System.Windows.Forms.Padding(8)
            Me.xtraTabPage1.Size = New System.Drawing.Size(693, 425)
            Me.xtraTabPage1.Text = "Scale Features"
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.rangeTrackLinear)
            Me.layoutControl1.Controls.Add(Me.lblTickOffset)
            Me.layoutControl1.Controls.Add(Me.tickOffset)
            Me.layoutControl1.Controls.Add(Me.labelsOrientation)
            Me.layoutControl1.Controls.Add(Me.textExtentTrack)
            Me.layoutControl1.Controls.Add(Me.labelsCountTrack)
            Me.layoutControl1.Controls.Add(Me.tickmarksCountTrack)
            Me.layoutControl1.Controls.Add(Me.valueTrack)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutControl1.Location = New System.Drawing.Point(8, 8)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(677, 409)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'rangeTrackLinear
            '
            Me.rangeTrackLinear.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 0)
            Me.rangeTrackLinear.Location = New System.Drawing.Point(78, 366)
            Me.rangeTrackLinear.MaximumSize = New System.Drawing.Size(0, 35)
            Me.rangeTrackLinear.MinimumSize = New System.Drawing.Size(0, 35)
            Me.rangeTrackLinear.Name = "rangeTrackLinear"
            Me.rangeTrackLinear.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.rangeTrackLinear.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rangeTrackLinear.Properties.Maximum = 20
            Me.rangeTrackLinear.Size = New System.Drawing.Size(293, 35)
            Me.rangeTrackLinear.StyleController = Me.layoutControl1
            Me.rangeTrackLinear.TabIndex = 15
            '
            'lblTickOffset
            '
            Me.lblTickOffset.EditValue = Nothing
            Me.lblTickOffset.Location = New System.Drawing.Point(512, 196)
            Me.lblTickOffset.MaximumSize = New System.Drawing.Size(0, 35)
            Me.lblTickOffset.MinimumSize = New System.Drawing.Size(0, 35)
            Me.lblTickOffset.Name = "lblTickOffset"
            Me.lblTickOffset.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.lblTickOffset.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lblTickOffset.Properties.Maximum = 25
            Me.lblTickOffset.Properties.Minimum = -25
            Me.lblTickOffset.Properties.TickFrequency = 5
            Me.lblTickOffset.Size = New System.Drawing.Size(120, 35)
            Me.lblTickOffset.StyleController = Me.layoutControl1
            Me.lblTickOffset.TabIndex = 14
            Me.lblTickOffset.Value = -25
            '
            'tickOffset
            '
            Me.tickOffset.EditValue = Nothing
            Me.tickOffset.Location = New System.Drawing.Point(512, 145)
            Me.tickOffset.MaximumSize = New System.Drawing.Size(0, 35)
            Me.tickOffset.MinimumSize = New System.Drawing.Size(0, 35)
            Me.tickOffset.Name = "tickOffset"
            Me.tickOffset.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.tickOffset.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.tickOffset.Properties.Maximum = 25
            Me.tickOffset.Properties.Minimum = -25
            Me.tickOffset.Properties.TickFrequency = 5
            Me.tickOffset.Size = New System.Drawing.Size(120, 35)
            Me.tickOffset.StyleController = Me.layoutControl1
            Me.tickOffset.TabIndex = 13
            Me.tickOffset.Value = -25
            '
            'labelsOrientation
            '
            Me.labelsOrientation.Location = New System.Drawing.Point(518, 314)
            Me.labelsOrientation.Name = "labelsOrientation"
            Me.labelsOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.labelsOrientation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.labelsOrientation.Size = New System.Drawing.Size(114, 20)
            Me.labelsOrientation.StyleController = Me.layoutControl1
            Me.labelsOrientation.TabIndex = 12
            '
            'textExtentTrack
            '
            Me.textExtentTrack.EditValue = Nothing
            Me.textExtentTrack.Location = New System.Drawing.Point(518, 340)
            Me.textExtentTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.textExtentTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.textExtentTrack.Name = "textExtentTrack"
            Me.textExtentTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.textExtentTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.textExtentTrack.Properties.Maximum = 30
            Me.textExtentTrack.Properties.Minimum = -30
            Me.textExtentTrack.Properties.TickFrequency = 5
            Me.textExtentTrack.Size = New System.Drawing.Size(114, 35)
            Me.textExtentTrack.StyleController = Me.layoutControl1
            Me.textExtentTrack.TabIndex = 9
            Me.textExtentTrack.Value = -30
            '
            'labelsCountTrack
            '
            Me.labelsCountTrack.EditValue = 6
            Me.labelsCountTrack.Location = New System.Drawing.Point(512, 43)
            Me.labelsCountTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.labelsCountTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.labelsCountTrack.Name = "labelsCountTrack"
            Me.labelsCountTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.labelsCountTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelsCountTrack.Properties.Maximum = 16
            Me.labelsCountTrack.Properties.Minimum = 6
            Me.labelsCountTrack.Size = New System.Drawing.Size(120, 35)
            Me.labelsCountTrack.StyleController = Me.layoutControl1
            Me.labelsCountTrack.TabIndex = 8
            Me.labelsCountTrack.Value = 6
            '
            'tickmarksCountTrack
            '
            Me.tickmarksCountTrack.EditValue = 6
            Me.tickmarksCountTrack.Location = New System.Drawing.Point(512, 94)
            Me.tickmarksCountTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.tickmarksCountTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.tickmarksCountTrack.Name = "tickmarksCountTrack"
            Me.tickmarksCountTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.tickmarksCountTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.tickmarksCountTrack.Properties.Minimum = 1
            Me.tickmarksCountTrack.Size = New System.Drawing.Size(120, 35)
            Me.tickmarksCountTrack.StyleController = Me.layoutControl1
            Me.tickmarksCountTrack.TabIndex = 7
            Me.tickmarksCountTrack.Value = 6
            '
            'valueTrack
            '
            Me.valueTrack.EditValue = Nothing
            Me.valueTrack.Location = New System.Drawing.Point(35, 325)
            Me.valueTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.valueTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.valueTrack.Name = "valueTrack"
            Me.valueTrack.Properties.AutoSize = False
            Me.valueTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.valueTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.valueTrack.Properties.Maximum = 50
            Me.valueTrack.Properties.TickFrequency = 2
            Me.valueTrack.Properties.TickStyle = System.Windows.Forms.TickStyle.Both
            Me.valueTrack.Size = New System.Drawing.Size(336, 35)
            Me.valueTrack.StyleController = Me.layoutControl1
            Me.valueTrack.TabIndex = 5
            '
            'gaugeControl1
            '
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(1, 1)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(369, 315)
            Me.gaugeControl1.TabIndex = 4
            '
            'linearGauge1
            '
            Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent1})
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 357, 303)
            Me.linearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent1})
            Me.linearGauge1.Name = "linearGauge1"
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent1})
            '
            'linearScaleBackgroundLayerComponent1
            '
            Me.linearScaleBackgroundLayerComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleBackgroundLayerComponent1.Name = "linearScaleBackgroundLayerComponent1"
            Me.linearScaleBackgroundLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.92!)
            Me.linearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.08!)
            Me.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style11
            Me.linearScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'linearScaleComponent1
            '
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 20.0!)
            Me.linearScaleComponent1.MajorTickCount = 6
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = 6.5!
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_2
            Me.linearScaleComponent1.MajorTickmark.TextOffset = 30.0!
            Me.linearScaleComponent1.MinorTickCount = 4
            Me.linearScaleComponent1.MinorTickmark.ShapeOffset = 6.5!
            Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_1
            Me.linearScaleComponent1.Name = "linearScaleComponent1"
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 230.0!)
            '
            'linearScaleLevelComponent1
            '
            Me.linearScaleLevelComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleLevelComponent1.Name = "linearScaleLevelComponent1"
            Me.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style11
            Me.linearScaleLevelComponent1.ZOrder = 15
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.CustomizationFormText = "Labeled Tickmark Shape Type:"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 92)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(288, 31)
            Me.layoutControlItem7.Text = "Major Tickmark Shape:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(108, 20)
            Me.layoutControlItem7.TextToControlDistance = 5
            '
            'layoutControlItem8
            '
            Me.layoutControlItem8.CustomizationFormText = "Tickmark Shape Type:"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 92)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(288, 31)
            Me.layoutControlItem8.Text = "Minor Tickmark Shape:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(108, 20)
            Me.layoutControlItem8.TextToControlDistance = 5
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup6, Me.layoutControlGroup7, Me.layoutControlItem1, Me.layoutControlItem25, Me.layoutControlItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(660, 419)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(371, 409)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(289, 10)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlGroup6
            '
            Me.layoutControlGroup6.CustomizationFormText = "Tickmarks"
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5, Me.layoutControlItem4, Me.layoutControlItem10, Me.layoutControlItem11})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(371, 0)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(289, 265)
            Me.layoutControlGroup6.Text = "Tickmarks"
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.labelsCountTrack
            Me.layoutControlItem5.CustomizationFormText = "Labeled Tickmarks Count:"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 12, 3)
            Me.layoutControlItem5.Size = New System.Drawing.Size(265, 60)
            Me.layoutControlItem5.Text = "Major Tickmark Count:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.tickmarksCountTrack
            Me.layoutControlItem4.CustomizationFormText = "Tickmark Count:"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 60)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 3)
            Me.layoutControlItem4.Size = New System.Drawing.Size(265, 51)
            Me.layoutControlItem4.Text = "Minor Tickmark Count:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem10
            '
            Me.layoutControlItem10.Control = Me.tickOffset
            Me.layoutControlItem10.CustomizationFormText = "Tickmark Offset:"
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 111)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 3)
            Me.layoutControlItem10.Size = New System.Drawing.Size(265, 51)
            Me.layoutControlItem10.Text = "Minor Tickmark Offset:"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem11
            '
            Me.layoutControlItem11.Control = Me.lblTickOffset
            Me.layoutControlItem11.CustomizationFormText = "Labeled Tickmark Offset:"
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 162)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 12)
            Me.layoutControlItem11.Size = New System.Drawing.Size(265, 60)
            Me.layoutControlItem11.Text = "Major Tickmark Offset:"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlGroup7
            '
            Me.layoutControlGroup7.CustomizationFormText = "Text"
            Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem6})
            Me.layoutControlGroup7.Location = New System.Drawing.Point(371, 265)
            Me.layoutControlGroup7.Name = "layoutControlGroup7"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(289, 144)
            Me.layoutControlGroup7.Spacing = New DevExpress.XtraLayout.Utils.Padding(8, 2, 8, 2)
            Me.layoutControlGroup7.Text = "Text"
            '
            'layoutControlItem9
            '
            Me.layoutControlItem9.Control = Me.labelsOrientation
            Me.layoutControlItem9.CustomizationFormText = "Tickmark Text Orientation:"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 12, 3)
            Me.layoutControlItem9.Size = New System.Drawing.Size(259, 35)
            Me.layoutControlItem9.Text = "Text Orientation:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.textExtentTrack
            Me.layoutControlItem6.CustomizationFormText = "Text Extent:"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 35)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 12)
            Me.layoutControlItem6.Size = New System.Drawing.Size(259, 60)
            Me.layoutControlItem6.Text = "Text Offset:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutControlItem1.Size = New System.Drawing.Size(371, 317)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem25
            '
            Me.layoutControlItem25.Control = Me.rangeTrackLinear
            Me.layoutControlItem25.CustomizationFormText = "Min/Max Value:"
            Me.layoutControlItem25.Location = New System.Drawing.Point(0, 363)
            Me.layoutControlItem25.Name = "layoutControlItem25"
            Me.layoutControlItem25.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 8)
            Me.layoutControlItem25.Size = New System.Drawing.Size(371, 56)
            Me.layoutControlItem25.Text = "Min/Max Value:"
            Me.layoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.layoutControlItem25.TextSize = New System.Drawing.Size(73, 13)
            Me.layoutControlItem25.TextToControlDistance = 5
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.valueTrack
            Me.layoutControlItem2.CustomizationFormText = "Value:"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 317)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 3)
            Me.layoutControlItem2.Size = New System.Drawing.Size(371, 46)
            Me.layoutControlItem2.Text = "Value:"
            Me.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(30, 13)
            Me.layoutControlItem2.TextToControlDistance = 5
            '
            'xtraTabPage4
            '
            Me.xtraTabPage4.Controls.Add(Me.layoutControl4)
            Me.xtraTabPage4.Name = "xtraTabPage4"
            Me.xtraTabPage4.Size = New System.Drawing.Size(693, 425)
            Me.xtraTabPage4.Text = "Range Bar && Marker Features"
            '
            'layoutControl4
            '
            Me.layoutControl4.Controls.Add(Me.markerShape)
            Me.layoutControl4.Controls.Add(Me.markerOffset)
            Me.layoutControl4.Controls.Add(Me.gaugeControl4)
            Me.layoutControl4.Controls.Add(Me.rbValue)
            Me.layoutControl4.Controls.Add(Me.rbStartValue)
            Me.layoutControl4.Controls.Add(Me.rbEndExtent)
            Me.layoutControl4.Controls.Add(Me.rbStartExtent)
            Me.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl4.Name = "layoutControl4"
            Me.layoutControl4.Root = Me.layoutControlGroup4
            Me.layoutControl4.Size = New System.Drawing.Size(693, 425)
            Me.layoutControl4.TabIndex = 0
            Me.layoutControl4.Text = "layoutControl4"
            '
            'markerShape
            '
            Me.markerShape.Location = New System.Drawing.Point(477, 314)
            Me.markerShape.Name = "markerShape"
            Me.markerShape.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.markerShape.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.markerShape.Size = New System.Drawing.Size(200, 20)
            Me.markerShape.StyleController = Me.layoutControl4
            Me.markerShape.TabIndex = 10
            '
            'markerOffset
            '
            Me.markerOffset.EditValue = Nothing
            Me.markerOffset.Location = New System.Drawing.Point(477, 263)
            Me.markerOffset.MaximumSize = New System.Drawing.Size(200, 35)
            Me.markerOffset.MinimumSize = New System.Drawing.Size(200, 35)
            Me.markerOffset.Name = "markerOffset"
            Me.markerOffset.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.markerOffset.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.markerOffset.Properties.Maximum = 50
            Me.markerOffset.Properties.Minimum = -50
            Me.markerOffset.Properties.TickFrequency = 10
            Me.markerOffset.Size = New System.Drawing.Size(200, 35)
            Me.markerOffset.StyleController = Me.layoutControl4
            Me.markerOffset.TabIndex = 9
            Me.markerOffset.Value = -50
            '
            'gaugeControl4
            '
            Me.gaugeControl4.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge4})
            Me.gaugeControl4.Location = New System.Drawing.Point(8, 0)
            Me.gaugeControl4.Name = "gaugeControl4"
            Me.gaugeControl4.Size = New System.Drawing.Size(370, 413)
            Me.gaugeControl4.TabIndex = 8
            '
            'linearGauge4
            '
            Me.linearGauge4.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent4})
            Me.linearGauge4.Bounds = New System.Drawing.Rectangle(6, 6, 358, 401)
            Me.linearGauge4.Markers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent() {Me.linearScaleMarkerComponent1})
            Me.linearGauge4.Name = "linearGauge4"
            Me.linearGauge4.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent() {Me.linearScaleRangeBarComponent1})
            Me.linearGauge4.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent4})
            '
            'linearScaleBackgroundLayerComponent4
            '
            Me.linearScaleBackgroundLayerComponent4.LinearScale = Me.linearScaleComponent4
            Me.linearScaleBackgroundLayerComponent4.Name = "linearScaleBackgroundLayerComponent4"
            Me.linearScaleBackgroundLayerComponent4.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.92!)
            Me.linearScaleBackgroundLayerComponent4.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.08!)
            Me.linearScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style11
            Me.linearScaleBackgroundLayerComponent4.ZOrder = 1000
            '
            'linearScaleComponent4
            '
            Me.linearScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent4.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 25.0!)
            Me.linearScaleComponent4.MajorTickCount = 6
            Me.linearScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent4.MajorTickmark.ShapeOffset = 6.0!
            Me.linearScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_2
            Me.linearScaleComponent4.MajorTickmark.TextOffset = 30.0!
            Me.linearScaleComponent4.MaxValue = 50.0!
            Me.linearScaleComponent4.MinorTickCount = 4
            Me.linearScaleComponent4.MinorTickmark.ShapeOffset = 6.0!
            Me.linearScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_1
            Me.linearScaleComponent4.Name = "linearScaleComponent4"
            Me.linearScaleComponent4.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 225.0!)
            Me.linearScaleComponent4.Value = 25.0!
            '
            'linearScaleMarkerComponent1
            '
            Me.linearScaleMarkerComponent1.LinearScale = Me.linearScaleComponent4
            Me.linearScaleMarkerComponent1.Name = "linearScaleMarkerComponent1"
            Me.linearScaleMarkerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Diamond
            Me.linearScaleMarkerComponent1.ZOrder = -150
            '
            'linearScaleRangeBarComponent1
            '
            Me.linearScaleRangeBarComponent1.AppearanceRangeBar.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#8080FF")
            Me.linearScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.LinearGradientBrushObject("Geometry[Start:0, 0;End:10, 10] Colors[Start:;End:#8080FF]")
            Me.linearScaleRangeBarComponent1.EndOffset = -20.0!
            Me.linearScaleRangeBarComponent1.LinearScale = Me.linearScaleComponent4
            Me.linearScaleRangeBarComponent1.Name = "linearScaleRangeBarComponent1"
            Me.linearScaleRangeBarComponent1.StartOffset = -10.0!
            Me.linearScaleRangeBarComponent1.ZOrder = -100
            '
            'rbValue
            '
            Me.rbValue.EditValue = Nothing
            Me.rbValue.Location = New System.Drawing.Point(477, 20)
            Me.rbValue.MaximumSize = New System.Drawing.Size(200, 35)
            Me.rbValue.MinimumSize = New System.Drawing.Size(200, 35)
            Me.rbValue.Name = "rbValue"
            Me.rbValue.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.rbValue.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rbValue.Properties.Maximum = 50
            Me.rbValue.Properties.TickFrequency = 5
            Me.rbValue.Size = New System.Drawing.Size(200, 35)
            Me.rbValue.StyleController = Me.layoutControl4
            Me.rbValue.TabIndex = 7
            '
            'rbStartValue
            '
            Me.rbStartValue.EditValue = Nothing
            Me.rbStartValue.Location = New System.Drawing.Point(477, 88)
            Me.rbStartValue.MaximumSize = New System.Drawing.Size(200, 35)
            Me.rbStartValue.MinimumSize = New System.Drawing.Size(200, 35)
            Me.rbStartValue.Name = "rbStartValue"
            Me.rbStartValue.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.rbStartValue.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rbStartValue.Properties.Maximum = 50
            Me.rbStartValue.Properties.TickFrequency = 5
            Me.rbStartValue.Size = New System.Drawing.Size(200, 35)
            Me.rbStartValue.StyleController = Me.layoutControl4
            Me.rbStartValue.TabIndex = 6
            '
            'rbEndExtent
            '
            Me.rbEndExtent.EditValue = Nothing
            Me.rbEndExtent.Location = New System.Drawing.Point(477, 139)
            Me.rbEndExtent.MaximumSize = New System.Drawing.Size(200, 35)
            Me.rbEndExtent.MinimumSize = New System.Drawing.Size(200, 35)
            Me.rbEndExtent.Name = "rbEndExtent"
            Me.rbEndExtent.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.rbEndExtent.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rbEndExtent.Properties.Maximum = 25
            Me.rbEndExtent.Properties.Minimum = -25
            Me.rbEndExtent.Properties.TickFrequency = 5
            Me.rbEndExtent.Size = New System.Drawing.Size(200, 35)
            Me.rbEndExtent.StyleController = Me.layoutControl4
            Me.rbEndExtent.TabIndex = 5
            Me.rbEndExtent.Value = -25
            '
            'rbStartExtent
            '
            Me.rbStartExtent.EditValue = Nothing
            Me.rbStartExtent.Location = New System.Drawing.Point(477, 190)
            Me.rbStartExtent.MaximumSize = New System.Drawing.Size(200, 35)
            Me.rbStartExtent.MinimumSize = New System.Drawing.Size(200, 35)
            Me.rbStartExtent.Name = "rbStartExtent"
            Me.rbStartExtent.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.rbStartExtent.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rbStartExtent.Properties.Maximum = 25
            Me.rbStartExtent.Properties.Minimum = -25
            Me.rbStartExtent.Properties.TickFrequency = 5
            Me.rbStartExtent.Size = New System.Drawing.Size(200, 35)
            Me.rbStartExtent.StyleController = Me.layoutControl4
            Me.rbStartExtent.TabIndex = 4
            Me.rbStartExtent.Value = -25
            '
            'layoutControlGroup4
            '
            Me.layoutControlGroup4.AllowDrawBackground = False
            Me.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4"
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem22, Me.layoutControlItem20, Me.layoutControlItem21, Me.layoutControlItem19, Me.layoutControlItem18, Me.emptySpaceItem2, Me.layoutControlItem3, Me.layoutControlItem26})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(693, 425)
            Me.layoutControlGroup4.Text = "layoutControlGroup4"
            Me.layoutControlGroup4.TextVisible = False
            '
            'layoutControlItem22
            '
            Me.layoutControlItem22.Control = Me.gaugeControl4
            Me.layoutControlItem22.CustomizationFormText = "layoutControlItem22"
            Me.layoutControlItem22.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem22.Name = "layoutControlItem22"
            Me.layoutControlItem22.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 0, 12)
            Me.layoutControlItem22.Size = New System.Drawing.Size(386, 425)
            Me.layoutControlItem22.Text = "layoutControlItem22"
            Me.layoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem22.TextToControlDistance = 0
            Me.layoutControlItem22.TextVisible = False
            '
            'layoutControlItem20
            '
            Me.layoutControlItem20.Control = Me.rbStartValue
            Me.layoutControlItem20.CustomizationFormText = "Start Value:"
            Me.layoutControlItem20.Location = New System.Drawing.Point(386, 68)
            Me.layoutControlItem20.Name = "layoutControlItem20"
            Me.layoutControlItem20.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 20, 3)
            Me.layoutControlItem20.Size = New System.Drawing.Size(307, 68)
            Me.layoutControlItem20.Text = "Anchor Value:"
            Me.layoutControlItem20.TextSize = New System.Drawing.Size(71, 13)
            '
            'layoutControlItem21
            '
            Me.layoutControlItem21.Control = Me.rbValue
            Me.layoutControlItem21.CustomizationFormText = "Value"
            Me.layoutControlItem21.Location = New System.Drawing.Point(386, 0)
            Me.layoutControlItem21.Name = "layoutControlItem21"
            Me.layoutControlItem21.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 20, 3)
            Me.layoutControlItem21.Size = New System.Drawing.Size(307, 68)
            Me.layoutControlItem21.Text = "Value:"
            Me.layoutControlItem21.TextSize = New System.Drawing.Size(71, 13)
            '
            'layoutControlItem19
            '
            Me.layoutControlItem19.Control = Me.rbEndExtent
            Me.layoutControlItem19.CustomizationFormText = "End Extent:"
            Me.layoutControlItem19.Location = New System.Drawing.Point(386, 136)
            Me.layoutControlItem19.Name = "layoutControlItem19"
            Me.layoutControlItem19.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 3)
            Me.layoutControlItem19.Size = New System.Drawing.Size(307, 51)
            Me.layoutControlItem19.Text = "End Offset:"
            Me.layoutControlItem19.TextSize = New System.Drawing.Size(71, 13)
            '
            'layoutControlItem18
            '
            Me.layoutControlItem18.Control = Me.rbStartExtent
            Me.layoutControlItem18.CustomizationFormText = "Start Extent:"
            Me.layoutControlItem18.Location = New System.Drawing.Point(386, 187)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 8)
            Me.layoutControlItem18.Size = New System.Drawing.Size(307, 56)
            Me.layoutControlItem18.Text = "Start Offset:"
            Me.layoutControlItem18.TextSize = New System.Drawing.Size(71, 13)
            '
            'emptySpaceItem2
            '
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(386, 342)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(307, 83)
            Me.emptySpaceItem2.Text = "emptySpaceItem2"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.markerOffset
            Me.layoutControlItem3.CustomizationFormText = "Marker Offset:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(386, 243)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 20, 3)
            Me.layoutControlItem3.Size = New System.Drawing.Size(307, 68)
            Me.layoutControlItem3.Text = "Marker Offset:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(71, 13)
            '
            'layoutControlItem26
            '
            Me.layoutControlItem26.Control = Me.markerShape
            Me.layoutControlItem26.CustomizationFormText = "Marker Shape:"
            Me.layoutControlItem26.Location = New System.Drawing.Point(386, 311)
            Me.layoutControlItem26.Name = "layoutControlItem26"
            Me.layoutControlItem26.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 8)
            Me.layoutControlItem26.Size = New System.Drawing.Size(307, 31)
            Me.layoutControlItem26.Text = "Marker Shape:"
            Me.layoutControlItem26.TextSize = New System.Drawing.Size(71, 13)
            '
            'xtraTabPage5
            '
            Me.xtraTabPage5.Controls.Add(Me.layoutControl5)
            Me.xtraTabPage5.Name = "xtraTabPage5"
            Me.xtraTabPage5.Size = New System.Drawing.Size(693, 425)
            Me.xtraTabPage5.Text = "State Indicator Features"
            '
            'layoutControl5
            '
            Me.layoutControl5.Controls.Add(Me.stateValTrack)
            Me.layoutControl5.Controls.Add(Me.gaugeControl5)
            Me.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl5.Name = "layoutControl5"
            Me.layoutControl5.Root = Me.layoutControlGroup5
            Me.layoutControl5.Size = New System.Drawing.Size(693, 425)
            Me.layoutControl5.TabIndex = 0
            Me.layoutControl5.Text = "layoutControl5"
            '
            'stateValTrack
            '
            Me.stateValTrack.EditValue = Nothing
            Me.stateValTrack.Location = New System.Drawing.Point(640, 24)
            Me.stateValTrack.MaximumSize = New System.Drawing.Size(30, 0)
            Me.stateValTrack.MinimumSize = New System.Drawing.Size(30, 0)
            Me.stateValTrack.Name = "stateValTrack"
            Me.stateValTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.stateValTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.stateValTrack.Properties.Maximum = 50
            Me.stateValTrack.Properties.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.stateValTrack.Properties.TickStyle = System.Windows.Forms.TickStyle.Both
            Me.stateValTrack.Size = New System.Drawing.Size(30, 393)
            Me.stateValTrack.StyleController = Me.layoutControl5
            Me.stateValTrack.TabIndex = 5
            '
            'gaugeControl5
            '
            Me.gaugeControl5.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge5})
            Me.gaugeControl5.Location = New System.Drawing.Point(8, 8)
            Me.gaugeControl5.Name = "gaugeControl5"
            Me.gaugeControl5.Size = New System.Drawing.Size(624, 409)
            Me.gaugeControl5.TabIndex = 4
            '
            'linearGauge5
            '
            Me.linearGauge5.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent5})
            Me.linearGauge5.Bounds = New System.Drawing.Rectangle(6, 6, 612, 397)
            Me.linearGauge5.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() {Me.linearScaleStateIndicatorComponent1, Me.linearScaleStateIndicatorComponent2})
            Me.linearGauge5.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent2})
            Me.linearGauge5.Name = "linearGauge5"
            Me.linearGauge5.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent5})
            '
            'linearScaleBackgroundLayerComponent5
            '
            Me.linearScaleBackgroundLayerComponent5.LinearScale = Me.linearScaleComponent5
            Me.linearScaleBackgroundLayerComponent5.Name = "linearScaleBackgroundLayerComponent5"
            Me.linearScaleBackgroundLayerComponent5.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.92!)
            Me.linearScaleBackgroundLayerComponent5.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.08!)
            Me.linearScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style11
            Me.linearScaleBackgroundLayerComponent5.ZOrder = 1000
            '
            'linearScaleComponent5
            '
            Me.linearScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent5.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 25.0!)
            Me.linearScaleComponent5.MajorTickCount = 6
            Me.linearScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent5.MajorTickmark.ShapeOffset = 6.5!
            Me.linearScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_2
            Me.linearScaleComponent5.MajorTickmark.TextOffset = -20.0!
            Me.linearScaleComponent5.MaxValue = 50.0!
            Me.linearScaleComponent5.MinorTickCount = 4
            Me.linearScaleComponent5.MinorTickmark.ShapeOffset = 6.5!
            Me.linearScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_1
            Me.linearScaleComponent5.Name = "linearScaleComponent5"
            Me.linearScaleComponent5.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 225.0!)
            '
            'linearScaleStateIndicatorComponent1
            '
            Me.linearScaleStateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 25.0!)
            Me.linearScaleStateIndicatorComponent1.IndicatorScale = Me.linearScaleComponent5
            Me.linearScaleStateIndicatorComponent1.Name = "linearScaleStateIndicatorComponent1"
            Me.linearScaleStateIndicatorComponent1.Size = New System.Drawing.SizeF(25.0!, 25.0!)
            ScaleIndicatorState1.IntervalLength = 20.0!
            ScaleIndicatorState1.Name = "State1"
            ScaleIndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4
            ScaleIndicatorState2.IntervalLength = 20.0!
            ScaleIndicatorState2.Name = "State2"
            ScaleIndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight3
            ScaleIndicatorState2.StartValue = 20.0!
            ScaleIndicatorState3.IntervalLength = 10.0!
            ScaleIndicatorState3.Name = "State3"
            ScaleIndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2
            ScaleIndicatorState3.StartValue = 40.0!
            Me.linearScaleStateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState1, ScaleIndicatorState2, ScaleIndicatorState3})
            Me.linearScaleStateIndicatorComponent1.ZOrder = -100
            '
            'linearScaleStateIndicatorComponent2
            '
            Me.linearScaleStateIndicatorComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 225.0!)
            Me.linearScaleStateIndicatorComponent2.IndicatorScale = Me.linearScaleComponent5
            Me.linearScaleStateIndicatorComponent2.Name = "linearScaleStateIndicatorComponent2"
            Me.linearScaleStateIndicatorComponent2.Size = New System.Drawing.SizeF(25.0!, 25.0!)
            ScaleIndicatorState4.IntervalLength = 10.0!
            ScaleIndicatorState4.Name = "State1"
            ScaleIndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile1
            ScaleIndicatorState5.IntervalLength = 10.0!
            ScaleIndicatorState5.Name = "State2"
            ScaleIndicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile2
            ScaleIndicatorState5.StartValue = 10.0!
            ScaleIndicatorState6.IntervalLength = 10.0!
            ScaleIndicatorState6.Name = "State3"
            ScaleIndicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile3
            ScaleIndicatorState6.StartValue = 20.0!
            ScaleIndicatorState7.IntervalLength = 10.0!
            ScaleIndicatorState7.Name = "State4"
            ScaleIndicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile4
            ScaleIndicatorState7.StartValue = 30.0!
            ScaleIndicatorState8.IntervalLength = 10.0!
            ScaleIndicatorState8.Name = "State5"
            ScaleIndicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile5
            ScaleIndicatorState8.StartValue = 40.0!
            Me.linearScaleStateIndicatorComponent2.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState4, ScaleIndicatorState5, ScaleIndicatorState6, ScaleIndicatorState7, ScaleIndicatorState8})
            Me.linearScaleStateIndicatorComponent2.ZOrder = -100
            '
            'linearScaleLevelComponent2
            '
            Me.linearScaleLevelComponent2.LinearScale = Me.linearScaleComponent5
            Me.linearScaleLevelComponent2.Name = "linearScaleLevelComponent2"
            Me.linearScaleLevelComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style11
            Me.linearScaleLevelComponent2.ZOrder = -50
            '
            'layoutControlGroup5
            '
            Me.layoutControlGroup5.AllowDrawBackground = False
            Me.layoutControlGroup5.CustomizationFormText = "layoutControlGroup5"
            Me.layoutControlGroup5.GroupBordersVisible = False
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem23, Me.layoutControlItem24})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(693, 425)
            Me.layoutControlGroup5.Text = "layoutControlGroup5"
            Me.layoutControlGroup5.TextVisible = False
            '
            'layoutControlItem23
            '
            Me.layoutControlItem23.Control = Me.gaugeControl5
            Me.layoutControlItem23.CustomizationFormText = "layoutControlItem23"
            Me.layoutControlItem23.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem23.Name = "layoutControlItem23"
            Me.layoutControlItem23.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 1, 8, 8)
            Me.layoutControlItem23.Size = New System.Drawing.Size(633, 425)
            Me.layoutControlItem23.Text = "layoutControlItem23"
            Me.layoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem23.TextToControlDistance = 0
            Me.layoutControlItem23.TextVisible = False
            '
            'layoutControlItem24
            '
            Me.layoutControlItem24.Control = Me.stateValTrack
            Me.layoutControlItem24.CustomizationFormText = "Value:"
            Me.layoutControlItem24.Location = New System.Drawing.Point(633, 0)
            Me.layoutControlItem24.Name = "layoutControlItem24"
            Me.layoutControlItem24.Padding = New DevExpress.XtraLayout.Utils.Padding(7, 8, 8, 8)
            Me.layoutControlItem24.Size = New System.Drawing.Size(60, 425)
            Me.layoutControlItem24.Text = "Value:"
            Me.layoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem24.TextSize = New System.Drawing.Size(30, 13)
            '
            'xtraTabPage6
            '
            Me.xtraTabPage6.Controls.Add(Me.layoutControl6)
            Me.xtraTabPage6.Name = "xtraTabPage6"
            Me.xtraTabPage6.Size = New System.Drawing.Size(693, 425)
            Me.xtraTabPage6.Text = "Label Features"
            '
            'layoutControl6
            '
            Me.layoutControl6.Controls.Add(Me.gaugeControl6)
            Me.layoutControl6.Controls.Add(Me.lblOrientation)
            Me.layoutControl6.Controls.Add(Me.trackBarControl1)
            Me.layoutControl6.Controls.Add(Me.vertLblPos)
            Me.layoutControl6.Controls.Add(Me.horzLblPos)
            Me.layoutControl6.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl6.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem27})
            Me.layoutControl6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl6.Name = "layoutControl6"
            Me.layoutControl6.Root = Me.layoutControlGroup8
            Me.layoutControl6.Size = New System.Drawing.Size(693, 425)
            Me.layoutControl6.TabIndex = 2
            Me.layoutControl6.Text = "layoutControl6"
            '
            'gaugeControl6
            '
            Me.gaugeControl6.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge6})
            Me.gaugeControl6.Location = New System.Drawing.Point(8, 8)
            Me.gaugeControl6.Name = "gaugeControl6"
            Me.gaugeControl6.Size = New System.Drawing.Size(437, 409)
            Me.gaugeControl6.TabIndex = 5
            '
            'linearGauge6
            '
            Me.linearGauge6.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent6})
            Me.linearGauge6.Bounds = New System.Drawing.Rectangle(6, 6, 425, 397)
            Me.linearGauge6.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent4})
            Me.linearGauge6.Name = "linearGauge6"
            Me.linearGauge6.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent6})
            '
            'linearScaleBackgroundLayerComponent6
            '
            Me.linearScaleBackgroundLayerComponent6.LinearScale = Me.linearScaleComponent6
            Me.linearScaleBackgroundLayerComponent6.Name = "linearScaleBackgroundLayerComponent6"
            Me.linearScaleBackgroundLayerComponent6.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.92!)
            Me.linearScaleBackgroundLayerComponent6.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.505!, 0.08!)
            Me.linearScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style11
            Me.linearScaleBackgroundLayerComponent6.ZOrder = 1000
            '
            'linearScaleComponent6
            '
            Me.linearScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent6.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 20.0!)
            ScaleLabel1.AppearanceBackground.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:infotext")
            ScaleLabel1.AppearanceBackground.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:infobackground")
            ScaleLabel1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:infotext")
            ScaleLabel1.Name = "Label0"
            ScaleLabel1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(40.0!, 125.0!)
            ScaleLabel1.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel1.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
            Me.linearScaleComponent6.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel1})
            Me.linearScaleComponent6.MajorTickCount = 6
            Me.linearScaleComponent6.MajorTickmark.ShapeOffset = 6.5!
            Me.linearScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_2
            Me.linearScaleComponent6.MajorTickmark.TextOffset = 30.0!
            Me.linearScaleComponent6.MinorTickCount = 4
            Me.linearScaleComponent6.MinorTickmark.ShapeOffset = 6.5!
            Me.linearScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_1
            Me.linearScaleComponent6.Name = "linearScaleComponent6"
            Me.linearScaleComponent6.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 230.0!)
            '
            'linearScaleLevelComponent4
            '
            Me.linearScaleLevelComponent4.LinearScale = Me.linearScaleComponent6
            Me.linearScaleLevelComponent4.Name = "linearScaleLevelComponent4"
            Me.linearScaleLevelComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style11
            Me.linearScaleLevelComponent4.ZOrder = 15
            '
            'lblOrientation
            '
            Me.lblOrientation.Location = New System.Drawing.Point(524, 178)
            Me.lblOrientation.Name = "lblOrientation"
            Me.lblOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lblOrientation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.lblOrientation.Size = New System.Drawing.Size(157, 20)
            Me.lblOrientation.StyleController = Me.layoutControl6
            Me.lblOrientation.TabIndex = 12
            '
            'trackBarControl1
            '
            Me.trackBarControl1.EditValue = Nothing
            Me.trackBarControl1.Location = New System.Drawing.Point(524, 12)
            Me.trackBarControl1.MaximumSize = New System.Drawing.Size(0, 30)
            Me.trackBarControl1.MinimumSize = New System.Drawing.Size(150, 30)
            Me.trackBarControl1.Name = "trackBarControl1"
            Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl1.Properties.Maximum = 50
            Me.trackBarControl1.Properties.TickFrequency = 5
            Me.trackBarControl1.Size = New System.Drawing.Size(157, 30)
            Me.trackBarControl1.StyleController = Me.layoutControl6
            Me.trackBarControl1.TabIndex = 11
            '
            'vertLblPos
            '
            Me.vertLblPos.EditValue = 50
            Me.vertLblPos.Location = New System.Drawing.Point(524, 127)
            Me.vertLblPos.MaximumSize = New System.Drawing.Size(0, 30)
            Me.vertLblPos.MinimumSize = New System.Drawing.Size(150, 30)
            Me.vertLblPos.Name = "vertLblPos"
            Me.vertLblPos.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.vertLblPos.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.vertLblPos.Properties.Maximum = 200
            Me.vertLblPos.Properties.Minimum = 50
            Me.vertLblPos.Properties.TickFrequency = 10
            Me.vertLblPos.Size = New System.Drawing.Size(157, 30)
            Me.vertLblPos.StyleController = Me.layoutControl6
            Me.vertLblPos.TabIndex = 10
            Me.vertLblPos.Value = 50
            '
            'horzLblPos
            '
            Me.horzLblPos.EditValue = 10
            Me.horzLblPos.Location = New System.Drawing.Point(524, 76)
            Me.horzLblPos.MaximumSize = New System.Drawing.Size(0, 30)
            Me.horzLblPos.MinimumSize = New System.Drawing.Size(150, 30)
            Me.horzLblPos.Name = "horzLblPos"
            Me.horzLblPos.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.horzLblPos.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.horzLblPos.Properties.Maximum = 125
            Me.horzLblPos.Properties.TickFrequency = 10
            Me.horzLblPos.Size = New System.Drawing.Size(157, 30)
            Me.horzLblPos.StyleController = Me.layoutControl6
            Me.horzLblPos.TabIndex = 9
            Me.horzLblPos.Value = 10
            '
            'comboBoxEdit1
            '
            Me.comboBoxEdit1.Location = New System.Drawing.Point(610, 21)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(146, 20)
            Me.comboBoxEdit1.StyleController = Me.layoutControl6
            Me.comboBoxEdit1.TabIndex = 8
            '
            'layoutControlItem27
            '
            Me.layoutControlItem27.Control = Me.comboBoxEdit1
            Me.layoutControlItem27.CustomizationFormText = "Needle type:"
            Me.layoutControlItem27.Location = New System.Drawing.Point(518, 0)
            Me.layoutControlItem27.Name = "layoutControlItem45"
            Me.layoutControlItem27.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 20, 5)
            Me.layoutControlItem27.Size = New System.Drawing.Size(254, 46)
            Me.layoutControlItem27.Text = "Needle Shape:"
            Me.layoutControlItem27.TextSize = New System.Drawing.Size(70, 20)
            Me.layoutControlItem27.TextToControlDistance = 5
            '
            'layoutControlGroup8
            '
            Me.layoutControlGroup8.AllowDrawBackground = False
            Me.layoutControlGroup8.CustomizationFormText = "layoutControlGroup6"
            Me.layoutControlGroup8.GroupBordersVisible = False
            Me.layoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem29, Me.layoutControlItem30, Me.layoutControlItem31, Me.layoutControlItem32, Me.layoutControlItem28})
            Me.layoutControlGroup8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup8.Name = "Root"
            Me.layoutControlGroup8.Size = New System.Drawing.Size(693, 425)
            Me.layoutControlGroup8.Text = "Root"
            Me.layoutControlGroup8.TextVisible = False
            '
            'layoutControlItem29
            '
            Me.layoutControlItem29.Control = Me.trackBarControl1
            Me.layoutControlItem29.CustomizationFormText = "Value:"
            Me.layoutControlItem29.Location = New System.Drawing.Point(446, 0)
            Me.layoutControlItem29.Name = "layoutControlItem49"
            Me.layoutControlItem29.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 12, 16)
            Me.layoutControlItem29.Size = New System.Drawing.Size(247, 73)
            Me.layoutControlItem29.Text = "Value:"
            Me.layoutControlItem29.TextSize = New System.Drawing.Size(58, 13)
            '
            'layoutControlItem30
            '
            Me.layoutControlItem30.Control = Me.vertLblPos
            Me.layoutControlItem30.CustomizationFormText = "End extent:"
            Me.layoutControlItem30.Location = New System.Drawing.Point(446, 124)
            Me.layoutControlItem30.Name = "layoutControlItem47"
            Me.layoutControlItem30.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 3, 3)
            Me.layoutControlItem30.Size = New System.Drawing.Size(247, 51)
            Me.layoutControlItem30.Text = "Y Position:"
            Me.layoutControlItem30.TextSize = New System.Drawing.Size(58, 13)
            '
            'layoutControlItem31
            '
            Me.layoutControlItem31.Control = Me.horzLblPos
            Me.layoutControlItem31.CustomizationFormText = "Start Extent:"
            Me.layoutControlItem31.Location = New System.Drawing.Point(446, 73)
            Me.layoutControlItem31.Name = "layoutControlItem46"
            Me.layoutControlItem31.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 3, 3)
            Me.layoutControlItem31.Size = New System.Drawing.Size(247, 51)
            Me.layoutControlItem31.Text = "X Position:"
            Me.layoutControlItem31.TextSize = New System.Drawing.Size(58, 13)
            '
            'layoutControlItem32
            '
            Me.layoutControlItem32.Control = Me.lblOrientation
            Me.layoutControlItem32.CustomizationFormText = "Label Orientation:"
            Me.layoutControlItem32.Location = New System.Drawing.Point(446, 175)
            Me.layoutControlItem32.Name = "layoutControlItem20"
            Me.layoutControlItem32.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 3, 3)
            Me.layoutControlItem32.Size = New System.Drawing.Size(247, 250)
            Me.layoutControlItem32.Text = "Orientation:"
            Me.layoutControlItem32.TextSize = New System.Drawing.Size(58, 13)
            '
            'layoutControlItem28
            '
            Me.layoutControlItem28.Control = Me.gaugeControl6
            Me.layoutControlItem28.CustomizationFormText = "layoutControlItem28"
            Me.layoutControlItem28.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem28.Name = "layoutControlItem28"
            Me.layoutControlItem28.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 1, 8, 8)
            Me.layoutControlItem28.Size = New System.Drawing.Size(446, 425)
            Me.layoutControlItem28.Text = "layoutControlItem28"
            Me.layoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem28.TextToControlDistance = 0
            Me.layoutControlItem28.TextVisible = False
            '
            'linearScaleEffectLayerComponent1
            '
            Me.linearScaleEffectLayerComponent1.Name = "linearScaleEffectLayerComponent1"
            Me.linearScaleEffectLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 2.0!)
            Me.linearScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.Linear_Style6
            Me.linearScaleEffectLayerComponent1.ZOrder = -1000
            '
            'LinearGaugeFeatures
            '
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "LinearGaugeFeatures"
            Me.Size = New System.Drawing.Size(699, 453)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.rangeTrackLinear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rangeTrackLinear, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblTickOffset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblTickOffset, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tickOffset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tickOffset, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.labelsOrientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textExtentTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textExtentTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.labelsCountTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.labelsCountTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tickmarksCountTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tickmarksCountTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.valueTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.valueTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage4.ResumeLayout(False)
            CType(Me.layoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl4.ResumeLayout(False)
            CType(Me.markerShape.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.markerOffset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.markerOffset, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearGauge4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbValue, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbStartValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbStartValue, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbEndExtent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbEndExtent, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbStartExtent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rbStartExtent, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage5.ResumeLayout(False)
            CType(Me.layoutControl5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl5.ResumeLayout(False)
            CType(Me.stateValTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.stateValTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearGauge5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleLevelComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage6.ResumeLayout(False)
            CType(Me.layoutControl6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl6.ResumeLayout(False)
            CType(Me.linearGauge6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleLevelComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblOrientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vertLblPos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vertLblPos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.horzLblPos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.horzLblPos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Private linearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
        Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Private linearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private valueTrack As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private labelsCountTrack As DevExpress.XtraEditors.TrackBarControl
        Private tickmarksCountTrack As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private textExtentTrack As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Private labelsOrientation As DevExpress.XtraEditors.ComboBoxEdit
        Private lblTickOffset As DevExpress.XtraEditors.TrackBarControl
        Private tickOffset As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Private linearScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent
        Private layoutControl4 As DevExpress.XtraLayout.LayoutControl
        Private rbValue As DevExpress.XtraEditors.TrackBarControl
        Private rbStartValue As DevExpress.XtraEditors.TrackBarControl
        Private rbEndExtent As DevExpress.XtraEditors.TrackBarControl
        Private rbStartExtent As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
        Private gaugeControl4 As DevExpress.XtraGauges.Win.GaugeControl
        Private linearGauge4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Private linearScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
        Private linearScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Private layoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
        Private linearScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent
        Private layoutControl5 As DevExpress.XtraLayout.LayoutControl
        Private stateValTrack As DevExpress.XtraEditors.TrackBarControl
        Private gaugeControl5 As DevExpress.XtraGauges.Win.GaugeControl
        Private linearGauge5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Private linearScaleBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
        Private linearScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Private linearScaleLevelComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
        Private linearScaleStateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
        Private linearScaleStateIndicatorComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Private rangeTrackLinear As DevExpress.XtraEditors.RangeTrackBarControl
        Private layoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Private linearScaleMarkerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent
        Private markerShape As DevExpress.XtraEditors.ComboBoxEdit
        Private markerOffset As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
        Private xtraTabPage6 As DevExpress.XtraTab.XtraTabPage
        Private layoutControl6 As DevExpress.XtraLayout.LayoutControl
        Private gaugeControl6 As DevExpress.XtraGauges.Win.GaugeControl
        Private linearGauge6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Private linearScaleBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
        Private linearScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Private linearScaleLevelComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
        Private lblOrientation As DevExpress.XtraEditors.ComboBoxEdit
        Private trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
        Private vertLblPos As DevExpress.XtraEditors.TrackBarControl
        Private horzLblPos As DevExpress.XtraEditors.TrackBarControl
        Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
        Private layoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
        Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    End Class
End Namespace
