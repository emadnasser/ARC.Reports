using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/PointLineSeries/StepLine2DControl(.SL).xaml"),
     CodeFile("Modules/PointLineSeries/StepLine2DControl.xaml.(cs)")]
    public partial class StepLine2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public StepLine2DControl() {
            InitializeComponent();
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(typeof(CrossMarker2DModel));
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }

    }
}
