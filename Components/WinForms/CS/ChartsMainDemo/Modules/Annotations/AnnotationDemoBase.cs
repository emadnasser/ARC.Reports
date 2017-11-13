using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.Annotations {
    public partial class AnnotationDemoBase : ChartDemoBase2D {
        public override ChartControl ChartControl { get { return this.chart; } }
        protected override DefaultBoolean CrosshairEnabled { get { return DefaultBoolean.False; } }

        public AnnotationDemoBase() {
            InitializeComponent();
            GeneratePoints();
        }
        void GeneratePoints() {
            Random random = new Random();
            if (chart.Series.Count > 0) {
                chart.BeginInit();
                Series series = chart.Series[0];
                series.Points.Clear();
                SeriesPoint maxPoint = null;
                SeriesPoint minPoint = null;
                for (int i = 0; i < 10; i++) {
                    double value = Math.Round(random.NextDouble() * 8, 2) + 2;
                    SeriesPoint point = new SeriesPoint(i + 1, value);
                    if (maxPoint == null || value > maxPoint.Values[0])
                        maxPoint = point;
                    if (minPoint == null || value < minPoint.Values[0])
                        minPoint = point;
                    series.Points.Add(point);
                }
                AddAnnotation(maxPoint, true);
                AddAnnotation(minPoint, false);
                UpdatePosition();
                UpdateAngle();
                UpdateConnector();
                UpdateShape();
                chart.EndInit();
            }
        }
        void UpdatePosition() {
            foreach (Annotation annotation in chart.AnnotationRepository) {
                RelativePosition position = annotation.ShapePosition as RelativePosition;
                SeriesPointAnchorPoint anchorPoint = annotation.AnchorPoint as SeriesPointAnchorPoint;
                if (position != null && anchorPoint != null) {
                    position.ConnectorLength = 75;
                    if (anchorPoint.SeriesPoint.NumericalArgument > 5)
                        position.Angle = 125;
                }
            }
        }
        void UpdateAngle() {
            foreach (Annotation annotation in chart.AnnotationRepository) {
                annotation.Angle = tbcAngle.Value;
                OnUpdateAngle(annotation);
            }
        }
        void UpdateConnector() {
            foreach (Annotation annotation in chart.AnnotationRepository)
                annotation.ConnectorStyle = (AnnotationConnectorStyle)cbeConnector.SelectedIndex;
        }
        void UpdateShape() {
            foreach (Annotation annotation in chart.AnnotationRepository)
                annotation.ShapeKind = (ShapeKind)cbeShape.SelectedIndex;
        }
        void tbcAngle_EditValueChanged(object sender, EventArgs e) {
            UpdateAngle();
        }
        void cbeConnector_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateConnector();
        }
        void cbeShape_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateShape();
        }
        void sbGeneratePoints_Click(object sender, EventArgs e) {
            GeneratePoints();
        }
        protected virtual void AddAnnotation(SeriesPoint point, bool isMaximum) {
        }
        protected virtual void OnUpdateAngle(Annotation annotation) {
        }
    }
}
