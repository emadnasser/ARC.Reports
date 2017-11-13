using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;
using System.Windows;

namespace ChartsDemo {
    [CodeFile("Modules/FinancialSeries/Stock2DControl(.SL).xaml"),
     CodeFile("Modules/FinancialSeries/Stock2DControl.xaml.(cs)")]
    public partial class Stock2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public Stock2DControl() {
            InitializeComponent();
            lbModel.SelectedItem = Stock2DModelKindHelper.FindActualStock2DModelKind(typeof(ThinStock2DModel));
            chart.Diagram.Series[0].DataSource = chart.Diagram.Series[0].DataSource = FinancialDataLoader.GetGoogleStockData();
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
        public override bool SupportSidebarContent() {
            return false;
        }
    }

    public class ComboBoxItem {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
