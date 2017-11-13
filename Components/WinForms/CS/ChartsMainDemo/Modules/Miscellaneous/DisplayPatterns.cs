using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	public partial class DisplayPatternsDemo : ChartDemoBase2D {
        ChartControl chart;

        Series Series { get { return chart.Series[0]; } }
        XYDiagram Diagram { get { return chart.Diagram as XYDiagram; } }
        AxisX AxisX { get { return Diagram != null ? Diagram.AxisX : null; } }
        AxisY AxisY { get { return Diagram != null ? Diagram.AxisY : null; } }
		public override ChartControl ChartControl { get { return chart; } }

		public DisplayPatternsDemo() {
			InitializeComponent();
		}

        void comboBoxSeriesLabels_EditValueChanged(object sender, EventArgs e) {
            if (Series != null)
                Series.Label.TextPattern = cbSeriesLabels.Text;
        }
        void cbLegendTextPattern_EditValueChanged(object sender, EventArgs e) {
            if (Series != null)
                Series.LegendTextPattern = cbLegendTextPattern.Text;
        }
        void cbAxisXLabelsPattern_EditValueChanged(object sender, EventArgs e) {
            if (AxisX != null)
                AxisX.Label.TextPattern = cbAxisXLabelsPattern.Text;
        }
        void cbAxisYLabelsPattern_EditValueChanged(object sender, EventArgs e) {
            if (AxisY != null)
                AxisY.Label.TextPattern = cbAxisYLabelsPattern.Text;
        }
        void UpdatePatternControls() {
            if (Series != null) {
                cbSeriesLabels.Text = Series.Label.TextPattern;
                cbLegendTextPattern.Text = Series.LegendTextPattern;
            }
            if (AxisX != null)
                cbAxisXLabelsPattern.Text = AxisX.Label.TextPattern;
            if (AxisY != null)
                cbAxisYLabelsPattern.Text = AxisY.Label.TextPattern;
        }

        protected override void InitControls() {
            base.InitControls();
            chart.DataSource = dS21.Countries;
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
        }
        protected override void SetAppearanceName(string appearanceName) {
            base.SetAppearanceName(appearanceName);
            if (chart.Series.Count == 0)
                return;
            if (appearanceName == "Dark" || appearanceName == "Dark Flat")
                chart.Series[0].Label.TextColor = Color.Black;
            else
                chart.Series[0].Label.TextColor = Color.Empty;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            UpdatePatternControls();
        }
	}
}
