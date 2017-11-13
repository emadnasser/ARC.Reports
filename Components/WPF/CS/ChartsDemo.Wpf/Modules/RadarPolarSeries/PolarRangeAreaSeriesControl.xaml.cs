using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;
using System.Collections.Generic;
using DevExpress.Xpf.Editors;

namespace ChartsDemo {
    [CodeFile("Modules/RadarPolarSeries/PolarRangeAreaSeriesControl(.SL).xaml"),
     CodeFile("Modules/RadarPolarSeries/PolarRangeAreaSeriesControl.xaml.(cs)")]
    public partial class PolarRangeAreaSeriesControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public PolarRangeAreaSeriesControl() {
            InitializeComponent();
            RangeArea2DHelper.PrepareComboBox(cbeLabelKind, 4);
            chart.DataSource = FunctionsPointGenerator.GeneratePoints(CircularFunction.Lemniskate);
        }

        void lbFunction_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            CircularFunction f;
            if ((string)lbFunction.SelectedItem == "Taubin's Heart")
                f = CircularFunction.TaubinsHeart;
            else if ((string)lbFunction.SelectedItem == "Cardioid")
                f = CircularFunction.Cardioid;
            else
                f = CircularFunction.Lemniskate;
            chart.DataSource = FunctionsPointGenerator.GeneratePoints(f);
            chart.Animate();
        }
        void cbeLabelKind_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            RangeAreaLabelKind labelKind = RangeArea2DHelper.GetMode(sender as ComboBoxEdit);
            CircularRangeAreaSeries2D.SetLabelKind(series.Label, labelKind);
        }
    }
}
