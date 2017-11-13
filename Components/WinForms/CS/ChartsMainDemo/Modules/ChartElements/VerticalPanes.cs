using DevExpress.Utils.Menu;

namespace DevExpress.XtraCharts.Demos.ChartElements {
    public partial class VerticalPanesDemo : ChartDemoBase2D {
        public override ChartControl ChartControl { get { return chart; } }

        public VerticalPanesDemo() {
            InitializeComponent();
        }

        protected override DXPopupMenu ConstructPopupMenu(object obj, ChartControl chartControl) {
            return DXMenuHelper.ConstructPaneMenu(obj, chartControl);
        }
    }
}

