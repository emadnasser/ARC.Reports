using System;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace HybridApp.Views {
    public class DemoSparkLineChart : ContentControl {
        double scale = 20;

        public static readonly DependencyProperty PointsProperty = DependencyProperty.Register("Points", typeof(IList<double>), typeof(DemoSparkLineChart), new PropertyMetadata(new List<double>(), (d, e) => ((DemoSparkLineChart)d).OnPointsChanged()));
        public static readonly DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(DemoSparkLineChart), new PropertyMetadata(null, (d, e) => ((DemoSparkLineChart)d).OnFillChanged()));
        public static readonly DependencyProperty StrokeProperty = DependencyProperty.Register("Stroke", typeof(Brush), typeof(DemoSparkLineChart), new PropertyMetadata(null, (d, e) => ((DemoSparkLineChart)d).OnStrokeChanged()));

        public DemoSparkLineChart() {
            DefaultStyleKey = typeof(DemoSparkLineChart);
            PathCore = new Path() { Stroke = new SolidColorBrush(Colors.Red), StrokeThickness = 1, UseLayoutRounding = false };
            Content = PathCore;
            Step = 10;
        }

        protected internal double MaxAvailableHeight { get; private set; }
        public double Scale {
            get { return scale; }
            set {
                if(scale == value)
                    return;
                scale = value;
                InvalidateMeasure();
            }
        }
        internal double Step { get; set; }
        public double StrokeThickness { get { return PathCore.StrokeThickness; } set { PathCore.StrokeThickness = value; } }
        protected internal Path PathCore { get; set; }
        public Brush Fill {
            get { return (Brush)GetValue(FillProperty); }
            set { SetValue(FillProperty, value); }
        }
        public IList<double> Points {
            get { return (IList<double>)GetValue(PointsProperty); }
            set { SetValue(PointsProperty, value); }
        }
        public Brush Stroke {
            get { return (Brush)GetValue(StrokeProperty); }
            set { SetValue(StrokeProperty, value); }
        }
        protected virtual Point CreatePoint(double point, int orderNumber) {
            return new Point(Step * orderNumber, MaxAvailableHeight - (point / Scale));
        }
        protected internal virtual PathSegmentCollection GenerateSegments(IList<double> points) {
            PathSegmentCollection segments = new PathSegmentCollection();
            for(int i = 1; i < points.Count - 1; i++) {
                segments.Add(new LineSegment() { Point = CreatePoint(points[i], i) });
            }
            segments.Add(new LineSegment() { Point = GetEndPoint() });
            return segments;
        }
        protected internal virtual Point GetStartPoint() {
            Point point = CreatePoint(Points[0], 0);
            return new Point(point.X + (Step / 2), point.Y);
        }
        protected internal virtual Point GetEndPoint() {
            Point point = CreatePoint(Points[Points.Count - 1], Points.Count - 1);
            return new Point(point.X - (Step / 2), point.Y);
        }
        protected internal virtual double GetStep(Size availableSize) {
            return availableSize.Width / (Points.Count - 1) + 2;
        }
        void UpdateContent(IList<Double> points, Size availableSize) {
            if(points == null || points.Count == 0 || MaxAvailableHeight == 0)
                return;
            if(availableSize.Width != 0 && !Double.IsInfinity(availableSize.Width)) {
                Step = GetStep(availableSize);
            }
        }
        protected virtual void UpdateData() {
            PathFigure figure = new PathFigure() { StartPoint = GetStartPoint() };
            figure.Segments = GenerateSegments(Points);

            PathGeometry geom = new PathGeometry();
            geom.Figures.Add(figure);
            CreateStartEndFigure(geom);
            PathCore.Data = geom;
        }
        protected internal virtual void CreateStartEndFigure(PathGeometry geom) {
            Point point = GetStartPoint();
            PathFigure figure = new PathFigure() { StartPoint = new Point(point.X - (StrokeThickness / 2), point.Y - (StrokeThickness / 2)) };
            figure.Segments.Add(new ArcSegment() { Size = new Size(1, 1), SweepDirection = SweepDirection.Clockwise, Point = new Point(figure.StartPoint.X + StrokeThickness, figure.StartPoint.Y + StrokeThickness) });
            figure.Segments.Add(new ArcSegment() { Size = new Size(1, 1), SweepDirection = SweepDirection.Clockwise, Point = figure.StartPoint });
            geom.Figures.Add(figure);

            point = GetEndPoint();
            figure = new PathFigure() { StartPoint = new Point(point.X - (StrokeThickness / 2), point.Y - (StrokeThickness / 2)) };
            figure.Segments.Add(new ArcSegment() { Size = new Size(1, 1), SweepDirection = SweepDirection.Clockwise, Point = new Point(figure.StartPoint.X + StrokeThickness, figure.StartPoint.Y + StrokeThickness) });
            figure.Segments.Add(new ArcSegment() { Size = new Size(1, 1), SweepDirection = SweepDirection.Clockwise, Point = figure.StartPoint });
            geom.Figures.Add(figure);
        }

        protected override Size MeasureOverride(Size availableSize) {
            bool allowUpdateData = MaxAvailableHeight == 0;
            MaxAvailableHeight = availableSize.Height;
            if(Double.IsInfinity(MaxAvailableHeight))
                MaxAvailableHeight = GetMaxValue();
            UpdateContent(Points, availableSize);
            if(allowUpdateData)
                UpdateData();
            return base.MeasureOverride(availableSize);
        }
        double GetMaxValue() {
            double maxValue = 0;
            for(int i = 0; i < Points.Count; i++) {
                if(maxValue < Points[i])
                    maxValue = Points[i];
            }
            return (maxValue / Scale) + 1;
        }
        protected internal virtual void OnPointsChanged() {
            UpdateData();
        }
        void OnFillChanged() {
            PathCore.Fill = Fill;
        }
        void OnStrokeChanged() {
            PathCore.Stroke = Stroke;
        }
    }
}
