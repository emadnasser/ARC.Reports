using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/PointLineSeries/StackedLine2DControl(.SL).xaml"),
     CodeFile("Modules/PointLineSeries/StackedLine2DControl.xaml.(cs)")]
    public partial class StackedLine2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public StackedLine2DControl() {
            InitializeComponent();
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(typeof(CrossMarker2DModel));
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
    }
}
