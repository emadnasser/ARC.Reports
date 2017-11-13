using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/AreaSeries/StackedSplineArea2DControl(.SL).xaml"),
     CodeFile("Modules/AreaSeries/StackedSplineArea2DControl.xaml.(cs)")]
    public partial class StackedSplineArea2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public StackedSplineArea2DControl() {
            InitializeComponent();
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
    }
}
