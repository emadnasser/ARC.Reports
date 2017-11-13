using System;
using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/BarSeries/BarSideBySide3DControl(.SL).xaml"),
     CodeFile("Modules/BarSeries/BarSideBySide3DControl.xaml.(cs)")]
    public partial class BarSideBySide3DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public BarSideBySide3DControl() {
            InitializeComponent();
        }

        void chbVisible_Checked(object sender, RoutedEventArgs e) {
            foreach (BarSideBySideSeries3D series in chart.Diagram.Series)
                series.LabelsVisibility = true;
        }
        void chbVisible_Unchecked(object sender, RoutedEventArgs e) {
            foreach (BarSideBySideSeries3D series in chart.Diagram.Series)
                series.LabelsVisibility = false;
        }
        void lbModel_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            Bar3DKind barKind = lbModel.SelectedItem as Bar3DKind;
            foreach (BarSeries3D series in chart.Diagram.Series)
                series.Model = (Bar3DModel)Activator.CreateInstance(barKind.Type);
        }
        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            Bar3DModel model = ((BarSeries3D)chart.Diagram.Series[0]).ActualModel;
            lbModel.SelectedItem = Bar3DModelKindHelper.FindActualBar3DModelKind(model);
        }
    }
}
