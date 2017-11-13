using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
    public partial class ScatterLineDemo : ChartDemoLineBase {
        const int A = 10;
        const int ArchimedeanSpiralIndex = 0;
        const int CardioidIndex = 1;
        const int CartesianFoliumIndex = 2;

        SeriesCollection Series { get { return chart.Series; } }
        Series ArchimedeanSpiralSeries { get { return Series[ArchimedeanSpiralIndex]; } }
        Series CardioidSeries { get { return Series[CardioidIndex]; } }
        Series CartesianFoliumSeries { get { return Series[CartesianFoliumIndex]; } }
        protected override Series[] ProcessedSeries { get { return new Series[] { ArchimedeanSpiralSeries, CardioidSeries, CartesianFoliumSeries }; } }
        protected override DefaultBoolean CrosshairEnabled { get { return DefaultBoolean.False; } }
        protected override DefaultBoolean ToolTipEnabled { get { return DefaultBoolean.True; } }
        public override ChartControl ChartControl { get { return chart; } }

        public ScatterLineDemo() {
            InitializeComponent();
            
        }
        void CreateArchimedeanSpiralPoints() {
            for (int i = 0; i < 720; i += 10) {
                double t = (double)i / 180 * Math.PI;
                double x = t * Math.Cos(t);
                double y = t * Math.Sin(t);
                ArchimedeanSpiralSeries.Points.Add(new SeriesPoint(x, y));
            }
        }
        void CreateCardioidPoints() {
            for (int i = 0; i < 360; i += 10) {
                double t = (double)i / 180 * Math.PI;
                double x = A * (2 * Math.Cos(t) - Math.Cos(2 * t));
                double y = A * (2 * Math.Sin(t) - Math.Sin(2 * t));
                CardioidSeries.Points.Add(new SeriesPoint(x, y));
            }
        }
        void CreateCartesianFoliumPoints() {
            for (int i = -30; i < 125; i += 5) {
                double t = Math.Tan((double)i / 180 * Math.PI);
                double x = 3 * (double)A * t / (t * t * t + 1);
                double y = x * t;
                CartesianFoliumSeries.Points.Add(new SeriesPoint(x, y));
            }
        }
        void ShowSeries(Series visibleSeries) {
            foreach (Series series in Series) {
                if (series == visibleSeries) {
                    visibleSeries.Visible = true;
                    seriesSelected = series;
                }
                else
                    series.Visible = false;
            }
        }
        void comboBoxEditFunctionType_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxEditFunctionType.SelectedIndex == ArchimedeanSpiralIndex) {
                if (ArchimedeanSpiralSeries.Points.Count == 0)
                    CreateArchimedeanSpiralPoints();
                ShowSeries(ArchimedeanSpiralSeries);
            }
            else if(comboBoxEditFunctionType.SelectedIndex == CardioidIndex) {
                if (CardioidSeries.Points.Count == 0)
                    CreateCardioidPoints();
                ShowSeries(CardioidSeries);
            }
            else if(comboBoxEditFunctionType.SelectedIndex == CartesianFoliumIndex) {
                if (CartesianFoliumSeries.Points.Count == 0)
                    CreateCartesianFoliumPoints();
                ShowSeries(CartesianFoliumSeries);
            }
            ChartControl.Animate();
        }
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = false;
            comboBoxEditFunctionType.SelectedIndex = ArchimedeanSpiralIndex;
            foreach (Series series in chart.Series)
                series.ToolTipPointPattern = "{A:F2} : {V:F2}";
        }       
    }
}

