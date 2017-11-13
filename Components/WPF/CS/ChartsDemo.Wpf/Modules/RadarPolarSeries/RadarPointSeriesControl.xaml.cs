using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/RadarPolarSeries/RadarPointSeriesControl(.SL).xaml"),
     CodeFile("Modules/RadarPolarSeries/RadarPointSeriesControl.xaml.(cs)")]
    public partial class RadarPointSeriesControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public RadarPointSeriesControl() {
            InitializeComponent();
            seriesDayTemperature.ToolTipPointPattern = "Date: {A:MMMM}\nTemperature: {V}";
            seriesNightTempertaure.ToolTipPointPattern = "Date: {A:MMMM}\nTemperature: {V}";
        }
    }
}
