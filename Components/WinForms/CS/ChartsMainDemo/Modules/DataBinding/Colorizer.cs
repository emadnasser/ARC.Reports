namespace DevExpress.XtraCharts.Demos.DataBinding {
    public partial class ColorizerDemo : ChartDemoBase2D {

        public override ChartControl ChartControl { get { return chart; } }

        public ColorizerDemo() {
            InitializeComponent();
            Series series = ChartControl.Series[0];
            RangeColorizer rangeColorizer = new RangeColorizer();
            rangeColorizer.RangeStops.AddRange(new double[] { 22, 30, 38, 46, 54, 64 });
            rangeColorizer.LegendItemPattern = "{V1} - {V2} HPI";
            rangeColorizer.PaletteName = "ColorizerPalette";
            series.Colorizer = rangeColorizer;
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.ArgumentDataMember = "Country";
            series.ValueDataMembers.AddRange(new string[] { "Product", "Population" });
            series.ColorDataMember = "HPI";
            series.ToolTipHintDataMember = "HPI";
            series.DataSource = HPI.GetData();
        }
    }
}
