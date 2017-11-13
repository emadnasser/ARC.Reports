using System;

namespace DevExpress.XtraCharts.Demos.ViewCombinations {
    public partial class BarAndArea3dDemo : ChartDemoBase3D {
        Diagram3D Diagram { get { return ChartControl.Diagram as Diagram3D; } }
        
        public override ChartControl ChartControl { get { return chart; } }

        public BarAndArea3dDemo() {
            InitializeComponent();
            ShowLabels = true;
            UpdateScrollAndZoomControls();
        }
        
        void UpdateScrollAndZoomControls() {
            tbcHorizontalScrollPercent.Value = (int)Math.Round(Diagram.HorizontalScrollPercent);
            tbcVerticalScrollPercent.Value = (int)Math.Round(Diagram.VerticalScrollPercent);
            zoomTrackBarControl.Value = Diagram.ZoomPercent;
        }
        void tbcVerticalScrollPercent_EditValueChanged(object sender, EventArgs e) {
            if (Diagram != null)
                Diagram.VerticalScrollPercent = tbcVerticalScrollPercent.Value;
        }
        void tbcHorizontalScrollPercent_EditValueChanged(object sender, EventArgs e) {
            if (Diagram != null)
                Diagram.HorizontalScrollPercent = tbcHorizontalScrollPercent.Value;
        }
        void zoomTrackBarControl_EditValueChanged(object sender, EventArgs e) {
            if (Diagram != null)
                Diagram.ZoomPercent = zoomTrackBarControl.Value;
        }
        void chart_Zoom3D(object sender, ChartZoom3DEventArgs e) {
            zoomTrackBarControl.Value = e.NewZoomPercent;
        }
        void chart_Scroll3D(object sender, ChartScroll3DEventArgs e) {
            if (e.ScrollDirection == ChartScrollDirection.Horizontal || e.ScrollDirection == ChartScrollDirection.Both)
                tbcHorizontalScrollPercent.Value = (int)Math.Round(e.NewHorizontalScrollPercent);
            if (e.ScrollDirection == ChartScrollDirection.Vertical || e.ScrollDirection == ChartScrollDirection.Both)
                tbcVerticalScrollPercent.Value = (int)Math.Round(e.NewVerticalScrollPercent);
        }

        protected override void UpdateRotationAngles(Diagram3D diagram) {
            diagram.RotationAngleY = 30;
            diagram.VerticalScrollPercent = 5;
            diagram.HorizontalScrollPercent = 0;
            diagram.ZoomPercent = 140;
            UpdateScrollAndZoomControls();
        }
    }
}
