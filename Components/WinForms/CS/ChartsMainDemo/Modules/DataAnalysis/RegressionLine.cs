using System;
using System.Drawing;

namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    public partial class RegressionLineDemo : ChartDemoBase2D {
        const int XMin = 0;
        const int XMax = 100;
        const int PointCount = 40;
        
        static readonly Random random = new Random();

        static double[] CalcRandomY(int[] arrayX) {
            double k = (double)random.Next(-100, 100) / 10;
            if (k < 0.1 && k >= 0)
                k = 0.1;
            if (k > -0.1 && k < 0)
                k = -0.1;
            double b = (double)random.Next(-100, 100) / 10;
            double deviation = Math.Abs(k * (XMax - XMin) * 0.4);
            double[] arrayY = new double[arrayX.Length];
            for (int i = 0; i < arrayY.Length; i++) {
                bool isNegativeDelta = random.Next(0, 1) == 0;
                double delta = deviation * random.NextDouble();
                if(isNegativeDelta)
                    delta = -delta;
                arrayY[i] = k * arrayX[i] + b + delta;
            }
            return arrayY;
        }
        static int[] CalcRandomX() {
            int[] arrayX = new int[PointCount];
            for (int i = 0; i < arrayX.Length; i++)
                arrayX[i] = random.Next(XMin, XMax);
            return arrayX;
        }
        static SeriesPoint[] CalcRandomPointsAroundLine() {
            int[] arrayX = CalcRandomX();
            double[] arrayY = CalcRandomY(arrayX);
            SeriesPoint[] seriesPoints = new SeriesPoint[arrayX.Length];
            for (int i = 0; i < arrayX.Length; i++)
                seriesPoints[i] = new SeriesPoint(arrayX[i], arrayY[i]);
            return seriesPoints;
        }

        Series Series { get { return chart.Series.Count > 0 ? chart.Series[0] : null; } }
        RegressionLine RegressionLine {
            get {
                if (Series != null) {
                    XYDiagramSeriesViewBase view = Series.View as XYDiagramSeriesViewBase;
                    if (view != null)
                        foreach (Indicator indicator in view.Indicators) {
                            RegressionLine regrLine = indicator as RegressionLine;
                            if (regrLine != null)
                                return regrLine;
                        }
                }
                return null;
            }
        }

        public override ChartControl ChartControl { get { return chart; } }
       
        public RegressionLineDemo() {
            InitializeComponent();
            ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
        }

        void InitSeries() {
            if (Series != null && Series.View.GetType().Equals(typeof(PointSeriesView))) {
                Series.Points.Clear();
                Series.Points.AddRange(CalcRandomPointsAroundLine());
            }
        }
        void btnCreateRandomPoints_Click(object sender, EventArgs e) {
            InitSeries();
            RegressionLine.Visible = false;
            ChartControl.Animate();
        }
        void speThickness_EditValueChanged(object sender, EventArgs e) {
            if(RegressionLine != null)
                RegressionLine.LineStyle.Thickness = Convert.ToInt32(speThickness.EditValue);
        }
        void clreColor_EditValueChanged(object sender, EventArgs e) {
            if (RegressionLine != null)
                RegressionLine.Color = (Color)clreColor.EditValue;
        }
        void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            if (RegressionLine != null)
                RegressionLine.LineStyle.DashStyle = (DashStyle)(cbDashStyle.SelectedIndex + 1);
        }
        void chart_AnimationEnded(object sender, EventArgs e) {
            RegressionLine.Visible = true;
        }

        protected override void DoShow() {
            base.DoShow();
            RegressionLine.Visible = false;
        }
        protected override void InitControls() {
            base.InitControls();
            if (RegressionLine != null) {
                clreColor.Color = RegressionLine.Color;
                speThickness.Value = RegressionLine.LineStyle.Thickness;
                cbDashStyle.SelectedIndex = (int)RegressionLine.LineStyle.DashStyle - 1;
            }
            InitSeries();
            ShowLabels = false;
            foreach (Series series in chart.Series)
                series.CrosshairLabelPattern = "{A}: {V:F2}";
        }


    }
}
