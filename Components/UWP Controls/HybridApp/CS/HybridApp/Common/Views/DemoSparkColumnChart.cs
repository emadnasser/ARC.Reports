using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace HybridApp.Views {
    public class DemoSparkColumnChart : DemoSparkLineChart {
        double offset = 1.5;
        double fractionOffsetColumn = 0;

        public static readonly DependencyProperty AutoScaleProperty =
            DependencyProperty.Register("AutoScale", typeof(bool), typeof(DemoSparkColumnChart), null);
        public bool AutoScale {
            get { return (bool)GetValue(AutoScaleProperty); }
            set { SetValue(AutoScaleProperty, value); }
        }
        public double Offset {
            get { return offset; }
            set { offset = value; }
        }
        public double FractionOffsetColumn {
            get { return fractionOffsetColumn; }
            set { fractionOffsetColumn = value; }
        }

        public DemoSparkColumnChart() {
            DefaultStyleKey = typeof(DemoSparkColumnChart);
            StrokeThickness = 0;
        }
        public TextBlock TextBlockFirstValue { get; set; }
        public TextBlock TextBlockLastValue { get; set; }
        protected internal override PathSegmentCollection GenerateSegments(IList<double> points) {
            PathSegmentCollection segments = new PathSegmentCollection();
            segments.Add(new PolyLineSegment() { Points = CreateColumn(points) });
            return segments;
        }

        PointCollection CreateColumn(IList<double> points) {
            PointCollection pointCollection = new PointCollection();
            if(points.Count == 0)
                return pointCollection;
            double maxValue = points[0];
            double minValue = points[0];
            foreach(double point in points) {
                if(point > maxValue) maxValue = point;
                if(point < minValue) minValue = point;
            }
            double columnOffset = minValue * ((fractionOffsetColumn <= 1.0) ? fractionOffsetColumn : 1.0);
            maxValue -= columnOffset;
            double scale = (AutoScale == false) ? Scale : maxValue / MaxAvailableHeight;
            for(int i = 0; i < points.Count; i++) {
                pointCollection.Add(new Point((Step * i) + offset, MaxAvailableHeight));
                pointCollection.Add(new Point((Step * i) + offset, MaxAvailableHeight - (points[i] - columnOffset) / scale));
                pointCollection.Add(new Point((Step * i) + Step - offset, MaxAvailableHeight - (points[i] - columnOffset) / scale));
                pointCollection.Add(new Point((Step * i) + Step - offset, MaxAvailableHeight));
            }
            pointCollection.Add(new Point((Step * points.Count) + Step, MaxAvailableHeight));
            return pointCollection;
        }

        PointCollection CreateColumn(double point, int orderNumber) {
            PointCollection points = new PointCollection();

            points.Add(new Point((Step * orderNumber) + offset, MaxAvailableHeight));
            points.Add(new Point((Step * orderNumber) + offset, point));
            points.Add(new Point((Step * orderNumber) + Step - offset, point));
            points.Add(new Point((Step * orderNumber) + Step - offset, MaxAvailableHeight));
            if(orderNumber == 11)
                points.Add(new Point((Step * orderNumber) + Step, MaxAvailableHeight));
            return points;
        }
        protected internal override Point GetStartPoint() {
            return new Point(offset, MaxAvailableHeight);
        }
        protected internal override double GetStep(Size availableSize) {
            return availableSize.Width / (Points.Count);
        }
        protected internal override void CreateStartEndFigure(PathGeometry geom) {
        }
        public void Redraw() {
            UpdateLayout();
            UpdateData();
        }
    }
}
