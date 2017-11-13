namespace DevExpress.XtraCharts.Demos.AreaViews {
	public partial class StackedArea3dDemo : Area3dDemoBase {
		ChartControl chart;

		public override ChartControl ChartControl { get { return this.chart; } }

		public StackedArea3dDemo() {
			InitializeComponent();
		}
        protected override void InitControls() {
            base.InitControls();
            ChartControl.DataSource = DevAV.GetSalesByLast10Years();
        }
    }
}
