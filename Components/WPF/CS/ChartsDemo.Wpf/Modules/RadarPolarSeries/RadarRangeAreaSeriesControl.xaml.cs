using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Editors;
using System.Windows;

namespace ChartsDemo {
    [CodeFile("Modules/RadarPolarSeries/RadarRangeAreaSeriesControl(.SL).xaml"),
     CodeFile("Modules/RadarPolarSeries/RadarRangeAreaSeriesControl.xaml.(cs)")]
    public partial class RadarRangeAreaSeriesControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public RadarRangeAreaSeriesControl() {
            InitializeComponent();
            RangeArea2DHelper.PrepareComboBox(cbeLabelKind, 0);
        }

        void cbeLabelKind_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            RangeAreaLabelKind labelKind = RangeArea2DHelper.GetMode(sender as ComboBoxEdit);
            CircularRangeAreaSeries2D.SetLabelKind(series.Label, labelKind);
        }
    }
}
