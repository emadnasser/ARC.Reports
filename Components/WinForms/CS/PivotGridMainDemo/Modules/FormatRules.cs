using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class FormatRules : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public FormatRules() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\FormatRules.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.FormatRules.xml";
			// TODO: Add any initialization after the InitializeComponent call
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		private void StyleConditions_Load(object sender, System.EventArgs e) {
            pivotGridControl1.BeginUpdate();
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			fieldYear.FilterValues.FilterType = PivotFilterType.Included;
			fieldYear.FilterValues.Add(2015);
            pivotGridControl1.OptionsCustomization.AllowFilterBySummary = false;
            pivotGridControl1.EndUpdate();
		}

        private void pivotGridControl1_Click(object sender, EventArgs e) {

        }
	}
}

