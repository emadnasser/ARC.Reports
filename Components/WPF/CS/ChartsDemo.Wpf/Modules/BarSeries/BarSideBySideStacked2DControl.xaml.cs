using System.Windows;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/BarSeries/BarSideBySideStacked2DControl(.SL).xaml"),
     CodeFile("Modules/BarSeries/BarSideBySideStacked2DControl.xaml.(cs)")]
    public partial class BarSideBySideStacked2DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public BarSideBySideStacked2DControl() {
            InitializeComponent();
            chart.DataSource = AgeStructure.GetDataByAgeAndGender();
            GroupSeries();
            lbModel.SelectedItem = Bar2DModelKindHelper.FindActualBar2DModelKind(typeof(SimpleBar2DModel));
        }

        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
        void lbGroupBy_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            GroupSeries();
            chart.Animate();
        }
        void GroupSeries() {
            foreach (BarSideBySideStackedSeries2D series in chart.Diagram.Series) {
                GenderAgeInfo genderAge = (GenderAgeInfo)series.Tag;
                series.StackedGroup = lbGroupBy.SelectedIndex == 0 ? genderAge.Gender : genderAge.Age;
            }
        }
    }
}
