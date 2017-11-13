using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for AutoFilterRow.
	/// </summary>
	public partial class AutoFilterRow : TutorialControl {
		public AutoFilterRow() {
			// This call is required by the Windows.Forms Form Designer.
			CreateWaitDialog();
			InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\AutoFilterRow.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.AutoFilterRow.xml";
			// TODO: Add any initialization after the InitForm call

		}

		private void AutoFilterRow_Load(object sender, System.EventArgs e) {
			InitIssueListData(dsIssueList1);
            InitCheckEditors();
			gridView1.FocusedRowHandle = GridControl.AutoFilterRowHandle;
		}

        bool initEditors = false;
        void InitCheckEditors() {
            initEditors = true;
            ceAutoFilterRow.Checked = gridView1.OptionsView.ShowAutoFilterRow;
            ceAutoFilterRowMenuItem.Checked = gridView1.OptionsMenu.ShowAutoFilterRowItem;
            initEditors = false;
        }

        protected override void InitXMLData(DataSet ds) {
            this.gridControl1.DataSource = ds.Tables["Items"];
            this.repositoryItemLookUpEdit1.DataSource = ds.Tables["Projects"];
            this.repositoryItemLookUpEdit2.DataSource = ds.Tables["Users"];
        }
        //<ceAutoFilterRow>
		private void ceAutoFilterRow_CheckedChanged(object sender, System.EventArgs e) {
            if(initEditors) return;
			gridView1.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked;
		}
        //</ceAutoFilterRow>

        //<ceAutoFilterRowMenuItem>
        private void ceAutoFilterRowMenuItem_CheckedChanged(object sender, EventArgs e) {
            if(initEditors) return;
            gridView1.OptionsMenu.ShowAutoFilterRowItem = ceAutoFilterRowMenuItem.Checked;
        }
        //</ceAutoFilterRowMenuItem>
        private void gridView1_GridMenuItemClick(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs e) {
            BeginInvoke(new MethodInvoker(InitCheckEditors));
        }
	}
}
