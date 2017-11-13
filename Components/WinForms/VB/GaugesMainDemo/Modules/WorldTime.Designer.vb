Namespace DevExpress.XtraGauges.Demos
    Partial Class WorldTime
        'UserControl overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                lockTimerCounter += 1
                If timer IsNot Nothing Then
                    timer.Stop()
                    timer.Dispose()
                    timer = Nothing
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim ScaleLabel1 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel2 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel3 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleIndicatorState1 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState2 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState3 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleLabel4 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel5 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel6 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleIndicatorState4 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState5 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState6 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleLabel7 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel8 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel9 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleIndicatorState7 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState8 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState9 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleLabel10 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel11 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel12 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleIndicatorState10 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState11 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState12 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleLabel13 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel14 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel15 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleIndicatorState13 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState14 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState15 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleLabel16 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel17 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleLabel18 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Dim ScaleIndicatorState16 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Dim ScaleIndicatorState17 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Rome = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge6 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent17 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent18 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.Moscow = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge5 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.Paris = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge4 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.Tokyo = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge3 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.London = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.Washington = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleStateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleStateIndicatorComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.circularGauge6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleEffectLayerComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleSpindleCapComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleEffectLayerComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleSpindleCapComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleEffectLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleSpindleCapComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleEffectLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleSpindleCapComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleEffectLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleSpindleCapComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.Rome)
            Me.layoutControl1.Controls.Add(Me.Moscow)
            Me.layoutControl1.Controls.Add(Me.Paris)
            Me.layoutControl1.Controls.Add(Me.Tokyo)
            Me.layoutControl1.Controls.Add(Me.London)
            Me.layoutControl1.Controls.Add(Me.Washington)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(685, 593)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'Rome
            '
            Me.Rome.BackColor = System.Drawing.Color.Transparent
            Me.Rome.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Rome.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge6})
            Me.Rome.Location = New System.Drawing.Point(453, 297)
            Me.Rome.Name = "Rome"
            Me.Rome.Size = New System.Drawing.Size(214, 278)
            Me.Rome.TabIndex = 8
            '
            'circularGauge6
            '
            Me.circularGauge6.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent6})
            Me.circularGauge6.Bounds = New System.Drawing.Rectangle(6, 6, 202, 266)
            Me.circularGauge6.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent6})
            Me.circularGauge6.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent16, Me.arcScaleStateIndicatorComponent17, Me.arcScaleStateIndicatorComponent18})
            Me.circularGauge6.Name = "circularGauge6"
            Me.circularGauge6.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent16, Me.arcScaleNeedleComponent17, Me.arcScaleNeedleComponent18})
            Me.circularGauge6.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent16, Me.arcScaleComponent17, Me.arcScaleComponent18})
            Me.circularGauge6.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent6})
            '
            'arcScaleBackgroundLayerComponent6
            '
            Me.arcScaleBackgroundLayerComponent6.ArcScale = Me.arcScaleComponent16
            Me.arcScaleBackgroundLayerComponent6.Name = "arcScaleBackgroundLayerComponent6"
            Me.arcScaleBackgroundLayerComponent6.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504!, 0.436!)
            Me.arcScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent6.Size = New System.Drawing.SizeF(216.0!, 250.0!)
            Me.arcScaleBackgroundLayerComponent6.ZOrder = 1000
            '
            'arcScaleComponent16
            '
            Me.arcScaleComponent16.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent16.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.arcScaleComponent16.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent16.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent16.EndAngle = 270.0!
            ScaleLabel1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ScaleLabel1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            ScaleLabel1.FormatString = "{0}"
            ScaleLabel1.Name = "Label0"
            ScaleLabel1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 135.0!)
            ScaleLabel1.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel1.Text = "Rome"
            ScaleLabel2.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel2.FormatString = "{0}"
            ScaleLabel2.Name = "Label1"
            ScaleLabel2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 238.0!)
            ScaleLabel2.Size = New System.Drawing.SizeF(50.0!, 15.0!)
            ScaleLabel2.Text = "Italy"
            ScaleLabel3.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
            ScaleLabel3.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel3.FormatString = "{0:F4}"
            ScaleLabel3.Name = "Label2"
            ScaleLabel3.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(160.0!, 225.0!)
            ScaleLabel3.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel3.Text = "63.255"
            Me.arcScaleComponent16.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel1, ScaleLabel2, ScaleLabel3})
            Me.arcScaleComponent16.MajorTickCount = 13
            Me.arcScaleComponent16.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent16.MajorTickmark.ShapeOffset = -9.5!
            Me.arcScaleComponent16.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent16.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent16.MajorTickmark.TextOffset = -18.0!
            Me.arcScaleComponent16.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent16.MaxValue = 12.0!
            Me.arcScaleComponent16.MinorTickCount = 4
            Me.arcScaleComponent16.MinorTickmark.ShapeOffset = -1.5!
            Me.arcScaleComponent16.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent16.Name = "arcScaleComponent16"
            Me.arcScaleComponent16.RadiusX = 74.0!
            Me.arcScaleComponent16.RadiusY = 74.0!
            Me.arcScaleComponent16.StartAngle = -90.0!
            '
            'arcScaleEffectLayerComponent6
            '
            Me.arcScaleEffectLayerComponent6.ArcScale = Me.arcScaleComponent16
            Me.arcScaleEffectLayerComponent6.Name = "arcScaleEffectLayerComponent6"
            Me.arcScaleEffectLayerComponent6.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
            Me.arcScaleEffectLayerComponent6.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent6.Size = New System.Drawing.SizeF(170.0!, 85.0!)
            Me.arcScaleEffectLayerComponent6.ZOrder = -1000
            '
            'arcScaleStateIndicatorComponent16
            '
            Me.arcScaleStateIndicatorComponent16.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 218.0!)
            Me.arcScaleStateIndicatorComponent16.IndicatorScale = Me.arcScaleComponent16
            Me.arcScaleStateIndicatorComponent16.Name = "arcScaleStateIndicatorComponent16"
            Me.arcScaleStateIndicatorComponent16.Size = New System.Drawing.SizeF(40.0!, 21.0!)
            ScaleIndicatorState1.IntervalLength = 12.0!
            ScaleIndicatorState1.Name = "Default"
            ScaleIndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagItaly
            Me.arcScaleStateIndicatorComponent16.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState1})
            Me.arcScaleStateIndicatorComponent16.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent17
            '
            Me.arcScaleStateIndicatorComponent17.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(118.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent17.IndicatorScale = Me.arcScaleComponent16
            Me.arcScaleStateIndicatorComponent17.Name = "arcScaleStateIndicatorComponent17"
            Me.arcScaleStateIndicatorComponent17.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent17.Size = New System.Drawing.SizeF(20.0!, 20.0!)
            ScaleIndicatorState2.IntervalLength = 12.0!
            ScaleIndicatorState2.Name = "Default"
            ScaleIndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyEUR
            Me.arcScaleStateIndicatorComponent17.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState2})
            Me.arcScaleStateIndicatorComponent17.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent18
            '
            Me.arcScaleStateIndicatorComponent18.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(195.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent18.IndicatorScale = Me.arcScaleComponent16
            Me.arcScaleStateIndicatorComponent18.Name = "arcScaleStateIndicatorComponent18"
            Me.arcScaleStateIndicatorComponent18.Size = New System.Drawing.SizeF(15.0!, 15.0!)
            ScaleIndicatorState3.IntervalLength = 12.0!
            ScaleIndicatorState3.Name = "Default"
            ScaleIndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow1
            Me.arcScaleStateIndicatorComponent18.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState3})
            Me.arcScaleStateIndicatorComponent18.ZOrder = -100
            '
            'arcScaleNeedleComponent16
            '
            Me.arcScaleNeedleComponent16.ArcScale = Me.arcScaleComponent16
            Me.arcScaleNeedleComponent16.EndOffset = 10.0!
            Me.arcScaleNeedleComponent16.Name = "arcScaleNeedleComponent16"
            Me.arcScaleNeedleComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent16.ZOrder = -50
            '
            'arcScaleNeedleComponent17
            '
            Me.arcScaleNeedleComponent17.ArcScale = Me.arcScaleComponent17
            Me.arcScaleNeedleComponent17.EndOffset = -5.0!
            Me.arcScaleNeedleComponent17.Name = "arcScaleNeedleComponent17"
            Me.arcScaleNeedleComponent17.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent17.ZOrder = -51
            '
            'arcScaleComponent17
            '
            Me.arcScaleComponent17.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent17.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent17.EndAngle = 270.0!
            Me.arcScaleComponent17.MajorTickCount = 2
            Me.arcScaleComponent17.MajorTickmark.ShowText = False
            Me.arcScaleComponent17.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent17.MaxValue = 12.0!
            Me.arcScaleComponent17.MinorTickCount = 0
            Me.arcScaleComponent17.Name = "arcScaleComponent17"
            Me.arcScaleComponent17.RadiusX = 74.0!
            Me.arcScaleComponent17.RadiusY = 74.0!
            Me.arcScaleComponent17.StartAngle = -90.0!
            Me.arcScaleComponent17.Value = 3.0!
            '
            'arcScaleNeedleComponent18
            '
            Me.arcScaleNeedleComponent18.ArcScale = Me.arcScaleComponent18
            Me.arcScaleNeedleComponent18.EndOffset = -10.0!
            Me.arcScaleNeedleComponent18.Name = "arcScaleNeedleComponent18"
            Me.arcScaleNeedleComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent18.ZOrder = -52
            '
            'arcScaleComponent18
            '
            Me.arcScaleComponent18.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent18.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent18.EndAngle = 270.0!
            Me.arcScaleComponent18.MajorTickCount = 2
            Me.arcScaleComponent18.MajorTickmark.ShowText = False
            Me.arcScaleComponent18.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent18.MaxValue = 12.0!
            Me.arcScaleComponent18.MinorTickCount = 0
            Me.arcScaleComponent18.Name = "arcScaleComponent18"
            Me.arcScaleComponent18.RadiusX = 74.0!
            Me.arcScaleComponent18.RadiusY = 74.0!
            Me.arcScaleComponent18.StartAngle = -90.0!
            Me.arcScaleComponent18.Value = 1.5!
            '
            'arcScaleSpindleCapComponent6
            '
            Me.arcScaleSpindleCapComponent6.ArcScale = Me.arcScaleComponent16
            Me.arcScaleSpindleCapComponent6.Name = "arcScaleSpindleCapComponent6"
            Me.arcScaleSpindleCapComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent6.Size = New System.Drawing.SizeF(12.0!, 12.0!)
            Me.arcScaleSpindleCapComponent6.ZOrder = -100
            '
            'Moscow
            '
            Me.Moscow.BackColor = System.Drawing.Color.Transparent
            Me.Moscow.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Moscow.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge5})
            Me.Moscow.Location = New System.Drawing.Point(453, 18)
            Me.Moscow.Name = "Moscow"
            Me.Moscow.Size = New System.Drawing.Size(214, 279)
            Me.Moscow.TabIndex = 8
            '
            'circularGauge5
            '
            Me.circularGauge5.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent5})
            Me.circularGauge5.Bounds = New System.Drawing.Rectangle(6, 6, 202, 267)
            Me.circularGauge5.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent5})
            Me.circularGauge5.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent13, Me.arcScaleStateIndicatorComponent14, Me.arcScaleStateIndicatorComponent15})
            Me.circularGauge5.Name = "circularGauge5"
            Me.circularGauge5.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent13, Me.arcScaleNeedleComponent14, Me.arcScaleNeedleComponent15})
            Me.circularGauge5.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent13, Me.arcScaleComponent14, Me.arcScaleComponent15})
            Me.circularGauge5.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent5})
            '
            'arcScaleBackgroundLayerComponent5
            '
            Me.arcScaleBackgroundLayerComponent5.ArcScale = Me.arcScaleComponent13
            Me.arcScaleBackgroundLayerComponent5.Name = "arcScaleBackgroundLayerComponent5"
            Me.arcScaleBackgroundLayerComponent5.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504!, 0.436!)
            Me.arcScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent5.Size = New System.Drawing.SizeF(216.0!, 250.0!)
            Me.arcScaleBackgroundLayerComponent5.ZOrder = 1000
            '
            'arcScaleComponent13
            '
            Me.arcScaleComponent13.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent13.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.arcScaleComponent13.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent13.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent13.EndAngle = 270.0!
            ScaleLabel4.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ScaleLabel4.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            ScaleLabel4.FormatString = "{0}"
            ScaleLabel4.Name = "Label0"
            ScaleLabel4.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 135.0!)
            ScaleLabel4.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel4.Text = "Moscow"
            ScaleLabel5.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel5.FormatString = "{0}"
            ScaleLabel5.Name = "Label1"
            ScaleLabel5.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 238.0!)
            ScaleLabel5.Size = New System.Drawing.SizeF(50.0!, 15.0!)
            ScaleLabel5.Text = "Russia"
            ScaleLabel6.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
            ScaleLabel6.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel6.FormatString = "{0:F4}"
            ScaleLabel6.Name = "Label2"
            ScaleLabel6.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(165.0!, 225.0!)
            ScaleLabel6.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel6.Text = "2 276.19"
            Me.arcScaleComponent13.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel4, ScaleLabel5, ScaleLabel6})
            Me.arcScaleComponent13.MajorTickCount = 13
            Me.arcScaleComponent13.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent13.MajorTickmark.ShapeOffset = -9.5!
            Me.arcScaleComponent13.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent13.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent13.MajorTickmark.TextOffset = -18.0!
            Me.arcScaleComponent13.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent13.MaxValue = 12.0!
            Me.arcScaleComponent13.MinorTickCount = 4
            Me.arcScaleComponent13.MinorTickmark.ShapeOffset = -1.5!
            Me.arcScaleComponent13.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent13.Name = "arcScaleComponent13"
            Me.arcScaleComponent13.RadiusX = 74.0!
            Me.arcScaleComponent13.RadiusY = 74.0!
            Me.arcScaleComponent13.StartAngle = -90.0!
            '
            'arcScaleEffectLayerComponent5
            '
            Me.arcScaleEffectLayerComponent5.ArcScale = Me.arcScaleComponent13
            Me.arcScaleEffectLayerComponent5.Name = "arcScaleEffectLayerComponent5"
            Me.arcScaleEffectLayerComponent5.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
            Me.arcScaleEffectLayerComponent5.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent5.Size = New System.Drawing.SizeF(170.0!, 85.0!)
            Me.arcScaleEffectLayerComponent5.ZOrder = -1000
            '
            'arcScaleStateIndicatorComponent13
            '
            Me.arcScaleStateIndicatorComponent13.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 218.0!)
            Me.arcScaleStateIndicatorComponent13.IndicatorScale = Me.arcScaleComponent13
            Me.arcScaleStateIndicatorComponent13.Name = "arcScaleStateIndicatorComponent13"
            Me.arcScaleStateIndicatorComponent13.Size = New System.Drawing.SizeF(40.0!, 21.0!)
            ScaleIndicatorState4.IntervalLength = 12.0!
            ScaleIndicatorState4.Name = "Default"
            ScaleIndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagRussia
            Me.arcScaleStateIndicatorComponent13.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState4})
            Me.arcScaleStateIndicatorComponent13.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent14
            '
            Me.arcScaleStateIndicatorComponent14.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(118.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent14.IndicatorScale = Me.arcScaleComponent13
            Me.arcScaleStateIndicatorComponent14.Name = "arcScaleStateIndicatorComponent14"
            Me.arcScaleStateIndicatorComponent14.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent14.Size = New System.Drawing.SizeF(20.0!, 20.0!)
            ScaleIndicatorState5.IntervalLength = 12.0!
            ScaleIndicatorState5.Name = "Default"
            ScaleIndicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyRUR
            Me.arcScaleStateIndicatorComponent14.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState5})
            Me.arcScaleStateIndicatorComponent14.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent15
            '
            Me.arcScaleStateIndicatorComponent15.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent15.IndicatorScale = Me.arcScaleComponent13
            Me.arcScaleStateIndicatorComponent15.Name = "arcScaleStateIndicatorComponent15"
            Me.arcScaleStateIndicatorComponent15.Size = New System.Drawing.SizeF(15.0!, 15.0!)
            ScaleIndicatorState6.IntervalLength = 12.0!
            ScaleIndicatorState6.Name = "Default"
            ScaleIndicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow2
            Me.arcScaleStateIndicatorComponent15.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState6})
            Me.arcScaleStateIndicatorComponent15.ZOrder = -100
            '
            'arcScaleNeedleComponent13
            '
            Me.arcScaleNeedleComponent13.ArcScale = Me.arcScaleComponent13
            Me.arcScaleNeedleComponent13.EndOffset = 10.0!
            Me.arcScaleNeedleComponent13.Name = "arcScaleNeedleComponent13"
            Me.arcScaleNeedleComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent13.ZOrder = -50
            '
            'arcScaleNeedleComponent14
            '
            Me.arcScaleNeedleComponent14.ArcScale = Me.arcScaleComponent14
            Me.arcScaleNeedleComponent14.EndOffset = -5.0!
            Me.arcScaleNeedleComponent14.Name = "arcScaleNeedleComponent14"
            Me.arcScaleNeedleComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent14.ZOrder = -51
            '
            'arcScaleComponent14
            '
            Me.arcScaleComponent14.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent14.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent14.EndAngle = 270.0!
            Me.arcScaleComponent14.MajorTickCount = 2
            Me.arcScaleComponent14.MajorTickmark.ShowText = False
            Me.arcScaleComponent14.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent14.MaxValue = 12.0!
            Me.arcScaleComponent14.MinorTickCount = 0
            Me.arcScaleComponent14.Name = "arcScaleComponent14"
            Me.arcScaleComponent14.RadiusX = 74.0!
            Me.arcScaleComponent14.RadiusY = 74.0!
            Me.arcScaleComponent14.StartAngle = -90.0!
            Me.arcScaleComponent14.Value = 3.0!
            '
            'arcScaleNeedleComponent15
            '
            Me.arcScaleNeedleComponent15.ArcScale = Me.arcScaleComponent15
            Me.arcScaleNeedleComponent15.EndOffset = -10.0!
            Me.arcScaleNeedleComponent15.Name = "arcScaleNeedleComponent15"
            Me.arcScaleNeedleComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent15.ZOrder = -52
            '
            'arcScaleComponent15
            '
            Me.arcScaleComponent15.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent15.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent15.EndAngle = 270.0!
            Me.arcScaleComponent15.MajorTickCount = 2
            Me.arcScaleComponent15.MajorTickmark.ShowText = False
            Me.arcScaleComponent15.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent15.MaxValue = 12.0!
            Me.arcScaleComponent15.MinorTickCount = 0
            Me.arcScaleComponent15.Name = "arcScaleComponent15"
            Me.arcScaleComponent15.RadiusX = 74.0!
            Me.arcScaleComponent15.RadiusY = 74.0!
            Me.arcScaleComponent15.StartAngle = -90.0!
            Me.arcScaleComponent15.Value = 1.5!
            '
            'arcScaleSpindleCapComponent5
            '
            Me.arcScaleSpindleCapComponent5.ArcScale = Me.arcScaleComponent13
            Me.arcScaleSpindleCapComponent5.Name = "arcScaleSpindleCapComponent5"
            Me.arcScaleSpindleCapComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent5.Size = New System.Drawing.SizeF(12.0!, 12.0!)
            Me.arcScaleSpindleCapComponent5.ZOrder = -100
            '
            'Paris
            '
            Me.Paris.BackColor = System.Drawing.Color.Transparent
            Me.Paris.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Paris.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge4})
            Me.Paris.Location = New System.Drawing.Point(232, 18)
            Me.Paris.Name = "Paris"
            Me.Paris.Size = New System.Drawing.Size(220, 279)
            Me.Paris.TabIndex = 7
            '
            'circularGauge4
            '
            Me.circularGauge4.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent4})
            Me.circularGauge4.Bounds = New System.Drawing.Rectangle(6, 6, 208, 267)
            Me.circularGauge4.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent4})
            Me.circularGauge4.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent10, Me.arcScaleStateIndicatorComponent11, Me.arcScaleStateIndicatorComponent12})
            Me.circularGauge4.Name = "circularGauge4"
            Me.circularGauge4.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent10, Me.arcScaleNeedleComponent11, Me.arcScaleNeedleComponent12})
            Me.circularGauge4.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent10, Me.arcScaleComponent11, Me.arcScaleComponent12})
            Me.circularGauge4.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent4})
            '
            'arcScaleBackgroundLayerComponent4
            '
            Me.arcScaleBackgroundLayerComponent4.ArcScale = Me.arcScaleComponent10
            Me.arcScaleBackgroundLayerComponent4.Name = "arcScaleBackgroundLayerComponent4"
            Me.arcScaleBackgroundLayerComponent4.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504!, 0.436!)
            Me.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent4.Size = New System.Drawing.SizeF(216.0!, 250.0!)
            Me.arcScaleBackgroundLayerComponent4.ZOrder = 1000
            '
            'arcScaleComponent10
            '
            Me.arcScaleComponent10.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent10.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.arcScaleComponent10.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent10.EndAngle = 270.0!
            ScaleLabel7.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ScaleLabel7.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            ScaleLabel7.FormatString = "{0}"
            ScaleLabel7.Name = "Label0"
            ScaleLabel7.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 135.0!)
            ScaleLabel7.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel7.Text = "Paris"
            ScaleLabel8.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel8.FormatString = "{0}"
            ScaleLabel8.Name = "Label1"
            ScaleLabel8.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 238.0!)
            ScaleLabel8.Size = New System.Drawing.SizeF(50.0!, 15.0!)
            ScaleLabel8.Text = "France"
            ScaleLabel9.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
            ScaleLabel9.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel9.FormatString = "{0:F4}"
            ScaleLabel9.Name = "Label2"
            ScaleLabel9.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(160.0!, 225.0!)
            ScaleLabel9.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel9.Text = "63.255"
            Me.arcScaleComponent10.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel7, ScaleLabel8, ScaleLabel9})
            Me.arcScaleComponent10.MajorTickCount = 13
            Me.arcScaleComponent10.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent10.MajorTickmark.ShapeOffset = -9.5!
            Me.arcScaleComponent10.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent10.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent10.MajorTickmark.TextOffset = -18.0!
            Me.arcScaleComponent10.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent10.MaxValue = 12.0!
            Me.arcScaleComponent10.MinorTickCount = 4
            Me.arcScaleComponent10.MinorTickmark.ShapeOffset = -1.5!
            Me.arcScaleComponent10.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent10.Name = "arcScaleComponent10"
            Me.arcScaleComponent10.RadiusX = 74.0!
            Me.arcScaleComponent10.RadiusY = 74.0!
            Me.arcScaleComponent10.StartAngle = -90.0!
            '
            'arcScaleEffectLayerComponent4
            '
            Me.arcScaleEffectLayerComponent4.ArcScale = Me.arcScaleComponent10
            Me.arcScaleEffectLayerComponent4.Name = "arcScaleEffectLayerComponent4"
            Me.arcScaleEffectLayerComponent4.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
            Me.arcScaleEffectLayerComponent4.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent4.Size = New System.Drawing.SizeF(170.0!, 85.0!)
            Me.arcScaleEffectLayerComponent4.ZOrder = -1000
            '
            'arcScaleStateIndicatorComponent10
            '
            Me.arcScaleStateIndicatorComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 218.0!)
            Me.arcScaleStateIndicatorComponent10.IndicatorScale = Me.arcScaleComponent10
            Me.arcScaleStateIndicatorComponent10.Name = "arcScaleStateIndicatorComponent10"
            Me.arcScaleStateIndicatorComponent10.Size = New System.Drawing.SizeF(40.0!, 21.0!)
            ScaleIndicatorState7.IntervalLength = 12.0!
            ScaleIndicatorState7.Name = "Default"
            ScaleIndicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagFrance
            Me.arcScaleStateIndicatorComponent10.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState7})
            Me.arcScaleStateIndicatorComponent10.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent11
            '
            Me.arcScaleStateIndicatorComponent11.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(118.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent11.IndicatorScale = Me.arcScaleComponent10
            Me.arcScaleStateIndicatorComponent11.Name = "arcScaleStateIndicatorComponent11"
            Me.arcScaleStateIndicatorComponent11.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent11.Size = New System.Drawing.SizeF(20.0!, 20.0!)
            ScaleIndicatorState8.IntervalLength = 12.0!
            ScaleIndicatorState8.Name = "Default"
            ScaleIndicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyEUR
            Me.arcScaleStateIndicatorComponent11.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState8})
            Me.arcScaleStateIndicatorComponent11.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent12
            '
            Me.arcScaleStateIndicatorComponent12.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(195.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent12.IndicatorScale = Me.arcScaleComponent10
            Me.arcScaleStateIndicatorComponent12.Name = "arcScaleStateIndicatorComponent12"
            Me.arcScaleStateIndicatorComponent12.Size = New System.Drawing.SizeF(15.0!, 15.0!)
            ScaleIndicatorState9.IntervalLength = 12.0!
            ScaleIndicatorState9.Name = "Default"
            ScaleIndicatorState9.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow1
            Me.arcScaleStateIndicatorComponent12.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState9})
            Me.arcScaleStateIndicatorComponent12.ZOrder = -100
            '
            'arcScaleNeedleComponent10
            '
            Me.arcScaleNeedleComponent10.ArcScale = Me.arcScaleComponent10
            Me.arcScaleNeedleComponent10.EndOffset = 10.0!
            Me.arcScaleNeedleComponent10.Name = "arcScaleNeedleComponent10"
            Me.arcScaleNeedleComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent10.ZOrder = -50
            '
            'arcScaleNeedleComponent11
            '
            Me.arcScaleNeedleComponent11.ArcScale = Me.arcScaleComponent11
            Me.arcScaleNeedleComponent11.EndOffset = -5.0!
            Me.arcScaleNeedleComponent11.Name = "arcScaleNeedleComponent11"
            Me.arcScaleNeedleComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent11.ZOrder = -51
            '
            'arcScaleComponent11
            '
            Me.arcScaleComponent11.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent11.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent11.EndAngle = 270.0!
            Me.arcScaleComponent11.MajorTickCount = 2
            Me.arcScaleComponent11.MajorTickmark.ShowText = False
            Me.arcScaleComponent11.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent11.MaxValue = 12.0!
            Me.arcScaleComponent11.MinorTickCount = 0
            Me.arcScaleComponent11.Name = "arcScaleComponent11"
            Me.arcScaleComponent11.RadiusX = 74.0!
            Me.arcScaleComponent11.RadiusY = 74.0!
            Me.arcScaleComponent11.StartAngle = -90.0!
            Me.arcScaleComponent11.Value = 3.0!
            '
            'arcScaleNeedleComponent12
            '
            Me.arcScaleNeedleComponent12.ArcScale = Me.arcScaleComponent12
            Me.arcScaleNeedleComponent12.EndOffset = -10.0!
            Me.arcScaleNeedleComponent12.Name = "arcScaleNeedleComponent12"
            Me.arcScaleNeedleComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent12.ZOrder = -52
            '
            'arcScaleComponent12
            '
            Me.arcScaleComponent12.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent12.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent12.EndAngle = 270.0!
            Me.arcScaleComponent12.MajorTickCount = 2
            Me.arcScaleComponent12.MajorTickmark.ShowText = False
            Me.arcScaleComponent12.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent12.MaxValue = 12.0!
            Me.arcScaleComponent12.MinorTickCount = 0
            Me.arcScaleComponent12.Name = "arcScaleComponent12"
            Me.arcScaleComponent12.RadiusX = 74.0!
            Me.arcScaleComponent12.RadiusY = 74.0!
            Me.arcScaleComponent12.StartAngle = -90.0!
            Me.arcScaleComponent12.Value = 1.5!
            '
            'arcScaleSpindleCapComponent4
            '
            Me.arcScaleSpindleCapComponent4.ArcScale = Me.arcScaleComponent10
            Me.arcScaleSpindleCapComponent4.Name = "arcScaleSpindleCapComponent4"
            Me.arcScaleSpindleCapComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent4.Size = New System.Drawing.SizeF(12.0!, 12.0!)
            Me.arcScaleSpindleCapComponent4.ZOrder = -100
            '
            'Tokyo
            '
            Me.Tokyo.BackColor = System.Drawing.Color.Transparent
            Me.Tokyo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Tokyo.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge3})
            Me.Tokyo.Location = New System.Drawing.Point(232, 297)
            Me.Tokyo.Name = "Tokyo"
            Me.Tokyo.Size = New System.Drawing.Size(220, 278)
            Me.Tokyo.TabIndex = 6
            '
            'circularGauge3
            '
            Me.circularGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent3})
            Me.circularGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 208, 266)
            Me.circularGauge3.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent3})
            Me.circularGauge3.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent7, Me.arcScaleStateIndicatorComponent8, Me.arcScaleStateIndicatorComponent9})
            Me.circularGauge3.Name = "circularGauge3"
            Me.circularGauge3.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent7, Me.arcScaleNeedleComponent8, Me.arcScaleNeedleComponent9})
            Me.circularGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent7, Me.arcScaleComponent8, Me.arcScaleComponent9})
            Me.circularGauge3.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent3})
            '
            'arcScaleBackgroundLayerComponent3
            '
            Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleComponent7
            Me.arcScaleBackgroundLayerComponent3.Name = "arcScaleBackgroundLayerComponent3"
            Me.arcScaleBackgroundLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504!, 0.436!)
            Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent3.Size = New System.Drawing.SizeF(216.0!, 250.0!)
            Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
            '
            'arcScaleComponent7
            '
            Me.arcScaleComponent7.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent7.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.arcScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent7.EndAngle = 270.0!
            ScaleLabel10.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ScaleLabel10.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            ScaleLabel10.FormatString = "{0}"
            ScaleLabel10.Name = "Label0"
            ScaleLabel10.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 135.0!)
            ScaleLabel10.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel10.Text = "Tokyo"
            ScaleLabel11.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel11.FormatString = "{0}"
            ScaleLabel11.Name = "Label1"
            ScaleLabel11.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 238.0!)
            ScaleLabel11.Size = New System.Drawing.SizeF(50.0!, 15.0!)
            ScaleLabel11.Text = "Japan"
            ScaleLabel12.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
            ScaleLabel12.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel12.FormatString = "{0:F4}"
            ScaleLabel12.Name = "Label2"
            ScaleLabel12.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(168.0!, 225.0!)
            ScaleLabel12.Size = New System.Drawing.SizeF(90.0!, 20.0!)
            ScaleLabel12.Text = "10 653.03"
            Me.arcScaleComponent7.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel10, ScaleLabel11, ScaleLabel12})
            Me.arcScaleComponent7.MajorTickCount = 13
            Me.arcScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent7.MajorTickmark.ShapeOffset = -9.5!
            Me.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent7.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent7.MajorTickmark.TextOffset = -18.0!
            Me.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent7.MaxValue = 12.0!
            Me.arcScaleComponent7.MinorTickCount = 4
            Me.arcScaleComponent7.MinorTickmark.ShapeOffset = -1.5!
            Me.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent7.Name = "arcScaleComponent7"
            Me.arcScaleComponent7.RadiusX = 74.0!
            Me.arcScaleComponent7.RadiusY = 74.0!
            Me.arcScaleComponent7.StartAngle = -90.0!
            '
            'arcScaleEffectLayerComponent3
            '
            Me.arcScaleEffectLayerComponent3.ArcScale = Me.arcScaleComponent7
            Me.arcScaleEffectLayerComponent3.Name = "arcScaleEffectLayerComponent3"
            Me.arcScaleEffectLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
            Me.arcScaleEffectLayerComponent3.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent3.Size = New System.Drawing.SizeF(170.0!, 85.0!)
            Me.arcScaleEffectLayerComponent3.ZOrder = -1000
            '
            'arcScaleStateIndicatorComponent7
            '
            Me.arcScaleStateIndicatorComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 218.0!)
            Me.arcScaleStateIndicatorComponent7.IndicatorScale = Me.arcScaleComponent7
            Me.arcScaleStateIndicatorComponent7.Name = "arcScaleStateIndicatorComponent7"
            Me.arcScaleStateIndicatorComponent7.Size = New System.Drawing.SizeF(40.0!, 21.0!)
            ScaleIndicatorState10.IntervalLength = 12.0!
            ScaleIndicatorState10.Name = "Default"
            ScaleIndicatorState10.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagJapan
            Me.arcScaleStateIndicatorComponent7.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState10})
            Me.arcScaleStateIndicatorComponent7.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent8
            '
            Me.arcScaleStateIndicatorComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(118.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent8.IndicatorScale = Me.arcScaleComponent7
            Me.arcScaleStateIndicatorComponent8.Name = "arcScaleStateIndicatorComponent8"
            Me.arcScaleStateIndicatorComponent8.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent8.Size = New System.Drawing.SizeF(20.0!, 20.0!)
            ScaleIndicatorState11.IntervalLength = 12.0!
            ScaleIndicatorState11.Name = "Default"
            ScaleIndicatorState11.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyJPY
            Me.arcScaleStateIndicatorComponent8.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState11})
            Me.arcScaleStateIndicatorComponent8.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent9
            '
            Me.arcScaleStateIndicatorComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(213.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent9.IndicatorScale = Me.arcScaleComponent7
            Me.arcScaleStateIndicatorComponent9.Name = "arcScaleStateIndicatorComponent9"
            Me.arcScaleStateIndicatorComponent9.Size = New System.Drawing.SizeF(15.0!, 15.0!)
            ScaleIndicatorState12.IntervalLength = 12.0!
            ScaleIndicatorState12.Name = "Default"
            ScaleIndicatorState12.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow10
            Me.arcScaleStateIndicatorComponent9.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState12})
            Me.arcScaleStateIndicatorComponent9.ZOrder = -100
            '
            'arcScaleNeedleComponent7
            '
            Me.arcScaleNeedleComponent7.ArcScale = Me.arcScaleComponent7
            Me.arcScaleNeedleComponent7.EndOffset = 10.0!
            Me.arcScaleNeedleComponent7.Name = "arcScaleNeedleComponent7"
            Me.arcScaleNeedleComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent7.ZOrder = -50
            '
            'arcScaleNeedleComponent8
            '
            Me.arcScaleNeedleComponent8.ArcScale = Me.arcScaleComponent8
            Me.arcScaleNeedleComponent8.EndOffset = -5.0!
            Me.arcScaleNeedleComponent8.Name = "arcScaleNeedleComponent8"
            Me.arcScaleNeedleComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent8.ZOrder = -51
            '
            'arcScaleComponent8
            '
            Me.arcScaleComponent8.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent8.EndAngle = 270.0!
            Me.arcScaleComponent8.MajorTickCount = 2
            Me.arcScaleComponent8.MajorTickmark.ShowText = False
            Me.arcScaleComponent8.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent8.MaxValue = 12.0!
            Me.arcScaleComponent8.MinorTickCount = 0
            Me.arcScaleComponent8.Name = "arcScaleComponent8"
            Me.arcScaleComponent8.RadiusX = 74.0!
            Me.arcScaleComponent8.RadiusY = 74.0!
            Me.arcScaleComponent8.StartAngle = -90.0!
            Me.arcScaleComponent8.Value = 3.0!
            '
            'arcScaleNeedleComponent9
            '
            Me.arcScaleNeedleComponent9.ArcScale = Me.arcScaleComponent9
            Me.arcScaleNeedleComponent9.EndOffset = -10.0!
            Me.arcScaleNeedleComponent9.Name = "arcScaleNeedleComponent9"
            Me.arcScaleNeedleComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent9.ZOrder = -52
            '
            'arcScaleComponent9
            '
            Me.arcScaleComponent9.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent9.EndAngle = 270.0!
            Me.arcScaleComponent9.MajorTickCount = 2
            Me.arcScaleComponent9.MajorTickmark.ShowText = False
            Me.arcScaleComponent9.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent9.MaxValue = 12.0!
            Me.arcScaleComponent9.MinorTickCount = 0
            Me.arcScaleComponent9.Name = "arcScaleComponent9"
            Me.arcScaleComponent9.RadiusX = 74.0!
            Me.arcScaleComponent9.RadiusY = 74.0!
            Me.arcScaleComponent9.StartAngle = -90.0!
            Me.arcScaleComponent9.Value = 1.5!
            '
            'arcScaleSpindleCapComponent3
            '
            Me.arcScaleSpindleCapComponent3.ArcScale = Me.arcScaleComponent7
            Me.arcScaleSpindleCapComponent3.Name = "arcScaleSpindleCapComponent3"
            Me.arcScaleSpindleCapComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent3.Size = New System.Drawing.SizeF(12.0!, 12.0!)
            Me.arcScaleSpindleCapComponent3.ZOrder = -100
            '
            'London
            '
            Me.London.BackColor = System.Drawing.Color.Transparent
            Me.London.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.London.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge2})
            Me.London.Location = New System.Drawing.Point(18, 297)
            Me.London.Name = "London"
            Me.London.Size = New System.Drawing.Size(213, 278)
            Me.London.TabIndex = 5
            '
            'circularGauge2
            '
            Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent2})
            Me.circularGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 201, 266)
            Me.circularGauge2.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent2})
            Me.circularGauge2.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent4, Me.arcScaleStateIndicatorComponent5, Me.arcScaleStateIndicatorComponent6})
            Me.circularGauge2.Name = "circularGauge2"
            Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent4, Me.arcScaleNeedleComponent5, Me.arcScaleNeedleComponent6})
            Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent4, Me.arcScaleComponent5, Me.arcScaleComponent6})
            Me.circularGauge2.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent2})
            '
            'arcScaleBackgroundLayerComponent2
            '
            Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent4
            Me.arcScaleBackgroundLayerComponent2.Name = "arcScaleBackgroundLayerComponent2"
            Me.arcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504!, 0.436!)
            Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(216.0!, 250.0!)
            Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
            '
            'arcScaleComponent4
            '
            Me.arcScaleComponent4.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent4.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.arcScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent4.EndAngle = 270.0!
            ScaleLabel13.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ScaleLabel13.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            ScaleLabel13.FormatString = "{0}"
            ScaleLabel13.Name = "Label0"
            ScaleLabel13.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 135.0!)
            ScaleLabel13.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel13.Text = "London"
            ScaleLabel14.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel14.FormatString = "{0}"
            ScaleLabel14.Name = "Label1"
            ScaleLabel14.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 238.0!)
            ScaleLabel14.Size = New System.Drawing.SizeF(90.0!, 15.0!)
            ScaleLabel14.Text = "United Kingdom"
            ScaleLabel15.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
            ScaleLabel15.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel15.FormatString = "{0:F4}"
            ScaleLabel15.Name = "Label2"
            ScaleLabel15.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(168.0!, 225.0!)
            ScaleLabel15.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel15.Text = "50.065"
            Me.arcScaleComponent4.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel13, ScaleLabel14, ScaleLabel15})
            Me.arcScaleComponent4.MajorTickCount = 13
            Me.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent4.MajorTickmark.ShapeOffset = -9.5!
            Me.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent4.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent4.MajorTickmark.TextOffset = -18.0!
            Me.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent4.MaxValue = 12.0!
            Me.arcScaleComponent4.MinorTickCount = 4
            Me.arcScaleComponent4.MinorTickmark.ShapeOffset = -1.5!
            Me.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent4.Name = "arcScaleComponent4"
            Me.arcScaleComponent4.RadiusX = 74.0!
            Me.arcScaleComponent4.RadiusY = 74.0!
            Me.arcScaleComponent4.StartAngle = -90.0!
            '
            'arcScaleEffectLayerComponent2
            '
            Me.arcScaleEffectLayerComponent2.ArcScale = Me.arcScaleComponent4
            Me.arcScaleEffectLayerComponent2.Name = "arcScaleEffectLayerComponent2"
            Me.arcScaleEffectLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
            Me.arcScaleEffectLayerComponent2.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent2.Size = New System.Drawing.SizeF(170.0!, 85.0!)
            Me.arcScaleEffectLayerComponent2.ZOrder = -1000
            '
            'arcScaleStateIndicatorComponent4
            '
            Me.arcScaleStateIndicatorComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 218.0!)
            Me.arcScaleStateIndicatorComponent4.IndicatorScale = Me.arcScaleComponent4
            Me.arcScaleStateIndicatorComponent4.Name = "arcScaleStateIndicatorComponent4"
            Me.arcScaleStateIndicatorComponent4.Size = New System.Drawing.SizeF(40.0!, 21.0!)
            ScaleIndicatorState13.IntervalLength = 12.0!
            ScaleIndicatorState13.Name = "Default"
            ScaleIndicatorState13.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagUK
            Me.arcScaleStateIndicatorComponent4.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState13})
            Me.arcScaleStateIndicatorComponent4.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent5
            '
            Me.arcScaleStateIndicatorComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(130.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent5.IndicatorScale = Me.arcScaleComponent4
            Me.arcScaleStateIndicatorComponent5.Name = "arcScaleStateIndicatorComponent5"
            Me.arcScaleStateIndicatorComponent5.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent5.Size = New System.Drawing.SizeF(20.0!, 20.0!)
            ScaleIndicatorState14.IntervalLength = 12.0!
            ScaleIndicatorState14.Name = "Default"
            ScaleIndicatorState14.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyGBP
            Me.arcScaleStateIndicatorComponent5.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState14})
            Me.arcScaleStateIndicatorComponent5.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent6
            '
            Me.arcScaleStateIndicatorComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(203.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent6.IndicatorScale = Me.arcScaleComponent4
            Me.arcScaleStateIndicatorComponent6.Name = "arcScaleStateIndicatorComponent6"
            Me.arcScaleStateIndicatorComponent6.Size = New System.Drawing.SizeF(15.0!, 15.0!)
            ScaleIndicatorState15.IntervalLength = 12.0!
            ScaleIndicatorState15.Name = "Default"
            ScaleIndicatorState15.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow9
            Me.arcScaleStateIndicatorComponent6.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState15})
            Me.arcScaleStateIndicatorComponent6.ZOrder = -100
            '
            'arcScaleNeedleComponent4
            '
            Me.arcScaleNeedleComponent4.ArcScale = Me.arcScaleComponent4
            Me.arcScaleNeedleComponent4.EndOffset = 10.0!
            Me.arcScaleNeedleComponent4.Name = "arcScaleNeedleComponent4"
            Me.arcScaleNeedleComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent4.ZOrder = -50
            '
            'arcScaleNeedleComponent5
            '
            Me.arcScaleNeedleComponent5.ArcScale = Me.arcScaleComponent5
            Me.arcScaleNeedleComponent5.EndOffset = -5.0!
            Me.arcScaleNeedleComponent5.Name = "arcScaleNeedleComponent5"
            Me.arcScaleNeedleComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent5.ZOrder = -51
            '
            'arcScaleComponent5
            '
            Me.arcScaleComponent5.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent5.EndAngle = 270.0!
            Me.arcScaleComponent5.MajorTickCount = 2
            Me.arcScaleComponent5.MajorTickmark.ShowText = False
            Me.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent5.MaxValue = 12.0!
            Me.arcScaleComponent5.MinorTickCount = 0
            Me.arcScaleComponent5.Name = "arcScaleComponent5"
            Me.arcScaleComponent5.RadiusX = 74.0!
            Me.arcScaleComponent5.RadiusY = 74.0!
            Me.arcScaleComponent5.StartAngle = -90.0!
            Me.arcScaleComponent5.Value = 3.0!
            '
            'arcScaleNeedleComponent6
            '
            Me.arcScaleNeedleComponent6.ArcScale = Me.arcScaleComponent6
            Me.arcScaleNeedleComponent6.EndOffset = -10.0!
            Me.arcScaleNeedleComponent6.Name = "arcScaleNeedleComponent6"
            Me.arcScaleNeedleComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent6.ZOrder = -52
            '
            'arcScaleComponent6
            '
            Me.arcScaleComponent6.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent6.EndAngle = 270.0!
            Me.arcScaleComponent6.MajorTickCount = 2
            Me.arcScaleComponent6.MajorTickmark.ShowText = False
            Me.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent6.MaxValue = 12.0!
            Me.arcScaleComponent6.MinorTickCount = 0
            Me.arcScaleComponent6.Name = "arcScaleComponent6"
            Me.arcScaleComponent6.RadiusX = 74.0!
            Me.arcScaleComponent6.RadiusY = 74.0!
            Me.arcScaleComponent6.StartAngle = -90.0!
            Me.arcScaleComponent6.Value = 1.5!
            '
            'arcScaleSpindleCapComponent2
            '
            Me.arcScaleSpindleCapComponent2.ArcScale = Me.arcScaleComponent4
            Me.arcScaleSpindleCapComponent2.Name = "arcScaleSpindleCapComponent2"
            Me.arcScaleSpindleCapComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent2.Size = New System.Drawing.SizeF(12.0!, 12.0!)
            Me.arcScaleSpindleCapComponent2.ZOrder = -100
            '
            'Washington
            '
            Me.Washington.BackColor = System.Drawing.Color.Transparent
            Me.Washington.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Washington.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.Washington.Location = New System.Drawing.Point(18, 18)
            Me.Washington.Name = "Washington"
            Me.Washington.Size = New System.Drawing.Size(213, 279)
            Me.Washington.TabIndex = 4
            '
            'circularGauge1
            '
            Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1})
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 201, 267)
            Me.circularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent1})
            Me.circularGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.arcScaleStateIndicatorComponent1, Me.arcScaleStateIndicatorComponent2})
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1, Me.arcScaleNeedleComponent2, Me.arcScaleNeedleComponent3})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1, Me.arcScaleComponent2, Me.arcScaleComponent3})
            Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent1})
            '
            'arcScaleBackgroundLayerComponent1
            '
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1"
            Me.arcScaleBackgroundLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504!, 0.436!)
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
            Me.arcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(216.0!, 250.0!)
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'arcScaleComponent1
            '
            Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent1.EndAngle = 270.0!
            ScaleLabel16.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ScaleLabel16.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            ScaleLabel16.FormatString = "{0}"
            ScaleLabel16.Name = "Label0"
            ScaleLabel16.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 135.0!)
            ScaleLabel16.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel16.Text = "Washington"
            ScaleLabel17.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel17.FormatString = "{0}"
            ScaleLabel17.Name = "Label1"
            ScaleLabel17.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 238.0!)
            ScaleLabel17.Size = New System.Drawing.SizeF(50.0!, 15.0!)
            ScaleLabel17.Text = "U.S.A."
            ScaleLabel18.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
            ScaleLabel18.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            ScaleLabel18.FormatString = "{0}"
            ScaleLabel18.Name = "Label2"
            ScaleLabel18.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(160.0!, 225.0!)
            ScaleLabel18.Size = New System.Drawing.SizeF(70.0!, 20.0!)
            ScaleLabel18.Text = "100.00"
            Me.arcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel16, ScaleLabel17, ScaleLabel18})
            Me.arcScaleComponent1.MajorTickCount = 13
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -9.5!
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
            Me.arcScaleComponent1.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent1.MajorTickmark.TextOffset = -18.0!
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 12.0!
            Me.arcScaleComponent1.MinorTickCount = 4
            Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -1.5!
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
            Me.arcScaleComponent1.Name = "arcScaleComponent1"
            Me.arcScaleComponent1.RadiusX = 74.0!
            Me.arcScaleComponent1.RadiusY = 74.0!
            Me.arcScaleComponent1.StartAngle = -90.0!
            '
            'arcScaleEffectLayerComponent1
            '
            Me.arcScaleEffectLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleEffectLayerComponent1.Name = "arcScaleEffectLayerComponent1"
            Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
            Me.arcScaleEffectLayerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
            Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(170.0!, 85.0!)
            Me.arcScaleEffectLayerComponent1.ZOrder = -1000
            '
            'arcScaleStateIndicatorComponent1
            '
            Me.arcScaleStateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 218.0!)
            Me.arcScaleStateIndicatorComponent1.IndicatorScale = Me.arcScaleComponent1
            Me.arcScaleStateIndicatorComponent1.Name = "arcScaleStateIndicatorComponent1"
            Me.arcScaleStateIndicatorComponent1.Size = New System.Drawing.SizeF(40.0!, 21.0!)
            ScaleIndicatorState16.IntervalLength = 12.0!
            ScaleIndicatorState16.Name = "Default"
            ScaleIndicatorState16.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagUSA
            Me.arcScaleStateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState16})
            Me.arcScaleStateIndicatorComponent1.ZOrder = -100
            '
            'arcScaleStateIndicatorComponent2
            '
            Me.arcScaleStateIndicatorComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(123.0!, 223.0!)
            Me.arcScaleStateIndicatorComponent2.IndicatorScale = Me.arcScaleComponent1
            Me.arcScaleStateIndicatorComponent2.Name = "arcScaleStateIndicatorComponent2"
            Me.arcScaleStateIndicatorComponent2.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
            Me.arcScaleStateIndicatorComponent2.Size = New System.Drawing.SizeF(20.0!, 20.0!)
            ScaleIndicatorState17.IntervalLength = 12.0!
            ScaleIndicatorState17.Name = "Default"
            ScaleIndicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyUSD
            Me.arcScaleStateIndicatorComponent2.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState17})
            Me.arcScaleStateIndicatorComponent2.ZOrder = -100
            '
            'arcScaleNeedleComponent1
            '
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.EndOffset = 10.0!
            Me.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent1.ZOrder = -50
            '
            'arcScaleNeedleComponent2
            '
            Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleNeedleComponent2.EndOffset = -5.0!
            Me.arcScaleNeedleComponent2.Name = "arcScaleNeedleComponent2"
            Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent2.ZOrder = -51
            '
            'arcScaleComponent2
            '
            Me.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent2.EndAngle = 270.0!
            Me.arcScaleComponent2.MajorTickCount = 2
            Me.arcScaleComponent2.MajorTickmark.ShowText = False
            Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent2.MaxValue = 12.0!
            Me.arcScaleComponent2.MinorTickCount = 0
            Me.arcScaleComponent2.Name = "arcScaleComponent2"
            Me.arcScaleComponent2.RadiusX = 74.0!
            Me.arcScaleComponent2.RadiusY = 74.0!
            Me.arcScaleComponent2.StartAngle = -90.0!
            Me.arcScaleComponent2.Value = 3.0!
            '
            'arcScaleNeedleComponent3
            '
            Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent3
            Me.arcScaleNeedleComponent3.EndOffset = -10.0!
            Me.arcScaleNeedleComponent3.Name = "arcScaleNeedleComponent3"
            Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent3.ZOrder = -52
            '
            'arcScaleComponent3
            '
            Me.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
            Me.arcScaleComponent3.EndAngle = 270.0!
            Me.arcScaleComponent3.MajorTickCount = 2
            Me.arcScaleComponent3.MajorTickmark.ShowText = False
            Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent3.MaxValue = 12.0!
            Me.arcScaleComponent3.MinorTickCount = 0
            Me.arcScaleComponent3.Name = "arcScaleComponent3"
            Me.arcScaleComponent3.RadiusX = 74.0!
            Me.arcScaleComponent3.RadiusY = 74.0!
            Me.arcScaleComponent3.StartAngle = -90.0!
            Me.arcScaleComponent3.Value = 1.5!
            '
            'arcScaleSpindleCapComponent1
            '
            Me.arcScaleSpindleCapComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleSpindleCapComponent1.Name = "arcScaleSpindleCapComponent1"
            Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(12.0!, 12.0!)
            Me.arcScaleSpindleCapComponent1.ZOrder = -100
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem4, Me.layoutControlItem3, Me.layoutControlItem2, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(685, 593)
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.Washington
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 0, 8, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 287)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.Paris
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(221, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 8, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(222, 287)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.Tokyo
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(221, 287)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 0, 8)
            Me.layoutControlItem3.Size = New System.Drawing.Size(222, 286)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.London
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 287)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 0, 0, 8)
            Me.layoutControlItem2.Size = New System.Drawing.Size(221, 286)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.Moscow
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(443, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 8, 8, 0)
            Me.layoutControlItem5.Size = New System.Drawing.Size(222, 287)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.Rome
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(443, 287)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 8, 0, 8)
            Me.layoutControlItem6.Size = New System.Drawing.Size(222, 286)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            '
            'timer
            '
            Me.timer.Interval = 1000
            '
            'WorldTime
            '
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "WorldTime"
            Me.Size = New System.Drawing.Size(685, 593)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.circularGauge6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleEffectLayerComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleSpindleCapComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleEffectLayerComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleSpindleCapComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleEffectLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleSpindleCapComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleEffectLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleSpindleCapComponent3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleEffectLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleSpindleCapComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private Washington As DevExpress.XtraGauges.Win.GaugeControl
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents timer As System.Windows.Forms.Timer
        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
        Private arcScaleStateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        Private London As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleEffectLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
        Private arcScaleStateIndicatorComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleNeedleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleNeedleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleNeedleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleSpindleCapComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private Paris As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge4 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleEffectLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
        Private arcScaleStateIndicatorComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleNeedleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleNeedleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleNeedleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleSpindleCapComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        Private Tokyo As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge3 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleEffectLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
        Private arcScaleStateIndicatorComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleNeedleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleNeedleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleNeedleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleSpindleCapComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private Rome As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge6 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleEffectLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
        Private arcScaleStateIndicatorComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleNeedleComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleNeedleComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent17 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleNeedleComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent18 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleSpindleCapComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        Private Moscow As DevExpress.XtraGauges.Win.GaugeControl
        Private circularGauge5 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Private arcScaleBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Private arcScaleComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleEffectLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
        Private arcScaleStateIndicatorComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleStateIndicatorComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
        Private arcScaleNeedleComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleNeedleComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleNeedleComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Private arcScaleComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private arcScaleSpindleCapComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
