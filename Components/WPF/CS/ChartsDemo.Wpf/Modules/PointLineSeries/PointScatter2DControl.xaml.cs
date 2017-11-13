using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;
using System.Windows;

namespace ChartsDemo {
    [CodeFile("Modules/PointLineSeries/PointScatter2DControl(.SL).xaml"),
     CodeFile("Modules/PointLineSeries/PointScatter2DControl.xaml.(cs)")]
    public partial class PointScatter2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public PointScatter2DControl() {
            InitializeComponent();
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(typeof(RingMarker2DModel));
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
    }
}
