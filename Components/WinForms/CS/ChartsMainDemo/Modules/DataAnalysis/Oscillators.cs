using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Globalization;

namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    public partial class OscillatorsDemo : ChartDemoBase2D {
        #region OscillatorItem class
        class OscillatorItem {
            readonly SeparatePaneIndicator oscillator;

            public SeparatePaneIndicator Oscillator { get { return oscillator; } }

            public OscillatorItem(SeparatePaneIndicator oscillator) {
                this.oscillator = oscillator;
            }
            public override string ToString() {
                return oscillator.Name;
            }
        }
        #endregion

        XYDiagram Diagram { get { return (XYDiagram)chart.Diagram; } }
        OscillatorItem SelectedOscillator { get { return (OscillatorItem)cbeOscillator.SelectedItem; } }

        public override ChartControl ChartControl { get { return chart; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } }

        public OscillatorsDemo() {
            InitializeComponent();
            try {
                chart.DataSource = CsvReader.ReadFinancialData("AUDUSDDaily.csv");
            }
            catch (Exception e) {
                XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, e.Message, "Data Loading Error");
            }
            Diagram.AxisX.WholeRange.SetMinMaxValues(new DateTime(2015, 1, 2), new DateTime(2015, 06, 30));
            Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;
            Diagram.AxisX.WholeRange.SideMarginsValue = 0.7;
            Diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Week;
            Diagram.AxisX.DateTimeScaleOptions.GridOffset = CalculateOffsetToMonday();
            Diagram.AxisX.Interlaced = false;
            InitializeOscillators();
        }

        double CalculateOffsetToMonday() {
            var currentDayOfWeekIndex = (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            return ((int)DayOfWeek.Monday) - currentDayOfWeekIndex;
        }
        void InitializeOscillators() {
            AddOscillator(new AverageTrueRange("(ATR) Average True Range"));
            AddOscillator(new CommodityChannelIndex("(CCI) Commodity Channel Index"));
            AddOscillator(new DetrendedPriceOscillator("(DPO) Detrended Price Oscillator"));
            MovingAverageConvergenceDivergence macd = new MovingAverageConvergenceDivergence("(MACD) Moving Average Convergence/Divergence") { SignalLineColor = Color.LightGray };
            macd.SignalLineStyle.Thickness = 2;
            AddOscillator(macd);
            AddOscillator(new RateOfChange("(RoC) Rate of Change"));
            AddOscillator(new RelativeStrengthIndex("(RSI) Relative Strength Index"));
            AddOscillator(new ChaikinsVolatility("(CHV) Chaikins Volatility"));
            AddOscillator(new TripleExponentialMovingAverageTrix("(TRIX) Triple Exponential Moving Average"));
            AddOscillator(new WilliamsR("(%R) Williams %R"));
            cbeOscillator.SelectedIndex = 0;
        }
        void AddOscillator(SeparatePaneIndicator oscillator) {
            StockSeriesView view = (StockSeriesView)chart.Series[0].View;
            XYDiagram diagram = (XYDiagram)chart.Diagram;
            view.Indicators.Add(oscillator);
            oscillator.AxisY = diagram.SecondaryAxesY[0];
            oscillator.Pane = diagram.Panes[0];
            oscillator.Visible = false;
            oscillator.LineStyle.Thickness = 2;
            oscillator.ShowInLegend = true;
            OscillatorItem item = new OscillatorItem(oscillator);
            cbeOscillator.Properties.Items.Add(item);
        }
        void cbeOscillator_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateControls();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            foreach (OscillatorItem item in cbeOscillator.Properties.Items) {
                if (item == SelectedOscillator) {
                    item.Oscillator.Visible = true;
                    if (chart.AnnotationRepository.Count > 0) {
                        TextAnnotation indicatorAnnotation = chart.AnnotationRepository[0] as TextAnnotation;
                        if (indicatorAnnotation != null)
                            indicatorAnnotation.Text = item.Oscillator.Name;
                    }
                }
                else
                    item.Oscillator.Visible = false;
            }
        }
    }
}
