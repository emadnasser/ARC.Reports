using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridUnboundMasterView.
	/// </summary>
	public partial class GridUnboundMasterView : TutorialControl {
		public GridUnboundMasterView() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridUnboundMasterView_Load(object sender, System.EventArgs e) {
			InitData(xtraTabControl1.SelectedTabPage.Tag.ToString());
			gridControl1.MainView.PopulateColumns();
			ShowMasterDetailRows();
		}
      //<gridControl1>
		private void InitData(string collectionName) {
			switch(collectionName) {
				case "IRelationList":
					gridControl1.DataSource = new IRelationListRecords();
					break;
				case "NestedCollections":
					gridControl1.DataSource = new NestedRecords();
					break;
			}
		}
      //</gridControl1>
		private void ShowMasterDetailRows() {
			for(int i = 0; i < gridView1.RowCount; i++)
			gridView1.SetMasterRowExpanded(i, true);
		}

		private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
			gridControl1.Parent = e.Page;
			InitData(e.Page.Tag.ToString());
			ShowMasterDetailRows();
		}
	}
}
