using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
    public partial class DrillDownDemo : ChartDemoBase2D {
        readonly string[] summaryColumnName = new string[] { "MinPrice", "MaxPrice", "AvgPrice" };

        Series CategoriesSeries { get { return chart.GetSeriesByName("Categories"); } }
        Series ProductsSeries { get { return chart.GetSeriesByName("Products"); } }
        bool IsCategoriesChart { get { return CategoriesSeries != null ? CategoriesSeries.Visible : false; } }

        protected override bool SeriesSelection { get { return IsCategoriesChart; } }

        public override ChartControl ChartControl { get { return this.chart; } }

        public DrillDownDemo() {
            InitializeComponent();
        }

        void InitProductsChart(SeriesPoint point) {
            if (CategoriesSeries != null && ProductsSeries != null) {
                CategoriesSeries.Visible = false;
                ProductsSeries.DataFilters[0].Value = (int)((DataRowView)point.Tag)["CategoryId"];
                ProductsSeries.LegendText = point.Argument;
                XYDiagramSeriesViewBase view = ProductsSeries.View as XYDiagramSeriesViewBase;
                if (view != null) {
                    AxisXBase axisX = view.AxisX;
                    axisX.Label.Angle = 30;
                    AxisYBase axisY = view.AxisY;
                    axisY.Title.Text = "Price, USD";
                    axisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                    chart.ToolTipOptions.ShowForPoints = true;
                    chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left;
                    chart.Legend.AlignmentVertical = LegendAlignmentVertical.Top;
                    chart.Legend.Margins.All = 10;
                    if (chart.Titles.Count > 1) {
                        chart.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.False;
                        chart.Titles[1].Visibility = DevExpress.Utils.DefaultBoolean.True;
                    }
                }
            }
            ChartControl.Animate();
        }
        void InitCategoriesChart() {
            if (CategoriesSeries != null) {
                CategoriesSeries.Visible = true;
                chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside;
                chart.Legend.AlignmentVertical = LegendAlignmentVertical.Center;
                chart.Legend.Margins.All = 5;
                chart.ToolTipOptions.ShowForPoints = false;
                if (chart.Titles.Count > 1) {
                    chart.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
                    chart.Titles[1].Visibility = DevExpress.Utils.DefaultBoolean.False;
                }
            }
            ChartControl.Animate();
        }
        void comboBoxSummary_SelectedIndexChanged(object sender, EventArgs e) {
            if (CategoriesSeries != null) {
                CategoriesSeries.ValueDataMembers[0] = summaryColumnName[comboBoxSummary.SelectedIndex];
                if (chart.Titles.Count > 0)
                    chart.Titles[0].Text = comboBoxSummary.SelectedItem.ToString() + " Product Prices by Categories";
            }
            ChartControl.Animate();
        }

        protected override bool AllowSelectAnotherObject(object obj) {
            return !IsCategoriesChart && (obj is ChartTitle);
        }
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            ProductsSeries.CrosshairLabelPattern = "Product: {A}\nPrice:     ${V:0.00}";
            ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
            string path = Utils.GetRelativePath("nwind.mdb");
            if (path.Length > 0)
                Utils.SetConnectionString(this.oleDbConnection1, path);
            else {
                XtraMessageBox.Show("The \"nwind.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                this.oleDbDataAdapterCategories.Fill(this.dS31);
                this.oleDbDataAdapterProducts.Fill(this.dS31);
            }
            catch (OleDbException e) {
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            comboBoxSummary.SelectedIndex = 0;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if(IsCategoriesChart) {
                if(seriesSelected != null && pointSelected != null) {
                    InitProductsChart(this.pointSelected);
                    comboBoxSummary.Enabled = false;
                    seriesSelected = null;
                }
            }
            else {
                if(selectedAnotherObject is ChartTitle) {
                    InitCategoriesChart();
                    comboBoxSummary.Enabled = true;
                    selectedAnotherObject = null;
                }
            }
        }
    }
}
