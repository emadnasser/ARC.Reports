using System.Globalization;
using System.Windows;
using System.Windows.Markup;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/FinancialSeries/CandleStick2DControl(.SL).xaml"),
     CodeFile("Modules/FinancialSeries/CandleStick2DControl.xaml.(cs)")]
    public partial class CandleStick2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public CandleStick2DControl() {
            InitializeComponent();
            lbModel.SelectedItem = CandleStick2DModelKindHelper.FindActualCandleStick2DModelKind(typeof(SimpleCandleStick2DModel));
            chart.Diagram.Series[0].DataSource = FinancialDataLoader.GetGoogleStockData();
            this.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.Name);
        }
        public override bool SupportSidebarContent() {
            return false;
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }

        void cbReductionLevel_SelectionChanged(object sender, RoutedEventArgs e) {
            if (chart != null) {
                CandleStickSeries2D series = (CandleStickSeries2D)chart.Diagram.Series[0];
                series.ReductionOptions.Level = (StockLevel)cbReductionLevel.SelectedIndex;
            }
        }
    }
}
