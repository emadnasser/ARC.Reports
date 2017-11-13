using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.CustomDraw {
    public partial class XYDiagramCustomPaintDemo : ChartDemoBase2D {
        static readonly Color cluster1Color = Color.FromArgb(89, Color.FromArgb(0xfda3a3));
        static readonly Color cluster1BorderColor = Color.FromArgb(89, Color.FromArgb(0xb41b1b));
        static readonly Color cluster2Color = Color.FromArgb(89, Color.FromArgb(0xa3befd));
        static readonly Color cluster2BorderColor = Color.FromArgb(89, Color.FromArgb(0x1947b3));
        static readonly Color cluster3Color = Color.FromArgb(89, Color.FromArgb(0x9dd987));
        static readonly Color cluster3BorderColor = Color.FromArgb(89, Color.FromArgb(0x61a647));
        static readonly Color selectionRectColor = Color.FromArgb(89, Color.FromArgb(0xf1ea6f));
        static readonly Color selectionRectBorderColor = Color.FromArgb(89, Color.FromArgb(0xbaa500));

        Cluster cluster1 = new Cluster();
        Cluster cluster2 = new Cluster();
        Cluster cluster3 = new Cluster();
        Cluster manualCluster = new Cluster();
        Point firstSelectionCorner = Point.Empty;
        Point lastSelectionCorner = Point.Empty;
        Rectangle selectionRectangle = Rectangle.Empty;

        XYDiagram XYDiagram { get { return (chart.Diagram as XYDiagram); } }
        bool ShouldCreateClusters {
            get {
                return XYDiagram != null &&
                    chart.Series[0].View.GetType().Equals(typeof(PointSeriesView)) &&
                    chart.Series[0].ArgumentScaleType == ScaleType.Numerical;
            }
        }

        protected override DefaultBoolean CrosshairEnabled { get { return DefaultBoolean.False; } }

        public override ChartControl ChartControl { get { return this.chart; } }

        public XYDiagramCustomPaintDemo() {
            InitializeComponent();
            InitSeries();
            cheAutoMode.Checked = true;
            ShowLabels = false;
        }

        void InitSeries() {
            if (chart.Series.Count > 0) {
                Random random = new Random();
                chart.Series[0].Points.Clear();
                chart.Series[0].Points.AddRange(DiagramToPointHelper.CalculatePoints(random, 50, 5, 9));
                chart.Series[0].Points.AddRange(DiagramToPointHelper.CalculatePoints(random, 50, 13, 5));
                chart.Series[0].Points.AddRange(DiagramToPointHelper.CalculatePoints(random, 50, 10, 18));
            }
        }
        void ProcessAutoClusters() {
            List<PointF> points1 = new List<PointF>();
            List<PointF> points2 = new List<PointF>();
            List<PointF> points3 = new List<PointF>();
            DiagramToPointHelper.CalculateClusters(chart.Series[0].Points, points1, points2, points3);
            cluster1.Calculate(points1);
            cluster2.Calculate(points2);
            cluster3.Calculate(points3);
            cluster1.IsClusterSelected = true;
            FillListBox(cluster1.SortedPoints);
        }
        void ProcessManualPoints() {
            DiagramCoordinates firstCoordinate = XYDiagram.PointToDiagram(firstSelectionCorner);
            DiagramCoordinates lastCoordinate = XYDiagram.PointToDiagram(lastSelectionCorner);
            if (firstCoordinate.IsEmpty || lastCoordinate.IsEmpty)
                return;
            PointF firstPoint = new PointF((float)firstCoordinate.NumericalArgument, (float)firstCoordinate.NumericalValue);
            PointF lastPoint = new PointF((float)lastCoordinate.NumericalArgument, (float)lastCoordinate.NumericalValue);
            RectangleF bounds = DiagramToPointHelper.CreateRectangle(firstPoint, lastPoint);
            List<PointF> manualPoints = new List<PointF>();
            foreach (SeriesPoint point in chart.Series[0].Points) {
                float x = (float)point.NumericalArgument;
                float y = (float)point.Values[0];
                if (bounds.Contains(x, y))
                    manualPoints.Add(new PointF(x, y));
            }
            if (manualPoints.Count > 0) {
                manualCluster.Calculate(manualPoints);
                FillListBox(manualCluster.SortedPoints);
            }
        }
        void FillListBox(List<PointF> points) {
            lbSelectedPoints.Items.Clear();
            foreach (PointF point in points)
                lbSelectedPoints.Items.Add(new ListBoxItem(point));
        }
        void ProcessSelection(Point point) {
            SelectCluster(cluster1, point, cluster2, cluster3);
            SelectCluster(cluster2, point, cluster1, cluster3);
            SelectCluster(cluster3, point, cluster1, cluster2);
        }
        void SelectCluster(Cluster cluster, Point point, Cluster inactiveCluster1, Cluster inactiveCluster2) {
            Point[] screenPoints = GetScreenPoints(cluster.ContourPoints);
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(screenPoints);
            if (!cluster.IsClusterSelected && path.IsVisible(point)) {
                inactiveCluster1.IsClusterSelected = false;
                inactiveCluster2.IsClusterSelected = false;
                cluster.IsClusterSelected = true;
                FillListBox(cluster.SortedPoints);
            }
            return;
        }
        double GetRangeMinValue(VisualRange range) {
            return (double)range.MinValue - range.SideMarginsValue;
        }
        double GetRangeMaxValue(VisualRange range) {
            return (double)range.MaxValue + range.SideMarginsValue;
        }
        Rectangle CalculateDiagramBounds() {
            Point p1 = XYDiagram.DiagramToPoint(GetRangeMinValue(XYDiagram.AxisX.VisualRange), GetRangeMinValue(XYDiagram.AxisY.VisualRange)).Point;
            Point p2 = XYDiagram.DiagramToPoint(GetRangeMaxValue(XYDiagram.AxisX.VisualRange), GetRangeMaxValue(XYDiagram.AxisY.VisualRange)).Point;
            return DiagramToPointHelper.CreateRectangle(p1, p2);
        }
        Point[] GetScreenPoints(List<PointF> contourPoints) {
            Point[] screenPoints = new Point[contourPoints.Count];
            for (int i = 0; i < contourPoints.Count; i++)
                screenPoints[i] = XYDiagram.DiagramToPoint(contourPoints[i].X, contourPoints[i].Y).Point;
            return screenPoints;
        }
        void DrawCluster(Cluster cluster, Graphics g, Color color, Color borderColor) {
            Point[] screenPoints = GetScreenPoints(cluster.ContourPoints);
            if (screenPoints.Length > 0) {
                if (cluster.IsClusterSelected) {
                    HatchBrush brush = new HatchBrush(HatchStyle.ForwardDiagonal, color, borderColor);
                    g.FillPolygon(brush, screenPoints);
                    g.DrawPolygon(new Pen(Color.FromArgb(255, borderColor), 2), screenPoints);
                }
                else {
                    g.FillPolygon(new SolidBrush(color), screenPoints);
                    g.DrawPolygon(new Pen(borderColor), screenPoints);
                }
            }
        }
        void simpleButtonRandom_Click(object sender, EventArgs e) {
            if (!ShouldCreateClusters)
                return;
            InitSeries();
            lbSelectedPoints.Items.Clear();
            if (cheAutoMode.Checked)
                ProcessAutoClusters();
            else
                manualCluster.Clear();
            chart.Animate();
            chart.Invalidate();
        }
        void chart_MouseDown(object sender, MouseEventArgs e) {
            if (!ShouldCreateClusters)
                return;
            if (!cheAutoMode.Checked) {
                Rectangle bounds = CalculateDiagramBounds();
                if (bounds.Contains(e.Location))
                    firstSelectionCorner = lastSelectionCorner = e.Location;
            }
            else
                ProcessSelection(e.Location);
        }
        void chart_MouseMove(object sender, MouseEventArgs e) {
            if (!ShouldCreateClusters)
                return;
            if (!firstSelectionCorner.IsEmpty && !cheAutoMode.Checked) {
                lastSelectionCorner = DiagramToPointHelper.GetLastSelectionCornerPosition(e.Location, CalculateDiagramBounds());
                if (!lastSelectionCorner.IsEmpty && firstSelectionCorner != lastSelectionCorner) {
                    selectionRectangle = DiagramToPointHelper.CreateRectangle(firstSelectionCorner, lastSelectionCorner);
                    chart.Invalidate();
                }
            }
        }
        void chart_MouseUp(object sender, MouseEventArgs e) {
            if (!ShouldCreateClusters)
                return;
            if (!cheAutoMode.Checked) {
                if (!selectionRectangle.IsEmpty)
                    ProcessManualPoints();
                firstSelectionCorner = lastSelectionCorner = Point.Empty;
                selectionRectangle = Rectangle.Empty;
            }
        }
        void cheAutoMode_CheckedChanged(object sender, EventArgs e) {
            if (!ShouldCreateClusters)
                return;
            lbSelectedPoints.Items.Clear();
            if (cheAutoMode.Checked) {
                ProcessAutoClusters();
                manualCluster.Clear();
            }
            else {
                cluster1.Clear();
                cluster2.Clear();
                cluster3.Clear();
            }
            chart.Invalidate();
        }
        void chart_CustomPaint(object sender, CustomPaintEventArgs e) {
            if (!ShouldCreateClusters)
                return;
            Graphics g = e.Graphics;
            g.SetClip(CalculateDiagramBounds());
            g.SmoothingMode = SmoothingMode.AntiAlias;
            DrawCluster(cluster1, g, cluster1Color, cluster1BorderColor);
            DrawCluster(cluster2, g, cluster2Color, cluster2BorderColor);
            DrawCluster(cluster3, g, cluster3Color, cluster3BorderColor);
            Point[] screenManualPoints = GetScreenPoints(manualCluster.ContourPoints);
            if (screenManualPoints.Length > 0) {
                g.FillPolygon(new SolidBrush(cluster3Color), screenManualPoints);
                g.DrawPolygon(new Pen(cluster3BorderColor), screenManualPoints);
            }
            if (!selectionRectangle.IsEmpty) {
                g.FillRectangle(new SolidBrush(selectionRectColor), selectionRectangle);
                g.DrawRectangle(new Pen(selectionRectBorderColor), selectionRectangle);
            }
        }
    }


    public class ListBoxItem {
        PointF point;

        public PointF Point { get { return point; } }

        public ListBoxItem(PointF point) {
            this.point = point;
        }

        public override string ToString() {
            return string.Format(CultureInfo.CurrentCulture, "X={0,5:F2}  Y={1,5:F2} ", point.X, point.Y);
        }
    }


    public class Cluster {
        List<PointF> points = new List<PointF>();
        List<PointF> sortedPoints = new List<PointF>();
        List<PointF> contourPoints = new List<PointF>();
        bool isClusterSelected = false;

        public List<PointF> Points { get { return points; } }
        public List<PointF> SortedPoints { get { return sortedPoints; } }
        public List<PointF> ContourPoints { get { return contourPoints; } }
        public bool IsClusterSelected { get { return isClusterSelected; } set { isClusterSelected = value; } }

        public void Calculate(List<PointF> points) {
            this.points = points;
            sortedPoints = DiagramToPointHelper.Sort(points);
            contourPoints = DiagramToPointHelper.CreateClosedCircuit(sortedPoints);
            isClusterSelected = false;
        }
        public void Clear() {
            points.Clear();
            sortedPoints.Clear();
            contourPoints.Clear();
            isClusterSelected = false;
        }
    }


    static class DiagramToPointHelper {
        const double Epsilon = 0.001;

        static PointF CalcRandomPoint(Random random, int xCenter, int yCenter) {
            const int dispersion = 2;
            const int expectedSum = 6;
            PointF point = new PointF();
            double sum = 0;
            for (int i = 0; i < 12; i++)
                sum += random.NextDouble();
            double radius = (sum - expectedSum) * dispersion;
            double angle = random.Next(360) * Math.PI / 180;
            point.X = (float)(xCenter + radius * Math.Cos(angle));
            point.Y = (float)(yCenter + radius * Math.Sin(angle));
            return point;
        }
        static bool AreEqual(PointF point1, PointF point2) {
            return AreEqual(point1.X, point2.X) && AreEqual(point1.Y, point2.Y);
        }
        static bool AreEqual(double number1, double number2) {
            double difference = number1 - number2;
            if (Math.Abs(difference) <= Epsilon)
                return true;
            return false;
        }
        static PointF GetClusterCenter(List<PointF> cluster) {
            if (cluster.Count == 0)
                return PointF.Empty;
            float centerX = 0;
            float centerY = 0;
            foreach (PointF point in cluster) {
                centerX += point.X;
                centerY += point.Y;
            }
            centerX /= cluster.Count;
            centerY /= cluster.Count;
            return new PointF(centerX, centerY);
        }
        static void CreateUpperArc(List<PointF> cluster, List<PointF> sortedCluster) {
            for (int i = 1; i < cluster.Count; i++) {
                if (i + 1 == cluster.Count) {
                    sortedCluster.Add(cluster[i]);
                    break;
                }
                bool shouldAddPoint = false;
                float x0 = sortedCluster[sortedCluster.Count - 1].X;
                float y0 = sortedCluster[sortedCluster.Count - 1].Y;
                float x1 = cluster[i].X;
                float y1 = cluster[i].Y;
                if (x1 == x0) {
                    if (y0 < y1)
                        shouldAddPoint = true;
                }
                else
                    for (int j = i + 1; j < cluster.Count; j++) {
                        if (cluster[j].Y >= (double)(cluster[j].X - x0) * (double)(y1 - y0) / (double)(x1 - x0) + y0) {
                            shouldAddPoint = false;
                            break;
                        }
                        else
                            shouldAddPoint = true;
                    }
                if (shouldAddPoint)
                    sortedCluster.Add(cluster[i]);
            }
        }
        static void CreateBottomArc(List<PointF> cluster, List<PointF> sortedCluster) {
            for (int i = cluster.Count - 1; i >= 0; i--) {
                if (i == 0) {
                    sortedCluster.Add(cluster[i]);
                    break;
                }
                bool shouldAddPoint = false;
                float x0 = sortedCluster[sortedCluster.Count - 1].X;
                float y0 = sortedCluster[sortedCluster.Count - 1].Y;
                float x1 = cluster[i].X;
                float y1 = cluster[i].Y;
                if (x1 == x0) {
                    if (y0 > y1)
                        shouldAddPoint = true;
                }
                else
                    for (int j = i - 1; j >= 0; j--) {
                        if (cluster[j].Y <= (double)(cluster[j].X - x0) * (double)(y1 - y0) / (double)(x1 - x0) + y0) {
                            shouldAddPoint = false;
                            break;
                        }
                        else
                            shouldAddPoint = true;
                    }
                if (shouldAddPoint)
                    sortedCluster.Add(cluster[i]);
            }
        }
        
        public static Rectangle CreateRectangle(Point corner1, Point corner2) {
            int x = corner1.X < corner2.X ? corner1.X : corner2.X;
            int y = corner1.Y < corner2.Y ? corner1.Y : corner2.Y;
            int width = Math.Abs(corner1.X - corner2.X);
            int height = Math.Abs(corner1.Y - corner2.Y);
            return new Rectangle(x, y, width, height);
        }
        public static RectangleF CreateRectangle(PointF corner1, PointF corner2) {
            float x = corner1.X < corner2.X ? corner1.X : corner2.X;
            float y = corner1.Y < corner2.Y ? corner1.Y : corner2.Y;
            float width = Math.Abs(corner1.X - corner2.X);
            float height = Math.Abs(corner1.Y - corner2.Y);
            return new RectangleF(x, y, width, height);
        }
        public static Point GetLastSelectionCornerPosition(Point p, Rectangle bounds) {
            if (p.X < bounds.Left)
                p.X = bounds.Left;
            else if (p.X > bounds.Right)
                p.X = bounds.Right - 1;
            if (p.Y < bounds.Top)
                p.Y = bounds.Top;
            else if (p.Y > bounds.Bottom)
                p.Y = bounds.Bottom - 1;
            return p;
        }
        public static SeriesPoint[] CalculatePoints(Random random, int count, int xCenter, int yCenter) {
            SeriesPoint[] seriesPoints = new SeriesPoint[count];
            for (int i = 0; i < count; i++) {
                PointF point = CalcRandomPoint(random, xCenter, yCenter);
                seriesPoints[i] = new SeriesPoint(point.X, new double[] { point.Y });
            }
            return seriesPoints;
        }
        public static void CalculateClusters(SeriesPointCollection seriesPoints, List<PointF> cluster1, List<PointF> cluster2, List<PointF> cluster3) {
            List<PointF> points = new List<PointF>();
            foreach (SeriesPoint point in seriesPoints)
                points.Add(new PointF((float)point.NumericalArgument, (float)point.Values[0]));
            if (points.Count < 100)
                return;
            PointF nextCenter1 = points[0];
            PointF nextCenter2 = points[50];
            PointF nextCenter3 = points[100];
            PointF center1;
            PointF center2;
            PointF center3;
            do {
                center1 = nextCenter1;
                center2 = nextCenter2;
                center3 = nextCenter3;
                cluster1.Clear();
                cluster2.Clear();
                cluster3.Clear();
                foreach (PointF point in points) {
                    float x = point.X;
                    float y = point.Y;
                    double distance1 = Math.Sqrt((center1.X - x) * (center1.X - x) + (center1.Y - y) * (center1.Y - y));
                    double distance2 = Math.Sqrt((center2.X - x) * (center2.X - x) + (center2.Y - y) * (center2.Y - y));
                    double distance3 = Math.Sqrt((center3.X - x) * (center3.X - x) + (center3.Y - y) * (center3.Y - y));
                    if (distance1 <= distance2 && distance1 <= distance3)
                        cluster1.Add(point);
                    else if (distance2 <= distance1 && distance2 <= distance3)
                        cluster2.Add(point);
                    else
                        cluster3.Add(point);
                }
                nextCenter1 = GetClusterCenter(cluster1);
                nextCenter2 = GetClusterCenter(cluster2);
                nextCenter3 = GetClusterCenter(cluster3);
            } while (!AreEqual(center1, nextCenter1) || !AreEqual(center2, nextCenter2) || !AreEqual(center3, nextCenter3));
        }
        public static List<PointF> Sort(List<PointF> cluster) {
            List<PointF> sortedCluster = new List<PointF>();
            if (cluster.Count == 0)
                return sortedCluster;
            sortedCluster.Add(cluster[0]);
            for (int i = 1; i < cluster.Count; i++) {
                if (sortedCluster[0].X >= cluster[i].X)
                    sortedCluster.Insert(0, cluster[i]);
                else if (sortedCluster[sortedCluster.Count - 1].X <= cluster[i].X)
                    sortedCluster.Insert(sortedCluster.Count, cluster[i]);
                else
                    for (int j = 0; j < sortedCluster.Count - 1; j++) {
                        if (sortedCluster[j].X <= cluster[i].X && sortedCluster[j + 1].X >= cluster[i].X) {
                            sortedCluster.Insert(j + 1, cluster[i]);
                            break;
                        }
                    }
            }
            return sortedCluster;
        }
        public static List<PointF> CreateClosedCircuit(List<PointF> sortedCluster) {
            List<PointF> contourPoints = new List<PointF>();
            if (sortedCluster.Count == 0)
                return contourPoints;
            contourPoints.Add(sortedCluster[0]);
            CreateUpperArc(sortedCluster, contourPoints);
            CreateBottomArc(sortedCluster, contourPoints);
            return contourPoints;
        }
    }
}
