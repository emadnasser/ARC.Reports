using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/BarSeries/BarSideBySide2DControl(.SL).xaml"),
     CodeFile("Modules/BarSeries/BarSideBySide2DControl.xaml.(cs)")]
    public partial class BarSideBySide2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public BarSideBySide2DControl() {
            InitializeComponent();
        }

        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
    }
}
