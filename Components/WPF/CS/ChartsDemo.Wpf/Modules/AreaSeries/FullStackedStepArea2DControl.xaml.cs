using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/AreaSeries/FullStackedStepArea2DControl(.SL).xaml"),
     CodeFile("Modules/AreaSeries/FullStackedStepArea2DControl.xaml.(cs)")]
    public partial class FullStackedStepArea2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public FullStackedStepArea2DControl() {
            InitializeComponent();
            foreach (AreaStackedSeries2D series in chart.Diagram.Series)
                series.CrosshairLabelPattern = "{S}\n{V:0.00}";
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
        void chbPercent_Checked(object sender, RoutedEventArgs e) {
            if (chart != null)
                foreach (AreaStepFullStackedSeries2D series in ((XYDiagram2D)chart.Diagram).Series)
                    series.Label.TextPattern = "{VP:P0}";
        }
        void chbPercent_UnChecked(object sender, RoutedEventArgs e) {
            if (chart != null)
                foreach (AreaStepFullStackedSeries2D series in ((XYDiagram2D)chart.Diagram).Series)
                    series.Label.TextPattern = "{V:N0}";
        }
    }
}
