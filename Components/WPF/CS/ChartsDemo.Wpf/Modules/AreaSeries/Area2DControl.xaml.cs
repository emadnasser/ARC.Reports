using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/AreaSeries/Area2DControl(.SL).xaml"),
     CodeFile("Modules/AreaSeries/Area2DControl.xaml.(cs)")]
    public partial class Area2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public Area2DControl() {
            InitializeComponent();
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(typeof(RingMarker2DModel));

        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
    }
}
