using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.DataBinding {
	public partial class TagPropertyDemo : ChartDemoBase2D {
        ChartControl chart;

		public override ChartControl ChartControl { get { return this.chart; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } } 

        public TagPropertyDemo() {
			InitializeComponent();
		}

        void chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = (string)((DataRowView)e.SeriesPoint.Tag)["OfficialName"];
        }
        void chart_BoundDataChanged(object sender, System.EventArgs e) {
            ChartControl.Animate();
        }

        protected override void InitControls() {
			base.InitControls();
            ShowLabels = true;
            ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;           
			string path = Utils.GetRelativePath("countriesDB.mdb");
			if (path.Length > 0)
				Utils.SetConnectionString(this.oleDbConnection1, path);
            else {
                XtraMessageBox.Show("The \"countriesDB.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                this.oleDbDataAdapter1.Fill(this.dS21);
            }
            catch (OleDbException e) {
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            chart.DataSource = dS21.Countries;
        }
    }
}
