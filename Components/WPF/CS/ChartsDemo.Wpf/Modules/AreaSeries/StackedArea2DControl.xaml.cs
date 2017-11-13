using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/AreaSeries/StackedArea2DControl(.SL).xaml"),
     CodeFile("Modules/AreaSeries/StackedArea2DControl.xaml.(cs)")]
    public partial class StackedArea2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public StackedArea2DControl() {
            InitializeComponent();
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
    }
}
