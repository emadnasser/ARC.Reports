using System.Windows;
using System.Collections.Generic;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Editors;
using System.Windows.Media;

namespace ChartsDemo {
    [CodeFile("Modules/DataAnalysis/ErrorBarsControl(.SL).xaml"),
    CodeFile("Modules/DataAnalysis/ErrorBarsControl.xaml.(cs)")]
    public partial class ErrorBarsControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        XYSeries2D series = null;
        ErrorBars indicator = null;

        public ErrorBarsControl() {
            InitializeComponent();
            UpdateSeries();
        }

        T GetListBoxEditItemTag<T>(object obj) {
            return (T)((ListBoxEditItem)obj).Tag;
        }
        void lbeIndicator_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            UpdateIndicator();
        }
        void lbeSeries_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            UpdateSeries();
        }
        void lbeDirection_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            UpdateDirection();
        }
        void lbeEndStyle_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            UpdateEndStyle();
        }
        void UpdateEndStyle() {
            if (indicator != null)
                indicator.EndStyle = GetListBoxEditItemTag<ErrorBarEndStyle>(lbeEndStyle.SelectedItem);
        }
        void UpdateDirection() {
            if (indicator != null)
                indicator.Direction = GetListBoxEditItemTag<ErrorBarDirection>(lbeDirection.SelectedItem);
        }
        void UpdateIndicator() {
            if (series != null) {
                series.Indicators.Clear();
                switch ((string)lbeIndicator.SelectedItem) {
                    case "Fixed Values":
                        indicator = new FixedValueErrorBars() { NegativeError = 1, PositiveError = 3 };
                        break;
                    case "Percentage":
                        indicator = new PercentageErrorBars() { Percent = 10 };
                        break;
                    case "Standard Deviation(s)":
                        indicator = new StandardDeviationErrorBars() { Multiplier = 1 };
                        break;
                    case "Standard Error":
                        indicator = new StandardErrorBars();
                        break;
                    case "Data Source":
                        indicator = new DataSourceBasedErrorBars() { NegativeErrorDataMember = "Negative", PositiveErrorDataMember = "Positive" };
                        break;
                }
                if (indicator != null) {
                    indicator.Brush = new SolidColorBrush(Colors.Black);
                    series.Indicators.Add(indicator);
                }
                UpdateDirection();
                UpdateEndStyle();
            }
        }
        void UpdateSeries() {
            diagram.Series.Clear();
            switch ((string)lbeSeries.SelectedItem) {
                case "Bar":
                    series = new BarSideBySideSeries2D();
                    break;
                case "Point":
                    series = new PointSeries2D();
                    break;
            }
            if (series != null) {
                series.ArgumentDataMember = "Argument";
                series.ValueDataMember = "Value";
                series.DataSource = GetData();
                diagram.Series.Add(series);
            }
            UpdateIndicator();
        }
        List<DataItem> GetData() {
            return new List<DataItem>() {
                new DataItem("A", 20, 5, 8),
                new DataItem("B", 50, 3, 5),
                new DataItem("C", 40, 20, 10),
                new DataItem("D", 22, 15, 5),
                new DataItem("E", 30, 5, 8),
                new DataItem("F", 45, 5, 4),
                new DataItem("G", 35, 5, 3),
                new DataItem("H", 28, 4, 2),
                new DataItem("I", 46, 6, 4),
                new DataItem("J", 27, 8, 20),
                new DataItem("K", 20, 5, 8),
                new DataItem("L", 50, 3, 5),
                new DataItem("M", 40, 20, 10),
                new DataItem("N", 22, 15, 5),
                new DataItem("O", 30, 5, 8),
                new DataItem("P", 45, 5, 2),
                new DataItem("Q", 35, 5, 5),
                new DataItem("R", 28, 4, 4),
                new DataItem("S", 46, 6, 5),
                new DataItem("T", 27, 8, 8),
            };
        }
    }

    public class DataItem {
        public string Argument { get; private set; }
        public int Value { get; private set; }
        public int Negative { get; private set; }
        public int Positive { get; private set; }

        public DataItem(string argument, int value, int negative, int positive) {
            Argument = argument;
            Value = value;
            Negative = negative;
            Positive = positive;
        }
    }
}
