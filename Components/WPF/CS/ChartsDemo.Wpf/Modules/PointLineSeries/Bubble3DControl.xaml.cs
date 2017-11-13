using System;
using System.Windows;
using System.Windows.Media.Animation;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Editors;
using System.Data;

namespace ChartsDemo {
    [CodeFile("Modules/PointLineSeries/Bubble3DControl(.SL).xaml"),
     CodeFile("Modules/PointLineSeries/Bubble3DControl.xaml.(cs)")]
    public partial class Bubble3DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public Bubble3DControl() {
            InitializeComponent();
        }
        void lbPosition_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            if (chart != null && lbPosition.SelectedItem != null)
                foreach (MarkerSeries3D series in chart.Diagram.Series)
                    MarkerSeries3D.SetLabelPosition(series.Label, (Marker3DLabelPosition)lbPosition.SelectedItem);
        }
        void lbModel_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            Marker3DKind markerKind = lbModel.SelectedItem as Marker3DKind;
            if (markerKind != null)
                Marker3DModelKindHelper.SetModel(chart, (Marker3DModel)Activator.CreateInstance(markerKind.Type));
        }
        void Bubble3DDemo_ModuleAppear(object sender, RoutedEventArgs e) {
            lbModel.SelectedItem = Marker3DModelKindHelper.FindActualMarker3DModelKind(((BubbleSeries3D)chart.Diagram.Series[0]).ActualModel);
            Storyboard sizeAnimation = Series.TryFindResource("SizeAnimationStoryboard") as Storyboard;
            if (sizeAnimation != null)
                sizeAnimation.Begin(Series);
        }
        void slMaxSize_EditValueChanged(object sender, EditValueChangedEventArgs e) {
            ((BubbleSeries3D)chart.Diagram.Series[0]).MaxSize = (double)e.NewValue;
        }
        void slMinSize_EditValueChanged(object sender, EditValueChangedEventArgs e) {
            ((BubbleSeries3D)chart.Diagram.Series[0]).MinSize = (double)e.NewValue;
        }
        void Storyboard_Completed(object sender, EventArgs e) {
            ((BubbleSeries3D)chart.Diagram.Series[0]).MaxSize = slMaxSize.Value;
            ((BubbleSeries3D)chart.Diagram.Series[0]).MinSize = slMinSize.Value;
        }
        void chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = ((string)((DataRowView)e.SeriesPoint.Tag).Row["Title"]).Replace("\n", " ");
        }
    }
}
