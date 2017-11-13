Namespace DevExpress.XtraGauges.Demos
    Partial Class CircularGaugeFeatures
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
            Dim ScaleIndicatorState13 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState14 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState15 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState16 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState17 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState18 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleLabel3 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.majorTickOffset = New DevExpress.XtraEditors.TrackBarControl
            Me.minorTickOffset = New DevExpress.XtraEditors.TrackBarControl
            Me.rangeTrack = New DevExpress.XtraEditors.RangeTrackBarControl
            Me.scaleLabelsCount = New DevExpress.XtraEditors.TrackBarControl
            Me.scaleTextOrientation = New DevExpress.XtraEditors.ComboBoxEdit
            Me.scaleTextExtentTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.scaleValueTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.scaleEndAngleTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.scaleStartAngleTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.scaleTicksCount = New DevExpress.XtraEditors.TrackBarControl
            Me.scaleRTrack = New DevExpress.XtraEditors.TrackBarControl
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl5 = New DevExpress.XtraLayout.LayoutControl
            Me.markerShape = New DevExpress.XtraEditors.ComboBoxEdit
            Me.markerOffset = New DevExpress.XtraEditors.TrackBarControl
            Me.trackBarControl32 = New DevExpress.XtraEditors.TrackBarControl
            Me.trackBarControl31 = New DevExpress.XtraEditors.TrackBarControl
            Me.trackBarControl30 = New DevExpress.XtraEditors.TrackBarControl
            Me.trackBarControl29 = New DevExpress.XtraEditors.TrackBarControl
            Me.gaugeControl5 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.circularGauge5 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.arcScaleBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.arcScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.arcScaleMarkerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent
            Me.arcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl6 = New DevExpress.XtraLayout.LayoutControl
            Me.trackBarControl28 = New DevExpress.XtraEditors.TrackBarControl
            Me.trackBarControl26 = New DevExpress.XtraEditors.TrackBarControl
            Me.trackBarControl25 = New DevExpress.XtraEditors.TrackBarControl
            Me.gaugeControl6 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.circularGauge6 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.arcScaleBackgroundLayerComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.arcScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.arcScaleNeedleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.layoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl7 = New DevExpress.XtraLayout.LayoutControl
            Me.statePageVal = New DevExpress.XtraEditors.TrackBarControl
            Me.gaugeControl7 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.circularGauge7 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.arcScaleBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.arcScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.arcScaleStateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
            Me.arcScaleNeedleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl
            Me.lblOrientation = New DevExpress.XtraEditors.ComboBoxEdit
            Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl
            Me.vertLblPos = New DevExpress.XtraEditors.TrackBarControl
            Me.horzLblPos = New DevExpress.XtraEditors.TrackBarControl
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.majorTickOffset, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.majorTickOffset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.minorTickOffset, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.minorTickOffset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rangeTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rangeTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleLabelsCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleLabelsCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleTextOrientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleTextExtentTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleTextExtentTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleValueTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleValueTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleEndAngleTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleEndAngleTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleStartAngleTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleStartAngleTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleTicksCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleTicksCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleRTrack, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scaleRTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage3.SuspendLayout()
            CType(Me.layoutControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl5.SuspendLayout()
            CType(Me.markerShape.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.markerOffset, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.markerOffset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl32, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl32.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl31, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl31.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl30, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl30.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl29, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl29.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem53, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage4.SuspendLayout()
            CType(Me.layoutControl6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl6.SuspendLayout()
            CType(Me.trackBarControl28, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl28.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl26, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl26.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl25, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl25.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage5.SuspendLayout()
            CType(Me.layoutControl7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl7.SuspendLayout()
            CType(Me.statePageVal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.statePageVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage6.SuspendLayout()
            CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType(Me.lblOrientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vertLblPos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vertLblPos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.horzLblPos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.horzLblPos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(801, 553)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage3, Me.xtraTabPage4, Me.xtraTabPage5, Me.xtraTabPage6})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.layoutControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Padding = New System.Windows.Forms.Padding(8)
            Me.xtraTabPage1.Size = New System.Drawing.Size(795, 525)
            Me.xtraTabPage1.Text = "Scale Features"
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.majorTickOffset)
            Me.layoutControl1.Controls.Add(Me.minorTickOffset)
            Me.layoutControl1.Controls.Add(Me.rangeTrack)
            Me.layoutControl1.Controls.Add(Me.scaleLabelsCount)
            Me.layoutControl1.Controls.Add(Me.scaleTextOrientation)
            Me.layoutControl1.Controls.Add(Me.scaleTextExtentTrack)
            Me.layoutControl1.Controls.Add(Me.scaleValueTrack)
            Me.layoutControl1.Controls.Add(Me.scaleEndAngleTrack)
            Me.layoutControl1.Controls.Add(Me.scaleStartAngleTrack)
            Me.layoutControl1.Controls.Add(Me.scaleRTrack)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Controls.Add(Me.scaleTicksCount)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem7})
            Me.layoutControl1.Location = New System.Drawing.Point(8, 8)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(779, 509)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            '
            'majorTickOffset
            '
            Me.majorTickOffset.EditValue = Nothing
            Me.majorTickOffset.Location = New System.Drawing.Point(544, 145)
            Me.majorTickOffset.MaximumSize = New System.Drawing.Size(0, 32)
            Me.majorTickOffset.MinimumSize = New System.Drawing.Size(0, 32)
            Me.majorTickOffset.Name = "majorTickOffset"
            Me.majorTickOffset.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.majorTickOffset.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.majorTickOffset.Properties.Maximum = 25
            Me.majorTickOffset.Properties.Minimum = -25
            Me.majorTickOffset.Properties.TickFrequency = 2
            Me.majorTickOffset.Size = New System.Drawing.Size(190, 32)
            Me.majorTickOffset.StyleController = Me.layoutControl1
            Me.majorTickOffset.TabIndex = 17
            Me.majorTickOffset.Value = -25
            '
            'minorTickOffset
            '
            Me.minorTickOffset.EditValue = Nothing
            Me.minorTickOffset.Location = New System.Drawing.Point(544, 196)
            Me.minorTickOffset.MaximumSize = New System.Drawing.Size(0, 32)
            Me.minorTickOffset.MinimumSize = New System.Drawing.Size(0, 32)
            Me.minorTickOffset.Name = "minorTickOffset"
            Me.minorTickOffset.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.minorTickOffset.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.minorTickOffset.Properties.Maximum = 25
            Me.minorTickOffset.Properties.Minimum = -25
            Me.minorTickOffset.Properties.TickFrequency = 2
            Me.minorTickOffset.Size = New System.Drawing.Size(190, 32)
            Me.minorTickOffset.StyleController = Me.layoutControl1
            Me.minorTickOffset.TabIndex = 16
            Me.minorTickOffset.Value = -25
            '
            'rangeTrack
            '
            Me.rangeTrack.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 0)
            Me.rangeTrack.Location = New System.Drawing.Point(77, 588)
            Me.rangeTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.rangeTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.rangeTrack.Name = "rangeTrack"
            Me.rangeTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.rangeTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rangeTrack.Properties.Maximum = 25
            Me.rangeTrack.Size = New System.Drawing.Size(318, 35)
            Me.rangeTrack.StyleController = Me.layoutControl1
            Me.rangeTrack.TabIndex = 15
            '
            'scaleLabelsCount
            '
            Me.scaleLabelsCount.EditValue = 6
            Me.scaleLabelsCount.Location = New System.Drawing.Point(544, 43)
            Me.scaleLabelsCount.MaximumSize = New System.Drawing.Size(0, 32)
            Me.scaleLabelsCount.MinimumSize = New System.Drawing.Size(0, 32)
            Me.scaleLabelsCount.Name = "scaleLabelsCount"
            Me.scaleLabelsCount.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.scaleLabelsCount.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.scaleLabelsCount.Properties.Maximum = 16
            Me.scaleLabelsCount.Properties.Minimum = 6
            Me.scaleLabelsCount.Size = New System.Drawing.Size(190, 32)
            Me.scaleLabelsCount.StyleController = Me.layoutControl1
            Me.scaleLabelsCount.TabIndex = 14
            Me.scaleLabelsCount.Value = 6
            '
            'scaleTextOrientation
            '
            Me.scaleTextOrientation.Location = New System.Drawing.Point(544, 310)
            Me.scaleTextOrientation.Name = "scaleTextOrientation"
            Me.scaleTextOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.scaleTextOrientation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.scaleTextOrientation.Size = New System.Drawing.Size(190, 20)
            Me.scaleTextOrientation.StyleController = Me.layoutControl1
            Me.scaleTextOrientation.TabIndex = 13
            '
            'scaleTextExtentTrack
            '
            Me.scaleTextExtentTrack.EditValue = Nothing
            Me.scaleTextExtentTrack.Location = New System.Drawing.Point(544, 340)
            Me.scaleTextExtentTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.scaleTextExtentTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.scaleTextExtentTrack.Name = "scaleTextExtentTrack"
            Me.scaleTextExtentTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.scaleTextExtentTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.scaleTextExtentTrack.Properties.Maximum = 50
            Me.scaleTextExtentTrack.Properties.Minimum = -20
            Me.scaleTextExtentTrack.Properties.TickFrequency = 5
            Me.scaleTextExtentTrack.Size = New System.Drawing.Size(190, 35)
            Me.scaleTextExtentTrack.StyleController = Me.layoutControl1
            Me.scaleTextExtentTrack.TabIndex = 12
            Me.scaleTextExtentTrack.Value = -20
            '
            'scaleValueTrack
            '
            Me.scaleValueTrack.EditValue = Nothing
            Me.scaleValueTrack.Location = New System.Drawing.Point(77, 537)
            Me.scaleValueTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.scaleValueTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.scaleValueTrack.Name = "scaleValueTrack"
            Me.scaleValueTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.scaleValueTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.scaleValueTrack.Properties.Maximum = 100
            Me.scaleValueTrack.Properties.TickFrequency = 5
            Me.scaleValueTrack.Size = New System.Drawing.Size(318, 35)
            Me.scaleValueTrack.StyleController = Me.layoutControl1
            Me.scaleValueTrack.TabIndex = 11
            '
            'scaleEndAngleTrack
            '
            Me.scaleEndAngleTrack.EditValue = Nothing
            Me.scaleEndAngleTrack.Location = New System.Drawing.Point(544, 564)
            Me.scaleEndAngleTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.scaleEndAngleTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.scaleEndAngleTrack.Name = "scaleEndAngleTrack"
            Me.scaleEndAngleTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.scaleEndAngleTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.scaleEndAngleTrack.Properties.Maximum = 360
            Me.scaleEndAngleTrack.Properties.TickFrequency = 10
            Me.scaleEndAngleTrack.Size = New System.Drawing.Size(190, 35)
            Me.scaleEndAngleTrack.StyleController = Me.layoutControl1
            Me.scaleEndAngleTrack.TabIndex = 10
            '
            'scaleStartAngleTrack
            '
            Me.scaleStartAngleTrack.EditValue = Nothing
            Me.scaleStartAngleTrack.Location = New System.Drawing.Point(544, 509)
            Me.scaleStartAngleTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.scaleStartAngleTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.scaleStartAngleTrack.Name = "scaleStartAngleTrack"
            Me.scaleStartAngleTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.scaleStartAngleTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.scaleStartAngleTrack.Properties.Maximum = 350
            Me.scaleStartAngleTrack.Properties.TickFrequency = 10
            Me.scaleStartAngleTrack.Size = New System.Drawing.Size(190, 35)
            Me.scaleStartAngleTrack.StyleController = Me.layoutControl1
            Me.scaleStartAngleTrack.TabIndex = 9
            '
            'scaleTicksCount
            '
            Me.scaleTicksCount.EditValue = 10
            Me.scaleTicksCount.Location = New System.Drawing.Point(544, 94)
            Me.scaleTicksCount.MaximumSize = New System.Drawing.Size(0, 32)
            Me.scaleTicksCount.MinimumSize = New System.Drawing.Size(0, 32)
            Me.scaleTicksCount.Name = "scaleTicksCount"
            Me.scaleTicksCount.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.scaleTicksCount.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.scaleTicksCount.Properties.Minimum = 1
            Me.scaleTicksCount.Size = New System.Drawing.Size(190, 32)
            Me.scaleTicksCount.StyleController = Me.layoutControl1
            Me.scaleTicksCount.TabIndex = 6
            Me.scaleTicksCount.Value = 10
            '
            'scaleRTrack
            '
            Me.scaleRTrack.EditValue = 75
            Me.scaleRTrack.Location = New System.Drawing.Point(544, 454)
            Me.scaleRTrack.MaximumSize = New System.Drawing.Size(0, 35)
            Me.scaleRTrack.MinimumSize = New System.Drawing.Size(0, 35)
            Me.scaleRTrack.Name = "scaleRTrack"
            Me.scaleRTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.scaleRTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.scaleRTrack.Properties.Maximum = 125
            Me.scaleRTrack.Properties.Minimum = 75
            Me.scaleRTrack.Properties.TickFrequency = 2
            Me.scaleRTrack.Size = New System.Drawing.Size(190, 35)
            Me.scaleRTrack.StyleController = Me.layoutControl1
            Me.scaleRTrack.TabIndex = 4
            Me.scaleRTrack.Value = 75
            '
            'gaugeControl1
            '
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(395, 529)
            Me.gaugeControl1.TabIndex = 0
            '
            'circularGauge1
            '
            Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1})
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 383, 517)
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1})
            '
            'arcScaleBackgroundLayerComponent1
            '
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1"
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style11
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'arcScaleComponent1
            '
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent1.EndAngle = 60.0!
            Me.arcScaleComponent1.MajorTickCount = 6
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F1}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -7.5!
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
            Me.arcScaleComponent1.MajorTickmark.TextOffset = -20.0!
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 10.0!
            Me.arcScaleComponent1.MinorTickCount = 3
            Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -4.0!
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
            Me.arcScaleComponent1.Name = "arcScaleComponent1"
            Me.arcScaleComponent1.RadiusX = 107.0!
            Me.arcScaleComponent1.RadiusY = 107.0!
            Me.arcScaleComponent1.StartAngle = -239.7!
            '
            'arcScaleNeedleComponent1
            '
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
            Me.arcScaleNeedleComponent1.StartOffset = -10.0!
            Me.arcScaleNeedleComponent1.ZOrder = -50
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 93)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 5, 3)
            Me.layoutControlItem6.Size = New System.Drawing.Size(360, 29)
            Me.layoutControlItem6.Text = "Major Tickmark Shape:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(109, 20)
            Me.layoutControlItem6.TextToControlDistance = 5
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 93)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 5)
            Me.layoutControlItem7.Size = New System.Drawing.Size(360, 29)
            Me.layoutControlItem7.Text = "Minor Tickmark Shape:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(109, 20)
            Me.layoutControlItem7.TextToControlDistance = 5
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup9, Me.layoutControlGroup10, Me.layoutControlGroup8, Me.layoutControlItem1, Me.layoutControlGroup11})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(762, 641)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(403, 631)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(359, 10)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlGroup9
            '
            Me.layoutControlGroup9.CustomizationFormText = "Text"
            Me.layoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem11, Me.layoutControlItem12})
            Me.layoutControlGroup9.Location = New System.Drawing.Point(403, 263)
            Me.layoutControlGroup9.Name = "layoutControlGroup9"
            Me.layoutControlGroup9.Size = New System.Drawing.Size(359, 144)
            Me.layoutControlGroup9.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutControlGroup9.Text = "Text"
            '
            'layoutControlItem11
            '
            Me.layoutControlItem11.Control = Me.scaleTextExtentTrack
            Me.layoutControlItem11.CustomizationFormText = "Labeled tickmark extent:"
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 35)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 5, 10)
            Me.layoutControlItem11.Size = New System.Drawing.Size(335, 60)
            Me.layoutControlItem11.Text = "Text Offset:"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem12
            '
            Me.layoutControlItem12.Control = Me.scaleTextOrientation
            Me.layoutControlItem12.CustomizationFormText = "Labeled tickmark text orientation:"
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 10, 5)
            Me.layoutControlItem12.Size = New System.Drawing.Size(335, 35)
            Me.layoutControlItem12.Text = "Text Orientation:"
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlGroup10
            '
            Me.layoutControlGroup10.CustomizationFormText = "Tickmarks"
            Me.layoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem42, Me.layoutControlItem5, Me.layoutControlItem4, Me.layoutControlItem43})
            Me.layoutControlGroup10.Location = New System.Drawing.Point(403, 0)
            Me.layoutControlGroup10.Name = "layoutControlGroup10"
            Me.layoutControlGroup10.Size = New System.Drawing.Size(359, 263)
            Me.layoutControlGroup10.Text = "Tickmarks"
            '
            'layoutControlItem42
            '
            Me.layoutControlItem42.Control = Me.scaleLabelsCount
            Me.layoutControlItem42.CustomizationFormText = "Labeled Tickmarks Count:"
            Me.layoutControlItem42.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem42.Name = "layoutControlItem42"
            Me.layoutControlItem42.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 12, 3)
            Me.layoutControlItem42.Size = New System.Drawing.Size(335, 60)
            Me.layoutControlItem42.Text = "Major Tickmark Count:"
            Me.layoutControlItem42.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.scaleTicksCount
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 60)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 3)
            Me.layoutControlItem5.Size = New System.Drawing.Size(335, 51)
            Me.layoutControlItem5.Text = "Minor Tickmark Count:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.minorTickOffset
            Me.layoutControlItem4.CustomizationFormText = "Minor Tickmark Offset:"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 162)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 10)
            Me.layoutControlItem4.Size = New System.Drawing.Size(335, 58)
            Me.layoutControlItem4.Text = "Minor Tickmark Offset:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem43
            '
            Me.layoutControlItem43.Control = Me.majorTickOffset
            Me.layoutControlItem43.CustomizationFormText = "Major Tickmark Offset:"
            Me.layoutControlItem43.Location = New System.Drawing.Point(0, 111)
            Me.layoutControlItem43.Name = "layoutControlItem43"
            Me.layoutControlItem43.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 3)
            Me.layoutControlItem43.Size = New System.Drawing.Size(335, 51)
            Me.layoutControlItem43.Text = "Major Tickmark Offset:"
            Me.layoutControlItem43.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlGroup8
            '
            Me.layoutControlGroup8.CustomizationFormText = "Geometry"
            Me.layoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem3})
            Me.layoutControlGroup8.Location = New System.Drawing.Point(403, 407)
            Me.layoutControlGroup8.Name = "layoutControlGroup8"
            Me.layoutControlGroup8.Size = New System.Drawing.Size(359, 224)
            Me.layoutControlGroup8.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutControlGroup8.Text = "Scale Geometry"
            '
            'layoutControlItem8
            '
            Me.layoutControlItem8.Control = Me.scaleStartAngleTrack
            Me.layoutControlItem8.CustomizationFormText = "Start angle:"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 60)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 5, 5)
            Me.layoutControlItem8.Size = New System.Drawing.Size(335, 55)
            Me.layoutControlItem8.Text = "Start Angle:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem9
            '
            Me.layoutControlItem9.Control = Me.scaleEndAngleTrack
            Me.layoutControlItem9.CustomizationFormText = "End angle:"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 115)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 5, 10)
            Me.layoutControlItem9.Size = New System.Drawing.Size(335, 60)
            Me.layoutControlItem9.Text = "End Angle:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.scaleRTrack
            Me.layoutControlItem3.CustomizationFormText = "RadiusX:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 10, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(335, 60)
            Me.layoutControlItem3.Text = "Radius:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(109, 13)
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 8, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(403, 529)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlGroup11
            '
            Me.layoutControlGroup11.AllowDrawBackground = False
            Me.layoutControlGroup11.CustomizationFormText = "layoutControlGroup11"
            Me.layoutControlGroup11.GroupBordersVisible = False
            Me.layoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem10, Me.layoutControlItem2})
            Me.layoutControlGroup11.Location = New System.Drawing.Point(0, 529)
            Me.layoutControlGroup11.Name = "layoutControlGroup11"
            Me.layoutControlGroup11.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal
            Me.layoutControlGroup11.Size = New System.Drawing.Size(403, 112)
            Me.layoutControlGroup11.Text = "layoutControlGroup11"
            '
            'layoutControlItem10
            '
            Me.layoutControlItem10.Control = Me.scaleValueTrack
            Me.layoutControlItem10.CustomizationFormText = "Value:"
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 8, 8, 3)
            Me.layoutControlItem10.Size = New System.Drawing.Size(403, 56)
            Me.layoutControlItem10.Text = "Value:"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(73, 13)
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.rangeTrack
            Me.layoutControlItem2.CustomizationFormText = "Min/Max Value:"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 56)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 8, 3, 8)
            Me.layoutControlItem2.Size = New System.Drawing.Size(403, 56)
            Me.layoutControlItem2.Text = "Min/Max Value:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(73, 13)
            '
            'xtraTabPage3
            '
            Me.xtraTabPage3.Controls.Add(Me.layoutControl5)
            Me.xtraTabPage3.Name = "xtraTabPage3"
            Me.xtraTabPage3.Size = New System.Drawing.Size(795, 525)
            Me.xtraTabPage3.Text = "Range Bar && Marker Features"
            '
            'layoutControl5
            '
            Me.layoutControl5.Controls.Add(Me.markerShape)
            Me.layoutControl5.Controls.Add(Me.markerOffset)
            Me.layoutControl5.Controls.Add(Me.trackBarControl32)
            Me.layoutControl5.Controls.Add(Me.trackBarControl31)
            Me.layoutControl5.Controls.Add(Me.trackBarControl30)
            Me.layoutControl5.Controls.Add(Me.trackBarControl29)
            Me.layoutControl5.Controls.Add(Me.gaugeControl5)
            Me.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl5.Name = "layoutControl5"
            Me.layoutControl5.Root = Me.layoutControlGroup5
            Me.layoutControl5.Size = New System.Drawing.Size(795, 525)
            Me.layoutControl5.TabIndex = 0
            Me.layoutControl5.Text = "layoutControl5"
            '
            'markerShape
            '
            Me.markerShape.Location = New System.Drawing.Point(559, 314)
            Me.markerShape.Name = "markerShape"
            Me.markerShape.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.markerShape.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.markerShape.Size = New System.Drawing.Size(220, 20)
            Me.markerShape.StyleController = Me.layoutControl5
            Me.markerShape.TabIndex = 9
            '
            'markerOffset
            '
            Me.markerOffset.EditValue = Nothing
            Me.markerOffset.Location = New System.Drawing.Point(559, 263)
            Me.markerOffset.MaximumSize = New System.Drawing.Size(0, 35)
            Me.markerOffset.MinimumSize = New System.Drawing.Size(0, 35)
            Me.markerOffset.Name = "markerOffset"
            Me.markerOffset.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.markerOffset.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.markerOffset.Properties.Maximum = 25
            Me.markerOffset.Properties.Minimum = -25
            Me.markerOffset.Properties.TickFrequency = 5
            Me.markerOffset.Size = New System.Drawing.Size(220, 35)
            Me.markerOffset.StyleController = Me.layoutControl5
            Me.markerOffset.TabIndex = 7
            Me.markerOffset.Value = -25
            '
            'trackBarControl32
            '
            Me.trackBarControl32.EditValue = 50
            Me.trackBarControl32.Location = New System.Drawing.Point(559, 20)
            Me.trackBarControl32.MaximumSize = New System.Drawing.Size(0, 35)
            Me.trackBarControl32.MinimumSize = New System.Drawing.Size(0, 35)
            Me.trackBarControl32.Name = "trackBarControl32"
            Me.trackBarControl32.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl32.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl32.Properties.Maximum = 100
            Me.trackBarControl32.Properties.TickFrequency = 10
            Me.trackBarControl32.Size = New System.Drawing.Size(220, 35)
            Me.trackBarControl32.StyleController = Me.layoutControl5
            Me.trackBarControl32.TabIndex = 8
            Me.trackBarControl32.Value = 50
            '
            'trackBarControl31
            '
            Me.trackBarControl31.EditValue = Nothing
            Me.trackBarControl31.Location = New System.Drawing.Point(559, 88)
            Me.trackBarControl31.MaximumSize = New System.Drawing.Size(0, 35)
            Me.trackBarControl31.MinimumSize = New System.Drawing.Size(0, 35)
            Me.trackBarControl31.Name = "trackBarControl31"
            Me.trackBarControl31.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl31.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl31.Properties.Maximum = 100
            Me.trackBarControl31.Properties.TickFrequency = 10
            Me.trackBarControl31.Size = New System.Drawing.Size(220, 35)
            Me.trackBarControl31.StyleController = Me.layoutControl5
            Me.trackBarControl31.TabIndex = 7
            '
            'trackBarControl30
            '
            Me.trackBarControl30.EditValue = Nothing
            Me.trackBarControl30.Location = New System.Drawing.Point(559, 190)
            Me.trackBarControl30.MaximumSize = New System.Drawing.Size(0, 35)
            Me.trackBarControl30.MinimumSize = New System.Drawing.Size(0, 35)
            Me.trackBarControl30.Name = "trackBarControl30"
            Me.trackBarControl30.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl30.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl30.Properties.Maximum = 40
            Me.trackBarControl30.Properties.Minimum = -10
            Me.trackBarControl30.Properties.TickFrequency = 5
            Me.trackBarControl30.Size = New System.Drawing.Size(220, 35)
            Me.trackBarControl30.StyleController = Me.layoutControl5
            Me.trackBarControl30.TabIndex = 6
            Me.trackBarControl30.Value = -10
            '
            'trackBarControl29
            '
            Me.trackBarControl29.EditValue = Nothing
            Me.trackBarControl29.Location = New System.Drawing.Point(559, 139)
            Me.trackBarControl29.MaximumSize = New System.Drawing.Size(0, 35)
            Me.trackBarControl29.MinimumSize = New System.Drawing.Size(0, 35)
            Me.trackBarControl29.Name = "trackBarControl29"
            Me.trackBarControl29.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl29.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl29.Properties.Maximum = 100
            Me.trackBarControl29.Properties.TickFrequency = 10
            Me.trackBarControl29.Size = New System.Drawing.Size(220, 35)
            Me.trackBarControl29.StyleController = Me.layoutControl5
            Me.trackBarControl29.TabIndex = 6
            '
            'gaugeControl5
            '
            Me.gaugeControl5.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge5})
            Me.gaugeControl5.Location = New System.Drawing.Point(8, 8)
            Me.gaugeControl5.Name = "gaugeControl5"
            Me.gaugeControl5.Size = New System.Drawing.Size(452, 509)
            Me.gaugeControl5.TabIndex = 4
            '
            'circularGauge5
            '
            Me.circularGauge5.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent5})
            Me.circularGauge5.Bounds = New System.Drawing.Rectangle(6, 6, 440, 497)
            Me.circularGauge5.Markers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent() {Me.arcScaleMarkerComponent1})
            Me.circularGauge5.Name = "circularGauge5"
            Me.circularGauge5.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.arcScaleRangeBarComponent1})
            Me.circularGauge5.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent5})
            '
            'arcScaleBackgroundLayerComponent5
            '
            Me.arcScaleBackgroundLayerComponent5.ArcScale = Me.arcScaleComponent5
            Me.arcScaleBackgroundLayerComponent5.Name = "arcScaleBackgroundLayerComponent5"
            Me.arcScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style11
            Me.arcScaleBackgroundLayerComponent5.ZOrder = 1000
            '
            'arcScaleComponent5
            '
            Me.arcScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent5.EndAngle = 60.0!
            Me.arcScaleComponent5.MajorTickCount = 6
            Me.arcScaleComponent5.MajorTickmark.FormatString = "{0:F1}"
            Me.arcScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
            Me.arcScaleComponent5.MajorTickmark.TextOffset = -20.0!
            Me.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent5.MaxValue = 10.0!
            Me.arcScaleComponent5.MinorTickCount = 3
            Me.arcScaleComponent5.MinorTickmark.ShapeOffset = 3.0!
            Me.arcScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
            Me.arcScaleComponent5.Name = "arcScaleComponent5"
            Me.arcScaleComponent5.StartAngle = -240.0!
            Me.arcScaleComponent5.Value = 5.0!
            '
            'arcScaleMarkerComponent1
            '
            Me.arcScaleMarkerComponent1.ArcScale = Me.arcScaleComponent5
            Me.arcScaleMarkerComponent1.Name = "arcScaleMarkerComponent1"
            Me.arcScaleMarkerComponent1.ZOrder = -100
            '
            'arcScaleRangeBarComponent1
            '
            Me.arcScaleRangeBarComponent1.AppearanceRangeBar.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#8080FF")
            Me.arcScaleRangeBarComponent1.AppearanceRangeBar.BorderWidth = 1.0!
            Me.arcScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.LinearGradientBrushObject("Geometry[Start:0, 0;End:10, 10] Colors[Start:;End:#8080FF]")
            Me.arcScaleRangeBarComponent1.ArcScale = Me.arcScaleComponent5
            Me.arcScaleRangeBarComponent1.EndOffset = 35.0!
            Me.arcScaleRangeBarComponent1.Name = "arcScaleRangeBarComponent1"
            Me.arcScaleRangeBarComponent1.StartOffset = 50.0!
            Me.arcScaleRangeBarComponent1.ZOrder = -10
            '
            'layoutControlGroup5
            '
            Me.layoutControlGroup5.AllowDrawBackground = False
            Me.layoutControlGroup5.CustomizationFormText = "layoutControlGroup5"
            Me.layoutControlGroup5.GroupBordersVisible = False
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem41, Me.layoutControlItem53, Me.emptySpaceItem5, Me.layoutControlItem54, Me.layoutControlItem52, Me.layoutControlItem51, Me.layoutControlItem18, Me.layoutControlItem19})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(795, 525)
            Me.layoutControlGroup5.Text = "layoutControlGroup5"
            Me.layoutControlGroup5.TextVisible = False
            '
            'layoutControlItem41
            '
            Me.layoutControlItem41.Control = Me.gaugeControl5
            Me.layoutControlItem41.CustomizationFormText = "layoutControlItem41"
            Me.layoutControlItem41.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem41.Name = "layoutControlItem41"
            Me.layoutControlItem41.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8)
            Me.layoutControlItem41.Size = New System.Drawing.Size(468, 525)
            Me.layoutControlItem41.Text = "layoutControlItem41"
            Me.layoutControlItem41.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem41.TextToControlDistance = 0
            Me.layoutControlItem41.TextVisible = False
            '
            'layoutControlItem53
            '
            Me.layoutControlItem53.Control = Me.trackBarControl31
            Me.layoutControlItem53.CustomizationFormText = "Start Value:"
            Me.layoutControlItem53.Location = New System.Drawing.Point(468, 68)
            Me.layoutControlItem53.Name = "layoutControlItem53"
            Me.layoutControlItem53.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 20, 3)
            Me.layoutControlItem53.Size = New System.Drawing.Size(327, 68)
            Me.layoutControlItem53.Text = "Anchor Value:"
            Me.layoutControlItem53.TextSize = New System.Drawing.Size(71, 13)
            '
            'emptySpaceItem5
            '
            Me.emptySpaceItem5.AllowHotTrack = False
            Me.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5"
            Me.emptySpaceItem5.Location = New System.Drawing.Point(468, 337)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(327, 188)
            Me.emptySpaceItem5.Text = "emptySpaceItem5"
            Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem54
            '
            Me.layoutControlItem54.Control = Me.trackBarControl32
            Me.layoutControlItem54.CustomizationFormText = "Value:"
            Me.layoutControlItem54.Location = New System.Drawing.Point(468, 0)
            Me.layoutControlItem54.Name = "layoutControlItem54"
            Me.layoutControlItem54.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 20, 3)
            Me.layoutControlItem54.Size = New System.Drawing.Size(327, 68)
            Me.layoutControlItem54.Text = "Value:"
            Me.layoutControlItem54.TextSize = New System.Drawing.Size(71, 13)
            '
            'layoutControlItem52
            '
            Me.layoutControlItem52.Control = Me.trackBarControl30
            Me.layoutControlItem52.CustomizationFormText = "End Extent:"
            Me.layoutControlItem52.Location = New System.Drawing.Point(468, 187)
            Me.layoutControlItem52.Name = "layoutControlItem52"
            Me.layoutControlItem52.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 8)
            Me.layoutControlItem52.Size = New System.Drawing.Size(327, 56)
            Me.layoutControlItem52.Text = "End Offset:"
            Me.layoutControlItem52.TextSize = New System.Drawing.Size(71, 13)
            '
            'layoutControlItem51
            '
            Me.layoutControlItem51.Control = Me.trackBarControl29
            Me.layoutControlItem51.CustomizationFormText = "Start Extent:"
            Me.layoutControlItem51.Location = New System.Drawing.Point(468, 136)
            Me.layoutControlItem51.Name = "layoutControlItem51"
            Me.layoutControlItem51.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 3)
            Me.layoutControlItem51.Size = New System.Drawing.Size(327, 51)
            Me.layoutControlItem51.Text = "Start Offset:"
            Me.layoutControlItem51.TextSize = New System.Drawing.Size(71, 13)
            '
            'layoutControlItem18
            '
            Me.layoutControlItem18.Control = Me.markerOffset
            Me.layoutControlItem18.CustomizationFormText = "Marker Offset:"
            Me.layoutControlItem18.Location = New System.Drawing.Point(468, 243)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 20, 3)
            Me.layoutControlItem18.Size = New System.Drawing.Size(327, 68)
            Me.layoutControlItem18.Text = "Marker Offset:"
            Me.layoutControlItem18.TextSize = New System.Drawing.Size(71, 13)
            '
            'layoutControlItem19
            '
            Me.layoutControlItem19.Control = Me.markerShape
            Me.layoutControlItem19.CustomizationFormText = "Marker Shape:"
            Me.layoutControlItem19.Location = New System.Drawing.Point(468, 311)
            Me.layoutControlItem19.Name = "layoutControlItem19"
            Me.layoutControlItem19.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 3)
            Me.layoutControlItem19.Size = New System.Drawing.Size(327, 26)
            Me.layoutControlItem19.Text = "Marker Shape:"
            Me.layoutControlItem19.TextSize = New System.Drawing.Size(71, 13)
            '
            'xtraTabPage4
            '
            Me.xtraTabPage4.Controls.Add(Me.layoutControl6)
            Me.xtraTabPage4.Name = "xtraTabPage4"
            Me.xtraTabPage4.Size = New System.Drawing.Size(795, 525)
            Me.xtraTabPage4.Text = "Needle Features"
            '
            'layoutControl6
            '
            Me.layoutControl6.Controls.Add(Me.trackBarControl28)
            Me.layoutControl6.Controls.Add(Me.trackBarControl26)
            Me.layoutControl6.Controls.Add(Me.trackBarControl25)
            Me.layoutControl6.Controls.Add(Me.gaugeControl6)
            Me.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl6.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem45})
            Me.layoutControl6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl6.Name = "layoutControl6"
            Me.layoutControl6.Root = Me.layoutControlGroup6
            Me.layoutControl6.Size = New System.Drawing.Size(795, 525)
            Me.layoutControl6.TabIndex = 0
            Me.layoutControl6.Text = "layoutControl6"
            '
            'trackBarControl28
            '
            Me.trackBarControl28.EditValue = Nothing
            Me.trackBarControl28.Location = New System.Drawing.Point(615, 12)
            Me.trackBarControl28.MaximumSize = New System.Drawing.Size(0, 30)
            Me.trackBarControl28.MinimumSize = New System.Drawing.Size(150, 30)
            Me.trackBarControl28.Name = "trackBarControl28"
            Me.trackBarControl28.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl28.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl28.Size = New System.Drawing.Size(168, 30)
            Me.trackBarControl28.StyleController = Me.layoutControl6
            Me.trackBarControl28.TabIndex = 11
            '
            'trackBarControl26
            '
            Me.trackBarControl26.EditValue = Nothing
            Me.trackBarControl26.Location = New System.Drawing.Point(615, 127)
            Me.trackBarControl26.MaximumSize = New System.Drawing.Size(0, 30)
            Me.trackBarControl26.MinimumSize = New System.Drawing.Size(150, 30)
            Me.trackBarControl26.Name = "trackBarControl26"
            Me.trackBarControl26.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl26.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl26.Properties.Maximum = 50
            Me.trackBarControl26.Properties.Minimum = -50
            Me.trackBarControl26.Properties.TickFrequency = 10
            Me.trackBarControl26.Size = New System.Drawing.Size(168, 30)
            Me.trackBarControl26.StyleController = Me.layoutControl6
            Me.trackBarControl26.TabIndex = 10
            Me.trackBarControl26.Value = -50
            '
            'trackBarControl25
            '
            Me.trackBarControl25.EditValue = Nothing
            Me.trackBarControl25.Location = New System.Drawing.Point(615, 76)
            Me.trackBarControl25.MaximumSize = New System.Drawing.Size(0, 30)
            Me.trackBarControl25.MinimumSize = New System.Drawing.Size(150, 30)
            Me.trackBarControl25.Name = "trackBarControl25"
            Me.trackBarControl25.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl25.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl25.Properties.Maximum = 50
            Me.trackBarControl25.Properties.Minimum = -50
            Me.trackBarControl25.Properties.TickFrequency = 10
            Me.trackBarControl25.Size = New System.Drawing.Size(168, 30)
            Me.trackBarControl25.StyleController = Me.layoutControl6
            Me.trackBarControl25.TabIndex = 9
            Me.trackBarControl25.Value = -50
            '
            'gaugeControl6
            '
            Me.gaugeControl6.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge6})
            Me.gaugeControl6.Location = New System.Drawing.Point(8, 8)
            Me.gaugeControl6.Name = "gaugeControl6"
            Me.gaugeControl6.Size = New System.Drawing.Size(524, 509)
            Me.gaugeControl6.TabIndex = 4
            '
            'circularGauge6
            '
            Me.circularGauge6.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent8})
            Me.circularGauge6.Bounds = New System.Drawing.Rectangle(6, 6, 512, 497)
            Me.circularGauge6.Name = "circularGauge6"
            Me.circularGauge6.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent6})
            Me.circularGauge6.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent6})
            '
            'arcScaleBackgroundLayerComponent8
            '
            Me.arcScaleBackgroundLayerComponent8.ArcScale = Me.arcScaleComponent6
            Me.arcScaleBackgroundLayerComponent8.Name = "arcScaleBackgroundLayerComponent8"
            Me.arcScaleBackgroundLayerComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style11
            Me.arcScaleBackgroundLayerComponent8.ZOrder = 1000
            '
            'arcScaleComponent6
            '
            Me.arcScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent6.EndAngle = 60.0!
            Me.arcScaleComponent6.MajorTickCount = 6
            Me.arcScaleComponent6.MajorTickmark.FormatString = "{0:F1}"
            Me.arcScaleComponent6.MajorTickmark.ShapeOffset = -4.0!
            Me.arcScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
            Me.arcScaleComponent6.MajorTickmark.TextOffset = -20.0!
            Me.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent6.MaxValue = 10.0!
            Me.arcScaleComponent6.MinorTickCount = 3
            Me.arcScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
            Me.arcScaleComponent6.Name = "arcScaleComponent6"
            Me.arcScaleComponent6.RadiusX = 103.0!
            Me.arcScaleComponent6.RadiusY = 103.0!
            Me.arcScaleComponent6.StartAngle = -240.0!
            '
            'arcScaleNeedleComponent6
            '
            Me.arcScaleNeedleComponent6.ArcScale = Me.arcScaleComponent6
            Me.arcScaleNeedleComponent6.Name = "arcScaleNeedleComponent6"
            Me.arcScaleNeedleComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
            Me.arcScaleNeedleComponent6.StartOffset = -9.5!
            Me.arcScaleNeedleComponent6.ZOrder = -50
            '
            'layoutControlItem45
            '
            Me.layoutControlItem45.CustomizationFormText = "Needle type:"
            Me.layoutControlItem45.Location = New System.Drawing.Point(518, 0)
            Me.layoutControlItem45.Name = "layoutControlItem45"
            Me.layoutControlItem45.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 20, 5)
            Me.layoutControlItem45.Size = New System.Drawing.Size(254, 46)
            Me.layoutControlItem45.Text = "Needle Shape:"
            Me.layoutControlItem45.TextSize = New System.Drawing.Size(70, 20)
            Me.layoutControlItem45.TextToControlDistance = 5
            '
            'layoutControlGroup6
            '
            Me.layoutControlGroup6.AllowDrawBackground = False
            Me.layoutControlGroup6.CustomizationFormText = "layoutControlGroup6"
            Me.layoutControlGroup6.GroupBordersVisible = False
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem44, Me.layoutControlItem49, Me.layoutControlItem47, Me.layoutControlItem46})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup6.Name = "Root"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(795, 525)
            Me.layoutControlGroup6.Text = "Root"
            Me.layoutControlGroup6.TextVisible = False
            '
            'layoutControlItem44
            '
            Me.layoutControlItem44.Control = Me.gaugeControl6
            Me.layoutControlItem44.CustomizationFormText = "layoutControlItem44"
            Me.layoutControlItem44.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem44.Name = "layoutControlItem44"
            Me.layoutControlItem44.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 1, 8, 8)
            Me.layoutControlItem44.Size = New System.Drawing.Size(533, 525)
            Me.layoutControlItem44.Text = "layoutControlItem44"
            Me.layoutControlItem44.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem44.TextToControlDistance = 0
            Me.layoutControlItem44.TextVisible = False
            '
            'layoutControlItem49
            '
            Me.layoutControlItem49.Control = Me.trackBarControl28
            Me.layoutControlItem49.CustomizationFormText = "Value:"
            Me.layoutControlItem49.Location = New System.Drawing.Point(533, 0)
            Me.layoutControlItem49.Name = "layoutControlItem49"
            Me.layoutControlItem49.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 12, 16)
            Me.layoutControlItem49.Size = New System.Drawing.Size(262, 73)
            Me.layoutControlItem49.Text = "Value:"
            Me.layoutControlItem49.TextSize = New System.Drawing.Size(62, 13)
            '
            'layoutControlItem47
            '
            Me.layoutControlItem47.Control = Me.trackBarControl26
            Me.layoutControlItem47.CustomizationFormText = "End extent:"
            Me.layoutControlItem47.Location = New System.Drawing.Point(533, 124)
            Me.layoutControlItem47.Name = "layoutControlItem47"
            Me.layoutControlItem47.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 3, 3)
            Me.layoutControlItem47.Size = New System.Drawing.Size(262, 401)
            Me.layoutControlItem47.Text = "End Offset:"
            Me.layoutControlItem47.TextSize = New System.Drawing.Size(62, 13)
            '
            'layoutControlItem46
            '
            Me.layoutControlItem46.Control = Me.trackBarControl25
            Me.layoutControlItem46.CustomizationFormText = "Start Extent:"
            Me.layoutControlItem46.Location = New System.Drawing.Point(533, 73)
            Me.layoutControlItem46.Name = "layoutControlItem46"
            Me.layoutControlItem46.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 3, 3)
            Me.layoutControlItem46.Size = New System.Drawing.Size(262, 51)
            Me.layoutControlItem46.Text = "Start Offset:"
            Me.layoutControlItem46.TextSize = New System.Drawing.Size(62, 13)
            '
            'xtraTabPage5
            '
            Me.xtraTabPage5.Controls.Add(Me.layoutControl7)
            Me.xtraTabPage5.Name = "xtraTabPage5"
            Me.xtraTabPage5.Size = New System.Drawing.Size(795, 525)
            Me.xtraTabPage5.Text = "State Indicator Features"
            '
            'layoutControl7
            '
            Me.layoutControl7.Controls.Add(Me.statePageVal)
            Me.layoutControl7.Controls.Add(Me.gaugeControl7)
            Me.layoutControl7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl7.Name = "layoutControl7"
            Me.layoutControl7.Root = Me.layoutControlGroup7
            Me.layoutControl7.Size = New System.Drawing.Size(795, 525)
            Me.layoutControl7.TabIndex = 0
            Me.layoutControl7.Text = "layoutControl7"
            '
            'statePageVal
            '
            Me.statePageVal.EditValue = Nothing
            Me.statePageVal.Location = New System.Drawing.Point(742, 24)
            Me.statePageVal.MaximumSize = New System.Drawing.Size(30, 0)
            Me.statePageVal.MinimumSize = New System.Drawing.Size(30, 0)
            Me.statePageVal.Name = "statePageVal"
            Me.statePageVal.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.statePageVal.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.statePageVal.Properties.Maximum = 100
            Me.statePageVal.Properties.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.statePageVal.Properties.TickFrequency = 5
            Me.statePageVal.Properties.TickStyle = System.Windows.Forms.TickStyle.Both
            Me.statePageVal.Size = New System.Drawing.Size(30, 493)
            Me.statePageVal.StyleController = Me.layoutControl7
            Me.statePageVal.TabIndex = 6
            '
            'gaugeControl7
            '
            Me.gaugeControl7.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge7})
            Me.gaugeControl7.Location = New System.Drawing.Point(8, 8)
            Me.gaugeControl7.Name = "gaugeControl7"
            Me.gaugeControl7.Size = New System.Drawing.Size(726, 509)
            Me.gaugeControl7.TabIndex = 4
            '
            'circularGauge7
            '
            Me.circularGauge7.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent6})
            Me.circularGauge7.Bounds = New System.Drawing.Rectangle(6, 6, 714, 497)
            Me.circularGauge7.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent1})
            Me.circularGauge7.Name = "circularGauge7"
            Me.circularGauge7.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent7})
            Me.circularGauge7.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent7})
            '
            'arcScaleBackgroundLayerComponent6
            '
            Me.arcScaleBackgroundLayerComponent6.ArcScale = Me.arcScaleComponent7
            Me.arcScaleBackgroundLayerComponent6.Name = "arcScaleBackgroundLayerComponent6"
            Me.arcScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style11
            Me.arcScaleBackgroundLayerComponent6.ZOrder = 1000
            '
            'arcScaleComponent7
            '
            Me.arcScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent7.EndAngle = 60.0!
            Me.arcScaleComponent7.MajorTickCount = 6
            Me.arcScaleComponent7.MajorTickmark.FormatString = "{0:F1}"
            Me.arcScaleComponent7.MajorTickmark.ShapeOffset = -0.8!
            Me.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
            Me.arcScaleComponent7.MajorTickmark.TextOffset = -17.0!
            Me.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent7.MinorTickCount = 3
            Me.arcScaleComponent7.MinorTickmark.ShapeOffset = 3.0!
            Me.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
            Me.arcScaleComponent7.Name = "arcScaleComponent7"
            Me.arcScaleComponent7.StartAngle = -240.0!
            '
            'arcScaleStateIndicatorComponent1
            '
            Me.arcScaleStateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 190.0!)
            Me.arcScaleStateIndicatorComponent1.IndicatorScale = Me.arcScaleComponent7
            Me.arcScaleStateIndicatorComponent1.Name = "arcScaleStateIndicatorComponent1"
            Me.arcScaleStateIndicatorComponent1.Size = New System.Drawing.SizeF(25.0!, 25.0!)
            ScaleIndicatorState13.IntervalLength = 0.15!
            ScaleIndicatorState13.Name = "Default"
            ScaleIndicatorState13.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile1
            ScaleIndicatorState14.IntervalLength = 0.15!
            ScaleIndicatorState14.Name = "State1"
            ScaleIndicatorState14.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile2
            ScaleIndicatorState14.StartValue = 0.15!
            ScaleIndicatorState15.IntervalLength = 0.15!
            ScaleIndicatorState15.Name = "State2"
            ScaleIndicatorState15.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile3
            ScaleIndicatorState15.StartValue = 0.3!
            ScaleIndicatorState16.IntervalLength = 0.15!
            ScaleIndicatorState16.Name = "State3"
            ScaleIndicatorState16.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile4
            ScaleIndicatorState16.StartValue = 0.45!
            ScaleIndicatorState17.IntervalLength = 0.12!
            ScaleIndicatorState17.Name = "State4"
            ScaleIndicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Smile5
            ScaleIndicatorState17.StartValue = 0.6!
            ScaleIndicatorState18.IntervalLength = 0.28!
            ScaleIndicatorState18.Name = "State5"
            ScaleIndicatorState18.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2
            ScaleIndicatorState18.StartValue = 0.72!
            Me.arcScaleStateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState13, ScaleIndicatorState14, ScaleIndicatorState15, ScaleIndicatorState16, ScaleIndicatorState17, ScaleIndicatorState18})
            Me.arcScaleStateIndicatorComponent1.ZOrder = -100
            '
            'arcScaleNeedleComponent7
            '
            Me.arcScaleNeedleComponent7.ArcScale = Me.arcScaleComponent7
            Me.arcScaleNeedleComponent7.Name = "arcScaleNeedleComponent7"
            Me.arcScaleNeedleComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
            Me.arcScaleNeedleComponent7.StartOffset = -9.5!
            Me.arcScaleNeedleComponent7.ZOrder = -50
            '
            'layoutControlGroup7
            '
            Me.layoutControlGroup7.AllowDrawBackground = False
            Me.layoutControlGroup7.CustomizationFormText = "layoutControlGroup7"
            Me.layoutControlGroup7.GroupBordersVisible = False
            Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem48, Me.layoutControlItem50})
            Me.layoutControlGroup7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup7.Name = "layoutControlGroup7"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(795, 525)
            Me.layoutControlGroup7.Text = "layoutControlGroup7"
            Me.layoutControlGroup7.TextVisible = False
            '
            'layoutControlItem48
            '
            Me.layoutControlItem48.Control = Me.gaugeControl7
            Me.layoutControlItem48.CustomizationFormText = "layoutControlItem48"
            Me.layoutControlItem48.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem48.Name = "layoutControlItem48"
            Me.layoutControlItem48.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8)
            Me.layoutControlItem48.Size = New System.Drawing.Size(742, 525)
            Me.layoutControlItem48.Text = "layoutControlItem48"
            Me.layoutControlItem48.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem48.TextToControlDistance = 0
            Me.layoutControlItem48.TextVisible = False
            '
            'layoutControlItem50
            '
            Me.layoutControlItem50.Control = Me.statePageVal
            Me.layoutControlItem50.CustomizationFormText = "Value:"
            Me.layoutControlItem50.Location = New System.Drawing.Point(742, 0)
            Me.layoutControlItem50.Name = "layoutControlItem50"
            Me.layoutControlItem50.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 8, 8, 8)
            Me.layoutControlItem50.Size = New System.Drawing.Size(53, 525)
            Me.layoutControlItem50.Text = "Value:"
            Me.layoutControlItem50.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem50.TextSize = New System.Drawing.Size(30, 13)
            '
            'xtraTabPage6
            '
            Me.xtraTabPage6.Controls.Add(Me.layoutControl2)
            Me.xtraTabPage6.Name = "xtraTabPage6"
            Me.xtraTabPage6.Size = New System.Drawing.Size(795, 525)
            Me.xtraTabPage6.Text = "Label Features"
            '
            'layoutControl2
            '
            Me.layoutControl2.Controls.Add(Me.lblOrientation)
            Me.layoutControl2.Controls.Add(Me.trackBarControl1)
            Me.layoutControl2.Controls.Add(Me.vertLblPos)
            Me.layoutControl2.Controls.Add(Me.horzLblPos)
            Me.layoutControl2.Controls.Add(Me.gaugeControl2)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem13})
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.Root = Me.layoutControlGroup2
            Me.layoutControl2.Size = New System.Drawing.Size(795, 525)
            Me.layoutControl2.TabIndex = 1
            Me.layoutControl2.Text = "layoutControl2"
            '
            'lblOrientation
            '
            Me.lblOrientation.Location = New System.Drawing.Point(602, 178)
            Me.lblOrientation.Name = "lblOrientation"
            Me.lblOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lblOrientation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.lblOrientation.Size = New System.Drawing.Size(181, 20)
            Me.lblOrientation.StyleController = Me.layoutControl2
            Me.lblOrientation.TabIndex = 12
            '
            'trackBarControl1
            '
            Me.trackBarControl1.EditValue = Nothing
            Me.trackBarControl1.Location = New System.Drawing.Point(602, 12)
            Me.trackBarControl1.MaximumSize = New System.Drawing.Size(0, 30)
            Me.trackBarControl1.MinimumSize = New System.Drawing.Size(150, 30)
            Me.trackBarControl1.Name = "trackBarControl1"
            Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl1.Properties.Maximum = 50
            Me.trackBarControl1.Properties.TickFrequency = 5
            Me.trackBarControl1.Size = New System.Drawing.Size(181, 30)
            Me.trackBarControl1.StyleController = Me.layoutControl2
            Me.trackBarControl1.TabIndex = 11
            '
            'vertLblPos
            '
            Me.vertLblPos.EditValue = 50
            Me.vertLblPos.Location = New System.Drawing.Point(602, 127)
            Me.vertLblPos.MaximumSize = New System.Drawing.Size(0, 30)
            Me.vertLblPos.MinimumSize = New System.Drawing.Size(150, 30)
            Me.vertLblPos.Name = "vertLblPos"
            Me.vertLblPos.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.vertLblPos.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.vertLblPos.Properties.Maximum = 200
            Me.vertLblPos.Properties.Minimum = 50
            Me.vertLblPos.Properties.TickFrequency = 10
            Me.vertLblPos.Size = New System.Drawing.Size(181, 30)
            Me.vertLblPos.StyleController = Me.layoutControl2
            Me.vertLblPos.TabIndex = 10
            Me.vertLblPos.Value = 50
            '
            'horzLblPos
            '
            Me.horzLblPos.EditValue = 50
            Me.horzLblPos.Location = New System.Drawing.Point(602, 76)
            Me.horzLblPos.MaximumSize = New System.Drawing.Size(0, 30)
            Me.horzLblPos.MinimumSize = New System.Drawing.Size(150, 30)
            Me.horzLblPos.Name = "horzLblPos"
            Me.horzLblPos.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.horzLblPos.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.horzLblPos.Properties.Maximum = 200
            Me.horzLblPos.Properties.Minimum = 50
            Me.horzLblPos.Properties.TickFrequency = 10
            Me.horzLblPos.Size = New System.Drawing.Size(181, 30)
            Me.horzLblPos.StyleController = Me.layoutControl2
            Me.horzLblPos.TabIndex = 9
            Me.horzLblPos.Value = 50
            '
            'gaugeControl2
            '
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge2})
            Me.gaugeControl2.Location = New System.Drawing.Point(8, 8)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.Size = New System.Drawing.Size(515, 509)
            Me.gaugeControl2.TabIndex = 4
            '
            'circularGauge2
            '
            Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent2})
            Me.circularGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 503, 497)
            Me.circularGauge2.Name = "circularGauge2"
            Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent2})
            Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent2})
            '
            'arcScaleBackgroundLayerComponent2
            '
            Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleBackgroundLayerComponent2.Name = "arcScaleBackgroundLayerComponent2"
            Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style11
            Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
            '
            'arcScaleComponent2
            '
            Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent2.EndAngle = 60.0!
            ScaleLabel3.AppearanceBackground.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:infotext")
            ScaleLabel3.AppearanceBackground.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:infobackground")
            ScaleLabel3.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ScaleLabel3.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:infotext")
            ScaleLabel3.Name = "Label0"
            ScaleLabel3.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 100.0!)
            ScaleLabel3.Size = New System.Drawing.SizeF(65.0!, 20.0!)
            Me.arcScaleComponent2.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel3})
            Me.arcScaleComponent2.MajorTickCount = 6
            Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F1}"
            Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -4.0!
            Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4
            Me.arcScaleComponent2.MajorTickmark.TextOffset = -20.0!
            Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent2.MaxValue = 10.0!
            Me.arcScaleComponent2.MinorTickCount = 3
            Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3
            Me.arcScaleComponent2.Name = "arcScaleComponent2"
            Me.arcScaleComponent2.RadiusX = 103.0!
            Me.arcScaleComponent2.RadiusY = 103.0!
            Me.arcScaleComponent2.StartAngle = -240.0!
            '
            'arcScaleNeedleComponent2
            '
            Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleNeedleComponent2.Name = "arcScaleNeedleComponent2"
            Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
            Me.arcScaleNeedleComponent2.StartOffset = -9.5!
            Me.arcScaleNeedleComponent2.ZOrder = -50
            '
            'layoutControlItem13
            '
            Me.layoutControlItem13.CustomizationFormText = "Needle type:"
            Me.layoutControlItem13.Location = New System.Drawing.Point(518, 0)
            Me.layoutControlItem13.Name = "layoutControlItem45"
            Me.layoutControlItem13.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 20, 5)
            Me.layoutControlItem13.Size = New System.Drawing.Size(254, 46)
            Me.layoutControlItem13.Text = "Needle Shape:"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(70, 20)
            Me.layoutControlItem13.TextToControlDistance = 5
            '
            'layoutControlGroup2
            '
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup6"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem14, Me.layoutControlItem15, Me.layoutControlItem16, Me.layoutControlItem17, Me.layoutControlItem20})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "Root"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(795, 525)
            Me.layoutControlGroup2.Text = "Root"
            Me.layoutControlGroup2.TextVisible = False
            '
            'layoutControlItem14
            '
            Me.layoutControlItem14.Control = Me.gaugeControl2
            Me.layoutControlItem14.CustomizationFormText = "layoutControlItem44"
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem14.Name = "layoutControlItem44"
            Me.layoutControlItem14.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 1, 8, 8)
            Me.layoutControlItem14.Size = New System.Drawing.Size(524, 525)
            Me.layoutControlItem14.Text = "layoutControlItem44"
            Me.layoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem14.TextToControlDistance = 0
            Me.layoutControlItem14.TextVisible = False
            '
            'layoutControlItem15
            '
            Me.layoutControlItem15.Control = Me.trackBarControl1
            Me.layoutControlItem15.CustomizationFormText = "Value:"
            Me.layoutControlItem15.Location = New System.Drawing.Point(524, 0)
            Me.layoutControlItem15.Name = "layoutControlItem49"
            Me.layoutControlItem15.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 12, 16)
            Me.layoutControlItem15.Size = New System.Drawing.Size(271, 73)
            Me.layoutControlItem15.Text = "Value:"
            Me.layoutControlItem15.TextSize = New System.Drawing.Size(58, 13)
            '
            'layoutControlItem16
            '
            Me.layoutControlItem16.Control = Me.vertLblPos
            Me.layoutControlItem16.CustomizationFormText = "End extent:"
            Me.layoutControlItem16.Location = New System.Drawing.Point(524, 124)
            Me.layoutControlItem16.Name = "layoutControlItem47"
            Me.layoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 3, 3)
            Me.layoutControlItem16.Size = New System.Drawing.Size(271, 51)
            Me.layoutControlItem16.Text = "Y Position:"
            Me.layoutControlItem16.TextSize = New System.Drawing.Size(58, 13)
            '
            'layoutControlItem17
            '
            Me.layoutControlItem17.Control = Me.horzLblPos
            Me.layoutControlItem17.CustomizationFormText = "Start Extent:"
            Me.layoutControlItem17.Location = New System.Drawing.Point(524, 73)
            Me.layoutControlItem17.Name = "layoutControlItem46"
            Me.layoutControlItem17.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 3, 3)
            Me.layoutControlItem17.Size = New System.Drawing.Size(271, 51)
            Me.layoutControlItem17.Text = "X Position:"
            Me.layoutControlItem17.TextSize = New System.Drawing.Size(58, 13)
            '
            'layoutControlItem20
            '
            Me.layoutControlItem20.Control = Me.lblOrientation
            Me.layoutControlItem20.CustomizationFormText = "Label Orientation:"
            Me.layoutControlItem20.Location = New System.Drawing.Point(524, 175)
            Me.layoutControlItem20.Name = "layoutControlItem20"
            Me.layoutControlItem20.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 12, 3, 3)
            Me.layoutControlItem20.Size = New System.Drawing.Size(271, 350)
            Me.layoutControlItem20.Text = "Orientation:"
            Me.layoutControlItem20.TextSize = New System.Drawing.Size(58, 13)
            '
            'CircularGaugeFeatures
            '
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "CircularGaugeFeatures"
            Me.Size = New System.Drawing.Size(801, 553)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.majorTickOffset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.majorTickOffset, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.minorTickOffset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.minorTickOffset, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rangeTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rangeTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleLabelsCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleLabelsCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleTextOrientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleTextExtentTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleTextExtentTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleValueTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleValueTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleEndAngleTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleEndAngleTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleStartAngleTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleStartAngleTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleTicksCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleTicksCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleRTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scaleRTrack, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage3.ResumeLayout(False)
            CType(Me.layoutControl5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl5.ResumeLayout(False)
            CType(Me.markerShape.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.markerOffset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.markerOffset, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl32.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl32, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl31.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl31, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl30.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl30, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl29.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl29, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem53, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage4.ResumeLayout(False)
            CType(Me.layoutControl6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl6.ResumeLayout(False)
            CType(Me.trackBarControl28.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl28, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl26.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl26, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl25.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl25, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage5.ResumeLayout(False)
            CType(Me.layoutControl7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl7.ResumeLayout(False)
            CType(Me.statePageVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statePageVal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage6.ResumeLayout(False)
            CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType(Me.lblOrientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vertLblPos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vertLblPos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.horzLblPos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.horzLblPos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private scaleRTrack As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private scaleTicksCount As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents scaleValueTrack As DevExpress.XtraEditors.TrackBarControl
        Private scaleEndAngleTrack As DevExpress.XtraEditors.TrackBarControl
        Private scaleStartAngleTrack As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Private scaleTextOrientation As DevExpress.XtraEditors.ComboBoxEdit
        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControl5 As DevExpress.XtraLayout.LayoutControl
        Private gaugeControl5 As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge5 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
        Private arcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
        Private layoutControl6 As DevExpress.XtraLayout.LayoutControl
        Private gaugeControl6 As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge6 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleNeedleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
        Private trackBarControl26 As DevExpress.XtraEditors.TrackBarControl
        Private trackBarControl25 As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControl7 As DevExpress.XtraLayout.LayoutControl
        Private statePageVal As DevExpress.XtraEditors.TrackBarControl
        Private gaugeControl7 As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge7 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleStateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleNeedleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
        Private trackBarControl28 As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
        Private trackBarControl30 As DevExpress.XtraEditors.TrackBarControl
        Private trackBarControl29 As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
        Private trackBarControl31 As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem
        Private trackBarControl32 As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
        Private scaleLabelsCount As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup
        Private scaleTextExtentTrack As DevExpress.XtraEditors.TrackBarControl
        Private rangeTrack As DevExpress.XtraEditors.RangeTrackBarControl
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private majorTickOffset As DevExpress.XtraEditors.TrackBarControl
        Private minorTickOffset As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
        Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
        Private arcScaleBackgroundLayerComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleMarkerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent
        Private xtraTabPage6 As DevExpress.XtraTab.XtraTabPage
        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl
        Private trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
        Private vertLblPos As DevExpress.XtraEditors.TrackBarControl
        Private horzLblPos As DevExpress.XtraEditors.TrackBarControl
        Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
        Private markerOffset As DevExpress.XtraEditors.TrackBarControl
        Private layoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
        Private markerShape As DevExpress.XtraEditors.ComboBoxEdit
        Private layoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
        Private lblOrientation As DevExpress.XtraEditors.ComboBoxEdit
        Private layoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem

    End Class
End Namespace
