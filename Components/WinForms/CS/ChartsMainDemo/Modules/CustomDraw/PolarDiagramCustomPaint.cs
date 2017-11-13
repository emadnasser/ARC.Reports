using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DevExpress.XtraCharts.Demos.CustomDraw {
    public partial class PolarDiagramCustomPaintDemo : ChartDemoBase2D {
        const int ImageWidth = 64;
        const int ImageHeight = 64;

        Target target1;
        Target target2;
        Target target3;
        Random random;
        int delayTime = 0;
        int radius;
        ControlCoordinates center;

        PolarDiagram PolarDiagram { get { return chart != null ? chart.Diagram as PolarDiagram : null; } }
        bool ShouldProcessTarget {
            get {
                return PolarDiagram != null &&
                    center != null &&
                    PolarDiagram.StartAngleInDegrees == 0 &&
                    PolarDiagram.DrawingStyle == RadarDiagramDrawingStyle.Circle &&
                    chart.Series[0].ValueScaleType == ScaleType.Numerical;
            }
        }

        public override ChartControl ChartControl { get { return this.chart; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } }
        public RadarAxisX AxisX { get { return PolarDiagram.AxisX; } }
        public RadarAxisY AxisY { get { return PolarDiagram.AxisY; } }
        
        public PolarDiagramCustomPaintDemo() {
            InitializeComponent();
            random = new Random();
            target1 = new Target(Math.PI / 2, (double)AxisX.VisualRange.MaxValue / 8, (double)AxisY.VisualRange.MaxValue / 2);
            target2 = new Target(0, (double)AxisX.VisualRange.MinValue, (double)AxisY.VisualRange.MinValue);
            target3 = new Target(-Math.PI / 2, -(double)AxisX.VisualRange.MaxValue / 8, (double)AxisY.VisualRange.MaxValue / 2);
            using (MemoryStream ms = new MemoryStream(global::DevExpress.XtraCharts.Demos.Properties.Resources.CrossCursor)) {
                chart.Cursor = new Cursor(ms);
            }
            timer.Enabled = true;
        }

        void CalculateCircle() {
            center = PolarDiagram.DiagramToPoint((double)AxisX.VisualRange.MinValue, (double)AxisY.VisualRange.MinValue);
            ControlCoordinates circlePoint = PolarDiagram.DiagramToPoint((double)AxisX.VisualRange.MinValue, (double)AxisY.VisualRange.MaxValue);
            radius = center.Point.Y - circlePoint.Point.Y;
        }
        void timer_Tick(object sender, EventArgs e) {
            if (!ShouldProcessTarget)
                return;
            if (target1.IsHit && target2.IsHit && target3.IsHit) {
                if (delayTime > 20) {
                    delayTime = 0;
                    target1.Recover();
                    target2.Recover();
                    target3.Recover();
                }
                else
                    delayTime += 1;
            }
            else {
                if (!target1.IsHit)
                    MoveTarget(target1);
                if (!target2.IsHit)
                    MoveTarget(target2);
                if (!target3.IsHit)
                    MoveTarget(target3);
                chart.Invalidate();
            }
        }
        void MoveTarget(Target target) {
            ControlCoordinates imageCenter = PolarDiagram.DiagramToPoint(target.Argument, target.Value);
            int imageCenterX = imageCenter.Point.X;
            int imageCenterY = imageCenter.Point.Y;
            int stepX, stepY;
            double currentRadius;
            int counter = 0;
            do {
                if (counter > 1000) {
                    imageCenterX = center.Point.X;
                    imageCenterY = center.Point.Y;
                }
                double extraAngle = (random.Next(50) - 25) * Math.PI / 180;
                target.MovementAngle += extraAngle;
                stepX = (int)(5 * Math.Cos(target.MovementAngle));
                stepY = (int)(5 * Math.Sin(target.MovementAngle));
                int deltaX = center.Point.X - imageCenterX - stepX;
                int deltaY = center.Point.Y - imageCenterY - stepY;
                currentRadius = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                counter++;
            }
            while (currentRadius >= radius);
            int x = imageCenterX + stepX;
            int y = imageCenterY + stepY;
            DiagramCoordinates diagramImageCenter = PolarDiagram.PointToDiagram(new Point(x, y));
            target.Argument = diagramImageCenter.NumericalArgument;
            target.Value = diagramImageCenter.NumericalValue;
        }
        void DrawTarget(Graphics g, Target target) {
            ControlCoordinates imageCenter = PolarDiagram.DiagramToPoint(target.Argument, target.Value);
            int left = imageCenter.Point.X - ImageWidth / 2;
            int top = imageCenter.Point.Y - ImageHeight / 2;
            g.DrawImage(target.Image, left, top, ImageWidth, ImageHeight);
        }
        void CheckHit(int x, int y, Target target) {
            ControlCoordinates imageCenter = PolarDiagram.DiagramToPoint(target.Argument, target.Value);
            int left = imageCenter.Point.X - ImageWidth / 2;
            int top = imageCenter.Point.Y - ImageHeight / 2;
            if (!target.IsHit && left + 13 <= x && x <= left + ImageWidth - 13 && top + 8 <= y && y <= top + ImageHeight - 8)
                target.Hit();
        }
        void chart_CustomPaint(object sender, CustomPaintEventArgs e) {
            if (PolarDiagram == null)
                return;
            Graphics g = e.Graphics;
            CalculateCircle();
            DrawTarget(g, target1);
            DrawTarget(g, target2);
            DrawTarget(g, target3);
        }
        void chart_MouseDown(object sender, MouseEventArgs e) {
            if (!ShouldProcessTarget)
                return;
            CheckHit(e.X, e.Y, target1);
            CheckHit(e.X, e.Y, target2);
            CheckHit(e.X, e.Y, target3);
        }      
    }

    class Target {
        double movementAngle;
        bool isHit = false;
        double _value;
        double argument;
        Image image;

        public double MovementAngle { get { return movementAngle; } set { movementAngle = value; } }
        public bool IsHit { get { return isHit; } set { isHit = value; } }
        public double Value { get { return _value; } set { _value = value; } }
        public double Argument { get { return argument; } set { argument = value; } }
        public Image Image { get { return image; } set { image = value; } }

        public Target(double movementAngle, double argument, double value) {
            this.movementAngle = movementAngle;
            this.argument = argument;
            _value = value;
            image = global::DevExpress.XtraCharts.Demos.Properties.Resources.Bug;
        }

        public void Hit() {
            isHit = true;
            image = global::DevExpress.XtraCharts.Demos.Properties.Resources.NoBug;
        }
        public void Recover() {
            isHit = false;
            image = global::DevExpress.XtraCharts.Demos.Properties.Resources.Bug;
        }
    }
}
