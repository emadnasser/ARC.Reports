using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraPivotGrid.Demos.Helpers;
using DevExpress.Utils.Menu;
using DevExpress.XtraPivotGrid.Localization;
using DevExpress.XtraEditors;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class OLAP : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		bool isConnecting;

        protected override bool HideCustFormWhenSwitchDemo {
            get { return false; }
        }
		public OLAP() {
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\OLAP.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.OLAP.xml";
		}

        private void OLAP_Load(object sender, System.EventArgs e) {
            pivotGridControl.FieldsCustomization();
			isConnecting = true;
            bool success = OLAPConfigurator.CreateSampleOLAPConfiguration(pivotGridControl);
			isConnecting = false;
            panelError.Visible = !success;
            separator1.Visible = !success;
            buttonNewConnection.Enabled = success;
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }
		void buttonNewConnection_Click(object sender, EventArgs e) {
			using(OLAPConnectionDesigner connectionDesigner = new OLAPConnectionDesigner()) {
				if(connectionDesigner.ShowDialog() == DialogResult.OK) {
                    pivotGridControl.Fields.Clear();
                    //<buttonNewConnection>
					pivotGridControl.OLAPConnectionString = connectionDesigner.ConnectionString;
                    //</buttonNewConnection>
					OLAPConfigurator.RetrieveFields(pivotGridControl);
				}
			}
		}

		private void pivotGridControl_FieldValueNotExpanded(object sender, PivotFieldValueEventArgs e) {
			XtraMessageBox.Show("Cannot show details for this item: it has no child items.", "OLAP Browser", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void pivotGridControl_ShowingCustomizationForm(object sender, CustomizationFormShowingEventArgs e) {
			e.ParentControl = splitPivotContainer.Panel1;
			e.CustomizationForm.Dock = DockStyle.Fill;
		}

        private void pivotGridControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.MenuType == PivotGridMenuType.Header || e.MenuType == PivotGridMenuType.HeaderArea) {
                foreach(DXMenuItem item in e.Menu.Items) {
                    if(item.Caption == PivotGridLocalizer.GetString(PivotGridStringId.PopupMenuHideFieldList)) {
                        e.Menu.Items.Remove(item);
                        break;
                    }
                }
            }
        }

		void pivotGridControl_QueryException(object sender, PivotQueryExceptionEventArgs e) {
			if(!isConnecting)
				e.Handled = true;
		}
	}
}

