using System;

namespace DevExpress.XtraCharts.Demos.Annotations {
    public partial class AnnotationLayoutDemo : ChartDemoBase2D {
        public override ChartControl ChartControl { get { return this.chart; } }

        public AnnotationLayoutDemo() {
            InitializeComponent();
        }
        void cheMoving_CheckedChanged(object sender, EventArgs e) {
            foreach (Annotation annotation in chart.AnnotationRepository)
                annotation.RuntimeMoving = cheMoving.Checked;
        }
        void cheResizing_CheckedChanged(object sender, EventArgs e) {
            foreach (Annotation annotation in chart.AnnotationRepository)
                annotation.RuntimeResizing = cheResizing.Checked;
        }
        void cheRotation_CheckedChanged(object sender, EventArgs e) {
            foreach (Annotation annotation in chart.AnnotationRepository)
                annotation.RuntimeRotation = cheRotation.Checked;
        }
        void cheAnchoring_CheckedChanged(object sender, EventArgs e) {
            foreach (Annotation annotation in chart.AnnotationRepository)
                annotation.RuntimeAnchoring = cheAnchoring.Checked;
        }
    }
}
