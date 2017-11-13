using System;
using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/PointLineSeries/Point3DControl(.SL).xaml"),
     CodeFile("Modules/PointLineSeries/Point3DControl.xaml.(cs)")]
    public partial class Point3DControl : ChartsDemoModule {

        public override ChartControlBase ActualChart { get { return chart; } }

        public Point3DControl() {
            InitializeComponent();
  }

        void lbModel_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            Marker3DKind markerKind = lbModel.SelectedItem as Marker3DKind;
            if (markerKind != null)
                Marker3DModelKindHelper.SetModel(chart, (Marker3DModel)Activator.CreateInstance(markerKind.Type));
        }
        void lbPosition_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            if (chart != null) {
                foreach (MarkerSeries3D series in chart.Diagram.Series)
                    MarkerSeries3D.SetLabelPosition(series.Label, (Marker3DLabelPosition)lbPosition.SelectedItem);
            }
        }
        void chart_Loaded(object sender, RoutedEventArgs e) {
            lbPosition.SelectedIndex = (int)MarkerSeries3D.GetLabelPosition(chart.Diagram.Series[0].Label);
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            lbModel.SelectedItem = Marker3DModelKindHelper.FindActualMarker3DModelKind(((PointSeries3D)chart.Diagram.Series[0]).ActualModel);
        }
    }
}
