using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class GroupInterval : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public GroupInterval() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\GroupInterval.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.GroupInterval.xml";

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		private void GroupInterval_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			InitComboBoxes();
			ceProductInterval.Checked = true;
			pivotGridControl1.HeaderImages = HeadersImageList;
			fieldExtendedPrice.ImageIndex = 3;
		}

		void InitComboBoxes() {
			Array arr = Enum.GetValues(typeof(PivotGroupInterval));
			foreach(PivotGroupInterval interval in arr) 
				if(interval.ToString().IndexOf("Date") == 0)
					icbGroupInterval.Properties.Items.Add(new ImageComboBoxItem(interval.ToString(), interval, -1));
			icbGroupInterval.SelectedIndex = icbGroupInterval.Properties.Items.Count - 1;
		}
        //<icbGroupInterval>
		private void icbGroupInterval_SelectedIndexChanged(object sender, System.EventArgs e) {
            fieldOrderDate.FilterValues.Clear();
			fieldOrderDate.GroupInterval = (PivotGroupInterval)icbGroupInterval.EditValue;
			fieldOrderDate.Caption = string.Format("Order Date ({0})", fieldOrderDate.GroupInterval.ToString().Replace("Date", ""));
		}
        //</icbGroupInterval>
        //<ceProductInterval>
		private void ceProductInterval_CheckedChanged(object sender, System.EventArgs e) {
			fieldProductAlphabetical.Visible = ceProductInterval.Checked;
		}
        //</ceProductInterval>

		private void pivotGridControl1_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e) {
			if(e.Field == fieldOrderDate && e.Field.GroupInterval == PivotGroupInterval.DateQuarter) {
				e.DisplayText = string.Format("Qtr {0}", e.Value);
				if(e.ValueType == PivotGridValueType.Total) e.DisplayText += " Total";
			}
		}

	}
}

