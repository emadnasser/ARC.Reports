
namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class RunningTotal : TutorialControl {
		public RunningTotal() {
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\RunningTotal.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.RunningTotal.xml";

			pivotGridControl.DataSource = GetNWindData("CustomerReports");
			ceShowRunningTotals.Checked = true;
            ceAllowCrossGroupRunningTotals.Checked = true;
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = false;
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }
        //<ceShowRunningTotals>
		void ceShowRunningTotals_CheckedChanged(object sender, System.EventArgs e) {
			fieldOrderQuarter.RunningTotal = ceShowRunningTotals.Checked;
            ceAllowCrossGroupRunningTotals.Enabled = ceShowRunningTotals.Checked;
		}
        //</ceShowRunningTotals>

        //<ceAllowCrossGroupRunningTotals>
        void ceAllowCrossGroupRunningTotals_CheckedChanged(object sender, System.EventArgs e) {
            pivotGridControl.OptionsData.AllowCrossGroupVariation = ceAllowCrossGroupRunningTotals.Checked;
        }
        //</ceAllowCrossGroupRunningTotals>
	}
}
