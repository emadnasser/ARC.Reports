using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridAlphaBlending.
	/// </summary>
	public partial class GridAlphaBlending : TutorialControl {
		public GridAlphaBlending() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridAlphaBlending_Load(object sender, System.EventArgs e) {
			InitHelper.InitAdvBandedView(gridControl1);
			checkEdit1.Checked = xtraGridBlending1.Enabled;
		}
		
		//<checkEdit1>
		private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
			CheckEdit checkEdit = sender as CheckEdit;
			xtraGridBlending1.Enabled = checkEdit.Checked;
			simpleButton1.Enabled = xtraGridBlending1.Enabled;
		}
		//</checkEdit1>

      //<simpleButton1>
		private void simpleButton1_Click(object sender, System.EventArgs e) {
			xtraGridBlending1.ShowDialog();
		}
      //</simpleButton1>
	}
}
