namespace DevExpress.XtraCharts.Demos.AreaViews {
	public partial class StackedAreaDemo : ChartDemoBase2D {
		ChartControl chart;

		public override ChartControl ChartControl { get { return this.chart; } }

		public StackedAreaDemo() {
			InitializeComponent();
		}

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            ChartControl.DataSource = DevAV.GetSalesByLast10Years();
        }
	}
}
