using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/AreaSeries/StackedArea3DControl(.SL).xaml"),
     CodeFile("Modules/AreaSeries/StackedArea3DControl.xaml.(cs)")]
    public partial class StackedArea3DControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public StackedArea3DControl() {
            InitializeComponent();
        }
    }
}
