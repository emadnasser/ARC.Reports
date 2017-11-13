using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/AreaSeries/StackedStepArea2DControl(.SL).xaml"),
     CodeFile("Modules/AreaSeries/StackedStepArea2DControl.xaml.(cs)")]
    public partial class StackedStepArea2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public StackedStepArea2DControl() {
            InitializeComponent();
            foreach (AreaStackedSeries2D series in chart.Diagram.Series)
                series.CrosshairLabelPattern = "{S}\n{V:0.00}";
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
    }
}
