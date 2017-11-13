using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.PivotGrid;
using DevExpress.Utils.Menu;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class RunTimeChangeSummaryType : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public RunTimeChangeSummaryType() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\RunTimeChangeSummaryType.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.RunTimeChangeSummaryType.xml";

			// TODO: Add any initialization after the InitializeComponent call
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			CreateDataFields();
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }


        //<checkEdit1>
        //<checkEdit2>
		private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
			CreateDataFields();
		}		

		private void checkEdit2_CheckedChanged(object sender, EventArgs e) {
			CreateDataFields();
		}

		private void CreateDataFields() {
			pivotGridControl1.BeginUpdate();

            for (int i = pivotGridControl1.Fields.Count -1; i >=0 ; i--) {
				if(pivotGridControl1.Fields[i].Area == PivotArea.DataArea) {
					pivotGridControl1.Fields.RemoveAt(i);
				}
			}
			if(checkEdit1.Checked) {
				for(int summaryType = 0; summaryType < 4; summaryType++) {
					PivotGridField field = pivotGridControl1.Fields.Add("Discount", PivotArea.DataArea);
					field.Options.ShowSummaryTypeName = true;
					field.Options.AllowRunTimeSummaryChange = false;
					field.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
					field.CellFormat.FormatString = "##0.##";
					field.SummaryType = (PivotSummaryType)summaryType;
				}
				pivotGridControl1.Fields["ProductName"].Width = 350;
			} else {
				PivotGridField field = pivotGridControl1.Fields.Add("Discount", PivotArea.DataArea);
				field.Options.ShowSummaryTypeName = true;
				field.Options.AllowRunTimeSummaryChange = true;
				field.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
				field.CellFormat.FormatString = "##0.##";

				pivotGridControl1.Fields["ProductName"].Width = 200;
			}

			pivotGridControl1.EndUpdate();
		}
        //</checkEdit2>
        //</checkEdit1>

        private void pivotGridControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.MenuType == PivotGridMenuType.HeaderSummaries)
                HideCustomMenuItem(e.Menu);
        }

        private void HideCustomMenuItem(DevExpress.Utils.Menu.DXPopupMenu menu) {
            for(int i = menu.Items.Count - 1; i >= 0; i--) {
                // Menu item tag list can be found in
                // http://devexpress.com/Help/?document=xtrapivotgrid/devexpressxtrapivotgridpivotgridcontrol_menuitemclicktopic.htm
                if(object.Equals(menu.Items[i].Tag, PivotSummaryType.Custom)) {
                    menu.Items.RemoveAt(i);
                    return;
                }
            }
        }
	}
}
