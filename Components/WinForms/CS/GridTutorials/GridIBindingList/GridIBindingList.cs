using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridIBindingList.
	/// </summary>
	public partial class GridIBindingList : TutorialControl {
		public GridIBindingList() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridIBindingList_Load(object sender, System.EventArgs e) {
			lbEvent.Text = "Ctrl+Del - Delete focused record.";
			InitData();
		}

      //<gridControl1>
		private void InitData() {
			GridIBindingListRecords collection = new GridIBindingListRecords();
			collection.Add(new GridIBindingListRecord(collection, "John Doe", 99.99, new DateTime(2003, 5, 30)));
			collection.Add(new GridIBindingListRecord(collection, "Alfred Newman", 50, new DateTime(2003, 7, 24)));

			gridControl1.DataSource = collection;
		}

		private void gridControl1_ProcessGridKey(object sender, System.Windows.Forms.KeyEventArgs e) {
			if(e.KeyCode == Keys.Delete && e.Control) {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
			}
		}
      //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
