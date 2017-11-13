using System;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.ChartElements {
    public partial class HorizontalPanesDemo : ChartDemoBase2D {
        Series LeftSeries { get { return chart.Series[0]; } }
        Series RightSeries { get { return chart.Series[1]; } }
        int LeftCategoryDefaultIndex { get { return 2; } }
        int RightCategoryDefaultIndex { get { return 3; } }

        public override ChartControl ChartControl { get { return chart; } }

        public HorizontalPanesDemo() {
            InitializeComponent();
        }

        void LeftSeriesDataBind() {
            if (chart.Series.Count > 0)
                SeriesDataBind(LeftSeries, this.dS31.Categories[cbLeftCategory.SelectedIndex]);
        }
        void RightSeriesDataBind() {
            if (chart.Series.Count > 1)
                SeriesDataBind(RightSeries, this.dS31.Categories[cbRightCategory.SelectedIndex]);
        }
        void SeriesDataBind(Series series, DS3.CategoriesRow row) {
            series.Name = row.CategoryName;
            series.DataFilters.Clear();
            series.DataFilters.Add(new DataFilter("Products.CategoryID", "System.Int32", DataFilterCondition.Equal, row.CategoryID));
            XYDiagramSeriesViewBase view = series.View as XYDiagramSeriesViewBase;
            if (view != null)
                view.AxisX.Title.Text = series.Name;
        }
        void cbLeftCategory_SelectedIndexChanged(object sender, EventArgs e) {
            LeftSeriesDataBind();
        }
        void cbRightCategory_SelectedIndexChanged(object sender, EventArgs e) {
            RightSeriesDataBind();
        }

        protected override void InitControls() {
            base.InitControls();
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
            foreach (DS3.CategoriesRow row in this.dS31.Categories) {
                this.cbLeftCategory.Properties.Items.Add(row.CategoryName);
                this.cbRightCategory.Properties.Items.Add(row.CategoryName);
            }
            this.cbLeftCategory.SelectedIndex = LeftCategoryDefaultIndex;
            this.cbRightCategory.SelectedIndex = RightCategoryDefaultIndex;
            LeftSeriesDataBind();
            RightSeriesDataBind();
        }
        protected override DXPopupMenu ConstructPopupMenu(object obj, ChartControl chartControl) {
            return DXMenuHelper.ConstructPaneMenu(obj, chartControl);
        }
    }
}
