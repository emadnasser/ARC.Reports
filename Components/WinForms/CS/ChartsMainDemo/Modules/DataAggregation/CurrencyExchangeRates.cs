using System;
using System.Globalization;
using System.IO;
using System.Xml;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.DataAggregation {
    public partial class CurrencyExchangeRatesDemo : ChartDemoBase {
        XYDiagram Diagram { get { return chart.Diagram as XYDiagram; } }
        AxisBase AxisX { get { return Diagram != null ? Diagram.AxisX : null; } }
        Series SeriesGBP { get { return chart.Series[0]; } }
        Series SeriesEUR { get { return chart.Series[1]; } }

        public override ChartControl ChartControl { get { return chart; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } }

        public CurrencyExchangeRatesDemo() {
            InitializeComponent();
        }

        void LoadSeries(Series series, string xmlFile) {
            LoadPoints(series, AssemblyHelper.GetEmbeddedResourceStream(typeof(CurrencyExchangeRatesDemo).Assembly, xmlFile, false));
        }
        void LoadPoints(Series series, Stream xmlStream) {
            if (series != null && xmlStream != null) {
                XmlDocument document = new XmlDocument();
                document.Load(xmlStream);
                series.Points.BeginUpdate();
                series.Points.Clear();
                if (document != null) {
                    XmlNodeList elements = document.DocumentElement.GetElementsByTagName("CurrencyRate");
                    foreach (XmlNode element in elements) {
                        DateTime date = DateTime.Parse(element.ChildNodes[0].InnerText, CultureInfo.InvariantCulture);
                        double rate = double.Parse(element.ChildNodes[1].InnerText, CultureInfo.InvariantCulture);
                        series.Points.Add(new SeriesPoint(date, rate));
                    }
                }
                series.Points.EndUpdate();
            }
        }

        protected override void InitControls() {
            base.InitControls();
            LoadSeries(SeriesGBP, "GbpUsdRate.xml");
            LoadSeries(SeriesEUR, "EurUsdRate.xml");
            TimeSpan offset = new TimeSpan(366 * 2, 0, 0, 0);
            AxisX.VisualRange.SetMinMaxValues((DateTime)AxisX.VisualRange.MaxValue - offset, (DateTime)AxisX.VisualRange.MaxValue);
        }

        void CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            int elementIndex = 0;
            foreach (CrosshairElementGroup crosshairGroup in e.CrosshairElementGroups) {
                foreach (CrosshairElement crosshairElement in crosshairGroup.CrosshairElements) {
                    CrosshairLabelElement labelElement = crosshairElement.LabelElement;
                    labelElement.MarkerSize = new System.Drawing.Size(0, 0);
                    labelElement.MarkerVisible = false;
                    labelElement.TextColor = chart.PaletteRepository[chart.PaletteName][elementIndex].Color;
                    elementIndex++;
                }
            }
        }
    }
}
