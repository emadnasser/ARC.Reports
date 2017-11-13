using System;
using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.CustomDraw {
    public partial class SeriesPointsDemo : ChartDemoBase2D {
        const int PointsCount = 25;

        Series Series { get { return chart.Series[0]; } }

        protected override DefaultBoolean CrosshairEnabled { get { return DefaultBoolean.False; } }
        
        public override ChartControl ChartControl { get { return this.chart; } }

        public SeriesPointsDemo() {
            InitializeComponent();
        }

        void simpleButtonRandom_Click(object sender, EventArgs e) {
            InitSeries();
            SetPointsColor(this.checkEditCustomDraw.Checked);
            ChartControl.Animate();
        }
        bool SupportType() {
            return chart.Series[0].View is SideBySideBarSeriesView ||
                   chart.Series[0].View is LineSeriesView ||
                   chart.Series[0].View is AreaSeriesView ||
                   chart.Series[0].View is PointSeriesView;
        }
        void InitSeries() {
            Random random = new Random();
            if (Series != null && SupportType()) {
                Series.Points.Clear();
                for (int i = 0; i < PointsCount; i++)
                    Series.Points.Add(new SeriesPoint(i.ToString(), new double[] { random.NextDouble() * 3 }));
            }
        }
        void chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            if (this.checkEditCustomDraw.Checked && e.SeriesPoint.Values.Length > 0) {
                string color = GetColorName(e.SeriesPoint[0]);
                if (!String.IsNullOrEmpty(color))
                    e.LabelText = color + ": " + e.LabelText;
            }
        }
        void checkEditCustomDraw_CheckedChanged(object sender, EventArgs e) {
            SetPointsColor(this.checkEditCustomDraw.Checked);
            this.chart.Invalidate();
        }
        string GetColorName(double val) {
            if (val < 1)
                return "Green";
            else if (val < 2)
                return "Yellow";
            else
                return "Red";
        }
        void SetPointsColor(bool colorize) {
            if (Series != null && SupportType()) {
                for (int i = 0; i < Series.Points.Count; i++)
                    SetColor(Series.Points[i], colorize);
            }
        }
        void SetColor(SeriesPoint point, bool colorize) {
            double val = point.Values[0];
            Color color;
            if (colorize) {
                if (val < 1)
                    color = Color.FromArgb(81, 137, 3);
                else if (val < 2)
                    color = Color.FromArgb(249, 170, 15);
                else
                    color = Color.FromArgb(199, 57, 12);
            }
            else
                color = Color.Empty;
            point.Color = color;
        }

        protected override void InitControls() {
            base.InitControls();
            this.checkEditCustomDraw.Checked = true;
            InitSeries();
            SetPointsColor(this.checkEditCustomDraw.Checked);
            ShowLabels = true;
        }

        public override void UpdateControls() {
            base.UpdateControls();
        }
    }
}
