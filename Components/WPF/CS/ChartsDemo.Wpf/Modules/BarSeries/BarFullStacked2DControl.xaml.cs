using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/BarSeries/BarFullStacked2DControl(.SL).xaml"),
     CodeFile("Modules/BarSeries/BarFullStacked2DControl.xaml.(cs)")]
    public partial class BarFullStacked2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public BarFullStacked2DControl() {
            InitializeComponent();
            lbModel.SelectedItem = Bar2DModelKindHelper.FindActualBar2DModelKind(typeof(FlatGlassBar2DModel));
        }

        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
        void chbPercent_Checked(object sender, RoutedEventArgs e) {
            foreach (BarFullStackedSeries2D series in chart.Diagram.Series)
                series.Label.TextPattern = "{VP:P0}";
        }
        void chbPercent_Unchecked(object sender, RoutedEventArgs e) {
            foreach (BarFullStackedSeries2D series in chart.Diagram.Series)
                series.Label.TextPattern = "${V}K";
        }
    }
}
