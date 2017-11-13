using System.Data;
using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/PointLineSeries/Bubble2DControl(.SL).xaml"),
     CodeFile("Modules/PointLineSeries/Bubble2DControl.xaml.(cs)")]
    public partial class Bubble2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public Bubble2DControl() {
            InitializeComponent();
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(typeof(RingMarker2DModel));
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
        void chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = ((string)((DataRowView)e.SeriesPoint.Tag).Row["Title"]).Replace("\n", " ");
        }
    }
}
