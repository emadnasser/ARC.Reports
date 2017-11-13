Namespace DevExpress.XtraGauges.Demos
    Partial Class DigitalClock
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
            Me.components = New System.ComponentModel.Container
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.digitalGauge2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
            Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
            CType(Me.digitalGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'timer
            '
            Me.timer.Interval = 500
            '
            'gaugeControl1
            '
            Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge2})
            Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(395, 301)
            Me.gaugeControl1.TabIndex = 0
            '
            'digitalGauge2
            '
            Me.digitalGauge2.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge2.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent1})
            Me.digitalGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 383, 289)
            Me.digitalGauge2.DigitCount = 6
            Me.digitalGauge2.Name = ""
            Me.digitalGauge2.Text = "00,000"
            '
            'digitalBackgroundLayerComponent1
            '
            Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(307.775!, 99.9625!)
            Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
            Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
            Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
            Me.digitalBackgroundLayerComponent1.ZOrder = 1000
            '
            'DigitalClock
            '
            Me.Controls.Add(Me.gaugeControl1)
            Me.Name = "DigitalClock"
            Me.Size = New System.Drawing.Size(395, 301)
            CType(Me.digitalGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents timer As System.Windows.Forms.Timer
        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
        Private digitalGauge2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
        Private digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    End Class
End Namespace
