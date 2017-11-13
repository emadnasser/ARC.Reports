using System;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
    public partial class EqualSizeForPiesDoughnutsDemo : ChartDemoBase2D {

        public override ChartControl ChartControl { get { return chart; } }

        public EqualSizeForPiesDoughnutsDemo() {
            InitializeComponent();
            checkEditShowLabels.Visible = false;
        }

        void cheEqualPieSize_CheckedChanged(object sender, EventArgs e) {
            if (chart == null)
                return;
            SimpleDiagram simpleDiagram = chart.Diagram as SimpleDiagram;
            if (simpleDiagram == null)
                return;
            if (cheEqualPieSize.Checked == true)
                simpleDiagram.EqualPieSize = true;
            else
                simpleDiagram.EqualPieSize = false;
        }
        void tbcMinAllowedSizePercentage_EditValueChanged(object sender, EventArgs e) {
            ((PieSeriesView)chart.Series["Condiments"].View).MinAllowedSizePercentage = tbcMinAllowedSizePercentage.Value;
        }
        void seRestoreDefaultLayout_Click(object sender, EventArgs e) {
            tbcMinAllowedSizePercentage.Value = 0;
            cheEqualPieSize.Checked = false;
            cbeView.SelectedIndex = 0;
        }
        void cbeView_SelectedIndexChanged(object sender, EventArgs e) {
            if ((string)cbeView.EditValue == "Pie")
                foreach (Series series in chart.Series)
                    series.ChangeView(ViewType.Pie);
            else
                foreach (Series series in chart.Series)
                    series.ChangeView(ViewType.Doughnut);
        }
        void tbcMinAllowedSizePercentage_BeforeShowValueToolTip(object sender, XtraEditors.TrackBarValueToolTipEventArgs e) {
            e.ShowArgs.ToolTip = string.Format("{0}%", tbcMinAllowedSizePercentage.Value);
        }
    }
}
